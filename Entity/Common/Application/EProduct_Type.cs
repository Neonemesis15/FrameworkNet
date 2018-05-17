using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EProduct_Type
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  17/07/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Product_Type
    ///                     permite al administrador del sistema gestionar las categorias de producto, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar categorias de producto.
    /// Modificación: Joseph Gonzales
    /// Fecha de Modificación: 10/08/2011
    /// Descripción: Se agrego el atributo lProduct_Category_company_id y lProduct_Category_company_name.
    /// </summary>

    public class EProduct_Type
    {
        public EProduct_Type()
        {
            //Se define el constructor por defecto
        }
        /// <summary>
        /// se agrega campo de group Categoy. 
        /// 03/03/2011 Magaly Jiménez
        /// </summary>
        private string lid_ProductCategory;
        private string lProduct_Category;
        private string lGroup_Category;
        private bool lProduct_Category_Status;
        private string lProduct_Category_company_id;
        private string lProduct_Category_company_name;
        private string lProduct_Category_CreateBy;
        private DateTime lProduct_Category_DateBy;
        private string lProduct_Category_ModiBy;
        private DateTime lProduct_Category_DateModiBy;

        public string id_Product_Category
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }

        public string Product_Category
        {
            get { return this.lProduct_Category; }
            set { this.lProduct_Category = value; }
        }
        public string Group_Category
        {
            get { return this.lGroup_Category; }
            set { this.lGroup_Category = value; }
        }
        /// <summary>
        /// Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
        /// 18/08/2010 Magaly Jiménez
        /// </summary> 

        public bool Product_Category_Status
        {
            get { return this.lProduct_Category_Status; }
            set { this.lProduct_Category_Status = value; }
        }

        public string Product_Category_company_id 
        {
            get { return this.lProduct_Category_company_id; }
            set { this.lProduct_Category_company_id = value; }
        }
         
        public string Product_Category_company_name
        {
            get { return this.lProduct_Category_company_name; }
            set { this.lProduct_Category_company_name = value; }
        }

        public string Product_Category_CreateBy
        {
            get { return this.lProduct_Category_CreateBy; }
            set { this.lProduct_Category_CreateBy = value; }
        }
         
        public DateTime Product_Category_DateBy
        {
            get { return this.lProduct_Category_DateBy; }
            set { this.lProduct_Category_DateBy = value; }
        }

        public string Product_Category_ModiBy
        {
            get { return this.lProduct_Category_ModiBy; }
            set { this.lProduct_Category_ModiBy = value; }
        }

        public DateTime Product_Category_DateModiBy
        {
            get { return this.lProduct_Category_DateModiBy; }
            set { this.lProduct_Category_DateModiBy = value; }
        }
    }
}