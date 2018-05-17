using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:              DOPE_Reporte_Presencia
    /// Creada Por:         Joseph Gonzales
    /// Fecha de Creación:  31/10/2011
    /// </summary>
    
    public class DOPE_Reporte_Presencia
    {
        private Conexion oConn;
        public DOPE_Reporte_Presencia()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        public EOPE_Reporte_Presencia RegistrarPresencia(int iPerson_id, string sId_Perfil, string sId_Equipo, string sId_Cliente, string sId_PtoVenta, string sId_Categoria,
                                                 string sId_Marca, string sId_OpcionPresencia, string sFec_Reg_Cel, string sLatitud, string sLongitud, string sOrigen,
                                                 string sTipo_Canal, string sComentario, string sId_Reg_Presencia)
        {


            oConn = new Conexion(2);
            string id = oConn.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_PRESENCIA", 15, iPerson_id, sId_Perfil, sId_Equipo, sId_Cliente, sId_PtoVenta, sId_Categoria,
                                          sId_Marca, sId_OpcionPresencia, sFec_Reg_Cel, sLatitud, sLongitud, sOrigen, sTipo_Canal, sComentario, sId_Reg_Presencia);

            EOPE_Reporte_Presencia oEOPE_Reporte_Presencia = new EOPE_Reporte_Presencia();

            oEOPE_Reporte_Presencia.Person_id = iPerson_id;
            oEOPE_Reporte_Presencia.Id_Perfil = sId_Perfil;
            oEOPE_Reporte_Presencia.Id_Equipo = sId_Equipo;
            oEOPE_Reporte_Presencia.Id_Cliente = sId_Cliente;
            oEOPE_Reporte_Presencia.Id_PtoVenta = sId_PtoVenta;
            oEOPE_Reporte_Presencia.Id_Categoria = sId_Categoria;
            oEOPE_Reporte_Presencia.Id_Marca = sId_Marca;
            oEOPE_Reporte_Presencia.Id_OpcionPresencia = sId_OpcionPresencia;
            oEOPE_Reporte_Presencia.Fec_Reg_Cel = sFec_Reg_Cel;
            oEOPE_Reporte_Presencia.Latitud = sLatitud;
            oEOPE_Reporte_Presencia.Longitud = sLongitud;
            oEOPE_Reporte_Presencia.Origen = sOrigen;
            oEOPE_Reporte_Presencia.Tipo_Canal = sTipo_Canal;
            oEOPE_Reporte_Presencia.Comentario = sComentario;
            oEOPE_Reporte_Presencia.ID = Convert.ToInt64(id);

            return oEOPE_Reporte_Presencia;
        }


        public EOPE_Reporte_Presencia RegistrarPresenciaDetalle(long lId_Reg_Presencia, string sId_Pop, string sValor_Pop, string sId_Producto, string sPrecio, string sStock,
                                                 string sId_Observacion, string sObservacion)
        {


            oConn = new Conexion(2);
            oConn.ejecutarDataTable("STP_JVM_INSERTAR_PRESENCIA_DETALLE", lId_Reg_Presencia, sId_Pop, sValor_Pop, sId_Producto, sPrecio, sStock,
                                          sId_Observacion, sObservacion);

            EOPE_Reporte_Presencia oEOPE_Reporte_Presencia = new EOPE_Reporte_Presencia();

            oEOPE_Reporte_Presencia.ID_REG_PRESENCIA = lId_Reg_Presencia;
            oEOPE_Reporte_Presencia.Id_Pop = sId_Pop;
            oEOPE_Reporte_Presencia.Valor_Pop = sValor_Pop;
            oEOPE_Reporte_Presencia.Id_Producto = sId_Producto;
            oEOPE_Reporte_Presencia.Precio = sPrecio;
            oEOPE_Reporte_Presencia.Stock = sStock;
            oEOPE_Reporte_Presencia.Id_Observacion = sId_Observacion;
            oEOPE_Reporte_Presencia.Observacion = sObservacion;


            return oEOPE_Reporte_Presencia;
        }


        public EOPE_Reporte_Presencia RegistrarPresencia_Pivot(string sId_Dato, string sId_Reg_Presencia, string IDPresencia)
        {

            string id = "";
            oConn = new Conexion(2);
            id = oConn.ejecutarretornodeOUTPUT("STP_JVM_INSERTAR_PRESENCIA_PIVOT", 2, sId_Dato, sId_Reg_Presencia, id);

            EOPE_Reporte_Presencia oEOPE_Reporte_Presencia = new EOPE_Reporte_Presencia();

            oEOPE_Reporte_Presencia.ID = Convert.ToInt64(id);

            return oEOPE_Reporte_Presencia;
        }


        public EOPE_Reporte_Presencia RegistrarPresenciaDetalle_Pivot(long lId, string sId_Producto, string sPrecio)
        {


            oConn = new Conexion(2);
            oConn.ejecutarDataTable("STP_JVM_INSERTAR_PRESENCIA_DETALLE_PIVOT", lId, sId_Producto, sPrecio);

            EOPE_Reporte_Presencia oEOPE_Reporte_Presencia = new EOPE_Reporte_Presencia();

            oEOPE_Reporte_Presencia.ID_REG_PRESENCIA = lId;
            oEOPE_Reporte_Presencia.Precio = sPrecio;
            oEOPE_Reporte_Presencia.Id_Producto = sId_Producto;


            return oEOPE_Reporte_Presencia;
        }
    }
}
