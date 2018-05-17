using System;
using System.Data;
using System.Configuration;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DEnviomail
    {
        /// <summary>
        /// Clase: DEnviomail
        /// CreateBy: Ing. Carlos Alberto Hernández Rincón
        /// CreateDate:12/05/2009
        /// Description: Define losmetodos para envio de email en SIGE
        /// Requerimiento No:
        /// </summary>
        private Conexion oConn;
        public DEnviomail()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        public EEnviomail Envio_emails(string sCountry, string stypemail) {

            Conexion oCoon = new Conexion();
            DataSet ds = oConn.ejecutarDataSet("UP_WEB_GEN_OBTENER_MENSAJERIA", sCountry,stypemail);
            oConn = null;
            if (ds.Tables[0] != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
               

            EEnviomail oeenvio = new EEnviomail();
            oeenvio.MailServer = ds.Tables[0].Rows[0]["OriEmaSrv"].ToString().Trim();
            oeenvio.MailFrom = ds.Tables[0].Rows[0]["OriEmaCta"].ToString().Trim();
            oeenvio.MailTo = ds.Tables[0].Rows[0]["EmaDtn"].ToString().Trim();
            oeenvio.Subject = ds.Tables[0].Rows[0]["EmaSbj"].ToString().Trim();
            oeenvio.Body= ds.Tables[0].Rows[0]["EmaTxt"].ToString().Trim();
            return oeenvio;
           }
           else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        
         
    }
}
