using System;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para ProductCategory
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate: 17-07-09
    /// Requerimiento:
    public class DProduct_Type
    {
        String messages = "";
        private Conexion oConn;
        public DProduct_Type()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

        //Metodo para Registrar categorias de Producto
        /// <summary>
        ///  Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <param name="iid_ProductClass"></param>
        /// <param name="bProductCategory_Status"></param>
        /// <param name="sProductCategory_CreateBy"></param>
        /// <param name="tProductCategory_DateBy"></param>
        /// <param name="sProductCategory_ModiBy"></param>
        /// <param name="tProductCategory_DateModiBy"></param>
        /// <returns>oerCategProduct</returns>
        /// 
        /// <summary>
        /// Modificiación: se agrega campo iProductCategory_company_id.
        /// 10/08/2011 Joseph Gonzales
        /// </summary> 
        public EProduct_Type RegistrarProductCategoryPK(string sid_ProductCategory, string sProductCategory, string sGroup_Category, bool bProductCategory_Status, string sProductCategory_company_id , string sProductCategory_CreateBy, DateTime tProductCategory_DateBy, string sProductCategory_ModiBy, DateTime tProductCategory_DateModiBy)
        {
            oConn = new Conexion(1);
            string id_Category = oConn.ejecutarEscalar("UP_WEB_REGISTER_PRODUCTCATEGORY", sid_ProductCategory, sProductCategory, sGroup_Category, bProductCategory_Status, sProductCategory_company_id, sProductCategory_CreateBy, tProductCategory_DateBy, sProductCategory_ModiBy, tProductCategory_DateModiBy);
            oConn = null;  
            EProduct_Type oerCategProduct = new EProduct_Type(); 
            oerCategProduct.id_Product_Category = id_Category;
            oerCategProduct.Product_Category = sProductCategory;
            oerCategProduct.Product_Category_Status = bProductCategory_Status;
            oerCategProduct.Product_Category_company_id = sProductCategory_company_id;
            oerCategProduct.Product_Category_CreateBy = sProductCategory_CreateBy;
            oerCategProduct.Product_Category_DateBy = tProductCategory_DateBy;
            oerCategProduct.Product_Category_ModiBy = sProductCategory_ModiBy; 
            oerCategProduct.Product_Category_DateModiBy = tProductCategory_DateModiBy;
            return oerCategProduct;
        } 

        //Nombre Metodo: SEARCH ProductCategory
        //Función: Permite Consultar categorias de productos
        /// <summary>
        ///  Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <returns>dt</returns>
        public DataTable ObtenerCategoryProduct(string sid_ProductCategory, string sProductCategory, string sCompanyId)
        {
            oConn = new Conexion(1);
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable("UP_WEB_SEARCHPRODUCTCATEGORY",
                    sid_ProductCategory, sProductCategory, sCompanyId);
            }
            catch (Exception ex)
            {
                messages = "Ocurrio un Error: " + ex.ToString();
            }

            if (messages.Equals(""))
            {
                if (dt.Rows.Count == 0)
                {
                    messages = "Error: No Existen Categorías Disponibles, ¡por favor Verificar...!";
                }   
            }

            #region Validación Comentada
            /*
            EProduct_Type oeProductCategory = new EProduct_Type();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeProductCategory.id_Product_Category = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        oeProductCategory.Product_Category = dt.Rows[i]["Product_Category"].ToString().Trim();
                        oeProductCategory.Group_Category = dt.Rows[i]["Group_Category"].ToString().Trim();
                        oeProductCategory.Product_Category_company_id = dt.Rows[i]["Company_id"].ToString().Trim();
                        oeProductCategory.Product_Category_company_name = dt.Rows[i]["Company_name"].ToString().Trim();
                        oeProductCategory.Product_Category_Status = Convert.ToBoolean(dt.Rows[i]["ProductCategory_Status"].ToString().Trim());                        
                        oeProductCategory.Product_Category_CreateBy = dt.Rows[i]["ProductCategory_CreateBy"].ToString().Trim();
                        oeProductCategory.Product_Category_DateBy = Convert.ToDateTime(dt.Rows[i]["ProductCategory_DateBy"].ToString().Trim());
                        oeProductCategory.Product_Category_ModiBy = dt.Rows[i]["ProductCategory_ModiBy"].ToString().Trim();
                        oeProductCategory.Product_Category_DateModiBy = Convert.ToDateTime(dt.Rows[i]["ProductCategory_DateModiBy"].ToString().Trim());
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
             * */
            #endregion 
            
            return dt;
        }


        //Nombre Metodo: ACTUALIZAR_ProductCategory
        //Función: Permite Actualizar categorias de productos
        /// <summary>
        ///  Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <param name="iid_ProductClass"></param>
        /// <param name="bProductCategory_Status"></param>
        /// <param name="sProductCategory_ModiBy"></param>
        /// <param name="tProductCategory_DateModiBy"></param>
        /// <returns>oeaProductCategory</returns>
        public EProduct_Type Actualizar_ProductCategory(string sid_ProductCategory, string sProductCategory, string sGroup_Category, string scompany_id ,bool bProductCategory_Status, string sProductCategory_ModiBy, DateTime tProductCategory_DateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_PRODUCTCATEGORY", sid_ProductCategory, sProductCategory, sGroup_Category, scompany_id, bProductCategory_Status, sProductCategory_ModiBy, tProductCategory_DateModiBy);
            oConn = null;
            EProduct_Type oeaProductCategory = new EProduct_Type();
            oeaProductCategory.Product_Category = sProductCategory;
            oeaProductCategory.Group_Category = sGroup_Category;
            oeaProductCategory.Product_Category_company_id = scompany_id;
            oeaProductCategory.Product_Category_Status = bProductCategory_Status;
            oeaProductCategory.Product_Category_ModiBy = sProductCategory_ModiBy;
            oeaProductCategory.Product_Category_DateModiBy = tProductCategory_DateModiBy;
            return oeaProductCategory;
        }

        //Metodo para Registrar categorias de Producto en DB Intermedia
        /// <summary>
        /// Registra categorias de Producto en DB Intermedia
        /// 15/06/2011 Angel Ortiz
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <param name="iid_ProductClass"></param>
        /// <param name="bProductCategory_Status"></param>
        /// <param name="sProductCategory_CreateBy"></param>
        /// <param name="tProductCategory_DateBy"></param>
        /// <param name="sProductCategory_ModiBy"></param>
        /// <param name="tProductCategory_DateModiBy"></param>
        /// <returns>oerCategProduct</returns>
        public EProduct_Type RegistrarProductCategoryPKTMP(string sid_ProductCategory, 
            string sProductCategory, bool bProductCategory_Status)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_CATEGORIA_TMP", 
                sid_ProductCategory, sProductCategory, Convert.ToInt32(bProductCategory_Status));
            oConn = null;
            EProduct_Type oerCategProduct = new EProduct_Type();
            oerCategProduct.id_Product_Category = sid_ProductCategory;
            oerCategProduct.Product_Category = sProductCategory;
            oerCategProduct.Product_Category_Status = bProductCategory_Status;
            return oerCategProduct;
        }

        /// <summary>
        /// Adtualiza Categoria en BD intermedia
        /// 28/01/2011 Magaly Jiménez
        /// Modificado: Se establece Conexion directa a la base intermedia. 
        /// 15/06/2011 - Angel Ortiz
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <param name="bProductCategory_Status"></param>
        /// <returns>oeaProductCategorytmp</returns>
        public EProduct_Type Actualizar_ProductCategoryTMP(string sid_ProductCategory, string sProductCategory, bool bProductCategory_Status)
        {
            oConn = new Conexion(2);
            int var = Convert.ToInt32(oConn.ejecutarEscalar("UP_WEBXPLORA_ACTUALIZAR_PRODUCTCATEGORYTMP", sid_ProductCategory, sProductCategory, bProductCategory_Status));
            oConn = null;
            EProduct_Type oeaProductCategorytmp = new EProduct_Type();
            oeaProductCategorytmp.Product_Category = sProductCategory;
            oeaProductCategorytmp.Product_Category_Status = bProductCategory_Status;
            return oeaProductCategorytmp;
        }
        
        /// <summary>
        /// Devuelve los mensajes de Error
        /// </summary>
        /// <returns></returns>
        public String getMessage() {
            return messages;
        }
    }
}