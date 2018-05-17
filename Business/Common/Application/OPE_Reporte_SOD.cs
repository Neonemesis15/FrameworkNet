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
    /// Clase:              OPE_Reporte_SOD
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  20/02/2012
    /// </summary>
    public class OPE_Reporte_SOD
    {
        public OPE_Reporte_SOD()
        { }

        public EOPE_Reporte_SOD RegistrarReporteSOD(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, string sORIGEN, string sOBSERVACION)
        {
            DOPE_Reporte_SOD oDOPE_Reporte_SOD = new DOPE_Reporte_SOD();
            EOPE_Reporte_SOD oEOPE_Reporte_SOD = oDOPE_Reporte_SOD.RegistrarReporteSOD(iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sFEC_REG_CEL, sLATITUD, sLONGITUD, sORIGEN, sOBSERVACION);
            oDOPE_Reporte_SOD = null;
            return oEOPE_Reporte_SOD;

        }

        public EOPE_Reporte_SOD RegistrarReporteStock_Detalle(int iID_REG_SOD, string ID_MARCA, string sEXHIB_PRIMARIA, string sEXHIB_SECUNDARIA, string sMOTIVO_OBS)
        {
            DOPE_Reporte_SOD oDOPE_Reporte_SOD = new DOPE_Reporte_SOD();
            EOPE_Reporte_SOD oEOPE_Reporte_SOD = oDOPE_Reporte_SOD.RegistrarReporteSOD_Detalle(iID_REG_SOD, ID_MARCA, sEXHIB_PRIMARIA, sEXHIB_SECUNDARIA, sMOTIVO_OBS);
            oDOPE_Reporte_SOD = null;
            return oEOPE_Reporte_SOD;

        }
    }
}
