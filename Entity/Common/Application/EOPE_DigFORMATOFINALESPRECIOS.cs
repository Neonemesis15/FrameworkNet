using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EOPE_DigFORMATOFINALESPRECIOS
    {
        public EOPE_DigFORMATOFINALESPRECIOS()
        {
            //Se define el contructor por defecto
        } 

        private long lid_FINALESPRECIOS;
        private string lid_planning;
        private int lCod_Formato;
        private DateTime lFecha_FINALESPRECIOS;
        private int lPerson_id;
        private int lNodeCommercial;
        private string lClientPDV_Code;
        private string lpdv_Name;
        private long lid_ProductSubCategory;
        private string lname_ProductSubCategory;
        private string lcod_Product;
        private string lProduct_name;
        private string lCosto_FINALESPRECIOS;
        private string lReventa_FINALESPRECIOS;
        private string lObservacion_FINALESPRECIOS;
        private string lReventaUnid_FINALESPRECIOS;
        private string lCreateBy_FINALESPRECIOS;
        private DateTime lDateby_FINALESPRECIOS;
        private string lModiby_FINALESPRECIOS;
        private DateTime lDateModiBy_FINALESPRECIOS;

       

        public long id_FINALESPRECIOS
        {
            get { return this.lid_FINALESPRECIOS; }
            set { this.lid_FINALESPRECIOS = value; }
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
        public DateTime Fecha_FINALESPRECIOS
        {
            get { return this.lFecha_FINALESPRECIOS; }
            set { this.lFecha_FINALESPRECIOS = value; }
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
        public long id_ProductSubCategory
             {
                 get { return this.lid_ProductSubCategory; }
                 set { this.lid_ProductSubCategory = value; }
        }
        public string name_ProductSubCategory
        {
            get { return this.lname_ProductSubCategory; }
            set { this.lname_ProductSubCategory = value; }
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
        public string Costo_FINALESPRECIOS
             {
                 get { return this.lCosto_FINALESPRECIOS; }
                 set { this.lCosto_FINALESPRECIOS = value; }
        }
        public string Reventa_FINALESPRECIOS
             {
                 get { return this.lReventa_FINALESPRECIOS; }
                 set { this.lReventa_FINALESPRECIOS = value; }
        }
        public string Observacion_FINALESPRECIOS
             {
                 get { return this.lObservacion_FINALESPRECIOS; }
                 set { this.lObservacion_FINALESPRECIOS = value; }
        }
        public string ReventaUnid_FINALESPRECIOS
             {
                 get { return this.lReventaUnid_FINALESPRECIOS; }
                 set { this.lReventaUnid_FINALESPRECIOS = value; }
        }
        public string CreateBy_FINALESPRECIOS
             {
                 get { return this.lCreateBy_FINALESPRECIOS; }
                 set { this.lCreateBy_FINALESPRECIOS = value; }
        }
        public DateTime Dateby_FINALESPRECIOS
             {
                 get { return this.lDateby_FINALESPRECIOS; }
                 set { this.lDateby_FINALESPRECIOS = value; }
        }
        public string Modiby_FINALESPRECIOS
             {
                 get { return this.lModiby_FINALESPRECIOS; }
                 set { this.lModiby_FINALESPRECIOS = value; }
        }
        public DateTime DateModiBy_FINALESPRECIOS
        {
            get { return this.lDateModiBy_FINALESPRECIOS; }
            set { this.lDateModiBy_FINALESPRECIOS = value; }
        }

       
    }
}
