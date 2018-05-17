using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Producto;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Producto
{
    public class DAO_Categoria
    {
        private Conexion oCoon;

        public DAO_Categoria()
        {
            oCoon = new Conexion();
        }

        public List<MA_Categoria> Get_Categoria()
        {
            /*
             * v.1.0 -  22 Oct. 2016    -   PSALAS  - Obtiene todas las Categorías  
             */
            try
            {
                List<MA_Categoria> oListMA_Categoria = new List<MA_Categoria>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_Categorias");
                while (readerObj.Read())
                {
                    MA_Categoria oMA_Categoria = new MA_Categoria();
                    oMA_Categoria.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_Categoria.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oListMA_Categoria.Add(oMA_Categoria);
                }
                readerObj.Close();
                if (oListMA_Categoria.Count > 0)
                {
                    return oListMA_Categoria;
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
    }
}
