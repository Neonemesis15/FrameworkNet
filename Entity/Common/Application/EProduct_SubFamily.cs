using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    class EProduct_SubFamily
    {
        private string id_ProductSubFamily;        
        private string id_ProductFamily;
        private string subfam_nombre;        
        private bool subfam_status;        
        private string subfam_CreateBy;        
        private DateTime subfam_DateBy;        
        private string subfam_ModiBy;        
        private DateTime subfam_DateModiBy;       

        public EProduct_SubFamily() 
        { 

        }

        public string Id_ProductSubFamily
        {
            get { return id_ProductSubFamily; }
            set { id_ProductSubFamily = value; }
        }

        public string Id_ProductFamily
        {
            get { return id_ProductFamily; }
            set { id_ProductFamily = value; }
        }

        public string Subfam_nombre
        {
            get { return subfam_nombre; }
            set { subfam_nombre = value; }
        }

        public bool Subfam_status
        {
            get { return subfam_status; }
            set { subfam_status = value; }
        }

        public string Subfam_CreateBy
        {
            get { return subfam_CreateBy; }
            set { subfam_CreateBy = value; }
        }

        public DateTime Subfam_DateBy
        {
            get { return subfam_DateBy; }
            set { subfam_DateBy = value; }
        }

        public string Subfam_ModiBy
        {
            get { return subfam_ModiBy; }
            set { subfam_ModiBy = value; }
        }

        public DateTime Subfam_DateModiBy
        {
            get { return subfam_DateModiBy; }
            set { subfam_DateModiBy = value; }
        }
    }
}
