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
    public class D_Reporte_Precio
    {
        private Conexion oCoon;
        public D_Reporte_Precio() {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }

        #region App Movil Lucky
        //pSalas. 01/03/2012. Se evalua si crear un RegistrarPrecio x Cliente y Canal, para enviar menos parametros.
        String error = string.Empty;
        public string RegistraPrecio(List<E_Reporte_Precio> ListaE_Reporte_Precio, string appEnvia)
        {
            foreach (E_Reporte_Precio oE_Reporte_Precio in ListaE_Reporte_Precio)
            {
                foreach (E_Reporte_Precio_Detalle oE_Reporte_Precio_Detalle in oE_Reporte_Precio.PrecioDetalle)
                {
                    string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADOS_PRECIO", 4,
                     oE_Reporte_Precio.Equipo_id,
                     oE_Reporte_Precio.ClientePDV_Code,
                     oE_Reporte_Precio.FechaRegistro,
                     oE_Reporte_Precio_Detalle.Id_producto,
                     "");
                    if (result == "1")
                    {
                        error += RegistraPrecio(oE_Reporte_Precio, appEnvia);                       
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
        public string RegistraPrecio(E_Reporte_Precio oE_Reporte_Precio, string appEnvia) {
            string id_reg_precio="";
            try
            {
                oCoon = new Conexion(2);
                id_reg_precio = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_INSERTAR_PRECIO", 17, oE_Reporte_Precio.Person_id ?? "0",
                    oE_Reporte_Precio.Perfil_id ?? "", oE_Reporte_Precio.Equipo_id ?? "", oE_Reporte_Precio.Cliente_id ?? "",
                    oE_Reporte_Precio.ClientePDV_Code ?? "", oE_Reporte_Precio.Categoria_id ?? "", oE_Reporte_Precio.Marca_id ?? "",
                    oE_Reporte_Precio.Id_familia ?? "", oE_Reporte_Precio.Id_subfamilia ?? "", oE_Reporte_Precio.Tipo_Canal ?? "",
                    oE_Reporte_Precio.FechaRegistro ?? "", oE_Reporte_Precio.Latitud ?? "", oE_Reporte_Precio.Longitud ?? "",
                    oE_Reporte_Precio.OrigenCoordenada ?? "", oE_Reporte_Precio.Observacion ?? "", oE_Reporte_Precio.Tipo_precio ?? "",
                    appEnvia ?? "0","");
                foreach (E_Reporte_Precio_Detalle detalle in oE_Reporte_Precio.PrecioDetalle)
                {
                    error = error + RegistrarPrecioDetalle(detalle, id_reg_precio);
                }
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        private string RegistrarPrecioDetalle(E_Reporte_Precio_Detalle oE_Reporte_Precio_Detalle, String id_reg_precio)
        {
            try
            {
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("SP_GES_OPE_INSERTAR_PRECIO_DETALLE", id_reg_precio, oE_Reporte_Precio_Detalle.Id_producto ?? "",
                    oE_Reporte_Precio_Detalle.Precio_lista ?? "", oE_Reporte_Precio_Detalle.Precio_reventa ?? "",
                    oE_Reporte_Precio_Detalle.Precio_oferta ?? "", oE_Reporte_Precio_Detalle.Pvp ?? "",
                    oE_Reporte_Precio_Detalle.Precio_costo ?? "", oE_Reporte_Precio_Detalle.Precio_min ?? "",
                    oE_Reporte_Precio_Detalle.Precio_max ?? "", oE_Reporte_Precio_Detalle.Precio_regular ?? "",
                    oE_Reporte_Precio_Detalle.Motivo_obs ?? "", oE_Reporte_Precio_Detalle.Precio_mayorista ?? "");
                error = "";
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        #endregion

        #region App Movil Movistar

        public string Registrar_Precio_Mov(List<E_Reporte_Precio_Mov> ListaE_Reporte_Precio, string appEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Precio_Mov oE_Reporte_Precio in ListaE_Reporte_Precio)
                {
                    Registrar_Precio_Mov_Cabecera(oE_Reporte_Precio, appEnvia);
                    error = error + "";
                }
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }

            return error;
            
            //foreach (E_Reporte_Precio oE_Reporte_Precio in ListaE_Reporte_Precio)
            //{
            //    foreach (E_Reporte_Precio_Detalle oE_Reporte_Precio_Detalle in oE_Reporte_Precio.PrecioDetalle)
            //    {
            //        string result = oCoon.ejecutarretornodeOUTPUT("STP_JVM_VERIFICAR_DUPLICADOS_PRECIO", 4,
            //         oE_Reporte_Precio.Equipo_id,
            //         oE_Reporte_Precio.ClientePDV_Code,
            //         oE_Reporte_Precio.FechaRegistro,
            //         oE_Reporte_Precio_Detalle.Id_producto,
            //         "");
            //        if (result == "1")
            //        {
            //            error += RegistraPrecio(oE_Reporte_Precio, appEnvia);
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
        private void Registrar_Precio_Mov_Cabecera(E_Reporte_Precio_Mov oE_Reporte_Precio, string appEnvia)
        {
            string id_reg_precio = "";
            try
            {
                oCoon = new Conexion(3);
                id_reg_precio = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_PRECIO", 15, 
                    oE_Reporte_Precio.Cod_Persona,
                    oE_Reporte_Precio.Cod_Equipo , 
                    oE_Reporte_Precio.Cod_Compania , 
                    oE_Reporte_Precio.Cod_PtoVenta,
                    oE_Reporte_Precio.Cod_Categoria, 
                    oE_Reporte_Precio.Cod_Marca,
                    oE_Reporte_Precio.Cod_Familia ?? null, 
                    oE_Reporte_Precio.Cod_SubFamilia ?? null, 
                    oE_Reporte_Precio.Fecha_Registro, 
                    oE_Reporte_Precio.Latitud ?? null, 
                    oE_Reporte_Precio.Longitud ?? null,
                    oE_Reporte_Precio.Origen ?? null, 
                    oE_Reporte_Precio.Observacion ?? null, 
                    oE_Reporte_Precio.Tipo_Precio ?? null,
                    appEnvia ?? "0", "");
                foreach (E_Reporte_Precio_Mov_Detalle detalle in oE_Reporte_Precio.Detalle)
                {
                    Registrar_Precio_Mov_Detalle(detalle, id_reg_precio);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        private void Registrar_Precio_Mov_Detalle(E_Reporte_Precio_Mov_Detalle oE_Reporte_Precio_Detalle, String id_reg_precio)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_PRECIO_DETALLE", id_reg_precio, 
                    oE_Reporte_Precio_Detalle.Sku_Producto ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Lista ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Reventa ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Oferta ?? null,
                    oE_Reporte_Precio_Detalle.Precio_PVP ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Costo ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Regular ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Min ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Max ?? null,
                    oE_Reporte_Precio_Detalle.Motivo_Observacion ?? null,
                    oE_Reporte_Precio_Detalle.Precio_Mayorista ?? null);
               
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            
        }
        #endregion



    }
}
