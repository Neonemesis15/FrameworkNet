using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{   
    /// <summary>
    /// Clase:              EReports
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  06/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-022 Gestión de Reportes
    ///                     «Functional» SIGE-ARF-073 Crear Reporte 
    ///                     «Functional» SIGE-ARF-074 Consulta Reporte
    ///                     «Functional» SIGE-ARF-075 Actualizar Reporte
    ///                     «Functional» SIGE-ARF-076 Deshabilitar Reporte
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Reports
    ///                     permite al administrador del sistema gestionar los Reportes, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Reportes.
    ///                     Permite registrar todos los reportes usuados por la Aplicación SIGE, para tal fin 
    ///                     se listaran en este maestro todos los reportes definidos para los diferentes modulos de SIGE.
    ///                     //
    /// </summary>
    
    public class EReports
    {
        
        private int lReportId;
        private int lorder_report;
        private string lReportNameReport;
        private string lReportDescription;
        private string lModuloid;
        private int lidTypeReport;
        private int lidindicador;
        private bool lReport_Status;
        private string lReportCreateBy;
        private DateTime lReportDateBy;
        private string lReportModiBy;
        private DateTime lReportDateModiBy;
       
        private int lid_ReportModulo;
        private string lModulo_id;
        private bool lReportModulo_Status;
        private string lReportModulo_CreateBy;
        private DateTime lReportModulo_DateBy;
        private string lReportModulo_ModiBy;
        private DateTime lReportModulo_DateModiBy;

        private int lid_ReportTypeReport;        
        private int lid_TypeReport;
        private bool lReportTypeReport_Status;
        private string lReportTypeReport_CreateBy;
        private DateTime lReportTypeReport_DateBy;
        private string lReportTypeReport_ModiBy;
        private DateTime lReportTypeReport_DateModiBy;


        public int reportId
        {
            get { return this.lReportId;}
            set { this.lReportId = value;}
        }

        public int order_report
        {
            get { return this.lorder_report; }
            set { this.lorder_report = value; }
        }


        public string ReportNameReport
        {
            get { return this.lReportNameReport; }
            set { this.lReportNameReport = value;}
        }

        public string ReportDescription
        {
            get { return this.lReportDescription; }
            set { this.lReportDescription = value; }
        }

        public string moduloid
        {
            get { return this.lModuloid; }
            set { this.lModuloid = value;}
        }

        public int idTypeReport
        {
            get { return this.lidTypeReport;}
            set { this.lidTypeReport= value; }
        }

        public int idindicador
        {
            get { return this.lidindicador; }
            set { this.lidindicador = value; }
        }


        public bool Report_Status
        {
            get { return this.lReport_Status; }
            set { this.lReport_Status = value; }
        }

        public string ReportCreateBy
        {
            get { return this.lReportCreateBy; }
            set { this.lReportCreateBy = value; }
        }

        public DateTime ReportDateBy
        {
            get { return this.lReportDateBy;}
            set { this.lReportDateBy = value; }
        }

        public string ReportModiBy
        {
            get { return this.lReportModiBy; }
            set { this.lReportModiBy = value; }
        }

        public DateTime ReportDateModiBy
        {
            get { return this.lReportDateModiBy; }
            set { this.lReportDateModiBy = value;}
        }


        public int id_ReportModulo
        {
            get { return this.lid_ReportModulo; }
            set { this.lid_ReportModulo = value;}
        }
        public string Modulo_id
        {
            get { return this.lModulo_id; }
            set { this.lModulo_id = value;}
        }
        public bool ReportModulo_Status
        {
            get { return this.lReportModulo_Status; }
            set { this.lReportModulo_Status = value;}
        }
        public string ReportModulo_CreateBy
        {
            get { return this.lReportModulo_CreateBy; }
            set { this.lReportModulo_CreateBy = value;}
        }
        public DateTime ReportModulo_DateBy
        {
            get { return this.lReportModulo_DateBy; }
            set { this.lReportModulo_DateBy = value;}
        }
        public string ReportModulo_ModiBy
        {
            get { return this.lReportModulo_ModiBy; }
            set { this.lReportModulo_ModiBy = value;}
        }
        public DateTime ReportModulo_DateModiBy
        {
            get { return this.lReportModulo_DateModiBy; }
            set { this.lReportModulo_DateModiBy = value; }
        }

        public int id_ReportTypeReport
        {
            get { return this.lid_ReportTypeReport; }
            set { this.lid_ReportTypeReport= value; }
        }
        public int id_TypeReport
        {
            get { return this.lid_TypeReport; }
            set { this.lid_TypeReport= value; }
        }
        public bool ReportTypeReport_Status
        {
            get { return this.lReportTypeReport_Status; }
            set { this.lReportTypeReport_Status= value; }
        }
        public string ReportTypeReport_CreateBy
        {
            get { return this.lReportTypeReport_CreateBy; }
            set { this.lReportTypeReport_CreateBy= value; }
        }
        public DateTime ReportTypeReport_DateBy
        {
            get { return this.lReportTypeReport_DateBy; }
            set { this.lReportTypeReport_DateBy= value; }
        }
        public string ReportTypeReport_ModiBy
        {
            get { return this.lReportTypeReport_ModiBy; }
            set { this.lReportTypeReport_ModiBy= value; }
        }
        public DateTime ReportTypeReport_DateModiBy
        {
            get { return this.lReportTypeReport_DateModiBy; }
            set { this.lReportTypeReport_DateModiBy= value; }
        }
    }
}
