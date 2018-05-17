using System;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ERoles
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  07/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-018 Gestión de Roles
    ///                     «Functional» SIGE-ARF-061 Crear Rol
    ///                     «Functional» SIGE-ARF-062 Consultar Rol
    ///                     «Functional» SIGE-ARF-063 Actualizar Rol
    ///                     «Functional» SIGE-ARF-064 Deshabilitar Rol
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Roles
    ///                     permite al administrador del sistema gestionar los Roles, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Roles.
    ///                     Permite Gestionar la Administracionde los Roles de aplicacion para controlar la 
    ///                     accecibilidad de usuarios. SIGE validara en el ingreso de cada usuario cual es su Rol 
    ///                     y con esto definiera unos perfiles de acuardo al requerimiento  SIGE-ARF-019  Gestión de Perfiles.
    /// </summary>
    
    public class ERoles
    {
        private string lRolid;
        private string lRolName;
        private string lRolDescription;
        private bool lRolStatus;
        private string lRolCreateBy;
        private string lRolDateBy;
        private string lRolModiBy;
        private string lRolDateModiBy;

        public string Rolid
        {
            get { return this.lRolid; }
            set { this.lRolid = value; }
        }
        public string RolName
        {
            get { return this.lRolName; }
            set { this.lRolName = value; }
        }
        public string RolDescription
        {
            get { return this.lRolDescription; }
            set { this.lRolDescription = value; }
        }
        public bool RolStatus
        {
            get { return this.lRolStatus; }
            set { this.lRolStatus = value; }
        }
        public string RolCreateBy
        {
            get { return this.lRolCreateBy; }
            set { this.lRolCreateBy = value; }
        }
        public string RolDateBy
        {
            get { return this.lRolDateBy; }
            set { this.lRolDateBy = value; }
        }
        public string RolModiBy
        {
            get { return this.lRolModiBy; }
            set { this.lRolModiBy = value; }
        }
        public string RolDateModiBy
        {
            get { return this.lRolDateModiBy; }
            set { this.lRolDateModiBy = value; }
        }
    }
}