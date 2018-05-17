using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// Descripción breve de DRoles.
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate:23/10/2010
    /// Requerimiento:
    public class DReportChannel
    {
         private Conexion oConn;
         public DReportChannel()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }


        /// <summary>
        /// Permite registrar la información del maestro de reportees canal.
        /// 23/10/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iReport_id"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="bReportCanal_Status"></param>
        /// <param name="sReportCana_CreateBy"></param>
        /// <param name="tReportCana_DateBy"></param>
        /// <param name="sReportCana_ModiBy"></param>
        /// <param name="tReportCana_DateModiBy"></param>
         /// <returns>oerRChannel</returns>
         public EReportChannel RegistrarRepVsCanal(int iReport_id, int iCompany_id, string scod_Channel, bool bReportCanal_Status,
            string sReportCana_CreateBy, DateTime tReportCana_DateBy, string sReportCana_ModiBy, DateTime tReportCana_DateModiBy, string Alias, string Id_Tiporeport)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERREPORTCHANNEL", iReport_id, iCompany_id, scod_Channel, bReportCanal_Status,
            sReportCana_CreateBy, tReportCana_DateBy, sReportCana_ModiBy, tReportCana_DateModiBy, Alias, Id_Tiporeport);

            EReportChannel oerRChannel = new EReportChannel();

            oerRChannel.Report_id = iReport_id;
            oerRChannel.Company_id = iCompany_id;
            oerRChannel.cod_Channel = scod_Channel;
            oerRChannel.ReportCanal_Status = bReportCanal_Status;
            oerRChannel.ReportCana_CreateBy = sReportCana_CreateBy;
            oerRChannel.ReportCana_DateBy = tReportCana_DateBy;
            oerRChannel.ReportCana_ModiBy = sReportCana_ModiBy;
            oerRChannel.ReportCana_DateModiBy = tReportCana_DateModiBy;   
             oerRChannel.ReportCanal_id= Convert.ToInt32(dt.Rows[0]["id"].ToString());

            return oerRChannel;
        }

         /// <summary>
         /// Permite registrar la información del maestro de TBL_OPCIONES_REPORTES.
         /// 21/11/2011 Carlos Marin 
         /// </summary>
         public DataTable RegistrarRepVsCanalTMP(string iReport_id, string sAlias, string iCompany_id, string scod_Channel, char bReportCanal_Status,
            string sID_TIPOREPORTE)
         {

             Conexion cn = new Conexion(2);

             DataTable dt = cn.ejecutarDataTable("UP_WEBXPLORA_AD_INSERTAR_TBL_REPORTES", iReport_id, sAlias, iCompany_id, scod_Channel, bReportCanal_Status, sID_TIPOREPORTE);


             return dt;
         }


      /// <summary>
      /// permite consultar información de maestro Asignación de reportes
      /// 23/10/2010 Magaly Jiménez
      /// </summary>
      /// <param name="iCompany_id"></param>
      /// <param name="scod_Channel"></param>
      /// <param name="iReportId"></param>
      /// <returns></returns>
     
         public DataTable ConsultaReportChannel( int iCompany_id, string scod_Channel, int iReportId)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTARREPORTCHANNEL", iCompany_id, scod_Channel, iReportId);
            EReportChannel oeReportChannel = new EReportChannel();
             
             
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeReportChannel.ReportCanal_id = Convert.ToInt32(dt.Rows[i]["ReportCanal_id"].ToString().Trim());
                        oeReportChannel.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeReportChannel.Report_id = Convert.ToInt32(dt.Rows[i]["Report_id"].ToString().Trim());
                        oeReportChannel.cod_Channel = (dt.Rows[i]["cod_Channel"].ToString().Trim());
                        oeReportChannel.ReportCanal_Status = Convert.ToBoolean(dt.Rows[i]["ReportCanal_Status"].ToString().Trim()); 
                        
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
        /// permite Actualizar información de maestro de reportChannel.
        /// 23/10/2010 Magaly Jimpenez.
        /// </summary>
        /// <param name="iReportCanal_id"></param>
        /// <param name="bReportCanal_Status"></param>
        /// <param name="sReportCana_ModiBy"></param>
        /// <param name="tReportCana_DateModiBy"></param>
        /// <returns></returns>

         public EReportChannel Actualizar_ReportChannel(int iReportCanal_id, bool bReportCanal_Status,
            string sReportCana_ModiBy, DateTime tReportCana_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_REPORTCHANNEL", iReportCanal_id, bReportCanal_Status,
            sReportCana_ModiBy, tReportCana_DateModiBy);
            EReportChannel oeaReporteChannel = new EReportChannel();


            oeaReporteChannel.ReportCanal_Status = bReportCanal_Status;
            oeaReporteChannel.ReportCana_ModiBy = sReportCana_ModiBy;
            oeaReporteChannel.ReportCana_DateModiBy =tReportCana_DateModiBy ;

            return oeaReporteChannel;
        }


    }
}
