using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class ECanalTipo
    {
        /// <summary>
        /// Clase:              ECanalTipo
        /// Creada Por:         Angel Ortiz
        /// Fecha de Creación:  05/08/2011
        /// Requerimientos No:  
        /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase CanalTipo
        ///                     Permite, crear, actualizar  e inativar los tipos de canales en los cuales Lucky provee sus servicios
        /// </summary>
        /// 
        public ECanalTipo() { }

        private int ichtype_id;
        private string schtype_nombre;
        private string schtype_descripcion;
        private bool bchtype_status;
        private string schtype_createby;
        private DateTime dchtime_datecreateby;
        private string schtype_modiby;
        private DateTime dchtime_datemodiby;

        public int Ichtype_id
        {
            get { return ichtype_id; }
            set { ichtype_id = value; }
        }
        

        public string Schtype_nombre
        {
            get { return schtype_nombre; }
            set { schtype_nombre = value; }
        }
        

        public string Schtype_descripcion
        {
            get { return schtype_descripcion; }
            set { schtype_descripcion = value; }
        }
        

        public bool Bchtype_status
        {
            get { return bchtype_status; }
            set { bchtype_status = value; }
        }
        

        public string Schtype_createby
        {
            get { return schtype_createby; }
            set { schtype_createby = value; }
        }
        

        public DateTime Dchtime_datecreateby
        {
            get { return dchtime_datecreateby; }
            set { dchtime_datecreateby = value; }
        }

        public string Schtype_modiby
        {
            get { return schtype_modiby; }
            set { schtype_modiby = value; }
        }
        

        public DateTime Dchtime_datemodiby
        {
            get { return dchtime_datemodiby; }
            set { dchtime_datemodiby = value; }
        }




    }
}
