using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{   
    /// <summary>
    /// Clase:              EDistrito
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  15/06/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-131 Gestionar Division Politica Distrito
    ///                     «Functional» SIGE-ARF-139 Crear Distrito
    ///                     «Functional» SIGE-ARF-148 Consultar Distrito
    ///                     «Functional» SIGE-ARF-147 Actualizar Distrito
    ///                     «Functional» SIGE-ARF-149 Inactivar Distrito    
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Distrito
    ///                     Este caso de uso permite al administrador del sistema gestionar los Distritos, 
    ///                     por medio de las operaciones de Crear, Consultar, Actualizar e Inactivar Distritos.
    /// </summary>
    public class EDistrito
    {
        public EDistrito() { 
        
        //Define el Constructor  por Defecto
        
        }

        private string lcodDistrict;
        private string lcodcountry;
        private string lcoddpto;
        private string lcodCity;
        private bool lDistrictStatus;
        private string lNameLocal;
        private string lLocalCreateBy;
        private DateTime lLocalDateBy;
        private string lLocalModiby;
        private DateTime lLocalDateModiBy;

        public string codDistrict {
            get { return this.lcodDistrict; }
            set { this.lcodDistrict = value; }
        
        
        }

        public string codcountry
        {
            get { return this.lcodcountry; }
            set { this.lcodcountry = value; }


        }

        public string coddpto
        {
            get { return this.lcoddpto; }
            set { this.lcoddpto = value; }


        }

        public string codCity
        {
            get { return this.lcodCity; }
            set { this.lcodCity = value; }


        }

        public bool DistrictStatus
        {
            get { return this.lDistrictStatus; }
            set { this.lDistrictStatus = value; }


        }

        public string NameLocal
        {
            get { return this.lNameLocal; }
            set { this.lNameLocal = value; }


        }

        public string LocalCreateBy
        {
            get { return this.lLocalCreateBy; }
            set { this.lLocalCreateBy = value; }


        }

        public DateTime LocalDateBy
        {
            get { return this.lLocalDateBy; }
            set { this.lLocalDateBy = value; }


        }

        public string LocalModiby
        {
            get { return this.lLocalModiby; }
            set { this.lLocalModiby = value; }


        }

        public DateTime LocalDateModiBy
        {
            get { return this.lLocalDateModiBy; }
            set { this.lLocalDateModiBy = value; }


        }


        
    }
}
