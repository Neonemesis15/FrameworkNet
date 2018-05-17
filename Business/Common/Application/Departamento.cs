using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    public class Departamento
    {
        public Departamento() { 
        
        
        //Se define el Constructor por Defecto
        
        
        }
        /// <summary>
        /// Metodo para el Registro de Departamentos 
        /// </summary>
        public EDepartamento RegisterDepartamento(string scoddpto, string scodcountry, string snamedpto,
            bool bdptostatus, string sdptoCreateBy, DateTime tdptoDateBy, string sdptoModiBy, DateTime tdptoModiDateBy) {
                DDepartamento odrdpto = new DDepartamento();
                EDepartamento oedpto = odrdpto.RegisterDepartamento(scoddpto, scodcountry, snamedpto, bdptostatus, sdptoCreateBy,
                    tdptoDateBy, sdptoModiBy, tdptoModiDateBy);
                odrdpto = null;
                return oedpto;
                
        
        
        
        }

        /// <summary>
        /// Metodo para Consultar Departamentos
        /// </summary>


        public DataTable ConsultaDepartamento(string scoddpto , string scodcountry , string snamedpto) { 
          DDepartamento oddpto= new DDepartamento();
          DataTable dt = oddpto.ConsultaDepartamento(scoddpto, scodcountry, snamedpto);

          return dt;
        
        }
       
        
           
           
        
        
        //}

        /// <summary>
        /// Metodo para Actualizar de Departamentos 
        /// </summary>
        public EDepartamento ActualizarDepartamento(string scoddpto, string scodcountry, string snamedpto,
            bool bdptostatus, string sdptoModiBy, DateTime tdptoModiDateBy)
        {
            DDepartamento odadpto = new DDepartamento();
            EDepartamento oeadpto = odadpto.ActualizarDepartamento(scoddpto, scodcountry, snamedpto, bdptostatus,
             sdptoModiBy, tdptoModiDateBy);
            odadpto = null;
            return oeadpto;
                
        
        
        
        }



    }
}
