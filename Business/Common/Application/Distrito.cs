using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Data.Common.Security;
using Lucky.Entity.Common.Application;
using Lucky.Business;
using Lucky.Entity.Common.Security;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Distrito
    /// Creada Por: Ing. Carlos Alberto Hernández Rincon
    /// Fecha de Creación: 15/06/2009
    /// Descripcion: Define los metodos del Negocio parra Distrito
    /// Requerimiento No <>
    /// </summary>


    public class Distrito
    {
        public Distrito() { 
        
        //Se define el contructor por defecto
        
        
        }

        /// <summary>
        /// Metodo para Registrar Distritos
        /// </summary>

        public EDistrito RegistrarDistrito(string scoddistrito, string scodcountry, string scoddpto, string scodcity,
             bool bDistrictStatus, string sNameLocal, string sLocalCreateBy, DateTime tLocalDateBy, string sLocalModiby,
             DateTime tLocalDateModiBy) {
                 DDistrito odrdistrito = new DDistrito();
                 EDistrito oerdistrito = odrdistrito.RegistrarDistrito(scoddistrito, scodcountry, scoddpto, scodcity,
                     bDistrictStatus, sNameLocal, sLocalCreateBy, tLocalDateBy, sLocalModiby, tLocalDateModiBy);
                 odrdistrito = null;
                 return oerdistrito;
             
           
        
        
        
        
        }


           /// <summary>
        /// Metodo para consultar Distritos
        /// </summary>

        public DataTable ConsultarDistrito(string scoddistrito, string scodcountry, string scoddepto, string scodcity, string snamedistrito)
        {
            DDistrito odcdistrito = new DDistrito();
            DataTable dt = odcdistrito.ConsultarDistrito(scoddistrito, scodcountry,  scoddepto,  scodcity, snamedistrito);
            return dt;        
        }

          /// <summary>
        /// Metodo para Actualizar Distritos
        /// </summary>

        public EDistrito ActualizarDistrito(string scoddistrito, string scodcountry, string scoddpto, string scodcity,
             bool bDistrictStatus, string sNameLocal, string sLocalModiby, DateTime tLocalDateModiBy) {
                 DDistrito odadistrito = new DDistrito();
                 EDistrito oeadistrito = odadistrito.ActualizarDistrito(scoddistrito, scodcountry, scoddpto, scodcity, bDistrictStatus,
                     sNameLocal, sLocalModiby, tLocalDateModiBy);
                 odadistrito = null;
                 return oeadistrito;
               
        
        
         }
       


    }
}
