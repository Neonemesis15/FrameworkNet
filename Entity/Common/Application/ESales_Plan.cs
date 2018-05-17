using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: ESales_Plan
    /// Creada Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creración: 01/10/2009
    /// Descripción: define los atributos y propiedades para la clase Sales_Plan
    /// Requerimiento<>
    /// </summary>

    public class ESales_Plan
    {
        public ESales_Plan() { 
        
        //Define el Constructor por defecto
        
        }
        private int lSalesPlanid;
        private int lcodstrategy;
        private int lcompanyid;
        private string lPlanningCodChannel;
        private int lidCityPri;
        private decimal lValuePlanCityPri;
        private string lcodcountry;
        private decimal lValuePlanCountry;
        private string lSalesPlanUnit;
        private int lidMonth;
        private int lYearsid;
        private bool lSalesPlan_Status;
        private string lSalesPlanCreateBy;
        private DateTime lSalesPlanDateBy;
        private string lSalesPlanModiBy;
        private DateTime lSalesPlanDateModiBy;



        public int SalesPlanid {

            get { return this.lSalesPlanid; }
            set { this.lSalesPlanid = value; } 
        
        
        }

        public int codstrategy
        {

            get { return this.lcodstrategy; }
            set { this.lcodstrategy = value; }


        }

        public int companyid {

            get { return this.lcompanyid; }
            set { this.lcompanyid = value; }
        
        
        }

        public string  PlanningCodChannel
        {

            get { return this.lPlanningCodChannel; }
            set { this.lPlanningCodChannel = value; }


        }

        public int idCityPri
        {

            get { return this.lidCityPri; }
            set { this.lidCityPri = value; }


        }


        public decimal ValuePlanCityPri
        {

            get { return this.lValuePlanCityPri; }
            set { this.lValuePlanCityPri = value; }


        }

        public string codcountry
        {

            get { return this.lcodcountry; }
            set { this.lcodcountry = value; }


        }

        public decimal ValuePlanCountry
        {

            get { return this.lValuePlanCountry; }
            set { this.lValuePlanCountry = value; }


        }

        public string SalesPlanUnit
        {

            get { return this.lSalesPlanUnit; }
            set { this.lSalesPlanUnit = value; }


        }

        public int idMonth
        {

            get { return this.lidMonth; }
            set { this.lidMonth = value; }


        }

        public int Yearsid
        {

            get { return this.lYearsid; }
            set { this.lYearsid = value; }


        }

        public bool SalesPlan_Status
        {
            get { return this.lSalesPlan_Status; }
            set { this.lSalesPlan_Status = value; }
        }

        public string SalesPlanCreateBy
        {

            get { return this.lSalesPlanCreateBy; }
            set { this.lSalesPlanCreateBy = value; }


        }

        public DateTime SalesPlanDateBy
        {

            get { return this.lSalesPlanDateBy; }
            set { this.lSalesPlanDateBy = value; }


        }

        public string SalesPlanModiBy
        {

            get { return this.lSalesPlanModiBy; }
            set { this.lSalesPlanModiBy = value; }


        }

        public DateTime SalesPlanDateModiBy
        {

            get { return this.lSalesPlanDateModiBy; }
            set { this.lSalesPlanDateModiBy = value; }


        }







    }
}
