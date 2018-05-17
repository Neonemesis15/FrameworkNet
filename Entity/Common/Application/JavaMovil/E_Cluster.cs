using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Cluster
    {
        //Add pSalas 16/02/2012
        private string cod_cluster;
        private string pregunta;
        private int req_Cantidad;

        [JsonProperty("a")]
        public string Cod_cluster
        {
            get { return cod_cluster; }
            set { cod_cluster = value; }
        }

         [JsonProperty("b")]
        public string Pregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }

         [JsonProperty("c")]
        public int Req_Cantidad
        {
            get { return req_Cantidad; }
            set { req_Cantidad = value; }
        }

    }
}
