using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace LuckyMer.Contracts.DataContract
{
    public class SincronizacionServiceRequest
    {
        [JsonProperty("e")]
        public string Id_Equipo { get; set; }

        [JsonProperty("c")]
        public string Cliente_Id { get; set; }

        [JsonProperty("i")]
        public string Person_Id { get; set; }        
    }

    public class SincronizacionServiceResponse : BaseResponse
    {
        [JsonProperty("s")]
        public ESincronizar Sincronizar { get; set; }
    }

    public class SincronizacionServiceAuditoriaRequest
    {
        [JsonProperty("e")]
        public string Id_Equipo { get; set; }
        
        [JsonProperty("i")]
        public string Person_Id { get; set; }
    }

    public class SincronizacionServiceAuditoriaResponse : BaseResponse
    {
        [JsonProperty("s")]
        public ESincronizarAuditoria Sincronizar { get; set; }
    }
}
