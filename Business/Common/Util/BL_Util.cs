using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Lucky.Entity.Common.Application.Cross;

namespace Lucky.Business.Common.Util
{
    public class BL_Util
    {
        public List<E_CmbGeneric> convertToCmbGeneric(IEnumerable<Object[]> obj) {
            List<E_CmbGeneric> lst = new List<E_CmbGeneric>();
            foreach (Object[] x in obj) {
                E_CmbGeneric oCmbGeneric = new E_CmbGeneric();
                oCmbGeneric.setId(x[0].ToString());
                oCmbGeneric.setName(x[1].ToString());
                lst.Add(oCmbGeneric);
            }
            return lst;
        }

    }
}
