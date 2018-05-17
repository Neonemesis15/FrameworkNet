using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
   public class AD_GestionProductosXReporte
    {
       public AD_GestionProductosXReporte()
        {
            //Se define el constructor por defecto.
        }


       public EAD_GestionProductosXReporte RegistrarGR(int iCompany_id, string scod_Channel, int iReport_id, bool bVista_Categoria, bool bVista_Marca, bool bVista_SubMarca, bool bVista_Familia, bool bVista_SubFamilia, bool bVista_Producto, string sid_Tipo_Reporte, bool bRelInfo_Status, string sRelInfo_CreateBy, DateTime tRelInfo_DateBy, string sRelInfo_ModiBy, DateTime tRelInfo_DateModiBy)
        {
            DAD_GestionProductosXReporte odrGestionR = new DAD_GestionProductosXReporte();
            EAD_GestionProductosXReporte oeORG = odrGestionR.RegistrarGR(iCompany_id, scod_Channel, iReport_id, bVista_Categoria, bVista_Marca, bVista_SubMarca, bVista_Familia, bVista_SubFamilia, bVista_Producto, sid_Tipo_Reporte, bRelInfo_Status, sRelInfo_CreateBy, tRelInfo_DateBy, sRelInfo_ModiBy, tRelInfo_DateModiBy);
            odrGestionR = null;
            return oeORG;
        }


       public EAD_GestionProductosXReporte RegistrarGRtmp(int id_RelInfo_prodcutos, int iCompany_id, string scod_Channel, int iReport_id, bool bVista_Categoria, bool bVista_Marca, bool bVista_SubMarca, bool bVista_Familia, bool bVista_Producto, string sid_Tipo_Reporte)
         {
             DAD_GestionProductosXReporte odrGRtmp = new DAD_GestionProductosXReporte();
             EAD_GestionProductosXReporte oeGRtmp = odrGRtmp.RegistrarGRPKTMP(id_RelInfo_prodcutos, iCompany_id, scod_Channel, iReport_id, bVista_Categoria, bVista_Marca, bVista_SubMarca, bVista_Familia, bVista_Producto, sid_Tipo_Reporte);
             odrGRtmp = null;
             return oeGRtmp;
         }


         public DataTable ConsultarGR(int iCompany_id, string scod_channel, int iReport_id)
         {
             DAD_GestionProductosXReporte odsRG = new DAD_GestionProductosXReporte();
             EAD_GestionProductosXReporte oeaGR = new EAD_GestionProductosXReporte();
             DataTable dtORG = odsRG.ObtenerGR(iCompany_id, scod_channel, iReport_id);
             odsRG = null;
             return dtORG;
         }


         public EAD_GestionProductosXReporte Actualizar_ParametroReport(int iid_RelInfo_prodcutos, bool bVista_Categoria, bool bVista_Marca, bool bVista_SubMarca, bool bVista_Familia, bool bVista_SubFamilia, bool bVista_Producto, bool bRelInfo_Status, string sRelInfo_ModiBy, DateTime tRelInfo_DateModiBy)
         {
             DAD_GestionProductosXReporte odaPAraReport = new DAD_GestionProductosXReporte();
             EAD_GestionProductosXReporte oeaPGR = odaPAraReport.Actualizar_ParametroReport(iid_RelInfo_prodcutos, bVista_Categoria, bVista_Marca, bVista_SubMarca, bVista_Familia, bVista_SubFamilia, bVista_Producto, bRelInfo_Status, sRelInfo_ModiBy, tRelInfo_DateModiBy);
             odaPAraReport = null;
             return oeaPGR;
         }
           

    }
}
