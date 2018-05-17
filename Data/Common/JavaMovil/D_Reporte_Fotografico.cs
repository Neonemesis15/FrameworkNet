using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Fotografico
    {


         private Conexion oCoon;
         public D_Reporte_Fotografico()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }
        #region  AppMovil Lucky
        public void RegistrarReporteFotografico(List<E_Reporte_Fotografico_General> listFotos)
        {
            oCoon = new Conexion(2);

            foreach (E_Reporte_Fotografico_General oE_Reporte_Fotografico in listFotos)
                RegistrarReporteFotografico(oE_Reporte_Fotografico);
        }
        public void RegistrarReporteFotografico(E_Reporte_Fotografico_General oE_Reporte_Fotografico, E_Visita oE_Visita)
        {
            try
            {
                D_Visita oD_Visita = new D_Visita();
                oD_Visita.RegistrarVisita(oE_Visita);

                //Tipo de Reporte por Defecto 01
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO",
                    Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                    //El atributo Perfil_Id se reemplaza por el Canal_Id
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
                foreach (E_Foto Foto in oE_Reporte_Fotografico.listFotos)
                {
                    oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
                    Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                    oE_Reporte_Fotografico.Perfil_id,
                    oE_Reporte_Fotografico.Equipo_id,
                    oE_Reporte_Fotografico.Cliente_id,
                    oE_Reporte_Fotografico.ClientePDV_Code,
                    1,
                    oE_Reporte_Fotografico.FechaRegistro,
                    oE_Reporte_Fotografico.Comentario,
                    DecodeFrom64(Foto.foto),
                    " "//oE_Reporte_Fotografico.NombreFoto
                    );
                }
            }
            catch (Exception ex) { }
        }
        public void RegistrarReporteFotografico(E_Reporte_Fotografico_General oE_Reporte_Fotografico)
        {
            try
            {
                //Tipo de Reporte por Defecto 01
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO",
                    Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                    //El atributo Perfil_Id se reemplaza por el Canal_Id
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
                foreach (E_Foto Foto in oE_Reporte_Fotografico.listFotos)
                {
                    oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
                    Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                    oE_Reporte_Fotografico.Perfil_id,
                    oE_Reporte_Fotografico.Equipo_id,
                    oE_Reporte_Fotografico.Cliente_id,
                    oE_Reporte_Fotografico.ClientePDV_Code,
                    1,
                    oE_Reporte_Fotografico.FechaRegistro,
                    oE_Reporte_Fotografico.Comentario,
                    DecodeFrom64(Foto.foto),
                    " "
                        //oE_Reporte_Fotografico.NombreFoto
                    );
                }
            }
            catch (Exception ex) { 
            }
        }
        public string RegistrarReporteFotografico(E_Reporte_Fotografico_General oE_Reporte_Fotografico, string AppEnvia)
        {
            string error = string.Empty;
            try
            {
                //Tipo de Reporte por Defecto 01
                oCoon = new Conexion(2);
                oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO",
                    Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                    //El atributo Perfil_Id se reemplaza por el Canal_Id
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
                foreach (E_Foto Foto in oE_Reporte_Fotografico.listFotos)
                {
                    oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
                    Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                    oE_Reporte_Fotografico.Perfil_id,
                    oE_Reporte_Fotografico.Equipo_id,
                    oE_Reporte_Fotografico.Cliente_id,
                    oE_Reporte_Fotografico.ClientePDV_Code,
                    1,
                    oE_Reporte_Fotografico.FechaRegistro,
                    oE_Reporte_Fotografico.Comentario,
                    DecodeFrom64(Foto.foto),
                    " "
                        //oE_Reporte_Fotografico.NombreFoto
                    );
                }
                error += "";
            }
            catch (Exception ex)
            {
                error += ex.Message;
            }
            return error;
        }
        public string RegistrarReporteFotografico(List<E_Reporte_Fotografico_General> oLista_EReporte_Fotografico, string AppEnvia)
        {
            string error = string.Empty;
            try
            {
                foreach (E_Reporte_Fotografico_General oE_Reporte_Fotografico in oLista_EReporte_Fotografico)
                {
                    //Tipo de Reporte por Defecto 01
                    oCoon = new Conexion(2);
                    oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO",
                        Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                        //El atributo Perfil_Id se reemplaza por el Canal_Id
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
                    foreach (E_Foto Foto in oE_Reporte_Fotografico.listFotos)
                    {
                        oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
                        Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                        oE_Reporte_Fotografico.Perfil_id,
                        oE_Reporte_Fotografico.Equipo_id,
                        oE_Reporte_Fotografico.Cliente_id,
                        oE_Reporte_Fotografico.ClientePDV_Code,
                        1,
                        oE_Reporte_Fotografico.FechaRegistro,
                        oE_Reporte_Fotografico.Comentario,
                        DecodeFrom64(Foto.foto),
                        " "
                            //oE_Reporte_Fotografico.NombreFoto
                        );
                    }
                    error += "";
                }
            }
            catch (Exception ex)
            {
                error += ex.Message;
            }
            return error;
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
        #endregion

        #region AppMovil Movistar
        #region Todos los Clientes
        /// <summary>
        /// Descripción : Registrar Reporte Fotografico para App Movistar.
        /// Fecha       : 18/05/2012 PSA.
        /// </summary>
        /// <param name="oLista_Reporte"></param>
        /// 
        String error = string.Empty;
        public string RegistrarReporteFotografico_Mov(List<E_Reporte_Fotografico_Mov> oLista_Reporte, int AppEnvia)
        {
            try
            { 
            foreach (E_Reporte_Fotografico_Mov oE_Reporte_Fotografico_Mov in oLista_Reporte)
            {
                RegistrarReporteFotografico_Mov_Cabecera(oE_Reporte_Fotografico_Mov, AppEnvia);
                error += "";
            }
                }
            catch (Exception ex )
            {
                error += ex.Message;
                throw ex;
            }

            return error;


        }
        /// <summary>
        /// Actualizacion
        /// Fecha       : 22/08/2012
        /// Descripcion : Se agrega el parametro SubReporte.
        /// Author      : Pablo Salas A.
        /// </summary>
        /// <param name="oE_Reporte_Fotografico"></param>
        /// <param name="AppEnvia"></param>
        private void RegistrarReporteFotografico_Mov_Cabecera(E_Reporte_Fotografico_Mov oE_Reporte_Fotografico, int AppEnvia)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_FOTOGRAFIA_V_1_1"
                ,Convert.ToInt32(oE_Reporte_Fotografico.Cod_Persona)
                ,oE_Reporte_Fotografico.Cod_Equipo
                ,oE_Reporte_Fotografico.Cod_Compania
                ,oE_Reporte_Fotografico.Cod_PtoVenta
                ,oE_Reporte_Fotografico.Cod_Categoria
                ,oE_Reporte_Fotografico.Cod_Marca 
                , oE_Reporte_Fotografico.Comentario ?? null
                , oE_Reporte_Fotografico.Nombre_Foto ?? null
                , oE_Reporte_Fotografico.Fec_Registro
                , oE_Reporte_Fotografico.Latitud ?? null
                , oE_Reporte_Fotografico.Longitud ?? null
                , oE_Reporte_Fotografico.Origen ?? null
                ,oE_Reporte_Fotografico.Cod_SubReporte ?? null //Add 22/08/2012 PSalas
                ,AppEnvia);
                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Cliente CocaCola
        //String error = string.Empty;
        //14/11/2012 psa RegistrarFotoCocaCola
        public string RegRepFoto_Mov_Coca(List<E_Reporte_Fotografico_Mov> oLista_Reporte)
        {
            string error="";
            try
            {
                foreach (E_Reporte_Fotografico_Mov oE_Reporte_Fotografico_Mov in oLista_Reporte)
                {
                    RegRepFoto_Mov_Cab_Coca(oE_Reporte_Fotografico_Mov);
                    error += "";
                }
            }
            catch (Exception ex)
            {
                error += ex.Message;
                throw ex;
            }

            return error;


        }
        //14/11/2012 psa. RegistrarFotoParaCocaCola
        private void RegRepFoto_Mov_Cab_Coca(E_Reporte_Fotografico_Mov oE_Reporte_Fotografico)
        {
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_OPE_REGISTRAR_FOTOGRAFIA_COCA",
                  oE_Reporte_Fotografico.Cod_PtoVenta
                , oE_Reporte_Fotografico.Nombre_Foto ?? null
                , oE_Reporte_Fotografico.Fec_Registro
                );


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion
        #endregion

    }
}
