using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Consulta_Reporte_SOD
    {

        [JsonProperty("a")]
        public string Nombre_PuntoDeVenta { get; set; }

        [JsonProperty("b")]
        public string Nombre_Categoria { get; set; }

        [JsonProperty("c")]
        public string Nombre_Marca { get; set; }

        [JsonProperty("d")]
        public float Exhibicion_Primaria { get; set; }

        [JsonProperty("e")]
        public float Exhibicion_Secundaria { get; set; }

        [JsonProperty("f")]
        public string Registrado { get; set; }

        [JsonProperty("g")]
        public Boolean Validado { get; set; }

        [JsonProperty("h")]
        public Boolean Validado_Cliente { get; set; }

        [JsonProperty("i")]
        public int Cod_SOD_Detalle { get; set; }

        [JsonProperty("j")]
        public string Nombre_Mercaderista { get; set; }

        [JsonProperty("k")]
        public DateTime Fecha_Registro_BD { get; set; }

        [JsonProperty("l")]
        public string Modificado_Por { get; set; }

        [JsonProperty("m")]
        public DateTime Fecha_Modificacion { get; set; }

        [JsonProperty("n")]
        public string Codigo_PuntoDeVenta { get; set; }

        [JsonProperty("o")]
        public string Nombre_NodoComercial { get; set; }

        [JsonProperty("p")]
        public string Nombre_Oficina { get; set; }

    }
}
