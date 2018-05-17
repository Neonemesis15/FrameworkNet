using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{    /// <summary>
    /// Descripción métodos para City_UserReports
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate: 08-09-2010
    /// Requerimiento:
    public class DCity_UserReport
    {
        private Conexion oConn;
        public DCity_UserReport()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        /// <summary>
        /// inserta información en tabla de city_userReport
        /// 23/10/2010 Magaly jimenez
        /// Modificación: se cambia campo de cod_City por  cod_Oficina
        /// 29/10/2010 Magaly jimenez
        /// </summary>
        /// <param name="iid_userinforme"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="bCity_UserRepor_Status"></param>
        /// <param name="sCity_UserRepor_CreateBy"></param>
        /// <param name="tCity_UserRepor_DateBy"></param>
        /// <param name="sCity_UserRepor_ModiBy"></param>
        /// <param name="tCity_UserRepor_DateModiBy"></param>
        /// <returns></returns>
        public ECity_UserReport RegistrarCityUserReports(int iid_userinforme, long lcod_Oficina, bool bCity_UserRepor_Status,
          string sCity_UserRepor_CreateBy, DateTime tCity_UserRepor_DateBy, string sCity_UserRepor_ModiBy, DateTime tCity_UserRepor_DateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_CITYUSERREPORTS", iid_userinforme, lcod_Oficina, bCity_UserRepor_Status,
            sCity_UserRepor_CreateBy, tCity_UserRepor_DateBy, sCity_UserRepor_ModiBy, tCity_UserRepor_DateModiBy);

            ECity_UserReport oerCityUserReport = new ECity_UserReport();

            oerCityUserReport.id_userinforme = iid_userinforme;
            oerCityUserReport.cod_Oficina = lcod_Oficina;
            oerCityUserReport.City_UserRepor_Status = bCity_UserRepor_Status;
            oerCityUserReport.City_UserRepor_CreateBy = sCity_UserRepor_CreateBy;
            oerCityUserReport.City_UserRepor_DateBy = tCity_UserRepor_DateBy;
            oerCityUserReport.City_UserRepor_ModiBy = sCity_UserRepor_ModiBy;
            oerCityUserReport.City_UserRepor_DateModiBy = tCity_UserRepor_DateModiBy;
            return oerCityUserReport;

        }
        /// <summary>
        /// Actualiza ciudades para maestro de asignación de informes a usuario.
        /// 21/10/2010 Magaly Jiménez
        /// Modificación: se cambia campo de cod_City por  cod_Oficina
        /// 29/10/2010 Magaly jimenez
        /// </summary>
        /// <param name="lid_City_UserRepor"></param>
        /// <param name="iid_userinforme"></param>
        /// <param name="scod_City"></param>
        /// <param name="bCity_UserRepor_Status"></param>
        /// <param name="sCity_UserRepor_ModiBy"></param>
        /// <param name="tCity_UserRepor_DateModiBy"></param>
        /// <returns></returns>
        public ECity_UserReport Actualizar_CityUserReport(int iid_userinforme, long lcod_Oficina, bool bCity_UserRepor_Status,
            string sCity_UserRepor_ModiBy, DateTime tCity_UserRepor_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARCLIE_CITY_USERS_REPORTS", iid_userinforme, lcod_Oficina, bCity_UserRepor_Status,
            sCity_UserRepor_ModiBy, tCity_UserRepor_DateModiBy);
            ECity_UserReport oeeaCityUR = new ECity_UserReport();

            oeeaCityUR.id_userinforme = iid_userinforme;
            oeeaCityUR.cod_Oficina = lcod_Oficina;
            oeeaCityUR.City_UserRepor_Status = bCity_UserRepor_Status;
            oeeaCityUR.City_UserRepor_ModiBy = sCity_UserRepor_ModiBy;
            oeeaCityUR.City_UserRepor_DateModiBy = tCity_UserRepor_DateModiBy;
          
            return oeeaCityUR;
        }

        

    }
}
