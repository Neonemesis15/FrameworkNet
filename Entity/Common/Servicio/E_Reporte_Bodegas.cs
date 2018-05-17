using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    /// <summary>
    /// Descripcion     : Entidad para devolver el Reporte de Colgate Bodegas.
    /// Fecha           : -------
    /// Actualizacion   : 19/09/2012 PCP.
    /// </summary>
    public class E_Reporte_Bodegas
    {
        [JsonProperty("a")]
        public string CodPtoVenta { get; set; }

        [JsonProperty("b")]
        public string NombrePtoVenta { get; set; }

        [JsonProperty("c")]
        public string CodElemento { get; set; }

        [JsonProperty("d")]
        public string NombreElemento { get; set; }

        [JsonProperty("e")]
        public string Objetivo { get; set; }

        [JsonProperty("f")]
        public string Cantidad { get; set; }

        [JsonProperty("g")]
        public string Cod_Categoria { get; set; }

        [JsonProperty("h")]
        public string Nombre_Categoria { get; set; }

        [JsonProperty("i")]
        public string Cod_Marca { get; set; }

        [JsonProperty("j")]
        public string Nombre_Marca { get; set; }

        [JsonProperty("k")]
        public string Cod_Oficina { get; set; }

        [JsonProperty("l")]
        public string Nombre_Oficina { get; set; }

        //Actualizacion_02. 
        [JsonProperty("m")]
        public string Cod_Cadena { get; set; }
        [JsonProperty("n")]
        public string Nombre_Cadena { get; set; }
        [JsonProperty("o")]
        public string Cod_Persona { get; set; }
        [JsonProperty("p")]
        public string Persona_Nombre { get; set; }
        [JsonProperty("q")]
        public string Cod_SubReporte { get; set; }
        [JsonProperty("r")]
        public string SubReporte_Nombre { get; set; }
        [JsonProperty("s")]
        public string Cod_MaterialApoyo { get; set; }
        [JsonProperty("t")]
        public string MaterialApoyo_Nombre { get; set; }
        [JsonProperty("u")]
        public string Cod_Observacion { get; set; }
        [JsonProperty("v")]
        public string Observacion_Marcada { get; set; } //Solo debe Permitir Números(1)
        [JsonProperty("w")]
        public string SKU_Producto { get; set; }
        [JsonProperty("x")]
        public string Producto_Nombre { get; set; }
        [JsonProperty("y")]
        public string Cod_Equipo { get; set; }
        [JsonProperty("z")]
        public string Nombre_Ciudad { get; set; }
        [JsonProperty("ñ")]
        public string Direccion_PDV { get; set; }
        [JsonProperty("aa")]
        public string Cod_Cluster { get; set; }
        [JsonProperty("ab")]
        public string Nombre_Cluster { get; set; }
    }
}
