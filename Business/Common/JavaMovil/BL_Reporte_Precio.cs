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
    public class BL_Reporte_Precio
    {
        public BL_Reporte_Precio(){}
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Precio));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
        String error = string.Empty;
        public string RegistrarPrecio(List<E_Reporte_Precio> oE_Reporte_Precio, string appEnvia) {
            D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
            
            try
            {
               error= oD_Reporte_Precio.RegistraPrecio(oE_Reporte_Precio, appEnvia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_Registar_Precio] [RegistrarPrecioFailed] :", ex);
            }
            return error;
        }
        
        //public void Registrar_Precio_Altomayo(E_Reporte_Precio oE_Reporte_Precio)
        //{
        //    D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();

        //    try
        //    {
        //        oD_Reporte_Precio.RegistraPrecio(oE_Reporte_Precio, appEnvia);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("[BL_Registar_Precio] [RegistrarPrecioFailed] :", ex);
        //    }

        //}


    }
}
