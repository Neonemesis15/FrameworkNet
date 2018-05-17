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
    /// Clase: AlmacenDetalle_Planning
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 10/11/2009
    /// Description: Establece los metodos para operar informacion relacionada con la data obtenida en calle
    /// Requerimiento No:
    /// </summary>
    /// 
    public class AlmacenDetalle_Planning
    {
        public AlmacenDetalle_Planning()
        {
            //Se define el constructor por defecto
        }              

        /// <summary>
        /// Metodo para registrar AlmacenDetalle_Planning (Actividades propias)
        /// Modificación  : 29/07/2010 Se cambia tipo de dato en id_planning de int a string
        ///                 Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_contenedor"></param>
        /// <param name="sid_planning"></param>
        /// <param name="iPerson_id"></param>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="iid_ProductsPlanning"></param>
        /// <param name="tdato_Date"></param>
        /// <param name="sdatoAlmacenado"></param>
        /// <param name="iweekNo"></param>
        /// <param name="balmacenDetalle_Status"></param>
        /// <param name="salmacenDetalle_CreateBy"></param>
        /// <param name="talmacenDetalle_DateBy"></param>
        /// <param name="salmacenDetalle_ModiBy"></param>
        /// <param name="talmacenDetalle_DateModiBy"></param>
        /// <returns></returns>
        public EAlmacenDetalle_Planning RegistrarDatosCalle(int iid_contenedor, string sid_planning, int iPerson_id, int iid_MPOSPlanning,
            int iid_ProductsPlanning, DateTime tdato_Date, string sdatoAlmacenado, int iweekNo, bool balmacenDetalle_Status, string salmacenDetalle_CreateBy,
            DateTime talmacenDetalle_DateBy, string salmacenDetalle_ModiBy, DateTime talmacenDetalle_DateModiBy)
        {
            DAlmacenDetalle_Planning odrAlmacenDetalle_Planning = new DAlmacenDetalle_Planning();
            EAlmacenDetalle_Planning oeAlmacenDetalle_Planning = odrAlmacenDetalle_Planning.RegistrarDatosCalle(iid_contenedor, sid_planning, iPerson_id, iid_MPOSPlanning,
            iid_ProductsPlanning, tdato_Date, sdatoAlmacenado, iweekNo, balmacenDetalle_Status, salmacenDetalle_CreateBy,
            talmacenDetalle_DateBy, salmacenDetalle_ModiBy, talmacenDetalle_DateModiBy);
            odrAlmacenDetalle_Planning = null;
            return oeAlmacenDetalle_Planning;
        }

        /// Metodo para actualizar AlmacenDetalle_Planning (Actividades propias)
        /// 
        public EAlmacenDetalle_Planning ActualizarDatosCalle(int iid_almacenDetalle, int iPerson_id, int iid_MPOSPlanning,
            int iid_ProductsPlanning, DateTime tdato_Date, string sdatoAlmacenado, int iweekNo, bool balmacenDetalle_Status, string salmacenDetalle_ModiBy,
            DateTime talmacenDetalle_DateModiBy)
        {
            DAlmacenDetalle_Planning odaDatosCalle = new DAlmacenDetalle_Planning();
            EAlmacenDetalle_Planning oeaDatosCalle = odaDatosCalle.Actualizar_DatosCalle(iid_almacenDetalle, iPerson_id, iid_MPOSPlanning,
             iid_ProductsPlanning, tdato_Date, sdatoAlmacenado, iweekNo, balmacenDetalle_Status, salmacenDetalle_ModiBy,
             talmacenDetalle_DateModiBy);
            odaDatosCalle = null;
            return oeaDatosCalle;
        }
    }
}
        

