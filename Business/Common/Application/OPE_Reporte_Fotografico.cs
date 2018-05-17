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
    
   public class OPE_Reporte_Fotografico
    {
       public OPE_Reporte_Fotografico()
       { }

       public EOPE_Reporte_Fotografico RegistrarFoto(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sTipo_Proceso,
                                                 string sFEC_REG_CEL, string sComentario, byte[] simagen, string sNOMBREFOTO)
       {
           DOPE_Reporte_Fotografico oDOPE_Reporte_Fotografico = new DOPE_Reporte_Fotografico();
           EOPE_Reporte_Fotografico oEOPE_Reporte_Fotografico = oDOPE_Reporte_Fotografico.RegistrarFoto(iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sTipo_Proceso,
                                                  sFEC_REG_CEL, sComentario, simagen, sNOMBREFOTO);
           oDOPE_Reporte_Fotografico = null;
           return oEOPE_Reporte_Fotografico;

       }
       public EOPE_Reporte_Fotografico RegistrarReporteFotografico(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sTIPO_REPORTE,
                                         string sID_CATEGORIA, string sID_MARCA, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, string sORIGEN, string TIPO_REP_FOTOGRAF)
       {
           DOPE_Reporte_Fotografico oDOPE_Reporte_Fotografico = new DOPE_Reporte_Fotografico();
           EOPE_Reporte_Fotografico oEOPE_Reporte_Fotografico = oDOPE_Reporte_Fotografico.RegistrarReporteFotografico(iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sTIPO_REPORTE,
                                        sID_CATEGORIA, sID_MARCA, sFEC_REG_CEL, sLATITUD, sLONGITUD, sORIGEN, TIPO_REP_FOTOGRAF);
           oDOPE_Reporte_Fotografico = null;
           return oEOPE_Reporte_Fotografico;

       }
    }
}
