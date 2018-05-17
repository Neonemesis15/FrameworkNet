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
    /// Clase: Report Channel
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 25/10/2010
    /// Description: Establece los metodos para operar informacion relacionada con el maestro de Asignación de reportes a Canal.
    /// Requerimiento No:
    /// </summary>
    
    public class ReportChannel
    {
        public ReportChannel()
        {
            //Se define el constructor por defecto
        }
        /// <summary>
        /// Registrar asignación de reportes por canal.
        /// 25/10/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iReport_id"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="bReportCanal_Status"></param>
        /// <param name="sReportCana_CreateBy"></param>
        /// <param name="tReportCana_DateBy"></param>
        /// <param name="sReportCana_ModiBy"></param>
        /// <param name="tReportCana_DateModiBy"></param>
        /// <returns>oeRCanal</returns>
        public EReportChannel RegistrarReportesCanal(int iReport_id, int iCompany_id, string scod_Channel, bool bReportCanal_Status,
            string sReportCana_CreateBy, DateTime tReportCana_DateBy, string sReportCana_ModiBy, DateTime tReportCana_DateModiBy, string Alias, string Id_Tiporeport)
        {
            DReportChannel odrReporteCanal = new DReportChannel();
            EReportChannel oeRCanal = odrReporteCanal.RegistrarRepVsCanal(iReport_id, iCompany_id, scod_Channel, bReportCanal_Status,
            sReportCana_CreateBy, tReportCana_DateBy, sReportCana_ModiBy, tReportCana_DateModiBy, Alias, Id_Tiporeport);
            odrReporteCanal = null;
            return oeRCanal;
        }

        public DataTable RegistrarRepVsCanalTMP(string iReport_id, string sAlias, string iCompany_id, string scod_Channel, char bReportCanal_Status,
           string sID_TIPOREPORTE)
        {
            DReportChannel odsReporteCanal = new DReportChannel();
            DataTable dtReporteCanal = odsReporteCanal.RegistrarRepVsCanalTMP(iReport_id, sAlias, iCompany_id, scod_Channel, bReportCanal_Status, sID_TIPOREPORTE);
            odsReporteCanal = null;
            return dtReporteCanal;
        }
        
        /// <summary>
        /// Consulta asignaciones de Reportes a canal
        /// 25/10/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="iReportId"></param>
        /// <returns>dtReporteCanal</returns>
        public DataTable ConsultarReporteCanal(int iCompany_id, string scod_Channel, int iReportId)
        {
            DReportChannel odsReporteCanal = new DReportChannel();
            EReportChannel oeRCanal=new EReportChannel();            
            DataTable dtReporteCanal = odsReporteCanal.ConsultaReportChannel (iCompany_id, scod_Channel, iReportId);
            odsReporteCanal = null;
            return dtReporteCanal;
        }

        /// <summary>
        /// permite Actualizar asignación de reportes por Canal.
        /// </summary>
        /// <param name="iReportCanal_id"></param>
        /// <param name="bReportCanal_Status"></param>
        /// <param name="sReportCana_ModiBy"></param>
        /// <param name="tReportCana_DateModiBy"></param>
        /// <returns>oeaRC</returns>
        public EReportChannel Actualizar_ReportesCanal(int iReportCanal_id, bool bReportCanal_Status,
            string sReportCana_ModiBy, DateTime tReportCana_DateModiBy)
        {
            DReportChannel odaReportChannel = new DReportChannel();
            EReportChannel oeaRC=odaReportChannel.Actualizar_ReportChannel(iReportCanal_id, bReportCanal_Status,
            sReportCana_ModiBy, tReportCana_DateModiBy);
            odaReportChannel = null;
            return oeaRC;
        }

    }
}
