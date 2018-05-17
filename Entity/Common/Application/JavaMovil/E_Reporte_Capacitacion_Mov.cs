using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Descripcion : Reporte de Capacitacion para App Movil Movistar
    /// Fecha       : 13/07/2012 ING. DUEB
    /// </summary>
    public class E_Reporte_Capacitacion_Mov:E_Reporte_Base_Mov
    {

        public E_Reporte_Capacitacion_Mov()
        {
            Detalle = new List<E_Reporte_Capacitacion_Detalle_Mov>();
        }

        [JsonProperty("q")]
        public List<E_Reporte_Capacitacion_Detalle_Mov> Detalle { get; set; }

    }

    public class E_Reporte_Capacitacion_Detalle_Mov
    {
        [JsonProperty("a")]
        public string Cod_Capacitacion { get; set; }
        [JsonProperty("b")]
        public string Valor_Capacitacion { get; set; }
        [JsonProperty("c")]
        public string Cod_Motivo { get; set; }
        [JsonProperty("d")]
        public string Varlor_Motivo { get; set; }      
    }
}
