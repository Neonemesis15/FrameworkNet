using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// Descripción métodos para AD_Report_Oficina
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate: 04-11-2010
    /// Requerimiento:
    public class DAD_ReportOficina
    {
        private Conexion oConn;
        public DAD_ReportOficina()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        /// <summary>
        /// Permite registrar asociaciones de Reporte a Oficinas.
        /// 04/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iReport_Id"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="bReport_Oficina_Status"></param>
        /// <param name="sReport_Oficina_CreateBy"></param>
        /// <param name="tReport_Oficina_DateBy"></param>
        /// <param name="sReport_Oficina_ModiBy"></param>
        /// <param name="tReport_Oficina_DateModiBy"></param>
        /// <returns></returns>
        public EAD_Report_Oficina RegistrarReportsOficina(int iReport_Id, long lcod_Oficina, bool bReport_Oficina_Status,
         string sReport_Oficina_CreateBy, DateTime tReport_Oficina_DateBy, string sReport_Oficina_ModiBy, DateTime tReport_Oficina_DateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_REPORT_OFICINA", iReport_Id, lcod_Oficina, bReport_Oficina_Status,
           sReport_Oficina_CreateBy,  tReport_Oficina_DateBy,  sReport_Oficina_ModiBy,  tReport_Oficina_DateModiBy);

            EAD_Report_Oficina oerReporOficina = new EAD_Report_Oficina();

            oerReporOficina.Report_Id = iReport_Id;
            oerReporOficina.cod_Oficina = lcod_Oficina;
            oerReporOficina.Report_Oficina_Status = bReport_Oficina_Status;
            oerReporOficina.Report_Oficina_CreateBy = sReport_Oficina_CreateBy;
            oerReporOficina.Report_Oficina_DateBy = tReport_Oficina_DateBy;
            oerReporOficina.Report_Oficina_ModiBy = sReport_Oficina_ModiBy;
            oerReporOficina.Report_Oficina_DateModiBy = tReport_Oficina_DateModiBy;         
            return oerReporOficina;

        }
        /// <summary>
        /// Permite Actualizar asociaciones de Reporte a Oficinas.
        /// 04/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="lid_ReportOficina"></param>
        /// <param name="iReport_Id"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="bReport_Oficina_Status"></param>
        /// <param name="sReport_Oficina_ModiBy"></param>
        /// <param name="tReport_Oficina_DateModiBy"></param>
        /// <returns></returns>
        public EAD_Report_Oficina Actualizar_ReportOficina(int iReport_Id, long lcod_Oficina, bool bReport_Oficina_Status,
            string sReport_Oficina_ModiBy, DateTime tReport_Oficina_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_REPORTOFICINA",  iReport_Id, lcod_Oficina, bReport_Oficina_Status,
            sReport_Oficina_ModiBy,tReport_Oficina_DateModiBy);

            EAD_Report_Oficina oeacReportOf = new EAD_Report_Oficina();
            oeacReportOf.Report_Id = iReport_Id;
            oeacReportOf.cod_Oficina = lcod_Oficina;
            oeacReportOf.Report_Oficina_Status = bReport_Oficina_Status;
            oeacReportOf.Report_Oficina_ModiBy = sReport_Oficina_ModiBy;
            oeacReportOf.Report_Oficina_DateModiBy = tReport_Oficina_DateModiBy;
            return oeacReportOf;
        }
    }
}
