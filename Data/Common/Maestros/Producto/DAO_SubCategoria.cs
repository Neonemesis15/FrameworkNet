using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Producto;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Producto
{
    public class DAO_SubCategoria
    {
        private Conexion oCoon;

        public DAO_SubCategoria()
        {
            oCoon = new Conexion();
        }

        public List<MA_SubCategoria> Get_SubCategoriaByCodCategoria(string codCategoria)
        {
            /*
             * v.1.0 -  22 Oct. 2016    -   PSALAS  - Obtiene todas las SubCategorias  
             */
            try
            {
                List<MA_SubCategoria> oListMA_SubCategoria = new List<MA_SubCategoria>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_SubCategoriaByCodCategoria", codCategoria);
                while (readerObj.Read())
                {
                    MA_SubCategoria oMA_SubCategoria = new MA_SubCategoria();
                    oMA_SubCategoria.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_SubCategoria.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oListMA_SubCategoria.Add(oMA_SubCategoria);
                }
                readerObj.Close();
                if (oListMA_SubCategoria.Count > 0)
                {
                    return oListMA_SubCategoria;
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
