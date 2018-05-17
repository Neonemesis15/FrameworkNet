using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ESectlr
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  16/10/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Sector
    ///                     permite al administrador del sistema gestionar las sectores, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar product_Family.
    /// Modificación. se agregan campos de categoria y subcategoria
    /// 16/11/2010 Magaly Jiménez.
    /// </summary>
    public class EProduct_Family
    {
        public EProduct_Family()
        {
            //Se define el constructor por defecto
        }
        private string lid_ProductFamily;
        private string lid_ProductCategory;
        private long lid_Subcategory;
        private int lid_Brand;
        private int lid_SubBrand ;  
        private string lname_Family;
        private string lfamily_Descripcion;
        private decimal lfamily_Peso;
        private bool lfamily_status;
        private string lfamily_CreateBy;
        private DateTime lfamily_DateBy;
        private string lfamily_ModyBy;
        private DateTime lfamily_DateModiBy;

        public string id_ProductFamily
        {
            get { return this.lid_ProductFamily; }
            set { this.lid_ProductFamily = value; }
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
        public int id_SubBrand
        {
            get { return this.lid_SubBrand; }
            set { this.lid_SubBrand = value; }
        }
    
        public string name_Family
        {
            get { return this.lname_Family; }
            set { this.lname_Family = value; }
        }
        public string family_Descripcion
        {
            get { return this.lfamily_Descripcion; }
            set { this.lfamily_Descripcion = value; }
        }

        public decimal family_Peso
        {
            get { return this.lfamily_Peso; }
            set { this.lfamily_Peso = value; }
        }
        
        public bool family_status
        {
            get { return this.lfamily_status; }
            set { this.lfamily_status = value; }
        }
        public string family_CreateBy
        {
            get { return this.lfamily_CreateBy; }
            set { this.lfamily_CreateBy = value; }
        }
        public DateTime family_DateBy
        {
            get { return this.lfamily_DateBy; }
            set { this.lfamily_DateBy = value; }
        }
        public string family_ModyBy
        {
            get { return this.lfamily_ModyBy; }
            set { this.lfamily_ModyBy = value; }
        }
        public DateTime family_DateModiBy
        {
            get { return this.lfamily_DateModiBy; }
            set { this.lfamily_DateModiBy = value; }
        }
  
    }
}
