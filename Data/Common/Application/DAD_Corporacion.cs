using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{    /// <summary>
    /// Clase:DAD_Corporacion
    /// Creada Por: Carlos Marín
    /// Fecha de Creacion: 16/08/2011
    /// Descripcion: Define los Metodos transaccionales para el maestro Corporación.
    /// </summary>
   public class DAD_Corporacion
    {
         private Conexion oConn;
         public DAD_Corporacion()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;

        }

         /// <summary>
         ///Metodo para Registrar Corporaciones
         /// </summary>

         public EAD_Corporacion RegistrarCorporacion(string scorp_name, bool bcorp_status, string scorp_createby,
     DateTime tcorp_datecreateby, string scorp_modifyby, DateTime tcorp_datemodiby)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_REGISTRAR_CORPORACION", scorp_name, bcorp_status, scorp_createby,
                      tcorp_datecreateby, scorp_modifyby, tcorp_datemodiby);
             EAD_Corporacion oEAD_Corporacion = new EAD_Corporacion();

             oEAD_Corporacion.corp_name = scorp_name;
             oEAD_Corporacion.corp_status = bcorp_status;
             oEAD_Corporacion.corp_createby = scorp_createby;
             oEAD_Corporacion.corp_datecreateby = tcorp_datecreateby;
             oEAD_Corporacion.corp_modifyby = scorp_modifyby;
             oEAD_Corporacion.corp_datemodiby = tcorp_datemodiby;
             return oEAD_Corporacion;


         }
         /// <summary>
         ///Metodo para Consultar Corporaciones
         /// </summary>
         public DataTable ConsultarCorporacion(int icorp_id)
         {

             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_CONSULTAR_CORPORACION", icorp_id);
             EAD_Distribuidora oecDex = new EAD_Distribuidora();

             if (dt != null)
             {
                 if (dt.Rows.Count > 0)
                 {
                     for (int i = 0; i <= dt.Rows.Count - 1; i++)
                     {
                         oecDex.Id_Dex = Convert.ToInt32(dt.Rows[i]["corp_id"].ToString().Trim());
                         oecDex.Dex_Name = dt.Rows[i]["corp_name"].ToString().Trim();
                         oecDex.Dex_Status = Convert.ToBoolean(dt.Rows[i]["corp_status"].ToString().Trim());
                         oecDex.Dex_CreateBy = dt.Rows[i]["corp_createby"].ToString().Trim();
                         oecDex.Dex_DateBy = Convert.ToDateTime(dt.Rows[i]["corp_datecreateby"].ToString().Trim());
                         oecDex.Dex_ModiBy = dt.Rows[i]["corp_modifyby"].ToString().Trim();
                         oecDex.Dex_DateModiBy = Convert.ToDateTime(dt.Rows[i]["corp_datemodiby"].ToString().Trim());
                     }
                 }
                 return dt;

             }
             else
             {

                 return null;
             }
         }

         public DataTable ConsultarCorporacionxNombre(string scorp_name)
         {

             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_CONSULTAR_CORPORACIONxNombre", scorp_name);
             EAD_Distribuidora oecDex = new EAD_Distribuidora();

             if (dt != null)
             {
                 if (dt.Rows.Count > 0)
                 {
                     for (int i = 0; i <= dt.Rows.Count - 1; i++)
                     {
                         oecDex.Id_Dex = Convert.ToInt32(dt.Rows[i]["corp_id"].ToString().Trim());
                         oecDex.Dex_Name = dt.Rows[i]["corp_name"].ToString().Trim();
                         oecDex.Dex_Status = Convert.ToBoolean(dt.Rows[i]["corp_status"].ToString().Trim());
                         oecDex.Dex_CreateBy = dt.Rows[i]["corp_createby"].ToString().Trim();
                         oecDex.Dex_DateBy = Convert.ToDateTime(dt.Rows[i]["corp_datecreateby"].ToString().Trim());
                         oecDex.Dex_ModiBy = dt.Rows[i]["corp_modifyby"].ToString().Trim();
                         oecDex.Dex_DateModiBy = Convert.ToDateTime(dt.Rows[i]["corp_datemodiby"].ToString().Trim());
                     }
                 }
                 return dt;

             }
             else
             {

                 return null;
             }
         }
         /// <summary>
         ///Metodo para Actualizar Corporaciones
         /// </summary>
         public EAD_Corporacion ActualizarCorporacion(int icorp_id, string scorp_name, bool bcorp_status, string scorp_modifyby, DateTime tcorp_datemodiby)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_ACTUALIZAR_CORPORACION", icorp_id, scorp_name, bcorp_status, scorp_modifyby, tcorp_datemodiby);
             EAD_Corporacion oEAD_Corporacion = new EAD_Corporacion();

             oEAD_Corporacion.corp_id = icorp_id;
             oEAD_Corporacion.corp_name = scorp_name;
             oEAD_Corporacion.corp_status = bcorp_status;
             oEAD_Corporacion.corp_modifyby = scorp_modifyby;
             oEAD_Corporacion.corp_datemodiby = tcorp_datemodiby;
             return oEAD_Corporacion;
         }
    }
}
