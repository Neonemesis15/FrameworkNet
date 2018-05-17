using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Producto
    {
        private Conexion oCoon;

        public D_Producto()
        {
            oCoon = new Conexion(3);
        }

        public E_PuntoVenta obtenerPtoVenta(string codigoPtoVenta)
        {
            DataTable dt = oCoon.ejecutarDataTable("SP_GES_CAM_OBTENER_PDV_X_CODIGO", codigoPtoVenta);
            E_PuntoVenta ePuntoVenta = new E_PuntoVenta();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ePuntoVenta.CodigoPDV = dt.Rows[0]["Cod_Pdv"].ToString().Trim();
                    ePuntoVenta.RazonSocial = dt.Rows[0]["Pdv_Nombre"].ToString().Trim();
                    ePuntoVenta.Direccion = dt.Rows[0]["Pdv_Direccion"].ToString().Trim();
                    ePuntoVenta.CodigoCadena = dt.Rows[0]["Cod_Cadena"].ToString().Trim();
                    ePuntoVenta.NombreCadena = dt.Rows[0]["Cad_Nombre"].ToString().Trim();
                    ePuntoVenta.CodigoCanal = dt.Rows[0]["Cod_Canal"].ToString().Trim();
                    ePuntoVenta.NombreCanal = dt.Rows[0]["Can_Nombre"].ToString().Trim();
                    ePuntoVenta.TipoMercado = dt.Rows[0]["Can_Tipo"].ToString().Trim();
                    ePuntoVenta.latitud = (dt.Rows[0]["Latitud"].ToString().Trim());
                    ePuntoVenta.longitud = (dt.Rows[0]["Longitud"].ToString().Trim());
                    //ePuntoVenta.latitud = float.Parse(dt.Rows[0]["Latitud"].ToString().Trim());
                    //ePuntoVenta.longitud = float.Parse(dt.Rows[0]["Longitud"].ToString().Trim());
                    ePuntoVenta.Fase = dt.Rows[0]["Cod_Fase"].ToString().Trim(); 
                }
                return ePuntoVenta;
            }
            else
            {
                return null;
            }
        }
    }
}
