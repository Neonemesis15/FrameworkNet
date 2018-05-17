using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_SincronizarPreDatos
    {
        [JsonProperty("a")]
        public List<E_Pais> listaPais { get; set; }

        [JsonProperty("b")]
        public List<E_Departamento> listaDepartamento { get; set; }

        [JsonProperty("c")]
        public List<E_Provincia> listaProvincia { get; set; }

        [JsonProperty("d")]
        public List<E_Distrito> ListaDistrito { get; set; }
    }
}