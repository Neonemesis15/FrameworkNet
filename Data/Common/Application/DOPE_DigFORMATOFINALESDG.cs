using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DOPE_DigFORMATOFINALESDG
    {
        private Conexion oConn;
        public DOPE_DigFORMATOFINALESDG()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }


        /// <summary>
        /// Método para registrar en la tabla OPE_DigFORMATOFINALESDG
        /// Ing. Mauricio Ortiz
        /// 02/05/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_FINALESDG"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iNodeCommercial"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="spdv_Name"></param>
        /// <param name="scod_Product"></param>
        /// <param name="sProduct_name"></param>
        /// <param name="sLocal1"></param>
        /// <param name="sLocal2"></param>
        /// <param name="sLocal3"></param>
        /// <param name="sLocal4"></param>
        /// <param name="sLocal5"></param>
        /// <param name="sTotal"></param>
        /// <param name="sCreateBy_FINALESDG"></param>
        /// <param name="tDateby_FINALESDG"></param>
        /// <param name="sModiby_FINALESDG"></param>
        /// <param name="tDateModiBy_FINALESDG"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOFINALESDG RegistrarFormatoFinalesDG(string sid_planning, int iCod_Formato, DateTime tFecha_FINALESDG, int iPerson_id,
                int iNodeCommercial, string sClientPDV_Code, string spdv_Name, string scod_Product,
                string sProduct_name, string sLocal1, string sLocal2, string sLocal3,
                string sLocal4, string sLocal5, string sTotal, string sCreateBy_FINALESDG,
                DateTime tDateby_FINALESDG, string sModiby_FINALESDG, DateTime tDateModiBy_FINALESDG)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_INSERTAR_FORMATO_FINALES_DG", sid_planning,  iCod_Formato, tFecha_FINALESDG, iPerson_id,
             iNodeCommercial, sClientPDV_Code, spdv_Name, scod_Product,
                 sProduct_name, sLocal1, sLocal2, sLocal3,
                     sLocal4, sLocal5, sTotal, sCreateBy_FINALESDG,
               tDateby_FINALESDG, sModiby_FINALESDG, tDateModiBy_FINALESDG);

            EOPE_DigFORMATOFINALESDG oeOPE_DigFORMATOFINALESDG = new EOPE_DigFORMATOFINALESDG();

            oeOPE_DigFORMATOFINALESDG.id_planning = sid_planning;
            oeOPE_DigFORMATOFINALESDG.Cod_Formato = iCod_Formato;
            oeOPE_DigFORMATOFINALESDG.Fecha_FINALESDG = tFecha_FINALESDG;
            oeOPE_DigFORMATOFINALESDG.Person_id = iPerson_id;
            oeOPE_DigFORMATOFINALESDG.NodeCommercial = iNodeCommercial;
            oeOPE_DigFORMATOFINALESDG.ClientPDV_Code = sClientPDV_Code;
            oeOPE_DigFORMATOFINALESDG.pdv_Name = spdv_Name;
            oeOPE_DigFORMATOFINALESDG.cod_Product = scod_Product;
            oeOPE_DigFORMATOFINALESDG.Product_name = sProduct_name;
            oeOPE_DigFORMATOFINALESDG.Local1 = sLocal1;
            oeOPE_DigFORMATOFINALESDG.Local2 = sLocal2;
            oeOPE_DigFORMATOFINALESDG.Local3 = sLocal3;
            oeOPE_DigFORMATOFINALESDG.Local4 = sLocal4;
            oeOPE_DigFORMATOFINALESDG.Local5 = sLocal5;
            oeOPE_DigFORMATOFINALESDG.Total = sTotal;
            oeOPE_DigFORMATOFINALESDG.CreateBy_FINALESDG = sCreateBy_FINALESDG;
            oeOPE_DigFORMATOFINALESDG.Dateby_FINALESDG = tDateby_FINALESDG;
            oeOPE_DigFORMATOFINALESDG.Modiby_FINALESDG = sModiby_FINALESDG;
            oeOPE_DigFORMATOFINALESDG.DateModiBy_FINALESDG = tDateModiBy_FINALESDG;





            return oeOPE_DigFORMATOFINALESDG;

        }


        /// <summary>
        /// Método para consultar en la tabla OPE_DigFORMATOFINALESDG
        /// Ing. Mauricio Ortiz
        /// 02/05/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_FINALESDG"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iNodeCommercial"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <returns></returns>
        public DataTable ConsultarFormatoFinalesDG(string sid_planning, int iCod_Formato, DateTime tFecha_FINALESDG, int iPerson_id,
           int iNodeCommercial, string sClientPDV_Code)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_CONSULTAR_FORMATO_FINALES_DG",sid_planning, iCod_Formato, tFecha_FINALESDG, iPerson_id,
             iNodeCommercial, sClientPDV_Code);
            EOPE_DigFORMATOFINALESDG oeOPE_DigFORMATOFINALESDG = new EOPE_DigFORMATOFINALESDG();
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
        /// Método para Actualizar registros en la tabla OPE_DigFORMATOFINALESDG
        /// Ing. Mauricio Ortiz
        /// 02/05/2011 
        /// </summary>
        /// <param name="iid_FINALESDG"></param>
        /// <param name="sLocal1"></param>
        /// <param name="sLocal2"></param>
        /// <param name="sLocal3"></param>
        /// <param name="sLocal4"></param>
        /// <param name="sLocal5"></param>
        /// <param name="sTotal"></param>
        /// <param name="sModiby_FINALESDG"></param>
        /// <param name="tDateModiBy_FINALESDG"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOFINALESDG ActualizarFormatoFinalesDG(long iid_FINALESDG, string sLocal1, string sLocal2, string sLocal3, string sLocal4, string sLocal5, string sTotal,
            string sModiby_FINALESDG, DateTime tDateModiBy_FINALESDG)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ACTUALIZAR_FORMATO_FINALES_DG", iid_FINALESDG, sLocal1, sLocal2, sLocal3, sLocal4, sLocal5, sTotal,
             sModiby_FINALESDG, tDateModiBy_FINALESDG);

            EOPE_DigFORMATOFINALESDG oaOPE_DigFORMATOFINALESDG = new EOPE_DigFORMATOFINALESDG();

            oaOPE_DigFORMATOFINALESDG.id_FINALESDG = iid_FINALESDG;
            oaOPE_DigFORMATOFINALESDG.Local1 = sLocal1;
            oaOPE_DigFORMATOFINALESDG.Local2 = sLocal2;
            oaOPE_DigFORMATOFINALESDG.Local3 = sLocal3;
            oaOPE_DigFORMATOFINALESDG.Local4 = sLocal4;
            oaOPE_DigFORMATOFINALESDG.Local5 = sLocal5;
            oaOPE_DigFORMATOFINALESDG.Total = sTotal;
            oaOPE_DigFORMATOFINALESDG.Modiby_FINALESDG = sModiby_FINALESDG;
            oaOPE_DigFORMATOFINALESDG.DateModiBy_FINALESDG = tDateModiBy_FINALESDG;



            return oaOPE_DigFORMATOFINALESDG;
        }


        /// <summary>
        /// Método para Eliminar registros en la tabla OPE_DigFORMATOFINALESDG
        /// Ing. Mauricio Ortiz
        /// 02/05/2011
        /// </summary>
        /// <param name="iid_FINALESDG"></param>
        /// <returns></returns>
        public DataTable EliminarFormatoFinalesDG(long iid_FINALESDG)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ELIMINAR_FORMATO_FINALES_DG", iid_FINALESDG);
            return dt;
        }
    }
}