using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    //CreateBy: Carlos Marin
    //CreateDate: 23/08/2011
    //Description: Atributos Entidad Reportes
    //Requerimiento:
   public class DTypeReports
    {
       private Conexion oConn;
       public DTypeReports()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        
        //Metodo para Registrar Tipos de Reportes

       public ETypeReports registrarTipoReporte(string sTypeReport_Name, bool bTypeReport__Status, string sTypeReport_CreateBy, DateTime tTypeReport_DateBy, string sTypeReport_ModiBy,
    DateTime tTypeReport_DateModiBy)
       {
           string idreport = oConn.ejecutarEscalar("UP_WEB_REGISTRAR_TIPO_INFORME", sTypeReport_Name, bTypeReport__Status, sTypeReport_CreateBy, tTypeReport_DateBy, sTypeReport_ModiBy, tTypeReport_DateModiBy);

           ETypeReports oETypeReports = new ETypeReports();
           oETypeReports.TypeReport_Name = sTypeReport_Name;
           oETypeReports.TypeReport__Status = bTypeReport__Status;
           oETypeReports.TypeReport_CreateBy = sTypeReport_CreateBy;
           oETypeReports.TypeReport_DateBy = tTypeReport_DateBy;
           oETypeReports.TypeReport_ModiBy = sTypeReport_ModiBy;
           oETypeReports.TypeReport_DateModiBy = tTypeReport_DateModiBy;
           return oETypeReports;
       }

       /// <summary>
       ///Metodo para Consultar Tipos de Reportes
       /// </summary>

       public DataTable ConsultarTiposReporteXcod(int iid_TypeReport)
       {
           DataTable dt = oConn.ejecutarDataTable("UP_WEB_CONSULAR_TIPO_INFORMEXCOD", iid_TypeReport);
           ETypeReports oETypeReports = new ETypeReports();

           if (dt != null)
           {
               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i <= dt.Rows.Count - 1; i++)
                   {
                       //oeReportes.reportId = Convert.ToInt32(dt.Rows[i]["Report_Id"].ToString().Trim());
                       //oeReportes.ReportNameReport = dt.Rows[i]["Report_NameReport"].ToString().Trim();
                       //oeReportes.ReportDescription = dt.Rows[i]["Report_Description"].ToString().Trim();                        
                       //oeReportes.Report_Status = Convert.ToBoolean(dt.Rows[i]["Report_Status"].ToString().Trim());
                       //oeReportes.ReportCreateBy = dt.Rows[i]["Report_CreateBy"].ToString().Trim();
                       //oeReportes.ReportDateBy = Convert.ToDateTime(dt.Rows[i]["Report_DateBy"].ToString().Trim());
                       //oeReportes.ReportModiBy = dt.Rows[i]["Report_ModiBy"].ToString().Trim();
                       //oeReportes.ReportDateModiBy = Convert.ToDateTime(dt.Rows[i]["Report_DateModiBy"].ToString().Trim());
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
