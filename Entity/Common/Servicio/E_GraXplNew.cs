using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_GraXplNew
    {
    }

    /* Gráfico de Barra al hacer Click se despliega el Detalle. Psa. 14/11/2012. */
    public class E_GrafBar {
        public E_GrafBar()
        {
            detalle = new List<E_GrafBar_Det>();
        }
        [JsonProperty("a")]
        public float valor { get; set; }
        [JsonProperty("b")]
        public List<E_GrafBar_Det> detalle { get; set; }
    }
    public class E_GrafBar_Det 
    {
        [JsonProperty("a")]
        public string nombre { get; set; }
        [JsonProperty("b")]
        public string[] encabezado { get; set; }
        [JsonProperty("c")]
        public float[] data { get; set; }
    }
}
