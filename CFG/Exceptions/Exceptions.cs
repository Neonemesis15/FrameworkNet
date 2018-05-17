using System;
using System.Configuration;

using Lucky.Business.Common.Application.Control;
using Lucky.Entity.Common.Application.Control;

namespace Lucky.CFG.Exceptions
{
    /// <summary>
    /// CreateBy: Ing.Carlos Alberto Hernandez Rincon
    /// CrateDate: 30/04/2009
    /// Description:Exceptions es una clase utilizada para poder enviar las Excepciones vía 
    /// e-mail y tomar una médida rápida sobre problemas que le puedan suceder 
    /// a un usuario determinado.
    /// Requerimiento N:
    /// </summary>
    public class Exceptions
    {
        public Exceptions(Exception ex)
        {
            this.mvarSource = ex.Source;
            this.mvarMessage = ex.Message;
            this.mvarStackTrace = ex.StackTrace;
            this.mvarHelpLink = ex.HelpLink;
        }
        private string mvarCountry;
        private string mvarSource;
        private string mvarMessage;
        private string mvarStackTrace;
        private string mvarHelpLink;
        private string lServer;
        private int lPuerto;
        private bool lCredenciales;
        private System.Net.ICredentials lDatosUsuario;
        private bool lMeCifrado; //Metodo de Crifrado Agregado Ing. CarlosH 29/11/2011

        private System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
        private System.Net.Mail.SmtpClient mailServer = new System.Net.Mail.SmtpClient();
        


        public System.Net.ICredentials DatosUsuario
        {
            get
            {
                return this.DatosUsuario;
            }
            set
            {
                string userName = ConfigurationManager.AppSettings["User"];
                string password = ConfigurationManager.AppSettings["Pass"];
                this.mailServer.Credentials = new System.Net.NetworkCredential(userName, password);
                this.lDatosUsuario = value;
            }
        }


        /// <summary>
        /// Porpiedad Credenciales por defecto
        /// </summary>
        public bool Credenciales
        {
            get
            {
                return this.lCredenciales;
            }

            set
            {

                mailServer.UseDefaultCredentials = value;
                this.lCredenciales = value;

            }

        }




        public string Server
        {
            get
            {
                return this.lServer;
            }
            set
            {
                mailServer.Host = value;
                this.lServer = value;
            }
        }

        /// <summary>
        /// Se Agrega el Puerto Ing. CarlosH 29/11/2011
        /// </summary>
        public int Puerto
        {
            get
            {
                return this.lPuerto;
            }
            set
            {

                mailServer.Port = value;
                this.lPuerto = value;
            }
        }



        /// <summary>
        /// Se Agrega Cifrado Ing. CarlosH 29/11/2011
        /// </summary>
        public bool MCifrado
        {
            get
            {
                return this.lMeCifrado;
            }
            set
            {

                mailServer.EnableSsl = value;
                this.lMeCifrado = value;
            }
        }

       

        public string Country
        {
            get
            {
                return this.mvarCountry;
            }
            set
            {
                this.mvarCountry = value;
            }
        }
        public string Source
        {
            get
            {
                return this.mvarSource;
            }
            set
            {
                this.mvarSource = value;
            }
        }
        public string Message
        {
            get
            {
                return this.mvarMessage;
            }
            set
            {
                this.mvarMessage = value;
            }
        }
        public string StackTrace
        {
            get
            {
                return this.mvarStackTrace;
            }
            set
            {
                this.mvarStackTrace = value;
            }
        }
        public string HelpLink
        {
            get
            {
                return this.mvarHelpLink;
            }
            set
            {
                this.mvarHelpLink = value;
            }
        }
        /// <summary>
        /// Envío de error de aplicación
        /// </summary>
        /// <param name="sOriCod">El código de origen</param>
        /// <param name="sModAcc">El código de módulo</param>
        public void errorWebsite(string sCountry)
        {
            MensajeriaError oMensajeriaError = new MensajeriaError();
            EMensajeriaError oeMensajeriaError = oMensajeriaError.obtener(sCountry);
            Messenger.Mails oMail = new Messenger.Mails();
            oMail.Credenciales = true;
            oMail.Server = oeMensajeriaError.MailServer;
            oMail.MCifrado = true;
            oMail.DatosUsuario = new System.Net.NetworkCredential(); ;
            oMail.From = oeMensajeriaError.MailFrom;
            oMail.To = ConfigurationManager.AppSettings["EMailDesarrolladores"];;
            oMail.Puerto = Convert.ToInt32(ConfigurationManager.AppSettings["Puerto"]);
            oMail.Subject = "Error en Desarrollo Xplora";
            oMail.BodyFormat = "HTML";
            oMail.CC = ConfigurationManager.AppSettings["EmailGerenciaIT"];

           
            string[] textArray1 = new string[] { this.mvarCountry, "<br><br>", this.mvarSource + " - " + this.mvarMessage, "<br><br>", this.mvarStackTrace, "<br><br>", this.mvarHelpLink };
            oMail.Body = string.Concat(textArray1);
            oMail.send();
            oMail = null;
            oeMensajeriaError = null;
            oMensajeriaError = null;
        }
    }
}