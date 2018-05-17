using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Oficina
    {
        [JsonProperty("a")]
        public long Cod_Oficina { get; set; }
        [JsonIgnore()]
        public int Company_id { get; set; }
        [JsonProperty("c")]
        public string Name_Oficina { get; set; }
        [JsonIgnore()]
        public string Abreviatura { get; set; }
        [JsonIgnore()]
        public int Orden { get; set; }
        [JsonIgnore()]
        public int Id_malla { get; set; }//Add 27/04/2012 PSA. No existe en el Framework Entity.Common.Application
        [JsonIgnore()]
        public bool Oficina_Status { get; set; }
        [JsonIgnore()]
        public string Oficina_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime Oficina_DateBy { get; set; }
        [JsonIgnore()]
        public string Oficina_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime Oficina_DateModiBy { get; set; }

    }
}
