using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Visibilidad
    {

        public E_Reporte_Visibilidad() {
            VisibilidadDetalle = new List<E_Reporte_Visibilidad_Detalle>();
        }

        private string person_id;
        [JsonProperty("a")]
        public string Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }
        private string perfil_id;
        [JsonProperty("b")]
        public string Perfil_id
        {
            get { return perfil_id; }
            set { perfil_id = value; }
        }
        private string equipo_id;
        [JsonProperty("c")]
        public string Equipo_id
        {
            get { return equipo_id; }
            set { equipo_id = value; }
        }
        private string cliente_id;
        [JsonProperty("d")]
        public string Cliente_id
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }
        private string clientePDV_Code;
        [JsonProperty("e")]
        public string ClientePDV_Code
        {
            get { return clientePDV_Code; }
            set { clientePDV_Code = value; }
        }
        private string categoria_id;
        [JsonProperty("f")]
        public string Categoria_id
        {
            get { return categoria_id; }
            set { categoria_id = value; }
        }
        private string marca_id;
        [JsonProperty("g")]
        public string Marca_id
        {
            get { return marca_id; }
            set { marca_id = value; }
        }
        private string fechaRegistro;
        [JsonProperty("h")]
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }
        private string latitud;
        [JsonProperty("i")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        private string longitud;
        [JsonProperty("j")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        private string origenCoordenada;
        [JsonProperty("k")]
        public string OrigenCoordenada
        {
            get { return origenCoordenada; }
            set { origenCoordenada = value; }
        }
        private string tipoCanal;
        [JsonProperty("l")]
        public string TipoCanal
        {
            get { return tipoCanal; }
            set { tipoCanal = value; }
        }
        private string comentario;
        [JsonProperty("m")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        private List<E_Reporte_Visibilidad_Detalle> visibilidadDetalle;
[JsonProperty("n")]
public List<E_Reporte_Visibilidad_Detalle> VisibilidadDetalle
{
  get { return visibilidadDetalle; }
  set { visibilidadDetalle = value; }
}
        
        

    }
}
