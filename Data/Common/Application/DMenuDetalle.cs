using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lucky.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DMenuDetalle
    {
        Conexion oConn = new Conexion();
        public List<EMenuDetalle> Get_MenuDetalleByIdMenu(Int32 Id_Menu)
        {

            List<EMenuDetalle> oList_EMenuDetalle = new List<EMenuDetalle>();

            try
            {
                DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_CLIE_V2_Get_MenuDetalleByMenuId", Id_Menu);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EMenuDetalle oEMenuDetalle = new EMenuDetalle();
                    oEMenuDetalle.Id_MenuD = Convert.ToInt32(dt.Rows[i]["id_MenuD"].ToString());
                    oEMenuDetalle.Id_Menu = Convert.ToInt32(dt.Rows[i]["id_Menu"].ToString());
                    oEMenuDetalle.Id_objeto = dt.Rows[i]["id_objeto"].ToString();
                    oEMenuDetalle.Descripcion = dt.Rows[i]["Descripcion"].ToString();
                    oEMenuDetalle.Id_Padre = Convert.ToInt32(dt.Rows[i]["id_Padre"] is DBNull?0:dt.Rows[i]["id_Padre"]);
                    oEMenuDetalle.Url = dt.Rows[i]["url"].ToString();
                    oEMenuDetalle.Url_foto = dt.Rows[i]["url_foto"].ToString();
                    oEMenuDetalle.MenuD_Status = Convert.ToBoolean(dt.Rows[i]["MenuD_Status"].ToString());
                    oEMenuDetalle.CreateBy = dt.Rows[i]["CreateBy"].ToString();
                    oEMenuDetalle.DateBy = Convert.ToDateTime(dt.Rows[i]["DateBy"].ToString());
                    oEMenuDetalle.ModiBy = dt.Rows[i]["ModiBy"].ToString();
                    oEMenuDetalle.DateModiBy = Convert.ToDateTime(dt.Rows[i]["DateModiBy"]);

                    oList_EMenuDetalle.Add(oEMenuDetalle);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oList_EMenuDetalle;
        }
    }
}

