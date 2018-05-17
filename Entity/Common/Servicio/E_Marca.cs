using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Marca
    {
        [JsonProperty("a")]
        public int Id_Brand { get; set; }
        [JsonIgnore()]
        public int Company_id { get; set; }
        [JsonIgnore()]
        public string Id_ProductCategory { get; set; }
        [JsonProperty("d")]
        public string Name_Brand { get; set; }
        [JsonIgnore()]
        public bool Brand_Status { get; set; }
        [JsonIgnore()]
        public string Brand_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime Brand_DateBy { get; set; }
        [JsonIgnore()]
        public string Brand_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime Brand_DateModiBy { get; set; }

    }
}
