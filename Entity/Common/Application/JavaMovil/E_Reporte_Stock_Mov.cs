using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Stock_Mov
    {
        public E_Reporte_Stock_Mov() {
            Detalle = new List<E_Reporte_Stock_Mov_Detalle>();
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
        public List<E_Reporte_Stock_Mov_Detalle> Detalle { get; set; }

    }
    public class E_Reporte_Stock_Mov_Detalle {
        [JsonProperty("a")]
        public string Cod_Familia { get; set; }
        [JsonProperty("b")]
        public string Cantidad { get; set; }
        [JsonProperty("c")]
        public string Motivo_Obs { get; set; }
        [JsonProperty("d")]
        public string SKU_Producto { get; set; }
        [JsonProperty("e")]
        public string Pedido { get; set; }
        [JsonProperty("f")]
        public string Ingreso { get; set; }
        [JsonProperty("g")]
        public string Venta { get; set; }
        [JsonProperty("h")]
        public string Semana { get; set; }
        [JsonProperty("i")]
        public string Exhibicion { get; set; }
        [JsonProperty("j")]
        public string Camara { get; set; }
        [JsonProperty("k")]
        public string Opcion { get; set; }
     
    }
}
