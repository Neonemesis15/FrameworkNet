using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    //Add 10/01/2012
    public class E_Reporte_Presencia_Detalle
    {
        [JsonIgnore()]
        public long Id_Reg_Presencia { get; set; }

        [JsonIgnore()]
        public string OpcionReporte_id { get; set; }

        [JsonProperty("q")]
        public string Codigo { get; set; }

        [JsonProperty("l")]
        public string ValorDetalle { get; set; }


        //[JsonProperty("u")]
        //public string Producto_id { get; set; }

        //[JsonProperty("e")]
        //public string Precio { get; set; }

        //[JsonProperty("k")]
        //public string Stock { get; set; }

        //[JsonProperty("h")]
        //public string idObservacion { get; set; }

        //[JsonProperty("v")]
        //public string Observacion { get; set; }



    }
}
