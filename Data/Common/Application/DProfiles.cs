using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DProfiles.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:26/05/2009
    /// Requerimiento:
    public class DProfiles
    {
        private Conexion oConn;

        public DProfiles()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Metodo para Registrar Perfiles
        public EProfiles registrarPerfilesPK(//string sPerfil_id,
            string sTipoPerfil_id,string sRolid, string sid_Level, string iPerfilName, string sModuloid, string sPerfilDescription,
            int idChannel, bool bPerfilStatus, string sPerfilCreateBy, string sPerfilDateBy, string sPerfilModiBy, string sPerfilDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERPROFILES"
                //, sPerfil_id
                , sTipoPerfil_id ?? null //PSalas 18/09/2012
                , sRolid
                , sid_Level
                , iPerfilName
                , sModuloid
                , sPerfilDescription
                , idChannel
                , bPerfilStatus
                , sPerfilCreateBy
                , sPerfilDateBy
                , sPerfilModiBy
                , sPerfilDateModiBy);
            EProfiles oerPerfiles = new EProfiles();
            oerPerfiles.Perfilid = dt.Rows[0]["Perfil_id"].ToString().Trim();
            oerPerfiles.TipoPerfil_id = dt.Rows[0]["TipPerfil_id"].ToString().Trim();//PSalas 18/09/2012
            oerPerfiles.Rolid = dt.Rows[0]["Rol_id"].ToString().Trim(); ;
            oerPerfiles.id_Level = dt.Rows[0]["id_Level"].ToString().Trim(); ;
            oerPerfiles.PerfilName = dt.Rows[0]["Perfil_Name"].ToString().Trim(); ;
            oerPerfiles.ModuloId = dt.Rows[0]["Modulo_id"].ToString().Trim(); ;
            oerPerfiles.PerfilDescription = dt.Rows[0]["Perfil_Description"].ToString().Trim(); ;
            oerPerfiles.PerfilChannel = Convert.ToInt32(dt.Rows[0]["cod_Channel"].ToString().Trim());
            oerPerfiles.PerfilStatus = Convert.ToBoolean(dt.Rows[0]["Perfil_Status"].ToString().Trim());
            oerPerfiles.PerfilCreateBy = dt.Rows[0]["Perfil_CreateBy"].ToString().Trim(); ;
            oerPerfiles.PerfilDateBy = dt.Rows[0]["Perfil_DateBy"].ToString().Trim(); ;
            oerPerfiles.PerfilModiBy = dt.Rows[0]["Perfil_ModiBy"].ToString().Trim(); ;
            oerPerfiles.PerfilDateModiBy = dt.Rows[0]["Perfil_DateModiBy"].ToString().Trim(); ;
            return oerPerfiles;


            #region Codigo Comentado 20092012
            ////oerPerfiles.Perfilid = sPerfil_id;
            //oerPerfiles.TipoPerfil_id = sTipoPerfil_id; //PSalas 18/09/2012
            //oerPerfiles.Rolid = sRolid;
            //oerPerfiles.id_Level = sid_Level;
            //oerPerfiles.PerfilName = iPerfilName;
            //oerPerfiles.ModuloId = sModuloid;
            //oerPerfiles.PerfilDescription = sPerfilDescription;
            //oerPerfiles.PerfilChannel = idChannel;
            //oerPerfiles.PerfilStatus = Convert.ToBoolean(bPerfilStatus.ToString().Trim());
            //oerPerfiles.PerfilCreateBy = sPerfilCreateBy;
            //oerPerfiles.PerfilDateBy = sPerfilDateBy;
            //oerPerfiles.PerfilModiBy = sPerfilModiBy;
            //oerPerfiles.PerfilDateModiBy = sPerfilDateModiBy;
            #endregion

            
        }


        //Metodo para Consultar Perfiles
        public DataTable ObtenerPerfiles(string sPerfilName, string sRolid, int idChannel, string sLevel/*, string sTipoPerfil*/)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHPERFILES", sPerfilName, sRolid, idChannel, sLevel/*, sTipoPerfil*/);
            EProfiles oePerfiles = new EProfiles();
            if (dt != null)
            {
                #region Comentar codigo No Utilizado 18/09/2012
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                //    {
                //        oePerfiles.Perfilid = dt.Rows[i]["Perfil_id"].ToString().Trim();
                //        oePerfiles.Rolid = dt.Rows[i]["Rol_id"].ToString().Trim();
                //        oePerfiles.id_Level = dt.Rows[i]["id_Level"].ToString().Trim();
                //        oePerfiles.PerfilName = (dt.Rows[i]["Perfil_Name"].ToString().Trim());
                //        oePerfiles.ModuloId = (dt.Rows[i]["Modulo_id"].ToString().Trim());
                //        oePerfiles.PerfilDescription = (dt.Rows[i]["Perfil_Description"].ToString().Trim());
                //        oePerfiles.PerfilChannel = Convert.ToInt32(dt.Rows[i]["cod_Channel"].ToString().Trim());
                //        oePerfiles.PerfilStatus = Convert.ToBoolean(dt.Rows[i]["Perfil_Status"].ToString().Trim());
                //        oePerfiles.PerfilCreateBy = (dt.Rows[i]["Perfil_CreateBy"].ToString().Trim());
                //        oePerfiles.PerfilDateBy = (dt.Rows[i]["Perfil_DateBy"].ToString().Trim());
                //        oePerfiles.PerfilModiBy = (dt.Rows[i]["Perfil_ModiBy"].ToString().Trim());
                //        oePerfiles.PerfilDateModiBy = (dt.Rows[i]["Perfil_DateModiBy"].ToString().Trim());
                //    }
                //}
                #endregion
                return dt;
            }
            else
            {  return null; }
        }

        //Metodo para Actualizar Perfiles Ing. Carlos Alberto Hernandez
        public EProfiles Actualizar_Perfiles(
            string sPerfilid, string sTipPerfilid, string sRolid, string sLevel, string iPerfilName, 
            string sModuloid, string sPerfilDescription, int idChannel, bool bPerfilStatus, string sPerfilModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_PROFILES"
                , sPerfilid
                , sTipPerfilid ?? null
                , sRolid
                , sLevel
                , iPerfilName
                , sModuloid
                , sPerfilDescription
                , idChannel
                , bPerfilStatus
                , sPerfilModiBy);

            EProfiles oeaPerfiles = new EProfiles();
            oeaPerfiles.Perfilid = sPerfilid;
            oeaPerfiles.Rolid = sRolid;
            oeaPerfiles.id_Level = sLevel;
            oeaPerfiles.PerfilName = iPerfilName;
            oeaPerfiles.ModuloId = sModuloid;
            oeaPerfiles.PerfilDescription = sPerfilDescription;
            oeaPerfiles.PerfilChannel = idChannel;
            oeaPerfiles.PerfilStatus = Convert.ToBoolean(bPerfilStatus.ToString().Trim());
            oeaPerfiles.PerfilModiBy = sPerfilModiBy;
            return oeaPerfiles;
        }
    }
}
