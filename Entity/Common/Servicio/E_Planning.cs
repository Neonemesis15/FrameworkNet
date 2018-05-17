using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Planning
    {
        [JsonProperty("a")]
        public string idPlanning { get; set; }

        [JsonProperty("b")]
        public string duracionProyecto { get; set; }

        [JsonProperty("c")]
        public string codCanal { get; set; }

        [JsonProperty("d")]
        public string estado { get; set; }

        [JsonProperty("e")]
        public string objetivo { get; set; }

        [JsonProperty("f")]
        public string mandatorio { get; set; }

        [JsonProperty("g")]
        public string mecanica { get; set; }

        [JsonProperty("h")]
        public string AreaInvolucrada { get; set; }

        [JsonProperty("i")]
        public string Contacto { get; set; }

        [JsonProperty("j")]
        public string FechaInicio { get; set; }

        [JsonProperty("k")]
        public string FechaFin { get; set; }

        [JsonProperty("l")]//Add 11/12/2012 psa.
        public string CodBudget { get; set; }

        [JsonProperty("m")]//Add 11/12/2012 psa.
        public string Planning_Name { get; set; }

        [JsonProperty("n")]//Add 11/12/2012 psa. -1 Registra - 2 Actualiza
        public string Opcion { get; set; }

        [JsonProperty("o")]//Add 11/12/2012 psa.
        public string CodStrategia { get; set; }

        [JsonProperty("p")]//Add 11/12/2012 psa.
        public string NameUser { get; set; }
        

    }
}
