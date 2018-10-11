using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data.SqlClient;

namespace Lucky.Data.Common.JavaMovil.Impl
{
    /// <summary>
    /// Implementación de Acceso a Datos para Estado.
    /// Developed by: 
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Create Class.
    /// </summary>
    public class DaoEstadoImpl : DaoEstado
    {
        // Mensajes para retornar Errores
        private String message;

        // Listado del Objeto a retornar
        private List<E_Estado> list;

        /// <summary>
        /// Implementación de Acceso a Datos para Estado.
        /// </summary>
        public DaoEstadoImpl() { 
            /// Sin Datos
        }

        /// <summary>
        /// Retorna el maestro de Estados para la App Mobile (Sincronización del AppMobile).
        /// </summary>
        /// <param name=""> Ninguno </param>
        /// <returns>Lista de Estados</returns>  Retorna la Lista de Estados.
        public List<E_Estado> estadoSinc()
        {
            // Crea Object Mapper
            SqlServerDatabaseHelper.RowMapper<E_Estado> estadoMapper = (delegate(SqlDataReader reader)
            {
                E_Estado objEstadoEN = new E_Estado();
                objEstadoEN.setCodigo(ParserDA.StringDB(reader["EST_Id"]));
                objEstadoEN.setDescripcion(ParserDA.StringDB(reader["EST_Nombre"]));
                return objEstadoEN;
            });

            try{
                list = SqlServerDatabaseHelper.ExecuteToList<E_Estado>("Sp_ges_cam_obtener_estado", estadoMapper);
                // Valida si devuelve registros
                if (list.Equals(null)) {
                    message = "¡No hay Estados para sincronizar!";
                }
            }catch(SqlException e){
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    message += "Index #" + i + "\n" +
                        "Error: " + e.Errors[i].ToString() + "\n";
                }
            }
            return list;
        }

        /// <summary>
        /// Retorna los mensaje de Error Controlados.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public string getMessage()
        {
            return message;
        }
    }
}
