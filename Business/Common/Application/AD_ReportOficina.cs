using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;


namespace Lucky.Business.Common.Application
{
    /// Clase: AD_ReportOficina
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 04/11/2010
    /// Description: Establece los metodos para operar informacion relacionada con las Ciudades almacenadas desde el maestro de asignación de Informes a Usuarios.
    /// Requerimiento No:
    /// </summary>
    /// 
  public class AD_ReportOficina
    {
      public AD_ReportOficina()
        {
            //Se define el constructor por defecto
        }
      /// <summary>
      /// Permite registrar asociaciones de Reporte a Oficinas.
      /// 04/11/2010 Magaly Jiménez
      /// </summary>
      /// <param name="iReport_Id"></param>
      /// <param name="lcod_Oficina"></param>
      /// <param name="bReport_Oficina_Status"></param>
      /// <param name="sReport_Oficina_CreateBy"></param>
      /// <param name="tReport_Oficina_DateBy"></param>
      /// <param name="sReport_Oficina_ModiBy"></param>
      /// <param name="tReport_Oficina_DateModiBy"></param>
      /// <returns></returns>
      public EAD_Report_Oficina RegistrarReportOficinas(int iReport_Id, long lcod_Oficina, bool bReport_Oficina_Status,
         string sReport_Oficina_CreateBy, DateTime tReport_Oficina_DateBy, string sReport_Oficina_ModiBy, DateTime tReport_Oficina_DateModiBy)
      {
          DAD_ReportOficina odrROficina = new DAD_ReportOficina();
          EAD_Report_Oficina oeReportOficina=odrROficina.RegistrarReportsOficina(iReport_Id, lcod_Oficina, bReport_Oficina_Status,
           sReport_Oficina_CreateBy, tReport_Oficina_DateBy, sReport_Oficina_ModiBy, tReport_Oficina_DateModiBy);


          odrROficina = null;
          return oeReportOficina;
      }
      /// <summary>
      /// Permite Actualizar asociaciones de Reporte a Oficinas.
      /// 04/11/2010 Magaly Jiménez
      /// </summary>
      /// <param name="lid_ReportOficina"></param>
      /// <param name="iReport_Id"></param>
      /// <param name="lcod_Oficina"></param>
      /// <param name="bReport_Oficina_Status"></param>
      /// <param name="sReport_Oficina_ModiBy"></param>
      /// <param name="tReport_Oficina_DateModiBy"></param>
      /// <returns></returns>
      public EAD_Report_Oficina ActualizarReOficina(int iReport_Id, long lcod_Oficina, bool bReport_Oficina_Status,
            string sReport_Oficina_ModiBy, DateTime tReport_Oficina_DateModiBy)
      {
          DAD_ReportOficina odaRO = new DAD_ReportOficina();
          EAD_Report_Oficina oeaRO=odaRO.Actualizar_ReportOficina(iReport_Id, lcod_Oficina, bReport_Oficina_Status,
            sReport_Oficina_ModiBy, tReport_Oficina_DateModiBy);
          odaRO = null;
          return oeaRO;



      }
    }
}
