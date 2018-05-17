using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Modificación :  02/03/2011 se adiciona el parametro Report_Id . Ing. Mauricio Ortiz
    /// </summary>
    public class EPLA_Brand_Planning
    {
        public EPLA_Brand_Planning()
        {
            //Se define el constructor por defecto
        }

        private long lid_BrandPlannin;
        private string lid_planning;
        private string lid_ProductCategory;
        private int lid_Brand;
        private int lReport_Id;
        private bool lStatus;
        private string lBrandPlan_CreateBy;
        private DateTime lBrandPlan_DateBy;
        private string lBrandPlan_ModiBy;
        private DateTime lBrandPlan_DateModiBy;

        public long id_BrandPlannin
        {
            get { return this.lid_BrandPlannin; }
            set { this.lid_BrandPlannin = value; }
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
        public string BrandPlan_CreateBy
        {
            get { return this.lBrandPlan_CreateBy; }
            set { this.lBrandPlan_CreateBy = value; }
        }
        public DateTime BrandPlan_DateBy
        {
            get { return this.lBrandPlan_DateBy; }
            set { this.lBrandPlan_DateBy = value; }
        }
        public string BrandPlan_ModiBy
        {
            get { return this.lBrandPlan_ModiBy; }
            set { this.lBrandPlan_ModiBy = value; }
        }
        public DateTime BrandPlan_DateModiBy
        {
            get { return this.lBrandPlan_DateModiBy; }
            set { this.lBrandPlan_DateModiBy = value; }
        }
    }
}