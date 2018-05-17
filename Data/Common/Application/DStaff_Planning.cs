using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase               : DStaff_Planning
    /// Creada Por          : Ing. Mauricio Ortiz.
    /// Fecha de Creación   : 12/08/2010
    /// Requerimiento No    : 
    /// Descripción         : Clase Data encargada de definir todos los metodos transaccionales para operar Staff_Planning
    /// </summary>
    public class DStaff_Planning
    {
        private Conexion oConn;
        public DStaff_Planning()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// Descripción : Método para registrar personal asignado a un planning
        /// Fecha       : 12/08/2010
        /// Creado por  : Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="bStaffPlanning_Status"></param>
        /// <param name="sStaffPlanning_CreateBy"></param>
        /// <param name="tStaffPlanning_DateBy"></param>
        /// <param name="sStaffPlanning_ModiBy"></param>
        /// <param name="tStaffPlanning_DateModiBy"></param>
        /// <returns oeStaff_Planning></returns>
        public EStaff_Planning RegistrarPersonal(string sid_planning, int iPerson_id, bool bStaffPlanning_Status,
            string sStaffPlanning_CreateBy, DateTime tStaffPlanning_DateBy, string sStaffPlanning_ModiBy, DateTime tStaffPlanning_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_CREARPERSONALPLANNING", sid_planning, iPerson_id, bStaffPlanning_Status,
            sStaffPlanning_CreateBy, tStaffPlanning_DateBy, sStaffPlanning_ModiBy, tStaffPlanning_DateModiBy);

            EStaff_Planning oeStaff_Planning = new EStaff_Planning();
            oeStaff_Planning.id_planning = sid_planning;
            oeStaff_Planning.Person_id = iPerson_id;
            oeStaff_Planning.StaffPlanning_Status = bStaffPlanning_Status;
            oeStaff_Planning.StaffPlanning_CreateBy = sStaffPlanning_CreateBy;
            oeStaff_Planning.StaffPlanning_DateBy = tStaffPlanning_DateBy;
            oeStaff_Planning.StaffPlanning_ModiBy = sStaffPlanning_ModiBy;
            oeStaff_Planning.StaffPlanning_DateModiBy = tStaffPlanning_DateModiBy;
            return oeStaff_Planning;
        }

        /// <summary>
        /// Metodo para registrar en DB_LUCKY_TMP en la tabla TBL_PERFIL
        /// Ing. Mauricio Ortiz
        /// 16/02/2011
        /// </summary>
        /// <param name="iPerson_id"></param>
        /// <param name="sID_EQUIPO"></param>
        /// <param name="sID_CLIENTE"></param>
        /// <returns></returns>
        public DataTable RegistrarTBL_PERFIL(int iPerson_id , string sID_EQUIPO, string sID_CLIENTE)
        {
            DataTable dtRegistrarTBL_PERFIL = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_PERFIL", iPerson_id, sID_EQUIPO, sID_CLIENTE);
            return dtRegistrarTBL_PERFIL;
        }


        /// <summary>
        /// Descripción : Método para actualizar personal asignado a un planning
        /// Fecha       : 17/09/2010
        /// Creado por  : Ing. Mauricio Ortiz
        /// <param name="sid_planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="bStaffPlanning_Status"></param>
        /// <param name="sStaffPlanning_ModiBy"></param>
        /// <param name="tStaffPlanning_DateModiBy"></param>
        /// <returns>oeStaff_Planning</returns>
        public EStaff_Planning ActualizaPersonal(string sid_planning, int iPerson_id, bool bStaffPlanning_Status,
           string sStaffPlanning_ModiBy, DateTime tStaffPlanning_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ACTUALIZARPERSONALPLANNING", sid_planning, iPerson_id, bStaffPlanning_Status,
             sStaffPlanning_ModiBy, tStaffPlanning_DateModiBy);

            EStaff_Planning oeStaff_Planning = new EStaff_Planning();
            oeStaff_Planning.id_planning = sid_planning;
            oeStaff_Planning.Person_id = iPerson_id;
            oeStaff_Planning.StaffPlanning_Status = bStaffPlanning_Status;            
            oeStaff_Planning.StaffPlanning_ModiBy = sStaffPlanning_ModiBy;
            oeStaff_Planning.StaffPlanning_DateModiBy = tStaffPlanning_DateModiBy;
            return oeStaff_Planning;

        }
    }
}

        
