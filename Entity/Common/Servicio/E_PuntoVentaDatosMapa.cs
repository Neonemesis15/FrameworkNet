    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PuntoVentaDatosMapa
    {
        [JsonProperty("a")]
        public string codPuntoVenta { get; set; }

        [JsonProperty("b")]
        public string nombrePuntoVenta { get; set; }

        [JsonProperty("c")]
        public string direccion { get; set; }

        [JsonProperty("d")]
        public string distrito { get; set; }

        [JsonProperty("e")]
        public string sector { get; set; }

        [JsonProperty("f")]
        public string ultimaVisita { get; set; }

        [JsonProperty("g")]
        public string nombreGestor { get; set; }

        [JsonProperty("h")]
        public string nombreAdministrador { get; set; }

        [JsonProperty("i")]
        public string email { get; set; }

        [JsonProperty("j")]
        public string rutaVendedor { get; set; }

        [JsonProperty("k")]
        public string nombreVendedor { get; set; }

        [JsonProperty("l")]
        public string zona { get; set; }

        [JsonProperty("m")]
        public string cumpleanios { get; set; }

        [JsonProperty("n")]
        public string horaAtencion { get; set; }

        [JsonProperty("o")]
        public string numeroLocales { get; set; }

        [JsonProperty("p")]
        public int estado { get; set; }

        [JsonProperty("q")]
        public List<E_Foto> listFotos { get; set; }
    }
}