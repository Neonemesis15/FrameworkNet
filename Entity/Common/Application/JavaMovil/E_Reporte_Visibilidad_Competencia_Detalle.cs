using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Detalle Entidad Reporte Visibilidad
    /// Creado por: Ing. Carlos Alberto Hernandez
    /// Fecha:06/03/2011
    /// </summary>
    public class E_Reporte_Visibilidad_Competencia_Detalle
    {
        private int id_RegVCom;

        [JsonIgnore()]
        public int Id_RegVCom
        {
            get { return id_RegVCom; }
            set { id_RegVCom = value; }
        }

        private string id_pop;

        [JsonProperty("b")]
        public string Id_pop
        {
            get { return id_pop; }
            set { id_pop = value; }
        }

        private string comentario;

        [JsonProperty("c")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        private string imagen;
        [JsonProperty("d")]
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

    }
}