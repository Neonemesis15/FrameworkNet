using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Data.Common.AppMobile
{
    interface DaoPersona
    {
        public List<Object[]> personaQry();
        public List<Object[]> personaQry(Int16 idPersona);
    }
}
