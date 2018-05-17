using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Text;








/// <summary>
/// Descripción breve de Lucky
/// </summary>
public class LuckyWs
{
    private DataSet ds;
    string file = "~/App_Data/Lucky.xml";
    
    //16-04-2016 - Off
    //private Facade_Planning.Facade_Proceso_Cliente objWS;
    
    //private LuckyService.Facade_Acceso_Purpura objWS;

	public LuckyWs()
	{
        ds = new DataSet("Luky");
        ds.ReadXml(HttpContext.Current.Server.MapPath(file));
        //16-04-2016 - Off    
        //objWS = new Facade_Planning.Facade_Proceso_Cliente();
	}

    public DataTable ObtenerUsuarios()
    {
        return ds.Tables["Person"];
        
    }

    public DataTable ObtenerServicios(int CompanyId)
    {
        DataTable dt = ds.Tables["Service"].Clone();
        int _Id = Convert.ToInt32(ds.Tables["Person"].Select("CompanyId = " + CompanyId.ToString())[0]["Person_Id"]);
        dt.Columns.Add("Canales", typeof(string));
        foreach (DataRow dr in ds.Tables["Service"].Select("Person_Id = " + _Id.ToString()))
        {
            int _servicio = Convert.ToInt32(dr["Service_Id"]);
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr2 in ds.Tables["Canal"].Select("Service_Id = " + _servicio.ToString()))
            {
                sb.AppendLine("<li class=\"canalItem\">");
                sb.AppendLine("<span>");
                sb.AppendLine(string.Format("<a href=\"{1}\" title=\"{0}\">{0}</a>", dr2["Nombre"].ToString(), dr2["Url"].ToString()));
                sb.AppendLine("</span>");
                sb.AppendLine("</li>");
            }
            List<object> items = new List<object>();
            foreach (object o in dr.ItemArray)
                items.Add(o);
            items.Add(sb.ToString());
            dt.Rows.Add(items.ToArray());
        }
        return dt;
    }

    public DataTable ObtenerServiciosWS(int CompanyId, string cod_country)
    {
        DataTable dt = new DataTable();

        string format = "~/Pages/img/{0}.png";
        dt.Columns.Add("Codigo", typeof(int));
        dt.Columns.Add("Imagen", typeof(string));
        dt.Columns.Add("Canales", typeof(string));
        dt.Columns.Add("Nombre", typeof(string));

        //16-04-2016
        /*
        foreach (DataRow servicio in objWS.Get_Obtener_Servicios_Activos(CompanyId, cod_country).Tables[0].Rows)
        {
            int _servicioId = Convert.ToInt32(servicio["codigo_Servicio"]);
            string nombreServicio = Convert.ToString(servicio["Nombre_Servicio"]);
            string img =string.Empty;
            if (Convert.ToBoolean(servicio["Estado"]))
            {
                //img = string.Format(format, nombreServicio);
                img = string.Format(format, nombreServicio.ToString() + "_g");
                
            }
            //else
            //{
            //    img = string.Format(format, nombreServicio.ToString() + "_g");
            //}
            
            StringBuilder sb    = new StringBuilder();

            foreach (DataRow row in objWS.Get_Obtener_Channels_Client(_servicioId, CompanyId).Tables[0].Rows)
            {
                string url = string.Empty;
                img = string.Format(format, nombreServicio);
                
                sb.AppendLine("<li class=\"canalItem\">");
                sb.AppendLine("<span>");

                if (Convert.ToBoolean(row[2]))
                {
                    url = row[0].ToString() + ".aspx";

                    sb.AppendLine(string.Format("<span style=\"cursor:pointer;\" onclick=\"lanzaCanal({3},{1},{2})\" title=\"{0}\">{0}</span>", row[1].ToString(), row[0].ToString(), CompanyId, _servicioId));
                    
                }
                else
                {
                    sb.AppendLine(string.Format("<a href=\"#\" title=\"{0}\">{0}</a>", row[1].ToString(), url, CompanyId, _servicioId));
                }

                sb.AppendLine("</span>");
                sb.AppendLine("</li>");
            }
            DataRow newrow      = dt.NewRow();
            newrow["Codigo"]    = _servicioId;
            newrow["Imagen"]    = img;
            newrow["Canales"]   = sb.ToString();
            newrow["Nombre"]    = nombreServicio;
           
           
            dt.Rows.Add(newrow);
        }
        */

        return dt;
    }
}
