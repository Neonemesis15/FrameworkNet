using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Producto;
using Lucky.Entity.Common.Maestros.Producto;

namespace Lucky.Business.Common.Maestros.Producto
{
    public class BL_Producto
    {

        DAO_Producto oDAO_Producto = new DAO_Producto();
        
        public String message;

        public String getMessages() {
            return message;
        }

        public BL_Producto() {
            this.message = "";
        }

        public string Insert_Producto(MA_Producto oMA_Producto){
            /*
             * v.1.0 -  13 Nov. 2016    -   PSALAS  - Inserta Producto  
             */
            string codigoProducto = "";
            try
            {
                codigoProducto = oDAO_Producto.Insert_Producto(oMA_Producto);
            }
            catch (Exception ex)
            {
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
                codigoProducto = oDAO_Producto.Update_Producto(oMA_Producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoProducto;

        }
        
        /// <summary>
        /// Obtener el Listado de Productos según IdCategoría y IdMarca.
        /// </summary>
        /// <param name="codCategoria"></param>
        /// <param name="codMarca"></param>
        /// <returns></returns>
        public List<MA_Producto> Get_Productos(string codCategoria, string codMarca)
        {
            List<MA_Producto> oListMA_Producto = new List<MA_Producto>();
            try
            {
                oListMA_Producto = oDAO_Producto.Get_Productos(codCategoria, codMarca);
                if (!oDAO_Producto.getMessages().Equals("")) {
                    message = oDAO_Producto.getMessages().ToString();
                }
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();
            }
            return oListMA_Producto;
        }

        /*public List<SR_Producto> Get_Productos(string codCategoria, string codMarca)
        {
            List<SR_Producto> oListSR_Producto = new List<SR_Producto>();
            try
            {
                oListSR_Producto = oDAO_Producto.Get_Productos(codCategoria, codMarca);
            }
            catch (Exception ex)
            {
                return null;
            }
            return oListSR_Producto;
        }*/
    }
}
