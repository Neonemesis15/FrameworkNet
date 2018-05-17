using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DOPE_DigFORMATOFINALSOD
    {
        private Conexion oConn;
        public DOPE_DigFORMATOFINALSOD()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
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
        /// <param name="icod_Oficina"></param>                
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
            int iPerson_id  , string sClientPDV_Code  , string spdv_Name, long  icod_Oficina, string sname_ProductCategory ,
                string sname_Brand, string sExhPrim_OpeDigFORMATOFINALSOD  ,  string sExhSec_OpeDigFORMATOFINALSOD  ,
                    string sCreateBy_OpeDigFORMATOFINALSOD  , DateTime tDateby_OpeDigFORMATOFINALSOD , string sModiby_OpeDigFORMATOFINALSOD,
                        DateTime tDateModiBy_OpeDigFORMATOFINALSOD)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_INSERTAR_FORMATO_FINAL_SOD",  sid_planning,  iCod_Formato, tFecha_OpeDigFORMATOFINALSOD,
             iPerson_id, sClientPDV_Code, spdv_Name, icod_Oficina, sname_ProductCategory,
                 sname_Brand, sExhPrim_OpeDigFORMATOFINALSOD, sExhSec_OpeDigFORMATOFINALSOD,
                     sCreateBy_OpeDigFORMATOFINALSOD, tDateby_OpeDigFORMATOFINALSOD, sModiby_OpeDigFORMATOFINALSOD,
                         tDateModiBy_OpeDigFORMATOFINALSOD);

            EOPE_DigFORMATOFINALSOD oeEOPE_DigFORMATOFINALSOD = new EOPE_DigFORMATOFINALSOD();


            oeEOPE_DigFORMATOFINALSOD.id_planning = sid_planning;
            oeEOPE_DigFORMATOFINALSOD.Cod_Formato = iCod_Formato;
            oeEOPE_DigFORMATOFINALSOD.Fecha_OpeDigFORMATOFINALSOD = tFecha_OpeDigFORMATOFINALSOD;
            oeEOPE_DigFORMATOFINALSOD.Person_id = iPerson_id;
            oeEOPE_DigFORMATOFINALSOD.ClientPDV_Code = sClientPDV_Code;
            oeEOPE_DigFORMATOFINALSOD.pdv_Name = spdv_Name;
            oeEOPE_DigFORMATOFINALSOD.cod_Oficina = icod_Oficina;
            oeEOPE_DigFORMATOFINALSOD.name_ProductCategory = sname_ProductCategory;
            oeEOPE_DigFORMATOFINALSOD.name_Brand = sname_Brand;
            oeEOPE_DigFORMATOFINALSOD.ExhPrim_OpeDigFORMATOFINALSOD = sExhPrim_OpeDigFORMATOFINALSOD;
            oeEOPE_DigFORMATOFINALSOD.ExhSec_OpeDigFORMATOFINALSOD = sExhSec_OpeDigFORMATOFINALSOD;
            oeEOPE_DigFORMATOFINALSOD.CreateBy_OpeDigFORMATOFINALSOD = sCreateBy_OpeDigFORMATOFINALSOD;
            oeEOPE_DigFORMATOFINALSOD.Dateby_OpeDigFORMATOFINALSOD = tDateby_OpeDigFORMATOFINALSOD;
            oeEOPE_DigFORMATOFINALSOD.Modiby_OpeDigFORMATOFINALSOD = sModiby_OpeDigFORMATOFINALSOD;
            oeEOPE_DigFORMATOFINALSOD.DateModiBy_OpeDigFORMATOFINALSOD = tDateModiBy_OpeDigFORMATOFINALSOD;
            
            return oeEOPE_DigFORMATOFINALSOD;

        }


        /// <summary>
        /// Método para consultar registros en la tabla OPE_DigFORMATOFINALSOD
        /// Ing. Mauricio Ortiz
        /// 28/04/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iCod_Formato"></param>
        /// <param name="tFecha_OpeDigFORMATOFINALSOD"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="icod_Oficina"></param>
        /// <returns></returns>
        public DataTable ConsultarOPE_DigFORMATOFINALSOD(string sid_planning, int iCod_Formato,  DateTime tFecha_OpeDigFORMATOFINALSOD, int iPerson_id,
                string sClientPDV_Code, long icod_Oficina)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_CONSULTAR_FORMATO_FINAL_SOD", sid_planning,  iCod_Formato, tFecha_OpeDigFORMATOFINALSOD, iPerson_id,
                 sClientPDV_Code,  icod_Oficina);
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


        /// <summary>
        /// Método para Eliminar registros en la tabla OPE_DigFORMATOFINALSOD
        /// Ing. Mauricio Ortiz
        /// 28/04/2011
        /// </summary>
        /// <param name="iid_OpeDigFORMATOFINALSOD"></param>       
        /// <returns></returns>
        public DataTable EliminarOPE_DigFORMATOFINALSOD(long iid_OpeDigFORMATOFINALSOD)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ELIMINAR_FORMATO_FINAL_SOD", iid_OpeDigFORMATOFINALSOD);
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
            string sModiby_OpeDigFORMATOFINALSOD,DateTime tDateModiBy_OpeDigFORMATOFINALSOD)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_DIG_ACTUALIZAR_FORMATO_FINAL_SOD", iid_OpeDigFORMATOFINALSOD, sExhPrim_OpeDigFORMATOFINALSOD, sExhSec_OpeDigFORMATOFINALSOD, sModiby_OpeDigFORMATOFINALSOD, tDateModiBy_OpeDigFORMATOFINALSOD);

            EOPE_DigFORMATOFINALSOD oaOPE_DigFORMATOFINALSOD = new EOPE_DigFORMATOFINALSOD();

            oaOPE_DigFORMATOFINALSOD.id_OpeDigFORMATOFINALSOD = iid_OpeDigFORMATOFINALSOD;
            oaOPE_DigFORMATOFINALSOD.ExhPrim_OpeDigFORMATOFINALSOD = sExhPrim_OpeDigFORMATOFINALSOD;
            oaOPE_DigFORMATOFINALSOD.ExhSec_OpeDigFORMATOFINALSOD = sExhSec_OpeDigFORMATOFINALSOD;
            oaOPE_DigFORMATOFINALSOD.Modiby_OpeDigFORMATOFINALSOD = sModiby_OpeDigFORMATOFINALSOD;
            oaOPE_DigFORMATOFINALSOD.DateModiBy_OpeDigFORMATOFINALSOD = tDateModiBy_OpeDigFORMATOFINALSOD;
                
            return oaOPE_DigFORMATOFINALSOD;
        }

    }
}
