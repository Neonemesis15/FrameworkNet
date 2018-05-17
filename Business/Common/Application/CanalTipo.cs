using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class CanalTipo
    {
        private DCanalTipo odcanaltipo;

        public CanalTipo()
        {
            odcanaltipo = new DCanalTipo();
        }        

        public ECanalTipo registrartipocanal(string schtype_nombre, string schtype_descripcion, bool bchtype_status, 
            string schtype_createby)
        {
            ECanalTipo oecanaltipo = new ECanalTipo();
            oecanaltipo = odcanaltipo.registrartipocanal(schtype_nombre, schtype_descripcion, bchtype_status, schtype_createby);
            return oecanaltipo;
        }

        public ECanalTipo actualizartipocanal(int ichtype_id, string schtype_nombre, string schtype_descripcion, bool bchtype_status,
            string schtype_modiby)
        {
            ECanalTipo oecanaltipo = new ECanalTipo();
            oecanaltipo = odcanaltipo.actualizartipocanal(ichtype_id, schtype_nombre, schtype_descripcion, bchtype_status, schtype_modiby);
            return oecanaltipo;
        }

        public DataTable buscarTipoCanal()
        {
            DataTable tipocanal = new DataTable();
            tipocanal = odcanaltipo.buscarTipoCanal();
            return tipocanal;
        }

        public DataTable buscarTipoCanal(string schtype_nombre, string schtype_descripcion)
        {
            DataTable tipocanal = new DataTable();
            tipocanal = odcanaltipo.buscarTipoCanal(schtype_nombre,schtype_descripcion);
            return tipocanal;
        }
    }
}
