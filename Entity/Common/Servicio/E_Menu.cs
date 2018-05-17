using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Menu
    {
        [JsonProperty("a")]
        public string NombreMenu { get; set; }
        [JsonProperty("b")]
        public string Pagina_URL { get; set; }
        [JsonProperty("c")]
        public string Image_URL { get; set; }
    }
}
