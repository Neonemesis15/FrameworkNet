using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EProduct_Presentations
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  27/08/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Product_Presentations
    ///                     permite al administrador del sistema gestionar las Presentaciones de producto, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Presentaciones de producto.
    ///                     Modificación: se agregan 3 campos  lid_ProductCategory, lid_Subcategory y  lid_Brand y al campo id_productPresentation se cambia tipo de dato de string por long.
    ///                     23/08/2010  por: Magaly Jiménez
    ///                     30/08/2010 se agrega campo Empaquetamiento y Unidad_Empaque. Ing. Mauricio Ortiz
    /// </summary>
    
    public class EProduct_Presentations
    {
        public EProduct_Presentations()
        {
            // Se define el constructor por defecto
        }
       
        private string lid_ProductPresentation;
        private string lid_ProductCategory;
        private long  lid_Subcategory;
        private int lid_Brand;
        private string lEmpaquetamiento;
        private string lUnidad_Empaque;
        private string lProductPresentationName;
        private decimal lProductPresentation_Neto;
        private int lid_UnitOfMeasure;
        private bool lProductPresentation_Status;
        private string lProductPresentation_CreateBy;
        private DateTime lProductPresentation_DateBy;
        private string lProductPresentation_ModiBy;
        private DateTime lProductPresentation_DateModiBy;

        public string id_ProductPresentation
        {
            get { return this.lid_ProductPresentation; }
            set { this.lid_ProductPresentation = value; }
        }
        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }
        public long id_Subcategory
        {
            get { return this.lid_Subcategory; }
            set { this.lid_Subcategory = value; }
        }
        public int id_Brand
        {
            get { return this.lid_Brand; }
            set { this.lid_Brand = value; }
        }

        public string Empaquetamiento
        
        {
            get { return this.lEmpaquetamiento; }
            set { this.lEmpaquetamiento = value; }
        }
        public string Unidad_Empaque
        {
            get { return this.lUnidad_Empaque; }
            set { this.lUnidad_Empaque = value; }
        }
        public string ProductPresentationName
        {
            get { return this.lProductPresentationName; }
            set { this.lProductPresentationName = value; }
        }

        public decimal ProductPresentation_Neto
        {
            get { return this.lProductPresentation_Neto; }
            set { this.lProductPresentation_Neto = value; }
        }
        public int id_UnitOfMeasure
        {
            get { return this.lid_UnitOfMeasure; }
            set { this.lid_UnitOfMeasure = value; }
        }

        public bool ProductPresentation_Status
        {
            get { return this.lProductPresentation_Status; }
            set { this.lProductPresentation_Status = value; }
        }
        public string ProductPresentation_CreateBy
        {
            get { return this.lProductPresentation_CreateBy; }
            set { this.lProductPresentation_CreateBy = value; }
        }
        public DateTime ProductPresentation_DateBy
        {
            get { return this.lProductPresentation_DateBy; }
            set { this.lProductPresentation_DateBy = value; }
        }
        public string ProductPresentation_ModiBy
        {
            get { return this.lProductPresentation_ModiBy; }
            set { this.lProductPresentation_ModiBy = value; }
        }
        public DateTime ProductPresentation_DateModiBy
        {
            get { return this.lProductPresentation_DateModiBy; }
            set { this.lProductPresentation_DateModiBy = value; }
        }
    }
}
        
