using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
     /// <summary>
    /// Clase: Familia de productos
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 19/10/2010
    /// Description: Establece los metodos para operar informacion relacionada con las familias de productos Lucky
    /// Requerimiento No:
    /// </summary>
    /// 

    public class BProduct_Family
    {
        public BProduct_Family()
        {
            //Se define el constructor por defecto
        }
        
        /// <summary>
        /// registra iformación maestro familia de productos.
        /// 19/10/2010 Magaly Jiménez
        ///  modificiación: se agrega camos de categoria y subcategoria
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
        /// <returns></returns>
        public EProduct_Family RegistrarProductosFamily(string sid_ProductFamily, string sid_ProductCategory, long lid_Subcategory, int iid_Brand, int iid_SubBrand, string sname_Family, string sfamily_Descripcion, decimal dfamily_Peso, bool bfamily_status, string sfamily_CreateBy, DateTime tfamily_DateBy, string sfamily_ModyBy, DateTime tfamily_DateModiBy)
        {
            DProduct_Family odrProductFamily = new DProduct_Family();
            EProduct_Family oeProductFamily = odrProductFamily.RegistrarProducFamily(sid_ProductFamily, sid_ProductCategory, lid_Subcategory, iid_Brand, iid_SubBrand, sname_Family, sfamily_Descripcion, dfamily_Peso, bfamily_status, sfamily_CreateBy, tfamily_DateBy, sfamily_ModyBy, tfamily_DateModiBy);
            odrProductFamily = null;
            return oeProductFamily;
        }

        /// <summary>
        ///  Inserta familias en BD intermedia
        /// 29/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductFamily"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sname_Family"></param>
        /// <param name="bfamily_status"></param>
        /// <returns></returns>
        public EProduct_Family RegistrarProductosFamilyTMP(string sid_ProductFamily, int iid_Brand, int iid_SubBrand, string sname_Family, bool bfamily_status, string sid_category)
        {
            DProduct_Family odrProductFamilytmp = new DProduct_Family();
            EProduct_Family oeProductFamilytmp = odrProductFamilytmp.RegistrarProducFamilyTMP(sid_ProductFamily, iid_Brand, iid_SubBrand, sname_Family, bfamily_status, sid_category);
            odrProductFamilytmp = null;
            return oeProductFamilytmp;
        }
        /// <summary>
        /// consulta Familia
        /// 19/10/2010 Magaly jiménez
        ///  modificiación: se agrega camos de categoria y subcategoria
        /// 16/11/2010 Magaly Jiménez
        ///  </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sname_Family"></param>
        /// <returns></returns>
        public DataTable ConsultarFamily(int iCompany_id, int iid_Brand, string sid_ProductCategory,  string sname_Family)
        {
            DProduct_Family odcPFamily = new DProduct_Family();
            EProduct_Family oecPFamily = new EProduct_Family();
            DataTable dtFamily = odcPFamily.ConsultarFamiliy(iCompany_id, iid_Brand,  sid_ProductCategory, sname_Family);
            odcPFamily = null;
            return dtFamily;
        }

        /// <summary>
        /// Método para obtener datos de la familia para registrar en PLA_Family_Planning
        /// Ing. Mauricio Ortiz
        /// 29/03/2011
        /// </summary>
        /// <param name="sname_Family"></param>
        /// <returns></returns>
        public DataTable ObtenerDatosFamilia(string sname_Family)
        {
            DProduct_Family odProdFamily = new DProduct_Family();
            DataTable dt = odProdFamily.ObtenerDatosFamilia(sname_Family);
            odProdFamily = null;
            return dt;
        }
        /// <summary>
        /// permite Actulizar información de maestro de familia de producto.
        /// 19/10/2010 Magaly Jimenez
        ///  modificiación: se agrega camos de categoria y subcategoria
        /// 16/11/2010 Magaly Jiménez
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
            DProduct_Family odAPFamily = new DProduct_Family();
            EProduct_Family oeaAPFamily = odAPFamily.Actualizar_PFamily(sid_ProductFamily, sid_ProductCategory, lid_Subcategory, iid_Brand, iid_SubBrand, sname_Family, sfamily_Descripcion, dfamily_Peso, bfamily_status,
                 sfamily_ModyBy, tfamily_DateModiBy);
           
           odAPFamily = null;
           return oeaAPFamily;
        }
        /// <summary>
        ///  Actualiza familias en BD intermedia
        /// 29/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductFamily"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="lid_Subcategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sname_Family"></param>
        /// <param name="bfamily_status"></param>
        /// <returns></returns>
        public EProduct_Family Actualizar_PFamilyTMP(string sid_ProductFamily, int iid_Brand, int iid_SubBrand, string sname_Family, bool bfamily_status)
        {
            DProduct_Family odAPFamilytmp = new DProduct_Family();
            EProduct_Family oeaAPFamilytmp = odAPFamilytmp.Actualizar_PFamilyTMP(sid_ProductFamily, iid_Brand, iid_SubBrand, sname_Family, bfamily_status);

            odAPFamilytmp = null;
            return oeaAPFamilytmp;
        }
    }
}
