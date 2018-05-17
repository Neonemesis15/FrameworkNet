using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;

namespace Lucky.Data.Common.JavaMovil
{
    public class DUsuario
    {
        private Conexion oConn;
        public DUsuario()
        {
            UserInterface oUserInterface = new UserInterface();
            oUserInterface = null;
        }

        public EUsuario Login(string usuario, string password)
        {
            oConn = new Conexion(2);
            EUsuario eusuario = new EUsuario();
            DataTable dtUsuario = oConn.ejecutarDataTable("STP_JVM_VALIDAR_USUARIO", usuario, password);
            if (dtUsuario.Rows.Count > 0)
            {
                System.Data.DataRow fila = dtUsuario.Rows[0];
                eusuario.Id_Compania = fila["ID_CLIENTE"].ToString().Trim();
                eusuario.Id_Canal = fila["ID_EQUIPO"].ToString().Trim();
                eusuario.Mer_Nombre = fila["MER_NOMBRE"].ToString().Trim();
                eusuario.Perfil_Id = fila["perfil_id"].ToString().Trim();
                eusuario.Person_Id = fila["person_id"].ToString().Trim();
                return eusuario;
            } 
            else
                return null;            
        }

        public EUsuarioAuditoria LoginAuditoria(string usuario, string password)
        {
            oConn = new Conexion(2);
            EUsuarioAuditoria eusuario = new EUsuarioAuditoria();
            DataTable dtUsuario = oConn.ejecutarDataTable("SP_JVM_AUDITORIA_VALIDAR_USUARIO", usuario, password);
            if (dtUsuario.Rows.Count > 0)
            {
                System.Data.DataRow fila = dtUsuario.Rows[0];
                eusuario.Person_Id = fila["PERSON_ID"].ToString().Trim();
                eusuario.Id_Equipo = fila["COD_EQUIPO"].ToString().Trim();
                eusuario.Mer_Nombre = fila["MER_NOMBRE"].ToString().Trim();                
                return eusuario;
            }
            else
                return null;
        }
    }
}
