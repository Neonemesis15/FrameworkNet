using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ETypeReports
    /// Creada Por:         Carlos Marin
    /// Fecha de Creación:  23/08/2011
    /// </summary>
    /// 
   public class ETypeReports
    {
       private int lid_TypeReport;
       private string lTypeReport_Name;
       private bool lTypeReport__Status;
       private string lTypeReport_CreateBy;
       private DateTime lTypeReport_DateBy;
       private string lTypeReport_ModiBy;
       private DateTime lTypeReport_DateModiBy;



        public int id_TypeReport
        {
            get { return lid_TypeReport; }
            set { lid_TypeReport = value; }
        }

        public string TypeReport_Name
        {
            get { return lTypeReport_Name; }
            set { lTypeReport_Name = value; }
        }

        public bool TypeReport__Status
        {
            get { return lTypeReport__Status; }
            set { lTypeReport__Status = value; }
        }

        public string TypeReport_CreateBy
        {
            get { return lTypeReport_CreateBy; }
            set { lTypeReport_CreateBy = value; }
        }

        public DateTime TypeReport_DateBy
        {
            get { return lTypeReport_DateBy; }
            set { lTypeReport_DateBy = value; }
        }

        public string TypeReport_ModiBy
        {
            get { return lTypeReport_ModiBy; }
            set { lTypeReport_ModiBy = value; }
        }

        public DateTime TypeReport_DateModiBy
        {
            get { return lTypeReport_DateModiBy; }
            set { lTypeReport_DateModiBy = value; }
        }


    }
}
