using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{ /// <summary>
    /// Clase:              EAD_ProductosAncla
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  07/09/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Productos Ancla
    ///                     permite al administrador del sistema gestionar los productos ancla, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Productos Ancla.
    /// </summary>
    public class EAD_ProductosAncla
    {
        public EAD_ProductosAncla()
        {
            //Se define el constructor por defecto
        }

        private long lid_pancla;
        private int lCompany_id;
        private string lid_ProductCategory;
        private long lid_Subcategory;
        private string lcod_Product;
        private long lcod_Oficina;
        private bool lpancla_Status;
        private string lpancla_CreateBy;
        private DateTime lpancla_DateBy;
        private string lpancla_ModiBy;
        private DateTime lpancla_DateModiBy;

        public long id_pancla
        {
            get { return this.lid_pancla; }
            set { this.lid_pancla = value; }
        }

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

        public long id_Subcategory
        {
            get { return this.lid_Subcategory; }
            set { this.lid_Subcategory = value; }
        }
        public string cod_Product
        {
            get { return this.lcod_Product; }
            set { this.lcod_Product = value; }
        }

        public long cod_Oficina
        {
            get { return this.lcod_Oficina; }
            set { this.lcod_Oficina = value; }
        }
        public bool pancla_Status
        {
            get { return this.lpancla_Status; }
            set { this.lpancla_Status = value; }
        }
        public string pancla_CreateBy
        {
            get { return this.lpancla_CreateBy; }
            set { this.lpancla_CreateBy = value; }
        }
        public DateTime pancla_DateBy
        {
            get { return this.lpancla_DateBy; }
            set { this.lpancla_DateBy = value; }
        }
        public string pancla_ModiBy
        {
            get { return this.lpancla_ModiBy; }
            set { this.lpancla_ModiBy = value; }
        }
        public DateTime pancla_DateModiBy
        {
            get { return this.lpancla_DateModiBy; }
            set { this.lpancla_DateModiBy = value; }
        }
    }
}
