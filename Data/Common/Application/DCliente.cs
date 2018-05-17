using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: <DCliente>
    /// Creada Por: <Ing.Carlos Alberto Hernandez Rincon>
    /// Fecha Creacion:<20/03/2010>
    /// Requerimiento:<Modulo CLiente>
    /// Descripcion:<Permite obtener datos para modulo CLiente>
    /// </summary>
    public class DCliente
    {
        private Conexion oConn;
        public DCliente() {

            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        
        
        
        }
        /// <summary>
        /// Metodo para obtener las 3 Categorias principales
        /// </summary>
        /// <param name="icompanyid"></param>
        /// <param name="tfecini"></param>
        /// <param name="tfecfin"></param>
        /// <returns></returns>
        public DataSet Get_ObtenerCtegorias_Presentaciones(int icompanyid, DateTime tfecini, DateTime tfecfin) {
            DataSet dscatego = null;
            dscatego = oConn.ejecutarDataSet("UP_WEBSIGE_CLIENTE_OBTENERCATEGOPRINCIPAL_PRESENTACIONES", icompanyid, tfecini, tfecfin);
            return dscatego;
        
        
        
        }

        /// <summary>
        /// Metodo para obtener Aporte Nacional al Plan de Ventas
        /// </summary>
        /// <param name="icompanyid"></param>
        /// <param name="tfecini"></param>
        /// <param name="tfecfin"></param>
        /// <returns></returns>
        public DataSet Get_ObtenerAporteNal_PlanVentas(int icompanyid, DateTime tfecini, DateTime tfecfin)
        {
            DataSet dsplan = null;
            dsplan = oConn.ejecutarDataSet("UP_WEBSIGE_CLIENTE_CONTRIBUCIONAL_PV", icompanyid, tfecini, tfecfin);
            return dsplan;



        }


    }
}
