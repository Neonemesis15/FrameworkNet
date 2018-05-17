using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Descripcion : Cabecera de Reporte de Visibilidad Competencia Movistar
    /// Fecha       : 19/05/2012 PSA
    /// </summary>
    public class E_Reporte_VisCompentencia_Mov
    {
        public E_Reporte_VisCompentencia_Mov() {
            Detalle = new List<E_Reporte_VisCompentencia_Mov_Detalle>();
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
        public int Cod_Marca { get; set; }
        [JsonProperty("g")]
        public DateTime Fec_Registro { get; set; }
        [JsonProperty("h")]
        public string Latitud { get; set; }
        [JsonProperty("i")]
        public string Longitud { get; set; }
        [JsonProperty("j")]
        public string Origen { get; set; }
        [JsonProperty("k")]
        public string Comentario { get; set; }
        [JsonProperty("l")]
        public int Cod_Competidora { get; set; }
        [JsonProperty("m")]
        public List<E_Reporte_VisCompentencia_Mov_Detalle> Detalle { get; set; }
        //Add 04/05/2012 PSA
        [JsonProperty("n")]
        public string Cod_Familia { get; set; }
        [JsonProperty("o")]
        public string Cod_SubFamilia { get; set; }
    }

    /// <summary>
    /// Descripcion : Detalle de Reporte de Visibilidad Competencia Movistar
    /// Fecha       : 19/05/2012 PSA
    /// </summary>
    public class E_Reporte_VisCompentencia_Mov_Detalle {

        [JsonProperty("a")]
        public string Cod_MatApoyo { get; set; }
        [JsonProperty("b")]
        public string Comentario { get; set; }
        [JsonProperty("c")]
        public string Nombre_Foto { get; set; }

    }
}
