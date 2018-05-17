using System;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DProductos.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:29/05/2009
    /// Requerimiento:
    /// Actualización: 13/06/2011 - Se define la conexión especçifica para cada DB (PRODUCCIÓN e INTERMEDIA). Angel Ortiz
    /// </summary>

    public class DProductos
    {        
        public DProductos()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

        //Metodo para Registrar Productos
        /// <summary>
        /// Se cambia  el parametro iProduct_weight a decimal Ing. Carlos Hernandez
        /// se incluye los parametros dProduct_PriceList y dProduct_PriceReSale Ing. Mauricio Ortiz
        /// se cambio el parametro iid_ProductTipo a string Ing. Mauricio Ortiz 
        /// ( antes era categoria de producto se decidio inclir el tipo de producto tambien . se modifico de int a string)
        /// se creo el campo id_Product tipo identity , el cod_product deja de ser llave primaria.
        /// De acuerdo a la nueva concepcion el campo dProduct_PriceList hace referencia al precio sugerido del punto de venta
        /// 10-10-2009 se eliminan los campos id_Brand , id_ProductClass y id_ProductCategory
        /// dada las nuevas relaciones existentes. estos campos se consultan de las tablas correspondientes Ing. Mauricio Ortiz
        ///         /// 
        /// </summary>

        /// Modificación:se agregan nuevos campos iid_Brand,sid_Product_Categ,sProduc_Caracteristicas, sProduc_Beneficios y se quita id_productipo
        /// 01/09/2010 Magaly jiménez.
        /// Modificación: se agrega nuevo campo para relacionar id_Product_Family
        /// 08/11/2010 Magaly Jiménez

        public EProductos RegistrarProductoPK(string scod_Product, string sProduct_CodeEAN, string sProduct_Name,
        int iid_Brand, int iid_SubBrand, string sid_ProductFamily, string sid_ProductSubFamily, int iCompany_id, string sid_Product_Categ, long lid_Subcategory, string sid_Product_Presentation,
        decimal dProduct_Factor, decimal dProduct_Peso_gr, int iid_UnitOfMeasure, int iProduct_weightMeasure, decimal dProduct_High, int iProduct_HighMeasure,
        decimal dProduct_width, int iProduct_widthMeasure, decimal dProduct_PriceList, decimal dProduct_PriceReSale, string sProduc_Caracteristicas, string sProduc_Beneficios, bool bProduct_Status,
        string sProduct_CreateBy, DateTime tProduct_DateBy, string sProduct_ModiBy, DateTime tProduct_DateModiby, string sEnglish_Alias)
        {
            Conexion oConn = new Conexion(1);

            int idProducto = Convert.ToInt32(oConn.ejecutarEscalar("UP_WEB_REGISTERPRODUCTOS",  scod_Product,  sProduct_CodeEAN, sProduct_Name,
            iid_Brand, iid_SubBrand, sid_ProductFamily, sid_ProductSubFamily, iCompany_id, sid_Product_Categ, lid_Subcategory, sid_Product_Presentation,
            dProduct_Factor,  dProduct_Peso_gr, iid_UnitOfMeasure, iProduct_weightMeasure, dProduct_High,  iProduct_HighMeasure,
            dProduct_width, iProduct_widthMeasure, dProduct_PriceList, dProduct_PriceReSale,  sProduc_Caracteristicas, sProduc_Beneficios,  bProduct_Status,
            sProduct_CreateBy, tProduct_DateBy, sProduct_ModiBy, tProduct_DateModiby, sEnglish_Alias));

            oConn = null;

            EProductos oerproducto = new EProductos();

            oerproducto.id_Product = idProducto; // se agrega el id del producto para devolverlo en el objeto
            oerproducto.cod_Product = scod_Product;
            oerproducto.Product_CodeEAN = sProduct_CodeEAN;
            oerproducto.Product_Name = sProduct_Name;
            oerproducto.id_Brand = iid_Brand;
            oerproducto.id_SubBrand = iid_SubBrand;
            oerproducto.id_ProductFamily = sid_ProductFamily;
            oerproducto.id_ProductSubFamily = sid_ProductSubFamily;
            oerproducto.Company_id = iCompany_id;
            oerproducto.id_Product_Categ = sid_Product_Categ;
            oerproducto.id_Product_Presentation = sid_Product_Presentation;
            oerproducto.Product_Factor = dProduct_Factor;
            oerproducto.Product_Peso_gr = dProduct_Peso_gr;
            oerproducto.id_UnitOfMeasure = iid_UnitOfMeasure;
            //oerproducto.Product_weight = dProduct_weight;
            //oerproducto.Product_weightMeasure = iProduct_weightMeasure;
            oerproducto.Product_High = dProduct_High;
            oerproducto.Product_HighMeasure = iProduct_HighMeasure;
            oerproducto.Product_width = dProduct_width;
            oerproducto.Product_widthMeasure = iProduct_widthMeasure;
            oerproducto.Product_PriceList = dProduct_PriceList;
            oerproducto.Product_PriceReSale = dProduct_PriceReSale;
            oerproducto.Produc_Caracteristicas = sProduc_Caracteristicas;
            oerproducto.Produc_Beneficios = sProduc_Beneficios;
            oerproducto.Product_Status = bProduct_Status;
            oerproducto.Product_CreateBy = sProduct_CreateBy;
            oerproducto.Product_DateBy = tProduct_DateBy;
            oerproducto.Product_ModiBy = sProduct_ModiBy;
            oerproducto.Product_DateModiby = tProduct_DateModiby;
            oerproducto.English_Alias = sEnglish_Alias;
            
            return oerproducto;
        }
        /// <summary>
        /// Registra productos en la BD intermedia
        /// 03/02/2011 Magaly Jiménez
        /// Actualización: 13/06/2011 - Se agregan parámetros y se selecciona directamente la conexión a la DB Intermedia. Angel Ortiz
        /// </summary>
        /// <returns></returns>
        public EProductos RegistrarProductoTMP( int iidProduct, string scodProd, string snameProd, string sidMarca, string sidSubMarca,
                                                string sidFamilia, string sidSubFamilia, string sidCompany, string sidCategory, string sidPresentacion, string sstatusProd)
        {
            Conexion oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERPRODUCTOSTMP", iidProduct, scodProd, snameProd, sidMarca, sidSubMarca,
                                                sidFamilia, sidSubFamilia, sidCompany, sidCategory, sidPresentacion, sstatusProd);
            EProductos oerproductotmp = new EProductos();
            return oerproductotmp;
        }

        /// <summary>
        ///Nombre Metodo: SEARCHPRODUCT
        ///Función: Permite Consultar productos
        /// </summary>

        ///Modificación: se cambia parametro de busqueda Product_CodeEAN por iid_Brand y se agregan campos de subcategoria, caracteristicas y beneficios.
        ///01/09/2010 Magaly jiménez
        ///Modificación: se agrega nuevo campo para relacionar id_Product_Family
        /// 08/11/2010 Magaly Jiménez
        public DataTable ObtenerProducto(int iCompany_id, string sid_ProductCategory, int iid_Brand, string scod_Product)
        {
            Conexion oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHPRODUCT", iCompany_id, sid_ProductCategory, iid_Brand, scod_Product);
            EProductos oeProducto = new EProductos();


            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                //    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                //    {
                //        oeProducto.id_Product = Convert.ToInt64(dt.Rows[i]["id_Product"].ToString().Trim());
                //        oeProducto.cod_Product = dt.Rows[i]["cod_Product"].ToString().Trim();
                //        oeProducto.Product_CodeEAN = dt.Rows[i]["Product_CodeEAN"].ToString().Trim();
                //        oeProducto.Product_Name = dt.Rows[i]["Product_Name"].ToString().Trim();
                //        oeProducto.id_Brand = Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                //        oeProducto.id_SubBrand = Convert.ToInt32(dt.Rows[i]["id_SubBrand"].ToString().Trim());
                //        oeProducto.id_ProductFamily = dt.Rows[i]["id_ProductFamily"].ToString().Trim();
                //        oeProducto.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                //        oeProducto.id_Product_Categ = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                //        oeProducto.id_Subcategory = Convert.ToInt64(dt.Rows[i]["id_Subcategory"].ToString().Trim());
                //        oeProducto.id_Product_Presentation = dt.Rows[i]["id_Product_Presentation"].ToString().Trim();
                //        oeProducto.Product_Factor = Convert.ToDecimal(dt.Rows[i]["Product_Factor"].ToString().Trim());
                //        oeProducto.Product_Peso_gr = Convert.ToDecimal(dt.Rows[i]["Product_Peso_gr"].ToString().Trim());
                //        //oeProducto.Product_weight = Convert.ToDecimal(dt.Rows[i]["Product_weight"].ToString().Trim());
                //        //oeProducto.Product_weightMeasure = Convert.ToInt32(dt.Rows[i]["Product_weightMeasure"].ToString().Trim());
                //        oeProducto.Product_High = Convert.ToDecimal(dt.Rows[i]["Product_High"].ToString().Trim());
                //        oeProducto.Product_HighMeasure = Convert.ToInt32(dt.Rows[i]["Product_HighMeasure"].ToString().Trim());
                //        oeProducto.Product_width = Convert.ToDecimal(dt.Rows[i]["Product_width"].ToString().Trim());
                //        oeProducto.Product_widthMeasure = Convert.ToInt32(dt.Rows[i]["Product_widthMeasure"].ToString().Trim());
                //        oeProducto.Product_PriceList = Convert.ToDecimal(dt.Rows[i]["Product_PriceList"].ToString().Trim());
                //        oeProducto.Product_PriceReSale = Convert.ToDecimal(dt.Rows[i]["Product_PriceReSale"].ToString().Trim());
                //        oeProducto.Produc_Caracteristicas = dt.Rows[i]["Produc_Caracteristicas"].ToString().Trim();
                //        oeProducto.Produc_Beneficios = dt.Rows[i]["Produc_Beneficios"].ToString().Trim();
                //        oeProducto.Product_Status = Convert.ToBoolean(dt.Rows[i]["Product_Status"].ToString().Trim());
                //        oeProducto.Product_CreateBy = dt.Rows[i]["Product_CreateBy"].ToString().Trim();
                //        oeProducto.Product_DateBy = Convert.ToDateTime(dt.Rows[i]["Product_DateBy"].ToString().Trim());
                //        oeProducto.Product_ModiBy = dt.Rows[i]["Product_ModiBy"].ToString().Trim();
                //        oeProducto.Product_DateModiby = Convert.ToDateTime(dt.Rows[i]["Product_DateModiby"].ToString().Trim());
                    //}
                }
                return dt;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// se implementa para eliminar webservices
        /// 15/03/2011 Magaly jimémez
        /// </summary>
        /// <param name="iidBrand"></param>
        /// <returns></returns>
        public DataTable LlenaComboClienteenProducto(int iidBrand)
        {
            Conexion oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_LLENACOMBOCLIENTEPRODUCT", iidBrand);
            EProductos oedProducto = new EProductos();


            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene id para llenar combos de carga masvia en productos.
        /// 10/03/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sCompany_Name"></param>
        /// <param name="sProduct_Category"></param>
        /// <param name="sName_Subcategory"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="Name_SubBrand"></param>
        /// <param name="sProductPresentationName"></param>
        /// <param name="name_Family"></param>
        /// <returns></returns>
        public DataSet ObteneridsProductos(int nconsulta, string sCompany_Name, string sProduct_Category, string sName_Subcategory, string sName_Brand, string Name_SubBrand, string sProductPresentationName, string name_Family, string sProduct_SubFamily, string sUnitOfMeasure_Name)
        {
            Conexion oConn = new Conexion(1);
            DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_AD_CONSULTAIDS_PRODUCTOS", nconsulta, sCompany_Name, sProduct_Category, sName_Subcategory, sName_Brand, Name_SubBrand, sProductPresentationName, name_Family, sProduct_SubFamily, sUnitOfMeasure_Name);
            return ds;
        }
        //Método para Actualizar Productos.

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
        /// <returns>oeaProductos</returns>
        public EProductos Actualizar_Productos(long lid_Product, string scod_Product, string sProduct_CodeEAN, string sProduct_Name,
              int iid_Brand, int iid_SubBrand, string sid_ProductFamily, string sid_ProductSubFamily, int iCompany_id, string sid_Product_Categ, long lid_Subcategory, string sid_Product_Presentation,
              decimal dProduct_Factor, decimal dProduct_Peso_gr, int iid_UnitOfMeasure, int iProduct_weightMeasure, decimal dProduct_High, int iProduct_HighMeasure,
              decimal dProduct_width, int iProduct_widthMeasure, decimal dProduct_PriceList, decimal dProduct_PriceReSale, string sProduc_Caracteristicas, string sProduc_Beneficios, bool bProduct_Status,
        string sProduct_ModiBy, DateTime tProduct_DateModiby, string sEnglish_Alias)
        {
            Conexion oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_PRODUCTOS", lid_Product, scod_Product, sProduct_CodeEAN, sProduct_Name,
               iid_Brand, iid_SubBrand, sid_ProductFamily, sid_ProductSubFamily, iCompany_id, sid_Product_Categ, lid_Subcategory, sid_Product_Presentation,
               dProduct_Factor, dProduct_Peso_gr, iid_UnitOfMeasure, iProduct_weightMeasure, dProduct_High, iProduct_HighMeasure,
               dProduct_width, iProduct_widthMeasure, dProduct_PriceList, dProduct_PriceReSale, sProduc_Caracteristicas, sProduc_Beneficios, bProduct_Status,
               sProduct_ModiBy, tProduct_DateModiby,sEnglish_Alias);
            oConn = null;
            EProductos oeaProductos = new EProductos();

            oeaProductos.id_Product = lid_Product;
            oeaProductos.cod_Product = scod_Product;
            oeaProductos.Product_CodeEAN = sProduct_CodeEAN;
            oeaProductos.Product_Name = sProduct_Name;
            oeaProductos.id_Brand = iid_Brand;
            oeaProductos.id_SubBrand = iid_SubBrand;
            oeaProductos.id_ProductFamily = sid_ProductFamily;
            oeaProductos.id_ProductSubFamily = sid_ProductSubFamily;
            oeaProductos.Company_id = iCompany_id;
            oeaProductos.id_Product_Categ = sid_Product_Categ;
            oeaProductos.id_Subcategory = lid_Subcategory;
            oeaProductos.id_Product_Presentation = sid_Product_Presentation;
            oeaProductos.Product_Factor = dProduct_Factor;
            oeaProductos.Product_Peso_gr = dProduct_Peso_gr;
            oeaProductos.id_UnitOfMeasure = iid_UnitOfMeasure;
            //oeaProductos.Product_weight = dProduct_weight;
            //oeaProductos.Product_weightMeasure = iProduct_weightMeasure;
            oeaProductos.Product_High = dProduct_High;
            oeaProductos.Product_HighMeasure = iProduct_HighMeasure;
            oeaProductos.Product_width = dProduct_width;
            oeaProductos.Product_widthMeasure = iProduct_widthMeasure;
            oeaProductos.Product_PriceList = dProduct_PriceList;
            oeaProductos.Product_PriceReSale = dProduct_PriceReSale;
            oeaProductos.Produc_Caracteristicas = sProduc_Caracteristicas;
            oeaProductos.Produc_Beneficios = sProduc_Beneficios;
            oeaProductos.Product_Status = bProduct_Status;
            oeaProductos.Product_ModiBy = sProduct_ModiBy;
            oeaProductos.Product_DateModiby = tProduct_DateModiby;
            oeaProductos.English_Alias = sEnglish_Alias;

            return oeaProductos;
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
        public EProductos Actualizar_Productostmp(long lid_Product, string scod_Product, string sProduct_Name, int iid_Brand,
            int iid_SubBrand, string sid_ProductFamily, string sid_ProductSubFamily, string sid_Product_Categ, string sid_Product_Presentation, bool bProduct_Status)
        {
            Conexion oConn = new Conexion(2);

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARPRODUCTOSTMP", lid_Product, scod_Product, sProduct_Name,
                iid_Brand, iid_SubBrand, sid_ProductFamily, sid_ProductSubFamily, sid_Product_Categ, sid_Product_Presentation, bProduct_Status);

            oConn = null;

            EProductos oeaProductostmp = new EProductos();

            //oeaProductos.id_Product = lid_Product;
            //oeaProductos.cod_Product = scod_Product;
            //oeaProductos.Product_CodeEAN = sProduct_CodeEAN;
            //oeaProductos.Product_Name = sProduct_Name;
            //oeaProductos.id_Brand = iid_Brand;
            //oeaProductos.id_SubBrand = iid_SubBrand;
            //oeaProductos.id_ProductFamily = sid_ProductFamily;
            //oeaProductos.Company_id = iCompany_id;
            //oeaProductos.id_Product_Categ = sid_Product_Categ;
            //oeaProductos.id_Subcategory = lid_Subcategory;
            //oeaProductos.id_Product_Presentation = sid_Product_Presentation;
            //oeaProductos.Product_Factor = dProduct_Factor;
            //oeaProductos.Product_Peso_gr = dProduct_Peso_gr;
            ////oeaProductos.Product_weight = dProduct_weight;
            ////oeaProductos.Product_weightMeasure = iProduct_weightMeasure;
            //oeaProductos.Product_High = dProduct_High;
            //oeaProductos.Product_HighMeasure = iProduct_HighMeasure;
            //oeaProductos.Product_width = dProduct_width;
            //oeaProductos.Product_widthMeasure = iProduct_widthMeasure;
            //oeaProductos.Product_PriceList = dProduct_PriceList;
            //oeaProductos.Product_PriceReSale = dProduct_PriceReSale;
            //oeaProductos.Produc_Caracteristicas = sProduc_Caracteristicas;
            //oeaProductos.Produc_Beneficios = sProduc_Beneficios;
            //oeaProductos.Product_Status = bProduct_Status;
            //oeaProductos.Product_ModiBy = sProduct_ModiBy;
            //oeaProductos.Product_DateModiby = tProduct_DateModiby;

            return oeaProductostmp;
        }
    }
}
