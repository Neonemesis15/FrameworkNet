using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Stock_Detalle
    {
        [JsonIgnore()]
        public string Id_Reg_Stock { get; set; }
        [JsonProperty("a")]
        public string Id_Familia { get; set; }
        [JsonProperty("b")]
        public string Cantidad { get; set; }
        [JsonProperty("c")]
        public string Motivo_Obs { get; set; }
        [JsonProperty("d")]
        public string Id_Producto { get; set; }
        [JsonProperty("e")]
        public string Pedido { get; set; }
        [JsonProperty("f")]
        public string Ingreso { get; set; }
        [JsonProperty("g")]
        public string Venta { get; set; }
        [JsonProperty("h")]
        public string Semana { get; set; }
        [JsonProperty("i")]
        public string Exhibicion { get; set; }
        [JsonProperty("j")]
        public string Camara { get; set; }
        [JsonProperty("k")]
        public string Opcion { get; set; }
    }
}
