using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Servicio
{
    public class E_Seguimiento
    {
        [JsonProperty("a")]
        public string nombreGestion { get; set; }

        [JsonProperty("n")]
        public string valor { get; set; }//1:hay data; 0:no tiene data
    }
}
