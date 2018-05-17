using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Consulta_Reporte_Presencia
    {
        [JsonProperty("a")]
        public string fec_reg_cel { get; set; }

        [JsonProperty("b")]
        public string oficina { get; set; }

        [JsonProperty("c")]
        public string supervisor { get; set; }

        [JsonProperty("d")]
        public string mercaderista { get; set; }

        [JsonProperty("e")]
        public string nodocomercial { get; set; }

        [JsonProperty("f")]
        public string PDV_Client { get; set; }

        [JsonProperty("g")]
        public string pdv { get; set; }

        [JsonProperty("h")]
        public string tiporeporte { get; set; }

        [JsonProperty("i")]
        public string categoria { get; set; }

        [JsonProperty("j")]
        public string marca { get; set; }

        [JsonProperty("k")]
        public string descripcion { get; set; }

        [JsonProperty("l")]
        public string valor { get; set; }

        [JsonProperty("m")]
        public string createby { get; set; }

        [JsonProperty("n")]
        public string dateby { get; set; }

        [JsonProperty("o")]
        public string modiby { get; set; }

        [JsonProperty("p")]
        public string datemodiby { get; set; }

        [JsonProperty("q")]
        public bool validado { get; set; }

        [JsonProperty("r")]
        public string id_detalle_presencia { get; set; }

        [JsonProperty("s")]
        public string opcion_reporte { get; set; }
    }
}
