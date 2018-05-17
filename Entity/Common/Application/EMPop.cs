using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{   
    public class EMPop
    {
        /// <summary>
        /// Clase:              EMPOP
        /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
        /// Fecha de Creación:  12/05/2009
        /// Requerimientos No:  «Functional» SIGE-ARF-040 Gestion de Material POP
        ///                     «Functional» SIGE-ARF-089 Crear material POP 
        ///                     «Functional» SIGE-ARF-090 Consultar Material POP 
        ///                     «Functional» SIGE-ARF-091 Actualizar Material POP
        ///                     «Functional» SIGE-ARF-092 Deshabilitar Material POP
        /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase MPOP
        ///                     permite, crear, actualizar e inactivar el material POP que Lucky usa en 
        ///                     sus respectivas campañas.
        /// Actualización:      Se agrega atributo lidtipoMa para definir el tipo de material POP
        ///                     
        /// </summary>
        
        public EMPop()
        {

            //Se define el constructor por defecto

        }

        private int lidMPointOfPurchase;
        private string lidtipoMa; 
        private string lPOPname;
        private string lPOPdescription;
        private bool lStatus;
        private string lMPointOfPurchaseCreateBy;
        private DateTime lMPointOfPurchaseDateBy;
        private string lMPointOfPurchaseModiBy;
        private DateTime lMPointOfPurchaseDateModiBy;

        public int idMPointOfPurchase
        {
            get { return this.lidMPointOfPurchase; }
            set { this.lidMPointOfPurchase = value; }
        }

        public string idtipoMa
        {
            get { return this.lidtipoMa; }
            set { this.lidtipoMa = value; }
        }

        public string POPname
        {
            get { return this.lPOPname; }
            set { this.lPOPname = value; }
        }

        public string POPdescription
        {
            get { return this.lPOPdescription; }
            set { this.lPOPdescription = value; }
        }

        public bool Status
        {
            get { return this.lStatus; }
            set { this.lStatus = value; }
        }

        public string MPointOfPurchaseCreateBy
        {
            get { return this.lMPointOfPurchaseCreateBy; }
            set { this.lMPointOfPurchaseCreateBy = value; }
        }

        public DateTime MPointOfPurchaseDateBy
        {
            get { return this.lMPointOfPurchaseDateBy; }
            set { this.lMPointOfPurchaseDateBy = value; }
        }

        public string MPointOfPurchaseModiBy
        {
            get { return this.lMPointOfPurchaseModiBy; }
            set { this.lMPointOfPurchaseModiBy = value; }
        }

        public DateTime MPointOfPurchaseDateModiBy
        {
            get { return this.lMPointOfPurchaseDateModiBy; }
            set { this.lMPointOfPurchaseDateModiBy = value; }
        }
    }
}
