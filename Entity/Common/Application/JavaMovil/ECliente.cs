using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class ECliente
    {
        [Newtonsoft.Json.JsonProperty("c")]    
        public string Codigo { get; set; }

        [Newtonsoft.Json.JsonProperty("n")]    
        public string RazonSocial { get; set; }
    }
}
