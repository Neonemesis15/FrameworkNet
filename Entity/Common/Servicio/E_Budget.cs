using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Budget
    {
        [JsonProperty("a")]
        public string Number_Budget { get; set; }

        [JsonProperty("b")]
        public string Name_Budget { get; set; }

        [JsonProperty("c")]
        public string Cod_Strategy { get; set; }

        [JsonProperty("d")]
        public string Strategy_Name { get; set; }

        [JsonProperty("e")]
        public string Company_id { get; set; }

        [JsonProperty("f")]
        public string Company_Name { get; set; }

        [JsonProperty("g")]
        public string Id_Planning { get; set; }

        [JsonProperty("h")]
        public DateTime Fec_IniPlanning { get; set; }

        [JsonProperty("i")]
        public DateTime Fec_FinPlanning { get; set; }

        [JsonProperty("j")]
        public string Name_Contact { get; set; }

    }
}
