using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reportes_Colgate_Minorista_Mov
    {
        public E_Reportes_Colgate_Minorista_Mov() {
            Reportes_Colgate_Minorista_Mov_Response = new E_Reportes_Colgate_Minorista_Mov_Response();
        }

        [JsonProperty("b")]
        public E_Reportes_Colgate_Minorista_Mov_Response Reportes_Colgate_Minorista_Mov_Response { get; set; }
    }

    public class E_Reportes_Colgate_Minorista_Mov_Response {
        //public E_Reportes_Colgate_Minorista_Mov_Response() {
        //    Registro_Reporte_Codigo_ITT_Mov_Response = new E_Reporte_Codigo_ITT_Mov_Response();
        //}

        //[JsonProperty("a")]
        //public E_Reporte_Codigo_ITT_Mov_Response Registro_Reporte_Codigo_ITT_Mov_Response { get; set; }
        //[JsonIgnore()]
        //public string Registro_Reporte_Presencia_Mov_Response { get; set; }
        //[JsonIgnore()]
        //public string Registro_Reporte_Fotografico_Mov_Response { get; set; }
        //[JsonIgnore()]
        //public string Registro_Visita_Mov_Response { get; set; }
        [JsonIgnore()]
        public string Mensaje_Response { get; set; }
    }
}
