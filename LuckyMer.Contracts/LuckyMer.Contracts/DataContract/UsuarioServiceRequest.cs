using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;

namespace LuckyMer.Contracts.DataContract
{
    public class UsuarioServiceRequest
    {
        [JsonProperty("u")]
        public string Usuario { get; set; }

        [JsonProperty("p")]
        public string Password { get; set; }
    }

    public class UsuarioServiceResponse : BaseResponse
    {
        [JsonProperty("u")]
        public EUsuario Usuario { get; set; }
    }

    public class UsuarioAuditoriaServiceResponse : BaseResponse
    {
        [JsonProperty("u")]
        public EUsuarioAuditoria Usuario { get; set; }
    }
}
