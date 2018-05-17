using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application
{
    public class E_Filtros
    {
        #region Filtros Generales
        [JsonProperty("a")]
        public string Cod_Servicio { get; set; }
        [JsonProperty("b")]
        public string Cod_Compania { get; set; }
        [JsonProperty("c")]
        public string Cod_Canal { get; set; }
        [JsonProperty("d")]
        public string Cod_Campania { get; set; }
        [JsonProperty("e")]
        #endregion

        #region Filtros Puntos de Relevamiento
        public string Cod_NodoComercial { get; set; }
        [JsonProperty("f")]
        public string Cod_PtoVenta { get; set; }
        [JsonProperty("g")]
        #endregion

        #region Filtro Items Relevados
        public string Cod_Categoria { get; set; }
        [JsonProperty("h")]
        public string Cod_SubCategoria { get; set; }
        [JsonProperty("i")]
        public string Cod_Marca { get; set; }
        [JsonProperty("j")]
        public string Cod_SubMarca { get; set; }
        [JsonProperty("k")]
        public string Cod_Familia { get; set; }
        [JsonProperty("l")]
        public string Cod_SubFamilia { get; set; }
        [JsonProperty("m")]
        public string Cod_Producto { get; set; }
        [JsonProperty("n")]
        public string Cod_MaterialApoyo { get; set; }
        #endregion

        #region Filtros Fechas
        [JsonProperty("o")]
        public string Cod_Anio { get; set; }
        [JsonProperty("p")]
        public string Cod_Mes { get; set; }
        [JsonProperty("q")]
        public string Cod_Periodo { get; set; }
        [JsonProperty("r")]
        public string Cod_Dia { get; set; }
        #endregion

        #region Filtros Reporte
        [JsonProperty("s")]
        public string Cod_Reporte { get; set; }
        [JsonProperty("t")]
        public string Cod_SubReporte { get; set; }
        #endregion
    }
}
