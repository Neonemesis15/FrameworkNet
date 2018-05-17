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
    /// Clase:              DOPE_REPORTE_COMPETENCIA
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  06/09/2011
    /// </summary>

   public class DOPE_REPORTE_COMPETENCIA
    {
      private Conexion oConn;
        public DOPE_REPORTE_COMPETENCIA()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        public EOPE_REPORTE_COMPETENCIA RegistrarReporteCompetencia(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sID_MARCA, 
                                                            string sID_TIPO_PROM, string sID_TIPO_ACT, string sID_GRUPO_OBJ, string sPRECIO_COSTO, string sPRECIO_PVP, string sFEC_INI_ACT,   
                                                            string sFEC_FIN_ACT, string sTXT_GRUPO_OBJ, string sCANT_PERSONAL, string sPREMIO, string sMECANICA, string sMAT_APOYO, string sOBSERVACIONES,
                                                            string sFEC_REG_CEL,string sLATITUD,string sLONGITUD,string sORIGEN,string sFEC_COMUNICACION,string sID_EMPRESA )
        {
            string sID_COMPETENCIA = "";

            oConn = new Conexion(2);
            sID_COMPETENCIA = oConn.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_COMPETENCIA", 26, iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sID_MARCA, sID_TIPO_PROM, sID_TIPO_ACT,
                                                     sID_GRUPO_OBJ, sPRECIO_COSTO, sPRECIO_PVP, sFEC_INI_ACT, sFEC_FIN_ACT, sTXT_GRUPO_OBJ, sCANT_PERSONAL, sPREMIO, sMECANICA, sMAT_APOYO, sOBSERVACIONES,
                                                     sFEC_REG_CEL, sLATITUD, sLONGITUD, sORIGEN, sFEC_COMUNICACION, sID_EMPRESA, sID_COMPETENCIA);


            EOPE_REPORTE_COMPETENCIA oEOPE_REPORTE_COMPETENCIA = new EOPE_REPORTE_COMPETENCIA();


            oEOPE_REPORTE_COMPETENCIA.ID_COMPETENCIA = sID_COMPETENCIA;

            return oEOPE_REPORTE_COMPETENCIA;
            
        }


        public EOPE_REPORTE_COMPETENCIA RegistrarReporteCompetencia_Detalle(int iID_COMPETENCIA, string sID_POP)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("STP_JVM_INSERTAR_COMPETENCIA_DETALLE", iID_COMPETENCIA, sID_POP);

            EOPE_REPORTE_COMPETENCIA oEOPE_REPORTE_COMPETENCIA = new EOPE_REPORTE_COMPETENCIA();

            return oEOPE_REPORTE_COMPETENCIA;

        }




    }
}
