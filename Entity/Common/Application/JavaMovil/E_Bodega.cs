using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Bodega
    {
        //Add pSalas 16/02/2012

        private string codCliente;
        private string nombre;
        private string direccion;

        [JsonProperty("a")]
        public string CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        [JsonProperty("b")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [JsonProperty("c")]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


    }
}
