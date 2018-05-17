using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EAdditionalItems__Management
    /// Creada Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación; 07/09/2009
    /// Requerimiento <>
    /// Descripcion: Define los atributos y propiedades de los mismos para la Clase AdditionalItems__Management  
    /// Modificacion: 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>


    public class EAdditionalItems__Management
    {
        public EAdditionalItems__Management()
        { 
        //Se define el Constructor por Defecto
        
        
        }
         //Se definen los Atributos
        private int liditemadi;
        private int lidcod_Point;
        private string lidplanning;
        private string litemadiCreateBy;
        private DateTime litemadiDateBy;
        private string litemadModiBy;
        private DateTime litemadDateModiBy;

        //Se definen las Propiedades de los Atributos


        public int iditemadi {
            get { return this.liditemadi; }
            set { this.liditemadi = value; }
        
        
        
        }

        public int idcod_Point
        {
            get { return this.lidcod_Point; }
            set { this.lidcod_Point = value; }



        }

        public string idplanning
        {
            get { return this.lidplanning; }
            set { this.lidplanning = value; }



        }

        public string itemadiCreateBy {
            get { return this.litemadiCreateBy; }
            set { this.litemadiCreateBy = value; }
        
        
        }

        public DateTime itemadiDateBy {
            get { return this.litemadiDateBy; }
            set { this.litemadiDateBy = value; }
        
          
        
        }

        public string itemadModiBy
        {
            get { return this.litemadModiBy; }
            set { this.litemadModiBy = value; }


        }

        public DateTime itemadDateModiBy
        {
            get { return this.litemadDateModiBy; }
            set { this.litemadDateModiBy = value; }



        }

    }
}
