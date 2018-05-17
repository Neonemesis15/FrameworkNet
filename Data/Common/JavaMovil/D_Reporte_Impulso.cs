using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Impulso
    {
        private Conexion oCoon;

        public D_Reporte_Impulso()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

        #region App Movil Movistar

        public string Registrar_Impulso_Mov(List<E_Reporte_Impulso_Mov> oListaReporteImpulso, string appEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Impulso_Mov oE_Reporte_Impulso_Mov in oListaReporteImpulso)
                {
                    Registrar_Impulso_Mov_Cabecera(oE_Reporte_Impulso_Mov, appEnvia);
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

        private void Registrar_Impulso_Mov_Cabecera(E_Reporte_Impulso_Mov oE_Reporte_Impulso_Mov, string appEnvia)
        {
            string id_reg_impulso = "";
            try
            {
                oCoon = new Conexion(3);
                id_reg_impulso = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_IMPULSO", 12,
                    oE_Reporte_Impulso_Mov.Cod_Persona,
                    oE_Reporte_Impulso_Mov.Cod_Equipo,
                    oE_Reporte_Impulso_Mov.Cod_Compania,
                    oE_Reporte_Impulso_Mov.Cod_PtoVenta,
                    oE_Reporte_Impulso_Mov.Cod_Categoria,
                    oE_Reporte_Impulso_Mov.Cod_Marca,
                    oE_Reporte_Impulso_Mov.Cod_Actividad ?? null,
                    oE_Reporte_Impulso_Mov.Fecha_Registro,
                    oE_Reporte_Impulso_Mov.Latitud ?? null,
                    oE_Reporte_Impulso_Mov.Longitud ?? null,
                    oE_Reporte_Impulso_Mov.Origen ?? null,
                    appEnvia ?? "0", 
                    "");
                foreach (E_Reporte_Impulso_Mov_Detalle detalle in oE_Reporte_Impulso_Mov.Detalle)
                {
                    Registrar_Impulso_Mov_Detalle(detalle, id_reg_impulso);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void Registrar_Impulso_Mov_Detalle(E_Reporte_Impulso_Mov_Detalle oE_Reporte_Impulso_Mov_Detalle, string id_reg_impulso)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_IMPULSO_DETALLE", id_reg_impulso,
                    oE_Reporte_Impulso_Mov_Detalle.Sku_Producto ?? null,
                    oE_Reporte_Impulso_Mov_Detalle.Ingreso ?? null,
                    oE_Reporte_Impulso_Mov_Detalle.Vta_x_Kilo ?? null,
                    oE_Reporte_Impulso_Mov_Detalle.Vta_x_Unidad ?? null,
                    oE_Reporte_Impulso_Mov_Detalle.Precio ?? null,
                    oE_Reporte_Impulso_Mov_Detalle.Stock_Final ?? null);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}