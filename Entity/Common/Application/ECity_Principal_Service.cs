using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:ECity_Principal_Service
    /// Creada Por: Ing. Carlos Alberto Hernandez R
    /// Fecha: 05/01/2009
    /// Requerimiento<>
    /// </summary>

    public class ECity_Principal_Service
    {
        public ECity_Principal_Service(){
       //Se define el Constructor por defecto
    
       }
        private int lidCityPri;
        private string lcod_City;
        private int lCodStrategy;
        private string lCodChannel;
        private int lcompany_id;
        private bool lCityPriStatus;
        private string lCityPriCreateBy;
        private DateTime lCityPriDateBy;
        private string lCityPriModiBy;
        private DateTime lCityPriDateModiBy;


        public int idCityPri {
            get { return this.lidCityPri; }
            set { this.lidCityPri = value; }
        
        
        
        }

        public string cod_City
        {
            get { return this.lcod_City; }
            set { this.lcod_City = value; }



        }


        public int CodStrategy
        {
            get { return this.lCodStrategy; }
            set { this.lCodStrategy = value; }



        }

        public string CodChannel
        {
            get { return this.lCodChannel; }
            set { this.lCodChannel = value; }



        }

        public int company_id
        {
            get { return this.lcompany_id; }
            set { this.lcompany_id = value; }



        }

        public bool CityPriStatus
        {
            get { return this.lCityPriStatus; }
            set { this.lCityPriStatus = value; }



        }



        public string CityPriCreateBy
        {
            get { return this.lCityPriCreateBy; }
            set { this.lCityPriCreateBy = value; }



        }

        public DateTime CityPriDateBy {
            get { return this.lCityPriDateBy; }
            set { this.lCityPriDateBy = value; }
        
        
        }


        public string CityPriModiBy
        {
            get { return this.lCityPriModiBy; }
            set { this.lCityPriModiBy = value; }



        }

        public DateTime CityPriDateModiBy
        {
            get { return this.lCityPriDateModiBy; }
            set { this.lCityPriDateModiBy = value; }


        }
    }
}
