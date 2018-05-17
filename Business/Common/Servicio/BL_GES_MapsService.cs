using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Entity.Common.Servicio;
using Lucky.Data.Common.Servicio;

namespace Lucky.Business.Common.Servicio
{
    public class BL_GES_MapsService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_GES_MapsService));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_GES_MapsService oD_GES_MapsService = new D_GES_MapsService();
        
        #region XploraMaps - Lima
        public E_Representatividad Obtener_Representatividad(int tipo, string codigo)
        {
            E_Representatividad oE_Representatividad = new E_Representatividad();
            try
            {
                oE_Representatividad = oD_GES_MapsService.Obtener_Representatividad(tipo, codigo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Representatividad_Failed] : ", ex);
            }
            return oE_Representatividad;
        }

        public List<E_PresenciaZonaDistrito> Obtener_Presencia_ZonaDistrito(int servicio, string canal, int codCliente, string coddepartamento, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        {
            List<E_PresenciaZonaDistrito> oListPresencia = new List<E_PresenciaZonaDistrito>();
            try
            {
                oListPresencia = oD_GES_MapsService.Obtener_Presencia_ZonaDistrito(servicio, canal, codCliente, coddepartamento, codciudad, codZona, codDistrito, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Presencia_ZonaDistrito_Failed] : ", ex);
            }
            return oListPresencia;
        }

        public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(int servicio, string canal, int codCliente, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        {
            List<E_ElemVisibilidadZonaDistrito> oListPresencia = new List<E_ElemVisibilidadZonaDistrito>();
            try
            {
                oListPresencia = oD_GES_MapsService.Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(servicio, canal, codCliente, codciudad, codZona, codDistrito, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Presencia_ZonaDistrito_Failed] : ", ex);
            }
            return oListPresencia;
        }
        
        public List<E_VentasZonaDistrito> Obtener_Ventas_ZonaDistrito(int tipo, string codigo, int reportsPlanning)
        {
            List<E_VentasZonaDistrito> oListVentas = new List<E_VentasZonaDistrito>();
            try
            {
                oListVentas = oD_GES_MapsService.Obtener_Ventas_ZonaDistrito(tipo, codigo, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Ventas_ZonaDistrito_Failed] : ", ex);
            }
            return oListVentas;
        }

        public List<E_PuntoVentaMapa> Obtener_PuntosVentaMapa(string equipo, string generador, string reportsPlanning, string codPais, string codDepartamento, string codProvincia, string codSector, string codDistrito)
        {
            List<E_PuntoVentaMapa> oListPuntoVenta = new List<E_PuntoVentaMapa>();
            try
            {
                oListPuntoVenta = oD_GES_MapsService.Obtener_PuntosVentaMapa(equipo, generador, reportsPlanning, codPais, codDepartamento, codProvincia, codSector, codDistrito);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntosVentaMapa_Failed] : ", ex);
            }
            return oListPuntoVenta;
        }

        public List<E_Provincia> Obtener_Provincia_Por_CodDepartamento(string codPais, string codDepartamento)
        {
            List<E_Provincia> oListProvincia = new List<E_Provincia>();
            try
            {
                oListProvincia = oD_GES_MapsService.Obtener_Provincia_Por_CodDepartamento(codPais, codDepartamento);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Provincia_Por_CodDepartamento_Failed] : ", ex);
            }
            return oListProvincia;
        }
        
        public List<E_Sector> Obtener_Sector_Por_PaisDepartamentoProvincia(string codPais, string codDepartamento, string codProvincia)
        {
            List<E_Sector> oListSector = new List<E_Sector>();
            try
            {
                oListSector = oD_GES_MapsService.Obtener_Sector_Por_PaisDepartamentoProvincia(codPais, codDepartamento, codProvincia);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Sector_Por_PaisDepartamentoProvincia_Failed] : ", ex);
            }
            return oListSector;
        }

        public E_PuntoVentaDatosMapa Obtener_DatosPuntosVentaMapa(string codPtoVenta, string reportsPlanning)
        {
            E_PuntoVentaDatosMapa oPtoVenta = new E_PuntoVentaDatosMapa();
            try
            {
                oPtoVenta = oD_GES_MapsService.Obtener_DatosPuntosVentaMapa(codPtoVenta, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_DatosPuntosVentaMapa_Failed] : ", ex);
            }
            return oPtoVenta;
        }

        public List<E_Presencia_PDV> Obtener_Presencia_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        {
            List<E_Presencia_PDV> oListPresenciaPDV = new List<E_Presencia_PDV>();
            try
            {
                oListPresenciaPDV = oD_GES_MapsService.Obtener_Presencia_PuntoVenta(codEquipo, reportsPlanning, codPtoVenta);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Presencia_PuntoVenta_Failed] : ", ex);
            }
            return oListPresenciaPDV;
        }

        public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        {
            List<E_ElemVisibilidad_PDV> oListElemVisibilidadPDV = new List<E_ElemVisibilidad_PDV>();
            try
            {
                oListElemVisibilidadPDV = oD_GES_MapsService.Obtener_ElemVisibilida_PuntoVenta(codEquipo, reportsPlanning, codPtoVenta);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_ElemVisibilida_PuntoVenta_Failed] : ", ex);
            }
            return oListElemVisibilidadPDV;
        }

        public List<E_Ventas_PDV> Obtener_Venta_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        {
            List<E_Ventas_PDV> oListVentaPDV = new List<E_Ventas_PDV>();
            try
            {
                oListVentaPDV = oD_GES_MapsService.Obtener_Venta_PuntoVenta(codEquipo, reportsPlanning, codPtoVenta);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Venta_PuntoVenta_Failed] : ", ex);
            }
            return oListVentaPDV;
        }

        public E_Foto_PDV Obtener_Foto_PuntoVenta(string reportsPlanning, string codPtoVenta)
        {
            E_Foto_PDV oFotoPDV = new E_Foto_PDV();
            try
            {
                oFotoPDV = oD_GES_MapsService.Obtener_Foto_PuntoVenta(reportsPlanning, codPtoVenta);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Foto_PuntoVenta_Failed] : ", ex);
            }
            return oFotoPDV;
        }

        public List<E_HistorialFoto_PDV> Obtener_HistorialFoto_PuntoVenta(string reportsPlanning, string codPtoVenta)
        {
            List<E_HistorialFoto_PDV> oListaFotos = new List<E_HistorialFoto_PDV>();
            try
            {
                oListaFotos = oD_GES_MapsService.Obtener_HistorialFoto_PuntoVenta(reportsPlanning, codPtoVenta);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_HistorialFoto_PuntoVenta_Failed] : ", ex);
            }
            return oListaFotos;
        }

        public List<E_Departamento> Obtener_Departamento_Por_CodPais(string codPais)
        {
            List<E_Departamento> oListDepartamento = new List<E_Departamento>();
            try
            {
                oListDepartamento = oD_GES_MapsService.Obtener_Departamento_Por_CodPais(codPais);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Departamento_Por_CodPais_Failed] : ", ex);
            }
            return oListDepartamento;
        }

        public List<E_Distrito> Obtener_Distrito_Por_CodSector(string codPais, string codDepartamento, string codProvincia, string codSector)
        {
            List<E_Distrito> oListDistrito = new List<E_Distrito>();
            try
            {
                oListDistrito = oD_GES_MapsService.Obtener_Distrito_Por_CodSector(codPais, codDepartamento, codProvincia, codSector);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Distrito_Por_CodSector_Failed] : ", ex);
            }
            return oListDistrito;
        }

        public List<E_PresenciaZonaDistritoMap> Obtener_PresenciaZonaDistritoMap(string codCanal, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codCategoria, string codProducto, string codPeriodo, string opcion)
        {
            List<E_PresenciaZonaDistritoMap> oListPresenciaZonaDistritoMap = new List<E_PresenciaZonaDistritoMap>();
            try
            {
                oListPresenciaZonaDistritoMap = oD_GES_MapsService.Obtener_PresenciaZonaDistritoMap(codCanal, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codPeriodo, opcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PresenciaZonaDistritoMap_Failed] : ", ex);
            }
            return oListPresenciaZonaDistritoMap;
        }

        public E_ClusterZonaDistrito_Group Obtener_ClusterZonaDistritoMap(string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_ClusterZonaDistrito_Group clusterZonaDistritoMap = new E_ClusterZonaDistrito_Group();
            try
            {
                clusterZonaDistritoMap = oD_GES_MapsService.Obtener_ClusterZonaDistritoMap(codZona, codDistrito, idPlanning, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_ClusterZonaDistritoMap_Failed] : ", ex);
            }
            return clusterZonaDistritoMap;
        }

        public List<E_TipoCluster> Obtener_TipoCluster()
        {
            List<E_TipoCluster> ListTipoCluster = new List<E_TipoCluster>();
            try
            {
                ListTipoCluster = oD_GES_MapsService.Obtener_TipoCluster();
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_TipoCluster_Failed] : ", ex);
            }
            return ListTipoCluster;
        }

        public List<E_PuntoVentaCluster> Obtener_PuntoVentaCluster(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string cluster, string codPeriodo)
        {
            List<E_PuntoVentaCluster> oListPuntoVentaCluster = new List<E_PuntoVentaCluster>();
            try
            {
                oListPuntoVentaCluster = oD_GES_MapsService.Obtener_PuntoVentaCluster(codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, cluster, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaCluster_Failed] : ", ex);
            }
            return oListPuntoVentaCluster;
        }

        public List<E_PuntoVentaMapaVentas> Obtener_PuntoVentaMapaVentas(string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codCategoria, string codProducto, string codCluster, string codPlanning, string codPeriodo)
        {
            List<E_PuntoVentaMapaVentas> oListPuntoVentaMapaVentas = new List<E_PuntoVentaMapaVentas>();
            try
            {
                oListPuntoVentaMapaVentas = oD_GES_MapsService.Obtener_PuntoVentaMapaVentas(codPais, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster, codPlanning, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaMapaVentas_Failed] : ", ex);
            }
            return oListPuntoVentaMapaVentas;
        }

        public List<E_PresenciaPDV> Obtener_PuntoVentaPresenciaSKU(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codProducto, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = new List<E_PresenciaPDV>();
            try
            {
                oListPuntoVenta = oD_GES_MapsService.Obtener_PuntoVentaPresenciaSKU(codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaSKU_Failed] : ", ex);
            }
            return oListPuntoVenta;
        }

        public List<E_Grafico_Tendencia> Obtener_Grafico_Tendencia(string codServicio, string codCanal, string codCliente, string codPais,
            string codDepartamento, string codProvincia, string codZona, string codDistrito,
            string codCategoria, string codProducto, string codCluster, string anio, string mes, string codPeriodo, string codOpcion)
        {
            List<E_Grafico_Tendencia> oListGraficoTendencia = new List<E_Grafico_Tendencia>();
            try
            {
                oListGraficoTendencia = oD_GES_MapsService.Obtener_Grafico_Tendencia(codServicio, codCanal, codCliente,
                    codPais, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Grafico_Tendencia_Failed] : ", ex);
            }
            return oListGraficoTendencia;
        }

        public List<E_Grafico_Variacion> Obtener_Grafico_Variacion(string codServicio, string codCanal, string codCliente, string codPais,
            string codDepartamento, string codProvincia, string codZona, string codDistrito,
            string codCategoria, string codProducto, string codCluster, string anio, string mes, string codPeriodo, string codOpcion)
        {
            List<E_Grafico_Variacion> oListGraficoVariacion = new List<E_Grafico_Variacion>();
            try
            {
                oListGraficoVariacion = oD_GES_MapsService.Obtener_Grafico_Variacion(codServicio, codCanal, codCliente,
                    codPais, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Grafico_Variacion_Failed] : ", ex);
            }
            return oListGraficoVariacion;
        }

        /// <summary>
        /// Author      : Pablo Salas A.
        /// Fecha       : 03/09/2012
        /// Descripcion : Obtener Ventas por Sku_Mandatorio Por Distrito / Zona Semanal o Mensual 
        /// </summary>
        /// <returns></returns>
        public E_VentasZonaDistrito_Detalle Obtener_Ventas_ZonaDistrito_Detalle(E_Filtros_XplMap_Colgate oE_Filtros_XplMap_Colgate
            //string codServicio, string codCanal, string codCliente, string codPais,
            //string codDepartamento, string codProvincia, string codDistrito, string codZona,
            //string codCluster, string anio, string mes, string codPeriodo, string codOpcion
            )
        {
            D_GES_MapsService oD_GES_MapsService = new D_GES_MapsService();
            E_VentasZonaDistrito_Detalle oE_VentasZonaDistrito_Detalle = new E_VentasZonaDistrito_Detalle();
            try {
                oE_VentasZonaDistrito_Detalle = oD_GES_MapsService.Obtener_Ventas_ZonaDistrito_Detalle(oE_Filtros_XplMap_Colgate);
                        #region Backup Parametros 03/09/2012 PSA
                        // codServicio,  codCanal,  codCliente,  codPais
                        //,codDepartamento,  codProvincia,  codDistrito,  codZona
                        //,codCluster,  anio,  mes,  codPeriodo,  codOpcion
                        #endregion
            }
            catch (Exception ex) {
                throw ex;
            }
            return oE_VentasZonaDistrito_Detalle;
        }

        public List<E_VentasZonaDistrito_Detalle_List> Obtener_Evolucion_Venta_SKUMandatorios(E_Filtros_XplMap_Colgate oE_Filtros_XplMap_Colgate
            //string codServicio, string codCanal, string codCliente, string codPais,
            //string codDepartamento, string codProvincia, string codDistrito, string codZona,
            //string codCluster, string anio, string mes, string codPeriodo, string codOpcion
            )
        {
            D_GES_MapsService oD_GES_MapsService = new D_GES_MapsService();
            List<E_VentasZonaDistrito_Detalle_List> oE_VentasZonaDistrito_Detalle = new List<E_VentasZonaDistrito_Detalle_List>();
            try
            {
                oE_VentasZonaDistrito_Detalle = oD_GES_MapsService.Obtener_Evolucion_Venta_SKUMandatorios(oE_Filtros_XplMap_Colgate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oE_VentasZonaDistrito_Detalle;
        }
        /// <summary>
        /// Fecha: 05/09/2012
        /// Author: Pablo Salas A.
        /// </summary>
        /// <param name="oE_Filtros_XplMap_Colgate"></param>
        /// <returns></returns>
        public List<E_PresenciaZonaDistrito_Detalle_List> Obtener_Evolucion_Presencia_SKUMandatorios(E_Filtros_XplMap_Colgate oE_Filtros_XplMap_Colgate) {

            D_GES_MapsService oD_GES_MapsService = new D_GES_MapsService();
            List<E_PresenciaZonaDistrito_Detalle_List> oListE_PresenciaZonaDistrito_Detalle_List = new List<E_PresenciaZonaDistrito_Detalle_List>();
            try {
                oListE_PresenciaZonaDistrito_Detalle_List = oD_GES_MapsService.Obtener_Evolucion_Presencia_SKUMandatorios(oE_Filtros_XplMap_Colgate);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oListE_PresenciaZonaDistrito_Detalle_List;
        }

        public E_Representatividad_Group Obtener_Representatividad_Group(string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_Representatividad_Group representatividadZonaDistritoMap = new E_Representatividad_Group();
            try
            {
                representatividadZonaDistritoMap = oD_GES_MapsService.Obtener_Representatividad_Group(codZona, codDistrito, idPlanning, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Representatividad_Group_Failed] : ", ex);
            }
            return representatividadZonaDistritoMap;
        }

        public List<E_PresenciaPDV> Obtener_PuntoVentaPresenciaElemVisibilidad(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = new List<E_PresenciaPDV>();
            try
            {
                oListPuntoVenta = oD_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidad(codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaElemVisibilidad_Failed] : ", ex);
            }
            return oListPuntoVenta;
        }

        public List<E_PresenciaPDV> Obtener_PuntoVentaRango(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = new List<E_PresenciaPDV>();
            try
            {
                oListPuntoVenta = oD_GES_MapsService.Obtener_PuntoVentaRango(codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaRango_Failed] : ", ex);
            }
            return oListPuntoVenta;
        }

        public E_ExportExcel Obtener_PuntoVentaPresenciaRangoToExcel(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_PuntoVentaPresenciaRangoToExcel(codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaRangoToExcel_Failed] : ", ex);
            }
            return oE_ExportExcel;
        }

        public E_ExportExcel Obtener_PuntoVentaPresenciaSKUToExcel(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codProducto, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_PuntoVentaPresenciaSKUToExcel(codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaSKUToExcel_Failed] : ", ex);
            }
            return oE_ExportExcel;
        }

        public E_ExportExcel Obtener_PuntoVentaPresenciaElemVisibilidadToExcel(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidadToExcel(codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Failed] : ", ex);
            }
            return oE_ExportExcel;
        }
        //XploraMaps - Lima
        public E_ExportExcel Obtener_Datos_Tendencia(string codServicio, string codCanal, string codCliente, string codPais,
            string codDpto, string codCity, string codDistrito, string codSector, string codCluster, string codYear,
            string codMes, string codPeriodo, string codOpcion)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_Datos_Tendencia(codServicio, codCanal, codCliente, codPais,
                codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Datos_Tendencia_Failed] : ", ex);
            }
            return oE_ExportExcel;
        }
        //XploraMaps - Provincia
        public E_ExportExcel Obtener_Datos_Tendencia_Prov(string codServicio, string codCanal, string codCliente, string codPais,
string codOficina, string codDpto, string codCity, string codDistrito, string codSector, string codCluster, string codYear,
string codMes, string codPeriodo, string codOpcion)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_Datos_Tendencia_Prov(codServicio, codCanal, codCliente, codPais,
                codOficina, codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Datos_Tendencia_Prov_Failed] : ", ex);
                throw ex;
            }

            return oE_ExportExcel;
        }


        //XploraMaps - Lima
        public E_ExportExcel Obtener_Datos_Variacion(string codServicio, string codCanal, string codCliente, string codPais,
            string codDpto, string codCity, string codDistrito, string codSector, string codCluster, string codYear,
            string codMes, string codPeriodo, string codOpcion)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_Datos_Variacion(codServicio, codCanal, codCliente, codPais,
                codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Datos_Variacion_Failed] : ", ex);
            }
            return oE_ExportExcel;
        }
        //XploraMaps - Provincia
        public E_ExportExcel Obtener_Datos_Variacion_Prov(string codServicio, string codCanal, string codCliente, string codPais,
            string codOficina, string codDpto, string codCity, string codDistrito, string codSector, string codCluster, string codYear,
            string codMes, string codPeriodo, string codOpcion)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_Datos_Variacion_Prov(codServicio, codCanal, codCliente, codPais,
                codOficina, codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Datos_Variacion_Prov_Failed] : ", ex);
                throw ex;

            }

            return oE_ExportExcel;
        }

        public E_Seguimiento_Ruta Obtener_Seguimiento_x_Ruta(string codEquipo, string codPais, string codDepartamento, string codProvincia,
            string codDistrito, string codGestor, string fecha)
        {
            E_Seguimiento_Ruta oE_Seguimiento_Ruta = new E_Seguimiento_Ruta();
            try
            {
                oE_Seguimiento_Ruta = oD_GES_MapsService.Obtener_Seguimiento_x_Ruta(codEquipo, codPais, codDepartamento, codProvincia,
                    codDistrito, codGestor, fecha);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Seguimiento_x_Ruta_Failed] : ", ex);
            }
            return oE_Seguimiento_Ruta;
        }

        #endregion

        #region XploraMaps - Provincia (Ciudad - Distrito)
        #region Sección Universo >>Warning<<

        //1.-Total de PDV’s por ciudad.(considerar periodo).
        public E_ClusterZonaDistrito_Group Obtener_ClusterZonaDistritoMap_Prov(string codOficina, string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_ClusterZonaDistrito_Group clusterZonaDistritoMap = null;
            try
            {
                clusterZonaDistritoMap = oD_GES_MapsService.Obtener_ClusterZonaDistritoMap_Prov(codOficina, codZona, codDistrito, idPlanning, reportsPlanning);
                
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_ClusterZonaDistritoMap_Prov_Failed] : ", ex);
            }
            return clusterZonaDistritoMap;
        }

        //2.-Total de PDV’s visitados por ciudad y a su vez éstos por clúster.(considerar periodo).
        public E_Representatividad_Group Obtener_Representatividad_Group_Prov(string codOficina, string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_Representatividad_Group representatividadZonaDistritoMap = null;
            try
            {
                representatividadZonaDistritoMap = oD_GES_MapsService.Obtener_Representatividad_Group_Prov(codOficina, codZona, codDistrito, idPlanning, reportsPlanning);
                return representatividadZonaDistritoMap;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Representatividad_Group_Prov_Failed] : ", ex);
                throw ex;
            }
        }

        //3.-Total de PDV's  por Cluster
        //Pendiente

        #endregion

        #region Sección - Presencia SKU Mandatorio
        //1.-Porcentaje de Presencia por Rangos.(considerar periodo).
        public List<E_PresenciaZonaDistrito> Obtener_Presencia_ZonaDistrito_Prov(int servicio, string canal, int codCliente, string codOficina, string coddepartamento, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        {
            List<E_PresenciaZonaDistrito> oListPresencia = null;
            try
            {
                oListPresencia = oD_GES_MapsService.Obtener_Presencia_ZonaDistrito_Prov(servicio, canal, codCliente, codOficina, coddepartamento, codciudad, codZona, codDistrito, reportsPlanning);
                
                return oListPresencia;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Presencia_ZonaDistrito_Prov_Failed] : ", ex);
                throw ex;
            }
        }
        public List<E_PuntoVentaCluster> Obtener_PuntoVentaCluster_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string cluster, string codPeriodo)
        {
            List<E_PuntoVentaCluster> oListPuntoVentaCluster = new List<E_PuntoVentaCluster>();
            try
            {
                oListPuntoVentaCluster = oD_GES_MapsService.Obtener_PuntoVentaCluster_Prov(codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, cluster, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaCluster_Failed] : ", ex);
            }
            return oListPuntoVentaCluster;
        }

        //2.-Cantidad PDV’s x SKU Mandatorio.(considerar periodo).
        //Se Reutiliza public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(int servicio, string canal, int codCliente, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        //UP_WEBXPLORA_PRESENCIA_ELEMVISIB_MAPS
        //1.1.-Pintar Mapa por Rangos
        public List<E_PresenciaPDV> Obtener_PuntoVentaRango_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codRango, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = null;
            try
            {
                oListPuntoVenta = oD_GES_MapsService.Obtener_PuntoVentaRango_Prov(codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codRango, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaRango_Prov_Failed] : ", ex);
                throw ex;
            }
            return oListPuntoVenta;
        }
        public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito_Prov(int servicio, string canal, int codCliente, string codOficina, string codDepartamento, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        {
            List<E_ElemVisibilidadZonaDistrito> oListPresencia = null;
            try
            {
                oListPresencia = oD_GES_MapsService.Obtener_Presencia_ElemeVisibilidad_ZonaDistrito_Prov(servicio, canal, codCliente, codOficina, codDepartamento, codciudad, codZona, codDistrito, reportsPlanning);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListPresencia;
        }
        //1.2.-Exportar a Excel por Rangos
        public E_ExportExcel Obtener_PuntoVentaPresenciaRangoToExcel_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codRango, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_PuntoVentaPresenciaRangoToExcel_Prov(codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codRango, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaRangoToExcel_Prov_Failed] : ", ex);
                throw ex;
            }

            return oE_ExportExcel;
        }
        //2.1.-Pintar Mapa PDV con SKUMandatorio
        public List<E_PresenciaPDV> Obtener_PuntoVentaPresenciaSKU_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codProducto, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = null;
            try
            {
                oListPuntoVenta = oD_GES_MapsService.Obtener_PuntoVentaPresenciaSKU_Prov(codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaSKU_Prov_Failed] : ", ex);
                throw ex;
            }
            return oListPuntoVenta;
        }
        //2.2.-Exportar a Excel por SKUMandatorios
        public E_ExportExcel Obtener_PuntoVentaPresenciaSKUToExcel_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codProducto, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_PuntoVentaPresenciaSKUToExcel_Prov(codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaSKUToExcel_Prov_Failed] : ", ex);
                throw ex;
            }

            return oE_ExportExcel;
        }

        #endregion

        #region Sección - Ventas x SubCategoria
        //3.-Matriz Ventas X Categoría X Distribuidora.(considerar periodo).
        //Reutilizacion
        //public List<E_VentasZonaDistrito> Obtener_Ventas_ZonaDistrito(int tipo, string codigo, int reportsPlanning)
        //UP_XPLORAMAPS_VENTAS
        #endregion

        #region Sección - Elementos de Visibilidad
        //3.- Cantidad de PDV’s por Elemento de Visibilidad (COLPAL, P&G) .(considerar periodo).
        //Reutilizacion del Metodo
        // public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_ELEMENTO_VISIBILIDAD_PDV
        //3.1 Exportar a Excel
        public E_ExportExcel Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                oE_ExportExcel = oD_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov(codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov_Failed] : ", ex);
                throw ex;
            }

            return oE_ExportExcel;
        }
        //3.2 Pintar Puntos en Mapa PDV
        public List<E_PresenciaPDV> Obtener_PuntoVentaPresenciaElemVisibilidad_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = null;

            try
            {
                oListPuntoVenta = oD_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidad_Prov(codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov] : ", ex);
                throw ex;
            }
            return oListPuntoVenta;
        }

        #endregion

        #region Sección - Graficos
        //1.- Ventas vs Presencia: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Tendencia
        public List<E_Grafico_Tendencia> Obtener_Grafico_Tendencia_Prov(string codServicio, string codCanal, string codCliente, string codPais,
    string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito,
    string codCategoria, string codProducto, string codCluster, string anio, string mes, string codPeriodo, string codOpcion)
        {
            List<E_Grafico_Tendencia> oListGraficoTendencia = null;
            try
            {
                oListGraficoTendencia = oD_GES_MapsService.Obtener_Grafico_Tendencia_Prov(codServicio, codCanal, codCliente,
                    codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Grafico_Tendencia_Prov_Failed] : ", ex);
                throw ex;
            }
            return oListGraficoTendencia;
        }
        //2.-Variación de Ventas: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Variacion
        public List<E_Grafico_Variacion> Obtener_Grafico_Variacion_Prov(string codServicio, string codCanal, string codCliente, string codPais,
    string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito,
    string codCategoria, string codProducto, string codCluster, string anio, string mes, string codPeriodo, string codOpcion)
        {
            List<E_Grafico_Variacion> oListGraficoVariacion = null;

            try
            {
                oListGraficoVariacion = oD_GES_MapsService.Obtener_Grafico_Variacion_Prov(codServicio, codCanal, codCliente,
                    codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Grafico_Variacion_Prov_Failed] : ", ex);
                throw ex;
            }
            return oListGraficoVariacion;
        }

        #endregion

        #region Sección - Visita por PDV >>Reutiliza Por Completo<<
        //1.- 4 Fotos (2 internas ant,des / 2 externas ant,des)
        //Reutilizar el que Existe
        //public E_Foto_PDV Obtener_Foto_PuntoVenta(string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_FOTO_PDV

        //2.-Datos del PDV igual que en Xplora Maps Lima.
        //Reutilizar el que Existe
        // public E_PuntoVentaDatosMapa Obtener_DatosPuntosVentaMapa(string codPtoVenta, string reportsPlanning)
        //SP_GES_MAPS_OBTENER_PDV

        //3.-Vista de Presencia por SKU igual que en Xplora Maps Lima(check).
        //Reutilizar el que Existe
        //SP_GES_MAPS_OBTENER_PRESENCIA_PDV
        //public List<E_Presencia_PDV> Obtener_Presencia_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)

        //4.-Vista de Elementos de Visibilidad por (cant x COLPAL/ COMP(P&G, UNILEVER, J&J etc)).
        //Reutilizar el que Existe
        // public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_ELEMENTO_VISIBILIDAD_PDV

        //5.-Vista de Ventas x SKU (importe/cantidad)
        //Reutilizar el que Existe
        //SP_GES_MAPS_OBTENER_VENTA_PDV
        //public List<E_Ventas_PDV> Obtener_Venta_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        #endregion

        #endregion

        #region Backus

        public E_Cobertura Obtener_Cobertura_PDV_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            E_Cobertura cobertura = new E_Cobertura();
            try
            {
                cobertura = oD_GES_MapsService.Obtener_Cobertura_PDV_x_Canal_Cadena(codCliente, codCanal, codCadena, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Cobertura_PDV_x_Canal_Cadena_Failed] : ", ex);
            }
            return cobertura;
        }

        public List<E_Status_EQF> Obtener_Status_EQF_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Status_EQF> listStatusEQF = new List<E_Status_EQF>();
            try
            {
                listStatusEQF = oD_GES_MapsService.Obtener_Status_EQF_x_Canal_Cadena(codCliente, codCanal, codCadena, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Status_EQF_x_Canal_Cadena_Failed] : ", ex);
            }
            return listStatusEQF;
        }

        public List<E_Presencia_ElementoVisibilidad> Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Presencia_ElementoVisibilidad> listElementoVisibilidad = new List<E_Presencia_ElementoVisibilidad>();
            try
            {
                listElementoVisibilidad = oD_GES_MapsService.Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena(codCliente, codCanal, codCadena, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Failed] : ", ex);
            }
            return listElementoVisibilidad;
        }

        public List<E_Presencia_Producto> Obtener_Presencia_Producto_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Presencia_Producto> listProducto = new List<E_Presencia_Producto>();
            try
            {
                listProducto = oD_GES_MapsService.Obtener_Presencia_Producto_x_Canal_Cadena(codCliente, codCanal, codCadena, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Presencia_Producto_x_Canal_Cadena_Failed] : ", ex);
            }
            return listProducto;
        }

        public List<E_Presencia_Producto> Obtener_Precio_Producto_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Presencia_Producto> listProducto = new List<E_Presencia_Producto>();
            try
            {
                listProducto = oD_GES_MapsService.Obtener_Precio_Producto_x_Canal_Cadena(codCliente, codCanal, codCadena, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Precio_Producto_x_Canal_Cadena_Failed] : ", ex);
            }
            return listProducto;
        }

        public List<E_PuntoVentaMapa> Obtener_PDV_Cluster_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_PuntoVentaMapa> listPtoVenta = new List<E_PuntoVentaMapa>();
            try
            {
                listPtoVenta = oD_GES_MapsService.Obtener_PDV_Cluster_x_Canal_Cadena(codCliente, codCanal, codCadena, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PDV_Cluster_x_Canal_Cadena_Failed] : ", ex);
            }
            return listPtoVenta;
        }

        public E_PuntoVentaDatosMapa Obtener_Datos_PDV_x_Cliente(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            E_PuntoVentaDatosMapa datosPtoVenta = new E_PuntoVentaDatosMapa();
            try
            {
                datosPtoVenta = oD_GES_MapsService.Obtener_Datos_PDV_x_Cliente(codCliente, codPtoVenta, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Datos_PDV_x_Cliente_Failed] : ", ex);
            }
            return datosPtoVenta;
        }

        public List<E_Presencia_Producto> Obtener_Presencia_Producto_x_PDV(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            List<E_Presencia_Producto> listProducto = new List<E_Presencia_Producto>();
            try
            {
                listProducto = oD_GES_MapsService.Obtener_Presencia_Producto_x_PDV(codCliente, codPtoVenta  , reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Presencia_Producto_x_PDV_Failed] : ", ex);
            }
            return listProducto;
        }

        public List<E_Presencia_Producto> Obtener_Precio_Producto_x_PDV(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            List<E_Presencia_Producto> listProducto = new List<E_Presencia_Producto>();
            try
            {
                listProducto = oD_GES_MapsService.Obtener_Precio_Producto_x_PDV(codCliente, codPtoVenta, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_Precio_Producto_x_PDV_Failed] : ", ex);
            }
            return listProducto;
        }

        public List<E_Presencia_ElementoVisibilidad> Obtener_MaterialApoyo_x_PDV(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            List<E_Presencia_ElementoVisibilidad> listElementoVisibilidad = new List<E_Presencia_ElementoVisibilidad>();
            try
            {
                listElementoVisibilidad = oD_GES_MapsService.Obtener_MaterialApoyo_x_PDV(codCliente, codPtoVenta, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_MaterialApoyo_x_PDV_Failed] : ", ex);
            }
            return listElementoVisibilidad;
        }

        public List<E_PuntoVentaDatosMapa> Obtener_PDV_x_Cliente(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_PuntoVentaDatosMapa> listPtoVenta = new List<E_PuntoVentaDatosMapa>();
            try
            {
                listPtoVenta = oD_GES_MapsService.Obtener_PDV_x_Cliente(codCliente, codCanal, codCadena, reportsPlanning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PDV_x_Cliente_Failed] : ", ex);
            }
            return listPtoVenta;
        }

        #endregion

        #region Alicorp
        //Add Psa. Fecha: 15/11/2012
        public List<E_PuntoDeVenta> Obtener_PDV_x_Cliente_Canal(string CodCliente, string CodCanal)
        {
            List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
            try
            {
                oListE_PuntoDeVenta = oD_GES_MapsService.Obtener_PDV_x_Cliente_Canal(CodCliente, CodCanal);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PDV_x_Cliente_Canal_Failed] : ", ex);
                throw ex;
            }
            return oListE_PuntoDeVenta;
        }
        //Add Psa. Fecha:15/11/2012
        public List<E_PuntoDeVenta> Obtener_PDV_x_Cliente_Canal_PDV(string CodCliente, string CodCanal, string CodPtoVenta)
        {
            List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
            try
            {
                oListE_PuntoDeVenta = oD_GES_MapsService.Obtener_PDV_x_Cliente_Canal_PDV( CodCliente, CodCanal, CodPtoVenta);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_MapsService][Obtener_PDV_x_Cliente_Canal_PDV_Failed] : ", ex);
                throw ex;
            }
            return oListE_PuntoDeVenta;
        }
        //Ok - Revisado
        public E_DatosFiltros Obtener_DatosFiltro_x_Persona(string CodPersona)
        {
            E_DatosFiltros oE_DatosFiltros = new E_DatosFiltros();
            try
            {
                oE_DatosFiltros=oD_GES_MapsService.Obtener_DatosFiltro_x_Persona(CodPersona);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oE_DatosFiltros;
        }
        //Ok
        public List<E_Canal> Obtener_Canal_x_Cliente_Persona(string CodCliente, string CodPersona)
        {
            List<E_Canal> oListE_Canal = new List<E_Canal>();
            try
            {
                oListE_Canal = oD_GES_MapsService.Obtener_Canal_x_Cliente_Persona(CodCliente, CodPersona);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Canal;
        }
        //Ok
        public List<E_Anio> Obtener_Anios_x_Cliente_Canal(string CodCliente, string CodCanal)
        {
            List<E_Anio> oListE_Anio = new List<E_Anio>();
            try
            {
                oListE_Anio = oD_GES_MapsService.Obtener_Anios_x_Cliente_Canal(CodCliente, CodCanal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Anio;
        }
        //Ok
        public List<E_Mes> Obtener_Mes_x_Cliente_Canal_Anio(string CodCliente, string CodCanal, string Anio)
        {
            List<E_Mes> oListE_Mes = new List<E_Mes>();
            try
            {
                oListE_Mes = oD_GES_MapsService.Obtener_Mes_x_Cliente_Canal_Anio(CodCliente, CodCanal, Anio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Mes;
        }
        //Ok - Modificado
        public List<E_Periodo> Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Reporte(string CodCliente, string CodCanal, string Anio, string Mes, string CodReporte)
        {
            List<E_Periodo> oListE_Periodo = new List<E_Periodo>();
            try
            {
                oListE_Periodo = oD_GES_MapsService.Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Reporte(CodCliente, CodCanal, Anio, Mes, CodReporte);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Periodo;
        }
        //Ok - Modificado
        public List<E_Categoria> Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep(string CodCliente, string CodCanal, string Anio, string Mes, string Periodo, string Departamento, string CodReporte)
        {
            List<E_Categoria> oListE_Categoria = new List<E_Categoria>();
            try
            {
                oListE_Categoria = oD_GES_MapsService.Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep(CodCliente, CodCanal, Anio, Mes, Periodo, Departamento, CodReporte);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Categoria;
        }
        //Ok - Modificado
        public List<E_Producto> Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep(string CodCliente, string CodCanal, string Anio, string Mes, string Periodo, string CodCategoria, string CodDepartamento, string CodReporte)
        {
            List<E_Producto> oListE_Producto = new List<E_Producto>();
            try
            {
                oListE_Producto = oD_GES_MapsService.Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep(CodCliente, CodCanal, Anio, Mes, Periodo, CodCategoria, CodDepartamento, CodReporte);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Producto;
        }
        //Ok
        public List<E_Resumen> Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto(string CodCliente, string CodCanal, string Anio, string Mes, string Periodo, string CodDepartamento)
        {
            List<E_Resumen> oListE_Resumen = new List<E_Resumen>();
            try
            {
                oListE_Resumen = oD_GES_MapsService.Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto(CodCliente, CodCanal, Anio, Mes, Periodo, CodDepartamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Resumen;
        }
        
        
        #endregion
    }
}