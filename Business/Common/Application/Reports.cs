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
    /// Clase: Company
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 01/06/2009
    /// Description: Establece los metodos para operar informacion relacionada con Reportes Lucky
    /// Requerimiento No
    /// </summary>
    public class Reports
    {
        public Reports()
        {
            //Se define el constructor por defecto
        }

        //----Metodo que permite registrar Reportes
        //Modificación: 29-09-09 de acuerdo a la nueva concepción se hara actualización del informe en estado y descripción
        // y se insertará en dos tablas nuevas la relacion de informes con modulo e informes con tipos de informe. Ing. Mauricio Ortiz

        public EReports RegistrarReportes(int iorder_report, string sReport_NameReport, string sReport_Description, bool bReport_Status, string sReport_CreateBy, DateTime tReport_DateBy, string sReport_ModiBy,
            DateTime tReport_DateModiBy)
        {
            DReports odrReportes = new DReports();
            EReports oeReportes = odrReportes.registrarReportesPK(iorder_report, sReport_NameReport, sReport_Description, bReport_Status, sReport_CreateBy, tReport_DateBy, sReport_ModiBy,
             tReport_DateModiBy);

            odrReportes = null;
            return oeReportes;
        }

        public EReports registrarReportesTMP(string sID_REPORTE, string sReport_NameReport, char cREP_STATUS)
        {
            DReports odrReportes = new DReports();
            EReports oeReportes = odrReportes.registrarReportesTMP(sID_REPORTE, sReport_NameReport, cREP_STATUS);

            odrReportes = null;
            return oeReportes;
        }

        //----Metodo que permite registrar relación de Informes con módulos


        public EReports RegistrarReportesModulos(int iReport_Id, string sModulo_id, bool bReportModulo_Status, string sReportModulo_CreateBy, DateTime tReportModulo_DateBy,
            string sReportModulo_ModiBy, DateTime tReportModulo_DateModiBy)
        {
            DReports odrReportes = new DReports();
            EReports oeReportes = odrReportes.registrarReportesModulosPK(iReport_Id, sModulo_id, bReportModulo_Status, sReportModulo_CreateBy, tReportModulo_DateBy,
            sReportModulo_ModiBy, tReportModulo_DateModiBy);
            odrReportes = null;
            return oeReportes;
        }

        //----Metodo que permite registrar relación de Informes con tipos de informe


        public EReports RegistrarReportesTiposInf(int iReport_Id, int iid_TypeReport, bool bReportTypeReport_Status,
            string sReportTypeReport_CreateBy, DateTime tReportTypeReport_DateBy, string sReportTypeReport_ModiBy, DateTime tReportTypeReport_DateModiBy)
        {
            DReports odrReportes = new DReports();
            EReports oeReportes = odrReportes.registrarReportesTipoInfPK(iReport_Id, iid_TypeReport, bReportTypeReport_Status,
             sReportTypeReport_CreateBy, tReportTypeReport_DateBy, sReportTypeReport_ModiBy, tReportTypeReport_DateModiBy);
            odrReportes = null;
            return oeReportes;
        }


        //----Metodo que permite registrar Reportes vs Servicios

        public EReportsStrategit RegistrarRepVsSer(int icod_Strategy, int iReport_id, bool bReportSt_Status,
            string sReportSt_CreateBy, DateTime tReportSt_DateBy, string sReportSt_ModiBy, DateTime tReportSt_DateModiBy)
        {
            DReportsStrategit odrRepVsSer = new DReportsStrategit();
            EReportsStrategit oeRepVsSer = odrRepVsSer.RegistrarRepVsEsPK(icod_Strategy, iReport_id, bReportSt_Status,
             sReportSt_CreateBy, tReportSt_DateBy, sReportSt_ModiBy, tReportSt_DateModiBy);

            odrRepVsSer = null;
            return oeRepVsSer;

        }


        //---Metodo de Consulta de Informes

        public DataTable BuscarInforme(string sReportid)
        {
            Lucky.Data.Common.Application.DReports odseInforme = new Lucky.Data.Common.Application.DReports();
            EReports oeInforme = new EReports();
            DataTable dtInforme = odseInforme.ObtenerInformes(sReportid);
            odseInforme = null;
            return dtInforme;
        }

        //---Metodo de Consulta de Informes por servicio

        public DataTable BuscarInfXServicio(int icodStrategy)
        {
            Lucky.Data.Common.Application.DReportsStrategit odseInfxserv = new Lucky.Data.Common.Application.DReportsStrategit();
            EReports oeInforme = new EReports();
            EQuestions_Strategy oeInfporServ = new EQuestions_Strategy();
            DataTable dtInforme = odseInfxserv.ObtenerInfXServicio(icodStrategy);
            odseInfxserv = null;
            return dtInforme;
        }

        //---Metodo de Consulta de Informes por servicio para indicadores


        public DataTable BuscarInfXServHabilitado(int icodStrategy)
        {
            Lucky.Data.Common.Application.DReportsStrategit odseInfxserv = new Lucky.Data.Common.Application.DReportsStrategit();
            EReports oeInforme = new EReports();
            EQuestions_Strategy oeInfporServ = new EQuestions_Strategy();
            DataTable dtInforme = odseInfxserv.ObtenerInfXServhabilitado(icodStrategy);
            odseInfxserv = null;
            return dtInforme;
        }



        //---Metodo de Consulta de modulos del Informes 

        public DataTable BuscarInformeModulo(int iReport_Id)
        {
            Lucky.Data.Common.Application.DReports odseInforme = new Lucky.Data.Common.Application.DReports();
            EReports oeInforme = new EReports();
            DataTable dtInforme = odseInforme.ObtenerInformesModulo(iReport_Id);
            odseInforme = null;
            return dtInforme;
        }

        //---Metodo de Consulta de modulos del Informe 

        public DataTable BuscarInformetipoInf(int iReport_Id)
        {
            Lucky.Data.Common.Application.DReports odseInforme = new Lucky.Data.Common.Application.DReports();
            EReports oeInforme = new EReports();
            DataTable dtInforme = odseInforme.ObtenerInformesTipoInf(iReport_Id);
            odseInforme = null;
            return dtInforme;
        }


        //---Metodo de Consulta de Informes vs Servicios

        public DataTable BuscarRepVsServ(int icodStrategy, int ReportId)
        {
            Lucky.Data.Common.Application.DReportsStrategit odseRepVsServ = new Lucky.Data.Common.Application.DReportsStrategit();
            EReportsStrategit oeRepVsServ = new EReportsStrategit();


            DataTable dtRepVsServ = odseRepVsServ.ObtenerRepVsEs(icodStrategy, ReportId);
            odseRepVsServ = null;
            return dtRepVsServ;
        }

        //----Metodo que permite Actualizar Informes ing. Mauricio Ortiz

        public EReports Actualizar_Reporte(int iReport_Id, int iorder_report, string sReport_NameReport, string sReport_Description,
            bool bReport_Status, string sReport_ModiBy, DateTime tReport_DateModiBy)
        {
            Lucky.Data.Common.Application.DReports odainformes = new Lucky.Data.Common.Application.DReports();
            EReports oeaInforme = odainformes.Actualizar_informe(iReport_Id, iorder_report, sReport_NameReport, sReport_Description,
             bReport_Status, sReport_ModiBy, tReport_DateModiBy);
            odainformes = null;
            return oeaInforme;
        }


        public EReports Actualizar_informeTMP(string sID_REPORTE, string sReport_NameReport, char cREP_STATUS)
        {
            Lucky.Data.Common.Application.DReports odainformes = new Lucky.Data.Common.Application.DReports();
             EReports oeaInforme = odainformes.Actualizar_informeTMP(sID_REPORTE, sReport_NameReport, cREP_STATUS);

             odainformes = null;
            return oeaInforme;
        }

        //----Metodo que permite Actualizar Informes vs servicios ing. Mauricio Ortiz

        public EReportsStrategit Actualizar_InformeVsServ(int iReportSt_id, int icod_Strategy, bool bReportSt_Status,
            string sReportSt_ModiBy, DateTime tReportSt_DateModiBy)
        {
            Lucky.Data.Common.Application.DReportsStrategit odainformesvsServ = new Lucky.Data.Common.Application.DReportsStrategit();
            EReportsStrategit oeaInformevsServ = odainformesvsServ.Actualizar_informevsServ(iReportSt_id, icod_Strategy, bReportSt_Status,
             sReportSt_ModiBy, tReportSt_DateModiBy);

            odainformesvsServ = null;
            return oeaInformevsServ;
        }

        //----Metodo que permite Actualizar relación de Informes con módulos  ing. Mauricio Ortiz

        public EReports Actualizar_Informemodulo(int iReport_Id, string sModulo_id, bool bReportModulo_Status,
            string sReportModulo_ModiBy, DateTime tReportModulo_DateModiBy)
        {
            Lucky.Data.Common.Application.DReports odainformesmodulo = new Lucky.Data.Common.Application.DReports();
            EReports oeaInformeModulo = odainformesmodulo.Actualizar_informemodulo(iReport_Id, sModulo_id, bReportModulo_Status,
             sReportModulo_ModiBy, tReportModulo_DateModiBy);

            odainformesmodulo = null;
            return oeaInformeModulo;
        }

        //----Metodo que permite Actualizar relación de Informes con tipos de informe  ing. Mauricio Ortiz

        public EReports Actualizar_InformeTipoInf(int iReport_Id, int iid_TypeReport, bool bReportTypeReport_Status,
            string sReportTypeReport_ModiBy, DateTime tReportTypeReport_DateModiBy)
        {
            Lucky.Data.Common.Application.DReports odainformesmodulo = new Lucky.Data.Common.Application.DReports();
            EReports oeaInformeModulo = odainformesmodulo.Actualizar_informeTipoInf(iReport_Id, iid_TypeReport, bReportTypeReport_Status,
             sReportTypeReport_ModiBy, tReportTypeReport_DateModiBy);
            odainformesmodulo = null;
            return oeaInformeModulo;
        }
    }
}


    


       