using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Consulta_Reporte_Stock
    {
        [JsonProperty("w")]
        public string Abreviatura_Oficina { get; set; }

        [JsonProperty("a")]
        public string Nombre_Oficina { get; set; }

        [JsonProperty("b")]
        public string Nombre_Zona { get; set; }

        [JsonProperty("x")]
        public string Codigo_PDV_Compania { get; set; }

        [JsonProperty("c")]
        public string Nombre_PDV { get; set; }

        [JsonProperty("d")]
        public string Nombre_Categoria { get; set; }

        [JsonProperty("e")]
        public string Nombre_Familia { get; set; }

        [JsonProperty("f")]
        public string Cantidad { get; set; }

        [JsonProperty("g")]
        public string Motivo_Obs { get; set; }

        [JsonProperty("h")]
        public string Cod_Producto { get; set; }

        [JsonProperty("i")]
        public string Pedido { get; set; }

        [JsonProperty("j")]
        public string Ingreso { get; set; }

        [JsonProperty("k")]
        public string Venta { get; set; }

        [JsonProperty("l")]
        public string Semana { get; set; }

        [JsonProperty("m")]
        public string Exhibicion { get; set; }

        [JsonProperty("n")]
        public string Camara { get; set; }

        [JsonProperty("o")]
        public string Opcion { get; set; }

        [JsonProperty("p")]
        public string Registrado_Por { get; set; }

        [JsonProperty("q")]
        public DateTime Fecha_Registro_Bd { get; set; }

        [JsonProperty("r")]
        public string Modificado_Por { get; set; }

        [JsonProperty("s")]
        public DateTime Fecha_Modificacion { get; set; }

        [JsonProperty("t")]
        public bool Validado { get; set; }

        [JsonProperty("u")]
        public bool Validado_Cliente { get; set; }

        [JsonProperty("v")]
        public int Cod_Stock_Detalle { get; set; }

        [JsonProperty("y")]
        public string Nombre_NodoComercial { get; set; }

        [JsonProperty("z")]
        public float Peso_Familia { get; set; }

    }
}
