using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Servicio;
using Lucky.Entity.Common.Application;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Servicio
{
    public class D_GES_Campania
    {
        private Conexion oCoon;
        public D_GES_Campania(){
            oCoon = new Conexion();
        }

        #region Gestion de Personal
        public List<E_Persona> Listar_Supervisor_Por_CodCampania(string CodCampania)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_ObtenerSupervisores_Por_CodCampania", CodCampania);
            List<E_Persona> listaSupervisor = new List<E_Persona>();
            try
            {
                while (readerObj.Read())
                {
                    E_Persona oE_Persona = new E_Persona();
                    oE_Persona.Person_id = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Person_idSupe")).ToString().Trim());
                    oE_Persona.Person_NameComplet = readerObj.GetValue(readerObj.GetOrdinal("Person_NameComplet")).ToString().Trim();
                    listaSupervisor.Add(oE_Persona);
                }
                readerObj.Close();

                if (listaSupervisor.Count <= 0)
                {
                    E_Persona oE_Persona = new E_Persona();
                    oE_Persona.Person_id = 0;
                    oE_Persona.Person_NameComplet = "Sin Datos Disponibles";
                    listaSupervisor.Add(oE_Persona);
                }

            }
            catch (Exception ex)
            {
                E_Persona oE_Persona = new E_Persona();
                oE_Persona.Person_id = 0;
                oE_Persona.Person_NameComplet = "Error: " + ex.Message;
                listaSupervisor.Add(oE_Persona);
            }
            return listaSupervisor;
        }

        #region Disabled
        //public List<E_Persona> Listar_Generadores_Por_CodSupervisor(string CodSupervisor) {
        //    IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_Generadores_por_CodSupervisor", CodSupervisor);
        //    List<E_Persona> listaGenerador = new List<E_Persona>();
        //    try
        //    {
        //        while (readerObj.Read())
        //        {
        //            E_Persona oE_Persona = new E_Persona();
        //            oE_Persona.Person_id = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Person_id")).ToString().Trim());
        //            oE_Persona.Person_NameComplet = readerObj.GetValue(readerObj.GetOrdinal("Person_NameComplet")).ToString().Trim();
        //            listaGenerador.Add(oE_Persona);
        //        }
        //        readerObj.Close();
        //        if (listaGenerador.Count <= 0) {
        //            E_Persona oE_Persona = new E_Persona();
        //            oE_Persona.Person_id = 0;
        //            oE_Persona.Person_NameComplet = "Sin Datos Disponibles";
        //            listaGenerador.Add(oE_Persona);
        //        }

        //    }
        //    catch (Exception ex) {
        //        E_Persona oE_Persona = new E_Persona();
        //        oE_Persona.Person_id = 0;
        //        oE_Persona.Person_NameComplet = "Error: " + ex.Message;
        //        listaGenerador.Add(oE_Persona);
        //    }
        //    return listaGenerador;    
        //}
        #endregion

        #region Lista de Mercaderista Por Camp,Dpto,Prov,Dist.
        //---Ok ...
        //---Descripcion    : Listar Generadores por CodCampania Dpto Prov Distric FechaRel
        //---Fecha          : 04/10/2012 PCP
        public List<E_Persona> Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel(string CodCampania, string CodDpto, string CodProv, string CodDist, string FechaRel)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_GeneradoresxCodCampxDptoxProvxDistxFecRel", CodCampania, CodDpto, CodProv, CodDist, FechaRel);
             
            List<E_Persona> listaGenerador = new List<E_Persona>();
            try
            {
                while (readerObj.Read())
                {
                    E_Persona oE_Persona = new E_Persona();
                    oE_Persona.Person_id = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Person_id")).ToString().Trim());
                    oE_Persona.Person_NameComplet = readerObj.GetValue(readerObj.GetOrdinal("Person_NameComplet")).ToString().Trim();
                    listaGenerador.Add(oE_Persona);
                }
                readerObj.Close();
                //if (listaGenerador.Count <= 0)
                //{
                //    E_Persona oE_Persona = new E_Persona();
                //    oE_Persona.Person_id = 0;
                //    oE_Persona.Person_NameComplet = "Sin Datos Disponibles";
                //    listaGenerador.Add(oE_Persona);
                //}

            }
            catch (Exception ex)
            {
                E_Persona oE_Persona = new E_Persona();
                oE_Persona.Person_id = 0;
                oE_Persona.Person_NameComplet = "Error: " + ex.Message;
                listaGenerador.Add(oE_Persona);
            }
            return listaGenerador;
        }

        #endregion

        //---Ok ...
        //---Descripcion    : Listar Generadores por CodCampania CodSupervisor
        //---Fecha          : 11/05/2012 PSA
        public List<E_Persona> Listar_Generadores_Por_CodCampania_FechaRelevo(string CodCampania, string FechaRelevo)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_Generadores_por_CodCampania_Fch_Relevo", CodCampania, FechaRelevo);

            List<E_Persona> listaGenerador = new List<E_Persona>();
            try
            {
                while (readerObj.Read())
                {
                    E_Persona oE_Persona = new E_Persona();
                    oE_Persona.Person_id = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Person_id")).ToString().Trim());
                    oE_Persona.Person_NameComplet = readerObj.GetValue(readerObj.GetOrdinal("Person_NameComplet")).ToString().Trim();
                    listaGenerador.Add(oE_Persona);
                }
                readerObj.Close();
                //if (listaGenerador.Count <= 0)
                //{
                //    E_Persona oE_Persona = new E_Persona();
                //    oE_Persona.Person_id = 0;
                //    oE_Persona.Person_NameComplet = "Sin Datos Disponibles";
                //    listaGenerador.Add(oE_Persona);
                //}

            }
            catch (Exception ex)
            {
                E_Persona oE_Persona = new E_Persona();
                oE_Persona.Person_id = 0;
                oE_Persona.Person_NameComplet = "Error: " + ex.Message;
                listaGenerador.Add(oE_Persona);
            }
            return listaGenerador;
        }

        //---Ok ...
        //---Descripcion    : Listar Generadores por CodCampania CodSupervisor
        //---Fecha          : 11/05/2012 PSA
        public List<E_Persona> Listar_Generadores_Por_CodCampania_CodSupervisor(string CodCampania, string CodSupervisor)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_Generadores_por_CodCampania_CodSupervisor", CodCampania, CodSupervisor);

            List<E_Persona> listaGenerador = new List<E_Persona>();
            try
            {
                while (readerObj.Read())
                {
                    E_Persona oE_Persona = new E_Persona();
                    oE_Persona.Person_id = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Person_id")).ToString().Trim());
                    oE_Persona.Person_NameComplet = readerObj.GetValue(readerObj.GetOrdinal("Person_NameComplet")).ToString().Trim();
                    listaGenerador.Add(oE_Persona);
                }
                readerObj.Close();
                if (listaGenerador.Count <= 0)
                {
                    E_Persona oE_Persona = new E_Persona();
                    oE_Persona.Person_id = 0;
                    oE_Persona.Person_NameComplet = "Sin Datos Disponibles";
                    listaGenerador.Add(oE_Persona);
                }

            }
            catch (Exception ex)
            {
                E_Persona oE_Persona = new E_Persona();
                oE_Persona.Person_id = 0;
                oE_Persona.Person_NameComplet = "Error: " + ex.Message;
                listaGenerador.Add(oE_Persona);
            }
            return listaGenerador;
        }
        public List<E_Persona> Listar_Generadores_Por_CodCanal_Y_CodCliente(string CodServicio, string CodCliente, string CodCanal,string año,string mes,string CodPeriodo,string CodCiudad,string CodZona)
        {
            List<E_Persona> oListPersona = new List<E_Persona>(); ;
            IDataReader readerObj;
            try
            {
                readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_Generadores_Por_CodCanal_Y_CodCliente", CodServicio, CodCliente, CodCanal,año,mes,CodPeriodo,CodCiudad,CodZona);
                while (readerObj.Read())
                {
                    E_Persona oE_Persona = new E_Persona();

                    oE_Persona.Person_id = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Person_id")).ToString());
                    oE_Persona.Person_NameComplet = readerObj.GetValue(readerObj.GetOrdinal("Person_NameComplet")).ToString();

                    oListPersona.Add(oE_Persona);
                }
                readerObj.Close();
                return oListPersona;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion de Puntos de Venta
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina(string CodCampania, string CodOficina)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_PDV_por_CodCampania_y_CodOficina", CodCampania, CodOficina);
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                while (readerObj.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    listaPDV.Add(oE_PuntoDeVenta);
                }
                readerObj.Close();

                if (listaPDV.Count <= 0)
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = "0";
                    oE_PuntoDeVenta.Pdv_Name = "Sin Datos Disponibles";
                    listaPDV.Add(oE_PuntoDeVenta);
                }

            }
            catch (Exception ex)
            {
                E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                oE_PuntoDeVenta.ClientPDV_Code = "0";
                oE_PuntoDeVenta.Pdv_Name = "Error: " + ex.Message;
                listaPDV.Add(oE_PuntoDeVenta);
            }
            return listaPDV;
        }
        //Descripcion:  Listar los Puntos de Venta por CodCampania, CodOficina y CodGenerador: 
        //              Campo  Obligatorio  : CodCampania,
        //              Campos Opcionales   : CodOficina, CodGenerador
        //Fecha:        03/05/2012 PSA
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador(string CodCampania, string CodOficina, string CodGenerador)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_PDV_por_CodCampania_CodOficina_CodGenerador", CodCampania, CodOficina, CodGenerador);
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                while (readerObj.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    listaPDV.Add(oE_PuntoDeVenta);
                }
                readerObj.Close();

                if (listaPDV.Count <= 0)
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = "0";
                    oE_PuntoDeVenta.Pdv_Name = "Sin Datos Disponibles";
                    listaPDV.Add(oE_PuntoDeVenta);
                }

            }
            catch (Exception ex)
            {
                E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                oE_PuntoDeVenta.ClientPDV_Code = "0";
                oE_PuntoDeVenta.Pdv_Name = "Error: " + ex.Message;
                listaPDV.Add(oE_PuntoDeVenta);
            }
            return listaPDV;
        }

        //Descripcion:  Listar los Puntos de Venta por CodCampania, CodOficina y CodGenerador: 
        //              Campo  Obligatorio  : CodCampania,
        //              Campos Opcionales   : CodOficina, CodGenerador
        //Fecha:        03/05/2012 PSA
        public List<E_PuntoDeVenta> Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha(string CodCampania, string CodDpto, string CodProv, string CodDist, string CodGenerador, string FechaRelevo)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_PDV_por_CodCampania_CodDpto_CodProv_CodDist_Fecha_Generador", CodCampania, CodDpto, CodProv, CodDist, CodGenerador, FechaRelevo);
            List<E_PuntoDeVenta> listaPDV = new List<E_PuntoDeVenta>();
            try
            {
                while (readerObj.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    listaPDV.Add(oE_PuntoDeVenta);
                }
                readerObj.Close();

                //if (listaPDV.Count <= 0)
                //{
                //    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                //    oE_PuntoDeVenta.ClientPDV_Code = "0";
                //    oE_PuntoDeVenta.Pdv_Name = "Sin Datos Disponibles";
                //    listaPDV.Add(oE_PuntoDeVenta);
                //}

            }
            catch (Exception ex)
            {
                E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                oE_PuntoDeVenta.ClientPDV_Code = "0";
                oE_PuntoDeVenta.Pdv_Name = "Error: " + ex.Message;
                listaPDV.Add(oE_PuntoDeVenta);
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
        /// <param name="CodCadena"></param>
        /// <returns></returns>
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena(string CodCampania, string CodOficina, string CodCadena)
        {
            try
            {
                List<E_PuntoDeVenta> listaPuntosVenta = new List<E_PuntoDeVenta>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_PDV_CODCAMPANIA_CODOFICINA_CODCADENA", CodCampania, CodOficina, CodCadena);
                while (readerObj.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    listaPuntosVenta.Add(oE_PuntoDeVenta);
                }
                readerObj.Close();

                if (listaPuntosVenta.Count > 0)
                {
                    return listaPuntosVenta;
                }
                else
                {
                    //if (listaPuntosVenta.Count <= 0)
                    //{
                        E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                        oE_PuntoDeVenta.ClientPDV_Code = "0";
                        oE_PuntoDeVenta.Pdv_Name = "Sin Datos Disponibles";
                        listaPuntosVenta.Add(oE_PuntoDeVenta);
                    //}
                    return listaPuntosVenta;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena(string CodCampania, string CodCiudad, string CodCadena)
        {
            try
            {
                List<E_PuntoDeVenta> listaPuntosVenta = new List<E_PuntoDeVenta>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_PDV_CODCAMPANIA_CODCIUDAD_CODCADENA", CodCampania, CodCiudad, CodCadena);
                while (readerObj.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    listaPuntosVenta.Add(oE_PuntoDeVenta);
                }
                readerObj.Close();

                if (listaPuntosVenta.Count > 0)
                {
                    return listaPuntosVenta;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
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
            try
            {
                List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_XPL_GES_CAM_OBTENER_PUNTODEVENTA_POR_CODCAMPANIA_CODDEPARTAMENTO_CODPROVINCIA_NODECOMMERCIAL", CodCampania, CodDepartamento, CodProvincia, CodNodeCommercial);
                while (readerObj.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    oListE_PuntoDeVenta.Add(oE_PuntoDeVenta);
                }
                if (oListE_PuntoDeVenta.Count > 0)
                {
                    return oListE_PuntoDeVenta;
                }
                else
                {
                    return null;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_PuntodeVentaPlanning> listarPuntodeVentaPlanning( string codOficina,string codDpto, string codProvincia,
            string codDistrito, string codtipoagrupacion, string codagrupacion, string codregion, string codzona)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_PuntodeVentaPlanning> listaE_PuntodeVentaPlanning = new List<E_PuntodeVentaPlanning>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_PDV_CodOficinaCodDepCodProCodDisCodTNodoCodNodoCodMalCodSec", codOficina, codDpto, codProvincia ?? "0", codDistrito ?? "0", codtipoagrupacion ?? "0", codagrupacion ?? "0", codregion ?? "0", codzona ?? "0");//cambiar nombre store
                
                while (readerObj.Read())
                {
                    E_PuntodeVentaPlanning oE_PuntodeVentaPlanning = new E_PuntodeVentaPlanning();
                    oE_PuntodeVentaPlanning.codPdv = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntodeVentaPlanning.nombrePdv = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    oE_PuntodeVentaPlanning.direccionPdv = readerObj.GetValue(readerObj.GetOrdinal("pdv_Address")).ToString().Trim();
                    oE_PuntodeVentaPlanning.regionPdv = readerObj.GetValue(readerObj.GetOrdinal("malla")).ToString().Trim();
                    oE_PuntodeVentaPlanning.zonapdv = readerObj.GetValue(readerObj.GetOrdinal("Sector")).ToString().Trim();
                    listaE_PuntodeVentaPlanning.Add(oE_PuntodeVentaPlanning);
                }
                readerObj.Close();

                if (listaE_PuntodeVentaPlanning.Count > 0)
                {
                    return listaE_PuntodeVentaPlanning;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        /// <summary>
        /// Autor:Pablo Salas A.
        /// Fecha:26/09/2012
        /// Descripcion: ListarPuntos de Venta por CodCompania.
        /// </summary>
        /// <param name="CodCompania"></param>
        /// <returns></returns>
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCompania(string CodCompania) {
            try {
                List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
                oCoon = new Conexion(1);
                DataTable dt = oCoon.ejecutarDataTable("SP_XPL_GES_CAM_OBTENER_PDV_POR_CodCompania", CodCompania);
                if (dt.Rows.Count > 0) { 
                    for (int i = 0; i < dt.Rows.Count; i++) {
                        E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                        oE_PuntoDeVenta.ClientPDV_Code = dt.Rows[i]["ClientPDV_Code"].ToString();
                        oE_PuntoDeVenta.Pdv_Name = dt.Rows[i]["pdv_Name"].ToString();
                        oListE_PuntoDeVenta.Add(oE_PuntoDeVenta);
                    }
                }
                return oListE_PuntoDeVenta;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        #endregion
        #region Gestion de Canales
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
                List<E_Canal> listaCanal = new List<E_Canal>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_CANAL_POR_CODCLIENTE_CODPERSONA_Y_CODOFICINA", CodCliente, CodPersona, CodOficina);
                while (readerObj.Read())
                {
                    E_Canal oE_Canal = new E_Canal();
                    oE_Canal.Cod_Channel = readerObj.GetValue(readerObj.GetOrdinal("Cod_Canal")).ToString().Trim();
                    oE_Canal.Channel_Name = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Canal")).ToString().Trim();
                    listaCanal.Add(oE_Canal);
                }
                readerObj.Close();

                if (listaCanal.Count > 0)
                {
                    return listaCanal;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<E_Canal> Listar_Canales_Por_CodCompania(string CodCompania)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_ObtenerCanales_Por_CodCompania", CodCompania);
            List<E_Canal> listaCanal = new List<E_Canal>();
            try
            {
                while (readerObj.Read())
                {
                    E_Canal oE_Canal = new E_Canal();
                    oE_Canal.Cod_Channel = readerObj.GetValue(readerObj.GetOrdinal("Cod_Channel")).ToString().Trim();
                    oE_Canal.Channel_Name = readerObj.GetValue(readerObj.GetOrdinal("Channel_Name")).ToString().Trim();
                    listaCanal.Add(oE_Canal);
                }
                readerObj.Close();

                if (listaCanal.Count <= 0)
                {
                    E_Canal oE_Canal = new E_Canal();
                    oE_Canal.Cod_Channel = "0";
                    oE_Canal.Channel_Name = "Sin Datos Disponibles";
                    listaCanal.Add(oE_Canal);
                }

            }
            catch (Exception ex)
            {

                E_Canal oE_Canal = new E_Canal();
                oE_Canal.Cod_Channel = "0";
                oE_Canal.Channel_Name = "" + ex.Message;
                listaCanal.Add(oE_Canal);
            }
            return listaCanal;
        }
        
        #endregion
        #region Gestion de Campania
        public List<E_Campania> Listar_Campania_Por_CodCanal_y_CodCompania(string CodCanal, string CodCompania)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_COMBO_PLANNING", CodCanal, CodCompania);
            List<E_Campania> listaCampania = new List<E_Campania>();
            try
            {
                while (readerObj.Read())
                {
                    E_Campania oE_Campania = new E_Campania();
                    oE_Campania.Id_planning = readerObj.GetValue(readerObj.GetOrdinal("id_planning")).ToString().Trim();
                    oE_Campania.Planning_Name = readerObj.GetValue(readerObj.GetOrdinal("Planning_Name")).ToString().Trim();
                    listaCampania.Add(oE_Campania);
                }
                readerObj.Close();

                if (listaCampania.Count <= 0)
                {
                    E_Campania oE_Campania = new E_Campania();
                    oE_Campania.Id_planning = "0";
                    oE_Campania.Planning_Name = "Sin Datos Disponibles";
                    listaCampania.Add(oE_Campania);
                }

            }
            catch (Exception ex)
            {
                E_Campania oE_Campania = new E_Campania();
                oE_Campania.Id_planning = "0";
                oE_Campania.Planning_Name = "" + ex.Message;
                listaCampania.Add(oE_Campania);
            }

            return listaCampania;
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public string registrarPlanning(E_Planning oE_Planning)
        {
            string error = string.Empty;
            try
            {
                Conexion ocon = new Conexion();
                //Update 12/11/2012 psa.
                string a = oCoon.ejecutarConRetorno("UP_WebXpl_Pla_SavUpd",
                    oE_Planning.idPlanning,
                    oE_Planning.CodBudget,
                    oE_Planning.Planning_Name,
                    oE_Planning.CodStrategia,
                    oE_Planning.codCanal,
                    oE_Planning.FechaInicio,
                    oE_Planning.FechaFin,
                    oE_Planning.Contacto,
                    oE_Planning.AreaInvolucrada,
                    oE_Planning.objetivo,
                    oE_Planning.mandatorio,
                    oE_Planning.mecanica,
                    oE_Planning.NameUser,
                    oE_Planning.Opcion);
                error = "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }
            return error;
        }
        #endregion
        #region Gestion de Reportes
        public List<E_Reporte> Listar_Reporte_Por_CodCampania(string CodCampania)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_ObtenerReportes_Por_CodCampania", CodCampania);
            List<E_Reporte> listaReporte = new List<E_Reporte>();
            try
            {
                while (readerObj.Read())
                {
                    E_Reporte oE_Reporte = new E_Reporte();
                    oE_Reporte.Report_Id = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Report_Id")).ToString().Trim());
                    oE_Reporte.Report_NameReport = readerObj.GetValue(readerObj.GetOrdinal("Report_NameReport")).ToString().Trim();
                    listaReporte.Add(oE_Reporte);
                }
                readerObj.Close();
                if (listaReporte.Count <= 0)
                {
                    E_Reporte oE_Reporte = new E_Reporte();
                    oE_Reporte.Report_Id = 0;
                    oE_Reporte.Report_NameReport = "Sin Datos Disponibles";
                    listaReporte.Add(oE_Reporte);
                }
            }
            catch (Exception ex)
            {
                E_Reporte oE_Reporte = new E_Reporte();
                oE_Reporte.Report_Id = 0;
                oE_Reporte.Report_NameReport = "Error: " + ex.Message;
                listaReporte.Add(oE_Reporte);
            }

            return listaReporte;
        }
        #endregion
        #region Gestion de Categoria
        public List<E_Categoria> Listar_Categoria_Por_CodCampania_y_CodReporte(string CodCampania, string CodReporte)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_ObtenerCategorias_Por_CodCampania_y_CodReporte", CodCampania, CodReporte);
            List<E_Categoria> listaCategoria = new List<E_Categoria>();
            try
            {
                while (readerObj.Read())
                {
                    E_Categoria oE_Categoria = new E_Categoria();
                    oE_Categoria.Id_ProductCategory = readerObj.GetValue(readerObj.GetOrdinal("id_ProductCategory")).ToString().Trim();
                    oE_Categoria.Product_Category = readerObj.GetValue(readerObj.GetOrdinal("Product_Category")).ToString().Trim();
                    listaCategoria.Add(oE_Categoria);
                }
                readerObj.Close();

                if (listaCategoria.Count <= 0)
                {
                    E_Categoria oE_Categoria = new E_Categoria();
                    oE_Categoria.Id_ProductCategory = "0";
                    oE_Categoria.Product_Category = "Sin Datos Disponibles";
                    listaCategoria.Add(oE_Categoria);
                }

            }
            catch (Exception ex)
            {
                E_Categoria oE_Categoria = new E_Categoria();
                oE_Categoria.Id_ProductCategory = "0";
                oE_Categoria.Product_Category = "Error: " + ex.Message;
                listaCategoria.Add(oE_Categoria);
            }

            return listaCategoria;
        }

        public List<E_Categoria> Listar_Categoria_Por_CodCampania(string CodCampania)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_COMBO_CATEGORIA_DE_PRODUCTO_REPORT_EXHIBICION", CodCampania);
            List<E_Categoria> listaCategoria = new List<E_Categoria>();
            try
            {
                while (readerObj.Read())
                {
                    E_Categoria oE_Categoria = new E_Categoria();
                    oE_Categoria.Id_ProductCategory = readerObj.GetValue(readerObj.GetOrdinal("id_ProductCategory")).ToString().Trim();
                    oE_Categoria.Product_Category = readerObj.GetValue(readerObj.GetOrdinal("Product_Category")).ToString().Trim();
                    listaCategoria.Add(oE_Categoria);
                }
                readerObj.Close();

                if (listaCategoria.Count <= 0)
                {
                    E_Categoria oE_Categoria = new E_Categoria();
                    oE_Categoria.Id_ProductCategory = "0";
                    oE_Categoria.Product_Category = "Sin Datos Disponibles";
                    listaCategoria.Add(oE_Categoria);
                }

            }
            catch (Exception ex)
            {
                E_Categoria oE_Categoria = new E_Categoria();
                oE_Categoria.Id_ProductCategory = "0";
                oE_Categoria.Product_Category = "Error: " + ex.Message;
                listaCategoria.Add(oE_Categoria);
            }

            return listaCategoria;
        }
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
                List<E_Categoria> listaCategoria = new List<E_Categoria>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_CATEGORIA_POR_CODCLIENTE_Y_CODCANAL_Y_CODREPORTE", CodCliente, CodCanal, CodReporte);
                while (readerObj.Read())
                {
                    E_Categoria oE_Categoria = new E_Categoria();
                    oE_Categoria.Id_ProductCategory = readerObj.GetValue(readerObj.GetOrdinal("Cod_Categoria")).ToString().Trim();
                    oE_Categoria.Product_Category = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Categoria")).ToString().Trim();
                    listaCategoria.Add(oE_Categoria);
                }
                readerObj.Close();

                if (listaCategoria.Count > 0)
                {
                    return listaCategoria;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
        #region Gestion de Marcas
        public List<E_Marca> Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria(string CodCampania, string CodReporte, string CodCategoria)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_ObtenerMarcas_Por_CodCampania_y_CodReporte_y_CodCategoria", CodCampania, CodReporte, CodCategoria);
            List<E_Marca> listaMarca = new List<E_Marca>();
            try
            {
                while (readerObj.Read())
                {
                    E_Marca oE_Marca = new E_Marca();
                    oE_Marca.Id_Brand = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("id_brand")).ToString().Trim());
                    oE_Marca.Name_Brand = readerObj.GetValue(readerObj.GetOrdinal("name_brand")).ToString().Trim();
                    listaMarca.Add(oE_Marca);
                }
                readerObj.Close();

                if (listaMarca.Count <= 0)
                {
                    E_Marca oE_Marca = new E_Marca();
                    oE_Marca.Id_Brand = 0;
                    oE_Marca.Name_Brand = "Sin Datos Disponibles";
                    listaMarca.Add(oE_Marca);
                }

            }
            catch (Exception ex)
            {
                E_Marca oE_Marca = new E_Marca();
                oE_Marca.Id_Brand = 0;
                oE_Marca.Name_Brand = "Error: " + ex.Message;
                listaMarca.Add(oE_Marca);
            }
            return listaMarca;
        }

        public List<E_Marca> Listar_Marca_Por_CodCategoria(string CodCategoria)
        {
            SqlDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_COMBO_MARCA_REPORT_EXHIBICION", CodCategoria);
            List<E_Marca> listaMarca = new List<E_Marca>();
            try
            {
                while (readerObj.Read())
                {
                    E_Marca oE_Marca = new E_Marca();
                    oE_Marca.Id_Brand = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("id_brand")).ToString().Trim());
                    oE_Marca.Name_Brand = readerObj.GetValue(readerObj.GetOrdinal("name_brand")).ToString().Trim();
                    listaMarca.Add(oE_Marca);
                }
                readerObj.Close();

                if (listaMarca.Count <= 0)
                {
                    E_Marca oE_Marca = new E_Marca();
                    oE_Marca.Id_Brand = 0;
                    oE_Marca.Name_Brand = "Sin Datos Disponibles";
                    listaMarca.Add(oE_Marca);
                }

            }
            catch (Exception ex)
            {
                E_Marca oE_Marca = new E_Marca();
                oE_Marca.Id_Brand = 0;
                oE_Marca.Name_Brand = "Error: " + ex.Message;
                listaMarca.Add(oE_Marca);
            }
            return listaMarca;
        }

        #endregion
        #region Gestion de Oficinas
        public List<E_Oficina> Listar_Oficinas_Por_CodCampania(string CodCampania)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_Oficinas_por_CodCampania", CodCampania);
            List<E_Oficina> listaOficina = new List<E_Oficina>();
            try
            {
                while (readerObj.Read())
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = Convert.ToInt64(readerObj.GetValue(readerObj.GetOrdinal("cod_Oficina")).ToString().Trim());
                    oE_Oficina.Name_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Name_Oficina")).ToString().Trim();
                    listaOficina.Add(oE_Oficina);
                }
                readerObj.Close();
                if (listaOficina.Count <= 0)
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = 0;
                    oE_Oficina.Name_Oficina = "Sin Datos Disponibles";
                    listaOficina.Add(oE_Oficina);
                }
            }
            catch (Exception ex)
            {
                E_Oficina oE_Oficina = new E_Oficina();
                oE_Oficina.Cod_Oficina = 0;
                oE_Oficina.Name_Oficina = "Error: " + ex.Message;
                listaOficina.Add(oE_Oficina);
            }

            return listaOficina;
        }
        #endregion
        #region Gestion de NodoCommercial
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
                List<E_Cadena> listaCadena = new List<E_Cadena>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_CADENA_POR_CODCAMPANIA_CODOFICINA", CodCampania, CodOficina);
                while (readerObj.Read())
                {
                    E_Cadena oE_Cadena = new E_Cadena();
                    oE_Cadena.Cod_Cadena = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Cod_Cadena")).ToString().Trim());
                    oE_Cadena.Nombre_Cadena = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Cadena")).ToString().Trim();
                    listaCadena.Add(oE_Cadena);
                }
                readerObj.Close();

                if (listaCadena.Count > 0)
                {
                    return listaCadena;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<E_Cadena> Listar_Cadena_Por_CodCliente_y_CodCanal(string CodCliente, string CodCanal)
        {
            try
            {
                List<E_Cadena> listaCadena = new List<E_Cadena>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_CADENA_POR_CODCLIENTE_CODCANAL", CodCliente, CodCanal);
                while (readerObj.Read())
                {
                    E_Cadena oE_Cadena = new E_Cadena();
                    oE_Cadena.Cod_Cadena = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Cod_Cadena")).ToString().Trim());
                    oE_Cadena.Nombre_Cadena = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Cadena")).ToString().Trim();
                    listaCadena.Add(oE_Cadena);
                }
                readerObj.Close();

                if (listaCadena.Count > 0)
                {
                    return listaCadena;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Autor: Carlos Marin
        /// Fecha: 06/06/2012
        /// Descripción: Método que devuelve las cadenas por código de campaña y codigo de la Ciudad
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodOficina"></param>
        /// <returns></returns>
        public List<E_NodeComercial> Listar_NodeComercial_Por_CodCampania_CodCiudad(string CodCampania, string CodCiudad)
        {

            try
            {
                List<E_NodeComercial> listaNodeComercial = new List<E_NodeComercial>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_CADENA_CODCAMPANIA_CODCIUDAD", CodCampania, CodCiudad);
                while (readerObj.Read())
                {
                    E_NodeComercial oE_NodeComercial = new E_NodeComercial();
                    oE_NodeComercial.id_NodeCommercial = readerObj.GetValue(readerObj.GetOrdinal("NodeCommercial")).ToString().Trim();
                    oE_NodeComercial.commercialNodeName = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();
                    listaNodeComercial.Add(oE_NodeComercial);
                }
                readerObj.Close();

                if (listaNodeComercial.Count > 0)
                {
                    return listaNodeComercial;
                }
                else
                {
                    E_NodeComercial oE_NodeComercial = new E_NodeComercial();
                    oE_NodeComercial.id_NodeCommercial = "0";
                    oE_NodeComercial.commercialNodeName = "Sin Datos disponibles";
                    listaNodeComercial.Add(oE_NodeComercial);
                    return listaNodeComercial;
                }
            }
            catch (Exception)
            {
                return null;
            }


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
            try
            {
                List<E_NodeComercial> oListE_NodeComercial = new List<E_NodeComercial>();
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_XPL_GES_CAM_OBTENER_NODECOMMERCIAL_POR_CODCAMPANIA_CODDEPARTAMENTO_CODPROVINCIA", CodCampania, CodDepartamento, CodProvincia);
                while (readerObj.Read())
                {
                    E_NodeComercial oE_NodeComercial = new E_NodeComercial();
                    oE_NodeComercial.id_NodeCommercial = readerObj.GetValue(readerObj.GetOrdinal("NODECOMMERCIAL")).ToString().Trim();
                    oE_NodeComercial.commercialNodeName = readerObj.GetValue(readerObj.GetOrdinal("COMMERCIALNODENAME")).ToString().Trim();
                    oListE_NodeComercial.Add(oE_NodeComercial);
                }
                if (oListE_NodeComercial.Count > 0)
                {
                    return oListE_NodeComercial;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        public List<E_NodeComercial> Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito(string CodCampania, string CodDepartamento, string CodProvincia, string CodDistrito)
        {
            try
            {
                List<E_NodeComercial> oListE_NodeComercial = new List<E_NodeComercial>();
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_XPL_GES_CAM_OBTENER_NODECOMMERCIAL_POR_CAMPANIA_DEPARTAMENTO_PROVINCIA_DISTRITO", CodCampania, CodDepartamento, CodProvincia, CodDistrito);
                while (readerObj.Read())
                {
                    E_NodeComercial oE_NodeComercial = new E_NodeComercial();
                    oE_NodeComercial.id_NodeCommercial = readerObj.GetValue(readerObj.GetOrdinal("NODECOMMERCIAL")).ToString().Trim();
                    oE_NodeComercial.commercialNodeName = readerObj.GetValue(readerObj.GetOrdinal("COMMERCIALNODENAME")).ToString().Trim();
                    oListE_NodeComercial.Add(oE_NodeComercial);
                }
                if (oListE_NodeComercial.Count > 0)
                {
                    return oListE_NodeComercial;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre método, agrego parametros codOficina,string codDepartamento, string codProvincia 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_NodeComercial_Type> listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia(string CodCampania,string codOficina,string codDepartamento, string codProvincia)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_NodeComercial_Type> listaE_NodeComercial_Type = new List<E_NodeComercial_Type>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_TNodo_Por_CodCampaniaCodOficinaCodDptoCodProvincia", CodCampania, codOficina, codDepartamento, codProvincia);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_NodeComercial_Type oE_NodeComercial_Type = new E_NodeComercial_Type();
                    oE_NodeComercial_Type.idNodeComType = readerObj.GetValue(readerObj.GetOrdinal("idNodeComType")).ToString().Trim();
                    oE_NodeComercial_Type.NodeComType_name = readerObj.GetValue(readerObj.GetOrdinal("NodeComType_name")).ToString().Trim();
                    listaE_NodeComercial_Type.Add(oE_NodeComercial_Type);
                }
                readerObj.Close();

                if (listaE_NodeComercial_Type.Count > 0)
                {
                    return listaE_NodeComercial_Type;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre de método, agrego pE codOficina,string codDepartamento, string codProvincia 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_NodeComercial> listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia(string CodCampania, string idNodeComercial_Type, string codOficina, string codDepartamento, string codProvincia)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_NodeComercial> listaE_NodeComercial = new List<E_NodeComercial>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_NodoCommercial_Por_CodCampaCodTNodoCodOficinaCodDptoCodProvincia", CodCampania, idNodeComercial_Type, codOficina, codDepartamento, codProvincia);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_NodeComercial oE_NodeComercial = new E_NodeComercial();
                    oE_NodeComercial.id_NodeCommercial = readerObj.GetValue(readerObj.GetOrdinal("NodeCommercial")).ToString().Trim();
                    oE_NodeComercial.commercialNodeName = readerObj.GetValue(readerObj.GetOrdinal("CommercialNodeName")).ToString().Trim();
                    listaE_NodeComercial.Add(oE_NodeComercial);
                }
                readerObj.Close();

                if (listaE_NodeComercial.Count > 0)
                {
                    return listaE_NodeComercial;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
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
                List<E_SubCategoria> listaSubCategoria = new List<E_SubCategoria>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_SUBCATEGORIA_POR_CODCATEGORIA", CodCategoria);
                while (readerObj.Read())
                {
                    E_SubCategoria oE_SubCategoria = new E_SubCategoria();
                    oE_SubCategoria.Cod_SubCategoria = readerObj.GetValue(readerObj.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                    oE_SubCategoria.Nombre_SubCategoria = readerObj.GetValue(readerObj.GetOrdinal("Nombre_SubCategoria")).ToString().Trim();
                    listaSubCategoria.Add(oE_SubCategoria);
                }
                readerObj.Close();

                if (listaSubCategoria.Count > 0)
                {
                    return listaSubCategoria;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
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
                oCoon = new Conexion(1);
                List<E_Producto> listaProducto = new List<E_Producto>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_PRODUCTO_POR_CODCAMPANIA_CODCATEGORIA_CODSUBCATEGORIA_CODMARCA", CodCampania, CodCategoria, CodSubCategoria, CodMarca);
                while (readerObj.Read())
                {
                    E_Producto oE_Producto = new E_Producto();
                    oE_Producto.Cod_Producto = readerObj.GetValue(readerObj.GetOrdinal("Cod_Producto")).ToString().Trim();
                    oE_Producto.Nombre_Producto = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Producto")).ToString().Trim();
                    listaProducto.Add(oE_Producto);
                }
                readerObj.Close();

                if (listaProducto.Count > 0)
                {
                    return listaProducto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 09/08/2012
        /// Descripción: Método que devuelve los productos por código de campaña, código de cliente,código de categoría, código de subcategoría, código de marca
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Producto> ListarProducto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca(string CodCampania, string CodCliente, string CodCategoria, string CodSubCategoria, string CodMarca)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_Producto> listaProducto = new List<E_Producto>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_PRODUCTO_POR_CODCAMPANIA_CODCLIENTE_CODCATEGORIA_CODSUBCATEGORIA_CODMARCA", CodCampania, CodCliente, CodCategoria, CodSubCategoria, CodMarca);
                while (readerObj.Read())
                {
                    E_Producto oE_Producto = new E_Producto();
                    oE_Producto.Cod_Producto = readerObj.GetValue(readerObj.GetOrdinal("Cod_Producto")).ToString().Trim();
                    oE_Producto.Nombre_Producto = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Producto")).ToString().Trim();
                    listaProducto.Add(oE_Producto);
                }
                readerObj.Close();

                if (listaProducto.Count > 0)
                {
                    return listaProducto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
        #region Gestion de Ciudad
        public List<E_Ciudad> Listar_Ciudad_Por_CodCampania(string CodCampania)
        {

            try
            {
                List<E_Ciudad> listaCiudad = new List<E_Ciudad>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_CIUDAD_CODCAMPANIA", CodCampania);
                while (readerObj.Read())
                {
                    E_Ciudad oE_Ciudad = new E_Ciudad();
                    oE_Ciudad.CodCiudad = readerObj.GetValue(readerObj.GetOrdinal("cod_City")).ToString().Trim();
                    oE_Ciudad.NomCiudad = readerObj.GetValue(readerObj.GetOrdinal("Name_City")).ToString().Trim();
                    listaCiudad.Add(oE_Ciudad);
                }
                readerObj.Close();

                if (listaCiudad.Count > 0)
                {
                    return listaCiudad;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }


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
            try
            {
                List<E_Ciudad> oListE_Ciudad = new List<E_Ciudad>();
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_XPL_GES_UBI_OBTENER_PROVINCIAS_POR_CODDEPARTAMENTO", CodDepartamento);
                while (readerObj.Read())
                {
                    E_Ciudad oE_Ciudad = new E_Ciudad();
                    oE_Ciudad.CodCiudad = readerObj.GetValue(readerObj.GetOrdinal("cod_City")).ToString().Trim();
                    oE_Ciudad.NomCiudad = readerObj.GetValue(readerObj.GetOrdinal("Name_City")).ToString().Trim();
                    oListE_Ciudad.Add(oE_Ciudad);
                }
                if (oListE_Ciudad.Count > 0)
                {
                    return oListE_Ciudad;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                List<E_Ciudad> oListE_Ciudad = new List<E_Ciudad>();
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_XPL_GES_CAM_OBTENER_PROVINCIAS_POR_CODCAMPANIA_CODDEPARTAMENTO", CodCampania, CodDepartamento);
                while (readerObj.Read())
                {
                    E_Ciudad oE_Ciudad = new E_Ciudad();
                    oE_Ciudad.CodCiudad = readerObj.GetValue(readerObj.GetOrdinal("cod_City")).ToString().Trim();
                    oE_Ciudad.NomCiudad = readerObj.GetValue(readerObj.GetOrdinal("name_City")).ToString().Trim();
                    oListE_Ciudad.Add(oE_Ciudad);
                }
                if (oListE_Ciudad.Count > 0)
                {
                    return oListE_Ciudad;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
            try
            {
                List<E_Departamento> oListE_Departamento = new List<E_Departamento>();
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_XPL_GES_CAM_OBTENER_DEPARTAMENTO_POR_CODCAMPANIA", CodCampania);
                while (readerObj.Read())
                {
                    E_Departamento oE_Departamento = new E_Departamento();
                    oE_Departamento.CodDepartamento = readerObj.GetValue(readerObj.GetOrdinal("cod_dpto")).ToString().Trim();
                    oE_Departamento.NombreDepartamento = readerObj.GetValue(readerObj.GetOrdinal("name_dpto")).ToString().Trim();
                    oListE_Departamento.Add(oE_Departamento);
                }
                if (oListE_Departamento.Count > 0)
                {
                    return oListE_Departamento;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambios: GFZ-Se cambio nombre, se agrego parametro codoficina 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_Departamento> listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina(string CodCliente, string codCampaña, string codpais,string codOficina)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_Departamento> listaDepartamento = new List<E_Departamento>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_Dpto_Por_CodCompCodCampCodPaisCodOficina", CodCliente, codCampaña, codpais, codOficina);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_Departamento oE_Departamento = new E_Departamento();
                    oE_Departamento.CodDepartamento = readerObj.GetValue(readerObj.GetOrdinal("cod_dpto")).ToString().Trim();
                    oE_Departamento.NombreDepartamento = readerObj.GetValue(readerObj.GetOrdinal("name_dpto")).ToString().Trim();
                    listaDepartamento.Add(oE_Departamento);
                }
                readerObj.Close();

                if (listaDepartamento.Count > 0)
                {
                    return listaDepartamento;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion de Provincia
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ- Cambio nombre de método, agrego parametro codOficina 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_Provincia> listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento(string codCampaña, string codpais,string codOficina, string coddepartamento)
        {

            try
            {
                oCoon = new Conexion(1);
                List<E_Provincia> listaProvincia = new List<E_Provincia>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_Prov_Por_CodCampaniaCodPaisCodOficinaCodDpto", codCampaña, codpais, codOficina, coddepartamento);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_Provincia oE_Provincia = new E_Provincia();
                    oE_Provincia.CodProvincia = readerObj.GetValue(readerObj.GetOrdinal("Cod_City")).ToString().Trim();
                    oE_Provincia.NombreProvincia = readerObj.GetValue(readerObj.GetOrdinal("Name_City")).ToString().Trim();
                    listaProvincia.Add(oE_Provincia);
                }
                readerObj.Close();

                if (listaProvincia.Count > 0)
                {
                    return listaProvincia;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
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
            try
            {
                List<E_Budget> oListBudget = new List<E_Budget>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_CAMP_OBTENER_PRESUESTOS_POR_CODCOMPANIA_CODOPCION", CodCompania, CodOpcion);

                while (readerObj.Read())
                {
                    E_Budget oE_Budget = new E_Budget();
                    oE_Budget.Number_Budget = readerObj.GetValue(readerObj.GetOrdinal("Number_ budget")).ToString().Trim();
                    oE_Budget.Name_Budget = readerObj.GetValue(readerObj.GetOrdinal("Name_budget")).ToString().Trim();
                    oListBudget.Add(oE_Budget);
                }
                readerObj.Close();

                if (oListBudget.Count > 0)
                {
                    return oListBudget;
                }
                else { return null; }

            }
            catch (Exception ex)
            {
                throw ex;
                //return null;
            }
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

            try
            {
                List<E_Budget> oListBudget = new List<E_Budget>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_CAM_OBTENER_PRESUPUESTO_POR_CODCLIENTE_CODPRESUPUESTO_CODOPCION", CodCompania, CodBudget, CodOpcion);
                while (readerObj.Read())
                {
                    E_Budget oE_Budget = new E_Budget();
                    oE_Budget.Cod_Strategy = readerObj.GetValue(readerObj.GetOrdinal("cod_Strategy")).ToString().Trim();
                    oE_Budget.Strategy_Name = readerObj.GetValue(readerObj.GetOrdinal("Strategy_Name")).ToString().Trim();
                    oE_Budget.Company_id = readerObj.GetValue(readerObj.GetOrdinal("Company_id")).ToString().Trim();
                    oE_Budget.Company_Name = readerObj.GetValue(readerObj.GetOrdinal("Company_Name")).ToString().Trim();
                    oE_Budget.Name_Budget = readerObj.GetValue(readerObj.GetOrdinal("Name_Budget")).ToString().Trim();
                    oE_Budget.Id_Planning = readerObj.GetValue(readerObj.GetOrdinal("Id_Planning")).ToString().Trim();
                    oE_Budget.Fec_IniPlanning = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_IniPlanning")));
                    oE_Budget.Fec_FinPlanning = Convert.ToDateTime(readerObj.GetValue(readerObj.GetOrdinal("Fec_FinPlanning")));
                    oE_Budget.Name_Contact = readerObj.GetValue(readerObj.GetOrdinal("Name_Contact")).ToString().Trim();
                    oListBudget.Add(oE_Budget);
                }
                if (oListBudget.Count > 0)
                {
                    return oListBudget;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region  Gestion de Reportes
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 10/09/2012
        /// Descripción: Método que devuelve los subreportes 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Sub_Reporte> Listar_Sub_Reportes(string CodReporte, string CodCompania, string CodChanel)
        {
            try
            {
                oCoon = new Conexion(4);
                List<E_Sub_Reporte> listaSubReporte = new List<E_Sub_Reporte>();
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OBTENER_SUB_REPORTE", CodReporte, CodCompania, CodChanel);
                while (readerObj.Read())
                {
                    E_Sub_Reporte oE_Sub_Reporte = new E_Sub_Reporte();
                    oE_Sub_Reporte.Cod_SubReporte = readerObj.GetValue(readerObj.GetOrdinal("id_Tipo_Reporte")).ToString().Trim();
                    oE_Sub_Reporte.Nombre_SubReporte = readerObj.GetValue(readerObj.GetOrdinal("TipoReporte_Descripcion")).ToString().Trim();
                    listaSubReporte.Add(oE_Sub_Reporte);
                }
                readerObj.Close();

                if (listaSubReporte.Count > 0)
                {
                    return listaSubReporte;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
        #region Gestion Oficina
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
                List<E_Oficina> listaOficina = new List<E_Oficina>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_OFICINA_POR_CODPERSONA", CodPersona);
                while (readerObj.Read())
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = Convert.ToInt64(readerObj.GetValue(readerObj.GetOrdinal("Cod_Oficina")).ToString().Trim());
                    oE_Oficina.Name_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Name_Oficina")).ToString().Trim();
                    listaOficina.Add(oE_Oficina);
                }
                readerObj.Close();

                if (listaOficina.Count > 0)
                {
                    return listaOficina;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Autor:       PSA
        /// Fecha:       13/06/2012
        /// Descripción: Obtiene las oficinas por Codigo de Campania y CodSupervisor.
        /// </summary>
        /// <param name="CodPersona"></param>
        /// <returns></returns>
        public List<E_Oficina> Listar_Oficinas_Por_CodCampania_Por_CodSupervisor(string CodCampania, string Cod_Supervisor)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Obtener_Oficinas_por_CodCampania_por_CodSupervisor", CodCampania, Cod_Supervisor);
            List<E_Oficina> listaOficina = new List<E_Oficina>();
            try
            {
                while (readerObj.Read())
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = Convert.ToInt64(readerObj.GetValue(readerObj.GetOrdinal("cod_Oficina")).ToString().Trim());
                    oE_Oficina.Name_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Name_Oficina")).ToString().Trim();
                    listaOficina.Add(oE_Oficina);
                }
                readerObj.Close();
                if (listaOficina.Count <= 0)
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = 0;
                    oE_Oficina.Name_Oficina = "Sin Datos Disponibles";
                    listaOficina.Add(oE_Oficina);
                }
            }
            catch (Exception ex)
            {
                E_Oficina oE_Oficina = new E_Oficina();
                oE_Oficina.Cod_Oficina = 0;
                oE_Oficina.Name_Oficina = "Error: " + ex.Message;
                listaOficina.Add(oE_Oficina);
            }

            return listaOficina;
        }
        /// <summary>
        /// Autor:       Pablo Salas A.
        /// Fecha:       31/08/2012
        /// Descripción: Obtiene las oficinas por Codigo de Compania.
        /// </summary>
        /// <param name="CodPersona"></param>
        /// <returns></returns>
        public List<E_Oficina> Listar_Oficinas_Por_CodCompania(string CodCompania)
        {

            List<E_Oficina> oListE_Oficina = new List<E_Oficina>();

            try
            {
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_AD_OBTENER_OFICINAS_BY_COMPANY", CodCompania);
                while (readerObj.Read())
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = Convert.ToInt64(readerObj.GetValue(readerObj.GetOrdinal("cod_Oficina")).ToString().Trim());
                    oE_Oficina.Name_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Name_Oficina")).ToString().Trim();
                    oListE_Oficina.Add(oE_Oficina);
                }
                readerObj.Close();
                if (oListE_Oficina.Count <= 0)
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = 0;
                    oE_Oficina.Name_Oficina = "Sin Datos Disponibles";
                    oListE_Oficina.Add(oE_Oficina);
                }

            }
            catch (Exception ex)
            { throw ex; }
            return oListE_Oficina;
        }
        /// <summary>
        /// Autor:Giam Farfán
        /// Fecha:27/09/2012
        /// Descripción: Obtner oficinas por codpais,codcliente,codcampania
        /// </summary>
        /// <param name="CodPais"></param>
        /// <param name="CodCliente"></param>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        public List<E_Oficina> Listar_Oficinas_Por_CodPais_CodCliente_CodCampania(string CodPais, string CodCliente,string CodCampania)
        {
            try
            {
                List<E_Oficina> listaOficina = new List<E_Oficina>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_CAM_OBTENER_OFICINA_POR_CodPaisCodCompaniaCodCampania", CodPais, CodCliente, CodCampania);
                while (readerObj.Read())
                {
                    E_Oficina oE_Oficina = new E_Oficina();
                    oE_Oficina.Cod_Oficina = Convert.ToInt64(readerObj.GetValue(readerObj.GetOrdinal("Cod_Oficina")).ToString().Trim());
                    oE_Oficina.Name_Oficina = readerObj.GetValue(readerObj.GetOrdinal("Name_Oficina")).ToString().Trim();
                    listaOficina.Add(oE_Oficina);
                }
                readerObj.Close();

                if (listaOficina.Count > 0)
                {
                    return listaOficina;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion Años
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
                List<E_Anio> listaAnio = new List<E_Anio>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_ANIOS");
                while (readerObj.Read())
                {
                    E_Anio oE_Anio = new E_Anio();
                    oE_Anio.anio = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Anio")).ToString().Trim());
                    listaAnio.Add(oE_Anio);
                }
                readerObj.Close();

                if (listaAnio.Count > 0)
                {
                    return listaAnio;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion Meses
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 14/05/2012
        /// Descripción: Método que devuelve los meses 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Mes> Listar_Meses()
        {
            try
            {
                List<E_Mes> listaMeses = new List<E_Mes>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_MESES");
                while (readerObj.Read())
                {
                    E_Mes oE_Mes = new E_Mes();
                    oE_Mes.numeroMes = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("numeroMes")).ToString().Trim());
                    oE_Mes.nombreMes = readerObj.GetValue(readerObj.GetOrdinal("nombreMes")).ToString().Trim();
                    listaMeses.Add(oE_Mes);
                }
                readerObj.Close();

                if (listaMeses.Count > 0)
                {
                    return listaMeses;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
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
                List<E_Periodo> listaPeriodo = new List<E_Periodo>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_PERIODO_POR_CODSERVICIO_CODCANAL_CODCLIENTE_CODREPORTE_ANIO_Y_MES", CodServicio, CodCanal, CodCliente, CodReporte, Anio, Mes);
                while (readerObj.Read())
                {
                    E_Periodo oE_Periodo = new E_Periodo();
                    oE_Periodo.Cod_Periodo = Convert.ToInt32(readerObj.GetValue(readerObj.GetOrdinal("Cod_Periodo")).ToString().Trim());
                    oE_Periodo.Descripcion = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Periodo")).ToString().Trim();
                    listaPeriodo.Add(oE_Periodo);
                }
                readerObj.Close();

                if (listaPeriodo.Count > 0)
                {
                    return listaPeriodo;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        //public List<E_Periodo> Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_V2(E_Filtros oE_Filtros){
        //try{}
        //    catch(Exception ex){}
        //}_
        #endregion
        #region Gestion Unicos

        ///Descripcion  : Listar Menús por CodPersona, dependiendo el Perfil y la Compañia de la Persona, mostrar los Reportes Asociados.
        ///Fecha        : 04/05/2012 PSA
        public List<E_Menu> Listar_Menu_Por_CodPersona(string CodPersona)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Listar_Menu_Por_CodPersona", CodPersona);
            List<E_Menu> listaMenu = new List<E_Menu>();
            try
            {
                while (readerObj.Read())
                {
                    E_Menu oE_Menu = new E_Menu();
                    oE_Menu.NombreMenu = readerObj.GetValue(readerObj.GetOrdinal("NombreMenu")).ToString().Trim();
                    oE_Menu.Pagina_URL = readerObj.GetValue(readerObj.GetOrdinal("Pagina_URL")).ToString().Trim();
                    oE_Menu.Image_URL = readerObj.GetValue(readerObj.GetOrdinal("Image_URL")).ToString().Trim();
                    listaMenu.Add(oE_Menu);
                }
                readerObj.Close();

                if (listaMenu.Count <= 0)
                {
                    E_Menu oE_Menu = new E_Menu();
                    oE_Menu.NombreMenu = "Sin Informacion";
                    oE_Menu.Pagina_URL = "Sin Informacion";
                    oE_Menu.Image_URL = "Sin Informacion";
                    listaMenu.Add(oE_Menu);
                }
            }
            catch (Exception ex)
            {
                E_Menu oE_Menu = new E_Menu();
                oE_Menu.NombreMenu = "Error: " + ex.Message;
                oE_Menu.Pagina_URL = "Sin Informacion";
                oE_Menu.Image_URL = "Sin Informacion";
                listaMenu.Add(oE_Menu);
            }
            return listaMenu;
        }
        ///Descripcion  : Llena el Reporte Stock Alicorp para que pueda registrar Cantidad y Observaciones.
        ///Fecha        : 05/05/2012 PSA
        public List<E_Reporte_Stock_Alicorp> Llenar_Reporte_Stock_Alicorp(string CodCampania, string CodReporte, string CodCategoria)
        {
            IDataReader readerObj = oCoon.ejecutarDataReader("UP_WebXplora_Llenar_Reporte_Stock_Alicorp", CodCampania, CodReporte, CodCategoria);
            List<E_Reporte_Stock_Alicorp> listaReporte = new List<E_Reporte_Stock_Alicorp>();
            try
            {
                while (readerObj.Read())
                {
                    E_Reporte_Stock_Alicorp oE_Reporte_Stock_Alicorp = new E_Reporte_Stock_Alicorp();
                    oE_Reporte_Stock_Alicorp.Id_Familia = readerObj.GetValue(readerObj.GetOrdinal("ID_FAMILIA")).ToString().Trim();
                    oE_Reporte_Stock_Alicorp.Fam_Nombre = readerObj.GetValue(readerObj.GetOrdinal("FAM_NOMBRE")).ToString().Trim();
                    oE_Reporte_Stock_Alicorp.Cantidad = readerObj.GetValue(readerObj.GetOrdinal("CANTIDAD")).ToString().Trim();
                    oE_Reporte_Stock_Alicorp.Observacion = readerObj.GetValue(readerObj.GetOrdinal("OBSERVACION")).ToString().Trim();
                    listaReporte.Add(oE_Reporte_Stock_Alicorp);
                }
                readerObj.Close();
                if (listaReporte.Count <= 0)
                {
                    E_Reporte_Stock_Alicorp oE_Reporte_Stock_Alicorp = new E_Reporte_Stock_Alicorp();
                    oE_Reporte_Stock_Alicorp.Id_Familia = "Sin Informacion";
                    oE_Reporte_Stock_Alicorp.Fam_Nombre = "Sin Informacion";
                    oE_Reporte_Stock_Alicorp.Cantidad = "Sin Informacion";
                    oE_Reporte_Stock_Alicorp.Observacion = "Sin Informacion";
                    listaReporte.Add(oE_Reporte_Stock_Alicorp);
                }
            }
            catch (Exception ex)
            {
                E_Reporte_Stock_Alicorp oE_Reporte_Stock_Alicorp = new E_Reporte_Stock_Alicorp();
                oE_Reporte_Stock_Alicorp.Id_Familia = "Error: " + ex.Message; ;
                oE_Reporte_Stock_Alicorp.Fam_Nombre = "Sin Informacion";
                oE_Reporte_Stock_Alicorp.Cantidad = "Sin Informacion";
                oE_Reporte_Stock_Alicorp.Observacion = "Sin Informacion";
                listaReporte.Add(oE_Reporte_Stock_Alicorp);
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
        //public List<E_Reporte_General> Llenar_Reporte_General(string CodCampania, string CodReporte, string CodCategoria,
        //    string CodMarca, string CodFamilia, string CodSubFamilia, string CodOficina, string CodGestor, string CodPDV)
        //{
        //    List<E_Reporte_General> listaReporte = new List<E_Reporte_General>();
        //    try
        //    {
        //        IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_DIGITACION_LLENAR_REPORTE"
        //            , CodCampania
        //            , CodReporte
        //            , CodCategoria  ?? "0"
        //            , CodMarca      ?? "0"
        //            , CodFamilia    ?? "0"
        //            , CodSubFamilia ?? "0"
        //            , CodOficina    ?? "0"
        //            , CodGestor     ?? "0"
        //            , CodPDV        ?? "0");
        //        while (readerObj.Read())
        //        {
        //            E_Reporte_General oE_Reporte_General = new E_Reporte_General();
        //            oE_Reporte_General.Cod_Oficina = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_OFICINA")).ToString().Trim();
        //            oE_Reporte_General.Nombre_Oficina = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_OFICINA")).ToString().Trim();
        //            oE_Reporte_General.CodPtoVenta = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_PTO_VENTA")).ToString().Trim();
        //            oE_Reporte_General.NombrePtoVenta = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_PTO_VENTA")).ToString().Trim();
        //            oE_Reporte_General.Cod_Categoria = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_CATEGORIA")).ToString().Trim();
        //            oE_Reporte_General.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_CATEGORIA")).ToString().Trim();
        //            oE_Reporte_General.Cod_Marca = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_MARCA")).ToString().Trim();
        //            oE_Reporte_General.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_MARCA")).ToString().Trim();
        //            oE_Reporte_General.CodElemento = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_ELEMENTO")).ToString().Trim();
        //            oE_Reporte_General.NombreElemento = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_ELEMENTO")).ToString().Trim();

        //            if (CodCampania.Equals("000361782010") && CodReporte.Equals("63"))
        //            {
        //                oE_Reporte_General.Objetivo = readerObj.GetValue(readerObj.GetOrdinal("OBJETIVO")).ToString().Trim();
        //                oE_Reporte_General.Cantidad = readerObj.GetValue(readerObj.GetOrdinal("CANTIDAD")).ToString().Trim();
        //            }

        //            listaReporte.Add(oE_Reporte_General);
        //        }
        //        readerObj.Close();

        //        if (listaReporte.Count > 0)
        //        {
        //            return listaReporte;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        /// <summary>
        /// Devuelte los datos del reporte para mostrar en la grilla.
        /// Modulos: Digitación, ...
        /// Autor: Joseph Gonzales
        /// Fecha: 10/05/2012
        /// Actualización: 16/06/2012 PSA. Se adapta el Metodo Llenar_Reporte_General para Colgate, ya que se sale del Standard Establecido para Alicorp. El nuevo nombre es Llenar_Reporte_Colgate_General y recibe una Entidad del Tipo E_Reporte_General.
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        public List<E_Reporte_General> Llenar_Reporte_General(E_Filtros_Llenar_Reporte_General oE_Filtros)
        {
            List<E_Reporte_General> listaReporte = new List<E_Reporte_General>();
            try
            {
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_DIGITACION_LLENAR_REPORTE_DELETE_backup03_08_2012"
                    , oE_Filtros.Cod_Campania
                    , oE_Filtros.Cod_Reporte
                    , oE_Filtros.Cod_Categoria ?? "0"
                    , oE_Filtros.Cod_Marca ?? "0"
                    , oE_Filtros.Cod_Familia ?? "0"
                    , oE_Filtros.Cod_SubFamilia ?? "0"
                    , oE_Filtros.Cod_Oficina ?? "0"
                    , oE_Filtros.Cod_Ciudad ?? "0"  //Add 19/06/2012 PSA
                    , oE_Filtros.Cod_Gestor ?? "0"
                    , oE_Filtros.Cod_PDV ?? "0"
                    , oE_Filtros.Cod_NodoComercial ?? "0"
                    , oE_Filtros.Cod_Anio ?? "0"
                    , oE_Filtros.Cod_Mes ?? "0"
                    , oE_Filtros.Cod_Periodo ?? "0"
                    , oE_Filtros.Cod_Departamento ?? "0" //Add 02/08/2012 PSA
                    );
                while (readerObj.Read())
                {
                    E_Reporte_General oE_Reporte_General = new E_Reporte_General();

                    if (oE_Filtros.Cod_Campania.Equals("813622482010") || oE_Filtros.Cod_Campania.Equals("0133725102010"))
                    {
                        oE_Reporte_General.Nombre_Ciudad = readerObj.GetValue(readerObj.GetOrdinal("Ciudad")).ToString().Trim();
                        oE_Reporte_General.Cod_Equipo = readerObj.GetValue(readerObj.GetOrdinal("codCampaña")).ToString().Trim();
                        oE_Reporte_General.Cod_Cadena = readerObj.GetValue(readerObj.GetOrdinal("cod_Cadena")).ToString().Trim();
                        oE_Reporte_General.Nombre_Cadena = readerObj.GetValue(readerObj.GetOrdinal("nombre_Cadena")).ToString().Trim();
                        oE_Reporte_General.CodPtoVenta = readerObj.GetValue(readerObj.GetOrdinal("cod_PDV")).ToString().Trim();
                        oE_Reporte_General.NombrePtoVenta = readerObj.GetValue(readerObj.GetOrdinal("Nombre_PDV")).ToString().Trim();
                        oE_Reporte_General.Cod_Persona = readerObj.GetValue(readerObj.GetOrdinal("cod_Persona")).ToString().Trim();
                        oE_Reporte_General.Persona_Nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre_Persona")).ToString().Trim();
                        oE_Reporte_General.Cod_SubReporte = readerObj.GetValue(readerObj.GetOrdinal("cod_Subreporte")).ToString().Trim();
                        oE_Reporte_General.SubReporte_Nombre = readerObj.GetValue(readerObj.GetOrdinal("SUBREPORTE")).ToString().Trim();
                        oE_Reporte_General.Cod_Categoria = readerObj.GetValue(readerObj.GetOrdinal("cod_Categoria")).ToString().Trim();
                        oE_Reporte_General.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("nombre_Categoria")).ToString().Trim();
                        oE_Reporte_General.Cod_MaterialApoyo = readerObj.GetValue(readerObj.GetOrdinal("cod_Pop")).ToString().Trim();
                        oE_Reporte_General.MaterialApoyo_Nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre_Pop")).ToString().Trim();
                        oE_Reporte_General.Cod_Observacion = readerObj.GetValue(readerObj.GetOrdinal("cod_Observacion")).ToString().Trim();
                        oE_Reporte_General.Observacion_Marcada = readerObj.GetValue(readerObj.GetOrdinal("Observacion")).ToString().Trim();
                        oE_Reporte_General.SKU_Producto = readerObj.GetValue(readerObj.GetOrdinal("SKU")).ToString().Trim();
                        oE_Reporte_General.Producto_Nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre_Producto")).ToString().Trim();
                    }
                    else
                    {
                        oE_Reporte_General.Cod_Oficina = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_OFICINA")).ToString().Trim();
                        oE_Reporte_General.Nombre_Oficina = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_OFICINA")).ToString().Trim();
                        oE_Reporte_General.CodPtoVenta = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_PTO_VENTA")).ToString().Trim();
                        oE_Reporte_General.NombrePtoVenta = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_PTO_VENTA")).ToString().Trim();
                        oE_Reporte_General.Cod_Categoria = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_CATEGORIA")).ToString().Trim();
                        oE_Reporte_General.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_CATEGORIA")).ToString().Trim();
                        oE_Reporte_General.Cod_Marca = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_MARCA")).ToString().Trim();
                        oE_Reporte_General.Nombre_Marca = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_MARCA")).ToString().Trim();
                        oE_Reporte_General.CodElemento = readerObj.GetValue(readerObj.GetOrdinal("CODIGO_ELEMENTO")).ToString().Trim();
                        oE_Reporte_General.NombreElemento = readerObj.GetValue(readerObj.GetOrdinal("NOMBRE_ELEMENTO")).ToString().Trim();

                        if (oE_Filtros.Cod_Campania.Equals("000361782010") && oE_Filtros.Cod_Reporte.Equals("63"))
                        {
                            oE_Reporte_General.Objetivo = readerObj.GetValue(readerObj.GetOrdinal("OBJETIVO")).ToString().Trim();
                            oE_Reporte_General.Cantidad = readerObj.GetValue(readerObj.GetOrdinal("CANTIDAD")).ToString().Trim();
                        }
                    }
                    listaReporte.Add(oE_Reporte_General);
                }
                readerObj.Close();

                if (listaReporte.Count > 0)
                {
                    return listaReporte;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Devuelte los datos del reporte para mostrar en la grilla.
        /// Modulos: Digitación, ...
        /// Autor: Peter Ccopa
        /// Fecha: 19/09/2012
        /// Se adapta el Metodo Llenar_Reporte_Bodegas para Colgate
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        public List<E_Reporte_Bodegas> Llenar_Reporte_Bodegas(E_Filtros_Llenar_Reporte_General oE_Filtros)
        {
            List<E_Reporte_Bodegas> listaReporte = new List<E_Reporte_Bodegas>();
            try
            {
                oCoon = new Conexion(1);
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_DIGITACION_LLENAR_REPORTE_X_SUBREPORTE_BODEGA_2"
                    , oE_Filtros.Cod_Campania
                    , oE_Filtros.Cod_Reporte
                    , oE_Filtros.Cod_Categoria ?? "0"
                    , oE_Filtros.Cod_Marca ?? "0"
                    , oE_Filtros.Cod_Familia ?? "0"
                    , oE_Filtros.Cod_SubFamilia ?? "0"
                    , oE_Filtros.Cod_Oficina ?? "0"
                    , oE_Filtros.Cod_Ciudad ?? "0"
                    , oE_Filtros.Cod_Gestor ?? "0"
                    , oE_Filtros.Cod_PDV ?? "0"
                    , oE_Filtros.Cod_NodoComercial ?? "0"
                    , oE_Filtros.Cod_Anio ?? "0"
                    , oE_Filtros.Cod_Mes ?? "0"
                    , oE_Filtros.Cod_Periodo ?? "0"
                    , oE_Filtros.Cod_Departamento ?? "0"
                    , oE_Filtros.Cod_SubReporte ?? "0"
                    , oE_Filtros.Fecha_Relevo ?? "0"
                    );
                //Campania,CodReporte,CodCategoria,CodMarca,CodFamilia,CodSubFamilia,      
                //Cod_Oficina,Cod_Ciudad,CodGenerador,Cod_PDVClient,Cod_NodoComercial,      
                //Cod_Anio,Cod_Mes,Cod_Periodo,Cod_Departamento,Cod_SubReporte
                while (readerObj.Read())
                {
                    E_Reporte_Bodegas oE_Reporte_Bodegas = new E_Reporte_Bodegas();

                    if (oE_Filtros.Cod_Campania.Equals("012011092692011") || oE_Filtros.Cod_Campania.Equals("0134226102010") || oE_Filtros.Cod_Campania.Equals("0134126102010"))
                    {
                        oE_Reporte_Bodegas.Nombre_Ciudad = readerObj.GetValue(readerObj.GetOrdinal("Ciudad")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_Equipo = readerObj.GetValue(readerObj.GetOrdinal("codCampaña")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_Cadena = readerObj.GetValue(readerObj.GetOrdinal("cod_Cadena")).ToString().Trim();
                        oE_Reporte_Bodegas.Nombre_Cadena = readerObj.GetValue(readerObj.GetOrdinal("nombre_Cadena")).ToString().Trim();
                        oE_Reporte_Bodegas.CodPtoVenta = readerObj.GetValue(readerObj.GetOrdinal("cod_PDV")).ToString().Trim();
                        oE_Reporte_Bodegas.NombrePtoVenta = readerObj.GetValue(readerObj.GetOrdinal("Nombre_PDV")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_Persona = readerObj.GetValue(readerObj.GetOrdinal("cod_Persona")).ToString().Trim();
                        oE_Reporte_Bodegas.Persona_Nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre_Persona")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_SubReporte = readerObj.GetValue(readerObj.GetOrdinal("cod_Subreporte")).ToString().Trim();
                        oE_Reporte_Bodegas.SubReporte_Nombre = readerObj.GetValue(readerObj.GetOrdinal("SUBREPORTE")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_Categoria = readerObj.GetValue(readerObj.GetOrdinal("cod_Categoria")).ToString().Trim();
                        oE_Reporte_Bodegas.Nombre_Categoria = readerObj.GetValue(readerObj.GetOrdinal("nombre_Categoria")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_MaterialApoyo = readerObj.GetValue(readerObj.GetOrdinal("cod_Pop")).ToString().Trim();
                        oE_Reporte_Bodegas.MaterialApoyo_Nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre_Pop")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_Observacion = readerObj.GetValue(readerObj.GetOrdinal("cod_Observacion")).ToString().Trim();
                        oE_Reporte_Bodegas.Observacion_Marcada = readerObj.GetValue(readerObj.GetOrdinal("Observacion")).ToString().Trim();
                        oE_Reporte_Bodegas.SKU_Producto = readerObj.GetValue(readerObj.GetOrdinal("SKU")).ToString().Trim();
                        oE_Reporte_Bodegas.Producto_Nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre_Producto")).ToString().Trim();
                        oE_Reporte_Bodegas.Direccion_PDV = readerObj.GetValue(readerObj.GetOrdinal("direccion_PDV")).ToString().Trim();
                        oE_Reporte_Bodegas.Cod_Cluster = readerObj.GetValue(readerObj.GetOrdinal("Cod_Cluster")).ToString().Trim();
                        oE_Reporte_Bodegas.Nombre_Cluster = readerObj.GetValue(readerObj.GetOrdinal("Cluster")).ToString().Trim();
                    }

                    listaReporte.Add(oE_Reporte_Bodegas);
                }
                readerObj.Close();

                if (listaReporte.Count > 0)
                {
                    return listaReporte;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Devuelte los datos del reporte para mostrar en la grilla.
        /// Modulos: Datameracderista
        /// Autor: Peter Ccopa
        /// Fecha: 8/11/2012
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        //public List<E_Reporte_Exhibicion> Llenar_Reporte_Exhibicion(E_Filtros_Reporte oE_Filtros)
        //{
        //    List<E_Reporte_Exhibicion> listaReporte = new List<E_Reporte_Exhibicion>();
        //    try
        //    {
        //        oCoon = new Conexion(1);
        //        //iidperson, sidplanning, sidchanel, cod_oficina, id_NodeComercial, ClientPDV_Code, sid_categoriaproducto, sidbrand, dfecha_inicio, dfecha_fin
        //        IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OPE_CONSULTA_REPORTE_EXHIBICION_2"
        //            , oE_Filtros.Cod_Gestor ?? "0"
        //            , oE_Filtros.Cod_Campania
        //            , oE_Filtros.Cod_Canal
        //            , oE_Filtros.Cod_Oficina ?? "0"
        //            , oE_Filtros.NodeComercial ?? "0"
        //            , oE_Filtros.Cod_Cliente ?? "0"
        //            , oE_Filtros.Cod_CategoriaProducto ?? "0"
        //            , oE_Filtros.Cod_Marca ?? "0"
        //            , oE_Filtros.Fecha_Inicio ?? "0"
        //            , oE_Filtros.Fecha_Fin ?? "0"
        //            );
        //        while (readerObj.Read())
        //        {
        //            E_Reporte_Exhibicion oE_Reporte_Exhibicion = new E_Reporte_Exhibicion();

        //            //N°,PDV,Categoria,Marca,Fecha-inicio,Fecha-fin,descripcion,Cantidad,Registrado-por,Fecha-de-registro,Modificado-por,Modifico-el

        //            //ROWID,PDV,Categoria,Marca,Fecha_inicio,Fecha_Fin,Cantidad,descripcion,RegistradoPor,
        //            //FechaRegistro,ModificadoPor,FechaModificacion,ClientPDV_Code,
        //            //Validado,Id_rexhd,Person_name,commercialNodeName

        //            oE_Reporte_Exhibicion.Num_Fila = readerObj.GetValue(readerObj.GetOrdinal("ROWID")).ToString().Trim();
        //            oE_Reporte_Exhibicion.PDV = readerObj.GetValue(readerObj.GetOrdinal("PDV")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Categoria = readerObj.GetValue(readerObj.GetOrdinal("Categoria")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Marca = readerObj.GetValue(readerObj.GetOrdinal("Marca")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Fecha_inicio = readerObj.GetValue(readerObj.GetOrdinal("Fecha_inicio")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Fecha_Fin = readerObj.GetValue(readerObj.GetOrdinal("Fecha_Fin")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Descripcion = readerObj.GetValue(readerObj.GetOrdinal("descripcion")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Cantidad = readerObj.GetValue(readerObj.GetOrdinal("Cantidad")).ToString().Trim();
        //            oE_Reporte_Exhibicion.RegistradoPor = readerObj.GetValue(readerObj.GetOrdinal("RegistradoPor")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Fecha_Registro = readerObj.GetValue(readerObj.GetOrdinal("FechaRegistro")).ToString().Trim();
        //            oE_Reporte_Exhibicion.ModificadoPor = readerObj.GetValue(readerObj.GetOrdinal("ModificadoPor")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Fecha_Modificacion = readerObj.GetValue(readerObj.GetOrdinal("FechaModificacion")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Cod_Cliente = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Validado = readerObj.GetValue(readerObj.GetOrdinal("Validado")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Id_Reporte = readerObj.GetValue(readerObj.GetOrdinal("Id_rexhd")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Gestor = readerObj.GetValue(readerObj.GetOrdinal("Person_name")).ToString().Trim();
        //            oE_Reporte_Exhibicion.Name_NodeComercial = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();

        //            listaReporte.Add(oE_Reporte_Exhibicion);
        //        }
        //        readerObj.Close();

        //        if (listaReporte.Count > 0)
        //        {
        //            return listaReporte;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        public EUsuario Obtener_Usuario(string idPerson)
        {
            try
            {
                oCoon = new Conexion(4);
                EUsuario oE_Usuario = new EUsuario();
                //DataTable tableObj = oCoon.ejecutarDataTable("UP_WEBXPLORA_OBTENER_USUARIO", idPerson);
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OBTENER_USUARIO", idPerson);

                while (readerObj.Read())
                {
                    oE_Usuario.nameuser = readerObj.GetValue(readerObj.GetOrdinal("name_user")).ToString().Trim();
                    //listaUsuario.Add(oE_Usuario);
                }
                readerObj.Close();

                if (oE_Usuario != null)
                {
                    return oE_Usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion de Distrito
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre método, agrego pE codOficina.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_Distrito> listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia(string codCampaña, string codpais, string codOficina,string coddepartamento, string codProvincia)
        {

            try
            {
                oCoon = new Conexion(1);
                List<E_Distrito> listaDistrito = new List<E_Distrito>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_Distrito_Por_CodCampCodPaisCodOficinaCodDptoCodProv", codCampaña, codpais, codOficina, coddepartamento, codProvincia);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_Distrito oE_Distrito = new E_Distrito();
                    oE_Distrito.CodDistrito = readerObj.GetValue(readerObj.GetOrdinal("Cod_District")).ToString().Trim();
                    oE_Distrito.NombreDistrito = readerObj.GetValue(readerObj.GetOrdinal("Name_Local")).ToString().Trim();
                    listaDistrito.Add(oE_Distrito);
                }
                readerObj.Close();

                if (listaDistrito.Count > 0)
                {
                    return listaDistrito;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion de Region
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre metodo, agrego nuevos parametros 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_Region> listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia(string codCampania, string codOficina, string codDepartamento, string codProvincia) 
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_Region> listaE_Region = new List<E_Region>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_Mallas_Por_CodCampaniaCodOficinaCodDptoCodProvincia", codCampania, codOficina, codDepartamento, codProvincia);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_Region oE_Region = new E_Region();
                    oE_Region.idRegion = readerObj.GetValue(readerObj.GetOrdinal("Cod_Producto")).ToString().Trim();
                    oE_Region.nameRegion = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Producto")).ToString().Trim();
                    listaE_Region.Add(oE_Region);
                }
                readerObj.Close();

                if (listaE_Region.Count > 0)
                {
                    return listaE_Region;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion de Sector
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// Cambio: GFZ - Cambio nombre metodo, agrego nuevos parametros 27/09/2012
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_Sector> listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia(string codCampania, string codRegion, string codOficina, string codDepartamento, string codProvincia) 
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_Sector> listaE_Sector = new List<E_Sector>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_PLA_OBTENER_SECTOR_POR_CodCampaniaCodMallaCodOficinaCodDptoCodProvincia", codCampania, codRegion, codOficina, codDepartamento, codProvincia);//cambiar nombre store
                while (readerObj.Read())
                {
                    E_Sector oE_Sector = new E_Sector();
                    oE_Sector.codSector = readerObj.GetValue(readerObj.GetOrdinal("id_Sector")).ToString().Trim();
                    oE_Sector.nombreSector = readerObj.GetValue(readerObj.GetOrdinal("Sector")).ToString().Trim();
                    listaE_Sector.Add(oE_Sector);
                }
                readerObj.Close();

                if (listaE_Sector.Count > 0)
                {
                    return listaE_Sector;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #region Gestion Unicos
        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        public List<E_Seguimiento> listarSeguimientoDeCampaña(string CodCliente, string codCampaña)
        {

            try
            {
                oCoon = new Conexion(1);
                List<E_Seguimiento> listaSeguimiento = new List<E_Seguimiento>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_PRODUCTO_POR_CODCAMPANIA_CODCLIENTE_CODCATEGORIA_CODSUBCATEGORIA_CODMARCA", CodCliente, codCampaña); //cambiar nombre store
                while (readerObj.Read())
                {
                    E_Seguimiento oE_Seguimiento = new E_Seguimiento();
                    oE_Seguimiento.nombreGestion = readerObj.GetValue(readerObj.GetOrdinal("Cod_Producto")).ToString().Trim();
                    oE_Seguimiento.valor = readerObj.GetValue(readerObj.GetOrdinal("Nombre_Producto")).ToString().Trim();
                    listaSeguimiento.Add(oE_Seguimiento);
                }
                readerObj.Close();

                if (listaSeguimiento.Count > 0)
                {
                    return listaSeguimiento;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        #endregion

        #region  Obtencion de Menu Datamercaderista
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 16/10/2012
        /// Descripción: Método que devuelve los Menu de Datamercaderista
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_MenuDatamercaderista> Listar_Menu_Datamercaderista(string idmodulo)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_MenuDatamercaderista> listaMenuDatamercaderista = new List<E_MenuDatamercaderista>();
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEB_OBTENERMENU",idmodulo);
                while (readerObj.Read())
                {
                    E_MenuDatamercaderista oE_MenuDatamercaderista = new E_MenuDatamercaderista();
                    oE_MenuDatamercaderista.Id = readerObj.GetValue(readerObj.GetOrdinal("id")).ToString().Trim();
                    //oE_MenuDatamercaderista.Parent_Id = readerObj.GetValue(readerObj.GetOrdinal("parent_id")).ToString().Trim();
                    oE_MenuDatamercaderista.Text = readerObj.GetValue(readerObj.GetOrdinal("text")).ToString().Trim();
                    oE_MenuDatamercaderista.Leaf = readerObj.GetValue(readerObj.GetOrdinal("leaf")).ToString().Trim();
                    oE_MenuDatamercaderista.Icon = readerObj.GetValue(readerObj.GetOrdinal("icon")).ToString().Trim();
                    oE_MenuDatamercaderista.Target = readerObj.GetValue(readerObj.GetOrdinal("hrefTarget")).ToString().Trim();
                    listaMenuDatamercaderista.Add(oE_MenuDatamercaderista);
                }
                readerObj.Close();

                if (listaMenuDatamercaderista.Count > 0)
                {
                    return listaMenuDatamercaderista;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region  Obtencion de Cadena
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 28/09/2012
        /// Descripción: Método que devuelve las Cadenas por Campaña y Generador
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_NodeComercial> Listar_Cadenas(string CodCampania, string CodGenerador, string FechaRelevo)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_NodeComercial> listaCadena = new List<E_NodeComercial>();
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OBTENER_CADENA_POR_CAMPANIA_CODGENERADOR", CodCampania, CodGenerador,FechaRelevo);
                while (readerObj.Read())
                {
                    E_NodeComercial oE_NodeComercial = new E_NodeComercial();
                    oE_NodeComercial.id_NodeCommercial = readerObj.GetValue(readerObj.GetOrdinal("NodeCommercial")).ToString().Trim();
                    oE_NodeComercial.commercialNodeName = readerObj.GetValue(readerObj.GetOrdinal("commercialNodeName")).ToString().Trim();
                    listaCadena.Add(oE_NodeComercial);
                }
                readerObj.Close();

                if (listaCadena.Count > 0)
                {
                    return listaCadena;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region  Obtencion de Proveedores
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 23/10/2012
        /// Descripción: Método que devuelve los Proveedores
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public List<E_Proveedor> Listar_Proveedores(string cod_prov)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_Proveedor> listaProveedor = new List<E_Proveedor>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_CAMP_OBTENER_PROVEEDOR",cod_prov);
                while (readerObj.Read())
                {
                    E_Proveedor oE_Proveedor = new E_Proveedor();
                    oE_Proveedor.Codigo = readerObj.GetValue(readerObj.GetOrdinal("CodProveedor")).ToString().Trim();
                    oE_Proveedor.Razon_social = readerObj.GetValue(readerObj.GetOrdinal("razon_social")).ToString().Trim();
                    oE_Proveedor.Direccion = readerObj.GetValue(readerObj.GetOrdinal("direccion")).ToString().Trim();
                    oE_Proveedor.CodDpto = readerObj.GetValue(readerObj.GetOrdinal("cod_dpto")).ToString().Trim();
                    oE_Proveedor.CodProv = readerObj.GetValue(readerObj.GetOrdinal("cod_prov")).ToString().Trim();
                    oE_Proveedor.CodDist = readerObj.GetValue(readerObj.GetOrdinal("cod_dist")).ToString().Trim();
                    oE_Proveedor.Email = readerObj.GetValue(readerObj.GetOrdinal("email")).ToString().Trim();
                    oE_Proveedor.Contacto = readerObj.GetValue(readerObj.GetOrdinal("contacto")).ToString().Trim();
                    oE_Proveedor.Telefonos = readerObj.GetValue(readerObj.GetOrdinal("telefonos")).ToString().Trim();
                    oE_Proveedor.Ruc = readerObj.GetValue(readerObj.GetOrdinal("ruc")).ToString().Trim();
                    oE_Proveedor.Dpto = readerObj.GetValue(readerObj.GetOrdinal("Name_dpto")).ToString().Trim();
                    oE_Proveedor.Provincia = readerObj.GetValue(readerObj.GetOrdinal("Name_Provincia")).ToString().Trim();
                    oE_Proveedor.Distrito = readerObj.GetValue(readerObj.GetOrdinal("Name_Distrito")).ToString().Trim();
                    oE_Proveedor.Usuario_Registro = readerObj.GetValue(readerObj.GetOrdinal("createby")).ToString().Trim();
                    oE_Proveedor.Fecha_Registro = readerObj.GetValue(readerObj.GetOrdinal("create_date")).ToString().Trim();

                    listaProveedor.Add(oE_Proveedor);
                }
                readerObj.Close();

                if (listaProveedor.Count > 0)
                {
                    return listaProveedor;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Gestion Rutas
        public List<E_PuntodeVentaPlanningRuta> Listar_Rutas_Por_CodCompania_CodCampania_CodPersona(string CodCompania, string CodCampania, string CodPerson) {
            try {
                oCoon = new Conexion(1);
                List<E_PuntodeVentaPlanningRuta> oListE_PuntodeVentaPlanningRuta = new List<E_PuntodeVentaPlanningRuta>();
                DataTable dt = oCoon.ejecutarDataTable("SP_XPL_GES_CAM_OBTENER_Rutas_POR_CodCompaniaCodCampaniaCodGestor", CodCompania, CodCampania, CodPerson);
                for(int i=0;i<dt.Rows.Count;i++){
                    E_PuntodeVentaPlanningRuta oE_PuntodeVentaPlanningRuta = new E_PuntodeVentaPlanningRuta();
                    oE_PuntodeVentaPlanningRuta.id_POSPlanningOpe= dt.Rows[i]["Id_POSPlanningOpe"].ToString();
                    oE_PuntodeVentaPlanningRuta.codPdv = dt.Rows[i]["ClientPDV_Code"].ToString();
                    oE_PuntodeVentaPlanningRuta.nombrePdv = dt.Rows[i]["pdv_Name"].ToString();
                    oE_PuntodeVentaPlanningRuta.direccionPdv = dt.Rows[i]["pdv_Address"].ToString();
                    oE_PuntodeVentaPlanningRuta.regionPdv = dt.Rows[i]["malla"].ToString();
                    oE_PuntodeVentaPlanningRuta.zonapdv = dt.Rows[i]["Sector"].ToString();
                    oE_PuntodeVentaPlanningRuta.fecha_Inicio = dt.Rows[i]["POSPlanningOpe_FechaInicio"].ToString();
                    oE_PuntodeVentaPlanningRuta.fecha_Fin = dt.Rows[i]["POSPlanningOpe_FechaFin"].ToString();
                    oListE_PuntodeVentaPlanningRuta.Add(oE_PuntodeVentaPlanningRuta);
                }
                return oListE_PuntodeVentaPlanningRuta;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        
        //08/11/2012 PSA. ListarRutasDevolviendo Coordenadas y Por Fecha.
        //Mod 14/11/2012. Se agrego Opcion, para consultar dependiendo del estado de las rutas, 1 Todos, 2 Habilitado, 3 Inhabilitado.
        public List<E_PuntodeVentaPlanningRuta> Listar_Rutas_Por_ComCamPerFec(string CodCompania, string CodCampania, string CodPerson, string Fecha,string Opcion)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_PuntodeVentaPlanningRuta> oListE_PuntodeVentaPlanningRuta = new List<E_PuntodeVentaPlanningRuta>();
                DataTable dt = oCoon.ejecutarDataTable("SP_XPL_GES_CAM_OBTENER_Rutas_POR_ComCamGesFec", CodCompania, CodCampania, CodPerson, Fecha,Opcion);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    E_PuntodeVentaPlanningRuta oE_PuntodeVentaPlanningRuta = new E_PuntodeVentaPlanningRuta();
                    oE_PuntodeVentaPlanningRuta.id_POSPlanningOpe = dt.Rows[i]["Id_POSPlanningOpe"].ToString();
                    oE_PuntodeVentaPlanningRuta.codPdv = dt.Rows[i]["ClientPDV_Code"].ToString();
                    oE_PuntodeVentaPlanningRuta.nombrePdv = dt.Rows[i]["pdv_Name"].ToString();
                    oE_PuntodeVentaPlanningRuta.direccionPdv = dt.Rows[i]["pdv_Address"].ToString();
                    oE_PuntodeVentaPlanningRuta.regionPdv = dt.Rows[i]["malla"].ToString();
                    oE_PuntodeVentaPlanningRuta.zonapdv = dt.Rows[i]["Sector"].ToString();
                    oE_PuntodeVentaPlanningRuta.fecha_Inicio = dt.Rows[i]["POSPlanningOpe_FechaInicio"].ToString();
                    oE_PuntodeVentaPlanningRuta.fecha_Fin = dt.Rows[i]["POSPlanningOpe_FechaFin"].ToString();
                    oE_PuntodeVentaPlanningRuta.latitud = dt.Rows[i]["Latitud"].ToString();
                    oE_PuntodeVentaPlanningRuta.longitud = dt.Rows[i]["Longitud"].ToString();
                    oE_PuntodeVentaPlanningRuta.estado = dt.Rows[i]["Estado"].ToString();
                    
                    oListE_PuntodeVentaPlanningRuta.Add(oE_PuntodeVentaPlanningRuta);
                }
                return oListE_PuntodeVentaPlanningRuta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Descripcion:Actualizar Ruta, usado para Modulo Planning - MVC
        /// Autor: Giam Farfan
        /// Fecha:30/10/2012
        /// </summary>
        /// <param name="oE_PuntodeVentaPlanningRuta"></param>
        /// <returns></returns>
        public string updateRuta(string nroRuta,string fechainicio,string fechafin)
        {
            string error = string.Empty;
            try
            {
                Conexion ocon = new Conexion();
                string a = oCoon.ejecutarConRetorno("SPU_UPDATE_RUTA",
                   nroRuta,fechainicio,fechafin
                );
                error = "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }
            return error;
        }

        /// <summary>
        /// Autor:Giam Farfan
        /// Descripcion: Metodo que recibe como parametro los codigos de rutas y valor 1(Habilita) 2(Inhabilita)procediendo a actualizar.
        /// Fecha: 13/11/2012
        /// </summary>
        /// <param name="nroRuta"></param>
        /// <returns></returns>
        public string actualizarEstadoRuta(string nroRuta,int valor)
        {
            string error = string.Empty;
            try
            {
                Conexion ocon = new Conexion();
                string a = oCoon.ejecutarConRetorno("SPU_MODPLANNING_ACTUALIZAR_ESTADO_RUTA",
                   nroRuta,valor
                );
                error = "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }
            return error;
        }
        #endregion

        /// <summary>
        /// Autor:Giam Farfan
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento de una campaña.
        /// </summary>
        /// <param name="CodCliente"></param>
        /// <param name="codCampaña"></param>
        /// <returns></returns>
        #region Planning
        #endregion

        #region  Obtencion de Correlativo
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 25/10/2012
        /// Descripción: Método que devuelve el correlativo de Orden de Compra
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public E_Correlativo obtener_NroOrdenCompra(string tipo_doc)
        {
            try
            {
                oCoon = new Conexion(1);
                E_Correlativo obtenerOC = new E_Correlativo();
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_OBTENER_CORRELATIVO", tipo_doc);
                while (readerObj.Read())
                {
                    E_Correlativo oE_OrdenCompra = new E_Correlativo();
                    oE_OrdenCompra.Nro_Doc = readerObj.GetValue(readerObj.GetOrdinal("NRO_OC")).ToString().Trim();
                    obtenerOC.Nro_Doc=oE_OrdenCompra.Nro_Doc;
                }
                readerObj.Close();

                if (obtenerOC.Nro_Doc!= "")
                {
                    return obtenerOC;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region  Obtencion de Parametros
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 30/10/2012
        /// Descripción: Método que devuelve el valor de un parametro
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public E_Parametros obtener_Parametro(string tipo)
        {
            try
            {
                oCoon = new Conexion(1);
                E_Parametros oE_Parametros = new E_Parametros();
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_OBTENER_PARAMETROS", tipo);
                while (readerObj.Read())
                {
                    oE_Parametros = new E_Parametros();
                    oE_Parametros.Tipo = readerObj.GetValue(readerObj.GetOrdinal("TIPO")).ToString().Trim();
                    oE_Parametros.Descripcion = readerObj.GetValue(readerObj.GetOrdinal("DESCRIPCION")).ToString().Trim();
                    oE_Parametros.Valor = readerObj.GetValue(readerObj.GetOrdinal("VALOR")).ToString().Trim();
                }
                readerObj.Close();

                if (oE_Parametros.Tipo != "")
                {
                    return oE_Parametros;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Gestion de Orden Compra
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:29/10/2012
        /// Descripcion: Metodo que trae las caceberas de Ordenes de Compras.
        /// </summary>
        /// <returns></returns>
        public List<E_OrdenCompra> ListarOrdenCompra_Cabecera(string Nro_OC)
        {

            try
            {
                oCoon = new Conexion(1);
                List<E_OrdenCompra> listaOC = new List<E_OrdenCompra>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_CAMP_OBTENER_ORDENES_COMPRA", Nro_OC);

                while (readerObj.Read())
                {
                    E_OrdenCompra oE_OrdenCompra = new E_OrdenCompra();
                    oE_OrdenCompra.Cod_Proveedor = readerObj.GetValue(readerObj.GetOrdinal("COD_PROVEEDOR")).ToString().Trim();
                    oE_OrdenCompra.Nro_OC = readerObj.GetValue(readerObj.GetOrdinal("NRO_OC")).ToString().Trim();
                    oE_OrdenCompra.Subtotal = Convert.ToDouble(readerObj.GetValue(readerObj.GetOrdinal("SUBTOTAL")));
                    oE_OrdenCompra.IGV = Convert.ToDouble(readerObj.GetValue(readerObj.GetOrdinal("IGV")));
                    oE_OrdenCompra.Total = Convert.ToDouble(readerObj.GetValue(readerObj.GetOrdinal("TOTAL")));
                    oE_OrdenCompra.User_Registro = readerObj.GetValue(readerObj.GetOrdinal("CREATEBY")).ToString().Trim();
                    oE_OrdenCompra.Condicion = readerObj.GetValue(readerObj.GetOrdinal("CONDICION")).ToString().Trim();
                    oE_OrdenCompra.Estado = readerObj.GetValue(readerObj.GetOrdinal("ESTADO")).ToString().Trim();
                    oE_OrdenCompra.Fecha_Registro = readerObj.GetValue(readerObj.GetOrdinal("DATE_CREATE")).ToString().Trim();
                    oE_OrdenCompra.Razon_Social = readerObj.GetValue(readerObj.GetOrdinal("razon_social")).ToString().Trim();
                    oE_OrdenCompra.Ruc = readerObj.GetValue(readerObj.GetOrdinal("ruc")).ToString().Trim();
                    oE_OrdenCompra.Autorizado_Por = readerObj.GetValue(readerObj.GetOrdinal("AUTORIZADO_POR")).ToString().Trim();
                    oE_OrdenCompra.Tranportar = readerObj.GetValue(readerObj.GetOrdinal("TRANSPORTAR")).ToString().Trim();
                    oE_OrdenCompra.Atendido = readerObj.GetValue(readerObj.GetOrdinal("ATENCION")).ToString().Trim();
                    oE_OrdenCompra.Fecha_Envio = readerObj.GetValue(readerObj.GetOrdinal("FECHA_ENVIO")).ToString().Trim();
                    listaOC.Add(oE_OrdenCompra);
                }
                readerObj.Close();

                if (listaOC.Count > 0)
                {
                    return listaOC;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:29/10/2012
        /// Descripcion: Metodo que trae el detalle de una Orden de Compra.
        /// </summary>
        /// <returns></returns>
        public List<E_OrdenCompraDetalle> ListarOrdenCompra_Detalle(string Nro_OC)
        {

            try
            {
                oCoon = new Conexion(1);
                List<E_OrdenCompraDetalle> listaOC_Det = new List<E_OrdenCompraDetalle>();
                IDataReader readerObj = oCoon.ejecutarDataReader("SP_GES_CAMP_OBTENER_ORDENES_COMPRA_DETALLE", Nro_OC);

                while (readerObj.Read())
                {
                    E_OrdenCompraDetalle oE_OrdenCompra = new E_OrdenCompraDetalle();
                    oE_OrdenCompra.Nro_OC = readerObj.GetValue(readerObj.GetOrdinal("NRO_OC")).ToString().Trim();
                    oE_OrdenCompra.ProductName = readerObj.GetValue(readerObj.GetOrdinal("DESCRIPCION_PROD")).ToString().Trim();
                    oE_OrdenCompra.UnitPrice = Convert.ToDouble(readerObj.GetValue(readerObj.GetOrdinal("PRECIO_UNIT")));
                    oE_OrdenCompra.UnitsInStock = Convert.ToInt16(readerObj.GetValue(readerObj.GetOrdinal("CANT")));
                    oE_OrdenCompra.PriceTotal = Convert.ToDouble(readerObj.GetValue(readerObj.GetOrdinal("PRECIO_TOT")));

                    listaOC_Det.Add(oE_OrdenCompra);
                }
                readerObj.Close();

                if (listaOC_Det.Count > 0)
                {
                    return listaOC_Det;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Gestion de PDVCadenas
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 28/09/2012
        /// Descripción: Método que devuelve los puntos de venta por código de campaña y código de cadena 
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodCadena"></param>
        /// <returns></returns>
        public List<E_PuntoDeVenta> Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena(string CodCampania, string CodGenerador, string CodCadena, string FechaRelevo)
        {
            try
            {
                oCoon = new Conexion(1);
                List<E_PuntoDeVenta> listaPuntosVenta = new List<E_PuntoDeVenta>();
                IDataReader readerObj = oCoon.ejecutarDataReader("UP_WEBXPLORA_OBTENER_PDV_POR_CodCampania_CodGenerador_CodCadena", CodCampania, CodGenerador, CodCadena, FechaRelevo);
                while (readerObj.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerObj.GetValue(readerObj.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerObj.GetValue(readerObj.GetOrdinal("pdv_Name")).ToString().Trim();
                    listaPuntosVenta.Add(oE_PuntoDeVenta);
                }
                readerObj.Close();

                if (listaPuntosVenta.Count > 0)
                {
                    return listaPuntosVenta;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

    }
}
