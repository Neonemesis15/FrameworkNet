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
    /// Clase: Sector
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 15/09/2010
    /// Description: Establece los metodos para operar informacion relacionada con las Sectores de Punto de Venta Lucky
    /// Requerimiento No:
    /// </summary>
    /// 
    public class Sector
    {
        public Sector()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        /// permite registrar sectores de Puntos de venta
        /// 15/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sSector"></param>
        /// <param name="iid_malla"></param>
        /// <param name="bSector_Status"></param>
        /// <param name="sSector_CreateBy"></param>
        /// <param name="tSector_DateBy"></param>
        /// <param name="sSector_ModiBy"></param>
        /// <param name="tSector_DateModiBy"></param>
        /// <returns>oeSector</returns>
        public ESector RegistrarSector(string sSector, int iid_malla, bool bSector_Status,
             string sSector_CreateBy, DateTime tSector_DateBy, string sSector_ModiBy, DateTime tSector_DateModiBy)
        {
            DSector odrSector = new DSector();
            ESector oeSector = odrSector.RegistrarSector(sSector, iid_malla, bSector_Status, sSector_CreateBy, tSector_DateBy, sSector_ModiBy, tSector_DateModiBy);
            odrSector = null;
            return oeSector;
        }
        /// <summary>
        /// permite Consultar sectores de Puntos de venta
        /// 15/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sSector"></param>
        /// <param name="iid_malla"></param>
        /// <returns>dtSector</returns>
        public DataTable ConsultarSector(int iid_malla,string sSector,  int icompanyid)
        {
            DSector odsSector = new DSector();
            ESector oeSector = new ESector();

            DataTable dtSector = odsSector.ObtenerSector(iid_malla, sSector,  icompanyid);
            odsSector = null;
            return dtSector;
        }

        /// <summary>
        /// Permite Actualizar Sectores de Puntos de Venta
        ///  15/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iid_sector"></param>
        /// <param name="iid_malla"></param>
        /// <param name="sSector"></param>
        /// <param name="bSector_Status"></param>
        /// <param name="sSector_ModiBy"></param>
        /// <param name="tSector_DateModiBy"></param>
        /// <returns> oeaSector</returns>
        public ESector Actualizar_Sector(int iid_sector, int iid_malla, string sSector, bool bSector_Status,
            string sSector_ModiBy, DateTime tSector_DateModiBy)
        {
            DSector odaSector = new DSector();
            ESector oeaSector = odaSector.Actualizar_Sector(iid_sector, iid_malla, sSector, bSector_Status,
            sSector_ModiBy, tSector_DateModiBy);
            odaSector = null;
            return oeaSector;
        }
    }
}
