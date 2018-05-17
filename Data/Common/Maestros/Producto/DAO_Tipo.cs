using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Producto;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Producto
{
    public class DAO_Tipo
    {
        private Conexion oCoon;

        public DAO_Tipo()
        {
            oCoon = new Conexion();
        }


        public List<MA_Tipo> Get_Tipos()
        {
            /*
             * v.1.0 -  11 Nov. 2016    -   PSALAS  - Obtiene todas las Tipos  
             */
            try
            {
                List<MA_Tipo> oListMA_Tipo = new List<MA_Tipo>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_Tipos");
                while (readerObj.Read())
                {
                    MA_Tipo oMA_Tipo = new MA_Tipo();
                    oMA_Tipo.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_Tipo.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oListMA_Tipo.Add(oMA_Tipo);
                }
                readerObj.Close();
                if (oListMA_Tipo.Count > 0)
                {
                    return oListMA_Tipo;
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
