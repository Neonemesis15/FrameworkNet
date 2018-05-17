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
    public class D_Reporte_Stock
    {
        private Conexion oCoon;
        public D_Reporte_Stock() {
            oCoon = new Conexion(2);
        }

        String error = string.Empty;
        #region App Movil Lucky
        public string Registrar_Reporte_Stock(List<E_Reporte_Stock> ListaE_Reporte_Stock, string appEnvia)
        {
            int valor = 1;
            string error = "";
            foreach(E_Reporte_Stock oE_Reporte_Stock  in ListaE_Reporte_Stock)
            {
                foreach (E_Reporte_Stock_Detalle oDetalle in oE_Reporte_Stock.StockDetalle)
                {
                    DataTable dt = oCoon.ejecutarDataTable("STP_JVM_VERIFICAR_DUPLICADOS_STOCK", oE_Reporte_Stock.Cliente_id, oE_Reporte_Stock.Equipo_id, oE_Reporte_Stock.ClientePDV_Code, oE_Reporte_Stock.FechaRegistro, oDetalle.Id_Familia);
                    if (dt.Rows[0]["EXISTE_REPORTS_PLANNING"].ToString() == "1")
                    {
                        if (dt.Rows[0]["EXISTE_CAB"].ToString() == "1" && dt.Rows[0]["EXISTE_ELEMENTO"].ToString() == "0")
                        {
                            //Registrar Detalle
                            Registrar_Reporte_Stock_Detalle(oDetalle, dt.Rows[0]["ID_REG_CABECERA"].ToString());
                            valor = valor * 1;
                        }
                        else if (dt.Rows[0]["EXISTE_CAB"].ToString() == "0")
                        {
                            //Inserta Cabecera y Detalle
                            Registrar_Reporte_Stock(oE_Reporte_Stock, appEnvia);
                            valor = valor * 1;
                        }
                        else {
                            valor = valor * 0;
                        }

                    }
                    else
                    {
                        error = "No se han Definido Periodos";
                        break;
                       
                    }

                }
                if (valor == 1) { error="";}
                else if(valor==0){error="Hay Data Duplicada para este Periodo";}
                error += Registrar_Reporte_Stock(oE_Reporte_Stock, appEnvia);
            }

            return error;
        }
        public string Registrar_Reporte_Stock(E_Reporte_Stock oE_Reporte_Stock, string appEnvia)
        {
            string id_reg_Stock = "";
            string id = "";

            oCoon = new Conexion(2);
            try{
                
                id = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_INSERTAR_STOCK", 15, oE_Reporte_Stock.Person_id ?? "",
                oE_Reporte_Stock.Perfil_id ?? "", oE_Reporte_Stock.Equipo_id ?? "", oE_Reporte_Stock.Cliente_id ?? "",
                oE_Reporte_Stock.ClientePDV_Code ?? "", oE_Reporte_Stock.Categoria ?? "", oE_Reporte_Stock.Marca ?? "",
                oE_Reporte_Stock.ProductFamily ?? "", oE_Reporte_Stock.ProductSubFamily ?? "", oE_Reporte_Stock.FechaRegistro ?? "",
                oE_Reporte_Stock.Latitud ?? "", oE_Reporte_Stock.Longitud ?? "", oE_Reporte_Stock.OrigenCoordenada ?? "",
                oE_Reporte_Stock.Observacion ?? "", appEnvia ?? "", id_reg_Stock);
           
                foreach (E_Reporte_Stock_Detalle detalle in oE_Reporte_Stock.StockDetalle) {
                    error = error + Registrar_Reporte_Stock_Detalle(detalle, id);
                }
            }
            catch (Exception ex) {
                error = error + ex.Message;
                throw ex;
            }
            return error;
        }
        public string Registrar_Reporte_Stock_Detalle(E_Reporte_Stock_Detalle oDetalle, string id)
        {
            try {
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("SP_GES_OPE_INSERTAR_STOCK_DETALLE", id, oDetalle.Id_Familia ?? "", oDetalle.Cantidad ?? "", oDetalle.Id_Producto ?? "",
                    oDetalle.Pedido, oDetalle.Ingreso ?? "", oDetalle.Venta ?? "", oDetalle.Motivo_Obs ?? "", oDetalle.Semana ?? "0", oDetalle.Exhibicion ?? "",
                    oDetalle.Camara, oDetalle.Opcion ?? "");
                error = "";
            }
            catch (Exception ex) {
                error = error + ex.Message;
            }
            return error;
        }
        #endregion

        #region AppMovil Movistar
        public string Registrar_Reporte_Stock_Mov(List<E_Reporte_Stock_Mov> oListaReporte, string appEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Stock_Mov oEReporte in oListaReporte)
                {
                    Registrar_Reporte_Stock_Mov_Cabecera(oEReporte, appEnvia);
                    error += "";
                }
            }
            catch (Exception ex) {
                error += ex.Message;
                throw ex;
            }
            return error;

            #region Warning controlar Duplicados
            //int valor = 1;
            //string error = "";
            //foreach (E_Reporte_Stock oE_Reporte_Stock in ListaE_Reporte_Stock)
            //{
            //    foreach (E_Reporte_Stock_Detalle oDetalle in oE_Reporte_Stock.StockDetalle)
            //    {
            //        DataTable dt = oCoon.ejecutarDataTable("STP_JVM_VERIFICAR_DUPLICADOS_STOCK", oE_Reporte_Stock.Cliente_id, oE_Reporte_Stock.Equipo_id, oE_Reporte_Stock.ClientePDV_Code, oE_Reporte_Stock.FechaRegistro, oDetalle.Id_Familia);
            //        if (dt.Rows[0]["EXISTE_REPORTS_PLANNING"].ToString() == "1")
            //        {
            //            if (dt.Rows[0]["EXISTE_CAB"].ToString() == "1" && dt.Rows[0]["EXISTE_ELEMENTO"].ToString() == "0")
            //            {
            //                //Registrar Detalle
            //                Registrar_Reporte_Stock_Detalle(oDetalle, dt.Rows[0]["ID_REG_CABECERA"].ToString());
            //                valor = valor * 1;
            //            }
            //            else if (dt.Rows[0]["EXISTE_CAB"].ToString() == "0")
            //            {
            //                //Inserta Cabecera y Detalle
            //                Registrar_Reporte_Stock(oE_Reporte_Stock, appEnvia);
            //                valor = valor * 1;
            //            }
            //            else
            //            {
            //                valor = valor * 0;
            //            }

            //        }
            //        else
            //        {
            //            error = "No se han Definido Periodos";
            //            break;

            //        }

            //    }
            //    if (valor == 1) { error = ""; }
            //    else if (valor == 0) { error = "Hay Data Duplicada para este Periodo"; }
            //    error += Registrar_Reporte_Stock(oE_Reporte_Stock, appEnvia);
            //}

            //return error;
#endregion
        }
        private void Registrar_Reporte_Stock_Mov_Cabecera(E_Reporte_Stock_Mov oE_Reporte, string appEnvia)
        {
            string id_reg_Stock = "";
            string id = "";

            oCoon = new Conexion(3);
            try
            {

                id = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_STOCK", 14, 
                oE_Reporte.Cod_Persona,
                oE_Reporte.Cod_Equipo, 
                oE_Reporte.Cod_Compania, 
                oE_Reporte.Cod_PtoVenta,
                oE_Reporte.Cod_Categoria ?? null, 
                oE_Reporte.Cod_Marca ?? null, 
                oE_Reporte.Cod_Familia ?? null,
                oE_Reporte.Cod_SubFamilia ?? null, 
                oE_Reporte.Fecha_Registro, 
                oE_Reporte.Latitud ?? null,
                oE_Reporte.Longitud ?? null, 
                oE_Reporte.Origen ?? null,
                oE_Reporte.Observacion ?? null, 
                appEnvia ?? "0", id_reg_Stock);

                foreach (E_Reporte_Stock_Mov_Detalle detalle in oE_Reporte.Detalle)
                {
                    Registrar_Reporte_Stock_Mov_Detalle(detalle, id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        private void Registrar_Reporte_Stock_Mov_Detalle(E_Reporte_Stock_Mov_Detalle oDetalle, string id)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_STOCK_DETALLE", id, 
                    oDetalle.Cod_Familia ?? null, 
                    oDetalle.Cantidad ?? null, 
                    oDetalle.Motivo_Obs ?? null,
                    oDetalle.SKU_Producto ?? null,
                    oDetalle.Pedido ?? null,
                    oDetalle.Ingreso ?? null,
                    oDetalle.Venta ?? null,
                    oDetalle.Semana ?? null,
                    oDetalle.Exhibicion ?? null,
                    oDetalle.Camara ?? null,
                    oDetalle.Opcion ?? null);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        #endregion

    }
}
