using System;

namespace Lucky.CFG.Web
{
    /// <summary>
    /// Clase utilizada para mostrar mensaje de sesión finalizada.
    /// </summary>
    public class SessionControl : System.Web.UI.Page
    {
        protected virtual void Main()
        {
            //Código que queremos se ejecute en todas las páginas web
        }
        protected virtual void Page_Load(object sender, EventArgs e)
        {
            Response.AddHeader("Refresh", Convert.ToString((Session.Timeout * 60) + 5));
            if (Session["sUser"] == null)
                Response.Redirect("~/err_mensaje.aspx?msg=" + "Su sesión ha expirado, por favor vuelva a ingresar al sistema.");
        }
    }
}