using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;
using Lucky.Business.Common.Exceptions;
using log4net;

namespace Lucky.Business.Common.JavaMovil
{
    public class UsuarioBLL
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UsuarioBLL));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly DUsuario dusuario = new DUsuario();

        public EUsuario Login(string usuario, string password)
        {
            Lucky.Entity.Common.Application.JavaMovil.EUsuario eusuario = null;
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    eusuario = dusuario.Login(usuario, password);
                    tx.Complete();
                }
                if (eusuario == null)
                {
                    throw new NegocioAmbienteException();
                }
            }
            catch (Exception ex)
            {
                log.Error("[UsuarioBLL] [LoginRechazado] :", ex);
                throw new NegocioAmbienteException();
            }

            return eusuario;
        }

        public EUsuarioAuditoria LoginAuditoria(string usuario, string password)
        {
            Lucky.Entity.Common.Application.JavaMovil.EUsuarioAuditoria eusuario = null;
            try
            {
                using (System.Transactions.TransactionScope tx = new System.Transactions.TransactionScope())
                {
                    eusuario = dusuario.LoginAuditoria(usuario, password);
                    tx.Complete();
                }
                if (eusuario == null)
                {
                    throw new NegocioAmbienteException();
                }
            }
            catch (Exception ex)
            {
                log.Error("[UsuarioBLL] [LoginAuditoriaRechazado] :", ex);
                throw new NegocioAmbienteException();
            }

            return eusuario;
        }
    }
}
