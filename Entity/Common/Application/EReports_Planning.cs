using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{ 
    // CreateBy         : Ing. Mauricio Ortiz
    // CreateDate       : 10/07/2009
    // Description      : Atributos Entidad Reportes Planning 
    // Requerimiento    :
    // Modificacion     : 29/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    //                    26/10/2010 Se agregan nuevos atributos y propiedades (lReport_Id, lid_Month, lReportsPlanning_Periodo)
    //                               Se quita el atributo y propiedad (lReportSt_id) que ya no aplica. Ing. Mauricio Ortiz


    public class EReports_Planning
    {
        public EReports_Planning()
        {        
        //Se define el contructor por defecto
        }

        private int lid_ReportsPlanning;
        private string lid_planning;
        private int lReport_Id;
        private string lid_Month;
        private int lReportsPlanning_Periodo;
        //private int lReportSt_id;
        private bool lReportsPlanning_Status;
        private string lReportsPlanning_CreateBy;
        private DateTime lReportsPlanning_DateBy;
        private string lReportsPlanning_ModiBy;
        private DateTime lReportsPlanning_DateModiBy;

        public int id_ReportsPlanning
        {
            get { return this.lid_ReportsPlanning; }
            set { this.lid_ReportsPlanning = value; }
        }

        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }

        //public int ReportSt_id
        //{
        //    get { return this.lReportSt_id; }
        //    set { this.lReportSt_id = value; }
        //}

        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }

        public string id_Month
        {
            get { return this.lid_Month; }
            set { this.lid_Month = value; }
        }

        public int ReportsPlanning_Periodo
        {
            get { return this.lReportsPlanning_Periodo; }
            set { this.lReportsPlanning_Periodo = value; }
        }

        public bool ReportsPlanning_Status
        {
            get { return this.lReportsPlanning_Status; }
            set { this.lReportsPlanning_Status = value; }
        }

        public string ReportsPlanning_CreateBy
        {
            get { return this.lReportsPlanning_CreateBy; }
            set { this.lReportsPlanning_CreateBy = value; }
        }

        public DateTime ReportsPlanning_DateBy
        {
            get { return this.lReportsPlanning_DateBy; }
            set { this.lReportsPlanning_DateBy = value; }
        }

        public string ReportsPlanning_ModiBy
        {
            get { return this.lReportsPlanning_ModiBy; }
            set { this.lReportsPlanning_ModiBy = value; }
        }

        public DateTime ReportsPlanning_DateModiBy
        {
            get { return this.lReportsPlanning_DateModiBy; }
            set { this.lReportsPlanning_DateModiBy = value; }
        }
    }
}
