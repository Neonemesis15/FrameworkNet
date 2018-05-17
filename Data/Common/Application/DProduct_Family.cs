using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para Familia de Producto
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate: 19-10-2010
    /// Requerimiento:
    public class DProduct_Family
    {
        private Conexion oConn;
        public DProduct_Family()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// metodo de insercioón de maestro familia de producto.
        /// 19/10/2010 Magaly Jiménez
        /// modificiación: se agrega camos de categoria y subcategoria
        /// 16/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductFamily"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sname_Family"></param>
        /// <param name="bfamily_status"></param>
        /// <param name="sfamily_CreateBy"></param>
        /// <param name="tfamily_DateBy"></param>
        /// <param name="sfamily_ModyBy"></param>
        /// <param name="tfamily_DateModiBy"></param>
        /// <returns>oerProducFamily</returns>
        public EProduct_Family RegistrarProducFamily(string sid_ProductFamily, string sid_ProductCategory, long lid_Subcategory, int iid_Brand, int iid_SubBrand, string sname_Family, string sfamily_Descripcion, decimal dfamily_Peso, bool bfamily_status, string sfamily_CreateBy, DateTime tfamily_DateBy, string sfamily_ModyBy, DateTime tfamily_DateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERFAMILY", sid_ProductFamily, sid_ProductCategory, lid_Subcategory, iid_Brand, iid_SubBrand, sname_Family, sfamily_Descripcion, dfamily_Peso, bfamily_status, sfamily_CreateBy, tfamily_DateBy, sfamily_ModyBy, tfamily_DateModiBy);

            EProduct_Family oerProducFamily = new EProduct_Family();

            oerProducFamily.id_ProductFamily=  sid_ProductFamily;
            oerProducFamily.id_ProductCategory = sid_ProductCategory;
            oerProducFamily.id_Subcategory = lid_Subcategory;
            oerProducFamily.id_Brand = iid_Brand;
            oerProducFamily.id_SubBrand = iid_SubBrand;    
            oerProducFamily.name_Family = sname_Family;
            oerProducFamily.family_Descripcion = sfamily_Descripcion;
            oerProducFamily.family_Peso = dfamily_Peso;
            oerProducFamily.family_status = bfamily_status;
            oerProducFamily.family_CreateBy = sfamily_CreateBy;
            oerProducFamily.family_DateBy = tfamily_DateBy;
            oerProducFamily.family_ModyBy = sfamily_ModyBy;
            oerProducFamily.family_DateModiBy = tfamily_DateModiBy;
            return oerProducFamily;

        }
        /// <summary>
        /// Inserta familias en BD intermedia
        /// 29/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductFamily"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sname_Family"></param>
        /// <param name="bfamily_status"></param>
        /// <returns></returns>
        public EProduct_Family RegistrarProducFamilyTMP(string sid_ProductFamily,  int iid_Brand, int iid_SubBrand, string sname_Family, bool bfamily_status, string sid_category)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERFAMILYTMP", sid_ProductFamily,  iid_Brand, iid_SubBrand, sname_Family, bfamily_status, sid_category);

            EProduct_Family oerProducFamily = new EProduct_Family();

            oerProducFamily.id_ProductFamily = sid_ProductFamily;
            oerProducFamily.id_Brand = iid_Brand;
            oerProducFamily.id_SubBrand = iid_SubBrand;
            oerProducFamily.name_Family = sname_Family;
            oerProducFamily.family_status = bfamily_status;
            oerProducFamily.id_ProductCategory = sid_category;
            return oerProducFamily;

        }

        /// <summary>
        /// consulta información del maestro familia de producto
        /// 19/10/2010 Magaly Jiménez
        /// modificiación: se agrega camos de categoria y subcategoria se agrega como parametro de consulta la categoria
        /// 16/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sname_Family"></param>
        /// <returns></returns>
        public DataTable ConsultarFamiliy(int iCompany_id, int iid_Brand, string sid_ProductCategory, string sname_Family)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTAFAMILY", iCompany_id, iid_Brand, sid_ProductCategory,  sname_Family);
            EProduct_Family oProFamily = new EProduct_Family();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oProFamily.id_ProductFamily = dt.Rows[i]["id_ProductFamily"].ToString().Trim();
                        oProFamily.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        oProFamily.id_Subcategory = Convert.ToInt64(dt.Rows[i]["id_Subcategory"].ToString().Trim());
                        oProFamily.id_Brand = Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                        oProFamily.id_SubBrand=Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                        oProFamily.name_Family = dt.Rows[i]["name_Family"].ToString().Trim();
                        oProFamily.family_Descripcion = dt.Rows[i]["family_Descripcion"].ToString().Trim();
                        oProFamily.family_Peso = Convert.ToDecimal(dt.Rows[i]["family_Peso"].ToString().Trim());
                        oProFamily.family_status = Convert.ToBoolean(dt.Rows[i]["family_status"].ToString().Trim());
                        //oProFamily.family_CreateBy = dt.Rows[i]["family_CreateBy"].ToString().Trim();
                        //oProFamily.family_DateBy = Convert.ToDateTime(dt.Rows[i]["family_DateBy"].ToString().Trim());
                        //oProFamily.family_ModyBy = dt.Rows[i]["family_ModyBy"].ToString().Trim();
                        //oProFamily.family_DateModiBy = Convert.ToDateTime(dt.Rows[i]["family_DateModiBy"].ToString().Trim());

     
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// permite actualizar información en maestro de familia de producto
        /// 19/10/2010 Magaly Jiménez
        /// modificiación: se agrega camos de categoria y subcategoria
        /// 16/11/2010 Magaly Jiméne
        /// </summary>
        /// <param name="sid_ProductFamily"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sname_Family"></param>
        /// <param name="bfamily_status"></param>
        /// <param name="sfamily_ModyBy"></param>
        /// <param name="tfamily_DateModiBy"></param>
        /// <returns></returns>
        public EProduct_Family Actualizar_PFamily(string sid_ProductFamily, string sid_ProductCategory, long lid_Subcategory, int iid_Brand, int iid_SubBrand, string sname_Family, string sfamily_Descripcion, decimal dfamily_Peso, bool bfamily_status,
                string sfamily_ModyBy, DateTime tfamily_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARPFAMILY", sid_ProductFamily, sid_ProductCategory, lid_Subcategory, iid_Brand, iid_SubBrand, sname_Family,  sfamily_Descripcion, dfamily_Peso, bfamily_status,
                 sfamily_ModyBy,  tfamily_DateModiBy);
            EProduct_Family oeaPFamily = new EProduct_Family();

            oeaPFamily.id_ProductCategory = sid_ProductCategory;
            oeaPFamily.id_Subcategory = lid_Subcategory;
            oeaPFamily.id_Brand = iid_Brand;
            oeaPFamily.id_SubBrand = iid_SubBrand;          
            oeaPFamily.name_Family = sname_Family;
            oeaPFamily.family_Descripcion = sfamily_Descripcion;
            oeaPFamily.family_Peso = dfamily_Peso;
            oeaPFamily.family_status = bfamily_status;
            oeaPFamily.family_ModyBy = sfamily_ModyBy;
            oeaPFamily.family_DateModiBy = tfamily_DateModiBy;

            return oeaPFamily;
        }
        /// <summary>
        /// Actualiza familias en BD intermedia
        /// 29/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductFamily"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sname_Family"></param>
        /// <param name="bfamily_status"></param>
        /// <returns></returns>
        public EProduct_Family Actualizar_PFamilyTMP(string sid_ProductFamily,  int iid_Brand, int iid_SubBrand, string sname_Family, bool bfamily_status)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARPFAMILYTMP", sid_ProductFamily, iid_Brand, iid_SubBrand, sname_Family, bfamily_status);
            EProduct_Family oeaPFamily = new EProduct_Family();


            oeaPFamily.id_Brand = iid_Brand;
            oeaPFamily.id_SubBrand = iid_SubBrand;
            oeaPFamily.name_Family = sname_Family;
            oeaPFamily.family_status = bfamily_status;

            return oeaPFamily;
        }


        /// <summary>
        /// Método para obtener datos de la familia para registrar en PLA_Family_Planning
        /// </summary>
        /// <param name="sname_Family"></param>
        /// <returns></returns>
        public DataTable ObtenerDatosFamilia(string sname_Family)
        {
            DataTable dtFamilia = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_OBTENERFAMILIASCLIENTE", sname_Family);
            return dtFamilia;
        }
   
    }
}
