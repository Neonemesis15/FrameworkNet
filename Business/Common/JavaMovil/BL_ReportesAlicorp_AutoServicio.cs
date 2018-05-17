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
    public class BL_ReportesAlicorp_AutoServicio
    {
        public BL_ReportesAlicorp_AutoServicio() { }

        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesAlicorp_AutoServicio));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;

        #region AppMovil Movistar
        public string Registrar_Reportes_Alicorp_Autoservicio(
            List<E_Reporte_Precio_Mov> oListE_Reporte_Precio_Mov,
            List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico_Mov,
            List<E_Reporte_Competencia_Mov> oListE_Reporte_Competencia_Mov,
            List<E_Reporte_Exhibicion_Mov> oListE_Reporte_Exhibicion_Mov,
            List<E_Reporte_Quiebre_Mov> oListE_Reporte_Quiebre_Mov,
            List<E_Reporte_LayOut_Mov> oListE_Reporte_LayOut_Mov,
            E_Visita_Mov oE_Visita_Mov,
            int AppEnvia)
        {
            string mensaje_Final = string.Empty;
            try
            {
                D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
                D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
                D_Reporte_Competencia oD_Reporte_Competencia = new D_Reporte_Competencia();
                D_Reporte_Exhibicion oD_Reporte_Exhibicion = new D_Reporte_Exhibicion();
                D_Reporte_Quiebre oD_Reporte_Quiebre = new D_Reporte_Quiebre();
                D_Reporte_LayOut oD_Reporte_LayOut = new D_Reporte_LayOut();
                D_Visita oD_Visita = new D_Visita();

                oD_Reporte_Precio.Registrar_Precio_Mov(oListE_Reporte_Precio_Mov, Convert.ToString(AppEnvia));
                oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico_Mov, AppEnvia);
                oD_Reporte_Competencia.Registrar_Competencia_Mov(oListE_Reporte_Competencia_Mov, Convert.ToString(AppEnvia));
                oD_Reporte_Exhibicion.Registrar_Reporte_Exhibicion_Mov(oListE_Reporte_Exhibicion_Mov, Convert.ToString(AppEnvia));
                oD_Reporte_Quiebre.Registrar_Reporte_Quiebre_Mov(oListE_Reporte_Quiebre_Mov, Convert.ToString(AppEnvia));
                oD_Reporte_LayOut.Registrar_Reporte_LayOut_Mov(oListE_Reporte_LayOut_Mov, Convert.ToString(AppEnvia));
                oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);
                mensaje_Final = "";
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registrar_Reportes_Alicorp_Autoservicio_Mov] [Registrar_Reportes_Alicorp_Autoservicio_Failed] :", ex);
                mensaje_Final = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception(); 
            }
            return mensaje_Final;
        }
        #endregion

    }
}
