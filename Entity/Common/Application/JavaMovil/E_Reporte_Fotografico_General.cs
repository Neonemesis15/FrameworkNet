using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Fotografico_General
    {
        [JsonProperty("a")]
        public string Person_id { get; set; }

        [JsonProperty("b")]
        public string Perfil_id { get; set; }//Modificac canal_id por perfil_id 14/03/2012 pSalas

        [JsonProperty("c")]
        public string Equipo_id { get; set; }

        [JsonProperty("d")]
        public string Cliente_id { get; set; }

        [JsonProperty("e")]
        public string ClientePDV_Code { get; set; }

        [JsonProperty("f")]
        public string TipoReporte_id { get; set; }

        [JsonProperty("g")]
        public string Categoria_id { get; set; }

        [JsonProperty("h")]
        public string Marca_id { get; set; }

        [JsonProperty("i")]
        public string FechaRegistro { get; set; }

        [JsonProperty("j")]
        public string Latitud { get; set; }

        [JsonProperty("k")]
        public string Longitud { get; set; }

        [JsonProperty("l")]
        public string OrigenCoordenada { get; set; }

        //solo se aplica para San Fernando - AAVV 13/01/2012
        [JsonIgnore()]
        public string TipoReporteFotografico_id { get; set; }

        //solo se aplica para San Fernando - AAVV 13/01/2012
        [JsonIgnore()]
        public string TipoProceso_id { get; set; }

        [JsonProperty("m")]
        public string Comentario { get; set; }

        [JsonIgnore()]
        public string NombreFoto { get; set; }

        /// <summary>
        ///
        /// Joseph Gonzales
        /// 15/01/2012
        /// </summary>
        [JsonProperty("n")]
        public List<E_Foto> listFotos { get; set; }

    }
    
    public class E_Foto
    {
        [JsonProperty("a")]
        public string foto { get; set; }
    }

}
