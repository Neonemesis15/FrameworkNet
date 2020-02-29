using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Servicio;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.CFG.Util;

namespace Lucky.Data.Common.Servicio
{
    public class D_GES_Operativa
    {
        // Variable de Çonexion
        private Conexion oCoon;
        
        // Variable para guardar los Errores
        private String messages = "";

        /// <summary>
        /// Función para retornar los mensajes de Error
        /// </summary>
        /// <returns></returns>
        public String getMessages() {
            return messages;
        }

        public D_GES_Operativa()
        {
            oCoon = new Conexion();
        }
        #region Gestion Reporte - Consultar
        //---En Desarrollo
        //---Descripcion: Consultar Reporte de Stock General
        //---Fecha      : 12/05/2012 PSA
        public List<E_Consulta_Reporte_Stock> Consultar_Reporte_Stock_General_Validado(string CodServicio, int CodCompania, string CodCanal, int CodOficina, string CodCategoria, int CodReporteCampania, string TipoData)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_VALIDADO_STOCK_ALI_MAY", CodServicio, CodCompania, CodCanal, CodOficina, CodCategoria, CodReporteCampania, TipoData);
            List<E_Consulta_Reporte_Stock> olistaConsultaReporte = new List<E_Consulta_Reporte_Stock>();
            try
            {
                while (readerObj.Read())
                {
                    E_Consulta_Reporte_Stock oE_Consulta_Reporte_Stock = new E_Consulta_Reporte_Stock();
                    oE_Consulta_Reporte_Stock.Nombre_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Name_Oficina")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Nombre_Zona = readerObj.GetValue(readerObj.GetOrdinal("Zona")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Codigo_PDV_Compania = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Nombre_PDV = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("product_Category")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Nombre_Familia = readerObj.GetValue(readerObj.GetOrdinal("name_Family")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Cantidad = readerObj.GetValue(readerObj.GetOrdinal("Cantidad")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Registrado_Por = readerObj.GetValue(readerObj.GetOrdinal("Person_name")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Fecha_Registro_Bd = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")));
                    oE_Consulta_Reporte_Stock.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("validClient")));
                    oE_Consulta_Reporte_Stock.Cod_Stock_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Id_StockDet")));

                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Stock);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count > 0)
                {
                    return olistaConsultaReporte;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }

        }

        public void Validar_Reporte_Stock(string oListaValidar, string oListaInvalidar)
        {
            try
            {
                oCoon = new Conexion(1);
                oCoon.ejecutarDataTable("SP_GES_OPE_VALIDAR_STOCK_CLIENTE", oListaValidar ?? "", oListaInvalidar ?? "");
            }
            catch (Exception)
            {
            }
        }

        //---Ok
        //---Descripcion: Consultar Reporte de Stock General
        //---Fecha      : 12/05/2012 PSA
        public List<E_Consulta_Reporte_Stock> Consultar_Reporte_Stock_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodFamilia, DateTime f_incio, DateTime f_fin)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_CONSULTA_STOCK", CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodFamilia, f_incio, f_fin);
            List<E_Consulta_Reporte_Stock> olistaConsultaReporte = new List<E_Consulta_Reporte_Stock>();
            try
            {
                while (readerObj.Read())
                {
                    E_Consulta_Reporte_Stock oE_Consulta_Reporte_Stock = new E_Consulta_Reporte_Stock();
                    oE_Consulta_Reporte_Stock.Abreviatura_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Abreviatura")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Nombre_PDV = readerObj.GetValue(readerObj.GetOrdinal("Punto de Venta")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Nombre_Familia = readerObj.GetValue(readerObj.GetOrdinal("Familia")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Cantidad = readerObj.GetValue(readerObj.GetOrdinal("Cantidad")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Registrado_Por = readerObj.GetValue(readerObj.GetOrdinal("Person_name")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Fecha_Registro_Bd = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")));
                    oE_Consulta_Reporte_Stock.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Fecha_Modificacion = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("DateModiBy")));
                    oE_Consulta_Reporte_Stock.Validado = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado")));
                    //oE_Consulta_Reporte_Stock.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("validClient")));
                    oE_Consulta_Reporte_Stock.Validado_Cliente = false; //Pendiente : Crear el Campo en la Tabla Reporte Stock 14/05/2012
                    oE_Consulta_Reporte_Stock.Cod_Stock_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Id_rstkd")));
                    oE_Consulta_Reporte_Stock.Nombre_NodoComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();
                    oE_Consulta_Reporte_Stock.Peso_Familia = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("family_Peso")));

                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Stock);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count <= 0)
                {
                    E_Consulta_Reporte_Stock oE_Consulta_Reporte_Stock = new E_Consulta_Reporte_Stock();
                    oE_Consulta_Reporte_Stock.Nombre_Oficina = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Nombre_Zona = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Nombre_PDV = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Nombre_Categoria = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Nombre_Familia = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Cantidad = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Registrado_Por = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Modificado_Por = "Sin Informacion";
                    oE_Consulta_Reporte_Stock.Validado_Cliente = Convert.ToBoolean("0");
                    oE_Consulta_Reporte_Stock.Cod_Stock_Detalle = Convert.ToInt32("0");

                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Stock);
                }

            }
            catch (Exception ex)
            {

                E_Consulta_Reporte_Stock oE_Consulta_Reporte_Stock = new E_Consulta_Reporte_Stock();
                oE_Consulta_Reporte_Stock.Nombre_Oficina = "" + ex.Message;
                olistaConsultaReporte.Add(oE_Consulta_Reporte_Stock);
            }
            return olistaConsultaReporte;
        }

        //---Ok
        //---   Descripcion : Consulta para DataMercaderista MVC
        //---   Fecha       : 14/05/2012 - PSA
        public List<E_Consulta_Reporte_Precio> Consultar_Reporte_Precio_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodSubcategoria, string CodMarca, string codProducto, DateTime f_incio, DateTime f_fin)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_CONSULTA_PRECIO", CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodSubcategoria, CodMarca, codProducto, f_incio, f_fin);
            List<E_Consulta_Reporte_Precio> olistaConsultaReporte = new List<E_Consulta_Reporte_Precio>();
            try
            {
                while (readerObj.Read())
                {

                    E_Consulta_Reporte_Precio oE_Consulta_Reporte_Precio = new E_Consulta_Reporte_Precio();
                    oE_Consulta_Reporte_Precio.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.Nombre_SubCategoria = readerObj.GetValue(readerObj.GetOrdinal("SubCategoria")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("Marca")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.Nombre_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("Punto de Venta")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.Nombre_Producto = readerObj.GetValue(readerObj.GetOrdinal("Producto")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.SKU = (readerObj.GetValue(readerObj.GetOrdinal("SKU")).ToString().Trim());
                    oE_Consulta_Reporte_Precio.Precio_Lista = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Precio Lista")));
                    oE_Consulta_Reporte_Precio.Precio_Reventa = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Precio Reventa")));
                    oE_Consulta_Reporte_Precio.Precio_Oferta = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Precio de Oferta")));
                    oE_Consulta_Reporte_Precio.Precio_PuntoDeVenta = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Precio Punto de Venta")));
                    oE_Consulta_Reporte_Precio.Precio_Costo = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Precio Costo")));
                    oE_Consulta_Reporte_Precio.Precio_Maximo = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Precio_MIN")));
                    oE_Consulta_Reporte_Precio.Precio_Minimo = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Precio_MAX")));
                    oE_Consulta_Reporte_Precio.Registrado_Por = readerObj.GetValue(readerObj.GetOrdinal("Person_name")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.Validado = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado")));
                    oE_Consulta_Reporte_Precio.Validado_Cliente = false;
                    //oE_Consulta_Reporte_Precio.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado_Cliente")));
                    oE_Consulta_Reporte_Precio.Cod_Precio_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Id")));
                    oE_Consulta_Reporte_Precio.Fecha_Registro_BD = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")).ToString().Trim());
                    oE_Consulta_Reporte_Precio.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.Fecha_Modificacion = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("DateModiBy")).ToString().Trim());
                    oE_Consulta_Reporte_Precio.Observacion = readerObj.GetValue(readerObj.GetOrdinal("Observacion")).ToString().Trim();
                    oE_Consulta_Reporte_Precio.Cod_Cliente_PDV = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim(); ;
                    oE_Consulta_Reporte_Precio.Nombre_NodoComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim(); ;
                    oE_Consulta_Reporte_Precio.Nombre_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Oficina")).ToString().Trim(); ;

                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Precio);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count <= 0)
                {
                    E_Consulta_Reporte_Precio oE_Consulta_Reporte_Precio = new E_Consulta_Reporte_Precio();
                    oE_Consulta_Reporte_Precio.Nombre_Oficina = "Sin Informacion";
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Precio);
                }

            }
            catch (Exception ex)
            {

                E_Consulta_Reporte_Precio oE_Consulta_Reporte_Precio = new E_Consulta_Reporte_Precio();
                oE_Consulta_Reporte_Precio.Nombre_Oficina = "" + ex.Message;
                olistaConsultaReporte.Add(oE_Consulta_Reporte_Precio);

            }
            return olistaConsultaReporte;

        }

        //---Warning
        //---   Descripcion : Consulta para DataMercaderista MVC
        //---   Fecha       : 14/05/2012 - PSA
        public List<E_Consulta_Reporte_SOD> Consultar_Reporte_SOD_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, DateTime f_incio, DateTime f_fin)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_CONSULTA_SOD", CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, f_incio, f_fin);
            List<E_Consulta_Reporte_SOD> olistaConsultaReporte = new List<E_Consulta_Reporte_SOD>();
            try
            {
                while (readerObj.Read())
                {

                    E_Consulta_Reporte_SOD oE_Consulta_Reporte_SOD = new E_Consulta_Reporte_SOD();
                    oE_Consulta_Reporte_SOD.Nombre_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("Punto de Venta")).ToString().Trim();
                    oE_Consulta_Reporte_SOD.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
                    oE_Consulta_Reporte_SOD.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("Marca")).ToString().Trim();
                    oE_Consulta_Reporte_SOD.Exhibicion_Primaria = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Exhib_Primaria")));
                    oE_Consulta_Reporte_SOD.Exhibicion_Secundaria = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Exhib_Secundaria")));
                    oE_Consulta_Reporte_SOD.Registrado = readerObj.GetValue(readerObj.GetOrdinal("Registrado")).ToString().Trim();
                    oE_Consulta_Reporte_SOD.Validado = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado")));
                    //oE_Consulta_Reporte_SOD.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado_Cliente")));
                    oE_Consulta_Reporte_SOD.Validado_Cliente = false;
                    oE_Consulta_Reporte_SOD.Cod_SOD_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("id_rpsd")));
                    oE_Consulta_Reporte_SOD.Fecha_Registro_BD = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")));
                    oE_Consulta_Reporte_SOD.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_SOD.Fecha_Modificacion = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("DateModiBy")));
                    oE_Consulta_Reporte_SOD.Codigo_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim(); ;
                    oE_Consulta_Reporte_SOD.Nombre_NodoComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();
                    oE_Consulta_Reporte_SOD.Nombre_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Oficina")).ToString().Trim();

                    olistaConsultaReporte.Add(oE_Consulta_Reporte_SOD);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count <= 0)
                {
                    E_Consulta_Reporte_SOD oE_Consulta_Reporte_SOD = new E_Consulta_Reporte_SOD();
                    oE_Consulta_Reporte_SOD.Nombre_Oficina = "Sin Informacion";
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_SOD);
                }

            }
            catch (Exception ex)
            {

                E_Consulta_Reporte_SOD oE_Consulta_Reporte_SOD = new E_Consulta_Reporte_SOD();
                oE_Consulta_Reporte_SOD.Nombre_Oficina = "" + ex.Message;
                olistaConsultaReporte.Add(oE_Consulta_Reporte_SOD);

            }
            return olistaConsultaReporte;

        }

        //---Warning
        //---   Descripcion : Consulta para DataMercaderista MVC
        //---   Fecha       : 14/05/2012 - PSA
        public List<E_Consulta_Reporte_LayOut> Consultar_Reporte_LayOut_General(string CodPersona, string CodCampania, string CodCanal, string CodCategoria, string CodMarca, DateTime f_incio, DateTime f_fin)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_CONSULTA_LAYOUT", CodPersona, CodCampania, CodCanal, CodCategoria, CodMarca, f_incio, f_fin);
            List<E_Consulta_Reporte_LayOut> olistaConsultaReporte = new List<E_Consulta_Reporte_LayOut>();
            try
            {
                while (readerObj.Read())
                {

                    E_Consulta_Reporte_LayOut oE_Consulta_Reporte_LayOut = new E_Consulta_Reporte_LayOut();

                    oE_Consulta_Reporte_LayOut.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
                    oE_Consulta_Reporte_LayOut.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("Marca")).ToString().Trim();
                    oE_Consulta_Reporte_LayOut.Objetivo = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Objetivo")));
                    oE_Consulta_Reporte_LayOut.Cantidad = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Cantidad")));
                    oE_Consulta_Reporte_LayOut.Frentes = Convert.ToUInt16(readerObj.GetValue(readerObj.GetOrdinal("Frentes")));
                    oE_Consulta_Reporte_LayOut.Registrado_Por = readerObj.GetValue(readerObj.GetOrdinal("Registrado por")).ToString().Trim();
                    oE_Consulta_Reporte_LayOut.Validado = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado")));
                    //oE_Consulta_Reporte_SOD.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado_Cliente")));
                    oE_Consulta_Reporte_LayOut.Validado_Cliente = false;
                    oE_Consulta_Reporte_LayOut.Cod_LayOut_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("id_layout")));
                    ///falta 1
                    oE_Consulta_Reporte_LayOut.Fecha_Registro_BD = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_BD")));
                    oE_Consulta_Reporte_LayOut.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_LayOut.Fecha_Modificacion = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("DateModiBy")));
                    oE_Consulta_Reporte_LayOut.Codigo_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim(); ;
                    oE_Consulta_Reporte_LayOut.Nombre_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Oficina")).ToString().Trim();
                    oE_Consulta_Reporte_LayOut.Nombre_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    oE_Consulta_Reporte_LayOut.Nombre_NodoComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_LayOut);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count <= 0)
                {
                    E_Consulta_Reporte_LayOut oE_Consulta_Reporte_LayOut = new E_Consulta_Reporte_LayOut();
                    oE_Consulta_Reporte_LayOut.Nombre_Oficina = "Sin Informacion";
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_LayOut);
                }

            }
            catch (Exception ex)
            {

                E_Consulta_Reporte_LayOut oE_Consulta_Reporte_LayOut = new E_Consulta_Reporte_LayOut();
                oE_Consulta_Reporte_LayOut.Nombre_Oficina = "" + ex.Message;
                olistaConsultaReporte.Add(oE_Consulta_Reporte_LayOut);

            }
            return olistaConsultaReporte;

        }

        //---Warning
        //---   Descripcion : Consulta para DataMercaderista MVC
        //---   Fecha       : 14/05/2012 - PSA
        public List<E_Consulta_Reporte_Quiebre> Consultar_Reporte_Quiebre_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, string codProducto, DateTime f_incio, DateTime f_fin)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_CONSULTA_QUIEBRE", CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, codProducto, f_incio, f_fin);
            List<E_Consulta_Reporte_Quiebre> olistaConsultaReporte = new List<E_Consulta_Reporte_Quiebre>();
            try
            {
                while (readerObj.Read())
                {

                    E_Consulta_Reporte_Quiebre oE_Consulta_Reporte_Quiebre = new E_Consulta_Reporte_Quiebre();

                    oE_Consulta_Reporte_Quiebre.Nombre_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("Punto de Venta")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Nombre_Producto = (readerObj.GetValue(readerObj.GetOrdinal("Producto")).ToString().Trim());
                    oE_Consulta_Reporte_Quiebre.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("Marca")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Quiebre = readerObj.GetValue(readerObj.GetOrdinal("Quiebre")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Descripcion = readerObj.GetValue(readerObj.GetOrdinal("Descripcion")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Validado = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado")));
                    //oE_Consulta_Reporte_Quiebre.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado_Cliente")));
                    oE_Consulta_Reporte_Quiebre.Validado_Cliente = false;
                    oE_Consulta_Reporte_Quiebre.Cod_Quiebre_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("id_reqd")));
                    oE_Consulta_Reporte_Quiebre.Nombre_Mercaderista = readerObj.GetValue(readerObj.GetOrdinal("Person_name")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Fecha_Registro_BD = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")));
                    oE_Consulta_Reporte_Quiebre.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Fecha_Modificacion = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("DateModiBy")));
                    oE_Consulta_Reporte_Quiebre.Codigo_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim(); ;
                    oE_Consulta_Reporte_Quiebre.Nombre_NodoComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();
                    oE_Consulta_Reporte_Quiebre.Cod_Producto = readerObj.GetValue(readerObj.GetOrdinal("cod_Product")).ToString().Trim();
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Quiebre);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count <= 0)
                {
                    E_Consulta_Reporte_Quiebre oE_Consulta_Reporte_Quiebre = new E_Consulta_Reporte_Quiebre();
                    oE_Consulta_Reporte_Quiebre.Descripcion = "Sin Informacion";
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Quiebre);
                }

            }
            catch (Exception ex)
            {

                E_Consulta_Reporte_Quiebre oE_Consulta_Reporte_Quiebre = new E_Consulta_Reporte_Quiebre();
                oE_Consulta_Reporte_Quiebre.Descripcion = " " + ex.Message;
                olistaConsultaReporte.Add(oE_Consulta_Reporte_Quiebre);

            }
            return olistaConsultaReporte;

        }

        //---Warning
        //---   Descripcion : Consulta para DataMercaderista MVC
        //---   Fecha       : 14/05/2012 - PSA
        public List<E_Consulta_Reporte_Exhibicion> Consultar_Reporte_Exhibicion_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, string f_incio, string f_fin)
        {
            //Conexion oCoon = new Conexion(4);
            SqlDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_CONSULTA_EXHIBICION", CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, f_incio, f_fin);
            List<E_Consulta_Reporte_Exhibicion> olistaConsultaReporte = new List<E_Consulta_Reporte_Exhibicion>();
            try
            {
                while (readerObj.Read())
                {

                    E_Consulta_Reporte_Exhibicion oE_Consulta_Reporte_Exhibicion = new E_Consulta_Reporte_Exhibicion();

                    oE_Consulta_Reporte_Exhibicion.Nombre_Foto = readerObj.GetValue(readerObj.GetOrdinal("Foto")).ToString().Trim();//Peter Ccopa - 24/08/2012
                    oE_Consulta_Reporte_Exhibicion.Num_Fila = readerObj.GetValue(readerObj.GetOrdinal("ROWID")).ToString().Trim();//Peter Ccopa - 24/08/2012
                    oE_Consulta_Reporte_Exhibicion.Id_Reporte = readerObj.GetValue(readerObj.GetOrdinal("Id_rexhd")).ToString().Trim();//Peter Ccopa - 24/08/2012
                    
                    oE_Consulta_Reporte_Exhibicion.Nombre_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("Punto de Venta")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("Marca")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Fecha_Inicio = (readerObj.GetValue(readerObj.GetOrdinal("Fecha_Inicio")).ToString().Trim());
                    oE_Consulta_Reporte_Exhibicion.Fecha_Fin = readerObj.GetValue(readerObj.GetOrdinal("Fecha_Fin")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Cantidad = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Cantidad")).ToString().Trim());
                    oE_Consulta_Reporte_Exhibicion.Descripcion = readerObj.GetValue(readerObj.GetOrdinal("Descripcion")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Validado = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado")));
                    //oE_Consulta_Reporte_Quiebre.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado_Cliente")));
                    oE_Consulta_Reporte_Exhibicion.Validado_Cliente = false;
                    oE_Consulta_Reporte_Exhibicion.Cod_Exhibicion_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("id_rexhd")));
                    oE_Consulta_Reporte_Exhibicion.Nombre_Mercaderista = readerObj.GetValue(readerObj.GetOrdinal("Person_name")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Fecha_Registro_BD = readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")).ToString().Trim();//Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")));
                    oE_Consulta_Reporte_Exhibicion.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Fecha_Modificacion = readerObj.GetValue(readerObj.GetOrdinal("DateModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Codigo_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim(); ;
                    oE_Consulta_Reporte_Exhibicion.Nombre_NodoComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();

                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Exhibicion);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count <= 0)
                {
                    E_Consulta_Reporte_Exhibicion oE_Consulta_Reporte_Exhibicion = new E_Consulta_Reporte_Exhibicion();
                    oE_Consulta_Reporte_Exhibicion.Descripcion = "Sin Informacion";
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Exhibicion);
                }

            }
            catch (Exception ex)
            {

                E_Consulta_Reporte_Exhibicion oE_Consulta_Reporte_Exhibicion = new E_Consulta_Reporte_Exhibicion();
                oE_Consulta_Reporte_Exhibicion.Descripcion = " " + ex.Message;
                olistaConsultaReporte.Add(oE_Consulta_Reporte_Exhibicion);

            }
            return olistaConsultaReporte;

        }

        //---Warning
        //---   Descripcion : Consulta para DataMercaderista MVC
        //---   Fecha       : 14/05/2012 - PSA
        public List<E_Consulta_Reporte_Exhibicion> Consultar_Reporte_Exhibicion(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, string f_incio, string f_fin)
        {
            Conexion oCoon = new Conexion(4);
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_CONSULTA_REPORTE_EXHIBICION", CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, f_incio, f_fin);
            List<E_Consulta_Reporte_Exhibicion> olistaConsultaReporte = new List<E_Consulta_Reporte_Exhibicion>();
            try
            {
                while (readerObj.Read())
                {

                    E_Consulta_Reporte_Exhibicion oE_Consulta_Reporte_Exhibicion = new E_Consulta_Reporte_Exhibicion();

                    oE_Consulta_Reporte_Exhibicion.Nombre_Foto = readerObj.GetValue(readerObj.GetOrdinal("Foto")).ToString().Trim();//Peter Ccopa - 24/08/2012
                    oE_Consulta_Reporte_Exhibicion.Num_Fila = readerObj.GetValue(readerObj.GetOrdinal("ROWID")).ToString().Trim();//Peter Ccopa - 24/08/2012
                    oE_Consulta_Reporte_Exhibicion.Id_Reporte = readerObj.GetValue(readerObj.GetOrdinal("Id_rexhd")).ToString().Trim();//Peter Ccopa - 24/08/2012

                    oE_Consulta_Reporte_Exhibicion.Nombre_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("Punto de Venta")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("Marca")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Fecha_Inicio = (readerObj.GetValue(readerObj.GetOrdinal("Fecha_inicio")).ToString().Trim());
                    oE_Consulta_Reporte_Exhibicion.Fecha_Fin = readerObj.GetValue(readerObj.GetOrdinal("Fecha_Fin")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Cantidad = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Cantidad")).ToString().Trim());
                    oE_Consulta_Reporte_Exhibicion.Descripcion = readerObj.GetValue(readerObj.GetOrdinal("descripcion")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Validado = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado")));
                    //oE_Consulta_Reporte_Quiebre.Validado_Cliente = Convert.ToBoolean(readerObj.GetValue(readerObj.GetOrdinal("Validado_Cliente")));
                    oE_Consulta_Reporte_Exhibicion.Validado_Cliente = false;
                    oE_Consulta_Reporte_Exhibicion.Cod_Exhibicion_Detalle = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("id_rexhd")));
                    oE_Consulta_Reporte_Exhibicion.Nombre_Mercaderista = readerObj.GetValue(readerObj.GetOrdinal("Person_name")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Fecha_Registro_BD = readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")).ToString().Trim();//Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_Reg_Bd")));
                    oE_Consulta_Reporte_Exhibicion.Modificado_Por = readerObj.GetValue(readerObj.GetOrdinal("ModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Fecha_Modificacion = readerObj.GetValue(readerObj.GetOrdinal("DateModiBy")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Codigo_PuntoDeVenta = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim(); ;
                    oE_Consulta_Reporte_Exhibicion.Nombre_NodoComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();
                    oE_Consulta_Reporte_Exhibicion.Registrado_Por = readerObj.GetValue(readerObj.GetOrdinal("Registrado por")).ToString().Trim();

                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Exhibicion);
                }
                readerObj.Close();

                if (olistaConsultaReporte.Count <= 0)
                {
                    E_Consulta_Reporte_Exhibicion oE_Consulta_Reporte_Exhibicion = new E_Consulta_Reporte_Exhibicion();
                    oE_Consulta_Reporte_Exhibicion.Descripcion = "Sin Informacion";
                    olistaConsultaReporte.Add(oE_Consulta_Reporte_Exhibicion);
                }

            }
            catch (Exception ex)
            {

                E_Consulta_Reporte_Exhibicion oE_Consulta_Reporte_Exhibicion = new E_Consulta_Reporte_Exhibicion();
                oE_Consulta_Reporte_Exhibicion.Descripcion = " " + ex.Message;
                olistaConsultaReporte.Add(oE_Consulta_Reporte_Exhibicion);

            }
            return olistaConsultaReporte;

        }

        /// <summary>
        /// Fecha: 15/08/2012
        /// Autor: Ditmar Estrada
        /// Descripción: Método que devuelve los datos del reporte de presencia para una campaña especifica en un rango de fechas
        /// </summary>
        /// 
        public List<E_Consulta_Reporte_Presencia> Consultar_Reporte_Presencia(string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV, string CodCategoria, string CodMarca, string CodSupervisor, string CodPersona, string CodTipoReporte, DateTime f_incio, DateTime f_fin)
        {
            List<E_Consulta_Reporte_Presencia> oListConsulta_Reporte_Presencia = null;
            try
            {
                DataTable dt = oCoon.ejecutarDataTable("UP_WEBXPLORA_OPE_CONSULTA_PRESENCIA", CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV, CodCategoria, CodMarca, CodSupervisor, CodPersona, CodTipoReporte, f_incio, f_fin);

                if (dt.Rows.Count > 0)
                {
                    oListConsulta_Reporte_Presencia = new List<E_Consulta_Reporte_Presencia>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Consulta_Reporte_Presencia oE_Consulta_Reporte_Presencia = new E_Consulta_Reporte_Presencia();

                        oE_Consulta_Reporte_Presencia.fec_reg_cel = dt.Rows[i]["fec_reg_cel"].ToString();
                        oE_Consulta_Reporte_Presencia.oficina = dt.Rows[i]["oficina"].ToString();
                        oE_Consulta_Reporte_Presencia.supervisor = dt.Rows[i]["supervisor"].ToString();
                        oE_Consulta_Reporte_Presencia.mercaderista = dt.Rows[i]["mercaderista"].ToString();
                        oE_Consulta_Reporte_Presencia.nodocomercial = dt.Rows[i]["nodocomercial"].ToString();
                        oE_Consulta_Reporte_Presencia.PDV_Client = dt.Rows[i]["PDV_Client"].ToString();
                        oE_Consulta_Reporte_Presencia.pdv = dt.Rows[i]["pdv"].ToString();
                        oE_Consulta_Reporte_Presencia.tiporeporte = dt.Rows[i]["tiporeporte"].ToString();
                        oE_Consulta_Reporte_Presencia.categoria = dt.Rows[i]["categoria"].ToString();
                        oE_Consulta_Reporte_Presencia.marca = dt.Rows[i]["marca"].ToString();
                        oE_Consulta_Reporte_Presencia.descripcion = dt.Rows[i]["descripción"].ToString();
                        oE_Consulta_Reporte_Presencia.valor = dt.Rows[i]["valor"].ToString();
                        oE_Consulta_Reporte_Presencia.createby = dt.Rows[i]["createby"].ToString();
                        oE_Consulta_Reporte_Presencia.dateby = dt.Rows[i]["dateby"].ToString();
                        oE_Consulta_Reporte_Presencia.modiby = dt.Rows[i]["modiby"].ToString();
                        oE_Consulta_Reporte_Presencia.datemodiby = dt.Rows[i]["datemodiby"].ToString();
                        oE_Consulta_Reporte_Presencia.validado = Convert.ToBoolean(dt.Rows[i]["validado"]);
                        oE_Consulta_Reporte_Presencia.id_detalle_presencia = dt.Rows[i]["id_detalle_presencia"].ToString();
                        oE_Consulta_Reporte_Presencia.opcion_reporte = dt.Rows[i]["opcion_reporte"].ToString();

                        oListConsulta_Reporte_Presencia.Add(oE_Consulta_Reporte_Presencia);
                    }
                }

                return oListConsulta_Reporte_Presencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Reporte_Relevo> Consulta_Reporte_Relevo(string fechaConsulta, string codCliente, string codUsuario,
    string codCanal, string codPais, string codDepartamento, string codProvincia)
        {
            List<E_Reporte_Relevo> oListConsulta_Reporte_Relevo = null;
            try
            {
                DataTable dt = oCoon.ejecutarDataTable("UP_GES_OPE_CONSULTA_REPORTE_RELEVO", fechaConsulta, codCliente,
                    codUsuario, codCanal, codPais, codDepartamento, codProvincia);

                if (dt.Rows.Count > 0)
                {
                    oListConsulta_Reporte_Relevo = new List<E_Reporte_Relevo>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Reporte_Relevo oE_Reporte_Relevo = new E_Reporte_Relevo();

                        oE_Reporte_Relevo.codigoGestor = dt.Rows[i]["codigoGestor"].ToString();
                        oE_Reporte_Relevo.nombreGestor = dt.Rows[i]["nombreGestor"].ToString();
                        oE_Reporte_Relevo.objetivoDiario = dt.Rows[i]["objetivoDiario"].ToString();
                        oE_Reporte_Relevo.pdvVisitado = dt.Rows[i]["pdvVisitado"].ToString();
                        oE_Reporte_Relevo.pdvRelevo = dt.Rows[i]["pdvRelevo"].ToString();
                        oE_Reporte_Relevo.cumplimientoValor = dt.Rows[i]["cumplimientoValor"].ToString();
                        oE_Reporte_Relevo.cumplimientoColor = dt.Rows[i]["cumplimientoColor"].ToString();
                        oE_Reporte_Relevo.pdvNuevo = dt.Rows[i]["pdvNuevo"].ToString();

                        oListConsulta_Reporte_Relevo.Add(oE_Reporte_Relevo);
                    }
                }

                return oListConsulta_Reporte_Relevo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_ContentStringDataSet Consultar_ReportePresenciaConsolidado(string CodCampania, string CodEquipo, string CodCanal, string CodMercaderista, string CodOficina, string CodMalla, string CodigoPDV, string CodTipoReporte, DateTime f_incio, DateTime f_fin)
        {
            E_ContentStringDataSet oE_ContentStringDataSet = new E_ContentStringDataSet();
            try
            {
                DataSet ds = oCoon.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTA_PRESENCIA_WITH_PIVOT",
                 CodCampania, CodEquipo, CodCanal, CodMercaderista, CodOficina, CodMalla, CodigoPDV, CodTipoReporte, f_incio, f_fin);

                for (int k = 0; k < ds.Tables.Count; k++)
                {
                    E_ContentStringDataTable oE_ContentStringDataTable = new E_ContentStringDataTable();

                    DataTable dt = ds.Tables[k];

                    //Inicializamos los Array
                    oE_ContentStringDataTable.Header = new string[dt.Columns.Count];
                    oE_ContentStringDataTable.Contents = new string[dt.Rows.Count][];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        oE_ContentStringDataTable.Contents[i] = new string[dt.Columns.Count];
                    }
                    //Obtenemos las cabeceras
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        oE_ContentStringDataTable.Header[i] = dt.Columns[i].ColumnName;
                    }
                    //Obtenemos los Detalles
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            oE_ContentStringDataTable.Contents[i][j] = dt.Rows[i][j].ToString();
                        }
                    }
                    oE_ContentStringDataSet.ContentStringDataTables.Add(oE_ContentStringDataTable);
                }
                return oE_ContentStringDataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Gestion Unicos
        /// <summary>
        /// Fecha: 15/05/2012
        /// Autor: Joseph Gonzales
        /// Descripción: Método que devuelve la cantidad de datos validados e invalidados
        /// </summary>
        /// <param name="CodServicio"></param>
        /// <param name="CodCompania"></param>
        /// <param name="CodCanal"></param>
        /// <param name="CodOficina"></param>
        /// <param name="CodCategoria"></param>
        /// <param name="CodReporteCampania"></param>
        /// <returns></returns>
        public E_Reporte_Data_Validada Consultar_Reporte_Data_Validada(string CodServicio, int CodCompania, string CodCanal, int CodOficina, string CodCategoria, int CodReporteCampania)
        {
            E_Reporte_Data_Validada oE_Reporte_Data_Validada = new E_Reporte_Data_Validada();
            DataTable dtUsuario = oCoon.ejecutarDataTable("SP_GES_OPE_OBTENER_VALIDADO", CodServicio, CodCompania, CodCanal, CodOficina, CodCategoria, CodReporteCampania);
            if (dtUsuario.Rows.Count > 0)
            {
                System.Data.DataRow fila = dtUsuario.Rows[0];
                oE_Reporte_Data_Validada.CantidadValidado = Convert.ToInt32(fila["Validados"]);
                oE_Reporte_Data_Validada.CantidadInvalidado = Convert.ToInt32(fila["Invalidados"]);
                oE_Reporte_Data_Validada.PorcentajeValidado = fila["Porcentaje_Vali"].ToString().Trim() + " %";
                oE_Reporte_Data_Validada.PorcentajeInvalidado = fila["Porcentaje_Invali"].ToString().Trim() + " %";
                return oE_Reporte_Data_Validada;
            }
            else
                return null;
        }

        /// <summary>
        /// Función de Logueo para la WebSite.
        /// </summary>
        /// <param name="sUser"></param>
        /// <param name="sPassw"></param>
        /// <returns></returns>
        public E_Persona Logueo(string sUser, string sPassw)
        {
            E_Persona oE_Persona = new E_Persona();

            DataTable dtc = fncGetPassword(sUser);
            if (getMessages().Equals("")){
                if (dtc.Rows.Count > 0){

                    string sclvr = dtc.Rows[0]["User_Password"].ToString();
                    string spasEncriptado = Encriptacion.Codificar(sPassw, "YourUglyRandomKeyLike-lkj54923c478");

                    //sclvr = dtc.Rows[0]["User_Password"].ToString();
                    if (sclvr != spasEncriptado && sclvr.Length < 15){
                        //Valida si la Clave no esta Enciptada y la encripta Ing. CarlosH 30/11/2011
                        //spasEncriptado = Lucky.CFG.Util.Encriptacion.Codificar(sclvr, "YourUglyRandomKeyLike-lkj54923c478");
                        //Actualiza la Clave encriptada Ing. CarlosH 30/11/2011
                        //oCoon.ejecutarDataReader("UP_WEBXPLORA_UPDATEPSWENCRIPTA", spasEncriptado, sUser);
                        fncUpdatePasswordEncriptado(spasEncriptado, sUser);
                    }

                    Lucky.Data.Common.Application.DUsuario odUsuario =
                        new Lucky.Data.Common.Application.DUsuario();

                    Lucky.Entity.Common.Application.EUsuario oEUsuario =
                        new Lucky.Entity.Common.Application.EUsuario();

                    try
                    {
                        oEUsuario = odUsuario.obtenerPK(sUser, spasEncriptado);
                        if (odUsuario.getMessages().Equals(""))
                        {
                            oE_Persona.Cod_city = oEUsuario.codcity;
                            oE_Persona.Cod_Country = oEUsuario.codCountry;
                            oE_Persona.Cod_dpto = oEUsuario.coddepartam;
                            oE_Persona.Company_id = oEUsuario.companyid;
                            oE_Persona.companyName = oEUsuario.companyName;
                            oE_Persona.fotocompany = oEUsuario.fotocompany;
                            oE_Persona.Id_type_Document = oEUsuario.idtypeDocument;
                            oE_Persona.Modulo_id = oEUsuario.Moduloid;
                            oE_Persona.Name_Perfil = oEUsuario.NamePerfil;
                            oE_Persona.Name_user = oEUsuario.nameuser;
                            oE_Persona.Perfil_id = oEUsuario.Perfilid;
                            oE_Persona.Person_Addres = oEUsuario.PersonAddres;
                            oE_Persona.Person_CreateBy = oEUsuario.PersonCreateBy;
                            oE_Persona.Person_DateBy = oEUsuario.PersonDateBy;
                            oE_Persona.Person_DateModiBy = oEUsuario.PersonDateModiBy;
                            oE_Persona.Person_Email = oEUsuario.PersonEmail;
                            oE_Persona.Person_Firtsname = oEUsuario.PersonFirtsname;
                            oE_Persona.Person_id = oEUsuario.Personid;
                            oE_Persona.Person_LastName = oEUsuario.PersonLastName;
                            oE_Persona.Person_ModiBy = oEUsuario.PersonModiBy;
                            oE_Persona.Person_nd = oEUsuario.Personnd;
                            oE_Persona.Person_Phone = oEUsuario.PersonPhone;
                            oE_Persona.Person_SeconName = oEUsuario.PersonSeconName;
                            oE_Persona.Person_Status = oEUsuario.PersonStatus;
                            oE_Persona.Person_Surname = oEUsuario.PersonSurname;
                            oE_Persona.User_Password = oEUsuario.UserPassword;
                            oE_Persona.User_Recall = oEUsuario.UserRecall;
                        }
                        else
                        {
                            messages = odUsuario.getMessages();
                        }
                    }
                    catch (Exception ex)
                    {
                        messages = "Error: " + ex.Message.ToString();
                    }
                }
                else
                {
                    messages = "Error: No se obtuvo password para el nameUser indicado, ¡por favor verificar!";
                }
            }
            else { 
                messages = getMessages();
            }
            return oE_Persona;
        }

        /// <summary>
        /// Función para obtener el Password de la Base de Datos,
        /// por idUser.
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        private DataTable fncGetPassword(String userName)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oCoon.ejecutarDataTable("UP_WEBXPLORAGEN_PASSUSER", userName);
            }
            catch (Exception ex)
            {
                messages = "Ocurrio un Error: " + ex.Message.ToString();
            }
            return dt;
        }

        /// <summary>
        /// Función para Actualizar la Encriptación del Password en Base de Datos
        /// En caso el password no se haya almacenado Encriptado.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="idUser"></param>
        public void fncUpdatePasswordEncriptado(String password, String userName)
        {
            try
            {
                oCoon.ejecutarDataReader("UP_WEBXPLORA_UPDATEPSWENCRIPTA", password, userName);
            }
            catch (Exception ex)
            {
                messages = "Error: " + ex.Message.ToString();
            }
        }

        public List<E_Informesv2> Listar_Informes_CM(string codPais, string codCliente, string idAgrupacion, string idPersona)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_Informesv2> listaE_InformesCMv2 = new List<E_Informesv2>();
                IDataReader readerObj = oCoon.ejecutarDataReader("up_Lista_Archivos_xp_ConsumoMasivo", codPais, codCliente, idAgrupacion, idPersona);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_Informesv2 oE_InformesCMv2 = new E_Informesv2();
                    oE_InformesCMv2.id = readerObj.GetValue(readerObj.GetOrdinal("ID")).ToString().Trim();
                    oE_InformesCMv2.nom_reporte = readerObj.GetValue(readerObj.GetOrdinal("nom_reporte")).ToString().Trim();
                    oE_InformesCMv2.ruta_reporte = readerObj.GetValue(readerObj.GetOrdinal("ruta_reporte")).ToString().Trim();
                    oE_InformesCMv2.anio = readerObj.GetValue(readerObj.GetOrdinal("anio")).ToString().Trim();
                    oE_InformesCMv2.info_mesinforme = readerObj.GetValue(readerObj.GetOrdinal("info_mesinforme")).ToString().Trim();
                    listaE_InformesCMv2.Add(oE_InformesCMv2);
                }
                readerObj.Close();

                if (listaE_InformesCMv2.Count > 0)
                {
                    return listaE_InformesCMv2;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public E_Informes Listar_Informes_MKT(int idCanal, int idReporte, int idMarca, int idServicio, string anio)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_Informesv2> listaE_InformesMKTv2 = new List<E_Informesv2>();
                List<E_Informesv2> listaAnios = new List<E_Informesv2>();
                IDataReader readerObj = oCoon.ejecutarDataReader("up_Lista_Informe_promociones", idCanal, idReporte, idMarca, idServicio,anio);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_Informesv2 oE_InformesMKTv2 = new E_Informesv2();
                    oE_InformesMKTv2.id = readerObj.GetValue(readerObj.GetOrdinal("ID")).ToString().Trim();
                    oE_InformesMKTv2.nom_reporte = readerObj.GetValue(readerObj.GetOrdinal("nom_reporte")).ToString().Trim();
                    oE_InformesMKTv2.ruta_reporte = readerObj.GetValue(readerObj.GetOrdinal("ruta_reporte")).ToString().Trim();
                    oE_InformesMKTv2.anio = readerObj.GetValue(readerObj.GetOrdinal("anio")).ToString().Trim();
                    listaE_InformesMKTv2.Add(oE_InformesMKTv2);
                }
                readerObj.NextResult();
                while (readerObj.Read())
                {
                    E_Informesv2 oE_Informesv2Anios = new E_Informesv2();
                    oE_Informesv2Anios.anio = readerObj.GetValue(readerObj.GetOrdinal("anio")).ToString().Trim();
                    listaAnios.Add(oE_Informesv2Anios);
                }
                readerObj.Close();

                E_Informes oE_Informes=new E_Informes();
                oE_Informes.listainformes=listaE_InformesMKTv2;
                oE_Informes.listanios=listaAnios;

                return oE_Informes;
            }
            catch (Exception)
            {
                return null;
            }
        }
       
        #endregion

        #region Gestion de Reportes - Registrar
        public string Registrar_Reporte_Encuesta(E_Reporte_Encuesta oE_Reporte_Encuesta)
        {
            try
            {
                oCoon = new Conexion(3);
                string Id_RepPreg = oCoon.ejecutarretornodeOUTPUT("UP_GES_OPE_REGISTRAR_REPORTE_ENCUESTA", 7
                    , oE_Reporte_Encuesta.preguntaA ?? null
                    , oE_Reporte_Encuesta.preguntaB ?? null
                    , oE_Reporte_Encuesta.preguntaC ?? null
                    , oE_Reporte_Encuesta.codigoUsuario ?? null
                    , oE_Reporte_Encuesta.codigoEquipo ?? null
                    , oE_Reporte_Encuesta.fechaEncuesta ?? null
                    , oE_Reporte_Encuesta.codigoPtoVenta ?? null
                    , ""
                    );
                //Registrar_Reporte_Encuesta_Detalle(Id_RepPreg);
                foreach (E_DistribuidoraEncuesta oE_DistribuidoraEncuesta in oE_Reporte_Encuesta.oListE_DistribuidoraEncuesta)
                {
                    Registrar_Reporte_Encuesta_Detalle(Id_RepPreg, oE_DistribuidoraEncuesta);
                }
                return Id_RepPreg;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Registrar_Reporte_Encuesta_Detalle(string Id_RepPreg, E_DistribuidoraEncuesta oE_DistribuidoraEncuesta)
        {
            try
            {
                oCoon = new Conexion(3);
                string xyz = oCoon.ejecutarConRetorno("up_registrar_reporte_encuesta_detalle", Id_RepPreg
                    , oE_DistribuidoraEncuesta.nombre ?? null
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Registrar_Reporte_Encuesta_EQF(E_Reporte_Encuesta_EQF oE_Reporte_Encuesta)
        {
            try
            {
                oCoon = new Conexion(3);
                string Id_RepPreg = oCoon.ejecutarretornodeOUTPUT("UP_GES_OPE_REGISTRAR_REPORTE_ENCUESTA_EQF", 9
                    , oE_Reporte_Encuesta.preguntaA ?? null
                    , oE_Reporte_Encuesta.preguntaB ?? null
                    , oE_Reporte_Encuesta.preguntaC ?? null
                    , oE_Reporte_Encuesta.preguntaE ?? null
                    , oE_Reporte_Encuesta.preguntaG ?? null
                    , oE_Reporte_Encuesta.codigoUsuario ?? null
                    , oE_Reporte_Encuesta.codigoEquipo ?? null
                    , oE_Reporte_Encuesta.fechaEncuesta ?? null
                    , oE_Reporte_Encuesta.codigoPtoVenta ?? null
                    , ""
                    );
                //Registrar_Reporte_Encuesta_Detalle(Id_RepPreg);
                foreach (E_DistribuidoraEncuesta oE_DistribuidoraEncuesta in oE_Reporte_Encuesta.oListE_DistribuidoraEncuesta)
                {
                    Registrar_Reporte_Encuesta_Detalle(Id_RepPreg, oE_DistribuidoraEncuesta);
                }

                foreach (E_Respuesta oE_Respuesta in oE_Reporte_Encuesta.oListEQF)
                {
                    Registrar_Reporte_Encuesta_Detalle_EQF(Id_RepPreg, oE_Respuesta);
                }
                return Id_RepPreg;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Registrar_Reporte_Encuesta_Detalle_EQF(string Id_RepPreg, E_Respuesta oE_Respuesta)
        {
            try
            {
                oCoon = new Conexion(3);
                foreach (E_Respuesta_Detalle det in oE_Respuesta.detalleRspta)
                {
                    oCoon.ejecutarConRetorno("up_registrar_reporte_encuesta_detalle_eqf", Id_RepPreg, oE_Respuesta.codigo
                    , det.codigo ?? null, det.adicional);
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:22/10/2012
        /// Descripcion: Metodo que registra nuevos proveedores.
        /// </summary>
        /// <returns></returns>
        public string registrarProveedor(E_Proveedor oE_Proveedor)
        {
            string error = string.Empty;
            try
            {
                Conexion ocon = new Conexion();
                string a = oCoon.ejecutarConRetorno("SP_GES_OPE_REGISTRAR_PROVEEDORES",
                    oE_Proveedor.Razon_social,
                    oE_Proveedor.Ruc,
                    oE_Proveedor.Direccion,
                    oE_Proveedor.CodDpto,
                    oE_Proveedor.CodProv,
                    oE_Proveedor.CodDist,
                    oE_Proveedor.Email,
                    oE_Proveedor.Contacto,
                    oE_Proveedor.Telefonos,
                    oE_Proveedor.Usuario_Registro
                );
                error = "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }
            return error;
        }

        #region Gestion de Tickets
        public string Registrar_Tickets(E_Tickets oE_Tickets)
        {
            try
            {
                oCoon = new Conexion(4);
                string nro_tickets = oCoon.ejecutarretornodeOUTPUT("UP_GES_OPE_REGISTRAR_TICKETS", 0
                    , " "
                    , oE_Tickets.Cod_Tickets
                    , oE_Tickets.Solicitante
                    , oE_Tickets.Telefono
                    , oE_Tickets.Email
                    , oE_Tickets.Cod_Categoria
                    , oE_Tickets.Cod_Area
                    , oE_Tickets.Tipo
                    , oE_Tickets.Id_Prioridad
                    , oE_Tickets.Asunto
                    , oE_Tickets.Descripcion
                    , oE_Tickets.Creado_Por
                    , oE_Tickets.Asignado
                    );
                return nro_tickets;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Actualizar Proveedor
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:31/10/2012
        /// Descripcion: Metodo que actualiza proveedores.
        /// </summary>
        /// <returns></returns>
        public string actualizarProveedor(E_Proveedor oE_Proveedor)
        {
            string error = string.Empty;
            try
            {
                Conexion ocon = new Conexion();
                string a = oCoon.ejecutarConRetorno("SP_GES_OPE_UPDATE_PROVEEDORES",
                    oE_Proveedor.Codigo,
                    oE_Proveedor.Razon_social,
                    oE_Proveedor.Ruc,
                    oE_Proveedor.Direccion,
                    oE_Proveedor.CodDpto,
                    oE_Proveedor.CodProv,
                    oE_Proveedor.CodDist,
                    oE_Proveedor.Email,
                    oE_Proveedor.Contacto,
                    oE_Proveedor.Telefonos,
                    oE_Proveedor.Usuario_Modify
                );
                error = "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }
            return error;
        }
        #endregion
        #region Gestion de OrdenCompra
        public string Registrar_OrdenCompra(E_OrdenCompra oE_OrdenCompra)
        {
            try
            {
                oCoon = new Conexion(1);
                string nro_oc =oCoon.ejecutarretornodeOUTPUT("UP_GES_OPE_REGISTRAR_ORDEN_COMPRA",0
                    ," "
                    , oE_OrdenCompra.Nro_OC ?? null
                    , oE_OrdenCompra.Cod_Proveedor ?? null
                    , oE_OrdenCompra.Total
                    , oE_OrdenCompra.Subtotal
                    , oE_OrdenCompra.IGV
                    , oE_OrdenCompra.Condicion ?? null
                    , oE_OrdenCompra.Autorizado_Por ?? null
                    , oE_OrdenCompra.Tranportar ?? null
                    , oE_OrdenCompra.Atendido ?? null
                    , oE_OrdenCompra.Fecha_Envio ?? null
                    , oE_OrdenCompra.User_Registro ?? null
                    );
                int grabados = 0;
                int registros = 0;
                foreach (E_OrdenCompraDetalle oE_OrdenCompraDet in oE_OrdenCompra.oList_Detalle)
                {
                    registros = registros + 1;
                    string nro = Registrar_OrdenCompra_Detalle(oE_OrdenCompraDet);
                    if (!nro.Equals(""))
                    {
                        grabados = grabados + 1;
                    }
                }
                if (grabados != registros)
                {
                    nro_oc = "Error al grabar el detalle";
                }
                return nro_oc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string Registrar_OrdenCompra_Detalle(E_OrdenCompraDetalle oE_OrdenCompraDet)
        {
            try
            {
                oCoon = new Conexion(1);
                string nro_oc = oCoon.ejecutarretornodeOUTPUT("UP_GES_OPE_REGISTRAR_ORDEN_COMPRA_DETALLE",0
                    ," "
                    , oE_OrdenCompraDet.Nro_OC ?? null
                    , oE_OrdenCompraDet.ProductName ?? null
                    , oE_OrdenCompraDet.UnitsInStock
                    , oE_OrdenCompraDet.UnitPrice
                    , oE_OrdenCompraDet.PriceTotal
                    );
                return nro_oc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Gestion Reporte - Actualizar
        //---Descripcion: Actualizar cantidad Reporte Exhibicion
        //---Fecha      : 10/11/2012 PCP
        public string Actualizar_Reporte_Exhibicion(string CodReporte, int Cantidad, string ModifyBy, string DateModify, string DateRegistro)
        {
            Conexion oCoon= new Conexion(4);
            var Fecha_Mod = DateTime.Now;
            var Fecha_Reg = Convert.ToDateTime(DateRegistro);
            string error = string.Empty;
            try
            {
                oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_ACTUALIZAR_REPORTE_EXHIBICION_DETALLE_CANTIDAD", Convert.ToInt32(CodReporte), Cantidad, Fecha_Reg, ModifyBy, Fecha_Mod);
                error = "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }
            return error;
        }

        //---Descripcion: Valida Reporte Exhibicion
        //---Fecha      : 14/11/2012 PCP
        public string Validar_Reporte_Exhibicion(string Checked, string unChecked)
        {
            Conexion oCoon = new Conexion(4);
            string error = string.Empty;
            
            
            try
            {
                if (Checked != "")
                {
                    var Validado = Checked.Split(',');
                    var totalValid = Validado.Count();
                    for (int i = 0; i < totalValid; i++)
                    {
                        oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_ACTUALIZAR_REPORTE_EXHIBICION_DETALLE_VALIDADO", Validado[i], 1);
                    }
                }
                if (unChecked != "")
                {
                    var inValidado = unChecked.Split(',');
                    var totalinValid = inValidado.Count();
                    for (int i = 0; i < totalinValid; i++)
                    {
                        oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_ACTUALIZAR_REPORTE_EXHIBICION_DETALLE_VALIDADO", inValidado[i], 0);
                    }
                }
                error = "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }
            return error;
        }

        #endregion

    }
}
