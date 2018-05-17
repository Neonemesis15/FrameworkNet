using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Incidencia
    {
        private Conexion oCoon;

        public D_Reporte_Incidencia()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

        #region App Movil Movistar

        public string Registrar_Incidencia_Mov(List<E_Reporte_Incidencia_Mov> oListaE_Reporte_Incidencia, string appEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Incidencia_Mov oE_Reporte_Incidencia_Mov in oListaE_Reporte_Incidencia)
                {
                    Registrar_Incidencia_Mov_Cabecera(oE_Reporte_Incidencia_Mov, appEnvia);
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

        private void Registrar_Incidencia_Mov_Cabecera(E_Reporte_Incidencia_Mov oE_Reporte_Incidencia_Mov, string appEnvia)
        {
            string id_reg_incidencia = "";
            try
            {
                oCoon = new Conexion(3);
                id_reg_incidencia = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_INCIDENCIA", 13,
                    oE_Reporte_Incidencia_Mov.Cod_Persona,
                    oE_Reporte_Incidencia_Mov.Cod_Equipo,
                    oE_Reporte_Incidencia_Mov.Cod_Compania,
                    oE_Reporte_Incidencia_Mov.Cod_PtoVenta,
                    oE_Reporte_Incidencia_Mov.Cod_Categoria ?? null,
                    oE_Reporte_Incidencia_Mov.Cod_Marca ?? null,
                    oE_Reporte_Incidencia_Mov.Cod_TipoIncidencia ?? null,
                    oE_Reporte_Incidencia_Mov.Fecha_Registro,
                    oE_Reporte_Incidencia_Mov.Latitud ?? null,
                    oE_Reporte_Incidencia_Mov.Longitud ?? null,
                    oE_Reporte_Incidencia_Mov.Origen ?? null,
                    oE_Reporte_Incidencia_Mov.Cod_Opcion ?? null,
                    appEnvia ?? "0", 
                    "");
                foreach (E_Reporte_Incidencia_Mov_Detalle detalle in oE_Reporte_Incidencia_Mov.Detalle)
                {
                    Registrar_Incidencia_Mov_Detalle(detalle, id_reg_incidencia);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void Registrar_Incidencia_Mov_Detalle(E_Reporte_Incidencia_Mov_Detalle oE_Reporte_Incidencia_Mov_Detalle, string id_reg_incidencia)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_INCIDENCIA_DETALLE_V_1_1", id_reg_incidencia,
                    oE_Reporte_Incidencia_Mov_Detalle.Sku_Producto ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Cod_Servicio ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Pedido ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Stock_Final ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Nombre_Foto ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Cod_Status ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Valor_Status ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Cod_Incidencia ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Cantidad ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Tipo_Distribuidor ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Valor_Incidencia ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Comentario_Foto ?? null,
                    oE_Reporte_Incidencia_Mov_Detalle.Cod_Opcion_Pedido ?? null //Add 24/08/2012 Pablo Salas A.
                    );

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
