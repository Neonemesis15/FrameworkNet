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
    public class D_Reporte_Pop
    {
         private Conexion oCoon;
         public D_Reporte_Pop()
            {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
            }

         public void Registrar_Pop_General_Lista(List<E_Reporte_Pop_General> oListReporte ) {
             foreach (E_Reporte_Pop_General oEReporte in oListReporte) {
                 Registrar_Pop_General(oEReporte);
             }
         
         }
         
         public string id = "";
         public void Registrar_Pop_General(E_Reporte_Pop_General oEReporte)
         {
             string id_reg_Cab = "";
             oCoon = new Conexion(2);
             //pSalas 06/03/2012 falta crear el Store Procedure
             id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_POP_02", 12, int.Parse(oEReporte.Person_id),
             oEReporte.Id_perfil ?? "", oEReporte.Id_equipo ?? "", oEReporte.Id_cliente ?? "",
             oEReporte.Id_categoria ?? "",
             oEReporte.Tipo_canal ?? "", oEReporte.Id_ptoVenta ?? "", oEReporte.FechaRegistro ?? "",
             oEReporte.Latitud ?? "", oEReporte.Longitud ?? "",
             oEReporte.Origen ?? "", oEReporte.Comentario ?? "", id_reg_Cab);

             foreach (E_Reporte_Pop_General_Detalle detalle in oEReporte.DetallePop)
                 Registrar_Pop_General_Detalle(detalle);

             //return oE_Reporte_Presencia;

             //oListE_Reporte_Presencia.Add(oE_Reporte_Presencia);

             //return oListE_Reporte_Presencia;
         }
         private void Registrar_Pop_General_Detalle(E_Reporte_Pop_General_Detalle detalle)
         {
             oCoon = new Conexion(2);
             E_Reporte_Presencia_General_Detalle oE_Reporte_Presencia_Detalle = new E_Reporte_Presencia_General_Detalle();

             //DataTable dt = 
             oCoon.ejecutarDataTable("STP_JVM_INSERTAR_POP_02_DETALLE",
             Convert.ToInt64(id), detalle.Id_marca ?? "", Convert.ToBoolean(detalle.Presencia.ToString() ?? ""),
             Convert.ToBoolean(detalle.Requerido.ToString() ?? ""), detalle.Comentario ?? "", detalle.Fecha_ini ?? "",
             detalle.Fecha_fin ?? "", DecodeFrom64(detalle.Foto ?? ""), detalle.Id_pop ?? "");
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

    }
}
