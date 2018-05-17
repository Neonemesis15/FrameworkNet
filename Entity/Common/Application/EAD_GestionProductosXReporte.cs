using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    public class EAD_GestionProductosXReporte
    {
        private int iid_RelInfo_prodcutos;
        private int lCompany_id;
        private string lcod_Channel;
        private int lReport_id;
        private string lid_Tipo_Reporte;
        private bool lVista_Categoria;
        private bool lVista_Marca;
        private bool lVista_SubMarca;
        private bool lVista_Familia;
        private bool lVista_SubFamilia;
        private bool lVista_Producto;
        private bool lRelInfo_Status;
        private string lRelInfo_CreateBy;
        private DateTime lRelInfo_DateBy;
        private string lRelInfo_ModiBy;
        private DateTime lRelInfo_DateModiBy;

        public EAD_GestionProductosXReporte()
        {
            //Se define el constructor por defecto
        }

        public int id_RelInfo_prodcutos
        {
            get { return iid_RelInfo_prodcutos; }
            set { iid_RelInfo_prodcutos = value; }
        }

        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }

        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel = value; }
        }

        public int Report_id
        {
            get { return this.lReport_id; }
            set { this.lReport_id = value; }
        }
       
        public bool Vista_Categoria
        {
            get { return this.lVista_Categoria; }
            set { this.lVista_Categoria = value; }
        }

        public bool Vista_Marca
        {
            get { return this.lVista_Marca; }
            set { this.lVista_Marca = value; }
        }

        public bool Vista_SubMarca
        {
            get { return this.lVista_SubMarca; }
            set { this.lVista_SubMarca = value; }
        }

        public bool Vista_Familia
        {
            get { return this.lVista_Familia; }
            set { this.lVista_Familia = value; }
        }


        public bool Vista_SubFamilia
        {
            get { return this.lVista_SubFamilia; }
            set { this.lVista_SubFamilia = value; }
        }
        public bool Vista_Producto
        {
            get { return this.lVista_Producto; }
            set { this.lVista_Producto = value; }
        }


        public string id_Tipo_Reporte
        {
            get { return this.lid_Tipo_Reporte; }
            set { this.lid_Tipo_Reporte = value; }
        }

        public bool RelInfo_Status
        {
            get { return this.lRelInfo_Status; }
            set { this.lRelInfo_Status = value; }
        }

        public string RelInfo_CreateBy
        {
            get { return this.lRelInfo_CreateBy; }
            set { this.lRelInfo_CreateBy = value; }
        }

        public DateTime RelInfo_DateBy
        {
            get { return this.lRelInfo_DateBy; }
            set { this.lRelInfo_DateBy = value; }
        }

        public string RelInfo_ModiBy
        {
            get { return this.lRelInfo_ModiBy; }
            set { this.lRelInfo_ModiBy = value; }
        }

        public DateTime RelInfo_DateModiBy
        {
            get { return this.lRelInfo_DateModiBy; }
            set { this.lRelInfo_DateModiBy = value; }
        }
    }
}
