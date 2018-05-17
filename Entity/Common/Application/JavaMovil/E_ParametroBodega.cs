using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_ParametroBodega
    {
        //Add pSalas 16/02/2012
        private string codigoTabla;
        private string codigo;
        private string descripcion;

         [JsonProperty("a")]
        public string CodigoTabla
        {
            get { return codigoTabla; }
            set { codigoTabla = value; }
        }
        
         [JsonProperty("b")]
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
       
         [JsonProperty("c")]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
       
         
    }
}
