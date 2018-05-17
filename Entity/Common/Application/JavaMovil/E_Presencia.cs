using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Presencia
    {
        //Add 16/02/2012 pSalas
        private string cod_Producto;
        private string prod_Nombre;

        [JsonProperty("a")]
        public string Cod_Producto
        {
            get { return cod_Producto; }
            set { cod_Producto = value; }
        }

        [JsonProperty("b")]
        public string Prod_Nombre
        {
            get { return prod_Nombre; }
            set { prod_Nombre = value; }
        }
    }
}
