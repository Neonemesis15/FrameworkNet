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
    public class BL_Reporte_ImplementarBodega
    {
        public BL_Reporte_ImplementarBodega() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReportesColgate_May));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_ImplementarBodega oD_Reporte_ImplementarBodega = new D_Reporte_ImplementarBodega();

        /// <summary>
        /// Metodo para Registrar Implementar Bodega ColgateBodega
        /// pSalas 27/03/2012
        /// </summary>
        /// <param name="oE_Reporte_Bodega"></param>
        /// <returns>Vacio si todo está Ok</returns>
        public string RegistrarImplementarBodega(E_Reporte_ImplementarBodega oE_Reporte_ImplementarBodega)
        {
            D_Reporte_ImplementarBodega oD_Reporte_ImplementarBodega = new D_Reporte_ImplementarBodega();
            String error = string.Empty;
            try
            {
                error = oD_Reporte_ImplementarBodega.RegistrarImplementarBodega(oE_Reporte_ImplementarBodega);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registrar_ImplementarBodega] [Registrar_ImplementarBodega_Failed] :", ex);
                error = ex.Message;
            }
            return error;
        }
    }
}
