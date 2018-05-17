using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using log4net;
namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Quiebre
    {
        public BL_Reporte_Quiebre() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Stock));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Quiebre oD_Reporte_Quiebre = new D_Reporte_Quiebre();
        String error = string.Empty;

        public string Registrar_Reporte_Quiebre(List<E_Reporte_Quiebre> listaReporte, string AppEnvia)
        {
            D_Reporte_Quiebre oD_Reporte_Quiebre = new D_Reporte_Quiebre();
            try { error = oD_Reporte_Quiebre.Registrar_Reporte_Quiebre_Lista(listaReporte, AppEnvia); }
            catch (Exception ex) {
                log.Error("[BL_Registrar_Quiebre][Registrar_Quiebre_Failed] :", ex);
                error = error + ex.Message;
            }
            return error;
        }
    }
}
