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
    public class BL_ReportesColgate_Min
    {

        public BL_ReportesColgate_Min() { }

        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_Min));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;


        #region AppMovil Movistar
        /// <summary>
        /// Descripcion     : Registrar Reportes de Colgate Minorista App Movistar
        /// Fecha           : 21/05/2012 - PSA
        /// Actualizacion   : 28/08/2012
        /// Descripcion     : Se agregan las nuevas validaciones del RQ Colgate v 1.9\
        /// Author          : Pablo Salas A.
        /// </summary>
        /// <param name="oListE_Reporte_Presencia_Mov"></param>
        /// <param name="oListE_Reporte_Fotografico_Mov"></param>
        /// <param name="oListE_Reporte_CodigoITT_Mov"></param>
        /// <param name="oE_Visita_Mov"></param>
        /// <param name="AppEnvia"></param>
        public E_Reportes_Colgate_Minorista_Mov_Response Registrar_Reportes_Colgate_Min_Mov_V_1_1(
            List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov, 
            List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico_Mov, 
            List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT_Mov, 
            E_Visita_Mov oE_Visita_Mov, 
            int AppEnvia)
        {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Visita oD_Visita = new D_Visita();

            string mensaje_Presencia = string.Empty;
            string mensaje_Fotografico = string.Empty;
            string mensaje_Codigo_ITT = string.Empty;
            string mensaje_Visita = string.Empty;

            E_Reportes_Colgate_Minorista_Mov_Response oE_Reportes_Colgate_Minorista_Mov_Response = new E_Reportes_Colgate_Minorista_Mov_Response();
            E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
            try
            {
                //mensaje_Presencia += oD_Reporte_Presencia.Registrar_Presencia_Mov(oListE_Reporte_Presencia_Mov, AppEnvia);//Disabled 28/08/2012 Antiguas Validaciones.
                oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oListE_Reporte_Presencia_Mov, AppEnvia);//Modificado el 28/08/2012 con las Nuevas Validaciones PSalas
                mensaje_Presencia += oE_Reporte_Presencia_Datos_Response.MensajeUsuario;
                mensaje_Fotografico += oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico_Mov, AppEnvia);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT_Mov); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                mensaje_Visita += oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);

                if (!mensaje_Presencia.Equals(""))
                    mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Alerta Rep. Fotografico" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita + Environment.NewLine;
                
                //oE_Reportes_Colgate_Minorista_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT_Mov);
                oE_Reportes_Colgate_Minorista_Mov_Response.Mensaje_Response = mensaje_Fotografico + mensaje_Presencia + mensaje_Visita;
               
                
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registrar_Reportes_Colgate_Min_Mov] [Registrar_Reportes_Colgate_Min_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Minorista_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception(); 
            }

            return oE_Reportes_Colgate_Minorista_Mov_Response;

        }

     //Backup : Registrar_Reportes_Colgate_Min_Mov V_1_0
    public E_Reportes_Colgate_Minorista_Mov_Response Registrar_Reportes_Colgate_Min_Mov(
    List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov,
    List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico_Mov,
    List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT_Mov,
    E_Visita_Mov oE_Visita_Mov,
    int AppEnvia)
        {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Visita oD_Visita = new D_Visita();

            string mensaje_Presencia = string.Empty;
            string mensaje_Fotografico = string.Empty;
            string mensaje_Codigo_ITT = string.Empty;
            string mensaje_Visita = string.Empty;

            E_Reportes_Colgate_Minorista_Mov_Response oE_Reportes_Colgate_Minorista_Mov_Response = new E_Reportes_Colgate_Minorista_Mov_Response();

            try
            {
                mensaje_Presencia += oD_Reporte_Presencia.Registrar_Presencia_Mov(oListE_Reporte_Presencia_Mov, AppEnvia);//Disabled 28/08/2012 Antiguas Validaciones.
                //mensaje_Presencia += oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oListE_Reporte_Presencia_Mov, AppEnvia);//Modificado el 28/08/2012 con las Nuevas Validaciones PSalas
                mensaje_Fotografico += oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico_Mov, AppEnvia);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT_Mov); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                mensaje_Visita += oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);

                if (!mensaje_Presencia.Equals(""))
                    mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Alerta Rep. Fotografico" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita + Environment.NewLine;

                //oE_Reportes_Colgate_Minorista_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT_Mov);
                oE_Reportes_Colgate_Minorista_Mov_Response.Mensaje_Response = mensaje_Fotografico + mensaje_Presencia + mensaje_Visita;


            }
            catch (Exception ex)
            {
                log.Error("[BL_Registrar_Reportes_Colgate_Min_Mov] [Registrar_Reportes_Colgate_Min_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Minorista_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }

            return oE_Reportes_Colgate_Minorista_Mov_Response;

        }
        #endregion
    }
}
