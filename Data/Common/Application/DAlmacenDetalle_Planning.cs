using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DAlmacenDetalle_Planning
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creación; 10/11/2009
    /// Requerimiento No 
    /// Descripción : Clase Data encargada de definir todos los metodos transaccionales para operar AlmacenDetalle_Planning
    /// </summary>
    /// 
    public class DAlmacenDetalle_Planning
    {
        private Conexion oConn;
        public DAlmacenDetalle_Planning()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
                
       
        /// <summary>
        /// Metodo para registrar AlmacenDetalle_Planning (Actividades propias datos de encabezado y pie)
        /// Modificación: 29/07/2010 Se cambia nombre de Store UP_WEBSIGE_OPERATIVO_SAVEPHOTOACTIVIDADPROPIA
        /// Por UP_WEBXPLORA_OPE_SAVEPHOTOACTIVIDADPROPIA y se modifica tipo de dato del 
		/// parametro id_planning de int a string. Ing. Mauricio Ortiz 
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
        /// <returns oerAlmacenDetalle_Planning></returns>
        public EAlmacenDetalle_Planning RegistrarDatosCalle(int iid_contenedor, string sid_planning, int iPerson_id, int iid_MPOSPlanning,
            int iid_ProductsPlanning, DateTime tdato_Date, string sdatoAlmacenado, int iweekNo, bool balmacenDetalle_Status, string salmacenDetalle_CreateBy,
            DateTime talmacenDetalle_DateBy, string salmacenDetalle_ModiBy, DateTime talmacenDetalle_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_SAVEACTIVIDADPROPIA", iid_contenedor, sid_planning, iPerson_id, iid_MPOSPlanning,
            iid_ProductsPlanning, tdato_Date, sdatoAlmacenado, iweekNo, balmacenDetalle_Status, salmacenDetalle_CreateBy,
            talmacenDetalle_DateBy, salmacenDetalle_ModiBy, talmacenDetalle_DateModiBy);

            EAlmacenDetalle_Planning oerAlmacenDetalle_Planning = new EAlmacenDetalle_Planning();
            oerAlmacenDetalle_Planning.id_contenedor = iid_contenedor;
            oerAlmacenDetalle_Planning.id_planning = sid_planning;
            oerAlmacenDetalle_Planning.Person_id = iPerson_id;
            oerAlmacenDetalle_Planning.id_MPOSPlanning = iid_MPOSPlanning;
            oerAlmacenDetalle_Planning.id_ProductsPlanning = iid_ProductsPlanning;
            oerAlmacenDetalle_Planning.dato_Date = tdato_Date;
            oerAlmacenDetalle_Planning.datoAlmacenado = sdatoAlmacenado;
            oerAlmacenDetalle_Planning.weekNo = iweekNo;
            oerAlmacenDetalle_Planning.almacenDetalle_Status = balmacenDetalle_Status;
            oerAlmacenDetalle_Planning.almacenDetalle_CreateBy = salmacenDetalle_CreateBy;
            oerAlmacenDetalle_Planning.almacenDetalle_DateBy = talmacenDetalle_DateBy;
            oerAlmacenDetalle_Planning.almacenDetalle_ModiBy = salmacenDetalle_ModiBy;
            oerAlmacenDetalle_Planning.almacenDetalle_DateModiBy = talmacenDetalle_DateModiBy;
            return oerAlmacenDetalle_Planning;
        }

        
        /// Metodo para actualizar AlmacenDetalle_Planning (Actividades propias)

        public EAlmacenDetalle_Planning Actualizar_DatosCalle(int iid_almacenDetalle, int iPerson_id, int iid_MPOSPlanning, 
            int iid_ProductsPlanning, DateTime tdato_Date, string sdatoAlmacenado, int iweekNo, bool balmacenDetalle_Status,  string salmacenDetalle_ModiBy, 
            DateTime talmacenDetalle_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_OPERATIVO_UPDATEFORMATOACTIVIDADPROPIA", iid_almacenDetalle, iPerson_id, iid_MPOSPlanning,
             iid_ProductsPlanning, tdato_Date, sdatoAlmacenado, iweekNo, balmacenDetalle_Status, salmacenDetalle_ModiBy,
            talmacenDetalle_DateModiBy);
            EAlmacenDetalle_Planning oeaDatosCalle = new EAlmacenDetalle_Planning();
            oeaDatosCalle.id_almacenDetalle = iid_almacenDetalle;
            oeaDatosCalle.Person_id = iPerson_id;
            oeaDatosCalle.id_MPOSPlanning = iid_MPOSPlanning;
            oeaDatosCalle.id_ProductsPlanning = iid_ProductsPlanning;
            oeaDatosCalle.dato_Date = tdato_Date;
            oeaDatosCalle.datoAlmacenado = sdatoAlmacenado;
            oeaDatosCalle.weekNo = iweekNo;
            oeaDatosCalle.almacenDetalle_Status = balmacenDetalle_Status;
            oeaDatosCalle.almacenDetalle_ModiBy = salmacenDetalle_ModiBy;
            oeaDatosCalle.almacenDetalle_DateModiBy = talmacenDetalle_DateModiBy;
            return oeaDatosCalle;
        }
    }
}
        
