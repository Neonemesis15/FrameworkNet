using System;
using System.Configuration;

namespace Lucky.CFG.Messenger
{
    /// <summary>
    /// Clase  para envío de e-mails.
    /// 
    /// Creada por: Ing. Carlos Alberto Hernadnez Rincon
    /// </summary>
    public class Mails
    {
        public Mails() { }
        // Fields
        private System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
        private System.Net.Mail.SmtpClient mailServer = new System.Net.Mail.SmtpClient();
        
        
   
       
        private string lFrom;
        private string lTo;
        private string lCC;
        private string lBCC;
        private string lSubject;
        private string lBody;
        private string lBodyFormat;
        private string lServer;
        private string lUser;
        private string lPassword;
        private int lPuerto;
        private bool lCredenciales;
        private bool lMeCifrado; //Metodo de Crifrado Agregado Ing. CarlosH 29/11/2011
        private System.Net.ICredentials lDatosUsuario;
        private string lCodigoModulo;
        private string lDataWindowNombre;
        private string lDataWindowArgumentos;
        private string lAdjunto;




        /// <summary>
        /// Se define esta Propiedad para definir la Autenticación de Correo Ing. Carlos Hernandez. R. 30/11/2011
        /// </summary>
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


       


        public string From
        {
            get
            {
                return this.lFrom;
            }
            set
            {
                this.mailMessage.From = new System.Net.Mail.MailAddress(value);
                this.lFrom = value;
            }
        }
        public string To
        {
            get
            {
                return this.lTo;
            }
            set
            {
                char[] cChars = { ';', ',' };
                string[] sArray = value.Split(cChars);
                for (int i = 0; i < sArray.Length; i++)
                    this.mailMessage.To.Add(sArray[i].ToString().Trim());
                this.lTo = value;
            }
        }
        public string CC
        {
            get
            {
                return this.lCC;
            }
            set
            {
                char[] cChars = { ';', ',' };
                string[] sArray = value.Split(cChars);
                for (int i = 0; i < sArray.Length; i++)
                    this.mailMessage.CC.Add(sArray[i].ToString().Trim());
                this.lCC = value;
            }
        }
        public string BCC
        {
            get
            {
                return this.lBCC;
            }
            set
            {
                char[] cChars = { ';', ',' };
                string[] sArray = value.Split(cChars);
                for (int i = 0; i < sArray.Length; i++)
                    this.mailMessage.Bcc.Add(sArray[i].ToString().Trim());
                this.lBCC = value;
            }
        }
        public string Subject
        {
            get
            {
                return this.lSubject;
            }
            set
            {
                this.mailMessage.Subject = value;
                this.lSubject = value;
            }
        }
        public string Body
        {
            get
            {
                return this.lBody;
            }
            set
            {
                this.mailMessage.Body = value;
                this.lBody = value;
            }
        }
        public string BodyFormat
        {
            get
            {
                return this.lBodyFormat;
            }
            set
            {
                string text1 = value.ToUpper();
                if (text1 == "HTML")
                {
                    this.mailMessage.IsBodyHtml = true;
                }
                else
                {
                    this.mailMessage.IsBodyHtml = false;
                }
                this.lBodyFormat = value;
            }
        }

        public string User
        {
        
         get{ return this.User;  }
        
         set{
         
             this.lUser=value;
         
         }
        
        
        }


          public string Password
        {
        
         get{ return this.Password;  }
        
         set{
         
             this.lPassword=value;
         
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

            set {

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
        public bool  MCifrado
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

       



        public string CodigoModulo
        {
            get
            {
                return this.lCodigoModulo;
            }
            set
            {
                this.lCodigoModulo = value;
            }
        }
        public string DataWindowNombre
        {
            get
            {
                return this.lDataWindowNombre;
            }
            set
            {
                this.lDataWindowNombre = value;
            }
        }
        public string DataWindowArgumentos
        {
            get
            {
                return this.lDataWindowArgumentos;
            }
            set
            {
                this.lDataWindowArgumentos = value;
            }
        }

       

        public string Adjunto
        {
            get
            {
                return this.lAdjunto;
            }
            set
            {
                this.lAdjunto = value;
            }
        }
        public void send()
        {
         
            mailServer.Send(mailMessage);
        }
        public void sendEMA(string sCountry)
        {
            Lucky.Data.Common.Application.Messenger.DMail dMail = new Lucky.Data.Common.Application.Messenger.DMail();
            dMail.New(sCountry, lFrom, lTo, lCC, lSubject,
                lBody, lDataWindowNombre, lDataWindowArgumentos, Adjunto);
            dMail = null;
        }
        /// <summary>
        /// //Define el metodo para envia r email solicitando la clave
        /// </summary>
        
        public void sendEmaClave( string sCountry, string sUsuario, string splabraR, string sEmail) {

            Lucky.Data.Common.Application.Messenger.DMail dMailAdmon = new Lucky.Data.Common.Application.Messenger.DMail();

        
        
        
        }
    }
}