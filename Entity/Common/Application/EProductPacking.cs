using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    //CreateBy: Ing. Mauricio Ortiz
    //CreateDate: 29/05/2009
    //Description: Atributos Entidad Product_Packing
    //Requerimiento:

    /// <summary>
    /// Clase:              EProductPacking
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  29/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-025 Gestión de Productos
    ///                     «Functional» SIGE-ARF-127 Creacion Masiva de Productos
    ///                     «Functional» SIGE-ARF-081 Crear Productos
    ///                     «Functional» SIGE-ARF-082 Consultar Producto
    ///                     «Functional» SIGE-ARF-083 Actualizar Producto
    ///                     «Functional» SIGE-ARF-084 Deshabilitar Producto
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase ProductPacking
    ///                     permite al administrador del sistema gestionar los empaquetamientos de producto, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar empaquetamientos de Productos.
    /// </summary>
    /// 
    public class EProductPacking
    {
        public EProductPacking()
        {


            //Se define el constructor por defecto

        }
        private int lid_ProductPacking;
        private int iid_Product;
        private int lid_Packing;
        private decimal lPeso;
        private int lUnitsByPacking;
        private string lProductPackinUnitOfMeasure;
        private bool lProductPackingStatus;
        private string lProductPacking_CreateBy;
        private DateTime lProductPacking_DateBy;
        private string lProductPacking_ModiBy;
        private DateTime lProductPacking_DateModiby;

        public int id_ProductPacking
        {
            get { return this.lid_ProductPacking; }
            set { this.lid_ProductPacking = value; }
        }

        public int id_Product
        {
            get { return this.iid_Product; }
            set { this.iid_Product = value; }
        }

        public int id_Packing
        {
            get { return this.lid_Packing; }
            set { this.lid_Packing = value; }
        }

        public decimal Peso
        {
            get { return this.lPeso; }
            set { this.lPeso = value; }
        }

        public int UnitsByPacking
        {
            get { return this.lUnitsByPacking; }
            set { this.lUnitsByPacking = value; }
        }

        public string ProductPackinUnitOfMeasure
        {
            get { return this.lProductPackinUnitOfMeasure; }
            set { this.lProductPackinUnitOfMeasure = value; }
        }

        public bool ProductPackingStatus
        {
            get { return this.lProductPackingStatus; }
            set { this.lProductPackingStatus = value; }
        }

        public string ProductPacking_CreateBy
        {
            get { return this.lProductPacking_CreateBy; }
            set { this.lProductPacking_CreateBy = value; }
        }
        public DateTime ProductPacking_DateBy
        {
            get { return this.lProductPacking_DateBy; }
            set { this.lProductPacking_DateBy = value; }
        }
        public string ProductPacking_ModiBy
        {
            get { return this.lProductPacking_ModiBy; }
            set { this.lProductPacking_ModiBy = value; }
        }
        public DateTime ProductPacking_DateModiby
        {
            get { return this.lProductPacking_DateModiby; }
            set { this.lProductPacking_DateModiby = value; }
        }
    }
}
        