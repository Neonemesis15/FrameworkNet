using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using log4net;
using Lucky.Data.Common.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Fotografico_Auditoria
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_May));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Fotografico_Auditoria oD_Reporte_Fotografico_Auditoria = new D_Reporte_Fotografico_Auditoria();

        public void registrarFotograficoAuditoria(E_Reporte_Fotografico_Auditoria reporteFotografico)
        {
            try
            {
                oD_Reporte_Fotografico_Auditoria.RegistrarReporteFotografico(reporteFotografico);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_RegistroPDV] [Registrar_RegistroPDV_Failed] :", ex);
            }
        }

        public void registrarFotograficoAuditoria(E_Reporte_Fotografico_Auditoria reporteFotografico, E_Visita visita)
        {
            try
            {
                oD_Reporte_Fotografico_Auditoria.RegistrarReporteFotografico(reporteFotografico, visita);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_RegistroPDV] [Registrar_RegistroPDV_Failed] :", ex);
            }
        }
    }
}
