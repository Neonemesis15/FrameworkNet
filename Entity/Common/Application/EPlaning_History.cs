using System;
using System.Collections.Generic;

using System.Text;

namespace Lucky.Entity.Common.Application
{    /// <summary>
    /// Descripción breve de EPlanning
    /// CreateBy: Ing. Carlos Alberto Hernandez RIncón
    /// CreateDate:02/05/2009
    /// Requerimiento:
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    public class EPlaning_History
    {
        public EPlaning_History()
        { 
        
        //Se define el constructor por defecto
        
        }

        private string lidplanning;
        private string lPlanningName;
        private int lcodStrategy;
        private string lPlanningCodChannel;
        private string  lPlanningStartActivity;
        private string  lPlanningEndActivity;
        private string lPlanningPictureFolder;
        private string lPlanningBudget;
        private bool lPlanningStatus;
        private string lPlanningCreateBy;
        private DateTime  lPlanningDateBy;
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

       


        public string  PlanningStartActivity
        {

            get { return this.lPlanningStartActivity; }
            set { this.lPlanningStartActivity = value; }




        }

        public string  PlanningEndActivity
        {

            get { return this.lPlanningEndActivity; }
            set { this.lPlanningEndActivity = value; }




        }

  
        public string PlanningPictureFolder
        {

            get { return this.lPlanningPictureFolder; }
            set { this.lPlanningPictureFolder = value; }




        }
        public string PlanningBudget
        {

            get { return this.lPlanningBudget; }
            set { this.lPlanningBudget = value; }




        }
        public bool PlanningStatus
        {

            get { return this.lPlanningStatus; }
            set { this.lPlanningStatus = value; }




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
