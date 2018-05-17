using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Presencia_General
    {

        public E_Reporte_Presencia_General() {
            DetallePresencia = new List<E_Reporte_Presencia_General_Detalle>();
        
        }

        private string person_id;
        private string perfil_id;
        private string equipo_id;
        private string cliente_id;
        private string clientePDV_Code;
        private string categoria_id;
        private string marca_id;
        private string opcionReporte_id;
        private string fechaRegistro;
        private string latitud;
        private string longitud;
        private string origenCoordenada;
        private string tipoCanal;
        private string comentario;
        private List<E_Reporte_Presencia_General_Detalle> detallePresencia;


        [JsonProperty("s")]
        public List<E_Reporte_Presencia_General_Detalle> DetallePresencia
        {
            get { return detallePresencia; }
            set { detallePresencia = value; }
        }

        [JsonProperty("i")]
        public string Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }

        [JsonProperty("f")]
        public string Perfil_id
        {

            get { return perfil_id; }
            set { perfil_id = value; }
        }

        [JsonProperty("e")]
        public string Equipo_id
        {
            get { return equipo_id; }
            set { equipo_id = value; }
        }

        [JsonProperty("c")]
        public string Cliente_id
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        [JsonProperty("p")]
        public string ClientPDV_Code
        {
            get { return clientePDV_Code; }
            set { clientePDV_Code = value; }
        }

        [JsonProperty("t")]
        public string Categoria_id
        {
            get { return categoria_id; }
            set { categoria_id = value; }
        }

        [JsonProperty("m")]
        public string Marca_id
        {
            get { return marca_id; }
            set { marca_id = value; }
        }

        [JsonProperty("n")]
        public string OpcionReporte_id
        {
            get { return opcionReporte_id; }
            set { opcionReporte_id = value; }
        }

        [JsonProperty("r")]
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        [JsonProperty("l")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        [JsonProperty("g")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        [JsonProperty("d")]
        public string OrigenCoordenada
        {
            get { return origenCoordenada; }
            set { origenCoordenada = value; }
        }

        [JsonProperty("b")]
        public string TipoCanal
        {
            get { return tipoCanal; }
            set { tipoCanal = value; }
        }

        [JsonProperty("o")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        [JsonIgnore()]
        public int Id_reg_presencia
        {
            get;
            set;
        }

    }
}
