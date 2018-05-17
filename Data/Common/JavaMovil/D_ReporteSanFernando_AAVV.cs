using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_ReporteSanFernando_AAVV
    {
        private Conexion oCoon;

        public D_ReporteSanFernando_AAVV()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

        #region AppMovil Movistar


        public string Registrar_ReporteSanFernando_AAVV_Mov(List<E_Reporte_Stock_Mov> oListaRepStock_Mov, 
            List<E_Reporte_Precio_Mov> oListaRepPrecio_Mov, List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov,
            List<E_Reporte_Incidencia_Mov> oListaRepIncidencia_Mov, E_Visita_Mov oE_Visita_Mov, int AppEnvia)
        {
            D_Reporte_Stock oD_Reporte_Stock = new D_Reporte_Stock();
            D_Reporte_Precio oD_Reporte_Precio = new D_Reporte_Precio();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Reporte_Incidencia oD_Reporte_Incidencia = new D_Reporte_Incidencia();
            D_Visita oD_Visita = new D_Visita();

            string mensaje_Stock = string.Empty;
            string mensaje_Precio = string.Empty;
            string mensaje_Fotografico = string.Empty;
            string mensaje_Incidencia = string.Empty;
            string mensaje_Visita = string.Empty;
            string mensaje_Final = string.Empty;
            try
            {
                mensaje_Stock = oD_Reporte_Stock.Registrar_Reporte_Stock_Mov(oListaRepStock_Mov, AppEnvia.ToString());
                mensaje_Precio = oD_Reporte_Precio.Registrar_Precio_Mov(oListaRepPrecio_Mov, AppEnvia.ToString());
                mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListaRepFotografico_Mov, AppEnvia);
                mensaje_Incidencia = oD_Reporte_Incidencia.Registrar_Incidencia_Mov(oListaRepIncidencia_Mov, AppEnvia.ToString());
                mensaje_Visita = oD_Visita.RegistrarVisita_Mov(oE_Visita_Mov);

                if (!mensaje_Stock.Equals(""))
                    mensaje_Stock = "Hubo Errores en Reporte Ventas. ";
                if (!mensaje_Precio.Equals(""))
                    mensaje_Precio = "Hubo Errores en Reporte Precios. ";
                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Hubo Errores en Reporte Fotográfico. ";
                if (!mensaje_Incidencia.Equals(""))
                    mensaje_Incidencia = "Hubo Errores en Reporte Incidencia. ";
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Hubo Errores en Registro de Visita. ";
            }
            catch (Exception ex) {
                throw ex;
            }
            return mensaje_Final = mensaje_Stock + mensaje_Precio + mensaje_Fotografico + mensaje_Incidencia + mensaje_Visita;
        }
        #endregion
    }
}
