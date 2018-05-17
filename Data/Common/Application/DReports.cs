using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    //CreateBy: Ing. Mauricio Ortiz
    //CreateDate: 01/06/2009
    //Description: Atributos Entidad Reportes
    //Requerimiento:
    //
    public class DReports
    {
        private Conexion oConn;
        public DReports()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        
        //Metodo para Registrar Reportes
        //Modificación: 29-09-09 de acuerdo a la nueva concepción se hara actualización del informe en estado y descripción
        // y se insertará en dos tablas nuevas la relacion de informes con modulo e informes con tipos de informe . Ing. Mauricio Ortiz
        public EReports registrarReportesPK(int iorder_report, string sReport_NameReport, string sReport_Description, bool bReport_Status, string sReport_CreateBy, DateTime tReport_DateBy, string sReport_ModiBy,
            DateTime tReport_DateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERREPORTES", iorder_report, sReport_NameReport, sReport_Description, bReport_Status, sReport_CreateBy, tReport_DateBy, sReport_ModiBy,
             tReport_DateModiBy);

            EReports oerreportes = new EReports();
            oerreportes.order_report = iorder_report;
            oerreportes.ReportNameReport = sReport_NameReport;
            oerreportes.ReportDescription = sReport_Description;            
            oerreportes.Report_Status = bReport_Status;
            oerreportes.ReportCreateBy=sReport_CreateBy;
            oerreportes.ReportDateBy = tReport_DateBy;
            oerreportes.ReportModiBy = sReport_ModiBy;
            oerreportes.ReportDateModiBy = tReport_DateModiBy;
            oerreportes.reportId = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            return oerreportes;
        }

        //Metodo para Registrar Reportes en TMP
        //Carlos Marin 22/08/2011
        public EReports registrarReportesTMP(string sID_REPORTE, string sReport_NameReport, char cREP_STATUS)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERREPORTESTMP", sID_REPORTE, sReport_NameReport, cREP_STATUS);

            EReports oerreportes = new EReports();
            return oerreportes;
        }




        //Metodo para Registrar Relación de Informes con Módulos
        //Modificación: 29-09-09 de acuerdo a la nueva concepción se hara actualización del informe en estado y descripción
        // y se insertará en dos tablas nuevas la relacion de informes con modulo e informes con tipos de informe . Ing. Mauricio Ortiz
        public EReports registrarReportesModulosPK(int iReport_Id, string sModulo_id, bool bReportModulo_Status, string sReportModulo_CreateBy, DateTime tReportModulo_DateBy,
            string sReportModulo_ModiBy, DateTime tReportModulo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERREPORTESMODULOS", iReport_Id, sModulo_id, bReportModulo_Status, sReportModulo_CreateBy, tReportModulo_DateBy,
            sReportModulo_ModiBy, tReportModulo_DateModiBy);

            EReports oerreportes = new EReports();
            oerreportes.reportId = iReport_Id;
            oerreportes.moduloid = sModulo_id;
            oerreportes.ReportModulo_Status = bReportModulo_Status;
            oerreportes.ReportModulo_CreateBy = sReportModulo_CreateBy;
            oerreportes.ReportModulo_DateBy = tReportModulo_DateBy;
            oerreportes.ReportModulo_ModiBy = sReportModulo_ModiBy;
            oerreportes.ReportModulo_DateModiBy = tReportModulo_DateModiBy;
            
            return oerreportes;
        }

        //Metodo para Registrar Relación de Informes con tipos de informe
        //Modificación: 29-09-09 de acuerdo a la nueva concepción se hara actualización del informe en estado y descripción
        // y se insertará en dos tablas nuevas la relacion de informes con modulo e informes con tipos de informe . Ing. Mauricio Ortiz
        public EReports registrarReportesTipoInfPK(int iReport_Id, int iid_TypeReport, bool bReportTypeReport_Status,
            string sReportTypeReport_CreateBy, DateTime tReportTypeReport_DateBy, string sReportTypeReport_ModiBy, DateTime tReportTypeReport_DateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERREPORTESTIPOINF", iReport_Id, iid_TypeReport, bReportTypeReport_Status,
             sReportTypeReport_CreateBy, tReportTypeReport_DateBy, sReportTypeReport_ModiBy, tReportTypeReport_DateModiBy);

            EReports oerreportes = new EReports();
            
            oerreportes.reportId = iReport_Id;            
            oerreportes.idTypeReport = iid_TypeReport;
            oerreportes.ReportTypeReport_Status = bReportTypeReport_Status;
            oerreportes.ReportTypeReport_CreateBy = sReportTypeReport_CreateBy;
            oerreportes.ReportTypeReport_DateBy = tReportTypeReport_DateBy;
            oerreportes.ReportTypeReport_ModiBy = sReportTypeReport_ModiBy;
            oerreportes.ReportTypeReport_DateModiBy = tReportTypeReport_DateModiBy;
            return oerreportes;
        }


        /// <summary>
        ///Nombre Metodo: SEARCHINFORMES
        ///Función: Permite Consultar informes
        /// </summary>

        public DataTable ObtenerInformes(string sReportid)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHINFORMES", sReportid);
            EReports oeReportes = new EReports();

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

        //consultar modulos del informe
        public DataTable ObtenerInformesModulo(int iReport_Id)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHINFORMESMODULOS", iReport_Id);
            EReports oeReportes = new EReports();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeReportes.moduloid = dt.Rows[i]["Modulo_id"].ToString().Trim();
                        oeReportes.ReportModulo_Status = Convert.ToBoolean(dt.Rows[i]["ReportModulo_Status"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //consultar tipos de informe del informe
        public DataTable ObtenerInformesTipoInf(int iReport_Id)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHINFORMESTIPOINF", iReport_Id);
            EReports oeReportes = new EReports();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeReportes.idTypeReport = Convert.ToInt32(dt.Rows[i]["id_TypeReport"].ToString().Trim());
                        oeReportes.ReportTypeReport_Status = Convert.ToBoolean(dt.Rows[i]["ReportTypeReport_Status"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }


        //Método para Actualizar Informes
        
        public EReports Actualizar_informe(int iReport_Id, int iorder_report, string sReport_NameReport, string sReport_Description,
            bool bReport_Status, string sReport_ModiBy,DateTime tReport_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_INFORME", iReport_Id, iorder_report, sReport_NameReport, sReport_Description,
             bReport_Status,  sReport_ModiBy, tReport_DateModiBy );
            EReports oeaInforme = new EReports();
            oeaInforme.ReportNameReport = sReport_NameReport;
            oeaInforme.ReportDescription = sReport_Description;            
            oeaInforme.Report_Status = bReport_Status;
            oeaInforme.ReportModiBy = sReport_ModiBy;
            oeaInforme.ReportDateModiBy = tReport_DateModiBy;
            return oeaInforme;
        }

        //Metodo para Registrar Reportes en TMP
        //Carlos Marin 23/08/2011
        public EReports Actualizar_informeTMP(string sID_REPORTE, string sReport_NameReport, char cREP_STATUS)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_INFORMETMP", sID_REPORTE, sReport_NameReport, cREP_STATUS);
            EReports oeaInforme = new EReports();

            return oeaInforme;
        }

        //Método para actualizar relación de informes con modulos en la aplicacion


        public EReports Actualizar_informemodulo( int iReport_Id, string sModulo_id, bool bReportModulo_Status,
            string sReportModulo_ModiBy, DateTime tReportModulo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_INFORMEMODULOS", iReport_Id, sModulo_id, bReportModulo_Status,
             sReportModulo_ModiBy, tReportModulo_DateModiBy);
            EReports oeaInforme = new EReports();

            oeaInforme.ReportModulo_Status = bReportModulo_Status;
            oeaInforme.ReportModulo_ModiBy = sReportModulo_ModiBy;
            oeaInforme.ReportModulo_DateModiBy = tReportModulo_DateModiBy;
            return oeaInforme;
        }

        //Método para actualizar relación de informes con tipos de informe en la aplicacion


        public EReports Actualizar_informeTipoInf(int iReport_Id, int iid_TypeReport, bool bReportTypeReport_Status,
            string sReportTypeReport_ModiBy, DateTime tReportTypeReport_DateModiBy)
        {

            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_INFORMETIPOINF", iReport_Id, iid_TypeReport, bReportTypeReport_Status,
             sReportTypeReport_ModiBy, tReportTypeReport_DateModiBy);
            EReports oeaInforme = new EReports();

            oeaInforme.ReportTypeReport_Status = bReportTypeReport_Status;
            oeaInforme.ReportTypeReport_ModiBy = sReportTypeReport_ModiBy;
            oeaInforme.ReportTypeReport_DateModiBy = tReportTypeReport_DateModiBy;
            return oeaInforme;
        }

    }
}

