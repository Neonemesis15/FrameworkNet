using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EInfo_Planning_City
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  08/10/2010        
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Info_Planning_City
    ///                     se almacenarán las ciudades en donde aplica los informes cargados por modulo planning    
    /// Modificción      :  28/10/2010 se adiciona el el atributo y propiedades para cod_Oficina . Ing. Mauricio Ortiz                    
    ///                     
    /// </summary>
    /// 
    public class EInfo_Planning_City
    {
        public EInfo_Planning_City()
        {
            // se define el constructor por defecto 
        }
        
        private long lid_infoplanningcity;
        private int lid_infoplanning;
        private long lcod_Oficina;
        private string lcod_City;
        private bool linfoplanningcity_Status;
        private string linfoplanningcity_CreateBy;
        private DateTime linfoplanningcity_DateBy;
        private string linfoplanningcity_ModiBy;
        private DateTime linfoplanningcity_DateModiBy;

        public long id_infoplanningcity
        {
            get { return this.lid_infoplanningcity; }
            set { this.lid_infoplanningcity = value; }
        }

        public int id_infoplanning
        {
            get { return this.lid_infoplanning; }
            set { this.lid_infoplanning = value; }
        }

        public long cod_Oficina
        {
            get { return this.lcod_Oficina; }
            set { this.lcod_Oficina = value; }
        }

        public string cod_City
        {
            get { return this.lcod_City; }
            set { this.lcod_City = value; }
        }

        public bool infoplanningcity_Status
        {
            get { return this.linfoplanningcity_Status; }
            set { this.linfoplanningcity_Status= value; }
        }

        public string infoplanningcity_CreateBy
        {
            get { return this.linfoplanningcity_CreateBy; }
            set { this.linfoplanningcity_CreateBy = value; }
        }

        public DateTime infoplanningcity_DateBy
        {
            get { return this.linfoplanningcity_DateBy; }
            set { this.linfoplanningcity_DateBy = value; }
        }

        public string infoplanningcity_ModiBy
        {
            get { return this.linfoplanningcity_ModiBy; }
            set { this.linfoplanningcity_ModiBy = value; }
        }

        public DateTime infoplanningcity_DateModiBy
        {
            get { return this.linfoplanningcity_DateModiBy; }
            set { this.linfoplanningcity_DateModiBy = value; }
        }
    }
}
