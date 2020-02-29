using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Application.Cross;
using Lucky.Business.Common.Util;
namespace Lucky.Business.Common.Application.Impl
{
    public class BL_ModuloImpl : I_BL_Modulo
    {
        DModulo oDModulo = new DModulo();
        BL_Util oBL_Util = new BL_Util();
        public List<E_CmbGeneric> moduloCmb()
        {
            List<E_CmbGeneric> lstCmb = null;
            try {
                List<Object[]> lst = oDModulo.moduloCmb();
                lstCmb = oBL_Util.convertToCmbGeneric(lst);
            }
            catch (Exception ex) {
                throw ex;    
            }
            return lstCmb;

        }

        public List<EModulo> moduloLstByIds(List<string> moduloIds)
        {
            throw new NotImplementedException();
        }
    }
}
