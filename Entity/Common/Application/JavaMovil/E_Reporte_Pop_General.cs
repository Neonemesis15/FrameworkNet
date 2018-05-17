using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Pop_General
    {
        private string person_id;
        [JsonProperty("a")]
        public string Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }
        private string id_perfil;
        [JsonProperty("b")]
        public string Id_perfil
        {
            get { return id_perfil; }
            set { id_perfil = value; }
        }
        private string id_equipo;
        [JsonProperty("c")]
        public string Id_equipo
        {
            get { return id_equipo; }
            set { id_equipo = value; }
        }
        private string id_cliente;
        [JsonProperty("d")]
        public string Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        private string id_categoria;
        [JsonProperty("e")]
        public string Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        private string tipo_canal;
        [JsonProperty("f")]
        public string Tipo_canal
        {
            get { return tipo_canal; }
            set { tipo_canal = value; }
        }
        private string id_ptoVenta;
        [JsonProperty("g")]
        public string Id_ptoVenta
        {
            get { return id_ptoVenta; }
            set { id_ptoVenta = value; }
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
        private string origen;
        [JsonProperty("k")]
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        private string comentario;
        [JsonProperty("l")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        private List<E_Reporte_Pop_General_Detalle> detallePop;


        [JsonProperty("m")]
        public List<E_Reporte_Pop_General_Detalle> DetallePop
        {
            get { return detallePop; }
            set { detallePop = value; }
        }

        public E_Reporte_Pop_General() {
            DetallePop = new List<E_Reporte_Pop_General_Detalle>();
        }

    }
}
