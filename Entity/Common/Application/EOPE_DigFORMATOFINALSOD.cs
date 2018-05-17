using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EOPE_DigFORMATOFINALSOD
    {
        public EOPE_DigFORMATOFINALSOD()
        {
            //Se define el contructor por defecto
        }

        private long lid_OpeDigFORMATOFINALSOD;
        private string lid_planning;
        private int lCod_Formato;
        private DateTime lFecha_OpeDigFORMATOFINALSOD;
        private int lPerson_id;
        private string lClientPDV_Code;
        private string lpdv_Name;       
        private long lcod_Oficina;
        private string lname_ProductCategory;       
        private string lid_ProductCategory;
        private string lname_Brand;
        private int lid_Brand;
        private string lExhPrim_OpeDigFORMATOFINALSOD;
        private string lExhSec_OpeDigFORMATOFINALSOD;
        private string lCreateBy_OpeDigFORMATOFINALSOD;
        private DateTime lDateby_OpeDigFORMATOFINALSOD;
        private string lModiby_OpeDigFORMATOFINALSOD;
        private DateTime lDateModiBy_OpeDigFORMATOFINALSOD;




        public long id_OpeDigFORMATOFINALSOD
        {
            get { return this.lid_OpeDigFORMATOFINALSOD; }
            set { this.lid_OpeDigFORMATOFINALSOD = value; }
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
        public DateTime Fecha_OpeDigFORMATOFINALSOD
        {
            get { return this.lFecha_OpeDigFORMATOFINALSOD; }
            set { this.lFecha_OpeDigFORMATOFINALSOD = value; }
        }
        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
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

       

        public long cod_Oficina
        {
            get { return this.lcod_Oficina; }
            set { this.lcod_Oficina = value; }
        }

        public string name_ProductCategory
        {
            get { return this.lname_ProductCategory; }
            set { this.lname_ProductCategory = value; }
        }

        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }
        public string name_Brand
        {
            get { return this.lname_Brand; }
            set { this.lname_Brand = value; }
        }
        public int id_Brand
        {
            get { return this.lid_Brand; }
            set { this.lid_Brand = value; }
        }
        public string ExhPrim_OpeDigFORMATOFINALSOD
        {
            get { return this.lExhPrim_OpeDigFORMATOFINALSOD; }
            set { this.lExhPrim_OpeDigFORMATOFINALSOD = value; }
        }
        public string ExhSec_OpeDigFORMATOFINALSOD
        {
            get { return this.lExhSec_OpeDigFORMATOFINALSOD; }
            set { this.lExhSec_OpeDigFORMATOFINALSOD = value; }
        }
        public string CreateBy_OpeDigFORMATOFINALSOD
        {
            get { return this.lCreateBy_OpeDigFORMATOFINALSOD; }
            set { this.lCreateBy_OpeDigFORMATOFINALSOD = value; }
        }
        public DateTime Dateby_OpeDigFORMATOFINALSOD
        {
            get { return this.lDateby_OpeDigFORMATOFINALSOD; }
            set { this.lDateby_OpeDigFORMATOFINALSOD = value; }
        }
        public string Modiby_OpeDigFORMATOFINALSOD
        {
            get { return this.lModiby_OpeDigFORMATOFINALSOD; }
            set { this.lModiby_OpeDigFORMATOFINALSOD = value; }
        }
        public DateTime DateModiBy_OpeDigFORMATOFINALSOD
        {
            get { return this.lDateModiBy_OpeDigFORMATOFINALSOD; }
            set { this.lDateModiBy_OpeDigFORMATOFINALSOD = value; }
        }

    }
}