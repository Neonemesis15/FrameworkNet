using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Observacion
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Observacion));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Observacion oD_Reporte_Observacion = new D_Reporte_Observacion();

        String error = string.Empty;
        public string Registrar_Observacion_Mov(List<E_Reporte_Observacion_Mov> ListaReporteMarcaje, int appEnvia)
        {
            try
            {
                error = oD_Reporte_Observacion.Registrar_Observacion_Mov(ListaReporteMarcaje, appEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Reporte_Observacion] [Registrar_Observacion_Mov_Failed] :", ex);
            }
            return error;
        }
    }
}
