using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.EAPro;
using System.Data;

namespace Lucky.Data.Common.EAPro
{
    public class D_EAPro_Service
    {
        private Conexion oConexion;
        public D_EAPro_Service()
        {
            oConexion = new Conexion(5);
        }

        public EAPRO_Usuario Validar_usuario(string usuario, string clave)
        {
            EAPRO_Usuario eusuario = new EAPRO_Usuario();
            DataTable dtUsuario = oConexion.ejecutarDataTable("UP_EAPRO_VALIDAR_USUARIO", usuario, clave);
            if (dtUsuario.Rows.Count > 0)
            {
                System.Data.DataRow fila = dtUsuario.Rows[0];
                eusuario.codigo = fila["codigo"].ToString().Trim();
                eusuario.nombre = fila["nombre"].ToString().Trim();
                eusuario.cargo = fila["cargo"].ToString().Trim();
                eusuario.codigoCargo = fila["codigoCargo"].ToString().Trim();
                eusuario.perfil = fila["perfil"].ToString().Trim();
                eusuario.email = fila["email"].ToString().Trim();
                return eusuario;
            }
            else
                return null;
        }

        public List<E_Sala> Obtener_salas()
        {
            List<E_Sala> oListSala = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_EAPRO_OBTENER_SALAS");

                if (dt.Rows.Count > 0)
                {
                    oListSala = new List<E_Sala>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_Sala oE_Sala = new E_Sala();

                        oE_Sala.codigo = dt.Rows[i]["codigo"].ToString();
                        oE_Sala.descripcion = dt.Rows[i]["descripcion"].ToString();
                        oE_Sala.capacidad = int.Parse(dt.Rows[i]["capacidad"].ToString());
                        oE_Sala.area = int.Parse(dt.Rows[i]["area"].ToString());
                        oE_Sala.largo = double.Parse(dt.Rows[i]["largo"].ToString());
                        oE_Sala.ancho = double.Parse(dt.Rows[i]["ancho"].ToString());
                        oE_Sala.alto = double.Parse(dt.Rows[i]["alto"].ToString());
                        oE_Sala.piso = int.Parse(dt.Rows[i]["piso"].ToString());

                        oListSala.Add(oE_Sala);
                    }
                }

                return oListSala;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_CentroCosto> Obtener_centro_costo()
        {
            List<E_CentroCosto> oListCentroCosto = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_EAPRO_OBTENER_CENTROCOSTO");

                if (dt.Rows.Count > 0)
                {
                    oListCentroCosto = new List<E_CentroCosto>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_CentroCosto oE_CentroCosto = new E_CentroCosto();

                        oE_CentroCosto.codigo = dt.Rows[i]["codigo"].ToString();
                        oE_CentroCosto.descripcion = dt.Rows[i]["descripcion"].ToString();
                        oE_CentroCosto.empresa = dt.Rows[i]["empresa"].ToString();

                        oListCentroCosto.Add(oE_CentroCosto);
                    }
                }

                return oListCentroCosto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EAPRO_Usuario> Obtener_usuarios()
        {
            List<EAPRO_Usuario> oListUsuario = null;

            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_EAPRO_OBTENER_USUARIOS");

                if (dt.Rows.Count > 0)
                {
                    oListUsuario = new List<EAPRO_Usuario>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        EAPRO_Usuario oEAPRO_Usuario = new EAPRO_Usuario();
                        
                        oEAPRO_Usuario.codigo = dt.Rows[i]["codigo"].ToString().Trim();
                        oEAPRO_Usuario.nombre = dt.Rows[i]["nombre"].ToString().Trim();
                        oEAPRO_Usuario.codigoCargo = dt.Rows[i]["codigoCargo"].ToString().Trim();
                        oEAPRO_Usuario.cargo = dt.Rows[i]["cargo"].ToString().Trim();
                        oEAPRO_Usuario.perfil = dt.Rows[i]["perfil"].ToString().Trim();
                        oEAPRO_Usuario.email = dt.Rows[i]["email"].ToString().Trim();

                        oListUsuario.Add(oEAPRO_Usuario);
                    }
                }

                return oListUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_SalasSeparadas> Obtener_separaciones(string codigoSala, string codigoUsuario, string codigoEncargado,
                    string codigoCentroCosto, string fechaInicio, string fechaFin)
        {
            List<E_SalasSeparadas> oListSalasSeparadas = null;
            try
            {
                DataTable dt = oConexion.ejecutarDataTable("UP_EAPRO_OBTENER_SALAS_SEPARADAS", codigoSala, codigoUsuario, codigoEncargado,
                    codigoCentroCosto, fechaInicio, fechaFin);
                oListSalasSeparadas = new List<E_SalasSeparadas>();
                if (dt.Rows.Count > 0)
                {                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        E_SalasSeparadas oE_Salas = new E_SalasSeparadas();

                        oE_Salas.codigo = dt.Rows[i]["codigo"].ToString().Trim();
                        oE_Salas.codigoSala = dt.Rows[i]["codigoSala"].ToString().Trim();
                        oE_Salas.nombreSala = dt.Rows[i]["nombreSala"].ToString().Trim();
                        oE_Salas.codigoUsuario = dt.Rows[i]["codigoUsuario"].ToString().Trim();
                        oE_Salas.nombreUsuario = dt.Rows[i]["nombreUsuario"].ToString().Trim();
                        oE_Salas.codigoEncargado = dt.Rows[i]["codigoEncargado"].ToString().Trim();
                        oE_Salas.nombreEncargado = dt.Rows[i]["nombreEncargado"].ToString().Trim();
                        oE_Salas.codigoCentroCosto = dt.Rows[i]["codigoCentroCosto"].ToString().Trim();
                        oE_Salas.nombreCentroCosto = dt.Rows[i]["nombreCentroCosto"].ToString().Trim();
                        oE_Salas.descripcion = dt.Rows[i]["descripcion"].ToString().Trim();
                        oE_Salas.adicionales = dt.Rows[i]["adicionales"].ToString().Trim();
                        oE_Salas.cantidad = dt.Rows[i]["cantidad"].ToString().Trim();
                        oE_Salas.fecha = dt.Rows[i]["fecha"].ToString().Trim();
                        oE_Salas.horaInicio = dt.Rows[i]["horaInicio"].ToString().Trim();
                        oE_Salas.horaFin = dt.Rows[i]["horaFin"].ToString().Trim();
                        oE_Salas.estado = dt.Rows[i]["estado"].ToString().Trim();
                        oE_Salas.creadoPor = dt.Rows[i]["creadoPor"].ToString().Trim();
                        oE_Salas.fechaCreacion = dt.Rows[i]["fechaCreacion"].ToString().Trim();
                        oE_Salas.modificadoPor = dt.Rows[i]["modificadoPor"].ToString().Trim();
                        oE_Salas.fechaModificacion = dt.Rows[i]["fechaModificacion"].ToString().Trim();

                        oListSalasSeparadas.Add(oE_Salas);
                    }
                }
                return oListSalasSeparadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Registrar_separacion(string codigoSala, string codigoUsuario, string codigoEncargado,
            string codigoCargo, string codigoCentroCosto, string descripcion, string adicionales, string cantidad,
            string fecha, string horaInicio, string horaFin)
        {
            try
            {
                oConexion.ejecutarSinRetorno("UP_EAPRO_REGISTRAR_SEPARACION_SALA", codigoSala, codigoUsuario,
                    codigoEncargado, codigoCargo, codigoCentroCosto, descripcion, adicionales, cantidad, fecha,
                    horaInicio, horaFin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar_separacion(int codigoRegistro, string codigoSala, string codigoUsuario, string codigoEncargado,
            string codigoCargo, string codigoCentroCosto, string descripcion, string adicionales, string cantidad,
            string fecha, string horaInicio, string horaFin)
        {
            try
            {
                oConexion.ejecutarSinRetorno("UP_EAPRO_ACTUALIZAR_SEPARACION_SALA", codigoRegistro, codigoSala, codigoUsuario,
                    codigoEncargado, codigoCargo, codigoCentroCosto, descripcion, adicionales, cantidad, fecha,
                    horaInicio, horaFin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar_separacion(int codigoRegistro)
        {
            try
            {
                oConexion.ejecutarSinRetorno("UP_EAPRO_ELIMINAR_SEPARACION_SALA", codigoRegistro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar_separacion_Fecha(int codigoRegistro, string fecha)
        {
            try
            {
                oConexion.ejecutarSinRetorno("UP_EAPRO_ACTUALIZAR_SEPARACION_SALA_POR_FECHA", codigoRegistro, fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}