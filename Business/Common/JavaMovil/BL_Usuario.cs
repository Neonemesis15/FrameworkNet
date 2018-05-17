using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Business.Common.Exceptions;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;

namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Usuario
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Usuario));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Usuario oD_Usuario = new D_Usuario();

        public E_Usuario Login_Mov(string usuario, string password)
        {
            E_Usuario eusuario = null;
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    eusuario = oD_Usuario.Login_Mov(usuario, password);
                    tx.Complete();
                }
                if (eusuario == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_Usuario] [Login_Mov_Failed] :", ex);
                throw new Exception();
            }

            return eusuario;
        }
    }
}
