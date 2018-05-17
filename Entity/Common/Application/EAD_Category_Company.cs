using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EAD_Category_Company
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  28/11/2011
    /// </summary>
   public class EAD_Category_Company
    {

        int lid_Cate_Comp;
        string lid_ProductCategory;
        string lCompany_id;
        bool lStatus;
        string lCreateBy;
        string lModiBy;
        DateTime lDateModiBy;




        public int id_Cate_Comp
        {
            get { return lid_Cate_Comp; }
            set { lid_Cate_Comp = value; }
        }
        public string id_ProductCategory
        {
            get { return lid_ProductCategory; }
            set { lid_ProductCategory = value; }
        }
        public string Company_id
        {
            get { return lCompany_id; }
            set { lCompany_id = value; }
        }
        public bool Status
        {
            get { return lStatus; }
            set { lStatus = value; }
        }
        public string CreateBy
        {
            get { return lCreateBy; }
            set { lCreateBy = value; }
        }
        DateTime lDateBy;

        public DateTime DateBy
        {
            get { return lDateBy; }
            set { lDateBy = value; }
        }
        public string ModiBy
        {
            get { return lModiBy; }
            set { lModiBy = value; }
        }
        public DateTime DateModiBy
        {
            get { return lDateModiBy; }
            set { lDateModiBy = value; }
        }


    }
}
