using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Registro_MotivoFase
    {
        public E_Registro_MotivoFase() {
            listaMotivo = new List<E_MotivoFase>();
        }

        [JsonProperty("a")]
        public int Cod_Persona { get; set; }

        [JsonProperty("b")]
        public string Cod_Equipo { get; set; }

        [JsonProperty("c")]
        public int Cod_Compania { get; set; }

        [JsonProperty("d")]
        public string Cod_PtoVenta { get; set; }

        [JsonProperty("e")]
        public string FechaRegistro { get; set; }

        [JsonProperty("f")]
        public string Latitud { get; set; }

        [JsonProperty("g")]
        public string Longitud { get; set; }

        [JsonProperty("h")]
        public string Origen { get; set; }

        [JsonProperty("i")]
        public string Fase { get; set; }

        [JsonProperty("j")]
        public List<E_MotivoFase> listaMotivo { get; set; }

        [JsonIgnore] 
        public string Nuevo { get; set; }// Si el PDV es Nuevo o Antiguo
        
    }

    public class E_MotivoFase
    {
        [JsonProperty("a")]
        public int CodMotivo { get; set; }
    }
}
