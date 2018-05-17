using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Competencia_Detalle
    {
        private string id_reg_competencia;
        [JsonProperty("a")]
        public string Id_reg_competencia
        {
            get { return id_reg_competencia; }
            set { id_reg_competencia = value; }
        }
        private string id_pop;
        [JsonProperty("b")]
        public string Id_pop
        {
            get { return id_pop; }
            set { id_pop = value; }
        }


    }
}
