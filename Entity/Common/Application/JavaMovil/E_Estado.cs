using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Estados para la App Mobile
    /// Developed by:
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Add comments.
    /// </summary>
    public class E_Estado
    {
        [JsonProperty("a")]
        public String Codigo { get; set; }
        [JsonProperty("b")]
        public String Descripcion { get; set; }

        public String getCodigo() {
            return Codigo;
        }
        public void setCodigo(String Codigo) {
            this.Codigo = Codigo;
        }

        public String getDescripcion() {
            return Descripcion;
        }
        public void setDescripcion(String Descripcion) {
            this.Descripcion = Descripcion;
        }
    }
}
