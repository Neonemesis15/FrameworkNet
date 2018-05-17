using System;
using System.Data;
using System.Configuration;
using Lucky.Entity.Common.Application.Control;

namespace Lucky.Data.Common.Application.Control
{
    /// <summary>
    /// CreateBy:Ing.
    /// Clase de datos encargada de obtener información necesaria para la mensajería de errores en una aplicación.
    /// </summary>
    public class DMensajeriaError
    {
        public DMensajeriaError()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        /// <summary>
        /// Permite obtener la dirección IP del servidor relay de e-mails 
        /// además de las cuentas From y To por aplicación.
        /// </summary>
        
    
        /// <returns></returns>
        public EMensajeriaError obtenerPK(String sCountry)
        {
            //String sUser = ConfigurationManager.AppSettings["USERERROR"].ToString();
            //String sPswd = ConfigurationManager.AppSettings["PSWDERROR"].ToString();
            Conexion oConn = new Conexion();
            DataSet ds = oConn.ejecutarDataSet("UP_WEB_GEN_OBTENER_MENSAJERIA_ERROR", sCountry);
            //oConn.cerrar();
            oConn = null;
            if (ds.Tables[0] != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    EMensajeriaError oeMensajeriaError = new EMensajeriaError();
                    oeMensajeriaError.MailServer = ds.Tables[0].Rows[0]["OriEmaSrv"].ToString().Trim();
                    oeMensajeriaError.MailFrom = ds.Tables[0].Rows[0]["OriEmaCta"].ToString().Trim();
                    oeMensajeriaError.MailTo = ds.Tables[0].Rows[0]["OriEmaCta"].ToString().Trim();
                    oeMensajeriaError.Text= ds.Tables[0].Rows[0]["EmaTxt"].ToString().Trim();
                    
                    return oeMensajeriaError;
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