using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para operar Product_Presentations
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate: 27/08/2009
    /// Requerimiento:

    public class DProduct_Presentations
    {
        private Conexion oConn;
        public DProduct_Presentations()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Metodo para Registrar Presentación de Producto
        /// <summary>
        /// Modificado: se agregan 3 campos : id_ProductCategory, id_Subcategory y id_Brand. y se modifica tipo de dato de string a long para: lidProductPresentation
        /// 24/08/2010 Magaly Jiménez
        /// Modificado: se quita parametro idProductPresentation por el cabio realizado de tipo de dato.
        /// 25/08/2010 por: Magaly jiménez
        /// 30/08/2010 se agregan dos parametros nuevos  sEmpaquetamiento,  sUnidad_Empaque . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="lidProductPresentation"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="lid_Subcategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sEmpaquetamiento"></param>
        /// <param name="sUnidad_Empaque"></param>
        /// <param name="dProductPresentation_Neto"></param>
        /// <param name="iid_UnitOfMeasure"></param>
        /// <param name="bProductPresentation_Status"></param>
        /// <param name="sProductPresentation_CreateBy"></param>
        /// <param name="tProductPresentation_DateBy"></param>
        /// <param name="sProductPresentation_ModiBy"></param>
        /// <param name="tProductPresentation_DateModiBy"></param>
        /// <returns>oerPresentation</returns>
        public EProduct_Presentations RegistrarPresentationPK( string sidProductPresentation, string sid_ProductCategory, long lid_Subcategory,  int iid_Brand, string sEmpaquetamiento, string sUnidad_Empaque , string sProductPresentationName, decimal dProductPresentation_Neto,
            int iid_UnitOfMeasure,bool bProductPresentation_Status, string sProductPresentation_CreateBy, DateTime tProductPresentation_DateBy, string sProductPresentation_ModiBy,
            DateTime tProductPresentation_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTER_PRESENTATION", sidProductPresentation, sid_ProductCategory, lid_Subcategory, iid_Brand, sEmpaquetamiento, sUnidad_Empaque, sProductPresentationName, dProductPresentation_Neto,
                iid_UnitOfMeasure, bProductPresentation_Status, sProductPresentation_CreateBy, tProductPresentation_DateBy, sProductPresentation_ModiBy, tProductPresentation_DateModiBy);
            EProduct_Presentations oerPresentation = new EProduct_Presentations();
            oerPresentation.id_ProductPresentation = sidProductPresentation;
            oerPresentation.id_ProductCategory = sid_ProductCategory;
            oerPresentation.id_Subcategory = lid_Subcategory;
            oerPresentation.id_Brand = iid_Brand;
            oerPresentation.Empaquetamiento = sEmpaquetamiento;
            oerPresentation.Unidad_Empaque = sUnidad_Empaque;
            oerPresentation.ProductPresentationName = sProductPresentationName;
            oerPresentation.ProductPresentation_Neto = dProductPresentation_Neto;
            oerPresentation.id_UnitOfMeasure = iid_UnitOfMeasure;
            oerPresentation.ProductPresentation_Status = bProductPresentation_Status;
            oerPresentation.ProductPresentation_CreateBy = sProductPresentation_CreateBy;
            oerPresentation.ProductPresentation_DateBy = tProductPresentation_DateBy;
            oerPresentation.ProductPresentation_ModiBy = sProductPresentation_ModiBy;
            oerPresentation.ProductPresentation_DateModiBy = tProductPresentation_DateModiBy;
            return oerPresentation;
        }
        /// <summary>
        /// Inserta presentaciones en la Bd intermedia
        /// 31/01/2011 Magaly jiménez
        /// </summary>
        /// <param name="sidProductPresentation"></param>
        /// <param name="sProductPresentationName"></param>
        /// <param name="dProductPresentation_Neto"></param>
        /// <param name="iid_UnitOfMeasure"></param>
        /// <param name="bProductPresentation_Status"></param>
        /// <returns></returns>
             public EProduct_Presentations RegistrarPresentationPKTMP( string sidProductPresentation, string sProductPresentationName, decimal dProductPresentation_Neto,
            int iid_UnitOfMeasure,bool bProductPresentation_Status)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_PRESENTATIONTMP", sidProductPresentation,  sProductPresentationName, dProductPresentation_Neto,
                iid_UnitOfMeasure, bProductPresentation_Status);
            EProduct_Presentations oerPresentation = new EProduct_Presentations();
            oerPresentation.id_ProductPresentation = sidProductPresentation;
    
            oerPresentation.ProductPresentationName = sProductPresentationName;
            oerPresentation.ProductPresentation_Neto = dProductPresentation_Neto;
            oerPresentation.id_UnitOfMeasure = iid_UnitOfMeasure;
            oerPresentation.ProductPresentation_Status = bProductPresentation_Status;

            return oerPresentation;
        }

        //Método para Consultar Presentación de Producto
        /// <summary>
        /// Modificiación: se quita parametro de consulta id_ProductPresentation y se agregan 2: id_ProductCategory y id_Brand.  y se modifica tipo de dato de string a long para: lidProductPresentation
        /// 24/08/2010 Magaly Jiménez
        /// 30/08/2010 se agrega dos columnas nuevas en la consulta Empaquetamiento,  Unidad_Empaque . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sProductPresentationName"></param>
        /// <returns>dt</returns>
        public DataTable ConsultarPresentacion(string sid_ProductCategory, int iid_Brand, string sProductPresentationName )
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SEARCHPRESENTATION", sid_ProductCategory, iid_Brand, sProductPresentationName);
            EProduct_Presentations oecPresentation = new EProduct_Presentations();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oecPresentation.id_ProductPresentation = dt.Rows[i]["id_ProductPresentation"].ToString().Trim();
                        oecPresentation.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        oecPresentation.id_Subcategory = Convert.ToInt64(dt.Rows[i]["id_Subcategory"].ToString().Trim());
                        oecPresentation.id_Brand = Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                        oecPresentation.Empaquetamiento = (dt.Rows[i]["Empaquetamiento"].ToString().Trim());
                        oecPresentation.Unidad_Empaque = dt.Rows[i]["Unidad_Empaque"].ToString().Trim();
                        oecPresentation.ProductPresentationName = dt.Rows[i]["ProductPresentationName"].ToString().Trim();
                        oecPresentation.ProductPresentation_Neto = Convert.ToDecimal(dt.Rows[i]["ProductPresentation_Neto"].ToString().Trim());
                        oecPresentation.id_UnitOfMeasure = Convert.ToInt32(dt.Rows[i]["id_UnitOfMeasure"].ToString().Trim());
                        oecPresentation.ProductPresentation_Status = Convert.ToBoolean(dt.Rows[i]["ProductPresentation_Status"].ToString().Trim());
                        oecPresentation.ProductPresentation_CreateBy = dt.Rows[i]["ProductPresentation_CreateBy"].ToString().Trim();
                        oecPresentation.ProductPresentation_DateBy = Convert.ToDateTime(dt.Rows[i]["ProductPresentation_DateBy"].ToString().Trim());
                        oecPresentation.ProductPresentation_ModiBy = dt.Rows[i]["ProductPresentation_ModiBy"].ToString().Trim();
                        oecPresentation.ProductPresentation_DateModiBy = Convert.ToDateTime(dt.Rows[i]["ProductPresentation_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Método para Actualizar Presentación de Producto
        /// <summary>
        /// Modificiación: se agregan 3 columnas para actualzación id_ProductCategory, id_Subcategory y id_Brand.  y se modifica tipo de dato de string a long para: lidProductPresentation.
        /// 24/08/2010 Magaly Jiménez
        /// 30/08/2010 se agregan dos parametros nuevos  sEmpaquetamiento,  sUnidad_Empaque . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sidProductPresentation"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="lid_Subcategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sEmpaquetamiento"></param>
        /// <param name="sUnidad_Empaque"></param>
        /// <param name="sProductPresentationName"></param>
        /// <param name="dProductPresentation_Neto"></param>
        /// <param name="iid_UnitOfMeasure"></param>
        /// <param name="bProductPresentation_Status"></param>
        /// <param name="sProductPresentation_ModiBy"></param>
        /// <param name="tProductPresentation_DateModiBy"></param>
        /// <returns>oeaPresentation</returns>
        public EProduct_Presentations ActualizarPresentation(string sidProductPresentation, string sid_ProductCategory, long lid_Subcategory, int iid_Brand, string sEmpaquetamiento, string sUnidad_Empaque, string sProductPresentationName, decimal dProductPresentation_Neto,
            int iid_UnitOfMeasure, bool bProductPresentation_Status, string sProductPresentation_ModiBy, DateTime tProductPresentation_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZARPRESENTATION", sidProductPresentation, sid_ProductCategory, lid_Subcategory, iid_Brand,  sEmpaquetamiento,  sUnidad_Empaque ,sProductPresentationName, dProductPresentation_Neto
            ,iid_UnitOfMeasure, bProductPresentation_Status, sProductPresentation_ModiBy, tProductPresentation_DateModiBy);
            EProduct_Presentations oeaPresentation = new EProduct_Presentations();
            oeaPresentation.id_ProductPresentation = sidProductPresentation;
            oeaPresentation.id_ProductCategory = sid_ProductCategory;
            oeaPresentation.id_Subcategory = lid_Subcategory;
            oeaPresentation.id_Brand = iid_Brand;
            oeaPresentation.Empaquetamiento = sEmpaquetamiento;
            oeaPresentation.Unidad_Empaque = sUnidad_Empaque;
            oeaPresentation.ProductPresentationName = sProductPresentationName;
            oeaPresentation.ProductPresentation_Neto = dProductPresentation_Neto;
            oeaPresentation.id_UnitOfMeasure = iid_UnitOfMeasure;
            oeaPresentation.ProductPresentation_Status = bProductPresentation_Status;
            oeaPresentation.ProductPresentation_ModiBy = sProductPresentation_ModiBy;
            oeaPresentation.ProductPresentation_DateModiBy = tProductPresentation_DateModiBy;
            return oeaPresentation;
        }
    }
}
        
