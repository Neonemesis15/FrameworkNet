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
    public class D_Reporte_Competencia
    {
        private Conexion oCoon;
        public D_Reporte_Competencia() {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }

        private string id = "";

        #region Servicios Aplicativo Movil Lucky
        
        public void RegistrarCompetencia(E_Reporte_Competencia oE_Reporte_Competencia,E_Reporte_Fotografico oE_Reporte_Fotografico)
        {
            #region Registrar Competencia
            string id_reg_competencia="";
            id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_COMPETENCIA_02",29,oE_Reporte_Competencia.Person_id ?? "",
                oE_Reporte_Competencia.Perfil_id ?? "", oE_Reporte_Competencia.Equipo_id ?? "", oE_Reporte_Competencia.Cliente_id ?? "",
                oE_Reporte_Competencia.ClientePDV_Code ?? "", oE_Reporte_Competencia.Categoria_id ?? "",
                oE_Reporte_Competencia.Marca_id ?? "", oE_Reporte_Competencia.Id_tipo_Promocion ?? "", oE_Reporte_Competencia.Id_Tipo_Actividad ?? "",
                oE_Reporte_Competencia.Id_Grupo_Objetivo ?? "", oE_Reporte_Competencia.Precio_Costo ?? "",
                oE_Reporte_Competencia.Precio_Pvp ?? "", oE_Reporte_Competencia.Fec_ini_Act ?? "", oE_Reporte_Competencia.Fec_fin_Act ?? "",
                oE_Reporte_Competencia.Txt_Grupo_Objetivo ?? "", oE_Reporte_Competencia.Cant_Personal ?? "", oE_Reporte_Competencia.Premio ?? "",
                oE_Reporte_Competencia.Mecanica ?? "", oE_Reporte_Competencia.Mat_Apoyo ?? "", oE_Reporte_Competencia.Observaciones ?? "",
                oE_Reporte_Competencia.FechaRegistro ?? "", oE_Reporte_Competencia.Latitud ?? "", oE_Reporte_Competencia.Longitud ?? "",
                oE_Reporte_Competencia.OrigenCoordenada ?? "", oE_Reporte_Competencia.Fec_Comunicacion ?? "", oE_Reporte_Competencia.Id_empresa ?? "",
                oE_Reporte_Competencia.Tipo_competencia ?? "", id_reg_competencia ?? "");
            foreach (E_Reporte_Competencia_Detalle detalle in oE_Reporte_Competencia.CompetenciaDetalle) {
                RegistrarCompetenciaDetalle(detalle);
            }
            #endregion

            #region Registrar Fotografia
            RegistarCompetencia_Foto(oE_Reporte_Fotografico);
            #endregion
        }
        private void RegistrarCompetenciaDetalle(E_Reporte_Competencia_Detalle oE_Reporte_Competencia_Detalle)
        {
            oCoon = new Conexion(2);
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_COMPETENCIA_02_DETALLE", id, oE_Reporte_Competencia_Detalle.Id_pop ?? "");
        }
        public void RegistarCompetencia_Foto(E_Reporte_Fotografico oE_Reporte_Fotografico)
        { 
            //Insertar Foto Tipo de Proceso por defecto 1
            oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
            Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
            oE_Reporte_Fotografico.Equipo_id ?? "",
            oE_Reporte_Fotografico.Cliente_id ?? "",
            oE_Reporte_Fotografico.ClientePDV_Code ?? "",
            2,//Reporte Competencia
            oE_Reporte_Fotografico.FechaRegistro ?? "",
            oE_Reporte_Fotografico.Comentario ?? "",
            DecodeFrom64(oE_Reporte_Fotografico.Foto1 + oE_Reporte_Fotografico.Foto2 + oE_Reporte_Fotografico.Foto3 + oE_Reporte_Fotografico.Foto4 + oE_Reporte_Fotografico.Foto5 + oE_Reporte_Fotografico.Foto6),
            " ");
            //oE_Reporte_Fotografico.NombreFoto
                
        }

        #region metodos Util
        //Convierte a byte[] un string Add 13/01/2012
        public static byte[] DecodeFrom64(String encodedData)
        {

            byte[] encodedDataAsBytes

                = System.Convert.FromBase64String(encodedData);
            return encodedDataAsBytes;

        }
        #endregion

        /// <summary>
        /// Descripcion : Registrar Competencia incluyendo los parámetros Foto y Comentario_Foto en la Entidad Competencia.
        /// Fecha       : 31/05/2012 PSA
        /// </summary>
        /// <param name="oE_Reporte_Competencia"></param>
        /// <param name="AppEnvia"></param>

        public string Registrar_Competencia_Web(List<E_Reporte_Competencia> oList_Report, string AppEnvia) {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Competencia oEReport in oList_Report)
                {
                    Registrar_Competencia_Web_Cabecera(oEReport, AppEnvia);
                    error += "";
                }
            }
            catch (Exception ex) {
                error += ex.Message;
            }
            return error;
        }
        private void Registrar_Competencia_Web_Cabecera(E_Reporte_Competencia oE_Reporte_Competencia, string AppEnvia)
        {
            try
            {
                #region Registrar Competencia Web
                oCoon = new Conexion(2);
                string id_reg_competencia = "";
                id_reg_competencia = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_COMPETENCIA_02", 28,
                oE_Reporte_Competencia.Person_id ?? "",
                oE_Reporte_Competencia.Perfil_id ?? "",
                oE_Reporte_Competencia.Equipo_id ?? "",
                oE_Reporte_Competencia.Cliente_id ?? "",
                oE_Reporte_Competencia.ClientePDV_Code ?? "",
                oE_Reporte_Competencia.Categoria_id ?? "",
                oE_Reporte_Competencia.Marca_id ?? "",
                oE_Reporte_Competencia.Id_tipo_Promocion ?? "",
                oE_Reporte_Competencia.Id_Tipo_Actividad ?? "",
                oE_Reporte_Competencia.Id_Grupo_Objetivo ?? "",
                oE_Reporte_Competencia.Precio_Costo ?? "",
                oE_Reporte_Competencia.Precio_Pvp ?? "",
                oE_Reporte_Competencia.Fec_ini_Act ?? "",
                oE_Reporte_Competencia.Fec_fin_Act ?? "",
                oE_Reporte_Competencia.Txt_Grupo_Objetivo ?? "",
                oE_Reporte_Competencia.Cant_Personal ?? "",
                oE_Reporte_Competencia.Premio ?? "",
                oE_Reporte_Competencia.Mecanica ?? "",
                oE_Reporte_Competencia.Mat_Apoyo ?? "",
                oE_Reporte_Competencia.Observaciones ?? "",
                oE_Reporte_Competencia.FechaRegistro ?? "",
                oE_Reporte_Competencia.Latitud ?? "",
                oE_Reporte_Competencia.Longitud ?? "",
                oE_Reporte_Competencia.OrigenCoordenada ?? "",
                oE_Reporte_Competencia.Fec_Comunicacion ?? "",
                oE_Reporte_Competencia.Id_empresa ?? "",
                oE_Reporte_Competencia.Tipo_competencia ?? "",
                AppEnvia, "");
                foreach (E_Reporte_Competencia_Detalle detalle in oE_Reporte_Competencia.CompetenciaDetalle)
                {
                    Registrar_Competencia_Web_Detalle(detalle, id_reg_competencia);
                }
                #endregion

                Registrar_Competencia_Web_Foto(oE_Reporte_Competencia);
            }
            catch (Exception ex) { }
            
        }
        private void Registrar_Competencia_Web_Detalle(E_Reporte_Competencia_Detalle oE_Reporte_Competencia_Detalle, string Id_Reg_Competencia)
        {
            try
            {
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("STP_JVM_INSERTAR_COMPETENCIA_02_DETALLE", Id_Reg_Competencia
                    , oE_Reporte_Competencia_Detalle.Id_pop ?? null);
            }
            catch (Exception ex) { }
        }
        private void Registrar_Competencia_Web_Foto(E_Reporte_Competencia oE_Reporte_Competencia)
        {
            try
            {
                oCoon = new Conexion(2);
                //Insertar Foto Tipo de Proceso por defecto 1
                oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
                Convert.ToInt32(oE_Reporte_Competencia.Person_id),
                oE_Reporte_Competencia.Equipo_id ?? "",
                oE_Reporte_Competencia.Cliente_id ?? "",
                oE_Reporte_Competencia.ClientePDV_Code ?? "",
                2,//Reporte Competencia
                oE_Reporte_Competencia.FechaRegistro ?? "",
                oE_Reporte_Competencia.Comentario_Foto ?? "",
                DecodeFrom64(oE_Reporte_Competencia.Foto),
                "");//oE_Reporte_Fotografico.NombreFoto
            }
            catch (Exception ex) { }
        }

        #endregion

        #region Servicio Aplicativo Movil Movistar


        public string Registrar_Competencia_Mov(List<E_Reporte_Competencia_Mov> oListaReporte, string AppEnvia) {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Competencia_Mov oE_Reporte in oListaReporte)
                {
                    Registrar_Competencia_Mov_Cabecera(oE_Reporte, AppEnvia);
                    error += "";
                }
                
            }
            catch (Exception ex) {
                error += ex.Message;
                throw ex;
            }
            return error;
        }
        private void Registrar_Competencia_Mov_Cabecera(E_Reporte_Competencia_Mov oE_Reporte, string AppEnvia)
        {
            try
            {
                oCoon = new Conexion(3);
               
                string id_reg_competencia = "";
                id_reg_competencia = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_COMPETENCIA_V_1_1", 40,
                    oE_Reporte.Cod_Persona,
                    oE_Reporte.Cod_Equipo,
                    oE_Reporte.Cod_Compania,
                    oE_Reporte.Cod_PtoVenta,
                    oE_Reporte.Cod_Categoria ?? null,
                    oE_Reporte.Cod_Marca ?? null,
                    oE_Reporte.Cod_Tipo_Prom ?? null,
                    oE_Reporte.Cod_Tipo_Act ?? null,
                    oE_Reporte.Cod_Grupo_Obj ?? null,
                    oE_Reporte.Precio_Costo ?? null,
                    oE_Reporte.Precio_PDV ?? null,
                    oE_Reporte.Precio_Regular ?? null,
                    oE_Reporte.Precio_Oferta ?? null,
                    oE_Reporte.Fec_Ini_Act ?? null,
                    oE_Reporte.Fec_Fin_Act ?? null,
                    oE_Reporte.Txt_Grupo_Obj ?? null,
                    oE_Reporte.Cant_Personal ?? null,
                    oE_Reporte.Premio ?? null,
                    oE_Reporte.Mecanica ?? null,
                    oE_Reporte.Mat_Apoyo ?? null,
                    oE_Reporte.Cod_Empresa ?? null,
                    oE_Reporte.Programa ?? null,
                    oE_Reporte.Descripcion_Actividad ?? null,
                    oE_Reporte.Cod_Material ?? null,
                    oE_Reporte.Descripcion_Material ?? null,
                    oE_Reporte.Tasa_Interes ?? null,
                    oE_Reporte.Cod_Banco ?? null,
                    oE_Reporte.Proporcion_Materia ?? null,
                    oE_Reporte.Proporcion_Efectiva ?? null,
                    oE_Reporte.Tipo_Competencia ?? null,
                    oE_Reporte.Observaciones ?? null,
                    oE_Reporte.Fec_Comunicacion ?? null,
                    oE_Reporte.Fecha_Registro,
                    oE_Reporte.Latitud ?? null,
                    oE_Reporte.Longitud ?? null,
                    oE_Reporte.Origen ?? null,
                    oE_Reporte.Nombre_Foto ?? null,
                    oE_Reporte.Precio_Mayorista ?? null,    //Add 05/09/2012 PSalas 
                    oE_Reporte.MObservacion ?? null,        //Add 05/09/2012 PSalas 
                    AppEnvia ?? "0", "");
                #region Backup 05/09/2012 PSalas 
                //id_reg_competencia = oCoon.ejecutarretornodeOUTPUT("SP_GES_OPE_REGISTRAR_COMPETENCIA", 38,
                //  oE_Reporte.Cod_Persona,
                //  oE_Reporte.Cod_Equipo,
                //  oE_Reporte.Cod_Compania,
                //  oE_Reporte.Cod_PtoVenta,
                //  oE_Reporte.Cod_Categoria ?? null,
                //  oE_Reporte.Cod_Marca ?? null,
                //  oE_Reporte.Cod_Tipo_Prom ?? null,
                //  oE_Reporte.Cod_Tipo_Act ?? null,
                //  oE_Reporte.Cod_Grupo_Obj ?? null,
                //  oE_Reporte.Precio_Costo ?? null,
                //  oE_Reporte.Precio_PDV ?? null,
                //  oE_Reporte.Precio_Regular ?? null,
                //  oE_Reporte.Precio_Oferta ?? null,
                //  oE_Reporte.Fec_Ini_Act ?? null,
                //  oE_Reporte.Fec_Fin_Act ?? null,
                //  oE_Reporte.Txt_Grupo_Obj ?? null,
                //  oE_Reporte.Cant_Personal ?? null,
                //  oE_Reporte.Premio ?? null,
                //  oE_Reporte.Mecanica ?? null,
                //  oE_Reporte.Mat_Apoyo ?? null,
                //  oE_Reporte.Cod_Empresa ?? null,
                //  oE_Reporte.Programa ?? null,
                //  oE_Reporte.Descripcion_Actividad ?? null,
                //  oE_Reporte.Cod_Material ?? null,
                //  oE_Reporte.Descripcion_Material ?? null,
                //  oE_Reporte.Tasa_Interes ?? null,
                //  oE_Reporte.Cod_Banco ?? null,
                //  oE_Reporte.Proporcion_Materia ?? null,
                //  oE_Reporte.Proporcion_Efectiva ?? null,
                //  oE_Reporte.Tipo_Competencia ?? null,
                //  oE_Reporte.Observaciones ?? null,
                //  oE_Reporte.Fec_Comunicacion ?? null,
                //  oE_Reporte.Fecha_Registro,
                //  oE_Reporte.Latitud ?? null,
                //  oE_Reporte.Longitud ?? null,
                //  oE_Reporte.Origen ?? null,
                //  oE_Reporte.Nombre_Foto ?? null,
                //  AppEnvia ?? "0", "");
                #endregion

                foreach (E_Reporte_Competencia_Mov_Detalle detalle in oE_Reporte.Detalle)
                {
                    Registrar_Competencia_Mov_Detalle(detalle, id_reg_competencia);
                }

            }
            catch (Exception ex) {
                throw ex;
            }
        
        }
        private void Registrar_Competencia_Mov_Detalle(E_Reporte_Competencia_Mov_Detalle oE_Reporte_Competencia_Detalle, string id_reg_competencia)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_COMPETENCIA_DETALLE",
                id_reg_competencia,
                oE_Reporte_Competencia_Detalle.Cod_Mat_Apoyo ?? null,
                oE_Reporte_Competencia_Detalle.Nombre_Foto ?? null);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
     


        #endregion
    }
}
