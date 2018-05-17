using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data;
namespace Lucky.Data.Common.JavaMovil
{
    /// <summary>
    /// Descripcion : Reporte de Capacitacion para App Movil Movistar
    /// Fecha       : 13/07/2012 ING. DUEB
    /// </summary>
    public class D_Reporte_Capacitacion
    {
        private Conexion oCoon;

        public D_Reporte_Capacitacion()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

        public string Registrar_Reporte_Capacitacion_Mov(List<E_Reporte_Capacitacion_Mov> oListaReporte_Capacitacion_Mov, int AppEnvio)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Capacitacion_Mov oE_Reporte_Capacitacion_Mov in oListaReporte_Capacitacion_Mov)
                {
                    Registrar_Reporte_Capacitacion_Cabecera_Mov(oE_Reporte_Capacitacion_Mov, AppEnvio);
                    error = error + "";
                }
            }
            catch (Exception ex)
            {
                error = error + ex.Message;
                throw ex;
            }

            return error;
        }

        private void Registrar_Reporte_Capacitacion_Cabecera_Mov(E_Reporte_Capacitacion_Mov oE_Reporte_Capacitacion_Mov, int appEnvia)
        {

            string id_reg_Capacitacion = "";
            try
            {
                oCoon = new Conexion(3);
                id_reg_Capacitacion = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_CAPACITACION", 12,
                    oE_Reporte_Capacitacion_Mov.Cod_Persona,
                    oE_Reporte_Capacitacion_Mov.Cod_Equipo,
                    oE_Reporte_Capacitacion_Mov.Cod_Compania,
                    oE_Reporte_Capacitacion_Mov.Cod_PtoVenta ,
                    oE_Reporte_Capacitacion_Mov.Cod_Categoria ?? null,
                    oE_Reporte_Capacitacion_Mov.Cod_Marca ?? null,
                    oE_Reporte_Capacitacion_Mov.Fecha_Registro,
                    oE_Reporte_Capacitacion_Mov.Latitud ?? null,
                    oE_Reporte_Capacitacion_Mov.Longitud ?? null,
                    oE_Reporte_Capacitacion_Mov.Origen ?? null,
                    oE_Reporte_Capacitacion_Mov.Cod_Opcion ?? null,
                    appEnvia.ToString() ?? "0", "");
                foreach (E_Reporte_Capacitacion_Detalle_Mov detalle in oE_Reporte_Capacitacion_Mov.Detalle)
                {
                    Registrar_Reporte_Capacitacion_Detalle_Mov(detalle, id_reg_Capacitacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Registrar_Reporte_Capacitacion_Detalle_Mov(E_Reporte_Capacitacion_Detalle_Mov detalle, string Id_Reg_Capacitacion)
        {

            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_CAPACITACION_DETALLE", Id_Reg_Capacitacion,
                    detalle.Cod_Capacitacion ?? null ,
                    detalle.Valor_Capacitacion ?? null,
                    detalle.Cod_Motivo ?? null,
                    detalle.Varlor_Motivo ?? null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
