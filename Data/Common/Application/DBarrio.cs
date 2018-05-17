using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DBarrio
    /// Creada Por: Ing. Carlos Alberto Hernández R.
    /// Fecha de Creación; 14/06/2009
    /// Requerimiento No SIGE-ARF-132 Gestionar Division Politica Barrio
    /// Descripción : Clase Data encargada de definir todos los metodos transaccionales para operar Barrio
    /// </summary>

    public class DBarrio
    {
        private Conexion oConn;
        public DBarrio()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// Metodo para registrar Barrios
        /// </summary>


        public EBarrio RegistrarBarrio(string scodbarrio, string scodcountry, string scoddpto, string scodcity, string scoddistrito,
            string snamebarrio, bool bstatusbarrio, string sBarrioCreateBy, DateTime tBarrioDateBy, string sBarrioModiBy, DateTime tBarrioDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_REGISTRARBARRIO", scodbarrio, scodcountry, scoddpto, scodcity, scoddistrito, snamebarrio, bstatusbarrio, sBarrioCreateBy, tBarrioDateBy, sBarrioModiBy,
                tBarrioDateModiBy);

            EBarrio oerbarrio = new EBarrio();
            oerbarrio.codComunity = scodbarrio;
            oerbarrio.codcountry = scodcountry;
            oerbarrio.coddpto = scoddpto;
            oerbarrio.codcity = scodcity;
            oerbarrio.codDistrict = scoddistrito;
            oerbarrio.NameCommunity = snamebarrio;
            oerbarrio.ComunityStatus = bstatusbarrio;
            oerbarrio.CommunityCreateBy = sBarrioCreateBy;
            oerbarrio.CommunityDateBy = tBarrioDateBy;
            oerbarrio.CommunityModiBy = sBarrioModiBy;
            oerbarrio.CommunityDateModiBy = tBarrioDateModiBy;
            return oerbarrio;

        }
        /// <summary>
        /// Metodo para Consultar barrios
        /// </summary>


        public DataTable ConsultarBarrio(string scodcountry, string scoddpto, string scodcity, string scoddistrito, string snamebarrio)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_CONSULTARBARRIOS", scodcountry, scoddpto, scodcity, scoddistrito, snamebarrio);
            EBarrio oecbarrio = new EBarrio();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oecbarrio.codComunity = dt.Rows[i]["cod_Community"].ToString().Trim();
                        oecbarrio.codcountry = dt.Rows[i]["cod_country"].ToString().Trim();
                        oecbarrio.coddpto = dt.Rows[i]["cod_dpto"].ToString().Trim();
                        oecbarrio.codcity = dt.Rows[i]["cod_City"].ToString().Trim();
                        oecbarrio.codDistrict = dt.Rows[i]["cod_District"].ToString().Trim();
                        oecbarrio.NameCommunity = dt.Rows[i]["Name_Community"].ToString().Trim();
                        oecbarrio.ComunityStatus = Convert.ToBoolean(dt.Rows[i]["Comunity_Status"].ToString().Trim());
                        oecbarrio.CommunityCreateBy = dt.Rows[i]["Community_CreateBy"].ToString().Trim();
                        oecbarrio.CommunityDateBy = Convert.ToDateTime(dt.Rows[i]["Community_DateBy"].ToString().Trim());
                        oecbarrio.CommunityModiBy = dt.Rows[i]["Community_ModiBy"].ToString().Trim();
                        oecbarrio.CommunityDateModiBy = Convert.ToDateTime(dt.Rows[i]["Community_DateModiBy"].ToString().Trim());

                    }
                }
                return dt;

            }

            else
            {

                return null;
            }
        }







        /// <summary>
        /// Metodo para Actualizar Barrios
        /// </summary>


        public EBarrio ActualizarBarrio(string scodbarrio, string scodcountry, string scoddpto, string scodcity, string scoddistrito,
            string snamebarrio, bool bstatusbarrio, string sBarrioModiBy, DateTime tBarrioDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZARBARRIO", scodbarrio, scodcountry, scoddpto, scodcity, scoddistrito, snamebarrio, bstatusbarrio, sBarrioModiBy,
                tBarrioDateModiBy);

            EBarrio oeabarrio = new EBarrio();
            oeabarrio.codComunity = scodbarrio;
            oeabarrio.codcountry = scodcountry;
            oeabarrio.coddpto = scoddpto;
            oeabarrio.codcity = scodcity;
            oeabarrio.codDistrict = scoddistrito;
            oeabarrio.NameCommunity = snamebarrio;
            oeabarrio.ComunityStatus = bstatusbarrio;
            oeabarrio.CommunityModiBy = sBarrioModiBy;
            oeabarrio.CommunityDateModiBy = tBarrioDateModiBy;
            return oeabarrio;

        }
    }
}
