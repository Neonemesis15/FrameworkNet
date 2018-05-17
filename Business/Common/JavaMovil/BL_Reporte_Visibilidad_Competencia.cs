using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Data.Common.JavaMovil;
using Lucky.Business.Common.Exceptions;
using log4net;


namespace Lucky.Business.Common.JavaMovil
{
    public class BL_Reporte_Visibilidad_Competencia
    {
        //Se define el constructor por defecto
        public BL_Reporte_Visibilidad_Competencia() { }
        private static readonly ILog log = LogManager.GetLogger(typeof(BL_Reporte_Visibilidad_Competencia));
        private static readonly bool isDebugEnabled = log.IsDebugEnabled;
        private static readonly D_Reporte_Visibilidad_Competencia oD_Reporte_VisiCompe = new D_Reporte_Visibilidad_Competencia();


        public void Registrar_VisibiCompe_General_Lista(List<E_Reporte_Visibilidad_Competencia> oList_Reporte_oD_Reporte_VisiCompe)
        {
            D_Reporte_Visibilidad_Competencia oD_Reporte_VisiCompe = new D_Reporte_Visibilidad_Competencia();
            try
            {
                oD_Reporte_VisiCompe.Registrar_Visibilidad_Competencia(oList_Reporte_oD_Reporte_VisiCompe);
                
            }
            catch (Exception ex)
            {
                log.Error("[BL_Reporte_Visibilidad_Competencia] [RegistrarVisiCOmpeFailed] :", ex);
            }
        }


    }
}
