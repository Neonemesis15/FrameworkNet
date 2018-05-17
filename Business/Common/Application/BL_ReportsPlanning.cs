using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
	public class BL_ReportsPlanning
	{
         /// <summary>
        /// Author  : Pablo Salas A.
        /// Fecha   : 24/09/2012
        /// Descripcion: Obtener los Dias por Listar_Dia_Por_CodServicioCodCompaniaCodCanal_CodReporte_Anio_Mes_Periodo
        /// </summary>
        /// <param name="oE_Filtros"></param>
        /// <returns></returns>
        public List<string> Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo(E_Filtros oE_Filtros)
        {
            DReports_Planning oDReports_Planning = new DReports_Planning();
            List<string> oListDias = new List<string>();
            try {
                oListDias = oDReports_Planning.Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo(oE_Filtros);
                return oListDias;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
	}
}
