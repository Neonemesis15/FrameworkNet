using System;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EProfiles
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  07/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-019 Gestión de Perfiles
    ///                     «Functional» SIGE-ARF-057 Crear Perfil
    ///                     «Functional» SIGE-ARF-058 Consultar Perfil
    ///                     «Functional» SIGE-ARF-059 Actualizar Perfil
    ///                     «Functional» SIGE-ARF-060 Deshabilitar Perfil
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Profiles
    ///                     permite al administrador del sistema gestionar los perfiles, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar perfiles.
    ///                     Define la funcionalidad  de un Rol esto quiere decir que la aplicacion validara 
    ///                     para la accebilidad del usuario que este tenga asociado un Rol con el Perfil apropiado 
    ///                     para definir permisos sobre funcionalidades del sistema.
    /// Modificaciones:     lid_Level Se adiciona este parametro 25-08-2009 Ing. Mauricio Ortiz . se agregó a la tabla profiles
    ///                     lModuloId se modificó int por string . Mauricio Ortiz
    /// Modificaciones:     lidChannel Se adiciona este parametro 24-05-2011 Angel Ortiz.
    ///                     
    /// </summary>

    public class EProfiles
    {
        private string lPerfilid;
        private string lRolid;
        private string lid_Level;
        private string lPerfilName;
        private string lModuloId;
        private string lPerfilDescription;
        private int lidChannel;
        private bool lPerfilStatus;
        private string lPerfilCreateBy;
        private string lPerfilDateBy;
        private string lPerfilModiBy;
        private string lPerfilDateModiBy;

        public string Perfilid
        {
            get { return this.lPerfilid; }
            set { this.lPerfilid = value; }
        }

        public string Rolid
        {
            get { return this.lRolid; }
            set { this.lRolid = value; }
        }

        public string id_Level
        {
            get { return this.lid_Level; }
            set { this.lid_Level = value; }
        }


        public string PerfilName
        {
            get { return this.lPerfilName; }
            set { this.lPerfilName = value;}
        }

        public string ModuloId
        {
            get { return this.lModuloId; }
            set { this.lModuloId = value; }
        }

        public string PerfilDescription
        {
            get { return this.lPerfilDescription; }
            set { this.lPerfilDescription = value;}
        }

        public int PerfilChannel
        {
            get { return this.lidChannel; }
            set { this.lidChannel = value; }
        }

        public bool PerfilStatus
        {
            get { return this.lPerfilStatus; }
            set { this.lPerfilStatus = value;}
        }

        public string PerfilCreateBy
        {
            get { return this.lPerfilCreateBy; }
            set { this.lPerfilCreateBy = value;}
        }

        public string PerfilDateBy
        {
            get { return this.lPerfilDateBy; }
            set { this.lPerfilDateBy = value;}
        }

        public string PerfilModiBy
        {
            get { return this.lPerfilModiBy; }
            set { this.lPerfilModiBy = value;}
        }

        public string PerfilDateModiBy
        {
            get { return this.lPerfilDateModiBy; }
            set { this.lPerfilDateModiBy = value;}
        }

        //Add 18/09/2012 PSalas
        public string TipoPerfil_id { get; set; }
    }
}