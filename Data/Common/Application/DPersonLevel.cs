using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción: Se definen los metodos transaccionales de PersonLevel
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate: 24/08/2009
    /// Requerimiento:
    public class DPersonLevel
    {
        private Conexion oConn;
        public DPersonLevel()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Metodo para Registrar Niveles de usuarios
        public EPersonLevel registrarPersonLevelPK(string sid_Level, string sLevel_Description, bool bLevel_status, string sLevel_CreateBy,
             DateTime tLevel_DateBy, string sLevel_ModiBy, DateTime tLevel_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERLEVEL", sid_Level, sLevel_Description, bLevel_status, sLevel_CreateBy,
              tLevel_DateBy, sLevel_ModiBy, tLevel_DateModiBy);
            EPersonLevel oerPersonLevel = new EPersonLevel();
            oerPersonLevel.id_Level = sid_Level;
            oerPersonLevel.Level_Description = sLevel_Description;
            oerPersonLevel.Level_status = bLevel_status;
            oerPersonLevel.Level_CreateBy = sLevel_CreateBy;
            oerPersonLevel.Level_DateBy = tLevel_DateBy;
            oerPersonLevel.Level_ModiBy = sLevel_ModiBy;
            oerPersonLevel.Level_DateModiBy = tLevel_DateModiBy;
            return oerPersonLevel;
        }

        //Metodo para Consultar Niveles de Usuario
        public DataTable ObtenerNiveles(string sid_Level, string sLevel_Description)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHNIVELES", sid_Level, sLevel_Description);
            EPersonLevel oePersonLevel = new EPersonLevel();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oePersonLevel.id_Level = dt.Rows[i]["id_Level"].ToString().Trim();
                        oePersonLevel.Level_Description = dt.Rows[i]["Level_Description"].ToString().Trim();
                        oePersonLevel.Modulo_id = dt.Rows[i]["Modulo_id"].ToString().Trim();
                        oePersonLevel.Modulo_Name = dt.Rows[i]["Modulo_Name"].ToString().Trim();
                        oePersonLevel.Person_Modulo_Status = Convert.ToBoolean(dt.Rows[i]["Level_status"].ToString().Trim());
                        oePersonLevel.Level_status = Convert.ToBoolean(dt.Rows[i]["Level_status"].ToString().Trim());
                        oePersonLevel.Level_CreateBy = dt.Rows[i]["Level_CreateBy"].ToString().Trim();
                        oePersonLevel.Level_DateBy = Convert.ToDateTime(dt.Rows[i]["Level_DateBy"].ToString().Trim());
                        oePersonLevel.Level_ModiBy = dt.Rows[i]["Level_ModiBy"].ToString().Trim();
                        oePersonLevel.Level_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Level_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Metodo para Actualizar Niveles de Usuario
        public EPersonLevel Actualizar_Niveles(string sid_Level, string sLevel_Description, bool bLevel_status, string sLevel_ModiBy, DateTime tLevel_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_NIVELES", sid_Level, sLevel_Description, bLevel_status,  sLevel_ModiBy,  tLevel_DateModiBy);
            EPersonLevel oeaNiveles = new EPersonLevel();
            oeaNiveles.id_Level = sid_Level;
            oeaNiveles.Level_Description = sLevel_Description;
            oeaNiveles.Level_status = bLevel_status;
            oeaNiveles.Level_ModiBy = sLevel_ModiBy;
            oeaNiveles.Level_DateModiBy = tLevel_DateModiBy;            
            return oeaNiveles;
        }

        /// <summary>
        /// inserción de relación de mosulos a Nivel a la tabla de [AD_Person_Modulos]
        /// 03/12/2010  Magaly Jiménez.
        /// </summary>
        /// <param name="sid_Level"></param>
        /// <param name="sModulo_id"></param>
        /// <param name="sModulo_Name"></param>
        /// <param name="bPerson_Modulo_Status"></param>
        /// <param name="sPerson_Modulo_CreateBy"></param>
        /// <param name="tPerson_Modulo_Dateby"></param>
        /// <param name="sPerson_Modulo_ModiBy"></param>
        /// <param name="tPerson_Modulo_DateModiBy"></param>
        /// <returns></returns>
        public EPersonLevel registrarPersonLevelModuloPK(string sid_Level, string sModulo_id, string sModulo_Name, bool bPerson_Modulo_Status, string sPerson_Modulo_CreateBy,
            DateTime tPerson_Modulo_Dateby, string sPerson_Modulo_ModiBy, DateTime tPerson_Modulo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERLEVELMODULO", sid_Level, sModulo_id, sModulo_Name, bPerson_Modulo_Status, sPerson_Modulo_CreateBy,
           tPerson_Modulo_Dateby, sPerson_Modulo_ModiBy, tPerson_Modulo_DateModiBy);
            EPersonLevel oerPersonLevelModulo = new EPersonLevel();
            oerPersonLevelModulo.id_Level=sid_Level;
            oerPersonLevelModulo.Modulo_id=sModulo_id;
            oerPersonLevelModulo.Modulo_Name=sModulo_Name;
            oerPersonLevelModulo.Person_Modulo_CreateBy=sPerson_Modulo_CreateBy;
            oerPersonLevelModulo.Person_Modulo_Dateby=tPerson_Modulo_Dateby;
            oerPersonLevelModulo.Person_Modulo_ModiBy=sPerson_Modulo_ModiBy;
            oerPersonLevelModulo.Person_Modulo_DateModiBy=tPerson_Modulo_DateModiBy;

            return oerPersonLevelModulo;
        }
        /// <summary>
        /// Permite Actualizar la tabla de AD_Person_Modulos.
        /// 04/12/2010  Magaly Jiménez
        /// </summary>
        /// <param name="sid_Level"></param>
        /// <param name="bPerson_Modulo_Status"></param>
        /// <param name="sPerson_Modulo_ModiBy"></param>
        /// <param name="tPerson_Modulo_DateModiBy"></param>
        /// <returns></returns>
        public EPersonLevel Actualizar_NivelesModulos(string sid_Level, string sModulo_id, bool bPerson_Modulo_Status, string sPerson_Modulo_ModiBy, DateTime tPerson_Modulo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_NIVELESMODULOS", sid_Level, sModulo_id,  bPerson_Modulo_Status, sPerson_Modulo_ModiBy, tPerson_Modulo_DateModiBy);
            EPersonLevel oeaNivelesModulo = new EPersonLevel();
            oeaNivelesModulo.id_Level = sid_Level;
            oeaNivelesModulo.Person_Modulo_Status = bPerson_Modulo_Status;
            oeaNivelesModulo.Person_Modulo_ModiBy = sPerson_Modulo_ModiBy;
            oeaNivelesModulo.Person_Modulo_DateModiBy = tPerson_Modulo_DateModiBy;
            return oeaNivelesModulo;
        }
    
        
    }
}


        