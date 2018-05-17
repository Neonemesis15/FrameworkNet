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
    public class D_Reporte_Promociones
    {
        private Conexion oCoon;
        public D_Reporte_Promociones()
            {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
            }
        #region App Movil Lucky
        public void Registrar_Promociones_General_Lista(List<E_Reporte_Promocion_General> oListEReporte) {
            foreach (E_Reporte_Promocion_General oEReporte in oListEReporte) {
                Registrar_Promociones_General(oEReporte);
            }
        }

        public void Registrar_Promociones_General(E_Reporte_Promocion_General oEReporte)
        {
            //string id_reg_Presencia = "";
            oCoon = new Conexion(2);
            //Crear un Store procedure para InsertarPresencia con nuevo AppMovil
            //id = 
            //pSalas 06/03/2012 pendiente el store procedure
            oCoon.ejecutarDataSet("STP_JVM_INSERTAR_PROMOCIONES", int.Parse(oEReporte.Person_id) ,
            oEReporte.Id_perfil ?? "", oEReporte.Id_equipo ?? "", oEReporte.Id_cliente ?? "",
            oEReporte.Id_ptoventa ?? "",
            oEReporte.Id_categoria ?? "", oEReporte.Id_marca ?? "", oEReporte.Id_company_promo ?? "",
            oEReporte.Id_promocion ?? "", oEReporte.Descripcion_promocion ?? "", oEReporte.Mecanica ?? "",
            oEReporte.Cod_producto ?? "", oEReporte.Fec_ini_promocion ?? "", oEReporte.Fec_fin_promocion ?? "",
            oEReporte.Precio_promocion ?? "", oEReporte.Precio_regular ?? "", oEReporte.FechaRegistro ?? "",
            oEReporte.Latitud ?? "", oEReporte.Longitud ?? "", oEReporte.Origen ?? "", oEReporte.Tipo_canal ?? "",
            oEReporte.Comentario ?? "");


            oCoon.ejecutarDataSet("stp_jvm_INSERTAR_FOTO", int.Parse(oEReporte.Person_id),
                 oEReporte.Id_perfil ?? "", oEReporte.Id_equipo ?? "", oEReporte.Id_cliente ?? "",
            oEReporte.Id_ptoventa ?? "", 9, oEReporte.FechaRegistro ?? "", oEReporte.Comentario ?? "", DecodeFrom64(oEReporte.Foto ?? ""), 
            "");//nombreFoto

            //foreach (E_Reporte_Presencia_General_Detalle detalle in oEReporte.DetallePresencia)
            //    Registrar_Presencia_General_Detalle(detalle);

            //return oE_Reporte_Presencia;

            //oListE_Reporte_Presencia.Add(oE_Reporte_Presencia);

            //return oListE_Reporte_Presencia;
        }
        #region metodos Util
        //Convierte a byte[] un string Add 13/01/2012
        public static byte[] DecodeFrom64(String encodedData)
        {

            byte[] encodedDataAsBytes

                = System.Convert.FromBase64String(encodedData);
            return encodedDataAsBytes;

        }
        #endregion
        #endregion 

        #region App Movil Movistar
        string error = string.Empty;
        public string  Registrar_Promociones_Mov(List<E_Reporte_Promocion_Mov> oListEReporte, int AppEnvia)
        {
            try
            {
                foreach (E_Reporte_Promocion_Mov oEReporte in oListEReporte)
                {
                    error += Registrar_Promociones_Mov_Cabecera(oEReporte, AppEnvia);
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            return error;
        }
        private string Registrar_Promociones_Mov_Cabecera(E_Reporte_Promocion_Mov oEReporte, int AppEnvia)
        {
            try
            {
                oCoon = new Conexion(3);

                oCoon.ejecutarDataSet("SP_GES_OPE_REGISTRAR_PROMOCION", oEReporte.Cod_Persona, oEReporte.Cod_Equipo,
                    oEReporte.Cod_Compania, oEReporte.Cod_PtoVenta, oEReporte.Cod_Categoria,
                    oEReporte.Cod_Marca, oEReporte.Cod_CompaniaPromo ?? null, oEReporte.Cod_Promocion ?? null,
                    oEReporte.Descripcion_Promocion ?? null, oEReporte.Mecanica ?? null, oEReporte.SKU_Producto ?? null,
                    oEReporte.Fec_Ini_Promocion ?? null, oEReporte.Fec_Fin_Promocion ?? null, oEReporte.Precio_Promocion ?? null,
                    oEReporte.Precio_Regular ?? null, oEReporte.Nombre_Foto ?? null, oEReporte.Fec_Registro,
                    oEReporte.Latitud ?? null, oEReporte.Longitud ?? null, oEReporte.Origen ?? null,
                    oEReporte.Comentario ?? null, AppEnvia);
                error += string.Empty;
            }
            catch (Exception ex) {
                error += ex.Message;
                throw ex;
            }
            return error;
        }
        #endregion 
    }
}
