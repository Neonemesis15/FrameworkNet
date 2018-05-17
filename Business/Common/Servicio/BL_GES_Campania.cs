using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Data.Common.Servicio;
using Lucky.Business.Common.Exceptions;
using Lucky.Entity.Common.Servicio;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Servicio
{
    public class BL_GES_Campania
    {
        public BL_GES_Campania() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_GES_Campania));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_GES_Campania oD_GES_Campania = new D_GES_Campania();

        #region Gestion de Canales
        public List<E_Canal> Listar_Canales_Por_CodCompania(string CodCompania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Canal> listaCanal = new List<E_Canal>();
            try
            {
                listaCanal = oD_GES_Campania.Listar_Canales_Por_CodCompania(CodCompania);
            }
            catch (Exception ex)
            {
                //E_Canal oE_Canal = new E_Canal();
                //oE_Canal.Cod_Channel = "0";
                //oE_Canal.Channel_Name = "<<Error en el Filtro>>";
                //listaCanal.Add(oE_Canal);

                log.Error("[BL_GES_Campania][Listar_Canales_Por_CodCompania_Failed] :", ex);
            }
            return listaCanal;
        }
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       11/05/2012
        /// Descripción: Método que devuelve los canales por código de cliente, código de persona y código de oficina
        /// </summary>
        /// <param name="CodPersona"></param>
        /// <returns></returns>
        public List<E_Canal> Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina(string CodCliente, string CodPersona, string CodOficina)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Canal> listaE_Canal = new List<E_Canal>();
                listaE_Canal = oD_GES_Campania.Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina(CodCliente, CodPersona, CodOficina);
                if (listaE_Canal == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Canal;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion
        #region Gestion de Campania
        public List<E_Campania> Listar_Campania_Por_CodCanal_y_CodCompania(string CodCanal, string CodCompania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Campania> listaCampania = new List<E_Campania>();
            try
            {
                listaCampania = oD_GES_Campania.Listar_Campania_Por_CodCanal_y_CodCompania(CodCanal, CodCompania);
            }
            catch (Exception ex)
            {
                //E_Campania oE_Campania = new E_Campania();
                //oE_Campania.Id_planning = "0";
                //oE_Campania.Planning_Name = "<<Sin Información>>";
                //listaCampania.Add(oE_Campania);

                log.Error("[BL_GES_Campania][Listar_Campania_Por_CodCanal_y_CodCliente_Failed] :", ex);
            }
            return listaCampania;
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public string registrarPlanning(E_Planning planning)
        {
            String error = string.Empty;

            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                error = oD_GES_Campania.registrarPlanning(planning);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [registrarPlanning] :", ex);
                error = error + ex.Message;
            }
            return error;
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Seguimiento> listarSeguimientoDeCampaña(string CodCliente, string CodCampania)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Seguimiento> listaE_Seguimiento = new List<E_Seguimiento>();
                listaE_Seguimiento = oD_GES_Campania.listarSeguimientoDeCampaña(CodCliente, CodCampania);
                if (listaE_Seguimiento == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Seguimiento;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarSeguimientoDeCampaña] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion de Reporte
        public List<E_Reporte> Listar_Reporte_Por_CodCampania(string CodCampania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Reporte> listaReporte = new List<E_Reporte>();
            try
            {
                listaReporte = oD_GES_Campania.Listar_Reporte_Por_CodCampania(CodCampania);
            }
            catch (Exception ex)
            {
                //E_Reporte oE_Reporte = new E_Reporte();
                //oE_Reporte.Report_Id = 0;
                //oE_Reporte.Report_NameReport = "<<Sin Información>>";
                //listaReporte.Add(oE_Reporte);

                log.Error("[BL_GES_Campania][Listar_Reporte_Por_CodCampania] : ", ex);
            }
            return listaReporte;
        }
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 10/09/2012
        /// Descripción: Método que devuelve los SubReportes por tipo de Reporte.
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        /// 
        public List<E_Sub_Reporte> ListarSubReportes(string CodReporte, string CodCompania, string CodChanel)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Sub_Reporte> listaE_SubReporte = new List<E_Sub_Reporte>();
                listaE_SubReporte = oD_GES_Campania.Listar_Sub_Reportes(CodReporte, CodCompania, CodChanel);
                if (listaE_SubReporte == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_SubReporte;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [ListarSubReportes] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion de Categoria
        public List<E_Categoria> Listar_Categoria_Por_CodCampania_y_CodReporte(string CodCampania, string CodReporte)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Categoria> listaCategoria = new List<E_Categoria>();
            try
            {
                listaCategoria = oD_GES_Campania.Listar_Categoria_Por_CodCampania_y_CodReporte(CodCampania, CodReporte);
            }
            catch (Exception ex)
            {
                //E_Categoria oE_Categoria = new E_Categoria();
                //oE_Categoria.Id_ProductCategory = "0";
                //oE_Categoria.Product_Category = "<<Sin Información>>";
                //listaCategoria.Add(oE_Categoria);
                log.Error("[BL_GES_Campania][Listar_Categoria_Por_CodCampania_y_CodReporte] : ", ex);
            }
            return listaCategoria;

        }

        public List<E_Categoria> Listar_Categoria_Por_CodCampania(string CodCampania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Categoria> listaCategoria = new List<E_Categoria>();
            try
            {
                listaCategoria = oD_GES_Campania.Listar_Categoria_Por_CodCampania(CodCampania);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Categoria_Por_CodCampania] : ", ex);
            }
            return listaCategoria;

        }

        #endregion
        #region Gestion de Marca
        public List<E_Marca> Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria(string CodCampania, string CodReporte, string CodCategoria)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Marca> listaMarca = new List<E_Marca>();
            try
            {
                listaMarca = oD_GES_Campania.Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria(CodCampania, CodReporte, CodCategoria);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria] : ", ex);
            }
            return listaMarca;
        }

        /////////////////////////
        public List<E_Marca> Listar_Marca_Por_CodCategoria(string CodCategoria)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Marca> listaMarca = new List<E_Marca>();
            try
            {
                listaMarca = oD_GES_Campania.Listar_Marca_Por_CodCategoria(CodCategoria);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Marca_Por_CodCategoria] : ", ex);
            }
            return listaMarca;
        }

        #endregion
        #region Gestion de Usuario
        //public List<E_Persona> Listar_Generadores_Por_CodSupervisor(string CodSupervisor) {
        //    D_GES_Campania oD_GES_Campania = new D_GES_Campania();
        //    List<E_Persona> listaGeneradores = new List<E_Persona>();
        //    try {
        //        listaGeneradores = oD_GES_Campania.Listar_Generadores_Por_CodSupervisor(CodSupervisor);
        //    }
        //    catch(Exception ex) {
        //        log.Error("[BL_GES_Campania][Listar_Generadores_Por_CodSupervisor] : ", ex);
        //    }
        //    return listaGeneradores;
        //}

        #region Listar_Generadores_Por_CodCampania_CodSupervisor
        //Modified 11/05/2012 PSA.
        public List<E_Persona> Listar_Generadores_Por_CodCampania_CodSupervisor(string CodCampania, string CodSupervisor)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Persona> listaGeneradores = new List<E_Persona>();
            try
            {
                listaGeneradores = oD_GES_Campania.Listar_Generadores_Por_CodCampania_CodSupervisor(CodCampania, CodSupervisor);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Generadores_Por_CodCampania_CodSupervisor] : ", ex);
            }
            return listaGeneradores;
        }
        public List<E_Persona> Listar_Generadores_Por_CodCanal_Y_CodCliente(string CodServicio, string CodCliente, string CodCanal,string año,string mes, string CodPeriodo,string CodCiudad,string CodZona)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Persona> listaGeneradores = new List<E_Persona>();
            try
            {
                listaGeneradores = oD_GES_Campania.Listar_Generadores_Por_CodCanal_Y_CodCliente(CodServicio, CodCliente, CodCanal,año,mes, CodPeriodo,CodCiudad,CodZona);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Generadores_Por_CodCanal_Y_CodCliente] : ", ex);
            }
            return listaGeneradores;
        }

        #endregion

        #region Listar_Generadores_Por_CodCampania_FechaRelevo
        //Modified 11/05/2012 PSA.
        public List<E_Persona> Listar_Generadores_Por_CodCampania_FechaRelevo(string CodCampania, string FechaRelevo)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Persona> listaGeneradores = new List<E_Persona>();
            try
            {
                listaGeneradores = oD_GES_Campania.Listar_Generadores_Por_CodCampania_FechaRelevo(CodCampania, FechaRelevo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Generadores_Por_CodCampania_FechaRelevo] : ", ex);
            }
            return listaGeneradores;
        }
        #endregion

        #region Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel
        //Create 04/10/2012 PCP.
        public List<E_Persona> Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel(string CodCampania, string CodDpto, string CodProv, string CodDist, string FechaRel)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Persona> listaGeneradores = new List<E_Persona>();
            try
            {
                listaGeneradores = oD_GES_Campania.Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel(CodCampania, CodDpto, CodProv, CodDist, FechaRel);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel] : ", ex);
            }
            return listaGeneradores;
        }
        #endregion

        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 11/09/2012
        /// Descripción: Método que devuelve el nombre de usuario
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        /// 
        public EUsuario obtenerNombreUsuario(string idPerson)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                EUsuario oUsuario = new EUsuario();
                oUsuario = oD_GES_Campania.Obtener_Usuario(idPerson);
                if (oUsuario == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return oUsuario;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [obtenerNombreUsuario] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        public List<E_Persona> Listar_Supervisor_Por_CodCampania(string CodCampania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Persona> listaSupervisor = new List<E_Persona>();
            try
            {
                listaSupervisor = oD_GES_Campania.Listar_Supervisor_Por_CodCampania(CodCampania);
            }
            catch (Exception ex)
            {

                log.Error("[BL_GES_Campania][Listar_Supervisor_Por_CodCampania] : ", ex);
            }
            return listaSupervisor;
        }
        #endregion
        #region Gestion de Punto de Venta
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina(string CodCampania, string CodOficina)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                listaPDV = oD_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina(CodCampania, CodOficina);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina] : ", ex);
            }
            return listaPDV;
        }
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador(string CodCampania, string CodOficina, string CodGenerador)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                listaPDV = oD_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador(CodCampania, CodOficina, CodGenerador);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador] : ", ex);
            }
            return listaPDV;
        }

        public List<E_PuntoDeVenta> Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha(string CodCampania, string CodDpto, string CodProv, string CodDist, string CodGenerador, string FechaRelevo)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                listaPDV = oD_GES_Campania.Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha(CodCampania, CodDpto, CodProv, CodDist, CodGenerador, FechaRelevo);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha] : ", ex);
            }
            return listaPDV;
        }
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que devuelve los puntos de venta por código de campaña, código de oficina y código de cadena 
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodOficina"></param>
        /// <param name="CodGenerador"></param>
        /// <returns></returns>
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena(string CodCampania, string CodOficina, string CodCadena)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                listaPDV = oD_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena(CodCampania, CodOficina, CodCadena);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena] : ", ex);
            }
            return listaPDV;
        }
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena(string CodCampania, string CodCiudad, string CodCadena)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                listaPDV = oD_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena(CodCampania, CodCiudad, CodCadena);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena] : ", ex);
            }
            return listaPDV;
        }
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener Los Puntos de Venta por CodCampania_CodDepartamento_CodProvincia_Cod_NodeCommercial 
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodDepartamento"></param>
        /// <param name="CodProvincia"></param>
        /// <param name="CodNodeCommercial"></param>
        /// <returns></returns>
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial(string CodCampania, string CodDepartamento, string CodProvincia, string CodNodeCommercial)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
            try
            {
                oListE_PuntoDeVenta = oD_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial(CodCampania, CodDepartamento, CodProvincia, CodNodeCommercial);
            }
            catch (Exception ex)
            {
                log.Error("http://services.lucky.com.pe:<puerto>/Ges_CampaniaService.svc/Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial " + Environment.NewLine +
                " [BL_GES_Campania][Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial] : ", ex);
                throw ex;
            }
            return oListE_PuntoDeVenta;
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_PuntodeVentaPlanning> listarPuntosdeVentaPlanning(string codOficina, string codDpto, string codProvincia,
            string codDistrito, string codtipoagrupacion, string codagrupacion, string codregion, string codzona)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_PuntodeVentaPlanning> listaE_PuntodeVentaPlanning = new List<E_PuntodeVentaPlanning>();
                listaE_PuntodeVentaPlanning = oD_GES_Campania.listarPuntodeVentaPlanning(codOficina,codDpto, codProvincia, codDistrito, codtipoagrupacion, codagrupacion, codregion, codzona);
                if (listaE_PuntodeVentaPlanning == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_PuntodeVentaPlanning;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarPuntosdeVenta] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        /// <summary>
        /// Autor:Pablo Salas A.
        /// Fecha:26/09/2012
        /// Descripcion: ListarPuntos de Venta por CodCompania.
        /// </summary>
        /// <param name="CodCompania"></param>
        /// <returns></returns>
        public List<E_PuntoDeVenta> Listar_PuntosDeVenta_Por_CodCompania(string CodCompania) {
            try {
                List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
                oListE_PuntoDeVenta = oD_GES_Campania.Listar_PuntoDeVenta_Por_CodCompania(CodCompania);
                return oListE_PuntoDeVenta;
            }
            catch (Exception ex) { 
            
                log.Error("[BL_GES_Campania] [Listar_PuntosDeVenta_Por_CodCompania] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion de Categoria
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve las categorías por código de canal y código de reporte
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Categoria> Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte(string CodCliente, string CodCanal, string CodReporte)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Categoria> listaE_Categoria = new List<E_Categoria>();
                listaE_Categoria = oD_GES_Campania.Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte(CodCliente, CodCanal, CodReporte);
                if (listaE_Categoria == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Categoria;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Categoria_Por_CodCanal_y_CodReporte] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion
        #region Gestion de Periodo
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve los periodos por código de canal, código de reporte, año y mes
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Periodo> Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes(string CodServicio, string CodCanal, string CodCliente, string CodReporte, string Anio, string Mes)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Periodo> listaE_Periodo = new List<E_Periodo>();
                listaE_Periodo = oD_GES_Campania.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes(CodServicio, CodCanal, CodCliente, CodReporte, Anio, Mes);
                if (listaE_Periodo == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Periodo;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion
        #region Gestion de Cadena
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que devuelve las cadena por código de campaña y código de oficina
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Cadena> Listar_Cadena_Por_CodCampania_y_CodOficina(string CodCampania, string CodOficina)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Cadena> listaE_Cadena = new List<E_Cadena>();
                listaE_Cadena = oD_GES_Campania.Listar_Cadena_Por_CodCampania_y_CodOficina(CodCampania, CodOficina);
                if (listaE_Cadena == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Cadena;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Cadena_Por_CodCampania_y_CodOficina] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public List<E_Cadena> Listar_Cadena_Por_CodCliente_y_CodCanal(string CodCliente, string CodCanal)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Cadena> listaE_Cadena = new List<E_Cadena>();
                listaE_Cadena = oD_GES_Campania.Listar_Cadena_Por_CodCliente_y_CodCanal(CodCliente, CodCanal);
                if (listaE_Cadena == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Cadena;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Cadena_Por_CodCliente_y_CodCanal_Failed] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion
        #region Gestion de SubCategoria
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que devuelve las SubCategorías por código de Categoría.
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_SubCategoria> ListarSubCategoria_Por_CodCategoria(string CodCategoria)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_SubCategoria> listaE_SubCategoria = new List<E_SubCategoria>();
                listaE_SubCategoria = oD_GES_Campania.ListarSubCategoria_Por_CodCategoria(CodCategoria);
                if (listaE_SubCategoria == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_SubCategoria;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [ListarSubCategoria_Por_CodCategoria] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion de Productos
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que devuelve los productos por código de campaña, código de categoría, código de subcategoría, código de marca
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Producto> ListarProducto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca(string CodCampania, string CodCategoria, string CodSubCategoria, string CodMarca)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Producto> listaE_Producto = new List<E_Producto>();
                listaE_Producto = oD_GES_Campania.ListarProducto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca(CodCampania, CodCategoria, CodSubCategoria, CodMarca);
                if (listaE_Producto == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Producto;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [ListarProducto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 09/08/2012
        /// Descripción: Método que devuelve los productos por código de campaña, código de cliente, código de categoría, código de subcategoría, código de marca
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Producto> ListarProducto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca(string CodCampania, string CodCliente, string CodCategoria, string CodSubCategoria, string CodMarca)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Producto> listaE_Producto = new List<E_Producto>();
                listaE_Producto = oD_GES_Campania.ListarProducto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca(CodCampania, CodCliente, CodCategoria, CodSubCategoria, CodMarca);
                if (listaE_Producto == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Producto;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [ListarProducto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Failed] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion
        #region Gestion de NodoCommercial
        /// <summary>
        /// Autor: Carlos 
        /// Fecha: 06/06/2012
        /// Descripción: Método que devuelve las cadenas por código de campaña y codigo de la Ciudad
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodOficina"></param>
        /// <returns></returns>
        public List<E_NodeComercial> Listar_NodeComercial_Por_CodCampania_CodCiudad(string CodCampania, string CodOficina)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_NodeComercial> listaNodeComercial = new List<E_NodeComercial>();
            try
            {
                listaNodeComercial = oD_GES_Campania.Listar_NodeComercial_Por_CodCampania_CodCiudad(CodCampania, CodOficina);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_NodeComercial_Por_CodCampania_CodOficina] : ", ex);
            }
            return listaNodeComercial;
        }
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener NodosCommerciales por codCampania_CodDepartamento y Cod_Provincia
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodDepartamento"></param>
        /// <param name="CodProvincia"></param>
        /// <returns></returns>
        public List<E_NodeComercial> Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia(string CodCampania, string CodDepartamento, string CodProvincia)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_NodeComercial> oListE_NodeComercial = new List<E_NodeComercial>();
            try
            {
                oListE_NodeComercial = oD_GES_Campania.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia(CodCampania, CodDepartamento, CodProvincia);
            }
            catch (Exception ex)
            {
                log.Error("http://services.lucky.com.pe:<puerto>/Ges_CampaniaService.svc/Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia " + Environment.NewLine +
                           " [BL_GES_Campania][Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia] : ", ex);
                throw ex;

            }
            return oListE_NodeComercial;
        }

        public List<E_NodeComercial> Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito(string CodCampania, string CodDepartamento, string CodProvincia, string CodDistrito)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_NodeComercial> oListE_NodeComercial = new List<E_NodeComercial>();
            try
            {
                oListE_NodeComercial = oD_GES_Campania.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito(CodCampania, CodDepartamento, CodProvincia,CodDistrito);
            }
            catch (Exception ex)
            {
                log.Error("http://services.lucky.com.pe:<puerto>/Ges_CampaniaService.svc/Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito " + Environment.NewLine +
                           " [BL_GES_Campania][Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito] : ", ex);
                throw ex;

            }
            return oListE_NodeComercial;
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ- Cambio nombre de metodo y agrego parametros 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_NodeComercial_Type> listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia(string CodCampania, string codOficina, string codDepartamento, string codProvincia)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_NodeComercial_Type> listaE_NodeComercial_Type = new List<E_NodeComercial_Type>();
                listaE_NodeComercial_Type = oD_GES_Campania.listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia(CodCampania, codOficina, codDepartamento, codProvincia);
                if (listaE_NodeComercial_Type == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_NodeComercial_Type;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia] :", ex);
                throw new NegocioAmbienteException();
            }

        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre metodo, se agrego parametros 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_NodeComercial> listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia(string CodCampania, string idNodeComercial_Type, string codOficina, string codDepartamento, string codProvincia)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_NodeComercial> listaE_NodeComercial = new List<E_NodeComercial>();
                listaE_NodeComercial = oD_GES_Campania.listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia(CodCampania, idNodeComercial_Type, codOficina, codDepartamento, codProvincia);
                if (listaE_NodeComercial == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_NodeComercial;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia] :", ex);
                throw new NegocioAmbienteException();
            }

        }
        #endregion
        #region Gestion Oficina
        public List<E_Oficina> Listar_Oficinas_Por_CodCampania(string CodCampania) {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Oficina> listaOficina = new List<E_Oficina>();
            try
            {
                listaOficina = oD_GES_Campania.Listar_Oficinas_Por_CodCampania(CodCampania);
            }
            catch (Exception ex) { 
                log.Error("[BL_GES_Campania][Listar_Oficinas_Por_CodCampania] : ", ex);
            }
            return listaOficina;
        }

        public List<E_Oficina> Listar_Oficinas_Por_CodCampania_Por_CodSupervisor(string CodCampania, string CodSupervisor)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Oficina> listaOficina = new List<E_Oficina>();
            try
            {
                listaOficina = oD_GES_Campania.Listar_Oficinas_Por_CodCampania_Por_CodSupervisor(CodCampania,CodSupervisor);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Oficinas_Por_CodCampania_Por_CodSupervisor] : ", ex);
            }
            return listaOficina;
        }

        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       11/05/2012
        /// Descripción: Obtiene las oficinas por el codigo de persona
        /// </summary>
        /// <param name="CodPersona"></param>
        /// <returns></returns>
        public List<E_Oficina> Listar_Oficinas_Por_CodPersona(string CodPersona)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Oficina> listaOficina = new List<E_Oficina>();
                listaOficina = oD_GES_Campania.Listar_Oficinas_Por_CodPersona(CodPersona);
                if (listaOficina == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaOficina;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Oficinas_Por_CodPersona] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        /// <summary>
        /// Autor:       Pablo Salas A.
        /// Fecha:       31/08/2012
        /// Descripción: Obtiene las oficinas por Codigo de Compania.
        /// </summary>
        /// <param name="CodPersona"></param>
        /// <returns></returns>
        public List<E_Oficina> Listar_Oficinas_Por_CodCompania(string CodCompania) {
            
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Oficina> listaOficina = new List<E_Oficina>();

            try {
                listaOficina = oD_GES_Campania.Listar_Oficinas_Por_CodCompania(CodCompania);
            }
            catch (Exception ex) {
                log.Error("[BL_GES_Campania] [Listar_Oficinas_Por_CodCompania] :", ex);
                throw new NegocioAmbienteException();
            }
            return listaOficina;
        }
        /// <summary>
        /// Autor:Giam Farfa
        /// Descripcion: Otberner oficinas por codpais, codcliente,codcampania
        /// Fecha:27/09/2012
        /// </summary>
        /// <param name="CodPais"></param>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Oficina> Listar_Oficinas_Por_CodPais_CodCliente_CodCampania(string CodPais, string CodCliente, string CodCampania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Oficina> listaOficina = new List<E_Oficina>();

            try
            {
                listaOficina = oD_GES_Campania.Listar_Oficinas_Por_CodPais_CodCliente_CodCampania(CodPais,CodCliente,CodCampania);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Oficinas_Por_CodPais_CodCliente_CodCampania] :", ex);
                throw new NegocioAmbienteException();
            }
            return listaOficina;
 
        }
        #endregion
        #region Gestion de Ciudad
        public List<E_Ciudad> Listar_Ciudad_Por_CodCampania(string CodCampania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Ciudad> listaCiudad = new List<E_Ciudad>();
            try
            {
                listaCiudad = oD_GES_Campania.Listar_Ciudad_Por_CodCampania(CodCampania);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_NodeComercial_Por_CodCampania_CodOficina] : ", ex);
            }
            return listaCiudad;
        }
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener las Provincias por CodDepartamento 
        /// </summary>
        /// <param name="CodDepartamento"></param>
        /// <returns></returns>
        public List<E_Ciudad> Listar_Ciudad_Por_CodDepartamento(string CodDepartamento)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Ciudad> oListE_Ciudad = new List<E_Ciudad>();
            try
            {
                oListE_Ciudad = oD_GES_Campania.Listar_Ciudad_Por_CodDepartamento(CodDepartamento);
            }
            catch (Exception ex)
            {
                log.Error("http://services.lucky.com.pe:<puerto>/Ges_CampaniaService.svc/Listar_Ciudad_Por_CodDepartamento " + Environment.NewLine +
                           " [BL_GES_Campania][Listar_Ciudad_Por_CodDepartamento] : ", ex);
                throw ex;

            }
            return oListE_Ciudad;
        }
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:03/08/2012
        /// Descripcion: Obtener Las  Provincias por CodCampania y  CodDepartamento.
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodDepartamento"></param>
        /// <param name="CodProvincia"></param>
        /// <param name="CodNodeCommercial"></param>
        /// <returns></returns>
        public List<E_Ciudad> Listar_Ciudad_Por_CodCampania_CodDepartamento(string CodCampania, string CodDepartamento)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Ciudad> oListE_Ciudad = new List<E_Ciudad>();
            try
            {
                oListE_Ciudad = oD_GES_Campania.Listar_Ciudad_Por_CodCampania_CodDepartamento(CodCampania, CodDepartamento);
            }
            catch (Exception ex)
            {
                log.Error("http://services.lucky.com.pe:<puerto>/Ges_CampaniaService.svc/Listar_Ciudad_Por_CodCampania_CodDepartamento " + Environment.NewLine +
                " [BL_GES_Campania][Listar_Ciudad_Por_CodCampania_CodDepartamento] : ", ex);
                throw ex;
            }
            return oListE_Ciudad;
        }

        #endregion
        #region Gestion de Budget
        /// <summary>
        /// Autor: Pablo Salas A.
        /// Fecha: 18/07/2012
        /// Descripción: Devuelve los Budget por CodCompania y CodOpcion
        /// </summary>
        /// <param name="CodCompania"></param>
        /// <param name="CodOpcion"></param>
        /// <returns></returns>
        public List<E_Budget> Listar_Budget_Por_CodCompania_CodOpcion(string CodCompania, string CodOpcion)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Budget> oListE_Budget = new List<E_Budget>();
            try
            {
                oListE_Budget = oD_GES_Campania.Listar_Budget_Por_CodCompania_CodOpcion(CodCompania, CodOpcion);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Budget_Por_CodCompania_CodOpcion] : ", ex);
                throw ex;
            }
            return oListE_Budget;
        }

        /// <summary>
        /// Autor: Pablo Salas A.
        /// Fecha: 19/07/2012
        /// Descripción: Devuelve los Budget por CodCompania , CodBudget,  CodOpcion
        /// </summary>
        /// <param name="CodCompania"></param>
        /// <param name="CodBudget"></param>
        /// <param name="CodOpcion"></param>
        /// <returns></returns>
        public List<E_Budget> Listar_Budget_Por_CodCompania_CodBudget_CodOpcion(string CodCompania, string CodBudget, string CodOpcion)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Budget> oListE_Budget = new List<E_Budget>();
            try
            {

                oListE_Budget = oD_GES_Campania.Listar_Budget_Por_CodCompania_CodBudget_CodOpcion(CodCompania, CodBudget, CodOpcion);
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Budget_Por_CodCompania_CodBudget_CodOpcion] : ", ex);
                throw ex;
            }
            return oListE_Budget;

        }
        #endregion
        #region Gestion Unicos

        ///Descripcion  : Listar Menús por CodPersona, dependiendo el Perfil y la Compañia de la Persona, mostrar los Reportes Asociados.
        ///Fecha        : 04/05/2012 PSA
        public List<E_Menu> Listar_Menu_Por_CodPersona(string CodPersona) {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Menu> listaMenu = new List<E_Menu>();
            try {
                listaMenu = oD_GES_Campania.Listar_Menu_Por_CodPersona(CodPersona);
            }
            catch (Exception ex) {
                log.Error("[BL_GES_Campania][Listar_Menu_Por_CodPersona] :", ex);
            }
            return listaMenu;
        }

        ///Descripcion  : Llena el Reporte Stock Alicorp para que pueda registrar Cantidad y Observaciones.
        ///Fecha        : 05/05/2012 PSA
        public List<E_Reporte_Stock_Alicorp> Llenar_Reporte_Stock_Alicorp(string CodCampania, string CodReporte, string CodCategoria) {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Reporte_Stock_Alicorp> listaReporte = new List<E_Reporte_Stock_Alicorp>();
            try {
                listaReporte = oD_GES_Campania.Llenar_Reporte_Stock_Alicorp(CodCampania, CodReporte, CodCategoria);
            }
            catch(Exception ex) { 
            log.Error("[BL_GES_Campania][Listar_Menu_Por_CodPersona] :", ex);
            }
            return listaReporte;
        }

        /// <summary>
        /// Devuelte los datos del reporte para mostrar en la grilla.
        /// Modulos: Digitación, ...
        /// Autor: Joseph Gonzales
        /// Fecha: 10/05/2012
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        //public List<E_Reporte_General> Llenar_Reporte_General(string CodCompania, string CodReporte, string CodCategoria,
        //    string CodMarca, string CodFamilia, string CodSubFamilia, string CodOficina, string CodGestor, string CodPDV)
        //{
        //    try
        //    {
        //        D_GES_Campania oD_GES_Campania = new D_GES_Campania();
        //        List<E_Reporte_General> listaReporte = new List<E_Reporte_General>();
        //        listaReporte = oD_GES_Campania.Llenar_Reporte_General(CodCompania, CodReporte, CodCategoria, CodMarca, CodFamilia,
        //            CodSubFamilia, CodOficina, CodGestor, CodPDV);
        //        if (listaReporte == null)
        //        {
        //            throw new NegocioAmbienteException();
        //        }
        //        else
        //        {
        //            return listaReporte;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("[BL_GES_Campania] [Llenar_Reporte_General] :", ex);
        //        throw new NegocioAmbienteException();
        //    }
        //}

        public List<E_Reporte_General> Llenar_Reporte_General(E_Filtros_Llenar_Reporte_General oE_Filtros)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Reporte_General> listaReporte = new List<E_Reporte_General>();
                listaReporte = oD_GES_Campania.Llenar_Reporte_General(oE_Filtros);
                if (listaReporte == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaReporte;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Llenar_Reporte_General] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       19/09/2012
        /// Descripción: los datos del reporte para mostrar en la grilla.
        /// </summary>
        public List<E_Reporte_Bodegas> Llenar_Reporte_Bodegas(E_Filtros_Llenar_Reporte_General oE_Filtros)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Reporte_Bodegas> listaReporte = new List<E_Reporte_Bodegas>();
                listaReporte = oD_GES_Campania.Llenar_Reporte_Bodegas(oE_Filtros);
                if (listaReporte == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaReporte;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Llenar_Reporte_Bodegas] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion de Departamento
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener los Departamentos por CodCampaña
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Departamento> Listar_Departamento_Por_CodCampania(string CodCampania)
        {
            D_GES_Campania oD_GES_Campania = new D_GES_Campania();
            List<E_Departamento> oListE_Departamento = new List<E_Departamento>();
            try
            {
                oListE_Departamento = oD_GES_Campania.Listar_Departamento_Por_CodCampania(CodCampania);
            }
            catch (Exception ex)
            {
                log.Error("http://services.lucky.com.pe:<puerto>/Ges_CampaniaService.svc/Listar_Departamento_Por_CodCampania " + Environment.NewLine +
                           " [BL_GES_Campania][Listar_Departamento_Por_CodCampania] : ", ex);
                throw ex;
            }
            return oListE_Departamento;
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre metodo y parametros 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Departamento> listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina(string CodCliente, string CodCampania, string codpais, string codOficina)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Departamento> listaE_Departamento = new List<E_Departamento>();
                listaE_Departamento = oD_GES_Campania.listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina(CodCliente, CodCampania, codpais,codOficina);
                if (listaE_Departamento == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Departamento;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion Anios
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que devuelve los años 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Anio> Listar_Anios()
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Anio> listaE_Anio = new List<E_Anio>();
                listaE_Anio = oD_GES_Campania.Listar_Anios();
                if (listaE_Anio == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Anio;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Anios] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion Meses
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que devuelve los años 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Mes> Listar_Meses()
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Mes> listaE_Mes = new List<E_Mes>();
                listaE_Mes = oD_GES_Campania.Listar_Meses();
                if (listaE_Mes == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Mes;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Meses] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion Provincia
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre metodo , agrego parametros 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Provincia> listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento(string CodCampania, string codpais, string codOficina,string coddepartamento)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Provincia> listaE_Provincia = new List<E_Provincia>();
                listaE_Provincia = oD_GES_Campania.listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento(CodCampania, codpais,codOficina, coddepartamento);
                if (listaE_Provincia == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Provincia;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion
        #region Gestion Distrito
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: Cambio nombre metodo, agrego parametros 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Distrito> listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia(string CodCampania, string codpais, string codOficina,string coddepartamento, string codProvincia)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Distrito> listaE_Distrito = new List<E_Distrito>();
                listaE_Distrito = oD_GES_Campania.listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia(CodCampania, codpais, codOficina,coddepartamento, codProvincia);
                if (listaE_Distrito == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Distrito;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion de Mallas
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre metodo y agrego parametros. 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Region> listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia(string codCampania, string codOficina, string codDepartamento, string codProvincia)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Region> listaE_Region = new List<E_Region>();
                listaE_Region = oD_GES_Campania.listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia(codCampania, codOficina, codDepartamento, codProvincia);
                if (listaE_Region == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Region;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion de Sectores
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ- Cambio nombre de metodo y agrego parametros.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Sector> listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia(string codCampania, string codRegion, string codOficina, string codDepartamento, string codProvincia)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Sector> listaE_Sector = new List<E_Sector>();
                listaE_Sector = oD_GES_Campania.listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia(codCampania, codRegion, codOficina, codDepartamento, codProvincia);
                if (listaE_Sector == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Sector;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion
        #region Gestion Rutas
        public List<E_PuntodeVentaPlanningRuta> Listar_Rutas_Por_CodCompania_CodCampania_CodPersona(string CodCompania, string CodCampania, string CodPerson) {
            try {
                List<E_PuntodeVentaPlanningRuta> oListE_PuntodeVentaPlanningRuta = new List<E_PuntodeVentaPlanningRuta>();
                oListE_PuntodeVentaPlanningRuta = oD_GES_Campania.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona(CodCompania, CodCampania, CodPerson);
                return oListE_PuntodeVentaPlanningRuta;
            }
            catch (Exception ex) {
                log.Error("[BL_GES_Campania][Listar_Rutas_Por_CodCompania_CodCampania_CodPerson] : ", ex);
                throw ex;
            }
        }

        //08/11/2012 PSA. ListarRutasDevolviendo Coordenadas y Por Fecha.
        public List<E_PuntodeVentaPlanningRuta> Listar_Rutas_Por_ComCamPerFec(string CodCompania, string CodCampania, string CodPerson, string Fecha, string Opcion)
        {
            List<E_PuntodeVentaPlanningRuta> oListE_PuntodeVentaPlanningRuta = new List<E_PuntodeVentaPlanningRuta>();
            try
            {
                oListE_PuntodeVentaPlanningRuta = oD_GES_Campania.Listar_Rutas_Por_ComCamPerFec(CodCompania, CodCampania, CodPerson, Fecha,Opcion);   
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][Listar_Rutas_Por_ComCamPerFec_Failed] : ", ex);
                throw ex;
            }
            return oListE_PuntodeVentaPlanningRuta;
        }


        public string updateRuta(string nroRuta,string fecha_inicio,string fecha_fin )
        {
            try
            {
                return oD_GES_Campania.updateRuta(nroRuta,fecha_inicio,fecha_fin);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][updateRuta] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public string actualizarEstadoRuta(string nroRuta,int valor)//1(Habilita) 2(Inhabilita)
        {
            try
            {
                return oD_GES_Campania.actualizarEstadoRuta(nroRuta,valor);

            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania][deleteRutas] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion

        #region Gestion de Cadenas
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       28/09/2012
        /// Descripción: Método que devuelve las Cadenas por Campaña y Generador
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<E_NodeComercial> Listar_Cadenas(string CodCampania, string CodGenerador, string FechaRelevo)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_NodeComercial> listaE_NodeComercial = new List<E_NodeComercial>();
                listaE_NodeComercial = oD_GES_Campania.Listar_Cadenas(CodCampania, CodGenerador, FechaRelevo);
                if (listaE_NodeComercial == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_NodeComercial;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Cadenas] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion

        #region Gestion de Obtener Nro OC
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       25/10/2012
        /// Descripción: Método que devuelve el correlativo de OC
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public E_Correlativo obtener_NroOrdenCompra(string Tipo_Doc)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                E_Correlativo listaE_OrdenCompra = new E_Correlativo();
                listaE_OrdenCompra = oD_GES_Campania.obtener_NroOrdenCompra(Tipo_Doc);
                if (listaE_OrdenCompra == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_OrdenCompra;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [obtener_NroOrdenCompra] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion

        #region Gestion de Menu Datamercaderista
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       16/10/2012
        /// Descripción: Método que devuelve los Menu Datamercaderista
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<E_MenuDatamercaderista> Listar_Menu_Datamercaderista(string idmodulo)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_MenuDatamercaderista> listaE_MenuDatamercaderista = new List<E_MenuDatamercaderista>();
                listaE_MenuDatamercaderista = oD_GES_Campania.Listar_Menu_Datamercaderista(idmodulo);
                if (listaE_MenuDatamercaderista == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_MenuDatamercaderista;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Menu_Datamercaderista] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion

        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        #region Planning
        #endregion

        #region Gestion de PDVCadenas
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       28/09/2012
        /// Descripción: Método que devuelve los PDV por Campaña, Cadena y Mercaderista
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena(string CodCampania, string CodGenerador,string CodCadena,string FechaRelevo)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_PuntoDeVenta> listaE_PuntoDeVenta = new List<E_PuntoDeVenta>();
                listaE_PuntoDeVenta = oD_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena(CodCampania, CodGenerador, CodCadena, FechaRelevo);
                if (listaE_PuntoDeVenta == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_PuntoDeVenta;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion

        #region Gestion de Parametros
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       30/10/2012
        /// Descripción: Método que devuelve el valor de un parametro
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public E_Parametros obtener_Parametro(string Tipo)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                E_Parametros listaE_Parametros = new E_Parametros();
                listaE_Parametros = oD_GES_Campania.obtener_Parametro(Tipo);
                if (listaE_Parametros == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Parametros;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [obtener_Parametro] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion

        #region Gestion orden de compras
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha:29/10/2012
        /// Descripcion: Metodo que trae detalle de la orden compra.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_OrdenCompra> ListarOrdenCompra_Cabecera(string Nro_OC)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_OrdenCompra> listaE_OrdenCompra = new List<E_OrdenCompra>();
                listaE_OrdenCompra = oD_GES_Campania.ListarOrdenCompra_Cabecera(Nro_OC);
                if (listaE_OrdenCompra == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_OrdenCompra;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [ListarOrdenCompra_Cabecera] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        public List<E_OrdenCompraDetalle> ListarOrdenCompra_Detalle(string Nro_OC)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_OrdenCompraDetalle> listaE_OrdenCompraDet = new List<E_OrdenCompraDetalle>();
                listaE_OrdenCompraDet = oD_GES_Campania.ListarOrdenCompra_Detalle(Nro_OC);
                if (listaE_OrdenCompraDet == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_OrdenCompraDet;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [ListarOrdenCompra_Detalle] :", ex);
                throw new NegocioAmbienteException();
            }
        }
        #endregion

        #region Gestion de Proveedores
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       23/10/2012
        /// Descripción: Método que devuelve los Proveedores
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<E_Proveedor> Listar_Proveedores(string cod_prov)
        {
            try
            {
                D_GES_Campania oD_GES_Campania = new D_GES_Campania();
                List<E_Proveedor> listaE_Proveedor = new List<E_Proveedor>();
                listaE_Proveedor = oD_GES_Campania.Listar_Proveedores(cod_prov);
                if (listaE_Proveedor == null)
                {
                    throw new NegocioAmbienteException();
                }
                else
                {
                    return listaE_Proveedor;
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_GES_Campania] [Listar_Proveedores] :", ex);
                throw new NegocioAmbienteException();
            }
        }

        #endregion

        #region Gestion de Reportes
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       08/11/2012
        /// Descripción: los datos del reporte para mostrar en la grilla.
        /// </summary>
        //public List<E_Reporte_Exhibicion> Llenar_Reporte_Exhibicion(E_Filtros_Reporte oE_Filtros)
        //{
        //    try
        //    {
        //        D_GES_Campania oD_GES_Campania = new D_GES_Campania();
        //        List<E_Reporte_Exhibicion> listaReporte = new List<E_Reporte_Exhibicion>();
        //        listaReporte = oD_GES_Campania.Llenar_Reporte_Exhibicion(oE_Filtros);
        //        if (listaReporte == null)
        //        {
        //            throw new NegocioAmbienteException();
        //        }
        //        else
        //        {
        //            return listaReporte;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("[BL_GES_Campania] [Llenar_Reporte_Exhibicion] :", ex);
        //        throw new NegocioAmbienteException();
        //    }
        //}
        #endregion
    }
}
