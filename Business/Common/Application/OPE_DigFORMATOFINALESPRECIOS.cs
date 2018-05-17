using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;


namespace Lucky.Business.Common.Application
{
    public class OPE_DigFORMATOFINALESPRECIOS
    {
        public OPE_DigFORMATOFINALESPRECIOS()
        {
            //Se define el constructor por defecto
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
            int iPerson_id, int iNodeCommercial, string sClientPDV_Code, string spdv_Name, string sid_ProductSubCategory,
             string scod_Product, string sProduct_name, string sCosto_FINALESPRECIOS, string sReventa_FINALESPRECIOS,
             string sObservacion_FINALESPRECIOS, string sReventaUnid_FINALESPRECIOS, string sCreateBy_FINALESPRECIOS,
            DateTime tDateby_FINALESPRECIOS, string sModiby_FINALESPRECIOS, DateTime tDateModiBy_FINALESPRECIOS)
        {
            DOPE_DigFORMATOFINALESPRECIOS odrOPE_DigFORMATOFINALESPRECIOS = new DOPE_DigFORMATOFINALESPRECIOS();
            EOPE_DigFORMATOFINALESPRECIOS oeOPE_DigFORMATOFINALESPRECIOS = odrOPE_DigFORMATOFINALESPRECIOS.RegistrarFormatoFinalesPrecios( sid_planning,  iCod_Formato,tFecha_FINALESPRECIOS,
             iPerson_id, iNodeCommercial, sClientPDV_Code, spdv_Name, sid_ProductSubCategory,
              scod_Product, sProduct_name, sCosto_FINALESPRECIOS, sReventa_FINALESPRECIOS,
              sObservacion_FINALESPRECIOS, sReventaUnid_FINALESPRECIOS, sCreateBy_FINALESPRECIOS,
             tDateby_FINALESPRECIOS, sModiby_FINALESPRECIOS, tDateModiBy_FINALESPRECIOS);
            odrOPE_DigFORMATOFINALESPRECIOS = null;
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
        /// Backup del metodo anterior se modifica porque el Store procedure no contiene los parametros sid_planning,iCod_Formato. Fecha:15/06/2011. Por: Pablo Salas.
        public DataTable ConsultarOPE_DigFORMATOFINALESPRECIOS(string sid_planning, int iCod_Formato, DateTime tFecha_OpeDigFORMATOFINALSOD, int iPerson_id,
            int iNodeCommercial, string sClientPDV_Code)
        {
            DOPE_DigFORMATOFINALESPRECIOS odOPE_DigFORMATOFINALESPRECIOS = new DOPE_DigFORMATOFINALESPRECIOS();
            DataTable dt = odOPE_DigFORMATOFINALESPRECIOS.ConsultarOPE_DigFORMATOFINALESPRECIOS(sid_planning, iCod_Formato, tFecha_OpeDigFORMATOFINALSOD, iPerson_id,
             iNodeCommercial, sClientPDV_Code);
            return dt;
        }
        //       public DataTable ConsultarOPE_DigFORMATOFINALESPRECIOS(string sid_planning, int iCod_Formato, DateTime tFecha_OpeDigFORMATOFINALSOD, int iPerson_id,
        //    int iNodeCommercial, string sClientPDV_Code)
        //{
        //    DOPE_DigFORMATOFINALESPRECIOS odOPE_DigFORMATOFINALESPRECIOS = new DOPE_DigFORMATOFINALESPRECIOS();
        //    DataTable dt = odOPE_DigFORMATOFINALESPRECIOS.ConsultarOPE_DigFORMATOFINALESPRECIOS( tFecha_OpeDigFORMATOFINALSOD, iPerson_id,
        //     iNodeCommercial, sClientPDV_Code);
        //    return dt;
        //}


        /// <summary>
        /// Método para Eliminar registros en la tabla OPE_DigFORMATOFINALESPRECIOS
        /// Ing. Mauricio Ortiz
        /// 29/04/2011
        /// <param name="iid_FINALESPRECIOS"></param>
        /// <returns></returns>
        public DataTable EliminarOPE_DigFORMATOFINALESPRECIOS(long iid_FINALESPRECIOS)
        {
            DOPE_DigFORMATOFINALESPRECIOS odOPE_DigFORMATOFINALESPRECIOS = new DOPE_DigFORMATOFINALESPRECIOS();
            DataTable dt = odOPE_DigFORMATOFINALESPRECIOS.EliminarOPE_DigFORMATOFINALESPRECIOS(iid_FINALESPRECIOS);
            odOPE_DigFORMATOFINALESPRECIOS = null;
            return dt;
        }

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
            DOPE_DigFORMATOFINALESPRECIOS odaOPE_DigFORMATOFINALESPRECIOS = new DOPE_DigFORMATOFINALESPRECIOS();
            EOPE_DigFORMATOFINALESPRECIOS oeOPE_DigFORMATOFINALESPRECIOS = odaOPE_DigFORMATOFINALESPRECIOS.ActualizarOPE_DigFORMATOFINALESPRECIOS(iid_FINALESPRECIOS, sCosto_FINALESPRECIOS, sReventa_FINALESPRECIOS,
          sObservacion_FINALESPRECIOS, sReventaUnid_FINALESPRECIOS, sModiby_FINALESPRECIOS, tDateModiBy_FINALESPRECIOS);
            odaOPE_DigFORMATOFINALESPRECIOS = null;
            return oeOPE_DigFORMATOFINALESPRECIOS;
        }
    }
}
