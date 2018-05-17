using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Opcion
    {
        //Add pSalas 16/02/2012

        private string id_Opcion;
        private string id_Preg;
        private string opcion_Descripcion;
         
        [JsonProperty("f")]
        public string Id_Opcion
        {
            get { return id_Opcion; }
            set { id_Opcion = value; }
        }

        [JsonIgnore()]
        public string Id_Preg
        {
            get { return id_Preg; }
            set { id_Preg = value; }
        }

        [JsonProperty("h")]
        public string Opcion_Descripcion
        {
            get { return opcion_Descripcion; }
            set { opcion_Descripcion = value; }
        }

    }
}
