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
    /// Clase: OPE_Tipo_Reporte
    /// Creada Por: Carlos Marin
    /// Fecha de Creacion: 06/12/2011
    /// Descripcion: Define metodos para maestro OPE_Tipo_Reporte
    /// </summary>
   public class OPE_Tipo_Reporte
    {


       public DataTable RegistrarTipo_Reporte(string id_Tipo_Reporte, string TipoReporte_Descripcion, string company_id,
    string Tipo_levantamiento, string report_id, string cod_channel)
        {

            DOPE_Tipo_Reporte oDOPE_Tipo_Reporte = new DOPE_Tipo_Reporte();

            DataTable dt = oDOPE_Tipo_Reporte.RegistrarTipo_Reporte(id_Tipo_Reporte, TipoReporte_Descripcion, company_id,
                      Tipo_levantamiento, report_id, cod_channel);
            
            return dt;

        }

       public DataTable ConsultarTipo_Reporte(string TipoReporte_Descripcion, string company_id,
     string report_id)
       {

           DOPE_Tipo_Reporte oDOPE_Tipo_Reporte = new DOPE_Tipo_Reporte();

           DataTable dt = oDOPE_Tipo_Reporte.ConsultarTipo_Reporte(TipoReporte_Descripcion, company_id, report_id);

           return dt;

       }

       public DataTable ActualizarTipo_Reporte(string id_Tipo_Reporte, string TipoReporte_Descripcion,
     string company_id, string Tipo_levantamiento, string report_id, string cod_channel)
       {

           DOPE_Tipo_Reporte oDOPE_Tipo_Reporte = new DOPE_Tipo_Reporte();

           DataTable dt = oDOPE_Tipo_Reporte.ActualizarTipo_Reporte(id_Tipo_Reporte, TipoReporte_Descripcion, company_id, Tipo_levantamiento, report_id, cod_channel);

           return dt;

       }
    }
}
