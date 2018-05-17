using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Canales
    /// Creada Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación: 13/06/2009
    /// Descripcion: Define los Metodos del negocio para transaccionar Canales en la capa de presentación
    /// Modificaciones: 25-06-09 se cambia idCadena por int , ahora es un identity. Ing. Mauricio Ortiz
    /// Requerimiento No <>
    /// </summary>

    public class Cadenas
    {
        public Cadenas(){
        
            //Se define el Constructor por defecto
        
        }

        /// <summary>
        /// Metodo para Registrar Cadenas 
        /// Requerimiento No:<>
        /// </summary>

        public ECadenas RegisterCadena(string snameCadena, bool bstatuscadena, string sCrateByCadena,
            DateTime tDateByCadena, string sModiByCadena, DateTime tDateModiByCadena) {
                DCadenas odcadenas = new DCadenas();
                ECadenas oecanales = odcadenas.RegisterCadena(snameCadena, bstatuscadena, sCrateByCadena, tDateByCadena,
                    sModiByCadena, tDateModiByCadena);
                odcadenas = null;
                return oecanales;
               
             
        }
        /// <summary>
        /// Metodo para Consultar  Cadenas 
        /// Requerimiento No:<>
        /// </summary>

        public DataTable ConsultarCadenas(string snameCadena) {

            DCadenas odccadenas = new DCadenas();
            DataTable dt = odccadenas.ConsultarCadenas(snameCadena);
            return dt;
      }
        /// <summary>
           /// Metodo para Actualizar Cadenas 
           /// Requerimiento No:<>
           /// </summary>

        public ECadenas ActualizarCadena(int iidCadena, string snameCadena, bool bstatuscadena, string sModiByCadena, DateTime tDateModiByCadena)
        {
            DCadenas odacadenas = new DCadenas();
            ECadenas oeacanales = odacadenas.ActualizarCadena(iidCadena, snameCadena, bstatuscadena, sModiByCadena, tDateModiByCadena);
            odacadenas = null;
            return oeacanales;
        }


    }
}
