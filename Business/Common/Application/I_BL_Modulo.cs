using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Application.Cross;

namespace Lucky.Business.Common.Application
{
    public interface I_BL_Modulo
    {
        List<EModulo> moduloLstByIds(List<String> moduloIds);
        List<E_CmbGeneric> moduloCmb();
    }
}
