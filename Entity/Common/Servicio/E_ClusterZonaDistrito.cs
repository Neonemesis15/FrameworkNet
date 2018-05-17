using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_ClusterZonaDistrito_Group
    {
        public E_ClusterZonaDistrito_Group()
        {
            listClusterProvincia = new List<E_ClusterZonaDistrito>();
            listClusterSector = new List<E_ClusterZonaDistrito>();
            listClusterDistrito = new List<E_ClusterZonaDistrito>();
            listClusterVisitado = new List<E_ClusterZonaDistrito>();
        }

        [JsonProperty("a")]
        public List<E_ClusterZonaDistrito> listClusterProvincia { get; set; }

        [JsonProperty("b")]
        public List<E_ClusterZonaDistrito> listClusterSector { get; set; }

        [JsonProperty("c")]
        public List<E_ClusterZonaDistrito> listClusterDistrito { get; set; }

        [JsonProperty("d")]
        public List<E_ClusterZonaDistrito> listClusterVisitado { get; set; }
    }
        
    public class E_ClusterZonaDistrito
    {
        [JsonProperty("a")]
        public string cluster { get; set; }

        [JsonProperty("b")]
        public string cantidad { get; set; }

        [JsonProperty("c")]
        public string codigo { get; set; }

        [JsonProperty("d")]
        public int posicion { get; set; }
    }
}
