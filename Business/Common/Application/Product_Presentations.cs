using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Descripción Clase Product_Presentations
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate: 27/08/2009
    /// Requerimiento:

    public class Product_Presentations
    {
        public Product_Presentations()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        //Método que permite registrar Presentación de Productos

        /// <summary>
        ///Modificado: se agregan 3 campos : id_ProductCategory, id_Subcategory y id_Brand. y se modifica tipo de dato de string a long para: lidProductPresentation
        /// 24/08/2010 Magaly Jiménez
        /// Modificado: se quita parametro idProductPresentation por el cabio realizado de tipo de dato.
        /// 25/08/2010 por: Magaly jiménez
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
        /// <param name="sProductPresentation_CreateBy"></param>
        /// <param name="tProductPresentation_DateBy"></param>
        /// <param name="sProductPresentation_ModiBy"></param>
        /// <param name="tProductPresentation_DateModiBy"></param>
        /// <returns>oePresentation</returns>

        public EProduct_Presentations RegistrarPresentation(string sidProductPresentation, string sid_ProductCategory, long lid_Subcategory, int iid_Brand,  string sEmpaquetamiento, string  sUnidad_Empaque ,string sProductPresentationName, decimal dProductPresentation_Neto,
            int iid_UnitOfMeasure, bool bProductPresentation_Status, string sProductPresentation_CreateBy, DateTime tProductPresentation_DateBy, string sProductPresentation_ModiBy,
            DateTime tProductPresentation_DateModiBy)
        {
            DProduct_Presentations odrPresentation = new DProduct_Presentations();
            EProduct_Presentations oePresentation = odrPresentation.RegistrarPresentationPK( sidProductPresentation, sid_ProductCategory, lid_Subcategory, iid_Brand, sEmpaquetamiento, sUnidad_Empaque, sProductPresentationName, dProductPresentation_Neto,
                iid_UnitOfMeasure, bProductPresentation_Status, sProductPresentation_CreateBy, tProductPresentation_DateBy, sProductPresentation_ModiBy, tProductPresentation_DateModiBy);
            odrPresentation = null;
            return oePresentation;
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
        public EProduct_Presentations RegistrarPresentationTMP(string sidProductPresentation,  string sProductPresentationName, decimal dProductPresentation_Neto,
            int iid_UnitOfMeasure, bool bProductPresentation_Status)
        {
            DProduct_Presentations odrPresentationtmp = new DProduct_Presentations();
            EProduct_Presentations oePresentationtmp = odrPresentationtmp.RegistrarPresentationPKTMP(sidProductPresentation, sProductPresentationName, dProductPresentation_Neto,
                iid_UnitOfMeasure, bProductPresentation_Status);
            odrPresentationtmp = null;
            return oePresentationtmp;
        }


        // Método que permite consultar Presentación de productos
        /// <summary>
        /// Modificiación: se quita parametro de consulta id_ProductPresentation y se agregan 2: id_ProductCategory y id_Brand  y se modifica tipo de dato de string a long para: lidProductPresentation
        /// 24/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sProductPresentationName"></param>
        /// <returns>dtPresentation</returns>

        public DataTable BuscarPresentation(string sid_ProductCategory, int iid_Brand, string sProductPresentationName)
        {
            DProduct_Presentations odsPresentation = new DProduct_Presentations();
            EProduct_Presentations oePresentation = new EProduct_Presentations();
            DataTable dtPresentation = odsPresentation.ConsultarPresentacion(sid_ProductCategory, iid_Brand, sProductPresentationName);

            odsPresentation = null;
            return dtPresentation;
        }
        //Metodo que permite actualizar Presentación de productos
        /// <summary>
        /// Modificiación: se agregan 3 columnas para actualzación id_ProductCategory, id_Subcategory y id_Brand  y se modifica tipo de dato de string a long para: lidProductPresentation
        /// 24/08/2010 Magaly Jiménez
        /// 30/08/2010 se agregan dos parametros nuevos  sEmpaquetamiento,  iUnidad_Empaque . Ing. Mauricio Ortiz

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

        public EProduct_Presentations ActualizarPresentation(string sidProductPresentation, string sid_ProductCategory, long lid_Subcategory, int iid_Brand, string sEmpaquetamiento, string sUnidad_Empaque ,string sProductPresentationName, decimal dProductPresentation_Neto,
            int iid_UnitOfMeasure, bool bProductPresentation_Status,string sProductPresentation_ModiBy, DateTime tProductPresentation_DateModiBy)
        {
            DProduct_Presentations odaPresentation = new DProduct_Presentations();
            EProduct_Presentations oeaPresentation = odaPresentation.ActualizarPresentation( sidProductPresentation,  sid_ProductCategory, lid_Subcategory, iid_Brand, sEmpaquetamiento,sUnidad_Empaque,  sProductPresentationName, dProductPresentation_Neto,iid_UnitOfMeasure, bProductPresentation_Status,
             sProductPresentation_ModiBy, tProductPresentation_DateModiBy);
            odaPresentation = null;
            return oeaPresentation;
        }
    }
}
       