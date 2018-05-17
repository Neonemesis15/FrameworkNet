using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Producto;
using Lucky.Entity.Common.Maestros.Producto;

namespace Lucky.Business.Common.Maestros.Producto
{
    public class BL_Tipo
    {
        DAO_Tipo oDAO_Tipo = new DAO_Tipo();

        public List<MA_Tipo> Get_Tipos()
        {
            List<MA_Tipo> oListMA_Tipo = new List<MA_Tipo>();
            try
            {
                oListMA_Tipo = oDAO_Tipo.Get_Tipos();
            }
            catch (Exception ex)
            {
                return null;
            }
            return oListMA_Tipo;
        }
    }
}
