using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;


namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Productos
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 29/05/2009
    /// Description: Establece los metodos para operar informacion relacionada con Productos Lucky
    /// Requerimiento No:
    /// </summary>
    public class Productos
    {
        public Productos()
        {
            //Se define el constructor por defecto
        }

        //----Metodo que permite registrar Productos Ing. Mauricio Ortiz
        /// <summary>
        /// Modificacion: El parametro  iProduct_weight se cambia a decimal Ing.Carlos Hernandez
        /// 10-10-2009 se eliminan los campos id_Brand , id_ProductClass y id_ProductCategory 
        /// dada las nuevas relaciones existentes. estos campos se consultan de las tablas correspondientes Ing. Mauricio Ortiz
        /// </summary>

        /// Modificación:se agregan nuevos campos iid_Brand,sid_Product_Categ,sProduc_Caracteristicas, sProduc_Beneficios y se quita id_productipo
        /// 01/09/2010 Magaly jiménez.
        /// Modificación: se agrega nuevo campo para relacionar id_Product_Family
        /// 08/11/2010 Magaly Jiménez
        public EProductos RegistrarProductos(string scod_Product, string sProduct_CodeEAN, string sProduct_Name,
              int iid_Brand, int iid_SubBrand, string sid_ProductFamily, string sid_ProductSubFamily, int iCompany_id, string sid_Product_Categ, long lid_Subcategory, string sid_Product_Presentation,
              decimal dProduct_Factor, decimal dProduct_Peso_gr, int iid_UnitOfMeasure, int iProduct_weightMeasure, decimal dProduct_High, int iProduct_HighMeasure,
              decimal dProduct_width, int iProduct_widthMeasure, decimal dProduct_PriceList, decimal dProduct_PriceReSale, string sProduc_Caracteristicas, string sProduc_Beneficios, bool bProduct_Status,
              string sProduct_CreateBy, DateTime tProduct_DateBy, string sProduct_ModiBy, DateTime tProduct_DateModiby, string sEnglish_Alias)
        {
            DProductos odrProductos = new DProductos();

            EProductos oeProductos = odrProductos.RegistrarProductoPK(scod_Product, sProduct_CodeEAN, sProduct_Name,
               iid_Brand, iid_SubBrand, sid_ProductFamily, sid_ProductSubFamily, iCompany_id, sid_Product_Categ, lid_Subcategory, sid_Product_Presentation,
               dProduct_Factor, dProduct_Peso_gr, iid_UnitOfMeasure, iProduct_weightMeasure, dProduct_High, iProduct_HighMeasure,
               dProduct_width, iProduct_widthMeasure, dProduct_PriceList, dProduct_PriceReSale, sProduc_Caracteristicas, sProduc_Beneficios, bProduct_Status,
               sProduct_CreateBy, tProduct_DateBy, sProduct_ModiBy, tProduct_DateModiby,sEnglish_Alias);

            odrProductos = null;
            return oeProductos;
        }
        /// <summary>
        /// Registra productos en la BD intermedia
        /// 03/02/2011 Magaly Jiménez
        /// </summary>
        /// <returns></returns>
        public EProductos RegistrarProductostmp(int iidProduct, string scodProd, string snameProd, string sidMarca, string sidSubMarca,
                                                string sidFamilia, string sid_ProductSubFamily, string sidCompany, string sidCategory, string sidPresentacion, string sstatusProd)
        {
            DProductos odrProductostmp = new DProductos();
            EProductos oeProductostmp = odrProductostmp.RegistrarProductoTMP(iidProduct, scodProd, snameProd, sidMarca, sidSubMarca, sidFamilia, sid_ProductSubFamily, sidCompany, sidCategory, sidPresentacion, sstatusProd);
            odrProductostmp = null;
            return oeProductostmp;
        }

        //---Metodo de Consulta de Productos Ing. Mauricio Ortiz
        /// <summary>
        /// Modificación: se cambia parametro de busqueda Product_CodeEAN por iid_Brand y se agregan campos de subcategoria, caracteristicas y beneficios.
        /// 01/09/2010 Magaly jiménez
        /// Modificación: se agrega nuevo campo para relacionar id_Product_Family
        /// 08/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sProduct_Name"></param>
        /// <returns>dtProducto</returns>
        public DataTable BuscarProductos(int iCompany_id, string sid_ProductCategory, int iid_Brand, string scod_Product)
        {
            Lucky.Data.Common.Application.DProductos odseProducto = new Lucky.Data.Common.Application.DProductos();
            EProductos oeProductos = new EProductos();
            DataTable dtProducto = odseProducto.ObtenerProducto(iCompany_id, sid_ProductCategory, iid_Brand, scod_Product);
            odseProducto = null;
            return dtProducto;
        }

        /// <summary>
        /// se implementa para eliminar webservices
        /// 15/03/2011 Magaly jimémez
        /// </summary>
        /// <param name="iidBrand"></param>
        /// <returns></returns>
        public DataTable LlenaComboClienteenProducto(int iidBrand)
        {
            Lucky.Data.Common.Application.DProductos odsedProducto = new Lucky.Data.Common.Application.DProductos();
            EProductos oedProductos = new EProductos();
            DataTable dtdProducto = odsedProducto.LlenaComboClienteenProducto(iidBrand);
            odsedProducto = null;
            return dtdProducto;
        }

        /// <summary>
        /// obtienes id de los combos de maestro de productos.
        /// 10/03/2011 Magaly Jimenez
        /// </summary>
        /// <param name="sCompany_Name"></param>
        /// <param name="sProduct_Category"></param>
        /// <param name="sName_Subcategory"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="Name_SubBrand"></param>
        /// <param name="sProductPresentationName"></param>
        /// <param name="name_Family"></param>
        /// <returns></returns>
        public DataSet ObteneridsProductos(int nconsulta, string sCompany_Name, string sProduct_Category, string sName_Subcategory, string sName_Brand, string Name_SubBrand, string sProductPresentationName, string name_Family, string ProductSubFamily, string sUnitOfMeasure_Name)
        {
            EProductos oeidsProductos = new EProductos();
            DProductos oeidsProductos1 = new DProductos();
            DataSet dsidsProductos = oeidsProductos1.ObteneridsProductos(nconsulta, sCompany_Name, sProduct_Category, sName_Subcategory, sName_Brand, Name_SubBrand, sProductPresentationName, name_Family, ProductSubFamily, sUnitOfMeasure_Name);
            oeidsProductos1 = null;
            return dsidsProductos;
        }

        //----Metodo que permite Actualizar Productos Ing. Mauricio Ortiz
        /// <summary>
        /// Modificiación: se agrega campos de id_Brand, sid_Product_Categ, lid_Subcategory, Produc_Caracteristicas y Produc_Beneficios.
        /// 01/09/2010 Magaly Jiménez.
        /// Modificación: se agrega nuevo campo para relacionar id_Product_Family
        /// 08/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="lid_Product"></param>
        /// <param name="scod_Product"></param>
        /// <param name="sProduct_CodeEAN"></param>
        /// <param name="sProduct_Name"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sid_SubBrand"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="sid_Product_Categ"></param>
        /// <param name="lid_Subcategory"></param>
        /// <param name="sid_Product_Presentation"></param>
        /// <param name="dProduct_Factor"></param>
        /// <param name="iProduct_weightMeasure"></param>
        /// <param name="dProduct_High"></param>
        /// <param name="iProduct_HighMeasure"></param>
        /// <param name="dProduct_width"></param>
        /// <param name="iProduct_widthMeasure"></param>
        /// <param name="dProduct_PriceList"></param>
        /// <param name="dProduct_PriceReSale"></param>
        /// <param name="sProduc_Caracteristicas"></param>
        /// <param name="sProduc_Beneficios"></param>
        /// <param name="bProduct_Status"></param>
        /// <param name="sProduct_ModiBy"></param>
        /// <param name="tProduct_DateModiby"></param>
        /// <returns> oeaProducto</returns>
        public EProductos Actualizar_Producto(long lid_Product, string scod_Product, string sProduct_CodeEAN, string sProduct_Name,
                    int iid_Brand, int iid_SubBrand, string sid_ProductFamily, string sid_ProductSubFamily, int iCompany_id, string sid_Product_Categ, long lid_Subcategory, string sid_Product_Presentation,
                    decimal dProduct_Factor, decimal dProduct_Peso_gr, int iid_UnitOfMeasure, int iProduct_weightMeasure, decimal dProduct_High, int iProduct_HighMeasure,
                    decimal dProduct_width, int iProduct_widthMeasure, decimal dProduct_PriceList, decimal dProduct_PriceReSale, string sProduc_Caracteristicas, string sProduc_Beneficios, bool bProduct_Status,
              string sProduct_ModiBy, DateTime tProduct_DateModiby, string sEnglish_Alias)
        {
            Lucky.Data.Common.Application.DProductos odaProducto = new Lucky.Data.Common.Application.DProductos();
            EProductos oeaProducto = odaProducto.Actualizar_Productos(lid_Product, scod_Product, sProduct_CodeEAN, sProduct_Name,
               iid_Brand, iid_SubBrand, sid_ProductFamily, sid_ProductSubFamily, iCompany_id, sid_Product_Categ, lid_Subcategory, sid_Product_Presentation,
               dProduct_Factor, dProduct_Peso_gr,  iid_UnitOfMeasure, iProduct_weightMeasure, dProduct_High, iProduct_HighMeasure,
               dProduct_width, iProduct_widthMeasure, dProduct_PriceList, dProduct_PriceReSale, sProduc_Caracteristicas, sProduc_Beneficios, bProduct_Status,
               sProduct_ModiBy, tProduct_DateModiby, sEnglish_Alias);
            odaProducto = null;
            return oeaProducto;
        }
        /// <summary>
        /// Actualiza produtos  en la base de datos intermedia
        /// 03/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="lid_Product"></param>
        /// <param name="scod_Product"></param>
        /// <param name="sProduct_Name"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sid_ProductFamily"></param>
        /// <param name="sid_Product_Categ"></param>
        /// <param name="sid_Product_Presentation"></param>
        /// <param name="bProduct_Status"></param>
        /// <returns></returns>
        public EProductos Actualizar_ProductoTMP(long lid_Product, string scod_Product, string sProduct_Name,
              int iid_Brand, int iid_SubBrand, string sid_ProductFamily, string sid_ProductSubFamily, string sid_Product_Categ, string sid_Product_Presentation,
              bool bProduct_Status)
        {
            Lucky.Data.Common.Application.DProductos odaProductotmp = new Lucky.Data.Common.Application.DProductos();
            EProductos oeaProducto = odaProductotmp.Actualizar_Productostmp(lid_Product, scod_Product, sProduct_Name,
               iid_Brand, iid_SubBrand, sid_ProductFamily, sid_ProductSubFamily, sid_Product_Categ,  sid_Product_Presentation,bProduct_Status);
            odaProductotmp = null;
            return oeaProducto;
        }
    }
}