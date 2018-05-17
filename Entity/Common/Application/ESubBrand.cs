using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ESubBrand
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  31/08/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase SubBrand
    ///                     permite al administrador del sistema gestionar las subMarcas, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar submarcas.
    /// </summary>

    public class ESubBrand
    {
        public ESubBrand()
        {
            //Se define el constructor por defecto
        }

        private int lid_SubBrand;
        private string lName_SubBrand;
        private int lid_Brand;
        private bool lSubBrand_Status;
        private string lSubBrand_CreateBy;
        private DateTime lSubBrand_DateBy;
        private string lSubBrand_ModiBy;
        private DateTime lSubBrand_DateModiBy;

        /// <summary>
        /// Modificación: se cambia tipo de dato de varchar a int al campo id_SubBrand.
        /// 17/08/20210 Magaly Jiménez
        /// </summary>
        public int id_SubBrand
        {
            get { return this.lid_SubBrand; }
            set { this.lid_SubBrand = value; }
        }
        public string Name_SubBrand
        {
            get { return this.lName_SubBrand; }
            set { this.lName_SubBrand = value; }
        }
        public int id_Brand
        {
            get { return this.lid_Brand; }
            set { this.lid_Brand = value; }
        }
        public bool SubBrand_Status
        {
            get { return this.lSubBrand_Status; }
            set { this.lSubBrand_Status = value; }
        }
        public string SubBrand_CreateBy
        {
            get { return this.lSubBrand_CreateBy; }
            set { this.lSubBrand_CreateBy = value; }
        }
        public DateTime SubBrand_DateBy
        {
            get { return this.lSubBrand_DateBy; }
            set { this.lSubBrand_DateBy = value; }
        }
        public string SubBrand_ModiBy
        {
            get { return this.lSubBrand_ModiBy; }
            set { this.lSubBrand_ModiBy = value; }
        }
        public DateTime SubBrand_DateModiBy
        {
            get { return this.lSubBrand_DateModiBy; }
            set { this.lSubBrand_DateModiBy = value; }
        }
    }
}
        