using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:ELearnningPlanning
    /// Creada Por          : Ing. Carlos Alberto Hernandez R
    /// Fecha de Creación   : 07/07/2009
    /// Requerimiento No    : <>
    /// Descripcion         : Define los atributos y propiedades Publicas de la Clase LearnningPlanning
    /// Modificacion        : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
    public class ELearnningPlanning
    {
        public ELearnningPlanning() { 
        
        //Se define el contructor por defecto
        
        }

        private int lidlearngplanning;
        private string lidplanning;
        private string llearngDescription;
        private string llearngCreateBy;
        private DateTime llearngDateBy;
        private string llearngModiBy;
        private DateTime llearngDateModiBy;


        public int idlearngplanning {
            get { return this.lidlearngplanning; }
            set { this.lidlearngplanning = value; }
        
        
        
        }

        public string idplanning
        {
            get { return this.lidplanning; }
            set { this.lidplanning = value; }



        }

        public string learngDescription
        {
            get { return this.llearngDescription; }
            set { this.llearngDescription = value; }



        }

        public string learngCreateBy
        {
            get { return this.llearngCreateBy; }
            set { this.llearngCreateBy = value; }



        }

        public DateTime learngDateBy
        {
            get { return this.llearngDateBy; }
            set { this.llearngDateBy = value; }



        }

        public string learngModiBy
        {
            get { return this.llearngModiBy; }
            set { this.llearngModiBy = value; }



        }

        public DateTime learngDateModiBy
        {
            get { return this.llearngDateModiBy; }
            set { this.llearngDateModiBy = value; }



        }


  


    }
}
