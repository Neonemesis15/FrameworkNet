using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DInfo_Planning_City
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creación; 08/10/2010
    /// Requerimiento No 
    /// Descripción : Clase Data encargada de definir todos los metodos transaccionales para operar Info_Planning_City
    /// </summary>


    public class DInfo_Planning_City
    {
        private Conexion oConn;
        public DInfo_Planning_City()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        
        /// <summary>
        /// Método para registrar las ciudades a las cuakles aplica el informe cargado
        /// Ing. Mauricio Ortiz
        /// 08/10/2010
        /// Modificación : 28/10/2010 se adiciona el parametro lcod_Oficina . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_infoplanning"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="scod_City"></param>
        /// <param name="binfoplanningcity_Status"></param>
        /// <param name="sinfoplanningcity_CreateBy"></param>
        /// <param name="tinfoplanningcity_DateBy"></param>
        /// <param name="sinfoplanningcity_ModiBy"></param>
        /// <param name="tinfoplanningcity_DateModiBy"></param>
        /// <returns></returns>
        public EInfo_Planning_City RegistrarCityInfoPlanning(int iid_infoplanning, long lcod_Oficina,
            string scod_City, bool binfoplanningcity_Status, string sinfoplanningcity_CreateBy,
            DateTime tinfoplanningcity_DateBy, string sinfoplanningcity_ModiBy, DateTime tinfoplanningcity_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_CIUDADESINFOPLANNING", iid_infoplanning, lcod_Oficina,
            scod_City, binfoplanningcity_Status, sinfoplanningcity_CreateBy,
            tinfoplanningcity_DateBy, sinfoplanningcity_ModiBy, tinfoplanningcity_DateModiBy);

            EInfo_Planning_City oerInfo_Planning_City = new EInfo_Planning_City();

            
            oerInfo_Planning_City.id_infoplanning = iid_infoplanning;
            oerInfo_Planning_City.cod_Oficina = lcod_Oficina;
            oerInfo_Planning_City.cod_City = scod_City;
            oerInfo_Planning_City.infoplanningcity_Status = binfoplanningcity_Status;
            oerInfo_Planning_City.infoplanningcity_CreateBy = sinfoplanningcity_CreateBy;
            oerInfo_Planning_City.infoplanningcity_DateBy = tinfoplanningcity_DateBy;
            oerInfo_Planning_City.infoplanningcity_ModiBy = sinfoplanningcity_ModiBy;
            oerInfo_Planning_City.infoplanningcity_DateModiBy = tinfoplanningcity_DateModiBy;

            return oerInfo_Planning_City;
        }
    }
}