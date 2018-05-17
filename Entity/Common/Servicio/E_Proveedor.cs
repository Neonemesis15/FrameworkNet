using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Proveedor
    {
        [JsonProperty("a")]
        public string Razon_social { get; set; }
        [JsonProperty("b")]
        public string Ruc { get; set; }
        [JsonProperty("c")]
        public string Direccion { get; set; }
        [JsonProperty("d")]
        public string CodDpto { get; set; }
        [JsonProperty("e")]
        public string CodProv { get; set; }
        [JsonProperty("f")]
        public string CodDist { get; set; }
        [JsonProperty("g")]
        public string Email { get; set; }
        [JsonProperty("h")]
        public string Contacto { get; set; }
        [JsonProperty("i")]
        public string Telefonos { get; set; }
        [JsonProperty("j")]
        public string Codigo { get; set; }
        [JsonProperty("k")]
        public string Dpto { get; set; }
        [JsonProperty("l")]
        public string Provincia { get; set; }
        [JsonProperty("m")]
        public string Distrito { get; set; }
        [JsonProperty("n")]
        public string Fecha_Registro { get; set; }
        [JsonProperty("o")]
        public string Usuario_Registro { get; set; }
        [JsonProperty("p")]
        public string Fecha_Modify { get; set; }
        [JsonProperty("q")]
        public string Usuario_Modify { get; set; }
    }
}
