using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;
namespace Lucky.Business.Common.Application
{
    public class OPE_DigFORMATOFINALSOD
    {
        public OPE_DigFORMATOFINALSOD()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        /// Método para registrar en la tabla OPE_DigFORMATOFINALSOD
        /// Ing. Mauricio Ortiz
        /// 27/04/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_OpeDigFORMATOFINALSOD"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="spdv_Name"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="sname_ProductCategory"></param>
        /// <param name="sname_Brand"></param>
        /// <param name="sExhPrim_OpeDigFORMATOFINALSOD"></param>
        /// <param name="sExhSec_OpeDigFORMATOFINALSOD"></param>
        /// <param name="sCreateBy_OpeDigFORMATOFINALSOD"></param>
        /// <param name="tDateby_OpeDigFORMATOFINALSOD"></param>
        /// <param name="sModiby_OpeDigFORMATOFINALSOD"></param>
        /// <param name="tDateModiBy_OpeDigFORMATOFINALSOD"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOFINALSOD RegistrarFormatoFinalSod(string sid_planning, int iCod_Formato, DateTime tFecha_OpeDigFORMATOFINALSOD,
            int iPerson_id, string sClientPDV_Code, string spdv_Name, long lcod_Oficina, string sname_ProductCategory,
                string sname_Brand, string sExhPrim_OpeDigFORMATOFINALSOD, string sExhSec_OpeDigFORMATOFINALSOD,
                    string sCreateBy_OpeDigFORMATOFINALSOD, DateTime tDateby_OpeDigFORMATOFINALSOD, string sModiby_OpeDigFORMATOFINALSOD,
                        DateTime tDateModiBy_OpeDigFORMATOFINALSOD)
        {
            DOPE_DigFORMATOFINALSOD odrOPE_DigFORMATOFINALSOD = new DOPE_DigFORMATOFINALSOD();
            EOPE_DigFORMATOFINALSOD oeOPE_DigFORMATOFINALSOD = odrOPE_DigFORMATOFINALSOD.RegistrarFormatoFinalSod( sid_planning,  iCod_Formato,tFecha_OpeDigFORMATOFINALSOD,
             iPerson_id, sClientPDV_Code, spdv_Name, lcod_Oficina, sname_ProductCategory,
                 sname_Brand, sExhPrim_OpeDigFORMATOFINALSOD, sExhSec_OpeDigFORMATOFINALSOD,
                     sCreateBy_OpeDigFORMATOFINALSOD, tDateby_OpeDigFORMATOFINALSOD, sModiby_OpeDigFORMATOFINALSOD,
                         tDateModiBy_OpeDigFORMATOFINALSOD);
            odrOPE_DigFORMATOFINALSOD = null;
            return oeOPE_DigFORMATOFINALSOD;
        }

        /// <summary>
        /// Método para consultar registros en la tabla OPE_DigFORMATOFINALSOD
        /// Ing. Mauricio Ortiz
        /// 28/04/2011
        /// </summary>
        /// <param name="iCod_Formato"></param>
        /// <param name="sid_planning"></param>
        /// <param name="tFecha_OpeDigFORMATOFINALSOD"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="icod_Oficina"></param>
        /// <returns></returns>
        public DataTable ConsultarOPE_DigFORMATOFINALSOD(string sid_planning, int iCod_Formato, DateTime tFecha_OpeDigFORMATOFINALSOD, int iPerson_id,
                string sClientPDV_Code, long icod_Oficina)
        {
            DOPE_DigFORMATOFINALSOD odOPE_DigFORMATOFINALSOD = new DOPE_DigFORMATOFINALSOD();
            DataTable dt = odOPE_DigFORMATOFINALSOD.ConsultarOPE_DigFORMATOFINALSOD( sid_planning,  iCod_Formato,tFecha_OpeDigFORMATOFINALSOD, iPerson_id,
                 sClientPDV_Code, icod_Oficina); 
            return dt;
        }


        /// <summary>
        /// Método para Eliminar registros en la tabla OPE_DigFORMATOFINALSOD
        /// Ing. Mauricio Ortiz
        /// 28/04/2011
        /// </summary>
        /// <param name="tFecha_OpeDigFORMATOFINALSOD"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="icod_Oficina"></param>
        /// <returns></returns>
        public DataTable EliminarOPE_DigFORMATOFINALSOD( long iid_OpeDigFORMATOFINALSOD)
        {
            DOPE_DigFORMATOFINALSOD odOPE_DigFORMATOFINALSOD = new DOPE_DigFORMATOFINALSOD();
            DataTable dt = odOPE_DigFORMATOFINALSOD.EliminarOPE_DigFORMATOFINALSOD(iid_OpeDigFORMATOFINALSOD);
            odOPE_DigFORMATOFINALSOD = null;
            return dt;
        }


        /// <summary>
        /// Método para Actualizar registros en la tabla OPE_DigFORMATOFINALSOD
        /// Ing. Mauricio Ortiz
        /// 28/04/2011 
        /// </summary>
        /// <param name="iid_OpeDigFORMATOFINALSOD"></param>
        /// <param name="sExhPrim_OpeDigFORMATOFINALSOD"></param>
        /// <param name="sExhSec_OpeDigFORMATOFINALSOD"></param>
        /// <param name="sModiby_OpeDigFORMATOFINALSOD"></param>
        /// <param name="tDateModiBy_OpeDigFORMATOFINALSOD"></param>
        /// <returns></returns>
        public EOPE_DigFORMATOFINALSOD ActualizarOPE_DigFORMATOFINALSOD(long iid_OpeDigFORMATOFINALSOD, string sExhPrim_OpeDigFORMATOFINALSOD, string sExhSec_OpeDigFORMATOFINALSOD,
            string sModiby_OpeDigFORMATOFINALSOD, DateTime tDateModiBy_OpeDigFORMATOFINALSOD)
        {
            DOPE_DigFORMATOFINALSOD odaOPE_DigFORMATOFINALSOD = new DOPE_DigFORMATOFINALSOD();
            EOPE_DigFORMATOFINALSOD oeOPE_DigFORMATOFINALSOD = odaOPE_DigFORMATOFINALSOD.ActualizarOPE_DigFORMATOFINALSOD(iid_OpeDigFORMATOFINALSOD, sExhPrim_OpeDigFORMATOFINALSOD, sExhSec_OpeDigFORMATOFINALSOD, sModiby_OpeDigFORMATOFINALSOD, tDateModiBy_OpeDigFORMATOFINALSOD);
            odaOPE_DigFORMATOFINALSOD = null;
            return oeOPE_DigFORMATOFINALSOD;
        }
    }
}
