using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;
using System.Configuration;

namespace Lucky.Data.Common.JavaMovil
{
     public class D_Reporte_Visibilidad_Competencia
    {
         private Conexion oCoon; 
         public D_Reporte_Visibilidad_Competencia()
            {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
            }

         #region AppMovil Lucky
         public void Registrar_Visibilidad_Competencia(List<E_Reporte_Visibilidad_Competencia> oListReporte_Visibilidad_Competencia)
         {
             foreach (E_Reporte_Visibilidad_Competencia oReporte_Visi_Competencia in oListReporte_Visibilidad_Competencia)
             {
                 Registrar_Visibilidad_Competencia(oReporte_Visi_Competencia);
                }
            }
         public string id = "";

         public void Registrar_Visibilidad_Competencia(E_Reporte_Visibilidad_Competencia oEReporteVisibilidad_aux)
         {
             string id_reg_visibicompe = "";
             oCoon = new Conexion(2);
             //Crear un Store procedure para InsertarPresencia con nuevo AppMovil
             id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_VISIBILIDAD_COMPETENCIA", 14, int.Parse(oEReporteVisibilidad_aux.Person_id ?? ""),
              oEReporteVisibilidad_aux.Perfil_id ?? "", oEReporteVisibilidad_aux.Equipo_id ?? "", oEReporteVisibilidad_aux.Cliente_id ?? "",
             oEReporteVisibilidad_aux.ClientePDV_Code ?? "",
             oEReporteVisibilidad_aux.Categoria_id ?? "", oEReporteVisibilidad_aux.Marca_id ?? "", oEReporteVisibilidad_aux.FechaRegistro ?? "",
            oEReporteVisibilidad_aux.Latitud ?? "", oEReporteVisibilidad_aux.Longitud ?? "", oEReporteVisibilidad_aux.OrigenCoordenada ?? "",
            oEReporteVisibilidad_aux.TipoCanal ?? "",
             oEReporteVisibilidad_aux.Comentario ?? "", oEReporteVisibilidad_aux.Id_empresacomeptidora ?? "", id_reg_visibicompe);




             foreach (E_Reporte_Visibilidad_Competencia_Detalle detalle in oEReporteVisibilidad_aux.VisibilidadDetalle)
                 Registrar_Visibilidad_Competencia_Detalle(detalle);

             //return oE_Reporte_Presencia;

             //oListE_Reporte_Presencia.Add(oE_Reporte_Presencia);

             //return oListE_Reporte_Presencia;
         }
         private void Registrar_Visibilidad_Competencia_Detalle(E_Reporte_Visibilidad_Competencia_Detalle detalle)
         {
             

             oCoon = new Conexion(2);
             E_Reporte_Visibilidad_Competencia_Detalle oE_Reporte_VisiCompe_Detalle = new E_Reporte_Visibilidad_Competencia_Detalle();

             //DataTable dt = 
             oCoon.ejecutarDataTable("STP_JVM_INSERTAR_VISIBILIDAD_COMPETENCIA_DETALLE",
             Convert.ToInt64(id), detalle.Id_pop ?? "", detalle.Comentario ?? "", DecodeFrom64(detalle.Imagen ?? ""));

             //return oE_Reporte_Presencia_Detalle;

         }

         #region metodos Util
         //Convierte a byte[] un string Add 13/01/2012
         public static byte[] DecodeFrom64(String encodedData)
         {

             byte[] encodedDataAsBytes

                 = System.Convert.FromBase64String(encodedData);
             return encodedDataAsBytes;

         }
         #endregion
         #endregion

        #region AppMovil Movistar

         /// <summary>
         /// Descripción    : Registrar Reporte de Visiblidad Competencia
         /// Fecha          : 21/05/2012 - PSA
         /// </summary>
         /// <param name="oListReporte_Visibilidad_Competencia"></param>
         /// <param name="App_Envia"></param>

         string error = string.Empty;

         public string Registrar_VisCompetencia_Mov(List<E_Reporte_VisCompentencia_Mov> oListReporte_Visibilidad_Competencia, int App_Envia)
         {
             try
             {
                 foreach (E_Reporte_VisCompentencia_Mov oReporte_Visi_Competencia in oListReporte_Visibilidad_Competencia)
                 {
                     error += Registrar_VisCompetencia_Mov_Cabecera(oReporte_Visi_Competencia, App_Envia);
                 }
             }
             catch (Exception ex) {
                 error += error + ex.Message;
                 throw ex;
             }
             return error;
         }
         private string Registrar_VisCompetencia_Mov_Cabecera(E_Reporte_VisCompentencia_Mov oEReporte, int App_Envia)
         {
             try
             {
                 string id_reg_visibicompe = "";
                 oCoon = new Conexion(3);
                 id_reg_visibicompe = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_VISIBILIDAD_COMPETENCIA", 13,
                  int.Parse(oEReporte.Cod_Persona.ToString() ?? ""),
                  oEReporte.Cod_Equipo, oEReporte.Cod_Compania, oEReporte.Cod_PtoVenta, oEReporte.Cod_Categoria,
                  oEReporte.Cod_Marca, oEReporte.Cod_Competidora, oEReporte.Fec_Registro, oEReporte.Latitud,
                  oEReporte.Longitud, oEReporte.Origen, oEReporte.Comentario, App_Envia, id_reg_visibicompe);

                 foreach (E_Reporte_VisCompentencia_Mov_Detalle detalle in oEReporte.Detalle)
                     error += Registrar_VisCompetencia_Mov_Detalle(detalle, id_reg_visibicompe);
             }
             catch (Exception ex) {
                 error += ex.Message;
                 throw ex;
             }
             return error;

         }
         private string Registrar_VisCompetencia_Mov_Detalle(E_Reporte_VisCompentencia_Mov_Detalle detalle, string Id_Reg_VisComp)
         {
             try
             {
                 oCoon = new Conexion(3);
                 oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_VISIBILIDAD_COMPETENCIA_DETALLE", Id_Reg_VisComp, detalle.Cod_MatApoyo,
                     detalle.Comentario, detalle.Nombre_Foto);
                 error += string.Empty;
             }
             catch (Exception ex) {
                 error += ex.Message;
                 throw ex;
             }
             return error;
         }

        #endregion

    }
}
