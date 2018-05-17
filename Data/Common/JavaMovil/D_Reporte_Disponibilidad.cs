using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;
using System.Configuration;


namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Disponibilidad
    {
        private Conexion oCoon;
        public D_Reporte_Disponibilidad() {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }

        private string id = "";

        public void RegistraDisponibilidad(E_Reporte_Disponibilidad oE_Reporte_Disponibilidad)
        {
            string id_reg_Disponibilidad = "";
            oCoon = new Conexion(2);
            try
            {
                id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_DISPONIBILIDAD_02", 13, oE_Reporte_Disponibilidad.Person_id ?? "",
                    oE_Reporte_Disponibilidad.Perfil_id ?? "", oE_Reporte_Disponibilidad.Equipo_id ?? "", oE_Reporte_Disponibilidad.Cliente_id ?? "",
                    oE_Reporte_Disponibilidad.ClientePDV_Code ?? "", oE_Reporte_Disponibilidad.Categoria_id ?? "", oE_Reporte_Disponibilidad.Marca_id ?? "",
                    oE_Reporte_Disponibilidad.FechaRegistro ?? "", oE_Reporte_Disponibilidad.Latitud ?? "", oE_Reporte_Disponibilidad.Longitud ?? "",
                    oE_Reporte_Disponibilidad.OrigenCoordenada ?? "", oE_Reporte_Disponibilidad.TipoCanal ?? "", oE_Reporte_Disponibilidad.Comentario ?? "",
                    id_reg_Disponibilidad);
                foreach (E_Reporte_Disponibilidad_Detalle detalle in oE_Reporte_Disponibilidad.DisponibilidadDetalle)
                {
                    RegistraDisponibilidadDetalle(detalle);
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private void RegistraDisponibilidadDetalle(E_Reporte_Disponibilidad_Detalle oE_Reporte_Disponibilidad_Detalle)
        {
            oCoon = new Conexion(2);
            try
            {
                oCoon.ejecutarDataTable("STP_JVM_INSERTAR_DISPONIBILIDAD_02_DETALLE", id, oE_Reporte_Disponibilidad_Detalle.Id_producto ?? "",
                    oE_Reporte_Disponibilidad_Detalle.Disponibilidad ?? "", oE_Reporte_Disponibilidad_Detalle.Stock ?? "",
                    oE_Reporte_Disponibilidad_Detalle.Pedido ?? "", oE_Reporte_Disponibilidad_Detalle.Minimo ?? "",
                    oE_Reporte_Disponibilidad_Detalle.Sugerido ?? "");
            }
            catch (Exception ex) {
                throw ex;
            }
        }


    }
}
