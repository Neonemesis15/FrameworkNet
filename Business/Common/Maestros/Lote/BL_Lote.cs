using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Lote;
using Lucky.Entity.Common.Maestros.Lote;
using System.Data;

namespace Lucky.Business.Common.Maestros.Lote
{
    public class BL_Lote
    {
        DAO_Lote oDAO_Lote = new DAO_Lote();
        public string Insert_Lote(DataTable oDataTable, string nombreArchivo)
        {
            string ideLote;
            try {
                ideLote = oDAO_Lote.Insert_Lote(oDataTable, nombreArchivo);
            }
            catch (Exception ex) {
                return null;
            }
            return ideLote;
        }

        public List<INT_Lote> ReadAll(string FecIni, string FecFin) {

            List<INT_Lote> lista = new List<INT_Lote>();
            try
            {
                lista = oDAO_Lote.ReadAll(FecIni, FecFin);
            }
            catch (Exception ex)
            {
                return null;
            }
            return lista;
        }
    }
}
