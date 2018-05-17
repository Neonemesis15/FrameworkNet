using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DSesion_Users
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creación; 17/11/2010    
    /// Descripción : Clase Data encargada de definir todos los metodos transaccionales para operar Sesion_Users
    /// </summary>
    public class DSesion_Users
    {
        private Conexion oConn;

        public DSesion_Users()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }


        /// <summary>
        /// Descripción : Método para registrar auditoria de ingreso al sistema xplora
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 17/11/2010
        /// </summary>
        /// <param name="sname_user"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="sModulo_id"></param>
        /// <param name="sModulo_Name"></param>        
        /// <param name="sMachine"></param>
        /// <param name="tDateby"></param>
        /// <returns>oerSesion_Users</returns>
        public ESesion_Users Registrar_Auditoria(string sname_user, int iCompany_id, string sMachine, DateTime tDateby)
        {
            DataTable dtRegistrar = oConn.ejecutarDataTable("UP_WEBXPLORA_GEN_AUDITORIAINGRESO", sname_user, iCompany_id, sMachine, tDateby);

            ESesion_Users oerSesion_Users = new ESesion_Users();
            oerSesion_Users.name_user = sname_user;
            oerSesion_Users.Company_id = iCompany_id;
            oerSesion_Users.Machine = sMachine;
            oerSesion_Users.Dateby = tDateby;
            return oerSesion_Users;
        }

        /// <summary>
        /// Descripción : Método para registrar auditoria de ingreso al sistema xplora al modulo cliente e intentar descargar un informe
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 18/11/2010
        /// </summary>
        /// <param name="sname_user"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="iReport_id"></param>
        /// <param name="sMachine"></param>
        /// <param name="sNameFile"></param>
        /// <param name="tDateby"></param>
        /// <param name="sHora"></param>        
        /// <returns></returns>
        public ESesion_Users Registrar_Auditoria_Download(string sname_user, int iCompany_id, string scod_Channel, int iReport_id, string sMachine, string sNameFile, DateTime tDateby, string sHora)
        {
            DataTable dtRegistrar = oConn.ejecutarDataTable("UP_WEBXPLORA_GEN_AUDITORIADOWNLOAD", sname_user, iCompany_id, scod_Channel, iReport_id, sMachine, sNameFile, tDateby, sHora);

            ESesion_Users oerSesion_Users = new ESesion_Users();
            oerSesion_Users.name_user = sname_user;
            oerSesion_Users.Company_id = iCompany_id;
            oerSesion_Users.cod_Channel = scod_Channel;
            oerSesion_Users.Report_Id = iReport_id;
            oerSesion_Users.Machine = sMachine;
            oerSesion_Users.NameFile = sNameFile;
            oerSesion_Users.Dateby = tDateby;
            oerSesion_Users.Hora = sHora;
            return oerSesion_Users;
        }

        /// <summary>
        /// Descripción : Método para validar duplicados antes de registrar auditoria de ingreso al sistema xplora al modulo cliente e intentar descargar un informe
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 19/11/2010
        /// </summary>
        /// <param name="sname_user"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="iReport_id"></param>
        /// <param name="sMachine"></param>
        /// <param name="sNameFile"></param>
        /// <param name="sHora"></param>
        /// <returns></returns>
        public DataTable Duplicado_Auditoria_Download(string sname_user, int iCompany_id, string scod_Channel, int iReport_id, string sMachine, string sNameFile, string sHora)
        {
            DataTable dtDuplicado = oConn.ejecutarDataTable("UP_WEBXPLORA_GEN_DUPLICADOAUDITORIADOWNLOAD", sname_user, iCompany_id, scod_Channel, iReport_id, sMachine, sNameFile, sHora);
            return dtDuplicado;
        }
    }
}



