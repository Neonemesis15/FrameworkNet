using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Seguimiento_Ruta_PDV
    {
        [JsonProperty("a")]
        public string codigoPtoVenta { get; set; }

        [JsonProperty("b")]
        public string nombrePtoVenta { get; set; }

        [JsonProperty("c")]
        public string direccion { get; set; }

        [JsonProperty("d")]
        public string latitud { get; set; }

        [JsonProperty("e")]
        public string longitud { get; set; }

        [JsonProperty("f")]
        public int posicion { get; set; }
    }

    public class E_Seguimiento_Ruta_Visitado
    {
        [JsonProperty("a")]
        public int posicion { get; set; }

        [JsonProperty("b")]
        public string zona { get; set; }

        [JsonProperty("c")]
        public string codigoPtoVenta { get; set; }

        [JsonProperty("d")]
        public string nombrePtoVenta { get; set; }

        [JsonProperty("e")]
        public string distrito { get; set; }

        [JsonProperty("f")]
        public string direccion { get; set; }

        [JsonIgnore()]
        public DateTime inicioVisitaDate { get; set; }

        [JsonIgnore()]
        public DateTime finVisitaDate { get; set; }

        [JsonProperty("g")]
        public string inicioVisita { get; set; }

        [JsonProperty("h")]
        public string finVisita { get; set; }

        [JsonProperty("i")]
        public string atencion { get; set; }

        [JsonProperty("j")]
        public string estado { get; set; }

        [JsonProperty("k")]
        public string latitud { get; set; }

        [JsonProperty("l")]
        public string longitud { get; set; }

        [JsonProperty("m")]
        public string colorEstado { get; set; }

        [JsonProperty("n")]
        public string traslado { get; set; }

        [JsonProperty("o")]
        public double atencionSeg { get; set; }

        [JsonProperty("p")]
        public double trasladoSeg { get; set; }

        [JsonProperty("q")]
        public List<E_Foto_Visitado> listaFoto { get; set; }
    }

    public class E_Seguimiento_Ruta
    {
        [JsonProperty("a")]
        public List<E_Seguimiento_Ruta_PDV> listPDVRuta { get; set; }

        [JsonProperty("b")]
        public List<E_Seguimiento_Ruta_Visitado> listPDVVisitados { get; set; }

        [JsonProperty("c")]
        public List<E_Seguimiento_Ruta_Visitado> listPDVNoVisitados { get; set; }
    }

    public class E_Foto_Visitado
    {
        [JsonProperty("a")]
        public string nombreFoto { get; set; }
    }
}
