using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Encuesta
    {
        public E_Reporte_Encuesta() {
            oListE_DistribuidoraEncuesta = new List<E_DistribuidoraEncuesta>();
        }

        [JsonProperty("a")]
        public String preguntaA;

        [JsonProperty("b")]
        public String preguntaB;

        [JsonProperty("c")]
        public String preguntaC;

        [JsonProperty("d")]
        public String codigoUsuario;

        [JsonProperty("e")]
        public String codigoEquipo;

        [JsonProperty("f")]
        public String fechaEncuesta;

        [JsonProperty("g")]
        public List<E_DistribuidoraEncuesta> oListE_DistribuidoraEncuesta;

        [JsonProperty("h")]
        public String codigoPtoVenta;
    }

    public class E_Reporte_Encuesta_EQF
    {
        public E_Reporte_Encuesta_EQF()
        {
            oListE_DistribuidoraEncuesta = new List<E_DistribuidoraEncuesta>();
        }

        [JsonProperty("a")]
        public String preguntaA;

        [JsonProperty("b")]
        public String preguntaB;

        [JsonProperty("c")]
        public String preguntaC;

        [JsonProperty("d")]
        public String codigoUsuario;

        [JsonProperty("e")]
        public String codigoEquipo;

        [JsonProperty("f")]
        public String fechaEncuesta;

        [JsonProperty("g")]
        public List<E_DistribuidoraEncuesta> oListE_DistribuidoraEncuesta;

        [JsonProperty("h")]
        public String codigoPtoVenta;

        [JsonProperty("i")]
	    public String preguntaE;
	
	    [JsonProperty("j")]
	    public List<E_Respuesta> oListEQF;

        [JsonProperty("k")]
	    public String preguntaG;
    }

    public class E_Respuesta {

	    [JsonProperty("a")]
	    public String codigo;

        [JsonProperty("b")]
	    public List<E_Respuesta_Detalle> detalleRspta;	
    }

    public class E_Respuesta_Detalle {

	    [JsonProperty("a")]
	    public String codigo;

        [JsonProperty("b")]
	    public String adicional;
    }
}
