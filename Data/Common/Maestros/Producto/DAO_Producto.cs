using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Producto;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Producto
{
    public class DAO_Producto
    {
        private Conexion oCoon;

        public DAO_Producto()
        {
            oCoon = new Conexion();
        }

        //public List<SR_Producto> Get_Productos(string codCategoria, string codMarca)
        //{
        //    /*
        //     * v.1.0 -  22 Oct. 2016    -   PSALAS  - Obtiene todas las Productos  
        //     */
        //    try
        //    {
        //        List<SR_Producto> oListSR_Producto = new List<SR_Producto>();
        //        IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_Productos", (codCategoria == null) ? "%" : codCategoria, (codMarca == null) ? "%" : codMarca);
        //        while (readerObj.Read())
        //        {
        //            SR_Producto oSR_Producto = new SR_Producto();
        //            oSR_Producto.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
        //            oSR_Producto.codigoint = readerObj.GetValue(readerObj.GetOrdinal("codigoint")).ToString().Trim();
        //            oSR_Producto.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
        //            oSR_Producto.alias = readerObj.GetValue(readerObj.GetOrdinal("alias")).ToString().Trim();
        //            oSR_Producto.precio_venta = readerObj.GetValue(readerObj.GetOrdinal("precio_venta")).ToString().Trim();
        //            oSR_Producto.precio_oferta = readerObj.GetValue(readerObj.GetOrdinal("precio_oferta")).ToString().Trim();
        //            oSR_Producto.stock = readerObj.GetValue(readerObj.GetOrdinal("stock")).ToString().Trim();
        //            oSR_Producto.promocion = readerObj.GetValue(readerObj.GetOrdinal("promocion")).ToString().Trim();
        //            oSR_Producto.categoria = readerObj.GetValue(readerObj.GetOrdinal("categoria")).ToString().Trim();
        //            oSR_Producto.subcategoria = readerObj.GetValue(readerObj.GetOrdinal("subcategoria")).ToString().Trim();
        //            oSR_Producto.familia = readerObj.GetValue(readerObj.GetOrdinal("familia")).ToString().Trim();
        //            oSR_Producto.marca = readerObj.GetValue(readerObj.GetOrdinal("marca")).ToString().Trim();
        //            oSR_Producto.tipo = readerObj.GetValue(readerObj.GetOrdinal("tipo")).ToString().Trim();
        //            oSR_Producto.formato = readerObj.GetValue(readerObj.GetOrdinal("formato")).ToString().Trim();
        //            oSR_Producto.fecha_creacion = readerObj.GetValue(readerObj.GetOrdinal("fecha_creacion")).ToString().Trim();
        //            oSR_Producto.creado_por = readerObj.GetValue(readerObj.GetOrdinal("creado_por")).ToString().Trim();
        //            oSR_Producto.fecha_modificacion = readerObj.GetValue(readerObj.GetOrdinal("fecha_modificacion")).ToString().Trim();
        //            oSR_Producto.modificado_por = readerObj.GetValue(readerObj.GetOrdinal("modificado_por")).ToString().Trim();		
        //            oListSR_Producto.Add(oSR_Producto);
        //        }
        //        readerObj.Close();
        //        if (oListSR_Producto.Count > 0)
        //        {
        //            return oListSR_Producto;
        //        }
        //        else
        //        {
        //            return null;
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
        
        public List<MA_Producto> Get_Productos(string codCategoria, string codMarca)
        {
            /*
             * v.1.0 -  22 Oct. 2016    -   PSALAS  - Obtiene todas las Productos  
             */
            try
            {
                List<MA_Producto> oListMA_Producto = new List<MA_Producto>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_Productos", (codCategoria == null) ? "%" : codCategoria, (codMarca == null) ? "%" : codMarca);
                while (readerObj.Read())
                {
                    MA_Producto oMA_Producto = new MA_Producto();
                    oMA_Producto.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_Producto.codigoint = readerObj.GetValue(readerObj.GetOrdinal("codigoint")).ToString().Trim();
                    oMA_Producto.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oMA_Producto.alias = readerObj.GetValue(readerObj.GetOrdinal("alias")).ToString().Trim();
                    oMA_Producto.precio_venta = readerObj.GetValue(readerObj.GetOrdinal("precio_venta")).ToString().Trim();
                    oMA_Producto.precio_oferta = readerObj.GetValue(readerObj.GetOrdinal("precio_oferta")).ToString().Trim();
                    oMA_Producto.stock = readerObj.GetValue(readerObj.GetOrdinal("stock")).ToString().Trim();
                    oMA_Producto.promocion = readerObj.GetValue(readerObj.GetOrdinal("promocion")).ToString().Trim();
                    oMA_Producto.cod_categoria = readerObj.GetValue(readerObj.GetOrdinal("cod_categoria")).ToString().Trim();
                    oMA_Producto.categoria = readerObj.GetValue(readerObj.GetOrdinal("categoria")).ToString().Trim();
                    oMA_Producto.cod_subcategoria = readerObj.GetValue(readerObj.GetOrdinal("cod_subcategoria")).ToString().Trim();
                    oMA_Producto.subcategoria = readerObj.GetValue(readerObj.GetOrdinal("subcategoria")).ToString().Trim();
                    oMA_Producto.cod_familia = readerObj.GetValue(readerObj.GetOrdinal("cod_familia")).ToString().Trim();
                    oMA_Producto.familia = readerObj.GetValue(readerObj.GetOrdinal("familia")).ToString().Trim();
                    oMA_Producto.cod_marca = readerObj.GetValue(readerObj.GetOrdinal("cod_marca")).ToString().Trim();
                    oMA_Producto.marca = readerObj.GetValue(readerObj.GetOrdinal("marca")).ToString().Trim();
                    oMA_Producto.cod_tipo = readerObj.GetValue(readerObj.GetOrdinal("cod_tipo")).ToString().Trim();
                    oMA_Producto.tipo = readerObj.GetValue(readerObj.GetOrdinal("tipo")).ToString().Trim();
                    oMA_Producto.cod_formato = readerObj.GetValue(readerObj.GetOrdinal("cod_formato")).ToString().Trim();
                    oMA_Producto.formato = readerObj.GetValue(readerObj.GetOrdinal("formato")).ToString().Trim();
                    oMA_Producto.fecha_creacion = readerObj.GetValue(readerObj.GetOrdinal("fecha_creacion")).ToString().Trim();
                    oMA_Producto.creado_por = readerObj.GetValue(readerObj.GetOrdinal("creado_por")).ToString().Trim();
                    oMA_Producto.fecha_modificacion = readerObj.GetValue(readerObj.GetOrdinal("fecha_modificacion")).ToString().Trim();
                    oMA_Producto.modificado_por = readerObj.GetValue(readerObj.GetOrdinal("modificado_por")).ToString().Trim();
                    oListMA_Producto.Add(oMA_Producto);
                }
                readerObj.Close();
                if (oListMA_Producto.Count > 0)
                {
                    return oListMA_Producto;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
        public string Insert_Producto(MA_Producto oMA_Producto) {
            
            /*
             * v.1.0 -  13 Nov. 2016    -   PSALAS  - Inserta Producto  
             */

            string codigoProducto="";
            try {
                codigoProducto = oCoon.ejecutarEscalar("PA_INSERT_Producto", 
                    oMA_Producto.codigo ?? null,
                    oMA_Producto.codigoint ?? null,
                    oMA_Producto.nombre ?? null,
                    oMA_Producto.alias ?? null,
                    oMA_Producto.precio_venta ?? null,
                    oMA_Producto.precio_oferta ?? null,
                    oMA_Producto.stock ?? null,
                    oMA_Producto.promocion ?? null,
                    oMA_Producto.cod_categoria ?? null,
                    oMA_Producto.cod_subcategoria ?? null,
                    oMA_Producto.cod_familia ?? null,
                    oMA_Producto.cod_marca ?? null,
                    oMA_Producto.cod_tipo ?? null,
                    oMA_Producto.cod_formato ?? null,
                    oMA_Producto.fecha_creacion ?? null,
                    oMA_Producto.creado_por ?? null,
                    oMA_Producto.fecha_modificacion ?? null,
                    oMA_Producto.modificado_por ?? null);
            }
            catch (Exception ex){
                throw ex;
            }
            return codigoProducto;
        }
        public string Update_Producto(MA_Producto oMA_Producto)
        {

            /*
             * v.1.0 -  23 Nov. 2016    -   PSALAS  - Inserta Producto  
             */

            string codigoProducto = "";
            try
            {
                codigoProducto = oCoon.ejecutarEscalar("PA_UPDATE_Producto",
                    oMA_Producto.codigo ?? null,
                    oMA_Producto.codigoint ?? null,
                    oMA_Producto.nombre ?? null,
                    oMA_Producto.alias ?? null,
                    oMA_Producto.precio_venta ?? null,
                    oMA_Producto.precio_oferta ?? null,
                    oMA_Producto.stock ?? null,
                    oMA_Producto.promocion ?? null,
                    oMA_Producto.cod_categoria ?? null,
                    oMA_Producto.cod_subcategoria ?? null,
                    oMA_Producto.cod_familia ?? null,
                    oMA_Producto.cod_marca ?? null,
                    oMA_Producto.cod_tipo ?? null,
                    oMA_Producto.cod_formato ?? null,
                    oMA_Producto.fecha_creacion ?? null,
                    oMA_Producto.creado_por ?? null,
                    oMA_Producto.fecha_modificacion ?? null,
                    oMA_Producto.modificado_por ?? null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoProducto;
        }    
    }
}
