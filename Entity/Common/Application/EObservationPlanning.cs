using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase           : EObservationPlanning
    /// Creada Por      : Ing. Carlos Alberto Hernandez R
    /// Fecha Creación  : 07/07/2009
    /// Requerimiento No  <>
    /// Descripcion     : Defines los atributos y propiedades publicas para la clase ObservationPlanning
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>

    public class EObservationPlanning
    {
        public EObservationPlanning() { 
        
        //Se define el constructor por defecto
        
        }
        private int lid_obsplanning;
        private string lid_planning;
        private string lobsDescription;
        private string lobsCrerateBy;
        private DateTime lobsDateBy;
        private string lobsModiBy;
        private DateTime lobsDateModiBy;



        public int id_obsplanning {
            get {return this.lid_obsplanning;}
            set { this.lid_obsplanning = value; }
        
        
        
        }

        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }



        }

        public string obsDescription
        {
            get { return this.lobsDescription; }
            set { this.lobsDescription = value; }



        }

        public string obsCrerateBy
        {
            get { return this.lobsCrerateBy; }
            set { this.lobsCrerateBy = value; }



        }

        public DateTime obsDateBy
        {
            get { return this.lobsDateBy; }
            set { this.lobsDateBy = value; }



        }

        public string obsModiBy
        {
            get { return this.lobsModiBy; }
            set { this.lobsModiBy = value; }



        }

        public DateTime obsDateModiBy
        {
            get { return this.lobsDateModiBy; }
            set { this.lobsDateModiBy = value; }



        }


    }
}
