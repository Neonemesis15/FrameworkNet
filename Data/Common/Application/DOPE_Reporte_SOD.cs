using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;
using System.Configuration;
using Lucky.Data;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:              DOPE_Reporte_SOD
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  20/02/2012
    /// </summary>
   public class DOPE_Reporte_SOD
    {
                     private Conexion oConn;
        public DOPE_Reporte_SOD()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        public EOPE_Reporte_SOD RegistrarReporteSOD(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, string sORIGEN, string sOBSERVACION)
        {
            string sID_REG_SOD = "";

            oConn = new Conexion(2);
            sID_REG_SOD = oConn.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_SOD", 11, iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sFEC_REG_CEL,
                                                       sLATITUD, sLONGITUD, sORIGEN, sOBSERVACION, sID_REG_SOD);


            EOPE_Reporte_SOD oEOPE_Reporte_SOD = new EOPE_Reporte_SOD();


            oEOPE_Reporte_SOD.ID_REG_SOD = sID_REG_SOD;

            return oEOPE_Reporte_SOD;

        }

        public EOPE_Reporte_SOD RegistrarReporteSOD_Detalle(int iID_REG_SOD, string ID_MARCA, string sEXHIB_PRIMARIA, string sEXHIB_SECUNDARIA, string sMOTIVO_OBS)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("STP_JVM_INSERTAR_SOD_DETALLE", iID_REG_SOD, ID_MARCA, sEXHIB_PRIMARIA, sEXHIB_SECUNDARIA, sMOTIVO_OBS);
            EOPE_Reporte_SOD oEOPE_Reporte_SOD = new EOPE_Reporte_SOD();
            return oEOPE_Reporte_SOD;
        }



    }
}
