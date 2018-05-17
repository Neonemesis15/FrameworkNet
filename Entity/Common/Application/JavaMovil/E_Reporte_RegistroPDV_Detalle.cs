using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_RegistroPDV_Detalle
    {
        [JsonIgnore()]
        public long Id_Reg_RegistroPDV { get; set; }

        [JsonProperty("m")]
        public string id_Pregunta { get; set; }

        [JsonProperty("n")]
        public List<E_Reporte_RegistroPDV_Detalle_Opcion> Id_Opcion { get; set; }

        public E_Reporte_RegistroPDV_Detalle() {
            Id_Opcion = new List<E_Reporte_RegistroPDV_Detalle_Opcion>();
        }
    }
}
