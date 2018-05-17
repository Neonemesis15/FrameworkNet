using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
   public class OPE_REPORTE_PRECIO
    {
       public OPE_REPORTE_PRECIO()
       { }

       public EOPE_REPORTE_PRECIO RegistrarReportePrecio(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sID_MARCA, string sID_FAMILIA, string sID_SUBFAMILIA, string sTIPO_CANAL, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, char cORIGEN, string sOBSERVACION)
       {
           DOPE_REPORTE_PRECIO oDOPE_REPORTE_PRECIO = new DOPE_REPORTE_PRECIO();
           EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = oDOPE_REPORTE_PRECIO.RegistrarReportePrecio(iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sID_MARCA, sID_FAMILIA, sID_SUBFAMILIA, sTIPO_CANAL, sFEC_REG_CEL, sLATITUD, sLONGITUD, cORIGEN, sOBSERVACION);
           oDOPE_REPORTE_PRECIO = null;
           return oEOPE_REPORTE_PRECIO;

       }

       public EOPE_REPORTE_PRECIO RegistrarReportePrecio_Detalle(int iID_REG_PRECIO, string sID_PRODUCTO, string sPRECIO_LISTA, string sPRECIO_REVENTA, string sPRECIO_OFERTA, string sPVP, string sPRECIO_COSTO, string sPRECIO_MIN, string sPRECIO_MAX, string sPRECIO_REGULAR, char cMOTIVO_OBS)
       {
           DOPE_REPORTE_PRECIO oDOPE_REPORTE_PRECIO = new DOPE_REPORTE_PRECIO();
           EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = oDOPE_REPORTE_PRECIO.RegistrarReportePrecio_Detalle(iID_REG_PRECIO, sID_PRODUCTO, sPRECIO_LISTA, sPRECIO_REVENTA, sPRECIO_OFERTA, sPVP, sPRECIO_COSTO, sPRECIO_MIN, sPRECIO_MAX, sPRECIO_REGULAR, cMOTIVO_OBS);
           oDOPE_REPORTE_PRECIO = null;
           return oEOPE_REPORTE_PRECIO;

       }

    }
}
