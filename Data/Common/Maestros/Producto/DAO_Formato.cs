using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Producto;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Producto
{
    public class DAO_Formato
    {
        private Conexion oCoon;

        public DAO_Formato()
        {
            oCoon = new Conexion();
        }


        public List<MA_Formato> Get_Formatos()
        {
            /*
             * v.1.0 -  11 Nov. 2016    -   PSALAS  - Obtiene todas las Formatos  
             */
            try
            {
                List<MA_Formato> oListMA_Formato = new List<MA_Formato>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_Formatos");
                while (readerObj.Read())
                {
                    MA_Formato oMA_Formato = new MA_Formato();
                    oMA_Formato.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_Formato.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oListMA_Formato.Add(oMA_Formato);
                }
                readerObj.Close();
                if (oListMA_Formato.Count > 0)
                {
                    return oListMA_Formato;
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
