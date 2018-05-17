using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase           : EMetaDataCaculation
    /// Creada Por      : Ing. Carlos Alberto Hernández Rincón
    /// Creada          : 05/02/2010
    /// Descripcion     : Define los atributos y propiedades de los mismos para la clase MetaDataCaculation
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
    /// 
    public class EMetaDataCaculation
    {
        public EMetaDataCaculation()
        {

            //Se define el constructor por defecto

        }
        /// <summary>
        /// Atributos
        /// </summary>
        private int lidDateCal;
        private string lidplanning;
        private int lidmetatabla;
        private int lobjectid;
        private int lcolumnid;
        private bool lDateCalStatus;
        private string lDateCalCreateBy;
        private DateTime lDateCalDateBy;
        private string lDateCalModyBy;
        private DateTime lDateCalDateModiBy;

        public int idDateCal
        {

            get { return this.lidDateCal; }
            set { this.lidDateCal = value; }
        }
        public string idplanning
        {

            get { return this.lidplanning; }
            set { this.lidplanning = value; }
        }

        public int idmetatabla
        {

            get { return this.lidmetatabla; }
            set { this.lidmetatabla = value; }


        }

        public int objectid
        {

            get { return this.lobjectid; }
            set { this.lobjectid = value; }


        }

        public int columnid
        {

            get { return this.lcolumnid; }
            set { this.lcolumnid = value; }


        }

        public bool DateCalStatus
        {

            get { return this.lDateCalStatus; }
            set { this.lDateCalStatus = value; }


        }

        public string DateCalCreateBy {
            get { return this.lDateCalCreateBy; }
            set { this.lDateCalCreateBy = value; }
        
        
        }

        public DateTime DateCalDateBy {
            get { return this.lDateCalDateBy; }
            set { this.lDateCalDateBy = value; }
        
        
        }

        public string DateCalModyBy
        {
            get { return this.lDateCalModyBy; }
            set { this.lDateCalModyBy = value; }


        }

        public DateTime DateCalDateModiBy
        {
            get { return this.lDateCalDateModiBy; }
            set { this.lDateCalDateModiBy = value; }


        }


    }

}