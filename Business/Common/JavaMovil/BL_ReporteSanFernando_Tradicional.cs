using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_ReporteSanFernando_Tradicional
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_ReporteSanFernando_Tradicional));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_ReporteSanFernando_Tradicional oD_ReporteSanFernando_Tradicional = new D_ReporteSanFernando_Tradicional();

        #region AppMovil Movistar

        public string Registrar_ReporteSanFernando_Tradicional_Mov(
              List<E_Reporte_Precio_Mov> oListaRepPrecio_Mov
            , List<E_Reporte_Exhibicion_Mov> oListaRepExhibicion_Mov
            , List<E_Reporte_Marcaje_Precio_Mov> oListaRepMarcaje_Mov
            , List<E_Reporte_Mat_Apoyo_Mov> oListaRepMat_Apoyo_Mov
            //, List<E_Reporte_Mandil_Mov> oListaRepMandil_Mov
            //, List<E_Reporte_MatAdicional_Mov> oListaRepMatAdicional_Mov
            //, List<E_Reporte_Observacion_Mov> oListaRepObservacion_Mov
            , List<E_Reporte_Capacitacion_Mov> oListaRepCapacitacion_Mov
            , List<E_Reporte_Incidencia_Mov> oListaRepIncidencia_Mov
            , List<E_Reporte_Credito_Competencia_Mov> oListaRepCredito_Competencia_Mov
            , List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov
            , E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        {
            string mensaje = "";
            try
            {
                mensaje = oD_ReporteSanFernando_Tradicional.Registrar_ReporteSanFernando_Tradicional_Mov(
                      oListaRepPrecio_Mov
                    , oListaRepExhibicion_Mov
                    , oListaRepMarcaje_Mov
                    , oListaRepMat_Apoyo_Mov
                    , oListaRepCapacitacion_Mov
                    , oListaRepIncidencia_Mov
                    , oListaRepCredito_Competencia_Mov
                    , oListaRepPresencia_Mov
                    , oE_Visita_Mov
                    , AppEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_ReporteSanFernando_Tradicional] [Registrar_ReporteSanFernando_Tradicional_Mov_Failed] :", ex);
                mensaje = "Se ha producido un Error, Consultar con el Equipo de TI.";
                throw new Exception();
            }
            return mensaje;
        }

        #endregion
    }
}
