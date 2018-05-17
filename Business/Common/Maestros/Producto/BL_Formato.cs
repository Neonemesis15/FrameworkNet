using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Producto;
using Lucky.Entity.Common.Maestros.Producto;

namespace Lucky.Business.Common.Maestros.Producto
{
    public class BL_Formato
    {
        DAO_Formato oDAO_Formato = new DAO_Formato();

        public List<MA_Formato> Get_Formatos()
        {
            List<MA_Formato> oListMA_Formato = new List<MA_Formato>();
            try
            {
                oListMA_Formato = oDAO_Formato.Get_Formatos();
            }
            catch (Exception ex)
            {
                return null;
            }
            return oListMA_Formato;
        }
    }
}
