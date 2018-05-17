using System;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;
using Lucky.Business.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class Enviomail
    {
        public Enviomail() { 
        
        
        }


         public Lucky.Business.Common.Application.Aplicacion Aplicacion
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// Permite obtener los datos necesarios envio de mensajeria.
        /// </summary>
        
        public EEnviomail Envio_mails(string sCountry, string stypemail)
        {
          DEnviomail odEnviomail= new DEnviomail();
          EEnviomail oeEnviomail= odEnviomail.Envio_emails(sCountry,stypemail);
          odEnviomail=null;
          return oeEnviomail;
       }

            

        
        
        }
        
    }
    

