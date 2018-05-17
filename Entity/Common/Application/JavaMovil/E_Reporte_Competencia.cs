using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Competencia
    {
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

        private string id_tipo_Promocion;
        [JsonProperty("h")]
        public string Id_tipo_Promocion
        {
            get { return id_tipo_Promocion; }
            set { id_tipo_Promocion = value; }
        }

        private string id_Tipo_Actividad;
        [JsonProperty("i")]
        public string Id_Tipo_Actividad
        {
            get { return id_Tipo_Actividad; }
            set { id_Tipo_Actividad = value; }
        }

        private string id_Grupo_Objetivo;
        [JsonProperty("j")]
        public string Id_Grupo_Objetivo
        {
            get { return id_Grupo_Objetivo; }
            set { id_Grupo_Objetivo = value; }
        }

        private string precio_Costo;
        [JsonProperty("k")]
        public string Precio_Costo
        {
            get { return precio_Costo; }
            set { precio_Costo = value; }
        }
        private string precio_Pvp;
        [JsonProperty("l")]
        public string Precio_Pvp
        {
            get { return precio_Pvp; }
            set { precio_Pvp = value; }
        }
        private string fec_ini_Act;
        [JsonProperty("m")]
        public string Fec_ini_Act
        {
            get { return fec_ini_Act; }
            set { fec_ini_Act = value; }
        }
        private string fec_fin_Act;
        [JsonProperty("n")]
        public string Fec_fin_Act
        {
            get { return fec_fin_Act; }
            set { fec_fin_Act = value; }
        }
        private string txt_Grupo_Objetivo;
        [JsonProperty("o")]
        public string Txt_Grupo_Objetivo
        {
            get { return txt_Grupo_Objetivo; }
            set { txt_Grupo_Objetivo = value; }
        }

        private string cant_Personal;
        [JsonProperty("p")]
        public string Cant_Personal
        {
            get { return cant_Personal; }
            set { cant_Personal = value; }
        }
        private string premio;
        [JsonProperty("q")]
        public string Premio
        {
            get { return premio; }
            set { premio = value; }
        }
        private string mecanica;
        [JsonProperty("r")]
        public string Mecanica
        {
            get { return mecanica; }
            set { mecanica = value; }
        }
        private string mat_Apoyo;
        [JsonProperty("s")]
        public string Mat_Apoyo
        {
            get { return mat_Apoyo; }
            set { mat_Apoyo = value; }
        }
        private string observaciones;
        [JsonProperty("t")]
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        private string fechaRegistro;
        [JsonProperty("u")]
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }
        private string latitud;
        [JsonProperty("v")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        private string longitud;
        [JsonProperty("w")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        private string origenCoordenada;
        [JsonProperty("x")]
        public string OrigenCoordenada
        {
            get { return origenCoordenada; }
            set { origenCoordenada = value; }
        }

        private string fec_Comunicacion;
        [JsonProperty("y")]
        public string Fec_Comunicacion
        {
            get { return fec_Comunicacion; }
            set { fec_Comunicacion = value; }
        }
        private string id_empresa;
        [JsonProperty("z")]
        public string Id_empresa
        {
            get { return id_empresa; }
            set { id_empresa = value; }
        }
        private string precio_regular;
        [JsonProperty("aa")]
        public string Precio_regular
        {
            get { return precio_regular; }
            set { precio_regular = value; }
        }
        private string precio_oferta;
        [JsonProperty("ab")]
        public string Precio_oferta
        {
            get { return precio_oferta; }
            set { precio_oferta = value; }
        }
        private string programa;
        [JsonProperty("ac")]
        public string Programa
        {
            get { return programa; }
            set { programa = value; }
        }
        private string descripcion_actividad;
        [JsonProperty("ad")]
        public string Descripcion_actividad
        {
            get { return descripcion_actividad; }
            set { descripcion_actividad = value; }
        }
        private string id_material;
        [JsonProperty("ae")]
        public string Id_material
        {
            get { return id_material; }
            set { id_material = value; }
        }
        private string des_material;
        [JsonProperty("af")]
        public string Des_material
        {
            get { return des_material; }
            set { des_material = value; }
        }
        private string tasa_interes;
        [JsonProperty("ag")]
        public string Tasa_interes
        {
            get { return tasa_interes; }
            set { tasa_interes = value; }
        }
        private string banco;
        [JsonProperty("ah")]
        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        private string proporcion_materia;
        [JsonProperty("ai")]
        public string Proporcion_materia
        {
            get { return proporcion_materia; }
            set { proporcion_materia = value; }
        }
        private string proporcion_efectiva;
        [JsonProperty("aj")]
        public string Proporcion_efectiva
        {
            get { return proporcion_efectiva; }
            set { proporcion_efectiva = value; }
        }
        private string tipo_competencia;
        [JsonProperty("ak")]
        public string Tipo_competencia
        {
            get { return tipo_competencia; }
            set { tipo_competencia = value; }
        }

        private List<E_Reporte_Competencia_Detalle> competenciaDetalle;
        [JsonProperty("al")]
        public List<E_Reporte_Competencia_Detalle> CompetenciaDetalle
        {
            get { return competenciaDetalle; }
            set { competenciaDetalle = value; }
        }
        
        /// <summary>
        /// Descripcion : Campo Adicionado Solo para registrar Desde Página Web.
        /// Fecha       : 31/05/2012
        /// </summary>
        [JsonProperty("am")]
        public string Foto { get; set; }

        [JsonProperty("an")]
        public string Comentario_Foto { get; set; }

        public E_Reporte_Competencia() {
            CompetenciaDetalle = new List<E_Reporte_Competencia_Detalle>();
        }
    }
}
