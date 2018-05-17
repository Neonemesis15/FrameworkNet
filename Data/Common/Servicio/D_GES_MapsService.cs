using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Servicio;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Servicio
{
    public class D_GES_MapsService
    {
        private Conexion oConexion;
        public D_GES_MapsService()
        {
            oConexion = new Conexion(1);
        }

        #region XploraGis Lima
        public E_Representatividad Obtener_Representatividad(int tipo, string codigo)
        {
            E_Representatividad oE_Representatividad = new E_Representatividad();
            try
            {
                DataTable result = oConexion.ejecutarDataTable("UP_XPLORAMAPS_REPRESENTATIVIDAD", tipo, codigo);
                oE_Representatividad.cantidad = int.Parse(result.Rows[0]["Cantidad"].ToString());
                oE_Representatividad.total = int.Parse(result.Rows[0]["Total"].ToString());
                oE_Representatividad.zona = int.Parse(result.Rows[0]["Zona"].ToString());
                return oE_Representatividad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PresenciaZonaDistrito> Obtener_Presencia_ZonaDistrito(int servicio, string canal, int codCliente, string coddepartamento, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        {
            List<E_PresenciaZonaDistrito> oListPresencia = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_WEBXPLORA_PRESENCIA_MAPS", servicio, canal, codCliente, coddepartamento, codciudad, codZona, codDistrito, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    oListPresencia = new List<E_PresenciaZonaDistrito>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaZonaDistrito presencia = new E_PresenciaZonaDistrito();

                        presencia.id_tipo = dt.Rows[i]["idTipo"].ToString();
                        presencia.tipo = dt.Rows[i]["tipo"].ToString();
                        presencia.id_elemento = dt.Rows[i]["idElemento"].ToString();
                        presencia.nombre_elemento = dt.Rows[i]["nombreElemento"].ToString();
                        presencia.coverage = dt.Rows[i]["coverage"].ToString();
                        presencia.totalcoverage = dt.Rows[i]["totalCoverage"].ToString();
                        presencia.rangos = dt.Rows[i]["Rangos"].ToString();
                        presencia.cobertura = dt.Rows[i]["Cobertura"].ToString();
                        presencia.nombreCliente = dt.Rows[i]["company"].ToString();

                        oListPresencia.Add(presencia);
                    }
                }
                return oListPresencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(int servicio, string canal, int codCliente, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        {
            List<E_ElemVisibilidadZonaDistrito> oListPresencia = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_WEBXPLORA_PRESENCIA_ELEMVISIB_MAPS", servicio, canal, codCliente, codciudad, codZona, codDistrito, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    oListPresencia = new List<E_ElemVisibilidadZonaDistrito>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_ElemVisibilidadZonaDistrito presencia = new E_ElemVisibilidadZonaDistrito();

                        presencia.idElemento = dt.Rows[i]["idElemento"].ToString();
                        presencia.nombreElemento = dt.Rows[i]["nombreElemento"].ToString();
                        presencia.nombrePropio = dt.Rows[i]["nombrePropio"].ToString();
                        presencia.cantidadPropio = dt.Rows[i]["cantidadPropio"].ToString();
                        presencia.nombreCompetencia = dt.Rows[i]["nombreCompetencia"].ToString();
                        presencia.cantidadCompetencia = dt.Rows[i]["cantidadCompetencia"].ToString();

                        oListPresencia.Add(presencia);
                    }
                }
                return oListPresencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_VentasZonaDistrito> Obtener_Ventas_ZonaDistrito(int tipo, string codigo, int reportsPlanning)
        {
            List<E_VentasZonaDistrito> oListVentas = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_XPLORAMAPS_VENTAS", tipo, codigo, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    oListVentas = new List<E_VentasZonaDistrito>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_VentasZonaDistrito venta = new E_VentasZonaDistrito();

                        venta.idCategoria = dt.Rows[i]["id_categoria"].ToString();
                        venta.nombreCategoria = dt.Rows[i]["categoria"].ToString();
                        venta.idDistribuidora = dt.Rows[i]["id_distribuidora"].ToString();
                        venta.nombreDistribuidora = dt.Rows[i]["distribuidora"].ToString();
                        venta.venta = double.Parse(dt.Rows[i]["ventas"].ToString());

                        oListVentas.Add(venta);
                    }
                }
                return oListVentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PuntoVentaMapa> Obtener_PuntosVentaMapa(string equipo, string generador, string reportsPlanning, string codPais, string codDepartamento, string codProvincia, string codSector, string codDistrito)
        {
            List<E_PuntoVentaMapa> oListPuntoVenta = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_WEBXPLORA_OBTENER_PTOVENTA_MAPS", equipo, generador, reportsPlanning, codPais, codDepartamento, codProvincia, codSector, codDistrito);
                if (dt.Rows.Count > 0)
                {
                    oListPuntoVenta = new List<E_PuntoVentaMapa>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PuntoVentaMapa ptoVenta = new E_PuntoVentaMapa();

                        ptoVenta.codPuntoVenta = dt.Rows[i]["ClientPDV_Code"].ToString();
                        ptoVenta.nombrePuntoVenta = dt.Rows[i]["pdv_Name"].ToString();
                        ptoVenta.latitud = dt.Rows[i]["latitud"].ToString();
                        ptoVenta.longitud = dt.Rows[i]["longitud"].ToString();
                        ptoVenta.color = dt.Rows[i]["Color"].ToString();

                        oListPuntoVenta.Add(ptoVenta);
                    }
                }
                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Provincia> Obtener_Provincia_Por_CodDepartamento(string codPais, string codDepartamento)
        {
            List<E_Provincia> oListProvincia = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PROVINCIA", codPais, codDepartamento);
                if (dt.Rows.Count > 0)
                {
                    oListProvincia = new List<E_Provincia>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Provincia provincia = new E_Provincia();

                        provincia.CodProvincia = dt.Rows[i]["COD_PROVINCIA"].ToString();
                        provincia.NombreProvincia = dt.Rows[i]["NOMBRE_PROVINCIA"].ToString();

                        oListProvincia.Add(provincia);
                    }
                }
                return oListProvincia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Sector> Obtener_Sector_Por_PaisDepartamentoProvincia(string codPais, string codDepartamento, string codProvincia)
        {
            List<E_Sector> oListSector = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_SECTOR", codPais, codDepartamento, codProvincia);
                if (dt.Rows.Count > 0)
                {
                    oListSector = new List<E_Sector>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Sector sector = new E_Sector();

                        sector.codSector = dt.Rows[i]["id_sector"].ToString();
                        sector.nombreSector = dt.Rows[i]["Sector"].ToString();

                        oListSector.Add(sector);
                    }
                }
                return oListSector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_PuntoVentaDatosMapa Obtener_DatosPuntosVentaMapa(string codPtoVenta, string reportsPlanning)
        {
            E_PuntoVentaDatosMapa oPtoVenta = new E_PuntoVentaDatosMapa();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PDV", codPtoVenta, reportsPlanning);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        oPtoVenta.codPuntoVenta = dt.Rows[0]["CodPuntoVenta"].ToString();
                        oPtoVenta.nombrePuntoVenta = dt.Rows[0]["NombrePuntoVenta"].ToString();
                        oPtoVenta.direccion = dt.Rows[0]["Direccion"].ToString();
                        oPtoVenta.distrito = dt.Rows[0]["Distrito"].ToString();
                        oPtoVenta.sector = dt.Rows[0]["Sector"].ToString();
                        oPtoVenta.ultimaVisita = dt.Rows[0]["UltimaVisita"].ToString();
                        oPtoVenta.nombreGestor = dt.Rows[0]["Generador"].ToString();
                        oPtoVenta.nombreAdministrador = dt.Rows[0]["Administrador"].ToString();
                        oPtoVenta.email = dt.Rows[0]["Email"].ToString();
                        oPtoVenta.rutaVendedor = dt.Rows[0]["RutaVendedor"].ToString();
                    }
                }
                return oPtoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Presencia_PDV> Obtener_Presencia_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        {
            List<E_Presencia_PDV> oListPresenciaPDV = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PRESENCIA_PDV", codEquipo, reportsPlanning, codPtoVenta);
                if (dt.Rows.Count > 0)
                {
                    oListPresenciaPDV = new List<E_Presencia_PDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Presencia_PDV presencia = new E_Presencia_PDV();

                        presencia.idTipo = dt.Rows[i]["id_tipo"].ToString();
                        presencia.tipo = dt.Rows[i]["tipo"].ToString();
                        presencia.codProducto = dt.Rows[i]["cod_Product"].ToString();
                        presencia.nombreProducto = dt.Rows[i]["Product_Name"].ToString();
                        presencia.codCliente = dt.Rows[i]["Company_id"].ToString();
                        presencia.presencia = int.Parse(dt.Rows[i]["presencia"].ToString());
                        oListPresenciaPDV.Add(presencia);
                    }
                }
                return oListPresenciaPDV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        {
            List<E_ElemVisibilidad_PDV> oListElemVisibilidadPDV = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_ELEMENTO_VISIBILIDAD_PDV", codEquipo, reportsPlanning, codPtoVenta);
                if (dt.Rows.Count > 0)
                {
                    oListElemVisibilidadPDV = new List<E_ElemVisibilidad_PDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_ElemVisibilidad_PDV elemVisibilidad = new E_ElemVisibilidad_PDV();

                        elemVisibilidad.idTipo = dt.Rows[i]["id_tipo"].ToString();
                        elemVisibilidad.tipo = dt.Rows[i]["tipo"].ToString();
                        elemVisibilidad.codElemento = dt.Rows[i]["idElemento"].ToString();
                        elemVisibilidad.nombreElemento = dt.Rows[i]["nombreElemento"].ToString();
                        elemVisibilidad.codCliente = dt.Rows[i]["CodCompania"].ToString();
                        elemVisibilidad.nombreCliente = dt.Rows[i]["NombreCompania"].ToString();
                        elemVisibilidad.cantidad = int.Parse(dt.Rows[i]["Cantidad"].ToString());

                        oListElemVisibilidadPDV.Add(elemVisibilidad);
                    }
                }
                return oListElemVisibilidadPDV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Ventas_PDV> Obtener_Venta_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        {
            List<E_Ventas_PDV> oListVentaPDV = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTA_PDV", codEquipo, reportsPlanning, codPtoVenta);
                if (dt.Rows.Count > 0)
                {
                    oListVentaPDV = new List<E_Ventas_PDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Ventas_PDV venta = new E_Ventas_PDV();

                        venta.codSKU = dt.Rows[i]["codSKU"].ToString();
                        venta.nombreSKU = dt.Rows[i]["nombreSKU"].ToString();
                        venta.ventas = double.Parse(dt.Rows[i]["ventas"].ToString());
                        venta.cantidad = dt.Rows[i]["cantidad"].ToString();
                        venta.precioUnit = double.Parse(dt.Rows[i]["precioUnit"].ToString());

                        oListVentaPDV.Add(venta);
                    }
                }
                return oListVentaPDV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Foto_PDV Obtener_Foto_PuntoVenta(string reportsPlanning, string codPtoVenta)
        {
            E_Foto_PDV oFotoPDV = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_FOTO_PDV", reportsPlanning, codPtoVenta);
                if (dt.Rows.Count > 0)
                {
                    oFotoPDV = new E_Foto_PDV();
                    oFotoPDV.interiorAntes = dt.Rows[0]["Nombre_Foto"].ToString();
                    oFotoPDV.interiorDespues = dt.Rows[1]["Nombre_Foto"].ToString();
                    oFotoPDV.exteriorAntes = dt.Rows[2]["Nombre_Foto"].ToString();
                    oFotoPDV.exteriorDespues = dt.Rows[3]["Nombre_Foto"].ToString();
                }
                return oFotoPDV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_HistorialFoto_PDV> Obtener_HistorialFoto_PuntoVenta(string reportsPlanning, string codPtoVenta)
        {
            List<E_HistorialFoto_PDV> oListFotoPDV = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_HISTORIALFOTO_PDV", reportsPlanning, codPtoVenta);
                if (dt.Rows.Count > 0)
                {
                    oListFotoPDV = new List<E_HistorialFoto_PDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_HistorialFoto_PDV historialFoto = new E_HistorialFoto_PDV();

                        historialFoto.fechaAntes = dt.Rows[i]["fechaAntes"].ToString();
                        historialFoto.fotoAntes = dt.Rows[i]["fotoAntes"].ToString();
                        historialFoto.fechaDespues = dt.Rows[i]["fechaDespues"].ToString();
                        historialFoto.fotoDespues = dt.Rows[i]["fotoDespues"].ToString();

                        oListFotoPDV.Add(historialFoto);
                    }
                }
                return oListFotoPDV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Departamento> Obtener_Departamento_Por_CodPais(string codPais)
        {
            List<E_Departamento> oListDepartamento = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_DEPARTAMENTO", codPais);
                if (dt.Rows.Count > 0)
                {
                    oListDepartamento = new List<E_Departamento>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Departamento departamento = new E_Departamento();

                        departamento.CodDepartamento = dt.Rows[i]["COD_DEPARTAMENTO"].ToString();
                        departamento.NombreDepartamento = dt.Rows[i]["NOMBRE_DPTO"].ToString();

                        oListDepartamento.Add(departamento);
                    }
                }
                return oListDepartamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Distrito> Obtener_Distrito_Por_CodSector(string codPais, string codDepartamento, string codProvincia, string codSector)
        {
            List<E_Distrito> oListDistrito = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_DISTRITO", codPais, codDepartamento, codProvincia, codSector);
                if (dt.Rows.Count > 0)
                {
                    oListDistrito = new List<E_Distrito>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Distrito distrito = new E_Distrito();

                        distrito.CodDistrito = dt.Rows[i]["COD_DISTRITO"].ToString();
                        distrito.NombreDistrito = dt.Rows[i]["NOMBRE_DISTRITO"].ToString();

                        oListDistrito.Add(distrito);
                    }
                }
                return oListDistrito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PresenciaZonaDistritoMap> Obtener_PresenciaZonaDistritoMap(string codCanal, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codCategoria, string codProducto, string codPeriodo, string opcion)
        {
            List<E_PresenciaZonaDistritoMap> oList_PresenciaZonaDistritoMap = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PRESENCIA_SEMAFOROS", codCanal, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codPeriodo, opcion);
                if (dt.Rows.Count > 0)
                {
                    oList_PresenciaZonaDistritoMap = new List<E_PresenciaZonaDistritoMap>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaZonaDistritoMap oE_PresenciaZonaDistritoMap = new E_PresenciaZonaDistritoMap();

                        oE_PresenciaZonaDistritoMap.id_elemento = dt.Rows[i]["idElemento"].ToString();
                        oE_PresenciaZonaDistritoMap.nombre_elemento = dt.Rows[i]["nombreElemento"].ToString();
                        oE_PresenciaZonaDistritoMap.coverage = dt.Rows[i]["coverage"].ToString();
                        oE_PresenciaZonaDistritoMap.totalcoverage = dt.Rows[i]["totalCoverage"].ToString();
                        oE_PresenciaZonaDistritoMap.presencia = dt.Rows[i]["presencia"].ToString();
                        oE_PresenciaZonaDistritoMap.codColor = dt.Rows[i]["codColor"].ToString();
                        oE_PresenciaZonaDistritoMap.cod_cobertura = dt.Rows[i]["cod_cobertura"].ToString();
                        oE_PresenciaZonaDistritoMap.cobertura = dt.Rows[i]["cobertura"].ToString();

                        oList_PresenciaZonaDistritoMap.Add(oE_PresenciaZonaDistritoMap);
                    }
                }
                return oList_PresenciaZonaDistritoMap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_ClusterZonaDistrito_Group Obtener_ClusterZonaDistritoMap(string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_ClusterZonaDistrito_Group clusterZonaDistritoMap = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_CLUSTER", codZona, codDistrito, idPlanning, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    clusterZonaDistritoMap = new E_ClusterZonaDistrito_Group();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_ClusterZonaDistrito oE_ClusterZonaDistrito = new E_ClusterZonaDistrito();

                        oE_ClusterZonaDistrito.cluster = dt.Rows[i]["Descripcion"].ToString();
                        oE_ClusterZonaDistrito.cantidad = dt.Rows[i]["Cantidad"].ToString();
                        oE_ClusterZonaDistrito.codigo = dt.Rows[i]["Codigo"].ToString();
                        oE_ClusterZonaDistrito.posicion = int.Parse(dt.Rows[i]["Posicion"].ToString());

                        if (oE_ClusterZonaDistrito.posicion == 0) //Provincia
                        {
                            clusterZonaDistritoMap.listClusterProvincia.Add(oE_ClusterZonaDistrito);
                        }
                        else if (oE_ClusterZonaDistrito.posicion == 1) //Sector
                        {
                            clusterZonaDistritoMap.listClusterSector.Add(oE_ClusterZonaDistrito);
                        }
                        else if (oE_ClusterZonaDistrito.posicion == 2) //Distrito
                        {
                            clusterZonaDistritoMap.listClusterDistrito.Add(oE_ClusterZonaDistrito);
                        }
                        else if (oE_ClusterZonaDistrito.posicion == 3) //Distrito
                        {
                            clusterZonaDistritoMap.listClusterVisitado.Add(oE_ClusterZonaDistrito);
                        }
                    }
                }
                return clusterZonaDistritoMap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_TipoCluster> Obtener_TipoCluster()
        {
            List<E_TipoCluster> ListTipoCluster = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_TIPO_CLUSTER");
                if (dt.Rows.Count > 0)
                {
                    ListTipoCluster = new List<E_TipoCluster>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_TipoCluster oE_TipoCluster = new E_TipoCluster();

                        oE_TipoCluster.codigo = dt.Rows[i]["Codigo"].ToString();
                        oE_TipoCluster.descripcion = dt.Rows[i]["Descripcion"].ToString();

                        ListTipoCluster.Add(oE_TipoCluster);
                    }
                }
                return ListTipoCluster;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PuntoVentaCluster> Obtener_PuntoVentaCluster(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string cluster, string codPeriodo)
        {
            List<E_PuntoVentaCluster> oList_PuntoVentaCluster = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PRESENCIA_CLUSTER", codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, cluster, codPeriodo);
                if (dt.Rows.Count > 0)
                {
                    oList_PuntoVentaCluster = new List<E_PuntoVentaCluster>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PuntoVentaCluster oE_PuntoVentaCluster = new E_PuntoVentaCluster();

                        oE_PuntoVentaCluster.codPuntoVenta = dt.Rows[i]["pdv_code"].ToString();
                        oE_PuntoVentaCluster.nombrePuntoVenta = dt.Rows[i]["pdv_name"].ToString();
                        oE_PuntoVentaCluster.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PuntoVentaCluster.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PuntoVentaCluster.cantidad = dt.Rows[i]["cantidad"].ToString();
                        oE_PuntoVentaCluster.total = dt.Rows[i]["total"].ToString();
                        oE_PuntoVentaCluster.presencia = dt.Rows[i]["presencia"].ToString();
                        oE_PuntoVentaCluster.color = dt.Rows[i]["color"].ToString();
                        oE_PuntoVentaCluster.cluster = dt.Rows[i]["cluster"].ToString();
                        oE_PuntoVentaCluster.cobertura = dt.Rows[i]["cobertura"].ToString();

                        oList_PuntoVentaCluster.Add(oE_PuntoVentaCluster);
                    }
                }
                return oList_PuntoVentaCluster;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PuntoVentaMapaVentas> Obtener_PuntoVentaMapaVentas(string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codCategoria, string codProducto, string codCluster, string codPlanning, string codPeriodo)
        {
            List<E_PuntoVentaMapaVentas> oListPuntoVentaMapaVentas = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PDV_VENTA", codPais, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster, codPlanning, codPeriodo);

                if (dt.Rows.Count > 0)
                {
                    oListPuntoVentaMapaVentas = new List<E_PuntoVentaMapaVentas>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PuntoVentaMapaVentas oE_PuntoVentaMapaVentas = new E_PuntoVentaMapaVentas();

                        oE_PuntoVentaMapaVentas.codPuntoVenta = dt.Rows[i]["CODIGO"].ToString();
                        oE_PuntoVentaMapaVentas.nombrePuntoVenta = dt.Rows[i]["NOMBRE"].ToString();
                        oE_PuntoVentaMapaVentas.cluster = dt.Rows[i]["CLUSTER"].ToString();
                        oE_PuntoVentaMapaVentas.color = dt.Rows[i]["COLOR"].ToString();
                        oE_PuntoVentaMapaVentas.venta = dt.Rows[i]["VENTA"].ToString();
                        oE_PuntoVentaMapaVentas.latitud = dt.Rows[i]["LATITUD"].ToString();
                        oE_PuntoVentaMapaVentas.longitud = dt.Rows[i]["LONGITUD"].ToString();

                        oListPuntoVentaMapaVentas.Add(oE_PuntoVentaMapaVentas);
                    }
                }

                return oListPuntoVentaMapaVentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PresenciaPDV> Obtener_PuntoVentaPresenciaSKU(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codProducto, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_SKU_PDV", codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);

                if (dt.Rows.Count > 0)
                {
                    oListPuntoVenta = new List<E_PresenciaPDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaPDV oE_PresenciaPDV = new E_PresenciaPDV();

                        oE_PresenciaPDV.codPuntoVenta = dt.Rows[i]["ClientPDV_Code"].ToString();
                        oE_PresenciaPDV.nombrePuntoVenta = dt.Rows[i]["pdv_Name"].ToString();
                        oE_PresenciaPDV.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PresenciaPDV.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PresenciaPDV.color = dt.Rows[i]["Color"].ToString();

                        oListPuntoVenta.Add(oE_PresenciaPDV);
                    }
                }

                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Grafico_Tendencia> Obtener_Grafico_Tendencia(string codServicio, string codCanal, string codCliente, string codPais,
            string codDepartamento, string codProvincia, string codZona, string codDistrito,
            string codCategoria, string codProducto, string codCluster, string anio, string mes, string codPeriodo, string codOpcion)
        {
            List<E_Grafico_Tendencia> oListGraficoTendencia = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PRESENCIA_TENDENCIA_DISTRI_ZONA", codServicio, codCanal, codCliente,
                    codPais, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);

                DataTable dtVentas = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_TENDENCIA", codServicio, codCanal, codCliente,
                    codPais, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);


                if (dt.Rows.Count > 0)
                {
                    oListGraficoTendencia = new List<E_Grafico_Tendencia>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Grafico_Tendencia oE_Grafico_Tendencia = new E_Grafico_Tendencia();

                        string ventas = "";
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (dt.Rows[i]["row_id"].ToString() == dtVentas.Rows[j]["rowId"].ToString())
                            {
                                ventas = dtVentas.Rows[j]["ventas"].ToString();
                                break;
                            }
                        }

                        oE_Grafico_Tendencia.orden = dt.Rows[i]["row_id"].ToString();
                        oE_Grafico_Tendencia.cebecera = dt.Rows[i]["cabecera"].ToString();
                        oE_Grafico_Tendencia.coverage = dt.Rows[i]["coverage"].ToString();
                        oE_Grafico_Tendencia.totalCoverage = dt.Rows[i]["total_coverage"].ToString();
                        oE_Grafico_Tendencia.porcentaje = dt.Rows[i]["porcentaje"].ToString();
                        oE_Grafico_Tendencia.ventas = ventas;
                        oE_Grafico_Tendencia.rangoFecha = dt.Rows[i]["rango_fecha"].ToString();
                        oE_Grafico_Tendencia.codPeriodo = dt.Rows[i]["id_reportsplanning"].ToString();

                        oListGraficoTendencia.Add(oE_Grafico_Tendencia);
                    }
                }

                return oListGraficoTendencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Grafico_Variacion> Obtener_Grafico_Variacion(string codServicio, string codCanal, string codCliente, string codPais,
            string codDepartamento, string codProvincia, string codZona, string codDistrito,
            string codCategoria, string codProducto, string codCluster, string anio, string mes, string codPeriodo, string codOpcion)
        {
            List<E_Grafico_Variacion> oListGraficoVariacion = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_VARIACION", codServicio, codCanal, codCliente,
                    codPais, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);

                if (dt.Rows.Count > 0)
                {
                    oListGraficoVariacion = new List<E_Grafico_Variacion>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Grafico_Variacion oE_Grafico_Variacion = new E_Grafico_Variacion();

                        oE_Grafico_Variacion.orden = dt.Rows[i]["rowId"].ToString();
                        oE_Grafico_Variacion.idElemento = dt.Rows[i]["idElemento"].ToString();
                        oE_Grafico_Variacion.nombreElemento = dt.Rows[i]["nombreElemento"].ToString();
                        oE_Grafico_Variacion.ventas = dt.Rows[i]["ventas"].ToString();
                        oE_Grafico_Variacion.anio = dt.Rows[i]["anio"].ToString();
                        oE_Grafico_Variacion.mes = dt.Rows[i]["mes"].ToString();
                        oE_Grafico_Variacion.periodo = dt.Rows[i]["periodo"].ToString();
                        oE_Grafico_Variacion.descripcion = dt.Rows[i]["descripcion"].ToString();

                        oListGraficoVariacion.Add(oE_Grafico_Variacion);
                    }
                }

                return oListGraficoVariacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

            E_VentasZonaDistrito_Detalle oE_VentasZonaDistrito_Detalle = new E_VentasZonaDistrito_Detalle();
            try
            {
                //DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_PRODUCTOS_DISTRI_ZONA", 254, 2008, 1561, 589, "07", "01", "06", 0, 1, 2012, 7, 1145, 2);
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_PRODUCTOS_DISTRI_ZONA"
                    , oE_Filtros_XplMap_Colgate.codServicio
                    , oE_Filtros_XplMap_Colgate.codCanal
                    , oE_Filtros_XplMap_Colgate.codCliente
                    , oE_Filtros_XplMap_Colgate.codPais ?? "0"
                    , oE_Filtros_XplMap_Colgate.codDepartamento ?? "0"
                    , oE_Filtros_XplMap_Colgate.codProvincia ?? "0"
                    , oE_Filtros_XplMap_Colgate.codDistrito ?? "0"
                    , oE_Filtros_XplMap_Colgate.codZona ?? "0"
                    , oE_Filtros_XplMap_Colgate.codCluster ?? "0"
                    , oE_Filtros_XplMap_Colgate.anio ?? "0"
                    , oE_Filtros_XplMap_Colgate.mes ?? "0"
                    , oE_Filtros_XplMap_Colgate.codPeriodo ?? "0"
                    , oE_Filtros_XplMap_Colgate.codOpcion
                );

                #region Backup 03/09/2012 Paso Por Parametros
                //codServicio,  codCanal,  codCliente,  codPais
                //,codDepartamento,  codProvincia,  codDistrito,  codZona
                //,codCluster,  anio,  mes,  codPeriodo,  codOpcion
                #endregion

                //Inicializamos los Array
                oE_VentasZonaDistrito_Detalle.Header = new string[dt.Columns.Count];
                oE_VentasZonaDistrito_Detalle.Contents = new string[dt.Rows.Count][];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_VentasZonaDistrito_Detalle.Contents[i] = new string[dt.Columns.Count];
                }



                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_VentasZonaDistrito_Detalle.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_VentasZonaDistrito_Detalle.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oE_VentasZonaDistrito_Detalle;

        }

        public List<E_VentasZonaDistrito_Detalle_List> Obtener_Evolucion_Venta_SKUMandatorios(E_Filtros_XplMap_Colgate oE_Filtros_XplMap_Colgate)
        {
            List<E_VentasZonaDistrito_Detalle_List> oE_VentasZonaDistrito_Detalle = new List<E_VentasZonaDistrito_Detalle_List>();
            try
            {
                //DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_PRODUCTOS_DISTRI_ZONA", 254, 2008, 1561, 589, "07", "01", "06", 0, 1, 2012, 7, 1145, 2);
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_PRODUCTOS_DISTRI_ZONA"
                    , oE_Filtros_XplMap_Colgate.codServicio
                    , oE_Filtros_XplMap_Colgate.codCanal
                    , oE_Filtros_XplMap_Colgate.codCliente
                    , oE_Filtros_XplMap_Colgate.codPais ?? "0"
                    , oE_Filtros_XplMap_Colgate.codDepartamento ?? "0"
                    , oE_Filtros_XplMap_Colgate.codProvincia ?? "0"
                    , oE_Filtros_XplMap_Colgate.codDistrito ?? "0"
                    , oE_Filtros_XplMap_Colgate.codZona ?? "0"
                    , oE_Filtros_XplMap_Colgate.codCluster ?? "0"
                    , oE_Filtros_XplMap_Colgate.anio ?? "0"
                    , oE_Filtros_XplMap_Colgate.mes ?? "0"
                    , oE_Filtros_XplMap_Colgate.codPeriodo ?? "0"
                    , oE_Filtros_XplMap_Colgate.codOpcion
                );

                if (dt.Rows.Count > 0)
                {
                    E_VentasZonaDistrito_Detalle_List oE_VentasZonaDistrito = new E_VentasZonaDistrito_Detalle_List();

                    //oE_VentasZonaDistrito_Detalle.Header[i] = dt.Columns[i].ColumnName;
                    oE_VentasZonaDistrito.nombreSKU = dt.Columns[0].ColumnName;
                    oE_VentasZonaDistrito.valor1 = dt.Columns[1].ColumnName;
                    oE_VentasZonaDistrito.valor2 = dt.Columns[2].ColumnName;
                    oE_VentasZonaDistrito.valor3 = dt.Columns[3].ColumnName;
                    oE_VentasZonaDistrito.valor4 = dt.Columns[4].ColumnName;
                    oE_VentasZonaDistrito.valor5 = dt.Columns[5].ColumnName;
                    oE_VentasZonaDistrito.valor6 = dt.Columns[6].ColumnName;
                    oE_VentasZonaDistrito.valor7 = dt.Columns[7].ColumnName;
                    oE_VentasZonaDistrito.valor8 = dt.Columns[8].ColumnName;
                    oE_VentasZonaDistrito_Detalle.Add(oE_VentasZonaDistrito);
                }

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_VentasZonaDistrito_Detalle_List oE_VentasZonaDistrito = new E_VentasZonaDistrito_Detalle_List();

                        oE_VentasZonaDistrito.nombreSKU = dt.Rows[i][0].ToString();
                        oE_VentasZonaDistrito.valor1 = dt.Rows[i][1].ToString();
                        oE_VentasZonaDistrito.valor2 = dt.Rows[i][2].ToString();
                        oE_VentasZonaDistrito.valor3 = dt.Rows[i][3].ToString();
                        oE_VentasZonaDistrito.valor4 = dt.Rows[i][4].ToString();
                        oE_VentasZonaDistrito.valor5 = dt.Rows[i][5].ToString();
                        oE_VentasZonaDistrito.valor6 = dt.Rows[i][6].ToString();
                        oE_VentasZonaDistrito.valor7 = dt.Rows[i][7].ToString();
                        oE_VentasZonaDistrito.valor8 = dt.Rows[i][8].ToString();

                        oE_VentasZonaDistrito_Detalle.Add(oE_VentasZonaDistrito);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oE_VentasZonaDistrito_Detalle;

        }

        /// <summary>
        /// Fecha   :05/09/2012 
        /// Author  :Pablo Salas A.
        /// </summary>
        /// <param name="oE_Filtros_XplMap_Colgate"></param>
        /// <returns></returns>
        public List<E_PresenciaZonaDistrito_Detalle_List> Obtener_Evolucion_Presencia_SKUMandatorios(E_Filtros_XplMap_Colgate oE_Filtros_XplMap_Colgate)
        {

            List<E_PresenciaZonaDistrito_Detalle_List> olistE_PresenciaZonaDistrito_Detalle_List = new List<E_PresenciaZonaDistrito_Detalle_List>();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PRESENCIA_PRODUCTOS_DISTRI_ZONA"
                    , oE_Filtros_XplMap_Colgate.codServicio
                    , oE_Filtros_XplMap_Colgate.codCanal
                    , oE_Filtros_XplMap_Colgate.codCliente
                    , oE_Filtros_XplMap_Colgate.codPais ?? "0"
                    , oE_Filtros_XplMap_Colgate.codDepartamento ?? "0"
                    , oE_Filtros_XplMap_Colgate.codProvincia ?? "0"
                    , oE_Filtros_XplMap_Colgate.codDistrito ?? "0"
                    , oE_Filtros_XplMap_Colgate.codZona ?? "0"
                    , oE_Filtros_XplMap_Colgate.codCluster ?? "0"
                    , oE_Filtros_XplMap_Colgate.anio ?? "0"
                    , oE_Filtros_XplMap_Colgate.mes ?? "0"
                    , oE_Filtros_XplMap_Colgate.codPeriodo ?? "0"
                    , oE_Filtros_XplMap_Colgate.codOpcion);


                //Cabecera
                if (dt.Rows.Count > 0)
                {
                    //for (int i = 0; i < dt.Columns.Count; i++)
                    //{
                    E_PresenciaZonaDistrito_Detalle_List oE_PresenciaZonaDistrito_Detalle_List = new E_PresenciaZonaDistrito_Detalle_List();
                    //oE_VentasZonaDistrito_Detalle.Header[i] = dt.Columns[i].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.nombreSKU = dt.Columns[0].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor1 = dt.Columns[1].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor2 = dt.Columns[2].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor3 = dt.Columns[3].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor4 = dt.Columns[4].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor5 = dt.Columns[5].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor6 = dt.Columns[6].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor7 = dt.Columns[7].ColumnName;
                    oE_PresenciaZonaDistrito_Detalle_List.valor8 = dt.Columns[8].ColumnName;
                    olistE_PresenciaZonaDistrito_Detalle_List.Add(oE_PresenciaZonaDistrito_Detalle_List);
                    //}
                }

                //Detalles
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaZonaDistrito_Detalle_List oE_PresenciaZonaDistrito_Detalle_List = new E_PresenciaZonaDistrito_Detalle_List();

                        oE_PresenciaZonaDistrito_Detalle_List.nombreSKU = dt.Rows[i][0].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor1 = dt.Rows[i][1].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor2 = dt.Rows[i][2].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor3 = dt.Rows[i][3].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor4 = dt.Rows[i][4].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor5 = dt.Rows[i][5].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor6 = dt.Rows[i][6].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor7 = dt.Rows[i][7].ToString();
                        oE_PresenciaZonaDistrito_Detalle_List.valor8 = dt.Rows[i][8].ToString();

                        olistE_PresenciaZonaDistrito_Detalle_List.Add(oE_PresenciaZonaDistrito_Detalle_List);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return olistE_PresenciaZonaDistrito_Detalle_List;

        }

        public E_Representatividad_Group Obtener_Representatividad_Group(string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_Representatividad_Group representatividadZonaDistritoMap = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_XPLORAMAPS_REPRESENTATIVIDAD_TOTAL", codZona, codDistrito, idPlanning, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    representatividadZonaDistritoMap = new E_Representatividad_Group();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Representatividad_Base oE_Representatividad_Base = new E_Representatividad_Base();

                        oE_Representatividad_Base.nombre = dt.Rows[i]["nombre"].ToString();
                        oE_Representatividad_Base.cantidad = int.Parse(dt.Rows[i]["cantidad"].ToString());
                        oE_Representatividad_Base.posicion = int.Parse(dt.Rows[i]["Posicion"].ToString());

                        if (oE_Representatividad_Base.posicion == 0) //Provincia
                        {
                            representatividadZonaDistritoMap.representatividadProvincia = oE_Representatividad_Base;
                        }
                        else if (oE_Representatividad_Base.posicion == 1) //Sector
                        {
                            representatividadZonaDistritoMap.representatividadSector = oE_Representatividad_Base;
                        }
                        else if (oE_Representatividad_Base.posicion == 2) //Distrito
                        {
                            representatividadZonaDistritoMap.representatividadDistrito = oE_Representatividad_Base;
                        }
                    }
                }
                return representatividadZonaDistritoMap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PresenciaPDV> Obtener_PuntoVentaPresenciaElemVisibilidad(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_ELEM_VISIBILIDAD_PDV", codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);

                if (dt.Rows.Count > 0)
                {
                    oListPuntoVenta = new List<E_PresenciaPDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaPDV oE_PresenciaPDV = new E_PresenciaPDV();

                        oE_PresenciaPDV.codPuntoVenta = dt.Rows[i]["ClientPDV_Code"].ToString();
                        oE_PresenciaPDV.nombrePuntoVenta = dt.Rows[i]["pdv_Name"].ToString();
                        oE_PresenciaPDV.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PresenciaPDV.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PresenciaPDV.color = dt.Rows[i]["Color"].ToString();

                        oListPuntoVenta.Add(oE_PresenciaPDV);
                    }
                }

                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PresenciaPDV> Obtener_PuntoVentaRango(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codRango, string codPeriodo)
        {
            List<E_PresenciaPDV> oListPuntoVenta = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_RANGO_PDV", codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codRango, codPeriodo);

                if (dt.Rows.Count > 0)
                {
                    oListPuntoVenta = new List<E_PresenciaPDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaPDV oE_PresenciaPDV = new E_PresenciaPDV();

                        oE_PresenciaPDV.codPuntoVenta = dt.Rows[i]["ClientPDV_Code"].ToString();
                        oE_PresenciaPDV.nombrePuntoVenta = dt.Rows[i]["pdv_Name"].ToString();
                        oE_PresenciaPDV.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PresenciaPDV.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PresenciaPDV.color = dt.Rows[i]["Color"].ToString();

                        oListPuntoVenta.Add(oE_PresenciaPDV);
                    }
                }

                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_ExportExcel Obtener_PuntoVentaPresenciaRangoToExcel(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codRango, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_RANGO_PDV_EXCEL",
                    codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codRango, codPeriodo);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oE_ExportExcel;
        }

        public E_ExportExcel Obtener_PuntoVentaPresenciaSKUToExcel(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codProducto, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_SKU_PDV_EXCEL",
                    codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oE_ExportExcel;
        }

        public E_ExportExcel Obtener_PuntoVentaPresenciaElemVisibilidadToExcel(string codCanal, string codPais, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codElemento, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_ELEMVISIBILIDAD_PDV_EXCEL",
                    codCanal, codPais, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oE_ExportExcel;
        }

        //Xplora Maps - Lima
        public E_ExportExcel Obtener_Datos_Tendencia(string codServicio, string codCanal, string codCliente, string codPais,
            string codDpto, string codCity, string codDistrito, string codSector, string codCluster, string codYear,
            string codMes, string codPeriodo, string codOpcion)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_XPLORAMAPS_OBTENER_LISTA_DATA_TENDENCIA", codServicio, codCanal, codCliente, codPais,
                codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oE_ExportExcel;
        }
        //Xplora Maps - Provincias
        public E_ExportExcel Obtener_Datos_Tendencia_Prov(string codServicio, string codCanal, string codCliente, string codPais,
    string codOficina, string codDpto, string codCity, string codDistrito, string codSector, string codCluster, string codYear,
    string codMes, string codPeriodo, string codOpcion)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_XPLORAMAPS_OBTENER_LISTA_DATA_TENDENCIA_Prov", codServicio, codCanal, codCliente, codPais,
                codOficina, codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
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
                DataTable dt = oConexion.ejecutarDataTable("UP_XPLORAMAPS_OBTENER_LISTA_DATA_VARIACION", codServicio, codCanal, codCliente, codPais,
                codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
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
                DataTable dt = oConexion.ejecutarDataTable("UP_XPLORAMAPS_OBTENER_LISTA_DATA_VARIACION_Prov", codServicio, codCanal, codCliente, codPais,
                codOficina, codDpto, codCity, codDistrito, codSector, codCluster, codYear, codMes, codPeriodo, codOpcion);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
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
                DataSet ds = oConexion.ejecutarDataSet("UP_GES_MAPS_OBTENER_SEGUIMIENTO_RUTA", codEquipo, codPais, codDepartamento, codProvincia,
                    codDistrito, codGestor, fecha);

                DataTable pdvRuta = ds.Tables[0];
                DataTable pdvVisitados = ds.Tables[1];
                DataTable pdvNoVisitados = ds.Tables[2];

                if (pdvRuta.Rows.Count > 0)
                {
                    List<E_Seguimiento_Ruta_PDV> oListSeguimientoRutaPDV = new List<E_Seguimiento_Ruta_PDV>();
                    for (int i = 0; i < pdvRuta.Rows.Count; i++)
                    {
                        E_Seguimiento_Ruta_PDV oE_Seguimiento_Ruta_PDV = new E_Seguimiento_Ruta_PDV();

                        oE_Seguimiento_Ruta_PDV.posicion = int.Parse(pdvRuta.Rows[i]["posicion"].ToString());
                        oE_Seguimiento_Ruta_PDV.codigoPtoVenta = pdvRuta.Rows[i]["codigoPtoVenta"].ToString();
                        oE_Seguimiento_Ruta_PDV.nombrePtoVenta = pdvRuta.Rows[i]["nombrePtoVenta"].ToString();
                        oE_Seguimiento_Ruta_PDV.direccion = pdvRuta.Rows[i]["direccion"].ToString();
                        oE_Seguimiento_Ruta_PDV.latitud = pdvRuta.Rows[i]["latitud"].ToString();
                        oE_Seguimiento_Ruta_PDV.longitud = pdvRuta.Rows[i]["longitud"].ToString();

                        oListSeguimientoRutaPDV.Add(oE_Seguimiento_Ruta_PDV);
                    }
                    oE_Seguimiento_Ruta.listPDVRuta = oListSeguimientoRutaPDV;
                }
                else
                {
                    oE_Seguimiento_Ruta.listPDVRuta = new List<E_Seguimiento_Ruta_PDV>();
                }

                if (pdvVisitados.Rows.Count > 0)
                {
                    List<E_Seguimiento_Ruta_Visitado> oListSeguimientoRutaVisitado = new List<E_Seguimiento_Ruta_Visitado>();
                    int total = pdvVisitados.Rows.Count;
                    for (int i = 0; i < pdvVisitados.Rows.Count; i++)
                    {
                        E_Seguimiento_Ruta_Visitado oE_Seguimiento_Ruta_Visitado = new E_Seguimiento_Ruta_Visitado();

                        oE_Seguimiento_Ruta_Visitado.posicion = int.Parse(pdvVisitados.Rows[i]["posicion"].ToString());
                        oE_Seguimiento_Ruta_Visitado.zona = pdvVisitados.Rows[i]["zona"].ToString();
                        oE_Seguimiento_Ruta_Visitado.codigoPtoVenta = pdvVisitados.Rows[i]["codigoPtoVenta"].ToString();
                        oE_Seguimiento_Ruta_Visitado.nombrePtoVenta = pdvVisitados.Rows[i]["nombrePtoVenta"].ToString();
                        oE_Seguimiento_Ruta_Visitado.distrito = pdvVisitados.Rows[i]["distrito"].ToString();
                        oE_Seguimiento_Ruta_Visitado.direccion = pdvVisitados.Rows[i]["direccion"].ToString();
                        oE_Seguimiento_Ruta_Visitado.inicioVisitaDate = Convert.ToDateTime(pdvVisitados.Rows[i]["inicioVisita"]);
                        oE_Seguimiento_Ruta_Visitado.finVisitaDate = Convert.ToDateTime(pdvVisitados.Rows[i]["finVisita"]);
                        if (oE_Seguimiento_Ruta_Visitado.inicioVisitaDate.ToString() != ""
                            || oE_Seguimiento_Ruta_Visitado.inicioVisitaDate.ToString() != "0"
                            || oE_Seguimiento_Ruta_Visitado.finVisitaDate.ToString() != ""
                            || oE_Seguimiento_Ruta_Visitado.finVisitaDate.ToString() != "0")
                        {
                            oE_Seguimiento_Ruta_Visitado.inicioVisita = String.Format("{0:T}", oE_Seguimiento_Ruta_Visitado.inicioVisitaDate);
                            oE_Seguimiento_Ruta_Visitado.finVisita = String.Format("{0:T}", oE_Seguimiento_Ruta_Visitado.finVisitaDate);
                            DateTime converted = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                            TimeSpan resta = oE_Seguimiento_Ruta_Visitado.finVisitaDate.Subtract(oE_Seguimiento_Ruta_Visitado.inicioVisitaDate);
                            oE_Seguimiento_Ruta_Visitado.atencion = String.Format("{0:%h}:{0:%m}:{0:%s}", resta); //String.Format("H:mm:ss}", converted.AddSeconds(resta.TotalSeconds));

                            var timeSpan = resta;

                            var seconds = timeSpan.TotalMinutes;

                            oE_Seguimiento_Ruta_Visitado.atencionSeg = seconds;
                        }
                        else
                        {
                            oE_Seguimiento_Ruta_Visitado.inicioVisita = "0";
                            oE_Seguimiento_Ruta_Visitado.finVisita = "0";
                            oE_Seguimiento_Ruta_Visitado.atencion = "0";
                        }

                        DateTime finAnterior;

                        if (i == 0)
                        {
                            oE_Seguimiento_Ruta_Visitado.traslado = "0";
                            oE_Seguimiento_Ruta_Visitado.trasladoSeg = 0;
                        }
                        else
                        {
                            int j = i;
                            finAnterior = Convert.ToDateTime(pdvVisitados.Rows[j - 1]["finVisita"]);
                        }

                        if (i > 0)
                        {
                            if (oE_Seguimiento_Ruta_Visitado.inicioVisitaDate.ToString() != ""
                               || oE_Seguimiento_Ruta_Visitado.inicioVisitaDate.ToString() != "0")
                            {
                                int j = i;
                                DateTime inicioActual = oE_Seguimiento_Ruta_Visitado.inicioVisitaDate;
                                finAnterior = Convert.ToDateTime(pdvVisitados.Rows[j - 1]["finVisita"]);

                                DateTime converted = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                                TimeSpan resta = inicioActual.Subtract(finAnterior);

                                var timeSpan = resta;

                                var seconds = timeSpan.TotalMinutes;

                                oE_Seguimiento_Ruta_Visitado.trasladoSeg = seconds;
                                oE_Seguimiento_Ruta_Visitado.traslado = String.Format("{0:%h}:{0:%m}:{0:%s}", resta);
                            }
                        }

                        oE_Seguimiento_Ruta_Visitado.estado = pdvVisitados.Rows[i]["estado"].ToString();
                        oE_Seguimiento_Ruta_Visitado.colorEstado = pdvVisitados.Rows[i]["colorEstado"].ToString();
                        oE_Seguimiento_Ruta_Visitado.latitud = pdvVisitados.Rows[i]["latitud"].ToString();
                        oE_Seguimiento_Ruta_Visitado.longitud = pdvVisitados.Rows[i]["longitud"].ToString();
                        oE_Seguimiento_Ruta_Visitado.listaFoto = new List<E_Foto_Visitado>();

                        DataTable fotoPDV = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_SEGUIMIENTO_RUTA_FOTO_PDV", codEquipo, oE_Seguimiento_Ruta_Visitado.codigoPtoVenta, fecha);

                        if (fotoPDV.Rows.Count > 0)
                        {
                            for (int k = 0; k < fotoPDV.Rows.Count; k++)
                            {
                                E_Foto_Visitado oFotoPDV = new E_Foto_Visitado();
                                oFotoPDV.nombreFoto = fotoPDV.Rows[k]["nombreFoto"].ToString();
                                oE_Seguimiento_Ruta_Visitado.listaFoto.Add(oFotoPDV);
                            }
                        }

                        oListSeguimientoRutaVisitado.Add(oE_Seguimiento_Ruta_Visitado);
                    }
                    oE_Seguimiento_Ruta.listPDVVisitados = oListSeguimientoRutaVisitado;
                }
                else
                {
                    oE_Seguimiento_Ruta.listPDVVisitados = new List<E_Seguimiento_Ruta_Visitado>();
                }

                if (pdvNoVisitados.Rows.Count > 0)
                {
                    List<E_Seguimiento_Ruta_Visitado> oListSeguimientoRutaNoVisitado = new List<E_Seguimiento_Ruta_Visitado>();
                    for (int i = 0; i < pdvNoVisitados.Rows.Count; i++)
                    {
                        E_Seguimiento_Ruta_Visitado oE_Seguimiento_Ruta_No_Visitado = new E_Seguimiento_Ruta_Visitado();

                        oE_Seguimiento_Ruta_No_Visitado.posicion = int.Parse(pdvNoVisitados.Rows[i]["posicion"].ToString());
                        oE_Seguimiento_Ruta_No_Visitado.zona = pdvNoVisitados.Rows[i]["zona"].ToString();
                        oE_Seguimiento_Ruta_No_Visitado.codigoPtoVenta = pdvNoVisitados.Rows[i]["codigoPtoVenta"].ToString();
                        oE_Seguimiento_Ruta_No_Visitado.nombrePtoVenta = pdvNoVisitados.Rows[i]["nombrePtoVenta"].ToString();
                        oE_Seguimiento_Ruta_No_Visitado.distrito = pdvNoVisitados.Rows[i]["distrito"].ToString();
                        oE_Seguimiento_Ruta_No_Visitado.direccion = pdvNoVisitados.Rows[i]["direccion"].ToString();
                        //oE_Seguimiento_Ruta_No_Visitado.inicioVisitaDate = Convert.ToDateTime(pdvRuta.Rows[i]["inicioVisita"]);
                        //oE_Seguimiento_Ruta_No_Visitado.finVisitaDate = Convert.ToDateTime(pdvRuta.Rows[i]["finVisita"]);
                        //oE_Seguimiento_Ruta_No_Visitado.inicioVisita = String.Format("{0:T}", oE_Seguimiento_Ruta_No_Visitado.inicioVisitaDate);
                        //oE_Seguimiento_Ruta_No_Visitado.finVisita = String.Format("{0:T}", oE_Seguimiento_Ruta_No_Visitado.finVisitaDate);
                        //oE_Seguimiento_Ruta_No_Visitado.traslado = String.Format("{0:T}", Convert.ToDateTime(oE_Seguimiento_Ruta_No_Visitado.finVisitaDate.Subtract(oE_Seguimiento_Ruta_No_Visitado.inicioVisitaDate).ToString()));
                        oE_Seguimiento_Ruta_No_Visitado.estado = pdvNoVisitados.Rows[i]["estado"].ToString();
                        oE_Seguimiento_Ruta_No_Visitado.colorEstado = pdvNoVisitados.Rows[i]["colorEstado"].ToString();
                        oE_Seguimiento_Ruta_No_Visitado.latitud = pdvNoVisitados.Rows[i]["latitud"].ToString();
                        oE_Seguimiento_Ruta_No_Visitado.longitud = pdvNoVisitados.Rows[i]["longitud"].ToString();

                        oListSeguimientoRutaNoVisitado.Add(oE_Seguimiento_Ruta_No_Visitado);
                    }
                    oE_Seguimiento_Ruta.listPDVNoVisitados = oListSeguimientoRutaNoVisitado;
                }
                else
                {
                    oE_Seguimiento_Ruta.listPDVNoVisitados = new List<E_Seguimiento_Ruta_Visitado>();
                }

                return oE_Seguimiento_Ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Cobertura Obtener_Cobertura_PDV_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            E_Cobertura oE_Cobertura = new E_Cobertura();
            try
            {
                DataTable result = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_COBERTURA", codCliente, codCanal, codCadena, reportsPlanning);
                oE_Cobertura.totalPDV = int.Parse(result.Rows[0]["totalPDV"].ToString());
                oE_Cobertura.totalPDVVisitados = int.Parse(result.Rows[0]["totalPDVVisitados"].ToString());
                oE_Cobertura.alcance = double.Parse(result.Rows[0]["alcance"].ToString());
                return oE_Cobertura;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Status_EQF> Obtener_Status_EQF_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Status_EQF> oListStatusEQF = new List<E_Status_EQF>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_STATUS_EQF", codCliente, codCanal, codCadena, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Status_EQF oE_Status_EQF = new E_Status_EQF();

                        oE_Status_EQF.codigo = dt.Rows[i]["codigo"].ToString();
                        oE_Status_EQF.nombre = dt.Rows[i]["nombre"].ToString();
                        oE_Status_EQF.cantidad = int.Parse(dt.Rows[i]["cantidad"].ToString());

                        oListStatusEQF.Add(oE_Status_EQF);
                    }
                }

                return oListStatusEQF;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Presencia_ElementoVisibilidad> Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Presencia_ElementoVisibilidad> oListElementoVisibilidad = new List<E_Presencia_ElementoVisibilidad>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_ELEMENTOS_VISIBILIDAD", codCliente, codCanal, codCadena, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Presencia_ElementoVisibilidad oE_Presencia_ElementoVisibilidad = new E_Presencia_ElementoVisibilidad();

                        oE_Presencia_ElementoVisibilidad.codigoElemento = dt.Rows[i]["codigoElemento"].ToString();
                        oE_Presencia_ElementoVisibilidad.nombreElemento = dt.Rows[i]["nombreElemento"].ToString();
                        oE_Presencia_ElementoVisibilidad.porcentaje = double.Parse(dt.Rows[i]["porcentaje"].ToString());
                        oE_Presencia_ElementoVisibilidad.tipo = dt.Rows[i]["tipo"].ToString();

                        oListElementoVisibilidad.Add(oE_Presencia_ElementoVisibilidad);
                    }
                }

                return oListElementoVisibilidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Presencia_Producto> Obtener_Presencia_Producto_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Presencia_Producto> oListProducto = new List<E_Presencia_Producto>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_PRODUCTO", codCliente, codCanal, codCadena, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Presencia_Producto oE_Presencia_Producto = new E_Presencia_Producto();

                        oE_Presencia_Producto.codigoProducto = dt.Rows[i]["codigoProducto"].ToString();
                        oE_Presencia_Producto.nombreProducto = dt.Rows[i]["nombreProducto"].ToString();
                        oE_Presencia_Producto.codigoCategoria = dt.Rows[i]["codigoCategoria"].ToString();
                        oE_Presencia_Producto.nombreCategoria = dt.Rows[i]["nombreCategoria"].ToString();
                        oE_Presencia_Producto.valor = double.Parse(dt.Rows[i]["valor"].ToString());

                        oListProducto.Add(oE_Presencia_Producto);
                    }
                }

                return oListProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Presencia_Producto> Obtener_Precio_Producto_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_Presencia_Producto> oListProducto = new List<E_Presencia_Producto>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRECIO_PRODUCTO", codCliente, codCanal, codCadena, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Presencia_Producto oE_Presencia_Producto = new E_Presencia_Producto();

                        oE_Presencia_Producto.codigoProducto = dt.Rows[i]["codigoProducto"].ToString();
                        oE_Presencia_Producto.nombreProducto = dt.Rows[i]["nombreProducto"].ToString();
                        oE_Presencia_Producto.codigoCategoria = dt.Rows[i]["codigoCategoria"].ToString();
                        oE_Presencia_Producto.nombreCategoria = dt.Rows[i]["nombreCategoria"].ToString();
                        oE_Presencia_Producto.valor = double.Parse(dt.Rows[i]["valor"].ToString());

                        oListProducto.Add(oE_Presencia_Producto);
                    }
                }

                return oListProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PuntoVentaMapa> Obtener_PDV_Cluster_x_Canal_Cadena(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_PuntoVentaMapa> oListPuntoVenta = new List<E_PuntoVentaMapa>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PDV_CLUSTER", codCliente, codCanal, codCadena, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PuntoVentaMapa oE_PuntoVentaMapa = new E_PuntoVentaMapa();

                        oE_PuntoVentaMapa.codPuntoVenta = dt.Rows[i]["codPuntoVenta"].ToString();
                        oE_PuntoVentaMapa.nombrePuntoVenta = dt.Rows[i]["nombrePuntoVenta"].ToString();
                        oE_PuntoVentaMapa.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PuntoVentaMapa.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PuntoVentaMapa.segmento = dt.Rows[i]["segmento"].ToString();
                        oE_PuntoVentaMapa.color = dt.Rows[i]["color"].ToString();

                        oListPuntoVenta.Add(oE_PuntoVentaMapa);
                    }
                }

                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_PuntoVentaDatosMapa Obtener_Datos_PDV_x_Cliente(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            E_PuntoVentaDatosMapa oPtoVenta = new E_PuntoVentaDatosMapa();
            oPtoVenta.listFotos = new List<E_Foto>();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_DATO_PDV_X_CLIENTE", codCliente, codPtoVenta, reportsPlanning);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        oPtoVenta.codPuntoVenta = dt.Rows[0]["CodPuntoVenta"].ToString();
                        oPtoVenta.nombrePuntoVenta = dt.Rows[0]["NombrePuntoVenta"].ToString();
                        oPtoVenta.direccion = dt.Rows[0]["Direccion"].ToString();
                        oPtoVenta.distrito = dt.Rows[0]["Distrito"].ToString();
                        oPtoVenta.sector = dt.Rows[0]["Sector"].ToString();
                        oPtoVenta.ultimaVisita = dt.Rows[0]["UltimaVisita"].ToString();
                        oPtoVenta.nombreGestor = dt.Rows[0]["Generador"].ToString();
                        oPtoVenta.nombreAdministrador = dt.Rows[0]["Administrador"].ToString();
                        oPtoVenta.email = dt.Rows[0]["Email"].ToString();
                        oPtoVenta.rutaVendedor = dt.Rows[0]["RutaVendedor"].ToString();
                        oPtoVenta.nombreVendedor = dt.Rows[0]["nombreVendedor"].ToString();
                        oPtoVenta.zona = dt.Rows[0]["zona"].ToString();
                        oPtoVenta.cumpleanios = dt.Rows[0]["cumpleanios"].ToString();
                        oPtoVenta.horaAtencion = dt.Rows[0]["horaAtencion"].ToString();
                        oPtoVenta.numeroLocales = dt.Rows[0]["numeroLocales"].ToString();
                        oPtoVenta.estado = int.Parse(dt.Rows[0]["estado"].ToString());

                        DataTable dtFoto = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PDV_FOTOS", codCliente, codPtoVenta, reportsPlanning);

                        if (dtFoto.Rows.Count > 0)
                        {
                            for (int k = 0; k < dtFoto.Rows.Count; k++)
                            {
                                E_Foto oE_Foto = new E_Foto();

                                oE_Foto.nombreFoto = dtFoto.Rows[k]["nombreFoto"].ToString();

                                oPtoVenta.listFotos.Add(oE_Foto);
                            }
                        }
                    }
                }
                return oPtoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Presencia_Producto> Obtener_Presencia_Producto_x_PDV(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            List<E_Presencia_Producto> oListProducto = new List<E_Presencia_Producto>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_PRODUCTO_X_PDV", codCliente, codPtoVenta, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Presencia_Producto oE_Presencia_Producto = new E_Presencia_Producto();

                        oE_Presencia_Producto.codigoProducto = dt.Rows[i]["codigoProducto"].ToString();
                        oE_Presencia_Producto.nombreProducto = dt.Rows[i]["nombreProducto"].ToString();
                        oE_Presencia_Producto.codigoCategoria = dt.Rows[i]["codigoCategoria"].ToString();
                        oE_Presencia_Producto.nombreCategoria = dt.Rows[i]["nombreCategoria"].ToString();
                        oE_Presencia_Producto.valor = double.Parse(dt.Rows[i]["valor"].ToString());

                        oListProducto.Add(oE_Presencia_Producto);
                    }
                }

                return oListProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Presencia_Producto> Obtener_Precio_Producto_x_PDV(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            List<E_Presencia_Producto> oListProducto = new List<E_Presencia_Producto>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRECIO_PRODUCTO_X_PDV", codCliente, codPtoVenta, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Presencia_Producto oE_Presencia_Producto = new E_Presencia_Producto();

                        oE_Presencia_Producto.codigoProducto = dt.Rows[i]["codigoProducto"].ToString();
                        oE_Presencia_Producto.nombreProducto = dt.Rows[i]["nombreProducto"].ToString();
                        oE_Presencia_Producto.codigoCategoria = dt.Rows[i]["codigoCategoria"].ToString();
                        oE_Presencia_Producto.nombreCategoria = dt.Rows[i]["nombreCategoria"].ToString();
                        oE_Presencia_Producto.valor = double.Parse(dt.Rows[i]["valor"].ToString());

                        oListProducto.Add(oE_Presencia_Producto);
                    }
                }

                return oListProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Presencia_ElementoVisibilidad> Obtener_MaterialApoyo_x_PDV(string codCliente, string codPtoVenta, string reportsPlanning)
        {
            List<E_Presencia_ElementoVisibilidad> oListElementoVisibilidad = new List<E_Presencia_ElementoVisibilidad>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_ELEMENTOS_VISIBILIDAD_X_PDV", codCliente, codPtoVenta, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Presencia_ElementoVisibilidad oE_Presencia_ElementoVisibilidad = new E_Presencia_ElementoVisibilidad();

                        oE_Presencia_ElementoVisibilidad.codigoElemento = dt.Rows[i]["codigoElemento"].ToString();
                        oE_Presencia_ElementoVisibilidad.nombreElemento = dt.Rows[i]["nombreElemento"].ToString();
                        oE_Presencia_ElementoVisibilidad.porcentaje = double.Parse(dt.Rows[i]["porcentaje"].ToString());
                        oE_Presencia_ElementoVisibilidad.tipo = dt.Rows[i]["tipo"].ToString();

                        oListElementoVisibilidad.Add(oE_Presencia_ElementoVisibilidad);
                    }
                }

                return oListElementoVisibilidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_PuntoVentaDatosMapa> Obtener_PDV_x_Cliente(string codCliente, string codCanal, string codCadena, string reportsPlanning)
        {
            List<E_PuntoVentaDatosMapa> oListPtoVenta = new List<E_PuntoVentaDatosMapa>();

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PDV_X_CLIENTE", codCliente, codCanal, codCadena, reportsPlanning);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PuntoVentaDatosMapa oPtoVenta = new E_PuntoVentaDatosMapa();
                        oPtoVenta.listFotos = new List<E_Foto>();

                        oPtoVenta.codPuntoVenta = dt.Rows[i]["CodPuntoVenta"].ToString();
                        oPtoVenta.nombrePuntoVenta = dt.Rows[i]["NombrePuntoVenta"].ToString();
                        oPtoVenta.direccion = dt.Rows[i]["Direccion"].ToString();
                        oPtoVenta.distrito = dt.Rows[i]["Distrito"].ToString();
                        oPtoVenta.sector = dt.Rows[i]["Sector"].ToString();
                        oPtoVenta.ultimaVisita = dt.Rows[i]["UltimaVisita"].ToString();
                        oPtoVenta.nombreGestor = dt.Rows[i]["Generador"].ToString();
                        oPtoVenta.nombreAdministrador = dt.Rows[i]["Administrador"].ToString();
                        oPtoVenta.email = dt.Rows[i]["Email"].ToString();
                        oPtoVenta.rutaVendedor = dt.Rows[i]["RutaVendedor"].ToString();
                        oPtoVenta.nombreVendedor = dt.Rows[i]["nombreVendedor"].ToString();
                        oPtoVenta.zona = dt.Rows[i]["zona"].ToString();
                        oPtoVenta.cumpleanios = dt.Rows[i]["cumpleanios"].ToString();
                        oPtoVenta.horaAtencion = dt.Rows[i]["horaAtencion"].ToString();
                        oPtoVenta.numeroLocales = dt.Rows[i]["numeroLocales"].ToString();
                        oPtoVenta.estado = int.Parse(dt.Rows[i]["estado"].ToString());

                        DataTable dtFoto = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PDV_FOTOS", codCliente, oPtoVenta.codPuntoVenta, reportsPlanning);

                        if (dtFoto.Rows.Count > 0)
                        {
                            for (int k = 0; k < dtFoto.Rows.Count; k++)
                            {
                                E_Foto oE_Foto = new E_Foto();

                                oE_Foto.nombreFoto = dtFoto.Rows[k]["nombreFoto"].ToString();

                                oPtoVenta.listFotos.Add(oE_Foto);
                            }
                        }

                        oListPtoVenta.Add(oPtoVenta);
                    }
                }

                return oListPtoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region XploraGis - Provincia (Ciudad - Distrito)
        #region Sección Universo >>Warning<<

        //1.-Total de PDV’s por ciudad.(considerar periodo).
        public E_ClusterZonaDistrito_Group Obtener_ClusterZonaDistritoMap_Prov(string codOficina, string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_ClusterZonaDistrito_Group clusterZonaDistritoMap = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_CLUSTER_Prov", codOficina, codZona, codDistrito, idPlanning, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    clusterZonaDistritoMap = new E_ClusterZonaDistrito_Group();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_ClusterZonaDistrito oE_ClusterZonaDistrito = new E_ClusterZonaDistrito();

                        oE_ClusterZonaDistrito.cluster = dt.Rows[i]["Descripcion"].ToString();
                        oE_ClusterZonaDistrito.cantidad = dt.Rows[i]["Cantidad"].ToString();
                        oE_ClusterZonaDistrito.codigo = dt.Rows[i]["Codigo"].ToString();
                        oE_ClusterZonaDistrito.posicion = int.Parse(dt.Rows[i]["Posicion"].ToString());

                        if (oE_ClusterZonaDistrito.posicion == 0) //Provincia
                        {
                            clusterZonaDistritoMap.listClusterProvincia.Add(oE_ClusterZonaDistrito);
                        }
                        else if (oE_ClusterZonaDistrito.posicion == 1) //Sector
                        {
                            clusterZonaDistritoMap.listClusterSector.Add(oE_ClusterZonaDistrito);
                        }
                        else if (oE_ClusterZonaDistrito.posicion == 2) //Distrito
                        {
                            clusterZonaDistritoMap.listClusterDistrito.Add(oE_ClusterZonaDistrito);
                        }
                        else if (oE_ClusterZonaDistrito.posicion == 3) //Distrito
                        {
                            clusterZonaDistritoMap.listClusterVisitado.Add(oE_ClusterZonaDistrito);
                        }
                    }
                }
                return clusterZonaDistritoMap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //2.-Total de PDV’s visitados por ciudad y a su vez éstos por clúster.(considerar periodo).
        public E_Representatividad_Group Obtener_Representatividad_Group_Prov(string codOficina, string codZona, string codDistrito, string idPlanning, string reportsPlanning)
        {
            E_Representatividad_Group representatividadZonaDistritoMap = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_XPLORAMAPS_REPRESENTATIVIDAD_TOTAL_Prov", codOficina, codZona, codDistrito, idPlanning, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    representatividadZonaDistritoMap = new E_Representatividad_Group();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Representatividad_Base oE_Representatividad_Base = new E_Representatividad_Base();

                        oE_Representatividad_Base.nombre = dt.Rows[i]["nombre"].ToString();
                        oE_Representatividad_Base.cantidad = int.Parse(dt.Rows[i]["cantidad"].ToString());
                        oE_Representatividad_Base.posicion = int.Parse(dt.Rows[i]["Posicion"].ToString());

                        if (oE_Representatividad_Base.posicion == 0) //Provincia
                        {
                            representatividadZonaDistritoMap.representatividadProvincia = oE_Representatividad_Base;
                        }
                        else if (oE_Representatividad_Base.posicion == 1) //Sector
                        {
                            representatividadZonaDistritoMap.representatividadSector = oE_Representatividad_Base;
                        }
                        else if (oE_Representatividad_Base.posicion == 2) //Distrito
                        {
                            representatividadZonaDistritoMap.representatividadDistrito = oE_Representatividad_Base;
                        }
                    }
                }
                return representatividadZonaDistritoMap;
            }
            catch (Exception ex)
            {
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
                DataTable dt = oConexion.ejecutarDataTable("UP_WEBXPLORA_PRESENCIA_MAPS_Prov", servicio, canal, codCliente, codOficina, coddepartamento, codciudad, codZona, codDistrito, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    oListPresencia = new List<E_PresenciaZonaDistrito>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaZonaDistrito presencia = new E_PresenciaZonaDistrito();

                        presencia.id_tipo = dt.Rows[i]["idTipo"].ToString();
                        presencia.tipo = dt.Rows[i]["tipo"].ToString();
                        presencia.id_elemento = dt.Rows[i]["idElemento"].ToString();
                        presencia.nombre_elemento = dt.Rows[i]["nombreElemento"].ToString();
                        presencia.coverage = dt.Rows[i]["coverage"].ToString();
                        presencia.totalcoverage = dt.Rows[i]["totalCoverage"].ToString();
                        presencia.rangos = dt.Rows[i]["Rangos"].ToString();
                        presencia.cobertura = dt.Rows[i]["Cobertura"].ToString();
                        presencia.nombreCliente = dt.Rows[i]["company"].ToString();

                        oListPresencia.Add(presencia);
                    }
                }
                return oListPresencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<E_PuntoVentaCluster> Obtener_PuntoVentaCluster_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string cluster, string codPeriodo)
        {
            List<E_PuntoVentaCluster> oList_PuntoVentaCluster = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PRESENCIA_CLUSTER_Prov", codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, cluster, codPeriodo);
                if (dt.Rows.Count > 0)
                {
                    oList_PuntoVentaCluster = new List<E_PuntoVentaCluster>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PuntoVentaCluster oE_PuntoVentaCluster = new E_PuntoVentaCluster();

                        oE_PuntoVentaCluster.codPuntoVenta = dt.Rows[i]["pdv_code"].ToString();
                        oE_PuntoVentaCluster.nombrePuntoVenta = dt.Rows[i]["pdv_name"].ToString();
                        oE_PuntoVentaCluster.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PuntoVentaCluster.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PuntoVentaCluster.cantidad = dt.Rows[i]["cantidad"].ToString();
                        oE_PuntoVentaCluster.total = dt.Rows[i]["total"].ToString();
                        oE_PuntoVentaCluster.presencia = dt.Rows[i]["presencia"].ToString();
                        oE_PuntoVentaCluster.color = dt.Rows[i]["color"].ToString();
                        oE_PuntoVentaCluster.cluster = dt.Rows[i]["cluster"].ToString();
                        oE_PuntoVentaCluster.cobertura = dt.Rows[i]["cobertura"].ToString();

                        oList_PuntoVentaCluster.Add(oE_PuntoVentaCluster);
                    }
                }
                return oList_PuntoVentaCluster;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_RANGO_PDV_Prov", codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codRango, codPeriodo);

                if (dt.Rows.Count > 0)
                {
                    oListPuntoVenta = new List<E_PresenciaPDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaPDV oE_PresenciaPDV = new E_PresenciaPDV();

                        oE_PresenciaPDV.codPuntoVenta = dt.Rows[i]["ClientPDV_Code"].ToString();
                        oE_PresenciaPDV.nombrePuntoVenta = dt.Rows[i]["pdv_Name"].ToString();
                        oE_PresenciaPDV.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PresenciaPDV.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PresenciaPDV.color = dt.Rows[i]["Color"].ToString();

                        oListPuntoVenta.Add(oE_PresenciaPDV);
                    }
                }

                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito_Prov(int servicio, string canal, int codCliente, string codOficina, string codDepartamento, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        {
            List<E_ElemVisibilidadZonaDistrito> oListPresencia = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_WEBXPLORA_PRESENCIA_ELEMVISIB_MAPS_Prov", servicio, canal, codCliente, codOficina,codDepartamento, codciudad, codZona, codDistrito, reportsPlanning);
                if (dt.Rows.Count > 0)
                {
                    oListPresencia = new List<E_ElemVisibilidadZonaDistrito>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_ElemVisibilidadZonaDistrito presencia = new E_ElemVisibilidadZonaDistrito();

                        presencia.idElemento = dt.Rows[i]["idElemento"].ToString();
                        presencia.nombreElemento = dt.Rows[i]["nombreElemento"].ToString();
                        presencia.nombrePropio = dt.Rows[i]["nombrePropio"].ToString();
                        presencia.cantidadPropio = dt.Rows[i]["cantidadPropio"].ToString();
                        presencia.nombreCompetencia = dt.Rows[i]["nombreCompetencia"].ToString();
                        presencia.cantidadCompetencia = dt.Rows[i]["cantidadCompetencia"].ToString();

                        oListPresencia.Add(presencia);
                    }
                }
                return oListPresencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //1.2.-Exportar a Excel por Rangos
        public E_ExportExcel Obtener_PuntoVentaPresenciaRangoToExcel_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codRango, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_RANGO_PDV_EXCEL_Prov",
                    codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codRango, codPeriodo);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
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
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_SKU_PDV_Prov", codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);

                if (dt.Rows.Count > 0)
                {
                    oListPuntoVenta = new List<E_PresenciaPDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaPDV oE_PresenciaPDV = new E_PresenciaPDV();

                        oE_PresenciaPDV.codPuntoVenta = dt.Rows[i]["ClientPDV_Code"].ToString();
                        oE_PresenciaPDV.nombrePuntoVenta = dt.Rows[i]["pdv_Name"].ToString();
                        oE_PresenciaPDV.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PresenciaPDV.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PresenciaPDV.color = dt.Rows[i]["Color"].ToString();

                        oListPuntoVenta.Add(oE_PresenciaPDV);
                    }
                }

                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //2.2.-Exportar a Excel por SKUMandatorios
        public E_ExportExcel Obtener_PuntoVentaPresenciaSKUToExcel_Prov(string codCanal, string codPais, string codOficina, string codDepartamento, string codProvincia, string codZona, string codDistrito, string codProducto, string codPeriodo)
        {
            E_ExportExcel oE_ExportExcel = new E_ExportExcel();
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_SKU_PDV_EXCEL_Prov",
                    codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codProducto, codPeriodo);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
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
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_ELEMVISIBILIDAD_PDV_EXCEL_Prov",
                    codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);

                //Inicializamos los Array
                oE_ExportExcel.Header = new string[dt.Columns.Count];
                oE_ExportExcel.Contents = new string[dt.Rows.Count][];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    oE_ExportExcel.Contents[i] = new string[dt.Columns.Count];
                }

                //Obtenemos las cabeceras
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    oE_ExportExcel.Header[i] = dt.Columns[i].ColumnName;
                }

                //Obtenemos los Detalles
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        oE_ExportExcel.Contents[i][j] = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
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
                DataTable dt = oConexion.ejecutarDataTable("UP_GES_MAPS_OBTENER_PRESENCIA_ELEM_VISIBILIDAD_PDV_Prov", codCanal, codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codElemento, codPeriodo);

                if (dt.Rows.Count > 0)
                {
                    oListPuntoVenta = new List<E_PresenciaPDV>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_PresenciaPDV oE_PresenciaPDV = new E_PresenciaPDV();

                        oE_PresenciaPDV.codPuntoVenta = dt.Rows[i]["ClientPDV_Code"].ToString();
                        oE_PresenciaPDV.nombrePuntoVenta = dt.Rows[i]["pdv_Name"].ToString();
                        oE_PresenciaPDV.latitud = dt.Rows[i]["latitud"].ToString();
                        oE_PresenciaPDV.longitud = dt.Rows[i]["longitud"].ToString();
                        oE_PresenciaPDV.color = dt.Rows[i]["Color"].ToString();

                        oListPuntoVenta.Add(oE_PresenciaPDV);
                    }
                }

                return oListPuntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_PRESENCIA_TENDENCIA_DISTRI_ZONA_Prov", codServicio, codCanal, codCliente,
                    codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);

                DataTable dtVentas = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_TENDENCIA_Prov", codServicio, codCanal, codCliente,
                    codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);


                if (dt.Rows.Count > 0)
                {
                    oListGraficoTendencia = new List<E_Grafico_Tendencia>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Grafico_Tendencia oE_Grafico_Tendencia = new E_Grafico_Tendencia();

                        string ventas = "";
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (dt.Rows[i]["row_id"].ToString() == dtVentas.Rows[j]["rowId"].ToString())
                            {
                                ventas = dtVentas.Rows[j]["ventas"].ToString();
                                break;
                            }
                        }

                        oE_Grafico_Tendencia.orden = dt.Rows[i]["row_id"].ToString();
                        oE_Grafico_Tendencia.cebecera = dt.Rows[i]["cabecera"].ToString();
                        oE_Grafico_Tendencia.coverage = dt.Rows[i]["coverage"].ToString();
                        oE_Grafico_Tendencia.totalCoverage = dt.Rows[i]["total_coverage"].ToString();
                        oE_Grafico_Tendencia.porcentaje = dt.Rows[i]["porcentaje"].ToString();
                        oE_Grafico_Tendencia.ventas = ventas;
                        oE_Grafico_Tendencia.rangoFecha = dt.Rows[i]["rango_fecha"].ToString();
                        oE_Grafico_Tendencia.codPeriodo = dt.Rows[i]["id_reportsplanning"].ToString();

                        oListGraficoTendencia.Add(oE_Grafico_Tendencia);
                    }
                }

                return oListGraficoTendencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                DataTable dt = oConexion.ejecutarDataTable("SP_GES_MAPS_OBTENER_VENTAS_VARIACION_Prov", codServicio, codCanal, codCliente,
                    codPais, codOficina, codDepartamento, codProvincia, codZona, codDistrito, codCategoria, codProducto, codCluster,
                    anio, mes, codPeriodo, codOpcion);

                if (dt.Rows.Count > 0)
                {
                    oListGraficoVariacion = new List<E_Grafico_Variacion>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Grafico_Variacion oE_Grafico_Variacion = new E_Grafico_Variacion();

                        oE_Grafico_Variacion.orden = dt.Rows[i]["rowId"].ToString();
                        oE_Grafico_Variacion.idElemento = dt.Rows[i]["idElemento"].ToString();
                        oE_Grafico_Variacion.nombreElemento = dt.Rows[i]["nombreElemento"].ToString();
                        oE_Grafico_Variacion.ventas = dt.Rows[i]["ventas"].ToString();
                        oE_Grafico_Variacion.anio = dt.Rows[i]["anio"].ToString();
                        oE_Grafico_Variacion.mes = dt.Rows[i]["mes"].ToString();
                        oE_Grafico_Variacion.periodo = dt.Rows[i]["periodo"].ToString();
                        oE_Grafico_Variacion.descripcion = dt.Rows[i]["descripcion"].ToString();

                        oListGraficoVariacion.Add(oE_Grafico_Variacion);
                    }
                }

                return oListGraficoVariacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        #region XploraMaps - Alicorp
        //Add Psa. Fecha: 15/11/2012
        public List<E_PuntoDeVenta> Obtener_PDV_x_Cliente_Canal(string CodCliente, string CodCanal)
        {
            List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtPdvByCliCan", CodCliente, CodCanal);
                while (readerSinc.Read()) {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerSinc.GetValue(readerSinc.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Latitud = readerSinc.GetValue(readerSinc.GetOrdinal("Latitud")).ToString().Trim();
                    oE_PuntoDeVenta.Longitud = readerSinc.GetValue(readerSinc.GetOrdinal("Longitud")).ToString().Trim();
                    oE_PuntoDeVenta.Segmento = readerSinc.GetValue(readerSinc.GetOrdinal("Segmento")).ToString().Trim();
                    oListE_PuntoDeVenta.Add(oE_PuntoDeVenta);
                }
                readerSinc.Close();
            }
            catch (Exception ex) {
                throw ex;
            }
            return oListE_PuntoDeVenta;
        }
        //Add Psa. Fecha:15/11/2012
        public List<E_PuntoDeVenta> Obtener_PDV_x_Cliente_Canal_PDV(string CodCliente, string CodCanal, string CodPtoVenta) {
            List<E_PuntoDeVenta> oListE_PuntoDeVenta = new List<E_PuntoDeVenta>();
            try {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtPdvDetByCliCanPdv", CodCliente, CodCanal, CodPtoVenta);
                while (readerSinc.Read())
                {
                    E_PuntoDeVenta oE_PuntoDeVenta = new E_PuntoDeVenta();
                    oE_PuntoDeVenta.ClientPDV_Code = readerSinc.GetValue(readerSinc.GetOrdinal("ClientPDV_Code")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Name = readerSinc.GetValue(readerSinc.GetOrdinal("Pdv_Name")).ToString().Trim();
                    oE_PuntoDeVenta.Pdv_Address = readerSinc.GetValue(readerSinc.GetOrdinal("Pdv_Address")).ToString().Trim();
                    oE_PuntoDeVenta.Distrito = readerSinc.GetValue(readerSinc.GetOrdinal("Distrito")).ToString().Trim();
                    oE_PuntoDeVenta.Zona = readerSinc.GetValue(readerSinc.GetOrdinal("Zona")).ToString().Trim();
                    oE_PuntoDeVenta.Segmento = readerSinc.GetValue(readerSinc.GetOrdinal("Segmento")).ToString().Trim();
                    oE_PuntoDeVenta.HorasAtencion = readerSinc.GetValue(readerSinc.GetOrdinal("HorasAtencion")).ToString().Trim();
                    oE_PuntoDeVenta.Administrador = readerSinc.GetValue(readerSinc.GetOrdinal("Administrador")).ToString().Trim();
                    oE_PuntoDeVenta.Cumpleanios = readerSinc.GetValue(readerSinc.GetOrdinal("Cumpleanios")).ToString().Trim();
                    oE_PuntoDeVenta.UltimaVisita = readerSinc.GetValue(readerSinc.GetOrdinal("UltimaVisita")).ToString().Trim();
                    oE_PuntoDeVenta.Email = readerSinc.GetValue(readerSinc.GetOrdinal("Email")).ToString().Trim();
                    oE_PuntoDeVenta.GIE = readerSinc.GetValue(readerSinc.GetOrdinal("GIE")).ToString().Trim();
                    oE_PuntoDeVenta.Vendedor = readerSinc.GetValue(readerSinc.GetOrdinal("Vendedor")).ToString().Trim();
                    oE_PuntoDeVenta.NroLocales = readerSinc.GetValue(readerSinc.GetOrdinal("NroLocales")).ToString().Trim();
                    oListE_PuntoDeVenta.Add(oE_PuntoDeVenta);
                }
                readerSinc.Close();
            }
            catch (Exception ex) {
                throw ex;
            }
            return oListE_PuntoDeVenta;
        }
        /************/
        //Ok - Revisado
        public E_DatosFiltros Obtener_DatosFiltro_x_Persona(string CodPersona) {
            E_DatosFiltros oE_DatosFiltros = new E_DatosFiltros();
            E_DatFil_DiasGiro oE_DatFil_DiasGiro = new E_DatFil_DiasGiro();
            E_DatFil_Precio oE_DatFil_Precio = new E_DatFil_Precio();
            E_DatFil_SOD oE_DatFil_SOD = new E_DatFil_SOD();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtDatFilByPer", CodPersona);
                while (readerSinc.Read())
                {
                    oE_DatosFiltros.Anio = readerSinc.GetValue(readerSinc.GetOrdinal("Anio")).ToString().Trim();
                    oE_DatosFiltros.CodCanal = readerSinc.GetValue(readerSinc.GetOrdinal("CodCanal")).ToString().Trim();
                    oE_DatosFiltros.Mes = readerSinc.GetValue(readerSinc.GetOrdinal("Mes")).ToString().Trim();
                    oE_DatosFiltros.Periodo = readerSinc.GetValue(readerSinc.GetOrdinal("Periodo")).ToString().Trim();
                }
                readerSinc.NextResult();
                while (readerSinc.Read())
                {
                    oE_DatFil_DiasGiro.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("CodCategoria")).ToString().Trim();
                }
                readerSinc.NextResult();
                while (readerSinc.Read()) {
                    oE_DatFil_Precio.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("CodCategoria")).ToString().Trim();
                    oE_DatFil_Precio.Sku = readerSinc.GetValue(readerSinc.GetOrdinal("Sku")).ToString().Trim();
                }
                readerSinc.NextResult();
                while (readerSinc.Read()) {
                    oE_DatFil_SOD.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("CodCategoria")).ToString().Trim();
                }
                readerSinc.Close();
                oE_DatosFiltros.E_DatFil_DiasGiro = oE_DatFil_DiasGiro;
                oE_DatosFiltros.E_DatFil_Precio = oE_DatFil_Precio;
                oE_DatosFiltros.E_DatFil_SOD = oE_DatFil_SOD;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oE_DatosFiltros;
        }
        //Ok --sql
        public List<E_Canal> Obtener_Canal_x_Cliente_Persona(string CodCliente,string CodPersona) {
            List<E_Canal> oListE_Canal = new List<E_Canal>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtCanByCliPer", CodCliente, CodPersona);
                while (readerSinc.Read())
                {
                    E_Canal oE_Canal = new E_Canal();
                    oE_Canal.Cod_Channel = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Channel")).ToString().Trim();
                    oE_Canal.Channel_Name = readerSinc.GetValue(readerSinc.GetOrdinal("Channel_Name")).ToString().Trim();
                    oListE_Canal.Add(oE_Canal);
                }
                readerSinc.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Canal;
        }
        //Ok --sql
        public List<E_Anio> Obtener_Anios_x_Cliente_Canal(string CodCliente, string CodCanal) {
            List<E_Anio> oListE_Anio = new List<E_Anio>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtAnioByCliCan", CodCliente, CodCanal);
                while (readerSinc.Read())
                {
                    E_Anio oE_Anio = new E_Anio();
                    oE_Anio.anio = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Anio")).ToString());
                    oListE_Anio.Add(oE_Anio);
                }
                readerSinc.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Anio;
        }
        //Ok --sql
        public List<E_Mes> Obtener_Mes_x_Cliente_Canal_Anio(string CodCliente, string CodCanal, string Anio) {
            List<E_Mes> oListE_Mes = new List<E_Mes>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtMesByCliCanAnio", CodCliente, CodCanal, Anio);
                while (readerSinc.Read())
                {
                    E_Mes oE_Mes = new E_Mes();
                    oE_Mes.numeroMes = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("numeroMes")).ToString());
                    oE_Mes.nombreMes = readerSinc.GetValue(readerSinc.GetOrdinal("nombreMes")).ToString().Trim();
                    oListE_Mes.Add(oE_Mes);
                }
                readerSinc.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Mes;
        }
        //Ok - Modificado
        public List<E_Periodo> Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Reporte(string CodCliente, string CodCanal, string Anio, string Mes, string Reporte) {
            List<E_Periodo> oListE_Periodo = new List<E_Periodo>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtPerByCliCanAnioMesRep", CodCliente, CodCanal, Anio, Mes, Reporte);
                while (readerSinc.Read())
                {
                    E_Periodo oE_Periodo = new E_Periodo();
                    oE_Periodo.Cod_Periodo = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Periodo")).ToString());
                    oE_Periodo.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                    oListE_Periodo.Add(oE_Periodo);
                }
                readerSinc.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Periodo;
        }
        //Ok - Modificado
        public List<E_Categoria> Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep(string CodCliente, string CodCanal, string Anio, string Mes, string Periodo, string Departamento, string CodReporte) {
            List<E_Categoria> oListE_Categoria = new List<E_Categoria>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtCatByCliCanAnioMesPerDptoRep", CodCliente, CodCanal, Anio, Mes, Periodo, Departamento, CodReporte);
                while (readerSinc.Read())
                {
                    E_Categoria oE_Categoria = new E_Categoria();
                    oE_Categoria.Id_ProductCategory = readerSinc.GetValue(readerSinc.GetOrdinal("Id_ProductCategory")).ToString().Trim();
                    oE_Categoria.Product_Category = readerSinc.GetValue(readerSinc.GetOrdinal("Product_Category")).ToString().Trim();
                    oListE_Categoria.Add(oE_Categoria);
                }
                readerSinc.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Categoria;
        }
        //Ok - Modificado
        public List<E_Producto> Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep(string CodCliente, string CodCanal, string Anio, string Mes, string Periodo, string CodCategoria, string CodDepartamento, string CodReporte) {
            List<E_Producto> oListE_Producto = new List<E_Producto>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtSKUByCliCanAnioMesPerCatDptoRep", CodCliente, CodCanal, Anio, Mes, Periodo, CodCategoria, CodDepartamento, CodReporte);
                while (readerSinc.Read())
                {
                    E_Producto oE_Producto = new E_Producto();
                    oE_Producto.Cod_Producto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                    oE_Producto.Nombre_Producto = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre_Producto")).ToString().Trim();
                    oListE_Producto.Add(oE_Producto);
                }
                readerSinc.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Producto;
        }
        //Ok
        public List<E_Resumen> Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto(string CodCliente, string CodCanal, string Anio, string Mes, string Periodo, string CodDepartamento) {
            List<E_Resumen> oListE_Resumen = new List<E_Resumen>();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtResByCliCanAnioMesPerDpto", CodCliente, CodCanal, Anio, Mes, Periodo, CodDepartamento);
                while (readerSinc.Read())
                {
                    E_Resumen oE_Resumen = new E_Resumen();
                    oE_Resumen.NombreResumen = readerSinc.GetValue(readerSinc.GetOrdinal("NombreResumen")).ToString().Trim();
                    oE_Resumen.Cantidad = readerSinc.GetValue(readerSinc.GetOrdinal("Cantidad")).ToString().Trim();
                    oListE_Resumen.Add(oE_Resumen);
                }
                readerSinc.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListE_Resumen;
        }
        /*********************/
        
        /*************/
        //Grafico Dinámico XploraMaps 
        //16-04-2016 Off
        /*public E_GraXplNew Obtener_GrafBar() {
            //E_GraXplNew oE_GraXplNew = new E_GraXplNew();
            E_GrafBar oE_GrafBar = new E_GrafBar();
            E_GrafBar_Det oE_GrafBar_Det = new E_GrafBar_Det();

            SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtGrafBar");
            while (readerSinc.Read()) { 
            
            }

            E_DatosFiltros oE_DatosFiltros = new E_DatosFiltros();
            E_DatFil_DiasGiro oE_DatFil_DiasGiro = new E_DatFil_DiasGiro();
            E_DatFil_Precio oE_DatFil_Precio = new E_DatFil_Precio();
            E_DatFil_SOD oE_DatFil_SOD = new E_DatFil_SOD();
            try
            {
                SqlDataReader readerSinc = oConexion.ejecutarDataReader("SP_GES_MAPS_ObtDatFilByPer", CodPersona);
                while (readerSinc.Read())
                {
                    oE_DatosFiltros.Anio = readerSinc.GetValue(readerSinc.GetOrdinal("Anio")).ToString().Trim();
                    oE_DatosFiltros.CodCanal = readerSinc.GetValue(readerSinc.GetOrdinal("CodCanal")).ToString().Trim();
                    oE_DatosFiltros.Mes = readerSinc.GetValue(readerSinc.GetOrdinal("Mes")).ToString().Trim();
                    oE_DatosFiltros.Periodo = readerSinc.GetValue(readerSinc.GetOrdinal("Periodo")).ToString().Trim();
                }
                readerSinc.NextResult();
                while (readerSinc.Read())
                {
                    oE_DatFil_DiasGiro.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("CodCategoria")).ToString().Trim();
                }
                readerSinc.NextResult();
                while (readerSinc.Read())
                {
                    oE_DatFil_Precio.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("CodCategoria")).ToString().Trim();
                    oE_DatFil_Precio.Sku = readerSinc.GetValue(readerSinc.GetOrdinal("Sku")).ToString().Trim();
                }
                readerSinc.NextResult();
                while (readerSinc.Read())
                {
                    oE_DatFil_SOD.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("CodCategoria")).ToString().Trim();
                }
                readerSinc.Close();
                oE_DatosFiltros.E_DatFil_DiasGiro = oE_DatFil_DiasGiro;
                oE_DatosFiltros.E_DatFil_Precio = oE_DatFil_Precio;
                oE_DatosFiltros.E_DatFil_SOD = oE_DatFil_SOD;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oE_DatosFiltros;
            
        }*/
        
        /************/

        #endregion
    }
}