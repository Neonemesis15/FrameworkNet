using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Maestros.Cliente;
using Lucky.Entity.Common.Maestros;

namespace Lucky.Business.Common.Maestros.Cliente
{
    public class BL_Canal
    {
        DAO_Canal oDAO_Canal = new DAO_Canal();

        public List<MA_Canal> Get_CanalesByCodUsuario(string codUsuario) {
            List<MA_Canal> oListMA_Canal = new List<MA_Canal>();
            try {
                oListMA_Canal = oDAO_Canal.Get_CanalesByCodUsuario(codUsuario);
            }
            catch (Exception ex) {
                return null;
            }
            return oListMA_Canal;
        }
    }
}
