using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;
namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Photographs_Service
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creacion; 03/11/2009
    /// Descripcion: Define los metodos del negocio para la clase Photographs_Service
    /// Requerimiento No <>
    /// </summary>
    /// 
    public class Photographs_Service
    {
        public Photographs_Service()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        /// Descripción  : Método para registrar fotográfias de actividades propias
        /// Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string
        ///                Ing. Mauricio Ortiz
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
        /// <returns oerFotoActividadPropia></returns>
        public EPhotographs_Service RegistrarFotosActividadPropia(string sid_planning, int iid_MPOSPlanning, DateTime tPhoto_Date,
             string sid_ProductCategory, string sPhoto_TypeReport, string sPhoto_Directory, string sPhoto_Comment_Observa,
            int iCompany_id, bool bPhoto_Status, string sPhoto_CreateBy, DateTime tPhoto_DateBy,
             string sPhoto_ModiBy, DateTime tPhoto_DateModiBy)
        {
            DPhotographs_Service odrFotosActividadPropia = new DPhotographs_Service();
            EPhotographs_Service oerFotoActividadPropia = odrFotosActividadPropia.RegistrarFotosActividadPropia(sid_planning, iid_MPOSPlanning, tPhoto_Date,
              sid_ProductCategory, sPhoto_TypeReport, sPhoto_Directory, sPhoto_Comment_Observa, iCompany_id, bPhoto_Status, sPhoto_CreateBy, tPhoto_DateBy,
              sPhoto_ModiBy, tPhoto_DateModiBy);
            odrFotosActividadPropia = null;
            return oerFotoActividadPropia;
        }

        /// <summary>
        /// Descripción : Método para actualizar fotográfias de actividades propias
        /// </summary>
        /// <param name="iid_Photographs"></param>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="tPhoto_Date"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="sPhoto_Directory"></param>
        /// <param name="sPhoto_Comment_Observa"></param>
        /// <param name="bPhoto_Status"></param>
        /// <param name="sPhoto_ModiBy"></param>
        /// <param name="tPhoto_DateModiBy"></param>
        /// <returns oeaFotosActividadPropia></returns>
        public EPhotographs_Service ActualizarFotosActividadPropia(int iid_Photographs, int iid_MPOSPlanning, DateTime tPhoto_Date,
            string sid_ProductCategory, string sPhoto_Directory, string sPhoto_Comment_Observa, bool bPhoto_Status, string sPhoto_ModiBy,
            DateTime tPhoto_DateModiBy)
        {
            DPhotographs_Service odaFotosActividadPropia = new DPhotographs_Service();
            EPhotographs_Service oeaFotosActividadPropia = odaFotosActividadPropia.Actualizar_FotosActividadPropia(iid_Photographs, iid_MPOSPlanning, tPhoto_Date,
             sid_ProductCategory, sPhoto_Directory, sPhoto_Comment_Observa, bPhoto_Status, sPhoto_ModiBy, tPhoto_DateModiBy);
            odaFotosActividadPropia = null;
            return oeaFotosActividadPropia;
        }

        /// <summary>
        /// Descripción : Método para Actualizar Informe fotográfico desde planning       
        /// </summary>
        /// <param name="iid_Photographs"></param>
        /// <param name="sPhoto_Comment_Observa"></param>
        /// <param name="bPhoto_general"></param>
        /// <param name="bPhoto_detallado"></param>
        /// <param name="sPhoto_ModiBy"></param>
        /// <param name="tPhoto_DateModiBy"></param>
        /// <returns></returns>
        public EPhotographs_Service ActualizarFotosActividadPropiaPlanning(int iid_Photographs, string sPhoto_Comment_Observa, bool bPhoto_general, bool bPhoto_detallado,
            string sPhoto_ModiBy, DateTime tPhoto_DateModiBy)
        {
            DPhotographs_Service odaFotosActividadPropia = new DPhotographs_Service();
            EPhotographs_Service oeaFotosActividadPropia = odaFotosActividadPropia.Actualizar_FotosActividadPropiaPlanning(iid_Photographs, sPhoto_Comment_Observa, bPhoto_general, bPhoto_detallado,
                sPhoto_ModiBy, tPhoto_DateModiBy);
            odaFotosActividadPropia = null;
            return oeaFotosActividadPropia;
        }

        /// <summary>
        /// Actualizar comentario de registro fotográfico desde supervisor
        /// </summary>
        /// <param name="iid_Photographs"></param>
        /// <param name="sPhoto_Comment_Observa"></param>
        /// <param name="sPhoto_ModiBy"></param>
        /// <param name="tPhoto_DateModiBy"></param>
        /// <returns oeaFotosActividadPropia></returns>
        public EPhotographs_Service Actualizar_ComentarioFotoActividadPropia(int iid_Photographs, string sPhoto_Comment_Observa, string sPhoto_ModiBy, DateTime tPhoto_DateModiBy)
        {
            DPhotographs_Service odaFotosActividadPropia = new DPhotographs_Service();
            EPhotographs_Service oeaFotosActividadPropia = odaFotosActividadPropia.Actualizar_ComentarioFotoActividadPropia(iid_Photographs, sPhoto_Comment_Observa, sPhoto_ModiBy, tPhoto_DateModiBy);
            odaFotosActividadPropia = null;
            return oeaFotosActividadPropia;
        }
    }
}

