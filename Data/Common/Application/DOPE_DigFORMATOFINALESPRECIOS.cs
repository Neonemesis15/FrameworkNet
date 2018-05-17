using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DOPE_DigFORMATOFINALESPRECIOS
    {
        private Conexion oConn;
        public DOPE_DigFORMATOFINALESPRECIOS()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }


        /// <summary>
        /// Método para registrar en la tabla OPE_DigFORMATOFINALESPRECIOS
        /// Ing. Mauricio Ortiz
        /// 28/04/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_FINALESPRECIOS"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iNodeCommercial"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="spdv_Name"></param>
        /// <param name="sid_ProductSubCategory"></param>
        /// <param name="scod_Product"></param>
        /// <param name="sProduct_name"></param>
        /// <param name="sCosto_FINALESPRECIOS"></param>
        /// <param name="sReventa_FINALESPRECIOS"></param>
        /// <param name="sObservacion_FINALESPRECIOS"></param>
        /// <param name="sReventaUnid_FINALESPRECIOS"></param>
        /// <param name="sCreateBy_FINALESPRECIOS"></param>
        /// <param name="tDateby_FINALESPRECIOS"></param>
        /// <param name="sModiby_FINALESPRECIOS"></param>
        /// <param name="tDateModiBy_FINALESPRECIOS"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOFINALESPRECIOS RegistrarFormatoFinalesPrecios(string sid_planning, int iCod_Formato, DateTime tFecha_FINALESPRECIOS,
            int iPerson_id, int iNodeCommercial, string sClientPDV_Code,        string spdv_Name, string sid_ProductSubCategory,
             string scod_Product, string sProduct_name, string sCosto_FINALESPRECIOS, string sReventa_FINALESPRECIOS,
             string sObservacion_FINALESPRECIOS, string sReventaUnid_FINALESPRECIOS,string sCreateBy_FINALESPRECIOS,
            DateTime tDateby_FINALESPRECIOS, string sModiby_FINALESPRECIOS, DateTime tDateModiBy_FINALESPRECIOS)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_INSERTAR_FORMATO_FINALES_PRECIOS", sid_planning,  iCod_Formato, tFecha_FINALESPRECIOS,
             iPerson_id, iNodeCommercial, sClientPDV_Code, spdv_Name, sid_ProductSubCategory,
              scod_Product, sProduct_name, sCosto_FINALESPRECIOS, sReventa_FINALESPRECIOS,
              sObservacion_FINALESPRECIOS, sReventaUnid_FINALESPRECIOS, sCreateBy_FINALESPRECIOS,
             tDateby_FINALESPRECIOS, sModiby_FINALESPRECIOS, tDateModiBy_FINALESPRECIOS);

            EOPE_DigFORMATOFINALESPRECIOS oeOPE_DigFORMATOFINALESPRECIOS = new EOPE_DigFORMATOFINALESPRECIOS();

            oeOPE_DigFORMATOFINALESPRECIOS.id_planning = sid_planning;
            oeOPE_DigFORMATOFINALESPRECIOS.Cod_Formato = iCod_Formato;
            oeOPE_DigFORMATOFINALESPRECIOS.Fecha_FINALESPRECIOS = tFecha_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.Person_id = iPerson_id;
            oeOPE_DigFORMATOFINALESPRECIOS.NodeCommercial = iNodeCommercial;
            oeOPE_DigFORMATOFINALESPRECIOS.ClientPDV_Code = sClientPDV_Code;
            oeOPE_DigFORMATOFINALESPRECIOS.pdv_Name = spdv_Name;
            oeOPE_DigFORMATOFINALESPRECIOS.name_ProductSubCategory = sid_ProductSubCategory;
            oeOPE_DigFORMATOFINALESPRECIOS.cod_Product = scod_Product;
            oeOPE_DigFORMATOFINALESPRECIOS.Product_name = sProduct_name;
            oeOPE_DigFORMATOFINALESPRECIOS.Costo_FINALESPRECIOS = sCosto_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.Reventa_FINALESPRECIOS = sReventa_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.Observacion_FINALESPRECIOS = sObservacion_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.ReventaUnid_FINALESPRECIOS = sReventaUnid_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.CreateBy_FINALESPRECIOS = sCreateBy_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.Dateby_FINALESPRECIOS = tDateby_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.Modiby_FINALESPRECIOS = sModiby_FINALESPRECIOS;
            oeOPE_DigFORMATOFINALESPRECIOS.DateModiBy_FINALESPRECIOS = tDateModiBy_FINALESPRECIOS;


            return oeOPE_DigFORMATOFINALESPRECIOS;

        }


        /// <summary>
        /// Método para consultar registros en la tabla OPE_DigFORMATOFINALESPRECIOS
        /// Ing. Mauricio Ortiz
        /// 29/04/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_OpeDigFORMATOFINALSOD"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iNodeCommercial"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <returns></returns>
        /// 
        /// Backup del metodo anterior, se modifica porque el store procedure 'UP_WEBXPLORA_OPE_DIG_CONSULTAR_FORMATO_FINALES_PRECIOS' no contiene los parametros
        /// sid_planning,  iCod_Formato. Fecha:15/06/2011. Por: Pablo Salas.
        ///
        public DataTable ConsultarOPE_DigFORMATOFINALESPRECIOS(string sid_planning, int iCod_Formato, DateTime tFecha_OpeDigFORMATOFINALSOD, int iPerson_id,
            int iNodeCommercial, string sClientPDV_Code)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_CONSULTAR_FORMATO_FINALES_PRECIOS", sid_planning, iCod_Formato, tFecha_OpeDigFORMATOFINALSOD, iPerson_id,
             iNodeCommercial, sClientPDV_Code);
            EOPE_DigFORMATOFINALSOD oeOPE_DigFORMATOFINALSOD = new EOPE_DigFORMATOFINALSOD();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
            }
            return null;

        }

        //public DataTable ConsultarOPE_DigFORMATOFINALESPRECIOS(DateTime tFecha_OpeDigFORMATOFINALSOD, int iPerson_id,
        //    int iNodeCommercial, string sClientPDV_Code)
        //{

        //    DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_CONSULTAR_FORMATO_FINALES_PRECIOS",  tFecha_OpeDigFORMATOFINALSOD, iPerson_id,
        //     iNodeCommercial, sClientPDV_Code);
        //    EOPE_DigFORMATOFINALSOD oeOPE_DigFORMATOFINALSOD = new EOPE_DigFORMATOFINALSOD();
        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            return dt;
        //        }
        //    }
        //    return null;

        //}


        /// <summary>
        /// Método para Actualizar registros en la tabla OPE_DigFORMATOFINALESPRECIOS
        /// Ing. Mauricio Ortiz
        /// 29/04/2011 
        /// </summary>
        /// <param name="iid_FINALESPRECIOS"></param>
        /// <param name="sCosto_FINALESPRECIOS"></param>
        /// <param name="sReventa_FINALESPRECIOS"></param>
        /// <param name="sObservacion_FINALESPRECIOS"></param>
        /// <param name="sReventaUnid_FINALESPRECIOS"></param>
        /// <param name="sModiby_FINALESPRECIOS"></param>
        /// <param name="tDateModiBy_FINALESPRECIOS"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOFINALESPRECIOS ActualizarOPE_DigFORMATOFINALESPRECIOS(long iid_FINALESPRECIOS, string sCosto_FINALESPRECIOS, string sReventa_FINALESPRECIOS,
         string sObservacion_FINALESPRECIOS, string sReventaUnid_FINALESPRECIOS, string sModiby_FINALESPRECIOS, DateTime tDateModiBy_FINALESPRECIOS)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ACTUALIZAR_FORMATO_FINALES_PRECIOS", iid_FINALESPRECIOS, sCosto_FINALESPRECIOS, sReventa_FINALESPRECIOS,
          sObservacion_FINALESPRECIOS, sReventaUnid_FINALESPRECIOS, sModiby_FINALESPRECIOS, tDateModiBy_FINALESPRECIOS);

            EOPE_DigFORMATOFINALESPRECIOS oaOPE_DigFORMATOFINALESPRECIOS = new EOPE_DigFORMATOFINALESPRECIOS();

            oaOPE_DigFORMATOFINALESPRECIOS.id_FINALESPRECIOS = iid_FINALESPRECIOS;
            oaOPE_DigFORMATOFINALESPRECIOS.Costo_FINALESPRECIOS = sCosto_FINALESPRECIOS;
            oaOPE_DigFORMATOFINALESPRECIOS.Reventa_FINALESPRECIOS = sReventa_FINALESPRECIOS;
            oaOPE_DigFORMATOFINALESPRECIOS.Observacion_FINALESPRECIOS = sObservacion_FINALESPRECIOS;
            oaOPE_DigFORMATOFINALESPRECIOS.ReventaUnid_FINALESPRECIOS = sReventaUnid_FINALESPRECIOS;
            oaOPE_DigFORMATOFINALESPRECIOS.Modiby_FINALESPRECIOS = sModiby_FINALESPRECIOS;
            oaOPE_DigFORMATOFINALESPRECIOS.DateModiBy_FINALESPRECIOS = tDateModiBy_FINALESPRECIOS;
            return oaOPE_DigFORMATOFINALESPRECIOS;
        }

        /// <summary>
        /// Método para Eliminar registros en la tabla OPE_DigFORMATOFINALESPRECIOS
        /// Ing. Mauricio Ortiz
        /// 29/04/2011
        /// </summary>
        /// <param name="iid_FINALESPRECIOS"></param>
        /// <returns></returns>
        public DataTable EliminarOPE_DigFORMATOFINALESPRECIOS(long iid_FINALESPRECIOS)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ELIMINAR_FORMATO_FINALES_PRECIOS", iid_FINALESPRECIOS);
            return dt; 
        }
    }
}
