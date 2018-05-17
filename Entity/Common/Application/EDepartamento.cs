using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{    
    /// <summary>
    /// Clase:              EDepartamento
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  15/06/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-129 Gestionar Division Politica Departamento
    ///                     «Functional» SIGE-ARF-137 Crear Departamento
    ///                     «Functional» SIGE-ARF-141 Consultar Departamento
    ///                     «Functional» SIGE-ARF-142 Actualizar Departamento
    ///                     «Functional» SIGE-ARF-143 Inactivar Departamento
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Departamento
    ///                     Este caso de uso permite al administrador del sistema gestionar los Departamentos 
    ///                     de una estructura de división politica, por medio de las operaciones de Crear, 
    ///                     Consultar, Actualizar e Inactivar departamentos.
    /// </summary>


    public class EDepartamento
    {
        public EDepartamento()
        { 
        
        //Define el Constructor por Defecto
        
        }
        private string lcoddpto;
        private string lcodCountry;
        private string lNamedpto;
        private bool lDptoStatus;
        private string lDepartamentCreateBy;
        private DateTime lDepartamentDateBy;
        private string lDepartamentModiBy;
        private DateTime lDepartamentDateModiBy;


        //Se definenen las propiedades

        public string coddpto {

            get { return this.lcoddpto; }
            set { this.lcoddpto = value; }
        
        
        
        
        }

        public string codCountry
        {

            get { return this.lcodCountry; }
            set { this.lcodCountry = value; }




        }

        public string Namedpto
        {

            get { return this.lNamedpto; }
            set { this.lNamedpto = value; }




        }



        public bool DptoStatus
        {

            get { return this.lDptoStatus; }
            set { this.lDptoStatus = value; }




        }

        public string DepartamentCreateBy
        {

            get { return this.lDepartamentCreateBy; }
            set { this.lDepartamentCreateBy = value; }




        }

        public DateTime DepartamentDateBy
        {

            get { return this.lDepartamentDateBy; }
            set { this.lDepartamentDateBy = value; }




        }

        public string DepartamentModiBy
        {

            get { return this.lDepartamentModiBy; }
            set { this.lDepartamentModiBy = value; }




        }

        public DateTime DepartamentDateModiBy
        {

            get { return this.lDepartamentDateModiBy; }
            set { this.lDepartamentDateModiBy = value; }




        }





    }
}
