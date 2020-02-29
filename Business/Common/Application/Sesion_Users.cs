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
    /// Clase: Sesion_Users
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creación; 17/11/2010    
    /// Descripción : Clase Business encargada de invocar todos los metodos data para operar Sesion_Users
    /// </summary>
    public class Sesion_Users
    {
        // Variable para guardar los Errores
        private String messages = "";


        /// <summary>
        /// Constructor
        /// </summary>
        public Sesion_Users()
        {
            // Se define el constructor por defecto
        }

        /// <summary>
        /// Retornar los Mensajes de Error
        /// </summary>
        /// <returns></returns>
        public String getMessages() {
            return messages;
        }

        /// <summary>
        /// Descripción : Método para registrar auditoria de ingreso al sistema xplora
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 17/11/2010
        /// </summary>
        /// <param name="sname_user"></param>
        /// <param name="iCompany_id"></param>        
        /// <param name="tDateby"></param>
        /// <returns></returns>
        public ESesion_Users Registrar_Auditoria(
            string sname_user, 
            int iCompany_id, 
            string sMachine, 
            DateTime tDateby)
        {
            DSesion_Users odrSesion_Users = new DSesion_Users();
            ESesion_Users oeSesion_Users = new ESesion_Users();

            try{
                oeSesion_Users =
                    odrSesion_Users.Registrar_Auditoria(sname_user, iCompany_id, sMachine, tDateby);
                if(!odrSesion_Users.getMessages().Equals("")){
                    messages = odrSesion_Users.getMessages();
                }
            }
            catch (Exception ex) {
                messages = ex.Message.ToString();
            }
            
            return oeSesion_Users;
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
            DSesion_Users odrSesion_Users = new DSesion_Users();
            ESesion_Users oeSesion_Users = odrSesion_Users.Registrar_Auditoria_Download(sname_user, iCompany_id, scod_Channel, iReport_id, sMachine, sNameFile, tDateby, sHora);

            odrSesion_Users = null;
            return oeSesion_Users;
        }


        /// <summary>
        /// Descripción : Método para validar duplicado antes de registrar auditoria de ingreso al sistema xplora al modulo cliente e intentar descargar un informe
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
            DSesion_Users odrSesion_Users = new DSesion_Users();
            DataTable dtDuplicado = odrSesion_Users.Duplicado_Auditoria_Download(sname_user, iCompany_id, scod_Channel, iReport_id, sMachine, sNameFile, sHora);

            odrSesion_Users = null;
            return dtDuplicado;
        }


    }
}
