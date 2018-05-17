using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Lucky.CFG.Tools
{
    /// <summary>
    /// Clase:Control de Usuario FileUploadreload
    /// Creada por: Ing. Carlos Hernandez
    /// Fecha:01/07/2009
    /// </summary>
   public  class FileUploadreload : System.Web.UI.WebControls.FileUpload
    {
       public FileUploadreload() { 
       
       
        }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) 

        { 

             writer.AddAttribute("onchange", "funcionJs()"); 

             writer.AddAttribute("name", "miUpload");

                  base.Render(writer);  

            }
    }
}






