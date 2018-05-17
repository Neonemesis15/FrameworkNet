using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EAplicacionWeb
    /// Creada Por: Ing. Carlos Alberto Hernández R.
    /// Fecha de Creación; 17/05/2009
    /// Requerimiento No : «Functional» SIGE-ARF-123 Autenticación de Usuarios
    /// Descripción : Clase Entity encargada de definir los métodos de acceso a aplicacion web
    /// </summary>
    public class EAplicacionWeb : EAplicacion
    {
        public EAplicacionWeb()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        private string lHomePage;
        private string lNombreWeb;
        private string lcod_Country;

        public string HomePage
        {
            get
            {
                return this.lHomePage;
            }
            set
            {
                this.lHomePage = value;
            }
        }
        public string NombreWeb
        {
            get
            {
                return this.lNombreWeb;
            }
            set
            {
                this.lNombreWeb = value;
            }
        }

        public string cod_Country
        {
            get {return this.lcod_Country;}
            set {this.lcod_Country = value;}
        }
    }
}