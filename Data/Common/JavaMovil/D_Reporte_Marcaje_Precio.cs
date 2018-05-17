using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Marcaje_Precio
    {
        private Conexion oCoon;

        public D_Reporte_Marcaje_Precio()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

        #region App Movil Movistar

        public string Registrar_Marcaje_Precio_Mov(List<E_Reporte_Marcaje_Precio_Mov> oListaReporteMarcaje, int appEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Marcaje_Precio_Mov oE_Reporte_Marcaje_Mov in oListaReporteMarcaje)
                {
                    Registrar_Marcaje_Mov_Cabecera(oE_Reporte_Marcaje_Mov, appEnvia);
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

        private void Registrar_Marcaje_Mov_Cabecera(E_Reporte_Marcaje_Precio_Mov oE_Reporte_Marcaje_Mov, int appEnvia)
        {
            string id_reg_marcaje = "";
            try
            {
                
                oCoon = new Conexion(3);
                id_reg_marcaje = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_MARCAJE_PRECIO", 12,
                    oE_Reporte_Marcaje_Mov.Cod_Persona,
                    oE_Reporte_Marcaje_Mov.Cod_Equipo,
                    oE_Reporte_Marcaje_Mov.Cod_Compania,
                    oE_Reporte_Marcaje_Mov.Cod_PtoVenta,
                    oE_Reporte_Marcaje_Mov.Cod_Categoria,
                    oE_Reporte_Marcaje_Mov.Cod_Marca,
                    oE_Reporte_Marcaje_Mov.Fecha_Registro,
                    oE_Reporte_Marcaje_Mov.Latitud ?? null,
                    oE_Reporte_Marcaje_Mov.Longitud ?? null,
                    oE_Reporte_Marcaje_Mov.Origen ?? null,
                    oE_Reporte_Marcaje_Mov.Cod_Opcion ?? null,
                    appEnvia,
                    "");
                foreach (E_Reporte_Marcaje_Precio_Mov_Detalle detalle in oE_Reporte_Marcaje_Mov.Detalle)
                {
                    Registrar_Marcaje_Mov_Detalle(detalle, id_reg_marcaje);
                }
                foreach (E_Reporte_Marcaje_Precio_Foto_Mov detalle in oE_Reporte_Marcaje_Mov.Fotos)
                {
                    Registrar_Marcaje_Precio_Foto(detalle, id_reg_marcaje);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void Registrar_Marcaje_Mov_Detalle(E_Reporte_Marcaje_Precio_Mov_Detalle oE_Reporte_Marcaje_Mov_Detalle, string id_reg_marcaje)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_MARCAJE_PRECIO_DETALLE_V_1_0", id_reg_marcaje
                    ,oE_Reporte_Marcaje_Mov_Detalle.Cod_Motivo ?? null
                    ,oE_Reporte_Marcaje_Mov_Detalle.Cantidad ?? null
                    ,oE_Reporte_Marcaje_Mov_Detalle.Valor_Motivo ?? null
                    ,oE_Reporte_Marcaje_Mov_Detalle.Cod_Marcaje ?? null
                    ,oE_Reporte_Marcaje_Mov_Detalle.Nombre_Foto ?? null //Add 09/08/2012 Pablo Salas A.
                    , oE_Reporte_Marcaje_Mov_Detalle.Comentario_Foto ?? null //Add 09/08/2012 Pablo Salas A.
                );
            }
            catch (Exception ex )
            {
                throw ex;
            }

        }
        private void Registrar_Marcaje_Precio_Foto(E_Reporte_Marcaje_Precio_Foto_Mov oE_Reporte_Marcaje_Precio_Foto_Mov, string id_reg_marcaje)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_MARCAJE_PRECIO_FOTOS", id_reg_marcaje,
                    oE_Reporte_Marcaje_Precio_Foto_Mov.Nombre_Foto);

            }
            catch (Exception ex )
            {
                throw ex;
            }
        }
        #endregion
    }
}
