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
    public class D_Reporte_SOD
    {
        private Conexion oCoon;
        public D_Reporte_SOD()
         {
            oCoon = new Conexion(2);
        }
        String error = string.Empty;
        #region AppMovil Lucky
        public string Registrar_Reporte_SOD_Lista(List<E_Reporte_SOD> oListEReporte, string AppEnvia)
         {
             foreach (E_Reporte_SOD oEReporte in oListEReporte)
             {
                 foreach (E_Reporte_SOD_Detalle oE_Reporte_SOD_Detalle in oEReporte.Detalle)
                 {
                     string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADOS_SOD", 4,
                    oEReporte.Equipo_id,
                    oEReporte.ClientePDV_Code,
                    oEReporte.FechaRegistro,
                    oE_Reporte_SOD_Detalle.Id_Brand,
                    "");
                     if (result == "1")
                     {
                         error += Registrar_Reporte_SOD(oEReporte, AppEnvia);
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
        private string Registrar_Reporte_SOD(E_Reporte_SOD oE_Reporte_SOD,string AppEnvia)
        {
            string id_reg_SOD = "";
            oCoon = new Conexion(2);
            try{

                id_reg_SOD = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_INSERTAR_SOD", 12, oE_Reporte_SOD.Person_id ?? "",
                oE_Reporte_SOD.Perfil_id ?? "", oE_Reporte_SOD.Equipo_id ?? "", oE_Reporte_SOD.Cliente_id ?? "",
                oE_Reporte_SOD.ClientePDV_Code ?? "", oE_Reporte_SOD.Categoria ?? "", oE_Reporte_SOD.FechaRegistro ?? "",
                oE_Reporte_SOD.Latitud ?? "", oE_Reporte_SOD.Longitud ?? "", oE_Reporte_SOD.OrigenCoordenada ?? "",
                oE_Reporte_SOD.Observacion ?? "", AppEnvia ?? "", "");
           
                foreach (E_Reporte_SOD_Detalle detalle in oE_Reporte_SOD.Detalle) {
                    error = error + Registrar_Reporte_SOD_Detalle(detalle, id_reg_SOD);
                }
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        private string Registrar_Reporte_SOD_Detalle(E_Reporte_SOD_Detalle oDetalle, String id_reg_SOD)
        {
            try {
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("SP_GES_OPE_INSERTAR_SOD_DETALLE", id_reg_SOD, oDetalle.Id_Brand ?? "", oDetalle.Exhib_Primaria ?? "", oDetalle.Exhib_Secundaria ?? "", oDetalle.Motivo_Obs ?? "");
                error = "";
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        #endregion

        #region AppMovil Movistar

        public string Registrar_Reporte_SOD_Mov(List<E_Reporte_SOD_Mov> oListEReporte, string AppEnvia)
        {
            try
            {
                string error = string.Empty;
                foreach (E_Reporte_SOD_Mov oEReporte in oListEReporte)
                {
                    Registrar_Reporte_SOD_Mov_Cabecera(oEReporte, AppEnvia);
                }
                error += "";
            }
            catch (Exception ex) {
                error += ex.Message;
                throw ex;
            }
            return error;

            //foreach (E_Reporte_SOD oEReporte in oListEReporte)
            //{
                //foreach (E_Reporte_SOD_Detalle oE_Reporte_SOD_Detalle in oEReporte.Detalle)
                //{
                //    string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADOS_SOD", 4,
                //   oEReporte.Equipo_id,
                //   oEReporte.ClientePDV_Code,
                //   oEReporte.FechaRegistro,
                //   oE_Reporte_SOD_Detalle.Id_Brand,
                //   "");
                //    if (result == "1")
                //    {
                //        error += Registrar_Reporte_SOD(oEReporte, AppEnvia);
                //    }
                //    else if (result == "0")
                //    {
                //        error += "No existe periodo creado para esta fecha de registro";
                //        break;
                //    }
                //    else
                //    {
                //        error += result;
                //    }
                //}
            //}
            
        }
        private void Registrar_Reporte_SOD_Mov_Cabecera(E_Reporte_SOD_Mov oE_Reporte_SOD, string AppEnvia)
        {
            string id_reg_SOD = "";
            oCoon = new Conexion(3);
            try
            {

                id_reg_SOD = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_SOD", 13, 
                oE_Reporte_SOD.Cod_Persona,
                oE_Reporte_SOD.Cod_Equipo, 
                oE_Reporte_SOD.Cod_Compania, 
                oE_Reporte_SOD.Cod_PtoVenta,
                oE_Reporte_SOD.Cod_Categoria ?? null,  
                oE_Reporte_SOD.Fecha_Registro,
                oE_Reporte_SOD.Latitud ?? null,
                oE_Reporte_SOD.Longitud ?? null,
                oE_Reporte_SOD.Origen ?? null,
                oE_Reporte_SOD.Observacion ?? null,
                oE_Reporte_SOD.Nombre_Foto ?? null,
                oE_Reporte_SOD.Comentario_Foto ?? null,
                AppEnvia ?? "0", "");

                foreach (E_Reporte_SOD_Mov_Detalle detalle in oE_Reporte_SOD.Detalle)
                {
                    Registrar_Reporte_SOD_Mov_Detalle(detalle, id_reg_SOD);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
        private void Registrar_Reporte_SOD_Mov_Detalle(E_Reporte_SOD_Mov_Detalle oDetalle, String id_reg_SOD)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_SOD_DETALLE", 
                id_reg_SOD, 
                oDetalle.Cod_Marca ?? null, 
                oDetalle.Exhibicion_Primaria ?? null, 
                oDetalle.Exhibicion_Secundaria ?? null, 
                oDetalle.Motivo_Obs ?? null);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
