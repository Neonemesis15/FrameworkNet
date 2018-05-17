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
    public class D_Reporte_RegistroPDV
    {
        private Conexion oCoon;
        public D_Reporte_RegistroPDV() { 
        }

        #region App Movil Movistar

        private string ClientPDV_Code;
        private string Nombre_Persona;

        /// <summary>
        /// Descripcion :Registrar el PDV y Devuelve el CódigoPDV_Cliente.
        /// Fecha       :04/05/2012 PSA      
        /// </summary>
        /// <param name="oE_Reporte"></param>
        /// <returns></returns>
        public E_Reporte_RegistroPDV_Response Reporte_Registrar_PDV(E_Reporte_RegistroPDV_Mov oE_Reporte) {
            
            //string CodigoPDV_Cliente = string.Empty;

            E_Reporte_RegistroPDV_Response oResponse = new E_Reporte_RegistroPDV_Response();
            try {
                if (!Registrar_PDV(oE_Reporte).Equals(0))
                {
                    if (!ClientPDV_Code.Equals(""))
                    {

                        //List<E_Distribuidora> oListDistribuidoras = new List<E_Distribuidora>();
                        D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();

                        //if (oE_Reporte.ListaNuevaDistribuidora != null)
                        //{
                        //    if (oE_Reporte.ListaNuevaDistribuidora.Count > 0)
                        //    {
                        //        foreach (E_Codigo_ITT_Nueva_Distribuidora oNuevaDistribuidora in oE_Reporte.ListaNuevaDistribuidora)
                        //        {
                        //            E_Distribuidora oE_Distribuidora = new E_Distribuidora();
                        //            oE_Distribuidora.CodDistribuidora = oD_Reporte_Codigo_ITT.Registrar_Nueva_Distribuidora(oNuevaDistribuidora).ToString();
                        //            oE_Distribuidora.NombreDistribuidora = oNuevaDistribuidora.NombreDistribuidora;
                        //            oE_Distribuidora.CodReporte = "102";
                        //            oListDistribuidoras.Add(oE_Distribuidora);
                        //        }

                        //        foreach (E_Distribuidora oDistribuidora in oListDistribuidoras)
                        //        {
                        //            oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Nueva_Distribuidora(int.Parse(oDistribuidora.CodDistribuidora), ClientPDV_Code);
                        //        }

                                //foreach (E_Codigo_ITT_Distribuidora oDistribuidora in oE_Reporte.ListaDistribuidora)
                                //{
                                //    oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Distribuidora(oDistribuidora, ClientPDV_Code);
                                //}
                        //    }
                        //}
                        ///>>>>Warning Falta Crear la Entidad E_Punto_de_Venta<<<<<
                        D_Producto dProducto = new D_Producto();
                        oResponse.NuevoCliente = dProducto.obtenerPtoVenta(ClientPDV_Code);

                        //Joseph Gonzales
                        //Modificación para almacenar los codigos ITT
                        if (oE_Reporte.ListaDistribuidora != null)
                        {
                            foreach (E_Codigo_ITT_Distribuidora oDistribuidora in oE_Reporte.ListaDistribuidora)
                            {
                                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Distribuidora(oDistribuidora, ClientPDV_Code);
                            }
                        }

                        //oResponse.ListaDistribuidoras = oD_Reporte_Codigo_ITT.ObtenerDistribuidorasXCodPuntoVenta(ClientPDV_Code);
                        oResponse.ListaDistribuidoras = new List<E_Distribuidora>();
                        oResponse.Mensaje = "Se Registro Punto de Venta con Exito";
                    }
                }
                else { 
                oResponse.Mensaje = "Error al Registrar Punto De Venta";
                }
            }
            catch (Exception ex) {
                oResponse.Mensaje = "Error en Aplicación Movil consultar con el Equipo de TI.";
                throw ex;
            }
            return oResponse;
        }
        
        /// <summary>
        /// Descripcion :Registrar Punto de Venta en el Maestro de PDV en Xplora y en BD Intermedia
        /// Fecha       :04/05/2012 PSA
        /// </summary>
        /// <param name="oE_Reporte"></param>
        /// 
        private int Registrar_PDV(E_Reporte_RegistroPDV_Mov oE_Reporte) {

            string Id_PointOfSale = string.Empty;
            int correcto = 1;
            try
            {
                #region Registrar PDV en Xplora
                oCoon = new Conexion(1);
                Id_PointOfSale = oCoon.ejecutarretornodeOUTPUT("UP_WEBXPLORA_AD_REGISTRAR_PUNTOSDEVENTA_OUTPUT_BAK", 30
                    ,oE_Reporte.Cod_TipoDocumento ?? null
                    ,oE_Reporte.PDV_RegTax ?? null
                    ,(oE_Reporte.PDV_Cliente_Nombres + " " + oE_Reporte.PDV_Cliente_Apellidos)?? null
                    ,null//Posicion1
                    ,null//Contacto2
                    ,null//Posicion2
                    ,oE_Reporte.PDV_RazonSocial ?? null
                    ,null//PDV_Nombre
                    ,oE_Reporte.PDV_Telefono ?? null
                    ,null//PDV_Anexo
                    ,null//PDV_Fax
                    ,oE_Reporte.Cod_Pais ?? null
                    ,oE_Reporte.Cod_Departamento ?? null
                    ,oE_Reporte.Cod_Provincia ?? null
                    ,oE_Reporte.Cod_Distrito ?? null
                    ,null//PDV_Cod_Comunidad
                    ,oE_Reporte.PDV_Direccion ?? null
                    ,null//PDV_Email
                    ,oE_Reporte.Cod_Canal ?? null
                    , oE_Reporte.Cod_TipoNodoComercial ?? "35" // Cod 35 - Sin Tipo de NodoComercial Asignado
                    , oE_Reporte.Cod_NodoComercial ?? "9162" // Cod 9162 - Sin NodoComercial Asignado.
                    ,oE_Reporte.Cod_Segmento ?? null // Aqui se guarda el Tipo de Poblacion (Urbanización, Pueblo Joven, etc.)
                    ,false//PDV_Estado, cuando se crea el PDV queda Invalidado. 
                    ,oE_Reporte.Creado_Por ?? null
                    ,oE_Reporte.Fecha_Registro
                    ,null//Modificado_Por
                    ,null//Fecha_Modificacion
                    ,oE_Reporte.Latitud ?? null
                    ,oE_Reporte.Longitud ?? null
                    ,oE_Reporte.Cod_Persona ?? null
                    ,"");//Id_PointOfSale
                
                #endregion


                if (!Id_PointOfSale.Equals(null))
                {
                    correcto *= Registrar_PDV_Client(oE_Reporte, Id_PointOfSale);
                    ClientPDV_Code = "PBODMOV_" + Id_PointOfSale.Trim();
                    Nombre_Persona = oE_Reporte.Creado_Por;
                }
                
            }
            catch (Exception ex) {
                correcto = 0;
                throw ex;
                
            }
            return correcto;
        }

        /// <summary>
        /// Descripcion :Registrar Punto de Venta Cliente, Asociar el Punto de Venta con un Cliente
        /// Fecha       :04/05/2012 PSA
        /// </summary>
        /// <param name="oE_Reporte"></param>
        /// <param name="Cod_PDV"></param>
        private int Registrar_PDV_Client(E_Reporte_RegistroPDV_Mov oE_Reporte, string Id_PointOfSale)
        {
            string Id_ClientPDV = string.Empty;
            string ClientPDV_Code = string.Empty;
            ClientPDV_Code = "PBODMOV_" + Id_PointOfSale.Trim();

            int correcto = 1;
            try
            {

                #region Registrar PointOfSale_Client en Xplora
                oCoon = new Conexion(1);
                Id_ClientPDV = oCoon.ejecutarretornodeOUTPUT("SP_XPL_UBI_REGISTRAR_PDVCLIENT_OUTPUT", 14
                ,oE_Reporte.Cod_Compania ?? null
                ,Convert.ToInt32(Id_PointOfSale)
                ,ClientPDV_Code ?? null
                ,oE_Reporte.Cod_Sector ?? "38" // Cod 38 - Sin Sector Asignado.
                , oE_Reporte.Cod_Oficina ?? "75"// Cod 75 - Sin Oficina Asignada.
                ,null//ClientPDV_Distribuidora
                ,0//ClientPDV_Status, Cuando se Crea el PDV_Client queda Invalidado
                ,oE_Reporte.Creado_Por ?? null
                ,oE_Reporte.Fecha_Registro ?? null
                ,null //ClientPDV_Modificado_Por
                ,null //ClientPDV_Fecha_Modificacion
                ,null //ClientPDV_PDV_Alias
                ,oE_Reporte.POSClient_Referencia ?? null
                ,oE_Reporte.Cod_Persona ?? null
                ,0);
                #endregion

                #region Registrar PointOfSale_Client en Intermedia
                oCoon = new Conexion(3);
                oCoon.ejecutarDataSet("SP_MOV_GES_UBI_REGISTRAR_PTO_VENTA_CLIENT"
                , ClientPDV_Code ?? null
                , oE_Reporte.Cod_NodoComercial ?? "9162" // Cod 9162 - Sin NodoComercial Asignado.
                , oE_Reporte.Cod_Canal ?? null
                , null // [COD_UPTOVENTA]
                , null // [COD_TPVENTA]
                , oE_Reporte.PDV_RazonSocial ?? null
                , oE_Reporte.PDV_Direccion ?? null
                , 1 // ESTADO
                , oE_Reporte.Latitud ?? null
                , oE_Reporte.Longitud ?? null
                );
                    
                #endregion

                if (!Id_ClientPDV.Equals(""))
                {
                    correcto *= Registrar_PDV_Planning(oE_Reporte, Id_ClientPDV, ClientPDV_Code);
                }   
            }
            catch (Exception ex) {
                correcto = 0;
                throw ex;
            }
            return correcto;
        }
        
        /// <summary>
        /// Descripcion :Registrar Punto de Venta en el Planning en Xplora
        /// Fecha       :04/05/2012 PSA
        /// </summary>
        /// <param name="oE_Reporte"></param>
        /// <param name="Cod_CompaniaPDV"></param>
        private int Registrar_PDV_Planning(E_Reporte_RegistroPDV_Mov oE_Reporte, string Id_ClientPDV, string ClientPDV_Code)
        {
            int correcto = 1;
            string Id_MPOSPlanning = string.Empty;
            try
            {
                #region Registrar PointOfSale_Planning en Xplora
                oCoon = new Conexion(1);
                Id_MPOSPlanning = oCoon.ejecutarretornodeOUTPUT("UP_WEBSIGE_PLANNING_INSERTARPDVPLANNING_MOVIL", 15
                        , Id_ClientPDV
                        , oE_Reporte.Cod_Equipo
                        , oE_Reporte.Cod_Ciudad ?? "999"// Cod 999 - Sin Ciudad Asignada.
                        , oE_Reporte.Cod_TipoNodoComercial ?? "35"// Cod 35 - Sin Tipo de NodoComercial Asignado.
                        , oE_Reporte.Cod_NodoComercial ?? "9162" // Cod 9162 - Sin NodoComercial Asignado.
                        , oE_Reporte.Cod_Oficina ?? "75"// Cod 75 - Sin Oficina Asignada.
                        , oE_Reporte.Cod_Malla ?? "27"  // Cod 27 - Sin Malla Asignada.
                        , oE_Reporte.Cod_Sector ?? "38" // Cod 38 - Sin Sector Asignado.
                        , false//PointOfSalePlanning_Status, Cuando se Registra esta en False.
                        , oE_Reporte.Creado_Por
                        , oE_Reporte.Fecha_Registro
                        , null//PointOfSalePlanning_Modificado_Por
                        , null//PointOfSalePlanning_Fecha_Modificacion
                        , null//PointOfSalePlanning_Contacto
                        , "NI"// 1 - Implementacion, 2 - Mantenimiento, 3 - Pendiente
                        , "");
                #endregion

                if (!Id_MPOSPlanning.Equals(""))
                {
                    correcto *= Registrar_PDV_Planning_Oper(oE_Reporte, Id_MPOSPlanning, ClientPDV_Code);
                }
                
            }
            catch (Exception ex) {
                correcto = 0;
                throw ex;
            }
            return correcto;
        }
        
        /// <summary>
        /// Descripcion :Asignar al Mercaderista la Ruta.
        /// Fecha       :06/05/2012 PSA
        /// </summary>
        /// <param name="oE_Reporte"></param>
        /// <param name="Cod_POSPlanning"></param>
        private int Registrar_PDV_Planning_Oper(E_Reporte_RegistroPDV_Mov oE_Reporte, string Id_MPOSPlanning, string ClientPDV_Code)
        {
            int correcto = 1;
            try
            {
                D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
                D_Registrar_Motivo oD_Registrar_Motivo = new D_Registrar_Motivo();

                #region Registrar Ruta en Xplora
                oCoon = new Conexion(1);
                oCoon.ejecutarDataTable("SP_XPL_GES_CAM_INSERTARPDVPLANNING_OPER"
                        , Id_MPOSPlanning
                        , oE_Reporte.Cod_Equipo
                        , oE_Reporte.Cod_Persona
                        , oE_Reporte.Fecha_Registro //Fecha_Inicio del Relevo
                        , null  // Cod Frecuencia
                        , false // Estado
                        , oE_Reporte.Creado_Por
                        , oE_Reporte.Fecha_Registro
                        , ClientPDV_Code);
                #endregion

                #region Registrar Ruta en Intermedia -- Comentado Psa 23/10/2012
                //oCoon = new Conexion(3);
                //oCoon.ejecutarDataSet("SP_MOV_GES_CAM_REGISTRAR_RUTA"
                //    , oE_Reporte.Cod_Equipo
                //    , ClientPDV_Code ?? null
                //    , oE_Reporte.Cod_Persona ?? null
                //    , oE_Reporte.Fecha_Registro ?? null //Fecha Inicio Ruta
                //    , null   //Fecha Fin Ruta
                //    , 1      //Estado
                //    );
                #endregion

                #region Registrar Ruta con Fase en Xplora - >>>>>Warning<<<<<<<<
                #endregion

                #region Registrar Ruta con Fase en Intermedia -- Comentado Psa 23/10/2012
                oCoon = new Conexion(3);
                oCoon.ejecutarDataSet("SP_MOV_GES_CAM_REGISTRAR_RUTA_FASE"
                    , ClientPDV_Code
                    , oE_Reporte.Cod_Equipo
                    , "NI" //Fase NI
                    );
                #endregion

                #region Registrar Presencia en BD Intermedia con Fase

                E_Reporte_Presencia_Mov oE_Reporte_Presencia_Mov = new E_Reporte_Presencia_Mov();
                oE_Reporte_Presencia_Mov.Cod_Equipo = oE_Reporte.Cod_Equipo;
                oE_Reporte_Presencia_Mov.Cod_Compania = int.Parse(oE_Reporte.Cod_Compania);
                oE_Reporte_Presencia_Mov.Cod_PtoVenta = ClientPDV_Code;
                oE_Reporte_Presencia_Mov.Cod_Persona = int.Parse(oE_Reporte.Cod_Persona);
                oE_Reporte_Presencia_Mov.FechaRegistro = oE_Reporte.Fecha_Registro;
                oE_Reporte_Presencia_Mov.Latitud = oE_Reporte.Latitud;
                oE_Reporte_Presencia_Mov.Longitud = oE_Reporte.Longitud;
                oE_Reporte_Presencia_Mov.Origen = oE_Reporte.Origen;
                oE_Reporte_Presencia_Mov.Fase = "NI";
                oE_Reporte_Presencia_Mov.Nuevo = "1";

                oD_Reporte_Presencia.Registrar_Presencia_Mov_Cabecera(oE_Reporte_Presencia_Mov, 0);

                #endregion
                
                #region Regisrar Motivos - No Implementación o No Mantenimiento en BD Intermedia
                
                E_MotivoFase oE_MotivoFase = new E_MotivoFase();
                oE_MotivoFase.CodMotivo = 93;//Motivo de No Implementación, 93 - Por Implementar.
                
                E_Registro_MotivoFase oE_Registro_MotivoFase = new E_Registro_MotivoFase();
                oE_Registro_MotivoFase.Cod_Persona = int.Parse(oE_Reporte.Cod_Persona);
                oE_Registro_MotivoFase.Cod_PtoVenta = ClientPDV_Code;
                oE_Registro_MotivoFase.Cod_Equipo = oE_Reporte.Cod_Equipo;
                oE_Registro_MotivoFase.Cod_Compania = int.Parse(oE_Reporte.Cod_Compania);
                oE_Registro_MotivoFase.FechaRegistro = oE_Reporte.Fecha_Registro;
                oE_Registro_MotivoFase.Origen = oE_Reporte.Origen;
                oE_Registro_MotivoFase.Latitud = oE_Reporte.Latitud;
                oE_Registro_MotivoFase.Longitud = oE_Reporte.Longitud; 
                oE_Registro_MotivoFase.Fase = "NI";
                oE_Registro_MotivoFase.Nuevo = "1";
                oE_Registro_MotivoFase.listaMotivo.Add(oE_MotivoFase);
                
                oD_Registrar_Motivo.RegistrarMotivoColgateBodega_Mov(oE_Registro_MotivoFase);

                #endregion

                            }
            catch (Exception ex) {
                correcto = 0;
                throw ex;
            }
            return correcto;
        }

        //string error = String.Empty;
        //public string Registrar_Codigo_ITT_Mov(List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT)
        //{
        //    if (oListE_Reporte_CodigoITT != null)
        //    {
        //        foreach (E_Reporte_Codigo_ITT_Mov oE_Reporte_CodigoITT in oListE_Reporte_CodigoITT)
        //        {
        //            error += Registrar_Codigo_ITT(oE_Reporte_CodigoITT);
        //        }
        //    }
        //    return error;
        //}
        //private string Registrar_Codigo_ITT(E_Reporte_Codigo_ITT_Mov oEReporteCodigoITT)
        //{
        //    oCoon = new Conexion(3);
        //    List<int> ListaCodNuevaDistb = new List<int>();
        //    try
        //    {
        //        foreach (E_Codigo_ITT_Nueva_Distribuidora oNuevaDistribuidora in oEReporteCodigoITT.ListaNuevaDistribuidora)
        //        {
        //            ListaCodNuevaDistb.Add(Registrar_Nueva_Distribuidora(oNuevaDistribuidora));
        //        }
        //        error = "";
        //        foreach (E_Codigo_ITT_Distribuidora oDistribuidora in oEReporteCodigoITT.ListaDistribuidora)
        //        {
        //            Registrar_Codigo_ITT_Distribuidora(oDistribuidora, oEReporteCodigoITT.CodPtoVenta);
        //        }
        //        foreach (int codDistribuidora in ListaCodNuevaDistb)
        //        {
        //            Registrar_Codigo_ITT_Nueva_Distribuidora(codDistribuidora, oEReporteCodigoITT.CodPtoVenta);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        error += ex.Message;
        //    }
        //    return error;
        //}
        //private int Registrar_Nueva_Distribuidora(E_Codigo_ITT_Nueva_Distribuidora oNuevaDistribuidora)
        //{
        //    oCoon = new Conexion(3);
        //    int codNuevaDistb = -1;
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(oNuevaDistribuidora.NombreDistribuidora))
        //        {
        //            codNuevaDistb = int.Parse(oCoon.ejecutarEscalar("SP_GES_OPE_REGISTRAR_DISTRIBUIDORA", oNuevaDistribuidora.NombreDistribuidora, Nombre_Persona));
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return codNuevaDistb;
        //}
        //private void Registrar_Codigo_ITT_Distribuidora(E_Codigo_ITT_Distribuidora oDistribuidora, string CodPtoVenta)
        //{
        //    oCoon = new Conexion(3);
        //    try
        //    {
        //        oCoon.ejecutarSinRetorno("SP_GES_OPE_REGISTRAR_ASIGNACION_DISTRIBUIDORA", CodPtoVenta, oDistribuidora.CodDistribuidora, oDistribuidora.TipoAsociación);

        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
        //private void Registrar_Codigo_ITT_Nueva_Distribuidora(int CodDistribuidora, string CodPtoVenta)
        //{
        //    oCoon = new Conexion(3);
        //    try
        //    {
        //        oCoon.ejecutarSinRetorno("SP_GES_OPE_REGISTRAR_ASIGNACION_DISTRIBUIDORA", CodPtoVenta, CodDistribuidora, 1);

        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        ///// <summary>
        ///// PSA 17/06/2012 Devuelve la Lista de Distribuidoras asociadas al Cod_PtoVentaCliente
        ///// </summary>
        ///// <param name="CodPtoVenta"></param>
        ///// <returns></returns>
        //private List<E_Distribuidora> ObtenerDistribuidorasXCodPuntoVenta(string CodPtoVenta) {
        //    List<E_Distribuidora> oListDistribuidoras = new List<E_Distribuidora>();
        //    try {
        //        oCoon = new Conexion(3);
        //        SqlDataReader readerSinc = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_DISTRIBUIDORAS_POR_CODPTOVENTACLIENTE", CodPtoVenta);
               
        //        while (readerSinc.Read())
        //        {
        //            E_Distribuidora oE_Distribuidora = new E_Distribuidora();
        //            oE_Distribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
        //            oE_Distribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
        //            oListDistribuidoras.Add(oE_Distribuidora);
        //        }

        //    }
        //    catch (Exception ex) { }
        //    return oListDistribuidoras;
        //}

        #endregion
    }
}
