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
    public class BL_Reporte_Competencia
    {

        public BL_Reporte_Competencia() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Precio));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Competencia oD_Reporte_Competencia = new D_Reporte_Competencia();

        public void Registrar_Reporte_Competencia(E_Reporte_Competencia oE_Reporte_Competencia, E_Reporte_Fotografico oFoto)
        {
            D_Reporte_Competencia oD_Reporte_Competencia = new D_Reporte_Competencia();
            try
            {
                oD_Reporte_Competencia.RegistrarCompetencia(oE_Reporte_Competencia, oFoto);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Competencia] [RegistrarCompetenciaFailed] :", ex);
            }

        }

        #region App Envia Pag Web 31/05/2012 PSA
        public string Registrar_Reporte_Competencia_Web(List<E_Reporte_Competencia> oList_Reportes, string AppEnvia) {
            D_Reporte_Competencia oD_Reporte_Competencia = new D_Reporte_Competencia();
            string error = string.Empty;
            try {
                error = oD_Reporte_Competencia.Registrar_Competencia_Web(oList_Reportes, AppEnvia);
            }
            catch (Exception ex) {
                log.Error("[BL_Registar_Competencia_Web] [Registrar_Reporte_Competencia_Web_Failed] :", ex);
                error = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();     
            }

            return error;
        }
        #endregion
    }
}
