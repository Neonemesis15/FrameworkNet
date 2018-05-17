using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class City
    {
        public City() { 
        
        //Se define el Constructor por defecto
        
        }
        /// <summary>
        /// Metodo para registrar Ciudades
        /// </summary>
        public ECity RegisterCity(string scodcity, string scodpto, string scodcountry, string snamecity,
        bool bCitystatus, string sCityCreateBy, DateTime tCityDateBy, string sCityModiBy, DateTime tCityModiDateBy) {
            DCity odrcity = new DCity();
            ECity oercity = odrcity.RegisterCity(scodcity, scodpto, scodcountry, snamecity, bCitystatus, sCityCreateBy, tCityDateBy,
                sCityModiBy, tCityModiDateBy);
            odrcity = null;
            return oercity;
       
        
        }

         /// <summary>
        /// Metodo para Consultar Ciudades
        /// </summary>

        public DataTable ConsultarCity(string scodcountry, string scoddpto, string scodcity, string snamecity) {
            DCity odscity = new DCity();
            DataTable dt = odscity.ConsultarCity(scodcountry,scoddpto, scodcity, snamecity);
            return dt;
        
        
        }

        /// <summary>
        /// Metodo para Actualizar Ciudades
        /// </summary>
        public ECity ActualizarCity(string scodcity, string scodpto, string scodcountry, string snamecity,
        bool bCitystatus, string sCityModiBy, DateTime tCityModiDateBy) {

            DCity odacity = new DCity();
            ECity oeacity = odacity.ActualizarCity(scodcity, scodpto, scodcountry, snamecity, bCitystatus, sCityModiBy, tCityModiDateBy);
            odacity = null;
            return oeacity;
       
        
        }




    }
}
