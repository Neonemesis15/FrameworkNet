using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Security;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de Destrategy.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:27/05/2009
    /// Requerimiento:
    public class DEstrategy
    {
        private Conexion oConn;
         public DEstrategy()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
         //Método para Registrar Servicios
         public EEstrategy RegistrarServiciosPK(string sStrategyName, string sStrategyDescription, string scodCountry, bool sStrategyStatus, string sStrategyCreateBy, string sStrategyDateBy, string sStrategyModiBy, String sStrategyDateModiBy)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERSERVICES", sStrategyName, sStrategyDescription, scodCountry, sStrategyStatus, sStrategyCreateBy, sStrategyDateBy, sStrategyModiBy, sStrategyDateModiBy);
             EEstrategy oerServicios = new EEstrategy();
             oerServicios.StrategyName = sStrategyName;
             oerServicios.StrategyDescription = sStrategyDescription;
             oerServicios.codCountry = scodCountry;
             oerServicios.StrategyStatus = Convert.ToBoolean(sStrategyStatus.ToString().Trim());
             oerServicios.StrategyCreateBy = sStrategyCreateBy;
             oerServicios.StrategyDateBy = sStrategyDateBy;
             oerServicios.StrategyModiBy = sStrategyModiBy;
             oerServicios.StrategyDateModiBy = sStrategyDateModiBy;
             return oerServicios;
         }
         //Método para Actualizar Servicios Ing. Carlos Alberto Hernandez
         public EEstrategy Actualizar_Servicios(int icodstrategy, string sStrategyName, string sStrategyDescription, string scodCountry, bool sStrategyStatus, string sStrategyModiBy, String sStrategyDateModiBy)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_SERVICIOS",icodstrategy, sStrategyName, sStrategyDescription, scodCountry, sStrategyStatus, sStrategyModiBy, sStrategyDateModiBy);
             EEstrategy oeaServicios = new EEstrategy();
             oeaServicios.codStrategy = icodstrategy;
             oeaServicios.StrategyName = sStrategyName;
             oeaServicios.StrategyDescription = sStrategyDescription;
             oeaServicios.codCountry = scodCountry;
             oeaServicios.StrategyStatus = Convert.ToBoolean(sStrategyStatus.ToString().Trim());
            oeaServicios.StrategyModiBy = sStrategyModiBy;
             oeaServicios.StrategyDateModiBy = sStrategyDateModiBy;
             return oeaServicios;
         }

         /// <summary>
         ///Nombre Metodo: Search_Servicios
         ///Función: Permite Consultar servicios Lucky
         /// </summary>

         public DataTable ObtenerServicios(string sStrategyName, string scodcountry)
         {

             DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHSERVICIOS", sStrategyName, scodcountry);
             EEstrategy oeEstrategy = new EEstrategy();            
             

             if (dt != null)
             {

                 if (dt.Rows.Count > 0)
                 {

                     for (int i = 0; i <= dt.Rows.Count - 1; i++)
                     {
                         oeEstrategy.codStrategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"].ToString().Trim());
                         oeEstrategy.StrategyName = dt.Rows[i]["Strategy_Name"].ToString().Trim();
                         oeEstrategy.StrategyDescription = dt.Rows[i]["Strategy_Description"].ToString().Trim();
                         oeEstrategy.codCountry = dt.Rows[i]["cod_Country"].ToString().Trim();
                         oeEstrategy.StrategyStatus = Convert.ToBoolean(dt.Rows[i]["Strategy_Status"].ToString().Trim());
                         oeEstrategy.StrategyCreateBy = dt.Rows[i]["Strategy_CreateBy"].ToString().Trim();
                         oeEstrategy.StrategyDateBy = dt.Rows[i]["Strategy_DateBy"].ToString().Trim();
                         oeEstrategy.StrategyModiBy = dt.Rows[i]["Strategy_ModiBy"].ToString().Trim();
                         oeEstrategy.StrategyDateModiBy = dt.Rows[i]["Strategy_DateModiBy"].ToString().Trim();
                     }
                 }
                 return dt;
             }
             else
             {
                 return null;
             }
         }
    }
}
