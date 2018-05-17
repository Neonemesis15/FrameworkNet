using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Base_Mov
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
        public string Cod_Categoria { get; set; }
        [JsonProperty("f")]
        public string Cod_SubCategoria { get; set; }
        [JsonProperty("g")]
        public string Cod_Marca { get; set; }
        [JsonProperty("h")]
        public string Cod_SubMarca { get; set; }
        [JsonProperty("i")]
        public string Cod_Familia { get; set; }
        [JsonProperty("j")]
        public string Cod_SubFamilia { get; set; }
        [JsonProperty("k")]
        public string Cod_Presentacion { get; set; }
        [JsonProperty("l")]
        public string Fecha_Registro { get; set; }
        [JsonProperty("m")]
        public string Latitud { get; set; }
        [JsonProperty("n")]
        public string Longitud { get; set; }
        [JsonProperty("o")]
        public string Origen { get; set; }
        [JsonProperty("p")]
        public string Cod_Opcion { get; set; }

    }
}
