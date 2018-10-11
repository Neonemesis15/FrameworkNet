using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Lucky.Data
{
    /// <summary>
    /// Clase Utilitaria para Conectarse a una Base de Datos Sql Server
    /// y retornar Listas (Para hacer la interconexión con Servicios Rest)
    /// Developed by: 
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Create Class.
    /// </summary>
    internal class SqlServerDatabaseHelper
    {
        public delegate T RowMapper<T>(SqlDataReader dataReader) where T : class;
 
        /// <summary>
        /// Abre una Conexión a la Base de Datos.
        /// </summary>
        /// <param name="person_id"> Identificador de Persona </param>
        /// <returns>SqlConnection</returns> Abre una Conexión a la Base de Datos
        private static SqlConnection OpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexBD"].ConnectionString;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Cierra una Conexión a la Base de Datos.
        /// </summary>
        /// <param name="SqlConnection"> Cadena Connection que desea cerrar </param>
        /// <returns>void</returns> Cierra una Cadena Conexión.
        private static void CloseConnection(SqlConnection connection)
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        /// <summary>
        /// Cierra la llamada a un Procedimiento Almacenado.
        /// </summary>
        /// <param name="SqlCommand"> Procedimiento Almacenado </param>
        /// <returns>void</returns>
        private static void CloseCommand(SqlCommand command)
        {
            if (command != null)
            {
                command.Dispose();
            }
        }
        /// <summary>
        /// Cierra la llamada a un SqlDataReader.
        /// </summary>
        /// <param name="SqlDataReader"> Objeto SqlDataReader </param>
        /// <returns>void</returns> 
        private static void CloseDataReader(SqlDataReader dataReader)
        {
            if (dataReader != null)
            {
                dataReader.Close();
                dataReader.Dispose();
            }
        }
        /// <summary>
        /// Inicia la llamada a un PrepareCommand (Procedimiento Almacenado).
        /// </summary>
        /// <param name="commandText"> Nombre del Procedimiento Almacenado </param>
        /// <param name="commandText"> Nombre del Procedimiento Almacenado </param>
        /// <returns>void</returns> 
        private static SqlCommand PrepareCommand(string commandText, 
            List<SqlParameter> parameters, 
            SqlConnection connection)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = commandText;
            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command;
        }

        public static List<T> ExecuteToList<T>(string commandText, RowMapper<T> rowMapper) where T : class
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            return ExecuteToList<T>(commandText, rowMapper, parameters);
        }

        public static List<T> ExecuteToList<T>(string commandText, RowMapper<T> rowMapper, SqlParameter parameter) where T : class
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(parameter);
            return ExecuteToList<T>(commandText, rowMapper, parameters);
        }

        public static T ExecuteToEntity<T>(string commandText, RowMapper<T> rowMapper, SqlParameter parameter) where T : class
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(parameter);
            return ExecuteToEntity<T>(commandText, rowMapper, parameters);
        }

        public static T ExecuteToEntity<T>(string commandText, RowMapper<T> rowMapper, List<SqlParameter> parameters) where T : class
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader dataReader = null;

            T entity = null;
            try
            {
                connection = OpenConnection();
                command = PrepareCommand(commandText, parameters, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    entity = rowMapper(dataReader);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseDataReader(dataReader);
                CloseCommand(command);
                CloseConnection(connection);
            }

            return entity;
        }

        public static List<T> ExecuteToList<T>(string commandText, RowMapper<T> rowMapper, List<SqlParameter> parameters) where T : class
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader dataReader = null;

            List<T> listEntity = new List<T>();
            try
            {
                connection = OpenConnection();
                command = PrepareCommand(commandText, parameters, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    T entity = rowMapper(dataReader);
                    listEntity.Add(entity);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseDataReader(dataReader);
                CloseCommand(command);
                CloseConnection(connection);
            }

            return listEntity;
        }

        public static void Execute(string commandText, SqlParameter parameter)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(parameter);

            Execute(commandText, parameters);
        }

        public static void Execute(string commandText, List<SqlParameter> parameters)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                connection = OpenConnection();
                command = PrepareCommand(commandText, parameters, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseCommand(command);
                CloseConnection(connection);
            }
        }

        public static void Execute(string commandText, SqlParameter parameter, string parameterOutput, ref object parameterOutputValue)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(parameter);

            Execute(commandText, parameter, parameterOutput, ref parameterOutputValue);
        }

        public static void Execute(string commandText, List<SqlParameter> parameters, string parameterOutput, ref object parameterOutputValue)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                connection = OpenConnection();
                command = PrepareCommand(commandText, parameters, connection);
                command.ExecuteNonQuery();
                parameterOutputValue = command.Parameters[parameterOutput].Value;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseCommand(command);
                CloseConnection(connection);
            }
        }
    }
}
