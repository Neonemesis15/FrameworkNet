using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Distribuidora
    /// Creada Por: Carlos Marin
    /// Fecha de Creacion: 16/08/2011
    /// Descripcion: Define metodos para maestro Corporación
    /// </summary>
    public class AD_Corporacion
    {
        public AD_Corporacion()
        {
            //Se define el Contructor por defecto     
        }

        /// <summary>
        ///Metodo para Registrar Corporacion
        /// </summary>


        public EAD_Corporacion RegistrarCorporacion(string scorp_name, bool bcorp_status, string scorp_createby,
      DateTime tcorp_datecreateby, string scorp_modifyby, DateTime tcorp_datemodiby)
        {
            DAD_Corporacion oDAD_Corporacion = new DAD_Corporacion();
            EAD_Corporacion oEAD_Corporacion = oDAD_Corporacion.RegistrarCorporacion(scorp_name, bcorp_status, scorp_createby,
                    tcorp_datecreateby, scorp_modifyby, tcorp_datemodiby);
            oDAD_Corporacion = null;
            return oEAD_Corporacion;

        }

        /// <summary>
        ///Metodo para Consultar Corporacion
        /// </summary>

        public DataTable ConsultarCorporacion(int icorp_id)
        {
            DAD_Corporacion oDAD_Corporacion = new DAD_Corporacion();
            DataTable dt = oDAD_Corporacion.ConsultarCorporacion(icorp_id);
            return dt;

        }

        public DataTable ConsultarCorporacionxNombre(string scorp_name)
        {
            DAD_Corporacion oDAD_Corporacion = new DAD_Corporacion();
            DataTable dt = oDAD_Corporacion.ConsultarCorporacionxNombre(scorp_name);
            return dt;

        }

        /// <summary>
        ///Metodo para Actualizar Corporacion
        /// </summary>


        public EAD_Corporacion ActualizarCorporacion(int icorp_id, string scorp_name, bool bcorp_status, string scorp_modifyby, DateTime tcorp_datemodiby)
        {
            DAD_Corporacion oDAD_Corporacion = new DAD_Corporacion();
            EAD_Corporacion oEAD_Corporacion = oDAD_Corporacion.ActualizarCorporacion(icorp_id, scorp_name, bcorp_status, scorp_modifyby, tcorp_datemodiby);
            oDAD_Corporacion = null;
            return oEAD_Corporacion;

        }

    }
}
