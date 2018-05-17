using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class BMenu
    {
        public List<EMenuDetalle> Get_MenuDetalleByMenuId(Int32 Menu_id)
        {
            try
            {
                DMenuDetalle oDMenuDetalle = new DMenuDetalle();

                return oDMenuDetalle.Get_MenuDetalleByIdMenu(Menu_id);
            }
            catch
            {
                return null;
            }
        }
    }
}
