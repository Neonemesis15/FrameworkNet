using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_RegistroPDV
    {
        private string person_id;
        private string equipo_id;
        private string cliente_id;
        private string clientePDV_Code;
        private string nombre;
        private string telefono;
        private string idImplementaPDV;
        private string fechaRegistro;
        private string latitud;
        private string longitud;
        private string origenCoordenada;

        
        [JsonProperty("a")]
        public string Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }

        [JsonProperty("b")]
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

        [JsonProperty("d")]
        public string ClientePDV_Code
        {
            get { return clientePDV_Code; }
            set { clientePDV_Code = value; }
        }

        [JsonProperty("e")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [JsonProperty("f")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [JsonProperty("g")]
        public string IdImplementaPDV
        {
            get { return idImplementaPDV; }
            set { idImplementaPDV = value; }
        }

        [JsonProperty("h")]
        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        [JsonProperty("i")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        [JsonProperty("j")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        [JsonProperty("k")]
        public string OrigenCoordenada
        {
            get { return origenCoordenada; }
            set { origenCoordenada = value; }
        }

        [JsonProperty("l")]
        public List<E_Reporte_RegistroPDV_Detalle> RegistroPDV_Detalle
        {
            get;
            set;
        }

        public E_Reporte_RegistroPDV()
        {
            RegistroPDV_Detalle = new List<E_Reporte_RegistroPDV_Detalle>();
        }

        //public E_Reporte_RegistroPDV() { 
        //E_Reporte_Presencia_Detalle
        //}
    }
}
