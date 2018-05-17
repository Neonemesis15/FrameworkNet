using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using log4net;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_LayOut
    {
        public BL_Reporte_LayOut() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Stock));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_LayOut oD_Reporte_LayOut = new D_Reporte_LayOut();
        String error = string.Empty;

        public string Registrar_Reporte_LayOut(List<E_Reporte_LayOut> listaReporte, string AppEnvia)
        {
            D_Reporte_LayOut oD_Reporte_LayOut = new D_Reporte_LayOut();
            try { error = oD_Reporte_LayOut.Registrar_Reporte_LayOut_Lista(listaReporte, AppEnvia); }
            catch (Exception ex) {
                log.Error("[BL_Registrar_LayOut][Registrar_LayOut_Failed] :", ex);
                error = error + ex.Message;
            }
            return error;
        }
    }
}
