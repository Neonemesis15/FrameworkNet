using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;
using Lucky.Business.Common.Exceptions;
using log4net;


namespace Lucky.Business.Common.JavaMovil
{
    public class BL_ReportesAlicorp_May
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesAlicorp_May));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;

        #region Warning - Registrar_Reportes_Alicorp_May_Mov - Pendiente Verificar Duplicados.
        public string Registrar_Reportes_Alicorp_May_Mov(
            List<E_Reporte_Precio_Mov> oListE_Reporte_Precio_Mov, 
            List<E_Reporte_SOD_Mov> oListE_Reporte_SOD_Mov, 
            List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico_Mov,
            List<E_Reporte_Competencia_Mov> oListE_Reporte_Competencia_Mov,
            List<E_Reporte_Stock_Mov> oListE_Reporte_Stock_Mov, 
            E_Visita_Mov oE_Visita_Mov, 
            int AppEnvia)
        {
            string mensaje = "";
            D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
            D_Reporte_SOD oD_Reporte_SOD = new D_Reporte_SOD();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Reporte_Competencia oD_Reporte_Competencia = new D_Reporte_Competencia();
            D_Reporte_Stock oD_Reporte_Stock = new D_Reporte_Stock();
            D_Visita oD_Visita = new D_Visita();

            try
            {
               
                oD_Reporte_Precio.Registrar_Precio_Mov(oListE_Reporte_Precio_Mov, Convert.ToString(AppEnvia));
                oD_Reporte_SOD.Registrar_Reporte_SOD_Mov(oListE_Reporte_SOD_Mov, Convert.ToString(AppEnvia));
                oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico_Mov, AppEnvia);
                oD_Reporte_Competencia.Registrar_Competencia_Mov(oListE_Reporte_Competencia_Mov, Convert.ToString(AppEnvia));
                oD_Reporte_Stock.Registrar_Reporte_Stock_Mov(oListE_Reporte_Stock_Mov, Convert.ToString(AppEnvia));
                oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReportesColgateMay_Mov] [RegistrarReportesColgateMay_Mov_Failed] :", ex);
                mensaje = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return mensaje;
        }
        #endregion

    }
}
