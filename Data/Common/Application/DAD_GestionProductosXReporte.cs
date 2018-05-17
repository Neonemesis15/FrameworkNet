using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
   public class DAD_GestionProductosXReporte
    {
       private Conexion oConn;
       public DAD_GestionProductosXReporte()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

       public EAD_GestionProductosXReporte RegistrarGR(int iCompany_id, string scod_Channel, int iReport_id, bool bVista_Categoria, bool bVista_Marca, bool bVista_SubMarca, bool bVista_Familia, bool bVista_SubFamilia, bool bVista_Producto, string sid_Tipo_Reporte, bool bRelInfo_Status, string sRelInfo_CreateBy, DateTime tRelInfo_DateBy, string sRelInfo_ModiBy, DateTime tRelInfo_DateModiBy)
       {
           oConn = new Conexion(1);
           string id_RelInfo_prodcutos = oConn.ejecutarEscalar("UP_WEBXPLORA_AD_REGISTERGR", iCompany_id, scod_Channel, iReport_id, bVista_Categoria, bVista_Marca, bVista_SubMarca, bVista_Familia, bVista_SubFamilia, bVista_Producto, sid_Tipo_Reporte, bRelInfo_Status, sRelInfo_CreateBy, tRelInfo_DateBy, sRelInfo_ModiBy, tRelInfo_DateModiBy);
           EAD_GestionProductosXReporte oerGestionR = new EAD_GestionProductosXReporte();

           oerGestionR.id_RelInfo_prodcutos = Convert.ToInt32(id_RelInfo_prodcutos);
           oerGestionR.Company_id = iCompany_id;
           oerGestionR.cod_Channel = scod_Channel;
           oerGestionR.Report_id = iReport_id;
           oerGestionR.Vista_Categoria = bVista_Categoria;
           oerGestionR.Vista_Marca =bVista_Marca;
           oerGestionR.Vista_SubMarca = bVista_SubMarca;
           oerGestionR.Vista_Familia = bVista_Familia;
           oerGestionR.Vista_SubFamilia = bVista_SubFamilia;
           oerGestionR.Vista_Producto=bVista_Producto;
           oerGestionR.id_Tipo_Reporte = sid_Tipo_Reporte;
           oerGestionR.RelInfo_Status = bRelInfo_Status;
           oerGestionR.RelInfo_CreateBy = sRelInfo_CreateBy;
           oerGestionR.RelInfo_DateBy = tRelInfo_DateBy;
           oerGestionR.RelInfo_ModiBy = sRelInfo_ModiBy;
           oerGestionR.RelInfo_DateModiBy = tRelInfo_DateModiBy;


           return oerGestionR;

       }

       public EAD_GestionProductosXReporte RegistrarGRPKTMP(int id_RelInfo_prodcutos, int iCompany_id, string scod_Channel, int iReport_id, bool bVista_Categoria, bool bVista_Marca, bool bVista_SubMarca, bool bVista_Familia, bool bVista_Producto, string sid_Tipo_Reporte)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERGRTMP", id_RelInfo_prodcutos, iCompany_id, scod_Channel, iReport_id, bVista_Categoria, bVista_Marca, bVista_SubMarca, bVista_Familia , bVista_Producto, sid_Tipo_Reporte);
            EAD_GestionProductosXReporte oerGRTMP = new EAD_GestionProductosXReporte();
            return oerGRTMP;
        }




       public DataTable ObtenerGR(int iCompany_id, string scod_Channel, int iReport_id)
       {
           oConn = new Conexion(1);
           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTARAD_PRODUCTOXREPORTE", iCompany_id, scod_Channel, iReport_id);
           EAD_GestionProductosXReporte oeGestionR = new EAD_GestionProductosXReporte();

           //if (dt != null)
           //{
           //    if (dt.Rows.Count > 0)
           //    {
           //        for (int i = 0; i <= dt.Rows.Count - 1; i++)
           //        {
           //            oeGestionR.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
           //            oeGestionR.cod_Channel = dt.Rows[i]["cod_Channel"].ToString().Trim();
           //            oeGestionR.Report_id = Convert.ToInt32(dt.Rows[i]["Report_id"].ToString().Trim());
           //            oeGestionR.Vista_Categoria = Convert.ToBoolean(dt.Rows[i]["Vista_Categoria"].ToString().Trim());
           //            oeGestionR.Vista_Marca = Convert.ToBoolean(dt.Rows[i]["Vista_Marca"].ToString().Trim());
           //            oeGestionR.Vista_SubMarca = Convert.ToBoolean(dt.Rows[i]["Vista_SubMarca"].ToString().Trim());
           //            oeGestionR.Vista_Familia = Convert.ToBoolean(dt.Rows[i]["Vista_Familia"].ToString().Trim());
           //            oeGestionR.Vista_SubFamilia = Convert.ToBoolean(dt.Rows[i]["Vista_SubFamilia"].ToString().Trim());
           //            oeGestionR.Vista_Producto = Convert.ToBoolean(dt.Rows[i]["Vista_Producto"].ToString().Trim());
           //            oeGestionR.id_Tipo_Reporte = dt.Rows[i]["id_Tipo_Reporte"].ToString().Trim();
           //            oeGestionR.RelInfo_Status = Convert.ToBoolean(dt.Rows[i]["RelInfo_Status"].ToString().Trim());
           //            oeGestionR.RelInfo_CreateBy = dt.Rows[i]["RelInfo_CreateBy"].ToString().Trim();
           //            oeGestionR.RelInfo_DateBy = Convert.ToDateTime(dt.Rows[i]["RelInfo_DateBy"].ToString().Trim());
           //            oeGestionR.RelInfo_ModiBy = dt.Rows[i]["RelInfo_ModiBy"].ToString().Trim();
           //            oeGestionR.RelInfo_DateModiBy = Convert.ToDateTime(dt.Rows[i]["RelInfo_DateModiBy"].ToString().Trim());
           //            oeGestionR.id_RelInfo_prodcutos = Convert.ToInt32(dt.Rows[i]["id_RelInfo_prodcutos"].ToString().Trim());
           //        }
           //    }
               return dt;
           //}
           //else
           //{
           //    return null;
           //}
       }

       public EAD_GestionProductosXReporte Actualizar_ParametroReport(int iid_RelInfo_prodcutos, bool bVista_Categoria, bool bVista_Marca, bool bVista_SubMarca, bool bVista_Familia, bool bVista_SubFamilia , bool bVista_Producto, bool bRelInfo_Status, string sRelInfo_ModiBy, DateTime tRelInfo_DateModiBy)
       {
           oConn = new Conexion(1);
           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARPARAMETROREPORTE", iid_RelInfo_prodcutos, bVista_Categoria, bVista_Marca, bVista_SubMarca, bVista_Familia, bVista_SubFamilia, bVista_Producto, bRelInfo_Status, sRelInfo_ModiBy, tRelInfo_DateModiBy);
           EAD_GestionProductosXReporte OEAParametroReporte = new EAD_GestionProductosXReporte();

           //OEAParametroReporte.Company_id = iCompany_id;
           //OEAParametroReporte.Name_Oficina = sName_Oficina;
           //OEAParametroReporte.Abreviatura = sAbreviatura;
           //OEAParametroReporte.Orden = iOrden;
           //OEAParametroReporte.Oficina_Status = bOficina_Status;
           //OEAParametroReporte.Oficina_ModiBy = sOficina_ModiBy;
           //OEAParametroReporte.Oficina_DateModiBy = tOficina_DateModiBy;

           return OEAParametroReporte;
       }
      

    }
}
