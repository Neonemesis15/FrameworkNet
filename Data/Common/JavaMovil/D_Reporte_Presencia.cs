using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;
using System.Configuration;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Presencia
    {
            private Conexion oCoon;    
            public D_Reporte_Presencia()
            {
            UserInterface oUserInterface = new UserInterface();
            //oCoon = new Conexion(2);
            oUserInterface = null;
            }
           
            String error = string.Empty;

        #region AppMovil Lucky
            /// <summary>
        /// Registrar una Lista de Objetos del tipo E_Reporte_Presencia_General, 
        /// con la validación que no se repita información referente a Pres.Colgate, 
        /// por Punto de Venta, Categoria, Producto y Semana para Colgate DT e IT.
        /// pSalas
        /// 17/03/2012
        /// </summary>
        /// <param name="oListReporte_Presencia"></param>
        /// <returns></returns>
            public string Registrar_Presencia_General_Lista(List<E_Reporte_Presencia_General> oListReporte_Presencia){
                string mensaje = "";
                int valor = 1;
                
                oCoon = new Conexion(2);

                foreach (E_Reporte_Presencia_General oReporte_Presencia in oListReporte_Presencia) {
                    if (oReporte_Presencia.OpcionReporte_id == "04" || oReporte_Presencia.OpcionReporte_id == "05")
                    {
                        //Verificar si Existe Producto para Presencia Colgate, para un Id_Equipo,Id_Cliente,ClientePDV_Code,Categoria_id y periodo  20/03/2012 pSalas
                        //En caso de Existir no insertará un nuevo registro.
                        foreach (E_Reporte_Presencia_General_Detalle oDetalle in oReporte_Presencia.DetallePresencia)
                        {
                            DataTable dt = oCoon.ejecutarDataTable("STP_JVM_VERIFICAR_PRODUCTO", oReporte_Presencia.Equipo_id, oReporte_Presencia.Cliente_id, oReporte_Presencia.ClientPDV_Code, oReporte_Presencia.Categoria_id, oReporte_Presencia.OpcionReporte_id,
                              oReporte_Presencia.FechaRegistro, oDetalle.Id_producto);
                            if (dt.Rows[0]["EXISTE_CAB"].ToString() == "1" && dt.Rows[0]["EXISTE_PRO"].ToString() == "0")
                            {
                                //insertar Detalle
                                Registrar_Presencia_General_Detalle(oDetalle, dt.Rows[0]["ID_REG_PRESENCIA"].ToString());
                                valor = valor * 1;
                            }
                            else if (dt.Rows[0]["EXISTE_CAB"].ToString() == "0" && dt.Rows[0]["EXISTE_PRO"].ToString() == "0")
                            {
                                //Registrar Cabecera y Detalle
                                Registrar_Presencia_General(oReporte_Presencia);
                                valor = valor * 1;
                            }
                            else {
                                valor = valor * 0;
                            }
                            
                        }
                    }
                    //
                    else if (oReporte_Presencia.OpcionReporte_id == "03") { 
                    //Verificar si Existe Material de Apoyo, para un Id_Equipo, Id_Cliente, ClientePVD_Code y periodo. pSalas. 02/04/2012
                    //En caso de Existir no insertará un nuevo registro.
                        foreach (E_Reporte_Presencia_General_Detalle oDetalle in oReporte_Presencia.DetallePresencia)
                        {
                            DataTable dt = oCoon.ejecutarDataTable("STP_JVM_VERIFICAR_MATERIAL_APOYO", oReporte_Presencia.Equipo_id, oReporte_Presencia.Cliente_id, oReporte_Presencia.ClientPDV_Code, oReporte_Presencia.OpcionReporte_id,
                                 oReporte_Presencia.FechaRegistro, oDetalle.Id_pop);
                            if (dt.Rows[0]["EXISTE_CAB"].ToString() == "1" && dt.Rows[0]["EXISTE_MATERIAL_APOYO"].ToString() == "0")
                            {
                                //insertar Detalle
                                Registrar_Presencia_General_Detalle(oDetalle, dt.Rows[0]["ID_REG_PRESENCIA"].ToString());
                                valor = valor * 1;
                            }
                            else if (dt.Rows[0]["EXISTE_CAB"].ToString() == "0" && dt.Rows[0]["EXISTE_MATERIAL_APOYO"].ToString() == "0")
                            {
                                //Registrar Cabecera y Detalle
                                Registrar_Presencia_General(oReporte_Presencia);
                                valor = valor * 1;
                            }
                            else
                            {
                                valor = valor * 0;
                            }
                        }
                    }
                    else
                    {
                        Registrar_Presencia_General(oReporte_Presencia);
                        valor = valor * 1;
                    }
                }
                if (valor == 1) { mensaje = "Registro Ok"; } else { mensaje = "Obs: Algunos insumos de Pres.Colg, Pres.Comp. y/o Elem. Vis. ya fueron ingresados"; }
                return mensaje;
                
            }
        /// <summary>
        /// Registra Presencia Normalmente sin ningún tipo de restriccion o validación Adicional
        /// Usado para Colgate Bodega
        /// pSalas 28/03/2012
        /// </summary>
        /// <param name="oListE_Reporte_Presencia_General"></param>
        /// <returns></returns>
            public string Registrar_Presencia_General_Lista_Normal(List<E_Reporte_Presencia_General> oListE_Reporte_Presencia_General) {
                try
                {
                    foreach (E_Reporte_Presencia_General ReportePresencia in oListE_Reporte_Presencia_General)
                    {
                        error = error + Registrar_Presencia_General(ReportePresencia);
                    }
                }
                catch (Exception ex) {
                    error = error + ex.Message;
                } 
                
                return error;
            }


            public string id = "";
            public string aux_OpcionReporte_id = "";
            /// <summary>
            /// Inserta el Reporte de Presencia Cabecera (Colgate DT,IT, Bodega)
            /// pSalas
            /// 17/03/2012
            /// Add ReportePresencia para (Colgate Bodega) pSalas 28/03/2012
            /// </summary>
            /// <param name="oEReportePresencia_aux"></param>
            public string Registrar_Presencia_General(E_Reporte_Presencia_General oEReportePresencia_aux)
            {
                string id_reg_Presencia = "";
                oCoon = new Conexion(2);
                //Crear un Store procedure para InsertarPresencia con nuevo AppMovil
                id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_PRESENCIA_02", 14, int.Parse(oEReportePresencia_aux.Person_id ?? ""),
                oEReportePresencia_aux.Perfil_id ?? "", oEReportePresencia_aux.Equipo_id ?? "", oEReportePresencia_aux.Cliente_id ?? "",
                oEReportePresencia_aux.ClientPDV_Code ?? "",
                oEReportePresencia_aux.Categoria_id ?? "", oEReportePresencia_aux.Marca_id ?? "", oEReportePresencia_aux.OpcionReporte_id ?? "",
                oEReportePresencia_aux.FechaRegistro ?? "",
                oEReportePresencia_aux.Latitud ?? "", oEReportePresencia_aux.Longitud ?? "", oEReportePresencia_aux.OrigenCoordenada ?? "",
                oEReportePresencia_aux.TipoCanal ?? "",
                oEReportePresencia_aux.Comentario ?? "", id_reg_Presencia );
                aux_OpcionReporte_id = oEReportePresencia_aux.OpcionReporte_id;
                try
                {
                    foreach (E_Reporte_Presencia_General_Detalle detalle in oEReportePresencia_aux.DetallePresencia)
                    {
                        error = error + Registrar_Presencia_General_Detalle(detalle);
                    }
                }
                catch(Exception ex) {
                    error = error + ex.Message;
                }
                return error;
            }

        /// <summary>
        /// Insertar el Reporte_Presencia  Detalle (Colgate IT,DT,Bodega)
        /// pSalas 
        /// 17/03/2012
        /// Add ReportePresencia Detalle para (Colgate Bodega) pSalas 28/03/2012
        /// </summary>
        /// <param name="detalle">E_Reporte_Presencia_General_Detalle</param>
            private string Registrar_Presencia_General_Detalle(E_Reporte_Presencia_General_Detalle detalle)
            {
                //Actualización para FarmaciasIT. pSalas 06/03/2012. Agrega campos Ubicación y Posicion
                
                oCoon = new Conexion(2);
                E_Reporte_Presencia_General_Detalle oE_Reporte_Presencia_Detalle = new E_Reporte_Presencia_General_Detalle();
                try
                {
                    //pSalas 28/03/2012 Adiciona los siguientes Parametros Cod_Cluster y Valor_Cluster
                    oCoon.ejecutarDataTable("STP_JVM_INSERTAR_PRESENCIA_02_DETALLE",
                    Convert.ToInt64(id), detalle.Id_pop ?? "", detalle.Valor_pop ?? "", detalle.Id_producto ?? "", detalle.Precio ?? "", detalle.Stock ?? "",
                    detalle.Id_observacion ?? "", detalle.Observacion ?? "", detalle.Cantidad ?? "", detalle.Num_frentes ?? "", detalle.Profundidad ?? "", detalle.Pedido_sugerido ?? "",
                    detalle.Presencia ?? "", detalle.Cumple_Layout ?? "", detalle.Ubicacion ?? "", detalle.Posicion ?? "",
                    detalle.Cod_Cluster ?? "", detalle.Valor_Cluster ?? "");
                    error = error + "";
                }
                catch (Exception ex) {
                    error = error +  ex.Message;
                }
                return error;
            }
        
            /// <summary>
        /// Inserta ReportePresencia_Detalle, Se utiliza para insertar un nuevo detalle, para una cabecera Existente.
        /// Validación para Controlar que no se pueda relevar repetidos en el Reporte PresenciaColgate  para Colgate DT e IT
        /// pSalas
        /// 17/03/2012
        /// </summary>
        /// <param name="detalle">E_PresenciaDetalle</param>
        /// <param name="id_reg_presencia">ID_REG_PRESENCIA</param>
            private void Registrar_Presencia_General_Detalle(E_Reporte_Presencia_General_Detalle detalle, string id_reg_presencia)
            {
                //Actualización para FarmaciasIT. pSalas 06/03/2012. Agrega campos Ubicación y Posicion

                oCoon = new Conexion(2);
                E_Reporte_Presencia_General_Detalle oE_Reporte_Presencia_Detalle = new E_Reporte_Presencia_General_Detalle();
                    //pSalas 28/03/2012 Adiciona los siguientes Parametros Cod_Cluster y Valor_Cluster
                    oCoon.ejecutarDataTable("STP_JVM_INSERTAR_PRESENCIA_02_DETALLE",
                    Convert.ToInt64(id_reg_presencia), detalle.Id_pop ?? "", detalle.Valor_pop ?? "", detalle.Id_producto ?? "", detalle.Precio ?? "", detalle.Stock ?? "",
                    detalle.Id_observacion ?? "", detalle.Observacion ?? "", detalle.Cantidad ?? "", detalle.Num_frentes ?? "", detalle.Profundidad ?? "", detalle.Pedido_sugerido ?? "",
                    detalle.Presencia ?? "", detalle.Cumple_Layout ?? "", detalle.Ubicacion ?? "", detalle.Posicion ?? "",
                    detalle.Cod_Cluster ?? "", detalle.Valor_Cluster ?? "");

            }
            #endregion

        #region AppMovil Movistar


            #region Codigo Reutilizable
            ///// <summary>
            ///// Descripcion : Retornar una lista de Puntos de Venta con Ventana para actualizar esta info.
            ///// Fecha       : 11/06/2012
            ///// </summary>
            ///// <param name="oListReportes"></param>
            ///// <returns></returns>
            //public List<PtosVenta_Con_Ventana> BuscarVentana(List<E_Reporte_Presencia_Mov> oListReportes) {
               
            //    List<PtosVenta_Con_Ventana> oListPtosVenta = new List<PtosVenta_Con_Ventana>();

            //    foreach (E_Reporte_Presencia_Mov Cabecera in oListReportes) {
            //        foreach (E_Reporte_Presencia_Mov_Detalle Detalle in Cabecera.Detalle) {
            //            if (Detalle.Cod_MatApoyo.Equals("09")) {
            //                PtosVenta_Con_Ventana oPtosVenta_Con_Ventana = new PtosVenta_Con_Ventana();
            //                oPtosVenta_Con_Ventana.Cod_Equipo = Cabecera.Cod_Equipo;
            //                oPtosVenta_Con_Ventana.Cod_PuntoVenta = Cabecera.Cod_PtoVenta;
            //                oPtosVenta_Con_Ventana.Fecha_Registro = Cabecera.FechaRegistro;
            //                oListPtosVenta.Add(oPtosVenta_Con_Ventana);
            //            }
            //        }
            //    }
            //    return oListPtosVenta;
            //}
            ///// <summary>
            ///// Descripcion : Clase para Guardar el Cod_PuntoVenta, Cod_Equipo y FechaRegistro.
            ///// Fecha       :  11/06/2012
            ///// </summary>
            //private class PtosVenta_Con_Ventana
            //{
            //    public string Cod_PuntoVenta { get; set; }
            //    public string Cod_Equipo { get; set; }
            //    public DateTime Fecha_Registro { get; set; }
            //}

            //private void Actualizar_Fase_PtoVenta(List<PtosVenta_Con_Ventana> oListPtosVenta_Con_Ventana) {
            //    try { 

            //    }
            //    catch (Exception ex) { 

            //    }
            //}
            #endregion
            string Cod_PtoVta_Cliente = string.Empty;
            public E_Reporte_Presencia_Datos_Response Registrar_Presencia_Bodega_Mov(List<E_Reporte_Presencia_Mov> oListaReporte, int AppEnvio)
            {
                E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
                try
                {
                    
                    foreach (E_Reporte_Presencia_Mov oReportePresencia in oListaReporte)
                    {
                        //Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);

                        if (Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 8)
                        {
                            Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                            
                        }
                        else
                        {
                            #region Validacion Duplicados
                            foreach (E_Reporte_Presencia_Mov_Detalle Detalle in oReportePresencia.Detalle)
                            {
                                string result;

                                if (Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 4 ||
                                    Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 5 ||
                                    Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 13 ||
                                    Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 14
                                    )
                                {
                                    oCoon = new Conexion(1);
                                    result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
                                    oReportePresencia.Cod_Compania,
                                    oReportePresencia.Cod_Equipo,
                                    oReportePresencia.Cod_OpcionPresencia.Trim(),
                                    oReportePresencia.Cod_PtoVenta,
                                    oReportePresencia.FechaRegistro,
                                    Detalle.SKU_Producto, "");
                                    Cod_PtoVta_Cliente = oReportePresencia.Cod_PtoVenta;

                                }
                                else if (Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 3 ||
                                         Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 6)
                                {
                                    oCoon = new Conexion(1);
                                    result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
                                    oReportePresencia.Cod_Compania,
                                    oReportePresencia.Cod_Equipo,
                                    oReportePresencia.Cod_OpcionPresencia.Trim(),
                                    oReportePresencia.Cod_PtoVenta.Trim(),
                                    oReportePresencia.FechaRegistro,
                                    Detalle.Cod_MatApoyo, "");
                                }
                                else
                                {
                                    result = "1";
                                }
                                if (result == "1")
                                {
                                    //Creacion de Cabecera Nueva
                                    //Creacion de Detalle por Productos y/o Materiales de Apoyo que no existen en ese periodo.
                                    E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Falta = new E_Reporte_Presencia_Mov();
                                    E_Reporte_Presencia_Mov_Detalle E_Reporte_Presencia_Mov_Falta_Detalle = new E_Reporte_Presencia_Mov_Detalle();

                                    #region Cabecera Faltante - No hay Items para ese periodo.
                                    oE_Reporte_Presencia_Mov_Falta.Cod_Categoria = oReportePresencia.Cod_Categoria;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_Compania=oReportePresencia.Cod_Compania;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_Equipo=oReportePresencia.Cod_Equipo;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_Familia=oReportePresencia.Cod_Familia;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_Marca=oReportePresencia.Cod_Marca;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_OpcionPresencia=oReportePresencia.Cod_OpcionPresencia;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_Persona=oReportePresencia.Cod_Persona;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_Presentacion=oReportePresencia.Cod_Presentacion;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_PtoVenta=oReportePresencia.Cod_PtoVenta;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_SubCategoria=oReportePresencia.Cod_SubCategoria;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_SubFamilia=oReportePresencia.Cod_SubFamilia;
                                    oE_Reporte_Presencia_Mov_Falta.Cod_SubMarca=oReportePresencia.Cod_SubMarca;
                                    oE_Reporte_Presencia_Mov_Falta.Comentario=oReportePresencia.Comentario;
                                    oE_Reporte_Presencia_Mov_Falta.Fase=oReportePresencia.Fase;
                                    oE_Reporte_Presencia_Mov_Falta.FechaRegistro=oReportePresencia.FechaRegistro;
                                    oE_Reporte_Presencia_Mov_Falta.Latitud=oReportePresencia.Latitud;
                                    oE_Reporte_Presencia_Mov_Falta.Longitud=oReportePresencia.Longitud;
                                    oE_Reporte_Presencia_Mov_Falta.Nuevo=oReportePresencia.Nuevo;
                                    oE_Reporte_Presencia_Mov_Falta.Origen = oReportePresencia.Origen;
                                    #endregion
                                    
                                    #region Detalle Faltante
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Cantidad = Detalle.Cantidad;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Cluster = Detalle.Cod_Cluster;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Cod_MatApoyo = Detalle.Cod_MatApoyo;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Observacion = Detalle.Cod_Observacion;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Posicion = Detalle.Cod_Posicion;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Ubicacion = Detalle.Cod_Ubicacion;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Cumple_Layout = Detalle.Cumple_Layout;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Num_Frentes = Detalle.Num_Frentes;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Observacion = Detalle.Observacion;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Pedido_Sugerido = Detalle.Pedido_Sugerido;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Precio = Detalle.Precio;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Presencia = Detalle.Presencia;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Profundidad = Detalle.Profundidad;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.SKU_Producto = Detalle.SKU_Producto;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Stock = Detalle.Stock;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Valor_Cluster = Detalle.Valor_Cluster;
                                    E_Reporte_Presencia_Mov_Falta_Detalle.Valor_MatApoyo = Detalle.Valor_MatApoyo;
                                    #endregion
                                    oE_Reporte_Presencia_Mov_Falta.Detalle.Add(E_Reporte_Presencia_Mov_Falta_Detalle);
                                    
                                    Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov_Falta,AppEnvio);
                                    //break;

                                    //oE_Reporte_Presencia_Mov_Falta.Detalle=
                                    //Registrar_Presencia_Mov_Cabecera(oReportePresencia_Faltantes, AppEnvio);
                                    //Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                                    //break;

                                }
                                else if (result == "0")
                                {
                                    Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                                    error += "Advertencia: No existe periodo creado para esta fecha de registro. Consulte con su Supervisor.";
                                    break;
                                }
                                else
                                {
                                    error += result + Environment.NewLine;
                                }
                            }
                        }
                        #endregion

                        Cod_PtoVta_Cliente = oReportePresencia.Cod_PtoVenta;
                    }

                    #region Actualizar Fase I - Puntos de Venta con Ventana
                    Actualizar_Fase_PDVs_Con_Ventana(oListaReporte);//Add 11/06/2012 PSA
                    #endregion

                    #region Actualizar Pdv_Nuevo
                    Actualizar_Estado_Pdv_Nuevo(oListaReporte);//Add 22/07/2012 PSA
                    #endregion

                    oE_Reporte_Presencia_Datos_Response.CodPtoVenta=Cod_PtoVta_Cliente;
                    if(Cod_Fase.Equals("I")){
                    oE_Reporte_Presencia_Datos_Response.FasePtoVenta=Cod_Fase;
                    }
                    oE_Reporte_Presencia_Datos_Response.comentario = error;
                    
                    return oE_Reporte_Presencia_Datos_Response;
                }
                catch (Exception ex)
                {
                    error = error + ex.Message;
                    throw ex;
                }

                //return oE_Reporte_Presencia_Datos_Response;
            }

            /// <summary>
            /// Descripcion : Registrar Reporte Presencia App Movil Movistar
            /// Fecha       : 08/06/2012 PSA
            /// </summary>
            /// <param name="oListaReporte"></param>
            /// <returns></returns>
            /// 
            public string Registrar_Presencia_Mov(List<E_Reporte_Presencia_Mov> oListaReporte, int AppEnvio)
            {
                try
                {
                    //oCoon = new Conexion(1);
                    foreach (E_Reporte_Presencia_Mov oReportePresencia in oListaReporte)
                    {
                        if (!string.IsNullOrEmpty(oReportePresencia.Cod_OpcionPresencia))
                        {
                            if (Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 8)
                            {
                                Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                            }
                            else
                            {
                                //Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                                foreach (E_Reporte_Presencia_Mov_Detalle Detalle in oReportePresencia.Detalle)
                                {

                                    string result;

                                    if (Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 4 ||
                                        Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 5 ||
                                        Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 13 ||
                                        Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 14)
                                    {
                                        oCoon = new Conexion(1);
                                        result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
                                        oReportePresencia.Cod_Compania,
                                        oReportePresencia.Cod_Equipo,
                                        oReportePresencia.Cod_OpcionPresencia.Trim(),
                                        oReportePresencia.Cod_PtoVenta,
                                        oReportePresencia.FechaRegistro,
                                        Detalle.SKU_Producto, "");
                                    }
                                    else if (Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 3 ||
                                            Convert.ToInt32(oReportePresencia.Cod_OpcionPresencia.ToString()) == 6)
                                    {
                                        oCoon = new Conexion(1);
                                        result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
                                        oReportePresencia.Cod_Compania,
                                        oReportePresencia.Cod_Equipo,
                                        oReportePresencia.Cod_OpcionPresencia.Trim(),
                                        oReportePresencia.Cod_PtoVenta.Trim(),
                                        oReportePresencia.FechaRegistro,
                                        Detalle.Cod_MatApoyo, "");
                                    }
                                    else
                                    {
                                        result = "1";
                                    }

                                    if (result == "1")
                                    {
                                        //Creacion de Cabecera Nueva
                                        //Creacion de Detalle por Productos y/o Materiales de Apoyo que no existen en ese periodo.
                                        E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Falta = new E_Reporte_Presencia_Mov();
                                        E_Reporte_Presencia_Mov_Detalle E_Reporte_Presencia_Mov_Falta_Detalle = new E_Reporte_Presencia_Mov_Detalle();

                                        #region Cabecera Faltante - No hay Items para ese periodo.
                                        oE_Reporte_Presencia_Mov_Falta.Cod_Categoria = oReportePresencia.Cod_Categoria;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_Compania = oReportePresencia.Cod_Compania;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_Equipo = oReportePresencia.Cod_Equipo;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_Familia = oReportePresencia.Cod_Familia;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_Marca = oReportePresencia.Cod_Marca;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_OpcionPresencia = oReportePresencia.Cod_OpcionPresencia;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_Persona = oReportePresencia.Cod_Persona;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_Presentacion = oReportePresencia.Cod_Presentacion;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_PtoVenta = oReportePresencia.Cod_PtoVenta;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_SubCategoria = oReportePresencia.Cod_SubCategoria;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_SubFamilia = oReportePresencia.Cod_SubFamilia;
                                        oE_Reporte_Presencia_Mov_Falta.Cod_SubMarca = oReportePresencia.Cod_SubMarca;
                                        oE_Reporte_Presencia_Mov_Falta.Comentario = oReportePresencia.Comentario;
                                        oE_Reporte_Presencia_Mov_Falta.Fase = oReportePresencia.Fase;
                                        oE_Reporte_Presencia_Mov_Falta.FechaRegistro = oReportePresencia.FechaRegistro;
                                        oE_Reporte_Presencia_Mov_Falta.Latitud = oReportePresencia.Latitud;
                                        oE_Reporte_Presencia_Mov_Falta.Longitud = oReportePresencia.Longitud;
                                        oE_Reporte_Presencia_Mov_Falta.Nuevo = oReportePresencia.Nuevo;
                                        oE_Reporte_Presencia_Mov_Falta.Origen = oReportePresencia.Origen;
                                        #endregion

                                        #region Detalle Faltante
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Cantidad = Detalle.Cantidad;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Cluster = Detalle.Cod_Cluster;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Cod_MatApoyo = Detalle.Cod_MatApoyo;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Observacion = Detalle.Cod_Observacion;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Posicion = Detalle.Cod_Posicion;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Cod_Ubicacion = Detalle.Cod_Ubicacion;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Cumple_Layout = Detalle.Cumple_Layout;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Num_Frentes = Detalle.Num_Frentes;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Observacion = Detalle.Observacion;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Pedido_Sugerido = Detalle.Pedido_Sugerido;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Precio = Detalle.Precio;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Presencia = Detalle.Presencia;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Profundidad = Detalle.Profundidad;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.SKU_Producto = Detalle.SKU_Producto;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Stock = Detalle.Stock;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Valor_Cluster = Detalle.Valor_Cluster;
                                        E_Reporte_Presencia_Mov_Falta_Detalle.Valor_MatApoyo = Detalle.Valor_MatApoyo;
                                        #endregion
                                        oE_Reporte_Presencia_Mov_Falta.Detalle.Add(E_Reporte_Presencia_Mov_Falta_Detalle);

                                        Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov_Falta, AppEnvio);
                                        //break;

                                        //oE_Reporte_Presencia_Mov_Falta.Detalle=
                                        //Registrar_Presencia_Mov_Cabecera(oReportePresencia_Faltantes, AppEnvio);
                                        //Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                                        //break;

                                    }
                                    else if (result == "0")
                                    {
                                        //Registrar Información sin Periodo. Pablo Salas
                                        Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                                        error = "No existe periodo creado para esta fecha de registro. Consulte con su Supervisor.";
                                        break;
                                    }
                                    else
                                    {
                                        error += result + Environment.NewLine;
                                    }
                                }
                            }
                        }
                        else {

                            Registrar_Presencia_Mov_Cabecera(oReportePresencia, AppEnvio);
                        }
                    }

                }
                catch (Exception ex)
                {
                    error = error + ex.Message;
                    throw ex;
                }

                return error;
            }
            /// <summary>
            /// Descripcion : Actualizar PDV de estado NI(No Implementado) a Implementado, si los registros contienen el Elemento Ventana Roja.
            /// Fecha       : 08/06/2012 PSA
            /// </summary>
            /// <param name="oListaReportes"></param>
            private string Cod_Fase = string.Empty;
            private void Actualizar_Fase_PDVs_Con_Ventana(List<E_Reporte_Presencia_Mov> oListaReportes)
            {
                try
                {
                    string ExistePeriodo = string.Empty;
                    foreach (E_Reporte_Presencia_Mov Cabecera in oListaReportes)
                    {
                        //Colgate Bodega y Estado de Punto de Venta NI(No Implementado).
                        if (Cabecera.Cod_Equipo.Equals("012011092692011") 
                            //&& string.IsNullOrEmpty(Cabecera.Fase)
                            //&& !Cabecera.Fase.Equals(null)
                            && Cabecera.Fase.Equals("NI")
                            && Cabecera.Cod_OpcionPresencia.Equals("3")
                        )
                        {
                            #region Actualizar Implementacion
                            //oCoon = new Conexion(3);
                            //string auxPeriodo = string.Empty;
                            //auxPeriodo = oCoon.ejecutarretornodeOUTPUT("TG_GES_OPE_DETERMINAR_PERIODO", 3
                            //,Cabecera.Cod_Equipo
                            //,Cabecera.Cod_PtoVenta
                            //,Cabecera.FechaRegistro
                            //,"");
                            //if (!auxPeriodo.Equals(""))
                            //{
                            //    ExistePeriodo = "";
                                foreach (E_Reporte_Presencia_Mov_Detalle Detalle in Cabecera.Detalle)
                                {
                                    if (Detalle.Cod_MatApoyo.Equals("02"))
                                    {
                                        #region Anterior código
                                        //oCoon = new Conexion(3);
                                        //oCoon.ejecutarDataTable("SP_GES_OPE_ACTUALIZAR_PTOVENTA_FASE_IMPLEMENTADO"
                                        //    , Cabecera.Cod_Persona
                                        //    , Cabecera.Cod_Equipo
                                        //    , Cabecera.Cod_Compania
                                        //    , Cabecera.Cod_PtoVenta
                                        //    , Cabecera.FechaRegistro
                                        //    , Cabecera.Latitud
                                        //    , Cabecera.Longitud
                                        //    , Cabecera.Origen
                                        //    );
                                        #endregion

                                        #region Actualiza Fase Implementación en Xplora
                                        oCoon = new Conexion(1);
                                        oCoon.ejecutarDataSet("SP_XPL_GES_OPE_ACTUALIZAR_FASE_IMPLEMENTADO"
                                        , Cabecera.Cod_Persona
                                        , Cabecera.Cod_Equipo
                                        , Cabecera.Cod_Compania
                                        , Cabecera.Cod_PtoVenta
                                        , Cabecera.FechaRegistro
                                        , Cabecera.Latitud
                                        , Cabecera.Longitud
                                        , Cabecera.Origen);
                                        #endregion

                                        #region Actualiza Fase Implementación en Intermedia
                                        oCoon = new Conexion(3);
                                        oCoon.ejecutarDataSet("SP_MOV_GES_OPE_ACTUALIZAR_FASE_IMPLEMENTADO"
                                        , Cabecera.Cod_Persona
                                        , Cabecera.Cod_Equipo
                                        , Cabecera.Cod_Compania
                                        , Cabecera.Cod_PtoVenta
                                        , Cabecera.FechaRegistro
                                        , Cabecera.Latitud
                                        , Cabecera.Longitud
                                        , Cabecera.Origen);

                                        #endregion

                                        Cod_Fase = "I";
                                    }
                                }
                            //}
                            //else {
                            //    ExistePeriodo = "Debe existir un periodo previamente definido para poder Relevar Información. Consulte con su Supervisor antes de continuar.";
                            //}
                            #endregion
                        }
                        else if (
                           Cabecera.Cod_Equipo.Equals("012011092692011")
                           && Cabecera.Fase.Equals("NM")
                           )
                        {
                            #region Warning - En Ambos métodos falta Actualizar el PointOfSale_Planning Xplora e Intermedia.
                            //Actualizar a fase M los registros de Presencia y Elimina los MotivoFase por PtoVenta, Equipo y Periodo en BD Intermedia - BDLUCKYTMP
                            oCoon = new Conexion(3);
                            oCoon.ejecutarDataTable("SP_MOV_GES_OPE_ACTUALIZAR_FASE_MANTENIMIENTO", Cabecera.Cod_Equipo, Cabecera.Cod_PtoVenta, Cabecera.Cod_Persona);

                            //Actualizar a fase M los registros de Presencia y Elimina los MotivoFase por PtoVenta, Camapania y Periodo en Xplora - DBLUCKYPRD_BAK
                            oCoon = new Conexion(1);
                            oCoon.ejecutarDataTable("SP_XPL_GES_OPE_ACTUALIZAR_FASE_MANTENIMIENTO", Cabecera.Cod_Equipo, Cabecera.Cod_PtoVenta, Cabecera.Cod_Persona);
                            #endregion
                        }
                    }
                    //return ExistePeriodo;
                }
                catch (Exception ex) {
                    //return "Ha ocurrido un Error, Consultar con Equipo de TI";
                    throw ex;
                }
            }
            public void Registrar_Presencia_Mov_Cabecera(E_Reporte_Presencia_Mov oEReportePresencia, int AppEnvio)
            {
                try
                {
                    string id_reg_Presencia = "";
                    oCoon = new Conexion(3);

                    id_reg_Presencia = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_PRESENCIA", 15,
                    oEReportePresencia.Cod_Persona, oEReportePresencia.Cod_Equipo,
                    oEReportePresencia.Cod_Compania, oEReportePresencia.Cod_PtoVenta,
                    oEReportePresencia.Cod_Categoria, oEReportePresencia.Cod_Marca,
                    oEReportePresencia.Cod_OpcionPresencia, oEReportePresencia.FechaRegistro,
                    oEReportePresencia.Latitud ?? null, oEReportePresencia.Longitud ?? null,
                    oEReportePresencia.Origen ?? null, oEReportePresencia.Comentario ?? null,
                    AppEnvio, oEReportePresencia.Fase ?? null, oEReportePresencia.Nuevo ?? "0", id_reg_Presencia);
                    foreach (E_Reporte_Presencia_Mov_Detalle detalle in oEReportePresencia.Detalle)
                    {
                        Registrar_Presencia_Mov_Detalle(detalle, id_reg_Presencia);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
            }
            private void Registrar_Presencia_Mov_Detalle(E_Reporte_Presencia_Mov_Detalle detalle, string Id_Reg_Presencia)
            {
                oCoon = new Conexion(3);
                E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Detalle = new E_Reporte_Presencia_Mov_Detalle();
                try
                {
                    oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_PRESENCIA_DETALLE",
                    Convert.ToInt64(Id_Reg_Presencia), detalle.Cod_MatApoyo ?? null, detalle.Valor_MatApoyo ?? null,
                    detalle.SKU_Producto ?? null, detalle.Precio ?? null, detalle.Stock ?? null,
                    detalle.Cod_Observacion ?? null, detalle.Observacion ?? null,
                    detalle.Cantidad ?? null, detalle.Num_Frentes ?? null,
                    detalle.Profundidad ?? null, detalle.Pedido_Sugerido ?? null,
                    detalle.Presencia ?? null, detalle.Cumple_Layout ?? null,
                    detalle.Cod_Ubicacion ?? null, detalle.Cod_Posicion ?? null,
                    detalle.Cod_Cluster ?? null, detalle.Valor_Cluster ?? null);
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
            }
            
            /// <summary>
            /// Author      : Pablo Salas A.
            /// Date        : 22/07/2012
            /// Description : Actualizar el estado del Punto de Venta en Si es Nuevo en la Tabla de Presencia.
            /// 
            /// </summary>
            /// <param name="oListaReportes"></param>
            private void Actualizar_Estado_Pdv_Nuevo(List<E_Reporte_Presencia_Mov> oListaReportes)
            {
                try
                {
                    string ExistePeriodo = string.Empty;
                    foreach (E_Reporte_Presencia_Mov oReportePresencia in oListaReportes)
                    {
                        //Colgate Bodega y Estado de Punto de Venta NI(No Implementado).
                        if (oReportePresencia.Cod_Equipo.Equals("012011092692011"))
                        {
                            #region Actualizar Estado PDV Nuevo en Xplora
                            oCoon = new Conexion(1);
                            oCoon.ejecutarDataSet("SP_XPL_GES_OPE_ACTUALIZAR_ESTADO_PDV_NUEVO"
                                , oReportePresencia.Cod_Equipo
                                , oReportePresencia.Cod_Compania
                                , oReportePresencia.Cod_PtoVenta
                                , oReportePresencia.FechaRegistro
                                );
                            #endregion

                            #region Actualizar Estado PDV Nuevo en Intermedia
                            oCoon = new Conexion(3);
                            oCoon.ejecutarDataSet("SP_MOV_GES_OPE_ACTUALIZAR_ESTADO_PDV_NUEVO"
                                , oReportePresencia.Cod_Equipo
                                , oReportePresencia.Cod_Compania
                                , oReportePresencia.Cod_PtoVenta
                                , oReportePresencia.FechaRegistro
                                );
                            #endregion
                        }
  
                    }                       
                        
                }
                catch (Exception ex)
                {
                    //return "Ha ocurrido un Error, Consultar con Equipo de TI";
                    throw ex;
                }
            }

            private string Actualizar_Fase_PDVs_Con_Ventana_V_1_1(List<E_Reporte_Presencia_Mov> oListaReportes)
            {
                string Cod_Fase_v1 = string.Empty;
                try
                {
                    string ExistePeriodo = string.Empty;
                    
                    foreach (E_Reporte_Presencia_Mov Cabecera in oListaReportes)
                    {
                        //Colgate Bodega y Estado de Punto de Venta NI(No Implementado).
                        if (Cabecera.Cod_Equipo.Equals("012011092692011")
                            //&& string.IsNullOrEmpty(Cabecera.Fase)
                            //&& !Cabecera.Fase.Equals(null)
                            && Cabecera.Fase.Equals("NI")
                            && Cabecera.Cod_OpcionPresencia.Equals("3")
                        )
                        {
                            #region Actualizar Implementacion
                            //oCoon = new Conexion(3);
                            //string auxPeriodo = string.Empty;
                            //auxPeriodo = oCoon.ejecutarretornodeOUTPUT("TG_GES_OPE_DETERMINAR_PERIODO", 3
                            //,Cabecera.Cod_Equipo
                            //,Cabecera.Cod_PtoVenta
                            //,Cabecera.FechaRegistro
                            //,"");
                            //if (!auxPeriodo.Equals(""))
                            //{
                            //    ExistePeriodo = "";
                            foreach (E_Reporte_Presencia_Mov_Detalle Detalle in Cabecera.Detalle)
                            {
                                if (Detalle.Cod_MatApoyo.Equals("02"))
                                {
                                    #region Anterior código
                                    //oCoon = new Conexion(3);
                                    //oCoon.ejecutarDataTable("SP_GES_OPE_ACTUALIZAR_PTOVENTA_FASE_IMPLEMENTADO"
                                    //    , Cabecera.Cod_Persona
                                    //    , Cabecera.Cod_Equipo
                                    //    , Cabecera.Cod_Compania
                                    //    , Cabecera.Cod_PtoVenta
                                    //    , Cabecera.FechaRegistro
                                    //    , Cabecera.Latitud
                                    //    , Cabecera.Longitud
                                    //    , Cabecera.Origen
                                    //    );
                                    #endregion

                                    #region Actualiza Fase Implementación en Xplora
                                    oCoon = new Conexion(1);
                                    oCoon.ejecutarDataSet("SP_XPL_GES_OPE_ACTUALIZAR_FASE_IMPLEMENTADO"
                                    , Cabecera.Cod_Persona
                                    , Cabecera.Cod_Equipo
                                    , Cabecera.Cod_Compania
                                    , Cabecera.Cod_PtoVenta
                                    , Cabecera.FechaRegistro
                                    , Cabecera.Latitud
                                    , Cabecera.Longitud
                                    , Cabecera.Origen);
                                    #endregion

                                    #region Actualiza Fase Implementación en Intermedia
                                    oCoon = new Conexion(3);
                                    oCoon.ejecutarDataSet("SP_MOV_GES_OPE_ACTUALIZAR_FASE_IMPLEMENTADO"
                                    , Cabecera.Cod_Persona
                                    , Cabecera.Cod_Equipo
                                    , Cabecera.Cod_Compania
                                    , Cabecera.Cod_PtoVenta
                                    , Cabecera.FechaRegistro
                                    , Cabecera.Latitud
                                    , Cabecera.Longitud
                                    , Cabecera.Origen);

                                    #endregion

                                    Cod_Fase_v1 = "I";
                                }
                            }
                            //}
                            //else {
                            //    ExistePeriodo = "Debe existir un periodo previamente definido para poder Relevar Información. Consulte con su Supervisor antes de continuar.";
                            //}
                            #endregion
                        }
                        else if (
                           Cabecera.Cod_Equipo.Equals("012011092692011")
                           && Cabecera.Fase.Equals("NM")
                           )
                        {
                            #region Warning - En Ambos métodos falta Actualizar el PointOfSale_Planning Xplora e Intermedia.
                            //Actualizar a fase M los registros de Presencia y Elimina los MotivoFase por PtoVenta, Equipo y Periodo en BD Intermedia - BDLUCKYTMP
                            oCoon = new Conexion(3);
                            oCoon.ejecutarDataTable("SP_MOV_GES_OPE_ACTUALIZAR_FASE_MANTENIMIENTO", Cabecera.Cod_Equipo, Cabecera.Cod_PtoVenta, Cabecera.Cod_Persona);

                            //Actualizar a fase M los registros de Presencia y Elimina los MotivoFase por PtoVenta, Camapania y Periodo en Xplora - DBLUCKYPRD_BAK
                            oCoon = new Conexion(1);
                            oCoon.ejecutarDataTable("SP_XPL_GES_OPE_ACTUALIZAR_FASE_MANTENIMIENTO", Cabecera.Cod_Equipo, Cabecera.Cod_PtoVenta, Cabecera.Cod_Persona);
                            #endregion
                        }
                    }
                    //return ExistePeriodo;
                }
                catch (Exception ex)
                {
                    //return "Ha ocurrido un Error, Consultar con Equipo de TI";
                    throw ex;
                }
                return Cod_Fase_v1;
            }


            #region Registrar_Presencia_Mov_V_1_2 >>>> Warning <<<< Pendiente Probar.
            public E_Reporte_Presencia_Datos_Response Registrar_Presencia_Mov_V_1_2(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov, int AppEnvio)
            {
                E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
                
                List<E_CantReg_X_CodSubReporte> oListE_CantReg_X_CodSubReporte = new List<E_CantReg_X_CodSubReporte>();

                int Periodo_Definido = 1;

                string Msj_Usu = String.Empty;
                string Cod_PtoVta_Cliente = String.Empty;

                #region Contador Nuevos Registros

                int cnt_SubRep_Cmt_New = 0;
                int cnt_SubRep_VisCol_New = 0;
                int cnt_SubRep_VisCom_New = 0;
                int cnt_SubRep_PreCol_New = 0;
                int cnt_SubRep_PreCom_New = 0;
                int cnt_SubRep_StkCol_New = 0;
                int cnt_SubRep_StkCom_New = 0;
                int cnt_SubRep_Otros = 0;

                #endregion

                #region Contador Actualizaciones

                int cnt_SubRep_StkCom_Upd = 0;
                int cnt_SubRep_StkCol_Upd = 0;
                int cnt_SubRep_PreCom_Upd = 0;
                int cnt_SubRep_VisCol_Upd = 0;
                int cnt_SubRep_VisCom_Upd = 0;
                int cnt_SubRep_PreCol_Upd = 0;

                #endregion

                #region String Items Duplicados
                string str_Dupl_VisColgate = string.Empty;
                string str_Dupl_VisCompetencia = string.Empty;
                string str_Dupl_PresColgate = string.Empty;
                string str_Dupl_PresCompetencia = string.Empty;
                string str_Dupl_StockColgate = string.Empty;
                string str_Dupl_StockCompetencia = string.Empty;
                #endregion

                try
                {
                    string result = string.Empty;
                    foreach (E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov in oListE_Reporte_Presencia_Mov)
                    {
                        if (!string.IsNullOrEmpty(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia))
                        {
                            #region Validacion para SubRepporte que contienen Comentarios - Deshabilitada -
                            if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 8)
                            {
                                oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
                            }
                            #endregion
                            #region Validación para SubReportes que contienen Productos
                            else if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 4 ||
                                        Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 5 ||
                                        Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 13 ||
                                        Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 14)
                            {
                                #region E_Reporte_Presencia_Cab_Faltante
                                E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Faltantes = new E_Reporte_Presencia_Mov();
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Categoria = oE_Reporte_Presencia_Mov.Cod_Categoria;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Compania = oE_Reporte_Presencia_Mov.Cod_Compania;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Equipo = oE_Reporte_Presencia_Mov.Cod_Equipo;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Familia = oE_Reporte_Presencia_Mov.Cod_Familia;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Marca = oE_Reporte_Presencia_Mov.Cod_Marca;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_OpcionPresencia = oE_Reporte_Presencia_Mov.Cod_OpcionPresencia;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Persona = oE_Reporte_Presencia_Mov.Cod_Persona;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Presentacion = oE_Reporte_Presencia_Mov.Cod_Presentacion;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_PtoVenta = oE_Reporte_Presencia_Mov.Cod_PtoVenta;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_SubCategoria = oE_Reporte_Presencia_Mov.Cod_SubCategoria;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_SubFamilia = oE_Reporte_Presencia_Mov.Cod_SubFamilia;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_SubMarca = oE_Reporte_Presencia_Mov.Cod_SubMarca;
                                oE_Reporte_Presencia_Mov_Faltantes.Comentario = oE_Reporte_Presencia_Mov.Comentario;
                                oE_Reporte_Presencia_Mov_Faltantes.Fase = oE_Reporte_Presencia_Mov.Fase;
                                oE_Reporte_Presencia_Mov_Faltantes.FechaRegistro = oE_Reporte_Presencia_Mov.FechaRegistro;
                                oE_Reporte_Presencia_Mov_Faltantes.Latitud = oE_Reporte_Presencia_Mov.Latitud;
                                oE_Reporte_Presencia_Mov_Faltantes.Longitud = oE_Reporte_Presencia_Mov.Longitud;
                                oE_Reporte_Presencia_Mov_Faltantes.Nuevo = oE_Reporte_Presencia_Mov.Nuevo;
                                oE_Reporte_Presencia_Mov_Faltantes.Origen = oE_Reporte_Presencia_Mov.Origen;
                                #endregion

                                foreach (E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle in oE_Reporte_Presencia_Mov.Detalle)
                                {
                                    #region Validacion Duplicados Productos
                                    oCoon = new Conexion(1);
                                    DataSet ds = new DataSet();
                                    //result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_OBTENER_ID_DET_ITEMS_DUPLICADOS_PRESENCIA", 6,

                                    #region Backup 06/09/2012 PSalas
                                    //ds = oCoon.ejecutarDataSet("SP_GES_OPE_OBTENER_ID_DET_ITEMS_DUPLICADOS_PRESENCIA",
                                    //oE_Reporte_Presencia_Mov.Cod_Compania,
                                    //oE_Reporte_Presencia_Mov.Cod_Equipo,
                                    //oE_Reporte_Presencia_Mov.Cod_Persona,
                                    //oE_Reporte_Presencia_Mov.Cod_PtoVenta,
                                    //oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Trim(),
                                    //oE_Reporte_Presencia_Mov.FechaRegistro,
                                    //oE_Reporte_Presencia_Mov_Detalle.SKU_Producto);
                                    #endregion

                                    ds = oCoon.ejecutarDataSet("SP_GES_OPE_OBTENER_ID_DET_ITEMS_DUPLICADOS_PRESENCIA_V_1_1",
                                    oE_Reporte_Presencia_Mov.Cod_Compania,
                                    oE_Reporte_Presencia_Mov.Cod_Equipo.Trim(),
                                    oE_Reporte_Presencia_Mov.Cod_Persona,
                                    oE_Reporte_Presencia_Mov.Cod_PtoVenta.Trim(),
                                    oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Trim(),
                                    oE_Reporte_Presencia_Mov.FechaRegistro,
                                    oE_Reporte_Presencia_Mov_Detalle.SKU_Producto.Trim());



                                    result = ds.Tables[0].Rows[0][0].ToString();
                                    //result = ds.Tables[0].Columns["OUTPUT"].ToString();

                                    #endregion

                                    #region Actualizacion de Productos Existentes y Registro de Relevo Sin Periodo.
                                    //Faltantes respectivamente.

                                    if (result == "1")
                                    {
                                        //Guardar en Detalles los Productos Faltantes
                                        E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle_Faltantes = new E_Reporte_Presencia_Mov_Detalle();
                                        oE_Reporte_Presencia_Mov_Detalle_Faltantes = oE_Reporte_Presencia_Mov_Detalle;
                                        oE_Reporte_Presencia_Mov_Faltantes.Detalle.Add(oE_Reporte_Presencia_Mov_Detalle_Faltantes);
                                       

                                    }
                                    else if (result == "0")
                                    {
                                        //No existe Periodo Definido
                                        Periodo_Definido = 0;
                                        oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
                                        break;
                                    }
                                    else
                                    {
                                        //Data Duplicada -- Actualiza Segun Perfil

                                        #region Actualizar Registros Presencia Xpl e Inter
                                        //Author        : Pablo Salas A.
                                        //Fecha         : 27/08/2012
                                        //Descripcion   : Método Actualizar_Presencia_X_Perfil.

                                        if (ds.Tables[1].Columns.Count > 0)
                                        {
                                            foreach (DataRow row in ds.Tables[1].Rows)
                                            {
                                                //string x = row["ID"].ToString();
                                                #region Actualiza en Intermerdia
                                                Actualizar_Presencia_Mov_Por_Perfil(row["ID"].ToString()
                                                    , oE_Reporte_Presencia_Mov.Cod_Persona.ToString() ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Presencia ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Precio ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Num_Frentes ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Profundidad ?? null
                                                    , oE_Reporte_Presencia_Mov.Cod_OpcionPresencia ?? null);

                                                #endregion

                                                #region Actualiza en Xplora
                                                Actualizar_Presencia_Xpl_Por_Perfil(row["ID"].ToString()
                                                    , oE_Reporte_Presencia_Mov.Cod_Persona.ToString() ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Presencia ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Precio ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Num_Frentes ?? null
                                                    , oE_Reporte_Presencia_Mov_Detalle.Profundidad ?? null
                                                    , oE_Reporte_Presencia_Mov.Cod_OpcionPresencia ?? null);

                                                #endregion

                                                if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("4"))
                                                {
                                                    cnt_SubRep_PreCol_Upd += 1;
                                                }
                                                else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("5"))
                                                {
                                                    cnt_SubRep_PreCom_Upd += 1;
                                                }

                                            }
                                        }
                                        else {

                                            #region String con Id_Items Duplicados
                                                if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("3"))
                                                {
                                                    //str_Dupl_VisColgate += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine;
                                                    str_Dupl_VisColgate += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + ", ";
                                                }
                                                else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("4"))
                                                {
                                                    //str_Dupl_PresColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                                    str_Dupl_PresColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                                }
                                                else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("5"))
                                                {
                                                    //str_Dupl_PresCompetencia += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                                    str_Dupl_PresCompetencia += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                                }
                                                else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("6"))
                                                {
                                                    //str_Dupl_VisCompetencia += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine;
                                                    str_Dupl_VisCompetencia += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + ", ";
                                                }
                                                else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("13"))
                                                {
                                                    //str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                                    str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                                }
                                                else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("14"))
                                                {
                                                    //str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                                    str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                                }
                                            #endregion
                                        
                                        }

                                        #endregion

                                    }

                                    #endregion
                                }

                                #region Insertar SubReportes que Contienen Productos
                                    if (oE_Reporte_Presencia_Mov_Faltantes.Detalle.Count > 0)
                                    {
                                        oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov_Faltantes, AppEnvio));
                                    }
                                #endregion

                            }
                            #endregion
                            #region Validación para SubReportes que contienen Elementos de Vis.
                            else if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 3 ||
                                       Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 6)
                            {
                                #region E_Reporte_Presencia_Cab_Faltante

                                E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Faltantes = new E_Reporte_Presencia_Mov();
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Categoria = oE_Reporte_Presencia_Mov.Cod_Categoria;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Compania = oE_Reporte_Presencia_Mov.Cod_Compania;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Equipo = oE_Reporte_Presencia_Mov.Cod_Equipo;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Familia = oE_Reporte_Presencia_Mov.Cod_Familia;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Marca = oE_Reporte_Presencia_Mov.Cod_Marca;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_OpcionPresencia = oE_Reporte_Presencia_Mov.Cod_OpcionPresencia;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Persona = oE_Reporte_Presencia_Mov.Cod_Persona;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_Presentacion = oE_Reporte_Presencia_Mov.Cod_Presentacion;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_PtoVenta = oE_Reporte_Presencia_Mov.Cod_PtoVenta;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_SubCategoria = oE_Reporte_Presencia_Mov.Cod_SubCategoria;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_SubFamilia = oE_Reporte_Presencia_Mov.Cod_SubFamilia;
                                oE_Reporte_Presencia_Mov_Faltantes.Cod_SubMarca = oE_Reporte_Presencia_Mov.Cod_SubMarca;
                                oE_Reporte_Presencia_Mov_Faltantes.Comentario = oE_Reporte_Presencia_Mov.Comentario;
                                oE_Reporte_Presencia_Mov_Faltantes.Fase = oE_Reporte_Presencia_Mov.Fase;
                                oE_Reporte_Presencia_Mov_Faltantes.FechaRegistro = oE_Reporte_Presencia_Mov.FechaRegistro;
                                oE_Reporte_Presencia_Mov_Faltantes.Latitud = oE_Reporte_Presencia_Mov.Latitud;
                                oE_Reporte_Presencia_Mov_Faltantes.Longitud = oE_Reporte_Presencia_Mov.Longitud;
                                oE_Reporte_Presencia_Mov_Faltantes.Nuevo = oE_Reporte_Presencia_Mov.Nuevo;
                                oE_Reporte_Presencia_Mov_Faltantes.Origen = oE_Reporte_Presencia_Mov.Origen;
                                #endregion

                                foreach (E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle in oE_Reporte_Presencia_Mov.Detalle)
                                {
                                    #region Validacion Duplicados Elementos de Vis.

                                    oCoon = new Conexion(1);
                                    result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
                                    oE_Reporte_Presencia_Mov.Cod_Compania,
                                    oE_Reporte_Presencia_Mov.Cod_Equipo.Trim(),
                                    oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Trim(),
                                    oE_Reporte_Presencia_Mov.Cod_PtoVenta.Trim(),
                                    oE_Reporte_Presencia_Mov.FechaRegistro,
                                    oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo.Trim(), "");

                                    #endregion

                                    #region Actualizacion e Inserción de Elementos de Vis. Existentes y Faltantes respectivamente.

                                    if (result == "1")
                                    {
                                        //Registrar Informacion Faltante
                                        E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle_Faltantes = new E_Reporte_Presencia_Mov_Detalle();
                                        oE_Reporte_Presencia_Mov_Detalle_Faltantes = oE_Reporte_Presencia_Mov_Detalle;
                                        oE_Reporte_Presencia_Mov_Faltantes.Detalle.Add(oE_Reporte_Presencia_Mov_Detalle_Faltantes);

                                    }
                                    else if (result == "0")
                                    {
                                        //No existe Periodo Definido
                                        Periodo_Definido = 0;
                                        oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
                                        break;

                                    }
                                    else
                                    {
                                        //Data Duplicada -- Actualiza Segun Perfil
                                        //Author        : Pablo Salas A.
                                        //Fecha         : 27/08/2012
                                        //Descripcion   : Método Actualizar_Presencia_X_Perfil.

                                        #region String con Id_Items Duplicados
                                        if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("3"))
                                        {
                                            str_Dupl_VisColgate += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + ", ";
                                            //str_Dupl_VisColgate += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine;
                                        }
                                        else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("4"))
                                        {
                                            str_Dupl_PresColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                            //str_Dupl_PresColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                        }
                                        else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("5"))
                                        {
                                            str_Dupl_PresCompetencia += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                            //str_Dupl_PresCompetencia += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                        }
                                        else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("6"))
                                        {
                                            str_Dupl_VisCompetencia += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + ", ";
                                            //str_Dupl_VisCompetencia += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine;
                                        }
                                        else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("13"))
                                        {
                                            str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                            //str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                        }
                                        else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("14"))
                                        {
                                            str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + ", ";
                                            //str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
                                        }
                                        #endregion

                                    }
                                    #endregion
                                }

                                #region Insertar SubReportes que Contienen Elementos de Visibilidad
                                if (oE_Reporte_Presencia_Mov_Faltantes.Detalle.Count > 0)
                                {
                                    oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov_Faltantes, AppEnvio));
                                }
                                #endregion
                            }
                            #endregion
                            #region Validacion para SubReportes que contienen Otros Tipo de Relevo - Deshabilitado -
                            else
                            {
                                //Sub Reporte Sin Control de Duplicados
                                oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
                            }
                            #endregion
                        }
                        else
                        {
                            oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
                        }

                        Cod_PtoVta_Cliente = oE_Reporte_Presencia_Mov.Cod_PtoVenta;
                    }

                    foreach (E_CantReg_X_CodSubReporte oE_CantReg_X_CodSubReporte in oListE_CantReg_X_CodSubReporte)
                    {
                        switch (oE_CantReg_X_CodSubReporte.Cod_SubReporte)
                        {
                            case "3": cnt_SubRep_VisCol_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
                                break;
                            case "6": cnt_SubRep_VisCom_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
                                break;
                            case "4": cnt_SubRep_PreCol_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
                                break;
                            case "5": cnt_SubRep_PreCom_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
                                break;
                            case "13": cnt_SubRep_StkCol_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
                                break;
                            case "14": cnt_SubRep_StkCom_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
                                break;
                            default: cnt_SubRep_Otros += oE_CantReg_X_CodSubReporte.Cant_Registros;
                                break;
                            
                        }
                    }

                    #region Mensaje al Usuario
                    ////Pendiente Agregar Mensaje de Periodo pendiente.
                    string periodo_Estado_txt = String.Empty;
                    if (Periodo_Definido.Equals(0))
                    {
                        periodo_Estado_txt = "---Advertencia---" + Environment.NewLine
                        + "No se ha definido Periodo para la Fecha de Relevo, Consulte con su Supervisor !";
                    }
                    else
                    {
                        periodo_Estado_txt = "OK" + Environment.NewLine
                            + "El Periodo de relevo OK!";
                    }

                    String str_Dupl = String.Empty;
                    #region Str - Duplicados
                        if (!string.IsNullOrEmpty(str_Dupl_VisColgate))
                        {
                            str_Dupl += "- Vis.Colgate: " + str_Dupl_VisColgate.Substring(0, str_Dupl_VisColgate.Length - 2) + "." + Environment.NewLine;
                        }
                        if (!string.IsNullOrEmpty(str_Dupl_VisCompetencia))
                        {
                            str_Dupl += "- Vis.Competencia: " + str_Dupl_VisCompetencia.Substring(0, str_Dupl_VisCompetencia.Length - 2) + "." + Environment.NewLine;
                        }
                        if (!string.IsNullOrEmpty(str_Dupl_PresColgate))
                        {
                            str_Dupl += "- Pres.Colgate: " + str_Dupl_PresColgate.Substring(0, str_Dupl_PresColgate.Length - 2) + "." + Environment.NewLine;
                        }
                        if (!string.IsNullOrEmpty(str_Dupl_PresCompetencia))
                        {
                            str_Dupl += " - Pres.Competencia: " + str_Dupl_PresCompetencia.Substring(0, str_Dupl_PresCompetencia.Length - 2) + "." + Environment.NewLine;
                        }
                        if (!string.IsNullOrEmpty(str_Dupl_StockColgate))
                        {
                            str_Dupl += "-  Stock.Colgate: " + str_Dupl_StockColgate.Substring(0, str_Dupl_StockColgate.Length - 2) + "." + Environment.NewLine;
                        }
                        if (!string.IsNullOrEmpty(str_Dupl_StockCompetencia))
                        {
                            str_Dupl += "- Stock.Competencia: " + str_Dupl_StockCompetencia.Substring(0, str_Dupl_StockCompetencia.Length - 2) + "." + Environment.NewLine;
                        }
                    #endregion

                    Msj_Usu =
                        "**********************" + Environment.NewLine
                        + "Estado del Periodo de Relevo " + Environment.NewLine
                        + "********************" + Environment.NewLine
                        + periodo_Estado_txt + Environment.NewLine
                        + "*********************" + Environment.NewLine
                        + "Se relevó con Éxito :" + Environment.NewLine
                        + "*********************" + Environment.NewLine
                        + cnt_SubRep_VisCol_New + " Elem. Vis.Colgate" + Environment.NewLine
                        + cnt_SubRep_VisCom_New + " Elem. Vis.Competencia" + Environment.NewLine
                        + cnt_SubRep_PreCol_New + " Prod. Pres.Colgate" + Environment.NewLine
                        + cnt_SubRep_PreCom_New + " Prod. Pres.Competencia" + Environment.NewLine
                        + cnt_SubRep_StkCol_New + " Prod. Stock.Colgate" + Environment.NewLine
                        + cnt_SubRep_StkCom_New + " Prod. Stock.Competencia" + Environment.NewLine
                        + cnt_SubRep_Cmt_New + " Comentarios y/o Notas" + Environment.NewLine
                        + cnt_SubRep_Otros + " Otros SubReportes" + Environment.NewLine
                        + "*********************" + Environment.NewLine
                        + "Se Actualizaron con Éxito:" + Environment.NewLine
                        + "*********************" + Environment.NewLine
                        //+ cnt_SubRep_VisCol_Upd + " Elem. Vis.Colgate" + Environment.NewLine
                        //+ cnt_SubRep_VisCom_Upd + " Elem. Vis.Competencia" + Environment.NewLine
                        + cnt_SubRep_PreCol_Upd + " Prod. Pres.Colgate" + Environment.NewLine
                        + cnt_SubRep_PreCom_Upd + " Prod. Pres.Competencia" + Environment.NewLine
                        //+ cnt_SubRep_StkCol_Upd + " Prod. Stock.Colgate" + Environment.NewLine
                        //+ cnt_SubRep_StkCom_Upd + " Prod. Stock.Competencia" + Environment.NewLine;
                        + "**********************" + Environment.NewLine
                        + "Se encontró Items Duplicados para:" + Environment.NewLine
                        + "**********************" + Environment.NewLine
                        + str_Dupl;

                    

                    //+ str_Dupl_VisColgate + " para Vis.Colgate" + Environment.NewLine
                        //+ str_Dupl_VisCompetencia + " para Vis.Competencia" + Environment.NewLine
                        //+ str_Dupl_PresColgate + " para Pres.Colgate" + Environment.NewLine
                        //+ str_Dupl_PresCompetencia + " para Pres.Competencia" + Environment.NewLine
                        //+ str_Dupl_StockColgate + " para Stock.Colgate" + Environment.NewLine
                        //+ str_Dupl_StockCompetencia + " para Stock.Competencia" + Environment.NewLine;

                   

                    #endregion
                }
                catch (Exception ex)
                {
                    Msj_Usu = "Error Consulta con el Equipo de TI";
                    throw ex;
                }

                //return Msj_Usu;
                
                oE_Reporte_Presencia_Datos_Response.MensajeUsuario = Msj_Usu;
                oE_Reporte_Presencia_Datos_Response.CodPtoVenta = Cod_PtoVta_Cliente;
                oE_Reporte_Presencia_Datos_Response.FasePtoVenta = Actualizar_Fase_PDVs_Con_Ventana_V_1_1(oListE_Reporte_Presencia_Mov);//Add 11/06/2012 PSA
                Actualizar_Estado_Pdv_Nuevo(oListE_Reporte_Presencia_Mov); //Add 22/07/2012 PSA

                return oE_Reporte_Presencia_Datos_Response;
            }
            #endregion

            #region Registrar_Presencia_Mov_V_1_1 >>>> Warning <<<< Backup.
            //public string Registrar_Presencia_Mov_V_1_1(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov, int AppEnvio)
            //{
            //    List<E_CantReg_X_CodSubReporte> oListE_CantReg_X_CodSubReporte = new List<E_CantReg_X_CodSubReporte>();

            //    int Periodo_Definido = 1;

            //    string Msj_Usu = String.Empty;

            //    #region Contador Nuevos Registros

            //    int cnt_SubRep_Cmt_New = 0;
            //    int cnt_SubRep_VisCol_New = 0;
            //    int cnt_SubRep_VisCom_New = 0;
            //    int cnt_SubRep_PreCol_New = 0;
            //    int cnt_SubRep_PreCom_New = 0;
            //    int cnt_SubRep_StkCol_New = 0;
            //    int cnt_SubRep_StkCom_New = 0;
            //    int cnt_SubRep_Otros = 0;

            //    #endregion

            //    #region Contador Actualizaciones

            //    int cnt_SubRep_StkCom_Upd = 0;
            //    int cnt_SubRep_StkCol_Upd = 0;
            //    int cnt_SubRep_PreCom_Upd = 0;
            //    int cnt_SubRep_VisCol_Upd = 0;
            //    int cnt_SubRep_VisCom_Upd = 0;
            //    int cnt_SubRep_PreCol_Upd = 0;

            //    #endregion

            //    #region String Items Duplicados
            //    string str_Dupl_VisColgate = string.Empty;
            //    string str_Dupl_VisCompetencia = string.Empty;
            //    string str_Dupl_PresColgate = string.Empty;
            //    string str_Dupl_PresCompetencia = string.Empty;
            //    string str_Dupl_StockColgate = string.Empty;
            //    string str_Dupl_StockCompetencia = string.Empty;
            //    #endregion

            //    try
            //    {
            //        string result = string.Empty;
            //        foreach (E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov in oListE_Reporte_Presencia_Mov)
            //        {
            //            if (!string.IsNullOrEmpty(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia))
            //            {
            //                #region Validacion para SubRepporte que contienen Comentarios - Deshabilitada -
            //                if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 8)
            //                {
            //                    oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
            //                }
            //                #endregion
            //                #region Validación para SubReportes que contienen Productos
            //                else if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 4 ||
            //                            Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 5 ||
            //                            Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 13 ||
            //                            Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 14)
            //                {
            //                    #region E_Reporte_Presencia_Cab_Faltante
            //                    E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Faltantes = new E_Reporte_Presencia_Mov();
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Categoria = oE_Reporte_Presencia_Mov.Cod_Categoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Compania = oE_Reporte_Presencia_Mov.Cod_Compania;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Equipo = oE_Reporte_Presencia_Mov.Cod_Equipo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Familia = oE_Reporte_Presencia_Mov.Cod_Familia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Marca = oE_Reporte_Presencia_Mov.Cod_Marca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_OpcionPresencia = oE_Reporte_Presencia_Mov.Cod_OpcionPresencia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Persona = oE_Reporte_Presencia_Mov.Cod_Persona;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Presentacion = oE_Reporte_Presencia_Mov.Cod_Presentacion;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_PtoVenta = oE_Reporte_Presencia_Mov.Cod_PtoVenta;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubCategoria = oE_Reporte_Presencia_Mov.Cod_SubCategoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubFamilia = oE_Reporte_Presencia_Mov.Cod_SubFamilia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubMarca = oE_Reporte_Presencia_Mov.Cod_SubMarca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Comentario = oE_Reporte_Presencia_Mov.Comentario;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Fase = oE_Reporte_Presencia_Mov.Fase;
            //                    oE_Reporte_Presencia_Mov_Faltantes.FechaRegistro = oE_Reporte_Presencia_Mov.FechaRegistro;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Latitud = oE_Reporte_Presencia_Mov.Latitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Longitud = oE_Reporte_Presencia_Mov.Longitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Nuevo = oE_Reporte_Presencia_Mov.Nuevo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Origen = oE_Reporte_Presencia_Mov.Origen;
            //                    #endregion

            //                    foreach (E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle in oE_Reporte_Presencia_Mov.Detalle)
            //                    {
            //                        #region Validacion Duplicados Productos
            //                        oCoon = new Conexion(1);
            //                        DataSet ds = new DataSet();
            //                        //result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_OBTENER_ID_DET_ITEMS_DUPLICADOS_PRESENCIA", 6,
            //                        ds = oCoon.ejecutarDataSet("SP_GES_OPE_OBTENER_ID_DET_ITEMS_DUPLICADOS_PRESENCIA",
            //                        oE_Reporte_Presencia_Mov.Cod_Compania,
            //                        oE_Reporte_Presencia_Mov.Cod_Equipo,
            //                        oE_Reporte_Presencia_Mov.Cod_Persona,
            //                        oE_Reporte_Presencia_Mov.Cod_PtoVenta,
            //                        oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Trim(),
            //                        oE_Reporte_Presencia_Mov.FechaRegistro,
            //                        oE_Reporte_Presencia_Mov_Detalle.SKU_Producto);

            //                        result = ds.Tables[0].Columns["OUTPUT"].ToString();
                                    
            //                        #endregion

            //                        #region Actualizacion e Inserción de Productos Existentes y Faltantes respectivamente.

            //                        if (result == "1")
            //                        {
            //                            //Guardar en Detalles los Productos Faltantes
            //                            E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle_Faltantes = new E_Reporte_Presencia_Mov_Detalle();
            //                            oE_Reporte_Presencia_Mov_Detalle_Faltantes = oE_Reporte_Presencia_Mov_Detalle;
            //                            oE_Reporte_Presencia_Mov_Faltantes.Detalle.Add(oE_Reporte_Presencia_Mov_Detalle_Faltantes);

            //                        }
            //                        else if (result == "0")
            //                        {
            //                            //No existe Periodo Definido
            //                            Periodo_Definido = 0;
            //                            oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
            //                            break;
            //                        }
            //                        else
            //                        {
            //                            //Data Duplicada -- Actualiza Segun Perfil

            //                            #region Actualizar Registros Presencia Xpl e Inter
            //                            //Author        : Pablo Salas A.
            //                            //Fecha         : 27/08/2012
            //                            //Descripcion   : Método Actualizar_Presencia_X_Perfil.
                                        
            //                            if (ds.Tables[1].Columns.Count > 0) {
            //                                foreach (DataRow row in ds.Tables[1].Rows)
            //                                {

            //                                    #region Actualiza en Intermerdia
            //                                    Actualizar_Presencia_Mov_Por_Perfil(row["ID"].ToString()
            //                                        , oE_Reporte_Presencia_Mov.Cod_Persona.ToString() ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Presencia ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Precio ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Num_Frentes ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Profundidad ?? null
            //                                        , oE_Reporte_Presencia_Mov.Cod_OpcionPresencia ?? null);

            //                                    #endregion

            //                                    #region Actualiza en Xplora
            //                                    Actualizar_Presencia_Xpl_Por_Perfil(row["ID"].ToString()
            //                                        , oE_Reporte_Presencia_Mov.Cod_Persona.ToString() ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Presencia ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Precio ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Num_Frentes ?? null
            //                                        , oE_Reporte_Presencia_Mov_Detalle.Profundidad ?? null
            //                                        , oE_Reporte_Presencia_Mov.Cod_OpcionPresencia ?? null);

            //                                    #endregion


            //                                    if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("4"))
            //                                    {
            //                                        cnt_SubRep_StkCol_Upd += 1;
            //                                    }
            //                                    else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("5"))
            //                                    {
            //                                        cnt_SubRep_StkCom_Upd += 1;
            //                                    }
                                                      
            //                                }
            //                            }
            //                            #endregion

            //                            #region String con Id_Items Duplicados
            //                            if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("3")){
            //                                str_Dupl_VisColgate += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine;
            //                            }else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("4")){
            //                                str_Dupl_PresColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
            //                            }else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("5")){
            //                                str_Dupl_PresCompetencia += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
            //                            }else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("6")){
            //                                str_Dupl_VisCompetencia += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine; 
            //                            }else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("13")){
            //                                str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine; 
            //                            }else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("14")){
            //                                str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
            //                            }
            //                            #endregion
            //                        }

            //                        if (oE_Reporte_Presencia_Mov_Faltantes.Detalle.Count > 0)
            //                        {
            //                            oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov_Faltantes, AppEnvio));
            //                        }

            //                        #endregion
            //                    }

            //                }
            //                #endregion
            //                #region Validación para SubReportes que contienen Elementos de Vis.
            //                else if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 3 ||
            //                           Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 6)
            //                {
            //                    #region E_Reporte_Presencia_Cab_Faltante

            //                    E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Faltantes = new E_Reporte_Presencia_Mov();
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Categoria = oE_Reporte_Presencia_Mov.Cod_Categoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Compania = oE_Reporte_Presencia_Mov.Cod_Compania;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Equipo = oE_Reporte_Presencia_Mov.Cod_Equipo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Familia = oE_Reporte_Presencia_Mov.Cod_Familia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Marca = oE_Reporte_Presencia_Mov.Cod_Marca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_OpcionPresencia = oE_Reporte_Presencia_Mov.Cod_OpcionPresencia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Persona = oE_Reporte_Presencia_Mov.Cod_Persona;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Presentacion = oE_Reporte_Presencia_Mov.Cod_Presentacion;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_PtoVenta = oE_Reporte_Presencia_Mov.Cod_PtoVenta;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubCategoria = oE_Reporte_Presencia_Mov.Cod_SubCategoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubFamilia = oE_Reporte_Presencia_Mov.Cod_SubFamilia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubMarca = oE_Reporte_Presencia_Mov.Cod_SubMarca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Comentario = oE_Reporte_Presencia_Mov.Comentario;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Fase = oE_Reporte_Presencia_Mov.Fase;
            //                    oE_Reporte_Presencia_Mov_Faltantes.FechaRegistro = oE_Reporte_Presencia_Mov.FechaRegistro;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Latitud = oE_Reporte_Presencia_Mov.Latitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Longitud = oE_Reporte_Presencia_Mov.Longitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Nuevo = oE_Reporte_Presencia_Mov.Nuevo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Origen = oE_Reporte_Presencia_Mov.Origen;
            //                    #endregion

            //                    foreach (E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle in oE_Reporte_Presencia_Mov.Detalle)
            //                    {
            //                        #region Validacion Duplicados Elementos de Vis.

            //                        oCoon = new Conexion(1);
            //                        result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
            //                        oE_Reporte_Presencia_Mov.Cod_Compania,
            //                        oE_Reporte_Presencia_Mov.Cod_Equipo,
            //                        oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Trim(),
            //                        oE_Reporte_Presencia_Mov.Cod_PtoVenta,
            //                        oE_Reporte_Presencia_Mov.FechaRegistro,
            //                        oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo, "");

            //                        #endregion

            //                        #region Actualizacion e Inserción de Elementos de Vis. Existentes y Faltantes respectivamente.

            //                        if (result == "1")
            //                        {
            //                            //Registrar Informacion Faltante
            //                            E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle_Faltantes = new E_Reporte_Presencia_Mov_Detalle();
            //                            oE_Reporte_Presencia_Mov_Detalle_Faltantes = oE_Reporte_Presencia_Mov_Detalle;
            //                            oE_Reporte_Presencia_Mov_Faltantes.Detalle.Add(oE_Reporte_Presencia_Mov_Detalle_Faltantes);

            //                        }
            //                        else if (result == "0")
            //                        {
            //                            //No existe Periodo Definido
            //                            Periodo_Definido = 0;
            //                            oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
            //                            break;

            //                        }
            //                        else
            //                        {
            //                            //Data Duplicada -- Actualiza Segun Perfil
            //                            //Author        : Pablo Salas A.
            //                            //Fecha         : 27/08/2012
            //                            //Descripcion   : Método Actualizar_Presencia_X_Perfil.

            //                            #region String con Id_Items Duplicados 
            //                            if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("3"))
            //                            {
            //                                str_Dupl_VisColgate += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine;
            //                            }
            //                            else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("4"))
            //                            {
            //                                str_Dupl_PresColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
            //                            }
            //                            else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("5"))
            //                            {
            //                                str_Dupl_PresCompetencia += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
            //                            }
            //                            else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("6"))
            //                            {
            //                                str_Dupl_VisCompetencia += oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo + Environment.NewLine;
            //                            }
            //                            else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("13"))
            //                            {
            //                                str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
            //                            }
            //                            else if (oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Equals("14"))
            //                            {
            //                                str_Dupl_StockColgate += oE_Reporte_Presencia_Mov_Detalle.SKU_Producto + Environment.NewLine;
            //                            }
            //                            #endregion

            //                        }


            //                        if (oE_Reporte_Presencia_Mov_Faltantes.Detalle.Count > 0)
            //                        {
            //                            oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov_Faltantes, AppEnvio));
            //                        }
            //                        #endregion
            //                    }

            //                }
            //                #endregion
            //                #region Validacion para SubReportes que contienen Otros Tipo de Relevo - Deshabilitado -
            //                else
            //                {
            //                    //Sub Reporte Sin Control de Duplicados
            //                    oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
            //                }
            //                #endregion
            //            }
            //            else
            //            {
            //                oListE_CantReg_X_CodSubReporte.Add(Registrar_Presencia_Mov_Cabecera_V_1_1(oE_Reporte_Presencia_Mov, AppEnvio));
            //            }
            //        }

            //        foreach (E_CantReg_X_CodSubReporte oE_CantReg_X_CodSubReporte in oListE_CantReg_X_CodSubReporte)
            //        {
            //            switch (oE_CantReg_X_CodSubReporte.Cod_SubReporte)
            //            {
            //                case "3": cnt_SubRep_VisCol_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
            //                    break;
            //                case "6": cnt_SubRep_VisCom_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
            //                    break;
            //                case "4": cnt_SubRep_PreCol_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
            //                    break;
            //                case "5": cnt_SubRep_PreCom_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
            //                    break;
            //                case "13": cnt_SubRep_StkCol_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
            //                    break;
            //                case "14": cnt_SubRep_StkCom_New += oE_CantReg_X_CodSubReporte.Cant_Registros;
            //                    break;
            //            }
            //        }

            //        #region Mensaje al Usuario
            //        ////Pendiente Agregar Mensaje de Periodo pendiente.
            //        string periodo_Estado_txt = String.Empty;
            //        if (Periodo_Definido.Equals(0))
            //        {
            //            periodo_Estado_txt = ">>>Advertencia<<<" + Environment.NewLine
            //            + "No se ha definido Periodo para la Fecha de Relevo, Consulte con su Supervisor !";
            //        }
            //        else {
            //            periodo_Estado_txt = ">>OK<<" + Environment.NewLine
            //                + "El Periodo de relevo OK!";
            //        }

            //        Msj_Usu =
            //            "***************************" + Environment.NewLine
            //            + "Estado del Periodo de Relevo " + Environment.NewLine
            //            + "***************************" + Environment.NewLine
            //            + periodo_Estado_txt + Environment.NewLine
            //            + "***************************" + Environment.NewLine
            //            + "Se relevó con Éxito :" + Environment.NewLine
            //            + "***************************" + Environment.NewLine
            //            + cnt_SubRep_VisCol_New + " Elem. Vis.Colgate" + Environment.NewLine
            //            + cnt_SubRep_VisCom_New + " Elem. Vis.Competencia" + Environment.NewLine
            //            + cnt_SubRep_PreCol_New + " Prod. Pres.Colgate" + Environment.NewLine
            //            + cnt_SubRep_PreCom_New + " Prod. Pres.Competencia" + Environment.NewLine
            //            + cnt_SubRep_StkCol_New + " Prod. Stock.Colgate" + Environment.NewLine
            //            + cnt_SubRep_StkCom_New + " Prod. Stock.Competencia" + Environment.NewLine
            //            + cnt_SubRep_Cmt_New + " Comentarios y/o Notas" + Environment.NewLine
            //            + cnt_SubRep_Otros + " Otros SubReportes" + Environment.NewLine
            //            + "***************************" + Environment.NewLine
            //            + "Se Actualizaron con Éxito:" + Environment.NewLine
            //            + "***************************" + Environment.NewLine
            //            //+ cnt_SubRep_VisCol_Upd + " Elem. Vis.Colgate" + Environment.NewLine
            //            //+ cnt_SubRep_VisCom_Upd + " Elem. Vis.Competencia" + Environment.NewLine
            //            + cnt_SubRep_PreCol_Upd + " Prod. Pres.Colgate" + Environment.NewLine
            //            + cnt_SubRep_PreCom_Upd + " Prod. Pres.Competencia" + Environment.NewLine
            //            //+ cnt_SubRep_StkCol_Upd + " Prod. Stock.Colgate" + Environment.NewLine
            //            //+ cnt_SubRep_StkCom_Upd + " Prod. Stock.Competencia" + Environment.NewLine;
            //            + "***************************" + Environment.NewLine
            //            + "Se encontró los Items Duplicados de:" + Environment.NewLine
            //            + "***************************" + Environment.NewLine
            //            + str_Dupl_VisColgate + " para Vis.Colgate" + Environment.NewLine
            //            + str_Dupl_VisCompetencia + " para Vis.Competencia" + Environment.NewLine
            //            + str_Dupl_PresColgate + " para Pres.Colgate" + Environment.NewLine
            //            + str_Dupl_PresCompetencia + " para Pres.Competencia" + Environment.NewLine
            //            + str_Dupl_StockColgate + " para Stock.Colgate" + Environment.NewLine
            //            + str_Dupl_StockCompetencia + " para Stock.Competencia" + Environment.NewLine;
            //        #endregion
            //    }
            //    catch (Exception ex)
            //    {
            //        Msj_Usu = "Error Consulta con el Equipo de TI";
            //        throw ex;
            //    }

            //    return Msj_Usu;
            //}
            #endregion

            //#region Clase Auxiliar para Cantidad de Registros X CodSubReporte . Fecha:25/08/2012. Author: Pablo Salas A.
            //class E_CantReg_X_CodSubReporte{
            //public string Cod_SubReporte { get; set; }
            //public int Cant_Registros { get; set; }
            //}
            //#endregion

            private E_CantReg_X_CodSubReporte Registrar_Presencia_Mov_Cabecera_V_1_1(E_Reporte_Presencia_Mov oEReportePresencia, int AppEnvio)
            {

                E_CantReg_X_CodSubReporte oE_CantReg_X_CodSubReporte = new E_CantReg_X_CodSubReporte();
                oE_CantReg_X_CodSubReporte.Cod_SubReporte = oEReportePresencia.Cod_OpcionPresencia.ToString();
                oE_CantReg_X_CodSubReporte.Cant_Registros = 0;

                try
                {
                    string id_reg_Presencia = "";
                    oCoon = new Conexion(3);

                    id_reg_Presencia = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_PRESENCIA", 15,
                    oEReportePresencia.Cod_Persona, oEReportePresencia.Cod_Equipo,
                    oEReportePresencia.Cod_Compania, oEReportePresencia.Cod_PtoVenta,
                    oEReportePresencia.Cod_Categoria, oEReportePresencia.Cod_Marca,
                    oEReportePresencia.Cod_OpcionPresencia, oEReportePresencia.FechaRegistro,
                    oEReportePresencia.Latitud ?? null, oEReportePresencia.Longitud ?? null,
                    oEReportePresencia.Origen ?? null, oEReportePresencia.Comentario ?? null,
                    AppEnvio, oEReportePresencia.Fase ?? null, oEReportePresencia.Nuevo ?? "0", id_reg_Presencia);
                    foreach (E_Reporte_Presencia_Mov_Detalle detalle in oEReportePresencia.Detalle)
                    {
                        Registrar_Presencia_Mov_Detalle_V_1_1(detalle, id_reg_Presencia);
                        oE_CantReg_X_CodSubReporte.Cant_Registros += 1;
                    }

                    #region Validacion Especial para SubReporte 8 - Comentarios 06/09/2012 PSalas
                    if (!string.IsNullOrEmpty(oEReportePresencia.Cod_OpcionPresencia)){
                        if (Convert.ToInt32(oEReportePresencia.Cod_OpcionPresencia.ToString()) == 8)
                        {
                            oE_CantReg_X_CodSubReporte.Cant_Registros += 1;
                        }
                    }    
                    #endregion
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return oE_CantReg_X_CodSubReporte;
            }

            private void Registrar_Presencia_Mov_Detalle_V_1_1(E_Reporte_Presencia_Mov_Detalle detalle, string Id_Reg_Presencia)
            {
                oCoon = new Conexion(3);
                E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Detalle = new E_Reporte_Presencia_Mov_Detalle();
                try
                {
                    oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_PRESENCIA_DETALLE",
                    Convert.ToInt64(Id_Reg_Presencia), detalle.Cod_MatApoyo ?? null, detalle.Valor_MatApoyo ?? null,
                    detalle.SKU_Producto ?? null, detalle.Precio ?? null, detalle.Stock ?? null,
                    detalle.Cod_Observacion ?? null, detalle.Observacion ?? null,
                    detalle.Cantidad ?? null, detalle.Num_Frentes ?? null,
                    detalle.Profundidad ?? null, detalle.Pedido_Sugerido ?? null,
                    detalle.Presencia ?? null, detalle.Cumple_Layout ?? null,
                    detalle.Cod_Ubicacion ?? null, detalle.Cod_Posicion ?? null,
                    detalle.Cod_Cluster ?? null, detalle.Valor_Cluster ?? null);

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            
            /// <summary>
            /// >>>>Actualiza Presencia en Intermedia<<<<
            /// Author  : Pablo Salas A.
            /// Fecha   : 27/08/2012
            /// Descripcion : Actualizar la Presencia Detalle Por Perfil
            /// </summary>
            /// <param name="Id_Detalle"></param>
            /// <param name="Id_Persona"></param>
            /// <returns></returns>
            private void Actualizar_Presencia_Mov_Por_Perfil(string Id_Detalle
                , string Id_Persona, string Val_Presencia, string Val_Precio, string Val_NumFrentes
                , string Val_Profundidad, string Cod_SubReporte) {

                    
                    try
                    {
                        oCoon = new Conexion(3);
                        oCoon.ejecutarSinRetorno("SP_Mov_GES_OPE_ACTUALIZAR_PRESENCIA", Id_Detalle
                            , Id_Persona
                            , Val_Presencia
                            , Val_Precio
                            , Val_NumFrentes
                            , Val_Profundidad);

                    }
                    catch (Exception ex) {
                        throw ex;
                    }
            }

            /// <summary>
            /// >>>>Actualiza Presencia en Xplora<<<<
            /// Author  : Pablo Salas A.
            /// Fecha   : 27/08/2012
            /// Descripcion : Actualizar la Presencia Detalle Por Perfil
            /// </summary>
            /// <param name="Id_Detalle"></param>
            /// <param name="Id_Persona"></param>
            /// <returns></returns>
            private void Actualizar_Presencia_Xpl_Por_Perfil(string Id_Detalle
                , string Id_Persona, string Val_Presencia, string Val_Precio, string Val_NumFrentes
                , string Val_Profundidad, string Cod_SubReporte) {
                    try {
                        oCoon = new Conexion(1);
                        oCoon.ejecutarSinRetorno("SP_Xpl_GES_OPE_ACTUALIZAR_PRESENCIA", Id_Detalle
                            , Id_Persona
                            , Val_Presencia
                            , Val_Precio
                            , Val_NumFrentes
                            , Val_Profundidad);
                    }
                    catch(Exception ex) {
                        throw ex;
                    }
            }


        #region Bak_25082012_Registrar_Presencia_Mov_V_1_1
        //private string Registrar_Presencia_Mov_V_1_1(List<E_Reporte_Presencia_Mov> oListE_Reporte_Presencia_Mov,int AppEnvio) {
            //    try {
            //        string result = string.Empty;
            //        foreach (E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov in oListE_Reporte_Presencia_Mov) {
            //            if (!string.IsNullOrEmpty(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia)) {
            //                if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 8)
            //                {
            //                    Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov, AppEnvio);
            //                    break;
            //                }
            //                else if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 4 ||
            //                            Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 5 ||
            //                            Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 13 ||
            //                            Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 14)
            //                {

            //                    E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Faltantes = new E_Reporte_Presencia_Mov();
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Categoria = oE_Reporte_Presencia_Mov.Cod_Categoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Compania=oE_Reporte_Presencia_Mov.Cod_Compania;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Equipo=oE_Reporte_Presencia_Mov.Cod_Equipo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Familia=oE_Reporte_Presencia_Mov.Cod_Familia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Marca=oE_Reporte_Presencia_Mov.Cod_Marca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_OpcionPresencia=oE_Reporte_Presencia_Mov.Cod_OpcionPresencia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Persona=oE_Reporte_Presencia_Mov.Cod_Persona;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Presentacion=oE_Reporte_Presencia_Mov.Cod_Presentacion;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_PtoVenta=oE_Reporte_Presencia_Mov.Cod_PtoVenta;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubCategoria=oE_Reporte_Presencia_Mov.Cod_SubCategoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubFamilia=oE_Reporte_Presencia_Mov.Cod_SubFamilia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubMarca=oE_Reporte_Presencia_Mov.Cod_SubMarca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Comentario=oE_Reporte_Presencia_Mov.Comentario;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Fase=oE_Reporte_Presencia_Mov.Fase;
            //                    oE_Reporte_Presencia_Mov_Faltantes.FechaRegistro=oE_Reporte_Presencia_Mov.FechaRegistro;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Latitud=oE_Reporte_Presencia_Mov.Latitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Longitud=oE_Reporte_Presencia_Mov.Longitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Nuevo=oE_Reporte_Presencia_Mov.Nuevo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Origen=oE_Reporte_Presencia_Mov.Origen;

            //                    foreach (E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle in oE_Reporte_Presencia_Mov.Detalle) {
            //                        oCoon = new Conexion(1);
            //                        result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
            //                        oE_Reporte_Presencia_Mov.Cod_Compania,
            //                        oE_Reporte_Presencia_Mov.Cod_Equipo,
            //                        oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Trim(),
            //                        oE_Reporte_Presencia_Mov.Cod_PtoVenta,
            //                        oE_Reporte_Presencia_Mov.FechaRegistro,
            //                        oE_Reporte_Presencia_Mov_Detalle.SKU_Producto, "");

            //                        if (result == "1")
            //                        {
            //                            //Registrar Informacion Faltante
            //                            E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle_Faltantes = new E_Reporte_Presencia_Mov_Detalle();
            //                            oE_Reporte_Presencia_Mov_Detalle_Faltantes = oE_Reporte_Presencia_Mov_Detalle;
            //                            oE_Reporte_Presencia_Mov_Faltantes.Detalle.Add(oE_Reporte_Presencia_Mov_Detalle_Faltantes);
            //                        }
            //                        else if (result == "0")
            //                        {
            //                            //No existe Periodo Definido
            //                            Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov, AppEnvio);
            //                            break;
 
            //                        }
            //                        else
            //                        {
            //                            //Data Duplicada -- Actualiza Segun Perfil
            //                        }
                                    
                                    
            //                        if (oE_Reporte_Presencia_Mov_Faltantes.Detalle.Count > 0) {
            //                            Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov_Faltantes, AppEnvio);
            //                        }
                                    
            //                    }
                                
            //                }
            //                else if (Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 3 ||
            //                           Convert.ToInt32(oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.ToString()) == 6)
            //                {
            //                    E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov_Faltantes = new E_Reporte_Presencia_Mov();
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Categoria = oE_Reporte_Presencia_Mov.Cod_Categoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Compania = oE_Reporte_Presencia_Mov.Cod_Compania;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Equipo = oE_Reporte_Presencia_Mov.Cod_Equipo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Familia = oE_Reporte_Presencia_Mov.Cod_Familia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Marca = oE_Reporte_Presencia_Mov.Cod_Marca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_OpcionPresencia = oE_Reporte_Presencia_Mov.Cod_OpcionPresencia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Persona = oE_Reporte_Presencia_Mov.Cod_Persona;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_Presentacion = oE_Reporte_Presencia_Mov.Cod_Presentacion;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_PtoVenta = oE_Reporte_Presencia_Mov.Cod_PtoVenta;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubCategoria = oE_Reporte_Presencia_Mov.Cod_SubCategoria;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubFamilia = oE_Reporte_Presencia_Mov.Cod_SubFamilia;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Cod_SubMarca = oE_Reporte_Presencia_Mov.Cod_SubMarca;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Comentario = oE_Reporte_Presencia_Mov.Comentario;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Fase = oE_Reporte_Presencia_Mov.Fase;
            //                    oE_Reporte_Presencia_Mov_Faltantes.FechaRegistro = oE_Reporte_Presencia_Mov.FechaRegistro;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Latitud = oE_Reporte_Presencia_Mov.Latitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Longitud = oE_Reporte_Presencia_Mov.Longitud;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Nuevo = oE_Reporte_Presencia_Mov.Nuevo;
            //                    oE_Reporte_Presencia_Mov_Faltantes.Origen = oE_Reporte_Presencia_Mov.Origen;

            //                    foreach (E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle in oE_Reporte_Presencia_Mov.Detalle)
            //                    {
            //                        oCoon = new Conexion(1);
            //                        result = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_VERIFICAR_DUPLICADOS_PRESENCIA", 6,
            //                        oE_Reporte_Presencia_Mov.Cod_Compania,
            //                        oE_Reporte_Presencia_Mov.Cod_Equipo,
            //                        oE_Reporte_Presencia_Mov.Cod_OpcionPresencia.Trim(),
            //                        oE_Reporte_Presencia_Mov.Cod_PtoVenta,
            //                        oE_Reporte_Presencia_Mov.FechaRegistro,
            //                        oE_Reporte_Presencia_Mov_Detalle.Cod_MatApoyo, "");
                                    
            //                        if (result == "1")
            //                        {
            //                            //Registrar Informacion Faltante
            //                            E_Reporte_Presencia_Mov_Detalle oE_Reporte_Presencia_Mov_Detalle_Faltantes = new E_Reporte_Presencia_Mov_Detalle();
            //                            oE_Reporte_Presencia_Mov_Detalle_Faltantes = oE_Reporte_Presencia_Mov_Detalle;
            //                            oE_Reporte_Presencia_Mov_Faltantes.Detalle.Add(oE_Reporte_Presencia_Mov_Detalle_Faltantes);
            //                        }
            //                        else if (result == "0")
            //                        {
            //                            //No existe Periodo Definido
            //                            Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov, AppEnvio);
            //                            break;

            //                        }
            //                        else
            //                        {
            //                            //Data Duplicada -- Actualiza Segun Perfil
            //                        }


            //                        if (oE_Reporte_Presencia_Mov_Faltantes.Detalle.Count > 0)
            //                        {
            //                            Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov_Faltantes, AppEnvio);
            //                        }
                                    
            //                    }

            //                }
            //                else { 
            //                //Sub Reporte Sin Control de Duplicados
            //                Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov, AppEnvio);
            //                }



                            

            //            }
            //        }
            //    }
            //    catch (Exception ex) { }

            //}
            #endregion
        #endregion
    }
}
