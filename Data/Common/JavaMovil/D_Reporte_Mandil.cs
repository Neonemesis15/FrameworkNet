using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Mandil
    {
        private Conexion oCoon;

        public D_Reporte_Mandil()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

        #region App Movil Movistar

         public string Registrar_Mandil_Mov(List<E_Reporte_Mandil_Mov> oListaReporteMandil, int appEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Mandil_Mov oE_Reporte_Mandil_Mov in oListaReporteMandil)
                {
                    Registrar_Mandil_Mov_Cabecera(oE_Reporte_Mandil_Mov, appEnvia);
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

         private void Registrar_Mandil_Mov_Cabecera(E_Reporte_Mandil_Mov oE_Reporte_Mandil_Mov, int appEnvia)
        {
            string id_reg_mandil = "";
            try
            {
                oCoon = new Conexion(3);
                id_reg_mandil = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_MANDIL", 11,
                    oE_Reporte_Mandil_Mov.Cod_Persona,
                    oE_Reporte_Mandil_Mov.Cod_Equipo,
                    oE_Reporte_Mandil_Mov.Cod_Compania,
                    oE_Reporte_Mandil_Mov.Cod_PtoVenta,
                    oE_Reporte_Mandil_Mov.Cod_Categoria,
                    oE_Reporte_Mandil_Mov.Cod_Marca,
                    oE_Reporte_Mandil_Mov.Fecha_Registro,
                    oE_Reporte_Mandil_Mov.Latitud ?? null,
                    oE_Reporte_Mandil_Mov.Longitud ?? null,
                    oE_Reporte_Mandil_Mov.Origen ?? null,
                    appEnvia.ToString() ?? "0", 
                    "");
                foreach (E_Reporte_Mandil_Mov_Detalle detalle in oE_Reporte_Mandil_Mov.Detalle)
                {
                    Registrar_Mandil_Mov_Detalle(detalle, id_reg_mandil);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
         private void Registrar_Mandil_Mov_Detalle(E_Reporte_Mandil_Mov_Detalle oE_Reporte_Mandil_Mov_Detalle, string id_reg_mandil)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_MANDIL_DETALLE", id_reg_mandil,
                    oE_Reporte_Mandil_Mov_Detalle.Opcion ?? null,
                    oE_Reporte_Mandil_Mov_Detalle.Cod_Motivo ?? null,
                    oE_Reporte_Mandil_Mov_Detalle.Cantidad ?? null);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
