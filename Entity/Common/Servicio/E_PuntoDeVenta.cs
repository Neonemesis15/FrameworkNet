using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_PuntoDeVenta
    {
        [JsonIgnore()]
        public int Id_PointOfsale { get; set; }
        [JsonIgnore()]
        public string Id_typeDocument { get; set; }
        [JsonIgnore()]
        public string Pdv_RegTax { get; set; }
        [JsonIgnore()]
        public string Pdv_contact1 { get; set; }
        [JsonIgnore()]
        public string Pdv_position1 { get; set; }
        [JsonIgnore()]
        public string Pdv_contact2 { get; set; }
        [JsonIgnore()]
        public string Pdv_position2 { get; set; }
        [JsonIgnore()]
        public string Pdv_RazonSocial { get; set; }

        [JsonIgnore()]
        public string Pdv_Phone { get; set; }
        [JsonIgnore()]
        public string Pdv_Anexo { get; set; }
        [JsonIgnore()]
        public string Pdv_Fax { get; set; }
        [JsonIgnore()]
        public string Pdv_codCountry { get; set; }
        [JsonIgnore()]
        public string Pdv_codDepartment { get; set; }
        [JsonIgnore()]
        public string Pdv_codProvince { get; set; }
        [JsonIgnore()]
        public string Pdv_codDistrict { get; set; }
        [JsonIgnore()]
        public string Pdv_codCommunity { get; set; }

        [JsonIgnore()]
        public string Pdv_email { get; set; }
        [JsonIgnore()]
        public string Pdv_codChannel { get; set; }
        [JsonIgnore()]
        public int IdNodeComType { get; set; }
        [JsonIgnore()]
        public string NameNodeType { get; set; }
        [JsonIgnore()]
        public string NodeCommercial { get; set; }
        [JsonIgnore()]
        public int Id_Segment { get; set; }
        [JsonIgnore()]
        public bool Pdv_status { get; set; }
        [JsonIgnore()]
        public string Pdv_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime Pdv_DateBy { get; set; }
        [JsonIgnore()]
        public string Pdv_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime Pdv_DateModiBy { get; set; }
        [JsonIgnore()]
        public int Id_ClientPDV { get; set; }
        [JsonIgnore()]
        public int Company_id { get; set; }

        [JsonIgnore()]
        public int Id_sector { get; set; }
        [JsonIgnore()]
        public long Cod_Oficina { get; set; }
        [JsonIgnore()]
        public int Id_Dex { get; set; }
        [JsonIgnore()]
        public bool ClientPDV_Status { get; set; }
        [JsonIgnore()]
        public string ClientPDV_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime ClientPDV_DateBy { get; set; }
        [JsonIgnore()]
        public string ClientPDV_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime ClientPDV_DateModiBy { get; set; }

        //Parametros necesarios hasta el momento 15/11/2012 Psa.
        [JsonProperty("a")]
        public string ClientPDV_Code { get; set; }
        [JsonProperty("b")]
        public string Pdv_Name { get; set; }
        [JsonProperty("c")]//Add 15/11/2012 psa. Se adiciona este campo para devolver coordenadas Alicorp
        public string Latitud { get; set; }
        [JsonProperty("d")]//Add 15/11/2012 psa. Se adiciona este campo para devolver coordenadas Alicorp
        public string Longitud { get; set; }
        //[JsonIgnore()]
        [JsonProperty("e")]//Add 15/11/2012 Psa. se adiciona este campo para devolver dirección
        public string Pdv_Address { get; set; }
        [JsonProperty("f")]//Add 15/11/2012 Psa. Distrito para Alicorp
        public string Distrito { get; set; }
        [JsonProperty("g")]//Add 15/11/2012 Psa. Zona para Alicorp
        public string Zona { get; set; }
        [JsonProperty("h")]//Add 15/11/2012 Psa. Segmento para Alicorp
        public string Segmento { get; set; }
        [JsonProperty("i")]//Add 15/11/2012 Psa. Horas Atencion para Alicorp
        public string HorasAtencion { get; set; }
        [JsonProperty("j")]//Add 15/11/2012 Psa. Administrador para Alicorp
        public string Administrador { get; set; }
        [JsonProperty("k")]//Add 15/11/2012 Psa. Cumpleanos para Alicorp
        public string Cumpleanios { get; set; }
        [JsonProperty("l")]//Add 15/11/2012 Psa. UltimaVisita para Alicorp
        public string UltimaVisita { get; set; }
        [JsonProperty("m")]//Add 15/11/2012 Psa. Email - Alicorp
        public string Email { get; set; }
        [JsonProperty("n")]//Add 15/11/2012 Psa. Generador - Alicorp
        public string GIE { get; set; }
        [JsonProperty("o")]//Add 15/11/2012 Psa. Vendedor - Alicorp
        public string Vendedor { get; set; }
        [JsonProperty("p")]//Add 15/11/2012 Psa. Nro Locales - Alicorp
        public string NroLocales { get; set; }
    }
}
