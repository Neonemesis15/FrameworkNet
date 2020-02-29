using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;
using Lucky.Data.Common.Application.Impl;
using Lucky.Business.Common.Application;
using Lucky.Business.Common.Application.Impl;


namespace Test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*DModulo moduloDao = new DModulo();
            List<String> list = new List<String>() { "AD","AUD","BBOX" };
            moduloDao.moduloLstGetByIds(list);*/

            /*DModulo moduloDao = new DModulo();
            moduloDao.moduloCmb();*/
            /*I_BL_Modulo oBL_Modulo = new BL_ModuloImpl();
            oBL_Modulo.moduloCmb();*/
            E_PersonLevel oEPersonLevel = new E_PersonLevel();
            oEPersonLevel.setId_Level("TEST");
            oEPersonLevel.setLevel_Description("TEST LEVEL");
            oEPersonLevel.setLevel_Status(true);
            oEPersonLevel.setLevel_CreateBy("psalas");
            oEPersonLevel.setLevel_DateBy(DateTime.Today.ToString());

            I_DaoPersonLevel oDaoPersonLevel = new DaoPersonLevelImpl();
            oDaoPersonLevel.personLevelIns(oEPersonLevel);
        }
    }
}