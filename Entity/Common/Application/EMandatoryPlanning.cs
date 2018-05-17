using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EMandatoryPlanning
    {
        /// <summary>
        /// Clase               : EMandatoryPlanning
        /// Creada Por          : ing.Carlos Alberto Hernandez Rincon
        /// Fecha de Creacion   : 08/07/2009
        /// Descripcion         : Define los atributos y propiedades de los mismos para la clase MandatoryPlanning
        /// Requerimiento No    : <>
        /// Modificacion        : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
        /// </summary>
        public EMandatoryPlanning() { 
        
        //Se define el contructor por defecto
        
        }
        private int lid_Mandtoryplanning;
        private string lid_planning;
        private string lMandtoryDescription;
        private string lMandtoryCreateBy;
        private DateTime lMandtoryDateBy;
        private string lMandtoryModiBy;
        private DateTime lMandtoryDateModiBy;

        public int id_Mandtoryplanning {
            get { return this.lid_Mandtoryplanning; }
            set { this.lid_Mandtoryplanning = value;
            }
        
        
        }

        public string id_planning
        {
            get { return this.lid_planning; }
            set
            {
                this.lid_planning = value;
            }


        }

        public string MandtoryDescription {
            get { return this.lMandtoryDescription; }
            set { this.lMandtoryDescription = value; }
        
        
        
        }

        public string MandtoryCreateBy
        {
            get { return this.lMandtoryCreateBy; }
            set { this.lMandtoryCreateBy = value; }



        }

        public DateTime MandtoryDateBy
        {
            get { return this.lMandtoryDateBy; }
            set { this.lMandtoryDateBy = value; }



        }

        public string MandtoryModiBy
        {
            get { return this.lMandtoryModiBy; }
            set { this.lMandtoryModiBy = value; }



        }

        public DateTime MandtoryDateModiBy
        {
            get { return this.lMandtoryDateModiBy; }
            set { this.lMandtoryDateModiBy = value; }



        }

    }
}
