using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// Clase:              DPhotographs_Service
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  03-10-2009
    /// Requerimientos No:  <>
    /// Descripcion:        Clase Data encargada de definir todos los metodos transaccionales para operar Photographs_Service
    ///                     permite al personal operativo y de apoyo por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar los registros fotográficos de actividades propias
    /// </summary> 

    public class DPhotographs_Service
    {
        private Conexion oConn;
        public DPhotographs_Service()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }        

        /// <summary>
        /// Método para registrar fotográfias de actividades propias 
        /// Modificación: 29/07/2010 Se cambia nombre de Store UP_WEBSIGE_OPERATIVO_SAVEPHOTOACTIVIDADPROPIA
        /// Por UP_WEBXPLORA_OPE_SAVEPHOTOACTIVIDADPROPIA y se modifica tipo de dato del 
        /// parametro id_planning de int a string. Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="tPhoto_Date"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sPhoto_TypeReport"></param>
        /// <param name="sPhoto_Directory"></param>
        /// <param name="sPhoto_Comment_Observa"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="bPhoto_Status"></param>
        /// <param name="sPhoto_CreateBy"></param>
        /// <param name="tPhoto_DateBy"></param>
        /// <param name="sPhoto_ModiBy"></param>
        /// <param name="tPhoto_DateModiBy"></param>
        /// <returns oerFotosActividadPropia></returns>
        public EPhotographs_Service RegistrarFotosActividadPropia(string sid_planning, int iid_MPOSPlanning, DateTime tPhoto_Date,
            string sid_ProductCategory, string sPhoto_TypeReport, string sPhoto_Directory, string sPhoto_Comment_Observa, int iCompany_id, bool bPhoto_Status, string sPhoto_CreateBy, DateTime tPhoto_DateBy,
            string sPhoto_ModiBy, DateTime tPhoto_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_SAVEPHOTOACTIVIDADPROPIA", sid_planning, iid_MPOSPlanning, tPhoto_Date,
             sid_ProductCategory, sPhoto_TypeReport, sPhoto_Directory, sPhoto_Comment_Observa, iCompany_id, bPhoto_Status, sPhoto_CreateBy, tPhoto_DateBy,
             sPhoto_ModiBy, tPhoto_DateModiBy);

            EPhotographs_Service oerFotosActividadPropia = new EPhotographs_Service();
            oerFotosActividadPropia.id_planning = sid_planning;
            oerFotosActividadPropia.id_MPOSPlanning = iid_MPOSPlanning;
            oerFotosActividadPropia.Photo_Date = tPhoto_Date;
            oerFotosActividadPropia.id_ProductCategory = sid_ProductCategory;
            oerFotosActividadPropia.Photo_TypeReport = sPhoto_TypeReport;
            oerFotosActividadPropia.Photo_Directory = sPhoto_Directory;
            oerFotosActividadPropia.Photo_Comment_Observa = sPhoto_Comment_Observa;
            oerFotosActividadPropia.Company_id = iCompany_id;
            oerFotosActividadPropia.Photo_Status = bPhoto_Status;
            oerFotosActividadPropia.Photo_CreateBy = sPhoto_CreateBy;
            oerFotosActividadPropia.Photo_DateBy = tPhoto_DateBy;
            oerFotosActividadPropia.Photo_ModiBy = sPhoto_ModiBy;
            oerFotosActividadPropia.Photo_DateModiBy = tPhoto_DateModiBy;
            return oerFotosActividadPropia;
        }


        //Método: Actualizar Informe fotográfico

        public EPhotographs_Service Actualizar_FotosActividadPropia(int iid_Photographs, int iid_MPOSPlanning, DateTime tPhoto_Date,
            string sid_ProductCategory, string sPhoto_Directory, string sPhoto_Comment_Observa, bool bPhoto_Status, string sPhoto_ModiBy,
            DateTime tPhoto_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_OPERATIVO_UPDATEPHOTOACTIVIDADPROPIA", iid_Photographs, iid_MPOSPlanning, tPhoto_Date,
             sid_ProductCategory, sPhoto_Directory, sPhoto_Comment_Observa, bPhoto_Status, sPhoto_ModiBy,
             tPhoto_DateModiBy);
            EPhotographs_Service oeaFotosActividadPropia = new EPhotographs_Service();
            oeaFotosActividadPropia.id_Photographs = iid_Photographs;
            oeaFotosActividadPropia.id_MPOSPlanning = iid_MPOSPlanning;
            oeaFotosActividadPropia.Photo_Date = tPhoto_Date;
            oeaFotosActividadPropia.id_ProductCategory = sid_ProductCategory;
            oeaFotosActividadPropia.Photo_Directory = sPhoto_Directory;
            oeaFotosActividadPropia.Photo_Comment_Observa = sPhoto_Comment_Observa;
            oeaFotosActividadPropia.Photo_Status = bPhoto_Status;
            oeaFotosActividadPropia.Photo_ModiBy = sPhoto_ModiBy;
            oeaFotosActividadPropia.Photo_DateModiBy = tPhoto_DateModiBy;
            return oeaFotosActividadPropia;
        }

        //Método: Actualizar Informe fotográfico desde planning

        public EPhotographs_Service Actualizar_FotosActividadPropiaPlanning(int iid_Photographs, string sPhoto_Comment_Observa, bool bPhoto_general, bool bPhoto_detallado,
            string sPhoto_ModiBy,DateTime tPhoto_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATEPHOTOACTIVIDADPROPIA", iid_Photographs, sPhoto_Comment_Observa, bPhoto_general,bPhoto_detallado, 
                sPhoto_ModiBy, tPhoto_DateModiBy);
            EPhotographs_Service oeaFotosActividadPropia = new EPhotographs_Service();
            oeaFotosActividadPropia.id_Photographs = iid_Photographs;            
            oeaFotosActividadPropia.Photo_Comment_Observa = sPhoto_Comment_Observa;
            oeaFotosActividadPropia.Photo_general = bPhoto_general;
            oeaFotosActividadPropia.Photo_detallado = bPhoto_detallado;
            oeaFotosActividadPropia.Photo_ModiBy = sPhoto_ModiBy;
            oeaFotosActividadPropia.Photo_DateModiBy = tPhoto_DateModiBy;
            return oeaFotosActividadPropia;
        }

        //Método: Actualizar comentario de registro fotográfico desde supervisor

        public EPhotographs_Service Actualizar_ComentarioFotoActividadPropia(int iid_Photographs, string sPhoto_Comment_Observa,string sPhoto_ModiBy, DateTime tPhoto_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SUPERVISOR_UPDATECOMMENTPHOTOACTIV", iid_Photographs, sPhoto_Comment_Observa, sPhoto_ModiBy, tPhoto_DateModiBy);
            EPhotographs_Service oeaFotosActividadPropia = new EPhotographs_Service();
            oeaFotosActividadPropia.id_Photographs = iid_Photographs;
            oeaFotosActividadPropia.Photo_Comment_Observa = sPhoto_Comment_Observa;            
            oeaFotosActividadPropia.Photo_ModiBy = sPhoto_ModiBy;
            oeaFotosActividadPropia.Photo_DateModiBy = tPhoto_DateModiBy;
            return oeaFotosActividadPropia;
        }
    }
}
