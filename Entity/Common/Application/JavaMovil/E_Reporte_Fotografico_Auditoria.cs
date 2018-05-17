using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Fotografico_Auditoria
    {
        [JsonProperty("i")]
        public string Person_id { get; set; }

        [JsonProperty("f")]
        public string canal_id { get; set; }

        [JsonProperty("e")]
        public string Equipo_id { get; set; }

        [JsonProperty("c")]
        public string Cliente_id { get; set; }

        [JsonProperty("p")]
        public string ClientePDV_Code { get; set; }

        [JsonProperty("n")]
        public string TipoReporte_id { get; set; }

        [JsonProperty("t")]
        public string Categoria_id { get; set; }

        [JsonProperty("m")]
        public string Marca_id { get; set; }

        [JsonProperty("r")]
        public string FechaRegistro { get; set; }

        [JsonProperty("l")]
        public string Latitud { get; set; }

        [JsonProperty("g")]
        public string Longitud { get; set; }

        [JsonProperty("d")]
        public string OrigenCoordenada { get; set; }

        //solo se aplica para San Fernando - AAVV 13/01/2012
        [JsonIgnore()]
        public string TipoReporteFotografico_id { get; set; }
        
        //solo se aplica para San Fernando - AAVV 13/01/2012
        [JsonIgnore()]
        public string TipoProceso_id { get; set; }

        [JsonProperty("y")]
        public string Comentario { get; set; }

        [JsonIgnore()]
        public string NombreFoto { get; set; }

        /// <summary>
        /// El String que contiene la foto codificada se divide en 6 partes para que el envio sea de forma correcta
        /// Joseph Gonzales
        /// 15/01/2012
        /// </summary>
        [JsonProperty("z")]
        public List<E_Foto_Auditoria> listFotos { get; set; }
    }

    public class E_Foto_Auditoria
    {
        [JsonProperty("f")]
        public string foto { get; set; }
    }
}
