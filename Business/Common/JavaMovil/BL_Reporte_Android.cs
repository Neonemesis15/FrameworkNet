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
    public class BL_Reporte_Android
    {
        public BL_Reporte_Android() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Android));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Android oD_Reporte_Android = new D_Reporte_Android();
        //Add 16/03/2012
        public void registraPDV_Android(List<EPuntoVenta> oListPDV) {
            D_Reporte_Android oD_Reporte_Android = new D_Reporte_Android();
            try {
                oD_Reporte_Android.Registrar_PtosVentas_Android_Lista(oListPDV);
            }
            catch(Exception ex) {
                log.Error("[BL_Registar_PDV_Android] [RegistrarPDV_Android_Failed] :", ex);
            }
        }
 
        

    }
}
