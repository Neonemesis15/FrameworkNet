using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DCountry
    /// Creada Por: Ing. Carlos Alberto Hernandez Rincon
    /// Fecha de Creacion: 13/09/2009
    /// Descripcion: Define los Metodos transaccionales para la Clase Country
    /// Requerimiento No <>
    /// </summary>

    public class DCountry
    {
        private Conexion oConn;
        public DCountry() {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        
        }
        /// <summary>
        /// Metodo para Crear Paises
        /// </summary>
      

        public ECountry RegisterCountry(string scodcountry, string snamecountry, string slenguaje, bool bCountryDpto,
            bool bCountryCity, bool bDistrito, bool bBarrio, bool bstatuscountry, string sCountryCreateBy, DateTime tCountryDateBy,
            string sCountryModiBy, DateTime tCountryDateModiBy) {
                DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_REGISTERCOUNTRY", scodcountry, snamecountry, slenguaje, bCountryDpto,
                    bCountryCity, bDistrito, bBarrio, bstatuscountry, sCountryCreateBy, tCountryDateBy, sCountryModiBy, tCountryDateModiBy);
                ECountry oercountry = new ECountry();
                oercountry.codCountry = scodcountry;
                oercountry.NameCountry = snamecountry;
                oercountry.codLenguaje = slenguaje;
                oercountry.CountryDpto = bCountryDpto;
                oercountry.CountryCiudad = bCountryCity;
                oercountry.CountryDistrito = bDistrito;
                oercountry.CountryBarrio = bBarrio;
                oercountry.Countrystatus = bstatuscountry;
                oercountry.CountryCreateBy = sCountryCreateBy;
                oercountry.CountryDateBy = tCountryDateBy;
                oercountry.CountryModiBy = sCountryModiBy;
                oercountry.CountryDateModiBy = tCountryDateModiBy;
                return oercountry;
             
        
          }
         /// <summary>
         /// Metodopara Consultar Paises
         /// </summary>
         

        public DataTable ConsultarCountry(string scodcountry, string snamecountry) {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SEARCHCOUNTRY", scodcountry, snamecountry);
            ECountry oescountry = new ECountry();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oescountry.codCountry = dt.Rows[i]["cod_Country"].ToString().Trim();
                        oescountry.NameCountry = dt.Rows[i]["Name_Country"].ToString().Trim();
                        oescountry.codLenguaje = dt.Rows[i]["cod_Lenguaje"].ToString().Trim();
                        oescountry.CountryDpto = Convert.ToBoolean(dt.Rows[i]["Country_Dpto"].ToString().Trim());
                        oescountry.CountryCiudad = Convert.ToBoolean(dt.Rows[i]["Country_Ciudad"].ToString().Trim());
                        oescountry.CountryDistrito = Convert.ToBoolean(dt.Rows[i]["Country_Distrito"].ToString().Trim());
                        oescountry.CountryBarrio = Convert.ToBoolean(dt.Rows[i]["Country_Barrio"].ToString().Trim());
                        oescountry.Countrystatus = Convert.ToBoolean(dt.Rows[i]["Country_status"].ToString().Trim());
                        oescountry.CountryCreateBy = dt.Rows[i]["Country_CreateBy"].ToString().Trim();
                        oescountry.CountryDateBy = Convert.ToDateTime(dt.Rows[i]["Country_DateBy"].ToString().Trim());
                        oescountry.CountryModiBy = dt.Rows[i]["Country_ModiBy"].ToString().Trim();
                        oescountry.CountryDateModiBy = Convert.ToDateTime(dt.Rows[i]["Country_DateModiBy"].ToString().Trim());
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
        /// Metodo para Actualizar Paises
        /// </summary>


        public ECountry ActualizarCountry(string scodcountry, string snamecountry, string slenguaje, bool bCountryDpto,
            bool bCountryCity, bool bDistrito, bool bBarrio, bool bstatuscountry, string sCountryModiBy, DateTime tCountryDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZARCOUNTRY", scodcountry, snamecountry, slenguaje, bCountryDpto,
                bCountryCity, bDistrito, bBarrio, bstatuscountry, sCountryModiBy, tCountryDateModiBy);
            ECountry oeacountry = new ECountry();
            oeacountry.codCountry = scodcountry;
            oeacountry.NameCountry = snamecountry;
            oeacountry.codLenguaje = slenguaje;
            oeacountry.CountryDpto = bCountryDpto;
            oeacountry.CountryCiudad = bCountryCity;
            oeacountry.CountryDistrito = bDistrito;
            oeacountry.CountryBarrio = bBarrio;
            oeacountry.Countrystatus = bstatuscountry;
            oeacountry.CountryModiBy = sCountryModiBy;
            oeacountry.CountryDateModiBy = tCountryDateModiBy;

            return oeacountry;


        }


    }
}
