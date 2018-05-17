using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;
using System.Configuration;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Visita
    {
        private Conexion oCoon;

        public D_Visita() {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }
        #region AppMovil Lucky
        public void RegistrarVisita(E_Visita oE_Visita)
        {
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_VISITA",
                oE_Visita.PersonId, oE_Visita.PerfilId,
                oE_Visita.EquipoId, oE_Visita.ClienteId, 
                oE_Visita.ClientPDV_Code,oE_Visita.NoVisitaId,
                oE_Visita.FechaIni,
                oE_Visita.LatitudInicio,oE_Visita.LongitudInicio,
                oE_Visita.OrigenInicio,oE_Visita.FechaFin,
                oE_Visita.LatitudFin,oE_Visita.LongitudFin,
                oE_Visita.OrigenFin);
        }
        #endregion

        #region AppMovil Movistar
        /// <summary>
        /// Descripcion : Registro de visita para App Movil Movistar
        /// Fecha       : 21/05/2012 PSA
        /// </summary>
        /// <param name="oE_Visita_Mov"></param>
        public string RegistrarVisita_Mov(E_Visita_Mov oE_Visita_Mov)
        {
            String error = string.Empty;
            try
            {
                oCoon = new Conexion(3);
                oCoon.ejecutarDataTable("SP_GES_USU_REGISTRAR_VISITA_V_1_0"
                    , oE_Visita_Mov.Cod_Persona
                    , oE_Visita_Mov.Cod_Equipo
                    , oE_Visita_Mov.Cod_Compania
                    , oE_Visita_Mov.Cod_PtoVenta
                    , oE_Visita_Mov.Cod_NoVisita ?? null
                    , oE_Visita_Mov.Fec_RegistroInicio
                    , oE_Visita_Mov.Latitud_Inicio ?? null
                    , oE_Visita_Mov.Longitud_Inicio ?? null
                    , oE_Visita_Mov.Origen_Inicio ?? null
                    , oE_Visita_Mov.Fec_RegistroFin
                    , oE_Visita_Mov.Latitud_Fin ?? null
                    , oE_Visita_Mov.Longitud_Fin ?? null
                    , oE_Visita_Mov.Origen_fin ?? null
                    , oE_Visita_Mov.Nombre_Foto ?? null
                    , oE_Visita_Mov.Comentario_Foto ?? null //Add 09/08/2012 Pablo Salas A.
                    );
                error = string.Empty;
            }
            catch (Exception ex) {
                error = ex.Message;
            }
            return error;
        }
        #endregion

    }
}
