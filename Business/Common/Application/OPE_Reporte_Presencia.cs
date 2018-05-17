using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class OPE_Reporte_Presencia
    {
        public OPE_Reporte_Presencia() { }

        public EOPE_Reporte_Presencia RegistrarReportePresencia(int iPerson_id, string sId_Perfil, string sId_Equipo, string sId_Cliente, string sId_PtoVenta, string sId_Categoria,
                                                 string sId_Marca, string sId_OpcionPresencia, string sFec_Reg_Cel, string sLatitud, string sLongitud, string sOrigen,
                                                 string sTipo_Canal, string sComentario, string sId_Reg_Presencia)
        {
            DOPE_Reporte_Presencia oDOPE_Reporte_Presencia = new DOPE_Reporte_Presencia();
            EOPE_Reporte_Presencia oEOPE_Rreporte_Presencia = oDOPE_Reporte_Presencia.RegistrarPresencia(iPerson_id, sId_Perfil, sId_Equipo, sId_Cliente, sId_PtoVenta, sId_Categoria, sId_Marca, sId_OpcionPresencia, sFec_Reg_Cel, sLatitud, sLongitud, sOrigen,
                                                 sTipo_Canal, sComentario, sId_Reg_Presencia);
            oDOPE_Reporte_Presencia = null;

            return oEOPE_Rreporte_Presencia;
        }

        public EOPE_Reporte_Presencia RegistrarReportePresenciaDetalle(long lId_Reg_Presencia, string sId_Pop, string sValor_Pop, string sId_Producto, string sPrecio, string sStock,
                                                 string sId_Observacion, string sObservacion)
        {
            DOPE_Reporte_Presencia oDOPE_Reporte_Presencia = new DOPE_Reporte_Presencia();
            EOPE_Reporte_Presencia oEOPE_Rreporte_Presencia = oDOPE_Reporte_Presencia.RegistrarPresenciaDetalle(lId_Reg_Presencia, sId_Pop, sValor_Pop, sId_Producto, sPrecio, sStock,
                                                 sId_Observacion, sObservacion);
            oDOPE_Reporte_Presencia = null;

            return oEOPE_Rreporte_Presencia;
        }

        public EOPE_Reporte_Presencia RegistrarReportePresencia_Pivot(string sId_Dato, string sId_Reg_Presencia, string IDPresencia)
        {
            DOPE_Reporte_Presencia oDOPE_Reporte_Presencia = new DOPE_Reporte_Presencia();
            EOPE_Reporte_Presencia oEOPE_Rreporte_Presencia = oDOPE_Reporte_Presencia.RegistrarPresencia_Pivot(sId_Dato, sId_Reg_Presencia, IDPresencia);
            oDOPE_Reporte_Presencia = null;

            return oEOPE_Rreporte_Presencia;
        }

        public EOPE_Reporte_Presencia RegistrarReportePresenciaDetalle_Pivot(long lId_Reg_Presencia, string sId_Producto, string sValor_Pop)
        {
            DOPE_Reporte_Presencia oDOPE_Reporte_Presencia = new DOPE_Reporte_Presencia();
            EOPE_Reporte_Presencia oEOPE_Rreporte_Presencia = oDOPE_Reporte_Presencia.RegistrarPresenciaDetalle_Pivot(lId_Reg_Presencia, sId_Producto, sValor_Pop );
            oDOPE_Reporte_Presencia = null;

            return oEOPE_Rreporte_Presencia;
        }

    }
}
