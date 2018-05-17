using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: AD_Category_Company
    /// Creada Por: Carlos Marin
    /// Fecha de Creacion: 28/11/2011
    /// Descripcion: Define metodos para maestro AD_Category_Company
    /// </summary>
   public class AD_Category_Company
    {
       public EAD_Category_Company Category_Company(string sid_ProductCategory, string Company_id, bool bStatus, string sCreateBy,
     DateTime dDateBy, string sModiBy, DateTime dDateModiBy)
       {

           DAD_Category_Company oDAD_Category_Company = new DAD_Category_Company();
           EAD_Category_Company oEAD_Category_Company = oDAD_Category_Company.RegistrarAD_Category_Company(sid_ProductCategory, Company_id, bStatus,
                      sCreateBy, dDateBy, sModiBy, dDateModiBy);
           oDAD_Category_Company = null;
           return oEAD_Category_Company;

       }

       public DataTable ConsultarAD_Category_Company(string sid_ProductCategory, string Company_id)
       {
           DAD_Category_Company oDAD_Category_Company = new DAD_Category_Company();
           DataTable dt = oDAD_Category_Company.ConsultarAD_Category_Company(sid_ProductCategory, Company_id);

           return dt;
       }
    }
}
