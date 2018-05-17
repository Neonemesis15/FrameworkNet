using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class BLPLA_VersionAppMovil
    {
        DPLA_VersionAppMovil dPLA_VersionAppMovil = new DPLA_VersionAppMovil();

        //public List<EPLA_VersionAppMovil> listarAppMovil(string codigoCliente)
        public List<EPLA_VersionAppMovil> listarAppMovil()
        {
            return dPLA_VersionAppMovil.listarAppMovil();
        }
    }
}
