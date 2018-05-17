using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// CreateBy        : Ing. Mauricio Ortiz
    /// CreateDate      : 10/07/2009
    /// Description     : Atributos Entidad EPointOfSale_Planning
    /// Requerimiento   :
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz

    public class EPointOfSale_Planning
    {
        public EPointOfSale_Planning()
        {        
        //Se define el contructor por defecto
        }

        private int lid_MPOSPlanning;
        private int lid_ClientPDV;
        private string lid_Planning;
        private bool lPointOfSalePlanning_Status;
        private string lPointOfSalePlanning_CreateBy;
        private DateTime lPointOfSalePlanning_DateBy;
        private string lPointOfSalePlanning_ModiBy;
        private DateTime lPointOfSalePlanning_DateModiBy;

        public int id_MPOSPlanning
        {
            get { return this.lid_MPOSPlanning; }
            set { this.lid_MPOSPlanning = value; }
        }
        public int id_ClientPDV
        {
            get { return this.lid_ClientPDV; }
            set { this.lid_ClientPDV = value; }
        }
        public string id_Planning
        {
            get { return this.lid_Planning; }
            set { this.lid_Planning = value; }
        }
        public bool PointOfSalePlanning_Status
        {
            get { return this.lPointOfSalePlanning_Status; }
            set { this.lPointOfSalePlanning_Status = value; }
        }
        public string PointOfSalePlanning_CreateBy
        {
            get { return this.lPointOfSalePlanning_CreateBy; }
            set { this.lPointOfSalePlanning_CreateBy = value; }
        }
        public DateTime PointOfSalePlanning_DateBy
        {
            get { return this.lPointOfSalePlanning_DateBy; }
            set { this.lPointOfSalePlanning_DateBy = value; }
        }
        public string PointOfSalePlanning_ModiBy
        {
            get { return this.lPointOfSalePlanning_ModiBy; }
            set { this.lPointOfSalePlanning_ModiBy = value; }
        }
        public DateTime PointOfSalePlanning_DateModiBy
        {
            get { return this.lPointOfSalePlanning_DateModiBy; }
            set { this.lPointOfSalePlanning_DateModiBy = value; }
        }
    }
}
