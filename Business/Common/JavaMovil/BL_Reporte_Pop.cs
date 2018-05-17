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
    public class BL_Reporte_Pop
    {
        public BL_Reporte_Pop() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Promociones));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;

        private static readonly D_Reporte_Pop oD_Reporte_Pop = new D_Reporte_Pop();

        public void Registrar_Pop_General_Lista(List<E_Reporte_Pop_General> oList_Reporte)
        {
            D_Reporte_Pop oDReporte = new D_Reporte_Pop();
            try
            {
                oDReporte.Registrar_Pop_General_Lista(oList_Reporte);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Pop] [RegistrarPopFailed] :", ex);
            }
        }
        public void Registrar_Pop_General(E_Reporte_Pop_General oEReporte)
        {
            //D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
            D_Reporte_Pop oDReporte = new D_Reporte_Pop();

            try
            {
                oDReporte.Registrar_Pop_General(oEReporte);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Pop] [RegistrarPopFailed] :", ex);
            }


        }

    }
}
