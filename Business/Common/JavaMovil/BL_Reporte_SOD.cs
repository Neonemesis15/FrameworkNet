using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using log4net;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_SOD
    {
        public BL_Reporte_SOD() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Stock));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_SOD oD_Reporte_SOD = new D_Reporte_SOD();
        String error = string.Empty;

        public string Registrar_Reporte_SOD(List<E_Reporte_SOD> listaReporte, string AppEnvia)
        {
            D_Reporte_SOD oD_Reporte_SOD = new D_Reporte_SOD();
            try { error = oD_Reporte_SOD.Registrar_Reporte_SOD_Lista(listaReporte, AppEnvia); }
            catch (Exception ex) {
                log.Error("[BL_Registrar_Stock][Registrar_Stock_Failed] :" , ex);
                error = error + ex.Message;
            }
            return error;
        }
    }
}
