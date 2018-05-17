using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using log4net;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Stock
    {
        public BL_Reporte_Stock() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Stock));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Stock oD_Reporte_Stock = new D_Reporte_Stock();
        String error = string.Empty;

        public string Registrar_Reporte_Stock(List<E_Reporte_Stock> ListaE_Reporte_Stock, string appEnvia)
        {
            D_Reporte_Stock oD_Reporte_Stock = new D_Reporte_Stock();
            try { error = oD_Reporte_Stock.Registrar_Reporte_Stock(ListaE_Reporte_Stock, appEnvia); }
            catch (Exception ex) {
                log.Error("[BL_Registrar_Stock][Registrar_Stock_Failed] :" , ex);
                error = error + ex.Message;
            }
            return error;
        }
    }
}
