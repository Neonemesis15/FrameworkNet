using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Lucky.Entity.Common.Servicio;
using Lucky.Data.Common.Servicio;

namespace Lucky.Business.Common.Servicio
{
    public class BL_Ges_ClienteService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Ges_ClienteService));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Ges_ClienteService oD_Ges_ClienteService = new D_Ges_ClienteService();

        public E_Usuario_Digitacion Obtener_Usuario_Digitacion(string usuario)
        {
            E_Usuario_Digitacion eUsuario = null;
            try
            {
                eUsuario = oD_Ges_ClienteService.Obtener_Usuario_Digitacion(usuario);
                if (eUsuario == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                log.Error("[BL_Ges_ClienteService][Obtener_Usuario_Digitacion_Failed] : ", ex);
            }
            return eUsuario;
        }
    }
}
