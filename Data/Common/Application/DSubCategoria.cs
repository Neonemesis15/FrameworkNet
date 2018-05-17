using System;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para SubCategoria
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate: 19-08-2010
    /// Requerimiento:

     public class DSubCategoria
    {
       private Conexion oConn;
        public DSubCategoria()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

         /// <summary>
         /// Creado: Metodo para Registrar SubCategorias de Producto
         /// </summary>
         /// <param name="lid_Subcategory"></param>
         /// <param name="sid_ProductCategory"></param>
         /// <param name="sName_Subcategory"></param>
         /// <param name="bSubcategory_Status"></param>
         /// <param name="sSubcategory_CreateBy"></param>
         /// <param name="tSubcategory_DateBy"></param>
         /// <param name="sSubcategory_ModiBy"></param>
         /// <param name="tSubcategory_DateModiBy"></param>
        /// <returns>oerSubCategoria</returns>

        public ESubCategoria RegistrarSubCategoria( string sid_ProductCategory, string sName_Subcategory, bool bSubcategory_Status,
           string sSubcategory_CreateBy, DateTime tSubcategory_DateBy, string sSubcategory_ModiBy, DateTime tSubcategory_DateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_SUBCATEGORIA",  sid_ProductCategory,  sName_Subcategory,  bSubcategory_Status,
            sSubcategory_CreateBy,  tSubcategory_DateBy,  sSubcategory_ModiBy,  tSubcategory_DateModiBy);
            oConn = null;
            ESubCategoria oerSubCategoria = new ESubCategoria();
            oerSubCategoria.id_ProductCategory = sid_ProductCategory;
            oerSubCategoria.Name_Subcategory = sName_Subcategory;
            oerSubCategoria.Subcategory_Status = bSubcategory_Status;
            oerSubCategoria.Subcategory_CreateBy=sSubcategory_CreateBy;
            oerSubCategoria.Subcategory_DateBy = tSubcategory_DateBy;
            oerSubCategoria.Subcategory_ModiBy = sSubcategory_ModiBy;
            oerSubCategoria.Subcategory_DateModiBy = tSubcategory_DateModiBy;
            return oerSubCategoria;         
        }

         /// <summary>
        ///  Creado: Metodo para Consultar SubCategorias de Producto
         /// </summary>
         /// <param name="sid_ProductCategory"></param>
         /// <param name="sName_Subcategory"></param>
        /// <returns>dt</returns>
        public DataTable ConsultarSubCategoria(string sid_ProductCategory, string sName_Subcategory)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTASUBCATEGORIA", sid_ProductCategory, sName_Subcategory);
            ESubCategoria oeSubCategoria = new ESubCategoria();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeSubCategoria.id_Subcategory = Convert.ToInt64(dt.Rows[i]["id_Subcategory"].ToString().Trim());
                        oeSubCategoria.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        oeSubCategoria.Name_Subcategory = dt.Rows[i]["Name_Subcategory"].ToString().Trim();
                        oeSubCategoria.Subcategory_Status = Convert.ToBoolean(dt.Rows[i]["Subcategory_Status"].ToString().Trim());
                        oeSubCategoria.Subcategory_CreateBy = dt.Rows[i]["Subcategory_CreateBy"].ToString().Trim();
                        oeSubCategoria.Subcategory_DateBy = Convert.ToDateTime(dt.Rows[i]["Subcategory_DateBy"].ToString().Trim());
                        oeSubCategoria.Subcategory_ModiBy = dt.Rows[i]["Subcategory_ModiBy"].ToString().Trim();
                        oeSubCategoria.Subcategory_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Subcategory_DateModiBy"].ToString().Trim());
                    }
                }
                oConn = null;
                return dt;
            }
            else
            {
                oConn = null;
                return null;
            }
        }

         /// <summary>
        /// Creado: Metodo para Actualizar SubCategorias de Producto
         /// </summary>
         /// <param name="lid_Subcategory"></param>
         /// <param name="sid_ProductCategory"></param>
         /// <param name="sName_Subcategory"></param>
         /// <param name="bSubcategory_Status"></param>
         /// <param name="sSubcategory_ModiBy"></param>
         /// <param name="tSubcategory_DateModiBy"></param>
        /// <returns>oeaSubCategoria</returns>
        public ESubCategoria Actualizar_SubCategoria(long lid_Subcategory, string sid_ProductCategory, string sName_Subcategory, bool bSubcategory_Status,
           string sSubcategory_ModiBy, DateTime tSubcategory_DateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARSUBCATEGORIA", lid_Subcategory, sid_ProductCategory, sName_Subcategory, bSubcategory_Status,
            sSubcategory_ModiBy, tSubcategory_DateModiBy);
            oConn = null;
            ESubCategoria oeaSubCategoria = new ESubCategoria();
            oeaSubCategoria.id_ProductCategory = sid_ProductCategory;
            oeaSubCategoria.Name_Subcategory = sName_Subcategory;
            oeaSubCategoria.Subcategory_Status = bSubcategory_Status;
            oeaSubCategoria.Subcategory_ModiBy = sSubcategory_ModiBy;
            oeaSubCategoria.Subcategory_DateModiBy = tSubcategory_DateModiBy;
           return oeaSubCategoria;
        }
    }
}
