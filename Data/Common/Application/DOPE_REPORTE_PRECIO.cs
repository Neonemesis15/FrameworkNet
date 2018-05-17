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
    /// Clase:DOPE_REPORTE_PRECIO
    /// Creada Por: Carlos Marin Moreno
    /// Fecha de Creacion: 01/09/2011
    /// </summary>
  public  class DOPE_REPORTE_PRECIO
    {

      private Conexion oConn;
      public DOPE_REPORTE_PRECIO()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
      public EOPE_REPORTE_PRECIO RegistrarReportePrecio(int iPerson_id, string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, string sID_PTOVENTA, string sID_CATEGORIA, string sID_MARCA, string sID_FAMILIA, string sID_SUBFAMILIA, string sTIPO_CANAL, string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, char cORIGEN, string sOBSERVACION)
      {

          string ID_REG_PRECIO="" ;
          oConn = new Conexion(2);
          string id = oConn.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_PRECIO_XLAPAGINA", 16, iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA, sID_MARCA, sID_FAMILIA, sID_SUBFAMILIA, sTIPO_CANAL, sFEC_REG_CEL, sLATITUD, sLONGITUD, cORIGEN, sOBSERVACION,"", ID_REG_PRECIO);




          EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = new EOPE_REPORTE_PRECIO();

          oEOPE_REPORTE_PRECIO.Person_id = iPerson_id;
          oEOPE_REPORTE_PRECIO.ID_PERFIL = sID_PERFIL;
          oEOPE_REPORTE_PRECIO.ID_EQUIPO = sID_EQUIPO;
          oEOPE_REPORTE_PRECIO.ID_CLIENTE = sID_CLIENTE;
          oEOPE_REPORTE_PRECIO.ID_PTOVENTA = sID_PTOVENTA;
          oEOPE_REPORTE_PRECIO.ID_CATEGORIA = sID_CATEGORIA;
          oEOPE_REPORTE_PRECIO.ID_MARCA = sID_MARCA;
          oEOPE_REPORTE_PRECIO.ID_FAMILIA = sID_FAMILIA;
          oEOPE_REPORTE_PRECIO.ID_SUBFAMILIA = sID_SUBFAMILIA;
          oEOPE_REPORTE_PRECIO.TIPO_CANAL = sTIPO_CANAL;
          oEOPE_REPORTE_PRECIO.FEC_REG_CEL = Convert.ToDateTime(sFEC_REG_CEL);
          oEOPE_REPORTE_PRECIO.LATITUD = sLATITUD;
          oEOPE_REPORTE_PRECIO.LONGITUD = sLONGITUD;
          oEOPE_REPORTE_PRECIO.ORIGEN = cORIGEN;
          oEOPE_REPORTE_PRECIO.OBSERVACION = sOBSERVACION;
          oEOPE_REPORTE_PRECIO.ID = Convert.ToInt64(id);
          
          return oEOPE_REPORTE_PRECIO;

      }

      public EOPE_REPORTE_PRECIO RegistrarReportePrecio_Detalle(int iID_REG_PRECIO, string sID_PRODUCTO, string sPRECIO_LISTA, string sPRECIO_REVENTA, string sPRECIO_OFERTA, string sPVP, string sPRECIO_COSTO, string sPRECIO_MIN, string sPRECIO_MAX, string sPRECIO_REGULAR, char cMOTIVO_OBS)
      {
          oConn = new Conexion(2);
          DataTable dt = oConn.ejecutarDataTable("STP_JVM_INSERTAR_PRECIO_DETALLE", iID_REG_PRECIO, sID_PRODUCTO, sPRECIO_LISTA, sPRECIO_REVENTA, sPRECIO_OFERTA, sPVP, sPRECIO_COSTO, sPRECIO_MIN, sPRECIO_MAX, sPRECIO_REGULAR, cMOTIVO_OBS);

          EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = new EOPE_REPORTE_PRECIO();

          oEOPE_REPORTE_PRECIO.ID_REG_PRECIO = iID_REG_PRECIO;
          oEOPE_REPORTE_PRECIO.ID_PRODUCTO = sID_PRODUCTO;
          oEOPE_REPORTE_PRECIO.PRECIO_LISTA = sPRECIO_LISTA;
          oEOPE_REPORTE_PRECIO.PRECIO_REVENTA = sPRECIO_REVENTA;
          oEOPE_REPORTE_PRECIO.PRECIO_OFERTA = sPRECIO_OFERTA;
          oEOPE_REPORTE_PRECIO.PVP = sPVP;
          oEOPE_REPORTE_PRECIO.PRECIO_COSTO = sPRECIO_COSTO;
          oEOPE_REPORTE_PRECIO.PRECIO_MIN = sPRECIO_MIN;
          oEOPE_REPORTE_PRECIO.PRECIO_MAX = sPRECIO_MAX;
          oEOPE_REPORTE_PRECIO.PRECIO_REGULAR = sPRECIO_REGULAR;
          oEOPE_REPORTE_PRECIO.MOTIVO_OBS = cMOTIVO_OBS;
          return oEOPE_REPORTE_PRECIO;

      }

    }
}
