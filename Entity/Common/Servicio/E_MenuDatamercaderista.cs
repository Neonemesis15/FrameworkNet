using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_MenuDatamercaderista
    {
        [JsonProperty("a")]
        public string Id { get; set; }
        [JsonProperty("b")]
        public string Text { get; set; }
        //[JsonProperty("c")]
        //public string Parent_Id { get; set; }
        [JsonProperty("c")]
        public string Leaf { get; set; }
        [JsonProperty("d")]
        public string Icon { get; set; }
        [JsonProperty("e")]
        public string Target { get; set; }
    }
}
