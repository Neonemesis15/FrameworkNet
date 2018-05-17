using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_NoVisita
    {
        private string id_noVisita;
        [JsonProperty("a")]
        public string Id_noVisita
        {
            get { return id_noVisita; }
            set { id_noVisita = value; }
        }
        private string descripcion;
        [JsonProperty("b")]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [JsonProperty("c")]
        public string tipo { get; set; }

        [JsonProperty("d")]
        public string grupo { get; set; }
    }
}
