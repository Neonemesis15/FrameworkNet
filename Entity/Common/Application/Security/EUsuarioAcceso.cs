using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Security
{
    /// <summary>
    /// Información de Aplicación
    /// </summary>
    public class EUsuarioAcceso
    {
        public EUsuarioAcceso()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        private string lidaccess;
        private string lcodCountry;
        private string lPerfilid;
        private string lModuloid;
        private string lnameuser;
        private string lUserPassword;


        public string  idaccess
        {

            get { return this.lidaccess; }

            set
            {

                this.lidaccess = value;


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
        public string Perfilid
        {
            get
            {
                return this.Perfilid;
            }
            set
            {
                this.lPerfilid = value;
            }
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
       
    }
}