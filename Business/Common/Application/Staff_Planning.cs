using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;


namespace Lucky.Business.Common.Application
{
    public class Staff_Planning
    {
        public Staff_Planning()
        {
            // se define el constructor por defecto
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
            DStaff_Planning odStaff_Planninf = new DStaff_Planning();
            EStaff_Planning oeStaff_Planning = odStaff_Planninf.RegistrarPersonal(sid_planning, iPerson_id, bStaffPlanning_Status,
             sStaffPlanning_CreateBy, tStaffPlanning_DateBy, sStaffPlanning_ModiBy, tStaffPlanning_DateModiBy);
            odStaff_Planninf = null;
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
        public DataTable RegistrarTBL_PERFIL(int iPerson_id, string sID_EQUIPO, string sID_CLIENTE)
        {
            DStaff_Planning odStaff_Planninf = new DStaff_Planning();
            DataTable dtRegistrarTBL_PERFIL = odStaff_Planninf.RegistrarTBL_PERFIL(iPerson_id, sID_EQUIPO, sID_CLIENTE);
            return dtRegistrarTBL_PERFIL;
        }

        

        /// <summary>
        /// Descripción : Método para actualizar personal asignado a un planning
        /// Fecha       : 17/09/2010
        /// Creado por  : Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="bStaffPlanning_Status"></param>
        /// <param name="sStaffPlanning_ModiBy"></param>
        /// <param name="tStaffPlanning_DateModiBy"></param>
        /// <returns></returns>
        public EStaff_Planning ActualizaPersonal(string sid_planning, int iPerson_id, bool bStaffPlanning_Status,
            string sStaffPlanning_ModiBy, DateTime tStaffPlanning_DateModiBy)
        {
            DStaff_Planning odStaff_Planninf = new DStaff_Planning();
            EStaff_Planning oeStaff_Planning = odStaff_Planninf.ActualizaPersonal(sid_planning, iPerson_id, bStaffPlanning_Status,
             sStaffPlanning_ModiBy, tStaffPlanning_DateModiBy);
            odStaff_Planninf = null;
            return oeStaff_Planning;
        }
        
            
    }
}
