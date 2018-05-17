using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ESubCategoria
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  19/08/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase SubCategoria
    ///                     permite al administrador del sistema gestionar las subCategorias, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar SubCategorias.
    /// </summary>


    public class ESubCategoria
    {
        public ESubCategoria()
        {
            //Se define el constructor por defecto
        }

        private long lid_Subcategory;
        private string lid_ProductCategory;
        private string lName_Subcategory;
        private bool lSubcategory_Status;
        private string lSubcategory_CreateBy;
        private DateTime lSubcategory_DateBy;
        private string lSubcategory_ModiBy;
        private DateTime lSubcategory_DateModiBy;



        public long id_Subcategory
        {
            get { return this.lid_Subcategory; }
            set{this.lid_Subcategory=value;}
        }

        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory;}
            set { this.lid_ProductCategory = value; }
        }

        public string Name_Subcategory
        {
            get { return this.lName_Subcategory;}
            set { this.lName_Subcategory = value; }
        }

        public bool Subcategory_Status
        {
            get { return this.lSubcategory_Status; }
            set { this.lSubcategory_Status = value; }
        }
        public string Subcategory_CreateBy
        {
            get { return this.lSubcategory_CreateBy; }
            set { this.lSubcategory_CreateBy = value; }
        }
        public DateTime Subcategory_DateBy
        {
            get { return this.lSubcategory_DateBy; }
            set { this.lSubcategory_DateBy = value; }
        }
        public string Subcategory_ModiBy
        {
            get { return this.lSubcategory_ModiBy; }
            set { this.lSubcategory_ModiBy = value; }
        }
        public DateTime Subcategory_DateModiBy
        {
            get { return this.lSubcategory_DateModiBy; }
            set { this.lSubcategory_DateModiBy = value; }
        }

    }
}
