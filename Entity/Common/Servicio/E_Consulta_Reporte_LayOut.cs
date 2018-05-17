using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Servicio
{
    public class E_Consulta_Reporte_LayOut
    {

        [JsonProperty("a")]
        public string Nombre_Categoria { get; set; }

        [JsonProperty("b")]
        public string Nombre_Marca { get; set; }

        [JsonProperty("c")]
        public int Objetivo { get; set; }

        [JsonProperty("d")]
        public int Cantidad { get; set; }

        [JsonProperty("e")]
        public int Frentes { get; set; }

        [JsonProperty("f")]
        public string Registrado_Por { get; set; }

        [JsonProperty("g")]
        public Boolean Validado { get; set; }

        [JsonProperty("h")]
        public Boolean Validado_Cliente { get; set; }

        [JsonProperty("i")]
        public int Cod_LayOut_Detalle { get; set; }

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
        public string Nombre_Oficina { get; set; }

        [JsonProperty("p")]
        public string Nombre_PuntoDeVenta { get; set; }

        [JsonProperty("q")]
        public string Nombre_NodoComercial { get; set; }
    }
}
