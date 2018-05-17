using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Persona
    {
        [JsonProperty("a")]
        public int Person_id { get; set; }
        [JsonProperty("b")]
        public string Id_type_Document { get; set; }
        [JsonProperty("c")]
        public string Person_nd { get; set; }
        [JsonProperty("d")]
        public string Person_Firtsname { get; set; }
        [JsonProperty("e")]
        public string Person_LastName { get; set; }
        [JsonProperty("f")]
        public string Person_Surname { get; set; }
        [JsonProperty("g")]
        public string Person_SeconName { get; set; }
        [JsonProperty("h")]
        public string Person_NameComplet { get; set; }
        [JsonProperty("i")]
        public string Person_Email { get; set; }
        [JsonProperty("j")]
        public string Person_Phone { get; set; }
        [JsonProperty("k")]
        public string Person_Addres { get; set; }
        [JsonProperty("l")]
        public string Cod_Country { get; set; }
        [JsonProperty("m")]
        public string Cod_dpto { get; set; }
        [JsonProperty("n")]
        public string Cod_city { get; set; }
        [JsonProperty("o")]
        public string Name_user { get; set; }
        [JsonProperty("p")]
        public string User_Password { get; set; }
        [JsonProperty("q")]
        public string Perfil_id { get; set; }
        [JsonProperty("r")]
        public string Name_Perfil { get; set; }
        [JsonProperty("s")]
        public string Modulo_id { get; set; }
        [JsonProperty("t")]
        public string User_Recall { get; set; }
        [JsonProperty("u")]
        public string Company_id { get; set; }
        [JsonProperty("v")]
        public string companyName { get; set; }
        [JsonProperty("w")]
        public string fotocompany { get; set; }
        [JsonProperty("x")]
        public bool Person_Status { get; set; }
        [JsonIgnore()]
        public string Person_CreateBy { get; set; }
        [JsonIgnore()]
        public string Person_DateBy { get; set; }
        [JsonIgnore()]
        public string Person_ModiBy { get; set; }
        [JsonIgnore()]
        public string Person_DateModiBy { get; set; }
    }
}
