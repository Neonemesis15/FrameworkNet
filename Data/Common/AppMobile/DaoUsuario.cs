using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.AppMobile;
using MySql.Data.MySqlClient;

namespace Lucky.Data.Common.AppMobile
{
    public class DaoUsuario
    {
        private StringBuilder sql = new StringBuilder();

        SqlDatabaseHelper.RowMapper<Usuario> usuarioMapper = (delegate(MySqlDataReader reader)
        {
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt16(reader[0]);
            usuario.IdPerfil = Convert.ToInt16(reader[1]);
            usuario.IdPersona = Convert.ToInt16(reader[2]);
            usuario.NombreUsuario = reader[3].ToString();
            usuario.Password = reader[4].ToString();
            return usuario;

        });

        public List<Usuario> usuarioQry() {
            sql.Append("SELECT id, ")
                .Append("idPerfil, ")
                .Append("idPersona, ")
                .Append("nombreUsuario, ")
                .Append("password ")
                .Append("FROM mdl_usuario ")
                .Append("WHERE id = @id ");

            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@id",1));


            return SqlDatabaseHelper.ExecuteToList02<Usuario>(sql.ToString(), usuarioMapper, parametros);
        }
    }
}
