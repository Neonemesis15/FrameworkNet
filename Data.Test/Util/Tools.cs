using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucky.Entity.Common.Application;

namespace Data.Test.Util
{
    public static class Tools
    {
        public static E_PersonLevel ePersonLevelOk() {
            E_PersonLevel oEPersonLevel = new E_PersonLevel();
            oEPersonLevel.setId_Level("TEST");
            oEPersonLevel.setLevel_Description("TEST DESCRIPTION");
            oEPersonLevel.setLevel_Status(true);
            oEPersonLevel.setLevel_CreateBy("psalas");
            oEPersonLevel.setLevel_DateBy(DateTime.Today.ToString());
            return oEPersonLevel;
        }

        public static E_PersonLevel ePersonLevelDuplicate()
        {
            E_PersonLevel oEPersonLevel = new E_PersonLevel();
            oEPersonLevel.setId_Level("0001");
            oEPersonLevel.setLevel_Description("GENERAL");
            oEPersonLevel.setLevel_Status(true);
            oEPersonLevel.setLevel_CreateBy("psalas");
            oEPersonLevel.setLevel_DateBy(DateTime.Today.ToString());
            return oEPersonLevel;
        }

        public static E_PersonLevel ePersonLevelNotDuplicate()
        {
            E_PersonLevel oEPersonLevel = new E_PersonLevel();
            oEPersonLevel.setId_Level("TEST");
            oEPersonLevel.setLevel_Description("TEST DESCRIPTION");
            oEPersonLevel.setLevel_Status(true);
            oEPersonLevel.setLevel_CreateBy("psalas");
            oEPersonLevel.setLevel_DateBy(DateTime.Today.ToString());
            return oEPersonLevel;
        }
    }
}
