using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data.SqlClient;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_AppMovil
    {
        private Conexion oCoon;

        public D_AppMovil()
        {
            oCoon = new Conexion(4);
        }

        public void RegistrarMarcacion_Mov(E_Marcacion oE_Marcacion)
        {            
            oCoon.ejecutarDataTable("SP_APPMOVIL_REGISTRAR_BITACORA", oE_Marcacion.PersonId, oE_Marcacion.EquipoId, oE_Marcacion.ClienteId, oE_Marcacion.EstadoId ?? "0", oE_Marcacion.MotivoId ?? "0", oE_Marcacion.FechaIni, oE_Marcacion.LatitudInicio, oE_Marcacion.LongitudInicio, oE_Marcacion.OrigenInicio, oE_Marcacion.FechaFin, oE_Marcacion.LatitudFin, oE_Marcacion.LongitudFin, oE_Marcacion.OrigenFin);
        }

        public E_AppMovil_Sincronizar Sincronizar_Mov(string person_id, int cliente, string equipo)
        {
            SqlDataReader readerSinc = oCoon.ejecutarDataReader("SP_APPMOVIL_SINCRONIZAR", equipo, cliente, person_id);

            List<E_PuntoVenta> listaPuntoVenta = new List<E_PuntoVenta>();
            List<E_AppMovilCategoria> listaCategoria = new List<E_AppMovilCategoria>();
            List<E_AppMovilMarca> listaMarca = new List<E_AppMovilMarca>();        
            List<E_AppMovilProducto> listaProducto = new List<E_AppMovilProducto>();
            List<E_AppMovilUndMed> listaUnidadMedida = new List<E_AppMovilUndMed>();
            List<E_Cobro_Cab> listaCobroCab = new List<E_Cobro_Cab>();
            List<E_Cobro_detalle> listaCobroDetalle = new List<E_Cobro_detalle>();

            while (readerSinc.Read())
            {
                E_PuntoVenta ePuntoVenta = new E_PuntoVenta();
                ePuntoVenta.CodigoPDV = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Pdv")).ToString().Trim();
                ePuntoVenta.RazonSocial = readerSinc.GetValue(readerSinc.GetOrdinal("Pdv_Nombre")).ToString().Trim();
                ePuntoVenta.Direccion = readerSinc.GetValue(readerSinc.GetOrdinal("Pdv_Direccion")).ToString().Trim();
                ePuntoVenta.CodigoCadena = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Cadena")).ToString().Trim();
                ePuntoVenta.NombreCadena = readerSinc.GetValue(readerSinc.GetOrdinal("Cad_Nombre")).ToString().Trim();
                ePuntoVenta.CodigoCanal = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Canal")).ToString().Trim();
                ePuntoVenta.NombreCanal = readerSinc.GetValue(readerSinc.GetOrdinal("Can_Nombre")).ToString().Trim();
                ePuntoVenta.TipoMercado = readerSinc.GetValue(readerSinc.GetOrdinal("Can_Tipo")).ToString().Trim();
                ePuntoVenta.latitud = (readerSinc.GetValue(readerSinc.GetOrdinal("Latitud")).ToString());
                ePuntoVenta.longitud = (readerSinc.GetValue(readerSinc.GetOrdinal("Longitud")).ToString());
                //ePuntoVenta.latitud = float.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Latitud")).ToString());
                //ePuntoVenta.longitud = float.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("Longitud")).ToString());
                ePuntoVenta.Fase = readerSinc.GetValue(readerSinc.GetOrdinal("Cod_Fase")).ToString().Trim();
                listaPuntoVenta.Add(ePuntoVenta);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_AppMovilCategoria eEstado = new E_AppMovilCategoria();
                eEstado.codCategoria = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_CATEGORIA"));
                eEstado.nombreCat = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_CATEGORIA")).ToString().Trim();
                listaCategoria.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_AppMovilMarca eEstado = new E_AppMovilMarca();
                eEstado.codMarca = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_MARCA"));
                eEstado.nombreMarca = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_MARCA")).ToString().Trim();
                eEstado.codCat = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_CATEGORIA"));
                listaMarca.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_AppMovilProducto eEstado = new E_AppMovilProducto();
                eEstado.codigo = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_PRODUCTO"));
                eEstado.nombre = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_PRODUCTO")).ToString().Trim();
                eEstado.precio = readerSinc.GetDouble(readerSinc.GetOrdinal("PRECIO")); 
                eEstado.stock = readerSinc.GetInt32(readerSinc.GetOrdinal("STOCK"));
                eEstado.unidadmedida = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_UNIDAD"));
                eEstado.codcat = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_CATEGORIA"));
                eEstado.codmarca = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_MARCA"));
                eEstado.dscto = double.Parse(readerSinc.GetValue(readerSinc.GetOrdinal("DSCTO")).ToString());
                listaProducto.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_AppMovilUndMed eEstado = new E_AppMovilUndMed();
                eEstado.codUnd = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_UNIDAD"));
                eEstado.nombreUnd = readerSinc.GetValue(readerSinc.GetOrdinal("NOMBRE_UNIDAD")).ToString().Trim();
                listaUnidadMedida.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Cobro_Cab eEstado = new E_Cobro_Cab();
                eEstado.codPedido = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_PEDIDO"));
                eEstado.codCliente = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PTO_VENTA")).ToString().Trim();
                eEstado.fechaini = readerSinc.GetValue(readerSinc.GetOrdinal("FECHA_INICIO")).ToString();
                eEstado.montobase = readerSinc.GetDouble(readerSinc.GetOrdinal("MONTO_BASE"));
                eEstado.igv = readerSinc.GetDouble(readerSinc.GetOrdinal("IGV"));
                eEstado.montotoal = readerSinc.GetDouble(readerSinc.GetOrdinal("MONTO_TOTAL"));
                eEstado.tipo = readerSinc.GetInt32(readerSinc.GetOrdinal("TIPO_COMPROBANTE"));
                
                listaCobroCab.Add(eEstado);
            }

            readerSinc.NextResult();
            while (readerSinc.Read())
            {
                E_Cobro_detalle eEstado = new E_Cobro_detalle();
                eEstado.coddetalle = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_DETALLE"));
                eEstado.codPedido = readerSinc.GetInt32(readerSinc.GetOrdinal("COD_PEDIDO"));
                eEstado.codProducto = readerSinc.GetValue(readerSinc.GetOrdinal("COD_PRODUCTO")).ToString().Trim();
                eEstado.cantidad = readerSinc.GetInt32(readerSinc.GetOrdinal("CANTIDAD"));
                eEstado.dscto = readerSinc.GetDouble(readerSinc.GetOrdinal("DSCTO"));
                eEstado.monto = readerSinc.GetDouble(readerSinc.GetOrdinal("MONTO"));
                eEstado.precio = readerSinc.GetDouble(readerSinc.GetOrdinal("PRECIO"));

                listaCobroDetalle.Add(eEstado);
            }

            readerSinc.Close();

            E_AppMovil_Sincronizar eSincronizar = new E_AppMovil_Sincronizar();
            eSincronizar.listaPtoVenta = listaPuntoVenta;
            eSincronizar.listaCategoria = listaCategoria;
            eSincronizar.listaMarca= listaMarca;
            eSincronizar.listaProducto = listaProducto;
            eSincronizar.listaUnidadMedida = listaUnidadMedida;
            eSincronizar.listaCobroCab = listaCobroCab;
            eSincronizar.listaCobroDetalle = listaCobroDetalle;
            return eSincronizar;
        }

        public void RegistrarPedido_Mov(List<E_Pedido_Cab> oE_Pedido_Cab)
        {
            foreach (E_Pedido_Cab ped in oE_Pedido_Cab)
            {
                string pedido = "";
                pedido = oCoon.ejecutarretornodeOUTPUT("SP_APPMOVIL_GUARDAR_PEDIDO_CABECERA", 8,
                    ped.codCliente, ped.codigo, ped.fechaini, ped.fechafin,
                    ped.montobase, ped.igv, ped.montotoal, ped.tipo,pedido);
                foreach (E_Pedido_detalle detalle in ped.detalle)
                {
                    oCoon.ejecutarDataTable("SP_APPMOVIL_GUARDAR_PEDIDO_DETALLE",
                        pedido, detalle.codProducto, detalle.precio, detalle.dscto, detalle.cantidad, detalle.monto);
                }
            }

            
        }

        public void Cobrar_Mov(int oE_Pedido_Cab)
        {
                oCoon.ejecutarDataTable("SP_APPMOVIL_COBRAR", oE_Pedido_Cab);
            }


        }


    
}
