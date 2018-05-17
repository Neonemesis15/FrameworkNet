using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Servicio;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Servicio
{
    public class D_GES_ReportesCliente
    {
        private Conexion oConexion;

        public D_GES_ReportesCliente()
        {
            oConexion = new Conexion(1);
        }

        public E_ReporteCliente_Stock_Validacion ObtenerStockDG_Validacion(string anio ,string mes, int periodo,int codOficina,string codCategoria)
        {
            E_ReporteCliente_Stock_Validacion oE_ReporteCliente_Stock_Validacion = null;

            double sumStockFinal = 0;
            double sumPromVentas = 0;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_REPORTS_V2_OBTENER_DIASGIRO_VALIDACION", anio,mes,periodo,codOficina,codCategoria);

                if (dt.Rows.Count > 0)
                {
                    oE_ReporteCliente_Stock_Validacion = new E_ReporteCliente_Stock_Validacion();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_ReporteCliente_Stock_Validacion_Detalle oE_ReporteCliente_Stock_Validacion_Detalle = new E_ReporteCliente_Stock_Validacion_Detalle();

                        oE_ReporteCliente_Stock_Validacion_Detalle.codPdv = dt.Rows[i]["ClientPDV_code"].ToString();
                        oE_ReporteCliente_Stock_Validacion_Detalle.nombrePdv = dt.Rows[i]["pdv_Name"].ToString();
                        oE_ReporteCliente_Stock_Validacion_Detalle.diasGiro = dt.Rows[i]["DiasGiro"].ToString();
                        oE_ReporteCliente_Stock_Validacion_Detalle.validacion = dt.Rows[i]["Validado"].ToString();

                        sumStockFinal += Convert.ToDouble(dt.Rows[i]["Stock_Final"]) ;
                        sumPromVentas += Convert.ToDouble(dt.Rows[i]["SellOut"]) / Convert.ToDouble(dt.Rows[i]["Rango_Dias"]);

                        oE_ReporteCliente_Stock_Validacion.oListReporteCliente_Stock_Validacion_Detalle.Add(oE_ReporteCliente_Stock_Validacion_Detalle);
                    }
                }
                oE_ReporteCliente_Stock_Validacion.totalDiasGiro =Math.Round(sumStockFinal/sumPromVentas,0);

                return oE_ReporteCliente_Stock_Validacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ValidarStockDiasGiro(string anio, string mes, int periodo, string codPdv, string codCategoria, bool validado, string user)
        {
            try
            {
                oConexion.ejecutarDataTable("SP_GES_REPORTS_V2_VALIDAR_DIASGIRO_STOCK", anio, mes, periodo, codPdv, codCategoria, validado, user);

                return "Actulizó con exito";

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Por: Ditmar Estrada Bernuy , 12/11/2012
        #region Obtener las Oficinas por canal,compañia y codigo de Persona
        public List<E_Oficina> Obtener_OficinasPorCodPersonaAndCanalAndCompania(int CodPersona,string CodCanal,int CodCompania)
        {
            try{
                SqlDataReader reader = oConexion.ejecutarDataReader("SP_GES_REPORTS_V2_OBTENER_OFICINAS_POR_CODPERSONA_AND_CANAL_AND_CLIENTE", CodPersona, CodCanal, CodCompania);
                List<E_Oficina> Oficinas = new List<E_Oficina>();
                while (reader.Read())
                {
                    E_Oficina Oficina = new E_Oficina();
                    Oficina.Cod_Oficina = (long)reader.GetValue(reader.GetOrdinal("cod_Oficina"));
                    Oficina.Name_Oficina = reader.GetValue(reader.GetOrdinal("Name_Oficina")).ToString();
                    Oficinas.Add(Oficina);
                }
                reader.Close();
                return Oficinas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Cliente CocaCola
        //public E_InformesCanje ObtenerInformesCanje() {
        //    try
        //    {
                ////2-Resultados de la Evolucion de Implementacion
                ////3-Status de las Mermas
                ////4.-Material de Implementacion
                ////5.-Cantidad Bodegas Implementadas según Frecuencia
                //E_InformesCanje oE_InformesCanje = new E_InformesCanje();
                ////Informe 1  
                //oE_InformesCanje.getCharColumn3DStacked = oListCharColumn3DStacked;
                ////Informe 2
                //oE_InformesCanje.getDatosPorVisita = oListGetDatosPorVisita;
                //oE_InformesCanje.getDatosPorAcumulado = oListGetDatosPorAcumulado;
                ////Informe 3
                //oE_InformesCanje.getDatosPorMerma = oListGetDatosPorMerma;
                ////Informe 4
                //oE_InformesCanje.getDatosMatImpl = oListGetDatosMatImpl;
                ////Informe 5
                //oE_InformesCanje.getDatosBodeImplFrec = oListGetDatosBodeImplFrec;
                //return oE_InformesCanje;

        //    }
        //    catch (Exception ex) {
        //        throw ex;
        //    }
        //}

        #region Analisis de Implementacion
        public List<GetDatosTotalImplementadoObjetivos> getDatosTotalImplementadoObjetivos(string opcion) {
            try {
                //1-Objetivos de Implementacion
                List<GetDatosTotalImplementadoObjetivos> oListGetDatosTotalImplementadoObjetivos = new List<GetDatosTotalImplementadoObjetivos>();
                #region 1 - Objetivos de Implementacion
                SqlDataReader readerSin_5 = oConexion.ejecutarDataReader("up_ges_cam_Coca_implementacion_objetivo_periodo",opcion);
                while (readerSin_5.Read())
                {
                    GetDatosTotalImplementadoObjetivos oGetDatosTotalImplementadoObjetivos = new GetDatosTotalImplementadoObjetivos();
                    oGetDatosTotalImplementadoObjetivos.nombre = readerSin_5.GetValue(readerSin_5.GetOrdinal("nombre")).ToString();
                    //oGetDatosTotalImplementadoObjetivos.porcentaje = double.Parse(readerSin_5.GetValue(readerSin_5.GetOrdinal("porcentaje")).ToString());
                    oGetDatosTotalImplementadoObjetivos.valor = int.Parse(readerSin_5.GetValue(readerSin_5.GetOrdinal("cant_pdv")).ToString());
                    oGetDatosTotalImplementadoObjetivos.PorcentajeEfectividad = double.Parse(readerSin_5.GetValue(readerSin_5.GetOrdinal("porcentaje")).ToString());
                    oGetDatosTotalImplementadoObjetivos.fecha = readerSin_5.GetValue(readerSin_5.GetOrdinal("fecha")).ToString();//Add 17/10/2012 pSalas
                    oListGetDatosTotalImplementadoObjetivos.Add(oGetDatosTotalImplementadoObjetivos);
                }
                readerSin_5.Close();
                return oListGetDatosTotalImplementadoObjetivos;
                #endregion
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        //Add 15/10/2012 psa. Obtener los Puntos de Venta Implementados y No Implementados, la fase(Implementado o no Implementado) y coordenadas.
        public List<GetDatosDetalleImplementacionObjetivo> getDatosDetalleImplementacionObjetivo(string opcion) {
            try {
                List<GetDatosDetalleImplementacionObjetivo> oListGetDatosDetalleImplementacionObjetivo = new List<GetDatosDetalleImplementacionObjetivo>();
                SqlDataReader readerSin = oConexion.ejecutarDataReader("up_ges_cam_Coca_GetDatosDetalleImplementacionObjetivo",opcion);
                while (readerSin.Read()) {
                    GetDatosDetalleImplementacionObjetivo oGetDatosDetalleImplementacionObjetivo = new GetDatosDetalleImplementacionObjetivo();
                    oGetDatosDetalleImplementacionObjetivo.codPDV = readerSin.GetValue(readerSin.GetOrdinal("pdv_codigo")).ToString();
                    oGetDatosDetalleImplementacionObjetivo.fase_pdv = readerSin.GetValue(readerSin.GetOrdinal("pdv_fase")).ToString();
                    oGetDatosDetalleImplementacionObjetivo.info_pdv = readerSin.GetValue(readerSin.GetOrdinal("pdv_informacion")).ToString();
                    oGetDatosDetalleImplementacionObjetivo.latitud = double.Parse(readerSin.GetValue(readerSin.GetOrdinal("pdv_latitud")).ToString());
                    oGetDatosDetalleImplementacionObjetivo.longitud = double.Parse(readerSin.GetValue(readerSin.GetOrdinal("pdv_longitud")).ToString());
                    oGetDatosDetalleImplementacionObjetivo.nombre_pdv = readerSin.GetValue(readerSin.GetOrdinal("pdv_nombre")).ToString();
                    oGetDatosDetalleImplementacionObjetivo.pie_pdv = readerSin.GetValue(readerSin.GetOrdinal("pdv_pie")).ToString();
                    oGetDatosDetalleImplementacionObjetivo.url_imagen_pdv = readerSin.GetValue(readerSin.GetOrdinal("pdv_urlImage")).ToString();
                    oListGetDatosDetalleImplementacionObjetivo.Add(oGetDatosDetalleImplementacionObjetivo);
                }
                readerSin.Close();
                return oListGetDatosDetalleImplementacionObjetivo;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public List<CharColumn3DStacked> getCharColumn3DStacked() {
            try {
                //1-Objetivos de Implementacion
                List<CharColumn3DStacked> oListCharColumn3DStacked = new List<CharColumn3DStacked>();

                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_ImplementaVsObjetivo");
                while (readerSinc.Read())
                {
                    CharColumn3DStacked oCharColumn3DStacked = new CharColumn3DStacked();
                    oCharColumn3DStacked.Visita = readerSinc.GetValue(readerSinc.GetOrdinal("fecha")).ToString();
                    oCharColumn3DStacked.Implementado = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("implementado")).ToString());
                    oCharColumn3DStacked.Objetivo = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("objetivo")).ToString());
                    oListCharColumn3DStacked.Add(oCharColumn3DStacked);
                }
                readerSinc.Close();
                return oListCharColumn3DStacked;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public List<GetDatosPorVisita> getDatosPorVisita() {
            try {
                List<GetDatosPorVisita> oListGetDatosPorVisita = new List<GetDatosPorVisita>();
                #region 2 - Resultados de la Evolucion de Implementacion
                SqlDataReader readerSinc_21 = oConexion.ejecutarDataReader("up_ges_cam_Coca_EvolucionImplementacion_Por_Visita");
                while (readerSinc_21.Read())
                {
                    GetDatosPorVisita oGetDatosPorVisita = new GetDatosPorVisita();
                    oGetDatosPorVisita.Visita = readerSinc_21.GetValue(readerSinc_21.GetOrdinal("fecha")).ToString();
                    oGetDatosPorVisita.Total = int.Parse(readerSinc_21.GetValue(readerSinc_21.GetOrdinal("cantidad")).ToString());
                    oListGetDatosPorVisita.Add(oGetDatosPorVisita);
                }
                readerSinc_21.Close();
                return oListGetDatosPorVisita;
                #endregion
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public List<GetDatosPorAcumulado> getDatosPorAcumulado() {
            try {
                List<GetDatosPorAcumulado> oListGetDatosPorAcumulado = new List<GetDatosPorAcumulado>();
                SqlDataReader readerSinc_22 = oConexion.ejecutarDataReader("up_ges_cam_Coca_Obtener_datos_acumulados");
                while (readerSinc_22.Read())
                {
                    GetDatosPorAcumulado oGetDatosPorAcumulado = new GetDatosPorAcumulado();
                    oGetDatosPorAcumulado.Visita = readerSinc_22.GetValue(readerSinc_22.GetOrdinal("Fecha")).ToString();
                    oGetDatosPorAcumulado.Porcentaje_1 = double.Parse(readerSinc_22.GetValue(readerSinc_22.GetOrdinal("porcentaje_01")).ToString());
                    oGetDatosPorAcumulado.Porcentaje_2 = double.Parse(readerSinc_22.GetValue(readerSinc_22.GetOrdinal("porcentaje_02")).ToString());
                    //oGetDatosPorAcumulado.Porcentaje_3 = double.Parse(readerSinc_22.GetValue(readerSinc_22.GetOrdinal("")).ToString());
                    oListGetDatosPorAcumulado.Add(oGetDatosPorAcumulado);
                }
                readerSinc_22.Close();
                return oListGetDatosPorAcumulado;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        //warning pendiente cambiar store
        public List<GetDatosPorMerma> getDatosPorMerma() {
            try {
                List<GetDatosPorMerma> oListGetDatosPorMerma = new List<GetDatosPorMerma>();
                #region 3 - Status de las Mermas
                SqlDataReader readerSinc_3 = oConexion.ejecutarDataReader("up_ges_cam_Coca_Obtener_datos_acumulados");
                while (readerSinc_3.Read())
                {
                    GetDatosPorMerma oGetDatosPorMerma = new GetDatosPorMerma();
                    oGetDatosPorMerma.TipoMerma = readerSinc_3.GetValue(readerSinc_3.GetOrdinal("Fecha")).ToString();
                    oGetDatosPorMerma.Porcentaje = int.Parse(readerSinc_3.GetValue(readerSinc_3.GetOrdinal("porcentaje_01")).ToString());
                    oGetDatosPorMerma.Total = double.Parse(readerSinc_3.GetValue(readerSinc_3.GetOrdinal("porcentaje_01")).ToString());
                }
                readerSinc_3.Close();
                return oListGetDatosPorMerma;
                #endregion
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public List<GetDatosMatImpl> getDatosMatImpl() {
            try {
                List<GetDatosMatImpl> oListGetDatosMatImpl = new List<GetDatosMatImpl>();
                #region 4 - Material de Implementacion
                SqlDataReader readerSinc_4 = oConexion.ejecutarDataReader("up_ges_cam_Coca_material_implementacion");
                while (readerSinc_4.Read())
                {
                    GetDatosMatImpl oGetDatosMatImpl = new GetDatosMatImpl();
                    oGetDatosMatImpl.Material = readerSinc_4.GetValue(readerSinc_4.GetOrdinal("nom_mat")).ToString();
                    oGetDatosMatImpl.Porcentaje = double.Parse(readerSinc_4.GetValue(readerSinc_4.GetOrdinal("porcentaje")).ToString());
                    oListGetDatosMatImpl.Add(oGetDatosMatImpl);
                }
                readerSinc_4.Close();
                return oListGetDatosMatImpl;
                #endregion
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public List<GetDatosBodeImplFrec> getDatosBodeImplFrec() {
            try {
                List<GetDatosBodeImplFrec> oListGetDatosBodeImplFrec = new List<GetDatosBodeImplFrec>();
                #region 5 - Cantidad de Bodegas Implementadas según Frecuencia
                SqlDataReader readerSinc_6 = oConexion.ejecutarDataReader("up_ges_cam_Coca_implementacion_frecuencia");
                while (readerSinc_6.Read())
                {
                    GetDatosBodeImplFrec oGetDatosBodeImplFrec = new GetDatosBodeImplFrec();
                    oGetDatosBodeImplFrec.Frecuencia = readerSinc_6.GetValue(readerSinc_6.GetOrdinal("id_frecuencia")).ToString();
                    oGetDatosBodeImplFrec.Implementados = int.Parse(readerSinc_6.GetValue(readerSinc_6.GetOrdinal("cant_frecuencia")).ToString());
                    oGetDatosBodeImplFrec.Objetivo = int.Parse(readerSinc_6.GetValue(readerSinc_6.GetOrdinal("cant_obj")).ToString());
                    oGetDatosBodeImplFrec.Porcentaje_Frecuencia = readerSinc_6.GetValue(readerSinc_6.GetOrdinal("porcentaje_frecuencia")).ToString();//Add 18/10/2012 psa.
                    oListGetDatosBodeImplFrec.Add(oGetDatosBodeImplFrec);
                }
                readerSinc_6.Close();
                return oListGetDatosBodeImplFrec;
                #endregion
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        //Add 17/10/2012. psa. descripcion: Obtener Datos del Resumen para Implementacion y Razones de No Implementacion.
        public List<GetDatosPorResumeImp_RazNoImpl> getDatosPorResumeImp_RazNoImpl()
        {
            try
            {
                List<GetDatosPorResumeImp_RazNoImpl> oListGetDatosPorResumeImp_RazNoImpl = new List<GetDatosPorResumeImp_RazNoImpl>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_getDatosPorResumeImp_RazNoImpl");
                while (readerSinc.Read()) {
                    GetDatosPorResumeImp_RazNoImpl oGetDatosPorResumeImp_RazNoImpl = new GetDatosPorResumeImp_RazNoImpl();
                    oGetDatosPorResumeImp_RazNoImpl.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Codigo")).ToString();
                    oGetDatosPorResumeImp_RazNoImpl.Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString();
                    oGetDatosPorResumeImp_RazNoImpl.Valor = readerSinc.GetValue(readerSinc.GetOrdinal("Valor")).ToString();
                    oListGetDatosPorResumeImp_RazNoImpl.Add(oGetDatosPorResumeImp_RazNoImpl);
                }
                readerSinc.Close();
                return oListGetDatosPorResumeImp_RazNoImpl;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        #endregion
        #region Analisis de Stock
        public List<GetDatosPorCantStock> getDatosPorCantStock() {
            try {
                List<GetDatosPorCantStock> getDatosPorCantStock = new List<GetDatosPorCantStock>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_Cantidad_Stock");
                while (readerSinc.Read()) {
                    GetDatosPorCantStock oGetDatosPorCantStock = new GetDatosPorCantStock();
                    oGetDatosPorCantStock.nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString();
                    oGetDatosPorCantStock.valor = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad")).ToString());
                    oGetDatosPorCantStock.porcentaje = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Porcentaje_salida")).ToString());
                    getDatosPorCantStock.Add(oGetDatosPorCantStock);
                }
                readerSinc.Close();
                return getDatosPorCantStock;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public List<GetDatosPorCantTotalPlatosVendidos> getDatosPorCantTotalPlatosVendidos() {
            try {
                List<GetDatosPorCantTotalPlatosVendidos> getDatosPorCantTotalPlatosVendidos = new List<GetDatosPorCantTotalPlatosVendidos>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_Cantidad_Platos_vendidos");
                while (readerSinc.Read()) { 
                GetDatosPorCantTotalPlatosVendidos oGetDatosPorCantTotalPlatosVendidos = new GetDatosPorCantTotalPlatosVendidos();
                oGetDatosPorCantTotalPlatosVendidos.nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString();
                oGetDatosPorCantTotalPlatosVendidos.valor = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad")).ToString());
                oGetDatosPorCantTotalPlatosVendidos.porcentaje = readerSinc.GetValue(readerSinc.GetOrdinal("porcentaje")).ToString();       //Add 16/10/2012 psa.
                oGetDatosPorCantTotalPlatosVendidos.cantidad_pdv = readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad_pdv")).ToString();   //Add 16/10/2012 psa.
                getDatosPorCantTotalPlatosVendidos.Add(oGetDatosPorCantTotalPlatosVendidos);
                }
                readerSinc.Close();
                return getDatosPorCantTotalPlatosVendidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Add 16/10/2012. psa. Descripcion: Mostrar Puntos de Venta Stock de Cantidad de Vendidos Vs Objetivo
        public List<GetDatosPorDetalleStockVenVsObj> getDatosPorDetalleStockVenVsObj() {
            try {
                List<GetDatosPorDetalleStockVenVsObj> getDatosPorDetalleStockVenVsObj = new List<GetDatosPorDetalleStockVenVsObj>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_getDatosPorDetalleStockVenVsObj");
                while (readerSinc.Read()) {
                    GetDatosPorDetalleStockVenVsObj oGetDatosPorDetalleStockVenVsObj = new GetDatosPorDetalleStockVenVsObj();
                    oGetDatosPorDetalleStockVenVsObj.codPDV = readerSinc.GetValue(readerSinc.GetOrdinal("pdv_codigo")).ToString();
                    oGetDatosPorDetalleStockVenVsObj.estadoPlato_pdv = readerSinc.GetValue(readerSinc.GetOrdinal("pdv_estadoPlato")).ToString();
                    oGetDatosPorDetalleStockVenVsObj.info_pdv = readerSinc.GetValue(readerSinc.GetOrdinal("pdv_informacion")).ToString();
                    oGetDatosPorDetalleStockVenVsObj.latitud = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("pdv_latitud")).ToString());
                    oGetDatosPorDetalleStockVenVsObj.longitud = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("pdv_longitud")).ToString());
                    oGetDatosPorDetalleStockVenVsObj.nombre_pdv = readerSinc.GetValue(readerSinc.GetOrdinal("pdv_nombre")).ToString();
                    oGetDatosPorDetalleStockVenVsObj.pie_pdv = readerSinc.GetValue(readerSinc.GetOrdinal("pdv_pie")).ToString();
                    oGetDatosPorDetalleStockVenVsObj.url_imagen_pdv = readerSinc.GetValue(readerSinc.GetOrdinal("pdv_urlImage")).ToString();
                    getDatosPorDetalleStockVenVsObj.Add(oGetDatosPorDetalleStockVenVsObj);
                }
                readerSinc.Close();
                return getDatosPorDetalleStockVenVsObj;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        //Add 05/11/2012 Psa
        public List<GetDatosPorCantStock> getTotAvaPlaIngAlm() {
            try {
                List<GetDatosPorCantStock> getDatosPorCantStock = new List<GetDatosPorCantStock>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_getTotAvaPlaIngAlm");
                while (readerSinc.Read())
                {
                    GetDatosPorCantStock oGetDatosPorCantStock = new GetDatosPorCantStock();
                    oGetDatosPorCantStock.nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString();
                    oGetDatosPorCantStock.valor = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad")).ToString());
                    oGetDatosPorCantStock.porcentaje = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Porcentaje_salida")).ToString());
                    getDatosPorCantStock.Add(oGetDatosPorCantStock);
                }
                readerSinc.Close();
                return getDatosPorCantStock;

            }
            catch (Exception ex) {
                throw ex;
            }
        }
        //Add 05/11/2012 Psa
        public List<GetDatosPorCantStock> getTotPlaDistCDV() {
            try
            {
                List<GetDatosPorCantStock> getDatosPorCantStock = new List<GetDatosPorCantStock>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_getTotPlaDistCDV");
                while (readerSinc.Read())
                {
                    GetDatosPorCantStock oGetDatosPorCantStock = new GetDatosPorCantStock();
                    oGetDatosPorCantStock.nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString();
                    oGetDatosPorCantStock.valor = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad")).ToString());
                    oGetDatosPorCantStock.porcentaje = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Porcentaje_salida")).ToString());
                    getDatosPorCantStock.Add(oGetDatosPorCantStock);
                }
                readerSinc.Close();
                return getDatosPorCantStock;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Add 05/11/2012 Psa
        public List<GetDatosPorCantStock> getAvaPlaObj() {
            try
            {
                List<GetDatosPorCantStock> getDatosPorCantStock = new List<GetDatosPorCantStock>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_getAvaPlaObj");
                while (readerSinc.Read())
                {
                    GetDatosPorCantStock oGetDatosPorCantStock = new GetDatosPorCantStock();
                    oGetDatosPorCantStock.nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString();
                    oGetDatosPorCantStock.valor = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad")).ToString());
                    oGetDatosPorCantStock.porcentaje = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Porcentaje_salida")).ToString());
                    getDatosPorCantStock.Add(oGetDatosPorCantStock);
                }
                readerSinc.Close();
                return getDatosPorCantStock;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region Analisis de Merma
        //warning pendiente cambiar store
        public List<GetDatosPorTipMerma> getDatosPorTipMerma() {
            try {
                List<GetDatosPorTipMerma> getDatosPorTipMerma = new List<GetDatosPorTipMerma>();
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("up_ges_cam_Coca_status_merma");
                while(readerSinc.Read()){
                    GetDatosPorTipMerma oGetDatosPorTipMerma = new GetDatosPorTipMerma();
                    oGetDatosPorTipMerma.TipoMerma = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString();
                    oGetDatosPorTipMerma.valor = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad")).ToString());
                    oGetDatosPorTipMerma.porcentaje = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("porcentaje")).ToString());
                    getDatosPorTipMerma.Add(oGetDatosPorTipMerma);
                }
                readerSinc.Close();
                return getDatosPorTipMerma;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region XploraNew - Grafico
        //public List<>
        #endregion
    }
}
