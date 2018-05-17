using System;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Security;
using Lucky.Entity.Common.Application.Security;

namespace Lucky.Data.Common.Application
{
    public class DDistrito
    {
        /// <summary>
        /// Clase: DCadenas
        /// Creada Por: Ing. Carlos Alberto Hernández RIncón
        /// Fecha de Creación: 12/06/2009
        /// Descripcion: Define los metodos transaccionales para la Clase Distrito
        /// Requerimiento No:<>
        /// </summary>

        private Conexion oConn;
        public DDistrito()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
     
         }
        /// <summary>
        /// Metodo para Registrar Distritos
        /// </summary>
       
       public EDistrito RegistrarDistrito(string scoddistrito, string scodcountry, string scoddpto, string scodcity,
            bool bDistrictStatus, string sNameLocal, string sLocalCreateBy, DateTime tLocalDateBy, string sLocalModiby,
            DateTime tLocalDateModiBy) {
                DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_REGISTRARDISTRITO", scoddistrito, scodcountry, scoddpto, scodcity, bDistrictStatus,sNameLocal, sLocalCreateBy,
                    tLocalDateBy, sLocalModiby, tLocalDateModiBy);
                EDistrito oedistrito = new EDistrito();
                oedistrito.codDistrict= scoddistrito;
                oedistrito.codcountry= scodcountry;
                oedistrito.coddpto= scoddpto;
                oedistrito.codCity= scodcity;
                oedistrito.DistrictStatus=bDistrictStatus;
                oedistrito.NameLocal = sNameLocal;
                oedistrito.LocalCreateBy=sLocalCreateBy;
                oedistrito.LocalDateBy=tLocalDateBy;
                oedistrito.LocalModiby= sLocalModiby;
                oedistrito.LocalDateModiBy= tLocalDateModiBy;
                return oedistrito;
                 }

        /// <summary>
        /// Metodo para consultar Distritos
        /// </summary>

       public DataTable ConsultarDistrito(string scoddistrito, string scodcountry, string scoddepto, string scodcity, string snamedistrito)
       {

           DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SEARCHDISTRITO", scoddistrito, scodcountry, scoddepto, scodcity, snamedistrito);
           EDistrito oedistrito = new EDistrito();
           if (dt != null)
           {
               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i <= dt.Rows.Count - 1; i++)
                   {
                       oedistrito.codDistrict = dt.Rows[i]["cod_District"].ToString().Trim();
                       oedistrito.codcountry = dt.Rows[i]["cod_country"].ToString().Trim();
                       oedistrito.coddpto = dt.Rows[i]["cod_dpto"].ToString().Trim();
                       oedistrito.codCity = dt.Rows[i]["cod_City"].ToString().Trim();
                       oedistrito.DistrictStatus = Convert.ToBoolean(dt.Rows[i]["District_Status"].ToString().Trim());
                       oedistrito.NameLocal = dt.Rows[i]["Name_Local"].ToString().Trim();
                       oedistrito.LocalCreateBy = dt.Rows[i]["Local_CreateBy"].ToString().Trim();
                       oedistrito.LocalDateBy = Convert.ToDateTime(dt.Rows[i]["Local_DateBy"].ToString().Trim());
                       oedistrito.LocalModiby = dt.Rows[i]["Local_Modiby"].ToString().Trim();
                       oedistrito.LocalDateModiBy = Convert.ToDateTime(dt.Rows[i]["Local_DateModiBy"].ToString().Trim());
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
        /// Metodo para Actualizar Distritos
        /// </summary>
       
       public EDistrito ActualizarDistrito(string scoddistrito, string scodcountry, string scoddpto, string scodcity,
            bool bDistrictStatus, string sNameLocal,  string sLocalModiby, DateTime tLocalDateModiBy) {
                DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZARDISTRITO", scoddistrito, scodcountry, scoddpto, scodcity, bDistrictStatus, sNameLocal,  sLocalModiby, tLocalDateModiBy);
                EDistrito oeadistrito = new EDistrito();
                oeadistrito.codDistrict= scoddistrito;
                oeadistrito.codcountry= scodcountry;
                oeadistrito.coddpto= scoddpto;
                oeadistrito.codCity= scodcity;
                oeadistrito.DistrictStatus=bDistrictStatus;
                oeadistrito.NameLocal = sNameLocal;
                oeadistrito.LocalModiby= sLocalModiby;
                oeadistrito.LocalDateModiBy= tLocalDateModiBy;
                return oeadistrito;
                 }

        
        
        
        }


    }
