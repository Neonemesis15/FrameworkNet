using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Usuario
    {
        private Conexion oCoon;
        public D_Usuario()
        {
            oCoon = new Conexion(3);
        }

        public E_Usuario Login_Mov(string usuario, string password)
        {
            E_Usuario eusuario = new E_Usuario();
            DataTable dtUsuario = oCoon.ejecutarDataTable("SP_GES_USU_VALIDAR_USUARIO", usuario, password);
            if (dtUsuario.Rows.Count > 0)
            {
                System.Data.DataRow fila = dtUsuario.Rows[0];
                eusuario.Person_Id = fila["COD_PERSONA"].ToString().Trim();
                eusuario.Equipo_Id = fila["COD_EQUIPO"].ToString().Trim();
                eusuario.Id_Compania = fila["COD_COMPANIA"].ToString().Trim();
                eusuario.Mer_Nombre = fila["NOMBRE"].ToString().Trim();
                eusuario.Id_Canal = fila["COD_CANAL"].ToString().Trim();
                eusuario.CodPais = fila["COD_PAIS"].ToString().Trim();
                eusuario.NombrePais = fila["NOMBRE_PAIS"].ToString().Trim();
                eusuario.Perfil_Id = fila["COD_PERFIL"].ToString().Trim();
                return eusuario;
            }
            else
                return null;
        }
    }
}
