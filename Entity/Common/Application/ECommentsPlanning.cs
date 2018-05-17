using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class ECommentsPlanning
    {
        /// <summary>
        /// Clase: ECommentsPlanning
        /// Creada Por: Ing. Carlos Alberto Hernandez
        /// Fecha de Creación:08/07/2009
        /// Descripcion: Define los atyributos y propiedades de los mismos para la Clase CommentsPlanning
        /// Modificacion:       28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
        /// </summary>

        public ECommentsPlanning()
        {

            //Se define el constructor por defecto        
        }

        private int lid_coment;
        private string lid_planning;
        private string lcomentDescription;
        private string lcomenCreateBy;
        private DateTime lcomentDateBy;
        private string lcomentModiBy;
        private DateTime lcomentDateModiBy;

        public int idcoment
        {
            get { return this.lid_coment; }
            set { this.lid_coment = value; }
        }


        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }

        public string comentDescription
        {
            get { return this.lcomentDescription; }
            set { this.lcomentDescription = value; }
        }

        public string comenCreateBy
        {
            get { return this.lcomenCreateBy; }
            set { this.lcomenCreateBy = value; }
        }

        public DateTime comnDateBy
        {

            get { return this.lcomentDateBy; }
            set { this.lcomentDateBy = value; }
        }


        public string comentModiBy
        {
            get { return this.lcomentModiBy; }
            set { this.lcomentModiBy = value; }
        }

        public DateTime comentDateModiBy
        {
            get { return this.lcomentDateModiBy; }
            set { this.lcomentDateModiBy = value; }
        }
    }
}