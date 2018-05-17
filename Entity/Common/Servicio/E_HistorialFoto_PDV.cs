using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_HistorialFoto_PDV
    {
        [JsonProperty("a")]
        public string fechaAntes { get; set; }

        [JsonProperty("b")]
        public string fotoAntes { get; set; }

        [JsonProperty("c")]
        public string fechaDespues { get; set; }

        [JsonProperty("d")]
        public string fotoDespues { get; set; }
    }
}
