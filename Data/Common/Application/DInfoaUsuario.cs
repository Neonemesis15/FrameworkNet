using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;



namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción: perite realizar metodos transaccionales de insertar, consultar y Actualizar datos en la tabla de CLIE_Users_Reports.
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate:03/08/2010
    /// Requerimiento:
    ///     /// Modificación se agrega campo de subchannel.  08/04/2011  Magaly Jiménez
    /// 
    public class DInfoaUsuario
    {
        private Conexion oConn;
        public DInfoaUsuario()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //metodo de insercion en asiganción de informe ausuario CLIE_Users_Reports
        public EInfoaUsaurio InsertarAsignciónInfoaUsu(int iPerson_id, int iReport_Id, int icod_Strategy, string scod_Channel, string scod_subchannel, string scod_Subnivel, int iCompany_id, bool buserinfo_status,
        string suserinfo_CreateBy, DateTime duserinfo_DateBy, string suserinfo_ModiBy, DateTime duserinfo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_INSERTARINFORMEAUSUARIO", iPerson_id, iReport_Id, icod_Strategy, scod_Channel,scod_subchannel, scod_Subnivel, iCompany_id, buserinfo_status,
           suserinfo_CreateBy, duserinfo_DateBy, suserinfo_ModiBy, duserinfo_DateModiBy);

            EInfoaUsaurio oeiInfoaUsu = new EInfoaUsaurio();

            oeiInfoaUsu.Person_id = iPerson_id;
            oeiInfoaUsu.Report_Id = iReport_Id;
            oeiInfoaUsu.cod_Strategy = icod_Strategy;
            oeiInfoaUsu.cod_Channel = scod_Channel;
            oeiInfoaUsu.cod_subchannel = scod_Channel;
            oeiInfoaUsu.Company_id = iCompany_id;
            oeiInfoaUsu.userinfo_status = buserinfo_status;
            oeiInfoaUsu.userinfo_CreateBy = suserinfo_CreateBy;
            oeiInfoaUsu.userinfo_DateBy = duserinfo_DateBy;
            oeiInfoaUsu.userinfo_ModiBy = suserinfo_ModiBy;
            oeiInfoaUsu.userinfo_DateModiBy = duserinfo_DateModiBy;

            return oeiInfoaUsu;
        }

        // Metodo para consultar Asignación de informe por usuario de tabla CLIE_Users_Reports
        /// <summary>
        /// Modificación: se modifica consulta se cambia de grilla a consulta normal con cuatro parametros
        /// 12/10/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="icod_Strategy"></param>
        /// <returns>dt</returns>
        public DataTable ConsultarAsignciónInfoaUsu(int iCompany_id,int iPerson_id, string scod_Channel, int icod_Strategy )
        {
            DataTable dt = oConn.ejecutarDataTable ("UP_WEBXPLORA_AD_CONSULTARCLIE_USERS_REPORTS", iCompany_id, iPerson_id, scod_Channel, icod_Strategy);
            EInfoaUsaurio oeCinfoaUsuario = new EInfoaUsaurio();
            ECompany oeCliente = new ECompany();
            EUsuario oeUsuario = new EUsuario();
            EEstrategy oeStrategy = new EEstrategy();
            ECanales oeCanal = new ECanales();
          

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {

                        oeCinfoaUsuario.id_userinforme = Convert.ToInt32(dt.Rows[i]["id_userinforme"].ToString().Trim());
                        oeCinfoaUsuario.Person_id = Convert.ToInt32(dt.Rows[i]["Person_id"].ToString().Trim());
                        //oeUsuario.nameuser = dt.Rows[i]["name_user"].ToString().Trim();
                        oeCinfoaUsuario.cod_Channel = dt.Rows[i]["cod_Channel"].ToString().Trim();
                        oeCinfoaUsuario.cod_subchannel = dt.Rows[i]["cod_subchannel"].ToString().Trim();
                        oeCinfoaUsuario.cod_Subnivel = dt.Rows[i]["cod_Subnivel"].ToString().Trim();
                        //oeCanal.ChannelName = dt.Rows[i]["Canal"].ToString().Trim();
                        oeCinfoaUsuario.cod_Strategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"].ToString().Trim());
                        //oeStrategy.StrategyName = dt.Rows[i]["Strategy_Name"].ToString().Trim();
                        oeCinfoaUsuario.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        // oeCliente.CompanyName = dt.Rows[i]["Company_Name"].ToString().Trim();
                        oeCinfoaUsuario.userinfo_status = Convert.ToBoolean(dt.Rows[i]["userinfo_status"].ToString().Trim());
                        oeCinfoaUsuario.userinfo_CreateBy = dt.Rows[i]["userinfo_CreateBy"].ToString().Trim();
                        oeCinfoaUsuario.userinfo_DateBy = Convert.ToDateTime(dt.Rows[i]["userinfo_DateBy"].ToString().Trim());
                        oeCinfoaUsuario.userinfo_ModiBy = dt.Rows[i]["userinfo_ModiBy"].ToString().Trim();
                        oeCinfoaUsuario.userinfo_DateModiBy = Convert.ToDateTime(dt.Rows[i]["userinfo_DateModiBy"].ToString().Trim());                  
              
   
                       
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }


        public EInfoaUsaurio Actualizar_AsignaciónInfoaUsu(int iPerson_id, int iReport_Id, int icod_Strategy, string scod_Channel, string scod_subchannel, string scod_Subnivel, bool buserinfo_status,
        string suserinfo_ModiBy, DateTime duserinfo_DateModiBy)
        {
            DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_AD_ACTUALIZARCLIE_USERS_REPORTS", iPerson_id, iReport_Id, icod_Strategy, scod_Channel, scod_subchannel, scod_Subnivel, buserinfo_status,
            suserinfo_ModiBy, duserinfo_DateModiBy);
            EInfoaUsaurio oeactInfoaUsu = new EInfoaUsaurio();


            oeactInfoaUsu.Person_id = iPerson_id;
            oeactInfoaUsu.Report_Id = iReport_Id;
            oeactInfoaUsu.cod_Strategy = icod_Strategy;
            oeactInfoaUsu.cod_Channel = scod_Channel;
            oeactInfoaUsu.cod_subchannel = scod_subchannel;
            oeactInfoaUsu.cod_Subnivel = scod_Subnivel;
            oeactInfoaUsu.userinfo_status = buserinfo_status;
            oeactInfoaUsu.userinfo_ModiBy = suserinfo_ModiBy;
            oeactInfoaUsu.userinfo_DateModiBy = duserinfo_DateModiBy;


            return oeactInfoaUsu;
        }

    }
}