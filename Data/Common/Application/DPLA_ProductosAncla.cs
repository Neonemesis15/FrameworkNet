using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{

    /// <summary>
    /// Descripción: métodos para producto Ancla
    /// CreateBy: Carlos Marín Moreno
    /// CreateDate: 03-11-2011
    /// Requerimiento:
   public class DPLA_ProductosAncla
    {
           private Conexion oConn;
           public DPLA_ProductosAncla()
           {
               UserInterface oUserInterface = new UserInterface();
               oConn = new Conexion();
               oUserInterface = null;
           }
           /// <summary>
           /// inserta información de producto Ancla
           /// 03/11/2011 Carlos Marín Moreno
           /// </summary>
           /// <param name="iCompany_id"></param>
           /// <param name="sid_ProductCategory"></param>
           /// <param name="lid_Subcategory"></param>
           /// <param name="scod_Product"></param>
           /// <param name="bpancla_Status"></param>
           /// <param name="spancla_CreateBy"></param>
           /// <param name="tpancla_DateBy"></param>
           /// <param name="spancla_ModiBy"></param>
           /// <param name="tpancla_DateModiBy"></param>
           /// <returns>oerpancla</returns>
           public EPLA_ProductosAncla Registrar_PAncla(int iCompany_id, int iid_ReportsPlanning, string sid_ProductCategory, long lid_Subcategory, string scod_Product, long lcod_Oficina, bool bpancla_Status, string spancla_CreateBy, DateTime tpancla_DateBy, string spancla_ModiBy, DateTime tpancla_DateModiBy)
           {
               DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_PLA_REGISTER_PRODUCTOANCLA", iCompany_id, iid_ReportsPlanning, sid_ProductCategory, lid_Subcategory, scod_Product, lcod_Oficina, bpancla_Status, spancla_CreateBy, tpancla_DateBy, spancla_ModiBy, tpancla_DateModiBy);
               EPLA_ProductosAncla oerpancla = new EPLA_ProductosAncla();
               oerpancla.Company_id = iCompany_id;
               oerpancla.id_ReportsPlanning= iid_ReportsPlanning;
               oerpancla.id_ProductCategory = sid_ProductCategory;
               oerpancla.id_Subcategory = lid_Subcategory;
               oerpancla.cod_Product = scod_Product;
               oerpancla.cod_Oficina = lcod_Oficina;
               oerpancla.pancla_Status = bpancla_Status;
               oerpancla.pancla_CreateBy = spancla_CreateBy;
               oerpancla.pancla_DateBy = tpancla_DateBy;
               oerpancla.pancla_ModiBy = spancla_ModiBy;
               oerpancla.pancla_DateModiBy = tpancla_DateModiBy;
               return oerpancla;
           }
           /// <summary>
           /// Metodo que permite Acutalizar precio de lista en la tabla dbo.Productos
           /// 03/11/2011 Carlos Marín Moreno
           /// </summary>
           /// <param name="scod_Product"></param>
           /// <param name="tProduct_PriceList"></param>
           /// <param name="sProduct_ModiBy"></param>
           /// <param name="tProduct_DateModiby"></param>
           /// <returns></returns>
           public EProductos Actualizar_Preciodelista(string scod_Product, decimal tProduct_PriceList, string sProduct_ModiBy, DateTime tProduct_DateModiby)
           {
               DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_AD_ACTUALIZARPRECIODELISTA", scod_Product, tProduct_PriceList, sProduct_ModiBy, tProduct_DateModiby);
               //EAD_ProductosAncla oeaPrelistaPancla = new EAD_ProductosAncla();
               EProductos oeaprecio = new EProductos();
               oeaprecio.cod_Product = scod_Product;
               oeaprecio.Product_PriceList = tProduct_PriceList;
               oeaprecio.Product_ModiBy = sProduct_ModiBy;
               oeaprecio.Product_DateModiby = tProduct_DateModiby;


               return oeaprecio;
           }
           /// <summary>
           /// Metodo que permite Consultar producto ancla
           ///  03/11/2011 Carlos Marín Moreno
           /// </summary>
           /// <param name="iCompany_id"></param>
           /// <param name="sid_ProductCategory"></param>
           /// <returns></returns>
           public DataTable ConsultarPAncla(int iCompany_id, string sid_ProductCategory, long lcod_Oficina, string sid_Subcategory,int iidReportPlanning)
           {
               DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_CONSULTAPRODUCTOANCLA", iCompany_id, sid_ProductCategory, lcod_Oficina, sid_Subcategory, iidReportPlanning);
               EPLA_ProductosAncla oePancla = new EPLA_ProductosAncla();
               if (dt != null)
               {
                   if (dt.Rows.Count > 0)
                   {
                       for (int i = 0; i <= dt.Rows.Count - 1; i++)
                       {
                           oePancla.id_pancla = Convert.ToInt64(dt.Rows[i]["id_pancla"].ToString().Trim());
                           oePancla.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                           oePancla.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                           oePancla.id_Subcategory = Convert.ToInt64(dt.Rows[i]["id_Subcategory"].ToString().Trim());
                           oePancla.cod_Product = dt.Rows[i]["cod_Product"].ToString().Trim();
                           oePancla.cod_Oficina = Convert.ToInt64(dt.Rows[i]["cod_Oficina"].ToString().Trim());
                           oePancla.pancla_Status = Convert.ToBoolean(dt.Rows[i]["pancla_Status"].ToString().Trim());
                           oePancla.pancla_CreateBy = dt.Rows[i]["pancla_CreateBy"].ToString().Trim();
                           oePancla.pancla_DateBy = Convert.ToDateTime(dt.Rows[i]["pancla_DateBy"].ToString().Trim());
                           oePancla.pancla_ModiBy = dt.Rows[i]["pancla_ModiBy"].ToString().Trim();
                           oePancla.pancla_DateModiBy = Convert.ToDateTime(dt.Rows[i]["pancla_DateModiBy"].ToString().Trim());
                       }
                   }
                   return dt;
               }
               else
               {
                   return null;
               }

           }

           /// <summary>
           /// permite consultar id de carga masiva en pancla.
           /// 03/11/2011 Carlos Marín Moreno
           /// </summary>
           /// <param name="sCompany_Name"></param>
           /// <param name="sName_Oficina"></param>
           /// <param name="sProduct_Category"></param>
           /// <param name="sName_Subcategory"></param>
           /// <param name="sName_Brand"></param>
           /// <param name="sProduct_Name"></param>
           /// <returns></returns>

           public DataSet ObteneridsProductosAncla(string sCompany_Name, string sName_Oficina, string sProduct_Category, string sName_Subcategory, string sName_Brand, string sProduct_Name)
           {
               DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_AD_CONSULTAIDS_PRODUCTOSANCLA", sCompany_Name, sName_Oficina, sProduct_Category, sName_Subcategory, sName_Brand, sProduct_Name);
               return ds;
           }
           /// <summary>
           /// Permite Actualizar producto ancla,
           /// 08/09/2010 Magaly jiménez
           /// </summary>
           /// <param name="lid_pancla"></param>
           /// <param name="scod_Product"></param>
           /// <param name="bpancla_Status"></param>
           /// <param name="spancla_ModiBy"></param>
           /// <param name="tpancla_DateModiBy"></param>
           /// <returns>oeaPacla</returns>
           public EPLA_ProductosAncla ActualizarPAncla(long lid_pancla, int iid_ReportsPlanning, long lid_Subcategory, string scod_Product, bool bpancla_Status, string spancla_ModiBy, DateTime tpancla_DateModiBy)
           {
               DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_PLA_ACTUALIZARPANCLA", lid_pancla, iid_ReportsPlanning, lid_Subcategory, scod_Product, bpancla_Status, spancla_ModiBy, tpancla_DateModiBy);

               EPLA_ProductosAncla oeaPacla = new EPLA_ProductosAncla();
               oeaPacla.id_pancla = lid_pancla;
               oeaPacla.id_Subcategory = lid_Subcategory;
               oeaPacla.cod_Product = scod_Product;
               oeaPacla.pancla_Status = bpancla_Status;
               oeaPacla.pancla_ModiBy = spancla_ModiBy;
               oeaPacla.pancla_DateModiBy = tpancla_DateModiBy;

               return oeaPacla;
           }
       

    }
}
