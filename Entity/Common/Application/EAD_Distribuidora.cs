using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EAD_Distribuidora
    /// Creada Por:         Ing. Magaly Andrea Jiménez
    /// Fecha de Creación:  01/04/2011
    /// </summary>
    public class EAD_Distribuidora
    {
        public EAD_Distribuidora()
        { 
         //Se define el Constructor por defecto
        
        }

        public int lId_Dex;
        public string lDex_Name;
        public bool lDex_Status; 
        public string lDex_CreateBy;
        public DateTime lDex_DateBy;
        public string lDex_ModiBy;
        public DateTime lDex_DateModiBy;



        public int Id_Dex
        {

            get { return this.lId_Dex; }

            set { this.lId_Dex = value; }

        }

        public string Dex_Name
        {

            get { return this.lDex_Name; }
            set { this.lDex_Name = value; }

        }

        public bool Dex_Status
        {

            get { return this.lDex_Status; }
            set { this.lDex_Status = value; }

        }
        public string Dex_CreateBy
        {

            get { return this.lDex_CreateBy; }
            set { this.lDex_CreateBy = value; }

        }

        public DateTime Dex_DateBy
        {

            get { return this.lDex_DateBy; }
            set { this.lDex_DateBy = value; }

        }
        public string Dex_ModiBy
        {

            get { return this.lDex_ModiBy; }
            set { this.lDex_ModiBy = value; }

        }
        public DateTime Dex_DateModiBy
        {

            get { return this.lDex_DateModiBy; }
            set { this.lDex_DateModiBy = value; }

        }
    
    }
}
