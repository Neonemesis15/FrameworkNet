using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EOPE_DigFORMATOAGCOCINA
    {
        public EOPE_DigFORMATOAGCOCINA()
        {
            //Se define el contructor por defecto
        }

        private long lid_AGCOCINA;
        private string lid_planning;
        private int lCod_Formato;
        private DateTime lFecha_ini_AGCOCINA;
        private DateTime lFecha_fin_AGCOCINA;
        private int lPerson_id;
        private int lNodeCommercial;
        private string lClientPDV_Code;
        private string lpdv_Name;
        private string lcod_Product;
        private string lProduct_name;
        private string lPrecio;
        private string lStock_inicial;
        private string lIngresos;
        private string lStock_Total;
        private string lStock_Final;
        private string lVentas;
        private string lCreateBy_AGCOCINA;
        private DateTime lDateby_AGCOCINA;
        private string lModiby_AGCOCINA;
        private DateTime lDateModiBy_AGCOCINA;
        
        public long id_AGCOCINA
        {
            get { return this.lid_AGCOCINA; }
            set { this.lid_AGCOCINA = value; }
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
        public DateTime Fecha_ini_AGCOCINA
        {
            get { return this.lFecha_ini_AGCOCINA; }
            set { this.lFecha_ini_AGCOCINA = value; }
        }
        public DateTime Fecha_fin_AGCOCINA
        {
            get { return this.lFecha_fin_AGCOCINA; }
            set { this.lFecha_fin_AGCOCINA = value; }
        }
        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
        }
        public int NodeCommercial
        {
            get { return this.lNodeCommercial; }
            set { this.lNodeCommercial= value; }
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
        public string Precio
        {
            get { return this.lPrecio; }
            set { this.lPrecio = value; }
        }
        public string Stock_inicial
        {
            get { return this.lStock_inicial; }
            set { this.lStock_inicial = value; }
        }
        public string Ingresos
        {
            get { return this.lIngresos; }
            set { this.lIngresos = value; }
        }
        public string Stock_Total
        {
            get { return this.lStock_Total; }
            set { this.lStock_Total = value; }
        }
        public string Stock_Final
        {
            get { return this.lStock_Final; }
            set { this.lStock_Final = value; }
        }
        public string Ventas
        {
            get { return this.lVentas; }
            set { this.lVentas = value; }
        }
        public string CreateBy_AGCOCINA
        {
            get { return this.lCreateBy_AGCOCINA; }
            set { this.lCreateBy_AGCOCINA= value; }
        }
        public DateTime Dateby_AGCOCINA
        {
            get { return this.lDateby_AGCOCINA; }
            set { this.lDateby_AGCOCINA = value; }
        }
        public string Modiby_AGCOCINA
        {
            get { return this.lModiby_AGCOCINA; }
            set { this.lModiby_AGCOCINA = value; }
        }
        public DateTime DateModiBy_AGCOCINA
        {
            get { return this.DateModiBy_AGCOCINA; }
            set { this.lDateModiBy_AGCOCINA= value; }
        }
    }
}
