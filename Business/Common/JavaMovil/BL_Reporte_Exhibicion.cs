using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using log4net;


namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Exhibicion
    {
        public BL_Reporte_Exhibicion() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Stock));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Exhibicion oD_Reporte_Exhibicion = new D_Reporte_Exhibicion();
        String error = string.Empty;

        public string Registrar_Reporte_Exhibicion(List<E_Reporte_Exhibicion> listaReporte, string AppEnvia)
        {
            D_Reporte_Exhibicion oD_Reporte_Exhibicion = new D_Reporte_Exhibicion();
            try { error = oD_Reporte_Exhibicion.Registrar_Reporte_Exhibicion_Lista(listaReporte, AppEnvia); }
            catch (Exception ex) {
                log.Error("[BL_Registrar_Exhibicion][Registrar_Exhibicion_Failed] :", ex);
                error = error + ex.Message;
            }
            return error;
        }
    }
}
