using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EObjetivesPlanning
    /// Creada Por: Ing. Carlos Alberto Hernandez
    /// Fecha: 08/07/2009
    /// Descripcion: Define los atributos y propiedades de los mismos para la clase ObjetivesPlanning
    /// Requerimiento No<>
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>

    public class EObjetivesPlanning
    {
        public EObjetivesPlanning()
        {
            //Se define el contructor por defecto
        }
        private int lid_objPlanning;
        private string lid_Planning;
        private string lobjPlaDescription;
        private string lobjPlaCreateBy;
        private DateTime lobjPlaDateBy;
        private string lobjPlaModiBy;
        private DateTime lobjPlaDatemodiBy;

        public int  idobjPlanning{

            get { return this.lid_objPlanning; }
            set { this.lid_objPlanning = value;
            }
    
    
    
        }

        public string id_Planning
        {

            get { return this.lid_Planning; }
            set
            {
                this.lid_Planning = value;
            }



        }

        public string objPlaDescription
        {

            get { return this.lobjPlaDescription; }
            set
            {
                this.lobjPlaDescription = value;
            }



        }
        public string objPlaCreateBy
        {

            get { return this.lobjPlaCreateBy; }
            set
            {
                this.lobjPlaCreateBy = value;
            }



        }

        public DateTime objPlaDateBy {
            get { return this.lobjPlaDateBy; }
            set { this.lobjPlaDateBy = value; }
        
        
        
        }

        public string objPlaModiBy
        {

            get { return this.lobjPlaModiBy; }
            set
            {
                this.lobjPlaModiBy = value;
            }



        }

        public DateTime objPlaDatemodiBy
        {
            get { return this.lobjPlaDatemodiBy; }
            set { this.lobjPlaDatemodiBy = value; }



        }
    }
    
}
