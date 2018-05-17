using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase               : EMechanicalActivity
    /// Creada Por          : Ing. Carlos Alberto Hernandez R
    /// Fecha de Creación   : 02/09/2009
    /// Requerimiento No    : <>
    /// Descripcion         : Define los atributos y propiedades Publicas de la Clase MechanicalActivity
    /// Modificacion        : 28/07/2010 Se coloca comentario de clase , no existía y Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
    /// 
    public class EMechanicalActivity
    {
        public EMechanicalActivity()
        {
    
        //Se define el constructor por defecto
    
       }
        private int lMechanicalActivity_id;
        private string lidPlanning;
        private string lMechanicalActivityDescription;
        private string lMechanicalActivityCreateBy;
        private DateTime lMechanicalActivityDateBy;
        private string lMechanicalActivityModyBy;
        private DateTime lMechanicalActivityDateModyBy;

        public int MechanicalActivity_id
        {
            get { return this.lMechanicalActivity_id; }
            set { this.lMechanicalActivity_id = value; }

      }
        public string idPlanning
        {
            get { return this.lidPlanning; }
            set { this.lidPlanning = value; }

        }


        public string MechanicalActivityDescription
        {
            get { return this.lMechanicalActivityDescription; }
            set { this.lMechanicalActivityDescription = value; }

        }

        public string MechanicalActivityCreateBy
        {
            get { return this.lMechanicalActivityCreateBy; }
            set { this.lMechanicalActivityCreateBy = value; }

        }

        public DateTime MechanicalActivityDateBy
        {
            get { return this.lMechanicalActivityDateBy; }
            set { this.lMechanicalActivityDateBy = value; }

        }

        public string MechanicalActivityModyBy
        {
            get { return this.lMechanicalActivityModyBy; }
            set { this.lMechanicalActivityModyBy = value; }

        }

        public DateTime MechanicalActivityDateModyBy
        {
            get { return this.lMechanicalActivityDateModyBy; }
            set { this.lMechanicalActivityDateModyBy = value; }

        }


    }
}
