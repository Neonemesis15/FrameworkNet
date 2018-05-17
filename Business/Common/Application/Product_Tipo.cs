using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;


namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Product_Tipo
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 07/09/2009
    /// Description: Establece los metodos para operar informacion relacionada con tipos de producto Lucky
    /// Requerimiento No:
    /// </summary>
    /// 
    public class Product_Tipo
    {
        public Product_Tipo()
        {
            //Se define el constructor por defecto
        }

        //----Metodo que permite registrar Tipos de producto

        public EProduct_Tipo RegistrarProductTipo(string sid_ProductTipo, string sProduct_Tipo, string sid_ProductCategory, bool bProductTipo_Status,
            string sProductTipo_CreateBy, DateTime tProductTipo_DateBy, string sProductTipo_ModiBy, DateTime tProductTipo_DateModiBy)
        {
            DProduct_Tipo odrProducttipo = new DProduct_Tipo();
            EProduct_Tipo oeProductTipo = odrProducttipo.RegistrarProductTipoPK(sid_ProductTipo, sProduct_Tipo, sid_ProductCategory, bProductTipo_Status,
             sProductTipo_CreateBy, tProductTipo_DateBy, sProductTipo_ModiBy, tProductTipo_DateModiBy);
            odrProducttipo = null;
            return oeProductTipo;
        }

        //---Metodo de Consulta de Tipos de producto

        public DataTable SearchProductTipo(string sid_ProductTipo, string sProduct_Tipo)
        {
            DProduct_Tipo odsProductTipo = new DProduct_Tipo();
            EProduct_Tipo oeProductTipo = new EProduct_Tipo();
            DataTable dtProductTipo = odsProductTipo.ObtenerTipoProduct(sid_ProductTipo, sProduct_Tipo);
            odsProductTipo = null;
            return dtProductTipo;
        }

        //----Metodo que permite Actualizar tipos de producto 

        public EProduct_Tipo Actualizar_ProductTipo(string sid_ProductTipo, string sProduct_Tipo, string sid_ProductCategory, bool bProductTipo_Status,
            string sProductTipo_ModiBy, DateTime tProductTipo_DateModiBy)
        {
            DProduct_Tipo odaProductTipo = new DProduct_Tipo();
            EProduct_Tipo oeaProductTipo = odaProductTipo.Actualizar_ProductTipo(sid_ProductTipo, sProduct_Tipo, sid_ProductCategory, bProductTipo_Status,
             sProductTipo_ModiBy, tProductTipo_DateModiBy);
            odaProductTipo = null;
            return oeaProductTipo;
        }
    }
}
        
