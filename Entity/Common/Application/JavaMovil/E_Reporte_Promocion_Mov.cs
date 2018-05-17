using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Promocion_Mov
    {
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
        public string Cod_CompaniaPromo { get; set; }
        [JsonProperty("h")]
        public string Cod_Promocion { get; set; }
        [JsonProperty("i")]
        public string Descripcion_Promocion { get; set; }
        [JsonProperty("j")]
        public string Mecanica { get; set; }
        [JsonProperty("k")]
        public string SKU_Producto { get; set; }
        [JsonProperty("l")]
        public string Fec_Ini_Promocion { get; set; }
        [JsonProperty("m")]
        public string Fec_Fin_Promocion { get; set; }
        [JsonProperty("n")]
        public string Precio_Promocion { get; set; }
        [JsonProperty("o")]
        public string Precio_Regular { get; set; }
        [JsonProperty("p")]
        public string Nombre_Foto { get; set; }
        [JsonProperty("q")]
        public DateTime Fec_Registro { get; set; }
        [JsonProperty("r")]
        public string Latitud { get; set; }
        [JsonProperty("s")]
        public string Longitud { get; set; }
        [JsonProperty("t")]
        public string Origen { get; set; }
        [JsonProperty("u")]
        public string Comentario { get; set; }
        
        //Add 04/05/2012 PSA
        [JsonProperty("v")]
        public string Cod_Familia{get;set;}
        [JsonProperty("w")]
        public string Cod_SubFamilia { get; set; }
        
    }
}
