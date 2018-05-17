using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Fotografico
    {
        private string person_id;
        [JsonProperty("i")]
        public string Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }

        private string perfil_id;
        [JsonProperty("f")]
        public string Perfil_id
        {
            get { return perfil_id; }
            set { perfil_id = value; }
        }

        private string equipo_id;
        [JsonProperty("e")]
        public string Equipo_id
        {
            get { return equipo_id; }
            set { equipo_id = value; }
        }

        private string cliente_id;
        [JsonProperty("c")]
        public string Cliente_id
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        private string clientePDV_Code;
        [JsonProperty("p")]
        public string ClientePDV_Code
        {
            get { return clientePDV_Code; }
            set { clientePDV_Code = value; }
        }

        private string tipoReporte_id;
        [JsonProperty("n")]
        public string TipoReporte_id
        {
            get { return tipoReporte_id; }
            set { tipoReporte_id = value; }
        }

        private string categoria_id;
        [JsonProperty("t")]
        public string Categoria_id
        {
            get { return categoria_id; }
            set { categoria_id = value; }
        }

        private string marca_id;
        [JsonProperty("m")]
        public string Marca_id
        {
            get { return marca_id; }
            set { marca_id = value; }
        }

        private string fechaRegistro;
        [JsonProperty("r")]
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        private string latitud;
        [JsonProperty("l")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        private string longitud;
        [JsonProperty("g")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        private string origenCoordenada;
        [JsonProperty("d")]
        public string OrigenCoordenada
        {
            get { return origenCoordenada; }
            set { origenCoordenada = value; }
        }

        //solo se aplica para San Fernando - AAVV 13/01/2012
        private string tipoReporteFotografico_id;
        [JsonIgnore()]
        public string TipoReporteFotografico_id
        {
            get { return tipoReporteFotografico_id; }
            set { tipoReporteFotografico_id = value; }
        }


        //solo se aplica para San Fernando - AAVV 13/01/2012
        private string tipoProceso_id;
        [JsonIgnore()]
        public string TipoProceso_id
        {
            get { return tipoProceso_id; }
            set { tipoProceso_id = value; }
        }

        private string comentario;
        [JsonProperty("y")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        
        private string nombreFoto;
        [JsonIgnore()]
        public string NombreFoto
        {
          get { return nombreFoto; }
          set { nombreFoto = value; }
        }
                
        /// <summary>
        /// El String que contiene la foto codificada se divide en 6 partes para que el envio sea de forma correcta
        /// Joseph Gonzales
        /// 15/01/2012
        /// </summary>
        [JsonProperty("1")]
        public string Foto1 { get; set; }

        [JsonProperty("2")]
        public string Foto2 { get; set; }

        [JsonProperty("3")]
        public string Foto3 { get; set; }

        [JsonProperty("4")]
        public string Foto4 { get; set; }

        [JsonProperty("5")]
        public string Foto5 { get; set; }

        [JsonProperty("6")]
        public string Foto6 { get; set; }
        
    }
}
