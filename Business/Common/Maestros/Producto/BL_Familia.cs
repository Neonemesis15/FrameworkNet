using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Producto;
using Lucky.Entity.Common.Maestros.Producto;

namespace Lucky.Business.Common.Maestros.Producto
{
    public class BL_Familia
    {
        DAO_Familia oDAO_Familia = new DAO_Familia();

        public List<MA_Familia> Get_FamiliasByCodSubCategoria(string codSubCategoria)
        {
            List<MA_Familia> oListMA_Familia = new List<MA_Familia>();
            try
            {
                oListMA_Familia = oDAO_Familia.Get_FamiliaByCodSubCategoria(codSubCategoria);
            }
            catch (Exception ex)
            {
                return null;
            }
            return oListMA_Familia;
        }
    }
}
