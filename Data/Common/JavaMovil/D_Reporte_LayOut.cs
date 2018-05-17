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
    public class D_Reporte_LayOut
    {
        private Conexion oCoon;
        public D_Reporte_LayOut()
          {
            oCoon = new Conexion(2);
        }

        String error = string.Empty;
        #region AppMovil Lucky
        public string Registrar_Reporte_LayOut_Lista(List<E_Reporte_LayOut> oListaReporte, string AppEnvia) {
            foreach (E_Reporte_LayOut oE_Reporte_LayOut in oListaReporte) {

                string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADO_LAYOUT", 5,
                 oE_Reporte_LayOut.CodCampania,
                 oE_Reporte_LayOut.codPDV,
                 oE_Reporte_LayOut.FechaBD,
                 oE_Reporte_LayOut.CodCategoria,
                 oE_Reporte_LayOut.CodMarca,
                 "");
                if (result == "1")
                {
                    error += Registrar_Reporte_LayOut(oE_Reporte_LayOut, AppEnvia);
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
            return error;
        }
        private string Registrar_Reporte_LayOut(E_Reporte_LayOut oE_Reporte_LayOut, string AppEnvia)
        {
            oCoon = new Conexion(2);
            try{
            
                oCoon.ejecutarDataTable("SP_GES_OPE_INSERTAR_LAYOUT",oE_Reporte_LayOut.CodPersona ?? "",
                oE_Reporte_LayOut.CodPerfil ?? "", oE_Reporte_LayOut.CodCampania ?? "", oE_Reporte_LayOut.codCompania ?? "",
                oE_Reporte_LayOut.codPDV ?? "", oE_Reporte_LayOut.CodCategoria ?? "", oE_Reporte_LayOut.CodMarca ?? "",
                oE_Reporte_LayOut.Objetivo ?? "",oE_Reporte_LayOut.Cantidad ?? "" , oE_Reporte_LayOut.Frentes ?? "",
                Convert.ToDateTime(oE_Reporte_LayOut.FechaBD.ToString() ?? ""),
                oE_Reporte_LayOut.Latitud ?? "", oE_Reporte_LayOut.Longitud ?? "",
                oE_Reporte_LayOut.Origen ?? "", AppEnvia ?? "", oE_Reporte_LayOut.Observacion ?? "");
           
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        #endregion

        #region AppMovil Movistar
        public string Registrar_Reporte_LayOut_Mov(List<E_Reporte_LayOut_Mov> oListaReporte, string AppEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_LayOut_Mov oE_Reporte in oListaReporte)
                {
                    Registrar_Reporte_LayOut_Mov_Cabecera(oE_Reporte, AppEnvia);
                    error += "";
                }
            }
            catch (Exception ex) {
                error += ex.Message;
                throw ex;
            }
            
            return error;

            //foreach (E_Reporte_LayOut oE_Reporte_LayOut in oListaReporte)
            //{

            //    string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADO_LAYOUT", 5,
            //     oE_Reporte_LayOut.CodCampania,
            //     oE_Reporte_LayOut.codPDV,
            //     oE_Reporte_LayOut.FechaBD,
            //     oE_Reporte_LayOut.CodCategoria,
            //     oE_Reporte_LayOut.CodMarca,
            //     "");
            //    if (result == "1")
            //    {
            //        error += Registrar_Reporte_LayOut(oE_Reporte_LayOut, AppEnvia);
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
            //return error;
        }
        private void Registrar_Reporte_LayOut_Mov_Cabecera(E_Reporte_LayOut_Mov oE_Reporte, string AppEnvia)
        {
            oCoon = new Conexion(3);
            try
            {
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_LAYOUT", 
                oE_Reporte.Cod_Persona,
                oE_Reporte.Cod_Equipo, 
                oE_Reporte.Cod_Compania,
                oE_Reporte.Cod_PtoVenta, 
                oE_Reporte.Cod_Categoria ?? null,
                oE_Reporte.Cod_Marca ?? null,
                oE_Reporte.Objetivo ?? null,
                oE_Reporte.Cantidad ?? null,
                oE_Reporte.Frentes ?? null,
                oE_Reporte.Fecha_Registro,
                oE_Reporte.Latitud ?? null,
                oE_Reporte.Longitud ?? null,
                oE_Reporte.Origen ?? null,
                oE_Reporte.Observacion ?? null,
                AppEnvia ?? "0");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion
    }
}
