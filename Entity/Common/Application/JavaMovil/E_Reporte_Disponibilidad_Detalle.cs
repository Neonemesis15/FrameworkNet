using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Disponibilidad_Detalle
    {
        private string id_reg_diponibilidad;
         [JsonIgnore()]
        public string Id_reg_diponibilidad
        {
            get { return id_reg_diponibilidad; }
            set { id_reg_diponibilidad = value; }
        }
         private string id_producto;
         [JsonProperty("b")]
         public string Id_producto
         {
             get { return id_producto; }
             set { id_producto = value; }
         }
        
        private string disponibilidad;
         [JsonProperty("c")]
        public string Disponibilidad
        {
            get { return disponibilidad; }
            set { disponibilidad = value; }
        }
        private string stock;
         [JsonProperty("d")]
        public string Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private string pedido;
         [JsonProperty("e")]
        public string Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }
        private string minimo;
         [JsonProperty("f")]
        public string Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }
        private string sugerido;
         [JsonProperty("g")]
        public string Sugerido
        {
            get { return sugerido; }
            set { sugerido = value; }
        }


    }
}
