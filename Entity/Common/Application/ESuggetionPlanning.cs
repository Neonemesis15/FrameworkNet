using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class ESuggetionPlanning
    {
        /// <summary>
        /// Clase               : ESuggetionPlanning
        /// Creada Por          : Ing. Carlos Alberto Hernandez Rincon
        /// Fecha de Creaciòn   : 07/07/2009
        /// Requerimiento No    : <>
        /// Descripcion         : Estable los atributos y propiedades de los mismos para SuggetionPlanning
        /// Modificacion        : 29/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
        /// </summary>
        public ESuggetionPlanning()
        {

            //Se define el constructor por defecto

        }

        private int lid_suggplanning;
        private string lidplanning;
        private string lsuggDescription;
        private string lsuggCreateBy;
        private DateTime lsuggDateBy;
        private string lsuggModiBy;
        private DateTime lsuggDateModiBy;

        public int id_suggplanning
        {
            get { return this.lid_suggplanning; }
            set { this.lid_suggplanning = value; }
        }

        public string idplanning
        {
            get { return this.lidplanning; }
            set { this.lidplanning = value; }
        }

        public string suggDescription
        {
            get { return this.lsuggDescription; }
            set { this.lsuggDescription = value; }
        }

        public string suggCreateBy
        {
            get { return this.lsuggCreateBy; }
            set { this.lsuggCreateBy = value; }
        }

        public DateTime suggDateBy
        {
            get { return this.lsuggDateBy; }
            set { this.lsuggDateBy = value; }



        }

        public string suggModiBy
        {
            get { return this.lsuggModiBy; }
            set { this.lsuggModiBy = value; }



        }

        public DateTime suggDateModiBy
        {
            get { return this.lsuggDateModiBy; }
            set { this.lsuggDateModiBy = value; }



        }


    }
}
