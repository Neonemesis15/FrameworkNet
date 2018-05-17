using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{    
    /// <summary>
    /// Clase:              ENodeType
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  13/06/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase NodeType
    ///                     permite al administrador del sistema gestionar los tipos de nodo comercial, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar tipos de nodo comercial.
    /// Modificaciones:     26-06-09 se cambia el parametro lidNodeComType de string a int . Ing. Mauricio Ortiz
    /// </summary>

    public class ENodeType
    {
        public ENodeType()
        { 
         //Se define el Constructor por defecto
        
        }
        public int lidNodeComType;
        public string lNodeComTypename;
        public bool lNodeComTypeStatus;
        public string lNodeComTypeCreateBy;
        public DateTime lNodeComTypeDateBy;
        public string lNodeComTypeModiBy;
        public DateTime lNodeComTypeDateModiBy;

        public int idNodeComType {

            get { return this.lidNodeComType; }

            set { this.lidNodeComType = value; }
        
        
       }

        public string NodeComTypename {

            get { return this.lNodeComTypename; }
            set { this.lNodeComTypename = value; }
        
        }

        public bool NodeComTypeStatus
        {

            get { return this.lNodeComTypeStatus; }
            set { this.lNodeComTypeStatus = value; }

        }
        public string NodeComTypeCreateBy
        {

            get { return this.lNodeComTypeCreateBy; }
            set { this.lNodeComTypeCreateBy = value; }

        }

        public DateTime NodeComTypeDateBy
        {

            get { return this.lNodeComTypeDateBy; }
            set { this.lNodeComTypeDateBy = value; }

        }
        public string NodeComTypeModiBy
        {

            get { return this.lNodeComTypeModiBy; }
            set { this.lNodeComTypeModiBy = value; }

        }
        public DateTime NodeComTypeDateModiBy
        {

            get { return this.lNodeComTypeDateModiBy; }
            set { this.lNodeComTypeDateModiBy = value; }

        }
    
    
    
    }
}
