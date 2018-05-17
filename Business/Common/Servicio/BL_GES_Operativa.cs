using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Data.Common.Servicio;
using Lucky.Business.Common.Exceptions;
using Lucky.Entity.Common.Servicio;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Business.Common.Servicio
{
    public class BL_GES_Operativa
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_GES_Campania));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();

        #region Gestion Consultar - Reportes
        #region ListarPeriodo_Por_CodServicio_OtrosFiltros - Disabled
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve los periodos por código de canal, código de reporte, año y mes
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        //public List<E_Periodo> Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes(string CodServicio, string CodCanal, string CodCliente, string CodReporte, string Anio, string Mes)
        //{
        //    try
        //    {
        //        D_GES_Campania oD_GES_Campania = new D_GES_Campania();
        //        List<E_Periodo> listaE_Periodo = new List<E_Periodo>();
        //        listaE_Periodo = oD_GES_Campania.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes(CodServicio, CodCanal, CodCliente, CodReporte, Anio, Mes);
        //        if (listaE_Periodo == null)
        //        {
        //            throw new NegocioAmbienteException();
        //        }
        //        else
        //        {
        //            return listaE_Periodo;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("[BL_GES_Campania] [Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes] :", ex);
        //        throw new NegocioAmbienteException();
        //    }
        //}
        //Consultar_Reporte_Stock
        #endregion

        //---Desarrollo
        //---Descripcion: Devolver la Consulta del Reporte de Stock para la Validación al Cliente
        //---Fecha      : 12/05/2012 PSA
        public List<E_Consulta_Reporte_Stock> Consultar_Reporte_Stock_Validado(string CodServicio, int CodCompania, string CodCanal, int CodOficina, string CodCategoria, int CodReporteCampania, string TipoData)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_Stock> oListaReporte = new List<E_Consulta_Reporte_Stock>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_Stock_General_Validado(CodServicio, CodCompania, CodCanal, CodOficina, CodCategoria, CodReporteCampania, TipoData);
                if (oListaReporte == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return oListaReporte;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Stock_Failed] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        /// Warning
        /// Fecha: 14/05/2012 - PSA
        /// Descripción: Consulta el Reporte de Stock para DataMercaderista MVC
        /// Pendiente: Falta Crear El campo ValidCliente
        /// </summary>
        /// <returns></returns>
        public List<E_Consulta_Reporte_Stock> Consultar_Reporte_Stock_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodFamilia, DateTime f_incio, DateTime f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_Stock> oListaReporte = new List<E_Consulta_Reporte_Stock>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_Stock_General(CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodFamilia, f_incio, f_fin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Stock_Failed] :", ex);
            }
            return oListaReporte;
        }

        /// Warning
        /// Fecha: 14/05/2012 - PSA
        /// Descripción: Consulta el Reporte de Precio para DataMercaderista MVC
        /// Pendiente: Falta Crear El campo ValidCliente
        /// </summary>
        /// <returns></returns>
        public List<E_Consulta_Reporte_Precio> Consultar_Reporte_Precio_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodSubcategoria, string CodMarca, string codProducto, DateTime f_incio, DateTime f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_Precio> oListaReporte = new List<E_Consulta_Reporte_Precio>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_Precio_General(CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodSubcategoria, CodMarca, codProducto, f_incio, f_fin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Precio_General_Failed] :", ex);
            }
            return oListaReporte;
        }

        /// Warning
        /// Fecha: 14/05/2012 - PSA
        /// Descripción: Consulta el Reporte de SOD para DataMercaderista MVC
        /// Pendiente: Falta Crear El campo ValidCliente
        /// </summary>
        /// <returns></returns>
        public List<E_Consulta_Reporte_SOD> Consultar_Reporte_SOD_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, DateTime f_incio, DateTime f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_SOD> oListaReporte = new List<E_Consulta_Reporte_SOD>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_SOD_General(CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, f_incio, f_fin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Precio_SOD_Failed] :", ex);
            }
            return oListaReporte;
        }

        /// Warning
        /// Fecha: 14/05/2012 - PSA
        /// Descripción: Consulta el Reporte de Exhibicion para DataMercaderista MVC
        /// Pendiente: Falta Crear El campo ValidCliente
        /// </summary>
        /// <returns></returns>
        public List<E_Consulta_Reporte_Exhibicion> Consultar_Reporte_Exhibicion_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, string f_incio, string f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_Exhibicion> oListaReporte = new List<E_Consulta_Reporte_Exhibicion>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_Exhibicion_General(CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, f_incio, f_fin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Exhibicion_General_Failed] :", ex);
            }
            return oListaReporte;
        }

        /// Warning
        /// Fecha: 14/05/2012 - PSA
        /// Descripción: Consulta el Reporte de Exhibicion para DataMercaderista MVC
        /// Pendiente: Falta Crear El campo ValidCliente
        /// </summary>
        /// <returns></returns>
        public List<E_Consulta_Reporte_Exhibicion> Consultar_Reporte_Exhibicion(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, string f_incio, string f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_Exhibicion> oListaReporte = new List<E_Consulta_Reporte_Exhibicion>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_Exhibicion(CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, f_incio, f_fin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Exhibicion_Failed] :", ex);
            }
            return oListaReporte;
        }

        /// Warning
        /// Fecha: 14/05/2012 - PSA
        /// Descripción: Consulta el Reporte de LayOut para DataMercaderista MVC
        /// Pendiente: Falta Crear El campo ValidCliente
        /// </summary>
        /// <returns></returns>
        public List<E_Consulta_Reporte_LayOut> Consultar_Reporte_LayOut_General(string CodPersona, string CodCampania, string CodCanal, string CodCategoria, string CodMarca, DateTime f_incio, DateTime f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_LayOut> oListaReporte = new List<E_Consulta_Reporte_LayOut>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_LayOut_General(CodPersona, CodCampania, CodCanal, CodCategoria, CodMarca, f_incio, f_fin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_LayOut_General_Failed] :", ex);
            }
            return oListaReporte;
        }

        /// Warning
        /// Fecha: 14/05/2012 - PSA
        /// Descripción: Consulta el Reporte de Quiebre para DataMercaderista MVC
        /// Pendiente: Falta Crear El campo ValidCliente
        /// </summary>
        /// <returns></returns>
        public List<E_Consulta_Reporte_Quiebre> Consultar_Reporte_Quiebre_General(string CodPersona, string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV_Compania, string CodCategoria, string CodMarca, string codProducto, DateTime f_incio, DateTime f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_Quiebre> oListaReporte = new List<E_Consulta_Reporte_Quiebre>();
            try
            {
                oListaReporte = oD_GES_Operativa.Consultar_Reporte_Quiebre_General(CodPersona, CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV_Compania, CodCategoria, CodMarca, codProducto, f_incio, f_fin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Quiebre_General_Failed] :", ex);
            }
            return oListaReporte;
        }

        #endregion

        #region Gestion Unicos
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que válida el reporte de stock
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public void Validar_Reporte_Stock(string oListaValidar, string oListaInvalidar)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            try
            {
                oD_GES_Operativa.Validar_Reporte_Stock(oListaValidar, oListaInvalidar);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Validar_Reporte_Stock_Failed] :", ex);
            }
        }

        /// <summary>
        /// Fecha: 15/05/2012
        /// Autor: Joseph Gonzales
        /// Descripción: Método que devuelve la cantidad de datos validados e invalidados
        /// </summary>
        /// <param name="CodServicio"></param>
        /// <param name="CodCompania"></param>
        /// <param name="CodCanal"></param>
        /// <param name="CodOficina"></param>
        /// <param name="CodCategoria"></param>
        /// <param name="CodReporteCampania"></param>
        /// <returns></returns>
        public E_Reporte_Data_Validada Consultar_Reporte_Data_Validada(string CodServicio, int CodCompania, string CodCanal, int CodOficina, string CodCategoria, int CodReporteCampania)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            E_Reporte_Data_Validada oE_Reporte_Data_Validada = new E_Reporte_Data_Validada();
            try
            {
                oE_Reporte_Data_Validada = oD_GES_Operativa.Consultar_Reporte_Data_Validada(CodServicio, CodCompania, CodCanal, CodOficina, CodCategoria, CodReporteCampania);
                if (oE_Reporte_Data_Validada == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return oE_Reporte_Data_Validada;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Data_Validada] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public E_Persona Logueo(string sUser, string sPassw)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            E_Persona oE_Persona = new E_Persona();

            try
            {
                oE_Persona = oD_GES_Operativa.Logueo(sUser, sPassw);
                if (oE_Persona == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return oE_Persona;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Logueo] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public List<E_Consulta_Reporte_Presencia> Consultar_Reporte_Presencia(string CodCampania, string CodCanal, string CodOficina, string CodNodoComercial, string CodigoPDV, string CodCategoria, string CodMarca, string CodSupervisor, string CodPersona, string CodTipoReporte, DateTime f_incio, DateTime f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Consulta_Reporte_Presencia> oListConsulta_Reporte_Presencia = new List<E_Consulta_Reporte_Presencia>();

            try
            {
                oListConsulta_Reporte_Presencia = oD_GES_Operativa.Consultar_Reporte_Presencia(CodCampania, CodCanal, CodOficina, CodNodoComercial, CodigoPDV, CodCategoria, CodMarca, CodSupervisor, CodPersona, CodTipoReporte, f_incio, f_fin);
                return oListConsulta_Reporte_Presencia;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_Reporte_Presencia] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public List<E_Reporte_Relevo> Consulta_Reporte_Relevo(string fechaConsulta, string codCliente, string codUsuario,
            string codCanal, string codPais, string codDepartamento, string codProvincia)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Reporte_Relevo> oListConsulta_Reporte_Relevo = new List<E_Reporte_Relevo>();

            try
            {
                oListConsulta_Reporte_Relevo = oD_GES_Operativa.Consulta_Reporte_Relevo(fechaConsulta, codCliente, codUsuario,
                codCanal, codPais, codDepartamento, codProvincia);
                return oListConsulta_Reporte_Relevo;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consulta_Reporte_Relevo] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        public E_ContentStringDataSet Consultar_ReportePresenciaConsolidado(string CodCampania, string CodEquipo, string CodCanal, string CodMercaderista, string CodOficina, string CodMalla, string CodigoPDV, string CodTipoReporte, DateTime f_incio, DateTime f_fin)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            E_ContentStringDataSet oE_ContentStringDataSet = new E_ContentStringDataSet();

            try
            {
                oE_ContentStringDataSet = oD_GES_Operativa.Consultar_ReportePresenciaConsolidado(CodCampania, CodEquipo, CodCanal, CodMercaderista, CodOficina, CodMalla, CodigoPDV, CodTipoReporte, f_incio, f_fin);
                return oE_ContentStringDataSet;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Consultar_ReportePresenciaConsolidado] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public List<E_Informesv2> Listar_Informes_CM(string codPais, string codCliente, string idAgrupacion, string idPersona)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            List<E_Informesv2> oListInformes = new List<E_Informesv2>();

            try
            {
                oListInformes = oD_GES_Operativa.Listar_Informes_CM(codPais, codCliente, idAgrupacion, idPersona);
                return oListInformes;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Listar_Informes_CM] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        public E_Informes Listar_Informes_MKT(int idCanal, int idReporte, int idMarca, int idServicio, string anio)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            E_Informes oInformes = new E_Informes();

            try
            {
                oInformes = oD_GES_Operativa.Listar_Informes_MKT(idCanal, idReporte, idMarca, idServicio, anio);
                return oInformes;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Listar_Informes_MKT] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion

        #region Gestion Orden de Compras - Registrar
        /// <summary>
        /// Author  : Peter Ccopa
        /// Fecha   : 25/10/2012
        /// Descripcion: Registrar Orden de Compras
        /// </summary>
        /// <param name="oE_OrdenCompra"></param>
        /// <returns></returns>
        public string Registrar_OrdenCompra(E_OrdenCompra oE_OrdenCompra)
        {
            try
            {
                return oD_GES_Operativa.Registrar_OrdenCompra(oE_OrdenCompra);
                
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Registrar_OrdenCompra] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion

        #region Gestion Tickets - Registrar
        /// <summary>
        /// Author  : Peter Ccopa
        /// Fecha   : 15/11/2012
        /// Descripcion: Registrar Tickets
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public string Registrar_Tickets(E_Tickets oE_Tickets)
        {
            try
            {
                return oD_GES_Operativa.Registrar_Tickets(oE_Tickets);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Registrar_Tickets] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion

        #region Gestion Reportes - Registrar
        /// <summary>
        /// Author  : Pablo Salas A.
        /// Fecha   : 26/09/2012
        /// Descripcion: Registrar_Reporte_Encuesta
        /// </summary>
        /// <param name="oE_Reporte_Encuesta"></param>
        /// <returns></returns>
        public string Registrar_Reporte_Encuesta(E_Reporte_Encuesta oE_Reporte_Encuesta)
        {
            try
            {
                string retorno = oD_GES_Operativa.Registrar_Reporte_Encuesta(oE_Reporte_Encuesta);
                return retorno;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Registrar_Reporte_Encuesta] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        /// <summary>
        /// Author  : Joseph Gonzales.
        /// Fecha   : 15/10/2012
        /// Descripcion: Registrar_Reporte_Encuesta
        /// </summary>
        /// <param name="oE_Reporte_Encuesta"></param>
        /// <returns></returns>
        public string Registrar_Reporte_Encuesta_EQF(E_Reporte_Encuesta_EQF oE_Reporte_Encuesta_EQF)
        {
            try
            {
                string retorno = oD_GES_Operativa.Registrar_Reporte_Encuesta_EQF(oE_Reporte_Encuesta_EQF);
                return retorno;
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][Registrar_Reporte_Encuesta_EQF] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion

        #region Gestion Proveedores
        /// <summary>
        /// Author  : Peter Ccopa
        /// Fecha   : 22/10/2012
        /// Descripcion: Registrar Proveedores
        /// </summary>
        /// <returns></returns>
        public string registrarProveedor(E_Proveedor oE_Proveedor)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            string resultado;
            try
            {
                resultado = oD_GES_Operativa.registrarProveedor(oE_Proveedor);
                
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][registrarProveedor] :", ex);
                throw new NegocioAmbienteException();
            }
            return resultado;
        }
        #endregion

        #region Actualiza Proveedores
        /// <summary>
        /// Author  : Peter Ccopa
        /// Fecha   : 31/10/2012
        /// Descripcion: Actualiza Proveedores
        /// </summary>
        /// <returns></returns>
        public string actualizarProveedor(E_Proveedor oE_Proveedor)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            string resultado;
            try
            {
                resultado = oD_GES_Operativa.actualizarProveedor(oE_Proveedor);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Operativa][actualizarProveedor] :", ex);
                throw new NegocioAmbienteException();
            }
            return resultado;
        }
        #endregion

        #region Gestion Reportes - Actualizar
        //---Descripcion: Actualiza Reporte de Exhibicion - Cantidad
        //---Fecha      : 10/11/2012 PCP
        public string Actualizar_Reporte_Exhibicion(string CodReporte, int Cantidad, string ModifyBy, string DateModify, string DateRegistro)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            string error = string.Empty;
            try
            {
                error = oD_GES_Operativa.Actualizar_Reporte_Exhibicion(CodReporte, Cantidad, ModifyBy, DateModify, DateRegistro);
                if (error != "")
                {
                    error = "error";
                    throw new NegocioAmbienteException();
                }
                else
                {
                    error="";
                }
            }
            catch (Exception ex)
            {
                error = "error";
                log.Error("[BL_GES_Operativa][Actualizar_Reporte_Exhibicion] :", ex);
                throw new NegocioAmbienteException();
            }
            return error;
        }

        //---Descripcion: Valida Reporte de Exhibicion - Cantidad
        //---Fecha      : 14/11/2012 PCP
        public string Validar_Reporte_Exhibicion(string Checked, string unChecked)
        {
            D_GES_Operativa oD_GES_Operativa = new D_GES_Operativa();
            string error = string.Empty;
            try
            {
                error = oD_GES_Operativa.Validar_Reporte_Exhibicion(Checked, unChecked);
                if (error != "")
                {
                    error = "error";
                    throw new NegocioAmbienteException();
                }
                else
                {
                    error = "";
                }
            }
            catch (Exception ex)
            {
                error = "error";
                log.Error("[BL_GES_Operativa][Validar_Reporte_Exhibicion] :", ex);
                throw new NegocioAmbienteException();
            }
            return error;
        }
        #endregion
    }
}