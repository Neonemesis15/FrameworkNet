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
    /// DOPE_REPORTE_PRECIO.cs
    /// Clase para Gestionar el Acceso a Datos, correspondiente al 
    /// Reporte de Precios.
    /// Developed by:
    /// - Carlos Marin Moreno (CMM)
    /// Changes:
    /// - 20-12-2018 Pablo Salas Alvarez (PSA) - Se Implementa los metodos para mejorar la Experiencia de Usuario para del Reporte de 
    ///                                          Precios (Agrupación de Cabeceras y Visualización de los Detalles dentro de una Grilla).
    /// - 01-09-2011 Carlos Marin Moreno (CMM) - Creación de la Clase.
    /// </summary>
  public  class DOPE_REPORTE_PRECIO{


      // Se Instancia a los Parametros
      EParametros oEParametros = new EParametros();

      // DataTable para Almancear el resultado de la Consulta
      DataTable dt = new DataTable();

      // Variable Conexion
      private Conexion oConn;
      
      // Variable para guardar Mensaje de Error.
      private String messages = "";

      /// <summary>
      /// Retorna los mensajes de Error
      /// </summary>
      /// <returns></returns>
      public String getMessages() {
          return messages;
      }

      /// <summary>
      /// Constructor de Clase
      /// </summary>
      public DOPE_REPORTE_PRECIO(){
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
      }

      /// <summary>
      /// Registrar Cabecera de la recolección de Precios en App Mobile
      /// </summary>
      /// <param name="iPerson_id"></param>
      /// <param name="sID_PERFIL"></param>
      /// <param name="sID_EQUIPO"></param>
      /// <param name="sID_CLIENTE"></param>
      /// <param name="sID_PTOVENTA"></param>
      /// <param name="sID_CATEGORIA"></param>
      /// <param name="sID_MARCA"></param>
      /// <param name="sID_FAMILIA"></param>
      /// <param name="sID_SUBFAMILIA"></param>
      /// <param name="sTIPO_CANAL"></param>
      /// <param name="sFEC_REG_CEL"></param>
      /// <param name="sLATITUD"></param>
      /// <param name="sLONGITUD"></param>
      /// <param name="cORIGEN"></param>
      /// <param name="sOBSERVACION"></param>
      /// <returns></returns>
      public EOPE_REPORTE_PRECIO RegistrarReportePrecio(int iPerson_id, 
          string sID_PERFIL, string sID_EQUIPO, string sID_CLIENTE, 
          string sID_PTOVENTA, string sID_CATEGORIA, string sID_MARCA, 
          string sID_FAMILIA, string sID_SUBFAMILIA, string sTIPO_CANAL, 
          string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, char cORIGEN, string sOBSERVACION){

              EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = oEOPE_REPORTE_PRECIO = new EOPE_REPORTE_PRECIO(); 
          string ID_REG_PRECIO="" ;
          string id = "";
          
          try
          {
              oConn = new Conexion(2);
              id = oConn.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_PRECIO_XLAPAGINA",
                  16, iPerson_id, sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, sID_CATEGORIA,
                  sID_MARCA, sID_FAMILIA, sID_SUBFAMILIA, sTIPO_CANAL, sFEC_REG_CEL, sLATITUD,
                  sLONGITUD, cORIGEN, sOBSERVACION, "", ID_REG_PRECIO);
          }
          catch (Exception ex) {
              messages = "Ocurrio un Error: " + ex.Message; 
          }

          // Verificar que no existan errores
          if (messages.Equals("")) {
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
          }

          return oEOPE_REPORTE_PRECIO;

      }

      /// <summary>
      /// Registar Registro de Precios Detalle para App Mobile.
      /// </summary>
      /// <param name="iID_REG_PRECIO"></param>
      /// <param name="sID_PRODUCTO"></param>
      /// <param name="sPRECIO_LISTA"></param>
      /// <param name="sPRECIO_REVENTA"></param>
      /// <param name="sPRECIO_OFERTA"></param>
      /// <param name="sPVP"></param>
      /// <param name="sPRECIO_COSTO"></param>
      /// <param name="sPRECIO_MIN"></param>
      /// <param name="sPRECIO_MAX"></param>
      /// <param name="sPRECIO_REGULAR"></param>
      /// <param name="cMOTIVO_OBS"></param>
      /// <returns></returns>
      public EOPE_REPORTE_PRECIO RegistrarReportePrecio_Detalle(int iID_REG_PRECIO, 
          string sID_PRODUCTO, string sPRECIO_LISTA, string sPRECIO_REVENTA, string sPRECIO_OFERTA, 
          string sPVP, string sPRECIO_COSTO, string sPRECIO_MIN, string sPRECIO_MAX, string sPRECIO_REGULAR, 
          char cMOTIVO_OBS){

              EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = new EOPE_REPORTE_PRECIO();
              
              try
              {
                  oConn = new Conexion(2);
                  DataTable dt = oConn.ejecutarDataTable("STP_JVM_INSERTAR_PRECIO_DETALLE",
                      iID_REG_PRECIO, sID_PRODUCTO, sPRECIO_LISTA, sPRECIO_REVENTA, sPRECIO_OFERTA, sPVP,
                      sPRECIO_COSTO, sPRECIO_MIN, sPRECIO_MAX, sPRECIO_REGULAR, cMOTIVO_OBS);
              }
              catch (Exception ex){

                  messages = "Ocurrio un Error: " + ex.Message;
              }

              if (messages.Equals("")) {
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
              }
          return oEOPE_REPORTE_PRECIO;
      }

      /// <summary>
      /// Retornar el Reporte de Precios
      /// </summary>
      /// <param name="oEParametros"></param>
      public DataTable find(String idPlanning, String idChannel,
          int idOficina, int idNodeCommercial, 
          String idPuntoDeVenta, String idCategoria,
          String idMarca, String idProducto, String idSubCategoria,
          int idPerson, DateTime fechaIni, DateTime fechaFin){

              // DataTable para guardar el Resultado
              DataTable dt = new DataTable();
    
              // Setear los Valores de los parametros en al entidad
              // EParametros
              oEParametros.setIdPlanning(idPlanning);
              oEParametros.setIdChannel(idChannel);
              oEParametros.setIdOficina(idOficina);
              oEParametros.setIdNodeCommercial(idNodeCommercial);
              oEParametros.setIdPuntoDeVenta(idPuntoDeVenta);
              oEParametros.setIdCategoria(idCategoria);
              oEParametros.setIdMarca(idMarca);
              oEParametros.setIdProducto(idProducto);
              oEParametros.setIdSubCategoria(idSubCategoria);
              oEParametros.setIdPerson(idPerson);
              oEParametros.setFechaInicio(fechaIni);
              oEParametros.setFechaFin(fechaFin);

              // Validar parametros
              validarParametros(oEParametros);
              
              // Validar que no existan errores despues de la validación
              // de parámetros.
              if (messages.Equals("")) {
                  // Validar Campos Obligatorios
                  verificarObligatorios(oEParametros);
                  if (messages.Equals("")) {
                      dt = findHeaders(oEParametros);
                      // Verificar que la consulta, devolvio al menos 1 registro.
                      if (dt.Rows.Count <= 0)
                      {
                          messages = "No se encontraron registros para los filtros" +
                              " indicados, por favor verifique!";
                      }
                  }
              }
              return dt;
      }

      /// <summary>
      /// Retornar los Headers para el Reporte de Precios.
      /// </summary>
      /// <param name="oEParametros"></param>
      private DataTable findHeaders(EParametros oEParametros) {

          try
          {
              oConn = new Conexion(1);
              dt = oConn.ejecutarDataTable("SP_GES_OPE_CONSULTA_PRECIO_V2",
                  oEParametros.getIdPlanning(),
                  oEParametros.getIdOficina(), 
                  oEParametros.getIdNodeCommercial(),
                  oEParametros.getIdPuntoDeVenta(),
                  oEParametros.getFechaInicio(), 
                  oEParametros.getFechaFin());
          }
          catch (Exception ex)
          {
              messages = "Ocurrio un Error: " + ex.Message;
          }

          return dt;
      }

      /// <summary>
      /// Retornar los Detalles por Cabecera para el Reporte de Precios
      /// </summary>
      /// <param name="id"></param>
      public DataTable findDetails(String idPuntoDeVenta, DateTime day) {
          try{
              oConn = new Conexion(1);
              dt = oConn.ejecutarDataTable("SP_GES_OPE_CONSULTA_PRECIO_DET_V2",
                  idPuntoDeVenta, 
                  day);
          }
          catch (Exception ex) {
              messages = "Ocurrio un Error: " + ex.Message.ToString();
          }

          return dt;
      }

      /// <summary>
      /// Valida que el formato de los parametros de Entrada sean 
      /// correctos.
      /// </summary>
      private void validarParametros(EParametros oEParametros)
      {
          // Validación del IdPlanning
          if (oEParametros.getIdPlanning().Equals("") ||
              oEParametros.getIdPlanning() == null){
              oEParametros.setIdPlanning("0");
          }

          // Validación del IdChannel
          if (oEParametros.getIdChannel().Equals("") ||
              oEParametros.getIdChannel() == null){
              oEParametros.setIdChannel("0");
          }

          // Validación del IdOficina
          if(oEParametros.getIdOficina() == null){
              oEParametros.setIdOficina(0);
          }

          // Validación del NodeCommercial
          if(oEParametros.getIdNodeCommercial() == null){
             oEParametros.setIdNodeCommercial(0);
          }

          // Validación del IdPuntoDeVenta
          if (oEParametros.getIdPuntoDeVenta().Equals("") ||
              oEParametros.getIdPuntoDeVenta() == null) {
              oEParametros.setIdPuntoDeVenta("0");
          }

          // Validación del idCategoria
          if (oEParametros.getIdCategoria().Equals("") ||
             oEParametros.getIdCategoria() == null) {
             oEParametros.setIdCategoria("0");
          }

          // Validación del idSubCategoria
          if (oEParametros.getIdSubCategoria().Equals("") ||
              oEParametros.getIdSubCategoria() == null) {
              oEParametros.setIdSubCategoria("0");
          }

          // Validación de idMarca
          if (oEParametros.getIdMarca().Equals("") ||
              oEParametros.getIdMarca() == null){
              oEParametros.setIdMarca("0");
          }

          // Validación del idProducto
          if (oEParametros.getIdProducto().Equals("") ||
             oEParametros.getIdProducto() == null) {
                 oEParametros.setIdProducto("0");
          }

          // Validación Fecha Ini
          if (oEParametros.getFechaInicio() == null) {
              messages = "Debe ingresar FECHA INICIAL";
          }

          // Validación Fecha Fin
          if (oEParametros.getFechaFin() == null) {
              messages = "Debe ingresar FECHA FIN";
          }

      }

      /// <summary>
      /// Verifica que se hayan ingresado todos los parametros de 
      /// entrada obligatorios. Se definen como campos obligatorios
      /// a los siguientes:
      /// 1.- idPlanning
      /// 2.- idChannel
      /// </summary>
      private void verificarObligatorios(EParametros oEParametros){
          if (oEParametros.getIdPlanning().Equals("0")) {
              messages = "No se ha seleccionado el idPlanning... ¡por" + 
              " favor, verificar!";
          }
          if (oEParametros.getIdChannel().Equals("0")) {
              messages += "No se ha seleccionado el idChannel... ¡por" +
                " favor, verificar!";
          }
      }

    }
}
