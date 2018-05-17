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
    public class BL_ReportesColgate_May
    {
        public BL_ReportesColgate_May() { }

        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_May));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_ReportesColgate_May oD_ReportesColgate_May = new D_ReportesColgate_May();

        #region AppMovil Lucky
        public string registrarPresencia_May(List<E_Reporte_Presencia> oListE_Reporte_Presencia, List<E_Reporte_Fotografico> oListE_Reporte_Fotografico, List<E_Reporte_Codigo_ITT> oListE_Reporte_CodigoITT, E_Visita oE_Visita)
        {
            string mensaje = "";
            D_ReportesColgate_May oD_ReportesColgate_May = new D_ReportesColgate_May();

            try
            {
                mensaje = oD_ReportesColgate_May.RegistrarReportesColgate_Mayoristas(oListE_Reporte_Presencia, oListE_Reporte_Fotografico, oListE_Reporte_CodigoITT, oE_Visita);
               

            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Presencia] [RegistrarPresenciaFailed] :", ex);
                mensaje = "Se ha producido un Error, Consultar con el Equipo de TI.";
                
            }
            return mensaje;
        }
        #endregion 

        #region AppMovil Movistar
        /// <summary>
        /// Descripcion : Registrar Información para Colgate Mayorista App Movistar
        /// Fecha       : 18/05/2012 PSA
        /// </summary>
        /// <param name="oListE_Reporte_Presencia"></param>
        /// <param name="oListE_Reporte_Fotografico"></param>
        /// <param name="oListE_Reporte_CodigoITT"></param>
        /// <param name="oE_Visita"></param>
        /// <returns></returns>
        //public E_Reportes_Colgate_Mayoristas_Mov_Response Registrar_ReportesColgateMay_Mov(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia, List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico, List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT, E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        //{
        //    //string mensaje = "";
        //    E_Reportes_Colgate_Mayoristas_Mov_Response oE_Reportes_Colgate_Mayoristas_Mov_Response = new E_Reportes_Colgate_Mayoristas_Mov_Response();
        //    D_ReportesColgate_May oD_ReportesColgate_May = new D_ReportesColgate_May();

        //    try
        //    {
        //        oE_Reportes_Colgate_Mayoristas_Mov_Response = oD_ReportesColgate_May.Registrar_ReportesColgateMay_Mov(oListE_Reporte_Presencia, oListE_Reporte_Fotografico, oListE_Reporte_CodigoITT, oE_Visita_Mov, AppEnvia);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("[BL_Registar_ReportesColgateMay_Mov] [RegistrarReportesColgateMay_Mov_Failed] :", ex);
        //        oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
        //        throw new Exception();                
        //    }
        //    return oE_Reportes_Colgate_Mayoristas_Mov_Response;
        //}


        /// Actualizacion   : 28/08/2012
        /// Descripcion     : Se agregan las nuevas validaciones del RQ Colgate v 1.9\
        /// Author          : Pablo Salas A.
        /// 
        public E_Reportes_Colgate_Mayoristas_Mov_Response Registrar_ReportesColgateMay_Mov_V_1_1(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia, List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico, List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT, E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Visita oD_Visita = new D_Visita();

            String mensaje_Presencia = string.Empty;
            String mensaje_Fotografico = string.Empty;
            String mensaje_Visita = string.Empty;

            E_Reportes_Colgate_Mayoristas_Mov_Response oE_Reportes_Colgate_Mayoristas_Mov_Response = new E_Reportes_Colgate_Mayoristas_Mov_Response();
            E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
            try
            {
                oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oListE_Reporte_Presencia, AppEnvia);//Modificado el 28/08/2012 con las Nuevas Validaciones PSalas
                //mensaje_Presencia = oD_Reporte_Presencia.Registrar_Presencia_Mov(oListE_Reporte_Presencia, AppEnvia);//Disabled 28/08/2012 PSA Antiguas Validaciones.
                mensaje_Presencia = oE_Reporte_Presencia_Datos_Response.MensajeUsuario;//Modificado el 28/08/2012 con las Nuevas Validaciones PSalas
                mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico, AppEnvia);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                mensaje_Visita = oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);
 
                if (!mensaje_Presencia.Equals(""))
                    mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Alerta Rep. Fotografico" + Environment.NewLine + mensaje_Fotografico + Environment.NewLine;
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita + Environment.NewLine; 
     
                //oE_Reportes_Colgate_Mayoristas_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT);
                oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response = mensaje_Presencia + mensaje_Fotografico + mensaje_Visita;

            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReportesColgateMay_Mov] [RegistrarReportesColgateMay_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return oE_Reportes_Colgate_Mayoristas_Mov_Response;
        }

        ///Registrar_ReportesColgateMay_Mov_V_1_0
        ///Backup   : 28/08/2012
        ///Author   : Pablo Salas Alvarez
        public E_Reportes_Colgate_Mayoristas_Mov_Response Registrar_ReportesColgateMay_Mov(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia, List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico, List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT, E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Visita oD_Visita = new D_Visita();

            String mensaje_Presencia = string.Empty;
            String mensaje_Fotografico = string.Empty;
            String mensaje_Visita = string.Empty;

            E_Reportes_Colgate_Mayoristas_Mov_Response oE_Reportes_Colgate_Mayoristas_Mov_Response = new E_Reportes_Colgate_Mayoristas_Mov_Response();
            //E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
            try
            {
                //oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oListE_Reporte_Presencia, AppEnvia);//Modificado el 28/08/2012 con las Nuevas Validaciones PSalas
                mensaje_Presencia = oD_Reporte_Presencia.Registrar_Presencia_Mov(oListE_Reporte_Presencia, AppEnvia);//Disabled 28/08/2012 PSA Antiguas Validaciones.
                //mensaje_Presencia = oE_Reporte_Presencia_Datos_Response.MensajeUsuario;//Modificado el 28/08/2012 con las Nuevas Validaciones PSalas
                mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico, AppEnvia);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                mensaje_Visita = oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);

                if (!mensaje_Presencia.Equals(""))
                    mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Alerta Rep. Fotografico" + Environment.NewLine + mensaje_Fotografico + Environment.NewLine;
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita + Environment.NewLine;

                //oE_Reportes_Colgate_Mayoristas_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT);
                oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response = mensaje_Presencia + mensaje_Fotografico + mensaje_Visita;

            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReportesColgateMay_Mov] [RegistrarReportesColgateMay_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return oE_Reportes_Colgate_Mayoristas_Mov_Response;
        }
        #endregion
    }
}
