using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Servicio;

namespace Lucky.Entity.Common.Contratos
{
    public class Consulta_Reporte_Presencia_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodCanal { get; set; }

        [JsonProperty("c")]
        public string CodOficina { get; set; }

        [JsonProperty("d")]
        public string CodNodoComercial { get; set; }

        [JsonProperty("e")]
        public string CodigoPDV { get; set; }

        [JsonProperty("f")]
        public string CodCategoria { get; set; }

        [JsonProperty("g")]
        public string CodMarca { get; set; }

        [JsonProperty("h")]
        public string CodSupervisor { get; set; }

        [JsonProperty("i")]
        public string CodPersona { get; set; }

        [JsonProperty("j")]
        public string CodTipoReporte { get; set; }

        [JsonProperty("k")]
        public string f_incio { get; set; }

        [JsonProperty("l")]
        public string f_fin { get; set; }
    }
    public class Consulta_Reporte_Presencia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Consulta_Reporte_Presencia> oListConsulta_Reporte_Presencia { get; set; }
    }

    public class Consulta_Reporte_PresenciaConsolidado_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodEquipo { get; set; }

        [JsonProperty("c")]
        public string CodCanal { get; set; }

        [JsonProperty("d")]
        public string CodMercaderista { get; set; }

        [JsonProperty("e")]
        public string CodOficina { get; set; }

        [JsonProperty("f")]
        public string CodMalla { get; set; }

        [JsonProperty("g")]
        public string CodigoPDV { get; set; }

        [JsonProperty("h")]
        public string CodTipoReporte { get; set; }

        [JsonProperty("i")]
        public string f_incio { get; set; }

        [JsonProperty("j")]
        public string f_fin { get; set; }
    }
    public class Consulta_Reporte_PresenciaConsolidado_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ContentStringDataSet oE_ContentStringDataSet { get; set; }
    }

    /// <summary>
    /// Descripcion: Listar informes para el menú Consumo Masivo v2 para el perfil 0999
    /// </summary>
    public class ListarInformesCMv2_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }
        [JsonProperty("b")]
        public string codCliente { get; set; }
        [JsonProperty("c")]
        public string idagrupacion { get; set; }
        [JsonProperty("d")]
        public string idPersona { get; set; }
    }
    public class ListarInformesCMv2_Response:BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Informesv2> oListE_InformesCMv2 { get; set; }
    }

    public class InformesMKTv2_Request
    {
        [JsonProperty("a")]
        public int idCanal { get; set; }
        [JsonProperty("b")]
        public int idReporte { get; set; }
        [JsonProperty("c")]
        public int idMarca { get; set; }
        [JsonProperty("d")]
        public int idServicio { get; set; }
        [JsonProperty("e")]
        public string anio { get; set; }
    }
    public class InformesMKTv2_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Informes oE_Informes { get; set; }
    }

}
