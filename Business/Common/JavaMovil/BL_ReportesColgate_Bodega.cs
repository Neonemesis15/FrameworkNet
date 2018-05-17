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
    public class BL_ReportesColgate_Bodega
    {
        public BL_ReportesColgate_Bodega() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_Bodega));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();
        #region App Movil Lucky
        public void registrarRegistroPDV_Bodega(List<E_Reporte_RegistroPDV> oList_E_Reporte_RegistroPDV) {
            D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();
            try {
                oD_ReportesColgate_Bodega.RegistrarReportesColgate_Bodega(oList_E_Reporte_RegistroPDV);
            }
            catch(Exception ex) {
                log.Error("[BL_Registar_RegistroPDV] [Registrar_RegistroPDV_Failed] :", ex);
            }
        }
        #endregion
        
        #region App Movil Movistar
        /// <summary>
        /// Descripcion : Registrar Reportes de Colgate Bodega App Movistar
        /// Fecha       : 01/06/2012
        /// Autor       : Joseph Gonzales
        /// </summary>
        /// <param name="oListE_Reporte_Presencia_Mov"></param>
        /// <param name="oListE_Reporte_CodigoITT_Mov"></param>
        /// <param name="oE_Visita_Mov"></param>
        /// <param name="AppEnvia"></param>
        //public E_Reportes_Colgate_Bodega_Mov_Response Registrar_ReportesColgateBodega_Mov(
        //    List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov,
        //    List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT_Mov,
        //    E_Visita_Mov oE_Visita_Mov,
        //    int AppEnvia)
        //{
        //    //string mensaje = "";
        //    E_Reportes_Colgate_Bodega_Mov_Response oE_Reportes_Colgate_Bodega_Mov_Response = new E_Reportes_Colgate_Bodega_Mov_Response();


        //    //E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
        //    //D_ReportesColgate_May oD_ReportesColgate_May = new D_ReportesColgate_May();
        //    //D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();
        //    try
        //    {
        //        oE_Reportes_Colgate_Bodega_Mov_Response = oD_ReportesColgate_Bodega.RegistrarReportesColgate_Bodega_Mov(oListE_Reporte_Presencia_Mov, oListE_Reporte_CodigoITT_Mov, oE_Visita_Mov, AppEnvia);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("[Registrar_ReportesColgateBodega_Mov] [RegistrarReportesColgateBodega_Mov_Failed] :", ex);
        //        oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
        //        throw new Exception();
        //    }
        //    return oE_Reportes_Colgate_Bodega_Mov_Response;
        //}


        /// Version         : Registrar_ReportesColgateBodega_Mov_1_1
        /// Actualizacion   : 28/08/2012
        /// Descripcion     : Se agregan las nuevas validaciones del RQ Colgate v 1.9
        /// Author          : Pablo Salas A.
        public E_Reportes_Colgate_Bodega_Mov_Response Registrar_ReportesColgateBodega_Mov_V_1_1(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov,List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT_Mov, List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico, E_Visita_Mov oE_Visita_Mov,int AppEnvia)
        {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Visita oD_Visita = new D_Visita();

            E_Reportes_Colgate_Bodega_Mov_Response oE_Reportes_Colgate_Bodega_Mov_Response = new E_Reportes_Colgate_Bodega_Mov_Response();

            //String mensaje_Fotografico = string.Empty;
            try
            {
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT_Mov);

                E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
                //oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Bodega_Mov(oListE_Reporte_Presencia_Mov, AppEnvia); // Disabled 28/08/2012
                oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oListE_Reporte_Presencia_Mov, AppEnvia); // Add 28/08/2012 Pablo Salas A.                
                //mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico, AppEnvia);
                String Mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico, AppEnvia);
                if(!Mensaje_Fotografico.Equals(""))
                    Mensaje_Fotografico = "Alerta Rep. Fotografico " + Environment.NewLine + Mensaje_Fotografico + Environment.NewLine;

                String Mensaje_Visita = oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);
                if (!Mensaje_Visita.Equals(""))
                    Mensaje_Visita = "Alerta Visita" + Environment.NewLine + Mensaje_Visita + Environment.NewLine;

                //Response de Registro de Reportes Bodega
                //oE_Reportes_Colgate_Bodega_Mov_Response.Reporte_Codigo_ITT_Mov_Response = oE_Reporte_Codigo_ITT_Mov_Response;
                oE_Reportes_Colgate_Bodega_Mov_Response.Reporte_Presencia_Mov_Response = oE_Reporte_Presencia_Datos_Response;
                oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = oE_Reporte_Presencia_Datos_Response.MensajeUsuario + Environment.NewLine + Mensaje_Visita + Environment.NewLine + Mensaje_Fotografico + Environment.NewLine;
            }
            catch (Exception ex)
            {
                log.Error("[Registrar_ReportesColgateBodega_Mov] [RegistrarReportesColgateBodega_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return oE_Reportes_Colgate_Bodega_Mov_Response;

            ////string mensaje = "";
            //E_Reportes_Colgate_Bodega_Mov_Response oE_Reportes_Colgate_Bodega_Mov_Response = new E_Reportes_Colgate_Bodega_Mov_Response();


            ////E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
            ////D_ReportesColgate_May oD_ReportesColgate_May = new D_ReportesColgate_May();
            ////D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();
            //try
            //{
            //    oE_Reportes_Colgate_Bodega_Mov_Response = oD_ReportesColgate_Bodega.RegistrarReportesColgate_Bodega_Mov(oListE_Reporte_Presencia_Mov, oListE_Reporte_CodigoITT_Mov, oE_Visita_Mov, AppEnvia);
            //}
            //catch (Exception ex)
            //{
            //    log.Error("[Registrar_ReportesColgateBodega_Mov] [RegistrarReportesColgateBodega_Mov_Failed] :", ex);
            //    oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
            //    throw new Exception();
            //}
            //return oE_Reportes_Colgate_Bodega_Mov_Response;
        }

        //Backup:   Registrar_ReportesColgateBodega_Mov V.1.0
        //Fecha :   28/08/2012
        //Author:   Pablo Salas A.

        public E_Reportes_Colgate_Bodega_Mov_Response Registrar_ReportesColgateBodega_Mov(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov, List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT_Mov, List<E_Reporte_Fotografico_Mov> oListE_Reporte_Fotografico, E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Visita oD_Visita = new D_Visita();

            E_Reportes_Colgate_Bodega_Mov_Response oE_Reportes_Colgate_Bodega_Mov_Response = new E_Reportes_Colgate_Bodega_Mov_Response();

            //String mensaje_Fotografico = string.Empty;
            try
            {
                //E_Reporte_Codigo_ITT_Mov_Response oE_Reporte_Codigo_ITT_Mov_Response = new E_Reporte_Codigo_ITT_Mov_Response();
                //oE_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT_Mov);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListE_Reporte_CodigoITT_Mov);

                E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
                oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Bodega_Mov(oListE_Reporte_Presencia_Mov, AppEnvia);

                //mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico, AppEnvia);
                String Mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListE_Reporte_Fotografico, AppEnvia);
                if (!Mensaje_Fotografico.Equals(""))
                    Mensaje_Fotografico = "Alerta Rep. Fotografico " + Environment.NewLine + Mensaje_Fotografico + Environment.NewLine;

                String Mensaje_Visita = oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);
                if (!Mensaje_Visita.Equals(""))
                    Mensaje_Visita = "Alerta Visita" + Environment.NewLine + Mensaje_Visita + Environment.NewLine;

                //Response de Registro de Reportes Bodega
                //oE_Reportes_Colgate_Bodega_Mov_Response.Reporte_Codigo_ITT_Mov_Response = oE_Reporte_Codigo_ITT_Mov_Response;
                oE_Reportes_Colgate_Bodega_Mov_Response.Reporte_Presencia_Mov_Response = oE_Reporte_Presencia_Datos_Response;
                oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = Mensaje_Visita + Environment.NewLine + Mensaje_Fotografico + Environment.NewLine;
            }
            catch (Exception ex)
            {
                log.Error("[Registrar_ReportesColgateBodega_Mov] [RegistrarReportesColgateBodega_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return oE_Reportes_Colgate_Bodega_Mov_Response;

            ////string mensaje = "";
            //E_Reportes_Colgate_Bodega_Mov_Response oE_Reportes_Colgate_Bodega_Mov_Response = new E_Reportes_Colgate_Bodega_Mov_Response();


            ////E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
            ////D_ReportesColgate_May oD_ReportesColgate_May = new D_ReportesColgate_May();
            ////D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();
            //try
            //{
            //    oE_Reportes_Colgate_Bodega_Mov_Response = oD_ReportesColgate_Bodega.RegistrarReportesColgate_Bodega_Mov(oListE_Reporte_Presencia_Mov, oListE_Reporte_CodigoITT_Mov, oE_Visita_Mov, AppEnvia);
            //}
            //catch (Exception ex)
            //{
            //    log.Error("[Registrar_ReportesColgateBodega_Mov] [RegistrarReportesColgateBodega_Mov_Failed] :", ex);
            //    oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
            //    throw new Exception();
            //}
            //return oE_Reportes_Colgate_Bodega_Mov_Response;
        }



        //Descripcion   : Registrar Nuevos Puntos de Venta Para Colgate Bodega.
        //Fecha         : 04/05/2012 PSA

        public E_Reporte_RegistroPDV_Response Registrar_PuntoDeVenta_Bodega_Mov(E_Reporte_RegistroPDV_Mov oE_Reporte_RegistroPDV_Mov)
        {
            E_Reporte_RegistroPDV_Response oE_Reporte_RegistroPDV_Response = new E_Reporte_RegistroPDV_Response();

            string mensaje = "";
            D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();
            try {
                oE_Reporte_RegistroPDV_Response.Mensaje = mensaje;
                oE_Reporte_RegistroPDV_Response = oD_ReportesColgate_Bodega.Registrar_PuntoDeVenta_Bodega_Mov(oE_Reporte_RegistroPDV_Mov);
            }
            catch (Exception ex) {
                log.Error("[Registrar_Registrar_ReportesPDV_Mov] [Registrar_ReportesPDV_Mov_Failed] :", ex);
                mensaje = "Se ha producido un Error, Consultar con el Equipo de TI.";
                oE_Reporte_RegistroPDV_Response.Mensaje = mensaje;
                throw new Exception();
            }
            return oE_Reporte_RegistroPDV_Response;
        }


        #endregion 


    }
}
