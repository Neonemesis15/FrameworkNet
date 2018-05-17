using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.CFG.Util
{
    public class Reportes_parametros
    {
        public Reportes_parametros()
        {
        }

        public Reportes_parametros(int id, int id_reporte, string id_user, int id_servicio, string id_canal, int id_compañia, int id_oficina, string id_punto_venta, string id_producto_categoria, string id_producto_marca, string Id_producto_familia, string id_año, string id_mes, int id_periodo, string descripcion, string id_tipoactividad, string fecha_inicio, string fecha_fin, string id_tipoReporte, string id_subCategoria, string id_subMarca, string skuProducto, int icadena, int inegocio,int id_Semana, string id_dia,int id_malla)
        {
            this.id = id;
            this.id_reporte = id_reporte;
            this.id_user = id_user;
            this.id_servicio = id_servicio;
            this.id_canal = id_canal;
            this.id_compañia = id_compañia;
            this.id_oficina = id_oficina;
            this.id_punto_venta = id_punto_venta;
            this.id_producto_categoria = id_producto_categoria;
            this.id_producto_marca = id_producto_marca;
            this.Id_producto_familia = Id_producto_familia;
            this.id_año = id_año;
            this.id_mes = id_mes;
            this.id_periodo = id_periodo;
            this.descripcion = descripcion;
            this.id_tipoactividad = id_tipoactividad;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.id_tipoReporte = id_tipoReporte;
            this.id_subCategoria = id_subCategoria;
            this.id_subMarca = id_subMarca;
            this.skuProducto = skuProducto;
            this.icadena = icadena;
            this.inegocio = inegocio;
            this.id_Semana= id_Semana;
            this.id_dia = id_dia;
            this.id_malla = id_malla;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id_reporte;

        public int Id_reporte
        {
            get { return id_reporte; }
            set { id_reporte = value; }
        }

        private string id_user;

        public string Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }

        private int id_servicio;

        public int Id_servicio
        {
            get { return id_servicio; }
            set { id_servicio = value; }
        }
        private string id_canal;

        public string Id_canal
        {
            get { return id_canal; }
            set { id_canal = value; }
        }
        private int id_compañia;

        public int Id_compañia
        {
            get { return id_compañia; }
            set { id_compañia = value; }
        }
        private int id_oficina;

        public int Id_oficina
        {
            get { return id_oficina; }
            set { id_oficina = value; }
        }
        private string id_punto_venta;

        public string Id_punto_venta
        {
            get { return id_punto_venta; }
            set { id_punto_venta = value; }
        }
        private string id_producto_categoria;

        public string Id_producto_categoria
        {
            get { return id_producto_categoria; }
            set { id_producto_categoria = value; }
        }
        private string id_producto_marca;

        public string Id_producto_marca
        {
            get { return id_producto_marca; }
            set { id_producto_marca = value; }
        }
        private string id_producto_familia;

        public string Id_producto_familia
        {
            get { return id_producto_familia; }
            set { id_producto_familia = value; }
        }
        private string id_año;

        public string Id_año
        {
            get { return id_año; }
            set { id_año = value; }
        }
        private string id_mes;

        public string Id_mes
        {
            get { return id_mes; }
            set { id_mes = value; }
        }

        private int id_periodo;

        public int Id_periodo
        {
            get { return id_periodo; }
            set { id_periodo = value; }
        }


        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string id_tipoactividad;

        public string Id_tipoactividad
        {
            get { return id_tipoactividad; }
            set { id_tipoactividad = value; }
        }

        private string fecha_inicio;

        public string Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }

        private string fecha_fin;

        public string Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        private string id_tipoReporte;

        public string Id_tipoReporte
        {
            get { return id_tipoReporte; }
            set { id_tipoReporte = value; }
        }

        private string id_subCategoria;

        public string Id_subCategoria
        {
            get { return id_subCategoria; }
            set { id_subCategoria = value; }
        }

        private string id_subMarca;

        public string Id_subMarca
        {
            get { return id_subMarca; }
            set { id_subMarca = value; }
        }

        private string skuProducto;

        public string SkuProducto
        {
            get { return skuProducto; }
            set { skuProducto = value; }
        }

        /// <summary>
        /// Agregado por: Ing. Carlos ALberto Hernández R. 30/04/2011
        /// </summary>
        private int  icadena;
        public int Icadena
        {
            get { return icadena; }
            set { icadena = value; }
        }

        /// <summary>
        /// Agregado por: Ing. Carlos ALberto Hernández R. 30/04/2011
        /// </summary>
        private int inegocio;
        public int Inegocio
        {
            get { return inegocio; }
            set { inegocio = value; }
        }

        /// <summary>
        /// Agregado por: Ing. Renato Castillo S. 07/09/2011
        /// </summary>
        private int id_Semana;

        public int Id_Semana
        {
            get { return id_Semana; }
            set { id_Semana = value; }
        }

        /// <summary>
        /// Agregado por: Ing. Ditmar Estrada B. 21/02/2012
        /// </summary>
        private int id_TipoCiudad;

        public int Id_TipoCiudad
        {
            get { return id_TipoCiudad; }
            set { id_TipoCiudad = value; }
        }

        private string Id_dia;

        public string id_dia
        {
            get { return Id_dia; }
            set { Id_dia = value; }
        }

        /// <summary>
        /// Agregado por: pSalas 28/02/2012
        /// </summary>
        private int id_malla;

        public int Id_malla
        {
            get { return id_malla; }
            set { id_malla = value; }
        }

       
    }
}
