using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EReportsStrategit
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  12/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-023 Gestionar Reportes Para Servicios
    ///                     «Functional» SIGE-ARF-077 Crear Relacion Servicio Reporte
    ///                     «Functional» SIGE-ARF-078 Consultar Relacion Servicio Reporte
    ///                     «Functional» SIGE-ARF-079 Actualizar Relacion Servicio Reporte
    ///                     «Functional» SIGE-ARF-080 Deshabilitar Relacion Servicio Reporte
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase ReportsStrategit
    ///                     permite al administrador del sistema gestionar la relación de servicios vs reportes, 
    ///                     por medio de las operaciones de Crear, Consultar, Actualizar e Inactivar relación de servicios vs
    ///                     reportes
    /// </summary>
    /// 
    public class EReportsStrategit
    {
         public EReportsStrategit()
        {        
        //Se define el contructor por defecto
        }

        private int lReportSt_id;
        private int lReport_id;
        private int lcod_Strategy;
        private bool lReportSt_Status;
        private string lReportSt_CreateBy;
        private DateTime lReportSt_DateBy;
        private string lReportSt_ModiBy;
        private DateTime lReportSt_DateModiBy;

        public int ReportSt_id
        {
            get { return this.lReportSt_id; }
            set { this.lReportSt_id = value; }
        }

        public int Report_id
        {
            get { return this.lReport_id; }
            set { this.lReport_id = value; }
        }

        public int cod_Strategy
        {
            get { return this.lcod_Strategy; }
            set { this.lcod_Strategy = value; }
        }

        public bool ReportSt_Status
        {
            get { return this.lReportSt_Status; }
            set { this.lReportSt_Status = value; }
        }

        public string ReportSt_CreateBy
        {
            get { return this.lReportSt_CreateBy; }
            set { this.lReportSt_CreateBy = value; }
        }

        public DateTime ReportSt_DateBy
        {
            get { return this.lReportSt_DateBy; }
            set { this.lReportSt_DateBy = value; }
        }

        public string ReportSt_ModiBy
        {
            get { return this.lReportSt_ModiBy; }
            set { this.lReportSt_ModiBy = value; }
        }

        public DateTime ReportSt_DateModiBy
        {
            get { return this.lReportSt_DateModiBy; }
            set { this.lReportSt_DateModiBy = value; }
        }
    }
}