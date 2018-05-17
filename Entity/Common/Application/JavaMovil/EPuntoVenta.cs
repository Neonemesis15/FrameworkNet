using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EPuntoVenta
    {
        [JsonProperty("i")]
        public string Codigo { get; set; }

        [JsonProperty("r")]
        public string RazonSocial { get; set; }

        [JsonProperty("a")]
        public string Direccion { get; set; }

        /// <summary>
        /// ColgateDT (Utilizado para Determinar las Promociones por Cadena) 
        /// pSalas 29/03/2012
        /// </summary>
        [JsonProperty("e")]
        public string CodigoCadena { get; set; }

        [JsonProperty("d")]
        public string NombreCadena { get; set; }

        //[JsonProperty("l")]
        //public string CodigoCanal { get; set; }


        [JsonProperty("c")]
        public string NombreCanal { get; set; }

        [JsonProperty("t")]
        public string TipoMercado { get; set; }
    }
}