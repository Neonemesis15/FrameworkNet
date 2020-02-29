using Lucky.Entity.Common.Application;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lucky.Data.Common.Application.Impl
{
    public class DaoPersonModulosImpl : I_DaoPersonModulos
    {
        private readonly Conexion oConn;
        private readonly StringBuilder sql;
        private string message;

        public DaoPersonModulosImpl() {
            this.oConn = new Conexion();
            this.sql = new StringBuilder();
        }
        public int personModulosIns(E_PersonModulos oPersonModulos)
        {
            SqlConnection sqlCnn = null;
            SqlCommand sqlCmd = null;

            int result = -1;
            sql.Append("INSERT INTO AD_Person_Modulos( ")
                .Append("id_Level, ")
                .Append("Modulo_id, ")
                .Append("Modulo_Name, ")
                .Append("Person_Modulo_Status, ")
                .Append("Person_Modulo_CreateBy, ")
                .Append("Person_Modulo_Dateby ")
                .Append(") ")
                .Append("VALUES( ")
                .Append("@id_Level, ")
                .Append("@Modulo_id, ")
                .Append("@Modulo_Name, ")
                .Append("@Person_Modulo_Status, ")
                .Append("@Person_Modulo_CreateBy, ")
                .Append("@Person_Modulo_Dateby ")
                .Append(") ");
            System.Diagnostics.Debug.WriteLine(sql.ToString());

            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), sqlCnn);
                sqlCmd.Parameters.AddWithValue("@id_Level", oPersonModulos.getIdLevel());
                sqlCmd.Parameters.AddWithValue("@Modulo_id", oPersonModulos.getModuloId());
                sqlCmd.Parameters.AddWithValue("@Modulo_Name", oPersonModulos.getModuloName());
                sqlCmd.Parameters.AddWithValue("@Person_Modulo_Status", oPersonModulos.getPersonModuloStatus());
                sqlCmd.Parameters.AddWithValue("@Person_Modulo_CreateBy", oPersonModulos.getPersonModuloCreateBy());
                sqlCmd.Parameters.AddWithValue("@Person_Modulo_Dateby", oPersonModulos.getPersonModuloDateBy());

                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                sqlCmd.Dispose();
                sqlCnn.Close();
            }

            return result;

        }
    }
}
