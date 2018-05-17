using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data;

namespace Lucky.Data.Common.JavaMovil
{
    class D_Reporte_Credito_Competencia
    {
         private Conexion oCoon;

         public D_Reporte_Credito_Competencia()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(3);
            oUserInterface = null;
        }

         public string Registrar_Reporte_Credito_Competencia_Mov(List<E_Reporte_Credito_Competencia_Mov> oListaReporte_Credito_Competencia_Mov, int AppEnvio)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Credito_Competencia_Mov oE_Reporte_Credito_Competencia_Mov in oListaReporte_Credito_Competencia_Mov)
                {
                    Registrar_Reporte_Credito_Competencia_Cabecera_Mov(oE_Reporte_Credito_Competencia_Mov, AppEnvio);
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

         private void Registrar_Reporte_Credito_Competencia_Cabecera_Mov(E_Reporte_Credito_Competencia_Mov oE_Reporte_Credito_Competencia_Mov, int appEnvia)
        {

            string id_reg_Cred_Compt = "";
            try
            {
                oCoon = new Conexion(3);
                id_reg_Cred_Compt = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_CREDITO_COMPETENCIA", 11,
                    oE_Reporte_Credito_Competencia_Mov.Cod_Persona,
                    oE_Reporte_Credito_Competencia_Mov.Cod_Equipo,
                    oE_Reporte_Credito_Competencia_Mov.Cod_Compania,
                    oE_Reporte_Credito_Competencia_Mov.Cod_PtoVenta,
                    oE_Reporte_Credito_Competencia_Mov.Cod_Categoria ?? null,
                    oE_Reporte_Credito_Competencia_Mov.Cod_Marca ?? null,
                    oE_Reporte_Credito_Competencia_Mov.Fecha_Registro,
                    oE_Reporte_Credito_Competencia_Mov.Latitud ?? null,
                    oE_Reporte_Credito_Competencia_Mov.Longitud ?? null,
                    oE_Reporte_Credito_Competencia_Mov.Origen ?? null,
                    appEnvia.ToString() ?? "0", "");
                foreach (E_Reporte_Credito_Competencia_Detalle_Mov detalle in oE_Reporte_Credito_Competencia_Mov.Detalle)
                {
                    Registrar_Reporte_Credito_Competencia_Detalle_Mov(detalle, id_reg_Cred_Compt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         private void Registrar_Reporte_Credito_Competencia_Detalle_Mov(E_Reporte_Credito_Competencia_Detalle_Mov Detalle, string id_reg_Cred_Compt)
        {

            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_CREDITO_COMPETENCIA_DETALLE", id_reg_Cred_Compt,
                    Detalle.Cod_Credito ?? null,
                    Detalle.Valor_Credito ?? null
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
