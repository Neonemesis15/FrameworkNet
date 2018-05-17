using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    //Clase para Mostrar la Primera Carga de los Informes. Alicorp - XploraMaps - Add 16/11/2012
    public class E_DatosFiltros
    {
        public E_DatosFiltros() {
            E_DatFil_DiasGiro = new E_DatFil_DiasGiro();
            E_DatFil_Precio = new E_DatFil_Precio();
            E_DatFil_SOD = new E_DatFil_SOD();
        }

        [JsonProperty("a")]
        public string CodCanal { get; set; }
        [JsonProperty("b")]
        public string Anio { get; set; }
        [JsonProperty("c")]
        public string Mes { get; set; }
        [JsonProperty("d")]
        public string Periodo { get; set; }
        /*[JsonProperty("e")]
        public string CodCategoria { get; set; }
        [JsonProperty("f")]
        public string Sku { get; set; }
        */
        [JsonProperty("e")]
        public E_DatFil_DiasGiro E_DatFil_DiasGiro { get; set; }
        [JsonProperty("f")]
        public E_DatFil_Precio E_DatFil_Precio { get; set; }
        [JsonProperty("g")]
        public E_DatFil_SOD E_DatFil_SOD { get; set; }
    }

    public class E_DatFil_DiasGiro{
        [JsonProperty("a")]
        public string CodCategoria{get;set;}
    }

    public class E_DatFil_Precio{
        [JsonProperty("a")]
        public string CodCategoria{get;set;}
        [JsonProperty("b")]
        public string Sku { get; set; }
    }

    public class E_DatFil_SOD {
        [JsonProperty("a")]
        public string CodCategoria { get; set; }
    }
}
