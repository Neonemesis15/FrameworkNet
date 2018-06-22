using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.AppMobile;
using Lucky.Entity.Common.AppMobile;

namespace Lucky.Business.Common.AppMobile
{
    public class BlUsuario
    {
        private DaoUsuario daoUsuario;

        public BlUsuario() {
            daoUsuario = new DaoUsuario();
        }

        public List<Usuario> usuarioQry() {
            return daoUsuario.usuarioQry();
        }
    }
}
