using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using System.Data;

namespace Lucky.Data.Common.Application
{
    public class DReports_Planning
    {
        private Conexion oCoon;
        public DReports_Planning() {
            oCoon = new Conexion();   
        }

        /// <summary>
        /// Author  : Pablo Salas A.
        /// Fecha   : 24/09/2012
        /// Descripcion: Obtener los Dias por Listar_Dia_Por_CodServicioCodCompaniaCodCanal_CodReporte_Anio_Mes_Periodo
        /// </summary>
        /// <param name="oE_Filtros"></param>
        /// <returns></returns>
        public List<string> Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo(E_Filtros oE_Filtros)
        {
            List<string> oListDias = new List<string>();
            try {
                DataTable dt = oCoon.ejecutarDataTable("UP_WEBXPLORA_OBTENERDIASXPERIODO_2"
                    , oE_Filtros.Cod_Servicio
                    , oE_Filtros.Cod_Compania
                    , oE_Filtros.Cod_Canal
                    , oE_Filtros.Cod_Reporte
                    , oE_Filtros.Cod_Anio ?? "0"
                    , oE_Filtros.Cod_Mes ?? "0"
                    , oE_Filtros.Cod_Periodo ?? "0");
                if (dt.Rows.Count > 0) {
                    for (int i = 0; i < dt.Rows.Count; i++) {
                       string dia = dt.Rows[i]["dia"].ToString();
                       oListDias.Add(dia);
                    }
                }
                return oListDias;
            }
            catch (Exception ex) {
                throw ex;
            }
        
        }

    }
}
