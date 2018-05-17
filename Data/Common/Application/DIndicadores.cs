using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DIndicadores
    /// Creada Por:Ing.Carlos Alberto Hernandez
    /// Fecha de Creacion: 05/05/2009
    /// Descripcion: Define las transaciones de datos para la clase Indicadores
    /// requerimiento No:
    /// </summary>
    public class DIndicadores
    {
        private Conexion oConn;
        public DIndicadores()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        ///Metodo para registrar los Indicadores
        ///Se elimina icodDetitem y iidsymbol porque N/A . Ing. Mauricio Ortiz
        ///se inserta bool bindicador_Status string sCreateBy DateTime tDateBy string sModiBy DateTime tDateModiBy . Ing. Mauricio Ortiz
        /// </summary>
        /// 




        public EIndicadores Resgistrar_Indicadores(int icodstrategy, string snameindicador, string sformula, string sdescripcionoperacion, int iReport_Id, bool bindicador_Status, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTER_INDICADORES", icodstrategy, snameindicador, sformula, sdescripcionoperacion, iReport_Id, bindicador_Status, sCreateBy, tDateBy, sModiBy, tDateModiBy);
            EIndicadores oeindicadors = new EIndicadores();
            oeindicadors.codStrategy = icodstrategy;
            oeindicadors.nameindicador = snameindicador;
            oeindicadors.formula = sformula;
            oeindicadors.descripcionoperacion = sdescripcionoperacion;
            oeindicadors.Report_Id = iReport_Id;
            oeindicadors.indicador_Status = bindicador_Status;
            oeindicadors.indicadorCreateBy = sCreateBy;
            oeindicadors.indicadorDateBy = tDateBy;
            oeindicadors.indicadorModiBy = sModiBy;
            oeindicadors.indicadorDateModiBy = tDateModiBy;


            return oeindicadors;


        }


        /// <summary>
        ///Nombre Metodo: SEARCHINDICADORES
        ///Función: Permite Consultar Indicadores
        ///Ing . Mauricio Ortiz
        /// </summary> 

        public DataTable Obtenerindicadores(string snameindicador)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHIINDICADORES", snameindicador);
            EIndicadores oeIndicador = new EIndicadores();


            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeIndicador.idindicador = Convert.ToInt32(dt.Rows[i]["id_indicador"].ToString().Trim());
                        oeIndicador.codStrategy = Convert.ToInt32(dt.Rows[i]["cod_strategy"].ToString().Trim());
                        oeIndicador.nameindicador = (dt.Rows[i]["name_indicador"].ToString().Trim());
                        oeIndicador.formula = dt.Rows[i]["formula"].ToString().Trim();
                        oeIndicador.descripcionoperacion = dt.Rows[i]["descripcion_operacion"].ToString().Trim();
                        oeIndicador.Report_Id = Convert.ToInt32(dt.Rows[i]["Report_Id"].ToString().Trim());
                        oeIndicador.indicador_Status = Convert.ToBoolean(dt.Rows[i]["indicador_Status"].ToString().Trim());
                        oeIndicador.indicadorCreateBy = dt.Rows[i]["indicador_CreateBy"].ToString().Trim();
                        oeIndicador.indicadorDateBy = Convert.ToDateTime(dt.Rows[i]["indicador_DateBy"].ToString().Trim());
                        oeIndicador.indicadorModiBy = dt.Rows[i]["indicador_ModiBy"].ToString().Trim();
                        oeIndicador.indicadorDateModiBy = Convert.ToDateTime(dt.Rows[i]["indicador_DateModiBy"].ToString().Trim());
                        oeIndicador.cod_Country = (dt.Rows[i]["cod_Country"].ToString().Trim());
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
        /// Metodo para Buscar Indicadores. 
        /// este método no tiene funcionalidad actualmente
        /// </summary>

        public DataTable Search_Indicadores(string sdescripcionoperacion)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WE_SEARCH_INDICADORES", sdescripcionoperacion);
            EIndicadores oesindicadors = new EIndicadores();
            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    oesindicadors.idindicador = Convert.ToInt32(dt.Rows[i]["id_indicador"].ToString().Trim());
                    oesindicadors.codDetitem = Convert.ToInt32(dt.Rows[i]["cod_Detitem"].ToString().Trim());
                    oesindicadors.formula = dt.Rows[i]["formula"].ToString().Trim();
                    oesindicadors.descripcionoperacion = dt.Rows[i]["descripcion_operacion"].ToString().Trim();
                    oesindicadors.idsymbol = Convert.ToInt32(dt.Rows[i]["id_symbol"].ToString().Trim());
                    oesindicadors.codStrategy = Convert.ToInt32(dt.Rows[i]["cod_strategy"].ToString().Trim());
                    oesindicadors.indicadorCreateBy = dt.Rows[i]["indicador_CreateBy"].ToString().Trim();
                    oesindicadors.indicadorDateBy = Convert.ToDateTime(dt.Rows[i]["indicador_DateBy"].ToString().Trim());
                    oesindicadors.indicadorModiBy = dt.Rows[i]["indicador_ModiBy"].ToString().Trim();
                    oesindicadors.indicadorDateModiBy = Convert.ToDateTime(dt.Rows[i]["indicador_DateModiBy"].ToString().Trim());
                }
                return dt;
            }
            else
            {
                return null;
            }
        }




        /// <summary>
        /// Metodo para actualizar indicadores

        /// </summary>
        public EIndicadores Actualizar_indicadores(int iid_indicador, string snameindicador, string sformula, string sdescripcion_operacion,
            int iReport_Id, bool bindicador_Status, string sindicador_ModiBy, DateTime tindicador_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_INDICADOR", iid_indicador, snameindicador, sformula, sdescripcion_operacion,
            iReport_Id, bindicador_Status, sindicador_ModiBy, tindicador_DateModiBy);
            EIndicadores oeaindicadors = new EIndicadores();

            oeaindicadors.idindicador = iid_indicador;
            oeaindicadors.nameindicador = snameindicador;
            oeaindicadors.formula = sformula;
            oeaindicadors.descripcionoperacion = sdescripcion_operacion;
            oeaindicadors.Report_Id = iReport_Id;
            oeaindicadors.indicador_Status = bindicador_Status;
            oeaindicadors.indicadorModiBy = sindicador_ModiBy;
            oeaindicadors.indicadorDateModiBy = tindicador_DateModiBy;

            return oeaindicadors;
        }
    }
}
        
        
     

