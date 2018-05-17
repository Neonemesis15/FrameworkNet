using System;

namespace Lucky.Data.Common.Application.Messenger
{
    /// <summary>
    /// Descripción breve de Mail.
    /// </summary>
    public class DMail
    {
        private Conexion oConn;
        public DMail()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        public void New(String sCountry, String sFrom, String sTo, String sCc, String sSubject, String sBody, String sEmaDW, String sEmaArg, String sEmaAdj)
        {
            if (sCc == null) sCc = "";
            oConn.ejecutarSinRetorno("UP_WEB_GEN_REG_EMA",
                sCountry, sFrom, sTo, sCc, sSubject,
                sBody, sEmaDW, sEmaArg, sEmaAdj);
        }

       
    }
}