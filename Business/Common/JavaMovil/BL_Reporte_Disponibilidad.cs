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
    public class BL_Reporte_Disponibilidad
    {
        public BL_Reporte_Disponibilidad() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Disponibilidad));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Disponibilidad oD_Reporte_Disponibilidad = new D_Reporte_Disponibilidad();

        public void RegistrarDisponibilidad(E_Reporte_Disponibilidad oE_Reporte_Disponibilidad)
        {
            D_Reporte_Disponibilidad oD_Reporte_Disponibilidad = new D_Reporte_Disponibilidad();
            
            try
            {
                oD_Reporte_Disponibilidad.RegistraDisponibilidad(oE_Reporte_Disponibilidad);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Disponibilidad] [RegistrarDisponibilidadFailed] :", ex);
            }

        }

    }
}
