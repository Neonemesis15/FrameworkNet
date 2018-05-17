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
    public class D_Reporte_Quiebre
    {
        private Conexion oCoon;
        String error = string.Empty;

        public D_Reporte_Quiebre()
        {
            oCoon = new Conexion(2);
        }
        #region AppMovil Lucky
        public string Registrar_Reporte_Quiebre_Lista(List<E_Reporte_Quiebre> oListEReporte, string AppEnvia)
        {
            foreach (E_Reporte_Quiebre oEReporte in oListEReporte)
            {
                foreach (E_Reporte_Quiebre_Detalle oE_Reporte_Quiebre_Detalle in oEReporte.Detalle)
                {
                    string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADOS_QUIEBRE", 4,
                 oEReporte.CodCampania,
                 oEReporte.codPDV,
                 oEReporte.FechaBD,
                 oE_Reporte_Quiebre_Detalle.CodProducto,
                 "");
                    if (result == "1")
                    {
                        error += Registrar_Reporte_Quiebre(oEReporte, AppEnvia);
                    }
                    else if (result == "0")
                    {
                        error += "No existe periodo creado para esta fecha de registro";
                        break;
                    }
                    else
                    {
                        error += result;
                    }
                }
            }
            return error;
        }
        private string Registrar_Reporte_Quiebre(E_Reporte_Quiebre oE_Reporte_Quiebre, string AppEnvia)
        {
            string id_reg_Quiebre = "";
            oCoon = new Conexion(2);
            try
            {

                id_reg_Quiebre = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_INSERTAR_QUIEBRE", 12, oE_Reporte_Quiebre.CodPersona ?? "",
                oE_Reporte_Quiebre.CodPerfil ?? "", oE_Reporte_Quiebre.CodCampania ?? "", oE_Reporte_Quiebre.codCompania ?? "",
                oE_Reporte_Quiebre.codPDV ?? "", oE_Reporte_Quiebre.CodCategoria ?? "", oE_Reporte_Quiebre.CodMarca ?? "",
                Convert.ToDateTime(oE_Reporte_Quiebre.FechaBD.ToString() ?? ""),
                oE_Reporte_Quiebre.Latitud ?? "", oE_Reporte_Quiebre.Longitud ?? "",
                oE_Reporte_Quiebre.Origen ?? "", AppEnvia ?? "", "");

                foreach (E_Reporte_Quiebre_Detalle detalle in oE_Reporte_Quiebre.Detalle)
                {
                    error = error + Registrar_Reporte_Quiebre_Detalle(detalle, id_reg_Quiebre);
                }
            }
            catch (Exception ex)
            {
                error = error + ex.Message;
            }
            return error;
        }
        private string Registrar_Reporte_Quiebre_Detalle(E_Reporte_Quiebre_Detalle oDetalle, String id_reg_Quiebre)
        {
            try
            {
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("SP_GES_OPE_INSERTAR_QUIEBRE_DETALLE", id_reg_Quiebre, oDetalle.CodProducto ?? "", oDetalle.Quiebre ?? "");
                error = "";
            }
            catch (Exception ex)
            {
                error = error + ex.Message;
            }
            return error;
        }
        #endregion

        #region AppMovil Movistar
        public string Registrar_Reporte_Quiebre_Mov(List<E_Reporte_Quiebre_Mov> oListEReporte, string AppEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Quiebre_Mov oE_Reporte in oListEReporte)
                {
                    Registrar_Reporte_Quiebre_Mov_Cabecera(oE_Reporte, AppEnvia);
                    error += "";
                }
            }
            catch (Exception ex) {

                error += ex.Message;
                throw ex;
            }
            return error;

            //foreach (E_Reporte_Quiebre oEReporte in oListEReporte)
            //{
            //    foreach (E_Reporte_Quiebre_Detalle oE_Reporte_Quiebre_Detalle in oEReporte.Detalle)
            //    {
            //        string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADOS_QUIEBRE", 4,
            //     oEReporte.CodCampania,
            //     oEReporte.codPDV,
            //     oEReporte.FechaBD,
            //     oE_Reporte_Quiebre_Detalle.CodProducto,
            //     "");
            //        if (result == "1")
            //        {
            //            error += Registrar_Reporte_Quiebre(oEReporte, AppEnvia);
            //        }
            //        else if (result == "0")
            //        {
            //            error += "No existe periodo creado para esta fecha de registro";
            //            break;
            //        }
            //        else
            //        {
            //            error += result;
            //        }
            //    }
            //}
            //return error;
        }
        private void Registrar_Reporte_Quiebre_Mov_Cabecera(E_Reporte_Quiebre_Mov oE_Reporte, string AppEnvia)
        {
            string id_reg_Quiebre = "";
            oCoon = new Conexion(3);
            try
            {

                id_reg_Quiebre = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_QUIEBRE", 11, 
                oE_Reporte.Cod_Persona,
                oE_Reporte.Cod_Equipo, 
                oE_Reporte.Cod_Compania, 
                oE_Reporte.Cod_PtoVenta,
                oE_Reporte.Cod_Categoria ?? null, 
                oE_Reporte.Cod_Marca ?? null, 
                oE_Reporte.Fecha_Registro,
                oE_Reporte.Latitud ?? null, 
                oE_Reporte.Longitud ?? null,
                oE_Reporte.Origen ?? null, 
                AppEnvia ?? "0", "");

                foreach (E_Reporte_Quiebre_Mov_Detalle detalle in oE_Reporte.Detalle)
                {
                    Registrar_Reporte_Quiebre_Mov_Detalle(detalle, id_reg_Quiebre);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        private void Registrar_Reporte_Quiebre_Mov_Detalle(E_Reporte_Quiebre_Mov_Detalle oDetalle, String id_reg_Quiebre)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_QUIEBRE_DETALLE", id_reg_Quiebre, 
                    oDetalle.SKU_Producto ?? null, 
                    oDetalle.Quiebre ?? null);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
