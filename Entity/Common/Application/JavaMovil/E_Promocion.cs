using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Promocion
    {
        [JsonProperty("a")]
        public string CodEmpresa { get; set; }

        [JsonProperty("b")]
        public string CodPromocion { get; set; }

        [JsonProperty("c")]
        public string DescPromocion { get; set; }

        /// <summary>
        /// Agregado para Diferenciar Las Promociones Por Cadena.
        /// pSalas 29/03/2012
        /// </summary>
        [JsonProperty("d")]
        public string CodCadena { get; set; }
    }
}
