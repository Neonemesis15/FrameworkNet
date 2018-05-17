using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Entity para generar atributos Json del Reporte Visibilidad Competencia
    /// Creado Por: Ing. Carlos Alberto Hernandez
    /// Fecha:06/03/2012
    /// Cliente: Colgate
    /// </summary>
    public class E_Reporte_Visibilidad_Competencia
    {
        public E_Reporte_Visibilidad_Competencia()
        {
            VisibilidadDetalle = new List<E_Reporte_Visibilidad_Competencia_Detalle>();
        }

        private string person_id;
        private string perfil_id;
        private string equipo_id;
        private string cliente_id;
        private string clientePDV_Code;
        private string categoria_id;
        private string marca_id;


        private string latitud;
        private string longitud;
        private string origenCoordenada;
        private string tipoCanal;
        private string comentario;
        private string id_empresacomeptidora;
                
        [JsonProperty("i")]
        public string Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }


        [JsonProperty("j")]
        public string Perfil_id
        {
            get { return perfil_id; }
            set { perfil_id = value; }
        }

        [JsonProperty("k")]
        public string Equipo_id
        {
            get { return equipo_id; }
            set { equipo_id = value; }
        }

        [JsonProperty("l")]
        public string Cliente_id
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        [JsonProperty("m")]
        public string ClientePDV_Code
        {
            get { return clientePDV_Code; }
            set { clientePDV_Code = value; }
        }
        [JsonProperty("n")]
        public string Categoria_id
        {
            get { return categoria_id; }
            set { categoria_id = value; }
        }

        [JsonProperty("o")]
        public string Marca_id
        {
            get { return marca_id; }
            set { marca_id = value; }
        }
        private string fechaRegistro;
        [JsonProperty("q")]
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }
        [JsonProperty("r")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        [JsonProperty("t")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        [JsonProperty("w")]
        public string OrigenCoordenada
        {
            get { return origenCoordenada; }
            set { origenCoordenada = value; }
        }
        [JsonProperty("x")]
        public string TipoCanal
        {
            get { return tipoCanal; }
            set { tipoCanal = value; }
        }
        [JsonProperty("y")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        [JsonProperty("z")]
        public string Id_empresacomeptidora
        {
            get { return id_empresacomeptidora; }
            set { id_empresacomeptidora = value; }
        }

        [JsonProperty("s")]
        public List<E_Reporte_Visibilidad_Competencia_Detalle> VisibilidadDetalle
        {
            get;
            set;
        }
    }
}
