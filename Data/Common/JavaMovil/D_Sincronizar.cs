using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    /// <summary>
    /// Class: D_Sincronizar.cs
    /// Developed by: 
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-11 (PSA) Add comments.
    /// </summary>
    public class D_Sincronizar
    {
        // Declara Clase Conexión
        private Conexion oConn;

        // Constructor
        public D_Sincronizar()
        {
            oConn = new Conexion(3);
        }

        /// <summary>
        /// Retorna la información que se utilizará como Base de Datos para el App Mobile.
        /// </summary>
        /// <param name="person_id"> Identificador de Persona </param>
        /// <param name="cliente_id"> Identificador de Cliente </param>
        /// <param name="equipo_id"> Identificador de Equipo(Planning) </param>
        /// <returns>E_Sincronizar</returns>  Un Objecto E_Sincronizar que contiene toda la información q
        /// que necesita el App Mobile para funcionar.
        public E_Sincronizar Sincronizar_Mov(string person_id, int cliente, string equipo)
        {
            SqlDataReader readerSinc = oConn.ejecutarDataReader("SP_GES_CAM_SINCRONIZAR", equipo, cliente, person_id);

            //Listas Generales para todas las cuentas
            List<E_Estado> listaEstado = new List<E_Estado>();
            List<E_Motivo> listaMotivo = new List<E_Motivo>();
            List<E_NoVisita> listaNoVisita = new List<E_NoVisita>();
            List<E_Reporte> listaReporte = new List<E_Reporte>();
            List<E_Opc_Reporte> listaOpcReporte = new List<E_Opc_Reporte>();
            List<E_PuntoVenta> listaPuntoVenta = new List<E_PuntoVenta>();
            //Listas Agregadas
            List<E_Perfil> listaPerfil = new List<E_Perfil>();          //Add 04/09/2012 PSalas
            List<E_TPerfil> listaTipoPerfil = new List<E_TPerfil>();    //Add 04/09/2012 PSalas

            ///Otros
            List<E_Categoria> listaCategoria = new List<E_Categoria>();
            List<E_Producto> listaProducto = new List<E_Producto>();
            List<E_Material_Apoyo> listaTipoMaterialApoyo = new List<E_Material_Apoyo>();
            List<E_Observacion> listaObservacion = new List<E_Observacion>();
            List<E_Marca> listaMarca = new List<E_Marca>();
            List<E_Promocion_Mov> listaPromocion = new List<E_Promocion_Mov>();
            List<E_Cluster> listaCluster = new List<E_Cluster>();
            List<E_Familia> listaFamilia = new List<E_Familia>();
            List<E_SubFamilia> listaSubFamilia = new List<E_SubFamilia>();
            List<E_Actividad> listaActividad = new List<E_Actividad>();
            List<E_Grupo_Objetivo> listaGrupoObjetivo = new List<E_Grupo_Objetivo>();
            List<E_Cond_Exhib> listaCondExhib = new List<E_Cond_Exhib>();
            List<E_Obj_Marca> listaObjxMarca = new List<E_Obj_Marca>();
            List<E_Servicio> listaServicio = new List<E_Servicio>();
            List<E_Competidora> listaCompetidora = new List<E_Competidora>();
            List<E_Opc_Pedido> listaOpcionPedido = new List<E_Opc_Pedido>();
            List<E_Motivo_Reporte> listaMotivoReporte = new List<E_Motivo_Reporte>();
            List<E_Distribuidora> listaDistribuidora = new List<E_Distribuidora>();
            List<E_Distribuidora_PtoVenta> listaDistribuidoraPtoVenta = new List<E_Distribuidora_PtoVenta>();
            List<E_Ubicacion> listaUbicacion = new List<E_Ubicacion>(); //Add 05/06/2012 PSA
            List<E_Posicion> listaPosicion = new List<E_Posicion>();    //Add 05/06/2012 PSA
            List<E_SubCategoria> listaSubCategoria = new List<E_SubCategoria>();    //Add 06/06/2012 JGonzales
            List<E_SubMarca> listaSubMarca = new List<E_SubMarca>();    //Add 06/06/2012 JGonzales
            List<E_Presentacion> listaPresentacion = new List<E_Presentacion>();    //Add 06/06/2012 JGonzales
            List<E_Fase> listaFase = new List<E_Fase>();    //Add 06/06/2012 JGonzales
            List<E_Segmento> listaSegmento = new List<E_Segmento>();    //Add 06/06/2012 JGonzales
            List<E_Exhibicion> listaExhibicion = new List<E_Exhibicion>();  //Add 20/06/2012 PSalas
            List<E_Motivo_Observacion> listaMotivo_Observacion = new List<E_Motivo_Observacion>();//Add 05/07/2012 PSalas

            //Datos Semana Anterior
            List<E_Datos_Presencia> listaDatosPresencia = new List<E_Datos_Presencia>();

            List<E_Marcaje_Precio> listaMarcajePrecio = new List<E_Marcaje_Precio>();
            List<E_Capacitacion> listaCapacitacion = new List<E_Capacitacion>();
            List<E_Status> listaStatus = new List<E_Status>();
            List<E_Incidencia> listaIncidencias = new List<E_Incidencia>();
            List<E_Credito> listaCredito = new List<E_Credito>();

            //Datos Analista
            List<E_Canal_x_Cliente> listaCanal = new List<E_Canal_x_Cliente>();
            List<E_Departamento_x_Canal> listaDepartamento = new List<E_Departamento_x_Canal>();
            List<E_Provincia_x_Canal> listaProvincia = new List<E_Provincia_x_Canal>();

            while (readerSinc.Read())
            {
                E_Estado eEstado = new E_Estado();
                eEstado.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Estado")).ToString().Trim();
                eEstado.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                listaEstado.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Motivo eMotivo = new E_Motivo();
                eMotivo.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Motivo")).ToString().Trim();
                eMotivo.CodigoEstado = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Estado")).ToString().Trim();
                eMotivo.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                listaMotivo.Add(eMotivo);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_NoVisita eNoVisita = new E_NoVisita();
                eNoVisita.Id_noVisita = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_NoVisita")).ToString().Trim();
                eNoVisita.tipo = readerSinc.GetValue(readerSinc.GetOrdinal("Tipo")).ToString().Trim();
                eNoVisita.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();                
                eNoVisita.grupo = readerSinc.GetValue(readerSinc.GetOrdinal("Grupo")).ToString().Trim();
                listaNoVisita.Add(eNoVisita);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Reporte eE_Reporte = new E_Reporte();
                eE_Reporte.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                eE_Reporte.Reporte_Alias = readerSinc.GetValue(readerSinc.GetOrdinal("Rep_Alias")).ToString().Trim();
                eE_Reporte.CodSubReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubReporte")).ToString().Trim();
                eE_Reporte.SubReporteAlias = readerSinc.GetValue(readerSinc.GetOrdinal("SRep_Alias")).ToString().Trim();
                eE_Reporte.Orden = readerSinc.GetValue(readerSinc.GetOrdinal("Orden")).ToString().Trim();//Add 04/09/2012
                listaReporte.Add(eE_Reporte);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Opc_Reporte eE_Opc_Reporte = new E_Opc_Reporte();
                eE_Opc_Reporte.CodReporte = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim());
                eE_Opc_Reporte.CodSubReporte = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Sub_Reporte")).ToString().Trim());
                eE_Opc_Reporte.VistaCategoria = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_Categoria")) ? 1 : 0;
                eE_Opc_Reporte.VistaSubCategoria = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_SubCategoria")) ? 1 : 0;
                eE_Opc_Reporte.VistaMarca = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_Marca")) ? 1 : 0;
                eE_Opc_Reporte.VistaSubMarca = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_SubMarca")) ? 1 : 0;
                eE_Opc_Reporte.VistaPresentacion = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_Presentacion")) ? 1 : 0;
                eE_Opc_Reporte.VistaFamilia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_Familia")) ? 1 : 0;
                eE_Opc_Reporte.VistaSubFamilia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_SubFamilia")) ? 1 : 0;
                eE_Opc_Reporte.VistaProducto = readerSinc.GetBoolean(readerSinc.GetOrdinal("Vista_Producto")) ? 1 : 0;
                listaOpcReporte.Add(eE_Opc_Reporte);
            }
            
            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_PuntoVenta ePuntoVenta = new E_PuntoVenta();
                ePuntoVenta.CodigoPDV = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Pdv")).ToString().Trim();
                ePuntoVenta.RazonSocial = readerSinc.GetValue(readerSinc.GetOrdinal("Pdv_Nombre")).ToString().Trim();
                ePuntoVenta.Direccion = readerSinc.GetValue(readerSinc.GetOrdinal("Pdv_Direccion")).ToString().Trim();
                ePuntoVenta.CodigoCadena = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Cadena")).ToString().Trim();
                ePuntoVenta.NombreCadena = readerSinc.GetValue(readerSinc.GetOrdinal("Cad_Nombre")).ToString().Trim();
                ePuntoVenta.CodigoCanal = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Canal")).ToString().Trim();
                ePuntoVenta.NombreCanal = readerSinc.GetValue(readerSinc.GetOrdinal("Can_Nombre")).ToString().Trim();
                ePuntoVenta.TipoMercado = readerSinc.GetValue(readerSinc.GetOrdinal("Can_Tipo")).ToString().Trim();
                ePuntoVenta.latitud = (readerSinc.GetValue(readerSinc.GetOrdinal("Latitud")).ToString().Trim());
                ePuntoVenta.longitud = (readerSinc.GetValue(readerSinc.GetOrdinal("Longitud")).ToString().Trim());
                //ePuntoVenta.latitud = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Latitud")).ToString().Trim());
                //ePuntoVenta.longitud = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Longitud")).ToString().Trim());
                //ePuntoVenta.latitud = double.Parse(readerSinc.GetDouble(readerSinc.GetOrdinal("Latitud")).ToString());
                //ePuntoVenta.longitud = double.Parse(readerSinc.GetDouble(readerSinc.GetOrdinal("Longitud")).ToString());
                ePuntoVenta.Fase = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Fase")).ToString().Trim();
                listaPuntoVenta.Add(ePuntoVenta);
            }
            readerSinc.NextResult();    //Add 04/09/2012 PSalas
            while (readerSinc.Read())
            {
                E_Perfil oE_Perfil = new E_Perfil();
                oE_Perfil.Cod_TPerfil = readerSinc.GetValue(readerSinc.GetOrdinal("COD_TPERFIL")).ToString().Trim();
                oE_Perfil.Cod_Perfil = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PERFIL")).ToString().Trim();
                oE_Perfil.Cod_Equipo = readerSinc.GetValue(readerSinc.GetOrdinal("COD_EQUIPO")).ToString().Trim();
                oE_Perfil.Per_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("PER_DESCRIPCION")).ToString().Trim();
                listaPerfil.Add(oE_Perfil);
            }
            readerSinc.NextResult();    //Add 04/09/2012 PSalas
            while (readerSinc.Read())
            {
                E_TPerfil oE_TPerfil = new E_TPerfil();
                oE_TPerfil.Cod_TPerfil = readerSinc.GetValue(readerSinc.GetOrdinal("COD_TPERFIL")).ToString().Trim();
                oE_TPerfil.TPerfil_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("TPERFIL_DESCRIPCION")).ToString().Trim();
                listaTipoPerfil.Add(oE_TPerfil);
            }

            #region Cliente Colgate
            if (cliente == 1561)
            {
                if (equipo.Equals("0")) //Mayorista
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Canal_x_Cliente eCanal = new E_Canal_x_Cliente();
                        eCanal.codCanal = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CANAL")).ToString().Trim();
                        eCanal.descCanal = readerSinc.GetValue(readerSinc.GetOrdinal("CAN_NOMBRE")).ToString().Trim();
                        eCanal.codCliente = readerSinc.GetValue(readerSinc.GetOrdinal("COD_COMPANIA")).ToString().Trim();
                        listaCanal.Add(eCanal);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Departamento_x_Canal eDepartamento = new E_Departamento_x_Canal();
                        eDepartamento.codDepartamento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DEPARTAMENTO")).ToString().Trim();
                        eDepartamento.codCanal = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CANAL")).ToString().Trim();
                        listaDepartamento.Add(eDepartamento);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Provincia_x_Canal eProvincia = new E_Provincia_x_Canal();
                        eProvincia.codDepartamento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DEPARTAMENTO")).ToString().Trim();
                        eProvincia.codProvincia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PROVINCIA")).ToString().Trim();
                        eProvincia.codCanal = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CANAL")).ToString().Trim();
                        listaProvincia.Add(eProvincia);
                    }
                }

                else if (equipo.Equals("813622482010")) //Mayorista
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1: 0;                        
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Observacion eE_Observacion = new E_Observacion();
                        eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                        eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaObservacion.Add(eE_Observacion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Datos_Presencia eDatosPresencia = new E_Datos_Presencia();
                        eDatosPresencia.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTO_VENTA")).ToString().Trim();
                        eDatosPresencia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eDatosPresencia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eDatosPresencia.CodOpcion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_OPCIONPRESENCIA")).ToString().Trim();
                        eDatosPresencia.CodElemento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ELEMENTO")).ToString().Trim();
                        eDatosPresencia.CodValor = readerSinc.GetValue(readerSinc.GetOrdinal("VALOR_ELEMENTO")).ToString().Trim().Replace(',', '.');
                        listaDatosPresencia.Add(eDatosPresencia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora eDistribuidora = new E_Distribuidora();
                        eDistribuidora.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eDistribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
                        listaDistribuidora.Add(eDistribuidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora_PtoVenta eDistribuidoraPtoVenta = new E_Distribuidora_PtoVenta();
                        eDistribuidoraPtoVenta.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidoraPtoVenta.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();
                        listaDistribuidoraPtoVenta.Add(eDistribuidoraPtoVenta);
                    }

                    readerSinc.Close();
                }

                else if (equipo.Equals("0133725102010")) //Minorista
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");                        
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Observacion eE_Observacion = new E_Observacion();
                        eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                        eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaObservacion.Add(eE_Observacion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Datos_Presencia eDatosPresencia = new E_Datos_Presencia();
                        eDatosPresencia.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTO_VENTA")).ToString().Trim();
                        eDatosPresencia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eDatosPresencia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eDatosPresencia.CodOpcion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_OPCIONPRESENCIA")).ToString().Trim();
                        eDatosPresencia.CodElemento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ELEMENTO")).ToString().Trim();
                        eDatosPresencia.CodValor = readerSinc.GetValue(readerSinc.GetOrdinal("VALOR_ELEMENTO")).ToString().Trim().Replace(',', '.');
                        listaDatosPresencia.Add(eDatosPresencia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora eDistribuidora = new E_Distribuidora();
                        eDistribuidora.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eDistribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
                        listaDistribuidora.Add(eDistribuidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora_PtoVenta eDistribuidoraPtoVenta = new E_Distribuidora_PtoVenta();
                        eDistribuidoraPtoVenta.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidoraPtoVenta.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();
                        listaDistribuidoraPtoVenta.Add(eDistribuidoraPtoVenta);
                    }

                    readerSinc.Close();
                }

                else if (equipo.Equals("0134126102010")) //Farmacia DT
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0 ;
                        eE_Marca.CodSubCategoria = "0";                        
                        listaMarca.Add(eE_Marca);
                    }
                    
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");                        
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        eProducto.CodCompania = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Compania")).ToString().Trim(); //Add PSA 05/07/2012 - Se Agrega El Parametro CodCompania

                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Observacion eE_Observacion = new E_Observacion();
                        eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                        eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaObservacion.Add(eE_Observacion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Promocion_Mov eE_Promocion_Mov = new E_Promocion_Mov();
                        eE_Promocion_Mov.CodPromocion = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Promocion")).ToString().Trim();
                        eE_Promocion_Mov.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString().Trim();
                        eE_Promocion_Mov.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Promocion_Mov.CodCompania = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Compania")).ToString().Trim();
                        listaPromocion.Add(eE_Promocion_Mov);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Competidora eCompetidora = new E_Competidora();
                        eCompetidora.CodCompetidora = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Competidora")).ToString().Trim();
                        eCompetidora.NombreCompetidora = readerSinc.GetValue(readerSinc.GetOrdinal("Com_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCompetidora.Add(eCompetidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Datos_Presencia eDatosPresencia = new E_Datos_Presencia();
                        eDatosPresencia.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTO_VENTA")).ToString().Trim();
                        eDatosPresencia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eDatosPresencia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eDatosPresencia.CodOpcion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_OPCIONPRESENCIA")).ToString().Trim();
                        eDatosPresencia.CodElemento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ELEMENTO")).ToString().Trim();
                        eDatosPresencia.CodValor = readerSinc.GetValue(readerSinc.GetOrdinal("VALOR_ELEMENTO")).ToString().Trim().Replace(',', '.');
                        listaDatosPresencia.Add(eDatosPresencia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora eDistribuidora = new E_Distribuidora();
                        eDistribuidora.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eDistribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
                        listaDistribuidora.Add(eDistribuidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora_PtoVenta eDistribuidoraPtoVenta = new E_Distribuidora_PtoVenta();
                        eDistribuidoraPtoVenta.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidoraPtoVenta.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();
                        listaDistribuidoraPtoVenta.Add(eDistribuidoraPtoVenta);
                    }

                    readerSinc.Close();
                }

                else if (equipo.Equals("0134226102010")) //Farmacia IT
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    //Add 01/08/2012
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");                        
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Observacion eE_Observacion = new E_Observacion();
                        eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                        eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaObservacion.Add(eE_Observacion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Datos_Presencia eDatosPresencia = new E_Datos_Presencia();
                        eDatosPresencia.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTO_VENTA")).ToString().Trim();
                        eDatosPresencia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eDatosPresencia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eDatosPresencia.CodOpcion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_OPCIONPRESENCIA")).ToString().Trim();
                        eDatosPresencia.CodElemento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ELEMENTO")).ToString().Trim();
                        eDatosPresencia.CodValor = readerSinc.GetValue(readerSinc.GetOrdinal("VALOR_ELEMENTO")).ToString().Trim().Replace(',', '.');
                        listaDatosPresencia.Add(eDatosPresencia);
                    }

                    //Sincronizar Ubicacion 
                    //05/06/2012 PSA
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Ubicacion eUbicacion = new E_Ubicacion();
                        eUbicacion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eUbicacion.Cod_SubReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBREPORTE")).ToString().Trim();
                        eUbicacion.Cod_Ubicacion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_UBICACION")).ToString().Trim();
                        eUbicacion.Ubi_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("UBI_DESCRIPCION")).ToString().Trim();
                        listaUbicacion.Add(eUbicacion);
                    }

                    //Sincronizar Posicion 
                    //05/06/2012 PSA
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Posicion ePosicion = new E_Posicion();
                        ePosicion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        ePosicion.Cod_SubReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBREPORTE")).ToString().Trim();
                        ePosicion.Cod_Posicion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_POSICION")).ToString().Trim();
                        ePosicion.Ubi_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("POS_DESCRIPCION")).ToString().Trim();
                        listaPosicion.Add(ePosicion);
                    }
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora eDistribuidora = new E_Distribuidora();
                        eDistribuidora.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eDistribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
                        listaDistribuidora.Add(eDistribuidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora_PtoVenta eDistribuidoraPtoVenta = new E_Distribuidora_PtoVenta();
                        eDistribuidoraPtoVenta.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();                        
                        eDistribuidoraPtoVenta.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();                        
                        listaDistribuidoraPtoVenta.Add(eDistribuidoraPtoVenta);
                    }   
                    
                    readerSinc.Close();
                }

                else if (equipo.Equals("012011092692011")) //Bodega
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    //Add 01/08/2012
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");                        
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Cluster eE_Cluster = new E_Cluster();
                        eE_Cluster.Cod_cluster = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Cluster")).ToString().Trim();
                        eE_Cluster.Pregunta = readerSinc.GetValue(readerSinc.GetOrdinal("Pregunta")).ToString().Trim();
                        eE_Cluster.Req_Cantidad = readerSinc.GetBoolean(readerSinc.GetOrdinal("Req_Cantidad")) ? 1 : 0;
                        listaCluster.Add(eE_Cluster);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Datos_Presencia eDatosPresencia = new E_Datos_Presencia();
                        eDatosPresencia.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTO_VENTA")).ToString().Trim();
                        eDatosPresencia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eDatosPresencia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eDatosPresencia.CodOpcion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_OPCIONPRESENCIA")).ToString().Trim();
                        eDatosPresencia.CodElemento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ELEMENTO")).ToString().Trim();
                        eDatosPresencia.CodValor = readerSinc.GetValue(readerSinc.GetOrdinal("VALOR_ELEMENTO")).ToString().Trim().Replace(',','.');
                        listaDatosPresencia.Add(eDatosPresencia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora eDistribuidora = new E_Distribuidora();
                        eDistribuidora.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eDistribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
                        listaDistribuidora.Add(eDistribuidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora_PtoVenta eDistribuidoraPtoVenta = new E_Distribuidora_PtoVenta();
                        eDistribuidoraPtoVenta.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();                        
                        eDistribuidoraPtoVenta.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();                        
                        listaDistribuidoraPtoVenta.Add(eDistribuidoraPtoVenta);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Fase eFase = new E_Fase();
                        eFase.CodFase = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FASE")).ToString().Trim();
                        eFase.NombreFase = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_FASE")).ToString().Trim();
                        eFase.Orden = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("ORDEN")).ToString().Trim());
                        listaFase.Add(eFase);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Segmento eSegmento = new E_Segmento();
                        eSegmento.CodSegmento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SEGMENTO")).ToString().Trim();
                        eSegmento.NombreSegmento = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_SEGMENTO")).ToString().Trim();
                        listaSegmento.Add(eSegmento);
                    }
                    //Add 16/10/2012 psa. solicitud de Joseph G. para el Canal Bodegas
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Observacion eE_Observacion = new E_Observacion();
                        eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                        eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaObservacion.Add(eE_Observacion);
                    }
                    readerSinc.Close();
                }
            }
            #endregion

            #region Cliente Alicorp
            else if (cliente == 1562) //ALICORP
            {
                #region Autoservicios
                if (equipo.Equals("000361782010")) //AASS
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();                        
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";    
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Familia eE_Familia = new E_Familia();
                        eE_Familia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Familia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                        eE_Familia.FamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("FAM_NOMBRE")).ToString().Trim();
                        eE_Familia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_Familia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_Familia.CodSubCategoria = "0";
                        eE_Familia.CodSubMarca = "0";
                        eE_Familia.CodPresentacion = "0";
                        listaFamilia.Add(eE_Familia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    { 
                        E_SubFamilia eE_SubFamilia = new E_SubFamilia();
                        eE_SubFamilia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_SubFamilia.CodSubFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBFAMILIA")).ToString().Trim();
                        eE_SubFamilia.SubFamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("SUBFAM_NOMBRE")).ToString().Trim();
                        eE_SubFamilia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_SubFamilia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_SubFamilia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                        eE_SubFamilia.CodSubCategoria = "0";
                        eE_SubFamilia.CodSubMarca = "0";
                        eE_SubFamilia.CodPresentacion = "0";
                        listaSubFamilia.Add(eE_SubFamilia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");                        
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Promocion_Mov eE_Promocion_Mov = new E_Promocion_Mov();
                        eE_Promocion_Mov.CodPromocion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PROMOCION")).ToString().Trim();
                        eE_Promocion_Mov.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE")).ToString().Trim();
                        eE_Promocion_Mov.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        listaPromocion.Add(eE_Promocion_Mov);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Actividad eE_Actividad = new E_Actividad();
                        eE_Actividad.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Actividad.CodActividad = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ACTIVIDAD")).ToString().Trim();
                        eE_Actividad.NombreActividad = readerSinc.GetValue(readerSinc.GetOrdinal("ACT_DESCRIPCION")).ToString().Trim();
                        listaActividad.Add(eE_Actividad);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Grupo_Objetivo eE_Grupo_Objetivo = new E_Grupo_Objetivo();
                        eE_Grupo_Objetivo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Grupo_Objetivo.CodGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("COD_GRUPOOBJ")).ToString().Trim();
                        eE_Grupo_Objetivo.NombreGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("GRUPOOBJ_DESC")).ToString().Trim();
                        listaGrupoObjetivo.Add(eE_Grupo_Objetivo);
                    }

                    //Add 20/06/2012 Psa
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Cond_Exhib eE_Cond_Exhib = new E_Cond_Exhib();
                        eE_Cond_Exhib.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Cond_Exhib.CodCondExhib = readerSinc.GetValue(readerSinc.GetOrdinal("COD_COND_EXH")).ToString().Trim();
                        eE_Cond_Exhib.NombreCondExhib = readerSinc.GetValue(readerSinc.GetOrdinal("DESCRIPCION")).ToString().Trim();
                        listaCondExhib.Add(eE_Cond_Exhib);
                    }
                    //Add 20/06/2012 PSA
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Exhibicion eE_Exhibicion = new E_Exhibicion();
                        eE_Exhibicion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Exhibicion.Cod_Exhibicion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_EXHIBICION")).ToString().Trim();
                        eE_Exhibicion.Exh_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("EXH_DESCRIPCION")).ToString().Trim();
                        listaExhibicion.Add(eE_Exhibicion);
                    }


                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Obj_Marca eE_Obj_Marca = new E_Obj_Marca();
                        eE_Obj_Marca.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();
                        eE_Obj_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_Obj_Marca.NombreMarca = readerSinc.GetValue(readerSinc.GetOrdinal("MAR_NOMBRE")).ToString().Trim();
                        eE_Obj_Marca.Objetivo = readerSinc.GetValue(readerSinc.GetOrdinal("OBJETIVO")).ToString().Trim();
                        eE_Obj_Marca.Cantidad = readerSinc.GetValue(readerSinc.GetOrdinal("CANTIDAD")).ToString().Trim();
                        eE_Obj_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        listaObjxMarca.Add(eE_Obj_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Motivo_Observacion eE_Motivo_Observacion = new E_Motivo_Observacion();
                        eE_Motivo_Observacion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Motivo_Observacion.Cod_MObs = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_MObs")).ToString().Trim();
                        eE_Motivo_Observacion.MObs_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaMotivo_Observacion.Add(eE_Motivo_Observacion);

                    }

                    readerSinc.Close();

                }
                #endregion
                #region Mayorista
                else if (equipo.Equals("813711382010")) //MAYORISTA
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();                        
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";    
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Familia eE_Familia = new E_Familia();
                        eE_Familia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Familia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                        eE_Familia.FamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("FAM_NOMBRE")).ToString().Trim();
                        eE_Familia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_Familia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_Familia.CodSubCategoria = "0";
                        eE_Familia.CodSubMarca = "0";
                        eE_Familia.CodPresentacion = "0";
                        listaFamilia.Add(eE_Familia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");                        
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Promocion_Mov eE_Promocion_Mov = new E_Promocion_Mov();
                        eE_Promocion_Mov.CodPromocion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PROMOCION")).ToString().Trim();
                        eE_Promocion_Mov.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE")).ToString().Trim();
                        eE_Promocion_Mov.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        listaPromocion.Add(eE_Promocion_Mov);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Actividad eE_Actividad = new E_Actividad();
                        eE_Actividad.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Actividad.CodActividad = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ACTIVIDAD")).ToString().Trim();
                        eE_Actividad.NombreActividad = readerSinc.GetValue(readerSinc.GetOrdinal("ACT_DESCRIPCION")).ToString().Trim();
                        listaActividad.Add(eE_Actividad);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Grupo_Objetivo eE_Grupo_Objetivo = new E_Grupo_Objetivo();
                        eE_Grupo_Objetivo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Grupo_Objetivo.CodGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("COD_GRUPOOBJ")).ToString().Trim();
                        eE_Grupo_Objetivo.NombreGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("GRUPOOBJ_DESC")).ToString().Trim();
                        listaGrupoObjetivo.Add(eE_Grupo_Objetivo);
                    }
                    
                    //Add 20/06/2012 Psa
                    readerSinc.NextResult();
                    while (readerSinc.Read()) 
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    //Add 05/07/2012 Psa
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Motivo_Observacion eE_Motivo_Observacion = new E_Motivo_Observacion();
                        eE_Motivo_Observacion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Motivo_Observacion.Cod_MObs = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_MObs")).ToString().Trim();
                        eE_Motivo_Observacion.MObs_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaMotivo_Observacion.Add(eE_Motivo_Observacion);
                                                
                    }

                    readerSinc.Close();
                }
                #endregion
            }
            #endregion

            #region Cliente San Fernando
            else if (cliente == 1572) // SAN FERNANDO
            {
                #region AAVV
                if (equipo.Equals("101131122011")) // AA VV
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";    
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Servicio eE_Servicio = new E_Servicio();
                        eE_Servicio.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Servicio.CodServicio = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SERVICIO")).ToString().Trim();
                        eE_Servicio.ServicioNombre = readerSinc.GetValue(readerSinc.GetOrdinal("SER_NOMBRE")).ToString().Trim();
                        eE_Servicio.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_Servicio.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        listaServicio.Add(eE_Servicio);
                    }

                    readerSinc.Close();
                }
                #endregion
                #region Moderno
                else if (equipo.Equals("004552352011")) // MODERNO
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Familia eE_Familia = new E_Familia();
                        eE_Familia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Familia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                        eE_Familia.FamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("FAM_NOMBRE")).ToString().Trim();
                        eE_Familia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_Familia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_Familia.CodSubCategoria = "0";
                        eE_Familia.CodSubMarca = "0";
                        eE_Familia.CodPresentacion = "0";
                        listaFamilia.Add(eE_Familia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_SubFamilia eE_SubFamilia = new E_SubFamilia();
                        eE_SubFamilia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_SubFamilia.CodSubFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBFAMILIA")).ToString().Trim();
                        eE_SubFamilia.SubFamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("SUBFAM_NOMBRE")).ToString().Trim();
                        eE_SubFamilia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_SubFamilia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_SubFamilia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                        eE_SubFamilia.CodSubCategoria = "0";
                        eE_SubFamilia.CodSubMarca = "0";
                        eE_SubFamilia.CodPresentacion = "0";
                        listaSubFamilia.Add(eE_SubFamilia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Competidora eCompetidora = new E_Competidora();
                        eCompetidora.CodCompetidora = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Competidora")).ToString().Trim();
                        eCompetidora.NombreCompetidora = readerSinc.GetValue(readerSinc.GetOrdinal("Com_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCompetidora.Add(eCompetidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Actividad eE_Actividad = new E_Actividad();
                        eE_Actividad.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Actividad.CodActividad = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ACTIVIDAD")).ToString().Trim();
                        eE_Actividad.NombreActividad = readerSinc.GetValue(readerSinc.GetOrdinal("ACT_DESCRIPCION")).ToString().Trim();
                        listaActividad.Add(eE_Actividad);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Grupo_Objetivo eE_Grupo_Objetivo = new E_Grupo_Objetivo();
                        eE_Grupo_Objetivo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Grupo_Objetivo.CodGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("COD_GRUPOOBJ")).ToString().Trim();
                        eE_Grupo_Objetivo.NombreGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("GRUPOOBJ_DESC")).ToString().Trim();
                        listaGrupoObjetivo.Add(eE_Grupo_Objetivo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Motivo_Observacion eE_Motivo_Observacion = new E_Motivo_Observacion();
                        eE_Motivo_Observacion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Motivo_Observacion.Cod_MObs = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_MObs")).ToString().Trim();
                        eE_Motivo_Observacion.MObs_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaMotivo_Observacion.Add(eE_Motivo_Observacion);

                    }

                    readerSinc.Close();
                }
                #endregion
                #region Tradicional
                else if (equipo.Equals("102141122011")) // TRADICIONAL
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    //readerSinc.NextResult();
                    //while (readerSinc.Read())
                    //{
                    //    E_Familia eE_Familia = new E_Familia();
                    //    eE_Familia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                    //    eE_Familia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                    //    eE_Familia.FamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("FAM_NOMBRE")).ToString().Trim();
                    //    eE_Familia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                    //    eE_Familia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                    //    eE_Familia.CodSubCategoria = "0";
                    //    eE_Familia.CodSubMarca = "0";
                    //    eE_Familia.CodPresentacion = "0";
                    //    listaFamilia.Add(eE_Familia);
                    //}

                    //readerSinc.NextResult();
                    //while (readerSinc.Read())
                    //{
                    //    E_SubFamilia eE_SubFamilia = new E_SubFamilia();
                    //    eE_SubFamilia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                    //    eE_SubFamilia.CodSubFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBFAMILIA")).ToString().Trim();
                    //    eE_SubFamilia.SubFamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("SUBFAM_NOMBRE")).ToString().Trim();
                    //    eE_SubFamilia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                    //    eE_SubFamilia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                    //    eE_SubFamilia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                    //    eE_SubFamilia.CodSubCategoria = "0";
                    //    eE_SubFamilia.CodSubMarca = "0";
                    //    eE_SubFamilia.CodPresentacion = "0";
                    //    listaSubFamilia.Add(eE_SubFamilia);
                    //}


                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    //Add Pablo Salas A. 25/07/2012 
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Exhibicion eE_Exhibicion = new E_Exhibicion();
                        eE_Exhibicion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Exhibicion.Cod_Exhibicion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_EXHIBICION")).ToString().Trim();
                        eE_Exhibicion.Exh_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("EXH_DESCRIPCION")).ToString().Trim();
                        listaExhibicion.Add(eE_Exhibicion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    
                    //readerSinc.NextResult();
                    //while (readerSinc.Read())
                    //{
                    //    E_Observacion eE_Observacion = new E_Observacion();
                    //    eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                    //    eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                    //    listaObservacion.Add(eE_Observacion);
                    //}

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Motivo_Reporte eE_Motivo_Reporte = new E_Motivo_Reporte();
                        eE_Motivo_Reporte.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Motivo_Reporte.CodMotivo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Motivo")).ToString().Trim();
                        eE_Motivo_Reporte.NombreMotivo = readerSinc.GetValue(readerSinc.GetOrdinal("Mot_Descripcion")).ToString().Trim();
                        listaMotivoReporte.Add(eE_Motivo_Reporte);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Opc_Pedido eE_Opc_Pedido = new E_Opc_Pedido();
                        eE_Opc_Pedido.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Opc_Pedido.CodOpcPedido = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Opc_Pedido")).ToString().Trim();
                        eE_Opc_Pedido.NombreOpcPedido = readerSinc.GetValue(readerSinc.GetOrdinal("Opc_Ped_Desc")).ToString().Trim();
                        listaOpcionPedido.Add(eE_Opc_Pedido);
                    }

                    //Author: Pablo Salas A.
                    //Fecha : 25/07/2012

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marcaje_Precio eE_Marcaje_Precio = new E_Marcaje_Precio();
                        eE_Marcaje_Precio.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marcaje_Precio.Cod_Marcaje_Precio = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marcaje_Precio")).ToString().Trim();
                        eE_Marcaje_Precio.MPre_Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("MPre_Nombre")).ToString().Trim();
                        listaMarcajePrecio.Add(eE_Marcaje_Precio);
                    }
                    
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Capacitacion eE_Capacitacion = new E_Capacitacion();
                        eE_Capacitacion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Capacitacion.Cod_Capacitacion = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Capacitacion")).ToString().Trim();
                        eE_Capacitacion.Cap_Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cap_Nombre")).ToString().Trim();
                        listaCapacitacion.Add(eE_Capacitacion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Status eE_Status = new E_Status();
                        eE_Status.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Status.Cod_Status = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Status")).ToString().Trim();
                        eE_Status.Sta_Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Sta_Nombre")).ToString().Trim();
                        listaStatus.Add(eE_Status);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Incidencia eE_Incidencia = new E_Incidencia();
                        eE_Incidencia.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Incidencia.Cod_Incidencia = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Incidencia")).ToString().Trim();
                        eE_Incidencia.Inc_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Inc_Descripcion")).ToString().Trim();
                        eE_Incidencia.Flg_Cantidad = readerSinc.GetBoolean(readerSinc.GetOrdinal("Flg_Cantidad")) ? 1 : 0;
                        listaIncidencias.Add(eE_Incidencia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Credito eE_Credito = new E_Credito();
                        eE_Credito.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Credito.Cod_Credito= readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Credito")).ToString().Trim();
                        eE_Credito.Cre_Nombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cre_Nombre")).ToString().Trim();
                        listaCredito.Add(eE_Credito);
                    }

                    readerSinc.Close();
                }
                #endregion
            #endregion

            #region Cliente Cementos Lima
            }
            else if (cliente == 1560) // CEMENTOS LIMA
            {
                #region Progresol
                if (equipo.Equals("811241282010")) // PROGRESOL
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult(); 
                    while (readerSinc.Read())
                    { 
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.Close();
                }
                #endregion
            }
            #endregion

            #region Cliente Altomayo - Prueba
            else if (cliente == 1619)
            {
                if (equipo.Equals("9900990099")) // DATA DE PRUEBA ALTOMAYO - ADD 07/06/2012
                {

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }
                    
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Observacion eE_Observacion = new E_Observacion();
                        eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                        eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaObservacion.Add(eE_Observacion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Promocion_Mov eE_Promocion_Mov = new E_Promocion_Mov();
                        eE_Promocion_Mov.CodPromocion = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Promocion")).ToString().Trim();
                        eE_Promocion_Mov.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Nombre")).ToString().Trim();
                        eE_Promocion_Mov.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        listaPromocion.Add(eE_Promocion_Mov);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Cluster eE_Cluster = new E_Cluster();
                        eE_Cluster.Cod_cluster = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Cluster")).ToString().Trim();
                        eE_Cluster.Pregunta = readerSinc.GetValue(readerSinc.GetOrdinal("Pregunta")).ToString().Trim();
                        eE_Cluster.Req_Cantidad = readerSinc.GetBoolean(readerSinc.GetOrdinal("Req_Cantidad")) ? 1 : 0;
                        listaCluster.Add(eE_Cluster);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Familia eE_Familia = new E_Familia();
                        eE_Familia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Familia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                        eE_Familia.FamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("FAM_NOMBRE")).ToString().Trim();
                        eE_Familia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_Familia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_Familia.CodSubCategoria = "0";
                        eE_Familia.CodSubMarca = "0";
                        eE_Familia.CodPresentacion = "0";
                        listaFamilia.Add(eE_Familia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_SubFamilia eE_SubFamilia = new E_SubFamilia();
                        eE_SubFamilia.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_SubFamilia.CodSubFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBFAMILIA")).ToString().Trim();
                        eE_SubFamilia.SubFamiliaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("SUBFAM_NOMBRE")).ToString().Trim();
                        eE_SubFamilia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_SubFamilia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_SubFamilia.CodFamilia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FAMILIA")).ToString().Trim();
                        eE_SubFamilia.CodSubCategoria = "0";
                        eE_SubFamilia.CodSubMarca = "0";
                        eE_SubFamilia.CodPresentacion = "0";
                        listaSubFamilia.Add(eE_SubFamilia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Actividad eE_Actividad = new E_Actividad();
                        eE_Actividad.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Actividad.CodActividad = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ACTIVIDAD")).ToString().Trim();
                        eE_Actividad.NombreActividad = readerSinc.GetValue(readerSinc.GetOrdinal("ACT_DESCRIPCION")).ToString().Trim();
                        listaActividad.Add(eE_Actividad);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Grupo_Objetivo eE_Grupo_Objetivo = new E_Grupo_Objetivo();
                        eE_Grupo_Objetivo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Grupo_Objetivo.CodGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("COD_GRUPOOBJ")).ToString().Trim();
                        eE_Grupo_Objetivo.NombreGrupoObjetivo = readerSinc.GetValue(readerSinc.GetOrdinal("GRUPOOBJ_DESC")).ToString().Trim();
                        listaGrupoObjetivo.Add(eE_Grupo_Objetivo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Cond_Exhib eE_Cond_Exhib = new E_Cond_Exhib();
                        eE_Cond_Exhib.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Cond_Exhib.CodCondExhib = readerSinc.GetValue(readerSinc.GetOrdinal("COD_COND_EXH")).ToString().Trim();
                        eE_Cond_Exhib.NombreCondExhib = readerSinc.GetValue(readerSinc.GetOrdinal("DESCRIPCION")).ToString().Trim();
                        listaCondExhib.Add(eE_Cond_Exhib);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Obj_Marca eE_Obj_Marca = new E_Obj_Marca();
                        eE_Obj_Marca.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();
                        eE_Obj_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eE_Obj_Marca.NombreMarca = readerSinc.GetValue(readerSinc.GetOrdinal("MAR_NOMBRE")).ToString().Trim();
                        eE_Obj_Marca.Objetivo = readerSinc.GetValue(readerSinc.GetOrdinal("OBJETIVO")).ToString().Trim();
                        eE_Obj_Marca.Cantidad = readerSinc.GetValue(readerSinc.GetOrdinal("CANTIDAD")).ToString().Trim();
                        eE_Obj_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        listaObjxMarca.Add(eE_Obj_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Servicio eE_Servicio = new E_Servicio();
                        eE_Servicio.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eE_Servicio.CodServicio = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SERVICIO")).ToString().Trim();
                        eE_Servicio.ServicioNombre = readerSinc.GetValue(readerSinc.GetOrdinal("SER_NOMBRE")).ToString().Trim();
                        eE_Servicio.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eE_Servicio.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        listaServicio.Add(eE_Servicio);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Competidora eCompetidora = new E_Competidora();
                        eCompetidora.CodCompetidora = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Competidora")).ToString().Trim();
                        eCompetidora.NombreCompetidora = readerSinc.GetValue(readerSinc.GetOrdinal("Com_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCompetidora.Add(eCompetidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Motivo_Reporte eE_Motivo_Reporte = new E_Motivo_Reporte();
                        eE_Motivo_Reporte.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Motivo_Reporte.CodMotivo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Motivo")).ToString().Trim();
                        eE_Motivo_Reporte.NombreMotivo = readerSinc.GetValue(readerSinc.GetOrdinal("Mot_Descripcion")).ToString().Trim();
                        listaMotivoReporte.Add(eE_Motivo_Reporte);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Opc_Pedido eE_Opc_Pedido = new E_Opc_Pedido();
                        eE_Opc_Pedido.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Opc_Pedido.CodOpcPedido = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Opc_Pedido")).ToString().Trim();
                        eE_Opc_Pedido.NombreOpcPedido = readerSinc.GetValue(readerSinc.GetOrdinal("Opc_Ped_Desc")).ToString().Trim();
                        listaOpcionPedido.Add(eE_Opc_Pedido);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Datos_Presencia eDatosPresencia = new E_Datos_Presencia();
                        eDatosPresencia.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTO_VENTA")).ToString().Trim();
                        eDatosPresencia.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("COD_CATEGORIA")).ToString().Trim();
                        eDatosPresencia.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("COD_MARCA")).ToString().Trim();
                        eDatosPresencia.CodOpcion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_OPCIONPRESENCIA")).ToString().Trim();
                        eDatosPresencia.CodElemento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_ELEMENTO")).ToString().Trim();
                        eDatosPresencia.CodValor = readerSinc.GetValue(readerSinc.GetOrdinal("VALOR_ELEMENTO")).ToString().Trim().Replace(',', '.');
                        listaDatosPresencia.Add(eDatosPresencia);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora eDistribuidora = new E_Distribuidora();
                        eDistribuidora.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eDistribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
                        listaDistribuidora.Add(eDistribuidora);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Distribuidora_PtoVenta eDistribuidoraPtoVenta = new E_Distribuidora_PtoVenta();
                        eDistribuidoraPtoVenta.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                        eDistribuidoraPtoVenta.CodPtoVenta = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTOVENTA")).ToString().Trim();
                        listaDistribuidoraPtoVenta.Add(eDistribuidoraPtoVenta);
                    }

                    //Sincronizar Ubicacion 
                    //05/06/2012 PSA
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Ubicacion eUbicacion = new E_Ubicacion();
                        eUbicacion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        eUbicacion.Cod_SubReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBREPORTE")).ToString().Trim();
                        eUbicacion.Cod_Ubicacion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_UBICACION")).ToString().Trim();
                        eUbicacion.Ubi_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("UBI_DESCRIPCION")).ToString().Trim();
                        listaUbicacion.Add(eUbicacion);
                    }

                    //Sincronizar Posicion 
                    //05/06/2012 PSA
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Posicion ePosicion = new E_Posicion();
                        ePosicion.Cod_Reporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_REPORTE")).ToString().Trim();
                        ePosicion.Cod_SubReporte = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SUBREPORTE")).ToString().Trim();
                        ePosicion.Cod_Posicion = readerSinc.GetValue(readerSinc.GetOrdinal("COD_POSICION")).ToString().Trim();
                        ePosicion.Ubi_Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("POS_DESCRIPCION")).ToString().Trim();
                        listaPosicion.Add(ePosicion);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Fase eFase = new E_Fase();
                        eFase.CodFase = readerSinc.GetValue(readerSinc.GetOrdinal("COD_FASE")).ToString().Trim();
                        eFase.NombreFase = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_FASE")).ToString().Trim();
                        eFase.Orden = int.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("ORDEN")).ToString().Trim());
                        listaFase.Add(eFase);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Segmento eSegmento = new E_Segmento();
                        eSegmento.CodSegmento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_SEGMENTO")).ToString().Trim();
                        eSegmento.NombreSegmento = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_SEGMENTO")).ToString().Trim();
                        listaSegmento.Add(eSegmento);
                    }

                    readerSinc.Close();

                    #region Datos De Prueba
                    #region Categorias
                    E_Categoria eE_Categoria = new E_Categoria();
                    eE_Categoria.IdReporte = "58";
                    eE_Categoria.IdCategoria = "10018";
                    eE_Categoria.CategoriaNombre = "Cafe Soluble";
                    listaCategoria.Add(eE_Categoria);

                    E_Categoria eE_Categoria2 = new E_Categoria();
                    eE_Categoria2.IdReporte = "58";
                    eE_Categoria2.IdCategoria = "10019";
                    eE_Categoria2.CategoriaNombre = "Cebada";
                    listaCategoria.Add(eE_Categoria2);

                    E_Categoria eE_Categoria3 = new E_Categoria();
                    eE_Categoria3.IdReporte = "19";
                    eE_Categoria3.IdCategoria = "10018";
                    eE_Categoria3.CategoriaNombre = "Cafe Soluble";
                    listaCategoria.Add(eE_Categoria3);

                    E_Categoria eE_Categoria4 = new E_Categoria();
                    eE_Categoria4.IdReporte = "19";
                    eE_Categoria4.IdCategoria = "10019";
                    eE_Categoria4.CategoriaNombre = "Cebada";
                    listaCategoria.Add(eE_Categoria4);
                    #endregion

                    #region Subcategorias
                    //SubCategorias
                    E_SubCategoria eE_SubCategoria = new E_SubCategoria();
                    eE_SubCategoria.CodReporte = "58";
                    eE_SubCategoria.CodCategoria = "10018";
                    eE_SubCategoria.CodSubCategoria = "01";
                    eE_SubCategoria.SubCategoriaNombre = "SubCategoria CafeSoluble 01";
                    listaSubCategoria.Add(eE_SubCategoria);

                    E_SubCategoria eE_SubCategoria1 = new E_SubCategoria();
                    eE_SubCategoria1.CodReporte = "58";
                    eE_SubCategoria1.CodCategoria = "10018";
                    eE_SubCategoria1.CodSubCategoria = "02";
                    eE_SubCategoria1.SubCategoriaNombre = "SubCategoria CafeSoluble 02";
                    listaSubCategoria.Add(eE_SubCategoria1);

                    E_SubCategoria eE_SubCategoria2 = new E_SubCategoria();
                    eE_SubCategoria2.CodReporte = "58";
                    eE_SubCategoria2.CodCategoria = "10019";
                    eE_SubCategoria2.CodSubCategoria = "03";
                    eE_SubCategoria2.SubCategoriaNombre = "SubCategoria Cebada 01";
                    listaSubCategoria.Add(eE_SubCategoria2);

                    E_SubCategoria eE_SubCategoria3 = new E_SubCategoria();
                    eE_SubCategoria3.CodReporte = "58";
                    eE_SubCategoria3.CodCategoria = "10019";
                    eE_SubCategoria3.CodSubCategoria = "04";
                    eE_SubCategoria3.SubCategoriaNombre = "SubCategoria Cebada 02";
                    listaSubCategoria.Add(eE_SubCategoria3);


                    E_SubCategoria eE_SubCategoria4 = new E_SubCategoria();
                    eE_SubCategoria4.CodReporte = "19";
                    eE_SubCategoria4.CodCategoria = "10018";
                    eE_SubCategoria4.CodSubCategoria = "01";
                    eE_SubCategoria4.SubCategoriaNombre = "SubCategoria CafeSoluble 01";
                    listaSubCategoria.Add(eE_SubCategoria4);

                    E_SubCategoria eE_SubCategoria5 = new E_SubCategoria();
                    eE_SubCategoria5.CodReporte = "19";
                    eE_SubCategoria5.CodCategoria = "10018";
                    eE_SubCategoria5.CodSubCategoria = "02";
                    eE_SubCategoria5.SubCategoriaNombre = "SubCategoria CafeSoluble 02";
                    listaSubCategoria.Add(eE_SubCategoria5);

                    E_SubCategoria eE_SubCategoria6 = new E_SubCategoria();
                    eE_SubCategoria6.CodReporte = "19";
                    eE_SubCategoria6.CodCategoria = "10019";
                    eE_SubCategoria6.CodSubCategoria = "03";
                    eE_SubCategoria6.SubCategoriaNombre = "SubCategoria Cebada 01";
                    listaSubCategoria.Add(eE_SubCategoria6);

                    E_SubCategoria eE_SubCategoria7 = new E_SubCategoria();
                    eE_SubCategoria7.CodReporte = "19";
                    eE_SubCategoria7.CodCategoria = "10019";
                    eE_SubCategoria7.CodSubCategoria = "04";
                    eE_SubCategoria7.SubCategoriaNombre = "SubCategoria Cebada 02";
                    listaSubCategoria.Add(eE_SubCategoria7);

                    #endregion

                    #region Marcas
                    E_Marca eE_Marcas = new E_Marca();
                    eE_Marcas.CodReporte = "58";
                    eE_Marcas.CodMarca = "100";
                    eE_Marcas.MarcaNombre = "Altomayo";
                    eE_Marcas.CodCategoria = "10018";
                    eE_Marcas.CodSubCategoria = "01";
                    listaMarca.Add(eE_Marcas);

                    E_Marca eE_Marcas2 = new E_Marca();
                    eE_Marcas2.CodReporte = "58";
                    eE_Marcas2.CodMarca = "101";
                    eE_Marcas2.MarcaNombre = "Nescafe";
                    eE_Marcas2.CodCategoria = "10018";
                    eE_Marcas2.CodSubCategoria = "02";
                    listaMarca.Add(eE_Marcas2);

                    E_Marca eE_Marcas3 = new E_Marca();
                    eE_Marcas3.CodReporte = "58";
                    eE_Marcas3.CodMarca = "102";
                    eE_Marcas3.MarcaNombre = "Kimbo";
                    eE_Marcas3.CodCategoria = "10019";
                    eE_Marcas3.CodSubCategoria = "03";
                    listaMarca.Add(eE_Marcas3);

                    E_Marca eE_Marcas4 = new E_Marca();
                    eE_Marcas4.CodReporte = "58";
                    eE_Marcas4.CodMarca = "103";
                    eE_Marcas4.MarcaNombre = "Otro Cafe";
                    eE_Marcas4.CodCategoria = "10019";
                    eE_Marcas4.CodSubCategoria = "04";
                    listaMarca.Add(eE_Marcas4);

                    E_Marca eE_Marcas5 = new E_Marca();
                    eE_Marcas5.CodReporte = "19";
                    eE_Marcas5.CodMarca = "100";
                    eE_Marcas5.MarcaNombre = "Altomayo";
                    eE_Marcas5.CodCategoria = "10018";
                    eE_Marcas5.CodSubCategoria = "01";
                    listaMarca.Add(eE_Marcas5);

                    E_Marca eE_Marcas6 = new E_Marca();
                    eE_Marcas6.CodReporte = "19";
                    eE_Marcas6.CodMarca = "101";
                    eE_Marcas6.MarcaNombre = "Nescafe";
                    eE_Marcas6.CodCategoria = "10018";
                    eE_Marcas6.CodSubCategoria = "02";
                    listaMarca.Add(eE_Marcas6);

                    E_Marca eE_Marcas7 = new E_Marca();
                    eE_Marcas7.CodReporte = "19";
                    eE_Marcas7.CodMarca = "102";
                    eE_Marcas7.MarcaNombre = "Kimbo";
                    eE_Marcas7.CodCategoria = "10019";
                    eE_Marcas7.CodSubCategoria = "03";
                    listaMarca.Add(eE_Marcas7);

                    E_Marca eE_Marcas8 = new E_Marca();
                    eE_Marcas8.CodReporte = "19";
                    eE_Marcas8.CodMarca = "103";
                    eE_Marcas8.MarcaNombre = "Otro Cafe";
                    eE_Marcas8.CodCategoria = "10019";
                    eE_Marcas8.CodSubCategoria = "04";
                    listaMarca.Add(eE_Marcas8);


                    #endregion

                    #region SubMarcas

                    E_SubMarca eE_SubMarca = new E_SubMarca();
                    eE_SubMarca.CodReporte = "58";
                    eE_SubMarca.CodSubMarca = "200";
                    eE_SubMarca.SubMarcaNombre = "SubMarca 01";
                    eE_SubMarca.CodCategoria = "10018";
                    eE_SubMarca.CodSubCategoria = "01";
                    eE_SubMarca.CodMarca = "100";
                    listaSubMarca.Add(eE_SubMarca);

                    E_SubMarca eE_SubMarca2 = new E_SubMarca();
                    eE_SubMarca2.CodReporte = "58";
                    eE_SubMarca2.CodSubMarca = "201";
                    eE_SubMarca2.SubMarcaNombre = "SubMarca 02";
                    eE_SubMarca2.CodCategoria = "10018";
                    eE_SubMarca2.CodSubCategoria = "02";
                    eE_SubMarca2.CodMarca = "101";
                    listaSubMarca.Add(eE_SubMarca2);


                    E_SubMarca eE_SubMarca4 = new E_SubMarca();
                    eE_SubMarca4.CodReporte = "58";
                    eE_SubMarca4.CodSubMarca = "202";
                    eE_SubMarca4.SubMarcaNombre = "SubMarca 03";
                    eE_SubMarca4.CodCategoria = "10019";
                    eE_SubMarca4.CodSubCategoria = "03";
                    eE_SubMarca4.CodMarca = "102";
                    listaSubMarca.Add(eE_SubMarca4);


                    E_SubMarca eE_SubMarca3 = new E_SubMarca();
                    eE_SubMarca3.CodReporte = "58";
                    eE_SubMarca3.CodSubMarca = "203";
                    eE_SubMarca3.SubMarcaNombre = "SubMarca 04";
                    eE_SubMarca3.CodCategoria = "10019";
                    eE_SubMarca3.CodSubCategoria = "04";
                    eE_SubMarca3.CodMarca = "103";
                    listaSubMarca.Add(eE_SubMarca3);


                    E_SubMarca eE_SubMarca5 = new E_SubMarca();
                    eE_SubMarca5.CodReporte = "19";
                    eE_SubMarca5.CodSubMarca = "200";
                    eE_SubMarca5.SubMarcaNombre = "SubMarca 01";
                    eE_SubMarca5.CodCategoria = "10018";
                    eE_SubMarca5.CodSubCategoria = "01";
                    eE_SubMarca5.CodMarca = "100";
                    listaSubMarca.Add(eE_SubMarca5);

                    E_SubMarca eE_SubMarca6 = new E_SubMarca();
                    eE_SubMarca6.CodReporte = "19";
                    eE_SubMarca6.CodSubMarca = "201";
                    eE_SubMarca6.SubMarcaNombre = "SubMarca 02";
                    eE_SubMarca6.CodCategoria = "10018";
                    eE_SubMarca6.CodSubCategoria = "02";
                    eE_SubMarca6.CodMarca = "101";
                    listaSubMarca.Add(eE_SubMarca6);


                    E_SubMarca eE_SubMarca7 = new E_SubMarca();
                    eE_SubMarca7.CodReporte = "19";
                    eE_SubMarca7.CodSubMarca = "202";
                    eE_SubMarca7.SubMarcaNombre = "SubMarca 03";
                    eE_SubMarca7.CodCategoria = "10019";
                    eE_SubMarca7.CodSubCategoria = "03";
                    eE_SubMarca7.CodMarca = "102";
                    listaSubMarca.Add(eE_SubMarca7);


                    E_SubMarca eE_SubMarca8 = new E_SubMarca();
                    eE_SubMarca8.CodReporte = "19";
                    eE_SubMarca8.CodSubMarca = "203";
                    eE_SubMarca8.SubMarcaNombre = "SubMarca 04";
                    eE_SubMarca8.CodCategoria = "10019";
                    eE_SubMarca8.CodSubCategoria = "04";
                    eE_SubMarca8.CodMarca = "103";
                    listaSubMarca.Add(eE_SubMarca8);

                    #endregion

                    #region Presentacion
                    E_Presentacion oE_Presentacion = new E_Presentacion();
                    oE_Presentacion.CodReporte = "58";
                    oE_Presentacion.CodPresentacion = "301";
                    oE_Presentacion.PresentacionNombre = "Presentacion 01";
                    oE_Presentacion.CodCategoria = "10018";
                    oE_Presentacion.CodSubCategoria = "01";
                    oE_Presentacion.CodMarca = "100";
                    oE_Presentacion.CodSubMarca = "200";
                    listaPresentacion.Add(oE_Presentacion);

                    E_Presentacion oE_Presentacion2 = new E_Presentacion();
                    oE_Presentacion2.CodReporte = "58";
                    oE_Presentacion2.CodPresentacion = "302";
                    oE_Presentacion2.PresentacionNombre = "Presentacion 02";
                    oE_Presentacion2.CodCategoria = "10018";
                    oE_Presentacion2.CodSubCategoria = "02";
                    oE_Presentacion2.CodMarca = "101";
                    oE_Presentacion2.CodSubMarca = "201";
                    listaPresentacion.Add(oE_Presentacion2);

                    E_Presentacion oE_Presentacion3 = new E_Presentacion();
                    oE_Presentacion3.CodReporte = "58";
                    oE_Presentacion3.CodPresentacion = "303";
                    oE_Presentacion3.PresentacionNombre = "Presentacion 03";
                    oE_Presentacion3.CodCategoria = "10019";
                    oE_Presentacion3.CodSubCategoria = "03";
                    oE_Presentacion3.CodMarca = "102";
                    oE_Presentacion3.CodSubMarca = "202";
                    listaPresentacion.Add(oE_Presentacion3);

                    E_Presentacion oE_Presentacion4 = new E_Presentacion();
                    oE_Presentacion4.CodReporte = "304";
                    oE_Presentacion4.CodPresentacion = "04";
                    oE_Presentacion4.PresentacionNombre = "Presentacion 04";
                    oE_Presentacion4.CodCategoria = "10019";
                    oE_Presentacion4.CodSubCategoria = "04";
                    oE_Presentacion4.CodMarca = "103";
                    oE_Presentacion4.CodSubMarca = "203";
                    listaPresentacion.Add(oE_Presentacion4);

                    E_Presentacion oE_Presentacion5 = new E_Presentacion();
                    oE_Presentacion5.CodReporte = "19";
                    oE_Presentacion5.CodPresentacion = "301";
                    oE_Presentacion5.PresentacionNombre = "Presentacion 01";
                    oE_Presentacion5.CodCategoria = "10018";
                    oE_Presentacion5.CodSubCategoria = "01";
                    oE_Presentacion5.CodMarca = "100";
                    oE_Presentacion5.CodSubMarca = "200";
                    listaPresentacion.Add(oE_Presentacion5);

                    E_Presentacion oE_Presentacion6 = new E_Presentacion();
                    oE_Presentacion6.CodReporte = "19";
                    oE_Presentacion6.CodPresentacion = "302";
                    oE_Presentacion6.PresentacionNombre = "Presentacion 02";
                    oE_Presentacion6.CodCategoria = "10018";
                    oE_Presentacion6.CodSubCategoria = "02";
                    oE_Presentacion6.CodMarca = "101";
                    oE_Presentacion6.CodSubMarca = "201";
                    listaPresentacion.Add(oE_Presentacion6);

                    E_Presentacion oE_Presentacion7 = new E_Presentacion();
                    oE_Presentacion7.CodReporte = "19";
                    oE_Presentacion7.CodPresentacion = "303";
                    oE_Presentacion7.PresentacionNombre = "Presentacion 03";
                    oE_Presentacion7.CodCategoria = "10019";
                    oE_Presentacion7.CodSubCategoria = "03";
                    oE_Presentacion7.CodMarca = "102";
                    oE_Presentacion7.CodSubMarca = "202";
                    listaPresentacion.Add(oE_Presentacion7);

                    E_Presentacion oE_Presentacion8 = new E_Presentacion();
                    oE_Presentacion8.CodReporte = "19";
                    oE_Presentacion8.CodPresentacion = "04";
                    oE_Presentacion8.PresentacionNombre = "Presentacion 04";
                    oE_Presentacion8.CodCategoria = "10019";
                    oE_Presentacion8.CodSubCategoria = "04";
                    oE_Presentacion8.CodMarca = "103";
                    oE_Presentacion8.CodSubMarca = "203";
                    listaPresentacion.Add(oE_Presentacion8);


                    #endregion

                    #region Familia
                    E_Familia eE_Familias = new E_Familia();
                    eE_Familias.CodReporte = "58";
                    eE_Familias.CodFamilia = "401";
                    eE_Familias.FamiliaNombre = "Familia 01";
                    eE_Familias.CodCategoria = "10018";
                    eE_Familias.CodSubCategoria = "01";
                    eE_Familias.CodMarca = "100";
                    eE_Familias.CodSubMarca = "200";
                    eE_Familias.CodPresentacion = "301";
                    listaFamilia.Add(eE_Familias);

                    E_Familia eE_Familias2 = new E_Familia();
                    eE_Familias2.CodReporte = "58";
                    eE_Familias2.CodFamilia = "402";
                    eE_Familias2.FamiliaNombre = "Familia 02";
                    eE_Familias2.CodCategoria = "10018";
                    eE_Familias2.CodSubCategoria = "02";
                    eE_Familias2.CodMarca = "101";
                    eE_Familias2.CodSubMarca = "201";
                    eE_Familias2.CodPresentacion = "302";
                    listaFamilia.Add(eE_Familias2);

                    E_Familia eE_Familias3 = new E_Familia();
                    eE_Familias3.CodReporte = "58";
                    eE_Familias3.CodFamilia = "403";
                    eE_Familias3.FamiliaNombre = "Familia 03";
                    eE_Familias3.CodCategoria = "10019";
                    eE_Familias3.CodSubCategoria = "03";
                    eE_Familias3.CodMarca = "102";
                    eE_Familias3.CodSubMarca = "202";
                    eE_Familias3.CodPresentacion = "303";
                    listaFamilia.Add(eE_Familias3);


                    E_Familia eE_Familias4 = new E_Familia();
                    eE_Familias4.CodReporte = "58";
                    eE_Familias4.CodFamilia = "404";
                    eE_Familias4.FamiliaNombre = "Familia 04";
                    eE_Familias4.CodCategoria = "10019";
                    eE_Familias4.CodSubCategoria = "04";
                    eE_Familias4.CodMarca = "103";
                    eE_Familias4.CodSubMarca = "203";
                    eE_Familias4.CodPresentacion = "304";
                    listaFamilia.Add(eE_Familias4);

                    E_Familia eE_Familias5 = new E_Familia();
                    eE_Familias5.CodReporte = "19";
                    eE_Familias5.CodFamilia = "401";
                    eE_Familias5.FamiliaNombre = "Familia 01";
                    eE_Familias5.CodCategoria = "10018";
                    eE_Familias5.CodSubCategoria = "01";
                    eE_Familias5.CodMarca = "100";
                    eE_Familias5.CodSubMarca = "200";
                    eE_Familias5.CodPresentacion = "301";
                    listaFamilia.Add(eE_Familias5);

                    E_Familia eE_Familias6 = new E_Familia();
                    eE_Familias6.CodReporte = "19";
                    eE_Familias6.CodFamilia = "402";
                    eE_Familias6.FamiliaNombre = "Familia 02";
                    eE_Familias6.CodCategoria = "10018";
                    eE_Familias6.CodSubCategoria = "02";
                    eE_Familias6.CodMarca = "101";
                    eE_Familias6.CodSubMarca = "201";
                    eE_Familias6.CodPresentacion = "302";
                    listaFamilia.Add(eE_Familias6);

                    E_Familia eE_Familias7 = new E_Familia();
                    eE_Familias7.CodReporte = "19";
                    eE_Familias7.CodFamilia = "403";
                    eE_Familias7.FamiliaNombre = "Familia 03";
                    eE_Familias7.CodCategoria = "10019";
                    eE_Familias7.CodSubCategoria = "03";
                    eE_Familias7.CodMarca = "102";
                    eE_Familias7.CodSubMarca = "202";
                    eE_Familias7.CodPresentacion = "303";
                    listaFamilia.Add(eE_Familias7);


                    E_Familia eE_Familias8 = new E_Familia();
                    eE_Familias8.CodReporte = "19";
                    eE_Familias8.CodFamilia = "404";
                    eE_Familias8.FamiliaNombre = "Familia 04";
                    eE_Familias8.CodCategoria = "10019";
                    eE_Familias8.CodSubCategoria = "04";
                    eE_Familias8.CodMarca = "103";
                    eE_Familias8.CodSubMarca = "203";
                    eE_Familias8.CodPresentacion = "304";
                    listaFamilia.Add(eE_Familias8);

                    #endregion

                    #region SubFamilia
                    E_SubFamilia eE_SubFamilias = new E_SubFamilia();
                    eE_SubFamilias.CodReporte = "58";
                    eE_SubFamilias.CodSubFamilia = "501";
                    eE_SubFamilias.SubFamiliaNombre = "SubFamilia 01";
                    eE_SubFamilias.CodCategoria = "10018";
                    eE_SubFamilias.CodSubCategoria = "01";
                    eE_SubFamilias.CodMarca = "100";
                    eE_SubFamilias.CodSubMarca = "200";
                    eE_SubFamilias.CodPresentacion = "301";
                    eE_SubFamilias.CodFamilia = "401";
                    listaSubFamilia.Add(eE_SubFamilias);

                    E_SubFamilia eE_SubFamilias2 = new E_SubFamilia();
                    eE_SubFamilias2.CodReporte = "58";
                    eE_SubFamilias2.CodSubFamilia = "502";
                    eE_SubFamilias2.SubFamiliaNombre = "SubFamilia 02";
                    eE_SubFamilias2.CodCategoria = "10018";
                    eE_SubFamilias2.CodSubCategoria = "02";
                    eE_SubFamilias2.CodMarca = "101";
                    eE_SubFamilias2.CodSubMarca = "201";
                    eE_SubFamilias2.CodPresentacion = "302";
                    eE_SubFamilias2.CodFamilia = "402";
                    listaSubFamilia.Add(eE_SubFamilias2);

                    E_SubFamilia eE_SubFamilias3 = new E_SubFamilia();
                    eE_SubFamilias3.CodReporte = "58";
                    eE_SubFamilias3.CodSubFamilia = "503";
                    eE_SubFamilias3.SubFamiliaNombre = "SubFamilia 03";
                    eE_SubFamilias3.CodCategoria = "10019";
                    eE_SubFamilias3.CodSubCategoria = "03";
                    eE_SubFamilias3.CodMarca = "102";
                    eE_SubFamilias3.CodSubMarca = "202";
                    eE_SubFamilias3.CodPresentacion = "303";
                    eE_SubFamilias3.CodFamilia = "403";
                    listaSubFamilia.Add(eE_SubFamilias3);

                    E_SubFamilia eE_SubFamilias4 = new E_SubFamilia();
                    eE_SubFamilias4.CodReporte = "58";
                    eE_SubFamilias4.CodSubFamilia = "504";
                    eE_SubFamilias4.SubFamiliaNombre = "SubFamilia 04";
                    eE_SubFamilias4.CodCategoria = "10019";
                    eE_SubFamilias4.CodSubCategoria = "04";
                    eE_SubFamilias4.CodMarca = "103";
                    eE_SubFamilias4.CodSubMarca = "203";
                    eE_SubFamilias4.CodPresentacion = "304";
                    eE_SubFamilias4.CodFamilia = "404";
                    listaSubFamilia.Add(eE_SubFamilias4);

                    E_SubFamilia eE_SubFamilias5 = new E_SubFamilia();
                    eE_SubFamilias5.CodReporte = "58";
                    eE_SubFamilias5.CodSubFamilia = "501";
                    eE_SubFamilias5.SubFamiliaNombre = "SubFamilia 01";
                    eE_SubFamilias5.CodCategoria = "10018";
                    eE_SubFamilias5.CodSubCategoria = "01";
                    eE_SubFamilias5.CodMarca = "100";
                    eE_SubFamilias5.CodSubMarca = "200";
                    eE_SubFamilias5.CodPresentacion = "301";
                    eE_SubFamilias5.CodFamilia = "401";
                    listaSubFamilia.Add(eE_SubFamilias5);

                    E_SubFamilia eE_SubFamilias6 = new E_SubFamilia();
                    eE_SubFamilias6.CodReporte = "58";
                    eE_SubFamilias6.CodSubFamilia = "502";
                    eE_SubFamilias6.SubFamiliaNombre = "SubFamilia 02";
                    eE_SubFamilias6.CodCategoria = "10018";
                    eE_SubFamilias6.CodSubCategoria = "02";
                    eE_SubFamilias6.CodMarca = "101";
                    eE_SubFamilias6.CodSubMarca = "201";
                    eE_SubFamilias6.CodPresentacion = "302";
                    eE_SubFamilias6.CodFamilia = "402";
                    listaSubFamilia.Add(eE_SubFamilias6);

                    E_SubFamilia eE_SubFamilias7 = new E_SubFamilia();
                    eE_SubFamilias7.CodReporte = "58";
                    eE_SubFamilias7.CodSubFamilia = "503";
                    eE_SubFamilias7.SubFamiliaNombre = "SubFamilia 03";
                    eE_SubFamilias7.CodCategoria = "10019";
                    eE_SubFamilias7.CodSubCategoria = "03";
                    eE_SubFamilias7.CodMarca = "102";
                    eE_SubFamilias7.CodSubMarca = "202";
                    eE_SubFamilias7.CodPresentacion = "303";
                    eE_SubFamilias7.CodFamilia = "403";
                    listaSubFamilia.Add(eE_SubFamilias7);

                    E_SubFamilia eE_SubFamilias8 = new E_SubFamilia();
                    eE_SubFamilias8.CodReporte = "58";
                    eE_SubFamilias8.CodSubFamilia = "504";
                    eE_SubFamilias8.SubFamiliaNombre = "SubFamilia 04";
                    eE_SubFamilias8.CodCategoria = "10019";
                    eE_SubFamilias8.CodSubCategoria = "04";
                    eE_SubFamilias8.CodMarca = "103";
                    eE_SubFamilias8.CodSubMarca = "203";
                    eE_SubFamilias8.CodPresentacion = "304";
                    eE_SubFamilias8.CodFamilia = "404";
                    listaSubFamilia.Add(eE_SubFamilias8);

                    #endregion

                    #region Productos
                    E_Producto eE_Producto = new E_Producto();
                    eE_Producto.CodReporte = "58";
                    eE_Producto.CodProducto = "2925";
                    eE_Producto.CodSKU = "COL0001";
                    eE_Producto.NombreProducto = "Producto 01";
                    eE_Producto.Propio = 1;
                    eE_Producto.CategoriaProducto = "10018";
                    eE_Producto.SubCategoriaProducto = "01";
                    eE_Producto.MarcaProducto = "100";
                    eE_Producto.SubMarcaProducto = "200";
                    eE_Producto.PresentacionProducto = "301";
                    eE_Producto.FamiliaProducto = "401";
                    eE_Producto.SubFamiliaProducto = "501";
                    listaProducto.Add(eE_Producto);

                    E_Producto eE_Producto2 = new E_Producto();
                    eE_Producto2.CodReporte = "58";
                    eE_Producto2.CodProducto = "2926";
                    eE_Producto2.CodSKU = "COL0002";
                    eE_Producto2.NombreProducto = "Producto 02";
                    eE_Producto2.Propio = 1;
                    eE_Producto2.CategoriaProducto = "10018";
                    eE_Producto2.SubCategoriaProducto = "02";
                    eE_Producto2.MarcaProducto = "101";
                    eE_Producto2.SubMarcaProducto = "201";
                    eE_Producto2.PresentacionProducto = "302";
                    eE_Producto2.FamiliaProducto = "402";
                    eE_Producto2.SubFamiliaProducto = "502";
                    listaProducto.Add(eE_Producto2);

                    E_Producto eE_Producto3 = new E_Producto();
                    eE_Producto3.CodReporte = "58";
                    eE_Producto3.CodProducto = "2931";
                    eE_Producto3.CodSKU = "COL0007";
                    eE_Producto3.NombreProducto = "Producto 03";
                    eE_Producto3.Propio = 1;
                    eE_Producto3.CategoriaProducto = "10019";
                    eE_Producto3.SubCategoriaProducto = "03";
                    eE_Producto3.MarcaProducto = "102";
                    eE_Producto3.SubMarcaProducto = "202";
                    eE_Producto3.PresentacionProducto = "303";
                    eE_Producto3.FamiliaProducto = "403";
                    eE_Producto3.SubFamiliaProducto = "503";
                    listaProducto.Add(eE_Producto3);

                    E_Producto eE_Producto4 = new E_Producto();
                    eE_Producto4.CodReporte = "58";
                    eE_Producto4.CodProducto = "2933";
                    eE_Producto4.CodSKU = "COL0008";
                    eE_Producto4.NombreProducto = "Producto 04";
                    eE_Producto4.Propio = 1;
                    eE_Producto4.CategoriaProducto = "10019";
                    eE_Producto4.SubCategoriaProducto = "04";
                    eE_Producto4.MarcaProducto = "103";
                    eE_Producto4.SubMarcaProducto = "203";
                    eE_Producto4.PresentacionProducto = "304";
                    eE_Producto4.FamiliaProducto = "404";
                    eE_Producto4.SubFamiliaProducto = "504";
                    listaProducto.Add(eE_Producto4);

                    E_Producto eE_Producto5 = new E_Producto();
                    eE_Producto5.CodReporte = "19";
                    eE_Producto5.CodProducto = "2925";
                    eE_Producto5.CodSKU = "COL0001";
                    eE_Producto5.NombreProducto = "Producto 01";
                    eE_Producto5.Propio = 1;
                    eE_Producto5.CategoriaProducto = "10018";
                    eE_Producto5.SubCategoriaProducto = "01";
                    eE_Producto5.MarcaProducto = "100";
                    eE_Producto5.SubMarcaProducto = "200";
                    eE_Producto5.PresentacionProducto = "301";
                    eE_Producto5.FamiliaProducto = "401";
                    eE_Producto5.SubFamiliaProducto = "501";
                    listaProducto.Add(eE_Producto5);

                    E_Producto eE_Producto6 = new E_Producto();
                    eE_Producto6.CodReporte = "19";
                    eE_Producto6.CodProducto = "2926";
                    eE_Producto6.CodSKU = "COL0002";
                    eE_Producto6.NombreProducto = "Producto 02";
                    eE_Producto6.Propio = 1;
                    eE_Producto6.CategoriaProducto = "10018";
                    eE_Producto6.SubCategoriaProducto = "02";
                    eE_Producto6.MarcaProducto = "101";
                    eE_Producto6.SubMarcaProducto = "201";
                    eE_Producto6.PresentacionProducto = "302";
                    eE_Producto6.FamiliaProducto = "402";
                    eE_Producto6.SubFamiliaProducto = "502";
                    listaProducto.Add(eE_Producto6);

                    E_Producto eE_Producto7 = new E_Producto();
                    eE_Producto7.CodReporte = "19";
                    eE_Producto7.CodProducto = "2931";
                    eE_Producto7.CodSKU = "COL0007";
                    eE_Producto7.NombreProducto = "Producto 03";
                    eE_Producto7.Propio = 1;
                    eE_Producto7.CategoriaProducto = "10019";
                    eE_Producto7.SubCategoriaProducto = "03";
                    eE_Producto7.MarcaProducto = "102";
                    eE_Producto7.SubMarcaProducto = "202";
                    eE_Producto7.PresentacionProducto = "303";
                    eE_Producto7.FamiliaProducto = "403";
                    eE_Producto7.SubFamiliaProducto = "503";
                    listaProducto.Add(eE_Producto7);

                    E_Producto eE_Producto8 = new E_Producto();
                    eE_Producto8.CodReporte = "19";
                    eE_Producto8.CodProducto = "2933";
                    eE_Producto8.CodSKU = "COL0008";
                    eE_Producto8.NombreProducto = "Producto 04";
                    eE_Producto8.Propio = 1;
                    eE_Producto8.CategoriaProducto = "10019";
                    eE_Producto8.SubCategoriaProducto = "04";
                    eE_Producto8.MarcaProducto = "103";
                    eE_Producto8.SubMarcaProducto = "203";
                    eE_Producto8.PresentacionProducto = "304";
                    eE_Producto8.FamiliaProducto = "404";
                    eE_Producto8.SubFamiliaProducto = "504";
                    listaProducto.Add(eE_Producto8);

                    #endregion

                    #endregion
                
                }
            }
            #endregion

            #region Cliente Backus
            if (cliente == 1637)
            {
                if (equipo.Equals("7777326102012")) //Supermercado
                {
                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Categoria eCategoria = new E_Categoria();
                        eCategoria.IdReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eCategoria.IdCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eCategoria.CategoriaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Cat_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        listaCategoria.Add(eCategoria);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Marca eE_Marca = new E_Marca();
                        eE_Marca.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Marca.CodMarca = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eE_Marca.MarcaNombre = readerSinc.GetValue(readerSinc.GetOrdinal("Mar_Nombre")).ToString().Trim();
                        eE_Marca.CodCategoria = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eE_Marca.MarcaPropia = readerSinc.GetBoolean(readerSinc.GetOrdinal("Mar_Propio")) ? 1 : 0;
                        eE_Marca.CodSubCategoria = "0";
                        listaMarca.Add(eE_Marca);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Producto eProducto = new E_Producto();
                        eProducto.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eProducto.CodProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Producto")).ToString().Trim();
                        eProducto.CodSKU = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SKU")).ToString().Trim();
                        eProducto.NombreProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Pro_Nombre")).ToString().Trim().Replace("&amp;", "y");
                        eProducto.Propio = readerSinc.GetBoolean(readerSinc.GetOrdinal("Pro_Tipo")) ? 1 : 0;
                        eProducto.CategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Categoria")).ToString().Trim();
                        eProducto.SubCategoriaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubCategoria")).ToString().Trim();
                        eProducto.MarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Marca")).ToString().Trim();
                        eProducto.SubMarcaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubMarca")).ToString().Trim();
                        eProducto.PresentacionProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Presentacion")).ToString().Trim();
                        eProducto.FamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Familia")).ToString().Trim();
                        eProducto.SubFamiliaProducto = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_SubFamilia")).ToString().Trim();
                        listaProducto.Add(eProducto);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Material_Apoyo eE_Material_Apoyo = new E_Material_Apoyo();
                        eE_Material_Apoyo.CodReporte = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Reporte")).ToString().Trim();
                        eE_Material_Apoyo.CodTipo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_TMaterial")).ToString().Trim();
                        eE_Material_Apoyo.CodMaterial = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Material")).ToString().Trim().Replace("&amp;", "y");
                        eE_Material_Apoyo.MatDescripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Descripcion")).ToString().Trim();
                        eE_Material_Apoyo.Propio = readerSinc.GetValue(readerSinc.GetOrdinal("Mat_Propio")).ToString().Trim();
                        listaTipoMaterialApoyo.Add(eE_Material_Apoyo);
                    }

                    readerSinc.NextResult();
                    while (readerSinc.Read())
                    {
                        E_Observacion eE_Observacion = new E_Observacion();
                        eE_Observacion.Codigo = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Observacion")).ToString().Trim();
                        eE_Observacion.Descripcion = readerSinc.GetValue(readerSinc.GetOrdinal("Descripcion")).ToString().Trim();
                        listaObservacion.Add(eE_Observacion);
                    }

                }
            }
            #endregion

            E_Sincronizar eSincronizar = new E_Sincronizar();
            eSincronizar.listaEstado = listaEstado;
            eSincronizar.listaMotivo = listaMotivo;
            eSincronizar.listaNoVisita = listaNoVisita;
            eSincronizar.ListaReporte = listaReporte;
            eSincronizar.ListaOpcionReporte = listaOpcReporte;
            eSincronizar.listaPuntoVenta = listaPuntoVenta;

            eSincronizar.listaCategoria = listaCategoria;
            eSincronizar.listaProducto = listaProducto;
            eSincronizar.listaTipoMaterialApoyo = listaTipoMaterialApoyo;
            eSincronizar.listaObservacion = listaObservacion;
            eSincronizar.listaMarca = listaMarca;
            eSincronizar.listaPromocion = listaPromocion;
            eSincronizar.listaCluster = listaCluster;
            eSincronizar.listaFamilia = listaFamilia;
            eSincronizar.listaSubFamilia = listaSubFamilia;
            eSincronizar.listaActividad = listaActividad;
            eSincronizar.listaGrupoObjetivo = listaGrupoObjetivo;
            eSincronizar.listaCondExhib = listaCondExhib;
            eSincronizar.listaObjxMarca = listaObjxMarca;
            eSincronizar.listaServicio = listaServicio;
            eSincronizar.listaCompetidora = listaCompetidora;
            eSincronizar.listaMotivoReporte = listaMotivoReporte;
            eSincronizar.listaOpcionPedido = listaOpcionPedido;
            eSincronizar.listaDistribuidora = listaDistribuidora;
            eSincronizar.listaDistribuidoraPtoVenta = listaDistribuidoraPtoVenta;
            eSincronizar.listaPosicion = listaPosicion;     //Add 05/06/2012 PSA
            eSincronizar.listaUbicacion = listaUbicacion;   //Add 05/06/2012 PSA
            eSincronizar.listaDatosPresencia = listaDatosPresencia;
            eSincronizar.listaSubCategoria = listaSubCategoria; //Add 06/06/2012 JGonzales
            eSincronizar.listaSubMarca = listaSubMarca; //Add 06/06/2012 JGonzales
            eSincronizar.listaPresentacion = listaPresentacion; //Add 06/06/2012 JGonzales
            eSincronizar.listaFase = listaFase; //Add 06/06/2012 JGonzales
            eSincronizar.listaSegmento = listaSegmento; //Add 06/06/2012 JGonzales
            eSincronizar.listaExhibicion = listaExhibicion;//Add 20/06/2012 PSalas
            eSincronizar.listaMotivo_Observacion = listaMotivo_Observacion;//Add 05/07/2012 PSalas
            eSincronizar.listaMarcaje_Precio = listaMarcajePrecio;//Add 25/07/2012 PSalas
            eSincronizar.listaCapacitacion = listaCapacitacion;//Add 25/07/2012 PSalas
            eSincronizar.listaStatus = listaStatus;//Add 25/07/2012 PSalas
            eSincronizar.listaIncidencias = listaIncidencias;//Add 25/07/2012 PSalas
            eSincronizar.listaCredito = listaCredito;//Add 25/07/2012 PSalas
            eSincronizar.listaCanal = listaCanal; //Add 29/08/2012 JGONZALES
            eSincronizar.listaDepartamentoXCanal = listaDepartamento; //Add 29/08/2012 JGONZALES
            eSincronizar.listaProvinciaXCanal = listaProvincia; //Add 29/08/2012 JGONZALES
            eSincronizar.listaPerfil = listaPerfil;//Add 04/09/2012 PSalas
            eSincronizar.listaTipoPerfil = listaTipoPerfil;//Add 04/09/2012 PSalas
            return eSincronizar;
        }

        public E_SincronizarPreDatos SincronizarPreDatos_Mov(string person_id, int cliente, string equipo)
        {
            SqlDataReader readerSinc = oConn.ejecutarDataReader("SP_GES_CAM_SINCRONIZAR_PREDATOS", equipo, cliente, person_id);

            //Listas Generales para todas las cuentas
            List<E_Pais> listaPais = new List<E_Pais>();
            List<E_Departamento> listaDepartamento = new List<E_Departamento>();
            List<E_Provincia> listaProvincia = new List<E_Provincia>();
            List<E_Distrito> listaDistrito = new List<E_Distrito>();

            while (readerSinc.Read())
            {
                E_Pais ePais = new E_Pais();
                ePais.CodPais = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PAIS")).ToString().Trim();
                ePais.NombrePais = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_PAIS")).ToString().Trim();
                listaPais.Add(ePais);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Departamento eDepartamento = new E_Departamento();
                eDepartamento.CodDepartamento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DEPARTAMENTO")).ToString().Trim();
                eDepartamento.CodPais = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PAIS")).ToString().Trim();
                eDepartamento.NombreDepartamento = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DPTO")).ToString().Trim();
                listaDepartamento.Add(eDepartamento);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Provincia eProvincia = new E_Provincia();
                eProvincia.CodProvincia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PROVINCIA")).ToString().Trim();
                eProvincia.CodPais = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PAIS")).ToString().Trim();
                eProvincia.CodDepartamento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DEPARTAMENTO")).ToString().Trim();
                eProvincia.NombreProvincia = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_PROVINCIA")).ToString().Trim();
                listaProvincia.Add(eProvincia);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Distrito eDistrito = new E_Distrito();
                eDistrito.CodDistrito = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRITO")).ToString().Trim();
                eDistrito.CodPais = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PAIS")).ToString().Trim();
                eDistrito.CodDepartamento = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DEPARTAMENTO")).ToString().Trim().Replace("&amp;", "y");
                eDistrito.CodProvincia = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PROVINCIA")).ToString().Trim();
                eDistrito.NombreDistrito = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRITO")).ToString().Trim();
                listaDistrito.Add(eDistrito);
            }

            readerSinc.Close();

            E_SincronizarPreDatos eSincronizarPreDatos = new E_SincronizarPreDatos();
            eSincronizarPreDatos.listaPais = listaPais;
            eSincronizarPreDatos.listaDepartamento = listaDepartamento;
            eSincronizarPreDatos.listaProvincia = listaProvincia;
            eSincronizarPreDatos.ListaDistrito = listaDistrito;

            return eSincronizarPreDatos;
        }
    }
}