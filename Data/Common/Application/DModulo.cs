using System;
using System.Collections.Generic;

using System.Text;

namespace Lucky.Data.Common.Application
{
    public class DModulo
    {
        private Conexion oConn;
        public DModulo()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
    }
}
