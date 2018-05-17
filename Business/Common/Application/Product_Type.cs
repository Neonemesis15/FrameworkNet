using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;


namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: ProductType
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 17/07/2009
    /// Description: Establece los metodos para operar informacion relacionada con categorias de producto Lucky
    /// Requerimiento No:
    /// </summary>
    /// 

    public class Product_Type
    {
        public Product_Type()
        {
            //Se define el constructor por defecto
        }

        //----Metodo que permite registrar Categorias de producto
        /// <summary>
        /// Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
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
        /// <returns> oeProductCategory</returns>
        /// 

        /// <summary>
        /// Modificiación: se agrega campo iProductCategory_company_id.
        /// 10/08/2011 Joseph Gonzales
        /// </summary> 
        public EProduct_Type RegistrarProductcategory(string sid_ProductCategory, string sProductCategory, string sGroup_Category, bool bProductCategory_Status, string sProductCategory_CompanyId, string sProductCategory_CreateBy, DateTime tProductCategory_DateBy, string sProductCategory_ModiBy, DateTime tProductCategory_DateModiBy)
        {
            DProduct_Type odrProductCategory = new DProduct_Type();
            EProduct_Type oeProductCategory = odrProductCategory.RegistrarProductCategoryPK(sid_ProductCategory, sProductCategory, sGroup_Category, bProductCategory_Status, sProductCategory_CompanyId, sProductCategory_CreateBy, tProductCategory_DateBy, sProductCategory_ModiBy, tProductCategory_DateModiBy);
            odrProductCategory = null; 
            return oeProductCategory; 
        }

        //----Metodo que permite registrar Categorias de producto en DB Intermedia
        /// <summary>
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
        /// <returns> oeProductCategory</returns>
        public EProduct_Type RegistrarProductcategoryTMP(string sid_ProductCategory, string sProductCategory, bool bProductCategory_Status)
        {
            DProduct_Type odrProductCategory = new DProduct_Type();
            EProduct_Type oeProductCategory = odrProductCategory.RegistrarProductCategoryPKTMP(sid_ProductCategory, sProductCategory, bProductCategory_Status);
            odrProductCategory = null;
            return oeProductCategory;
        }

        //---Metodo de Consulta de Categorias de producto
        /// <summary>
        /// Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <returns>dtProductCategory</returns>
        public DataTable SearchProductCategory(string sid_ProductCategory, string sProductCategory, string sCompanyId)
        {
            DProduct_Type odsProductCategory = new DProduct_Type();
            EProduct_Type oeProductCategory = new EProduct_Type();
            DataTable dtProductCategory = odsProductCategory.ObtenerCategoryProduct(sid_ProductCategory, sProductCategory, sCompanyId);

            odsProductCategory = null;
            return dtProductCategory;
        }

        //----Metodo que permite Actualizar Categorias de producto 
        /// <summary>
        /// Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <param name="iid_ProductClass"></param>
        /// <param name="bProductCategory_Status"></param>
        /// <param name="sProductCategory_ModiBy"></param>
        /// <param name="tProductCategory_DateModiBy"></param>
        /// <returns>oeaProductCategory</returns>
        public EProduct_Type Actualizar_ProductCategory(string sid_ProductCategory, string sProductCategory, string sGroup_Category , string sCompanyId,bool bProductCategory_Status, string sProductCategory_ModiBy, DateTime tProductCategory_DateModiBy)
        {
            DProduct_Type odaProductCategory = new DProduct_Type();
            EProduct_Type oeaProductCategory = odaProductCategory.Actualizar_ProductCategory(sid_ProductCategory, sProductCategory, sGroup_Category, sCompanyId, bProductCategory_Status, sProductCategory_ModiBy, tProductCategory_DateModiBy);
            odaProductCategory = null;
            return oeaProductCategory;
        }
        /// <summary>
        /// Adtualiza Categoria en BD intermedia
        /// 28/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sProductCategory"></param>
        /// <param name="bProductCategory_Status"></param>
        /// <returns></returns>
        public EProduct_Type Actualizar_ProductCategorytmp(string sid_ProductCategory, string sProductCategory, bool bProductCategory_Status)
        {
            DProduct_Type odaProductCategorytmp = new DProduct_Type();
            EProduct_Type oeaProductCategorytmp = odaProductCategorytmp.Actualizar_ProductCategoryTMP(sid_ProductCategory, sProductCategory, bProductCategory_Status);
            odaProductCategorytmp = null;
            return oeaProductCategorytmp;
        }
    }
}
      
