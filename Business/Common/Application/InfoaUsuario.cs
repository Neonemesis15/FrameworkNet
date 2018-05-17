using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: InfoaUsuarios tabla CLIE_Users_Reports
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 03/08/2010
    /// Description: establece metodos de insercion, consulta y actualización de Asignación de informe a usuario en la tabla CLIE_Users_Reports.
    /// Requerimiento No:
    /// Modificación se agrega campo de subchannel.  08/04/2011  Magaly Jiménez
    /// </summary>
    public class InfoaUsuario
    {
        public InfoaUsuario()
        {
        }
        //Metodo que permite insertar registros de asignación de informe a usuario.

        public EInfoaUsaurio InsertarInfoaUsuario(int iPerson_id, int iReport_Id, int icod_Strategy, string scod_Channel, string scod_subchannel, string scod_Subnivel, int iCompany_id, bool buserinfo_status,
        string suserinfo_CreateBy, DateTime duserinfo_DateBy, string suserinfo_ModiBy, DateTime duserinfo_DateModiBy)
        {
            DInfoaUsuario odiInfoaUsurio = new DInfoaUsuario();

            EInfoaUsaurio oeInfoaUsuario = odiInfoaUsurio.InsertarAsignciónInfoaUsu(iPerson_id, iReport_Id, icod_Strategy, scod_Channel, scod_subchannel, scod_Subnivel, iCompany_id, buserinfo_status,
          suserinfo_CreateBy, duserinfo_DateBy, suserinfo_ModiBy, duserinfo_DateModiBy);

            odiInfoaUsurio = null;
            return oeInfoaUsuario;

        }
        /// <summary>
        /// Modificación: se modifica consulta se cambia de grilla a consulta normal con cuatro parametros
        /// 12/10/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="icod_Strategy"></param>
        /// <returns>dsInfoaUsuario</returns>
        public DataTable ConsultarInfoaUsuario(int iCompany_id, int iPerson_id, string scod_Channel, int icod_Strategy)
        {
            Lucky.Data.Common.Application.DInfoaUsuario odCInfoaUsuario = new Lucky.Data.Common.Application.DInfoaUsuario();
            EInfoaUsaurio oeInfoaUsuario = new EInfoaUsaurio();
            DataTable dsInfoaUsuario = odCInfoaUsuario.ConsultarAsignciónInfoaUsu(iCompany_id, iPerson_id, scod_Channel, icod_Strategy);
            odCInfoaUsuario = null;
            return dsInfoaUsuario;
        }






        /// <summary>
        /// se actualiza información de tabla Clie_userReport
        /// </summary>
        /// <param name="iPerson_id"></param>
        /// <param name="iReport_Id"></param>
        /// <param name="icod_Strategy"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="scod_subchannel"></param>
        /// <param name="buserinfo_status"></param>
        /// <param name="suserinfo_ModiBy"></param>
        /// <param name="duserinfo_DateModiBy"></param>
        /// <returns></returns>
        public EInfoaUsaurio Actualizar_AsignaciónInfoaUsu(int iPerson_id, int iReport_Id, int icod_Strategy, string scod_Channel, string scod_subchannel, string scod_Subnivel, bool buserinfo_status,
        string suserinfo_ModiBy, DateTime duserinfo_DateModiBy)
        {
            DInfoaUsuario odactInfoaUsu = new DInfoaUsuario();
            EInfoaUsaurio oeactInfoaUsu = odactInfoaUsu.Actualizar_AsignaciónInfoaUsu(iPerson_id, iReport_Id, icod_Strategy, scod_Channel,  scod_subchannel, scod_Subnivel, buserinfo_status,
            suserinfo_ModiBy, duserinfo_DateModiBy);

            oeactInfoaUsu = null;
            return oeactInfoaUsu;
        }
    }

}
