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
    /// Clase: SubBrand
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 01/09/2009
    /// Description: Establece los metodos para operar informacion relacionada con las SubMarcas de productos Lucky
    /// Requerimiento No:
    /// </summary>
    /// 
    public class SubBrand
    {
        public SubBrand()
        {
            //Se define el constructor por defecto
        }

        //----Metodo que permite registrar SubMarca de producto

        /// <summary>
        /// Se elimina  id_SubBrand en la inserción
        /// 17/08/2010 Magaly Jimenez
        /// </summary>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="bSubBrand_Status"></param>
        /// <param name="sSubBrand_CreateBy"></param>
        /// <param name="tSubBrand_DateBy"></param>
        /// <param name="sSubBrand_ModiBy"></param>
        /// <param name="tSubBrand_DateModiBy"></param>
        /// <returns>oeSubBrand</returns>
        public ESubBrand RegistrarSubBrand(string sName_SubBrand, int iid_Brand, bool bSubBrand_Status,
            string sSubBrand_CreateBy, DateTime tSubBrand_DateBy, string sSubBrand_ModiBy, DateTime tSubBrand_DateModiBy)
        {
            DSubBrand odrSubBrand = new DSubBrand();
            ESubBrand oeSubBrand = odrSubBrand.RegistrarSubBrandPK(sName_SubBrand,iid_Brand, bSubBrand_Status,
             sSubBrand_CreateBy, tSubBrand_DateBy, sSubBrand_ModiBy, tSubBrand_DateModiBy);
            odrSubBrand = null;
            return oeSubBrand;
        }
        /// <summary>
        /// Inserta en Bd intermedia
        /// 31/01/2011 Magaly Jiménez
        /// Agregados parametros apra insrcion directa en DB Intermedia
        /// 15/06/2011 - Angel Ortiz.
        /// </summary>
        /// <returns></returns>
        public ESubBrand RegistrarSubBrandTMP(string sid_SubBrand, string sName_SubBrand, int iid_Brand, bool bSubBrand_Status)
        {
            DSubBrand odrSubBrandtmp = new DSubBrand();
            ESubBrand oeSubBrandtmp = odrSubBrandtmp.RegistrarSubBrandPKTMP(sid_SubBrand, sName_SubBrand, iid_Brand, bSubBrand_Status);
            odrSubBrandtmp = null;
            return oeSubBrandtmp;
        }


        //---Metodo de Consulta de SubMarcas de producto

        /// <summary>
        /// Se cambia tipo de dato de varchar a int en la columna id_SubBrand.
        /// 17/08/2010 Magaly Jimenez
        /// </summary>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <returns>dtSubBrand</returns>
        public DataTable SearchSubBrand(string sid_ProductCategory,int iid_Brand,  string sName_SubBrand)
        {
            DSubBrand odsSubBrand = new DSubBrand();
            ESubBrand oeSubBrand = new ESubBrand();

            DataTable dtSubBrand = odsSubBrand.ObtenerSubBrand(sid_ProductCategory, iid_Brand, sName_SubBrand);
            odsSubBrand = null;
            return dtSubBrand;
        }

        //----Metodo que permite Actualizar SubMarca de producto 
        /// <summary>
        /// Se cambia tipo de dato de varchar a int en la columna id_SubBrand.
        /// 17/08/2010 Magaly Jimenez
        /// </summary>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="bSubBrand_Status"></param>
        /// <param name="sSubBrand_ModiBy"></param>
        /// <param name="tSubBrand_DateModiBy"></param>
        /// <returns>oeaSubBrand</returns>
        public ESubBrand Actualizar_SubBrand( int iid_SubBrand, string sName_SubBrand, int iid_Brand, bool bSubBrand_Status,
             string sSubBrand_ModiBy, DateTime tSubBrand_DateModiBy)
        {
            DSubBrand odaSubBrand = new DSubBrand();
            ESubBrand oeaSubBrand = odaSubBrand.Actualizar_SubBrand(iid_SubBrand, sName_SubBrand, iid_Brand, bSubBrand_Status,
              sSubBrand_ModiBy, tSubBrand_DateModiBy);
            odaSubBrand = null;
            return oeaSubBrand;
        }

        /// <summary>
        ///  Actuliza Submarcas en BD intermedia
        /// 31/01/2011 Magaly Jiménez.
        /// </summary>
        /// <param name="iid_SubBrand"></param>
        /// <param name="sName_SubBrand"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="bSubBrand_Status"></param>
        /// <returns></returns>
        public ESubBrand Actualizar_SubBrandtmp(int iid_SubBrand, string sName_SubBrand, int iid_Brand, bool bSubBrand_Status)
        {
            DSubBrand odaSubBrandtmp = new DSubBrand();
            ESubBrand oeaSubBrandtmp = odaSubBrandtmp.Actualizar_SubBrandtmp(iid_SubBrand, sName_SubBrand, iid_Brand, bSubBrand_Status);
            odaSubBrandtmp = null;
            return oeaSubBrandtmp;
        }
    }
}
