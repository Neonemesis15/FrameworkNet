using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.CFG.Util
{
    public class Reportes_parametros_SF
    {
        public Reportes_parametros_SF() {

            ListPuntoDeVenta = new List<string>();
            ListFamilia = new List<string>();
            ListSubfamilia = new List<string>();
            ListProductos = new List<string>();
            ListDias = new List<string>();
        }

        private int id;
        private int id_servicio;
        private string id_canal;
        private int id_compania;
        private int id_reporte;
        private string id_user;
        private int id_oficina;
        private string id_corporacion;          // New
        private string id_cadena;               // New
        private List<string> listPuntoDeVenta;  // New
        private string id_fuerzaVenta;          // New
        private string id_supervisor;           // New
        private string id_categoria;
        private string id_marca;
        private List<string> listFamilia;
        private List<string> listSubfamilia;
        private List<string> listProductos;
        private string id_year;
        private string id_month;
        private string id_periodo;
        private List<string> listDias;
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public int Id_reporte
        {
            get { return id_reporte; }
            set { id_reporte = value; }
        }
        
        public string Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }
        
        public int Id_servicio
        {
            get { return id_servicio; }
            set { id_servicio = value; }
        }
       
        public string Id_canal
        {
            get { return id_canal; }
            set { id_canal = value; }
        }        

        public int Id_compania
        {
            get { return id_compania; }
            set { id_compania = value; }
        }

        public int Id_oficina
        {
            get { return id_oficina; }
            set { id_oficina = value; }
        }
        
        public string Id_corporacion
        {
            get { return id_corporacion; }
            set { id_corporacion = value; }
        }
       
        public string Id_cadena
        {
            get { return id_cadena; }
            set { id_cadena = value; }
        }

        public string Id_fuerzaVenta
        {
            get { return id_fuerzaVenta; }
            set { id_fuerzaVenta = value; }
        }
       
        public string Id_supervisor
        {
            get { return id_supervisor; }
            set { id_supervisor = value; }
        }
        
        public string Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        
        public string Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }
       
        public string Id_year
        {
            get { return id_year; }
            set { id_year = value; }
        }
       
        public string Id_month
        {
            get { return id_month; }
            set { id_month = value; }
        }
       
        public string Id_periodo
        {
            get { return id_periodo; }
            set { id_periodo = value; }
        }

        private string id_puntoDeVenta;
        private string id_familias;
        private string id_subfamilias;
        private string id_productos;
        private string id_dias;

        public string Id_puntoDeVenta
        {
            get { return id_puntoDeVenta; }
            set { id_puntoDeVenta = value; }
        }
        

        public string Id_familias
        {
            get { return id_familias; }
            set { id_familias = value; }
        }
        
        public string Id_subfamilias
        {
            get { return id_subfamilias; }
            set { id_subfamilias = value; }
        }
        

        public string Id_productos
        {
            get { return id_productos; }
            set { id_productos = value; }
        }
        

        public string Id_dias
        {
            get { return id_dias; }
            set { id_dias = value; }
        }


        public List<string> ListPuntoDeVenta
        {
            get { return listPuntoDeVenta; }
            set { listPuntoDeVenta = value; }
        }
        public List<string> ListProductos
        {
            get { return listProductos; }
            set { listProductos = value; }
        }
        public List<string> ListSubfamilia
        {
            get { return listSubfamilia; }
            set { listSubfamilia = value; }
        }
        public List<string> ListFamilia
        {
            get { return listFamilia; }
            set { listFamilia = value; }
        }
        public List<string> ListDias
        {
            get { return listDias; }
            set { listDias = value; }
        }




    }
}
