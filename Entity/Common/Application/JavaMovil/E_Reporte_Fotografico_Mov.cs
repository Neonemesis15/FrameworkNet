using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Fotografico_Mov
    {
        [JsonProperty("a")]
        public int Cod_Persona { get; set; }
        [JsonProperty("b")]
        public string Cod_Equipo { get; set; }
        [JsonProperty("c")]
        public int Cod_Compania { get; set; }
        [JsonProperty("d")]
        public string Cod_PtoVenta { get; set; }
        [JsonProperty("e")]
        public int Cod_Categoria { get; set; }
        [JsonProperty("f")]
        public int Cod_Marca { get; set; }
        [JsonProperty("g")]
        public string Comentario { get; set; }
        [JsonProperty("h")]
        public string Nombre_Foto { get; set; }
        [JsonProperty("i")]
        public DateTime Fec_Registro { get; set; }
        [JsonProperty("j")]
        public string Latitud { get; set; }
        [JsonProperty("k")]
        public string Longitud { get; set; }
        [JsonProperty("l")]
        public string Origen { get; set; }
        //Add 04/05/2012 PSA
        [JsonProperty("m")]
        public string Cod_Familia { get; set; }
        [JsonProperty("n")]
        public string Cod_SubFamilia { get; set; }
        //Add 22/08/2012 Psa.
        [JsonProperty("o")]
        public string Cod_SubReporte { get; set; }
    }
}
