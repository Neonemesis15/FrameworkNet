using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application.Response
{
    public class LoginResponse
    {
        private EUsuario oEUsuario;
        private String urlPage;

        public EUsuario OEUsuario
        {
            get { return oEUsuario; }
            set { oEUsuario = value; }
        }
        
        public String UrlPage
        {
            get { return urlPage; }
            set { urlPage = value; }
        }
    }
}
