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
    /// Clase:              DOPE_Reporte_Fotografico
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  14/09/2011
    /// </summary>
    
   public class DOPE_Reporte_Fotografico
    {
      
      private Conexion oConn;
      public DOPE_Reporte_Fotografico()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
      
       
       public EOPE_Reporte_Fotografico  RegistrarFoto(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sTipo_Proceso,
                                                 string sFEC_REG_CEL, string sComentario, byte[] bimagen, string sNOMBREFOTO )
       {


                    oConn = new Conexion(2);
                    oConn.ejecutarDataTable("stp_jvm_INSERTAR_FOTO", iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sTipo_Proceso,
                                                  sFEC_REG_CEL, sComentario, bimagen, sNOMBREFOTO);


                    EOPE_Reporte_Fotografico oEOPE_Reporte_Fotografico = new EOPE_Reporte_Fotografico();
                    oEOPE_Reporte_Fotografico.Person_id = iPerson_id;
                    oEOPE_Reporte_Fotografico.ID_PERFIL = sID_PERFIL;
                    oEOPE_Reporte_Fotografico.ID_EQUIPO = sID_EQUIPO;
                    oEOPE_Reporte_Fotografico.ID_EQUIPO = sID_EQUIPO;
                    oEOPE_Reporte_Fotografico.ID_CLIENTE = sID_CLIENTE;
                    oEOPE_Reporte_Fotografico.ID_PTOVENTA = sID_PTOVENTA;
                    oEOPE_Reporte_Fotografico.Tipo_Proceso =Convert.ToInt32(sTipo_Proceso);
                    oEOPE_Reporte_Fotografico.FEC_REG_CEL = sFEC_REG_CEL;
                    oEOPE_Reporte_Fotografico.Comentario = sComentario;
                    oEOPE_Reporte_Fotografico.imagen = bimagen;
                    oEOPE_Reporte_Fotografico.NOMBREFOTO = sNOMBREFOTO;
                   


                    return oEOPE_Reporte_Fotografico;

       }

       public EOPE_Reporte_Fotografico RegistrarReporteFotografico(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sTIPO_REPORTE,
                                         string sID_CATEGORIA,string sID_MARCA, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD , string sORIGEN,string sTIPO_REP_FOTOGRAF)
       {

           oConn = new Conexion(2);
           oConn.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO", iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sTIPO_REPORTE,
                                        sID_CATEGORIA, sID_MARCA, sFEC_REG_CEL, sLATITUD, sLONGITUD, sORIGEN, sTIPO_REP_FOTOGRAF);


           EOPE_Reporte_Fotografico oEOPE_Reporte_Fotografico = new EOPE_Reporte_Fotografico();
           oEOPE_Reporte_Fotografico.Person_id = iPerson_id;
           oEOPE_Reporte_Fotografico.ID_PERFIL = sID_PERFIL;
           oEOPE_Reporte_Fotografico.ID_EQUIPO = sID_EQUIPO;
           oEOPE_Reporte_Fotografico.ID_EQUIPO = sID_EQUIPO;
           oEOPE_Reporte_Fotografico.ID_CLIENTE = sID_CLIENTE;
           oEOPE_Reporte_Fotografico.ID_PTOVENTA = sID_PTOVENTA;
           oEOPE_Reporte_Fotografico.TIPO_REPORTE = sTIPO_REPORTE;
           oEOPE_Reporte_Fotografico.ID_CATEGORIA = sID_CATEGORIA;
           oEOPE_Reporte_Fotografico.ID_MARCA = sID_MARCA;
           oEOPE_Reporte_Fotografico.FEC_REG_CEL = sFEC_REG_CEL;
           oEOPE_Reporte_Fotografico.LATITUD = sLATITUD;
           oEOPE_Reporte_Fotografico.LONGITUD = sLONGITUD;
           oEOPE_Reporte_Fotografico.ORIGEN = sORIGEN;
           oEOPE_Reporte_Fotografico.TIPO_REP_FOTOGRAF = sTIPO_REP_FOTOGRAF;

           return oEOPE_Reporte_Fotografico;

       }
    }
}
