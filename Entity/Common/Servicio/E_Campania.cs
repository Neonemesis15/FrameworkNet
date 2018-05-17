using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_Campania
    {
        [JsonProperty("a")]
        public string Id_planning{get;set;}
        [JsonProperty("b")]
        public string Planning_Name { get; set; }
        [JsonIgnore()]
        public int Cod_Strategy { get; set; }
        [JsonIgnore()]
        public string Planning_CodChannel { get; set; }
        [JsonIgnore()]
        public DateTime Planning_StartActivity { get; set; }
        [JsonIgnore()]
        public DateTime Planning_EndActivity { get; set; }
        [JsonIgnore()]
        public string Planning_ReportAditional { get; set; }
        [JsonIgnore()]
        public string Planning_DevelopmentActivityReport { get; set; }
        [JsonIgnore()]
        public int Planning_Person_Eje { get; set; }
        [JsonIgnore()]
        public string Planning_ActivityFormats { get; set; }
        [JsonIgnore()]
        public string Planning_AreaInvolved { get; set; }
        [JsonIgnore()]
        public DateTime Planning_DateRepSoli { get; set; }
        [JsonIgnore()]
        public DateTime Planning_PreproduDateini { get; set; }
        [JsonIgnore()]
        public DateTime Planning_PreproduDateEnd { get; set; }
        [JsonIgnore()]
        public string Planning_ProjectDuration { get; set; }
        [JsonIgnore()]
        public DateTime Planning_DateFinreport { get; set; }
        [JsonIgnore()]
        public string Planning_Vigen { get; set; }
        [JsonIgnore()]
        public string Planning_Budget { get; set; }
        [JsonIgnore()]
        public int Id_designFor { get; set; }
        [JsonIgnore()]
        public string Name_Contact { get; set; }
        [JsonIgnore()]
        public string Email_Contac { get; set; }
        [JsonIgnore()]
        public bool Planning_Status { get; set; }
        [JsonIgnore()]
        public int Status_id { get; set; }
        [JsonIgnore()]
        public bool Planning_FormaCompe { get; set; }
        [JsonIgnore()]
        public string Planning_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime Planning_DateBy { get; set; }
        [JsonIgnore()]
        public string Planning_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime Planning_DateModiBy { get; set; }

    }
}
