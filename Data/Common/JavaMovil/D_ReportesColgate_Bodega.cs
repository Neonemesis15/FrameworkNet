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
    public class D_ReportesColgate_Bodega
    {
        private Conexion oCoon;
        public D_ReportesColgate_Bodega() {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }
        #region AppMovil Nextel
        public void RegistrarReportesColgate_Bodega(List<E_Reporte_RegistroPDV> oListE_Reporte_RegistroPDV) {
            oCoon = new Conexion(2);
            foreach (E_Reporte_RegistroPDV oE_Reporte_RegistroPDV in oListE_Reporte_RegistroPDV) 
                {
                    RegistrarReporteRegistroPDV(oE_Reporte_RegistroPDV);
                }
                
        }

        public string id = "";
        public void RegistrarReporteRegistroPDV(E_Reporte_RegistroPDV oE_Reporte_RegistroPDV) {
            string id_Reg_RegistroPDV = "";
            oCoon = new Conexion(2);
            id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_REGISTRO_PDV", 11, oE_Reporte_RegistroPDV.Person_id,
                oE_Reporte_RegistroPDV.Equipo_id,oE_Reporte_RegistroPDV.Cliente_id,oE_Reporte_RegistroPDV.ClientePDV_Code,
                oE_Reporte_RegistroPDV.Nombre,oE_Reporte_RegistroPDV.Telefono,oE_Reporte_RegistroPDV.IdImplementaPDV,
                oE_Reporte_RegistroPDV.FechaRegistro, oE_Reporte_RegistroPDV.Latitud, oE_Reporte_RegistroPDV.Longitud,
                oE_Reporte_RegistroPDV.OrigenCoordenada, id_Reg_RegistroPDV);
            foreach (E_Reporte_RegistroPDV_Detalle detalle in oE_Reporte_RegistroPDV.RegistroPDV_Detalle)
                    {
                        RegistrarReporteRegistroPDV_Detalle(detalle);
                    }
        }

        public string id_Pregunta = "";
        public void RegistrarReporteRegistroPDV_Detalle(E_Reporte_RegistroPDV_Detalle oE_Reporte_RegistroPDV_Detalle)
        {
            #region
            //string id_Reg_IdPregunta = "";
            //DataSet id_PreguntaAux;
            //oCoon = new Conexion(2);
            //Obtener el IdPregunta del RegistrarReporteRegistroPDV_Detalle
            //id_PreguntaAux = oCoon.ejecutarDataSet("STP_JVM_INSERTAR_REGISTRO_PDV_DETALLE", Convert.ToInt64(id), id_Reg_IdPregunta);
            //id_Pregunta = id_PreguntaAux.ToString();
            #endregion

            id_Pregunta = oE_Reporte_RegistroPDV_Detalle.id_Pregunta;
            foreach (E_Reporte_RegistroPDV_Detalle_Opcion opciones in oE_Reporte_RegistroPDV_Detalle.Id_Opcion)
            {
                RegistrarReporteRegistroPDV_Detalle_Opcion(id_Pregunta, opciones.id_Opcion);
            }
            
        }

        public void RegistrarReporteRegistroPDV_Detalle_Opcion(string id_Pregunta,string id_Opcion)
        {
            oCoon = new Conexion(2);
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REGISTRO_PDV_DETALLE", Convert.ToInt64(id), id_Pregunta, id_Opcion);

        }
        #endregion 

        #region AppMovil Movistar
        /// <summary>
        /// Descripcion : Registrar Reportes de Colgate Bodega para el App Movistar
        /// Fecha       : 01/06/2012
        /// Autor       : Joseph Gonzales
        /// </summary>
        /// <param name="oListRepPresencia"></param>
        /// <param name="oListRepFotogradico"></param>
        /// <param name="oListRepITT"></param>
        /// <param name="oE_Visita"></param>
        /// <returns></returns>
        public E_Reportes_Colgate_Bodega_Mov_Response RegistrarReportesColgate_Bodega_Mov(
            List<E_Reporte_Presencia_Mov> oListRepPresencia,
            List<E_Reporte_Codigo_ITT_Mov> oListRepITT,
            E_Visita_Mov oE_Visita, int AppEnvia)
        {

            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Visita oD_Visita = new D_Visita();

            E_Reportes_Colgate_Bodega_Mov_Response oE_Reportes_Colgate_Bodega_Mov_Response = new E_Reportes_Colgate_Bodega_Mov_Response();
            
            try
            {
                //E_Reporte_Codigo_ITT_Mov_Response oE_Reporte_Codigo_ITT_Mov_Response = new E_Reporte_Codigo_ITT_Mov_Response();
                //oE_Reporte_Codigo_ITT_Mov_Response = 
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListRepITT);

                E_Reporte_Presencia_Datos_Response oE_Reporte_Presencia_Datos_Response = new E_Reporte_Presencia_Datos_Response();
                oE_Reporte_Presencia_Datos_Response = oD_Reporte_Presencia.Registrar_Presencia_Bodega_Mov(oListRepPresencia, AppEnvia);

                String Registro_Visita_Response = oD_Visita.RegistrarVisita_Mov(oE_Visita);
                if (!Registro_Visita_Response.Equals(""))
                    Registro_Visita_Response = "Hubo Errores en Registro de Visita. ";

                //Response de Registro de Reportes Bodega
                //oE_Reportes_Colgate_Bodega_Mov_Response.Reporte_Codigo_ITT_Mov_Response = oE_Reporte_Codigo_ITT_Mov_Response;
                oE_Reportes_Colgate_Bodega_Mov_Response.Reporte_Presencia_Mov_Response = oE_Reporte_Presencia_Datos_Response;
                oE_Reportes_Colgate_Bodega_Mov_Response.Mensaje_Response = Registro_Visita_Response;
            }
            catch (Exception ex) {
                throw ex;
            }
            return oE_Reportes_Colgate_Bodega_Mov_Response;
        }
               
        /// <summary>
        /// Descripcion : Registrar Nuevos Puntos de Venta para el App Movistar, Retorna el ClientPDV_Code.
        /// Fecha       : 02/05/2012
        /// Autor       : PSA
        /// </summary>
        /// <param name="oE_Reporte_RegistroPDV_Mov"></param>
        /// <returns></returns>
        public E_Reporte_RegistroPDV_Response Registrar_PuntoDeVenta_Bodega_Mov(
            E_Reporte_RegistroPDV_Mov oE_Reporte_RegistroPDV_Mov)
        {
            
            E_Reporte_RegistroPDV_Response oE_Reporte_RegistroPDV_Response = new E_Reporte_RegistroPDV_Response();
            try {
                D_Reporte_RegistroPDV oD_Reporte_RegistroPDV = new D_Reporte_RegistroPDV();
                String ClientPDV_Code = string.Empty;
                String mensaje_Final = string.Empty;
                oE_Reporte_RegistroPDV_Response = oD_Reporte_RegistroPDV.Reporte_Registrar_PDV(oE_Reporte_RegistroPDV_Mov);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oE_Reporte_RegistroPDV_Response;
        }

        #endregion
    }
}
