using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class ECity
    {        
        /// <summary>
        /// Clase:              ECity
        /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
        /// Fecha de Creación:  15/06/2009
        /// Requerimientos No:  «Functional» SIGE-ARF-130 Gestionar Division Politica Ciudad/Provincia
        ///                     «Functional» SIGE-ARF-138 Crear Ciudad/Provincia
        ///                     «Functional» SIGE-ARF-144 Consultar Ciudad/Provincia
        ///                     «Functional» SIGE-ARF-145 Actualizar Ciudad/Provincia
        ///                     «Functional» SIGE-ARF-146 Inactivar Ciudad/Provincia
        /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase City
        ///                     Este caso de uso permite al administrador del sistema gestionar las 
        ///                     Ciudades, por medio de las operaciones de Crear, Consultar, Actualizar e Inactivar Ciudades.
        /// </summary>
       

        public ECity() { 
        
        //Define el Constructor por defecto
        
        
        }
        private string lcodCity;
        private string lcoddpto;
        private string lcodcountry;
        private string lNameCity;
        private bool lCityStatus;
        private string lCityCreateBy;
        private DateTime lCityDateBy;
        private string lCityModiBy;
        private DateTime lCityDateModiBy;

        //Se definen las propiedades

        public string codCity {
            get { return this.lcodCity; }
            set { this.lcodCity = value; }
        
        }

        public string coddpto
        {
            get { return this.lcoddpto; }
            set { this.lcoddpto = value; }

        }
        public string codcountry
        {
            get { return this.lcodcountry; }
            set { this.lcodcountry = value; }

        }

        public string NameCity
        {
            get { return this.lNameCity; }
            set { this.lNameCity = value; }

        }

        public bool CityStatus
        {
            get { return this.lCityStatus; }
            set { this.lCityStatus = value; }

        }

        public string CityCreateBy
        {
            get { return this.lCityCreateBy; }
            set { this.lCityCreateBy = value; }

        }

        public DateTime CityDateBy
        {
            get { return this.lCityDateBy; }
            set { this.lCityDateBy = value; }

        }

        public string CityModiBy
        {
            get { return this.lCityModiBy; }
            set { this.lCityModiBy = value; }

        }

        public DateTime CityDateModiBy
        {
            get { return this.lCityDateModiBy; }
            set { this.lCityDateModiBy = value; }

        }





    }
}
