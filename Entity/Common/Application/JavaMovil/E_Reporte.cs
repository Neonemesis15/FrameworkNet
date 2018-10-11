using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }
        [JsonProperty("b")]
        public string Reporte_Alias { get; set; }
        [JsonProperty("c")]
        public string CodSubReporte { get; set; }
        [JsonProperty("d")]
        public string SubReporteAlias { get; set; }
        [JsonProperty("e")]
        public string Orden { get; set; }

        public string getCodReporte() {
            return CodReporte;
        }

        public void setCodReporte(string CodReporte)
        {
            this.CodReporte = CodReporte;
        }

        public string getReporte_Alias() {
            return Reporte_Alias;
        }

        public void setReporte_Alias(string Reporte_Alias) {
            this.Reporte_Alias = Reporte_Alias;
        }

        public string getCodSubReporte() {
            return CodSubReporte;
        }

        public void setCodSubReporte(string CodSubReporte) {
            this.CodSubReporte = CodSubReporte;
        }

        public string getSubReporteAlias() {
            return SubReporteAlias;
        }

        public void setSubReporteAlias(string SubReporteAlias) {
            this.SubReporteAlias = SubReporteAlias;
        }

        public string getOrden() {
            return Orden;
        }
        public void setOrden(string Orden)
        {
            this.Orden = Orden;
        }

    }
}
