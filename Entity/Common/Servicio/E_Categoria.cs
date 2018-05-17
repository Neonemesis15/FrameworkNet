using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Categoria
    {
        [JsonProperty("a")]
        public string Id_ProductCategory { get; set; }
        [JsonProperty("b")]
        public string Product_Category { get; set; }
        [JsonIgnore()]
        public string Group_Category { get; set; }
        [JsonIgnore()]
        public bool ProductCategory_Status { get; set; }
        [JsonIgnore()]
        public int Company_id { get; set; }
        [JsonIgnore()]
        public string ProductCategory_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime ProductCategory_DateBy { get; set; }
        [JsonIgnore()]
        public string ProductCategory_ModiBy { get; set; }
        [JsonIgnore()]
        public string ProductCategory_DateModiBy { get; set; }
    }
}
