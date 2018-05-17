using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DOPE_DigFORMATOAGCOCINA
    {
        private Conexion oConn;
        public DOPE_DigFORMATOAGCOCINA()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// Método para registrar en la tabla OPE_DigFORMATOAGCOCINA
        /// Ing. Mauricio Ortiz
        /// 25/05/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_ini_AGCOCINA"></param>
        /// <param name="tFecha_fin_AGCOCINA"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iNodeCommercial"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="spdv_Name"></param>
        /// <param name="scod_Product"></param>
        /// <param name="sProduct_name"></param>
        /// <param name="sPrecio"></param>
        /// <param name="sStock_inicial"></param>
        /// <param name="sIngresos"></param>
        /// <param name="sStock_Total"></param>
        /// <param name="sStock_Final"></param>
        /// <param name="sVentas"></param>
        /// <param name="sCreateBy_AGCOCINA"></param>
        /// <param name="tDateby_AGCOCINA"></param>
        /// <param name="sModiby_AGCOCINA"></param>
        /// <param name="tDateModiBy_AGCOCINA"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOAGCOCINA RegistrarFormatoAGCOCINA(string sid_planning, int iCod_Formato, DateTime tFecha_ini_AGCOCINA, DateTime tFecha_fin_AGCOCINA,
            int iPerson_id, int iNodeCommercial, string sClientPDV_Code, string spdv_Name, string scod_Product, string sProduct_name, string sPrecio,
            string sStock_inicial, string sIngresos, string sStock_Total, string sStock_Final, string sVentas, string sCreateBy_AGCOCINA, DateTime tDateby_AGCOCINA,
            string sModiby_AGCOCINA, DateTime tDateModiBy_AGCOCINA)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_INSERTAR_FORMATO_AGCOCINA",sid_planning,iCod_Formato, tFecha_ini_AGCOCINA, tFecha_fin_AGCOCINA,
             iPerson_id, iNodeCommercial, sClientPDV_Code, spdv_Name, scod_Product, sProduct_name, sPrecio,
             sStock_inicial, sIngresos, sStock_Total, sStock_Final, sVentas, sCreateBy_AGCOCINA, tDateby_AGCOCINA,
             sModiby_AGCOCINA, tDateModiBy_AGCOCINA);

            EOPE_DigFORMATOAGCOCINA oeOPE_DigFORMATOAGCOCINA = new EOPE_DigFORMATOAGCOCINA();

            oeOPE_DigFORMATOAGCOCINA.id_planning = sid_planning;
            oeOPE_DigFORMATOAGCOCINA.Cod_Formato = iCod_Formato;
            oeOPE_DigFORMATOAGCOCINA.Fecha_ini_AGCOCINA = tFecha_ini_AGCOCINA;
            oeOPE_DigFORMATOAGCOCINA.Fecha_fin_AGCOCINA = tFecha_fin_AGCOCINA;
            oeOPE_DigFORMATOAGCOCINA.Person_id = iPerson_id;
            oeOPE_DigFORMATOAGCOCINA.NodeCommercial = iNodeCommercial;
            oeOPE_DigFORMATOAGCOCINA.ClientPDV_Code = sClientPDV_Code;
            oeOPE_DigFORMATOAGCOCINA.pdv_Name = spdv_Name;
            oeOPE_DigFORMATOAGCOCINA.cod_Product = scod_Product;
            oeOPE_DigFORMATOAGCOCINA.Product_name = sProduct_name;
            oeOPE_DigFORMATOAGCOCINA.Precio = sPrecio;
            oeOPE_DigFORMATOAGCOCINA.Stock_inicial = sStock_inicial;
            oeOPE_DigFORMATOAGCOCINA.Ingresos = sIngresos;
            oeOPE_DigFORMATOAGCOCINA.Stock_Total = sStock_Total;
            oeOPE_DigFORMATOAGCOCINA.Stock_Final = sStock_Final;
            oeOPE_DigFORMATOAGCOCINA.Ventas = sVentas;
            oeOPE_DigFORMATOAGCOCINA.CreateBy_AGCOCINA = sCreateBy_AGCOCINA;
            oeOPE_DigFORMATOAGCOCINA.Dateby_AGCOCINA = tDateby_AGCOCINA;
            oeOPE_DigFORMATOAGCOCINA.Modiby_AGCOCINA = sModiby_AGCOCINA;
            oeOPE_DigFORMATOAGCOCINA.DateModiBy_AGCOCINA = tDateModiBy_AGCOCINA;
            return oeOPE_DigFORMATOAGCOCINA;
        }

        /// <summary>
        /// Método para consultar en la tabla OPE_DigFORMATOAGCOCINA
        /// Ing. Mauricio Ortiz
        /// 25/05/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_ini_AGCOCINA"></param>
        /// <param name="tFecha_fin_AGCOCINA"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iNodeCommercial"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <returns></returns>
        public DataTable ConsultarFormatoAGCOCINA(string sid_planning, int iCod_Formato, DateTime tFecha_ini_AGCOCINA, DateTime tFecha_fin_AGCOCINA, int iPerson_id,
           int iNodeCommercial, string sClientPDV_Code)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_CONSULTAR_FORMATO_AGCOCINA",sid_planning,iCod_Formato, tFecha_ini_AGCOCINA, tFecha_fin_AGCOCINA, iPerson_id,
            iNodeCommercial, sClientPDV_Code);
            EOPE_DigFORMATOAGCOCINA oeOPE_DigFORMATOAGCOCINA = new EOPE_DigFORMATOAGCOCINA();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
            }
            return null;
        }

        /// <summary>
        /// Método para actualizar en la tabla OPE_DigFORMATOAGCOCINA
        /// Ing. Mauricio Ortiz
        /// 25/05/2011
        /// <param name="iid_AGCOCINA"></param>
        /// <param name="sPrecio"></param>
        /// <param name="sStock_inicial"></param>
        /// <param name="sIngresos"></param>
        /// <param name="sStock_Total"></param>
        /// <param name="sStock_Final"></param>
        /// <param name="sVentas"></param>
        /// <param name="sModiby_AGCOCINA"></param>
        /// <param name="tDateModiBy_AGCOCINA"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOAGCOCINA ActualizarFormatoAGCOCINA(long iid_AGCOCINA, string sPrecio, string sStock_inicial, string sIngresos, string sStock_Total, string sStock_Final, string sVentas,
            string sModiby_AGCOCINA, DateTime tDateModiBy_AGCOCINA)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ACTUALIZAR_FORMATO_AGCOCINA", iid_AGCOCINA, sPrecio, sStock_inicial,
                sIngresos, sStock_Total, sStock_Final, sVentas,
             sModiby_AGCOCINA, tDateModiBy_AGCOCINA);

            EOPE_DigFORMATOAGCOCINA oaOPE_DigFORMATOAGCOCINA = new EOPE_DigFORMATOAGCOCINA();

            oaOPE_DigFORMATOAGCOCINA.id_AGCOCINA = iid_AGCOCINA;
            oaOPE_DigFORMATOAGCOCINA.Precio = sPrecio;
            oaOPE_DigFORMATOAGCOCINA.Stock_inicial = sStock_inicial;
            oaOPE_DigFORMATOAGCOCINA.Ingresos = sIngresos;
            oaOPE_DigFORMATOAGCOCINA.Stock_Total = sStock_Total;
            oaOPE_DigFORMATOAGCOCINA.Stock_Final = sStock_Final;
            oaOPE_DigFORMATOAGCOCINA.Ventas = sVentas;
            oaOPE_DigFORMATOAGCOCINA.Modiby_AGCOCINA = sModiby_AGCOCINA;
            oaOPE_DigFORMATOAGCOCINA.DateModiBy_AGCOCINA = tDateModiBy_AGCOCINA;

            return oaOPE_DigFORMATOAGCOCINA;
        }


        /// <summary>
        /// Método para eliminar en la tabla OPE_DigFORMATOAGCOCINA
        /// INg. Mauricio Ortiz
        /// 26/05/2011
        /// </summary>
        /// <param name="iid_AGCOCINA"></param>
        /// <returns></returns>
        public DataTable EliminarFormatoAGCOCINA(long iid_AGCOCINA)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ELIMINAR_FORMATO_AGCOCINA", iid_AGCOCINA);
            return dt;
        }

    }
}
