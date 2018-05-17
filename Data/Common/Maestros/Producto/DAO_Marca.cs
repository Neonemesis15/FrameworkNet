using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Producto;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Producto
{
    public class DAO_Marca
    {
        private Conexion oCoon;

        public DAO_Marca()
        {
            oCoon = new Conexion();
        }

        public List<MA_Marca> Get_Marcas()
        {
            /*
             * v.1.0 -  22 Oct. 2016    -   PSALAS  - Obtiene todas las marcas  
             */
            try
            {
                List<MA_Marca> oListMA_Marca = new List<MA_Marca>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_Marcas");
                while (readerObj.Read())
                {
                    MA_Marca oMA_Marca = new MA_Marca();
                    oMA_Marca.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_Marca.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oListMA_Marca.Add(oMA_Marca);
                }
                readerObj.Close();
                if (oListMA_Marca.Count > 0)
                {
                    return oListMA_Marca;
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
