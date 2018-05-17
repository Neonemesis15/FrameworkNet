using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Lote;

namespace Lucky.Business.Common.Maestros.Lote
{
    public class BL_Lote_Contador
    {
        DAO_Lote_Contador oDAO_Lote = new DAO_Lote_Contador();
        public List<INT_Lote_Contador> ReadAll(string ideLote)
        {

            List<INT_Lote_Contador> lista = new List<INT_Lote_Contador>();
            try
            {
                lista = oDAO_Lote.ReadAll(ideLote);
            }
            catch (Exception ex)
            {
                return null;
            }
            return lista;
        }
    }
}
