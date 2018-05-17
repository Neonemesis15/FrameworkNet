using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EProduct_Tipo
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  04/09/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Product_Tipo
    ///                     permite al administrador del sistema gestionar los tipos de producto, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Tipos de producto.
    /// </summary>

    public class EProduct_Tipo
    {
        public EProduct_Tipo()
        {
            // se define el contructor por defecto
        }

        private string lid_ProductTipo;
        private string lProduct_Tipo;
        private string lid_ProductCategory;
        private bool lProductTipo_Status;
        private string lProductTipo_CreateBy;
        private DateTime lProductTipo_DateBy;
        private string lProductTipo_ModiBy;
        private DateTime lProductTipo_DateModiBy;

        public string id_ProductTipo
        {
            get { return this.lid_ProductTipo; }
            set { this.lid_ProductTipo = value; }
        }

        public string Product_Tipo
        {
            get { return this.lProduct_Tipo; }
            set { this.lProduct_Tipo = value; }
        }

        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }

        public bool ProductTipo_Status
        {
            get { return this.lProductTipo_Status; }
            set { this.lProductTipo_Status = value; }
        }

        public string ProductTipo_CreateBy
        {
            get { return this.lProductTipo_CreateBy; }
            set { this.lProductTipo_CreateBy = value; }
        }

        public DateTime ProductTipo_DateBy
        {
            get { return this.lProductTipo_DateBy; }
            set { this.lProductTipo_DateBy = value; }
        }

        public string ProductTipo_ModiBy
        {
            get { return this.lProductTipo_ModiBy; }
            set { this.lProductTipo_ModiBy = value; }
        }

        public DateTime ProductTipo_DateModiBy
        {
            get { return this.lProductTipo_DateModiBy; }
            set { this.lProductTipo_DateModiBy = value; }
        }
    }
}