using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Producto;
using Lucky.Entity.Common.Maestros.Producto;

namespace Lucky.Business.Common.Maestros.Producto
{
    public class BL_SubCategoria
    {
        DAO_SubCategoria oDAO_SubCategoria = new DAO_SubCategoria();

        public List<MA_SubCategoria> Get_SubCategoriasByCodCategoria(string codCategoria)
        {
            List<MA_SubCategoria> oListMA_SubCategoria = new List<MA_SubCategoria>();
            try
            {
                oListMA_SubCategoria = oDAO_SubCategoria.Get_SubCategoriaByCodCategoria(codCategoria);
            }
            catch (Exception ex)
            {
                return null;
            }
            return oListMA_SubCategoria;
        }
    }
}
