using System;
using System.Collections.Generic;

using System.Text;

namespace Lucky.Data.Common.Application
{
    public class DTablas
    {
        private Conexion oConn;
        public DTablas()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
    }
}
