using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    //CreateBy: Ing. Mauricio Ortiz
    //CreateDate: 29/05/2009
    //Description: Atributos Entidad Product_Packing
    //Requerimiento:
    public class DProductPacking
    {
        private Conexion oConn;
        public DProductPacking()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Método para Registrar Empaquetamientos de producto
        /// <summary>
        /// Se agregan los object para hacer la actualizacion Ing.Carlos Hernandez
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
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERPRODPACKING", iid_Product, iid_Packing, dPeso,
            iUnitsByPacking, sProductPackinUnitOfMeasure, bProductPackingStatus, sProductPacking_CreateBy, tProductPacking_DateBy,
                sProductPacking_ModiBy, tProductPacking_DateModiby);
            EProductPacking oerProdPacking = new EProductPacking();

            oerProdPacking.id_Product = iid_Product;
            oerProdPacking.id_Packing = iid_Packing;
            oerProdPacking.Peso = dPeso;
            oerProdPacking.UnitsByPacking = iUnitsByPacking;
            oerProdPacking.ProductPackinUnitOfMeasure = sProductPackinUnitOfMeasure;
            oerProdPacking.ProductPackingStatus = bProductPackingStatus;
            oerProdPacking.ProductPacking_CreateBy = sProductPacking_CreateBy;
            oerProdPacking.ProductPacking_DateBy = tProductPacking_DateBy;
            oerProdPacking.ProductPacking_ModiBy = sProductPacking_ModiBy;
            oerProdPacking.ProductPacking_DateModiby = tProductPacking_DateModiby;
            

            return oerProdPacking;
        }

        /// <summary>
        ///Método: Buscar Empaquetamientos de producto
        ///Función: Permite Consultar empaquetamientos de productos
        /// </summary>

        public DataTable ObtenerProductPacking(int iid_Product)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHPRODUCTPACKING", iid_Product);
            EProductPacking oeProductPacking = new EProductPacking();            

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeProductPacking.id_Packing = Convert.ToInt32(dt.Rows[i]["id_Packing"].ToString().Trim());
                        oeProductPacking.UnitsByPacking = Convert.ToInt32(dt.Rows[i]["UnitsByPacking"].ToString().Trim());
                        oeProductPacking.ProductPackingStatus = Convert.ToBoolean(dt.Rows[i]["ProductPackingStatus"].ToString().Trim());
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
        ///Método: Buscar Empaquetamientos de producto
        ///Función: Permite Consultar empaquetamientos de productos que se desea actualizar
        /// </summary>
        public DataTable ObtenerProductPackingActual(int iid_Product, int iid_Packing)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHPRODUCTPACKINGACTUAL", iid_Product,iid_Packing);
            EProductPacking oeProductPacking = new EProductPacking();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeProductPacking.id_Packing = Convert.ToInt32(dt.Rows[i]["id_Packing"].ToString().Trim());
                        oeProductPacking.UnitsByPacking = Convert.ToInt32(dt.Rows[i]["UnitsByPacking"].ToString().Trim());
                        oeProductPacking.ProductPackingStatus = Convert.ToBoolean(dt.Rows[i]["ProductPackingStatus"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }



        //Método para Actualizar ProductPacking

        public EProductPacking Actualizar_ProductPacking( int iid_Product, int iid_Packing, decimal dPeso, int iUnitsByPacking,
            string sProductPackinUnitOfMeasure, bool bProductPackingStatus, string sProductPacking_ModiBy, DateTime tProductPacking_DateModiby)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_PRODUCTpacking", iid_Product, iid_Packing, dPeso, iUnitsByPacking,
             sProductPackinUnitOfMeasure, bProductPackingStatus, sProductPacking_ModiBy, tProductPacking_DateModiby);

            EProductPacking oeaProducPacking = new EProductPacking();

            oeaProducPacking.id_Product = iid_Product;
            oeaProducPacking.id_Packing = iid_Packing;
            oeaProducPacking.Peso = dPeso;
            oeaProducPacking.UnitsByPacking = iUnitsByPacking;
            oeaProducPacking.ProductPackinUnitOfMeasure = sProductPackinUnitOfMeasure;
            oeaProducPacking.ProductPackingStatus = bProductPackingStatus;
            oeaProducPacking.ProductPacking_ModiBy = sProductPacking_ModiBy;
            oeaProducPacking.ProductPacking_DateModiby = tProductPacking_DateModiby;            

            return oeaProducPacking;
        }
    }
}


