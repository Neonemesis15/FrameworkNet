using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase:              Info_Planning_City
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  08/10/2010        
    /// Requerimientos No:  
    /// Descripcion:        Define los métodos del negocio para la clase Info_Planning_City
    /// </summary>
    /// 
    public class Info_Planning_City
    {
        public Info_Planning_City()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        /// Método para registrar las ciudades a las cuakles aplica el informe cargado
        /// Ing. Mauricio Ortiz
        /// 08/10/2010
        /// </summary>
        /// <param name="lid_infoplanningcity"></param>
        /// <param name="iid_infoplanning"></param>
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
            DInfo_Planning_City odRInfo_Planning_City = new DInfo_Planning_City();
            EInfo_Planning_City oerInfo_Planning_City = odRInfo_Planning_City.RegistrarCityInfoPlanning(iid_infoplanning, lcod_Oficina,
            scod_City, binfoplanningcity_Status, sinfoplanningcity_CreateBy,
            tinfoplanningcity_DateBy, sinfoplanningcity_ModiBy, tinfoplanningcity_DateModiBy);
            odRInfo_Planning_City = null;
            return oerInfo_Planning_City;
        }
    }
}