using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EPLA_Family_Planning
    {
        public EPLA_Family_Planning()
        {
            //Se define el constructor por defecto
        }

        private long lid_FamilyPlanning;
        private string lid_planning;
        private string lid_ProductCategory;
        private int lid_Brand;
        private string lid_ProductFamily;
        private int lReport_Id;
        private bool lStatus;
        private string lFamilyPlan_CreateBy;
        private DateTime lFamilyPlan_DateBy;
        private string lFamilyPlan_ModiBy;
        private DateTime lFamilyPlan_DateModiBy;


        public long id_FamilyPlanning
        {
            get { return this.lid_FamilyPlanning; }
            set { this.lid_FamilyPlanning = value; }
        }
        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }

        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }


        public int id_Brand
        {
            get { return this.lid_Brand; }
            set { this.lid_Brand = value; }
        }
        public string id_ProductFamily
        {
            get { return this.lid_ProductFamily; }
            set { this.lid_ProductFamily = value; }
        }
        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }
        public bool Status
        {
            get { return this.lStatus; }
            set { this.lStatus = value; }
        }
        public string FamilyPlan_CreateBy
        {
            get { return this.lFamilyPlan_CreateBy; }
            set { this.lFamilyPlan_CreateBy = value; }
        }
        public DateTime FamilyPlan_DateBy
        {
            get { return this.lFamilyPlan_DateBy; }
            set { this.lFamilyPlan_DateBy = value; }
        }
        public string FamilyPlan_ModiBy
        {
            get { return this.lFamilyPlan_ModiBy; }
            set { this.lFamilyPlan_ModiBy = value; }
        }
        public DateTime FamilyPlan_DateModiBy
        {
            get { return this.lFamilyPlan_DateModiBy; }
            set { this.lFamilyPlan_DateModiBy = value; }
        }
    }
}