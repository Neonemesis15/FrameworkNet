using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Registrar_Motivo
    {
        private Conexion oCoon;

        public D_Registrar_Motivo()
        { }

        public void RegistrarMotivoColgateBodega_Mov(E_Registro_MotivoFase oE_Registro_MotivoFase)
        {
            try
            {
                #region Registrar MotivoFase en Intermedia
                oCoon = new Conexion(3);
                string id_MotivoFase = oCoon.ejecutarretornodeOUTPUT("SP_MOV_GES_OPE_REGISTRAR_MOTIVOFASE", 8,
                oE_Registro_MotivoFase.Cod_Persona, oE_Registro_MotivoFase.Cod_Equipo,
                oE_Registro_MotivoFase.Cod_Compania, oE_Registro_MotivoFase.Cod_PtoVenta,
                oE_Registro_MotivoFase.Latitud ?? null, oE_Registro_MotivoFase.Longitud ?? null,
                oE_Registro_MotivoFase.Origen ?? null, oE_Registro_MotivoFase.Fase ?? null, 0);
                #endregion

                if (!id_MotivoFase.Equals("0"))
                {

                    #region Eliminar Detalle MotivoFase en Intermedia
                    oCoon = new Conexion(3);
                    oCoon.ejecutarDataSet("SP_MOV_GES_OPE_ELIMINAR_MOTIVOFASE_DETALLE", id_MotivoFase);
                    #endregion

                    #region Eliminar Detalle MotivoFase en Xplora
                    oCoon = new Conexion(1);
                    oCoon.ejecutarDataSet("SP_XPL_GES_OPE_ELIMINAR_MOTIVOFASE_DETALLE",id_MotivoFase);
                    #endregion

                    foreach (E_MotivoFase oE_MotivoFase in oE_Registro_MotivoFase.listaMotivo)
                    {
                        RegistrarMotivoFaseColgateBodega_Mov(oE_MotivoFase, id_MotivoFase);
                    }
                }
                

                #region Actualizar MotivoFase en Xplora
                oCoon = new Conexion(1);
                oCoon.ejecutarDataTable("SP_XPL_GES_OPE_ACTUALIZAR_MOTIVOFASE",
                oE_Registro_MotivoFase.Cod_Persona, oE_Registro_MotivoFase.Cod_Equipo,
                oE_Registro_MotivoFase.Cod_Compania, oE_Registro_MotivoFase.Cod_PtoVenta,
                oE_Registro_MotivoFase.Latitud ?? null, oE_Registro_MotivoFase.Longitud ?? null,
                oE_Registro_MotivoFase.Origen ?? null, oE_Registro_MotivoFase.Fase ?? null);
                #endregion


            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void RegistrarMotivoFaseColgateBodega_Mov(E_MotivoFase oE_MotivoFase, string id_MotivoFase)
        {
            try
            {
                //#region Eliminar Detalle MotivoFase en Xplora >>>>Warning - Metodo no Implementado<<<<
                //oCoon = new Conexion(1);
                //oCoon.ejecutarSinRetorno("SP_XPL_GES_OPE_ELIMINAR_MOTIVOFASE_DETALLE", id_MotivoFase);
                //#endregion


                oCoon = new Conexion(3);
                oCoon.ejecutarSinRetorno("SP_MOV_GES_OPE_REGISTRAR_MOTIVOFASE_DETALLE", id_MotivoFase, oE_MotivoFase.CodMotivo);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}