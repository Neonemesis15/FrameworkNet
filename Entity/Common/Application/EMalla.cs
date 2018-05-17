using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{  /// <summary>
    /// Clase:              EMallas
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  13/09/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Mallas
    ///                     permite al administrador del sistema gestionar las Mallas, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Marcas
    /// </summary>

    public class EMalla
    {
        public EMalla()
        {
            //Se define el constructor por defecto
        }

        private int lid_malla;
        private int lCompany_id;
        private string lmalla;
        private bool lmalla_Status;
        private string lmalla_CreateBy;
        private DateTime lmalla_DateBy;
        private string lmalla_ModiBy;
        private DateTime lmalla_DateModiBy;

         public int id_malla
        {
            get { return this.lid_malla; }
            set { this.lid_malla = value; }
        }

        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }

        public string malla
        {
            get { return this.lmalla; }
            set { this.lmalla = value; }
        }

        public bool malla_Status
        {
            get { return this.lmalla_Status; }
            set { this.lmalla_Status = value; }
        }

        public string malla_CreateBy
        {
            get { return this.lmalla_CreateBy; }
            set { this.lmalla_CreateBy = value; }
        }

        public DateTime malla_DateBy
        {
            get { return this.lmalla_DateBy; }
            set { this.lmalla_DateBy = value; }
        }

        public string malla_ModiBy
        {
            get { return this.lmalla_ModiBy; }
            set { this.lmalla_ModiBy = value; }
        }

        public DateTime malla_DateModiBy
        {
            get { return this.lmalla_DateModiBy; }
            set { this.lmalla_DateModiBy = value; }
        }
    }
    
}
