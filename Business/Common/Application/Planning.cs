using System;
using System.Collections.Generic;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class Planning
    {
        // Variables
        // Variable para guardar los mensajes
        private String messages = "";
        DPlanning dplanning = new DPlanning();

        /// <summary>
        /// Retornar los mensajes
        /// </summary>
        /// <returns></returns>
        public String getMessages(){
            return messages;
        }

        /// <summary>
        /// Retornar la información del Presupuesto by idCompany
        /// 'Numero_Presupuesto', - Correspondiente al [number_ budget].
        /// 'Nombre',             - Concatenado del [number_ budget] + name_budget.
        /// 'name',               - Corresponde al name_budget (Nombre del Bucket).
        /// 'id_planning'         - Corresponde al Identificador del Planning.
        /// </summary>
        /// <param name="idCompany"></param>
        /// <returns></returns>
        public DataTable presupuestoSearch(int idCompany) {
            DataTable dt = new DataTable();

            dt = dplanning.presupuestoSearch(idCompany);

            if (!dplanning.getMessages().Equals(""))
            {
                messages = dplanning.getMessages();
            }

            return dt;
        }

        /// <summary>
        /// Retorna DataTable con la información del Presupuesto
        /// por idCompany (Dummy)
        /// </summary>
        /// <param name="idCompany"></param>
        /// <returns></returns>
        public DataTable presupuestoSearchDummy(int idCompany) {
            
            // Crear el Objeto DataTable
            DataTable dt = new DataTable();

            // Definir las Columnas
            dt.Columns.Add("Numero_Presupuesto", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("id_planning", typeof(string));

            //Llenar información
            dt.Rows.Add("0001", "Prepuesto Supermercado", 
                "Dummy Supermercado", "1999000901");
            dt.Rows.Add("0002", "Prepuesto Mayorista", 
                "Dummy Mayorista", "1999000902");
            dt.Rows.Add("0003", "Prepuesto Minorista", 
                "Dummy Minorista", "1999000903");

            return dt;
        }

        /// <summary>
        /// Retornar DataSet con el conjunto de datos relacionados al Planning
        /// al Planning.
        /// DataTable[0] - Obtiene información para llenar combo de Planning
        /// DataTable[1] - Obtiene información de los objetivos para la Campaña
        /// DataTable[2] - Obtiene información de los Productos con SKU Mandatorio
        /// DataTable[3] - Obtiene información de la Mecánica de las Actividades
        /// DataTable[4] - Obtiene información del Personal Asignado a la Campaña
        /// DataTable[5] - Obtiene información de la asginación de Mercaderista y Supervisores
        /// DataTable[6] - Obtiene información de los PDVs de la Campania
        /// DataTable[7] - Obtiene información de los Productos Asignados por Campania 
        /// DataTable[8] - Obtiene información de los Puntos de Venta Asignados a los Mercaderistas
        /// DataTable[9] - Obtiene información del Planning Seleccionado
        /// DataTable[10]- Obtiene información de los Reportes asignados a la Campania
        /// DataTable[11]- Obtiene información de los Paneles Asignados a la Campania
        /// DataTable[12]- Obtiene información de las Marcas Asignadas a la Campania
        /// DataTable[13]- Obtiene información de las Familias Asignadas a la Campania
        /// DataTable[14]- Obtiene información de las Categorias Asignadas a la Campania
        /// ds = oCoon.ejecutarDataSet("UP_WEBSIGE_PLANNIG_CREADOS", CmbSelCampaña.SelectedValue);
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <returns></returns>
        public DataSet getInfoPlanning(String idPlanning) {
            // Creacion de DataSet
            DataSet ds = new DataSet();
            ds = dplanning.getInfoPlanning(idPlanning);
            if (!dplanning.getMessages().Equals("")) {
                messages = dplanning.getMessages();
            }
            return ds;
        }

        /// <summary>
        /// Retornar DataSet con el conjunto de datos relacionados
        /// al Planning (Dummy).
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <returns></returns>
        public DataSet getInfoPlanningDummy(String idPlanning)
        {
            // Creacion de DataSet
            DataSet ds = new DataSet();
            try
            {
                // Creación de DataTable[00]
                DataTable dt00 = new DataTable();
                dt00.Columns.Add("id_planning", typeof(string));
                dt00.Columns.Add("planning_name", typeof(string));

                //Llenar información
                dt00.Rows.Add("1930000001", "Planning Prueba 01");
                dt00.Rows.Add("1930000002", "Planning Prueba 02");

                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt00);

                // Creación de DataTable[01]
                DataTable dt01 = new DataTable();
                dt01.Columns.Add("id_objplanning", typeof(int));
                dt01.Columns.Add("id_planning", typeof(string));
                dt01.Columns.Add("objpladescription", typeof(string));
                dt01.Columns.Add("objplacreateby", typeof(string));
                dt01.Columns.Add("objpladateby", typeof(DateTime));
                dt01.Columns.Add("objplamodiby", typeof(string));
                dt01.Columns.Add("objpladatemodiby", typeof(DateTime));

                //Llenar información
                dt01.Rows.Add(1, "1930000001", "Planning Prueba 01",
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt01.Rows.Add(2, "1930000002", "Planning Prueba 02",
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);

                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt01);

                DataTable dt02 = new DataTable();
                dt02.Columns.Add("id_mandtoryplanning", typeof(int));
                dt02.Columns.Add("id_planning", typeof(string));
                dt02.Columns.Add("mandtorydescription", typeof(string));
                dt02.Columns.Add("mandtorycreateby", typeof(string));
                dt02.Columns.Add("mandtorydateby", typeof(DateTime));
                dt02.Columns.Add("mandtorymodiby", typeof(string));
                dt02.Columns.Add("mandtorydatemodiby", typeof(DateTime));

                //Llenar información
                dt02.Rows.Add(1, "1930000001", "Mandatory Description 01",
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt02.Rows.Add(2, "1930000001", "Mandatory Description 02",
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);

                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt02);



                DataTable dt03 = new DataTable();
                dt03.Columns.Add("mechanicalactivity_id", typeof(int));
                dt03.Columns.Add("id_planning", typeof(string));
                dt03.Columns.Add("mechanicalactivity_description", typeof(string));
                dt03.Columns.Add("mechanicalactivity_createby", typeof(string));
                dt03.Columns.Add("mechanicalactivity_dateby", typeof(DateTime));
                dt03.Columns.Add("mechanicalactivity_modyby", typeof(string));
                dt03.Columns.Add("mechanicalactivity_datemodyby", typeof(DateTime));

                //Llenar información
                dt03.Rows.Add(1, "1930000001", "Mechanic Description 01",
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt03.Rows.Add(2, "1930000001", "Mechanic Description 02",
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);

                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt03);

                DataTable dt04 = new DataTable();
                dt04.Columns.Add("id_staffplanning", typeof(int));
                dt04.Columns.Add("id_planning", typeof(string));
                dt04.Columns.Add("person_id", typeof(int));
                dt04.Columns.Add("staffplanning_status", typeof(bool));
                dt04.Columns.Add("staffplanning_createby", typeof(string));
                dt04.Columns.Add("staffplanning_dateby", typeof(DateTime));
                dt04.Columns.Add("staffplanning_modiby", typeof(string));
                dt04.Columns.Add("staffplanning_datemodiby", typeof(DateTime));

                //Llenar información
                dt04.Rows.Add(1, "1930000001", 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt04.Rows.Add(2, "1930000001", 2, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt04.Rows.Add(3, "1930000001", 3, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt04.Rows.Add(4, "1930000001", 4, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt04.Rows.Add(5, "1930000001", 5, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt04);

                DataTable dt05 = new DataTable();
                dt05.Columns.Add("id_asigper", typeof(int));
                dt05.Columns.Add("id_planning", typeof(string));
                dt05.Columns.Add("person_idsupe", typeof(int));
                dt05.Columns.Add("person_idopera", typeof(int));
                dt05.Columns.Add("asigmenper_status", typeof(bool));
                dt05.Columns.Add("asigmenper_createby", typeof(string));
                dt05.Columns.Add("asigmenper_dateby", typeof(DateTime));
                dt05.Columns.Add("asigmenper_modiby", typeof(string));
                dt05.Columns.Add("asigmenper_datemodiby", typeof(DateTime));
                //Llenar información
                dt05.Rows.Add(1, "1930000001", 1, 9, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt05.Rows.Add(2, "1930000001", 2, 9, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt05.Rows.Add(3, "1930000001", 3, 9, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt05.Rows.Add(4, "1930000001", 4, 9, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt05.Rows.Add(5, "1930000001", 5, 9, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt05.Rows.Add(6, "1930000001", 6, 9, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);

                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt05);

                DataTable dt06 = new DataTable();
                dt06.Columns.Add("id_mposplanning", typeof(int));
                //Llenar información
                dt06.Rows.Add(1);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt06);

                DataTable dt07 = new DataTable();
                dt07.Columns.Add("id_productsplanning", typeof(int));
                dt07.Columns.Add("id_planning", typeof(string));
                dt07.Columns.Add("id_product", typeof(int));
                dt07.Columns.Add("id_productcategory", typeof(string));
                dt07.Columns.Add("id_brand", typeof(int));
                dt07.Columns.Add("id_subbrand", typeof(string));
                dt07.Columns.Add("id_productfamily", typeof(string));
                dt07.Columns.Add("id_productsubfamily", typeof(string));
                dt07.Columns.Add("product_caracte", typeof(string));
                dt07.Columns.Add("product_benefi", typeof(string));
                dt07.Columns.Add("productsplanning_initialstock", typeof(int));
                dt07.Columns.Add("report_id", typeof(int));
                dt07.Columns.Add("status", typeof(bool));
                dt07.Columns.Add("productplan_createby", typeof(string));
                dt07.Columns.Add("productplan_dateby", typeof(DateTime));
                dt07.Columns.Add("productplan_modiby", typeof(string));
                dt07.Columns.Add("productplan_datemodiby", typeof(DateTime));
                //Llenar información
                dt07.Rows.Add(1, "1930000001", 1, 1, 1, "1", "1", "1",
                "Character Product 01", "Benefic Producto 01", 100, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt07.Rows.Add(2, "1930000001", 2, 1, 1, "1", "1", "1",
                "Character Product 02", "Benefic Producto 02", 100, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt07.Rows.Add(3, "1930000001", 3, 1, 1, "1", "1", "1",
                "Character Product 03", "Benefic Producto 03", 100, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt07.Rows.Add(4, "1930000001", 4, 1, 1, "1", "1", "1",
                "Character Product 04", "Benefic Producto 04", 100, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt07.Rows.Add(5, "1930000001", 5, 1, 1, "1", "1", "1",
                "Character Product 05", "Benefic Producto 05", 100, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt07);

                DataTable dt08 = new DataTable();
                dt08.Columns.Add("id_posplanningope", typeof(int));
                dt08.Columns.Add("id_mposplanning", typeof(int));
                dt08.Columns.Add("id_planning", typeof(string));
                dt08.Columns.Add("person_id", typeof(int));
                dt08.Columns.Add("posplanningope_fechainicio", typeof(DateTime));
                dt08.Columns.Add("posplanningope_fechafin", typeof(DateTime));
                dt08.Columns.Add("id_frecuencia", typeof(int));
                dt08.Columns.Add("posplanningope_status", typeof(bool));
                dt08.Columns.Add("posplanningope_createby", typeof(string));
                dt08.Columns.Add("posplanningope_dateby", typeof(DateTime));
                dt08.Columns.Add("posplanningope_modiby", typeof(string));
                dt08.Columns.Add("posplanningope_datemodiby", typeof(DateTime));
                //Llenar información
                dt08.Rows.Add(1, 1, "1930000001", 1, DateTime.Now,
                DateTime.Now, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt08.Rows.Add(2, 1, "1930000001", 2, DateTime.Now,
                DateTime.Now, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt08.Rows.Add(3, 1, "1930000001", 3, DateTime.Now,
                DateTime.Now, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt08.Rows.Add(4, 1, "1930000001", 4, DateTime.Now,
                DateTime.Now, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt08.Rows.Add(5, 1, "1930000001", 5, DateTime.Now,
                DateTime.Now, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt08.Rows.Add(6, 1, "1930000001", 6, DateTime.Now,
                DateTime.Now, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt08.Rows.Add(7, 1, "1930000001", 7, DateTime.Now,
                DateTime.Now, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt08);

                DataTable dt09 = new DataTable();
                dt09.Columns.Add("id_planning", typeof(string));
                dt09.Columns.Add("planning_name", typeof(string));
                dt09.Columns.Add("cod_strategy", typeof(int));
                dt09.Columns.Add("planning_codchannel", typeof(string));
                dt09.Columns.Add("planning_startactivity", typeof(DateTime));
                dt09.Columns.Add("planning_endactivity", typeof(DateTime));
                dt09.Columns.Add("planning_reportaditional", typeof(string));
                dt09.Columns.Add("planning_developmentactivityreport", typeof(string));
                dt09.Columns.Add("planning_person_eje", typeof(int));
                dt09.Columns.Add("planning_activityformats", typeof(string));
                dt09.Columns.Add("planning_areainvolved", typeof(string));
                dt09.Columns.Add("planning_daterepsoli", typeof(DateTime));
                dt09.Columns.Add("planning_preprodudateini", typeof(DateTime));
                dt09.Columns.Add("planning_preprodudateend", typeof(DateTime));
                dt09.Columns.Add("planning_projectduration", typeof(string));
                dt09.Columns.Add("planning_datefinreport", typeof(DateTime));
                dt09.Columns.Add("planning_vigen", typeof(string));
                dt09.Columns.Add("planning_budget", typeof(string));
                dt09.Columns.Add("id_designfor", typeof(int));
                dt09.Columns.Add("name_contact", typeof(string));
                dt09.Columns.Add("email_contac", typeof(string));
                dt09.Columns.Add("planning_status", typeof(bool));
                dt09.Columns.Add("status_id", typeof(int));
                dt09.Columns.Add("planning_formacompe", typeof(bool));
                dt09.Columns.Add("planning_createby", typeof(string));
                dt09.Columns.Add("planning_dateby", typeof(DateTime));
                dt09.Columns.Add("planning_modiby", typeof(string));
                dt09.Columns.Add("planning_datemodiby", typeof(DateTime));
                dt09.Columns.Add("strategy_name", typeof(string));
                //Llenar información
                dt09.Rows.Add("1930000001", "Planning 01", 1,
                "1", DateTime.Now, DateTime.Now, "1", "1", 1, "1", "1",
                DateTime.Now, DateTime.Now, DateTime.Now, "1",
                DateTime.Now, "1", "1", 1, "Contact Name 01", "abc@email.com",
                true, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now,
                "Strategy Name 01");

                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt09);

                DataTable dt10 = new DataTable();
                dt10.Columns.Add("id_reportsplanning", typeof(int));
                dt10.Columns.Add("id_planning", typeof(string));
                dt10.Columns.Add("report_id", typeof(int));
                dt10.Columns.Add("id_year", typeof(int));
                dt10.Columns.Add("id_month", typeof(int));
                dt10.Columns.Add("reportsplanning_periodo", typeof(int));
                dt10.Columns.Add("reportsplanning_recogerdesde", typeof(DateTime));
                dt10.Columns.Add("reportsplanning_recogerhasta", typeof(DateTime));
                dt10.Columns.Add("reportsplanning_validacionanalista", typeof(bool));
                dt10.Columns.Add("reportsplanning_status", typeof(bool));
                dt10.Columns.Add("reportsplanning_createby", typeof(string));
                dt10.Columns.Add("reportsplanning_dateby", typeof(DateTime));
                dt10.Columns.Add("reportsplanning_modiby", typeof(string));
                dt10.Columns.Add("reportsplanning_datemodiby", typeof(DateTime));
                //Llenar información
                dt10.Rows.Add(1, "1930000001", 1, 2019, 1, 1, DateTime.Now,
                DateTime.Now, true, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt10.Rows.Add(2, "1930000001", 1, 2019, 1, 2, DateTime.Now,
                DateTime.Now, true, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt10.Rows.Add(3, "1930000001", 1, 2019, 1, 3, DateTime.Now,
                DateTime.Now, true, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt10.Rows.Add(4, "1930000001", 1, 2019, 1, 4, DateTime.Now,
                DateTime.Now, true, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt10);

                DataTable dt11 = new DataTable();
                dt11.Columns.Add("id_panelplanning", typeof(int));
                dt11.Columns.Add("id_planning", typeof(string));
                dt11.Columns.Add("id_mposplanning", typeof(int));
                dt11.Columns.Add("clientpdv_code", typeof(string));
                dt11.Columns.Add("report_id", typeof(int));
                dt11.Columns.Add("status_panelplanning", typeof(bool));
                dt11.Columns.Add("panelplanning_createby", typeof(string));
                dt11.Columns.Add("panelplanning_dateby", typeof(DateTime));
                dt11.Columns.Add("panelplanning_modiby", typeof(string));
                dt11.Columns.Add("panelplanning_datemodiby", typeof(DateTime));
                //Llenar información
                dt11.Rows.Add(1, "1930000001", 1, "PDV001", 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt11);

                DataTable dt12 = new DataTable();
                dt12.Columns.Add("id_brandplanning", typeof(int));
                dt12.Columns.Add("id_planning", typeof(int));
                dt12.Columns.Add("id_brand", typeof(int));
                dt12.Columns.Add("report_id", typeof(int));
                dt12.Columns.Add("status", typeof(bool));
                dt12.Columns.Add("brandplan_createby", typeof(string));
                dt12.Columns.Add("brandplan_dateby", typeof(DateTime));
                dt12.Columns.Add("brandplan_modiby", typeof(string));
                dt12.Columns.Add("brandplan_datemodiby", typeof(DateTime));
                //Llenar información
                dt12.Rows.Add(1, "1930000001", 1, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt12.Rows.Add(2, "1930000001", 2, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt12.Rows.Add(3, "1930000001", 3, 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt12);

                DataTable dt13 = new DataTable();
                dt13.Columns.Add("id_brandplanning", typeof(int));
                dt13.Columns.Add("id_planning", typeof(string));
                dt13.Columns.Add("id_productcategory", typeof(string));
                dt13.Columns.Add("id_brand", typeof(int));
                dt13.Columns.Add("id_productfamily", typeof(string));
                dt13.Columns.Add("report_id", typeof(int));
                dt13.Columns.Add("status", typeof(bool));
                dt13.Columns.Add("familyplan_createby", typeof(string));
                dt13.Columns.Add("familyplan_dateby", typeof(DateTime));
                dt13.Columns.Add("familyplan_modiby", typeof(string));
                dt13.Columns.Add("familyplan_datemodiby", typeof(DateTime));
                //Llenar información
                dt13.Rows.Add(1, "1930000001", "CAT001", 1, "FAM001",
                1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt13.Rows.Add(2, "1930000001", "CAT001", 2, "FAM001",
                1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                dt13.Rows.Add(3, "1930000001", "CAT001", 3, "FAM001",
                1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt13);



                DataTable dt14 = new DataTable();
                dt14.Columns.Add("id_categoryplanning", typeof(int));
                dt14.Columns.Add("id_planning", typeof(string));
                dt14.Columns.Add("id_productcategory", typeof(string));
                dt14.Columns.Add("report_id", typeof(int));
                dt14.Columns.Add("status", typeof(bool));
                dt14.Columns.Add("categoryplan_createby", typeof(string));
                dt14.Columns.Add("categoryplan_dateby", typeof(DateTime));
                dt14.Columns.Add("categoryplan_modiby", typeof(string));
                dt14.Columns.Add("categoryplan_datemodiby", typeof(DateTime));
                //Llenar información
                dt14.Rows.Add(1, "1930000001", "CAT001", 1, true,
                "cmarin", DateTime.Now, "cmarin", DateTime.Now);
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt14);
            }
            catch (Exception ex) {
                messages = "Error: " + ex.Message.ToString();
            }
            return ds;
        }

        /// <summary>
        /// Obtener información del Presupuesto,
        /// Interface con EasyWin, devuelve información 
        /// para llenar Combos correspondientes al Planning.
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public DataTable cmbInterfaceEasyWin(String idBudget,
        int option) {

            DataTable dt = dplanning.cmbInterfaceEasyWin(idBudget,
                option);
            if (!dplanning.getMessages().Equals("")) {
                messages = dplanning.getMessages();
            }
            return dt;

        }

        /// <summary>
        /// Obtener información del Presupuesto,
        /// Interface con EasyWin, devuelve información 
        /// para llenar Combos correspondientes al Planning.
        /// (Dummy)
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public DataTable cmbInterfaceEasyWinDummy(String idBudget,
        int option) {
            DataTable dt = new DataTable();
            try
            {
                switch (option)
                {
                    case 1:
                        // Definir las Columnas
                        dt.Columns.Add("Company_id", typeof(int));
                        dt.Columns.Add("Company_Name", typeof(string));
                        //Llenar información
                        dt.Rows.Add(1560, "Alicorp");
                        //dt.Rows.Add(1561, "Lucky");
                        //dt.Rows.Add(1562, "Colgate");
                        break;
                    case 2:
                        // Definir las Columnas
                        dt.Columns.Add("Person_id", typeof(int));
                        dt.Columns.Add("Nombres", typeof(string));
                        dt.Columns.Add("person_status", typeof(bool));
                        dt.Columns.Add("Perfil_id", typeof(string));
                        dt.Columns.Add("name_user", typeof(string));
                        dt.Columns.Add("User_Password", typeof(string));
                        dt.Columns.Add("Person_Email", typeof(string));

                        //Llenar información
                        dt.Rows.Add(1, "Nombre 01 Apellido 01", true,
                        "PRF001", "cmarin", DateTime.Now, "cmarin88",
                        "awsasdfasfq", "cmarin@email.com");
                        break;
                    case 3:
                        // Definir las Columnas
                        dt.Columns.Add("Person_id", typeof(int));
                        dt.Columns.Add("Nombres", typeof(string));
                        dt.Columns.Add("Perfil_id", typeof(string));
                        dt.Columns.Add("perfil_name", typeof(string));

                        //Llenar información
                        dt.Rows.Add(1, "Nombre 01 Apellido 01",
                        "PRF001", "Operativo");
                        break;
                    case 4:
                        // Definir las Columnas
                        dt.Columns.Add("Person_id", typeof(int));
                        dt.Columns.Add("Nombres", typeof(string));
                        dt.Columns.Add("Perfil_id", typeof(string));
                        dt.Columns.Add("perfil_name", typeof(string));

                        //Llenar información
                        dt.Rows.Add(2, "Nombre 02 Apellido 02",
                        "PRF002", "Supervisor");
                        break;
                    case 5:
                        // Definir las Columnas
                        dt.Columns.Add("Company_id", typeof(int));
                        dt.Columns.Add("Company_Name", typeof(string));
                        //Llenar información
                        dt.Rows.Add(1560, "Alicorp");
                        dt.Rows.Add(1561, "Lucky");
                        dt.Rows.Add(1562, "Colgate");
                        break;
                    case 6:
                        // Definir las Columnas
                        dt.Columns.Add("Person_id", typeof(int));
                        dt.Columns.Add("Nombres", typeof(string));
                        dt.Columns.Add("Perfil_id", typeof(string));
                        dt.Columns.Add("name_user", typeof(string));
                        dt.Columns.Add("User_Password", typeof(string));
                        dt.Columns.Add("Person_Email", typeof(string));
                        //Llenar información
                        dt.Rows.Add(1, "Nombre 01 Apellido 01",
                        "PRF001", "nlucky", "qwefqwerzcv",
                        "nlucky2@email.com");
                        dt.Rows.Add(2, "Nombre 02 Apellido 02",
                        "PRF002", "jlucky", "asdfqwerzcv",
                        "jlucky@email.com");
                        dt.Rows.Add(3, "Nombre 03 Apellido 03",
                        "PRF005", "mlucky", "zxcfqwerzcv",
                        "mlucky1@email.com");
                        break;
                }
            }
            catch (Exception ex) {
                messages = "Error: " + ex.Message.ToString();
            }
            return dt;
            
        }

        /// <summary>
        /// Obtener el Listado de Controllers,
        /// Supervisores y Mercaderistas, para el caso
        /// de los mercaderistas remueve todos aquellos
        /// que tengan supervisor.
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <returns></returns>
        public DataSet getStaffPlanning(String idPlanning) {
            // Creacion de DataSet
            DataSet ds = new DataSet();
            ds = dplanning.getStaffPlanning(idPlanning);
            if (dplanning.getMessages().Equals("")) {
                // Retornar el Listado de Mercaderistas
                //DataTable dtMercaderistas = ds.Tables[1];
                try
                {
                    for (int i = 0;
                        i <= ds.Tables[1].Rows.Count - 1;
                        i++)
                    {

                        // Verificar si tienen Supervisor
                        DataTable dtCheck = dplanning.getCheckOperationAssigment(
                            idPlanning,
                            int.Parse(ds.Tables[1].Rows[i]["person_id"].ToString()));

                        if (dtCheck.Rows.Count > 0)
                        {
                            DataRowCollection itemColumns = ds.Tables[1].Rows;
                            itemColumns[i].Delete();
                            // Accept changes on others.
                            ds.Tables[1].AcceptChanges();
                            i--;
                        }
                    }
                }
                catch (Exception ex) {
                    messages = "Error: " + ex.Message.ToString();
                }
            }
            else
            {
                messages = dplanning.getMessages();
            }
            return ds;
        }

        /// <summary>
        /// Obtener el Listado de Controllers,
        /// Supervisores y Mercaderistas (Dummy).
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <returns></returns>
        public DataSet getStaffPlanningDummy(String idPlanning) {
            // Creacion de DataSet
            DataSet ds = new DataSet();
            try
            {
                // Creación de DataTable[00]
                DataTable dt00 = new DataTable();
                dt00.Columns.Add("person_id", typeof(int));
                dt00.Columns.Add("name_user", typeof(string));
                //Llenar información
                dt00.Rows.Add(1, "Supervisor 01");
                dt00.Rows.Add(2, "Supervisor 02");
                dt00.Rows.Add(3, "Supervisor 03");
                dt00.Rows.Add(4, "Supervisor 04");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt00);

                // Creación de DataTable[01]
                DataTable dt01 = new DataTable();
                dt01.Columns.Add("person_id", typeof(int));
                dt01.Columns.Add("name_user", typeof(string));
                //Llenar información
                dt01.Rows.Add(1, "Mercaderista 01");
                dt01.Rows.Add(2, "Mercaderista 02");
                dt01.Rows.Add(3, "Mercaderista 03");
                dt01.Rows.Add(4, "Mercaderista 04");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt01);

                // Creación de DataTable[02]
                DataTable dt02 = new DataTable();
                dt02.Columns.Add("person_id", typeof(int));
                dt02.Columns.Add("name_user", typeof(string));
                //Llenar información
                dt02.Rows.Add(1, "Controller 01");
                dt02.Rows.Add(2, "Controller 02");
                dt02.Rows.Add(3, "Controller 03");
                dt02.Rows.Add(4, "Controller 04");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt02);

            }
            catch (Exception ex) {
                messages = "Error: " + ex.Message.ToString();
            }
            return ds;
        }

        public List<EPlaning> lista_campanias_cliente(int company_id)
        {
            
            
            List<EPlaning> leplanning = new List<EPlaning>();

            DataTable dt = new DataTable();
            dt = dplanning.lista_campanias_cliente(company_id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EPlaning eplanning = new EPlaning();
                eplanning.idplanning = dt.Rows[i]["id_planning"].ToString();
                eplanning.PlanningName = dt.Rows[i]["Planning_Name"].ToString();
                eplanning.codStrategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"]);
                eplanning.PlanningCodChannel = dt.Rows[i]["Planning_CodChannel"].ToString();
                eplanning.PlanningStartActivity = Convert.ToDateTime(dt.Rows[i]["Planning_StartActivity"]);
                eplanning.PlanningEndActivity = Convert.ToDateTime(dt.Rows[i]["Planning_EndActivity"]);
                leplanning.Add(eplanning);
            }
            return leplanning;
        }

        /// <summary>
        /// Retornar la información de los puntos de Venta, incluye
        /// Ciudades, Nodos Comerciales, Oficinas, Regiones, Zona.
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="idCity"></param>
        /// <param name="idNodeCommercial"></param>
        /// <param name="idOficina"></param>
        /// <param name="idMalla"></param>
        /// <returns></returns>
        public DataSet getInfoPtoVenta(String idPlanning,
        string idCity, int idNodeCommercialType,
        string idNodeCommercial, int idOficina,
        int idMalla){
            DataSet ds = dplanning.getInfoPtoVenta(
                idPlanning,
                idCity,
                idNodeCommercialType,
                idNodeCommercial,
                idOficina,
                idMalla
                );

            if (!dplanning.getMessages().Equals("")) {
                messages = dplanning.getMessages();
            }
            return ds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="idCity"></param>
        /// <param name="idNodeCommercial"></param>
        /// <param name="idOficina"></param>
        /// <param name="idMalla"></param>
        /// <returns></returns>
        public DataSet getInfoPtoVentaDummy(String idPlanning,
        string idCity, int idNodeCommercialType,
        string idNodeCommercial, int idOficina,
        int idMalla){
            // Creacion de DataSet
            DataSet ds = new DataSet();
            try
            {
                // Creación de DataTable[00]
                DataTable dt00 = new DataTable();
                // Agregar Columnas
                dt00.Columns.Add("cod_city", typeof(string));
                dt00.Columns.Add("name_city", typeof(string));
                //Llenar información
                dt00.Rows.Add("01", "Arequipa");
                dt00.Rows.Add("02", "Lima");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt00);

                // Creación de DataTable[01]
                DataTable dt01 = new DataTable();
                // Agregar Columnas
                dt01.Columns.Add("idnodecomtype", typeof(int));
                dt01.Columns.Add("nodecomtype_name", typeof(string));
                //Llenar información
                dt01.Rows.Add("01", "Cencosud");
                dt01.Rows.Add("02", "Supermercados Peruanos");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt01);

                // Creación de DataTable[02]
                DataTable dt02 = new DataTable();
                // Agregar Columnas
                dt02.Columns.Add("nodecommercial", typeof(int));
                dt02.Columns.Add("commercialnodename", typeof(string));
                //Llenar información
                dt02.Rows.Add("01", "Netro");
                dt02.Rows.Add("02", "Tottus");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt02);

                // Creación de DataTable[03]
                DataTable dt03 = new DataTable();
                // Agregar Columnas
                dt03.Columns.Add("cod_oficina", typeof(int));
                dt03.Columns.Add("name_oficina", typeof(string));
                //Llenar información
                dt03.Rows.Add("01", "Puno");
                dt03.Rows.Add("02", "Cuzco");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt03);

                // Creación de DataTable[04]
                DataTable dt04 = new DataTable();
                // Agregar Columnas
                dt04.Columns.Add("id_malla", typeof(int));
                dt04.Columns.Add("malla", typeof(string));
                //Llenar información
                dt04.Rows.Add("01", "Lima Sur");
                dt04.Rows.Add("02", "Lima Norte");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt04);

                // Creación de DataTable[05]
                DataTable dt05 = new DataTable();
                // Agregar Columnas
                dt05.Columns.Add("id_sector", typeof(int));
                dt05.Columns.Add("sector", typeof(string));
                //Llenar información
                dt05.Rows.Add("01", "Sur Chico");
                dt05.Rows.Add("02", "Lima Metropolitana");
                // Insertar DataTable in DataSet ds
                ds.Tables.Add(dt05);
            }
            catch (Exception ex) { 
                messages = "Error: " + ex.Message.ToString();
            }
            return ds;
        }

        

        /// <summary>
        /// Get List of PointOfSale by IdPlanning
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="idCity"></param>
        /// <param name="idTypeNodeCommercial"></param>
        /// <param name="idNodeCommercial"></param>
        /// <param name="idOficina"></param>
        /// <param name="idMalla"></param>
        /// <param name="idSector"></param>
        /// <returns></returns>
        public DataTable getListPdvPlanning(String idPlanning,
        String idCity, int idTypeNodeCommercial,
        String idNodeCommercial, int idOficina,
        int idMalla, int idSector) {
            DataTable dt =
                dplanning.getListPdvPlanning(idPlanning,
                idCity, idTypeNodeCommercial,
                idNodeCommercial, idOficina,
                idMalla, idSector);
            if (!dplanning.getMessages().Equals(""))
            {
                messages = dplanning.getMessages();
            }
            return dt;
        }

        public DataTable getListPdvPlanningDummy(String idPlanning,
        String idCity, int idTypeNodeCommercial,
        String idNodeCommercial, int idOficina,
        int idMalla, int idSector) {
            // Crear el DataTable
            DataTable dt = new DataTable();
            try
            {
                // Crear las Columnas del DataTable
                dt.Columns.Add("Código", typeof(int));
                dt.Columns.Add("Punto de Venta", typeof(string));
                dt.Columns.Add("Dirección", typeof(string));
                dt.Columns.Add("Región", typeof(string));
                dt.Columns.Add("Zona", typeof(string));

                //Llenar información
                dt.Rows.Add(1, "Rosita S.A.C.", "Direccion 01",
                "Lima Sur", "Sur Chico");
                dt.Rows.Add(2, "Jenny S.A.C.", "Direccion 02",
                "Lima Sur", "Sur Chico");
                dt.Rows.Add(3, "Elizabeth S.A.C.", "Direccion 03",
                "Lima Sur", "Sur Chico");
                dt.Rows.Add(4, "Liliana S.A.C.", "Direccion 04",
                "Lima Sur", "Sur Chico");
                dt.Rows.Add(5, "Maguie S.A.C.", "Direccion 05",
                "Lima Sur", "Sur Chico");
            }
            catch (Exception ex)
            {
                messages = "Ocurrio un Error: "
                    + ex.Message.ToString();
            }
            return dt;
        }

        public DataTable getByIdPlanning(String idBudget)
        {
            
            DataTable dt =
                    dplanning.getByIdPlanning(idBudget);

            if (!dplanning.getMessages().Equals(""))
            {
                messages = dplanning.getMessages();
            }
            return dt;
        }

        public DataTable getByIdPlanningDummy(String idBudget)
        {
            // Crear el DataTable
            DataTable dt = new DataTable();
            try
            {
                // Crear las Columnas del DataTable
                dt.Columns.Add("Planning", typeof(string));
                dt.Columns.Add("status_id", typeof(int));
                dt.Columns.Add("status_name", typeof(string));
                dt.Columns.Add("planning_codchannel", typeof(string));
                dt.Columns.Add("name_country", typeof(string));
                dt.Columns.Add("channel_name", typeof(string));
                dt.Columns.Add("company_id", typeof(int));
                dt.Columns.Add("planning_startactivity", typeof(DateTime));
                dt.Columns.Add("planning_endactivity", typeof(DateTime));

                //Llenar información
                dt.Rows.Add("0001", 1, "Habilitado",
                "1000", "Peru", "Mayoristas", "1560", DateTime.Now,
                DateTime.Now);
            }
            catch (Exception ex)
            {
                messages = "Ocurrio un Error: "
                    + ex.Message.ToString();
            }
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPointOfSalePlanningOper"></param>
        /// <param name="idPerson"></param>
        /// <param name="idPlanning"></param>
        /// <returns></returns>
        public DataTable getDuplicateRutas(String idPointOfSalePlanningOper,
        String idPerson, String idPlanning) {
            DataTable dt = dplanning.getDuplicateRutas(
                idPointOfSalePlanningOper, 
                idPerson, 
                idPlanning);

            if (!dplanning.getMessages().Equals(""))
            {
                messages = dplanning.getMessages();
            }
            return dt;
        }
    }
}
