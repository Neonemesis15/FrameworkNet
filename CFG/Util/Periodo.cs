using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data;
using System.Data;
using System.Configuration;

namespace Lucky.CFG.Util
{
    public class Periodo 
    {
        Conexion oCoon = new Conexion();
        public Periodo()
        {
        }
        private string oficina;
        private string categoria;
        private string sub_categoria;
        private string marca;
        private string sub_marca;
        private string sku;
        private string puntoDeventa;
        private string canal;       
        
        public Periodo(int reportid, string oficina, string categoria, string sub_categoria, string marca, string sub_marca, string sku, string puntoDeventa, string canal, int cliente, int servicio)
        {
            this.reportid = reportid;
            this.oficina = oficina;
            this.categoria = categoria;
            this.sub_categoria = sub_categoria;
            this.marca = marca;
            this.sub_marca = sub_marca;
            this.sku = sku;
            this.puntoDeventa = puntoDeventa;
            this.canal = canal;
            this.cliente = cliente;
            this.servicio = servicio;
        }

        //nuevo constructor no solicita el parámetro de puntoDeventa. Angel Ortiz - 13/12/2011
        public Periodo(int reportid, string oficina, string categoria, string sub_categoria, string marca, string sub_marca, string sku, string canal, int cliente, int servicio)
        {
            this.reportid = reportid;
            this.oficina = oficina;
            this.categoria = categoria;
            this.sub_categoria = sub_categoria;
            this.marca = marca;
            this.sub_marca = sub_marca;
            this.sku = sku;
            this.canal = canal;
            this.cliente = cliente;
            this.servicio = servicio;
        }
        /// <summary>
        /// Metodo para parametros de Precios es AASS ing. Carlos Hernández R. 30/03/2011
        /// </summary>

        public Periodo(int reportid, int icadena, string categoria, int inegocio, string canal, int cliente, int servicio)
        {
            this.reportid = reportid;

            this.categoria = categoria;
            this.icadena = icadena;
            this.inegocio = inegocio;
            this.canal = canal;
            this.cliente = cliente;
            this.servicio = servicio;
        }

        /// <summary>
        /// Metodo para parametros de Precios es AASS ing. Carlos Hernández R. 30/03/2011
        /// </summary>

        public Periodo(int reportid, int icadena, string categoria, string canal, int cliente, int servicio)
        {
            this.reportid = reportid;

            this.categoria = categoria;
            this.icadena = icadena;
            this.canal = canal;
            this.cliente = cliente;
            this.servicio = servicio;
        }
        public Periodo(int reportid, string oficina, string categoria, string marca, string familia, string canal, int cliente, int servicio)//report Stock
        {
            this.reportid = reportid;
            this.oficina = oficina;
            this.categoria = categoria;
            this.marca = marca;
            this.familia = familia;
            this.canal = canal;
            this.cliente = cliente;
            this.servicio = servicio;
        }

        public Periodo(int flag, int reportid, string oficina, string categoria, string marca, string puntoDeventa, string canal, int cliente, int servicio)//para sod
        {
            this.reportid = reportid;
            this.oficina = oficina;
            this.categoria = categoria;
            this.marca = marca;
            this.puntoDeventa = puntoDeventa;
            this.canal = canal;
            this.cliente = cliente;
            this.servicio = servicio;
        }

        public string Canal
        {
            get { return canal; }
            set { canal = value; }
        }
        private int cliente;

        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private int servicio;

        public int Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }
        private int reportid;

        public int Reportid
        {
            get { return reportid; }
            set { reportid = value; }
        }
        private String año;

        public String Año
        {
            get { return año; }
            set { año = value; }
        }
        private String mes;

        public String Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        private String periodo;

        public String PeriodoId
        {
            get { return periodo; }
            set { periodo = value; }
        }
        private string familia;
        public string Familia
        {
            get { return familia; }
            set { familia = value; }
        }

        private bool validacion;
        public bool Validacion
        {
            get { return validacion; }
            set { validacion = value; }
        }

        private string perfil;

        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        /// <summary>
        /// Agregado por: Ing. Carlos Hernandez 30/03/2011
        /// </summary>
        private int icadena;
        public int  Icadena
        {
            get { return icadena; }
            set { icadena = value; }
        }

        /// <summary>
        /// Agregado por: Ing. Carlos Hernandez 30/03/2011
        /// </summary>
        private int inegocio;
        public int Inegocio
        {
            get { return inegocio; }
            set { inegocio = value; }
        }

        //Add 27/12/2011
        private String dia;
        public String Dia {
            get { return dia; }
            set { dia = value; }
        }
       
        public void Set_PeriodoConDataValidada()
        {
            try
            {
                Mes = DateTime.Now.Month.ToString();
                if (Mes.Length == 1)
                    Mes = "0" + Mes;
                Año = DateTime.Now.Year.ToString();

                DataTable dtPeriodo = null;
                dtPeriodo = oCoon.ejecutarDataTable("UP_WEBXPLORA_PLA_OBTENER_REPORTPLANNING_BY_REPORTID_AND_ANO_MES",Canal, Reportid, Año, Mes);

                int NumPeriodo = dtPeriodo.Rows.Count;

                if (dtPeriodo.Rows.Count > 0)
                {
                    Año = dtPeriodo.Rows[0]["id_Year"].ToString();
                    Mes = dtPeriodo.Rows[0]["id_Month"].ToString();
                    for (int i = 0; i < dtPeriodo.Rows.Count; i++)
                    {
                        DateTime datedesde = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerDesde"]);
                        DateTime datehasta = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerHasta"]);

                        if ((DateTime.Now >= datedesde) && (DateTime.Now <= datehasta))
                        {
                            PeriodoId = dtPeriodo.Rows[i]["periodo"].ToString();
                        }
                    }

                }
                else
                {
                    PeriodoId = "0";
                }
                if (PeriodoId == null)
                {
                    PeriodoId = dtPeriodo.Rows.Count.ToString();
                }

                DataTable dtConsulta = DataTableReport();

                int contador = 0;
                const int max = 25;
                while (dtConsulta.Rows.Count == 0 && contador<max)
                {
                    if (Mes == "01")
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = (Convert.ToInt32(Año) - 1).ToString();
                            Mes = "12";
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = (Convert.ToInt32(PeriodoId) - 1).ToString();
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = Año;
                            Mes = (Convert.ToInt32(Mes) - 1).ToString();
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                        }
                        else if(Convert.ToInt32(PeriodoId) ==0)
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = "0";
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = (Convert.ToInt32(PeriodoId) - 1).ToString();
                        }
                    }

                    if (Mes.Length == 1)
                        Mes = "0" + Mes;
                    dtConsulta = DataTableReport();
                    contador=contador+1;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void Set_PeriodoConDataValidada_New()
        {
            try
            {
                Mes = DateTime.Now.Month.ToString();
                if (Mes.Length == 1)
                    Mes = "0" + Mes;
                Año = DateTime.Now.Year.ToString();

                DataTable dtPeriodo = null;
                dtPeriodo = oCoon.ejecutarDataTable("UP_WEBXPLORA_PLA_OBTENER_REPORTPLANNING_BY_REPORTID_AND_ANO_MES_NEW", Canal, Reportid, Año, Mes);

                int NumPeriodo = dtPeriodo.Rows.Count;

                Año = dtPeriodo.Rows[0]["id_Year"].ToString();
                Mes = dtPeriodo.Rows[0]["id_Month"].ToString();
                for (int i = 0; i < dtPeriodo.Rows.Count; i++)
                {
                    DateTime datedesde = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerDesde"]);
                    DateTime datehasta = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerHasta"]);

                    if ((DateTime.Now >= datedesde) && (DateTime.Now <= datehasta))
                    {
                        PeriodoId = dtPeriodo.Rows[i]["periodo"].ToString();
                        break;
                    }
                }

                if (PeriodoId == null)
                {
                    //PeriodoId = dtPeriodo.Rows.Count.ToString();
                    for (int i = 0; i < dtPeriodo.Rows.Count; i++)
                    {
                        DateTime datehasta = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerHasta"]);
                        //DateTime datedesde = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerDesde"]);

                        if ((DateTime.Now > datehasta))
                        {
                            PeriodoId = dtPeriodo.Rows[i]["periodo"].ToString();
                            Año = dtPeriodo.Rows[i]["id_Year"].ToString();
                            Mes = dtPeriodo.Rows[i]["id_Month"].ToString();
                            break;
                        }
                    }
                }

                DataTable dtConsulta = DataTableReport();

                int contador = 0;
                const int max = 25;
                while (dtConsulta.Rows.Count == 0 && contador < max)
                {
                    if (Mes == "01")
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = (Convert.ToInt32(Año) - 1).ToString();
                            Mes = "12";
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = (Convert.ToInt32(PeriodoId) - 1).ToString();
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = Año;
                            Mes = (Convert.ToInt32(Mes) - 1).ToString();
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = (Convert.ToInt32(PeriodoId) - 1).ToString();
                        }
                    }

                    if (Mes.Length == 1)
                        Mes = "0" + Mes;
                    dtConsulta = DataTableReport();
                    contador = contador + 1;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }


        public void Set_PeriodoConDataValidada_SF_AAVV()
        {
            try
            {
                Mes = DateTime.Now.Month.ToString();
                if (Mes.Length == 1)
                    Mes = "0" + Mes;
                Año = DateTime.Now.Year.ToString();
                //Add 27/12/2011
                Dia = DateTime.Now.Day.ToString();

                DataTable dtPeriodo = null;
                dtPeriodo = oCoon.ejecutarDataTable("UP_WEBXPLORA_PLA_OBTENER_REPORTPLANNING_BY_REPORTID_AND_ANO_MES_NEW", Canal, Reportid, Año, Mes);

                int NumPeriodo = dtPeriodo.Rows.Count;

                Año = dtPeriodo.Rows[0]["id_Year"].ToString();
                Mes = dtPeriodo.Rows[0]["id_Month"].ToString();
                for (int i = 0; i < dtPeriodo.Rows.Count; i++)
                {
                    DateTime datedesde = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerDesde"]);
                    DateTime datehasta = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerHasta"]);

                    if ((DateTime.Now >= datedesde) && (DateTime.Now <= datehasta))
                    {
                        PeriodoId = dtPeriodo.Rows[i]["periodo"].ToString();

                    }
                }

                if (PeriodoId == null)
                {
                    //PeriodoId = dtPeriodo.Rows.Count.ToString();
                    for (int i = 0; i < dtPeriodo.Rows.Count; i++)
                    {
                        DateTime datehasta = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerHasta"]);
                        //DateTime datedesde = Convert.ToDateTime(dtPeriodo.Rows[i]["ReportsPlanning_RecogerDesde"]);

                        if ((DateTime.Now > datehasta))
                        {
                            PeriodoId = dtPeriodo.Rows[i]["periodo"].ToString();
                            Año = dtPeriodo.Rows[i]["id_Year"].ToString();
                            Mes = dtPeriodo.Rows[i]["id_Month"].ToString();
                            break;
                        }
                    }
                }

                DataTable dtConsulta = DataTableReport();

                int contador = 0;
                const int max = 25;
                while (dtConsulta.Rows.Count == 0 && contador < max)
                {
                    if (Mes == "01")
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = (Convert.ToInt32(Año) - 1).ToString();
                            Mes = "12";
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = (Convert.ToInt32(PeriodoId) - 1).ToString();
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = Año;
                            Mes = (Convert.ToInt32(Mes) - 1).ToString();
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = (Convert.ToInt32(PeriodoId) - 1).ToString();
                        }
                    }

                    if (Mes.Length == 1)
                        Mes = "0" + Mes;
                    dtConsulta = DataTableReport();
                    contador = contador + 1;
                }



                DataTable dtConsulta2 = DataTableReport_2();
                //hacer dos dtConsulta 1.- para consultar el periodo y otra para consulta el dia
                // consulta para el periodo con data
                int contador_dia = 0;
                const int max_dia = 30;
                while (dtConsulta2.Rows.Count == 0 && contador_dia < max_dia)
                {
                    

                    if (Mes == "01")
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = (Convert.ToInt32(Año) - 1).ToString();
                            Mes = "12";
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                            Dia = (Convert.ToInt32(Dia) - 1).ToString();
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = PeriodoId;
                            Dia = (Convert.ToInt32(Dia) - 1).ToString();
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(PeriodoId) == 1)
                        {
                            Año = Año;
                            Mes = (Convert.ToInt32(Mes) - 1).ToString();
                            PeriodoId = dtPeriodo.Rows.Count.ToString();
                            Dia = (Convert.ToInt32(Dia) - 1).ToString();
                        }
                        else
                        {
                            Año = Año;
                            Mes = Mes;
                            PeriodoId = PeriodoId;
                            Dia = (Convert.ToInt32(Dia) - 1).ToString();
                        }
                    }

                    if (Mes.Length == 1)
                        Mes = "0" + Mes;
                    dtConsulta2 = DataTableReport_2();
                    contador = contador + 1;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        //Add 27/12/2011
        // Determinar el dia con Data, solo para AAVV
        private DataTable DataTableReport_2() {
            try {
                DataTable dtReport = null;
                switch (Reportid) { 
                    case 19:
                            if (Canal == "1025")
                            {
                                dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_SF_PRECIO_AAVV_ZONA", Canal, Servicio.ToString(), Cliente.ToString(), Año, Mes, Dia, PeriodoId);
                            }
                            break;
                
                 case 57:
                        if (Canal == "1025") {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_SF_INCIDENCIAS_TOTALES_AAVV",Cliente.ToString(),Canal,Servicio.ToString(),57,Año,Mes,Dia,PeriodoId);
                        }
                        break;
                case 28:
             
                    if (Canal == "1025") {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_SF_VENTAS_ZONA_AAVV",Canal,Servicio.ToString(),"9463",Año,Mes,Dia,PeriodoId);
                        }
                        break;
                }
                        return dtReport;
            }
            catch (Exception ex) {
                ex.Message.ToString();
                return null;
            }
        }


        private DataTable DataTableReport()
        {
            try
            {
                DataTable dtReport = null;
                switch (Reportid)
                {
                    //Reporte de Incidencias - AAVV
                    //Add 27/12/2011
                    case 57:
                        if (Canal == "1025") {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_SF_INCIDENCIAS_TOTALES_AAVV", Cliente.ToString(), Canal, Servicio.ToString(), 57, Año, Mes, 0, PeriodoId);
                        }
                        break;
                    //Reporte de Precios
                    case 19:
                        if (Canal == "1000")
                        {
                            //dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIEN_V2_PRECIOS_REPORTE_Alicorpnew2", Año, Mes, PeriodoId, oficina, categoria, sub_categoria, marca, sub_marca, sku, puntoDeventa, Cliente, Servicio, Canal); Nueva Consulta dirigida a la tabla CUBE - Angel Ortiz - 01/12/2011
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIEN_V2_PRECIOS_REPORTE_Cube_Panel", Año, Mes, PeriodoId, oficina, categoria, sub_categoria, marca, sub_marca, sku, Cliente, Servicio, Canal);
                        }
                        else if (Canal == "1241")
                        {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_ALICORP_PRECIOS_AASS",Cliente, Servicio, Canal, Año,Icadena, categoria,Mes,PeriodoId,Inegocio);
                        }
                        else if (Canal == "1003") {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_PRECIO_SF_MODERNO", Cliente.ToString(), Servicio.ToString(), Canal, 0, oficina, 0, 0, categoria, marca, Familia, 0, 0, 0, Año, Mes, PeriodoId);
                        }
                        //Add 27/12/2011
                        else if (Canal == "1025") {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_SF_PRECIO_AAVV_ZONA",Canal,Servicio.ToString(),Cliente.ToString(),Año,Mes,0,PeriodoId);
                        }
                        break;
                        //Reporte de Stock
                    case 28:
                        if (Canal == "1000")
                        {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_STOCK_REPORTE_Cube", Cliente.ToString(), Servicio.ToString(), Canal, oficina, categoria, marca, Familia, Año, Mes, PeriodoId);
                        }
                        else if (Canal == "1003")
                        {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_CONSULTA_STOCK_INGRESOS_SF_MODERNO_DESCANSO", Cliente.ToString(), Servicio.ToString(), Canal, 0, oficina, 0, 0, categoria, marca, Familia, 0, 0, 0, Año, Mes, PeriodoId);
                        }
                        //Add 27/12/2011 - Reporte de Ventas
                        else if (Canal == "1025") {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_SF_VENTAS_ZONA_AAVV", Canal, Servicio.ToString(), "9463", Año, Mes, 0, PeriodoId);
                        }
                        break;
                    case 21:
                        dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_REPORTE_EVOLUCION_SOD_POR_OFICINA", Servicio, Canal, Cliente, Año, Mes, oficina, puntoDeventa, categoria, marca, 0);
                        break;
                        //Reporte de Competencia
                    case 25:
                        if (Canal == "1000")
                        {
                        dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_REPORTE_COMPETENCIA", Cliente, Canal, "0", Año, Mes, "0", "0");
                        }
                        else if (Canal == "1003")
                        {
                        dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_COMPETENCIA_SF_MODERNO", Cliente.ToString(), Servicio.ToString(), Canal, 0, oficina, 0, 0, categoria, marca, 0 , 0 , 0, Año, Mes, PeriodoId);
                        }
                        break;

                    case 63:
                        dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_REPORTE_CUMPLIMIENTO_LAYOUT",Servicio,Canal,Cliente, Año, Mes, "0", "0");
                        break;

                    //Reporte de Impulso
                    case 51:
                        if (Canal == "1003")
                        {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_IMPULSO_SF_M", Cliente.ToString(), Servicio.ToString(), Canal, 0, oficina, 0, 0, categoria, marca, Familia, 0, 0, 0, Año, Mes, PeriodoId);
                        }
                        break;
                    //reporte de presencia
                    case 58:
                        if (canal == "1000" && Cliente == 1561)
                        {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_REPORTE_COLGATE_OBTENER_PERIODO_ANALISTA", Servicio.ToString(), Canal, Cliente.ToString(), Año, Mes, PeriodoId);

                            Año = dtReport.Rows[0]["id_Year"].ToString();
                            Mes = dtReport.Rows[0]["id_Month"].ToString();
                            PeriodoId = dtReport.Rows[0]["ReportsPlanning_Periodo"].ToString();
                        }
                        if (canal == "1023" && Cliente == 1561)
                        {
                            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_REPORTE_COLGATE_OBTENER_PERIODO_ANALISTA", Servicio.ToString(), Canal, Cliente.ToString(), Año, Mes, PeriodoId);

                            Año = dtReport.Rows[0]["id_Year"].ToString();
                            Mes = dtReport.Rows[0]["id_Month"].ToString();
                            PeriodoId = dtReport.Rows[0]["ReportsPlanning_Periodo"].ToString();
                        }
                        break;
                }
                return dtReport;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        public void SetPeriodoInicial_Presencia()
        {
            DataTable dtReport;

            if (Perfil == ConfigurationManager.AppSettings["PerfilAnalista"])
                Validacion = false;
            else
                Validacion = true;

            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_REPORTE_COLGATE_PRESENCIA_OBTENER_PERIODO_ANALISTA_CLIENTE", Servicio.ToString(), Canal, Cliente.ToString(), Validacion);

            Año = dtReport.Rows[0]["año"].ToString();
            Mes = dtReport.Rows[0]["mes"].ToString();
            PeriodoId = dtReport.Rows[0]["periodo"].ToString();
        }
        public void SetPeriodoInicial_SOD()
        {
            DataTable dtReport;

            dtReport = oCoon.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_REPORTE_SOD_OBTENER_PERIODO_ANALISTA", Servicio.ToString(), Canal, Cliente.ToString());

            Año = dtReport.Rows[0]["año"].ToString();
            Mes = dtReport.Rows[0]["mes"].ToString();
        
        }
        /// <summary>
        /// Devuelve un vector con dos valores el primero el primero el dia de inicio del periodo y el segundo valor el dia fin del periodo.
        /// </summary>
        /// <returns></returns>
        public int[] determinarPeriodo(int numPeriodo, int periodo)
        {
            int[] vec = new int[2];
            switch (numPeriodo)
            {
                case 1:

                    vec[0] = 1;
                    vec[1] = 31;
                    break;

                case 2:

                    if (periodo == 1)
                    {
                        vec[0] = 1;
                        vec[1] = 15;

                    }
                    else
                    {
                        vec[0] = 16;
                        vec[1] = 31;
                    }

                    break;

                case 3:

                    if (periodo == 1)
                    {
                        vec[0] = 1;
                        vec[1] = 10;

                    }
                    else if (periodo == 2)
                    {
                        vec[0] = 11;
                        vec[1] = 20;
                    }
                    else
                    {
                        vec[0] = 21;
                        vec[1] = 31;
                    }
                    break;

                case 4:

                    if (periodo == 1)
                    {
                        vec[0] = 1;
                        vec[1] = 8;

                    }
                    else if (periodo == 2)
                    {
                        vec[0] = 9;
                        vec[1] = 16;
                    }
                    else if (periodo == 3)
                    {
                        vec[0] = 17;
                        vec[1] = 24;
                    }
                    else
                    {
                        vec[0] = 25;
                        vec[1] = 31;
                    }
                    break;

                case 5:

                    if (periodo == 1)
                    {
                        vec[0] = 1;
                        vec[1] = 6;

                    }
                    else if (periodo == 2)
                    {
                        vec[0] = 7;
                        vec[1] = 12;
                    }
                    else if (periodo == 3)
                    {
                        vec[0] = 13;
                        vec[1] = 18;
                    }
                    else if (periodo == 4)
                    {
                        vec[0] = 19;
                        vec[1] = 24;
                    }
                    else
                    {
                        vec[0] = 25;
                        vec[1] = 31;
                    }
                    break;
                default:

                    if (periodo == 1)
                    {
                        vec[0] = 1;
                        vec[1] = 5;

                    }
                    else if (periodo == 2)
                    {
                        vec[0] = 6;
                        vec[1] = 10;
                    }
                    else if (periodo == 3)
                    {
                        vec[0] = 11;
                        vec[1] = 15;
                    }
                    else if (periodo == 4)
                    {
                        vec[0] = 16;
                        vec[1] = 20;
                    }
                    else if (periodo == 5)
                    {
                        vec[0] = 21;
                        vec[1] = 25;
                    }
                    else
                    {
                        vec[0] = 26;
                        vec[1] = 31;
                    }
                    break;
            }
            return vec;
        }
    }
}
