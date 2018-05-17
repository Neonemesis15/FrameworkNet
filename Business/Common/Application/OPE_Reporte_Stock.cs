using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase:              OPE_Reporte_Stock
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  09/09/2011
    /// </summary>
   public class OPE_Reporte_Stock
    {
       public OPE_Reporte_Stock()
       { }

       public EOPE_Reporte_Stock RegistrarReporteStock(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sID_MARCA,
                                                          string sID_FAMILIA, string sID_SUBFAMILIA, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, string sORIGEN)
       {
           DOPE_Reporte_Stock oDOPE_Reporte_Stock = new DOPE_Reporte_Stock();
           EOPE_Reporte_Stock oEOPE_Reporte_Stock = oDOPE_Reporte_Stock.RegistrarReporteStock(iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sID_MARCA, sID_FAMILIA, sID_SUBFAMILIA, sFEC_REG_CEL, sLATITUD, sLONGITUD, sORIGEN);
           oDOPE_Reporte_Stock = null;
           return oEOPE_Reporte_Stock;

       }

       public EOPE_Reporte_Stock RegistrarReporteStock_Detalle(int iID_REG_STOCK, string sID_FAMILIA, string sCANTIDAD, string sID_PRODUCTO, string sCANT_PEDIDO, string sCANT_INGRESO, string sCANT_VENTA, string sMOTIVO_OBS)
       {
           DOPE_Reporte_Stock oDOPE_Reporte_Stock = new DOPE_Reporte_Stock();
           EOPE_Reporte_Stock oEOPE_Reporte_Stock = oDOPE_Reporte_Stock.RegistrarReporteStock_Detalle(iID_REG_STOCK, sID_FAMILIA, sCANTIDAD, sID_PRODUCTO, sCANT_PEDIDO, sCANT_INGRESO, sCANT_VENTA, sMOTIVO_OBS);
           oDOPE_Reporte_Stock = null;
           return oEOPE_Reporte_Stock;

       }
    }
}
