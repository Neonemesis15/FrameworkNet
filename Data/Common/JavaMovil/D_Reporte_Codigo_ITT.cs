using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Codigo_ITT
    {
        private Conexion oCoon;
        public string id = "";

        public D_Reporte_Codigo_ITT()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }
        
        #region Aplicativo Movil Lucky
        public void Registrar_Presencia_Codigo_ITT(List<E_Reporte_Codigo_ITT> oListE_Reporte_CodigoITT)
        {
            if (oListE_Reporte_CodigoITT != null)
            {
                foreach (E_Reporte_Codigo_ITT oE_Reporte_CodigoITT in oListE_Reporte_CodigoITT)
                {
                    Registrar_Presencia_Codigo_ITT(oE_Reporte_CodigoITT);
                }
            }
        }

        /// <summary>
        /// Joseph Gonzales
        /// Fecha: 20/04/2012
        /// DEscripcion: Registra la cabecera del reporte de codigos ITT
        /// </summary>
        /// <param name="oEReportePresencia_aux">Objeto de la entidad E_Reporte_Codigo_ITT</param>
        /// <returns></returns>
        public void Registrar_Presencia_Codigo_ITT(E_Reporte_Codigo_ITT oEReporteCodigoITT)
        {
            oCoon = new Conexion(2);
            id = oCoon.ejecutarretornodeOUTPUT("SP_JVM_INSERTAR_REPORTE_ITT", 9, oEReporteCodigoITT.personId ?? "0",
            oEReporteCodigoITT.perfilId ?? "", oEReporteCodigoITT.equipoId ?? "", oEReporteCodigoITT.clienteId ?? "",
            oEReporteCodigoITT.clientPDV_Code ?? "", oEReporteCodigoITT.fechaReg ?? "", oEReporteCodigoITT.latitud ?? "",
            oEReporteCodigoITT.longitud ?? "", oEReporteCodigoITT.origen ?? "", oEReporteCodigoITT.idRegistro);

            foreach (E_Reporte_Codigo_ITT_Detalle detalle in oEReporteCodigoITT.detalle)
            {
                detalle.idRegistro = int.Parse(id);
                Registrar_Presencia_Codigo_ITT_Detalle(detalle);
            }
        }

        /// <summary>
        /// Joseph Gonzales
        /// Fecha: 20/04/2012
        /// DEscripcion: Registra el detalle del reporte de codigos ITT
        /// </summary>
        /// <param name="detalle">Objeto de la Entidad E_Reporte_Codigo_ITT_Detalle</param>
        private void Registrar_Presencia_Codigo_ITT_Detalle(E_Reporte_Codigo_ITT_Detalle detalle)
        {
            oCoon = new Conexion(2);
            oCoon.ejecutarDataTable("SP_JVM_INSERTAR_REPORTE_ITT_DETALLE",
                detalle.idRegistro, detalle.id ?? "", detalle.distribuidora ?? "", detalle.codigo ?? "");
        }
        #endregion

        #region Aplicativo Movil Movistar
        /// <summary>
        /// Pablo Salas
        /// Fecha: 17/05/2012
        /// DEscripcion: Registra lista de Objetos del Tipo E_Reporte_Codigo_ITT para app Movistar
        /// </summary>
        /// <param name="oListE_Reporte_CodigoITT"></param>
        /// 
        public void Registrar_Codigo_ITT_Mov(List<E_Reporte_Codigo_ITT_Mov> oListE_Reporte_CodigoITT)
        {
            //E_Reporte_Codigo_ITT_Mov_Response oE_Reporte_Codigo_ITT_Mov_Response = new E_Reporte_Codigo_ITT_Mov_Response();
            //List<E_Distribuidora> oListaE_Distribuidora = new List<E_Distribuidora>();
            try
            {
                if (oListE_Reporte_CodigoITT != null)
                {
                    foreach (E_Reporte_Codigo_ITT_Mov oE_Reporte_CodigoITT in oListE_Reporte_CodigoITT)
                    {
                        Registrar_Codigo_ITT(oE_Reporte_CodigoITT);
                    }
                }
                //oE_Reporte_Codigo_ITT_Mov_Response.ListaDistribuidoras = oListaE_Distribuidora;
            }
            catch (Exception ex) {
                throw ex;
            }
            //return oE_Reporte_Codigo_ITT_Mov_Response;
        }

        public void Registrar_Codigo_ITT(E_Reporte_Codigo_ITT_Mov oEReporteCodigoITT)
        {
            //oCoon = new Conexion(3);
            //List<int> ListaCodNuevaDistb = new List<int>();
            //List<E_Distribuidora> oListE_Distribuidora = new List<E_Distribuidora>();
            try
            {
                //foreach (E_Codigo_ITT_Nueva_Distribuidora oNuevaDistribuidora in oEReporteCodigoITT.ListaNuevaDistribuidora)
                //{
                //    ListaCodNuevaDistb.Add(Registrar_Nueva_Distribuidora(oNuevaDistribuidora));
                //}
               
                foreach (E_Codigo_ITT_Distribuidora oDistribuidora in oEReporteCodigoITT.ListaDistribuidora)
                {
                    Registrar_Codigo_ITT_Distribuidora(oDistribuidora, oEReporteCodigoITT.CodPtoVenta);
                }
                //foreach (int codDistribuidora in ListaCodNuevaDistb)
                //{
                //    Registrar_Codigo_ITT_Nueva_Distribuidora(codDistribuidora, oEReporteCodigoITT.CodPtoVenta);
                //}
                //oListE_Distribuidora = ObtenerDistribuidorasXCodPuntoVenta(oEReporteCodigoITT.CodPtoVenta);
            }
            catch (Exception ex)
            {
                throw ex;   
            }
            //return oListE_Distribuidora;           
        }

       
        //public  int Registrar_Nueva_Distribuidora(E_Codigo_ITT_Nueva_Distribuidora oNuevaDistribuidora)
        //{
        //    oCoon = new Conexion(3);
        //    int codNuevaDistb = -1;
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(oNuevaDistribuidora.NombreDistribuidora))
        //        {
        //            #region Registrar Distribuidora en Xplora
        //            oCoon = new Conexion(1);
        //            codNuevaDistb = int.Parse(oCoon.ejecutarEscalar("SP_XPL_GES_OPE_REGISTRAR_DISTRIBUIDORA_OUTPUT", oNuevaDistribuidora.NombreDistribuidora, oNuevaDistribuidora.CreadoPor ?? "abodega"));
        //            #endregion

        //            #region Registrar Distribuidora en Intermedia
        //            if (codNuevaDistb != -1){
        //            oCoon = new Conexion(3);
        //            oCoon.ejecutarDataSet("SP_MOV_GES_OPE_REGISTRAR_DISTRIBUIDORA", codNuevaDistb, oNuevaDistribuidora.NombreDistribuidora,1);
        //            }

        //            #endregion

        //        }
        //    }
        //    catch (Exception ex) {
        //        throw ex;
        //    }
        //    return codNuevaDistb;
        //}

        public  void Registrar_Codigo_ITT_Distribuidora(E_Codigo_ITT_Distribuidora oDistribuidora, string CodPtoVenta)
        {
            
            try
            {
                #region Registrar Distribuidora X PtoVenta en Intermedia.
                oCoon = new Conexion(3);
                oCoon.ejecutarSinRetorno("SP_MOV_GES_OPE_REGISTRAR_ASIGNACION_DISTRIBUIDORA_PTOVENTA_V_1_1"
                    , CodPtoVenta
                    , oDistribuidora.CodDistribuidora
                    , oDistribuidora.CodITT);
                #endregion

                //#region Registrar Distribuidora X Equipo en Xplora >>>>>Warning<<<<<<
                //#endregion

                //#region Registrar Distribuidora X Equipo en Intermedia 
                //oCoon = new Conexion(3);
                //oCoon.ejecutarDataSet("SP_MOV_GES_CAM_REGISTRAR_EQUIPO_DISTRIBUIDORA", Cod_Equipo, "102", oDistribuidora.CodDistribuidora, Convert.ToInt32(oDistribuidora.CodITT));
                //#endregion


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  void Registrar_Codigo_ITT_Nueva_Distribuidora(int CodDistribuidora, string CodPtoVenta)
        {
            
            try
            {
                #region Registrar Distribuidora X PtoVenta en Intermedia.
                oCoon = new Conexion(3);
                string Cod_Equipo = string.Empty;
                Cod_Equipo = oCoon.ejecutarretornodeOUTPUT("SP_MOV_GES_OPE_REGISTRAR_ASIGNACION_DISTRIBUIDORA_PTOVENTA_OUTPUT_CODEQUIPO",3
                    , CodPtoVenta
                    , CodDistribuidora
                    , 1
                    , "");
                #endregion

                #region Registrar Distribuidora X Equipo en Xplora >>>>>Warning<<<<<<
                #endregion

                #region Registrar Distribuidora X Equipo en Intermedia 
                oCoon = new Conexion(3);
                oCoon.ejecutarDataSet("SP_MOV_GES_CAM_REGISTRAR_EQUIPO_DISTRIBUIDORA", Cod_Equipo, "102", CodDistribuidora, 1);
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PSA 17/06/2012 Devuelve la Lista de Distribuidoras asociadas al Cod_PtoVentaCliente
        /// </summary>
        /// <param name="CodPtoVenta"></param>
        /// <returns></returns>
        public  List<E_Distribuidora> ObtenerDistribuidorasXCodPuntoVenta(string CodPtoVenta)
        {
            List<E_Distribuidora> oListDistribuidoras = new List<E_Distribuidora>();
            try
            {
                oCoon = new Conexion(3);
                SqlDataReader readerSinc = oCoon.ejecutarDataReader("SP_GES_OPE_OBTENER_DISTRIBUIDORAS_POR_CODPTOVENTACLIENTE", CodPtoVenta);

                while (readerSinc.Read())
                {
                    E_Distribuidora oE_Distribuidora = new E_Distribuidora();
                    oE_Distribuidora.CodDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("COD_DISTRIBUIDORA")).ToString().Trim();
                    oE_Distribuidora.NombreDistribuidora = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_DISTRIBUIDORA")).ToString().Trim();
                    oListDistribuidoras.Add(oE_Distribuidora);
                }

            }
            catch (Exception ex) {
                throw ex;
            }
            return oListDistribuidoras;
        }

        ///// <summary>
        ///// Autor   : Pablo Salas A.
        ///// Fecha   : 22/07/2012
        ///// Descripcion: Obtener E_PuntoVenta con CodPuntoVenta
        ///// </summary>
        ///// <param name="CodPtoVenta"></param>
        ///// <returns></returns>
        //public E_PuntoVenta obtenerPtoVenta(string codigoPtoVenta)
        //{
        //    oCoon = new Conexion(3);
        //    DataTable dt = oCoon.ejecutarDataTable("SP_GES_CAM_OBTENER_PDV_X_CODIGO", codigoPtoVenta);
        //    E_PuntoVenta ePuntoVenta = new E_PuntoVenta();

        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            ePuntoVenta.CodigoPDV = dt.Rows[0]["Cod_Pdv"].ToString().Trim();
        //            ePuntoVenta.RazonSocial = dt.Rows[0]["Pdv_Nombre"].ToString().Trim();
        //            ePuntoVenta.Direccion = dt.Rows[0]["Pdv_Direccion"].ToString().Trim();
        //            ePuntoVenta.CodigoCadena = dt.Rows[0]["Cod_Cadena"].ToString().Trim();
        //            ePuntoVenta.NombreCadena = dt.Rows[0]["Cad_Nombre"].ToString().Trim();
        //            ePuntoVenta.CodigoCanal = dt.Rows[0]["Cod_Canal"].ToString().Trim();
        //            ePuntoVenta.NombreCanal = dt.Rows[0]["Can_Nombre"].ToString().Trim();
        //            ePuntoVenta.TipoMercado = dt.Rows[0]["Can_Tipo"].ToString().Trim();
        //            ePuntoVenta.latitud = double.Parse(dt.Rows[0]["Latitud"].ToString().Trim());
        //            ePuntoVenta.longitud = double.Parse(dt.Rows[0]["Longitud"].ToString().Trim());
        //            ePuntoVenta.Fase = dt.Rows[0]["Cod_Fase"].ToString().Trim();
        //        }
        //        return ePuntoVenta;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        #endregion

    }
}