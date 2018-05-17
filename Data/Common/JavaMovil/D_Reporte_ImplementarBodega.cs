using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;
using System.Configuration;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_ImplementarBodega
    {

        /// <summary>
        /// Metodo para Registrar  Implementar Bodega (Colgate Bodega)
        /// App Movil LuckyBodega
        /// pSalas 27/03/2012
        /// </summary>
          private Conexion oCoon;
          public D_Reporte_ImplementarBodega()
        {
            UserInterface oUserInterface = new UserInterface();
            oCoon = new Conexion(2);
            oUserInterface = null;
        }

        public string RegistrarImplementarBodega(E_Reporte_ImplementarBodega oE_Reporte_Implementar) {
            String error = string.Empty;
            try
            {
                oCoon.ejecutarDataTable("STP_JVM_INSERTAR_IMPLEMENTAR_BODEGA", oE_Reporte_Implementar.Person_id ?? "", 
                    oE_Reporte_Implementar.CodCliente ?? "", oE_Reporte_Implementar.Nombre ?? "", oE_Reporte_Implementar.RazonSocial ?? "", 
                    oE_Reporte_Implementar.Direccion ?? "",  oE_Reporte_Implementar.Distrito ?? "", oE_Reporte_Implementar.Referencia ?? "",
                    oE_Reporte_Implementar.Ruc ?? "", oE_Reporte_Implementar.NombreDistribuidora ?? "",
                    oE_Reporte_Implementar.Fec_Reg ?? "",  oE_Reporte_Implementar.Origen ?? "",  oE_Reporte_Implementar.Latitud ?? "", 
                    oE_Reporte_Implementar.Longitud ?? "" );
                error = "";
            }
            catch (Exception ex) {
                error = ex.Message;
            }
            return error;
        }


    }
}