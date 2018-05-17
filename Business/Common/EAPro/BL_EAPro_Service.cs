using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Entity.Common.EAPro;
using Lucky.Data.Common.EAPro;

namespace Lucky.Business.Common.EAPro
{
    public class BL_EAPro_Service
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_EAPro_Service));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_EAPro_Service oD_EAPro_Service = new D_EAPro_Service();

        public EAPRO_Usuario Validar_usuario(string usuario, string clave)
        {
            EAPRO_Usuario eUsuario = null;
            try
            {
                eUsuario = oD_EAPro_Service.Validar_usuario(usuario, clave);
                if (eUsuario == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Validar_usuario_Failed] : ", ex);
            }
            return eUsuario;
        }

        public List<E_Sala> Obtener_salas()
        {
            List<E_Sala> oListSala = new List<E_Sala>();
            try
            {
                oListSala = oD_EAPro_Service.Obtener_salas();
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Obtener_salas_Failed] : ", ex);
            }
            return oListSala;
        }

        public List<E_CentroCosto> Obtener_centro_costo()
        {
            List<E_CentroCosto> oListCentroCosto = new List<E_CentroCosto>();
            try
            {
                oListCentroCosto = oD_EAPro_Service.Obtener_centro_costo();
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Obtener_centro_costo_Failed] : ", ex);
            }
            return oListCentroCosto;
        }

        public List<EAPRO_Usuario> Obtener_usuarios()
        {
            List<EAPRO_Usuario> oListUSuarios = new List<EAPRO_Usuario>();
            try
            {
                oListUSuarios = oD_EAPro_Service.Obtener_usuarios();
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Obtener_usuarios_Failed] : ", ex);
            }
            return oListUSuarios;
        }

        public List<E_SalasSeparadas> Obtener_separaciones(string codigoSala, string codigoUsuario, string codigoEncargado,
                    string codigoCentroCosto, string fechaInicio, string fechaFin)
        {
            List<E_SalasSeparadas> oListSalasSeparadas = new List<E_SalasSeparadas>();
            try
            {
                oListSalasSeparadas = oD_EAPro_Service.Obtener_separaciones(codigoSala, codigoUsuario, codigoEncargado, 
                    codigoCentroCosto, fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Obtener_separaciones_Failed] : ", ex);
            }
            return oListSalasSeparadas;
        }

        public void Registrar_separacion(string codigoSala, string codigoUsuario, string codigoEncargado,
            string codigoCargo, string codigoCentroCosto, string descripcion, string adicionales, string cantidad,
            string fecha, string horaInicio, string horaFin)
        {
            try
            {
                oD_EAPro_Service.Registrar_separacion(codigoSala, codigoUsuario, codigoEncargado, codigoCargo,
                    codigoCentroCosto, descripcion, adicionales, cantidad, fecha, horaInicio, horaFin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Registrar_separacion_Failed] : ", ex);
            }
        }

        public void Actualizar_separacion(int codigoRegistro, string codigoSala, string codigoUsuario, string codigoEncargado,
            string codigoCargo, string codigoCentroCosto, string descripcion, string adicionales, string cantidad,
            string fecha, string horaInicio, string horaFin)
        {
            try
            {
                oD_EAPro_Service.Actualizar_separacion(codigoRegistro, codigoSala, codigoUsuario, codigoEncargado, codigoCargo,
                    codigoCentroCosto, descripcion, adicionales, cantidad, fecha, horaInicio, horaFin);
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Actualizar_separacion_Failed] : ", ex);
            }
        }

        public void Eliminar_separacion(int codigoRegistro)
        {
            try
            {
                oD_EAPro_Service.Eliminar_separacion(codigoRegistro);
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service]Eliminar_separacion_Failed] : ", ex);
            }
        }

        public void Actualizar_separacion_Fecha(int codigoRegistro, string fecha)
        {
            try
            {
                oD_EAPro_Service.Actualizar_separacion_Fecha(codigoRegistro, fecha);
            }
            catch (Exception ex)
            {
                log.Error("[BL_EAPro_Service][Actualizar_separacion_Fecha_Failed] : ", ex);
            }
        }
    }
}
