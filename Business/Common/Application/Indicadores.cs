using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Data.Common.Security;
using Lucky.Entity.Common.Application;
using Lucky.Business;
using Lucky.Entity.Common.Security;
using Lucky.Entity.Common.Application.Security;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Indicadores
    /// Creado Por: Ing.Carlos Alberto Hernandez
    /// Fecha de Creacion:05/05/2009
    /// Descripcion:Define los metodos del Negocio para gestionar los Indicadores
    /// </summary>
    public class Indicadores
    {
        public Indicadores()
        {

            //Se define el constructor por defecto


        }
        /// <summary>
        /// Metodo para registrar Indicadores
        /// Se elimina icodDetitem y iidsymbol porque N/A . Ing. Mauricio Ortiz
        /// se inserta bindicador_Status , string sCreateBy DateTime tDateBy string sModiBy DateTime tDateModiBy . Ing. Mauricio Ortiz
        /// </summary>

        public EIndicadores Registrar_Indicadores(int icodstrategy, string snameindicador, string sformula, string sdescripcionoperacion, int iReport_Id, bool bindicador_Status, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy)
        {

            DIndicadores odrindicators = new DIndicadores();
            EIndicadores oerindicators = odrindicators.Resgistrar_Indicadores(icodstrategy, snameindicador, sformula, sdescripcionoperacion, iReport_Id, bindicador_Status, sCreateBy, tDateBy, sModiBy, tDateModiBy);
            odrindicators = null;
            return oerindicators;

        }

        //---Metodo de Consulta de indicadores
        // --- Ing. Mauricio Ortiz

        public DataTable BuscarIndicador(string nameindicador)
        {
            Lucky.Data.Common.Application.DIndicadores odseIndicador = new Lucky.Data.Common.Application.DIndicadores();
            EIndicadores oeIndicador = new EIndicadores();

            DataTable dtIndicador = odseIndicador.Obtenerindicadores(nameindicador);

            odseIndicador = null;
            return dtIndicador;
        }


        /// <summary>
        /// Metodo para Consultar Indicadores
        /// </summary>
        public DataTable Search_Indicadores(string sdescripcionoperacion)
        {

            DIndicadores odsindicators = new DIndicadores();
            DataTable dt = odsindicators.Search_Indicadores(sdescripcionoperacion);
            odsindicators = null;
            return dt;


        }
        /// <summary>
        /// Metodo para Actualizar Indicadores
        /// </summary>
        public EIndicadores Actualizar_indicadores(int iid_indicador, string snameindicador, string sformula, string sdescripcion_operacion,
            int iReport_Id, bool bindicador_Status, string sindicador_ModiBy, DateTime tindicador_DateModiBy)
        {
            DIndicadores odaindicators = new DIndicadores();
            EIndicadores oeaindicators = odaindicators.Actualizar_indicadores(iid_indicador, snameindicador, sformula, sdescripcion_operacion,
            iReport_Id, bindicador_Status, sindicador_ModiBy, tindicador_DateModiBy);

            odaindicators = null;
            return oeaindicators;
        }
    }
}
      
        
  