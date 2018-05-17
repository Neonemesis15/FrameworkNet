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
    public class D_Reporte_Mat_Apoyo
    {
         private Conexion oCoon;
         public D_Reporte_Mat_Apoyo()
            {

            }
        /// <summary>
        /// Descripción : Registrar Material de Apoyo App Movistar
        /// Fecha       : 21/05/2012 - PSA
        /// </summary>
        /// <param name="oListReporte"></param>
        /// <param name="AppEnvia"></param>
         string error = string.Empty;
         public string Registrar_Material_Apoyo_Mov(List<E_Reporte_Mat_Apoyo_Mov> oListReporte, int AppEnvia)
         {
             try
             {
                 oCoon = new Conexion(3);

                 foreach (E_Reporte_Mat_Apoyo_Mov oEReporte in oListReporte)
                 {
                     Registrar_Material_Apoyo_Mov_Cabecera(oEReporte, AppEnvia);

                     //foreach (E_Reporte_Mat_Apoyo_Mov_Detalle oEReporte_Detalle in oEReporte.Detalle)
                     //{
                     //    string result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_MATERIAL_APOYO",
                     //        5,
                     //        oEReporte.Cod_Compania,
                     //        oEReporte.Cod_Equipo,
                     //        oEReporte.Cod_PtoVenta,
                     //        oEReporte.Fec_Registro,
                     //        oEReporte_Detalle.Cod_MatApoyo, "");

                     //    if (result == "1")
                     //    {
                     //        Registrar_Material_Apoyo_Mov_Cabecera(oEReporte, AppEnvia);
                     //    }
                     //    else if (result == "0")
                     //    {
                     //        error += "No existe periodo creado para esta fecha de registro";
                     //        break;
                     //    }
                     //    else
                     //    {
                     //        error += result + Environment.NewLine;
                     //    }
                     //}
                 }
             }
             catch (Exception ex) {
                  error = error + ex.Message;
                  throw ex;
             }
             return error;
         }
         
         public string id = "";
         private void Registrar_Material_Apoyo_Mov_Cabecera(E_Reporte_Mat_Apoyo_Mov oEReporte, int AppEnvia)
         {
             string id_reg_Cab = "";
             oCoon = new Conexion(3);
             try
             {
                 id = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_MAT_APOYO", 11, oEReporte.Cod_Persona,
                     oEReporte.Cod_Equipo, oEReporte.Cod_Compania, oEReporte.Cod_PtoVenta, oEReporte.Cod_Categoria,
                     oEReporte.Fec_Registro, oEReporte.Latitud, oEReporte.Longitud, oEReporte.Origen,
                     oEReporte.Comentario, AppEnvia, id_reg_Cab);

                 foreach (E_Reporte_Mat_Apoyo_Mov_Detalle detalle in oEReporte.Detalle)
                     Registrar_Material_Apoyo_Mov_Detalle(detalle, id);
             }
             catch (Exception ex) {
                 throw ex;
             }
         }
         private void Registrar_Material_Apoyo_Mov_Detalle(E_Reporte_Mat_Apoyo_Mov_Detalle detalle, string Id_Reg_MatApoyo)
         {
             try
             {
                 oCoon = new Conexion(3);
                 oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_MAT_APOYO_DETALLE",
                 Convert.ToInt64(id), detalle.Cod_MatApoyo ?? null, detalle.Presencia ?? null,
                 detalle.Cod_Marca ?? null, detalle.Comentario ?? null, detalle.Fecha_Ini ?? null,
                 detalle.Fecha_Fin ?? null, detalle.Nombre_Foto ?? null,
                 detalle.Cantidad ?? null);
                 error += string.Empty;
             }
             catch (Exception ex) {
                 throw ex;
             }
         }
    }
}
