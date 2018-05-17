using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DRoles.
    /// CreateBy: Ing. Carlos Alberto Hernandez RIncón
    /// CreateDate:02/05/2009
    /// Requerimiento:
    /// Modificaciones : 11-06-2009 , se modifica para que el usuario pueda ingresar el id del rol . Ing. Mauricio Ortiz
    public class DRoles
    {
        private Conexion oConn;
        public DRoles()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        //Metodo para COnsultar Roles
        public DataTable ObtenerRoles(string sNameRol)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_OBTENERROLES", sNameRol);
            ERoles oeRoles = new ERoles();
            if (dt != null)
            {

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeRoles.Rolid = dt.Rows[i]["Rol_id"].ToString().Trim();
                        oeRoles.RolName = dt.Rows[i]["Rol_Name"].ToString().Trim();
                        oeRoles.RolDescription = dt.Rows[i]["Rol_Description"].ToString().Trim();
                        oeRoles.RolStatus = Convert.ToBoolean(dt.Rows[i]["Rol_Status"].ToString().Trim());
                        oeRoles.RolCreateBy = dt.Rows[i]["Rol_CreateBy"].ToString().Trim();
                        oeRoles.RolDateBy = dt.Rows[i]["Rol_DateBy"].ToString().Trim();
                        oeRoles.RolModiBy = dt.Rows[i]["Rol_DateModiBy"].ToString().Trim();
                    }
                }

                return dt;
            }


            else
            {
                return null;
            }
        }

        //Metodo para Registrar Roles

        public ERoles RegistrarRolesPK(string iRol_id, string sRolName, string sRolDescription, bool bRolStatus, string sRolCreateBy,
           string sRolDateBy, string sRolModiBy, string sRolDateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_RERGISTERROLES", iRol_id, sRolName, sRolDescription, bRolStatus, sRolCreateBy, sRolDateBy, sRolModiBy, sRolDateModiBy);

            ERoles oerRoles = new ERoles();

            oerRoles.Rolid = iRol_id;
            oerRoles.RolName = sRolName;
            oerRoles.RolDescription = sRolDescription;
            oerRoles.RolStatus = Convert.ToBoolean(bRolStatus.ToString().Trim());
            oerRoles.RolCreateBy = sRolCreateBy;
            oerRoles.RolDateBy = sRolDateBy;
            oerRoles.RolModiBy = sRolModiBy;
            oerRoles.RolDateModiBy = sRolDateModiBy;
            return oerRoles;



        }

        //Metodo para Actualizar Roles

        public ERoles ActulizarRoles(string sRol_id, string sRolName, string sRolDescription, bool bRolStatus, string sRolModiBy, string sRolDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAROL", sRol_id, sRolName, sRolDescription, bRolStatus, sRolModiBy, sRolDateModiBy);
            ERoles oearoles = new ERoles();



            oearoles.Rolid = sRol_id;
            oearoles.RolName = sRolName;
            oearoles.RolDescription = sRolDescription;
            oearoles.RolStatus = bRolStatus;
            oearoles.RolModiBy = sRolModiBy;
            oearoles.RolDateModiBy = sRolDateModiBy;
            return oearoles;
        }
     
        

    }
}
