using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Marcaje_Precio_Mov:E_Reporte_Base_Mov
    {
        public E_Reporte_Marcaje_Precio_Mov()
        {
            Detalle = new List<E_Reporte_Marcaje_Precio_Mov_Detalle>();
            Fotos = new List<E_Reporte_Marcaje_Precio_Foto_Mov>();
        }
        [JsonProperty("q")]
        public List<E_Reporte_Marcaje_Precio_Mov_Detalle> Detalle { get; set; }

        [JsonIgnore()]
        public List<E_Reporte_Marcaje_Precio_Foto_Mov> Fotos{ get; set; }
    }

    public class E_Reporte_Marcaje_Precio_Mov_Detalle
    {
        [JsonProperty("a")]
        public string Cod_Motivo { get; set; }

        [JsonProperty("b")]
        public string Cantidad { get; set; }

        [JsonProperty("c")]
        public string Valor_Motivo { get; set; }

        [JsonProperty("d")]
        public string Cod_Marcaje { get; set; }

        /// <summary>
        /// Author  : Pablo Salas A.
        /// Date    : 26/07/2012
        /// Descriprion:
        /// Nombre de la Foto Usado para Cliente San Fernando Tradicional
        /// </summary>
        [JsonProperty("e")]
        public string Nombre_Foto { get; set; }

        [JsonProperty("f")]
        public string Comentario_Foto { get; set; }
    }

    public class E_Reporte_Marcaje_Precio_Foto_Mov
    {
        [JsonIgnore()]
        public string Nombre_Foto{ get; set; }
    }
}