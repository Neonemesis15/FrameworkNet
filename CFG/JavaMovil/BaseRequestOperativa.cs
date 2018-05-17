using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.CFG.JavaMovil
{
    public class BaseRequestOperativa
    {
        [JsonProperty("b")]
        public string AppEnvia { get; set; }
    }
}
