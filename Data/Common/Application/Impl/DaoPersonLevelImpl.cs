using Lucky.Entity.Common.Application;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application.Util;

namespace Lucky.Data.Common.Application.Impl
{
    public class DaoPersonLevelImpl : I_DaoPersonLevel
    {
        private readonly Conexion oConn;
        private readonly StringBuilder sql;
        private string message;

        public DaoPersonLevelImpl() {
            this.oConn = new Conexion();
            this.sql = new StringBuilder();
        }

        public int personLevelDel(string id_Level)
        {
            SqlConnection sqlCnn = null;
            SqlCommand sqlCmd = null;
            int result = -1;
            Util.Tools.Clear(sql);
            sql.Append("DELETE FROM Person_Level ")
                .Append("WHERE ")
                .Append("id_level = @id_level");
            System.Diagnostics.Debug.WriteLine(sql.ToString());

            try
            {
                sqlCnn = oConn.GetConnection();
                sqlCmd = new SqlCommand(sql.ToString(), sqlCnn);
                sqlCmd.Parameters.AddWithValue("@id_Level", id_Level);

                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                throw ex;
            }
            finally
            {
                sqlCmd.Dispose();
                sqlCnn.Close();
            }
            return result;
        }

        public int personLevelIns(E_PersonLevel oPersonLevel)
        {
            SqlConnection sqlCnn = null;
            SqlCommand sqlCmd = null;
            int result = -1;
            Util.Tools.Clear(sql);
            sql.Append("INSERT INTO Person_Level( ")
                .Append("id_Level, ")
                .Append("Level_Description, ")
                .Append("Level_status, ")
                .Append("Level_CreateBy, ")
                .Append("Level_DateBy ")
                .Append(") ")
                .Append("VALUES ( ")
                .Append("@id_Level, ")
                .Append("@Level_Description, ")
                .Append("@Level_status, ")
                .Append("@Level_CreateBy, ")
                .Append("@Level_DateBy ")
                .Append(") ");
            System.Diagnostics.Debug.WriteLine(sql.ToString());

            try {
                sqlCnn = oConn.GetConnection();
                sqlCmd = new SqlCommand(sql.ToString(), sqlCnn);
                sqlCmd.Parameters.AddWithValue("@id_Level", oPersonLevel.getId_Level());
                sqlCmd.Parameters.AddWithValue("@Level_Description", oPersonLevel.getLevel_Description());
                sqlCmd.Parameters.AddWithValue("@Level_status", oPersonLevel.getLevel_Status());
                sqlCmd.Parameters.AddWithValue("@Level_CreateBy", oPersonLevel.getLevel_CreateBy());
                sqlCmd.Parameters.AddWithValue("@Level_DateBy", oPersonLevel.getLevel_DateBy());

                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                throw ex;
            }
            finally {
                sqlCmd.Dispose();
                sqlCnn.Close();
            }
            return result;
        }

        public int personLevelIsDuplicate(E_PersonLevel oPersonLevel)
        {
            SqlConnection sqlCnn = null;
            SqlCommand sqlCmd = null;

            int result = -1;
            Util.Tools.Clear(sql);
            sql.Append("SELECT COUNT(1) ")
                .Append("FROM person_level ")
                .Append("WHERE level_description = @Level_Description ");

            System.Diagnostics.Debug.WriteLine(sql.ToString());

            try
            {
                sqlCnn = oConn.GetConnection();
                sqlCmd = new SqlCommand(sql.ToString(), sqlCnn);
                sqlCmd.Parameters.AddWithValue("@Level_Description", oPersonLevel.getLevel_Description());
                result = (int)sqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                throw ex;
            }
            finally {
                sqlCmd.Dispose();
                sqlCnn.Close();
            }
            return result;
        }
    }
}
