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
    public class BL_ReportesColgate_FarmaciaDT
    {
        public BL_ReportesColgate_FarmaciaDT() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Visibilidad_Competencia));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        //private static readonly D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();

        #region App Movil Lucky
        public string registrarReportesColgate_FarmaciaDT(
            List<E_Reporte_Presencia_General> oList_E_ReportePresencia, 
            List<E_Reporte_Visibilidad_Competencia> oList_E_ReporteVisibilidadCompetencia , 
            List<E_Reporte_Promocion_General> oList_E_ReportePromocion, 
            List<E_Reporte_Pop_General> oList_E_ReportePop,
            List<E_Reporte_Codigo_ITT> oList_E_ReporteCodigoITT,
            E_Visita oE_Visita)
        {
            //D_ReportesColgate_Bodega oD_ReportesColgate_Bodega = new D_ReportesColgate_Bodega();
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Promociones oD_Reporte_Promociones = new D_Reporte_Promociones();
            D_Reporte_Pop oD_Reporte_Pop = new D_Reporte_Pop();
            D_Reporte_Visibilidad_Competencia oD_reporteVisCompe = new D_Reporte_Visibilidad_Competencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Visita oD_Visita = new D_Visita();
            string mensaje = "";
            try
            {
                //oD_ReportesColgate_Bodega.RegistrarReportesColgate_Bodega(oList_E_Reporte_RegistroPDV);
                mensaje=oD_Reporte_Presencia.Registrar_Presencia_General_Lista(oList_E_ReportePresencia);
                oD_reporteVisCompe.Registrar_Visibilidad_Competencia(oList_E_ReporteVisibilidadCompetencia);//Adiciona Ing. Carlos Hernandez 07/03/2012
                oD_Reporte_Promociones.Registrar_Promociones_General_Lista(oList_E_ReportePromocion);
                oD_Reporte_Pop.Registrar_Pop_General_Lista(oList_E_ReportePop);
                oD_Reporte_Codigo_ITT.Registrar_Presencia_Codigo_ITT(oList_E_ReporteCodigoITT);
                oD_Visita.RegistrarVisita(oE_Visita);//Add 12/03/2012
                return mensaje;
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_ReportesColgateFarmaciaDT] [Registrar_ReportesColgateFarmaciaDT_Failed] :", ex);
                mensaje = "Se ha producido un Error, Consultar con el Equipo de TI.";
                return mensaje;
            }
        }
        #endregion


        #region App Movil Movistar
        /// <summary>
        /// Descripcion : Registro de Reportes de Colgate Farmacia para AppMovil Movistar
        /// Fecha       : 21/05/2012 - PSA
        /// Actualizacion   : 28/08/2012
        /// Descripcion     : Se agregan las nuevas validaciones del RQ Colgate v 1.9
        /// Author          : Pablo Salas A.
        /// </summary>
        /// <param name="oList_E_Reporte_ITT_Mov"></param>
        /// <param name="oList_E_Reporte_Promocion_Mov"></param>
        /// <param name="oList_E_Reporte_Presencia_Mov"></param>
        /// <param name="oList_E_Reporte_MatApoyo_Mov"></param>
        /// <param name="oList_E_Reporte_VisComp_Mov"></param>
        /// <param name="oE_Visita"></param>
        /// <param name="AppEnvia"></param>
        public E_Reportes_Colgate_Farmacia_DT_Mov_Response Registar_Reporte_Colgate_Farmacia_DT_Mov_V_1_1(List<E_Reporte_Presencia_Mov> oList_E_Reporte_Presencia_Mov,List<E_Reporte_Codigo_ITT_Mov> oList_E_Reporte_ITT_Mov,List<E_Reporte_Promocion_Mov> oList_E_Reporte_Promocion_Mov,List<E_Reporte_Mat_Apoyo_Mov> oList_E_Reporte_MatApoyo_Mov,List<E_Reporte_VisCompentencia_Mov> oList_E_Reporte_VisComp_Mov,E_Visita_Mov oE_Visita_Mov,int AppEnvia) {
                D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
                D_Reporte_Promociones oD_Reporte_Promociones = new D_Reporte_Promociones();
                D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
                D_Reporte_Mat_Apoyo oD_Reporte_Mat_Apoyo = new D_Reporte_Mat_Apoyo();
                D_Reporte_Visibilidad_Competencia oD_Reporte_Visibilidad_Competencia = new D_Reporte_Visibilidad_Competencia();
                D_Visita oD_Visita_Mov = new D_Visita();

                String mensaje_Presencia = string.Empty;
                String mensaje_Codigo_ITT = string.Empty;
                String mensaje_Promociones = string.Empty;
                String mensaje_Mat_Apoyo = string.Empty;
                String mensaje_VisCompetencia = string.Empty;
                String mensaje_Visita = string.Empty;
                //String mensaje_Final = string.Empty;

                E_Reportes_Colgate_Farmacia_DT_Mov_Response oE_Reportes_Colgate_Farmacia_DT_Mov_Response = new E_Reportes_Colgate_Farmacia_DT_Mov_Response();
                E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
                try {

                    oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Mov_V_1_2(oList_E_Reporte_Presencia_Mov, AppEnvia);//Add 28/082/2012 Nuevas Validaciones PSalas

                    //mensaje_Codigo_ITT += oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_Reporte_ITT_Mov);
                    mensaje_Promociones = oD_Reporte_Promociones.Registrar_Promociones_Mov(oList_E_Reporte_Promocion_Mov, AppEnvia);
                    //mensaje_Presencia = oD_Reporte_Presencia.Registrar_Presencia_Mov(oList_E_Reporte_Presencia_Mov, AppEnvia);//Disabled 28/08/2012 Antiguas Validaciones PSalas
                    mensaje_Presencia = oE_Reporte_Presencia_Datos_Response.MensajeUsuario;
                    mensaje_Mat_Apoyo = oD_Reporte_Mat_Apoyo.Registrar_Material_Apoyo_Mov(oList_E_Reporte_MatApoyo_Mov, AppEnvia);
                    mensaje_VisCompetencia = oD_Reporte_Visibilidad_Competencia.Registrar_VisCompetencia_Mov(oList_E_Reporte_VisComp_Mov, AppEnvia);
                    oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_Reporte_ITT_Mov); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                    mensaje_Visita = oD_Visita_Mov.RegistrarVisita_Mov(oE_Visita_Mov);
                    

                    //if (!mensaje_Codigo_ITT.Equals(""))
                    //    mensaje_Codigo_ITT = "Alerta Rep. Código ITT" + Environment.NewLine + mensaje_Codigo_ITT + Environment.NewLine;
                    if (!mensaje_Promociones.Equals(""))
                        mensaje_Promociones = "Alerta Rep. Promocion" + Environment.NewLine + mensaje_Promociones;
                    if (!mensaje_Presencia.Equals(""))
                        mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                    if (!mensaje_Mat_Apoyo.Equals(""))
                        mensaje_Mat_Apoyo = "Alerta Rep. Material Apoyo" + Environment.NewLine + mensaje_Mat_Apoyo + Environment.NewLine;
                    if (!mensaje_VisCompetencia.Equals(""))
                        mensaje_VisCompetencia = "Alerta Rep. Visibilidad Competencia" + Environment.NewLine + mensaje_Mat_Apoyo + Environment.NewLine;
                    if (!mensaje_Visita.Equals(""))
                        mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita;

                    //oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_Reporte_ITT_Mov);
                    oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Mensaje_Response = mensaje_Promociones + mensaje_Presencia + mensaje_Mat_Apoyo + mensaje_VisCompetencia + mensaje_Visita;


                    //mensaje_Final = mensaje_Codigo_ITT + mensaje_Promociones + mensaje_Presencia + mensaje_Mat_Apoyo + mensaje_VisCompetencia + mensaje_Visita;

                }
                catch (Exception ex) {
                    log.Error("[BL_Registar_Reporte_Colgate_Farmacia_DT_Mov] [Registar_Reporte_Colgate_Farmacia_DT_Mov_Failed] :", ex);
                    oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                    throw new Exception(); 
                }
                return oE_Reportes_Colgate_Farmacia_DT_Mov_Response;
        }

        //Backup : 28/08/2012
        //Author : Pablo Salas A.
        public E_Reportes_Colgate_Farmacia_DT_Mov_Response Registar_Reporte_Colgate_Farmacia_DT_Mov(List<E_Reporte_Presencia_Mov> oList_E_Reporte_Presencia_Mov, List<E_Reporte_Codigo_ITT_Mov> oList_E_Reporte_ITT_Mov, List<E_Reporte_Promocion_Mov> oList_E_Reporte_Promocion_Mov, List<E_Reporte_Mat_Apoyo_Mov> oList_E_Reporte_MatApoyo_Mov, List<E_Reporte_VisCompentencia_Mov> oList_E_Reporte_VisComp_Mov, E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        {
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Reporte_Promociones oD_Reporte_Promociones = new D_Reporte_Promociones();
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Mat_Apoyo oD_Reporte_Mat_Apoyo = new D_Reporte_Mat_Apoyo();
            D_Reporte_Visibilidad_Competencia oD_Reporte_Visibilidad_Competencia = new D_Reporte_Visibilidad_Competencia();
            D_Visita oD_Visita_Mov = new D_Visita();

            String mensaje_Presencia = string.Empty;
            String mensaje_Codigo_ITT = string.Empty;
            String mensaje_Promociones = string.Empty;
            String mensaje_Mat_Apoyo = string.Empty;
            String mensaje_VisCompetencia = string.Empty;
            String mensaje_Visita = string.Empty;
            //String mensaje_Final = string.Empty;

            E_Reportes_Colgate_Farmacia_DT_Mov_Response oE_Reportes_Colgate_Farmacia_DT_Mov_Response = new E_Reportes_Colgate_Farmacia_DT_Mov_Response();

            try
            {
                //mensaje_Codigo_ITT += oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_Reporte_ITT_Mov);
                mensaje_Promociones = oD_Reporte_Promociones.Registrar_Promociones_Mov(oList_E_Reporte_Promocion_Mov, AppEnvia);
                mensaje_Presencia = oD_Reporte_Presencia.Registrar_Presencia_Mov(oList_E_Reporte_Presencia_Mov, AppEnvia);
                mensaje_Mat_Apoyo = oD_Reporte_Mat_Apoyo.Registrar_Material_Apoyo_Mov(oList_E_Reporte_MatApoyo_Mov, AppEnvia);
                mensaje_VisCompetencia = oD_Reporte_Visibilidad_Competencia.Registrar_VisCompetencia_Mov(oList_E_Reporte_VisComp_Mov, AppEnvia);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_Reporte_ITT_Mov); //Reporte de Codigos ITT. Add 24/08/2012 Pablo Salas A.
                mensaje_Visita = oD_Visita_Mov.RegistrarVisita_Mov(oE_Visita_Mov);


                //if (!mensaje_Codigo_ITT.Equals(""))
                //    mensaje_Codigo_ITT = "Alerta Rep. Código ITT" + Environment.NewLine + mensaje_Codigo_ITT + Environment.NewLine;
                if (!mensaje_Promociones.Equals(""))
                    mensaje_Promociones = "Alerta Rep. Promocion" + Environment.NewLine + mensaje_Promociones;
                if (!mensaje_Presencia.Equals(""))
                    mensaje_Presencia = "Alerta Rep. Presencia" + Environment.NewLine + mensaje_Presencia + Environment.NewLine;
                if (!mensaje_Mat_Apoyo.Equals(""))
                    mensaje_Mat_Apoyo = "Alerta Rep. Material Apoyo" + Environment.NewLine + mensaje_Mat_Apoyo + Environment.NewLine;
                if (!mensaje_VisCompetencia.Equals(""))
                    mensaje_VisCompetencia = "Alerta Rep. Visibilidad Competencia" + Environment.NewLine + mensaje_Mat_Apoyo + Environment.NewLine;
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Alerta Visita" + Environment.NewLine + mensaje_Visita;

                //oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oList_E_Reporte_ITT_Mov);
                oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Mensaje_Response = mensaje_Promociones + mensaje_Presencia + mensaje_Mat_Apoyo + mensaje_VisCompetencia + mensaje_Visita;


                //mensaje_Final = mensaje_Codigo_ITT + mensaje_Promociones + mensaje_Presencia + mensaje_Mat_Apoyo + mensaje_VisCompetencia + mensaje_Visita;

            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Reporte_Colgate_Farmacia_DT_Mov] [Registar_Reporte_Colgate_Farmacia_DT_Mov_Failed] :", ex);
                oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Mensaje_Response = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return oE_Reportes_Colgate_Farmacia_DT_Mov_Response;
        }


        #endregion
    }
}
