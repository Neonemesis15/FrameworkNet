using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Pregunta
    {
        //Add 16/02/2012
        private string id_preg;
        private string pregunta_Descripcion;
        private string tipoPregunta;
        private string show;
        
        //Constructor
        public E_Pregunta()
        {
            Id_Opcion = new List<E_Opcion>();

        }

        [JsonProperty("a")]
        public string Id_preg
        {
            get { return id_preg; }
            set { id_preg = value; }
        }

        [JsonProperty("b")]
        public string Pregunta_Descripcion
        {
            get { return pregunta_Descripcion; }
            set { pregunta_Descripcion = value; }
        }

        [JsonProperty("c")]
        public string TipoPregunta
        {
            get { return tipoPregunta; }
            set { tipoPregunta = value; }
        }

        [JsonProperty("d")]
        public string Show
        {
            get { return show; }
            set { show = value; }
        }

        [JsonProperty("e")]
        public List<E_Opcion> Id_Opcion { get; set; }
    }
}
