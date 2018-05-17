using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
   public class OPE_REPORTE_COMPETENCIA
    {

       public OPE_REPORTE_COMPETENCIA()
       { }

       public EOPE_REPORTE_COMPETENCIA RegistrarReporteCompetencia(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sID_MARCA,
                                                            string sID_TIPO_PROM, string sID_TIPO_ACT, string sID_GRUPO_OBJ, string sPRECIO_COSTO, string sPRECIO_PVP, string sFEC_INI_ACT,
                                                            string sFEC_FIN_ACT, string sTXT_GRUPO_OBJ, string sCANT_PERSONAL, string sPREMIO, string sMECANICA, string sMAT_APOYO, string sOBSERVACIONES,
                                                            string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, string sORIGEN, string sFEC_COMUNICACION, string sID_EMPRESA)
       {
           DOPE_REPORTE_COMPETENCIA oDOPE_REPORTE_COMPETENCIA = new DOPE_REPORTE_COMPETENCIA();
           EOPE_REPORTE_COMPETENCIA oEOPE_REPORTE_COMPETENCIA = oDOPE_REPORTE_COMPETENCIA.RegistrarReporteCompetencia(iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sID_MARCA, sID_TIPO_PROM, sID_TIPO_ACT,
                                                     sID_GRUPO_OBJ, sPRECIO_COSTO, sPRECIO_PVP, sFEC_INI_ACT, sFEC_FIN_ACT, sTXT_GRUPO_OBJ, sCANT_PERSONAL, sPREMIO, sMECANICA, sMAT_APOYO, sOBSERVACIONES,
                                                     sFEC_REG_CEL, sLATITUD, sLONGITUD, sORIGEN, sFEC_COMUNICACION, sID_EMPRESA);
           oDOPE_REPORTE_COMPETENCIA = null;
           return oEOPE_REPORTE_COMPETENCIA;

       }

       public EOPE_REPORTE_COMPETENCIA RegistrarReporteCompetencia_Detalle(int iID_COMPETENCIA, string sID_POP)
       {
           DOPE_REPORTE_COMPETENCIA oDOPE_REPORTE_COMPETENCIA = new DOPE_REPORTE_COMPETENCIA();
           EOPE_REPORTE_COMPETENCIA oEOPE_REPORTE_COMPETENCIA = oDOPE_REPORTE_COMPETENCIA.RegistrarReporteCompetencia_Detalle(iID_COMPETENCIA,sID_POP);
           oDOPE_REPORTE_COMPETENCIA = null;
           return oEOPE_REPORTE_COMPETENCIA;

       }
    }
}
