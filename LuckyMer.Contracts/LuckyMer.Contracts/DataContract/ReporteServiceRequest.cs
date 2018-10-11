using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using Newtonsoft.Json;

namespace LuckyMer.Contracts.DataContract
{
    public class ReporteServiceRequest
    {
        [JsonProperty("p")]
        public List<E_Reporte_Presencia> ListaReportePresencia { get; set; }

        [JsonProperty("f")]
        public List<E_Reporte_Fotografico> ListaReporteFotografico { get; set; }

        [JsonProperty("v")]
        public E_Visita Visita{ get; set; }
    }

    public class ReporteServiceResponse : BaseResponse
    {
    }
}
