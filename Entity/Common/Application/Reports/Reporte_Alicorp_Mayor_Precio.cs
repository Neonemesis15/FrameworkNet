using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.Reports
{
    class Reporte_Alicorp_Mayor_Precio
    {
        //[JsonProperty("a")]
        //public int Cod_Periodo { get; set; }

        [JsonProperty("b")]
        public string Periodo { get; set; }

        [JsonProperty("c")]
        public int Cod_Oficina { get; set; }

        [JsonProperty("d")]
        public string Desc_Oficina { get; set; }

        [JsonProperty("e")]
        public string Abreviatura { get; set; }

        [JsonProperty("f")]
        public string Id_Category { get; set; }

        [JsonProperty("g")]
        public string Product_Category { get; set; }

        [JsonProperty("h")]
        public Int64 Id_Subcategory { get; set; }

        [JsonProperty("i")]
        public string Name_Subcategory { get; set; }

        [JsonProperty("j")]
        public int Id_Brand { get; set; }

        [JsonProperty("k")]
        public int Id_Subbrand { get; set; }

        [JsonProperty("l")]
        public string Cod_Product { get; set; }

        [JsonProperty("m")]
        public string Product_Name { get; set; }

        [JsonProperty("n")]
        public float Peso { get; set; }

        [JsonProperty("o")]
        public float Mejor_PrecioAncla { get; set; }

        [JsonProperty("p")]
        public float Peso_Ancla { get; set; }

        [JsonProperty("q")]
        public float Mejor_Precio { get; set; }

        [JsonProperty("r")]
        public float Precio_Dex { get; set; }

        [JsonProperty("s")]
        public float Precio_Reventa { get; set; }

        [JsonProperty("t")]
        public float Precio_PVP { get; set; }

        [JsonProperty("u")]
        public float Precio_Reventa_Ancla { get; set; }

        [JsonProperty("v")]
        public int Orden { get; set; }

    }
}