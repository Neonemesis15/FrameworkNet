using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Business.Common.Maestros.Lote;
using System.Data.SqlClient;
using System.Data;

namespace Lucky.Data.Common.Maestros.Lote
{
    public class DAO_Lote_Contador
    {
        public List<INT_Lote_Contador> ReadAll(string ideLote)
        {

            List<INT_Lote_Contador> lista = new List<INT_Lote_Contador>();
            using (var cn = DataBase.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("usp_LoteContador_Listar", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@IdeLote", ideLote);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    INT_Lote_Contador c = new INT_Lote_Contador()
                    {
                        codigo = item[0].ToString(),
                        idelote = item[1].ToString(),
                        orden = item[2].ToString(),
                        cod_proceso = item[3].ToString(),
                        reg_total = item[4].ToString(),
                        reg_error = item[5].ToString(),
                        reg_ok = item[6].ToString(),
                        estado = item[7].ToString(),
                        fecha_incio = item[8].ToString(),
                        fecha_fin = item[9].ToString()
                    };
                    lista.Add(c);
                }
                return lista;
            }
        }
    }
}
