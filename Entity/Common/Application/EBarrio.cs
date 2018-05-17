using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EBarrio
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  16/06/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-132 Gestionar Division Politica Barrio
    ///                     «Functional» SIGE-ARF-140 Crear Barrio
    ///                     «Functional» SIGE-ARF-151 Consultar Barrio
    ///                     «Functional» SIGE-ARF-150 Actualizar Barrio
    ///                     «Functional» SIGE-ARF-152 Inactivar Barrio
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Barrio
    ///                     permite al administrador del sistema gestionar los Barrios, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Barrios.
    /// </summary>

    public class EBarrio
    {
        public EBarrio()
        {
            //Se define el contructor por defecto
        }

        //Aqui se definen los atributos
        private string lcodCommunity;
        private string lcodcountry;
        private string lcoddpto;
        private string lcodcity;
        private string lcodDistrict;
        private string lNameCommunity;
        private bool lComunityStatus;
        private string lCommunityCreateBy;
        private DateTime lCommunityDateBy;
        private string lCommunityModiBy;
        private DateTime lCommunityDateModiBy;

        //Defino las propiedades de los atributos
        public string codComunity
        {
            get { return this.lcodCommunity; }
            set { this.lcodCommunity = value; }
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

        public string codcity
        {
            get { return this.lcodcity; }
            set { this.lcodcity = value; }
        }

        public string codDistrict
        {
            get { return this.lcodDistrict; }
            set { this.lcodDistrict = value; }
        }

        public string NameCommunity
        {
            get { return this.lNameCommunity; }
            set { this.lNameCommunity = value; }
        }

        public bool ComunityStatus
        {
            get { return this.lComunityStatus; }
            set { this.lComunityStatus = value; }
        }

        public string CommunityCreateBy
        {
            get { return this.lCommunityCreateBy; }
            set { this.lCommunityCreateBy = value; }
        }

        public DateTime CommunityDateBy
        {
            get { return this.lCommunityDateBy; }
            set { this.lCommunityDateBy = value; }
        }

        public string CommunityModiBy
        {
            get { return this.lCommunityModiBy; }
            set { this.lCommunityModiBy = value; }
        }

        public DateTime CommunityDateModiBy
        {
            get { return this.lCommunityDateModiBy; }
            set { this.lCommunityDateModiBy = value; }
        }
    }
}