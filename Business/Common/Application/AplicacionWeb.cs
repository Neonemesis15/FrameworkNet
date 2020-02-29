using System;
using System.Data;
using System.Text;
using Lucky.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;
using log4net;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Obtiene Información de la Aplicación
    /// Developed by: 
    /// - Ing. Carlos Alberto Hernandez R. (CAHR)
    /// Changes:
    /// - 2009-04-29 Carlos Alberto Hernandez R. (CAHR) Creación de la Clase
    /// - 2018-10-15 Pablo Salas Alvarez (PSA) Refactoring.
    /// </summary>
    public class AplicacionWeb : Aplicacion
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Aplicacion));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        //static AplicacionWeb()
        //{
        //    XmlConfigurator.Configure();
        //}
        // Inicializar Ilog


        // Obtener información de la Aplicación
        DAplicacion odAplicacion;

        // Variable para almacenar los Mensajes de Error de la Aplicación
        public String message = "";

        /// <summary>
        /// Contructor
        /// </summary>
        public AplicacionWeb(){

            // Inicializar
            odAplicacion = new DAplicacion();
        }

        /// <summary>
        /// Obtener Información de la Aplicación de la Tabla [appLucky]
        /// </summary>
        /// <param name="sCountry">Codigo del Pais</param>
        /// <param name="smodul">Código del Módulo</param>
        /// <returns></returns>
        public EAplicacionWeb obtenerAplicacion(string sCountry, string smodul){

            EAplicacionWeb oeAplicacionWeb = new EAplicacionWeb();
            
            try{
                EAplicacion oeAplicacion = odAplicacion.obtenerPK(sCountry, smodul);

                if (odAplicacion.getMessage().Equals("")){

                    oeAplicacionWeb.NombreWeb = oeAplicacion.nameapp;
                    oeAplicacionWeb.verapp = oeAplicacion.verapp;
                    oeAplicacionWeb.abrapp = oeAplicacionWeb.abrapp;
                    oeAplicacionWeb.HomePage = oeAplicacion.appurl;
                    log.Info("[AplicacionWeb][obtenerAplicacion_Passed]:");
                    //odAplicacion = null;
                }
                else{
                    message = odAplicacion.getMessage();
                    log.Debug("[AplicacionWeb][obtenerAplicacion_Failed] :" + message);

                }
            }
            catch (Exception ex) {
                message = "Ocurrio un Error: " + ex.ToString().Substring(0, 100) + "...";
                log.Error("[AplicacionWeb][obtenerAplicacion_Failed] : ", ex);
            }

            return oeAplicacionWeb;
        }

        /// <summary>
        /// Obtiene el Mensaje de Error en caso se haya presentado
        /// Si es Null quiere decir que todo esta ok.
        /// </summary>
        /// <returns></returns>
        public String getMessage()
        {
            return message;
        }
    }
}