using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{/// <summary>
    /// Clase:              EReportChannel
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  22/10/2010   
    /// </summary>

   public class EReportChannel
   {
       public EReportChannel()
        {
            //Se define el constructor por defecto
        }

       private int lReportCanal_id;
        private int lReport_id ;
        private int lCompany_id;
        private string lcod_Channel;
        private bool lReportCanal_Status;
        private string lReportCana_CreateBy;
        private DateTime lReportCana_DateBy;
        private string lReportCana_ModiBy;
        private DateTime lReportCana_DateModiBy;

        public int ReportCanal_id
        {
            get { return this.lReportCanal_id; }
            set { this.lReportCanal_id = value; }
        }

        public int Report_id
        {
            get { return this.lReport_id; }
            set { this.lReport_id = value; }
        }
        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }
        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel = value; }
        }
        public bool ReportCanal_Status
        {
            get { return this.lReportCanal_Status; }
            set { this.lReportCanal_Status = value; }
        }

        public string ReportCana_CreateBy
        {
            get { return this.lReportCana_CreateBy; }
            set { this.lReportCana_CreateBy = value; }
        }

        public DateTime ReportCana_DateBy
        {
            get { return this.lReportCana_DateBy; }
            set { this.lReportCana_DateBy = value; }
        }

        public string ReportCana_ModiBy
        {
            get { return this.lReportCana_ModiBy; }
            set { this.lReportCana_ModiBy = value; }
        }

        public DateTime ReportCana_DateModiBy
        {
            get { return this.lReportCana_DateModiBy; }
            set { this.lReportCana_DateModiBy = value; }
        }
    }
}
