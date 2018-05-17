using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Entity.Common.Servicio;
using Lucky.Data.Common.Servicio;

namespace Lucky.Business.Common.Servicio
{
    public class BL_GES_ReportesCliente
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_GES_ReportesCliente));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_GES_ReportesCliente oD_GES_ReportesCliente = new D_GES_ReportesCliente();


        public E_ReporteCliente_Stock_Validacion ObtenerStockDG_Validacion(string anio ,string mes, int periodo,int codOficina,string codCategoria)
        {
            E_ReporteCliente_Stock_Validacion oE_ReporteCliente_Stock_Validacion = new E_ReporteCliente_Stock_Validacion();
            try
            {
                oE_ReporteCliente_Stock_Validacion = oD_GES_ReportesCliente.ObtenerStockDG_Validacion(anio, mes, periodo, codOficina, codCategoria);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][ObtenerStockDG_Validacion_Failed] : ", ex);
            }
            return oE_ReporteCliente_Stock_Validacion;
        }
        public string ValidarStockDiasGiro(string anio, string mes, int periodo, string codPdv, string codCategoria, bool validado, string user)
        {
            string mensaje = "";
            try
            {
                mensaje= oD_GES_ReportesCliente.ValidarStockDiasGiro(anio, mes, periodo,codPdv, codCategoria,validado,user);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][ValidarStockDiasGiro_Failed] : ", ex);
            }
            return mensaje;
        }

        //Por: Ditmar Estrada Bernuy , 12/11/2012
        #region Obtener las Oficinas por canal,compañia y codigo de Persona

        public List<E_Oficina> Obtener_OficinasPorCodPersonaAndCanalAndCompania(int CodPersona, string CodCanal, int CodCompania)
        {
            List<E_Oficina> Oficinas = new List<E_Oficina>();
            try
            {              
                Oficinas = oD_GES_ReportesCliente.Obtener_OficinasPorCodPersonaAndCanalAndCompania(CodPersona,CodCanal,CodCompania);
                
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][Obtener_OficinasPorCodPersonaAndCanalAndCompania_Failed] : ", ex);
            }
            return Oficinas;
        }
        #endregion

        //Add 13/10/2012 PSalas
        //public E_InformesCanje ObtenerInformesCanje() {
        //    try {
        //        E_InformesCanje oE_InformesCanje = new E_InformesCanje();
        //        oE_InformesCanje = oD_GES_ReportesCliente.ObtenerInformesCanje();
        //        return oE_InformesCanje;
        //    }
        //    catch (Exception ex) {
        //        throw ex;
        //    }
        //}
        #region CocaCola
        #region Analisis de Implementacion
        public List<GetDatosTotalImplementadoObjetivos> getDatosTotalImplementadoObjetivos(string opcion) {
            try {
                return oD_GES_ReportesCliente.getDatosTotalImplementadoObjetivos(opcion);
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosTotalImplementadoObjetivos_Failed] : ", ex);
                throw ex;
            }
        }
        //Add 15/10/2012 psa. Obtener los Puntos de Venta Implementados y No Implementados, la fase(Implementado o no Implementado) y coordenadas.
        public List<GetDatosDetalleImplementacionObjetivo> getDatosDetalleImplementacionObjetivo(string opcion) {
            try {
                return oD_GES_ReportesCliente.getDatosDetalleImplementacionObjetivo(opcion);
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosDetalleImplementacionObjetivo_Failed] : ", ex);
                throw ex;
            }
        }
        public List<CharColumn3DStacked> getCharColumn3DStacked() {
            try {
                return oD_GES_ReportesCliente.getCharColumn3DStacked();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getCharColumn3DStacked_Failed] : ", ex);
                throw ex;
            }
        }
        public List<GetDatosPorVisita> getDatosPorVisita() {
            try {
                return oD_GES_ReportesCliente.getDatosPorVisita();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosPorVisita_Failed] : ", ex);
                throw ex;
            }
        }
        public List<GetDatosPorAcumulado> getDatosPorAcumulado() {
            try {
                return oD_GES_ReportesCliente.getDatosPorAcumulado();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosPorAcumulado_Failed] : ", ex);
                throw ex;
            }
        }
        public List<GetDatosPorMerma> getDatosPorMerma() {
            try {
                return oD_GES_ReportesCliente.getDatosPorMerma();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosPorMerma_Failed] : ", ex);
                throw ex;
            }
        }
        public List<GetDatosMatImpl> getDatosMatImpl() {
            try {
                return oD_GES_ReportesCliente.getDatosMatImpl();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosMatImpl_Failed] : ", ex);
                throw ex;
            }
        }
        public List<GetDatosBodeImplFrec> getDatosBodeImplFrec() {
            try {
                return oD_GES_ReportesCliente.getDatosBodeImplFrec();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosBodeImplFrec_Failed] : ", ex);
                throw ex;
            }
        }
        //Add 17/10/2012. psa. descripcion: Obtener Datos del Resumen para Implementacion y Razones de No Implementacion.
        public List<GetDatosPorResumeImp_RazNoImpl> getDatosPorResumeImp_RazNoImpl() {
            try {
                return oD_GES_ReportesCliente.getDatosPorResumeImp_RazNoImpl();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosBodeImplFrec_Failed] : ", ex);
                throw ex;
            }
        }
        #endregion
        #region Analisis de Stock
        public List<GetDatosPorCantStock> getDatosPorCantStock() {
            try
            {
                return oD_GES_ReportesCliente.getDatosPorCantStock();
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][getDatosPorCantStock_Failed] : ", ex);
                throw ex;
            }
        }
        public List<GetDatosPorCantTotalPlatosVendidos> getDatosPorCantTotalPlatosVendidos() {
            try
            {
                return oD_GES_ReportesCliente.getDatosPorCantTotalPlatosVendidos();
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][getDatosPorCantTotalPlatosVendidos_Failed] : ", ex);
                throw ex;
            }
        }
        //Add 16/10/2012 psa. descripcion:ObtenerDatosPorDetalleStockVendidosVsObjetivo, muestra coordenadas para representarlas en mapa.
        public List<GetDatosPorDetalleStockVenVsObj> getDatosPorDetalleStockVenVsObj() {
            try {
                return oD_GES_ReportesCliente.getDatosPorDetalleStockVenVsObj();
            }
            catch (Exception ex) {
                log.Error("[BL_GES_ReportesCliente][getDatosPorDetalleStockVenVsObj_Failed] : ", ex);
                throw ex;
            }
        }
        //Add 05/11/2012 psa.
        public List<GetDatosPorCantStock> getTotAvaPlaIngAlm()
        {
            try
            {
                return oD_GES_ReportesCliente.getTotAvaPlaIngAlm();
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][getTotAvaPlaIngAlm_Failed] : ", ex);
                throw ex;
            }
        }
        //Add 05/11/2012 psa.
        public List<GetDatosPorCantStock> getTotPlaDistCDV()
        {
            try
            {
                return oD_GES_ReportesCliente.getTotPlaDistCDV();
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][getTotPlaDistCDV_Failed] : ", ex);
                throw ex;
            }
        }
        //Add 05/11/2012 psa.
        public List<GetDatosPorCantStock> getAvaPlaObj()
        {
            try
            {
                return oD_GES_ReportesCliente.getAvaPlaObj();
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][getAvaPlaObj_Failed] : ", ex);
                throw ex;
            }
        }
        #endregion
        #region Analisis de Merma
        public List<GetDatosPorTipMerma> getDatosPorTipMerma() {
            try
            {
                return oD_GES_ReportesCliente.getDatosPorTipMerma();
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_ReportesCliente][getDatosPorTipMerma_Failed] : ", ex);
                throw ex;
            }
        }
        #endregion
        #endregion
    }
}
