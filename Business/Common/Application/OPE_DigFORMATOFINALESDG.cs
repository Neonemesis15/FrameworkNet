using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class OPE_DigFORMATOFINALESDG
    {
        public OPE_DigFORMATOFINALESDG()
        {
            //Se define el constructor por defecto
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
            DOPE_DigFORMATOFINALESDG odrOPE_DigFORMATOFINALESDG = new DOPE_DigFORMATOFINALESDG();
            EOPE_DigFORMATOFINALESDG oeOPE_DigFORMATOFINALESDG = odrOPE_DigFORMATOFINALESDG.RegistrarFormatoFinalesDG( sid_planning,  iCod_Formato,tFecha_FINALESDG, iPerson_id,
             iNodeCommercial, sClientPDV_Code, spdv_Name, scod_Product,
                 sProduct_name, sLocal1, sLocal2, sLocal3,
                     sLocal4, sLocal5, sTotal, sCreateBy_FINALESDG,
               tDateby_FINALESDG, sModiby_FINALESDG, tDateModiBy_FINALESDG);
            odrOPE_DigFORMATOFINALESDG = null;
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
            DOPE_DigFORMATOFINALESDG odOPE_DigFORMATOFINALESDG = new DOPE_DigFORMATOFINALESDG();
            DataTable dt = odOPE_DigFORMATOFINALESDG.ConsultarFormatoFinalesDG( sid_planning,  iCod_Formato,tFecha_FINALESDG, iPerson_id,
            iNodeCommercial, sClientPDV_Code);
            return dt;
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
            DOPE_DigFORMATOFINALESDG odOPE_DigFORMATOFINALESDG = new DOPE_DigFORMATOFINALESDG();
            DataTable dt = odOPE_DigFORMATOFINALESDG.EliminarFormatoFinalesDG(iid_FINALESDG);
            odOPE_DigFORMATOFINALESDG = null;
            return dt;
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
            DOPE_DigFORMATOFINALESDG odaOPE_DigFORMATOFINALESDG = new DOPE_DigFORMATOFINALESDG();
            EOPE_DigFORMATOFINALESDG oeOPE_DigFORMATOFINALESDG = odaOPE_DigFORMATOFINALESDG.ActualizarFormatoFinalesDG(iid_FINALESDG, sLocal1, sLocal2, sLocal3, sLocal4, sLocal5, sTotal,
             sModiby_FINALESDG, tDateModiBy_FINALESDG);

            odaOPE_DigFORMATOFINALESDG = null;
            return oeOPE_DigFORMATOFINALESDG;
        }
    

       
    }
}