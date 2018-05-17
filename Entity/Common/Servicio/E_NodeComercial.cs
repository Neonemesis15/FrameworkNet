using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace Lucky.Entity.Common.Servicio
{
   public class E_NodeComercial
    {

       [JsonProperty("a")]
       public string id_NodeCommercial { get; set; }
       [JsonProperty("b")]
       public string commercialNodeName { get; set; }
       [JsonProperty("c")]
       public string idNodeComType { get; set; }
       [JsonProperty("d")]
       public string NodeCommercial_Status { get; set; }
       [JsonProperty("e")]
       public string NodeCommercial_CreateBy { get; set; }
       [JsonProperty("f")]
       public string NodeCommercial_DateBy { get; set; }
       [JsonProperty("g")]
       public string NodeCommercial_ModiBy { get; set; }
       [JsonProperty("h")]
       public string NodeCommercial_DatemodiBy { get; set; }

    }
}
