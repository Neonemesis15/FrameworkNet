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
    /// Clase: Barrio
    /// Creada Por: Ing. Carlos Alberto Hernandez Rincon
    /// Fecha de Creacion; 15/06/2009
    /// Descripcion: Define los metodos del negocio para la clase barrio
    /// Requerimiento No <>
    /// </summary>

    public class Barrio
    {
        public Barrio()
        {

            //Se define el constructor por defecto


        }

        /// <summary>
        /// Metodo para registrar Barrios
        /// </summary>


        public EBarrio RegistrarBarrio(string scodbarrio, string scodcountry, string scoddpto, string scodcity, string scoddistrito,
            string snamebarrio, bool bstatusbarrio, string sBarrioCreateBy, DateTime tBarrioDateBy, string sBarrioModiBy, DateTime tBarrioDateModiBy)
        {
            DBarrio odrbarrio = new DBarrio();
            EBarrio oerbarrio = odrbarrio.RegistrarBarrio(scodbarrio, scodcountry, scoddpto, scodcity, scoddistrito, snamebarrio,
                bstatusbarrio, sBarrioCreateBy, tBarrioDateBy, sBarrioModiBy, tBarrioDateModiBy);
            odrbarrio = null;
            return oerbarrio;



        }
        /// <summary>
        /// Metodo para consultar Barrios
        /// </summary>


        public DataTable ConsultarBarrio(string scodcountry, string scoddpto, string scodcity, string scoddistrito, string snamebarrio)
        {
            DBarrio odcbarrio = new DBarrio();
            DataTable dt = odcbarrio.ConsultarBarrio(scodcountry, scoddpto, scodcity, scoddistrito, snamebarrio);
            return dt;

        }
        public EBarrio ActualizarBarrio(string scodbarrio, string scodcountry, string scoddpto, string scodcity, string scoddistrito,
           string snamebarrio, bool bstatusbarrio, string sBarrioModiBy, DateTime tBarrioDateModiBy)
        {
            DBarrio odabarrio = new DBarrio();
            EBarrio oeabarrio = odabarrio.ActualizarBarrio(scodbarrio, scodcountry, scoddpto, scodcity, scoddistrito, snamebarrio, bstatusbarrio,
                sBarrioModiBy, tBarrioDateModiBy);
            odabarrio = null;
            return oeabarrio;


        }

    }
}
