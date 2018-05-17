using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Producto
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodProducto { get; set; }

        [JsonProperty("c")]
        public string CodSKU { get; set; }
        
        [JsonProperty("d")]
        public string NombreProducto { get; set; }

        [JsonProperty("e")]
        public int Propio { get; set; }

        [JsonProperty("f")]
        public string CategoriaProducto { get; set; }

        [JsonProperty("g")]
        public string SubCategoriaProducto { get; set; }

        [JsonProperty("h")]
        public string MarcaProducto { get; set; }

        [JsonProperty("i")]
        public string SubMarcaProducto { get; set; }

        [JsonProperty("j")]
        public string FamiliaProducto { get; set; }

        [JsonProperty("k")]
        public string SubFamiliaProducto { get; set; }

        [JsonProperty("l")]
        public string PresentacionProducto { get; set; }

        //[JsonProperty("m")]//Add 05/07/2012 PSA Codigo de la Compania
        [JsonIgnore()]
        public string CodCompania { get; set; }
    }
}
