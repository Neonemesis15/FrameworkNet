using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Pop_General_Detalle
    {

        private string id_reg_pop;
        [JsonIgnore()]
        public string Id_reg_pop
        {
            get { return id_reg_pop; }
            set { id_reg_pop = value; }
        }
        private string id_marca;
        [JsonProperty("a")]
        public string Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        private bool presencia;
        [JsonProperty("b")]
        public bool Presencia
        {
            get { return presencia; }
            set { presencia = value; }
        }
        private bool requerido;
        [JsonProperty("c")]
        public bool Requerido
        {
            get { return requerido; }
            set { requerido = value; }
        }
        private string comentario;
        [JsonProperty("d")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        private string fecha_ini;
        [JsonProperty("e")]
        public string Fecha_ini
        {
            get { return fecha_ini; }
            set { fecha_ini = value; }
        }
        private string fecha_fin;
        [JsonProperty("f")]
        public string Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        private string foto;
        [JsonProperty("g")]
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        private string id_pop;
        [JsonProperty("h")]
        public string Id_pop
        {
            get { return id_pop; }
            set { id_pop = value; }
        }
    }
}
