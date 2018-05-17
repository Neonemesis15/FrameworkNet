using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    //CreateBy         : Ing. Mauricio Ortiz
    //CreateDate       : 10/07/2009
    //Description      : Atributos Entidad MPointOfPurchase_Planning
    //Requerimiento    :
    // Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz


    public class EMPointOfPurchase_Planning
    {
        public EMPointOfPurchase_Planning()
        {
            //Se define el contructor por defecto
        }

        private int lid_MPOPPlanning;
        private string lid_Planning;
        private int lid_MPointOfPurchase;
        private bool lMPOPPlanning_Status;
        private string lMPOPPlanning_CreateBy;
        private DateTime lMPOPPlanning_DateBy;
        private string lMPOPPlanning_ModiBy;
        private DateTime lMPOPPlanning_DateModiBy;

        public int id_MPOPPlanning
        {
            get { return this.lid_MPOPPlanning; }
            set { this.lid_MPOPPlanning = value; }
        }
        public string id_Planning
        {
            get { return this.lid_Planning; }
            set { this.lid_Planning = value; }
        }
        public int id_MPointOfPurchase
        {
            get { return this.lid_MPointOfPurchase; }
            set { this.lid_MPointOfPurchase = value; }
        }

        public bool MPOPPlanning_Status
        {
            get { return this.lMPOPPlanning_Status; }
            set { this.lMPOPPlanning_Status = value; }
        }
        public string MPOPPlanning_CreateBy
        {
            get { return this.lMPOPPlanning_CreateBy; }
            set { this.lMPOPPlanning_CreateBy = value; }
        }
        public DateTime MPOPPlanning_DateBy
        {
            get { return this.lMPOPPlanning_DateBy; }
            set { this.lMPOPPlanning_DateBy = value; }
        }
        public string MPOPPlanning_ModiBy
        {
            get { return this.lMPOPPlanning_ModiBy; }
            set { this.lMPOPPlanning_ModiBy = value; }
        }
        public DateTime MPOPPlanning_DateModiBy
        {
            get { return this.lMPOPPlanning_DateModiBy; }
            set { this.lMPOPPlanning_DateModiBy = value; }
        }
    }
}
        

    

