using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Producto;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Producto
{
    public class DAO_Familia
    {
        private Conexion oCoon;

        public DAO_Familia()
        {
            oCoon = new Conexion();
        }

        public List<MA_Familia> Get_FamiliaByCodSubCategoria(string codSubCategoria)
        {
            /*
             * v.1.0 -  29 Oct. 2016    -   PSALAS  - Obtiene todas las Familias  
             */
            try
            {
                List<MA_Familia> oListMA_Familia = new List<MA_Familia>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_FamiliaByCodSubCategoria", codSubCategoria);
                while (readerObj.Read())
                {
                    MA_Familia oMA_Familia = new MA_Familia();
                    oMA_Familia.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_Familia.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oListMA_Familia.Add(oMA_Familia);
                }
                readerObj.Close();
                if (oListMA_Familia.Count > 0)
                {
                    return oListMA_Familia;
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
