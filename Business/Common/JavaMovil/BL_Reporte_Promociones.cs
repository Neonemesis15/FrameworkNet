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
    public class BL_Reporte_Promociones
    {
        public BL_Reporte_Promociones() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Promociones));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Promociones oD_Reporte_Promocioneses = new D_Reporte_Promociones();

        public void Registrar_Promociones_General_Lista(List<E_Reporte_Promocion_General> oList_Reporte)
        {
            D_Reporte_Promociones oDReporte = new D_Reporte_Promociones();
            try
            {
                oDReporte.Registrar_Promociones_General_Lista(oList_Reporte);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Promocion] [RegistrarPromocionFailed] :", ex);
            }
        }
        public void Registrar_Promociones_General(E_Reporte_Promocion_General oEReporte)
        {
            //D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
            D_Reporte_Promociones oDReporte = new D_Reporte_Promociones();

            try
            {
                oDReporte.Registrar_Promociones_General(oEReporte);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Promocion] [RegistrarPromocionFailed] :", ex);
            }


        }


    }
}
