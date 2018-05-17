using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data;
using Lucky.Data.Common.Security;
using Lucky.Entity.Common.Security;
using Lucky.Business.Common.Security;
using Lucky.Business.Common.Application;

namespace Lucky.Business.Common.Security
{
    /// Permite manipular los Accesos a los diferentes sistemas y usuarios.
    /// </summary>
    public class UsuarioAcceso
    {
        /// <summary>
        /// Constructor por defecto. No realiza ninguna accion
        /// </summary>
        public UsuarioAcceso()
        {

        }
        public Lucky.Business.Common.Application.Aplicacion Aplication
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        public Lucky.Business.Common.Application.Aplicacion Usuario
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
        /// Verifica si el usuario cuenta con acceso al sistema SIGE
        /// </summary>
        /// <param name="sUser">Usuario</param>
        /// <param name="sOriCod">Origen</param>
        /// <returns></returns>
        public EUsuarioAcceso obtenerAleatorioxUsuario(string sUser, string sPassw)
        {
            DUsuarioAcceso odUsuarioAcceso = new DUsuarioAcceso();
            EUsuarioAcceso oeUsuarioAcceso = odUsuarioAcceso.UsuarioAcceso(sUser,sPassw);
            odUsuarioAcceso = null;
            return oeUsuarioAcceso;
        }
       
    }
}