﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace Lucky.Entity.Common.Servicio
{
   public class E_Ciudad
    {

        [JsonProperty("a")]
        public string CodCiudad { get; set; }
        [JsonProperty("b")]
        public string NomCiudad { get; set; }
        
    }
}
