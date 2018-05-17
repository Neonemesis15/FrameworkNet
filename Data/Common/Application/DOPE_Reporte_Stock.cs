using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;
using System.Configuration;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:              DOPE_Reporte_Stock
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  09/09/2011
    /// </summary>
   public class DOPE_Reporte_Stock
    {
             private Conexion oConn;
             public DOPE_Reporte_Stock()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

             public EOPE_Reporte_Stock RegistrarReporteStock(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sID_MARCA,
                                                          string sID_FAMILIA, string sID_SUBFAMILIA, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, string sORIGEN)
             {
                 string sID_REG_STOCK = "";

                 oConn = new Conexion(2);
                 sID_REG_STOCK = oConn.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_STOCK", 14, iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sID_MARCA,
                                                           sID_FAMILIA, sID_SUBFAMILIA, sFEC_REG_CEL, sLATITUD, sLONGITUD, sORIGEN,"", sID_REG_STOCK);


                 EOPE_Reporte_Stock oEOPE_Reporte_Stock = new EOPE_Reporte_Stock();


                 oEOPE_Reporte_Stock.ID_REG_STOCK = sID_REG_STOCK;

                 return oEOPE_Reporte_Stock;

             }

             public EOPE_Reporte_Stock RegistrarReporteStock_Detalle(int iID_REG_STOCK, string sID_FAMILIA, string sCANTIDAD, string sID_PRODUCTO, string sCANT_PEDIDO, string sCANT_INGRESO, string sCANT_VENTA, string sMOTIVO_OBS)
             {
                 oConn = new Conexion(2);
                 DataTable dt = oConn.ejecutarDataTable("STP_JVM_INSERTAR_STOCK_DETALLE", iID_REG_STOCK, sID_FAMILIA, sCANTIDAD, sID_PRODUCTO, sCANT_PEDIDO, sCANT_INGRESO, sCANT_VENTA, sMOTIVO_OBS, null);
                 EOPE_Reporte_Stock oEOPE_Reporte_Stock = new EOPE_Reporte_Stock();
                 return oEOPE_Reporte_Stock;
             }




    }
}
