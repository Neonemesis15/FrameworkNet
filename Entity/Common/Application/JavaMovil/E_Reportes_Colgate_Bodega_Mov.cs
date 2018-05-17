using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reportes_Colgate_Bodega_Mov
    {
        public E_Reportes_Colgate_Bodega_Mov() {
            Reportes_Colgate_Bodega_Mov_Response = new E_Reportes_Colgate_Bodega_Mov_Response();
        }

        [JsonProperty("b")]
        public E_Reportes_Colgate_Bodega_Mov_Response Reportes_Colgate_Bodega_Mov_Response { get; set; }
    }

    public class E_Reportes_Colgate_Bodega_Mov_Response{
        public E_Reportes_Colgate_Bodega_Mov_Response() {
            //Reporte_Codigo_ITT_Mov_Response = new E_Reporte_Codigo_ITT_Mov_Response();
            Reporte_Presencia_Mov_Response = new E_Reporte_Presencia_Datos_Response();
        }

        //[JsonProperty("a")]
        //public E_Reporte_Codigo_ITT_Mov_Response Reporte_Codigo_ITT_Mov_Response { get; set; }
        [JsonProperty("b")]
        public E_Reporte_Presencia_Datos_Response Reporte_Presencia_Mov_Response { get; set; }
        //[JsonIgnore()]
        //public string Registro_Visita_Mov_Response { get; set; }
        [JsonIgnore()]
        public string Mensaje_Response { get; set; }
    }
}
