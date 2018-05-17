using System;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EEnviomail
    /// CreateBy: Ing. Carlos Alberto Hernández Rincón
    /// DateBy: 12/05/2009
    /// Description: Se usa para definir atributos de la clase EnvioEmail
    /// Requerimiento:
    /// </summary>
    public class EEnviomail
    {
        public EEnviomail()
        {

        }
        private string lMailServer;
        private string lMailFrom;
        private string lMailTo;
        private string lSubject;
        private String  lBody;
        public string MailServer
        {
            get
            {
                return this.lMailServer;
            }
            set
            {
                this.lMailServer = value;
            }
        }
        public string MailFrom
        {
            get
            {
                return this.lMailFrom;
            }
            set
            {
                this.lMailFrom = value;
            }
        }
        public string MailTo
        {
            get
            {
                return this.lMailTo;
            }
            set
            {
                this.lMailTo = value;
            }
        }

        public string Subject {
            get { return this.lSubject; }
            set { this.lSubject = value; }
        
        
        
        
        }

        public String Body {

            get { return this.lBody; }
            set { this.lBody = value; }
        
        
        
        }
    }
}