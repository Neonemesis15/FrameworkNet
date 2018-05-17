using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Consulta_Reporte_Exhibicion
    {

        [JsonProperty("a")]
        public string Nombre_PuntoDeVenta { get; set; }

        [JsonProperty("b")]
        public string Nombre_Categoria { get; set; }

        [JsonProperty("c")]
        public string Nombre_Marca { get; set; }

        [JsonProperty("d")]
        public string Fecha_Inicio { get; set; }

        [JsonProperty("e")]
        public string Fecha_Fin { get; set; }

        [JsonProperty("f")]
        public int Cantidad { get; set; }

        [JsonProperty("g")]
        public string Descripcion { get; set; }

        [JsonProperty("h")]
        public string Registrado_Por { get; set; }

        [JsonProperty("i")]
        public Boolean Validado { get; set; }

        [JsonProperty("j")]
        public Boolean Validado_Cliente { get; set; }

        [JsonProperty("k")]
        public int Cod_Exhibicion_Detalle { get; set; }

        [JsonProperty("l")]
        public string Nombre_Mercaderista { get; set; }

        [JsonProperty("m")]
        public string Fecha_Registro_BD { get; set; }

        [JsonProperty("n")]
        public string Modificado_Por { get; set; }

        [JsonProperty("o")]
        public string Fecha_Modificacion { get; set; }

        [JsonProperty("p")]
        public string Codigo_PuntoDeVenta { get; set; }

        [JsonProperty("q")]
        public string Nombre_NodoComercial { get; set; }

        //Peter Ccopa - 24/08/2012
        //Para mostrar la foto del Reporte
        [JsonProperty("r")]
        public string Nombre_Foto { get; set; }

        [JsonProperty("s")]
        public string Num_Fila { get; set; }

        [JsonProperty("t")]
        public string Id_Reporte { get; set; }
    }
}
