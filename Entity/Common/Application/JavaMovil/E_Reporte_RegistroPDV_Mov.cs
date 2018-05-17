using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_RegistroPDV_Mov
    {
        [JsonProperty("a")]
        public string Cod_TipoDocumento{get;set;}
        [JsonProperty("b")]
        public string PDV_RegTax { get; set; }
        [JsonProperty("c")]
        public string PDV_Cliente_Nombres { get; set; }
        [JsonProperty("d")]
        public string PDV_Cliente_Apellidos { get; set; }
        [JsonProperty("e")]
        public string PDV_RazonSocial { get; set; }
        [JsonProperty("f")]
        public string PDV_Telefono { get; set; }
        [JsonProperty("g")]
        public string Cod_Pais { get; set; }
        [JsonProperty("h")]
        public string Cod_Departamento { get; set; }
        [JsonProperty("i")]
        public string Cod_Provincia { get; set; }
        [JsonProperty("j")]
        public string Cod_Distrito { get; set; }
        [JsonProperty("k")]
        public string PDV_Direccion { get; set; }
        [JsonProperty("l")]
        public string Cod_Compania { get; set; }
        [JsonProperty("m")]
        public string Cod_Canal { get; set; }
        [JsonProperty("n")]
        public string Cod_Equipo { get; set; }
        [JsonProperty("o")]
        public string Cod_TipoNodoComercial { get; set; }
        [JsonProperty("p")]
        public string Cod_NodoComercial { get; set; }
        [JsonProperty("q")]
        public string Cod_Segmento { get; set; }
        [JsonProperty("r")]
        public string Creado_Por { get; set; }
        [JsonProperty("s")]
        public string Fecha_Registro { get; set; }
        [JsonProperty("t")]
        public string POSClient_Referencia{get;set;}
        [JsonProperty("u")]
        public string Cod_Ciudad { get; set; }
        [JsonProperty("v")]
        public string Cod_Oficina { get; set; }
        [JsonProperty("w")]
        public string Cod_Malla { get; set; }
        [JsonProperty("x")]
        public string Cod_Sector { get; set; }
        [JsonProperty("y")]
        public string POSPlanning_Estado { get; set; }

        [JsonProperty("z")]
        //[JsonIgnore]
        public List<E_Codigo_ITT_Distribuidora> ListaDistribuidora { get; set; }

        //[JsonProperty("aa")]
        //[JsonIgnore]
        //public List<E_Codigo_ITT_Nueva_Distribuidora> ListaNuevaDistribuidora { get; set; }

        [JsonProperty("ab")]
        public string Cod_Persona { get; set; }
        
        [JsonProperty("ac")]
        public string Latitud { get; set; }
        
        [JsonProperty("ad")]
        public string Longitud { get; set; }

        [JsonProperty("ae")]
        public string Origen { get; set; }

    }

    public class E_Reporte_RegistroPDV_Response {
        [JsonProperty("a")]
        public E_PuntoVenta NuevoCliente { get;set; }
        
        [JsonProperty("b")]
        public List<E_Distribuidora> ListaDistribuidoras { get; set; }

        [JsonProperty("c")]
        public string Mensaje { get; set; }
    }
}
