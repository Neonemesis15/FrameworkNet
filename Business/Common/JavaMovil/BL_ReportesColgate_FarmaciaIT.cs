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
    public class BL_ReportesColgate_FarmaciaIT
    {
        public BL_ReportesColgate_FarmaciaIT() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_May));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;

        #region AppMovil Lucky
        public string registrarReportesColgate_FarmaciaIT(
            List<E_Reporte_Presencia_General> oList_E_ReportePresencia, 
            List<E_Reporte_Fotografico_General> oList_E_ReporteFotografico,
            List<E_Reporte_Codigo_ITT> oList_E_ReporteCodigoITT,
            E_Visita oE_Visita)
        {
    
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Visita oD_Visita = new D_Visita();
            string mensaje = "";
            try
            {
                mensaje =  oD_Reporte_Presencia.Registrar_Presencia_General_Lista(oList_E_ReportePresencia);
                oD_Reporte_Fotografico.RegistrarReporteFotografico(oList_E_ReporteFotografico);
                oD_Reporte_Codigo_ITT.Registrar_Presencia_Codigo_ITT(oList_E_ReporteCodigoITT);
                oD_Visita.RegistrarVisita(oE_Visita);//Add 12/03/2012

                return mensaje;
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReportesColgateFarmaciaIT] [Registrar_ReportesColgateFarmaciaIT_Failed] :", ex);
                mensaje = "Se ha producido un Error, Consultar con el Equipo de TI.";
                return mensaje;
            }
        }
        #endregion

        #region AppMovil Movistar
        /// <summary>
        /// Descripcion : Reportes de Colgate Farmacia IT para App Movistar
        /// Fecha       : 21/05/2012 - PSA
        /// Actualizacion   : 28/08/2012
        /// Descripcion     : Se agregan las nuevas validaciones del RQ Colgate v 1.9
        /// Author          : Pablo Salas A.
        /// </summary>
        /// <param name="oList_E_ReportePresencia_Mov"></param>
        /// <param name="oList_E_ReporteFotografico_Mov"></param>
        /// <param name="oList_E_ReporteCodigoITT_Mov"></param>
        /// <param name="oE_Visita_Mov"></param>
        /// <param name="App_Envia"></param>
        public E_Reportes_Colgate_Farmacia_IT_Mov_Response Registrar_Reportes_Colgate_Farmacia_IT_Mov_V_1_1(
            List<E_Reporte_Presencia_Mov> oList_E_ReportePresencia_Mov,
            List<E_Reporte_Fotografico_Mov> oList_E_ReporteFotografico_Mov,
            List<E_Reporte_Codigo_ITT_Mov> oList_E_ReporteCodigoITT_Mov,
            E_Visita_Mov oE_Visita_Mov,
            int App_Envia)
        {

            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Visita oD_Visita = new D_Visita();

            string mensaje_Presencia = string.Empty;
            string mensaje_Fotografico = string.Empty;
            //string mensaje_Codigo_ITT = string.Empty;
            string mensaje_Visita = string.Empty;
            //string mensaje_Final = string.Empty;

            E_Reportes_Colgate_Farmacia_IT_Mov_Response oE_Reportes_Colgate_Farmacia_IT_Mov_Response = new E_Reportes_Colgate_Farmacia_IT_Mov_Response();
            E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
            try
            {
                oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oList_E_ReportePresencia_Mov, App_Envia);//Add 28/08/2012 Nuevas Validaciones PSalas
                //mensaje_Presencia+=oD_Reporte_Presencia.Registrar_Presencia_Mov(oList_E_ReportePresencia_Mov, App_Envia);//Disabled 28/08/2012 Antiguas Validaciones
                mensaje_Presencia = oE_Reporte_Presencia_Datos_Response.MensajeUsuario;
                mensaje_Fotografico+=oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oList_E_ReporteFotografico_Mov, App_Envia);
                //mensaje_Codigo_ITT+=oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_ReporteCodigoITT_Mov);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_ReporteCodigoITT_Mov); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                mensaje_Visita += oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);

                if (!mensaje_Presencia.Equals(""))
                    mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Alerta Rep. Fotografico" + Environment.NewLine + mensaje_Fotografico + Environment.NewLine;
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita;

                //oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_ReporteCodigoITT_Mov);
                oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Mensaje_Response = mensaje_Presencia + mensaje_Fotografico + mensaje_Visita;

            }
            catch (Exception ex)
            {
                log.Error("[BL_Registrar_Reportes_Colgate_Farmacia_IT_Mov] [Registrar_Reportes_Colgate_Farmacia_IT_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception(); 
            }
            return oE_Reportes_Colgate_Farmacia_IT_Mov_Response;
        }

        //Registrar_Reportes_Colgate_Farmacia_IT_Mov V_1_0
        //Backup : 28/08/2012
        //Author : Pablo Salas A.
        public E_Reportes_Colgate_Farmacia_IT_Mov_Response Registrar_Reportes_Colgate_Farmacia_IT_Mov(
    List<E_Reporte_Presencia_Mov> oList_E_ReportePresencia_Mov,
    List<E_Reporte_Fotografico_Mov> oList_E_ReporteFotografico_Mov,
    List<E_Reporte_Codigo_ITT_Mov> oList_E_ReporteCodigoITT_Mov,
    E_Visita_Mov oE_Visita_Mov,
    int App_Envia)
        {

            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Visita oD_Visita = new D_Visita();

            string mensaje_Presencia = string.Empty;
            string mensaje_Fotografico = string.Empty;
            //string mensaje_Codigo_ITT = string.Empty;
            string mensaje_Visita = string.Empty;
            //string mensaje_Final = string.Empty;

            E_Reportes_Colgate_Farmacia_IT_Mov_Response oE_Reportes_Colgate_Farmacia_IT_Mov_Response = new E_Reportes_Colgate_Farmacia_IT_Mov_Response();

            try
            {
                mensaje_Presencia += oD_Reporte_Presencia.Registrar_Presencia_Mov(oList_E_ReportePresencia_Mov, App_Envia);//Disabled 28/08/2012 Antiguas Validaciones
                //mensaje_Presencia += oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oList_E_ReportePresencia_Mov, App_Envia);//Add 28/08/2012 Nuevas Validaciones PSalas
                mensaje_Fotografico += oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oList_E_ReporteFotografico_Mov, App_Envia);
                //mensaje_Codigo_ITT+=oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_ReporteCodigoITT_Mov);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_ReporteCodigoITT_Mov); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                mensaje_Visita += oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);

                if (!mensaje_Presencia.Equals(""))
                    mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Alerta Rep. Fotografico" + Environment.NewLine + mensaje_Fotografico + Environment.NewLine;
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita;

                //oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_ReporteCodigoITT_Mov);
                oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Mensaje_Response = mensaje_Presencia + mensaje_Fotografico + mensaje_Visita;

            }
            catch (Exception ex)
            {
                log.Error("[BL_Registrar_Reportes_Colgate_Farmacia_IT_Mov] [Registrar_Reportes_Colgate_Farmacia_IT_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return oE_Reportes_Colgate_Farmacia_IT_Mov_Response;
        }
        #endregion
    }
}
