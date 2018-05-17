using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Descripcion : Cabecera del Reporte Material de Apoyo App Movistar
    /// Fecha       : 19/05/2012 PSA
    /// </summary>
    public class E_Reporte_Mat_Apoyo_Mov
    {
        public E_Reporte_Mat_Apoyo_Mov() {
            Detalle = new List<E_Reporte_Mat_Apoyo_Mov_Detalle>();
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
        public int Cod_Categoria { get; set; }
        [JsonProperty("f")]
        public DateTime Fec_Registro { get; set; }
        [JsonProperty("g")]
        public string Latitud { get; set; }
        [JsonProperty("h")]
        public string Longitud { get; set; }
        [JsonProperty("i")]
        public string Origen { get; set; }
        [JsonProperty("j")]
        public string Comentario { get; set; }
        [JsonProperty("k")]
        public List<E_Reporte_Mat_Apoyo_Mov_Detalle> Detalle { get; set; }
        //Add 04/05/2012 PSA
        [JsonProperty("l")]
        public string Cod_Marca { get; set; }
        [JsonProperty("m")]
        public string Cod_Familia { get; set; }
        [JsonProperty("n")]
        public string Cod_SubFamilia { get; set; }

    }

    /// <summary>
    /// Descripcion : Detalle del Reporte Material de Apoyo App Movistar
    /// Fecha       : 19/05/2012 PSA
    /// </summary>
    public class E_Reporte_Mat_Apoyo_Mov_Detalle {

        [JsonProperty("a")]
        public string Cod_MatApoyo { get; set; }
        [JsonProperty("b")]
        public string Presencia { get; set; }
        [JsonProperty("c")]
        public string Cod_Marca { get; set; }
        [JsonProperty("d")]
        public string Comentario { get; set; }
        [JsonProperty("e")]
        public string Fecha_Ini { get; set; }
        [JsonProperty("f")]
        public string Fecha_Fin { get; set; }
        [JsonProperty("g")]
        public string Nombre_Foto { get; set; }
        [JsonProperty("h")]
        public string Cantidad { get; set; }

    }
}
