using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Security.Principal;
using Microsoft.Reporting.WebForms;


namespace CFG.Tools
{
    public class ReportServerNetCredentials : IReportServerCredentials
    {
        /// <summary>
        /// Clase para manejo de Cfredencias RRSS
        /// Creada por: Ing. Carlos Hernandez
        /// Fecha: 08/12/2010
        /// </summary>
        /// <param name="authCookie"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="authority"></param>
        /// <returns></returns>
        public bool GetFormsCredentials(out System.Net.Cookie authCookie, out string userName,
       out string password, out string authority)
        {
            authCookie = null;
            userName = null;
            password = null;
            authority = null;
            return false;
        }
        /// <summary>       
        /// /// Specifies the user to impersonate when connecting to a report server.     
        /// /// </summary>      
        /// /// <value></value>    
        /// /// <returns>A WindowsIdentity object representing the user to impersonate.</returns>     
        public WindowsIdentity ImpersonationUser
        {
            get
            {
                return null;
            }
        }
        /// <summary>       
        /// Returns network credentials to be used for authentication with the report server.        
        /// </summary>        
        /// <value></value>        
        // <returns>A NetworkCredentials object.</returns>    
        public System.Net.ICredentials NetworkCredentials
        {
            get
            {
               
                string userName =ConfigurationManager.AppSettings["ReportUser"];
                string domainName = ConfigurationManager.AppSettings["ReportServerDomain"];
                string password = ConfigurationManager.AppSettings["ReportUserPass"];
                return new System.Net.NetworkCredential(userName, password, domainName);
            }
        }

        /// <summary>
        /// Para Autenticacion Correo Ing. CarlosH 30/11/2011
        /// </summary>
        public System.Net.ICredentials NetworkCredentialsEmail
        {
            get
            {

                string userName = ConfigurationManager.AppSettings["User"];
               
                string password = ConfigurationManager.AppSettings["Pass"];
                return new System.Net.NetworkCredential(userName, password);
            }
        }

    }
}
