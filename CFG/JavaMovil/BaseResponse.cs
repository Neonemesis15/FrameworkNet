using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.CFG.JavaMovil
{
    public class BaseResponse
    {
        public const int GENERAL_ERROR = 2;
        public const int DB_ERROR = 3;
        public const int NEGOCIO_ERROR = 1;
        public const int EXITO = 0;
            
        [JsonProperty("d")]
        public string Descripcion { get; set; }

        [JsonProperty("e")]
        public int Estado { get; set; }        
    }
}
