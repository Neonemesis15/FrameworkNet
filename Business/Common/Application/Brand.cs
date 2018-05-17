using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Brand
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 17/07/2009
    /// ModiBy:Magaly Jiménez , se adiciona campo Company_id
    /// Mdoydateby: 17/08/2010
    /// Description: Establece los metodos para operar informacion relacionada con Marcas de producto Lucky
    /// Requerimiento No:
    /// </summary>
    public class Brand
    {
        public Brand()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        /// Metodo que permite registrar Marca de producto
        /// Modificación: se agrega campo company_id de tipo int.
        /// 17/08/2010 Magaly Jiménez
        /// 30/11/2010 se adiciona sid_ProductCategory y lid_Subcategory . Ing. Mauricio Ortiz
        /// </summary>

        /// <param name="lid_Subcategory"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="bBrand_Status"></param>
        /// <param name="sBrand_CreateBy"></param>
        /// <param name="tBrand_DateBy"></param>
        /// <param name="sBrand_ModiBy"></param>
        /// <param name="tBrand_DateModiBy"></param>
        /// <returns>oeBrand</returns>
        public EBrand RegistrarBrand(int iCompany_id, string sid_ProductCategory,  string sName_Brand, bool bBrand_Status, string sBrand_CreateBy, DateTime tBrand_DateBy, string sBrand_ModiBy, DateTime tBrand_DateModiBy)
        {
            DBrand odrBrand = new DBrand();
            EBrand oeBrand = odrBrand.RegistrarBrandPK(iCompany_id, sid_ProductCategory, sName_Brand, bBrand_Status, sBrand_CreateBy, tBrand_DateBy, sBrand_ModiBy, tBrand_DateModiBy);
            odrBrand = null;
            return oeBrand;
        }
        /// <summary>
        /// inserta marca en BD intermedia
        /// 28/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="bBrand_Status"></param>
        /// <param name="sBrand_CreateBy"></param>
        /// <param name="tBrand_DateBy"></param>
        /// <param name="sBrand_ModiBy"></param>
        /// <param name="tBrand_DateModiBy"></param>
        /// <returns></returns>
        public EBrand RegistrarBrandtmp(int iCompany_id, int iidBrand, string sName_Brand, bool bBrand_Status)
        {
            DBrand odrBrandtmp = new DBrand();
            EBrand oeBrandtmp = odrBrandtmp.RegistrarBrandPKTMP(iCompany_id, iidBrand, sName_Brand, bBrand_Status);
            odrBrandtmp = null;
            return oeBrandtmp;
        }
        /// <summary>
        /// inserta categoria y marca en la bd intemerdia en la tabla TBL_MARCA_CATEGORIA
        /// 16/02/2011  Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sid_Brand"></param>
        /// <returns></returns>
        public EBrand RegistrarBrandCategorytmp(string sid_ProductCategory, string sid_Brand)
        {
            DBrand odrBrandcategorytmp = new DBrand();
            EBrand oeBrandcategorytmp = odrBrandcategorytmp.RegistrarBrandCategoryPKTMP(sid_ProductCategory,  sid_Brand);
            odrBrandcategorytmp = null;
            return oeBrandcategorytmp;
        }

        
        /// <summary>
        /// Metodo de Consulta de Marcas de producto
        //  Modificación : 30/11/2010 se adiciona paramentros a la consulta 
        //                sid_ProductCategory, Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_Brand"></param>
        /// <param name="sName_Brand"></param>
        /// <returns></returns>
        public DataTable SearchBrand(int iid_Brand, string sid_ProductCategory, string sName_Brand)
        {
            DBrand odsBrand = new DBrand();
            EBrand oeBrand = new EBrand();
            DataTable dtBrand = odsBrand.ObtenerBrand(iid_Brand, sid_ProductCategory, sName_Brand);
            odsBrand = null;
            return dtBrand;
        }

        /// <summary>
        /// retorna id de compañia y categoria para carga masiva de marca.
        /// 02/03/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sCompany_Name"></param>
        /// <param name="sProduct_Category"></param>
        /// <returns></returns>
        public DataSet Searchidcompanycategory(string sCompany_Name, string sProduct_Category)
        {
            DBrand odsBrandid = new DBrand();
            EBrand oeBrandid = new EBrand();
            DataSet dsBrandid = odsBrandid.ObteneridCompanyCategory(sCompany_Name, sProduct_Category);
            odsBrandid = null;
            return dsBrandid;
        }
        /// <summary>
        ///  se realiza consulta para cuando venga del modulo planning solo muestre la información por el cliente del usuario
        /// 22/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iid_Brand"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="iCompany_id"></param>
        /// <returns></returns>
        public DataTable SearchBrandPlanning(int iid_Brand, string sid_ProductCategory, string sName_Brand, int iCompany_id)
        {
            DBrand odsBrandPla = new DBrand();
            EBrand oeBrand = new EBrand();
            DataTable dtBrandpla = odsBrandPla.ObtenerBrandPlanning(iid_Brand, sid_ProductCategory, sName_Brand, iCompany_id);
            odsBrandPla = null;
            return dtBrandpla;
        }

        /// <summary>
        /// Método para obtener datos de la marca para registrar en PLA_Brand_Planning
        /// Ing. Mauricio Ortiz
        /// 29/03/2011
        /// /// modificacion : se agrega parametro sProduct_Category Ing. Mauricio Ortiz 29/04/2011
        /// </summary>
        /// <param name="sProduct_Category"></param>
        /// <param name="sName_Brand"></param>
        /// <returns></returns>
        public DataTable ObtenerDatosMarca(string sProduct_Category ,string sName_Brand)
        {
            DBrand odBrand = new DBrand();
            DataTable dt = odBrand.ObtenerDatosMarca(sProduct_Category,sName_Brand);
            odBrand = null;
            return dt;
        }
     

        //----Metodo que permite Actualizar Marca de producto 
        /// <summary>
        ///  Modificación: se agrega campo company_id de tipo int.
        /// 17/08/2010 Magaly Jiménez
        /// 30/11/2010 se adiciona sid_ProductCategory y lid_Subcategory . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_Brand"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="lid_Subcategory"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="bBrand_Status"></param>
        /// <param name="sBrand_ModiBy"></param>
        /// <param name="tBrand_DateModiBy"></param>
        /// <returns>oeaBrand</returns>
        public EBrand Actualizar_Brand(int iid_Brand, int iCompany_id, string sid_ProductCategory,  string sName_Brand, bool bBrand_Status, string sBrand_ModiBy, DateTime tBrand_DateModiBy)
        {
            DBrand odaBrand = new DBrand();
            EBrand oeaBrand = odaBrand.Actualizar_Brand(iid_Brand, iCompany_id, sid_ProductCategory, sName_Brand, bBrand_Status, sBrand_ModiBy, tBrand_DateModiBy);
            odaBrand = null;
            return oeaBrand;
        }
        /// <summary>
        /// Actuliza información  en la BD Intermedia
        /// 28/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iid_Brand"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="bBrand_Status"></param>
        /// <returns></returns>
        public EBrand Actualizar_BrandTMP(int iid_Brand, string sName_Brand, bool bBrand_Status, string scategory)
        {
            DBrand odaBrandtmp = new DBrand();
            EBrand oeaBrandtmp = odaBrandtmp.Actualizar_BrandTMP(iid_Brand, sName_Brand, bBrand_Status, scategory);
            odaBrandtmp = null;
            return oeaBrandtmp;
        }
    }
}
