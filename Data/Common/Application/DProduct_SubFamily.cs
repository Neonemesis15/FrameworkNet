using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para SubFamilia de Producto
    /// CreateBy: Angel Ortiz
    /// CreateDate: 08/07/2011
    /// Requerimiento:
    /// </summary>
    class DProduct_SubFamily
    {
        private Conexion oConn;
        public DProduct_SubFamily()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
    }
}
