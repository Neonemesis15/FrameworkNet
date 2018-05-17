using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Usuario
    {
        [JsonProperty("i")]
        public string Person_Id { get; set; }

        [JsonProperty("f")]
        public string Equipo_Id { get; set; }

        [JsonProperty("e")]
        public string Id_Canal { get; set; }

        [JsonProperty("c")]
        public string Id_Compania { get; set; }

        [JsonProperty("n")]
        public string Mer_Nombre { get; set; }

        [JsonProperty("p")]
        public string CodPais { get; set; }

        [JsonProperty("q")]
        public string NombrePais { get; set; }

        [JsonProperty("r")]
        public string Perfil_Id { get; set; }
    }
}
