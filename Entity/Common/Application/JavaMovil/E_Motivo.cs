using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Motivos para la App Mobile
    /// Developed by:
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Encapsule Methods
    /// </summary>
    public class E_Motivo
    {
        [JsonProperty("a")]
        public String Codigo { get; set; }

        [JsonProperty("b")]
        public String CodigoEstado { get; set; }

        [JsonProperty("c")]
        public String Descripcion { get; set; }

        public String getCodigo() {
            return Codigo;
        }
        public void setCodigo(String Codigo)
        {
            this.Codigo = Codigo;
        }
        
        public String getCodigoEstado() {
            return CodigoEstado;
        }
        public void getCodigoEstado(String CodigoEstado) {
            this.CodigoEstado = CodigoEstado;
        }

        public String getDescripcion() {
            return Descripcion;
        }
        public void setDescripcion(String Descripcion) {
            this.Descripcion = Descripcion;
        }

    }
}
