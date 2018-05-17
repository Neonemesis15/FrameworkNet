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
    /// Clase: Products_PlanningOpe
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creacion; 16/02/2010
    /// Descripcion: Define los metodos del negocio para la clase Products_PlanningOpe
    /// Requerimiento No <>
    /// </summary>

    public class Products_PlanningOpe
    {
        public Products_PlanningOpe()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        /// Metodo para registrar asignación de productos a operativos
        /// Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string
        ///                Ing. Mauricio Ortiz      
        /// </summary>
        /// <param name="iid_ProductsPlanning"></param>
        /// <param name="sid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="bProducts_PlanningOpe_Status"></param>
        /// <param name="sProducts_PlanningOpe_CreateBy"></param>
        /// <param name="tProducts_PlanningOpe_DateBy"></param>
        /// <param name="sProducts_PlanningOpe_ModiBy"></param>
        /// <param name="tProducts_PlanningOpe_DateModiBy"></param>
        /// <returns oerProducts_PlanningOpe></returns>
        public EProducts_PlanningOpe RegistrarAsignPRODUCTOSaOperativo(int iid_ProductsPlanning, string sid_Planning, int iPerson_id,
            bool bProducts_PlanningOpe_Status, string sProducts_PlanningOpe_CreateBy, DateTime tProducts_PlanningOpe_DateBy,
            string sProducts_PlanningOpe_ModiBy, DateTime tProducts_PlanningOpe_DateModiBy)
        {
            DProducts_PlanningOpe odrProducts_PlanningOpe = new DProducts_PlanningOpe();
            EProducts_PlanningOpe oerProducts_PlanningOpe = odrProducts_PlanningOpe.RegistrarAsignPRODUCTOSaOperativo(iid_ProductsPlanning, sid_Planning, iPerson_id,
            bProducts_PlanningOpe_Status, sProducts_PlanningOpe_CreateBy, tProducts_PlanningOpe_DateBy,
            sProducts_PlanningOpe_ModiBy, tProducts_PlanningOpe_DateModiBy);
            odrProducts_PlanningOpe = null;
            return oerProducts_PlanningOpe;
        }

        /// <summary>
        /// Metodo para actualizar asignación de producto a operativos
        /// Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string
        ///                Ing. Mauricio Ortiz 
        /// </summary>
        /// <param name="iid_ProductsPlanning"></param>
        /// <param name="sid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="bProducts_PlanningOpe_Status"></param>
        /// <param name="sProducts_PlanningOpe_ModiBy"></param>
        /// <param name="tProducts_PlanningOpe_DateModiBy"></param>
        /// <returns oeaProducts_PlanningOpe></returns>
        public EProducts_PlanningOpe ActualizarAsignPRODUCTOaOperativo(int iid_ProductsPlanning, string sid_Planning, int iPerson_id,
            bool bProducts_PlanningOpe_Status, string sProducts_PlanningOpe_ModiBy, DateTime tProducts_PlanningOpe_DateModiBy)
        {
            DProducts_PlanningOpe odaProducts_PlanningOpe = new DProducts_PlanningOpe();
            EProducts_PlanningOpe oeaProducts_PlanningOpe = odaProducts_PlanningOpe.ActualizarAsignPRODUCTOaOperativo(iid_ProductsPlanning, sid_Planning, iPerson_id,
                bProducts_PlanningOpe_Status, sProducts_PlanningOpe_ModiBy, tProducts_PlanningOpe_DateModiBy);
            odaProducts_PlanningOpe = null;
            return oeaProducts_PlanningOpe;
        }
    }
}