using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Información de Aplicación
    /// </summary>
    public class Aplicacion
    {
        public Aplicacion()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        public EAplicacion obtener(string sCountry,string smodul)
        {
            Lucky.Data.Common.Application.DAplicacion odAplicacion = 
                new Lucky.Data.Common.Application.DAplicacion();
            EAplicacion oeAplicacion = odAplicacion.obtenerPK(sCountry, smodul);
            odAplicacion = null;
            return oeAplicacion;
        }
    }
}