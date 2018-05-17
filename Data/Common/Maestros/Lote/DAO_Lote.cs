using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Maestros.Lote;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.Maestros.Lote
{
    public class DAO_Lote
    {
        public string Insert_Lote(DataTable oDataTable, string nombreArchivo)
        {
            ///////////////////////////////////////////
            string ideLote = "";
            int ok;
            using (var cn = DataBase.getConnection())
            {
                SqlCommand cmd = new SqlCommand("PA_INSERT_LOTE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE_ARCHIVO", nombreArchivo);
                cmd.Parameters.Add("@CODLOTE", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                try
                {
                    cn.Open();
                    ok = cmd.ExecuteNonQuery() == 1 ? 1 : 0;
                    ideLote = (string)cmd.Parameters["@CODLOTE"].Value;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }

            ///////////////////////////////////////////

            oDataTable.Columns.Add("IDELOTE");

            oDataTable.Columns[0].ColumnName = "COD_CATEGORIA";
            oDataTable.Columns[1].ColumnName = "COD_SUBCATEGORIA";
            oDataTable.Columns[2].ColumnName = "COD_FAMILIA";
            oDataTable.Columns[3].ColumnName = "COD_MARCA";
            oDataTable.Columns[4].ColumnName = "COD_PRODUCTO";
            oDataTable.Columns[5].ColumnName = "CODIGO_INT";
            oDataTable.Columns[6].ColumnName = "PRODUCTO";
            oDataTable.Columns[7].ColumnName = "ALIAS";
            oDataTable.Columns[8].ColumnName = "COD_TIPO";
            oDataTable.Columns[9].ColumnName = "COD_FORMATO";
            oDataTable.Columns[10].ColumnName = "PRECIO_VENTA";
            oDataTable.Columns[11].ColumnName = "PRECIO_OFERTA";
            oDataTable.Columns[12].ColumnName = "STOCK";
            oDataTable.Columns[13].ColumnName = "PROMOCION";
            oDataTable.Columns[14].ColumnName = "IDELOTE";


            foreach (DataRow dr in oDataTable.Rows) // search whole table
            {
                dr["IDELOTE"] = ideLote;
            }


            using (var cn = DataBase.getConnection())
            {
                try
                {
                    cn.Open();

                        //////////////////////
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(cn.ConnectionString))
                        {
                            bulkCopy.DestinationTableName = "INT_LOTE_DET";

                            bulkCopy.ColumnMappings.Add("COD_CATEGORIA", "COD_CATEGORIA");
                            bulkCopy.ColumnMappings.Add("COD_SUBCATEGORIA", "COD_SUBCATEGORIA");
                            bulkCopy.ColumnMappings.Add("COD_FAMILIA", "COD_FAMILIA");
                            bulkCopy.ColumnMappings.Add("COD_MARCA", "COD_MARCA");
                            bulkCopy.ColumnMappings.Add("COD_PRODUCTO", "COD_PRODUCTO");
                            bulkCopy.ColumnMappings.Add("CODIGO_INT", "CODIGO_INT");
                            bulkCopy.ColumnMappings.Add("PRODUCTO", "PRODUCTO");
                            bulkCopy.ColumnMappings.Add("ALIAS", "ALIAS");
                            bulkCopy.ColumnMappings.Add("COD_TIPO", "COD_TIPO");
                            bulkCopy.ColumnMappings.Add("COD_FORMATO", "COD_FORMATO");
                            bulkCopy.ColumnMappings.Add("PRECIO_VENTA", "PRECIO_VENTA");
                            bulkCopy.ColumnMappings.Add("PRECIO_OFERTA", "PRECIO_OFERTA");
                            bulkCopy.ColumnMappings.Add("STOCK", "STOCK");
                            bulkCopy.ColumnMappings.Add("PROMOCION", "PROMOCION");
                            bulkCopy.ColumnMappings.Add("IDELOTE", "IDELOTE");	

                            bulkCopy.WriteToServer(oDataTable);
                        };
                        /////////////////////
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }

            Lote_Contador_Create(ideLote);

            return ideLote;
        }

        public string Lote_Contador_Create(string CodLote) {
            int ok;
            using (var cn = DataBase.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_LoteContador_Create", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDELOTE", CodLote);
                try
                {
                    cn.Open();
                    ok = cmd.ExecuteNonQuery() == 1 ? 1 : 0;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
                return ok.ToString();
            }

        }

        public List<INT_Lote> ReadAll(string FecIni, string FecFin) {

            List<INT_Lote> lista = new List<INT_Lote>();
            using (var cn = DataBase.getConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("usp_Lotes_Listar", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@FechaIni", FecIni);
                da.SelectCommand.Parameters.AddWithValue("@FechaFin", FecFin);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    INT_Lote c = new INT_Lote()
                    {
                        codigo = item[0].ToString(),
                        nombre_archivo = item[1].ToString(),
                        estado = item[2].ToString(),
                        fecha_creacion = item[3].ToString(),
                        creado_por = item[4].ToString(),
                        fecha_modificacion = item[5].ToString(),
                        modificado_por = item[6].ToString()
                    };
                    lista.Add(c);
                }
                return lista;
            }
        }
        
        #region
        /*public string Insert_Lote(INT_Lote oLote)
        {
            string ideLote = oCoon.ejecutarEscalar("PA_INSERT_LOTE",
                oLote.nombre_archivo ?? null,
                oLote.proceso ?? null);

            List<INT_Lote_Det> oList_Lote_Det = oLote.list_LoteDet;

            
             //1.- Definimos un DataTable con sus Cabecera y Detalle
             //2.- Llenamos 
             
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(oCoon.Conexion()))
            {
                bulkCopy.DestinationTableName = "INT_LOTE_DET";
                bulkCopy.WriteToServer(dt);
            };

            return ideLote;
        }*/
        #endregion

    }
}
