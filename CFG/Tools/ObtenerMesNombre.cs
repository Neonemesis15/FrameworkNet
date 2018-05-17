using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Data;

namespace Lucky.CFG.Tools
{
    /// <summary>
    /// Clase: ObtenerMesNombre
    /// Creada Por:  Ing.Carlos Alberto Hernandez Rincon
    /// Fecha: 10/03/2010
    /// Requerimiento<Modulo Cliente-Fltros Generales>
    /// Descripcion: Permite Obtener el nombre del mes basados en una fecha
    /// </summary>
    public class ObtenerMesNombre
    {
        private Conexion oConn;
        public ObtenerMesNombre() {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        
        
        
        }
        /// <summary>
        /// Metodo Para Obtener el Nombre del Mes
        /// </summary>
        /// <param name="tfecha"></param>
        /// <returns></returns>
        public string ObtenerNombreMes(DateTime tfecha) {

            string mes;
            mes = oConn.ejecutarEscalar("UP_WEBSIGE_GENERAL_OBTENERMES_FECHA", tfecha);
            return mes;

        
        
        
        
        
        }
    }
}
