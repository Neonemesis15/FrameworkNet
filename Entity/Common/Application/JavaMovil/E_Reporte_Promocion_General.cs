using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Promocion_General
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
        private string id_ptoventa;
        [JsonProperty("e")]
        public string Id_ptoventa
        {
            get { return id_ptoventa; }
            set { id_ptoventa = value; }
        }
        private string id_categoria;
        [JsonProperty("f")]
        public string Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        private string id_marca;
        [JsonProperty("g")]
        public string Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }
        private string id_company_promo;
        [JsonProperty("h")]
        public string Id_company_promo
        {
            get { return id_company_promo; }
            set { id_company_promo = value; }
        }
        private string id_promocion;
        [JsonProperty("i")]
        public string Id_promocion
        {
            get { return id_promocion; }
            set { id_promocion = value; }
        }
        private string descripcion_promocion;
        [JsonProperty("j")]
        public string Descripcion_promocion
        {
            get { return descripcion_promocion; }
            set { descripcion_promocion = value; }
        }
        private string mecanica;
        [JsonProperty("k")]
        public string Mecanica
        {
            get { return mecanica; }
            set { mecanica = value; }
        }
        private string cod_producto;
        [JsonProperty("l")]
        public string Cod_producto
        {
            get { return cod_producto; }
            set { cod_producto = value; }
        }
        private string fec_ini_promocion;
        [JsonProperty("m")]
        public string Fec_ini_promocion
        {
            get { return fec_ini_promocion; }
            set { fec_ini_promocion = value; }
        }
        private string fec_fin_promocion;
        [JsonProperty("n")]
        public string Fec_fin_promocion
        {
            get { return fec_fin_promocion; }
            set { fec_fin_promocion = value; }
        }
        private string precio_promocion;
        [JsonProperty("o")]
        public string Precio_promocion
        {
            get { return precio_promocion; }
            set { precio_promocion = value; }
        }
        private string precio_regular;
        [JsonProperty("p")]
        public string Precio_regular
        {
            get { return precio_regular; }
            set { precio_regular = value; }
        }
        private string fechaRegistro;
        [JsonProperty("q")]
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }
        private string latitud;
        [JsonProperty("r")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        private string longitud;
        [JsonProperty("s")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        private string origen;
        [JsonProperty("t")]
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        private string tipo_canal;
        [JsonProperty("u")]
        public string Tipo_canal
        {
            get { return tipo_canal; }
            set { tipo_canal = value; }
        }
        private string comentario;
        [JsonProperty("v")]
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        private string foto;
         [JsonProperty("w")]
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}
