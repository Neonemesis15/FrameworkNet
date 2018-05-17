using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{  
    /// <summary>
    /// Clase:              EBrand
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  17/07/2009
    /// ModiBy:Magaly Jiménez , se adiciona campo Company_id
    /// Mdoydateby: 17/08/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Brand
    ///                     permite al administrador del sistema gestionar las Marcas, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Marcas
    /// Modificación :      Ing. Mauricio Ortiz 30/11/2010 Se adiciona id_ProductCategory y id_Subcategory de acuerdo a 
    ///                     requerimiento realizado por Carlos Hernandez .  
  /// Modificación :      Ing. Magaly Jiménez 01/12/2010 quita id_Subcategory de acuerdo a 
///                    
    /// </summary>

    public class EBrand
    {
        public EBrand()
        {
            //Se define el constructor por defecto
        }

        private int lid_Brand;
        private int lCompany_id;
        private string lid_ProductCategory;
        private string lName_Brand;
        private bool lBrand_Status;
        private string lBrand_CreateBy;
        private DateTime lBrand_DateBy;
        private string lBrand_ModiBy;
        private DateTime lBrand_DateModiBy;

        public int id_Brand
        {
            get { return this.lid_Brand; }
            set { this.lid_Brand = value; }
        }
        /// <summary>
        /// Modificiacón: se agrega campo  Company_id.
        /// 17/08/Magaly jiménez
        /// </summary>
        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }

        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }

        public string Name_Brand
        {
            get { return this.lName_Brand; }
            set { this.lName_Brand = value; }
        }

        public bool Brand_Status
        {
            get { return this.lBrand_Status; }
            set { this.lBrand_Status = value; }
        }

        public string Brand_CreateBy
        {
            get { return this.lBrand_CreateBy; }
            set { this.lBrand_CreateBy = value; }
        }

        public DateTime Brand_DateBy
        {
            get { return this.lBrand_DateBy; }
            set { this.lBrand_DateBy = value; }
        }

        public string Brand_ModiBy
        {
            get { return this.lBrand_ModiBy; }
            set { this.lBrand_ModiBy = value; }
        }

        public DateTime Brand_DateModiBy
        {
            get { return this.lBrand_DateModiBy; }
            set { this.lBrand_DateModiBy = value; }
        }
    }
}