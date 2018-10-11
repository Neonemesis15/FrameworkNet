using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Data.Common.AppMobile
{
    interface DaoPersona
    {
        List<Object[]> personaQry();
        List<Object[]> personaQry(Int16 idPersona);
    }
}
