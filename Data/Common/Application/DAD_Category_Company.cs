using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:DAD_Category_Company
    /// Creada Por: Carlos Marín
    /// Fecha de Creacion: 28/11/2011
    /// Descripcion: Define los Metodos transaccionales para el maestro DAD_Category_Company.
    /// </summary>
   public class DAD_Category_Company
    {
         private Conexion oConn;
         public DAD_Category_Company()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;

        }

         /// <summary>
         ///Metodo para Registrar DAD_Category_Company
         /// </summary>

         public EAD_Category_Company RegistrarAD_Category_Company(string sid_ProductCategory, string Company_id, bool bStatus, string sCreateBy,
     DateTime dDateBy, string sModiBy, DateTime dDateModiBy)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_INSERT_AD_Category_Company", sid_ProductCategory, Company_id, bStatus,
                      sCreateBy, dDateBy, sModiBy, dDateModiBy);
             EAD_Category_Company oEAD_Category_Company = new EAD_Category_Company();

             oEAD_Category_Company.id_ProductCategory = sid_ProductCategory;
             oEAD_Category_Company.Company_id = Company_id;
             oEAD_Category_Company.Status = bStatus;
             oEAD_Category_Company.CreateBy = sCreateBy;
             oEAD_Category_Company.DateBy = dDateBy;
             oEAD_Category_Company.ModiBy = sModiBy;
             oEAD_Category_Company.DateModiBy = dDateModiBy;
             return oEAD_Category_Company;

         }



         public DataTable ConsultarAD_Category_Company(string sid_ProductCategory, string Company_id)
           {
               DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_SELECT_AD_Category_Company", sid_ProductCategory, Company_id);

               return dt;
           }


    }
}
