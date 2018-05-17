using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{  
    /// <summary>
    /// Clase:              ECompany
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  12/05/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Company
    ///                     permite al administrador del sistema gestionar los Barrios, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Compañias.
    /// </summary>

    public class ECompany
    {
        public ECompany() { 
        
        //Aqui se define el constructor por defecto
        
        }
        /// <summary>
        ///  /// se adiciona campo sCompany_Foto  21 de enero de 2010 Magaly jimenez
        /// </summary>
        private  int lCompanyid;
        private string   lidtypeDocument;
        private string lType_Company;
        private string lCompanynd;
        private string lCompanyName;
        private string lCompanyEmail;
        private string lCompanyPhone;
        private string lCompanyAddres;
        private string lCompany_Foto;
        private string lcodCountry;        
        private bool lCompanyStatus;
        private string lCompanyCreateBy;
        private string lCompanyDateBy;
        private string lCompanyModiBy;
        private string lCompanyDateModiBy;

        public int Companyid{

            get { return this.lCompanyid; }
            set { this.lCompanyid = value; }    
    
        }

        public string  idtypeDocument
        {

            get { return this.lidtypeDocument; }
            set { this.lidtypeDocument = value; }

        }

        public string Type_Company
        {

            get { return this.lType_Company; }
            set { this.lType_Company = value; }

        }


        public string Companynd
        {

            get { return this.lCompanynd; }
            set { this.lCompanynd = value; }

        }
        public string  CompanyName
        {

            get { return this.lCompanyName; }
            set { this.lCompanyName = value; }

        }


        public string CompanyEmail
        {

            get { return this.lCompanyEmail; }
            set { this.lCompanyEmail = value; }

        }

        public string CompanyPhone
        {

            get { return this.lCompanyPhone; }
            set { this.lCompanyPhone = value; }

        }

        public string CompanyAddres
        {

            get { return this.lCompanyAddres; }
            set { this.lCompanyAddres = value; }

        }

        public string Company_Foto
        {

            get { return this.lCompany_Foto; }
            set { this.lCompany_Foto = value; }

        }

        public string codCountry
        {

            get { return this.lcodCountry; }
            set { this.lcodCountry = value; }

        }

       

        public bool CompanyStatus {
            get { return this.lCompanyStatus; }
            set { this.lCompanyStatus = value; }
        
        
        
        }

        public string CompanyCreateBy
        {

            get { return this.lCompanyCreateBy; }
            set { this.lCompanyCreateBy = value; }

        }

        public string CompanyDateBy
        {

            get { return this.lCompanyDateBy; }
            set { this.lCompanyDateBy = value; }

        }

        public string CompanyModiBy
        {

            get { return this.lCompanyModiBy; }
            set { this.lCompanyModiBy = value; }

        }

        public string CompanyDateModiBy
        {

            get { return this.lCompanyDateModiBy; }
            set { this.lCompanyDateModiBy = value; }

        }

    }
}
