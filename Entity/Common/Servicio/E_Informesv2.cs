using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{   
    //
    //Listar informes para el menú Consumo Masivo v2 para el perfil 0999
    public class E_Informesv2
    {
        [JsonProperty("a")]
        public string id { get; set; }
        [JsonProperty("b")]
        public string nom_reporte { get; set; }
        [JsonProperty("c")]
        public string ruta_reporte { get; set; }
        [JsonProperty("d")]
        public string anio { get; set; }
        [JsonProperty("e")]
        public string info_mesinforme { get; set; }
        [JsonProperty("f")]
        public string extension { get; set; }
    }
}
