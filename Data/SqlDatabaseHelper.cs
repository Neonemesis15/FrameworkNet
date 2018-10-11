using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Lucky.Data
{
    /// <summary>
    /// Conecta con una base de Datos Mysql y 
    /// retorna Listas (Para hacer la interconexión con Servicios Rest)
    /// Developed by:
    /// - Pablo Salas Alvarez (PSA)
    /// Email: 
    /// - pablo.salas.alvarez88@gmail.com
    /// Changes: 
    /// - 2018-06-22 (PSA) Create Class 
    /// Descripcion: 
    /// </summary>
    /// <returns></returns>
    class SqlDatabaseHelper
    {
        public delegate T RowMapper<T>(MySqlDataReader dataReader) where T : class;
        
        private static MySqlConnection OpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConectaDBMysql"].ConnectionString;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        private static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private static void CloseCommand(MySqlCommand command)
        {
            if (command != null)
            {
                command.Dispose();
            }
        }

        private static void CloseDataReader(MySqlDataReader dataReader)
        {
            if (dataReader != null)
            {
                dataReader.Close();
                dataReader.Dispose();
            }
        }

        private static MySqlCommand PrepareCommand(string commandText, List<MySqlParameter> parameters, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = commandText;
            foreach (MySqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command;
        }

        private static MySqlCommand PrepareCommand02(string commandText, List<MySqlParameter> parameters, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = commandText;
            foreach (MySqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command;
        }

        public static List<T> ExecuteToList<T>(string commandText, RowMapper<T> rowMapper) where T : class
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            return ExecuteToList<T>(commandText, rowMapper, parameters);
        }

        public static List<T> ExecuteToList<T>(string commandText, RowMapper<T> rowMapper, MySqlParameter parameter) where T : class
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(parameter);
            return ExecuteToList<T>(commandText, rowMapper, parameters);
        }

        public static T ExecuteToEntity<T>(string commandText, RowMapper<T> rowMapper, MySqlParameter parameter) where T : class
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(parameter);
            return ExecuteToEntity<T>(commandText, rowMapper, parameters);
        }

        public static T ExecuteToEntity<T>(string commandText, RowMapper<T> rowMapper, List<MySqlParameter> parameters) where T : class
        {
            MySqlConnection connection = null;
            MySqlCommand command = null;
            MySqlDataReader dataReader = null;

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
            catch (MySqlException ex)
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

        public static List<T> ExecuteToList<T>(string commandText, RowMapper<T> rowMapper, List<MySqlParameter> parameters) where T : class
        {
            MySqlConnection connection = null;
            MySqlCommand command = null;
            MySqlDataReader dataReader = null;

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
            catch (MySqlException ex)
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

        public static List<T> ExecuteToList02<T>(string commandText, RowMapper<T> rowMapper, List<MySqlParameter> parameters) where T : class
        {
            MySqlConnection connection = null;
            MySqlCommand command = null;
            MySqlDataReader dataReader = null;

            List<T> listEntity = new List<T>();
            try
            {
                connection = OpenConnection();
                command = PrepareCommand02(commandText, parameters, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    T entity = rowMapper(dataReader);
                    listEntity.Add(entity);
                }
            }
            catch (MySqlException ex)
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


        public static void Execute(string commandText, MySqlParameter parameter)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(parameter);

            Execute(commandText, parameters);
        }

        public static void Execute(string commandText, List<MySqlParameter> parameters)
        {
            MySqlConnection connection = null;
            MySqlCommand command = null;

            try
            {
                connection = OpenConnection();
                command = PrepareCommand(commandText, parameters, connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                CloseCommand(command);
                CloseConnection(connection);
            }
        }

        public static void Execute(string commandText, MySqlParameter parameter, string parameterOutput, ref object parameterOutputValue)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(parameter);

            Execute(commandText, parameter, parameterOutput, ref parameterOutputValue);
        }

        public static void Execute(string commandText, List<MySqlParameter> parameters, string parameterOutput, ref object parameterOutputValue)
        {
            MySqlConnection connection = null;
            MySqlCommand command = null;

            try
            {
                connection = OpenConnection();
                command = PrepareCommand(commandText, parameters, connection);
                command.ExecuteNonQuery();
                parameterOutputValue = command.Parameters[parameterOutput].Value;
            }
            catch (MySqlException ex)
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
