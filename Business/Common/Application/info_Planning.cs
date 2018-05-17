using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Data.Common.Security;
using Lucky.Entity.Common.Application;
using Lucky.Business;
using Lucky.Entity.Common.Security;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Info_Planning
    /// CreateBy: Ing. Magaly_Andrea_Jiménez
    /// DateBy: 03/06/2010
    /// Description: Establece los metodos para operar informacion relacionada con Info_Planning Lucky
    /// Requerimiento No:
    /// </summary>
    public class info_Planning
    {
        public info_Planning()
        {
            //Se define el constructor por defecto
        }

        public DataSet Eliminar_Info_Planning(string sruta_reporte, string scod_channel)
        {
            Lucky.Data.Common.Application.Dinfo_Planning odainfo_Planning = new Lucky.Data.Common.Application.Dinfo_Planning();
            DataSet dsinfo_Planning = odainfo_Planning.Eliminar_info_Planning(sruta_reporte, scod_channel);
            odainfo_Planning = null;
            return dsinfo_Planning;
        }

        public DataTable Duplicados_Info_Planning(string scod_Channel, string sruta_reporte)
        {
            Dinfo_Planning odsinfo_Planning = new Dinfo_Planning();
            DataTable dt = odsinfo_Planning.Duplicados_Info_Planning(scod_Channel, sruta_reporte);
            return dt;
        }

        public DataTable Duplicados_Info_Planning_consubcanal(string scod_Channel, string sruta_reporte, string scod_SubChannel)
        {
            Dinfo_Planning odsinfo_Planning = new Dinfo_Planning();
            DataTable dt = odsinfo_Planning.Duplicados_Info_Planning_consubcanal(scod_Channel, sruta_reporte, scod_SubChannel);
            return dt;
        }
    }
}
