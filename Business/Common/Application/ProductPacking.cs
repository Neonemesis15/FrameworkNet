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
    /// Clase: ProductPacking
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 29/05/2009
    /// Description: Establece los metodos para operar informacion relacionada con Empaquetamiento de Productos Lucky
    /// Requerimiento No:
    /// </summary>

    public class ProductPacking
    {
        public ProductPacking()
        {
            //Se define el constructor por defecto
        }

        //----Metodo que permite registrar Empaquetamiento de Productos
        /// <summary>
        /// Se cambia el parametro iPeso a Decimal Ing.Carlos Hernandez
        /// Se agregaron los objects para la insercion Ing.Carlos Hernandez  
        /// Se eliminaron los objects para la inserción ya que no deben ir en esta capa Ing. Mauricio Ortiz
        /// 
        /// </summary>
        /// <param name="iid_Packing"></param>
        /// <param name="iPeso"></param>
        /// <param name="sProductPackinUnitOfMeasure"></param>
        /// <param name="iUnitsByPacking"></param>
        /// <param name="scod_Product"></param>
        /// <returns></returns>


        public EProductPacking RegistrarProdPacking(int iid_Product, int iid_Packing, decimal dPeso,
            int iUnitsByPacking, string sProductPackinUnitOfMeasure, bool bProductPackingStatus, string sProductPacking_CreateBy, DateTime tProductPacking_DateBy,
                string sProductPacking_ModiBy, DateTime tProductPacking_DateModiby)
        {
            DProductPacking odrProdPacking = new DProductPacking();

            EProductPacking oeProdPacking = odrProdPacking.RegistrarProdPacking(iid_Product, iid_Packing, dPeso,
             iUnitsByPacking, sProductPackinUnitOfMeasure, bProductPackingStatus, sProductPacking_CreateBy, tProductPacking_DateBy,
                 sProductPacking_ModiBy, tProductPacking_DateModiby);

            odrProdPacking = null;
            return oeProdPacking;
        }

        //----Metodo que permite Actualizar ProductPacking  Ing. Mauricio Ortiz

        public EProductPacking Actualizar_ProductPacking(int iid_Product, int iid_Packing, decimal dPeso, int iUnitsByPacking,
            string sProductPackinUnitOfMeasure, bool bProductPackingStatus, string sProductPacking_ModiBy, DateTime tProductPacking_DateModiby)
        {
            Lucky.Data.Common.Application.DProductPacking odaProductPacking = new Lucky.Data.Common.Application.DProductPacking();
            EProductPacking oeaProductPacking = odaProductPacking.Actualizar_ProductPacking(iid_Product, iid_Packing, dPeso, iUnitsByPacking,
             sProductPackinUnitOfMeasure, bProductPackingStatus, sProductPacking_ModiBy, tProductPacking_DateModiby);

            odaProductPacking = null;
            return oeaProductPacking;
        }

        //---Metodo de Consulta de Productos Ing. Mauricio Ortiz

        public DataTable BuscarProductPacking(int iid_Product)
        {
            DProductPacking odseProductPacking = new DProductPacking();
            EProductPacking oeProductPacking = new EProductPacking();

            DataTable dtProductPacking = odseProductPacking.ObtenerProductPacking(iid_Product);
            odseProductPacking = null;
            return dtProductPacking;
        }

        //---Metodo de Consulta de empaquetamientos actuales para la actualización del Producto Ing. Mauricio Ortiz
        public DataTable BuscarProductPackingActual(int iid_Product,int iid_Packing)
        {
            DProductPacking odseProductPacking = new DProductPacking();
            EProductPacking oeProductPacking = new EProductPacking();

            DataTable dtProductPacking = odseProductPacking.ObtenerProductPackingActual(iid_Product,iid_Packing);
            odseProductPacking = null;
            return dtProductPacking;
        }
    }
}
       