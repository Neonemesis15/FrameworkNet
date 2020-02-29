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

        Lucky.Data.Common.Application.DAplicacion odAplicacion = new Lucky.Data.Common.Application.DAplicacion();
        public Aplicacion()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        public EAplicacion obtener(string sCountry,string smodul)
        {
            EAplicacion oeAplicacion = null;
            try
            {
                oeAplicacion = odAplicacion.obtenerPK(sCountry, smodul);
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Error:" + ex.Message.ToString());
            }
            return oeAplicacion;
        }
    }
}