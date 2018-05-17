using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_NodeComercial_Type
    {
        [JsonProperty("a")]
        public string idNodeComType { get; set; }
        [JsonProperty("b")]
        public string NodeComType_name { get; set; }
        [JsonIgnore]
        public string NodeComType_Status { get; set; }
        [JsonIgnore]
        public string NodeComType_CreateBy { get; set; }
        [JsonIgnore]
        public string NodeComType_DateBy { get; set; }
        [JsonIgnore]
        public string NodeComType_ModiBy { get; set; }
        [JsonIgnore]
        public string NodeComType_DateModiBy { get; set; }
        
    }
}
