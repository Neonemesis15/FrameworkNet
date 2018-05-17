using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Company
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 01/06/2009
    /// Description: Establece los metodos para operar informacion relacionada con Reportes Lucky
    /// Requerimiento No:
    /// </summary>
    /// 
   public class TypeReports
    {
       public TypeReports()
        {
            //Se define el constructor por defecto
        }

       public ETypeReports registrarTipoReporte(string sTypeReport_Name, bool bTypeReport__Status, string sTypeReport_CreateBy, DateTime tTypeReport_DateBy, string sTypeReport_ModiBy,
    DateTime tTypeReport_DateModiBy)
       {
           DTypeReports oDTypeReports = new DTypeReports();
           ETypeReports oETypeReports = oDTypeReports.registrarTipoReporte(sTypeReport_Name, bTypeReport__Status, sTypeReport_CreateBy, tTypeReport_DateBy, sTypeReport_ModiBy, tTypeReport_DateModiBy);

           oDTypeReports = null;
           return oETypeReports;
       }

       public DataTable BuscarInforme(int iid_TypeReport)
       {
           Lucky.Data.Common.Application.DTypeReports oDTypeReports = new Lucky.Data.Common.Application.DTypeReports();
           EReports oeInforme = new EReports();
           DataTable dtTipoTipoReporte = oDTypeReports.ConsultarTiposReporteXcod(iid_TypeReport);
           oDTypeReports = null;
           return dtTipoTipoReporte;
       }


    }
}
