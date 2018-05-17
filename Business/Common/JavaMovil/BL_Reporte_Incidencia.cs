using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Incidencia
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Incidencia));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Incidencia oD_Reporte_Incidencia = new D_Reporte_Incidencia();

        String error = string.Empty;
        public string Registrar_Incidencia_Mov(List<E_Reporte_Incidencia_Mov> ListaReporteIncidencia, string appEnvia)
        {
            try
            {
                error = oD_Reporte_Incidencia.Registrar_Incidencia_Mov(ListaReporteIncidencia, appEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Reporte_Incidencia] [RegistrarIncidenciaFailed] :", ex);
            }
            return error;
        }
    }
}
