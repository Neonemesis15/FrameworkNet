using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: SubCategoria
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 19/08/2010
    /// Description: Establece los metodos para operar informacion relacionada con las SubCategorias de productos Lucky
    /// Requerimiento No:
    /// </summary>
    /// 
    public class SubCategoria
    {
         public SubCategoria()
        {
            //Se define el constructor por defecto
        }
        //----Metodo que permite registrar SubCategorias de producto
        public ESubCategoria RegistrarSubCategoria( string sid_ProductCategory, string sName_Subcategory, bool bSubcategory_Status,
           string sSubcategory_CreateBy, DateTime tSubcategory_DateBy, string sSubcategory_ModiBy, DateTime tSubcategory_DateModiBy)
        {
            DSubCategoria odrSubCategoria = new DSubCategoria();
            ESubCategoria oeSubCategoria = odrSubCategoria.RegistrarSubCategoria(sid_ProductCategory, sName_Subcategory, bSubcategory_Status,
            sSubcategory_CreateBy, tSubcategory_DateBy, sSubcategory_ModiBy, tSubcategory_DateModiBy);
           
             
             odrSubCategoria = null;
             return oeSubCategoria;
         }

         //---Metodo de Consulta de SubCategorias de producto
        public DataTable ConsultarSubCategoria(string sid_ProductCategory, string sName_Subcategory)
         {
             DSubCategoria odsSubCategoria = new DSubCategoria();
             ESubCategoria oeSubCategoria = new ESubCategoria();

             DataTable dtSubCategoria = odsSubCategoria.ConsultarSubCategoria(sid_ProductCategory, sName_Subcategory);
             odsSubCategoria = null;
             return dtSubCategoria;
         }
        //----Metodo que permite Actualizar Subcategorias de producto 
        public ESubCategoria Actualizar_SubCategoria(long lid_Subcategory, string sid_ProductCategory, string sName_Subcategory, bool bSubcategory_Status,
          string sSubcategory_ModiBy, DateTime tSubcategory_DateModiBy)
         {
             DSubCategoria odaSubCategoria = new DSubCategoria();
             ESubCategoria oeaSubCategoria = odaSubCategoria.Actualizar_SubCategoria( lid_Subcategory,  sid_ProductCategory, sName_Subcategory,  bSubcategory_Status,
             sSubcategory_ModiBy,  tSubcategory_DateModiBy);
             odaSubCategoria = null;
             return oeaSubCategoria;
         }
    }
}
