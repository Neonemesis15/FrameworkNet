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
    public class D_Marcacion
    {

        private Conexion oCoon;

        public D_Marcacion() {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }

        public void RegistrarMarcacion(E_Marcacion oE_Marcacion) {
            oCoon.ejecutarDataTable("STP_JVM_INSERTAR_MARCACION", oE_Marcacion.PersonId,oE_Marcacion.PerfilId,oE_Marcacion.EquipoId,oE_Marcacion.ClienteId,oE_Marcacion.EstadoId,oE_Marcacion.MotivoId,oE_Marcacion.FechaIni,oE_Marcacion.LatitudInicio,oE_Marcacion.LongitudInicio,oE_Marcacion.OrigenInicio,oE_Marcacion.FechaFin,oE_Marcacion.LatitudFin,oE_Marcacion.LongitudFin,oE_Marcacion.OrigenFin);
        }

        public void RegistrarMarcacion_Mov(E_Marcacion oE_Marcacion)
        {
            oCoon = new Conexion(3);
            oCoon.ejecutarDataTable("SP_GES_USU_REGISTRAR_ESTADO", oE_Marcacion.PersonId, oE_Marcacion.EquipoId, oE_Marcacion.ClienteId, oE_Marcacion.EstadoId ?? "0", oE_Marcacion.MotivoId ?? "0", oE_Marcacion.FechaIni, oE_Marcacion.LatitudInicio, oE_Marcacion.LongitudInicio, oE_Marcacion.OrigenInicio, oE_Marcacion.FechaFin, oE_Marcacion.LatitudFin, oE_Marcacion.LongitudFin, oE_Marcacion.OrigenFin);
        }
    }
}