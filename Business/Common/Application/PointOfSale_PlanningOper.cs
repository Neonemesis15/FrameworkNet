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
    /// Clase: PointOfSale_PlanningOper
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creacion; 16/02/2010
    /// Descripcion: Define los metodos del negocio para la clase PointOfSale_PlanningOper
    /// Requerimiento No <>
    /// </summary>
    public class PointOfSale_PlanningOper
    {

        // Instancia al Data Entity
        EPointOfSale_PlanningOper oerPointOfSale_PlanningOper;

        // Instanciar al Access Data
        DPointOfSale_PlanningOper odrPointOfSale_PlanningOper;

        // Variable para almacenar los Mensajes de Error de la Aplicación
        public String message = "";

        /// <summary>
        /// Retorna los Mensajes de Error, si es vacio quiere decir que todo esta Ok
        /// </summary>
        /// <returns></returns>
        public String getMessage()
        {
            return message;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PointOfSale_PlanningOper()
        {
            // Inicializar el Data Access
            odrPointOfSale_PlanningOper = new DPointOfSale_PlanningOper();

            //Se define el constructor por defecto
        }


        /// <summary>
        /// Metodo para registrar asignación de puntos de venta a operativos
        /// Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string
        ///                Ing. Mauricio Ortiz
        ///                     06/09/2010 se crean dos parametros para las fechas inicial y final
        ///                     tPOSPlanningOpe_Fechainicio y tPOSPlanningOpe_Fechafin. Ing. Mauricio Ortiz
        /// </summary>        
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="sid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="tPOSPlanningOpe_Fechainicio"></param>
        /// <param name="tPOSPlanningOpe_Fechafin"></param> 
        /// <param name="bPOSPlanningOpe_Status"></param>
        /// <param name="sPOSPlanningOpe_CreateBy"></param>
        /// <param name="tPOSPlanningOpe_DateBy"></param>
        /// <param name="sPOSPlanningOpe_ModiBy"></param>
        /// <param name="tPOSPlanningOpe_DateModiBy"></param>
        /// <returns oerPointOfSale_PlanningOper></returns>
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
            try{
                // Instanciar al Objeto Acceso a Datos
                oerPointOfSale_PlanningOper =
                    odrPointOfSale_PlanningOper.RegistrarAsignPDVaOperativo(
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
                message = "Error: " + ex.ToString().Substring(0,50) + " ...";
            }

            // Validar que el mensaje de respuesta de Data Access sea "" (Cuando es "" es Correcto)
            if (odrPointOfSale_PlanningOper.getMessage() != "") {
                message = odrPointOfSale_PlanningOper.getMessage();
            }

            return oerPointOfSale_PlanningOper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="sid_Planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="tPOSPlanningOpe_Fechainicio"></param>
        /// <param name="tPOSPlanningOpe_Fechafin"></param>
        /// <returns></returns>
        public DataTable RegistrarTBL_EQUIPO_PTO_VENTA(
            int iid_MPOSPlanning, 
            string sid_Planning, 
            int iPerson_id, 
            DateTime tPOSPlanningOpe_Fechainicio, 
            DateTime tPOSPlanningOpe_Fechafin)
        {
            DPointOfSale_PlanningOper odRegistrarTBL_EQUIPO_PTO_VENTA = new DPointOfSale_PlanningOper();
            DataTable dtRegistrarTBL_EQUIPO_PTO_VENTA = 
                odRegistrarTBL_EQUIPO_PTO_VENTA.RegistrarTBL_EQUIPO_PTO_VENTA(
                    iid_MPOSPlanning, 
                    sid_Planning, 
                    iPerson_id, 
                    tPOSPlanningOpe_Fechainicio, 
                    tPOSPlanningOpe_Fechafin);
            return dtRegistrarTBL_EQUIPO_PTO_VENTA;
        }

        /// <summary>
        /// Metodo para actualizar asignación de puntos de venta a operativos
        /// Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string
        ///                Ing. Mauricio Ortiz
        ///               29/01/2011 se crean dos paraemtros para las fechas inicial y final
        ///               tPOSPlanningOpe_Fechainicio y tPOSPlanningOpe_Fechafin. Ing. Mauricio Ortiz
        /// </summary>     
        /// <param name="iid_POSPlanningOpe"></param>
        /// <param name="tPOSPlanningOpe_Fechainicio"></param>
        /// <param name="tPOSPlanningOpe_Fechafin"></param>
        /// <param name="sPOSPlanningOpe_ModiBy"></param>
        /// <param name="tPOSPlanningOpe_DateModiBy"></param>
        /// <returns></returns>
        public EPointOfSale_PlanningOper ActualizarAsignPDVaOperativo(
            int iid_POSPlanningOpe, 
            DateTime tPOSPlanningOpe_Fechainicio,
            DateTime tPOSPlanningOpe_Fechafin, 
            string sPOSPlanningOpe_ModiBy, 
            DateTime tPOSPlanningOpe_DateModiBy){

            oerPointOfSale_PlanningOper =
                odrPointOfSale_PlanningOper.ActualizarAsignPDVaOperativo(
                iid_POSPlanningOpe,
                tPOSPlanningOpe_Fechainicio,
                tPOSPlanningOpe_Fechafin,
                sPOSPlanningOpe_ModiBy,
                tPOSPlanningOpe_DateModiBy);

            // Si el message es vacío ("") significa que no se han presentado errores
            if (!odrPointOfSale_PlanningOper.getMessage().Equals("")) {
                message = odrPointOfSale_PlanningOper.getMessage();
            }

            return oerPointOfSale_PlanningOper;
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
            DataTable dtActualizaTBL_EQUIPO_PTO_VENTA = 
                odrPointOfSale_PlanningOper.ActualizarTBL_EQUIPO_PTO_VENTA(
                sClientPDV_Code, 
                sid_Planning, 
                iPerson_id, 
                tPOSPlanningOpe_Fechainicio, 
                tPOSPlanningOpe_Fechafin);
            
            if (!odrPointOfSale_PlanningOper.getMessage().Equals("")) {
                message = odrPointOfSale_PlanningOper.getMessage();
            }

            return dtActualizaTBL_EQUIPO_PTO_VENTA;
        }

        /// <summary>
        /// Descripción : Método para consultar los puntos de venta asignados a un planning
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 04/09/2010
        /// Modificación: 12/11/2010 se adiciona nuevos parametros scod_City ,iidNodeComType ,
        ///                             sNodeCommercial, lcod_Oficina  Ing. Mauricio Ortiz 
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="scod_City"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="imalla"></param>
        /// <param name="isector"></param>
        /// <returns>dt</returns>
        public DataTable Consultar_PDVPlanning(
            string sid_planning, 
            string scod_City, 
            int iidNodeComType, 
            string sNodeCommercial, 
            long lcod_Oficina, 
            int imalla, 
            int isector){

            DPlanning odPlanning = new DPlanning();
            
            DataTable dt = 
                odPlanning.Consultar_PDVPlanning(
                sid_planning, 
                scod_City, 
                iidNodeComType, 
                sNodeCommercial, 
                lcod_Oficina, 
                imalla, 
                isector);

            if (!odPlanning.getMessages().Equals(""))
            {
                message = odPlanning.getMessages();
            }
            else {
                if (dt.Rows.Count <= 0) {
                    message = "No se encontraron Puntos de Venta " +
                        "aplicando los filtros seleccionados";
                }
            }
            
            return dt;
        }

        /// <summary>
        /// Metodo Dummy
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="scod_City"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="imalla"></param>
        /// <param name="isector"></param>
        /// <returns></returns>
        public DataTable Consultar_PDVPlanningDummy(
        string sid_planning,
        string scod_City,
        int iidNodeComType,
        string sNodeCommercial,
        long lcod_Oficina,
        int imalla,
        int isector) {

            // Crear el DataTable
            DataTable dt = new DataTable();

            try {
                // Crear las Columnas del DataTable
                dt.Columns.Add("id_mposplanning", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                //Llenar información
                dt.Rows.Add(1, "Rosita S.A.C.");
                dt.Rows.Add(2, "Jenny S.A.C.");
                dt.Rows.Add(3, "Elizabeth S.A.C.");
                dt.Rows.Add(4, "Liliana S.A.C.");
                dt.Rows.Add(5, "Maguie S.A.C.");
            }
            catch (Exception ex) {
                message = "Ocurrio un Error: "
                    + ex.Message.ToString();
            }

            return dt;
        }

        /// <summary>
        /// Obtener puntos de venta asignados a un operativo
        /// Ing. Mauricio Ortiz
        /// 27/10/2010
        /// </summary>
        /// DataTable[0] Retornar listado de Puntos de Venta asignados a un Mercaderista por idPlanning
        /// - No            .- Número de Orden del Punto de Venta
        /// - Código        .- Identificador del Punto de Venta Asignado al Mercaderista.
        /// - Nombre        .- Nombre del Punto de Venta Asignado al Mercadersita.
        /// - Región        .- Nombre de la Región del Punto de Venta Asignado al Mercaderista.
        /// - Zona          .- Nombre de la Zona del Punto de Venta asignado al Mercaderista.
        /// - Fecha inicio  .- Fecha de Inicio para recolectar información del Punto de Venta asignado al Mercaderista.
        /// - Fecha fin     .- Fecha de Fin para recolectar información del Punto de Venta asignado al Mercaderista.
        /// <param name="sid_planning"></param>
        /// <param name="iidperson"></param>
        /// <returns></returns>
        public DataTable Consultar_PDVPlanningXoperativo(
        string sid_planning, int iid_person)
        {
            DPointOfSale_PlanningOper odDPointOfSale_PlanningOper = 
                new DPointOfSale_PlanningOper();

            DataTable dt = 
                odDPointOfSale_PlanningOper
                .ObtenerPuntosVentaXoperativo(
                sid_planning, iid_person);

            if (!odDPointOfSale_PlanningOper
            .getMessage().Equals("")) {
                message = odDPointOfSale_PlanningOper
                .getMessage();
            }

            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iid_person"></param>
        /// <returns></returns>
        public DataTable Consultar_PDVPlanningXoperativoDummy(
        string sid_planning, int iid_person) {
            // Creación de DataTable[]
            DataTable dt = new DataTable();
            try {
                // Agregar Columnas
                dt.Columns.Add("No", typeof(int));
                dt.Columns.Add("Código", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Región", typeof(string));
                dt.Columns.Add("Zona", typeof(string));
                dt.Columns.Add("Fecha inicio", typeof(string));
                dt.Columns.Add("Fecha fin", typeof(string));
                //Llenar información
                dt.Rows.Add(1, "PDV0001", "Fiorela S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0002", "Rosita S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0003", "Jenny S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0004", "Elizabeth S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0005", "Liliana S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0006", "Gaby S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0007", "Sandra S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0008", "Mery S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
                dt.Rows.Add(1, "PDV0009", "Stefi S.A.C.",
                "Lima Sur", "Sur", "13-01-2019", "20-01-2019");
            }
            catch (Exception ex) {
                message = "Error: " + ex.Message.ToString();
            }
            return dt;
        }

        /// <summary>
        /// Eliminar puntos de venta asignados a un operativo
        /// Ing. Mauricio Ortiz
        /// 27/10/2010
        /// </summary>
        /// <param name="iid_POSPlanningOpe"></param>
        /// <returns></returns>
        public DataTable EliminarPuntosVentaXoperativo(int iid_POSPlanningOpe){
           
            DataTable dt = odrPointOfSale_PlanningOper.EliminarPuntosVentaXoperativo(iid_POSPlanningOpe);

            // Si el getMessage es diferente de vacio (""), quiere decir que hubo Errores durante el procesamiento
            if (!odrPointOfSale_PlanningOper.getMessage().Equals("")) {
                message = odrPointOfSale_PlanningOper.getMessage();
            }

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
        public DataTable EliminarPuntosVentaXoperativo_TBL_EQUIPO_PTO_VENTA(
            string sid_Planning, int iPerson_id, int iid_POSPlanningOpe){
            
            DataTable dt =
                odrPointOfSale_PlanningOper.EliminarPuntosVentaXoperativo_TBL_EQUIPO_PTO_VENTA(
                sid_Planning, iPerson_id, iid_POSPlanningOpe);
            
            // Si el getMessage es diferente de vacio (""), quiere decir que hubo Errores durante el procesamiento
            if (!odrPointOfSale_PlanningOper.getMessage().Equals("")){
                message = odrPointOfSale_PlanningOper.getMessage();
            }

            return dt;
        }
    }
}

