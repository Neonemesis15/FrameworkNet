using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EPLA_Panel_Planning
    {
        public EPLA_Panel_Planning()
        {
            //se define constructor por defecto
        }

        private long lid_PanelPlanning;
        private string lid_planning;
        private int lid_MPOSPlanning;
        private string lClientPDV_Code;
        private int lReport_Id;
        private bool lStatus_PanelPlanning;
        private string lPanelPlanning_CreateBy;
        private DateTime lPanelPlanning_DateBy;
        private string lPanelPlanning_ModiBy;
        private DateTime lPanelPlanning_DateModiBy;


        public long id_PanelPlanning
        {
            get { return this.lid_PanelPlanning; }
            set { this.lid_PanelPlanning = value; }
        }

        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }
        public int id_MPOSPlanning
        {
            get { return this.lid_MPOSPlanning; }
            set { this.lid_MPOSPlanning = value; }
        }
        public string ClientPDV_Code
        {
            get { return this.lClientPDV_Code; }
            set { this.lClientPDV_Code = value; }
        }
        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }
        public bool Status_PanelPlanning
        {
            get { return this.lStatus_PanelPlanning; }
            set { this.lStatus_PanelPlanning = value; }
        }
        public string PanelPlanning_CreateBy
        {
            get { return this.lPanelPlanning_CreateBy; }
            set { this.lPanelPlanning_CreateBy = value; }
        }
        public DateTime PanelPlanning_DateBy
        {
            get { return this.lPanelPlanning_DateBy; }
            set { this.lPanelPlanning_DateBy = value; }
        }
        public string PanelPlanning_ModiBy
        {
            get { return this.lPanelPlanning_ModiBy; }
            set { this.lPanelPlanning_ModiBy = value; }
        }
        public DateTime PanelPlanning_DateModiBy
        {
            get { return this.lPanelPlanning_DateModiBy; }
            set { this.lPanelPlanning_DateModiBy = value; }
        }
    }
}
