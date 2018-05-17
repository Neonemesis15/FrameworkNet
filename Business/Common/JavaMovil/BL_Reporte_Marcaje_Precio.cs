using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Marcaje_Precio
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Marcaje_Precio));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Marcaje_Precio oD_Reporte_Marcaje = new D_Reporte_Marcaje_Precio();

        String error = string.Empty;
        public string Registrar_Marcaje_Mov(List<E_Reporte_Marcaje_Precio_Mov> ListaReporteMarcaje, int appEnvia)
        {
            try
            {
                error = oD_Reporte_Marcaje.Registrar_Marcaje_Precio_Mov(ListaReporteMarcaje, appEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Reporte_Marcaje_Precio] [Registrar_Marcaje_Mov_Failed] :", ex);
            }
            return error;
        }
    }
}
