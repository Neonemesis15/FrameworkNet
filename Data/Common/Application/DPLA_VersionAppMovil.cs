using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class DPLA_VersionAppMovil
    {
        private Conexion oConn;

        public DPLA_VersionAppMovil()
        {
            //UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion(1);
           // oUserInterface = null;
        }

        //public List<EPLA_VersionAppMovil> listarAppMovil(string codigoCliente)
        public List<EPLA_VersionAppMovil> listarAppMovil()
        {

            List<EPLA_VersionAppMovil> listaVersiones = new List<EPLA_VersionAppMovil>();
            
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_OBTENER_APP_MOVIL");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        EPLA_VersionAppMovil version = new EPLA_VersionAppMovil();
                        version.nombre = dt.Rows[i]["Aplicacion_Movil"].ToString();
                        version.version = dt.Rows[i]["Version_App"].ToString();
                        version.ruta = dt.Rows[i]["Ruta_Serv"].ToString();

                        listaVersiones.Add(version);
                    }
                }

                return listaVersiones;
            }
            else
            {
                return null;
            }            
        }
    }
}
