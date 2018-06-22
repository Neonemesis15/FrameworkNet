using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.AppMobile
{
    public class Usuario
    {
        private Int16 id;
        private Int16 idPersona;
        private Int16 idPerfil;
        private String nombreUsuario;
        private String password;

        public Int16 Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public Int16 IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }
        

        public Int16 IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        

        public String NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
