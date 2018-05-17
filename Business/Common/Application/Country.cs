using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Country
    /// Creada Por: Ing. Carlos Alberto Hernandez R
    /// Fecha de Creacion: 13/06/2009
    /// Descripcion: Define los metodos del Negocio para Crear Paises
    /// Requerimiento No <>
    /// </summary>

     public class Country
       {
         public Country() { 
         
         //Define el Constructor por defecto
         
         }
           /// <summary>
        /// Metodo para Crear Paises
        /// </summary>


         public ECountry RegisterCountry(string scodcountry, string snamecountry, string slenguaje, bool bCountryDpto,
             bool bCountryCity, bool bDistrito, bool bBarrio, bool bstatuscountry, string sCountryCreateBy, DateTime tCountryDateBy,
             string sCountryModiBy, DateTime tCountryDateModiBy) {
                 DCountry odrcountry = new DCountry();
                 ECountry oercountry = odrcountry.RegisterCountry(scodcountry, snamecountry, slenguaje, bCountryDpto, bCountryCity, bDistrito,
                     bBarrio, bstatuscountry, sCountryCreateBy, tCountryDateBy, sCountryModiBy, tCountryDateModiBy);
                 odrcountry = null;
                 return oercountry;
           
         
           }
         /// <summary>
         /// Metodopara Consultar Paises
         /// </summary>


         public DataTable ConsultarCountry(string scodcountry, string snamecountry)
         {
             DCountry odscountry = new DCountry();
             DataTable dt = odscountry.ConsultarCountry(scodcountry, snamecountry);
             return dt;
         }
         /// <summary>
        /// Metodo para Actualizar Paises
        /// </summary>


         public ECountry ActualizarCountry(string scodcountry, string snamecountry, string slenguaje, bool bCountryDpto,
             bool bCountryCity, bool bDistrito, bool bBarrio, bool bstatuscountry, string sCountryModiBy, DateTime tCountryDateModiBy) {
                 DCountry odacountry = new DCountry();
                 ECountry oeacountry = odacountry.ActualizarCountry(scodcountry, snamecountry, slenguaje, bCountryDpto, bCountryCity, bDistrito,
                     bBarrio, bstatuscountry, sCountryModiBy, tCountryDateModiBy);
                 odacountry = null;
                 return oeacountry;
         
         
         
         }
        

       }
}
