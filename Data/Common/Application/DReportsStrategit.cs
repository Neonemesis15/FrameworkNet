using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
   
    /// Descripción breve de DRoles.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:01/06/2009
    /// Requerimiento:
 
    public class DReportsStrategit
    {
        private Conexion oConn;
        public DReportsStrategit()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Metodo para Registrar reportes vs servicios

        public EReportsStrategit RegistrarRepVsEsPK(int icod_Strategy, int iReport_id, bool bReportSt_Status,
            string sReportSt_CreateBy, DateTime tReportSt_DateBy, string sReportSt_ModiBy, DateTime tReportSt_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERREPVSSERV", icod_Strategy,  iReport_id,  bReportSt_Status,
             sReportSt_CreateBy,  tReportSt_DateBy,  sReportSt_ModiBy,  tReportSt_DateModiBy);

            EReportsStrategit oerRepvsEs = new EReportsStrategit();

            oerRepvsEs.cod_Strategy = icod_Strategy;
            oerRepvsEs.Report_id = iReport_id;
            oerRepvsEs.ReportSt_Status = bReportSt_Status;
            oerRepvsEs.ReportSt_CreateBy = sReportSt_CreateBy;
            oerRepvsEs.ReportSt_DateBy = tReportSt_DateBy;
            oerRepvsEs.ReportSt_ModiBy = sReportSt_ModiBy;
            oerRepvsEs.ReportSt_DateModiBy = tReportSt_DateModiBy;
            
            return oerRepvsEs;
        }


      
        //Nombre Metodo: SEARCHinfvsserv
        //Función: Permite Consultar informes vs servicios
       

        public DataTable ObtenerRepVsEs(int icodStrategy , int ReportId)
        {
          
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHINFvsSERV", icodStrategy,ReportId);
            EReportsStrategit oeRepvsEs = new EReportsStrategit();
            EEstrategy oeEstrategy = new EEstrategy();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeRepvsEs.ReportSt_id = Convert.ToInt32(dt.Rows[i]["ReportSt_id"].ToString().Trim());
                        oeRepvsEs.Report_id = Convert.ToInt32(dt.Rows[i]["Report_id"].ToString().Trim());
                        oeEstrategy.codCountry = (dt.Rows[i]["cod_Country"].ToString().Trim());
                        oeRepvsEs.cod_Strategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"].ToString().Trim());
                        oeRepvsEs.ReportSt_Status = Convert.ToBoolean(dt.Rows[i]["ReportSt_Status"].ToString().Trim()); 
                        
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Nombre Metodo: SEARCHinfvsserv
        //Función: Permite Consultar informes vs servicios


        public DataTable ObtenerInfXServicio(int icodStrategy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_CONSULTAREPORTESXESTRATEGIA", icodStrategy);
            EReportsStrategit oeRepvsEs = new EReportsStrategit();
            EReports oeReports = new EReports();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {                       
                        oeRepvsEs.Report_id = Convert.ToInt32(dt.Rows[i]["Report_id"].ToString().Trim());
                        oeReports.ReportNameReport = dt.Rows[i]["Report_NameReport"].ToString().Trim();
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Nombre Metodo: SEARCHinfvsserv
        //Función: Permite Consultar informes vs servicios para indicadores


        public DataTable ObtenerInfXServhabilitado(int icodStrategy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_CONSULTAINFXSERVHABILITDO", icodStrategy);
            EReportsStrategit oeRepvsEs = new EReportsStrategit();
            EReports oeReports = new EReports();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeRepvsEs.Report_id = Convert.ToInt32(dt.Rows[i]["Report_id"].ToString().Trim());
                        oeReports.ReportNameReport = dt.Rows[i]["Report_NameReport"].ToString().Trim();
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }




        //Método para Actualizar Informes VS servicios

        public EReportsStrategit Actualizar_informevsServ(int iReportSt_id, int icod_Strategy, bool bReportSt_Status,
            string sReportSt_ModiBy , DateTime tReportSt_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_INFORMEvsSERVICIO",iReportSt_id, icod_Strategy,   bReportSt_Status,
             sReportSt_ModiBy ,  tReportSt_DateModiBy );
            EReportsStrategit oeaInformevsServ = new EReportsStrategit();
            
                    
            oeaInformevsServ.ReportSt_Status = bReportSt_Status;           
            oeaInformevsServ.ReportSt_ModiBy = sReportSt_ModiBy;
            oeaInformevsServ.ReportSt_DateModiBy = tReportSt_DateModiBy;

              return oeaInformevsServ;
        }



       

    }
}
