using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: ECityPlanning
    /// Creada Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación: 09/07/2009 
    /// Requerimiento No: «Functional» SIGE-ARF-026  Gestión Planning 
    /// Descripcion: Define los atributos y propiedades de los mismos para la Clase CityPlanning   
    /// Modificacion: 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
    /// 
    

    public class ECityPlanning
    {
        public ECityPlanning() { 
        
        //Se define el constructor por defecto
        
        }
        private int lidCityPlanning;
        private string lidplanning;
        private string lCodCity;
        private int lcompanyid;
        private string  lCityPrincipal;
        private bool lCityPlanningStatus;
        private string lCityPlanningCreateBy;
        private DateTime lCityPlanningDateBy;
        private string lCityPlanningModiBy;
        private DateTime lCityPlanningDateModiBy;


        public int  idCityPlanning{
            get { return this.lidCityPlanning; }
            set { this.lidCityPlanning = value; }
         
    
        }

        public string idplanning
        {
            get { return this.lidplanning; }
            set { this.lidplanning = value; }


        }

        public string CodCity
        {
            get { return this.lCodCity; }
            set { this.lCodCity = value; }


        }
        public int companyid
        {
            get { return this.lcompanyid; }
            set { this.lcompanyid = value; }



        }
        public string  CityPrincipal {
            get { return this.lCityPrincipal; }
            set { this.lCityPrincipal = value; }           
        
        
        
        }
        

        public bool CityPlanningStatus
        {
            get { return this.lCityPlanningStatus; }
            set { this.lCityPlanningStatus = value; }


        }

        public string CityPlanningCreateBy
        {
            get { return this.lCityPlanningCreateBy; }
            set { this.lCityPlanningCreateBy = value; }


        }

        public DateTime CityPlanningDateBy
        {
            get { return this.lCityPlanningDateBy; }
            set { this.lCityPlanningDateBy = value; }


        }

        public string CityPlanningModiBy
        {
            get { return this.lCityPlanningModiBy; }
            set { this.lCityPlanningModiBy = value; }


        }

        public DateTime CityPlanningDateModiBy
        {
            get { return this.lCityPlanningDateModiBy; }
            set { this.lCityPlanningDateModiBy = value; }


        }

    }
}
