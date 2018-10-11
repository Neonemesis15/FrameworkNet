using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    /// <summary>
    /// Interfaz de Acceso a Datos para Estado.
    /// Developed by: 
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Create Class.
    /// </summary>
    public interface DaoEstado
    {
        /// <summary>
        /// Retorna el maestro de Estados para la App Mobile (Sincronización del AppMobile).
        /// </summary>
        /// <param name=""> Ninguno </param>
        /// <returns>List de Estados</returns>
        public List<E_Estado> estadoSinc();

        /// <summary>
        /// Retorna los mensaje de Error Controlados.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public String getMessage();
    }
}
