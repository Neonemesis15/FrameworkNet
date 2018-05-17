using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DProducts_PlanningOpe
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creación; 16/02/2010
    /// Requerimiento No 
    /// Descripción : Clase Data encargada de definir todos los metodos transaccionales para operar Products_PlanningOpe
    /// </summary>


    public class DProducts_PlanningOpe
    {
        private Conexion oConn;
        public DProducts_PlanningOpe()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// Metodo para registrar asignación de productos a operativos
        /// Modificación : 29/07/2010 Se cambia tipo de datos de id_planning de int a string
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_ProductsPlanning"></param>
        /// <param name="iid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="bProducts_PlanningOpe_Status"></param>
        /// <param name="sProducts_PlanningOpe_CreateBy"></param>
        /// <param name="tProducts_PlanningOpe_DateBy"></param>
        /// <param name="sProducts_PlanningOpe_ModiBy"></param>
        /// <param name="tProducts_PlanningOpe_DateModiBy"></param>
        /// <returns>oerProducts_PlanningOpe</returns>

        public EProducts_PlanningOpe RegistrarAsignPRODUCTOSaOperativo(int iid_ProductsPlanning, string sid_Planning, int iPerson_id,
            bool bProducts_PlanningOpe_Status, string sProducts_PlanningOpe_CreateBy, DateTime tProducts_PlanningOpe_DateBy,
            string sProducts_PlanningOpe_ModiBy, DateTime tProducts_PlanningOpe_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SUPERVISOR_ASIGNARPRODUCTOSAOPERATIVO", iid_ProductsPlanning, sid_Planning, iPerson_id,
            bProducts_PlanningOpe_Status, sProducts_PlanningOpe_CreateBy, tProducts_PlanningOpe_DateBy,
            sProducts_PlanningOpe_ModiBy, tProducts_PlanningOpe_DateModiBy);

            EProducts_PlanningOpe oerProducts_PlanningOpe = new EProducts_PlanningOpe();

            oerProducts_PlanningOpe.id_ProductsPlanning = iid_ProductsPlanning;
            oerProducts_PlanningOpe.id_Planning = sid_Planning;
            oerProducts_PlanningOpe.Person_id = iPerson_id;
            oerProducts_PlanningOpe.Products_PlanningOpe_Status = bProducts_PlanningOpe_Status;
            oerProducts_PlanningOpe.Products_PlanningOpe_CreateBy = sProducts_PlanningOpe_CreateBy;
            oerProducts_PlanningOpe.Products_PlanningOpe_DateBy = tProducts_PlanningOpe_DateBy;
            oerProducts_PlanningOpe.Products_PlanningOpe_ModiBy = sProducts_PlanningOpe_ModiBy;
            oerProducts_PlanningOpe.Products_PlanningOpe_DateModiBy = tProducts_PlanningOpe_DateModiBy;

            return oerProducts_PlanningOpe;
        }

        /// <summary>
        /// Metodo para actualizar asignación de producto a operativos
        /// Modificación : 29/07/2010 se cambia tipo de dato en id_planning de int a string 
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_ProductsPlanning"></param>
        /// <param name="iid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="bProducts_PlanningOpe_Status"></param>
        /// <param name="sProducts_PlanningOpe_ModiBy"></param>
        /// <param name="tProducts_PlanningOpe_DateModiBy"></param>
        /// <returns>oeaProducts_PlanningOpe</returns>

        public EProducts_PlanningOpe ActualizarAsignPRODUCTOaOperativo(int iid_ProductsPlanning, string sid_Planning, int iPerson_id,
            bool bProducts_PlanningOpe_Status, string sProducts_PlanningOpe_ModiBy, DateTime tProducts_PlanningOpe_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SUPERVISOR_UPDATEASIGNARPRODUCTOAOPERATIVO", iid_ProductsPlanning, sid_Planning, iPerson_id,
                bProducts_PlanningOpe_Status, sProducts_PlanningOpe_ModiBy, tProducts_PlanningOpe_DateModiBy);

            EProducts_PlanningOpe oeaProducts_PlanningOpe = new EProducts_PlanningOpe();

            oeaProducts_PlanningOpe.id_ProductsPlanning = iid_ProductsPlanning;
            oeaProducts_PlanningOpe.id_Planning = sid_Planning;
            oeaProducts_PlanningOpe.Person_id = iPerson_id;
            oeaProducts_PlanningOpe.Products_PlanningOpe_Status = bProducts_PlanningOpe_Status;
            oeaProducts_PlanningOpe.Products_PlanningOpe_ModiBy = sProducts_PlanningOpe_ModiBy;
            oeaProducts_PlanningOpe.Products_PlanningOpe_DateModiBy = tProducts_PlanningOpe_DateModiBy;

            return oeaProducts_PlanningOpe;
        }
    }
}