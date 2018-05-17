using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_SOD_Mov
    {
        public E_Reporte_SOD_Mov(){
            Detalle = new List<E_Reporte_SOD_Mov_Detalle>();
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
        public string Fecha_Registro { get; set; }
        [JsonProperty("g")]
        public string Latitud { get; set; }
        [JsonProperty("h")]
        public string Longitud { get; set; }
        [JsonProperty("i")]
        public string Origen { get; set; }
        [JsonProperty("j")]
        public string Observacion { get; set; }
        [JsonProperty("k")]
        public List<E_Reporte_SOD_Mov_Detalle> Detalle { get; set; } 
        [JsonProperty("l")]
        public string Nombre_Foto { get; set; }
        [JsonProperty("m")]
        public string Comentario_Foto { get; set; }
    }

    public class E_Reporte_SOD_Mov_Detalle {
        [JsonProperty("a")]
        public string Cod_Marca { get; set; }
        [JsonProperty("b")]
        public string Exhibicion_Primaria { get; set; }
        [JsonProperty("c")]
        public string Exhibicion_Secundaria { get; set; }
        [JsonProperty("d")]
        public string Motivo_Obs { get; set; }
    }
}
