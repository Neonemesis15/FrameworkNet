using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;
namespace Lucky.Business.Common.Application
{
    public class OPE_DigFORMATOAGCOCINA
    {
        public OPE_DigFORMATOAGCOCINA()
        {
            //Se define el constructor por defecto
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
            DOPE_DigFORMATOAGCOCINA odrOPE_DigFORMATOAGCOCINA = new DOPE_DigFORMATOAGCOCINA();
            EOPE_DigFORMATOAGCOCINA oeOPE_DigFORMATOAGCOCINA = odrOPE_DigFORMATOAGCOCINA.RegistrarFormatoAGCOCINA( sid_planning,  iCod_Formato,tFecha_ini_AGCOCINA, tFecha_fin_AGCOCINA,
              iPerson_id, iNodeCommercial, sClientPDV_Code, spdv_Name, scod_Product, sProduct_name, sPrecio,
              sStock_inicial, sIngresos, sStock_Total, sStock_Final, sVentas, sCreateBy_AGCOCINA, tDateby_AGCOCINA,
              sModiby_AGCOCINA, tDateModiBy_AGCOCINA);
            odrOPE_DigFORMATOAGCOCINA = null;
            return oeOPE_DigFORMATOAGCOCINA;
        }
        

        /// <summary>
        /// Método para consultar en la tabla OPE_DigFORMATOAGCOCINA
        /// Ing. Mauricio Ortiz
        /// 25/05/2011
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
            DOPE_DigFORMATOAGCOCINA odOPE_DigFORMATOAGCOCINA = new DOPE_DigFORMATOAGCOCINA();

            DataTable dt = odOPE_DigFORMATOAGCOCINA.ConsultarFormatoAGCOCINA( sid_planning,  iCod_Formato, tFecha_ini_AGCOCINA, tFecha_fin_AGCOCINA, iPerson_id,
            iNodeCommercial, sClientPDV_Code);
            return dt;
        }

        public EOPE_DigFORMATOAGCOCINA ActualizarFormatoAGCOCINA(long iid_AGCOCINA, string sPrecio, string sStock_inicial, string sIngresos, string sStock_Total, string sStock_Final, string sVentas,
            string sModiby_AGCOCINA, DateTime tDateModiBy_AGCOCINA)
        {
            DOPE_DigFORMATOAGCOCINA odaDOPE_DigFORMATOAGCOCINA = new DOPE_DigFORMATOAGCOCINA();
            EOPE_DigFORMATOAGCOCINA oeEOPE_DigFORMATOAGCOCINA = odaDOPE_DigFORMATOAGCOCINA.ActualizarFormatoAGCOCINA(iid_AGCOCINA, sPrecio, sStock_inicial,
                 sIngresos, sStock_Total, sStock_Final, sVentas,
              sModiby_AGCOCINA, tDateModiBy_AGCOCINA);

            odaDOPE_DigFORMATOAGCOCINA = null;

            return oeEOPE_DigFORMATOAGCOCINA; ;
        }

        /// <summary>
        // Método para Eliminar registros en la tabla OPE_DigFORMATOFINALESDG
        // Ing. Mauricio Ortiz
        // 02/05/2011
        /// </summary>
        /// <param name="iid_AGCOCINA"></param>
        /// <returns></returns>
        public DataTable EliminarFormatoAGCOCINA(long iid_AGCOCINA)
        {
            DOPE_DigFORMATOAGCOCINA odDOPE_DigFORMATOAGCOCINA = new DOPE_DigFORMATOAGCOCINA();
            DataTable dt = odDOPE_DigFORMATOAGCOCINA.EliminarFormatoAGCOCINA(iid_AGCOCINA);
            odDOPE_DigFORMATOAGCOCINA = null;
            return dt;
        }    
    }
}
