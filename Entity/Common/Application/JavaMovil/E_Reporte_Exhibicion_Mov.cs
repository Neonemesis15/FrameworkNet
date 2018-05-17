using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Exhibicion_Mov:E_Reporte_Base_Mov
    {
        public E_Reporte_Exhibicion_Mov() {
            Detalle = new List<E_Reporte_Exhibicion_Mov_Detalle>();
        }
        [JsonProperty("q")]
        public string Cod_Condicion { get; set; }
        [JsonProperty("r")]
        public string Fecha_Inicio { get; set; }
        [JsonProperty("s")]
        public string Fecha_Fin { get; set; }
        [JsonProperty("t")]
        public List<E_Reporte_Exhibicion_Mov_Detalle> Detalle { get; set; }
        [JsonProperty("u")]
        public string Nombre_Foto { get; set; }
        [JsonProperty("v")]
        public string Comentario_Foto { get; set; }
    }

    public class E_Reporte_Exhibicion_Mov_Detalle {
        [JsonProperty("a")]
        public string Cod_Tipo { get; set; }

        [JsonProperty("b")]
        public string Cantidad { get; set; }

        [JsonProperty("c")]
        public string Cod_Categoria { get; set; }   

        [JsonProperty("d")]
        public string Cod_Motivo { get; set; }

        [JsonProperty("e")]
        public string Valor_Motivo { get; set; }

        [JsonProperty("f")]
        public string Cod_Exhibicion{ get; set; }

        [JsonProperty("g")]
        public string Valor_Exhibicion { get; set; }

        /// <summary>
        /// Author  : Pablo Salas A.
        /// Date    : 26/07/2012
        /// Description : 
        /// Código de SubReporte Para San Fernando Tradicional - 
        /// SubReporteExhibicion con la Opcion de Agregar mas SubReportes
        /// </summary>
        [JsonProperty("h")]
        public string Cod_Sub_Reporte { get; set; }
    }
}
