using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Credito_Competencia_Mov:E_Reporte_Base_Mov
    {
        /// <summary>
        /// Descripcion : Reporte de Crédito competencia para App Movil Movistar
        /// Fecha       : 16/07/2012 ING. DUEB
        /// </summary>

        public E_Reporte_Credito_Competencia_Mov()
        {
            Detalle = new List<E_Reporte_Credito_Competencia_Detalle_Mov>();
        }
        [JsonProperty("q")]
        public List<E_Reporte_Credito_Competencia_Detalle_Mov> Detalle { get; set; }
    }

    public class E_Reporte_Credito_Competencia_Detalle_Mov
    {
        [JsonProperty("a")]
        public string Cod_Credito { get; set; }
        [JsonProperty("b")]
        public string Valor_Credito { get; set; }
    }
}
