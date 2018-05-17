using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;


namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Distribuidora
    /// Creada Por: Ing. Magaly jiménez
    /// Fecha de Creacion: 01/04/2011
    /// Descripcion: Define metodos para maestro Distribuidoras
    /// </summary>
    /// 
    public class AD_Distribuidora
    {
        public AD_Distribuidora()
        {         
            //Se define el Contructor por defecto     
        }

        /// <summary>
        ///Metodo para Registrar distribuidora
        /// </summary>


        public EAD_Distribuidora RegistrarDex(string snamedex, bool bstatusdex, string sCreatebydex,
            DateTime tDateBydex, string sModiBydex, DateTime tDateModiBydex)
        {
            DAD_Distribuidora oddex = new DAD_Distribuidora();
            EAD_Distribuidora oedex = oddex.RegistrarDEX(snamedex, bstatusdex, sCreatebydex,
                    tDateBydex, sModiBydex, tDateModiBydex);
            oddex = null;
            return oedex;




        }


        /// <summary>
        ///Metodo para Consultar distribuidoras
        /// </summary>

        public DataTable Consultardex(int iId_Dex)
        {
            DAD_Distribuidora odcdex = new DAD_Distribuidora();
            DataTable dt = odcdex.ConsultarDEX(iId_Dex);
            return dt;

        }


        /// <summary>
        ///Metodo para Actualizar Distribuidoras
        /// </summary>


        public EAD_Distribuidora ActualizarDex(int iId_Dex, string sDex_Name, bool bDex_Status, string sDex_ModiBy, DateTime tDex_DateModiBy)
        {
            DAD_Distribuidora odadex = new DAD_Distribuidora();
            EAD_Distribuidora oeadex = odadex.ActualizarDEX(iId_Dex, sDex_Name, bDex_Status, sDex_ModiBy, tDex_DateModiBy);
            odadex = null;
            return oeadex;




        }


    }
}
