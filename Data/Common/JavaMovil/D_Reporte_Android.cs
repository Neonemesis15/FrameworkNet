using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using System.Data;
using System.Data.SqlClient;

namespace Lucky.Data.Common.JavaMovil
{
    public class D_Reporte_Android
    {
        private Conexion oConn;
        public D_Reporte_Android()
        {
            UserInterface oUserInterface = new UserInterface();
            oUserInterface = null;
        }



        #region borrar
        //Borrar este metodo luego 16/03/2012 pSalas
        public void Registrar_PtosVentas_Android_Lista(List<EPuntoVenta> oListPtoVenta)
        {
            foreach (EPuntoVenta PDV in oListPtoVenta)
                Registrar_PtosVentas_Android(PDV);
        }

        //Borrar este metodo luego 16/03/2012 pSalas
        public void Registrar_PtosVentas_Android(EPuntoVenta oPDVA)
        {
            oConn = new Conexion(2);
            
            oConn.ejecutarDataTable("SP_ADM_REGISTRAR_PDV_BORRAR", oPDVA.Codigo, oPDVA.RazonSocial, oPDVA.Direccion,
                oPDVA.NombreCadena, oPDVA.NombreCanal, oPDVA.TipoMercado);

        }
        #endregion 

    }
}
