using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Visita
    {
        private int personId;

        [JsonProperty("i")]
        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
        private String perfilId;

        [JsonProperty("p")]
        public String PerfilId
        {
            get { return perfilId; }
            set { perfilId = value; }
        }
        private String equipoId;

        [JsonProperty("e")]
        public String EquipoId
        {
            get { return equipoId; }
            set { equipoId = value; }
        }
        private String clienteId;

        [JsonProperty("c")]
        public String ClienteId
        {
            get { return clienteId; }
            set { clienteId = value; }
        }
        private String clientPDV_Code;

        [JsonProperty("v")]
        public String ClientPDV_Code
        {
            get { return clientPDV_Code; }
            set { clientPDV_Code = value; }
        }
        private String noVisitaId;

        [JsonProperty("n")]
        public String NoVisitaId
        {
            get { return noVisitaId; }
            set { noVisitaId = value; }
        }
        private String fechaIni;

        [JsonProperty("f")]
        public String FechaIni
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }
        private String latitudInicio;

        [JsonProperty("l")]
        public String LatitudInicio
        {
            get { return latitudInicio; }
            set { latitudInicio = value; }
        }
        private String longitudInicio;

        [JsonProperty("g")]
        public String LongitudInicio
        {
            get { return longitudInicio; }
            set { longitudInicio = value; }
        }
        private String origenInicio;

        [JsonProperty("o")]
        public String OrigenInicio
        {
            get { return origenInicio; }
            set { origenInicio = value; }
        }
        private String fechaFin;

        [JsonProperty("h")]
        public String FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        private String latitudFin;

        [JsonProperty("m")]
        public String LatitudFin
        {
            get { return latitudFin; }
            set { latitudFin = value; }
        }
        private String longitudFin;

        [JsonProperty("q")]
        public String LongitudFin
        {
            get { return longitudFin; }
            set { longitudFin = value; }
        }
        private String origenFin;

        [JsonProperty("r")]
        public String OrigenFin
        {
            get { return origenFin; }
            set { origenFin = value; }
        }
    }
}
