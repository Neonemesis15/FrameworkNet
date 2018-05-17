using System;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Security;
using Lucky.Entity.Common.Application.Security;


namespace Lucky.Data.Common.Application
{
      /// <summary>
      /// Clase: DCadenas
      /// Creada Por: Ing. Carlos Alberto Hernández RIncón
      /// Fecha de Creación: 12/06/2009
      /// Descripcion: Define los metodos transaccionales para la Clase Cadenas
      /// Modificaciones: 25-06-09 se cambia idCadena por int , ahora es un identity. Ing. Mauricio Ortiz
      /// Requerimiento No:<>
      /// </summary>
  
    
    public class DCadenas
    {
        private Conexion oConn;
        public DCadenas() {

            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        
        }
        /// <summary>
        /// Metodo para Registrar Cadenas 
        /// Requerimiento No:<>
        /// </summary>

        public ECadenas RegisterCadena(string snameCadena, bool bstatuscadena, string sCrateByCadena,
            DateTime tDateByCadena, string sModiByCadena, DateTime tDateModiByCadena) {

                DataTable dt = oConn.ejecutarDataTable("UP_WEB_SIGE_REGISTERCADENA", snameCadena, bstatuscadena, sCrateByCadena,
                    tDateByCadena, sModiByCadena, tDateModiByCadena);

                ECadenas oecadenas = new ECadenas();
                //oecadenas.idmarketChain = sidCadena;
                oecadenas.MarketChainname = snameCadena;
                oecadenas.MarketChainStatus = bstatuscadena;
                oecadenas.MarketChainCreateBy = sCrateByCadena;
                oecadenas.MarketChainDateBy = tDateByCadena;
                oecadenas.MarketChainModiBy = sModiByCadena;
                oecadenas.MarketChainDateModiBy = tDateModiByCadena;
                return oecadenas;

                
             }
        /// <summary>
        /// Metodo para Consultar  Cadenas 
        /// Requerimiento No:<>
        /// </summary>

           public DataTable ConsultarCadenas(string snameCadena) {

            DataTable dt = oConn.ejecutarDataTable("UP_WESIGE_SEARCH_CADENAS", snameCadena);
            ECadenas oescadena = new ECadenas();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oescadena.idmarketChain = Convert.ToInt32(dt.Rows[i]["id_marketChain"].ToString().Trim());
                        oescadena.MarketChainname = dt.Rows[i]["MarketChain_name"].ToString().Trim();
                        oescadena.MarketChainStatus = Convert.ToBoolean(dt.Rows[i]["MarketChain_Status"].ToString().Trim());
                        oescadena.MarketChainCreateBy = dt.Rows[i]["MarketChain_CreateBy"].ToString().Trim();
                        oescadena.MarketChainDateBy = Convert.ToDateTime(dt.Rows[i]["MarketChain_DateBy"].ToString().Trim());
                        oescadena.MarketChainModiBy = dt.Rows[i]["MarketChain_ModiBy"].ToString().Trim();
                        oescadena.MarketChainDateModiBy = Convert.ToDateTime(dt.Rows[i]["MarketChain_DateModiBy"].ToString().Trim());
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
           /// Metodo para Actualizar Cadenas 
           /// Requerimiento No:<>
           /// </summary>

           public ECadenas ActualizarCadena(int iidCadena, string snameCadena, bool bstatuscadena,string sModiByCadena, DateTime tDateModiByCadena)
           {

               DataTable dt = oConn.ejecutarDataTable("UP_WEB_SIGE_ACTUALIZACADENA", iidCadena, snameCadena, bstatuscadena, sModiByCadena, tDateModiByCadena);

               ECadenas oeacadenas = new ECadenas();
               //oeacadenas.idmarketChain = iidCadena;
               oeacadenas.MarketChainname = snameCadena;
               oeacadenas.MarketChainStatus = bstatuscadena;
               oeacadenas.MarketChainModiBy = sModiByCadena;
               oeacadenas.MarketChainDateModiBy = tDateModiByCadena;
               return oeacadenas;


           }
    }
}
