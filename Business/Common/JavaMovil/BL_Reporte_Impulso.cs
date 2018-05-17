using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Impulso
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Impulso));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Impulso oD_Reporte_Impulso = new D_Reporte_Impulso();

        String error = string.Empty;
        public string Registrar_Impulso_Mov(List<E_Reporte_Impulso_Mov> ListaReporteImpulso, string appEnvia)
        {
            try
            {
                error = oD_Reporte_Impulso.Registrar_Impulso_Mov(ListaReporteImpulso, appEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Reporte_Impulso] [Registrar_Impulso_Mov_Failed] :", ex);
            }
            return error;
        }
    }
}
