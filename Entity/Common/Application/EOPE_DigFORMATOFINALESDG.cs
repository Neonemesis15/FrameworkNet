using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EOPE_DigFORMATOFINALESDG
    {
        public EOPE_DigFORMATOFINALESDG()
        {
            //Se define el contructor por defecto
        }


        private long lid_FINALESDG;
        private string lid_planning;
        private int lCod_Formato;
        private DateTime lFecha_FINALESDG;
        private int lPerson_id;
        private int lNodeCommercial;
        private string lClientPDV_Code;
        private string lpdv_Name;
        private string lcod_Product;
        private string lProduct_name;
        private string lLocal1;
        private string lLocal2;
        private string lLocal3;
        private string lLocal4;
        private string lLocal5;
        private string lTotal;
        private string lCreateBy_FINALESDG;
        private DateTime lDateby_FINALESDG;
        private string lModiby_FINALESDG;
        private DateTime lDateModiBy_FINALESDG;



        public long id_FINALESDG
        {
            get { return this.lid_FINALESDG; }
            set { this.lid_FINALESDG = value; }
        }
        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }
        public int Cod_Formato
        {
            get { return this.lCod_Formato; }
            set { this.lCod_Formato = value; }
        }
        public DateTime Fecha_FINALESDG
        {
            get { return this.lFecha_FINALESDG; }
            set { this.lFecha_FINALESDG = value; }
        }

        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
        }
        public int NodeCommercial
        {
            get { return this.lNodeCommercial; }
            set { this.lNodeCommercial = value; }
        }

        public string ClientPDV_Code
        {
            get { return this.lClientPDV_Code; }
            set { this.lClientPDV_Code = value; }
        }
        public string pdv_Name
        {
            get { return this.lpdv_Name; }
            set { this.lpdv_Name = value; }
        }
        public string cod_Product
        {
            get { return this.lcod_Product; }
            set { this.lcod_Product = value; }
        }
        public string Product_name
        {
            get { return this.lProduct_name; }
            set { this.lProduct_name = value; }
        }
        public string Local1
        {
            get { return this.lLocal1; }
            set { this.lLocal1 = value; }
        }
        public string Local2
        {
            get { return this.lLocal2; }
            set { this.lLocal2 = value; }
        }
        public string Local3
        {
            get { return this.lLocal3; }
            set { this.lLocal3 = value; }
        }
        public string Local4
        {
            get { return this.lLocal4; }
            set { this.lLocal4 = value; }
        }
        public string Local5
        {
            get { return this.lLocal5; }
            set { this.lLocal5 = value; }
        }
        public string Total
        {
            get { return this.lTotal; }
            set { this.lTotal = value; }
        }
        public string CreateBy_FINALESDG
        {
            get { return this.lCreateBy_FINALESDG; }
            set { this.lCreateBy_FINALESDG = value; }
        }
        public DateTime Dateby_FINALESDG
        {
            get { return this.lDateby_FINALESDG; }
            set { this.lDateby_FINALESDG = value; }
        }
        public string Modiby_FINALESDG
        {
            get { return this.lModiby_FINALESDG; }
            set { this.lModiby_FINALESDG = value; }
        }
        public DateTime DateModiBy_FINALESDG
        {
            get { return this.lDateModiBy_FINALESDG; }
            set { this.lDateModiBy_FINALESDG = value; }
        }

    }
}