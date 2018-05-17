using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_ExportExcel
    {
        [JsonProperty("a")]
        public string[] Header { get; set; }

        [JsonProperty("b")]
        public string[][] Contents { get; set; }
    }
}
