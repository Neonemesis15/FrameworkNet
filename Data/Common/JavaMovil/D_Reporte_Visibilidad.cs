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
    public class D_Reporte_Visibilidad
    {
          private Conexion oCoon;
          public D_Reporte_Visibilidad()
          {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }

        #region Cliente Altomayo 02/03/2012
        
        //public void Registra_Visibilidad_Altomayo_Lista(List<E_Reporte_Visibilidad> oListE_Reporte_Visibilidad, List<E_Reporte_Fotografico> oListFoto)
        //{

        //    foreach (E_Reporte_Visibilidad oE_Reporte_Visibilidad in oListE_Reporte_Visibilidad)
        //        Registrar_Visibilidad_Altomayo(oE_Reporte_Visibilidad);

        //    foreach (E_Reporte_Fotografico oE_Reporte_Fotografico in oListFoto)
        //        Registrar_Visibilidad_Altomayo_Foto(oE_Reporte_Fotografico);

        //}
        private string id = "";
        public void  Registrar_Visibilidad_Altomayo(E_Reporte_Visibilidad oE_Reporte_Visibilidad)
        {
            string id_reg_Visibilidad = "";
            oCoon = new Conexion(2);
            id = oCoon.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_VISIBILIDAD_02", 14, oE_Reporte_Visibilidad.Person_id ?? "",
                oE_Reporte_Visibilidad.Perfil_id ?? "", oE_Reporte_Visibilidad.Equipo_id ?? "", oE_Reporte_Visibilidad.Cliente_id ?? "",
                oE_Reporte_Visibilidad.ClientePDV_Code ?? "", oE_Reporte_Visibilidad.Categoria_id ?? "", oE_Reporte_Visibilidad.Marca_id ?? "",
                oE_Reporte_Visibilidad.FechaRegistro ?? "", oE_Reporte_Visibilidad.Latitud ?? "", oE_Reporte_Visibilidad.Longitud ?? "",
                oE_Reporte_Visibilidad.OrigenCoordenada ?? "", oE_Reporte_Visibilidad.TipoCanal ?? "", oE_Reporte_Visibilidad.Comentario ?? "",
                id_reg_Visibilidad);
            foreach (E_Reporte_Visibilidad_Detalle detalle in oE_Reporte_Visibilidad.VisibilidadDetalle)
            {
                Registrar_Visibilidad_Altomayo_Detalle(detalle);
            }
        }

        private void Registrar_Visibilidad_Altomayo_Detalle(E_Reporte_Visibilidad_Detalle oE_Reporte_Visibilidad_Detalle)
        {
            oCoon = new Conexion(2);
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_VISIBILIDAD_02_DETALLE", id, oE_Reporte_Visibilidad_Detalle.Id_material ?? "",
                oE_Reporte_Visibilidad_Detalle.Status ?? "", oE_Reporte_Visibilidad_Detalle.Cantidad ?? "", DecodeFrom64(oE_Reporte_Visibilidad_Detalle.Foto) );
        }

        //public void  Registrar_Visibilidad_Altomayo_Foto(E_Reporte_Fotografico oE_Reporte_Fotografico)
        //{
        //    #region
        //    ////Tipo de Reporte por Defecto 01
        //    //oCoon = new Conexion(2);
        //    //oCoon.ejecutarDataTable("STP_JVM_INSERTAR_REPORTE_FOTOGRAFICO",
        //    //    Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
        //    //    oE_Reporte_Fotografico.Perfil_id,
        //    //    oE_Reporte_Fotografico.Equipo_id,
        //    //    oE_Reporte_Fotografico.Cliente_id,
        //    //    oE_Reporte_Fotografico.ClientePDV_Code,
        //    //    "01",
        //    //    oE_Reporte_Fotografico.Categoria_id,
        //    //    oE_Reporte_Fotografico.Marca_id,
        //    //    oE_Reporte_Fotografico.FechaRegistro,
        //    //    oE_Reporte_Fotografico.Latitud,
        //    //    oE_Reporte_Fotografico.Longitud,
        //    //    oE_Reporte_Fotografico.OrigenCoordenada, " "
        //    //    //oE_Reporte_Fotografico.TipoReporteFotografico_id
        //    //    );
        //    #endregion

        //    //Insertar Foto Tipo de Proceso por defecto 1
        //    oCoon.ejecutarDataTable("stp_jvm_INSERTAR_FOTO",
        //        Convert.ToInt32(oE_Reporte_Fotografico.Person_id),
        //        oE_Reporte_Fotografico.Perfil_id,
        //        oE_Reporte_Fotografico.Equipo_id,
        //        oE_Reporte_Fotografico.Cliente_id,
        //        oE_Reporte_Fotografico.ClientePDV_Code,
        //        8, //Tipo de Proceso Visibilidad ModiBy pSalas 02/03/2012 envie 'V'
        //        oE_Reporte_Fotografico.FechaRegistro,
        //        oE_Reporte_Fotografico.Comentario,
        //        DecodeFrom64(oE_Reporte_Fotografico.Foto1 + oE_Reporte_Fotografico.Foto2 + oE_Reporte_Fotografico.Foto3 + oE_Reporte_Fotografico.Foto4 + oE_Reporte_Fotografico.Foto5 + oE_Reporte_Fotografico.Foto6),
        //        " " //oE_Reporte_Fotografico.NombreFoto
        //        );

        //}
        
        #endregion

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
