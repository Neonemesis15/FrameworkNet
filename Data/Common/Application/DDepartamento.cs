using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DDepartamento
    /// Creada Por: Ing. Carlos Alberto Hernandez Rincon
    /// Descripcion: Define los metodos transaccionales para la clase Departamento
    /// Requerimiento No <>
    /// </summary>

    public class DDepartamento
    {
        private Conexion oConn;
        public DDepartamento() {

            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        
        }
        /// <summary>
        /// Metodo para el Registro de Departamentos 
        /// </summary>
        public EDepartamento RegisterDepartamento(string scoddpto, string scodcountry, string snamedpto,
            bool bdptostatus, string sdptoCreateBy, DateTime tdptoDateBy, string sdptoModiBy, DateTime tdptoModiDateBy) {
                DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_REGISTERDEPTO", scoddpto, scodcountry, snamedpto, bdptostatus, sdptoCreateBy,
                 tdptoDateBy, sdptoModiBy, tdptoModiDateBy);
                EDepartamento oerdepto = new EDepartamento();
                oerdepto.coddpto = scoddpto;
                oerdepto.codCountry = scodcountry;
                oerdepto.Namedpto = snamedpto;
                oerdepto.DptoStatus = bdptostatus;
                oerdepto.DepartamentCreateBy = sdptoCreateBy;
                oerdepto.DepartamentDateBy = tdptoDateBy;
                oerdepto.DepartamentModiBy = sdptoModiBy;
                oerdepto.DepartamentDateModiBy = tdptoModiDateBy;
                return oerdepto;

              }
        
        /// <summary>
        /// Metodo para Consultar Departamentos
        /// </summary>

        public DataTable ConsultaDepartamento(string scoddpto, string scodcountry, string snamedpto)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SEARCHDPTO", scodcountry, scoddpto, snamedpto);
            EDepartamento oesdpto = new EDepartamento();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oesdpto.coddpto = dt.Rows[i]["cod_dpto"].ToString().Trim();
                        oesdpto.codCountry = dt.Rows[i]["cod_Country"].ToString().Trim();
                        oesdpto.Namedpto = dt.Rows[i]["Name_dpto"].ToString().Trim();
                        oesdpto.DepartamentCreateBy = dt.Rows[i]["Departament_CreateBy"].ToString().Trim();
                        oesdpto.DepartamentDateBy = Convert.ToDateTime(dt.Rows[i]["Departament_DateBy"].ToString().Trim());
                        oesdpto.DepartamentModiBy = dt.Rows[i]["Departament_ModiBy"].ToString().Trim();
                        oesdpto.DepartamentDateModiBy = Convert.ToDateTime(dt.Rows[i]["Departament_DateModiBy"].ToString().Trim());
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
        /// Metodo para Actualizar de Departamentos 
        /// </summary>
        public EDepartamento ActualizarDepartamento(string scoddpto, string scodcountry, string snamedpto,
            bool bdptostatus, string sdptoModiBy, DateTime tdptoModiDateBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZARDPTO", scoddpto, scodcountry, snamedpto, bdptostatus, sdptoModiBy, tdptoModiDateBy);
            EDepartamento oeadepto = new EDepartamento();
            oeadepto.coddpto = scoddpto;
            oeadepto.codCountry = scodcountry;
            oeadepto.Namedpto = snamedpto;
            oeadepto.DptoStatus = bdptostatus;
            oeadepto.DepartamentModiBy = sdptoModiBy;
            oeadepto.DepartamentDateModiBy = tdptoModiDateBy;
            return oeadepto;

        }


    }
}
