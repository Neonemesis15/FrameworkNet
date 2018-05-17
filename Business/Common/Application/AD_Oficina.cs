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
    /// Clase:Oficina
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 29/10/2010
    /// </summary>

    public class AD_Oficina
    {
        public AD_Oficina()
        {
            //Se define el constructor por defecto
        }
        /// <summary>
        /// registra oficinas
        /// 29/10/2010 Magaly Jiménez
        /// modificiación se agregan campos abreviatura y orden 
        /// 25/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sName_Oficina"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="bOficina_Status"></param>
        /// <param name="sOficina_CreateBy"></param>
        /// <param name="tOficina_DateBy"></param>
        /// <param name="sOficina_ModiBy"></param>
        /// <param name="tOficina_DateModiBy"></param>
        /// <returns></returns>
        public EAD_Oficina RegistrarOficina(int iCompany_id, string sName_Oficina, string sAbreviatura, int iOrden, bool bOficina_Status, string sOficina_CreateBy, DateTime tOficina_DateBy, string sOficina_ModiBy, DateTime tOficina_DateModiBy)
        {
            DAD_Oficina odrOficina = new DAD_Oficina();
            EAD_Oficina oeOficina = odrOficina.RegistrarOficinas(iCompany_id, sName_Oficina, sAbreviatura, iOrden, bOficina_Status, sOficina_CreateBy, tOficina_DateBy, sOficina_ModiBy, tOficina_DateModiBy);
            odrOficina = null;
            return oeOficina;
        }
        /// <summary>
        /// consulta información en maestro de oficinas
        /// 30/10/2010 Magaly Jiménez
        /// </summary>
        /// <param name="lcod_Oficina"></param>
        /// <param name="sName_Oficina"></param>
        /// <returns></returns>
        public DataTable ConsultarOficinas(long lcod_Oficina, string sName_Oficina)
        {
            DAD_Oficina odsOficina = new DAD_Oficina();
            EAD_Oficina oeOficina = new EAD_Oficina();
            DataTable dtOficina=odsOficina.ObtenerOficina(lcod_Oficina, sName_Oficina);
            odsOficina = null;
            return dtOficina;
        }


        /// <summary>
        /// permite Actualizar información en maestro de Oficina.
        /// 30/10/2010 Magaly Jiménez
        /// modificiación se agregan campos de abreviatura y orden en  maestro de Oficina.
        /// 25/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="lcod_Oficina"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="sName_Oficina"></param>
        /// <param name="bOficina_Status"></param>
        /// <param name="sOficina_ModiBy"></param>
        /// <param name="tOficina_DateModiBy"></param>
        /// <returns>oeaOfcina</returns>
        public EAD_Oficina Actualizar_Oficina(long lcod_Oficina, int iCompany_id, string sName_Oficina, string sAbreviatura, int iOrden, bool bOficina_Status, string sOficina_ModiBy, DateTime tOficina_DateModiBy)
        {
            DAD_Oficina odaOficina = new DAD_Oficina();
            EAD_Oficina oeaOfcina = odaOficina.Actualizar_Oficina(lcod_Oficina, iCompany_id, sName_Oficina, sAbreviatura, iOrden, bOficina_Status, sOficina_ModiBy, tOficina_DateModiBy);
            odaOficina = null;
            return oeaOfcina;
        }
           

    }
}
