using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    /// <summary>
    /// Descripcion     : Entidad para devolver el Reporte General.
    /// Fecha           : -------
    /// Actualizacion_01: 24/05/2012 PSA. Se agrega los parametros, Cod_Categoria, Nombre_Categoria, Cod_Marca y Nombre_Marca a solicitud de AHU.
    /// Actualizacion_02: 16/06/2012 PSA. Se agrega los parametros, Cod_Cadena,Nombre_Cadena, Cod_Persona, Persona_Nombre, Cod_SubReporte, SubReporte_Nombre, Cod_MaterialApoyo, MaterialApoyo_Nombre, Cod_Observación, Observacion_Marcó, SKU_Producto, Producto_Nombre
    /// </summary>
    public class E_Reporte_General
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
        public string Nombre_Cadena{get;set;}
        [JsonProperty("o")]
        public string Cod_Persona{get;set;}
        [JsonProperty("p")]
        public string Persona_Nombre{get;set;}
        [JsonProperty("q")]
        public string Cod_SubReporte{get;set;}
        [JsonProperty("r")]
        public string SubReporte_Nombre{get;set;}
        [JsonProperty("s")]
        public string Cod_MaterialApoyo{get;set;}
        [JsonProperty("t")]
        public string MaterialApoyo_Nombre{get;set;}
        [JsonProperty("u")]
        public string Cod_Observacion{get;set;}
        [JsonProperty("v")]
        public string Observacion_Marcada{get;set;} //Solo debe Permitir Números(1)
        [JsonProperty("w")]
        public string SKU_Producto{get;set;}
        [JsonProperty("x")]
        public string Producto_Nombre { get; set; }
        [JsonProperty("y")]
        public string Cod_Equipo { get; set; }
        [JsonProperty("z")]
        public string Nombre_Ciudad { get; set; }
        [JsonProperty("ñ")]
        public string Direccion_PDV { get; set; }
    }
}
