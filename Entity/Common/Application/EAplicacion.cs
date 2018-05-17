using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EAplicacion
    /// Creada Por: Ing. Carlos Alberto Hernández R.
    /// Fecha de Creación; 20/08/2009
    /// Requerimiento No : «Functional» SIGE-ARF-123 Autenticación de Usuarios
    /// Descripción : Clase Entity encargada de definir el tipo de aplicacion que va a manejar el FrameWork
    /// </summary>

    public class EAplicacion
    {
        public EAplicacion()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        private string lcodapplucky;
        private string lnameapp;
        private string lverapp;
        private string labrapp;
        private bool   lappStatus;
        private string lappurl;
        private string lappCreateBy;
        private string lappDateBy;
        private string lappModiBy;
        private string lappDateModiBy;



        public string codapplucky
        {
            get
            {
                return this.lcodapplucky;
            }
            set
            {
                this.lcodapplucky = value;
            }
        }
        public string nameapp
        {
            get
            {
                return this.lnameapp;
            }
            set
            {
                this.lnameapp = value;
            }
        }
        public string verapp
        {
            get
            {
                return this.lverapp;
            }
            set
            {
                this.lverapp = value;
            }
        }
        public string abrapp
        {
            get
            {
                return this.labrapp;
            }
            set
            {
                this.labrapp = value;
            }
        }
        public bool appStatus
        {
            get
            {
                return this.lappStatus;
            }
            set
            {
                this.lappStatus = value;
            }
        }

        public string appurl
        {
            get { return this.lappurl; }
            set
            {
                this.lappurl = value;
            }

        }

        public string appCreateBy
        {
            get
            {
                return this.lappCreateBy;
            }
            set
            {
                this.lappCreateBy = value;
            }
        }
        public string appDateBy
        {
            get
            {
                return this.lappDateBy;
            }
            set
            {
                this.lappDateBy = value;
            }
        }
        public string appModiBy
        {
            get
            {
                return this.lappModiBy;
            }
            set
            {
                this.lappModiBy = value;
            }
        }
        public string appDateModiBy
        {
            get
            {
                return this.lappDateModiBy;
            }
            set
            {
                this.lappDateModiBy = value;
            }
        }
    }
}