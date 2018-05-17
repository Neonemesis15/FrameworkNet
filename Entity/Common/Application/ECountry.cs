using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{    
    /// <summary>
    /// Clase:              ECountry
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  14/06/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-128 Gestionar Division Politica Paises
    ///                     «Functional» SIGE-ARF-133 Crear Pais
    ///                     «Functional» SIGE-ARF-134 Consultar Pais
    ///                     «Functional» SIGE-ARF-135 Actualizar Pais
    ///                     «Functional» SIGE-ARF-136 Inactivar Pais
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Country
    ///                     Este caso de uso permite al administrador del sistema gestionar los países, 
    ///                     por medio de las operaciones de Crear, Consultar, Actualizar e Inactivar Países 
    /// </summary>

    public class ECountry
    {
        public ECountry() { 
        
        //Se define el Constructor por Defecto
        
        }
        //Define Atributos
        private string lcodCountry;
        private string lNameCountry;
        private string lcodLenguaje;
        private bool lCountryDpto;
        private bool lCountryCiudad;
        private bool lCountryDistrito;
        private bool lCountryBarrio;
        private bool lCountrystatus;
        private string lCountryCreateBy;
        private DateTime lCountryDateBy;
        private string lCountryModiBy;
        private DateTime lCountryDateModiBy;

        //Define propiedades

        public string codCountry {

            get { return this.lcodCountry; }
            set { this.lcodCountry = value; }
        
        
        }

        public string NameCountry
        {

            get { return this.lNameCountry; }
            set { this.lNameCountry = value; }


        }

        public string codLenguaje
        {

            get { return this.lcodLenguaje; }
            set { this.lcodLenguaje = value; }


        }

        public bool CountryDpto
        {

            get { return this.lCountryDpto; }
            set { this.lCountryDpto = value; }


        }

        public bool CountryCiudad
        {

            get { return this.lCountryCiudad; }
            set { this.lCountryCiudad = value; }


        }

        public bool CountryDistrito
        {

            get { return this.lCountryDistrito; }
            set { this.lCountryDistrito = value; }


        }

        public bool CountryBarrio
        {

            get { return this.lCountryBarrio; }
            set { this.lCountryBarrio = value; }


        }

        public bool Countrystatus
        {

            get { return this.lCountrystatus; }
            set { this.lCountrystatus = value; }


        }

        public string CountryCreateBy
        {

            get { return this.lCountryCreateBy; }
            set { this.lCountryCreateBy = value; }


        }

        public DateTime CountryDateBy
        {

            get { return this.lCountryDateBy; }
            set { this.lCountryDateBy = value; }


        }

        public string CountryModiBy
        {

            get { return this.lCountryModiBy; }
            set { this.lCountryModiBy = value; }


        }

        public DateTime CountryDateModiBy
        {

            get { return this.lCountryDateModiBy; }
            set { this.lCountryDateModiBy = value; }


        }
    }
}
