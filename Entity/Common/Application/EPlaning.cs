using System;
using System.Collections.Generic;

using System.Text;

namespace Lucky.Entity.Common.Application
{    /// <summary>
    /// Descripción breve de EPlanning
    /// CreateBy: Ing. Carlos Alberto Hernandez RIncón
    /// CreateDate:02/05/2009
    /// Requerimientos <SIGE-ARF-026  Gestión Planning,SIGE-ARF-099 Presupuesto Aprobado,SIGE-ARF-034 Construcción Mercaderismo,SIGE-ARF-033 Construcción Degustación,SIGE-ARF-032, Construcción Impulso,SIGE-ARF-031  Construcción Sampling,SIGE-ARF-030 Construcción Visibilidad,SIGE-ARF-029 Construcción Sell Sampling,SIGE-ARF-028  Construcción Canje,SIGE-ARF-035  Construcción Anfitrionaje,SIGE-ARF-027  Construcción Blitz>
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    public class EPlaning
    {
        public EPlaning()
        {
            //Se define el constructor por defecto
        }

        private string lidplanning;
        private string lPlanningName;
        private int lcodStrategy;
        private string lPlanningCodChannel;
        private DateTime lPlanningStartActivity;
        private DateTime lPlanningEndActivity;
        private string lPlanningReportAditional;
        private string lPlanningDevelopmentActivityReport;
        private int lPlanningPersonEje;
        private string lPlanningActivityFormats;
        private string lPlanningAreaInvolved;
        private DateTime lPlanningDateRepSoli;
        private DateTime lPlanningPreproduDateini;
        private DateTime lPlanningPreproduDateEnd;
        private string lPlanningProjectDuration;
        private DateTime lPlanningDateFinreport;
        private string lPlanningVigen;
        private string lPlanningBudget;
        private int lddesignFor;
        private string lnamecontac;
        private string lemailcontac;
        private bool lPlanningStatus;
        private int lStatusid;
        private bool lPlanningFormaCompe;
        private string lPlanningCreateBy;
        private DateTime lPlanningDateBy;
        private string lPlanningModiBy;
        private DateTime lPlanningDateModiBy;

        public string idplanning
        {
            get { return this.lidplanning; }
            set { this.lidplanning = value; }
        }
        public string PlanningName
        {
            get { return this.lPlanningName; }
            set { this.lPlanningName = value; }
        }
        public int codStrategy
        {
            get { return this.lcodStrategy; }
            set { this.lcodStrategy = value; }
        }
        public string PlanningCodChannel
        {
            get { return this.lPlanningCodChannel; }
            set { this.lPlanningCodChannel = value; }
        }
        public DateTime PlanningStartActivity
        {
            get { return this.lPlanningStartActivity; }
            set { this.lPlanningStartActivity = value; }
        }
        public DateTime PlanningEndActivity
        {
            get { return this.lPlanningEndActivity; }
            set { this.lPlanningEndActivity = value; }
        }
        public string PlanningReportAditional
        {
            get { return this.lPlanningReportAditional; }
            set { this.lPlanningReportAditional = value; }
        }
        public string PlanningDevelopmentActivityReport
        {
            get { return this.lPlanningDevelopmentActivityReport; }
            set { this.lPlanningDevelopmentActivityReport = value; }
        }
        public int PlanningPersonEje
        {
            get { return this.lPlanningPersonEje; }
            set { this.lPlanningPersonEje = value; }
        }
        public string PlanningActivityFormats
        {
            get { return this.lPlanningActivityFormats; }
            set { this.lPlanningActivityFormats = value; }
        }
        public string PlanningAreaInvolved
        {
            get { return this.lPlanningAreaInvolved; }
            set { this.lPlanningAreaInvolved = value; }
        }
        public DateTime PlanningDateRepSoli
        {
            get { return this.lPlanningDateRepSoli; }
            set { this.lPlanningDateRepSoli = value; }
        }
        public DateTime PlanningPreproduDateini
        {
            get { return this.lPlanningPreproduDateini; }
            set { this.lPlanningPreproduDateini = value; }
        }
        public DateTime PlanningPreproduDateEnd
        {
            get { return this.lPlanningPreproduDateEnd; }
            set { this.lPlanningPreproduDateEnd = value; }
        }
        public string PlanningProjectDuration
        {
            get { return this.lPlanningProjectDuration; }
            set { this.lPlanningProjectDuration = value; }
        }
        public DateTime PlanningDateFinreport
        {
            get { return this.lPlanningDateFinreport; }
            set { this.lPlanningDateFinreport = value; }
        }
        public string PlanningVigen
        {
            get { return this.lPlanningVigen; }
            set { this.lPlanningVigen = value; }
        }
        public string PlanningBudget
        {
            get { return this.lPlanningBudget; }
            set { this.lPlanningBudget = value; }
        }
        public int ddesignFor
        {
            get { return this.lddesignFor; }
            set { this.lddesignFor = value; }
        }
        public string namecontac
        {
            get { return this.lnamecontac; }
            set { this.lnamecontac = value; }
        }
        public string emailcontac
        {
            get { return this.lemailcontac; }
            set { this.lemailcontac = value; }
        }
        public bool PlanningStatus
        {
            get { return this.lPlanningStatus; }
            set { this.lPlanningStatus = value; }
        }
        public int Statusid
        {
            get { return this.lStatusid; }
            set { this.lStatusid = value; }
        }
        public bool PlanningFormaCompe
        {
            get { return this.lPlanningFormaCompe; }
            set { this.lPlanningFormaCompe = value; }
        }
        public string PlanningCreateBy
        {
            get { return this.lPlanningCreateBy; }
            set { this.lPlanningCreateBy = value; }
        }
        public DateTime PlanningDateBy
        {
            get { return this.lPlanningDateBy; }
            set { this.lPlanningDateBy = value; }
        }
        public string PlanningModiBy
        {
            get { return this.lPlanningModiBy; }
            set { this.lPlanningModiBy = value; }
        }
        public DateTime PlanningDateModiBy
        {
            get { return this.lPlanningDateModiBy; }
            set { this.lPlanningDateModiBy = value; }
        }
    }
}
    

