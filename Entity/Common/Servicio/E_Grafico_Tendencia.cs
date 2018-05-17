using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Grafico_Tendencia
    {
        //row_id,cabecera,coverage,total_coverage,porcentaje,rango_fecha,id_reportsplanning

        [JsonProperty("a")]
        public string cebecera { get; set; }

        [JsonProperty("b")]
        public string coverage { get; set; }

        [JsonProperty("c")]
        public string totalCoverage { get; set; }

        [JsonProperty("d")]
        public string porcentaje { get; set; }

        [JsonProperty("e")]
        public string ventas { get; set; }

        [JsonProperty("f")]
        public string rangoFecha { get; set; }

        [JsonProperty("g")]
        public string codPeriodo { get; set; }

        [JsonProperty("h")]
        public string orden { get; set; }
    }
}