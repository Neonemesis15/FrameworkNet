using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Producto;
using Lucky.Entity.Common.Maestros.Producto;

namespace Lucky.Business.Common.Maestros.Producto
{
    public class BL_Categoria
    {
        DAO_Categoria oDAO_Categoria = new DAO_Categoria();

        public List<MA_Categoria> Get_Categorias()
        {
            List<MA_Categoria> oListMA_Categoria = new List<MA_Categoria>();
            try
            {
                oListMA_Categoria = oDAO_Categoria.Get_Categoria();
            }
            catch (Exception ex)
            {
                return null;
            }
            return oListMA_Categoria;
        }
    }
}
