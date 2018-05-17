using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Lucky.CFG;

namespace Lucky.CFG.Tools
{

    public class CTreviewEdit:TreeView
    {
        public CTreviewEdit() { 
        
        
        }
        public event TreeNodeEditEventHandler TreeNodeEdit;

       public  virtual void OnTreeNodeEdit(TreeNodeEditEventArgs e)
        {
            if (TreeNodeEdit != null)
            {
                TreeNodeEdit();
            }
        }



    }
}
