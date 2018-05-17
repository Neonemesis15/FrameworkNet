using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Servicio;

namespace Lucky.Entity.Common.Contratos
{
    //Por: Ditmar Estrada Bernuy , 12/11/2012
    #region Obtener las Oficinas por canal,compañia y codigo de Persona
    public class OficinasPorPersona_Request
    {
        [JsonProperty("a")]
        public int CodPersona { get; set; }

        [JsonProperty("b")]
        public string CodCanal { get; set; }

        [JsonProperty("c")]
        public int CodCompania { get; set; }
    }
    public class OficinasPorPersona_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Oficina> Oficinas { get; set; }
    }
    #endregion
}
