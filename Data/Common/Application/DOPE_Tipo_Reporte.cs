using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:DOPE_Tipo_Reporte
    /// Creada Por: Carlos Marín
    /// Fecha de Creacion: 06/12/2011
    /// Descripcion: Define los Metodos transaccionales para el maestro OPE_Tipo_Reporte.
    /// </summary>
   public  class DOPE_Tipo_Reporte
    {
         private Conexion oConn;
         public DOPE_Tipo_Reporte()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;

        }


         /// <summary>
         ///Metodo para Registrar Tipo_Reporte
         /// </summary>
         public DataTable RegistrarTipo_Reporte(string id_Tipo_Reporte, string TipoReporte_Descripcion, string company_id,
     string Tipo_levantamiento, string report_id, string cod_channel)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_REGISTRAR_TIPO_REPORTE", id_Tipo_Reporte, TipoReporte_Descripcion, company_id,
                      Tipo_levantamiento, report_id, cod_channel);


             return dt;


         }

       

          /// <summary>
         ///Metodo para Consultar Tipo_Reporte
         /// </summary>
         public DataTable ConsultarTipo_Reporte(string TipoReporte_Descripcion, string company_id,
     string report_id)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_CONSULTAR_TIPO_REPORTE", TipoReporte_Descripcion, company_id, report_id);


             return dt;


         }

         /// <summary>
         ///Metodo para Actualizar Tipo_Reporte
         /// </summary>
         public DataTable ActualizarTipo_Reporte(string id_Tipo_Reporte, string TipoReporte_Descripcion,
     string company_id ,string Tipo_levantamiento, string report_id, string cod_channel)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_ACTUALIZAR_TIPO_REPORTE", id_Tipo_Reporte, TipoReporte_Descripcion, company_id, Tipo_levantamiento, report_id, cod_channel);


             return dt;


         }



    }
}
