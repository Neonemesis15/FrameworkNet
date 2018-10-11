using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Estados de No Visita para la App Mobile
    /// Developed by:
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Encapsule Methods.
    /// </summary>
    public class E_NoVisita
    {

        [JsonProperty("a")]
        public string Id_noVisita {get;set;}

        public string getId_noVisita() {
            return Id_noVisita;
        }

        public void setId_noVisita(string Id_noVisita)
        {
            this.Id_noVisita = Id_noVisita;
        }

        [JsonProperty("b")]
        public string Descripcion {get;set;}

        public string getDescripcion() {
            return Descripcion;
        }

        public void setDescripcion(string Descripcion)
        {
            this.Descripcion = Descripcion;
        }


        [JsonProperty("c")]
        public string tipo { get; set; }

        public string getTipo() {
            return tipo;
        }

        public void setTipo(string tipo) {
            this.tipo = tipo;
        }


        [JsonProperty("d")]
        public string grupo { get; set; }

        public string getGrupo() {
            return grupo;
        }

        public void setGrupo(string grupo) {
            this.grupo = grupo;
        }
        

    }
}
