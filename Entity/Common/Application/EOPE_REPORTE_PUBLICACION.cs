using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
  public class EOPE_REPORTE_PUBLICACION
    {
      public EOPE_REPORTE_PUBLICACION()
        {
            //Se define el contructor por defecto
        }


        private int lid_rptePbl;
        private int lPerson_id;
        private string lid_Plannig;
        private int lcompany_id;
        private int lnodeComercial_id;
        private string lid_ProductFamily;       
        private string lSKU;
        private int lid_tipoPublicacion;       
        private DateTime lfec_ini_act;
        private DateTime lfec_fin_act;
        private DateTime lFec_Reg_Cel;
        private DateTime lFec_Reg_BD;
        private string lCreateBy;
        private DateTime lDateBy;
        private string lModiBy;
        private DateTime lDateModiBy;
        private bool lValidado;
        private string lpromocionPuntual;
        private decimal lPVP;
        private decimal lOferta;

        public int id_rptePbl
        {
            get { return this.lid_rptePbl; }
            set { this.lid_rptePbl = value; }
        }

        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
        }
        public string id_Plannig
        {
            get { return this.lid_Plannig; }
            set { this.lid_Plannig = value; }
        }
        public int company_id
        {
            get { return this.lcompany_id; }
            set { this.lcompany_id = value; }
        }

        public int nodeComercial_id
        {
            get { return this.lnodeComercial_id; }
            set { this.lnodeComercial_id = value; }
        }

        public string id_ProductFamily
        {
            get { return this.lid_ProductFamily; }
            set { this.lid_ProductFamily = value; }
        }
        
      public string SKU
        {
            get { return this.lSKU; }
            set { this.lSKU = value; }
        }
     
      public int id_tipoPublicacion
        {
            get { return this.lid_tipoPublicacion; }
            set { this.lid_tipoPublicacion = value; }
        }      
      
        public DateTime fec_ini_act
        {
            get { return this.lfec_ini_act; }
            set { this.lfec_ini_act = value; }
        }

        public DateTime fec_fin_act
        {
            get { return this.lfec_fin_act; }
            set { this.lfec_fin_act = value; }
        }
        public DateTime Fec_Reg_Cel
        {
            get { return this.lFec_Reg_Cel; }
            set { this.lFec_Reg_Cel = value; }
        }
        public DateTime Fec_Reg_BD
        {
            get { return this.lFec_Reg_BD; }
            set { this.lFec_Reg_BD = value; }
        }
        public string CreateBy
        {
            get { return this.lCreateBy; }
            set { this.lCreateBy = value; }
        }
        public DateTime DateBy
        {
            get { return this.lDateBy; }
            set { this.lDateBy = value; }
        }
        public string ModiBy
        {
            get { return this.lModiBy; }
            set { this.lModiBy = value; }
        }

        public DateTime DateModiBy
        {
            get { return this.lDateModiBy; }
            set { this.lDateModiBy = value; }
        }
        public bool Validado
        {
            get { return this.lValidado; }
            set { this.lValidado = value; }
        }

        public string promocionPuntual
        {
            get { return this.lpromocionPuntual; }
            set { this.lpromocionPuntual = value; }
        }
        public decimal PVP
        {
            get { return this.lPVP; }
            set { this.lPVP = value; }
        }
        public decimal Oferta
        {
            get { return this.lOferta; }
            set { this.lOferta = value; }
        }

      

    }
}
 