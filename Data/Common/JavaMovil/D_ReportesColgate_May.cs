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
    public class D_ReportesColgate_May
    {
        private Conexion oCoon;
        public D_ReportesColgate_May() {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }

        #region AppMovil Lucky
        /// <summary>
        /// Fecha: 19/04/2012
        /// Autor: Joseph Gonzales
        /// Descripción: Se agrega la validación para evitar que se releve datos duplicados en un periodo x PDV x Reporte x Opción de Reporte x SKU, para los canales Mayor y Menor
        /// y se agrega el reporte de Codigos ITT
        /// </summary> 
        public string RegistrarReportesColgate_Mayoristas(List<E_Reporte_Presencia> oListE_Reporte_Presencia, List<E_Reporte_Fotografico> oListE_Reporte_Fotografico, List<E_Reporte_Codigo_ITT> oListE_Reporte_CodigoITT, E_Visita oE_Visita)
        {

            oCoon = new Conexion(2);

            string mensaje = "";
            int valor = 1;

            foreach (E_Reporte_Fotografico oE_Reporte_Fotografico in oListE_Reporte_Fotografico)
            {
                //Solo inserta en caso de que no exista un reporte fotografico teniendo en cuenta: Person_id,Equipo_id,Cliente_id,ClientePDV_Code, Categoria_id, Fecha_Registro
                //Hasta resolver el inconveniente de envio de Fotos Duplicadas en LuckyGestor
                //04/04/2012 pSalas 
                DataTable dt = oCoon.ejecutarDataTable("SP_JMV_EXISTE_FOTO", oE_Reporte_Fotografico.Person_id,oE_Reporte_Fotografico.Equipo_id,
                oE_Reporte_Fotografico.Cliente_id,oE_Reporte_Fotografico.ClientePDV_Code,"01",oE_Reporte_Fotografico.Categoria_id,oE_Reporte_Fotografico.FechaRegistro);
                if (dt.Rows[0]["EXISTE_FOTO"].ToString() == "0")
                {
                    RegistrarReporteFotografico(oE_Reporte_Fotografico);
                }
            }
           
            foreach (E_Reporte_Presencia oReporte_Presencia in oListE_Reporte_Presencia)
            {
                if (oReporte_Presencia.OpcionReporte_id == "04" || oReporte_Presencia.OpcionReporte_id == "05")
                {
                    //Verificar si Existe Producto para Presencia Colgate, para un Id_Equipo,Id_Cliente,ClientePDV_Code,Categoria_id y periodo  20/03/2012 pSalas
                    //En caso de Existir no insertará un nuevo registro.
                    foreach (E_Reporte_Presencia_Detalle oDetalle in oReporte_Presencia.PresenciaDetalle)
                    {
                        DataTable dt = oCoon.ejecutarDataTable("STP_JVM_VERIFICAR_PRODUCTO", oReporte_Presencia.Equipo_id, oReporte_Presencia.Cliente_id, oReporte_Presencia.ClientPDV_Code, oReporte_Presencia.Categoria_id, oReporte_Presencia.OpcionReporte_id,
                          oReporte_Presencia.FechaRegistro, oDetalle.Codigo);
                        if (dt.Rows[0]["EXISTE_CAB"].ToString() == "1" && dt.Rows[0]["EXISTE_PRO"].ToString() == "0")
                        {
                            //insertar Detalle
                            RegistrarReportePresenciaDetalle(oDetalle, dt.Rows[0]["ID_REG_PRESENCIA"].ToString());
                            valor = valor * 1;
                        }
                        else if (dt.Rows[0]["EXISTE_CAB"].ToString() == "0" && dt.Rows[0]["EXISTE_PRO"].ToString() == "0")
                        {
                            //Registrar Cabecera y Detalle
                            RegistrarReportePresencia(oReporte_Presencia);
                            valor = valor * 1;
                        }
                        else
                        {
                            valor = valor * 0;
                        }

                    }
                }
                //
                else if (oReporte_Presencia.OpcionReporte_id == "03")
                {
                    //Verificar si Existe Material de Apoyo, para un Id_Equipo, Id_Cliente, ClientePVD_Code y periodo. pSalas. 02/04/2012
                    //En caso de Existir no insertará un nuevo registro.
                    foreach (E_Reporte_Presencia_Detalle oDetalle in oReporte_Presencia.PresenciaDetalle)
                    {
                        DataTable dt = oCoon.ejecutarDataTable("STP_JVM_VERIFICAR_MATERIAL_APOYO", oReporte_Presencia.Equipo_id, oReporte_Presencia.Cliente_id, oReporte_Presencia.ClientPDV_Code, oReporte_Presencia.OpcionReporte_id,
                             oReporte_Presencia.FechaRegistro, oDetalle.Codigo);
                        if (dt.Rows[0]["EXISTE_CAB"].ToString() == "1" && dt.Rows[0]["EXISTE_MATERIAL_APOYO"].ToString() == "0")
                        {
                            //insertar Detalle
                            RegistrarReportePresenciaDetalle(oDetalle, dt.Rows[0]["ID_REG_PRESENCIA"].ToString());
                            valor = valor * 1;
                        }
                        else if (dt.Rows[0]["EXISTE_CAB"].ToString() == "0" && dt.Rows[0]["EXISTE_MATERIAL_APOYO"].ToString() == "0")
                        {
                            //Registrar Cabecera y Detalle
                            RegistrarReportePresencia(oReporte_Presencia);
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
                    RegistrarReportePresencia(oReporte_Presencia);
                    valor = valor * 1;
                }
            }

            D_Reporte_Codigo_ITT dReporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            dReporte_Codigo_ITT.Registrar_Presencia_Codigo_ITT(oListE_Reporte_CodigoITT);
            
            D_Visita oD_Visita = new D_Visita();
            oD_Visita.RegistrarVisita(oE_Visita);

            if (valor == 1) { mensaje = "Registro Ok"; } else { mensaje = "Obs: Algunos insumos de Pres.Colg, Pres.Comp. y/o Elem. Vis. ya fueron ingresados"; }
            return mensaje;
        }
        public void RegistrarReporteFotografico(E_Reporte_Fotografico oE_Reporte_Fotografico)
        {
            //Tipo de Reporte por Defecto 01
            oCoon = new Conexion(2);
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO", 
                Convert.ToInt32(oE_Reporte_Fotografico.Person_id), 
                oE_Reporte_Fotografico.Perfil_id, 
                oE_Reporte_Fotografico.Equipo_id, 
                oE_Reporte_Fotografico.Cliente_id,
                oE_Reporte_Fotografico.ClientePDV_Code,
                "01", 
                oE_Reporte_Fotografico.Categoria_id, 
                oE_Reporte_Fotografico.Marca_id, 
                oE_Reporte_Fotografico.FechaRegistro, 
                oE_Reporte_Fotografico.Latitud, 
                oE_Reporte_Fotografico.Longitud, 
                oE_Reporte_Fotografico.OrigenCoordenada, " "
                //oE_Reporte_Fotografico.TipoReporteFotografico_id
                );


            //Insertar Foto Tipo de Proceso por defecto 1
            oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO", 
                Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                oE_Reporte_Fotografico.Perfil_id, 
                oE_Reporte_Fotografico.Equipo_id, 
                oE_Reporte_Fotografico.Cliente_id, 
                oE_Reporte_Fotografico.ClientePDV_Code, 
                1, 
                oE_Reporte_Fotografico.FechaRegistro, 
                oE_Reporte_Fotografico.Comentario,
                DecodeFrom64(oE_Reporte_Fotografico.Foto1 + oE_Reporte_Fotografico.Foto2 + oE_Reporte_Fotografico.Foto3 + oE_Reporte_Fotografico.Foto4 + oE_Reporte_Fotografico.Foto5 + oE_Reporte_Fotografico.Foto6), 
                " "
                //oE_Reporte_Fotografico.NombreFoto
                );

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
        #region RegistrarPresenciaColgate
        public string id = "";
        public string aux_OpcionReporte_id = "";
        public E_Reporte_Presencia RegistrarReportePresencia(E_Reporte_Presencia oEReportePresencia_aux)
        {


            string id_reg_Presencia = "";
            oCoon = new Conexion(2);
            id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_PRESENCIA_New", 14, int.Parse(oEReportePresencia_aux.Person_id),
            oEReportePresencia_aux.Perfil_id, oEReportePresencia_aux.Equipo_id, oEReportePresencia_aux.Cliente_id,
            oEReportePresencia_aux.ClientPDV_Code,
            oEReportePresencia_aux.Categoria_id, oEReportePresencia_aux.Marca_id, oEReportePresencia_aux.OpcionReporte_id,
            oEReportePresencia_aux.FechaRegistro,
            oEReportePresencia_aux.Latitud, oEReportePresencia_aux.Longitud, oEReportePresencia_aux.OrigenCoordenada,
            oEReportePresencia_aux.TipoCanal,
            oEReportePresencia_aux.Comentario, id_reg_Presencia);

            aux_OpcionReporte_id = oEReportePresencia_aux.OpcionReporte_id;

            E_Reporte_Presencia oE_Reporte_Presencia = new E_Reporte_Presencia();


            oE_Reporte_Presencia.Person_id = oEReportePresencia_aux.Person_id;
            oE_Reporte_Presencia.Perfil_id = oEReportePresencia_aux.Perfil_id;
            oE_Reporte_Presencia.Equipo_id = oEReportePresencia_aux.Equipo_id;
            oE_Reporte_Presencia.Cliente_id = oEReportePresencia_aux.Cliente_id;
            oE_Reporte_Presencia.ClientPDV_Code = oEReportePresencia_aux.ClientPDV_Code;
            oE_Reporte_Presencia.Categoria_id = oEReportePresencia_aux.Categoria_id;
            oE_Reporte_Presencia.Marca_id = oEReportePresencia_aux.Marca_id;
            oE_Reporte_Presencia.OpcionReporte_id = oEReportePresencia_aux.OpcionReporte_id;
            oE_Reporte_Presencia.FechaRegistro = oEReportePresencia_aux.FechaRegistro;
            oE_Reporte_Presencia.Latitud = oEReportePresencia_aux.Latitud;
            oE_Reporte_Presencia.Longitud = oEReportePresencia_aux.Longitud;
            oE_Reporte_Presencia.OrigenCoordenada = oEReportePresencia_aux.OrigenCoordenada;
            oE_Reporte_Presencia.TipoCanal = oEReportePresencia_aux.TipoCanal;
            oE_Reporte_Presencia.Comentario = oEReportePresencia_aux.Comentario;
            oE_Reporte_Presencia.Id_reg_presencia = int.Parse(id);
            foreach (E_Reporte_Presencia_Detalle detalle in oEReportePresencia_aux.PresenciaDetalle)
                RegistrarReportePresenciaDetalle(detalle);

            return oE_Reporte_Presencia;

            //oListE_Reporte_Presencia.Add(oE_Reporte_Presencia);

            //return oListE_Reporte_Presencia;
        }

        public E_Reporte_Presencia_Detalle RegistrarReportePresenciaDetalle(E_Reporte_Presencia_Detalle detalle)
        {

            oCoon = new Conexion(2);
            E_Reporte_Presencia_Detalle oE_Reporte_Presencia_Detalle = new E_Reporte_Presencia_Detalle();

            DataTable dt = oCoon.ejecutarDataTable("STP_JVM_INSERTAR_PRESENCIA_DETALLE_New",
            Convert.ToInt64(id), detalle.Codigo, detalle.ValorDetalle, aux_OpcionReporte_id);

            oE_Reporte_Presencia_Detalle.Id_Reg_Presencia = Convert.ToInt64(id);
            oE_Reporte_Presencia_Detalle.Codigo = detalle.Codigo;
            oE_Reporte_Presencia_Detalle.ValorDetalle = detalle.ValorDetalle;
            oE_Reporte_Presencia_Detalle.OpcionReporte_id = aux_OpcionReporte_id;

            return oE_Reporte_Presencia_Detalle;

        }

        public E_Reporte_Presencia_Detalle RegistrarReportePresenciaDetalle(E_Reporte_Presencia_Detalle detalle, string id_reg_presencia)
        {

            oCoon = new Conexion(2);
            E_Reporte_Presencia_Detalle oE_Reporte_Presencia_Detalle = new E_Reporte_Presencia_Detalle();

            DataTable dt = oCoon.ejecutarDataTable("STP_JVM_INSERTAR_PRESENCIA_DETALLE_New",
            Convert.ToInt64(id_reg_presencia), detalle.Codigo, detalle.ValorDetalle, aux_OpcionReporte_id);

            oE_Reporte_Presencia_Detalle.Id_Reg_Presencia = Convert.ToInt64(id_reg_presencia);
            oE_Reporte_Presencia_Detalle.Codigo = detalle.Codigo;
            oE_Reporte_Presencia_Detalle.ValorDetalle = detalle.ValorDetalle;
            oE_Reporte_Presencia_Detalle.OpcionReporte_id = aux_OpcionReporte_id;

            return oE_Reporte_Presencia_Detalle;

        }

        #endregion
        #endregion 

        #region AppMovil Movistar
        /// <summary>
        /// Descripcion : Registrar Reportes de Colgate Mayorista para el App Movistar
        /// Fecha       : 18/05/2012 PSA
        /// </summary>
        /// <param name="oListRepPresencia"></param>
        /// <param name="oListRepFotogradico"></param>
        /// <param name="oListRepITT"></param>
        /// <param name="oE_Visita"></param>
        /// <returns></returns>
        public E_Reportes_Colgate_Mayoristas_Mov_Response Registrar_ReportesColgateMay_Mov(
            List<E_Reporte_Presencia_Mov> oListRepPresencia, 
            List<E_Reporte_Fotografico_Mov> oListRepFotogradico, 
            List<E_Reporte_Codigo_ITT_Mov> oListRepITT, 
            E_Visita_Mov oE_Visita, int AppEnvia) {
            
            D_Reporte_Presencia oD_Reporte_Presencia = new D_Reporte_Presencia();
            D_Reporte_Codigo_ITT oD_Reporte_Codigo_ITT = new D_Reporte_Codigo_ITT();
            D_Reporte_Fotografico oD_Reporte_Fotografico = new D_Reporte_Fotografico();
            D_Visita oD_Visita = new D_Visita();
            
            String mensaje_Presencia = string.Empty;
            String mensaje_Fotografico = string.Empty;
            String mensaje_Visita = string.Empty;

            
            E_Reportes_Colgate_Mayoristas_Mov_Response oE_Reportes_Colgate_Mayoristas_Mov_Response = new E_Reportes_Colgate_Mayoristas_Mov_Response();
            try
            {
                mensaje_Presencia = oD_Reporte_Presencia.Registrar_Presencia_Mov(oListRepPresencia, AppEnvia);
                mensaje_Fotografico = oD_Reporte_Fotografico.RegistrarReporteFotografico_Mov(oListRepFotogradico, AppEnvia);
                mensaje_Visita = oD_Visita.RegistrarVisita_Mov(oE_Visita);

                if (!mensaje_Fotografico.Equals(""))
                    mensaje_Fotografico = "Hubo Errores en Reporte Fotográfico. ";
                if (!mensaje_Visita.Equals(""))
                    mensaje_Visita = "Hubo Errores en Registro de Visita. ";
                
                //oE_Reportes_Colgate_Mayoristas_Mov_Response.Registro_Reporte_Codigo_ITT_Mov_Response = oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListRepITT);
                oD_Reporte_Codigo_ITT.Registrar_Codigo_ITT_Mov(oListRepITT);
                oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response = mensaje_Fotografico + mensaje_Presencia + mensaje_Visita;

                
            }
            catch (Exception ex) { 
            
            }
            return oE_Reportes_Colgate_Mayoristas_Mov_Response;

            //return mensaje_Final = mensaje_Presencia + mensaje_Fotografico + mensaje_Codigo_ITT + mensaje_Visita;
        }
        #endregion
    }
}
