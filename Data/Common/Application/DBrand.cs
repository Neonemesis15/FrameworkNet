using System;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para Brand
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate: 17-07-09
    /// ModiBy:Magaly Jiménez , se adiciona campo Company_id
    /// Mdoydateby: 17/08/2010
    /// Requerimiento:
    /// </summary>    
    public class DBrand
    {
        private Conexion oConn;
        public DBrand()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }
                
        /// <summary>
        /// Metodo para Registrar Marcas de Producto
        ///  Modificación: se agrega campo de Company_id como int.
        ///  17/08/2010 Magaly jimenez
        ///  30/11/2010 se adiciona sid_ProductCategory y lid_Subcategory . Ing. Mauricio Ortiz
        ///  01/12/2010 se quita lid_Subcategory . Ing. Magaly Jiménez
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
        /// <returns>dt</returns>
        public EBrand RegistrarBrandPK(int iCompany_id, string sid_ProductCategory,  string sName_Brand, bool bBrand_Status, string sBrand_CreateBy, DateTime tBrand_DateBy, string sBrand_ModiBy, DateTime tBrand_DateModiBy)
        {
            oConn = new Conexion(1);
            int idBrand = Convert.ToInt32(oConn.ejecutarEscalar("UP_WEB_REGISTER_BRAND", iCompany_id, sid_ProductCategory,  sName_Brand, bBrand_Status, sBrand_CreateBy, tBrand_DateBy, sBrand_ModiBy, tBrand_DateModiBy));
            oConn = null;
            EBrand oerbrand = new EBrand();
            oerbrand.id_Brand = idBrand;
            oerbrand.id_ProductCategory = sid_ProductCategory;
            oerbrand.Company_id = iCompany_id;
            oerbrand.Name_Brand = sName_Brand;
            oerbrand.Brand_Status = bBrand_Status;
            oerbrand.Brand_CreateBy = sBrand_CreateBy;
            oerbrand.Brand_DateBy = tBrand_DateBy;
            oerbrand.Brand_ModiBy = sBrand_ModiBy;
            oerbrand.Brand_DateModiBy = tBrand_DateModiBy;
            return oerbrand;
        }
        /// <summary>
        /// Inserta marca en BD intermedia
        /// 28/01/2011 Magaly Jiménez
        /// Modificación: 13/06/2011 - Angel Ortiz - Se  agrega captura de tipo de Cliente y se realiza conexion directa a DB intermedia.
        /// Modificación: 08/11/2011 - Carlos Marin - se hace un convert al campo status para el registro de la bd intermedia ya que acepta 1 ó 0
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="bBrand_Status"></param>
        /// <returns></returns>
        public EBrand RegistrarBrandPKTMP(int iCompany_id, int iidBrand, string sName_Brand, bool bBrand_Status)
        {
            oConn = new Conexion(1);
            int CompanyType = Convert.ToInt32(oConn.ejecutarEscalar("UP_WEBXPLORA_OBTENER_TIPO_CLIENTE", iCompany_id));
            oConn = null;
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_BRANDTMP", CompanyType, iidBrand, sName_Brand, Convert.ToInt16(bBrand_Status));
            oConn = null;
            EBrand oerbrandtmp = new EBrand();
            oerbrandtmp.Company_id = iCompany_id;
            return oerbrandtmp;
        }
        /// <summary>
        /// Inserta Categoria y marca en la bd intemerdia en la tabla TBL_MARCA_CATEGORIA
        /// 16/02/2011  Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sid_Brand"></param>
        /// <returns></returns>
        public EBrand RegistrarBrandCategoryPKTMP(string sid_ProductCategory, string sid_Brand)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_REGISTER_BRANDCATEGORYTMP", sid_ProductCategory, sid_Brand);
            oConn = null;
            EBrand oerbrandCtmp = new EBrand();
            oerbrandCtmp.id_ProductCategory = sid_ProductCategory;
            oerbrandCtmp.id_Brand = Convert.ToInt32( sid_Brand);
            return oerbrandCtmp;
        }        

        /// <summary>
        ///Nombre Metodo: SEARCHBRAND
        ///Descripción  :  Permite Consultar marcas productos
        ///Modificación : 30/11/2010 se adiciona paramentros a la consulta 
        ///                sid_ProductCategory, Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_Brand"></param>
        /// <param name="sName_Brand"></param>
        /// <returns></returns>
        public DataTable ObtenerBrand(int iid_Brand , string sid_ProductCategory,  string sName_Brand)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHBRAND", iid_Brand, sid_ProductCategory, sName_Brand);
            oConn = null;
            EBrand oeBrand = new EBrand();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeBrand.id_Brand = Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                        oeBrand.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        oeBrand.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeBrand.Name_Brand = dt.Rows[i]["Name_Brand"].ToString().Trim();
                        oeBrand.Brand_Status = Convert.ToBoolean(dt.Rows[i]["Brand_Status"].ToString().Trim());
                        oeBrand.Brand_CreateBy = dt.Rows[i]["Brand_CreateBy"].ToString().Trim();
                        oeBrand.Brand_DateBy = Convert.ToDateTime(dt.Rows[i]["Brand_DateBy"].ToString().Trim());
                        oeBrand.Brand_ModiBy = dt.Rows[i]["Brand_ModiBy"].ToString().Trim();
                        oeBrand.Brand_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Brand_DateModiBy"].ToString().Trim());
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
        /// retorna id de compañia y categoria para carga masiva de marca.
        /// 02/03/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sCompany_Name"></param>
        /// <param name="sProduct_Category"></param>
        /// <returns></returns>
        public DataSet ObteneridCompanyCategory(string sCompany_Name, string sProduct_Category)
        {
            oConn = new Conexion(1);
            DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_AD_CONSULTAIDCOMPANY_IDCATEGORIA", sCompany_Name, sProduct_Category);
            oConn = null;
            return ds;
        }
        /// <summary>
        /// se realiza consulta para cuando venga del modulo planning solo muestre la información por el cliente del usuario
        /// 22/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iid_Brand"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="iCompany_id"></param>
        /// <returns></returns>
        public DataTable ObtenerBrandPlanning(int iid_Brand, string sid_ProductCategory, string sName_Brand, int iCompany_id)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHBRANDPLANNING", iid_Brand, sid_ProductCategory, sName_Brand, iCompany_id);
            oConn = null;
            EBrand oeBrandPla = new EBrand();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeBrandPla.id_Brand = Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                        oeBrandPla.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        oeBrandPla.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeBrandPla.Name_Brand = dt.Rows[i]["Name_Brand"].ToString().Trim();
                        oeBrandPla.Brand_Status = Convert.ToBoolean(dt.Rows[i]["Brand_Status"].ToString().Trim());
                        oeBrandPla.Brand_CreateBy = dt.Rows[i]["Brand_CreateBy"].ToString().Trim();
                        oeBrandPla.Brand_DateBy = Convert.ToDateTime(dt.Rows[i]["Brand_DateBy"].ToString().Trim());
                        oeBrandPla.Brand_ModiBy = dt.Rows[i]["Brand_ModiBy"].ToString().Trim();
                        oeBrandPla.Brand_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Brand_DateModiBy"].ToString().Trim());
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
        ///Nombre Metodo: ACTUALIZAR_BRAND
        ///Función: Permite Actualizar marcas productos
        /// Modificiacón:se agrega campo de Company_id como int.
        ///  17/08/2010 Magaly jimenez
        ///  30/11/2010 se adiciona sid_ProductCategory y lid_Subcategory . Ing. Mauricio Ortiz
        ///  01/12/2010 se quita lid_Subcategory . Ing. Magaly Jiménez
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
        public EBrand Actualizar_Brand(int iid_Brand, int iCompany_id, string sid_ProductCategory, string sName_Brand, bool bBrand_Status, string sBrand_ModiBy, DateTime tBrand_DateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_BRAND", iid_Brand, iCompany_id, sid_ProductCategory ,  sName_Brand, bBrand_Status, sBrand_ModiBy, tBrand_DateModiBy);
            oConn = null;
            EBrand oeaBrand = new EBrand();            
            oeaBrand.Company_id = iCompany_id;
            oeaBrand.id_ProductCategory = sid_ProductCategory;
            oeaBrand.Name_Brand = sName_Brand;
            oeaBrand.Brand_Status = bBrand_Status;
            oeaBrand.Brand_ModiBy = sBrand_ModiBy;
            oeaBrand.Brand_DateModiBy = tBrand_DateModiBy;
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
        public EBrand Actualizar_BrandTMP(int iid_Brand,  string sName_Brand, bool bBrand_Status, string scategory)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_BRANDTMP", iid_Brand, sName_Brand, bBrand_Status, scategory);
            oConn = null;
            EBrand oeaBrandTMP = new EBrand();
            oeaBrandTMP.Name_Brand = sName_Brand;
            oeaBrandTMP.Brand_Status = bBrand_Status;
            return oeaBrandTMP;
        }

        /// <summary>
        /// Método para obtener datos de la marca para registrar en PLA_Brand_Planning
        /// Ing. Mauricio Ortiz
        /// 29/03/2011
        /// modificacion : se agrega parametro sProduct_Category Ing. Mauricio Ortiz 29/04/2011
        /// </summary>
        /// <param name="sProduct_Category"></param>
        /// <param name="sName_Brand"></param>        
        /// <returns></returns>
        public DataTable ObtenerDatosMarca(string sProduct_Category ,string sName_Brand)
        {
            oConn = new Conexion(1);
            DataTable dtMarcas = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_OBTENERMARCASCLIENTE", sProduct_Category, sName_Brand);
            oConn = null;
            return dtMarcas;
        }
    }
}