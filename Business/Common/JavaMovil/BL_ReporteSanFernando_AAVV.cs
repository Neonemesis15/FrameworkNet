using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_ReporteSanFernando_AAVV
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_May));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_ReporteSanFernando_AAVV oD_ReporteSanFernando_AAVV = new D_ReporteSanFernando_AAVV();

        #region AppMovil Movistar

        public string Registrar_ReporteSanFernando_AAVV_Mov(List<E_Reporte_Stock_Mov> oListaRepStock_Mov, List<E_Reporte_Precio_Mov> oListaRepPrecio_Mov, List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov, List<E_Reporte_Incidencia_Mov> oListaRepIncidencia_Mov, E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        {
            string mensaje = "";
            try
            {
                mensaje = oD_ReporteSanFernando_AAVV.Registrar_ReporteSanFernando_AAVV_Mov(oListaRepStock_Mov, oListaRepPrecio_Mov, oListaRepFotografico_Mov, oListaRepIncidencia_Mov, oE_Visita_Mov, AppEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_ReporteSanFernando_AAVV] [Registrar_ReporteSanFernando_AAVV_Mov_Failed] :", ex);
                mensaje = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return mensaje;
        }

        #endregion
    }
}
