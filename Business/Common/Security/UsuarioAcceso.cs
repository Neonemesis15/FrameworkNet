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
    /// Permite manipular los Accesos a los diferentes sistemas 
    /// y usuarios.
    /// </summary>
    public class UsuarioAcceso
    {
        // Accediendo a la Capa de Acceso a Datos
        DUsuarioAcceso odUsuarioAcceso = new DUsuarioAcceso();
        // Variable para almacenar los Errores
        String messages = "";
        /// <summary>
        /// Retorna vacio si no hay errores, en caso de tener errores
        /// se debe mostrar.
        /// </summary>
        /// <returns></returns>
        public String getMessages(){
        return messages;}
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
            EUsuarioAcceso oeUsuarioAcceso = new EUsuarioAcceso();
            try{
                oeUsuarioAcceso = 
                    odUsuarioAcceso.UsuarioAcceso(sUser, sPassw);
            }
            catch (Exception ex) {
                messages = "Ocurrio un Error: " + ex.Message.ToString();
            }
            return oeUsuarioAcceso;
        }
       
    }
}