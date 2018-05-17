using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using System.Data.SqlClient;
using System.Data;

namespace Lucky.Data.Common.Application
{
    public class D_TipoProfiles
    {
        private Conexion oConn;
        public D_TipoProfiles() { }
        //Descripcion: Registrar TipoPerfil. 04/09/2012 PSA
        public string registrar_TipoPerfil(E_TipoProfiles oE_TipoProfiles) {
            try {
                oConn = new Conexion(1);
                //Cantidad de Registros Insertados - 04/09/2012 - PSA
                DataTable dt = oConn.ejecutarDataTable("up_Xpl_Ges_TPer_Registrar_TipoPerfil"
                    ,oE_TipoProfiles.TipPerfil_Descripcion
                    ,oE_TipoProfiles.CreateBy);
                string total = dt.Rows[0][0].ToString();
                return total;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        //Descripcion: Actualizar TipoPerfil por IdPerfil. 04/09/2012 PSA
        public string actualizar_TipoPerfil_Por_IdPerfil(E_TipoProfiles oE_TipoProfiles, string IdPerfil) {
            try { 
                return "Por Implementar";
            }
            catch (Exception ex) { 
                throw ex;
            }
        }
        //Descripcion: Eliminar TipoPerfil por IdPerfil. 04/09/2012 PSA
        public string eliminar_TipoPerfil_Por_IdPerfil(string IdPerfil) {
            try {
                return "Por Implementar";
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public List<E_TipoProfiles> consultar_TipoPerfil_Por_PerfDescripcion(string perf_descripcion) {
            try {
                oConn = new Conexion(1);
                List<E_TipoProfiles> oListE_TipoProfiles = new List<E_TipoProfiles>();
                DataTable dt = oConn.ejecutarDataTable("up_Xpl_Ges_TPer_Consultar", perf_descripcion);
                if (dt != null) {
                    if (dt.Rows.Count > 0) {
                        for (int i = 0; i <= dt.Rows.Count - 1; i++) {
                            E_TipoProfiles oE_TipoProfiles = new E_TipoProfiles();
                            oE_TipoProfiles.TipPerfil_id = dt.Rows[i]["TipPerfil_id"].ToString();
                            oE_TipoProfiles.TipPerfil_Descripcion = dt.Rows[i]["TipPerfil_Descripcion"].ToString();
                            oE_TipoProfiles.Status = Convert.ToBoolean(dt.Rows[i]["Status"]);
                            oE_TipoProfiles.CreateBy = dt.Rows[i]["CreateBy"].ToString();
                            oE_TipoProfiles.DateBy = dt.Rows[i]["DateBy"].ToString();
                            oE_TipoProfiles.ModiBy = dt.Rows[i]["ModiBy"].ToString();
                            oE_TipoProfiles.DateModiBy = dt.Rows[i]["DateModiBy"].ToString();
                            oListE_TipoProfiles.Add(oE_TipoProfiles);
                        }
                    }
                }
                return oListE_TipoProfiles;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
