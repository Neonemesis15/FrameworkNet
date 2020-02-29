using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public interface I_DaoPersonLevel
    {
        int personLevelIsDuplicate(E_PersonLevel oPersonLevel);
        int personLevelIns(E_PersonLevel oPersonLevel);
        int personLevelDel(string id_Level);
    }
}
