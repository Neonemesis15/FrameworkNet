using System;

namespace Lucky.Entity.Common.Application.Control
{
    /// <summary>
    /// Esta clase es utilizada para dar información sobre la cuenta a la cual 
    /// le llegarán los errores de la aplicación.
    /// </summary>
    public class EMensajeriaError
    {
        public EMensajeriaError()
        {

        }
        private string lMailServer;
        private string lMailFrom;
        private string lMailTo;
        private string lText;



        public string Text {

            get {

                return this.lText;
            
            
            }
            set {

                this.lText = value;
            
            }
        
        
        
        }
            
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
    }
}