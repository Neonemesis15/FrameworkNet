using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Lucky.Entity.Common.Servicio
{
    public class E_Reporte
    {
        [JsonProperty("a")]
        public int Report_Id { get; set; }
        [JsonIgnore()]
        public int Order_report { get; set; }
        [JsonProperty("b")]
        public string Report_NameReport { get; set; }
        [JsonIgnore()]
        public string Report_Description { get; set; }
        [JsonIgnore()]
        public string Moduloid { get; set; }
        [JsonIgnore()]
        public int IdTypeReport { get; set; }
        [JsonIgnore()]
        public int Idindicador { get; set; }
        [JsonIgnore()]
        public bool Report_Status { get; set; }
        [JsonIgnore()]
        public string Report_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime Report_DateBy { get; set; }
        [JsonIgnore()]
        public string Report_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime Report_DateModiBy { get; set; }
        [JsonIgnore()]
        public int Id_ReportModulo { get; set; }
        [JsonIgnore()]
        public string Modulo_id { get; set; }
        [JsonIgnore()]
        public bool ReportModulo_Status { get; set; }
        [JsonIgnore()]
        public string ReportModulo_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime ReportModulo_DateBy { get; set; }
        [JsonIgnore()]
        public string ReportModulo_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime ReportModulo_DateModiBy { get; set; }
        [JsonIgnore()]
        public int Id_ReportTypeReport { get; set; }
        [JsonIgnore()]
        public int Id_TypeReport { get; set; }
        [JsonIgnore()]
        public bool ReportTypeReport_Status { get; set; }
        [JsonIgnore()]
        public string ReportTypeReport_CreateBy { get; set; }
        [JsonIgnore()]
        public DateTime ReportTypeReport_DateBy { get; set; }
        [JsonIgnore()]
        public string ReportTypeReport_ModiBy { get; set; }
        [JsonIgnore()]
        public DateTime ReportTypeReport_DateModiBy { get; set; }
        

    }
}
