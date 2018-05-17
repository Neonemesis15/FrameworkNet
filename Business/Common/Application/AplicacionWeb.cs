using System;
using System.Data;
using System.Text;
using Lucky.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Información de Aplicación
    /// </summary>
    public class AplicacionWeb : Aplicacion
    {
        public AplicacionWeb()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        public EAplicacionWeb obtenerAplicacion(string sCountry, string smodul)
        {
           
            DAplicacion odAplicacion = new DAplicacion();
            EAplicacion oeAplicacion = odAplicacion.obtenerPK(sCountry,smodul);
            EAplicacionWeb oeAplicacionWeb = new EAplicacionWeb();
            oeAplicacionWeb.NombreWeb = oeAplicacion.nameapp;
            oeAplicacionWeb.verapp = oeAplicacion.verapp;
            oeAplicacionWeb.abrapp = oeAplicacionWeb.abrapp;
             oeAplicacionWeb.HomePage = oeAplicacion.appurl;
             odAplicacion = null;
            return oeAplicacionWeb;
        }
    }
}