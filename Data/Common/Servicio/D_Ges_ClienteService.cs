using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Servicio;
using System.Data;

namespace Lucky.Data.Common.Servicio
{
    public class D_Ges_ClienteService
    {
        private Conexion oConexion;
        public D_Ges_ClienteService()
        {
            oConexion = new Conexion(1);
        }

        public E_Usuario_Digitacion Obtener_Usuario_Digitacion(string usuario)
        {
            E_Usuario_Digitacion eusuario = new E_Usuario_Digitacion();
            DataTable dtUsuario = oConexion.ejecutarDataTable("UP_GES_USU_OBTENER_USUARIO_DIGITACION", usuario);
            if (dtUsuario.Rows.Count > 0)
            {
                System.Data.DataRow fila = dtUsuario.Rows[0];
                eusuario.codigoCliente = fila["codigoCliente"].ToString().Trim();
                eusuario.fotoCliente = fila["fotoCliente"].ToString().Trim();
                eusuario.nombreCliente = fila["nombreCliente"].ToString().Trim();
                eusuario.codigoUsuario = fila["codigoUsuario"].ToString().Trim();
                eusuario.codigoPerfil = fila["codigoPerfil"].ToString().Trim();
                eusuario.nombreUsuario = fila["nombreUsuario"].ToString().Trim();
                eusuario.nombreCompleto = fila["nombreCompleto"].ToString().Trim();
                return eusuario;
            }
            else
                return null;
        }
    }
}
