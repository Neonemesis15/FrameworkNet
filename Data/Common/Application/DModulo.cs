using System;
using System.Collections.Generic;
using Lucky.Entity.Common.Application;
using System.Text;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Application
{
    public class DModulo
    {
        private readonly Conexion oConn;
        private readonly StringBuilder sql;
        private String message;
        public DModulo()
        {
            UserInterface oUserInterface = new UserInterface();
            oUserInterface = null;
            this.oConn = new Conexion();
            this.sql = new StringBuilder();
        }
        
        /// <summary>
        /// Obtener Listado de Modulos, por Ids
        /// </summary>
        /// <param name="moduloIds"></param>
        /// <returns></returns>
        public List<EModulo> moduloLstGetByIds(List<String> moduloIds) {
            SqlConnection sqlCnn = null;
            SqlCommand sqlCmd = null;
            SqlDataReader sqlReader;
            
            List<EModulo> list = null;
            
            sql.Append("SELECT ")
                .Append("Modulo_id, ")
                .Append("Modulo_Name, ")
                .Append("Modulo_Description, ")
                .Append("Modulo_Status, ")
                .Append("Modulo_CreateBy, ")
                .Append("Modulo_DateBy, ")
                .Append("Modulo_ModiBy, ")
                .Append("Modulo_DateModiBy ")
                .Append("FROM Modulos ")
                .Append("WHERE Modulo_id IN ('")
                .Append(string.Join("','", moduloIds.ToArray()))
                .Append("')");

            System.Diagnostics.Debug.WriteLine(sql.ToString());
            
            try
            {
                using (sqlCnn = oConn.GetConnection()) {
                    //sqlCnn.Open();
                    sqlCmd = new SqlCommand(sql.ToString(), sqlCnn);
                    sqlReader = sqlCmd.ExecuteReader();

                    list = new List<EModulo>();

                    while (sqlReader.Read()) {
                        
                        EModulo reg = new EModulo();
                        reg.Moduloid = sqlReader.GetString(0);
                        reg.ModuloName = sqlReader.GetString(1);
                        reg.ModuloDescription = sqlReader.GetString(2);
                        reg.ModuloStatus = sqlReader.GetBoolean(3);
                        //reg.ModuloCreateBy = sqlReader.GetString(4);
                        //reg.ModuloDateBy = sqlReader.GetString(5);
                        //reg.ModuloModiBy = sqlReader.GetString(6);
                        //reg.ModuloDateModiBy = sqlReader.GetString(7);

                        list.Add(reg);
                    }
                    sqlReader.Close();
                    sqlCmd.Dispose();
                    sqlCnn.Close();
                    
                }
                
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Ocurrio un error: " + ex.Message);
                message = ex.Message.ToString();
                throw ex;
            }

            list.ForEach(i => System.Diagnostics.Debug.WriteLine(i.Moduloid.ToString()));

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Object[]> moduloCmb() {
            SqlConnection sqlCnn = null;
            SqlCommand sqlCmd = null;
            SqlDataReader sqlReader = null;
            List<Object[]> lst = null;
            sql.Append("SELECT ")
                .Append("Modulo_id, ")
                .Append("Modulo_Name ")
                .Append("FROM Modulos");
            try
            {
                using (sqlCnn = oConn.GetConnection()) {
                    sqlCmd = new SqlCommand(sql.ToString(), sqlCnn);
                    sqlReader = sqlCmd.ExecuteReader();
                    lst = new List<Object[]>();
                    while (sqlReader.Read()) {
                        Object[] obj = new Object[2];
                        obj[0] = sqlReader.GetValue(0);
                        obj[1] = sqlReader.GetValue(1);
                        lst.Add(obj);
                    }
                    sqlReader.Close();
                    sqlCmd.Dispose();
                    sqlCnn.Close();
                }
            }
            catch (Exception ex) {
                message = ex.Message.ToString();
                throw ex;
            }
            return lst;
        }
    }
}
