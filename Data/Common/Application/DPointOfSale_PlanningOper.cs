using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DPointOfSale_PlanningOper
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creación; 16/02/2010
    /// Requerimiento No 
    /// Descripción : Clase Data encargada de definir todos los metodos transaccionales para operar PointOfSale_PlanningOper
    /// </summary>
    public class DPointOfSale_PlanningOper
    {

        private Conexion oConn;
        public DPointOfSale_PlanningOper()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        // Variable para almacenar los Mensajes de Error de la Aplicación
        public String message;

        // Variable para almacenar el Resultado de las consultas a la Base de Datos por Store Procedure
        public DataTable dt;

        // Variable para almacenar en un Objeto el resultado de la consulta.
        EPointOfSale_PlanningOper oerPointOfSale_PlanningOper;

        /// <summary>
        /// Retorna los Mensajes de Error, si es vacio quiere decir que todo esta Ok
        /// </summary>
        /// <returns></returns>
        public String getMessage() {
            return message;
        }

        /// <summary>
        /// Metodo para registrar asignación de puntos de venta a operativos
        /// Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string. 
        ///                Ing. Mauricio Ortiz
        ///                     06/09/2010 se crean dos paraemtros para las fechas inicial y final
        ///                     tPOSPlanningOpe_Fechainicio y tPOSPlanningOpe_Fechafin. Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="iid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="tPOSPlanningOpe_Fechainicio"></param>
        /// <param name="tPOSPlanningOpe_Fechafin"></param> 
        /// <param name="bPOSPlanningOpe_Status"></param>
        /// <param name="sPOSPlanningOpe_CreateBy"></param>
        /// <param name="tPOSPlanningOpe_DateBy"></param>
        /// <param name="sPOSPlanningOpe_ModiBy"></param>
        /// <param name="tPOSPlanningOpe_DateModiBy"></param>
        /// <returns>oerPointOfSale_PlanningOper</returns>
        public EPointOfSale_PlanningOper RegistrarAsignPDVaOperativo(
            int iid_MPOSPlanning, 
            string sid_Planning,
            int iPerson_id, 
            DateTime tPOSPlanningOpe_Fechainicio, 
            DateTime tPOSPlanningOpe_Fechafin, 
            int ifrecuencia, 
            bool bPOSPlanningOpe_Status, 
            string sPOSPlanningOpe_CreateBy, 
            DateTime tPOSPlanningOpe_DateBy, 
            string sPOSPlanningOpe_ModiBy,
            DateTime tPOSPlanningOpe_DateModiBy){

                // Ejecuta Procedimiento
                try{
                    dt = oConn.ejecutarDataTable(
                        "UP_WEBSIGE_SUPERVISOR_ASIGNARPDVAOPERATIVO_tmp",
                        iid_MPOSPlanning,
                        sid_Planning,
                        iPerson_id,
                        tPOSPlanningOpe_Fechainicio,
                        tPOSPlanningOpe_Fechafin,
                        ifrecuencia,
                        bPOSPlanningOpe_Status,
                        sPOSPlanningOpe_CreateBy,
                        tPOSPlanningOpe_DateBy,
                        sPOSPlanningOpe_ModiBy,
                        tPOSPlanningOpe_DateModiBy);
                }catch (Exception ex) {
                    message = "Ocurrió un Error: " + ex.ToString();
                }

                // Valida si el resultado devuelve registros
                if (dt.Rows.Count > 0 ){

                    oerPointOfSale_PlanningOper = new EPointOfSale_PlanningOper();
                    oerPointOfSale_PlanningOper.id_MPOSPlanning = iid_MPOSPlanning;
                    oerPointOfSale_PlanningOper.id_Planning = sid_Planning;
                    oerPointOfSale_PlanningOper.Person_id = iPerson_id;
                    oerPointOfSale_PlanningOper.POSPlanningOpe_Fechainicio = tPOSPlanningOpe_Fechainicio;
                    oerPointOfSale_PlanningOper.POSPlanningOpe_Fechafin = tPOSPlanningOpe_Fechafin;
                    oerPointOfSale_PlanningOper.Frecuencia = ifrecuencia;
                    oerPointOfSale_PlanningOper.POSPlanningOpe_Status = bPOSPlanningOpe_Status;
                    oerPointOfSale_PlanningOper.POSPlanningOpe_CreateBy = sPOSPlanningOpe_CreateBy;
                    oerPointOfSale_PlanningOper.POSPlanningOpe_DateBy = tPOSPlanningOpe_DateBy;
                    oerPointOfSale_PlanningOper.POSPlanningOpe_ModiBy = sPOSPlanningOpe_ModiBy;
                    oerPointOfSale_PlanningOper.POSPlanningOpe_DateModiBy = tPOSPlanningOpe_DateModiBy;

                }
                else {
                    message = "No se Encontraron Puntos de Venta Asignados a Mercaderistas, ¡Por favor verifique!";
                }

            return oerPointOfSale_PlanningOper;
        }

        /// <summary>
        /// Método para registrar asignacion de puntos de venta a operativo en BD movil
        /// Ing. Mauricio Ortiz
        /// 11/02/2011
        /// </summary>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="sid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="tPOSPlanningOpe_Fechainicio"></param>
        /// <param name="tPOSPlanningOpe_Fechafin"></param>
        /// <returns></returns>
        public DataTable RegistrarTBL_EQUIPO_PTO_VENTA(int iid_MPOSPlanning, string sid_Planning, int iPerson_id, DateTime tPOSPlanningOpe_Fechainicio, DateTime tPOSPlanningOpe_Fechafin)
        {
            DataTable dtRegistraTBL_EQUIPO_PTO_VENTA = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_EQUIPO_PTO_VENTA", iid_MPOSPlanning, sid_Planning, iPerson_id, tPOSPlanningOpe_Fechainicio, tPOSPlanningOpe_Fechafin);
            return dtRegistraTBL_EQUIPO_PTO_VENTA;
        }

        ///// <summary>
        ///// Metodo para actualizar asignación de puntos de venta a operativos
        /////  Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string. 
        /////                Ing. Mauricio Ortiz
        /////                29/01/2011 se crean dos paraemtros para las fechas inicial y final
        /////                tPOSPlanningOpe_Fechainicio y tPOSPlanningOpe_Fechafin. Ing. Mauricio Ortiz
        ///// </summary>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="tPOSPlanningOpe_Fechainicio"></param>
        /// <param name="tPOSPlanningOpe_Fechafin"></param>
        /// <param name="sPOSPlanningOpe_ModiBy"></param>
        /// <param name="tPOSPlanningOpe_DateModiBy"></param>
        /// <returns></returns>
        public EPointOfSale_PlanningOper ActualizarAsignPDVaOperativo(int iid_POSPlanningOpe, DateTime tPOSPlanningOpe_Fechainicio,
            DateTime tPOSPlanningOpe_Fechafin, string sPOSPlanningOpe_ModiBy, DateTime tPOSPlanningOpe_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SUPERVISOR_UPDATEASIGNARPDVAOPERATIVO", iid_POSPlanningOpe, tPOSPlanningOpe_Fechainicio,
                tPOSPlanningOpe_Fechafin, sPOSPlanningOpe_ModiBy, tPOSPlanningOpe_DateModiBy);

            EPointOfSale_PlanningOper oeaPointOfSale_PlanningOper = new EPointOfSale_PlanningOper();

            oeaPointOfSale_PlanningOper.id_POSPlanningOpe = iid_POSPlanningOpe;
            oeaPointOfSale_PlanningOper.POSPlanningOpe_Fechainicio = tPOSPlanningOpe_Fechainicio;
            oeaPointOfSale_PlanningOper.POSPlanningOpe_Fechafin = tPOSPlanningOpe_Fechafin;
            oeaPointOfSale_PlanningOper.POSPlanningOpe_ModiBy = sPOSPlanningOpe_ModiBy;
            oeaPointOfSale_PlanningOper.POSPlanningOpe_DateModiBy = tPOSPlanningOpe_DateModiBy;

            return oeaPointOfSale_PlanningOper;
        }

        /// <summary>
        /// Metodo para actualizar en TBL_EQUIPO_PTO_VENTA las fechas de inicio y fin
        /// Ing. Mauricio Ortiz
        /// 12/02/2011
        /// </summary>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="sid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="tPOSPlanningOpe_Fechainicio"></param>
        /// <param name="tPOSPlanningOpe_Fechafin"></param>
        /// <returns></returns>
        public DataTable ActualizarTBL_EQUIPO_PTO_VENTA(string sClientPDV_Code, string sid_Planning, int iPerson_id, DateTime tPOSPlanningOpe_Fechainicio, DateTime tPOSPlanningOpe_Fechafin)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ACTUALIZAR_TBL_EQUIPO_PTO_VENTA", sClientPDV_Code, sid_Planning, iPerson_id, tPOSPlanningOpe_Fechainicio, tPOSPlanningOpe_Fechafin);
            return dt;
        }

        /// <summary>
        /// Obtener puntos de venta asignados a un operativo
        /// Ing. Mauricio Ortiz
        /// 27/10/2010
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iidperson"></param>
        /// <returns></returns>
        public DataTable ObtenerPuntosVentaXoperativo(string sid_planning, int iidperson)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_OBTENERPDVXOPERATIVO", sid_planning, iidperson);
            EPointOfSale_PlanningOper oeEPointOfSale_PlanningOper = new EPointOfSale_PlanningOper();
            EPuntosDV oeEPuntosDV = new EPuntosDV();
            EMalla oeEMalla = new EMalla();
            ESector oeESector = new ESector();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeEPointOfSale_PlanningOper.id_POSPlanningOpe = Convert.ToInt32(dt.Rows[i]["No"].ToString().Trim());
                        oeEPuntosDV.ClientPDV_Code = dt.Rows[i]["Código"].ToString().Trim();
                        oeEPuntosDV.pdvName = dt.Rows[i]["Nombre"].ToString().Trim();
                        oeEMalla.malla = dt.Rows[i]["Región"].ToString().Trim();
                        oeESector.Sector = dt.Rows[i]["Zona"].ToString().Trim();
                        oeEPointOfSale_PlanningOper.POSPlanningOpe_Fechainicio = Convert.ToDateTime(dt.Rows[i]["Fecha inicio"].ToString().Trim());
                        oeEPointOfSale_PlanningOper.POSPlanningOpe_Fechafin = Convert.ToDateTime(dt.Rows[i]["Fecha fin"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Eliminar puntos de venta asignados a un operativo
        /// Ing. Mauricio Ortiz
        /// 27/10/2010
        /// </summary>
        /// <param name="iid_POSPlanningOpe"></param>
        /// <returns></returns>
        public DataTable EliminarPuntosVentaXoperativo(int iid_POSPlanningOpe)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINARPDVXOPERATIVO", iid_POSPlanningOpe);
            return dt;
        }

        /// <summary>
        /// Eliminar registros en la tabla [TBL_EQUIPO_PTO_VENTA]
        /// Ing. Mauricio Ortiz
        /// 18/02/2011
        /// </summary>
        /// <param name="sid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iid_POSPlanningOpe"></param>
        /// <returns></returns>
        public DataTable EliminarPuntosVentaXoperativo_TBL_EQUIPO_PTO_VENTA(string sid_Planning, int iPerson_id, int iid_POSPlanningOpe)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINARPDVXOPERATIVO_TBL_EQUIPO_PTO_VENTA", sid_Planning, iPerson_id, iid_POSPlanningOpe);
            return dt;
        }
    }
}


