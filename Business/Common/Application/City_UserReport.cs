using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{/// <summary>
    /// Clase: City_UserReports
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 08/10/2010
    /// Description: Establece los metodos para operar informacion relacionada con las Ciudades almacenadas desde el maestro de asignación de Informes a Usuarios.
    /// Requerimiento No:
    /// </summary>
    /// 
    public class City_UserReport
    {
        public City_UserReport()
        {
            //Se define el constructor por defecto
        }
        /// <summary>
        /// Permite insertar las ciudades que se seleccionan en el maestro de asignación de informes a ususarios.
        /// 08/10/2010  Magaly Jiménez
        /// Modificiacón: se cambia tipo de cod_City por cod_Oficina
        /// 29/10/2010  Magaly Jiménez
        /// </summary>
        /// <param name="iid_userinforme"></param>
        /// <param name="scod_City"></param>
        /// <param name="bCity_UserRepor_Status"></param>
        /// <param name="sCity_UserRepor_CreateBy"></param>
        /// <param name="tCity_UserRepor_DateBy"></param>
        /// <param name="sCity_UserRepor_ModiBy"></param>
        /// <param name="tCity_UserRepor_DateModiBy"></param>
        /// <returns>oeCityUserReport</returns>
        public ECity_UserReport RegistrarCityUserReport(int iid_userinforme, long lcod_Oficina, bool bCity_UserRepor_Status,
          string sCity_UserRepor_CreateBy, DateTime tCity_UserRepor_DateBy, string sCity_UserRepor_ModiBy, DateTime tCity_UserRepor_DateModiBy)
        {
            DCity_UserReport odrCityUserReport = new DCity_UserReport();
            ECity_UserReport oeCityUserReport =odrCityUserReport.RegistrarCityUserReports(iid_userinforme, lcod_Oficina, bCity_UserRepor_Status,
            sCity_UserRepor_CreateBy, tCity_UserRepor_DateBy, sCity_UserRepor_ModiBy, tCity_UserRepor_DateModiBy);


            odrCityUserReport = null;
            return oeCityUserReport;
        }
        /// <summary>
        /// Permite Actualizar ciudades en maestro de asignación de informes a usuarios.
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
        public ECity_UserReport ActualizarCityUR(int iid_userinforme, long lcod_Oficina, bool bCity_UserRepor_Status,
            string sCity_UserRepor_ModiBy, DateTime tCity_UserRepor_DateModiBy)
        {
            DCity_UserReport odaCityUR = new DCity_UserReport();
            ECity_UserReport oeaCityUserR=odaCityUR.Actualizar_CityUserReport( iid_userinforme, lcod_Oficina, bCity_UserRepor_Status,
            sCity_UserRepor_ModiBy, tCity_UserRepor_DateModiBy);
            odaCityUR = null;
            return oeaCityUserR;



        }
    }
}
