using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Canal
    {
        [JsonProperty("a")]
        public string Cod_Channel { get; set; }
        [JsonIgnore()]
        public int Company_id { get; set; }
        [JsonProperty("c")]
        public string Channel_Name { get; set; }
        [JsonIgnore()]
        public string Channel_description { get; set; }
        [JsonIgnore()]
        public string Chtype_id { get; set; }
        [JsonIgnore()]
        public bool Channel_Status { get; set; }
        [JsonIgnore()]
        public string Channel_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime Channel_DateBy { get; set; }
        [JsonIgnore()]
        public string Channel_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime Channel_DateModiBy { get; set; }

    }
}
