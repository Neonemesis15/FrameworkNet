using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Incidencia_Mov:E_Reporte_Base_Mov
    {
        public E_Reporte_Incidencia_Mov()
        {
            Detalle = new List<E_Reporte_Incidencia_Mov_Detalle>();
        }
        [JsonProperty("q")]
        public string Cod_TipoIncidencia { get; set; }
       
        [JsonProperty("r")]
        public List<E_Reporte_Incidencia_Mov_Detalle> Detalle { get; set; }
    }

    public class E_Reporte_Incidencia_Mov_Detalle
    {
        [JsonIgnore()]
        public int Cod_Reporte { get; set; }

        [JsonProperty("a")]
        public string Sku_Producto { get; set; }

        [JsonProperty("b")]
        public string Cod_Servicio { get; set; }

        [JsonProperty("c")]
        public string Pedido { get; set; }

        [JsonProperty("d")]
        public string Stock_Final { get; set; }

        [JsonProperty("e")]
        public string Nombre_Foto { get; set; }

        [JsonProperty("f")]
        public string Cod_Status { get; set; }

        [JsonProperty("g")]
        public string Valor_Status { get; set; }

        [JsonProperty("h")]
        public string Cod_Incidencia { get; set; }

        [JsonProperty("i")]
        public string Cantidad { get; set; }

        [JsonProperty("j")]
        public string Tipo_Distribuidor { get; set; }

        [JsonProperty("k")]
        public string Valor_Incidencia { get; set; }

        [JsonProperty("l")]
        public string Comentario_Foto { get; set; }

        [JsonProperty("m")]
        public string Cod_Sub_Reporte { get; set; }

        //Add 24/08/2012 Pablo Salas A.
        [JsonProperty("n")]
        public string Cod_Opcion_Pedido { get; set; }
    }
}
