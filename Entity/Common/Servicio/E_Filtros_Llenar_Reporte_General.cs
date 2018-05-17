using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Filtros_Llenar_Reporte_General
    {
        [JsonProperty("a")]
        public string Cod_Campania { get; set; }

        [JsonProperty("b")]
        public string Cod_Reporte { get; set; }

        [JsonProperty("c")]
        public string Cod_Categoria { get; set; }

        [JsonProperty("d")]
        public string Cod_Marca { get; set; }

        [JsonProperty("e")]
        public string Cod_Familia { get; set; }

        [JsonProperty("f")]
        public string Cod_SubFamilia { get; set; }

        [JsonProperty("g")]
        public string Cod_Oficina { get; set; }

        [JsonProperty("h")] //Add 19/06/2012 PSA
        public string Cod_Ciudad { get; set; }

        [JsonProperty("i")]
        public string Cod_Gestor { get; set; }

        [JsonProperty("j")]
        public string Cod_PDV { get; set; }

        [JsonProperty("k")]
        public string Cod_NodoComercial { get; set; }

        [JsonProperty("l")]
        public string Cod_Anio { get; set; }

        [JsonProperty("m")]
        public string Cod_Mes { get; set; }

        [JsonProperty("n")]
        public string Cod_Periodo { get; set; }

        


        /// <summary>
        /// Author:
        /// Fecha:02/08/2012
        /// Descripcion:
        /// </summary>
        [JsonProperty("o")]
        public string Cod_Departamento { get; set; }

        [JsonProperty("p")]
        public string Cod_SubReporte { get; set; }

        [JsonProperty("q")]
        public string Fecha_Relevo { get; set; }
    }
}
