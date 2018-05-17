using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Observacion_Mov
    {
        public E_Reporte_Observacion_Mov()
        {
            Detalle = new List<E_Reporte_Observacion_Mov_Detalle>();
        }

        [JsonProperty("a")]
        public int Cod_Persona { get; set; }

        [JsonProperty("b")]
        public string Cod_Equipo { get; set; }

        [JsonProperty("c")]
        public int Cod_Compania { get; set; }

        [JsonProperty("d")]
        public string Cod_PtoVenta { get; set; }

        [JsonProperty("e")]
        public string Cod_Categoria { get; set; }

        [JsonProperty("f")]
        public string Cod_Marca { get; set; }

        [JsonProperty("g")]
        public DateTime Fecha_Registro { get; set; }

        [JsonProperty("h")]
        public string Latitud { get; set; }

        [JsonProperty("i")]
        public string Longitud { get; set; }

        [JsonProperty("j")]
        public string Origen { get; set; }

        [JsonProperty("k")]
        public List<E_Reporte_Observacion_Mov_Detalle> Detalle { get; set; }
    }

    public class E_Reporte_Observacion_Mov_Detalle
    {
        [JsonProperty("a")]
        public string Cod_Observacion { get; set; }

        [JsonProperty("b")]
        public string Cod_Opcion { get; set; }
    }
}
