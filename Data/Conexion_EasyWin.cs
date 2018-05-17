﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace Lucky.Data
{
    public class Conexion_EasyWin
    {

        /// <summary>
        /// Clase: Conexion_EasyWin
        /// CreateBy: Ing.Carlos Alberto Hernández
        /// DateBy: 26/05/2009
        ///esta clase define los métodos para conectar
        //con la base de datos EasyWin con el fin de suplir el Reqeurimiento No: tanto en modo conectado
        //como en desconectado
        /// </summary>

        String oSqlConnIN;
        private SqlTransaction oSqlTransaction = null;
        public Conexion_EasyWin(){
     
     //la cadena de conexión de registra en el 
        //archivo Web.config

         ConnectionStringSettings settingconectionEasy;
         settingconectionEasy= ConfigurationManager.ConnectionStrings["ConectaDBEasywin"];
         oSqlConnIN = settingconectionEasy.ConnectionString;
      
     
  }





        public SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection(oSqlConnIN);
            try
            {
                cn.Open();
                return cn;
            }
            catch
            {
                return null;
            }
        }
        public SqlDataAdapter getAdapter(String s_Sql)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter(s_Sql, oSqlConnIN);
                return adp;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Funcion que devuelve el tipo de dato SqlDbType 
        /// proveniente de un parametro de stored procedure
        /// </summary>
        /// <param name="sNombreTipo">Nombre del Tipo de dato</param>
        /// <returns>Devuelve el tipo de dato SqlDbType</returns>
        private SqlDbType f_obtenerSQLType(String sNombreTipo)
        {
            SqlDbType tTipo;

            switch (sNombreTipo)
            {
                case "bit":
                    tTipo = SqlDbType.Bit;
                    break;

                case "char":
                    tTipo = SqlDbType.Char;
                    break;

                case "varchar":
                    tTipo = SqlDbType.VarChar;
                    break;

                case "decimal":
                    tTipo = SqlDbType.Decimal;
                    break;

                case "integer":
                case "int":
                    tTipo = SqlDbType.Int;
                    break;

                case "smallint":
                    tTipo = SqlDbType.SmallInt;
                    break;

                case "datetime":
                    tTipo = SqlDbType.DateTime;
                    break;

                case "smalldatetime":
                    tTipo = SqlDbType.SmallDateTime;
                    break;

                case "nvarchar":
                    tTipo = SqlDbType.NVarChar;
                    break;

                case "image":
                    tTipo = SqlDbType.Image;
                    break;

                case "xml":
                    tTipo = SqlDbType.Xml;
                    break;

                case "text":
                    tTipo = SqlDbType.Text;
                    break;

                case "ntext":
                    tTipo = SqlDbType.NText;
                    break;

                default:
                    throw (new Exception("Tipo de dato SQL no soportado:" + sNombreTipo));
            }

            return tTipo;
        }


        /// <summary>
        /// Obtiene los parametros de los Store Procedure
        /// utilizando el sp del sistema sp_procedure_params_rowset
        /// </summary>
        private DataSet obtenerParametros(string sProcedure)
        {

            SqlParameter[] arParms = { new SqlParameter("@procedure_name", SqlDbType.NChar, 256),
                                      new SqlParameter("@group_number", SqlDbType.Int, 4),
                                      new SqlParameter("@procedure_schema", SqlDbType.NChar, 256),
                                      new SqlParameter("@parameter_name", SqlDbType.NChar, 256) };

            arParms[0].Value = sProcedure;
            arParms[1].Value = DBNull.Value;
            arParms[2].Value = DBNull.Value;
            arParms[3].Value = DBNull.Value;

            DataSet ds;

            if (oSqlTransaction != null)
            {
                ds = SqlHelper.ExecuteDataset
                    (
                    oSqlTransaction,
                    CommandType.StoredProcedure,
                    "sp_procedure_params_rowset",
                    arParms
                    );
            }
            else
            {
                ds = SqlHelper.ExecuteDataset
                    (
                    oSqlConnIN,
                    CommandType.StoredProcedure,
                    "sp_procedure_params_rowset",
                    arParms
                    );
            }

            if (ds.Tables[0].Rows.Count <= 0)
                throw new Exception("El store procedure " + sProcedure + " no existe o no tiene permisos para ejecutarlo.");
            else
                return ds;
        }
        /// <summary>
        /// Ejecuta un SQL Query del tipo Select
        /// </summary>
        /// <param name="sQuery">SQL Query</param>
        /// <returns>DataSet con el resultado obtenido del Query</returns>
        public DataSet ejecutarQuery(String sQuery)
        {
            DataSet ds = null;

            if (oSqlTransaction != null)
            {
                ds = SqlHelper.ExecuteDataset
                    (
                    oSqlTransaction,
                    CommandType.Text,
                    sQuery
                    );
            }
            else
            {
                ds = SqlHelper.ExecuteDataset
                    (
                    this.oSqlConnIN,
                    CommandType.Text,
                    sQuery
                    );
            }
            return ds;
        }
        /// <summary>
        /// Ejecuta un SQL Query que no devuelve resultado
        /// </summary>
        /// <param name="sQuery">SQL Query</param>
        public void ejecutarQuerySinRetorno(String sQuery)
        {
            if (oSqlTransaction != null)
            {
                SqlHelper.ExecuteDataset
                    (
                    oSqlTransaction,
                    CommandType.Text,
                    sQuery
                    );
            }
            else
            {
                SqlHelper.ExecuteDataset
                    (
                    this.oSqlConnIN,
                    CommandType.Text,
                    sQuery
                    );
            }
        }
        /// <summary>
        /// Ejecuta un procedure y almacena el resultado en un DataReader
        /// </summary>
        /// <param name="sProcedure">Nombre del Stored procedure</param>
        /// <param name="valores">Arreglo con los parametros del stored</param>
        /// <returns>DataReader con el resultado de la Consulta</returns>
        public SqlDataReader ejecutarDataReader(String sProcedure, params object[] valores)
        {
            return SqlHelper.ExecuteReader(this.oSqlConnIN, sProcedure, valores);
        }

        /// <summary>
        /// Ejecuta un procedure y almacena el resultado en un DataSet
        /// </summary>
        /// <param name="sProcedure">Nombre del Stored procedure</param>
        /// <param name="valores">Lista de parametros del stored</param>
        /// <returns>DataSet con el resultado de la Consulta</returns>
        public DataSet ejecutarDataSet(String sProcedure, params object[] valores)
        {
            SqlParameter[] arParms = new SqlParameter[valores.Length];

            //DataSet ds=ejecutarQuery("SELECT * FROM sysobjects WHERE xtype = 'P' AND name = '"+ sProcedure+"'");
            //if (ds.Tables[0].Rows.Count == 0)
            //    throw new Exception("El store procedure " + sProcedure + " no existe o no tiene permisos para ejecutarlo.");

            //ds=ejecutarQuery("sp_help " + sProcedure);

            //Obtiene los parámetros del procecimiento
            DataSet ds = obtenerParametros(sProcedure);

            if (ds.Tables.Count == 0)
                return null;
            else if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0]; //Estructura del Stored
                //if (dt.Rows.Count != valores.Length)
                //{
                //    return null;
                //}
                Int32 i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    //Omite el parámetro de retorno del procedimiento
                    if (!dr["Parameter_name"].Equals("@RETURN_VALUE"))
                    {
                        arParms[i] = new SqlParameter(dr["Parameter_name"].ToString(), f_obtenerSQLType(dr["Type_name"].ToString()));
                        arParms[i].Value = valores[i];
                        i++;
                    }
                }
                if (i != valores.Length)
                    throw new Exception("La cantidad de parámetros ingresados no coincide con las del procedimiento.");
            }
            //Se verifica si existe una Transaccion de BD activa
            ds = null;
            if (oSqlTransaction != null)
            {
                ds = SqlHelper.ExecuteDataset
                    (
                    oSqlTransaction,
                    CommandType.StoredProcedure,
                    sProcedure,
                    arParms
                    );
            }
            else
            {
                ds = SqlHelper.ExecuteDataset
                    (
                    oSqlConnIN,
                    CommandType.StoredProcedure,
                    sProcedure,
                    arParms
                    );
            }

            return ds;
        }

        /// <summary>
        /// Ejecuta un procedure y almacena el resultado en un DataTable
        /// </summary>
        /// <param name="sProcedure">Nombre del Stored procedure</param>
        /// <param name="valores">Lista de parametros del stored</param>
        /// <returns>DataSet con el resultado de la Consulta</returns>
        public DataTable ejecutarDataTable(String sProcedure, params object[] valores)
        {
            SqlParameter[] arParms = new SqlParameter[valores.Length];

            //DataSet ds = ejecutarQuery("SELECT * FROM sysobjects WHERE xtype = 'P' AND name = '" + sProcedure + "'");
            //if (ds.Tables[0].Rows.Count == 0)
            //    throw new Exception("El store procedure " + sProcedure + " no existe o no tiene permisos para ejecutarlo.");

            DataTable dt = null;

            //ds = ejecutarQuery("sp_help " + sProcedure);

            //Obtiene los parámetros del procecimiento
            DataSet ds = obtenerParametros(sProcedure);

            if (ds.Tables.Count == 0)
                return null;
            else if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0]; //Estructura del Stored
                //if (dt.Rows.Count != valores.Length)
                //{
                //    return null;
                //}
                Int32 i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    //Omite el parámetro de retorno del procedimiento
                    if (!dr["Parameter_name"].Equals("@RETURN_VALUE"))
                    {
                        arParms[i] = new SqlParameter(dr["Parameter_name"].ToString(), f_obtenerSQLType(dr["Type_name"].ToString()));
                        arParms[i].Value = valores[i];
                        i++;
                    }
                }
                if (i != valores.Length)
                    throw new Exception("La cantidad de parámetros ingresados no coincide con las del procedimiento.");
            }
            //Se verifica si existe una Transaccion de BD activa
            ds = null;
            dt = null;

            DataSet dsResult;
            if (oSqlTransaction != null)
                dsResult = SqlHelper.ExecuteDataset(oSqlTransaction, CommandType.StoredProcedure, sProcedure, arParms);
            else
                dsResult = SqlHelper.ExecuteDataset(oSqlConnIN, CommandType.StoredProcedure, sProcedure, arParms);

            if (oSqlTransaction != null) oSqlTransaction.Dispose();
            if (dsResult.Tables.Count > 0) dt = dsResult.Tables[0]; else dt = null;
            dsResult = null;
            if (dt != null) return dt.Copy(); else return null;
        }

        /// <summary>
        /// Ejecuta un procedure y almacena el resultado en una variable.
        /// El Resultado debe ser un numero entero (escalar)
        /// </summary>
        /// <param name="sProcedure">Nombre del Stored procedure</param>
        /// <param name="valores">Lista de Parametros del stored</param>
        /// <returns>String con el valor devuelto por el stored</returns>
        public String ejecutarEscalar(String sProcedure, params object[] valores)
        {
            SqlParameter[] arParms = new SqlParameter[valores.Length];

            //DataSet ds=ejecutarQuery("SELECT * FROM sysobjects WHERE xtype = 'P' AND name = '"+ sProcedure+"'");
            //if (ds.Tables[0].Rows.Count == 0)
            //    throw new Exception("El store procedure " + sProcedure + " no existe o no tiene permisos para ejecutarlo.");

            //ds=ejecutarQuery("sp_help " + sProcedure);

            //Obtiene los parámetros del procecimiento
            DataSet ds = obtenerParametros(sProcedure);

            if (ds.Tables.Count == 0)
                return null;
            else if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0]; //Estructura del Stored
                //if(dt.Rows.Count != valores.Length)
                //{	
                //    return null;
                //}
                Int32 i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    //Omite el parámetro de retorno del procedimiento
                    if (!dr["Parameter_name"].Equals("@RETURN_VALUE"))
                    {
                        arParms[i] = new SqlParameter(dr["Parameter_name"].ToString(), f_obtenerSQLType(dr["Type_name"].ToString()));
                        arParms[i].Value = valores[i];
                        i++;
                    }
                }
                if (i != valores.Length)
                    throw new Exception("La cantidad de parámetros ingresados no coincide con las del procedimiento.");
            }

            //Se verifica si existe una Transaccion de BD activa
            String sValor;
            if (oSqlTransaction != null)
            {
                sValor = SqlHelper.ExecuteScalar
                    (
                    oSqlTransaction,
                    CommandType.StoredProcedure,
                    sProcedure,
                    arParms
                    ).ToString();
            }
            else
            {
                sValor = SqlHelper.ExecuteScalar
                    (
                    this.oSqlConnIN,
                    CommandType.StoredProcedure,
                    sProcedure,
                    arParms
                    ).ToString();
            }
            return sValor;
        }

        /// <summary>
        /// Ejecuta un Procedure que no devuelve ningun resultado
        /// </summary>
        /// <param name="sProcedure">Nombre del Stored procedure</param>
        /// <param name="valores">Lista de Parametros del stored</param>
        public void ejecutarSinRetorno(String sProcedure, params object[] valores)
        {
            SqlParameter[] arParms = new SqlParameter[valores.Length];

            //DataSet ds=ejecutarQuery("SELECT * FROM sysobjects WHERE xtype = 'P' AND name = '"+ sProcedure+"'");
            //if (ds.Tables[0].Rows.Count == 0)
            //    throw new Exception("El store procedure " + sProcedure + " no existe o no tiene permisos para ejecutarlo.");

            //ds=ejecutarQuery("sp_help " + sProcedure);

            //Obtiene los parámetros del procecimiento
            DataSet ds = obtenerParametros(sProcedure);
            if (ds.Tables.Count == 0)
                return;
            else if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0]; //Estructura del Stored
                //if(dt.Rows.Count != valores.Length)
                //{	
                //    return;
                //}
                Int32 i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    //Omite el parámetro de retorno del procedimiento
                    if (!dr["Parameter_name"].Equals("@RETURN_VALUE"))
                    {
                        arParms[i] = new SqlParameter(dr["Parameter_name"].ToString(), f_obtenerSQLType(dr["Type_name"].ToString()));
                        arParms[i].Value = valores[i];
                        i++;
                    }
                }
                if (i != valores.Length)
                    throw new Exception("La cantidad de parámetros ingresados no coincide con las del procedimiento.");
            }

            //Se verifica si existe una Transaccion de BD activa
            if (oSqlTransaction != null)
            {
                SqlHelper.ExecuteNonQuery
                    (
                    this.oSqlTransaction,
                    CommandType.StoredProcedure,
                    sProcedure,
                    arParms
                    );
            }
            else
            {
                SqlHelper.ExecuteNonQuery
                    (
                    this.oSqlConnIN,
                    CommandType.StoredProcedure,
                    sProcedure,
                    arParms
                    );
            }
        }

        /// <summary>
        /// Inicia una Transaccion de Base de Datos
        /// </summary>
        //public void iniciaTrans()
        //{
        //    oSqlConnIN.Open();
        //    oSqlTransaction = oSqlConnIN.BeginTransaction();
        //}

        /// <summary>
        /// Salva de manera Permanente los datos en la BD que hayan sido
        /// ingresados dentro de una Transaccion
        /// </summary>
        public void Commit()
        {
            oSqlTransaction.Commit();

        }

        /// <summary>
        /// Deshace cualquier operacion realizada dentro de una Transaccion
        /// </summary>
        public void Rollback()
        {
            oSqlTransaction.Rollback();

        }
    }
}