using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EProductos
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  12/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-025 Gestión de Productos
    ///                     «Functional» SIGE-ARF-127 Creacion Masiva de Productos
    ///                     «Functional» SIGE-ARF-081 Crear Productos
    ///                     «Functional» SIGE-ARF-082 Consultar Producto
    ///                     «Functional» SIGE-ARF-083 Actualizar Producto
    ///                     «Functional» SIGE-ARF-084 Deshabilitar Producto
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Productos
    ///                     permite al administrador del sistema gestionar los Productos, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Productos.
    ///                     Permite Administrar los productos usadas en las respectivas campañas del negocio y relacionarlas 
    ///                     por Cliente. Este maestro articula la información de los productos necesaria para la contrucción 
    ///                     de los servicios ofrecidos por Lucky en el Modulo Planning ver referencia Files:
    ///                     C:\SIGE\Artefactos Socializados\Tabla productos SIGE
    /// Modificaciones:     lid_Product se crea campo identity . cod_Product deja de ser la llave.  Ing. Mauricio Ortiz 
    ///                     lid_Product_Categ se creo el campo categorias de producto cambio de int a string Ing. Mauricio Ortiz
    ///                     lid_ProductTipo antes era categoria de producto se decidio inclir el tipo de producto 
    ///                     tambien se modificó de int a string Ing. Mauricio Ortiz
    ///                     lProduct_PriceList de acuerdo a la nueva concepcion este campo hace referencia al precio 
    ///                     sugerido del punto de venta
    ///                     Modificado: se agrega campo lid_Subcategory por nuevo maestro subcategoria
    ///                     21/08/2010 Magaly Jiménez
    ///                     Modificado: se cambia tipo de dato de id_producto en int a long, se quita campos lid_Product_Class y lid_ProductTipo, ademas se agregan campos de caracteristicas y beneficios.
    ///                     31/08/2010 Magaly Jiménez
    ///                     Modificado: se agregan campos Product_Family y Product_Peso_gr para relacionarlo al nuevo maestro de Productos.
    ///                     08/11/2010  Magaly Jiménez
    /// </summary>

    public class EProductos
    {
        public EProductos()
        {
            //Se define el constructor por defecto       
        }

        private long lid_Product;
        private string lcod_Product;
        private string lProduct_CodeEAN;
        private string lProduct_Name;
        private int lid_Brand;
        private int lid_SubBrand;
        private string lid_ProductFamily;
        private string lid_ProductSubFamily;

        
        private int lCompany_id;
        private string lid_Product_Categ;
        private long lid_Subcategory;
        private string lid_Product_Presentation;
        private decimal lProduct_Factor;
        //private decimal lProduct_weight;
        private int lProduct_weightMeasure;
        private decimal lProduct_Peso_gr;
        private int lid_UnitOfMeasure;
        private decimal lProduct_High;
        private int lProduct_HighMeasure;
        private decimal lProduct_width;
        private int lProduct_widthMeasure;
        private decimal lProduct_PriceList;
        private decimal lProduct_PriceReSale;
        private string lProduc_Caracteristicas;
        private string lProduc_Beneficios;
        private bool lProduct_Status;
        private string lProduct_CreateBy;
        private DateTime lProduct_DateBy;
        private string lProduct_ModiBy;
        private DateTime lProduct_DateModiby;

        private string lEnglish_Alias;


        public long id_Product
        {
            get { return this.lid_Product; }
            set { this.lid_Product = value; }
        }
        public string cod_Product
        {
            get { return this.lcod_Product; }
            set { this.lcod_Product = value; }
        }
        public string Product_CodeEAN
        {
            get { return this.lProduct_CodeEAN; }
            set { this.lProduct_CodeEAN = value; }
        }
        public string Product_Name
        {
            get { return this.lProduct_Name; }
            set { this.lProduct_Name = value; }
        }

        public int id_Brand
        {
            get { return this.lid_Brand; }
            set { this.lid_Brand = value; }
        }
        public int id_SubBrand
        {
            get { return this.lid_SubBrand; }
            set { this.lid_SubBrand = value; }
        }

        public string id_ProductFamily
        {
            get { return this.lid_ProductFamily; }
            set { this.lid_ProductFamily = value; }
        }

        public string id_ProductSubFamily
        {
            get { return this.lid_ProductSubFamily; }
            set { this.lid_ProductSubFamily = value; }
        }
        
        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }

        public string id_Product_Categ
        {
            get { return this.lid_Product_Categ; }
            set { this.lid_Product_Categ = value; }
        }

        public long id_Subcategory
        {
            get { return this.lid_Subcategory; }
            set { this.lid_Subcategory = value; }
        }

        public string id_Product_Presentation
        {
            get { return this.lid_Product_Presentation; }
            set { this.lid_Product_Presentation = value; }
        }
        public decimal Product_Factor
        {
            get { return this.lProduct_Factor; }
            set { this.lProduct_Factor = value; }
        }
        //public decimal Product_weight
        //{
        //    get { return this.lProduct_weight; }
        //    set { this.lProduct_weight = value; }
        //}
        public decimal Product_Peso_gr
        {
            get { return this.lProduct_Peso_gr; }
            set { this.lProduct_Peso_gr = value; }
        }

        public int id_UnitOfMeasure
        {
            get { return this.lid_UnitOfMeasure; }
            set { this.lid_UnitOfMeasure = value; }
        }

        
        public int Product_weightMeasure
        {
            get { return this.lProduct_weightMeasure; }
            set { this.lProduct_weightMeasure = value; }
        }
        public decimal Product_High
        {
            get { return this.lProduct_High; }
            set { this.lProduct_High = value; }
        }
        public int Product_HighMeasure
        {
            get { return this.lProduct_HighMeasure; }
            set { this.lProduct_HighMeasure = value; }
        }
        public decimal Product_width
        {
            get { return this.lProduct_width; }
            set { this.lProduct_width = value; }
        }
        public int Product_widthMeasure
        {
            get { return this.lProduct_widthMeasure; }
            set { this.lProduct_widthMeasure = value; }
        }
        public decimal Product_PriceList
        {
            get { return this.lProduct_PriceList; }
            set { this.lProduct_PriceList = value; }
        }
        public decimal Product_PriceReSale
        {
            get { return this.lProduct_PriceReSale; }
            set { this.lProduct_PriceReSale = value; }
        }
        public string Produc_Caracteristicas
        {
            get { return this.lProduc_Caracteristicas; }
            set { this.lProduc_Caracteristicas = value; }
        }
        public string Produc_Beneficios
        {
            get { return this.lProduc_Beneficios; }
            set { this.lProduc_Beneficios = value; }
        }
        public bool Product_Status
        {
            get { return this.lProduct_Status; }
            set { this.lProduct_Status = value; }
        }
        public string Product_CreateBy
        {
            get { return this.lProduct_CreateBy; }
            set { this.lProduct_CreateBy = value; }
        }
        public DateTime Product_DateBy
        {
            get { return this.lProduct_DateBy; }
            set { this.lProduct_DateBy = value; }
        }
        public string Product_ModiBy
        {
            get { return this.lProduct_ModiBy; }
            set { this.lProduct_ModiBy = value; }
        }
        public DateTime Product_DateModiby
        {
            get { return this.lProduct_DateModiby; }
            set { this.lProduct_DateModiby = value; }
        }

        public string English_Alias
        {
            get { return lEnglish_Alias; }
            set { lEnglish_Alias = value; }
        }
    }
}