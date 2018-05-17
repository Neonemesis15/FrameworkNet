using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class BL_TipoPerfil
    {
        public BL_TipoPerfil() { 
        }
        private static readonly D_TipoProfiles oD_TipoProfiles = new D_TipoProfiles();
        //Fecha:04/09/2012. PSA. RegistrarTipoPerfil
        public string registrar_TipoPerfil(E_TipoProfiles oE_TipoProfiles) {
            try {
                string filas = oD_TipoProfiles.registrar_TipoPerfil(oE_TipoProfiles);
                return filas;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        //Fecha: 04/09/2012. PSA. Consultar TipoPerfil
        public List<E_TipoProfiles> consultar_TipoPerfil_Por_PerfDescripcion(string perf_descripcion)
        {
            try {
                List<E_TipoProfiles> oListE_TipoProfiles = new List<E_TipoProfiles>();
                oListE_TipoProfiles = oD_TipoProfiles.consultar_TipoPerfil_Por_PerfDescripcion(perf_descripcion);
                return oListE_TipoProfiles;
            }
            catch(Exception ex) {
                throw ex;
            }
        }

    }
}
