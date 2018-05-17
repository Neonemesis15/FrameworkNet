using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EAlmacenDetalle_Planning
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  10/11/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase AlmacenDetalle_Planning
    ///                     permite al administrador del sistema gestionar la información recopilada en calle en cuanto 
    ///                     a los formatos de levantamiento de informacion de la actividad mediante las operaciones de 
    ///                     de Crear, Consultar, Actualizar e Inactivar informacion recopilada en calle.
    /// Modificacion:       28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz

    /// </summary>
     
    public class EAlmacenDetalle_Planning
    {
        public EAlmacenDetalle_Planning()
        {
            // Se define el constructor por defecto
        }

        private int lid_almacenDetalle;
        private int lid_contenedor;
        private string lid_planning;
        private int lPerson_id;
        private int lid_MPOSPlanning;
        private int lid_ProductsPlanning;
        private DateTime ldato_Date;
        private string ldatoAlmacenado;
        private int lweekNo;
        private bool lalmacenDetalle_Status;
        private string lalmacenDetalle_CreateBy;
        private DateTime lalmacenDetalle_DateBy;
        private string lalmacenDetalle_ModiBy;
        private DateTime lalmacenDetalle_DateModiBy;

        public int id_almacenDetalle
        {
            get { return this.lid_almacenDetalle; }
            set { this.lid_almacenDetalle = value; }
        }

        public int id_contenedor
        {
            get { return this.lid_contenedor; }
            set { this.lid_contenedor = value; }
        }
        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }
        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
        }
        public int id_MPOSPlanning
        {
            get { return this.lid_MPOSPlanning; }
            set { this.lid_MPOSPlanning = value; }
        }
        public int id_ProductsPlanning
        {
            get { return this.lid_ProductsPlanning; }
            set { this.lid_ProductsPlanning = value; }
        }
        public DateTime dato_Date
        {
            get { return this.ldato_Date; }
            set { this.ldato_Date = value; }
        }
        public string datoAlmacenado
        {
            get { return this.ldatoAlmacenado; }
            set { this.ldatoAlmacenado = value; }
        }

        public int weekNo
        {
            get { return this.lweekNo; }
            set { this.lweekNo = value; }
        }

        public bool almacenDetalle_Status
        {
            get { return this.lalmacenDetalle_Status; }
            set { this.lalmacenDetalle_Status= value; }
        }

        public string almacenDetalle_CreateBy
        {
            get { return this.lalmacenDetalle_CreateBy; }
            set { this.lalmacenDetalle_CreateBy = value; }
        }
        public DateTime almacenDetalle_DateBy
        {
            get { return this.lalmacenDetalle_DateBy; }
            set { this.lalmacenDetalle_DateBy = value; }
        }
        public string almacenDetalle_ModiBy
        {
            get { return this.lalmacenDetalle_ModiBy; }
            set { this.lalmacenDetalle_ModiBy = value; }
        }
        public DateTime almacenDetalle_DateModiBy
        {
            get { return this.lalmacenDetalle_DateModiBy; }
            set { this.lalmacenDetalle_DateModiBy = value; }
        }
    }
}
