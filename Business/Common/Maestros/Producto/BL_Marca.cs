using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Producto;
using Lucky.Entity.Common.Maestros.Producto;

namespace Lucky.Business.Common.Maestros.Producto
{
    public class BL_Marca
    {
        DAO_Marca oDAO_Marca = new DAO_Marca();

        public List<MA_Marca> Get_Marcas()
        {
            List<MA_Marca> oListMA_Marca = new List<MA_Marca>();
            try
            {
                oListMA_Marca = oDAO_Marca.Get_Marcas();
            }
            catch (Exception ex)
            {
                return null;
            }
            return oListMA_Marca;
        }
    }
}
