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
    /// Business Class para el Reporte Precio
    /// </summary>
   public class OPE_REPORTE_PRECIO
    {
       /// <summary>
       /// Constructor
       /// </summary>
       public OPE_REPORTE_PRECIO(){ }

       // DataTable para guardar el Resultado
       DataTable dt = new DataTable();

       // Variable para guardar los Errores
       String messages = "";
       
       // Instanciar a la Capa Data para el Reporte
       // de Precio
       DOPE_REPORTE_PRECIO oDOPE_REPORTE_PRECIO =
               new DOPE_REPORTE_PRECIO();

       /// <summary>
       /// Retorna los mensajes de Error
       /// </summary>
       /// <returns></returns>
       public String getMessages(){
           return messages;
       }

       /// <summary>
       /// Registar Precio para AppMobile
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
           string sFEC_REG_CEL, string sLATITUD, string sLONGITUD, 
           char cORIGEN, string sOBSERVACION)
       {
           EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = 
               oDOPE_REPORTE_PRECIO.RegistrarReportePrecio(iPerson_id, 
               sID_PERFIL, sID_EQUIPO, sID_CLIENTE, sID_PTOVENTA, 
               sID_CATEGORIA, sID_MARCA, sID_FAMILIA, sID_SUBFAMILIA, 
               sTIPO_CANAL, sFEC_REG_CEL, sLATITUD, sLONGITUD, cORIGEN, 
               sOBSERVACION);
                      
           return oEOPE_REPORTE_PRECIO;

       }

       /// <summary>
       /// Registrar Reporte Precio Detalle App Mobile
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
       public EOPE_REPORTE_PRECIO RegistrarReportePrecio_Detalle(
           int iID_REG_PRECIO, string sID_PRODUCTO, string sPRECIO_LISTA, 
           string sPRECIO_REVENTA, string sPRECIO_OFERTA, string sPVP, 
           string sPRECIO_COSTO, string sPRECIO_MIN, string sPRECIO_MAX, 
           string sPRECIO_REGULAR, char cMOTIVO_OBS)
       {
           EOPE_REPORTE_PRECIO oEOPE_REPORTE_PRECIO = 
               oDOPE_REPORTE_PRECIO.RegistrarReportePrecio_Detalle(
               iID_REG_PRECIO, sID_PRODUCTO, sPRECIO_LISTA, 
               sPRECIO_REVENTA, sPRECIO_OFERTA, sPVP, sPRECIO_COSTO, 
               sPRECIO_MIN, sPRECIO_MAX, sPRECIO_REGULAR, cMOTIVO_OBS);
           
           return oEOPE_REPORTE_PRECIO;

       }

       /// <summary>
       /// Buscar los registros para Precios
       /// aplicando los Filtros.
       /// </summary>
       /// <param name="idPlanning"></param>
       /// <param name="idChannel"></param>
       /// <param name="idOficina"></param>
       /// <param name="idNodeCommercial"></param>
       /// <param name="idPuntoDeVenta"></param>
       /// <param name="idCategoria"></param>
       /// <param name="idMarca"></param>
       /// <param name="idProducto"></param>
       /// <param name="idSubCategoria"></param>
       /// <param name="idPerson"></param>
       /// <param name="fechaIni"></param>
       /// <param name="fechaFin"></param>
       /// <returns></returns>
       public DataTable find(String idPlanning, String idChannel,
          int idOficina, int idNodeCommercial,
          String idPuntoDeVenta, String idCategoria,
          String idMarca, String idProducto, String idSubCategoria,
          int idPerson, DateTime fechaIni, DateTime fechaFin) {
           try{
               dt = oDOPE_REPORTE_PRECIO.find(idPlanning, idChannel, idOficina,
                      idNodeCommercial, idPuntoDeVenta, idCategoria, idMarca,
                      idProducto, idSubCategoria, idPerson, fechaIni,
                      fechaFin);
               // Verificar si devuelve registros
               if (dt.Rows.Count <= 0) {
                   messages = "No se encontraron registros para la consulta" +
                       " solicitada, ¡Por favor Verifique!";
               }
               // Verificar que no existan errores
                if (!oDOPE_REPORTE_PRECIO.getMessages().Equals("")){
                    messages = oDOPE_REPORTE_PRECIO.getMessages();
                }
           }
           catch (Exception ex) {
               messages = "Ocurrio un Error:" + ex.ToString();
           }

           return dt;

       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="idPlanning"></param>
       /// <param name="idChannel"></param>
       /// <param name="idOficina"></param>
       /// <param name="idNodeCommercial"></param>
       /// <param name="idPuntoDeVenta"></param>
       /// <param name="idCategoria"></param>
       /// <param name="idMarca"></param>
       /// <param name="idProducto"></param>
       /// <param name="idSubCategoria"></param>
       /// <param name="idPerson"></param>
       /// <param name="fechaIni"></param>
       /// <param name="fechaFin"></param>
       /// <returns></returns>
       public DataTable findDummy(String idPlanning, String idChannel,
       int idOficina, int idNodeCommercial,
       String idPuntoDeVenta, String idCategoria,
       String idMarca, String idProducto, String idSubCategoria,
       int idPerson, DateTime fechaIni, DateTime fechaFin){

           // Crear el Objeto DataTable
           DataTable dt = new DataTable();
           
           // Definir las Columnas
           dt.Columns.Add("rowNumber", typeof(int));
           dt.Columns.Add("repPrecioCod", typeof(string));
           dt.Columns.Add("oficinaName", typeof(string));
           dt.Columns.Add("ptoVentaCode", typeof(string));
           dt.Columns.Add("ptoVentaName", typeof(string));
           dt.Columns.Add("fecReg", typeof(string));
           dt.Columns.Add("cantReg", typeof(int));

           //Llenar información
           dt.Rows.Add(1, "04-01-2019|PDV001","Lima","PDV001",
           "Market Pepito S.A.C.", "04-01-2019",15);
           dt.Rows.Add(2, "04-01-2019|PDV002", "Lima", "PDV002",
           "Market Juanito S.A.C.", "04-01-2019", 20);
           dt.Rows.Add(3, "04-01-2019|PDV003", "Lima", "PDV003",
           "Market Mary S.A.C.", "04-01-2019", 18);
           dt.Rows.Add(4, "04-01-2019|PDV004", "Lima", "PDV004",
           "Market Fiorela S.A.C.", "04-01-2019", 22);
           dt.Rows.Add(5, "04-01-2019|PDV005", "Lima", "PDV005",
           "Market Lukitas S.A.C.", "04-01-2019", 100);
           dt.Rows.Add(6, "04-01-2019|PDV006", "Lima", "PDV006",
           "Market Matei S.A.C.", "04-01-2019", 98);

           return dt;
       }
      /// <summary>
      /// Retornar los Detalles por Cabecera para el Reporte de Precios
      /// </summary>
      /// <param name="id"></param>
       public DataTable findDetails(String idPuntoDeVenta, 
       DateTime day) {
           try{
               
               dt = oDOPE_REPORTE_PRECIO.findDetails(idPuntoDeVenta, day);
               
               // Verificar si devuelve registros
               if (dt.Rows.Count <= 0) {
                   messages = "No se encontraron registros para la consulta" +
                           " solicitada, ¡Por favor Verifique!";
               }
               
               // Verificar que no existan errores
               if (!oDOPE_REPORTE_PRECIO.getMessages().Equals("")) {
                   messages = oDOPE_REPORTE_PRECIO.getMessages();
               }

           }
           catch (Exception ex) {
               messages = "Ocurrio un Error: " + ex.Message.ToString();
           }
           return dt;
       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="idPuntoDeVenta"></param>
       /// <param name="day"></param>
       /// <returns></returns>
       public DataTable findDetailsDummy(String idPuntoDeVenta,
       DateTime day) {
           // Crear el Objeto DataTable
           DataTable dt = new DataTable();
           
           // Definir las Columnas
           dt.Columns.Add("Id", typeof(int));
           dt.Columns.Add("Category_Name", typeof(string));
           dt.Columns.Add("Brand_Name", typeof(string));
           dt.Columns.Add("Id_Producto", typeof(string));
           dt.Columns.Add("Product_Name", typeof(string));
           dt.Columns.Add("Precio_Lista", typeof(decimal));
           dt.Columns.Add("Precio_Reventa", typeof(decimal));
           dt.Columns.Add("Precio_Oferta", typeof(decimal));
           dt.Columns.Add("Precio_PVP", typeof(decimal));
           dt.Columns.Add("Precio_Costo", typeof(decimal));
           dt.Columns.Add("Precio_Regular", typeof(decimal));
           dt.Columns.Add("Precio_Min", typeof(decimal));
           dt.Columns.Add("Precio_Max", typeof(decimal));
           dt.Columns.Add("Observacion", typeof(string));
           dt.Columns.Add("Validado", typeof(bool));
           dt.Columns.Add("CreateBy", typeof(string));
           dt.Columns.Add("DateBy", typeof(DateTime));
           dt.Columns.Add("ModiBy", typeof(string));
           dt.Columns.Add("DateModiBy", typeof(DateTime));

           // DateTime fecha = DateTime.Now;

           //Llenar información
           dt.Rows.Add(1, "Aceites", "Primor", "SKU001",
               "Aceite Primor 1L",
               7.70, 5.30, 8.99, 4.88, 5.99, 5.44, 3.44, 4.33,
               "Ninguna", 1, "cmarin", DateTime.Now, "cmarin",
               DateTime.Now);

            dt.Rows.Add(2, "Aceites", "Primor", "SKU002",
                "Aceite Primor 2L",
                7.70, 5.30, 8.99, 4.88, 5.99, 5.44, 3.44, 4.33,
                "Ninguna", 1, "cmarin", DateTime.Now, "cmarin",
                DateTime.Now);

            dt.Rows.Add(3, "Aceites", "Primor", "SKU003",
                "Aceite Primor 3L",
                7.70, 5.30, 8.99, 4.88, 5.99, 5.44, 3.44, 4.33,
                "Ninguna", 1, "cmarin", DateTime.Now, "cmarin",
                DateTime.Now);

            dt.Rows.Add(4, "Aceites", "Primor", "SKU004",
                "Aceite Primor 4L",
                7.70, 5.30, 8.99, 4.88, 5.99, 5.44, 3.44, 4.33,
                "Ninguna", 1, "cmarin", DateTime.Now, "cmarin",
                DateTime.Now);

            dt.Rows.Add(5, "Aceites", "Primor", "SKU005",
                "Aceite Primor 5L",
                7.70, 5.30, 8.99, 4.88, 5.99, 5.44, 3.44, 4.33,
                "Ninguna", 1, "cmarin", DateTime.Now, "cmarin",
                DateTime.Now);

           return dt;
       }
   }
}
