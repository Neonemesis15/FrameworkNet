using System;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DCanalTipo.
    /// CreateBy: Angel Ortiz
    /// CreateDate: 05/08/2011
    /// Requerimiento:
    /// </summary>
 
    public class DCanalTipo
    {
        private Conexion oConn;
        
        public DCanalTipo()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

        public ECanalTipo registrartipocanal(string schtype_nombre, string schtype_descripcion, bool bchtype_status, 
            string schtype_createby)
        {
            oConn = new Conexion(1);
            ECanalTipo oecanaltipo = new ECanalTipo();
            string ichtype_id = oConn.ejecutarEscalar("UP_WEBXPLORA_AD_REGISTER_CHANNELTYPE", schtype_nombre, schtype_descripcion, bchtype_status, schtype_createby);
            oecanaltipo.Ichtype_id = Convert.ToInt32(ichtype_id);
            oecanaltipo.Schtype_nombre = schtype_nombre;
            oecanaltipo.Schtype_descripcion = schtype_descripcion;
            oecanaltipo.Bchtype_status = bchtype_status;
            oecanaltipo.Schtype_createby = schtype_createby;
            return oecanaltipo;
        }

        public ECanalTipo actualizartipocanal(int ichtype_id, string schtype_nombre, string schtype_descripcion, bool bchtype_status,
            string schtype_modiby)
        {
            oConn = new Conexion(1);
            ECanalTipo oecanaltipo = new ECanalTipo();
            string response = oConn.ejecutarEscalar("UP_WEBXPLORA_AD_ACTUALIZA_CHANNELTYPE", ichtype_id, schtype_nombre, schtype_descripcion, bchtype_status, schtype_modiby);            
            return oecanaltipo;
        }

        public DataTable buscarTipoCanal()
        {
            oConn = new Conexion(1);
            DataTable tipocanal = new DataTable();
            tipocanal = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_BUSCAR_TIPOCANAL", null, null);
            return tipocanal;
        }

        public DataTable buscarTipoCanal(string schtype_nombre, string schtype_descripcion)
        {
            oConn = new Conexion(1);
            DataTable tipocanal = new DataTable();
            tipocanal = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_BUSCAR_TIPOCANAL", schtype_nombre, schtype_descripcion);
            return tipocanal;
        }
    }
}
