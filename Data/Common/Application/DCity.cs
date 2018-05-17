using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DCity
    {
        /// <summary>
        /// Clase: DCity
        /// Creada Por: Ing.Carlos Alberto Hernandez Rincon
        /// Fecha de Creacion: 14/06/2009
        /// Descripcion: Define los metodos transaccionales para la Clase City
        /// Requerimiento No <>
        /// </summary>

        
        private Conexion oConn;
        public DCity() { 
            UserInterface oUserInterface = new UserInterface();
             oConn = new Conexion();
             oUserInterface = null;
        
        }
        /// <summary>
        /// Metodo para registrar Ciudades
        /// </summary>
        public ECity RegisterCity(string scodcity,string scodpto, string scodcountry, string snamecity,
        bool bCitystatus, string sCityCreateBy,DateTime tCityDateBy,string sCityModiBy, DateTime tCityModiDateBy){
           DataTable dt= oConn.ejecutarDataTable("UP_WEBSIGE_REGISTERCITY",scodcity, scodpto, scodcountry, snamecity, bCitystatus, sCityCreateBy,
               tCityDateBy, sCityModiBy, tCityModiDateBy);
              ECity oecity= new ECity();
              oecity.codCity= scodcity;
              oecity.coddpto= scodpto;
              oecity.codcountry= scodcountry;
              oecity.CityStatus= bCitystatus;
              oecity.CityCreateBy= sCityCreateBy;
              oecity.CityDateBy= tCityDateBy;
              oecity.CityModiBy= sCityModiBy;
              oecity.CityDateModiBy= tCityModiDateBy;
              return oecity;

        
        
        }
        
        /// <summary>
        /// Metodo para Consultar Ciudades
        /// </summary>
       
        public DataTable ConsultarCity( string scodcountry, string scoddpto, string scodcity, string snamecity){
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SEARCHCITY", scodcountry, scoddpto, scodcity, snamecity);
            ECity oescity= new ECity();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oescity.codcountry = dt.Rows[i]["cod_country"].ToString().Trim();
                        oescity.coddpto = dt.Rows[i]["cod_dpto"].ToString().Trim();
                        oescity.codCity = dt.Rows[i]["cod_City"].ToString().Trim();
                        oescity.NameCity = dt.Rows[i]["Name_City"].ToString().Trim();
                        oescity.CityStatus = Convert.ToBoolean(dt.Rows[i]["City_Status"].ToString().Trim());
                        oescity.CityCreateBy = dt.Rows[i]["City_CreateBy"].ToString().Trim();
                        oescity.CityDateBy = Convert.ToDateTime(dt.Rows[i]["City_DateBy"].ToString().Trim());
                        oescity.CityModiBy = dt.Rows[i]["City_ModiBy"].ToString().Trim();
                        oescity.CityDateModiBy = Convert.ToDateTime(dt.Rows[i]["City_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        
        
        
        
        
        

        /// <summary>
        /// Metodo para Actualizar Ciudades
        /// </summary>
        public ECity ActualizarCity(string scodcity, string scodpto, string scodcountry, string snamecity,
        bool bCitystatus,  string sCityModiBy, DateTime tCityModiDateBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZACITY", scodcity, scodpto, scodcountry, snamecity, bCitystatus, sCityModiBy, tCityModiDateBy);
            ECity oeacity = new ECity();
            oeacity.codCity = scodcity;
            oeacity.coddpto = scodpto;
            oeacity.codcountry = scodcountry;
            oeacity.CityStatus = bCitystatus;
            oeacity.CityModiBy = sCityModiBy;
            oeacity.CityDateModiBy = tCityModiDateBy;
            return oeacity;



        }
        
        
        }
    }


