using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Servicio
{
    public class E_Consulta_Reporte_Precio
    {
        [JsonProperty("a")]
        public string Nombre_Categoria { get; set; }
        [JsonProperty("b")]
        public string Nombre_SubCategoria { get; set; }
        [JsonProperty("c")]
        public string Nombre_Marca { get; set; }
        [JsonProperty("d")]
        public string Nombre_PuntoDeVenta { get; set; }
        [JsonProperty("e")]
        public string Nombre_Producto { get; set; }
        [JsonProperty("f")]
        public string SKU { get; set; }
        [JsonProperty("g")]
        public float Precio_Lista { get; set; }
        [JsonProperty("h")]
        public float Precio_Reventa { get; set; }
        [JsonProperty("i")]
        public float Precio_Oferta { get; set; }
        [JsonProperty("j")]
        public float Precio_PuntoDeVenta { get; set; }
        [JsonProperty("k")]
        public float Precio_Costo { get; set; }
        [JsonProperty("l")]
        public float Precio_Minimo { get; set; }
        [JsonProperty("m")]
        public float Precio_Maximo { get; set; }
        [JsonProperty("n")]
        public string Registrado_Por { get; set; }
        [JsonProperty("o")]
        public Boolean Validado { get; set; }
        [JsonProperty("p")]
        public Boolean Validado_Cliente { get; set; }
        [JsonProperty("q")]
        public int Cod_Precio_Detalle { get; set; }
        [JsonProperty("r")]
        public string Person_Name { get; set; }
        [JsonProperty("s")]
        public DateTime Fecha_Registro_BD { get; set; }
        [JsonProperty("t")]
        public string Modificado_Por { get; set; }
        [JsonProperty("u")]
        public DateTime Fecha_Modificacion { get; set; }
        [JsonProperty("v")]
        public string Cod_Cliente_PDV { get; set; }
        [JsonProperty("w")]
        public string Nombre_NodoComercial { get; set; }
        [JsonProperty("x")]
        public string Nombre_Oficina { get; set; }
        [JsonProperty("y")]
        public string Observacion { get; set; }

    }
}
