using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EProducto
    {
        [JsonProperty("i")]
        public string IdReporte { get; set; }

        [JsonProperty("k")]
        public string IdSKU { get; set; }

        [JsonProperty("c")]
        public string CodigoProducto { get; set; }

        [JsonProperty("n")]
        public string NombreProducto { get; set; }

        [JsonProperty("t")]
        public string CategoriaProducto { get; set; }

        [JsonProperty("m")]
        public string MarcaProducto { get; set; }

        [JsonProperty("f")]
        public string FamiliaProducto { get; set; }

        [JsonProperty("s")]
        public string SubFamiliaProducto { get; set; }

        [JsonProperty("g")]
        public string FlagMandatorio { get; set; }

        [JsonProperty("p")]//Add pSalas 12/03/2012 Determinar si el Producto es Propio o de Competencia.
        public string Propio { get; set; }

        [JsonProperty("l")]//Add pSalas 14/03/2012 Determinar de que Compañia en específico es el Producto.
        public string Id_Cliente { get; set; }

    }
}