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
    public class BL_Reporte_Visibilidad
    {
        public BL_Reporte_Visibilidad() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Visibilidad));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Visibilidad oD_Reporte_Visibilidad = new D_Reporte_Visibilidad();

        
        public void Registrar_Visibilidad_Altomayo(E_Reporte_Visibilidad oE_Reporte_Visibilidad) {
            D_Reporte_Visibilidad oD_Reporte_Visibilidad = new D_Reporte_Visibilidad();
            try
            {
                oD_Reporte_Visibilidad.Registrar_Visibilidad_Altomayo(oE_Reporte_Visibilidad);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Visibilidad_Altomayo] [RegistrarVisibilidadAltomayoFailed] :", ex);
            }
                
        }


    }
}
