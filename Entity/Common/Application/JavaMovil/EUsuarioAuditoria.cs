using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class EUsuarioAuditoria
    {
        [JsonProperty("i")]
        public string Person_Id { get; set; }
        
        [JsonProperty("e")]
        public string Id_Equipo { get; set; }

        [JsonProperty("n")]
        public string Mer_Nombre { get; set; }
    }
}
