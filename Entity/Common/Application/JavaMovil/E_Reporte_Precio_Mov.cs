using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Descripcion : Reporte de Precio para App Movil Movistar
    /// Fecha       : 26/05/2012 PSA
    /// </summary>
    public class E_Reporte_Precio_Mov
    {
        public E_Reporte_Precio_Mov() {
            Detalle = new List<E_Reporte_Precio_Mov_Detalle>();
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
        public string Cod_Familia { get; set; }
        [JsonProperty("h")]
        public string Cod_SubFamilia { get; set; }
        [JsonProperty("i")]
        public string Fecha_Registro { get; set; }
        [JsonProperty("j")]
        public string Latitud { get; set; }
        [JsonProperty("k")]
        public string Longitud { get; set; }
        [JsonProperty("l")]
        public string Origen { get; set; }
        [JsonProperty("m")]
        public string Observacion { get; set; }
        [JsonProperty("n")]
        public string Tipo_Precio { get; set; }
        [JsonProperty("o")]
        public List<E_Reporte_Precio_Mov_Detalle> Detalle { get; set; }

    }

    public class E_Reporte_Precio_Mov_Detalle {
        [JsonProperty("a")]
        public string Sku_Producto { get; set; }
        [JsonProperty("b")]
        public string Precio_Lista { get; set; }
        [JsonProperty("c")]
        public string Precio_Reventa { get; set; }
        [JsonProperty("d")]
        public string Precio_Oferta { get; set; }
        [JsonProperty("e")]
        public string Precio_PVP { get; set; }
        [JsonProperty("f")]
        public string Precio_Costo { get; set; }
        [JsonProperty("g")]
        public string Precio_Regular { get; set; }
        [JsonProperty("h")]
        public string Precio_Min { get; set; }
        [JsonProperty("i")]
        public string Precio_Max { get; set; }
        [JsonProperty("j")]
        public string Precio_Mayorista { get; set; }
        [JsonProperty("k")]
        public string Motivo_Observacion { get; set; }
    }
}
