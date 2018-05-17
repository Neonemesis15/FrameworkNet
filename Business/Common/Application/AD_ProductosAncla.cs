﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{ /// <summary>
    /// Clase: SubCategoria
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy:07/09/2010
    /// Description: Establece los metodos para operar informacion relacionada con los Productos Ancla
    /// Requerimiento No:
    /// </summary>
    /// 
    public class AD_ProductosAncla
    {
        public AD_ProductosAncla()
        {
            //Se define el constructor por defecto
        }
        /// <summary>
        /// inserta registro en tabla de ad_productosancla
        /// 07/09/2010 Magaly Jiménez
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
        /// <returns>oePAncla</returns>
        public EAD_ProductosAncla RegistrarPAncla(int iCompany_id, string sid_ProductCategory, long lid_Subcategory, string scod_Product, long lcod_Oficina, bool bpancla_Status, string spancla_CreateBy, DateTime tpancla_DateBy, string spancla_ModiBy, DateTime tpancla_DateModiBy)
        {
            DAD_ProductosAncla odrPAncla = new DAD_ProductosAncla();
            EAD_ProductosAncla oePAncla= odrPAncla.Registrar_PAncla(iCompany_id,  sid_ProductCategory, lid_Subcategory, scod_Product, lcod_Oficina, bpancla_Status, spancla_CreateBy, tpancla_DateBy, spancla_ModiBy, tpancla_DateModiBy);

            odrPAncla = null;
            return oePAncla;
        }
        /// <summary>
        /// Actualiza precio de lista en la tabla de productos desde el maestro de productos ancla.
        /// 07/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="scod_Product"></param>
        /// <param name="tProduct_PriceList"></param>
        /// <param name="sProduct_ModiBy"></param>
        /// <param name="tProduct_DateModiby"></param>
        /// <returns>oeapPancla</returns>
        public EProductos Actualizar_PrecioLista(string scod_Product, decimal tProduct_PriceList, string sProduct_ModiBy, DateTime tProduct_DateModiby)
        {
            DAD_ProductosAncla odapPAncla = new DAD_ProductosAncla();
            EProductos oeapPancla = odapPAncla.Actualizar_Preciodelista(scod_Product, tProduct_PriceList, sProduct_ModiBy, tProduct_DateModiby);
            odapPAncla = null;
            return oeapPancla;
        }
        /// <summary>
        /// Permite consultar productos ancla
        /// 08/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <returns></returns>
        public DataTable ConsultarPancla(int iCompany_id, string sid_ProductCategory, long lcod_Oficina)
        {
            DAD_ProductosAncla odsPancla = new DAD_ProductosAncla();
            EAD_ProductosAncla oePancla = new EAD_ProductosAncla();

            DataTable dtPancla = odsPancla.ConsultarPAncla(iCompany_id, sid_ProductCategory, lcod_Oficina);
            odsPancla = null;
            return dtPancla;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCompany_Name"></param>
        /// <param name="sName_Oficina"></param>
        /// <param name="sProduct_Category"></param>
        /// <param name="sName_Subcategory"></param>
        /// <param name="sName_Brand"></param>
        /// <param name="sProduct_Name"></param>
        /// <returns></returns>
        public DataSet ObteneridProducAncla(string sCompany_Name, string sName_Oficina, string sProduct_Category, string sName_Subcategory, string sName_Brand, string sProduct_Name)
        {
            DAD_ProductosAncla odpancla= new DAD_ProductosAncla();
            DataSet ds = new DataSet();
            ds = odpancla.ObteneridsProductosAncla(sCompany_Name, sName_Oficina, sProduct_Category, sName_Subcategory, sName_Brand, sProduct_Name);
            return ds;
        }



        /// <summary>
        /// Permite Actualizar productos Ancla
        /// 08/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="lid_pancla"></param>
        /// <param name="scod_Product"></param>
        /// <param name="bpancla_Status"></param>
        /// <param name="spancla_ModiBy"></param>
        /// <param name="tpancla_DateModiBy"></param>
        /// <returns>oeaPancla</returns>
        public EAD_ProductosAncla Actualizar_Pancla(long lid_pancla, long lid_Subcategory, string scod_Product, bool bpancla_Status, string spancla_ModiBy, DateTime tpancla_DateModiBy)
        {
            DAD_ProductosAncla odaPancla = new DAD_ProductosAncla();
            EAD_ProductosAncla oeaPancla=odaPancla.ActualizarPAncla(lid_pancla, lid_Subcategory, scod_Product, bpancla_Status, spancla_ModiBy, tpancla_DateModiBy);
            odaPancla = null;
            return oeaPancla;
        }
    }
}
