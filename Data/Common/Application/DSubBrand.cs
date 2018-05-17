using System;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para SubBrand
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate: 31-08-09
    /// Requerimiento:

    public class DSubBrand
    {
        private Conexion oConn;
        public DSubBrand()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }
        //Metodo para Registrar SubMarcas de Producto

        /// <summary>
        /// Modificación: Se  Elimina  id_SubBrand en la inserción(se elimina columana en metodo RegistrarSubBrandPK)
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="bSubBrand_Status"></param>
        /// <param name="sSubBrand_CreateBy"></param>
        /// <param name="tSubBrand_DateBy"></param>
        /// <param name="sSubBrand_ModiBy"></param>
        /// <param name="tSubBrand_DateModiBy"></param>
        /// <returns>oerSubBrand</returns>
        public ESubBrand RegistrarSubBrandPK(string sName_SubBrand, int iid_Brand, bool bSubBrand_Status,
            string sSubBrand_CreateBy, DateTime tSubBrand_DateBy, string sSubBrand_ModiBy, DateTime tSubBrand_DateModiBy)
        {
            oConn = new Conexion(1);
            int iid_SubBrand = Convert.ToInt32(oConn.ejecutarEscalar("UP_WEB_REGISTER_SUBBRAND",  sName_SubBrand, iid_Brand, bSubBrand_Status,
             sSubBrand_CreateBy, tSubBrand_DateBy, sSubBrand_ModiBy, tSubBrand_DateModiBy));
            oConn = null;
            ESubBrand oerSubBrand = new ESubBrand();
            oerSubBrand.id_SubBrand = iid_SubBrand;
            oerSubBrand.Name_SubBrand = sName_SubBrand;
            oerSubBrand.id_Brand = iid_Brand;
            oerSubBrand.SubBrand_Status = bSubBrand_Status;
            oerSubBrand.SubBrand_CreateBy = sSubBrand_CreateBy;
            oerSubBrand.SubBrand_DateBy = tSubBrand_DateBy;
            oerSubBrand.SubBrand_ModiBy = sSubBrand_ModiBy;
            oerSubBrand.SubBrand_DateModiBy = tSubBrand_DateModiBy;
            return oerSubBrand;
        }
        /// <summary>
        /// Inserta en BD Intermedia
        /// 31/01/2011 Magaly Jiménez.
        /// Se agregan parametros para la insercion directa en DB Intermedia
        /// 15/06/2011 Angel Ortiz.
        /// </summary>
        /// <returns></returns>
        public ESubBrand RegistrarSubBrandPKTMP(string sid_SubBrand, string sName_SubBrand, int iid_Brand, bool bSubBrand_Status)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_SUBBRANDTMP", sid_SubBrand, sName_SubBrand, iid_Brand, bSubBrand_Status);
            oConn = null;
            ESubBrand oerSubBrandtmp = new ESubBrand();
            return oerSubBrandtmp;
        }
        //Método que permite consultar SubMarcas de Producto

        /// <summary>
        /// Modificado: Consulta se cambia tipo de dato de la columna id_SubBrand de de varchar a int. 
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <returns>dt</returns>
        public DataTable ObtenerSubBrand(string sid_ProductCategory,  int iid_Brand, string sName_SubBrand)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHSUBBRAND", sid_ProductCategory, iid_Brand, sName_SubBrand );
            oConn = null;
            ESubBrand oeSubBrand = new ESubBrand();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeSubBrand.id_SubBrand = Convert.ToInt32( dt.Rows[i]["id_SubBrand"].ToString().Trim());
                        oeSubBrand.Name_SubBrand = dt.Rows[i]["Name_SubBrand"].ToString().Trim();
                        oeSubBrand.id_Brand = Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                        oeSubBrand.SubBrand_Status = Convert.ToBoolean(dt.Rows[i]["SubBrand_Status"].ToString().Trim());
                        oeSubBrand.SubBrand_CreateBy = dt.Rows[i]["SubBrand_CreateBy"].ToString().Trim();
                        oeSubBrand.SubBrand_DateBy = Convert.ToDateTime(dt.Rows[i]["SubBrand_DateBy"].ToString().Trim());
                        oeSubBrand.SubBrand_ModiBy = dt.Rows[i]["SubBrand_ModiBy"].ToString().Trim();
                        oeSubBrand.SubBrand_DateModiBy = Convert.ToDateTime(dt.Rows[i]["SubBrand_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Metodo que permite Actualizar submarcas productos

        /// <summary>
        /// Modificado:   Actualización se cambia tipo de dato de la columna id_SubBrand de de varchar a int.
        /// 18/08/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="bSubBrand_Status"></param>
        /// <param name="sSubBrand_ModiBy"></param>
        /// <param name="tSubBrand_DateModiBy"></param>
        /// <returns></returns>
        public ESubBrand Actualizar_SubBrand( int iid_SubBrand, string sName_SubBrand, int iid_Brand, bool bSubBrand_Status,
             string sSubBrand_ModiBy, DateTime tSubBrand_DateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_SUBBRAND", iid_SubBrand, sName_SubBrand, iid_Brand, bSubBrand_Status,
              sSubBrand_ModiBy, tSubBrand_DateModiBy);
            oConn = null;
            ESubBrand oeaSubBrand = new ESubBrand();
            oeaSubBrand.id_SubBrand = iid_SubBrand;
            oeaSubBrand.Name_SubBrand = sName_SubBrand;
            oeaSubBrand.id_Brand = iid_Brand;
            oeaSubBrand.SubBrand_Status = bSubBrand_Status;
            oeaSubBrand.SubBrand_ModiBy = sSubBrand_ModiBy;
            oeaSubBrand.SubBrand_DateModiBy = tSubBrand_DateModiBy;
            return oeaSubBrand;
        }
        /// <summary>
        /// Actuliza Submarcas en BD intermedia
        /// 31/01/2011 Magaly Jiménez.
        /// </summary>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="bSubBrand_Status"></param>
        /// <returns></returns>
        public ESubBrand Actualizar_SubBrandtmp( int iid_SubBrand, string sName_SubBrand, int iid_Brand, bool bSubBrand_Status)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_SUBBRANDTMP", iid_SubBrand, sName_SubBrand, iid_Brand, bSubBrand_Status);
            oConn = null;
            ESubBrand oeaSubBrandtmp = new ESubBrand();
            oeaSubBrandtmp.id_SubBrand = iid_SubBrand;
            oeaSubBrandtmp.Name_SubBrand = sName_SubBrand;
            oeaSubBrandtmp.id_Brand = iid_Brand;
            oeaSubBrandtmp.SubBrand_Status = bSubBrand_Status; 
            return oeaSubBrandtmp;
        }
    }
}
      
