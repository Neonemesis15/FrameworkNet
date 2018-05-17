using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    public class D_PointOfSale_GIS
    {
        private Conexion oConn;

        public D_PointOfSale_GIS()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;

        }

        public List<EAD_PointOfSale_GIS> listarPuntosdeVenta() {
            
            List<EAD_PointOfSale_GIS> puntosdeventa = new List<EAD_PointOfSale_GIS>();
            EAD_PointOfSale_GIS puntodeventa = new EAD_PointOfSale_GIS();

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_LISTA_PUNTOS_GEOGRAFICOS");

            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        puntodeventa.Posgis_id = Convert.ToInt32(dt.Rows[i]["posgis_id"]);
                        puntodeventa.Posgis_nombre = dt.Rows[i]["posgis_nombre"].ToString();
                        puntodeventa.Posgis_latitud = dt.Rows[i]["posgis_latitud"].ToString();
                        puntodeventa.Posgis_longitud = dt.Rows[i]["posgis_longitud"].ToString();
                        puntodeventa.Posgis_iconmarker = dt.Rows[i]["posgis_iconmarker"].ToString();
                        puntodeventa.Posgis_informacion = dt.Rows[i]["posgis_informacion"].ToString();
                        puntodeventa.Posgis_status = Convert.ToBoolean(dt.Rows[i]["posgis_status"]);
                        puntodeventa.Posgis_createby = dt.Rows[i]["posgis_createby"].ToString();
                        puntodeventa.Posgis_dateby = Convert.ToDateTime(dt.Rows[i]["posgis_dateby"]);
                        puntodeventa.Posgis_modiby = dt.Rows[i]["posgis_modiby"].ToString();
                        puntodeventa.Posgis_datemodiby = Convert.ToDateTime(dt.Rows[i]["posgis_datemodiby"]);

                        puntosdeventa.Add(puntodeventa);
                    }
                }
            }
            
            return puntosdeventa;
        }
    }
}
