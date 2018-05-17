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
    public class BL_Reporte_Presencia
    {
        public BL_Reporte_Presencia() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Presencia));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
        String error = string.Empty;

        public void Registrar_Presencia_General_Lista(List<E_Reporte_Presencia_General> oList_Reporte_Presencia) {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            
            //return oD_Reporte_Presencia.Registrar_Presencia_General_Lista(oList_Reporte_Presencia);

            try
            {
                oD_Reporte_Presencia.Registrar_Presencia_General_Lista(oList_Reporte_Presencia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Presencia] [RegistrarPresenciaFailed] :", ex);
            }
        }
        
        /// <summary>
        /// Registra Reporte de Presencia para ColgateBodega
        /// pSalas 28/03/2012
        /// </summary>
        /// <param name="oListReporte_Presencia"></param>
        /// <returns></returns>
        public string Registrar_Presencia_General_Lista_Normal(List<E_Reporte_Presencia_General> oListReporte_Presencia, List<E_Reporte_Codigo_ITT> oListReporte_CodigoITT, E_Visita oE_Visita)
        {
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT(); 
            D_Visita oD_Visita = new D_Visita();
            try
            {
               error = oD_Reporte_Presencia.Registrar_Presencia_General_Lista_Normal(oListReporte_Presencia);
               oD_Reporte_Codigo_ITT.Registrar_Presencia_Codigo_ITT(oListReporte_CodigoITT);
               oD_Visita.RegistrarVisita(oE_Visita);
            }
            catch (Exception ex) {
                log.Error("[BL_Registar_Presencia_General_Lista_Normal] [Registar_Presencia_General_Lista_NormalFailed] :", ex);
                error = ex.Message;
            }
            return error;
        }



        /// <summary>
        /// Registrar Presencia para Colgate DT,IT 
        /// Date:   17/03/2012 pSalas
        /// </summary>
        /// <param name="oE_Reporte_Presencia"></param>
        public void Registrar_Presencia_General(E_Reporte_Presencia_General oE_Reporte_Presencia)
        {
            //D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();

            try
            {
                oD_Reporte_Presencia.Registrar_Presencia_General(oE_Reporte_Presencia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Presencia] [RegistrarPrecioFailed] :", ex);
            }


        }
    }
}

