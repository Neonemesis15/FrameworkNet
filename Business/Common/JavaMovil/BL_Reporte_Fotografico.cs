using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using log4net;
using Lucky.Data.Common.JavaMovil;
using Lucky.Business.Common.Exceptions;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Fotografico
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_May));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();

        public void registrarFotografico(E_Reporte_Fotografico_General reporteFotografico)
        {
            try
            {
                oD_Reporte_Fotografico.RegistrarReporteFotografico(reporteFotografico);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReporteFotografico] [Registrar_ReporteFotografico_Failed] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public void registrarFotografico(E_Reporte_Fotografico_General reporteFotografico, E_Visita visita)
        {
            try
            {
                oD_Reporte_Fotografico.RegistrarReporteFotografico(reporteFotografico, visita);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReporteFotografico] [Registrar_ReporteFotografico_Failed] :", ex);
                throw new Exception();     
            }
        }

        public string registrarFotografico(E_Reporte_Fotografico_General reporteFotografico, string AppEnvia)
        {
            string mensaje = string.Empty;
            try
            {
                mensaje = oD_Reporte_Fotografico.RegistrarReporteFotografico(reporteFotografico, AppEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReporteFotografico] [Registrar_ReporteFotografico_Failed] :", ex);
                mensaje = "Ocurrio un Error. Comuniquese con el Equipo de TI.";
                throw new Exception();     
            }
            return mensaje;
        }
        public string registrarFotografico(List<E_Reporte_Fotografico_General> oListReporteFotografico, string AppEnvia) {
            string mensaje = string.Empty;
            try
            {
                mensaje = oD_Reporte_Fotografico.RegistrarReporteFotografico(oListReporteFotografico, AppEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReporteFotografico] [Registrar_ReporteFotografico_Failed] :", ex);
                mensaje = "Ocurrio un Error. Comuniquese con el Equipo de TI.";
                throw new Exception();
            }
            return mensaje;
        }

        #region App Movistar
        #region Cliente - CocaCola 
        //14/11/2012 Psa
        public string RegRepFoto_Mov_Coca(List<E_Reporte_Fotografico_Mov> oLista_Reporte)
        {
            string mensaje = "";
            try
            {
                oD_Reporte_Fotografico.RegRepFoto_Mov_Coca(oLista_Reporte);
                mensaje += "Se registró ha registrado la Foto";   
            }
            catch (Exception ex)
            {
                mensaje += ex.Message;
                throw ex;
            }
            return mensaje;
        }
        #endregion

        #endregion
    }
}
