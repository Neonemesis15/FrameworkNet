using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Presencia_General_Detalle
    {
        private string id_reg_presencia;
        [JsonIgnore()]
        public string Id_reg_presencia
        {
            get { return id_reg_presencia; }
            set { id_reg_presencia = value; }
        }

        private string id_producto;
        [JsonProperty("d")]
        public string Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        private string num_frentes;
        [JsonProperty("i")]
        public string Num_frentes
        {
            get { return num_frentes; }
            set { num_frentes = value; }
        }

        private string profundidad;
        [JsonProperty("j")]
        public string Profundidad
        {
            get { return profundidad; }
            set { profundidad = value; }
        }

        private string precio;
        [JsonProperty("k")]
        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string pedido_sugerido;
        [JsonProperty("l")]
        public string Pedido_sugerido
        {
            get { return pedido_sugerido; }
            set { pedido_sugerido = value; }
        }

        private string presencia;
        [JsonProperty("m")]
        public string Presencia
        {
            get { return presencia; }
            set { presencia = value; }
        }







        private string id_pop;
        [JsonProperty("b")]
        public string Id_pop
        {
            get { return id_pop; }
            set { id_pop = value; }
        }

        private string valor_pop;
        [JsonProperty("c")]
        public string Valor_pop
        {
            get { return valor_pop; }
            set { valor_pop = value; }
        }

        private string cumple_Layout;
        [JsonProperty("n")]
        public string Cumple_Layout
        {
            get { return cumple_Layout; }
            set { cumple_Layout = value; }
        }




        private string id_observacion;
        [JsonProperty("f")]
        public string Id_observacion
        {
            get { return id_observacion; }
            set { id_observacion = value; }
        }

        private string observacion;
        [JsonProperty("g")]
        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }





        
        
        private string stock;
        [JsonProperty("e")]
        public string Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        
        private string cantidad;
        [JsonProperty("h")]
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
       

        

        
        

        private string ubicacion;//Agregado para ColgateDT pSalas 06/03/2012
        [JsonProperty("o")]
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        private string posicion;//Agregado para ColgateDT pSalas 06/03/2012
        [JsonProperty("p")]
        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        /// <summary>
        /// Parametro para ColgateBodega
        /// pSalas 
        /// 28/03/2012
        /// </summary>
        private string cod_Cluster;
        [JsonProperty("q")]
        public string Cod_Cluster
        {
            get { return cod_Cluster; }
            set { cod_Cluster = value; }
        }

        /// <summary>
        /// Parámetro para ColgateBodega
        /// pSalas
        /// 28/03/2012
        /// </summary>
        private string valor_Cluster;
        [JsonProperty("r")]
        public string Valor_Cluster
        {
            get { return valor_Cluster; }
            set { valor_Cluster = value; }
        }
    }
}
