using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Producto
    {
        [JsonProperty("a")]
        public string Cod_Producto { get; set; }

        [JsonProperty("b")]
        public string Nombre_Producto { get; set; }
    }
}
