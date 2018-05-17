using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Sincronizar_Bodega
    {
        [JsonProperty("a")]
        public List<E_Presencia> ListaPresencia { get; set; }

        [JsonProperty("b")]
        public List<E_ParametroBodega> ListaParametroBodega { get; set; }

        [JsonProperty("c")]
        public List<E_Cluster> ListaCluster { get; set; }

        [JsonProperty("d")]
        public List<E_Bodega> ListaBodega { get; set; }

        [JsonProperty("e")]
        public List<E_Pregunta> ListaPregunta { get; set; }

        ////Add pSalas 16/02/2012
        //[JsonProperty("f")]
        //public List<E_Opcion> ListaOpcion { get; set; }


    }
}
