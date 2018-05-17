using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    //CreateBy: Ing. Mauricio Ortiz
    //CreateDate: 04/09/2009
    //Description: Metodos transaccionales para Product_Tipo
    //Requerimiento:

    public class DProduct_Tipo
    {
        private Conexion oConn;
        public DProduct_Tipo()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Metodo para Registrar tipos de Producto
        public EProduct_Tipo RegistrarProductTipoPK(string sid_ProductTipo, string sProduct_Tipo, string sid_ProductCategory, bool bProductTipo_Status,
            string sProductTipo_CreateBy, DateTime tProductTipo_DateBy, string sProductTipo_ModiBy, DateTime tProductTipo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTER_TIPOPRODUCTO", sid_ProductTipo, sProduct_Tipo, sid_ProductCategory, bProductTipo_Status,
             sProductTipo_CreateBy, tProductTipo_DateBy, sProductTipo_ModiBy, tProductTipo_DateModiBy);
            EProduct_Tipo oerTipoProduct = new EProduct_Tipo();
            oerTipoProduct.id_ProductTipo = sid_ProductTipo;
            oerTipoProduct.Product_Tipo = sProduct_Tipo;
            oerTipoProduct.id_ProductCategory = sid_ProductCategory;
            oerTipoProduct.ProductTipo_Status = bProductTipo_Status;
            oerTipoProduct.ProductTipo_CreateBy = sProductTipo_CreateBy;
            oerTipoProduct.ProductTipo_DateBy = tProductTipo_DateBy;
            oerTipoProduct.ProductTipo_ModiBy = sProductTipo_ModiBy;
            oerTipoProduct.ProductTipo_DateModiBy = tProductTipo_DateModiBy;
            return oerTipoProduct;
        }

        //Método: Buscar Tipos de Producto

        public DataTable ObtenerTipoProduct(string sid_ProductTipo, string sProduct_Tipo)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHTIPOPRODUCTO", sid_ProductTipo, sProduct_Tipo);
            EProduct_Tipo oeProductTipo = new EProduct_Tipo();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeProductTipo.id_ProductTipo = dt.Rows[i]["id_ProductTipo"].ToString().Trim();
                        oeProductTipo.Product_Tipo = dt.Rows[i]["Product_Tipo"].ToString().Trim();
                        oeProductTipo.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        oeProductTipo.ProductTipo_Status = Convert.ToBoolean(dt.Rows[i]["ProductTipo_Status"].ToString().Trim());
                        oeProductTipo.ProductTipo_CreateBy = dt.Rows[i]["ProductTipo_CreateBy"].ToString().Trim();
                        oeProductTipo.ProductTipo_DateBy = Convert.ToDateTime(dt.Rows[i]["ProductTipo_DateBy"].ToString().Trim());
                        oeProductTipo.ProductTipo_ModiBy = dt.Rows[i]["ProductTipo_ModiBy"].ToString().Trim();
                        oeProductTipo.ProductTipo_DateModiBy = Convert.ToDateTime(dt.Rows[i]["ProductTipo_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }


        //Método: Actualizar Tipos de producto         

        public EProduct_Tipo Actualizar_ProductTipo(string sid_ProductTipo, string sProduct_Tipo, string sid_ProductCategory, bool bProductTipo_Status,
            string sProductTipo_ModiBy, DateTime tProductTipo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_TIPOPRODUCTO", sid_ProductTipo, sProduct_Tipo, sid_ProductCategory, bProductTipo_Status,
             sProductTipo_ModiBy, tProductTipo_DateModiBy);
            EProduct_Tipo oeaProductTipo = new EProduct_Tipo();
            oeaProductTipo.Product_Tipo = sProduct_Tipo;
            oeaProductTipo.id_ProductCategory = sid_ProductCategory;
            oeaProductTipo.ProductTipo_Status = bProductTipo_Status;
            oeaProductTipo.ProductTipo_ModiBy = sProductTipo_ModiBy;
            oeaProductTipo.ProductTipo_DateModiBy = tProductTipo_DateModiBy;
            return oeaProductTipo;
        }
    }
}
        


       
