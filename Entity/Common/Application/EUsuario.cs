using System;


namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Nombre de Clase: EUsuario
    /// Creada Por:Ing.Carlos Alberto Hernandez Rincon
    /// Fecha de Creacion: 15/03/2009
    /// Requerimiento No<>
    /// Descripcion: Define Los atributos y propiedades de los mismos para la Clase Usuario
    /// Modificacion: Se agrega los atributos lidlevel y lleveldescription para definir el nivel de Usuario en SIGE
    /// Fecha de Modificacion; 24/08/2009 Ing. Carlos Hernandez
    /// Modificación 1: Se agrega el atributo lfotocompany
    /// Fecha de Modificación :01/09/2010
    /// Se Agregan los atributos coddepartament y codcity 05/10/2010
    /// </summary>
    /// Atributos
    public class EUsuario
    {
       
        private int  lPersonid;
        private string lidtypeDocument;
        private string lPersonnd;
        private string lPersonFirtsname;
        private string lPersonLastName;
        private string lPersonSurname;
        private string lPersonSeconName;
        private string lPersonEmail;
        private string lPersonPhone;
        private string lPersonAddres;
        private string lcodCountry;
        private string lcoddepartam;
        private string lcodcity;
        private string lnameuser;
        private string lUserPassword;
        private string  lPerfilid;
        private string lNamePerfil;
        private string lModuloid;
        private string lUserRecall;
        private string lcompanyid;
        private string lidlevel;
        private string lleveldescription;
        private string lcompanyName;
        private string lfotocompany;
        private bool lPersonStatus;
        private string lPersonCreateBy;
        private string lPersonDateBy;
        private string lPersonModiBy;
        private string lPersonDateModiBy;

        /// <summary>
        /// Propiedades de los atributos
        /// </summary>

   


        public int  Personid {

            get { return this.lPersonid; }

            set {

                this.lPersonid = value;
            
            
            }
        
        
        
        
        }





        public string idtypeDocument
        {
            get
            {
                return this.lidtypeDocument;
            }
            set
            {
                this.lidtypeDocument = value;
            }
        }
        public string Personnd
        {
            get
            {
                return this.lPersonnd;
            }
            set
            {
                this.lPersonnd = value;
            }
        }
        public string PersonFirtsname
        {
            get
            {
                return this.lPersonFirtsname;
            }
            set
            {
                this.lPersonFirtsname = value;
            }
        }
        public string PersonLastName
        {
            get
            {
                return this.lPersonLastName;
            }
            set
            {
                this.lPersonLastName = value;
            }
        }
        public string PersonSurname
        {
            get
            {
                return this.lPersonSurname;
            }
            set
            {
                this.lPersonSurname = value;
            }
        }
        public string PersonSeconName
        {
            get
            {
                return this.lPersonSeconName;
            }
            set
            {
                this.lPersonSeconName = value;
            }
        }
        public string PersonEmail
        {
            get
            {
                return this.lPersonEmail;
            }
            set
            {
                this.lPersonEmail = value;
            }

        }
        public string PersonPhone
        {
            get
            {
                return this.lPersonPhone;
            }
            set
            {
                this.lPersonPhone = value;
            }

        }


        public string PersonAddres
        {
            get
            {
                return this.lPersonAddres;
            }
            set
            {
                this.lPersonAddres = value;
            }

        }

        public string codCountry
        {
            get
            {
                return this.lcodCountry;
            }
            set
            {
                this.lcodCountry = value;
            }

        }


        public string coddepartam
        {
            get
            {
                return this.lcoddepartam;
            }
            set
            {
                this.lcoddepartam = value;
            }

        }

        public string codcity
        {
            get
            {
                return this.lcodcity;
            }
            set
            {
                this.lcodcity = value;
            }

        }

        public string nameuser
        {
            get
            {
                return this.lnameuser;
            }
            set
            {
                this.lnameuser = value;
            }

        }

        public string UserPassword
        {
            get
            {
                return this.lUserPassword;
            }
            set
            {
                this.lUserPassword = value;
            }

        }

        public string  Perfilid
        {
            get
            {
                return this.lPerfilid;
            }
            set
            {
                this.lPerfilid = value;
            }

        }

        public string NamePerfil {
            get { return this.lNamePerfil; }
            set { this.lNamePerfil = value; }
        
        
        
        }


        public string Moduloid
        {
            get
            {
                return this.lModuloid;
            }
            set
            {
                this.lModuloid = value;
            }

        }


        public string UserRecall
        {
            get
            {
                return this.lUserRecall;
            }
            set
            {
                this.lUserRecall = value;
            }

        }
        public string companyid
        {
            get
            {
                return this.lcompanyid;
            }
            set
            {
                this.lcompanyid = value;
            }

        }

        public string companyName {

            get { return this.lcompanyName; }
            set { this.lcompanyName = value; }
        
        
        
        }

        public string fotocompany
        {

            get { return this.lfotocompany; }
            set { this.lfotocompany = value; }



        }
        public string idlevel
        {
            get
            {
                return this.lidlevel;
            }
            set
            {
                this.lidlevel = value;
            }

        }

        public string leveldescription
        {
            get
            {
                return this.lleveldescription;
            }
            set
            {
                this.lleveldescription = value;
            }

        }
        public bool PersonStatus
        {
            get
            {
                return this.lPersonStatus;
            }
            set
            {
                this.lPersonStatus = value;
            }

        }
        

        public string PersonCreateBy
        {
            get
            {
                return this.lPersonCreateBy;
            }
            set
            {
                this.lPersonCreateBy = value;
            }

        }


        public string PersonDateBy
        {
            get
            {
                return this.lPersonDateBy;
            }
            set
            {
                this.lPersonDateBy = value;
            }

        }

        public string PersonModiBy
        {
            get
            {
                return this.lPersonModiBy;
            }
            set
            {
                this.lPersonModiBy = value;
            }

        }

        public string PersonDateModiBy
        {
            get
            {
                return this.lPersonDateModiBy;
            }
            set
            {
                this.lPersonDateModiBy = value;
            }

        }
       
        
        
        
        
        
        


        /// <summary>
        /// Función que retorna el nombre del usuario colocando primero 
        /// el apellido paterno y luego el materno.
        /// </summary>
        /// <returns></returns>
        public string NameFirstPaternalLastName()
        {
            return lPersonFirtsname + " " + lPersonLastName + " " + lPersonSurname;
        }
        public string NameFirstMaternalLastName()
        {
            return lPersonFirtsname + " " + lPersonSurname + " " + lPersonSurname;
        }
    }
}