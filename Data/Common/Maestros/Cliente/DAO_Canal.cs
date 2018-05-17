using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Cliente
{
    public class DAO_Canal
    {
        private Conexion oCoon;
        
        public DAO_Canal(){
            oCoon = new Conexion();
        }

        public List<MA_Canal> Get_CanalesByCodUsuario(string codUsuario) {
            try {
                
                
                List<MA_Canal> oListMA_Canal = new List<MA_Canal>();
                IDataReader readerObj = oCoon.ejecutarDataReader("PA_GET_CanalesByCodUsuario", codUsuario);
                while (readerObj.Read()) {
                    MA_Canal oMA_Canal = new MA_Canal();
                    oMA_Canal.codigo = readerObj.GetValue(readerObj.GetOrdinal("codigo")).ToString().Trim();
                    oMA_Canal.nombre = readerObj.GetValue(readerObj.GetOrdinal("nombre")).ToString().Trim();
                    oListMA_Canal.Add(oMA_Canal);
                }
                readerObj.Close();
                if (oListMA_Canal.Count > 0)
                {
                    return oListMA_Canal;
                }
                else {
                    return null;
                }
                
            }
            catch (Exception) {
                return null;
            }
        }
    }
}
