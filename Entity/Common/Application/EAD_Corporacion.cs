using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{/// <summary>
    /// Clase:              EAD_Corporacion
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  16/08/2011
    /// </summary>
   public class EAD_Corporacion
    {

        public EAD_Corporacion()
        { 
         //Se define el Constructor por defecto
        
        }

        public int lcorp_id;
        public string lcorp_name;
        public bool lcorp_status;
        public string lcorp_createby;
        public DateTime lcorp_datecreateby;
        public string lcorp_modifyby;
        public DateTime lcorp_datemodiby;

        public int corp_id
        {

            get { return this.lcorp_id; }

            set { this.lcorp_id = value; }

        }

        public string corp_name
        {

            get { return this.lcorp_name; }

            set { this.lcorp_name = value; }

        }

        public bool corp_status
        {

            get { return this.lcorp_status; }

            set { this.lcorp_status = value; }

        }

        public string corp_createby
        {

            get { return this.lcorp_createby; }

            set { this.lcorp_createby = value; }

        }

        public DateTime corp_datecreateby
        {

            get { return this.lcorp_datecreateby; }

            set { this.lcorp_datecreateby = value; }

        }

        public string corp_modifyby
        {

            get { return this.lcorp_modifyby; }

            set { this.lcorp_modifyby = value; }

        }

        public DateTime corp_datemodiby
        {

            get { return this.lcorp_datemodiby; }

            set { this.lcorp_datemodiby = value; }

        }

    }
}
