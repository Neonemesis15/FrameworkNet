using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{

    /// <summary>
    /// Clase:DAD_Distribuidora
    /// Creada Por: Ing. Magaly Andrea Jiménez
    /// Fecha de Creacion: 01/04/2011
    /// Descripcion: Define los Metodos transaccionales para el maestro Distribuidora.
    /// </summary>
   
    public class DAD_Distribuidora
    {

         private Conexion oConn;
        public DAD_Distribuidora()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;

        }
        
      
       
              /// <summary>
              ///Metodo para Registrar Distribuidoras
              /// </summary>


        public EAD_Distribuidora RegistrarDEX(string snamedex, bool bstatusdex, string sCreatebydex,
            DateTime tDateBydex, string sModiBydex, DateTime tDateModiBydex)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_REGISTERDISTRIBUIDORA", snamedex, bstatusdex, sCreatebydex,
                     tDateBydex, sModiBydex, tDateModiBydex);
            EAD_Distribuidora oedex = new EAD_Distribuidora();

            oedex.Dex_Name = snamedex;
            oedex.Dex_Status = bstatusdex;
            oedex.Dex_CreateBy = sCreatebydex;
            oedex.Dex_DateBy = tDateBydex;
            oedex.Dex_ModiBy = sModiBydex;
            oedex.Dex_DateModiBy = tDateModiBydex;
            return oedex;


        }
        /// <summary>
        ///Metodo para Consultar Distribuidoras. 
        /// </summary>

       public DataTable ConsultarDEX(int iId_Dex)
       {

           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTARDISTRIBUIDORA", iId_Dex);
           EAD_Distribuidora oecDex = new EAD_Distribuidora();
        
           if (dt != null)
           {
               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i <= dt.Rows.Count - 1; i++)
                   {
                       oecDex.Id_Dex = Convert.ToInt32(dt.Rows[i]["Id_Dex"].ToString().Trim());
                       oecDex.Dex_Name = dt.Rows[i]["Dex_Name"].ToString().Trim();
                       oecDex.Dex_Status = Convert.ToBoolean(dt.Rows[i]["Dex_Status"].ToString().Trim());
                       oecDex.Dex_CreateBy = dt.Rows[i]["Dex_CreateBy"].ToString().Trim();
                       oecDex.Dex_DateBy = Convert.ToDateTime(dt.Rows[i]["Dex_DateBy"].ToString().Trim());
                       oecDex.Dex_ModiBy = dt.Rows[i]["Dex_ModiBy"].ToString().Trim();
                       oecDex.Dex_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Dex_DateModiBy"].ToString().Trim());
                   }
               }
               return dt;

           }
           else
           {

               return null;
           }
       }
           
      

       /// <summary>
       ///Metodo para Actualizar Distribuidora 
       /// </summary>


       public EAD_Distribuidora ActualizarDEX(int iId_Dex, string sDex_Name, bool bDex_Status, string sDex_ModiBy, DateTime tDex_DateModiBy)
       {
           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARDISTRIBUIDORA", iId_Dex, sDex_Name, bDex_Status, sDex_ModiBy, tDex_DateModiBy);
           EAD_Distribuidora oeadex = new EAD_Distribuidora();

           oeadex.Id_Dex = iId_Dex;
           oeadex.Dex_Name = sDex_Name;
           oeadex.Dex_Status = bDex_Status;
           oeadex.Dex_ModiBy = sDex_ModiBy;
           oeadex.Dex_DateModiBy = tDex_DateModiBy;
           return oeadex;
        }

        
    
        
        
        
        
        
        
        }
    }

