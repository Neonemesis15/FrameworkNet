using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Exhibicion
    {
         private Conexion oCoon;
        public D_Reporte_Exhibicion() {
            oCoon = new Conexion(2);
        }
        String error = string.Empty;
        #region App Movil Lucky
        public string Registrar_Reporte_Exhibicion_Lista(List<E_Reporte_Exhibicion> oListEReporte, string AppEnvia)
        {
            foreach (E_Reporte_Exhibicion oEReporte in oListEReporte)
            {
                error = error + Registrar_Reporte_Exhibicion(oEReporte, AppEnvia);
            }
            return error;
        }
        public string id = "";
        private string Registrar_Reporte_Exhibicion(E_Reporte_Exhibicion oE_Reporte_Exhibicion, string AppEnvia)
        {
            string id_reg_Exhibicion = "";
            oCoon = new Conexion(2);
            try{
            
                id = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_INSERTAR_EXHIBICION",15,oE_Reporte_Exhibicion.CodPersona ?? "",
                oE_Reporte_Exhibicion.CodPerfil ?? "", oE_Reporte_Exhibicion.CodCampania ?? "", oE_Reporte_Exhibicion.codCompania ?? "",
                oE_Reporte_Exhibicion.codPDV ?? "", oE_Reporte_Exhibicion.CodCategoria ?? "", oE_Reporte_Exhibicion.CodMarca ?? "",
                oE_Reporte_Exhibicion.CodCondicion ?? "", Convert.ToDateTime(oE_Reporte_Exhibicion.FechaInicio.ToString() ?? ""), 
                Convert.ToDateTime(oE_Reporte_Exhibicion.FechaFin.ToString() ?? ""),
                Convert.ToDateTime(oE_Reporte_Exhibicion.FechaBD.ToString() ?? ""),
                oE_Reporte_Exhibicion.Latitud ?? "", oE_Reporte_Exhibicion.Longitud ?? "",
                oE_Reporte_Exhibicion.Origen ?? "", AppEnvia ?? "", id_reg_Exhibicion);
           
                foreach (E_Reporte_Exhibicion_Detalle detalle in oE_Reporte_Exhibicion.Detalle) {
                    error = error + Registrar_Reporte_Exhibicion_Detalle(detalle);
                }
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        private string Registrar_Reporte_Exhibicion_Detalle(E_Reporte_Exhibicion_Detalle oDetalle) {
            try {
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("SP_GES_OPE_INSERTAR_EXHIBICION_DETALLE", id, oDetalle.Id_Tipo ?? "", oDetalle.Cantidad ?? "", oDetalle.Cod_Categoria ?? "");
                error = "";
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        #endregion

        #region App Movil Movistar
        public string Registrar_Reporte_Exhibicion_Mov(List<E_Reporte_Exhibicion_Mov> oListEReporte, string AppEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Exhibicion_Mov oEReporte in oListEReporte)
                {
                    Registrar_Reporte_Exhibicion_Mov_Cabecera(oEReporte, AppEnvia);
                    error += "";
                }
            }
            catch (Exception ex) {
                error += ex.Message;
                throw ex;
            }
            return error;
        }
        private void Registrar_Reporte_Exhibicion_Mov_Cabecera(E_Reporte_Exhibicion_Mov oE_Reporte, string AppEnvia)
        {
            string id_reg_Exhibicion = "";
            oCoon = new Conexion(3);
            try
            {

                id_reg_Exhibicion = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_EXHIBICION", 17, 
                oE_Reporte.Cod_Persona,
                oE_Reporte.Cod_Equipo, 
                oE_Reporte.Cod_Compania , 
                oE_Reporte.Cod_PtoVenta,
                oE_Reporte.Cod_Categoria ?? null, 
                oE_Reporte.Cod_Marca ?? null, 
                oE_Reporte.Cod_Condicion ?? null, 
                oE_Reporte.Fecha_Inicio ?? null,
                oE_Reporte.Fecha_Fin ?? null,
                oE_Reporte.Fecha_Registro,
                oE_Reporte.Latitud ?? null, 
                oE_Reporte.Longitud ?? null,
                oE_Reporte.Origen ?? null, 
                oE_Reporte.Cod_Opcion ?? null,
                oE_Reporte.Nombre_Foto ?? null,
                oE_Reporte.Comentario_Foto ?? null,
                AppEnvia ?? "0"
                , "");

                foreach (E_Reporte_Exhibicion_Mov_Detalle detalle in oE_Reporte.Detalle)
                {
                    Registrar_Reporte_Exhibicion_Mov_Detalle(detalle, id_reg_Exhibicion);
                }
            }
            catch (Exception ex )
            {
                throw ex;
            }
         
        }
        private void Registrar_Reporte_Exhibicion_Mov_Detalle(E_Reporte_Exhibicion_Mov_Detalle oDetalle, string Id_Reg_Exhibicion)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_EXHIBICION_DETALLE_", Id_Reg_Exhibicion, 
                    oDetalle.Cod_Tipo ?? null,
                    oDetalle.Cantidad ?? null,
                    oDetalle.Cod_Categoria ?? null,
                    oDetalle.Cod_Motivo ?? null,
                    oDetalle.Valor_Motivo ?? null,
                    oDetalle.Cod_Exhibicion ?? null,
                    oDetalle.Valor_Exhibicion ?? null,
                    oDetalle.Cod_Sub_Reporte ?? null);
                
            }
            catch (Exception ex )
            {
                throw ex;
            }

        }
        #endregion 

    }
}
