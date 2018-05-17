using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application.Interfaces
{
    /// <summary>
    /// Clase: EPresupuesto
    /// Creada Por:Ing.Carlos Alberto Hernández Rincón
    /// Fecha de Creación: 25/06/2009
    /// Descripcion: Define los Atributos y Propiedades de los mismos para la Clase Presupuesto
    /// Requerimiento:<>
    /// </summary>
    public class EPresupuesto
    {
        public EPresupuesto() { 
        
        //Se define el constructor por Defecto
        
        }

        private int lidbudget;
        private string lNumberbudget;
        private string lNamebudget;
        private DateTime lFeciniPlanning;
        private DateTime lFecFinPlanning;
        private int lPersonid;
        private string lPerfilid;
        private int lCompanyid;
        private int lidplanning;
        private string lcodcountry;
        private int lcodstrategy;
        private string lnamecompany;
        private string lname;
        private string lState;
        private string lbudgetCreateBy;
        private DateTime lbudgetDateBy;
        private string lbudgetModiBy;
        private DateTime lbudgetDateModiBy;
        private string lName_Country;

        public int idbudget {

            get { return this.lidbudget; }
            set { this.lidbudget = value; }
        
        
        
        }

        public string Numberbudget
        {

            get { return this.lNumberbudget; }
            set { this.lNumberbudget = value; }



        }

        public string Namebudget
        {

            get { return this.lNamebudget; }
            set { this.lNamebudget = value; }



        }

        public DateTime FeciniPlanning
        {

            get { return this.lFeciniPlanning; }
            set { this.lFeciniPlanning = value; }



        }

        public DateTime FecFinPlanning
        {

            get { return this.lFecFinPlanning; }
            set { this.lFecFinPlanning = value; }



        }

        public int Personid
        {

            get { return this.lPersonid; }
            set { this.lPersonid = value; }



        }

        public string  Perfilid
        {

            get { return this.lPerfilid; }
            set { this.lPerfilid = value; }



        }
        public int Companyid
        {

            get { return this.lCompanyid; }
            set { this.lCompanyid = value; }



        }
        public int idPlanning
        {

            get { return this.lidplanning; }
            set { this.lidplanning = value; }



        }
        public string codcountry {
            get { return this.lcodcountry; }
            set { this.lcodcountry = value; }
           
        
        
        
        }
        public int codstrategy {

            get {return  this.lcodstrategy; }
            set { this.lcodstrategy = value; }
        
        
        
        }
   

        public string State
        {

            get { return this.lState; }
            set { this.lState = value; }



        }

        public string namecompany
        {

            get { return this.lnamecompany; }
            set { this.lnamecompany = value; }



        }


        public string name
        {

            get { return this.lname; }
            set { this.lname = value; }



        }

        public string budgetCreateBy
        {

            get { return this.lbudgetCreateBy; }
            set { this.lbudgetCreateBy = value; }



        }

        public DateTime budgetDateBy
        {

            get { return this.lbudgetDateBy; }
            set { this.lbudgetDateBy = value; }



        }

        public string budgetModiBy
        {

            get { return this.lbudgetModiBy; }
            set { this.lbudgetModiBy = value; }



        }

        public DateTime budgetDateModiBy
        {

            get { return this.lbudgetDateModiBy; }
            set { this.lbudgetDateModiBy = value; }



        }

        public string Name_Country
        {
            get { return this.lName_Country; }
            set { this.lName_Country = value; }
        }


    }
}
