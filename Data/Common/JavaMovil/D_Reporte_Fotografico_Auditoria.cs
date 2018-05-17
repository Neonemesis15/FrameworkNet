using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Fotografico_Auditoria
    {
        private Conexion oCoon;
        public D_Reporte_Fotografico_Auditoria()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }
        public void RegistrarReporteFotografico(List<E_Reporte_Fotografico_Auditoria> listFotos)
        {
            oCoon = new Conexion(2);

            foreach (E_Reporte_Fotografico_Auditoria oE_Reporte_Fotografico in listFotos)
                RegistrarReporteFotografico(oE_Reporte_Fotografico);
        }

        public void RegistrarReporteFotografico(E_Reporte_Fotografico_Auditoria oE_Reporte_Fotografico, E_Visita oE_Visita)
        {

            D_Visita oD_Visita = new D_Visita();
            oD_Visita.RegistrarVisita(oE_Visita);

            //Tipo de Reporte por Defecto 01
            oCoon = new Conexion(2);
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO",
                Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                //El atributo Perfil_Id se reemplaza por el Canal_Id
                oE_Reporte_Fotografico.canal_id,
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
            foreach (E_Foto_Auditoria Foto in oE_Reporte_Fotografico.listFotos)
            {
                oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
                Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                oE_Reporte_Fotografico.canal_id,
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

        public void RegistrarReporteFotografico(E_Reporte_Fotografico_Auditoria oE_Reporte_Fotografico)
        {
            //Tipo de Reporte por Defecto 01
            oCoon = new Conexion(2);
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO",
                Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                //El atributo Perfil_Id se reemplaza por el Canal_Id
                oE_Reporte_Fotografico.canal_id,
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
            foreach (E_Foto_Auditoria Foto in oE_Reporte_Fotografico.listFotos)
            {
                oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
                Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
                oE_Reporte_Fotografico.canal_id,
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

        #region metodos Util
        //Convierte a byte[] un string Add 13/01/2012
        public static byte[] DecodeFrom64(String encodedData)
        {

            byte[] encodedDataAsBytes

                = System.Convert.FromBase64String(encodedData);
            return encodedDataAsBytes;

        }
        #endregion

    }
}
