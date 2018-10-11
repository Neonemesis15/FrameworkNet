using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Mallas
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 13/09/2010
    /// Description: Establece los metodos para operar informacion relacionada con Mallas de Puntos de venta.
    /// Requerimiento No:
    /// </summary>
    /// 

    public class Malla
    {
        public Malla()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        /// permite Registrar mallas
        /// 13/09/2010 Magaly jiménez
        /// </summary>
        /// <param name="smalla"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="bmalla_Status"></param>
        /// <param name="smalla_CreateBy"></param>
        /// <param name="tmalla_DateBy"></param>
        /// <param name="smalla_ModiBy"></param>
        /// <param name="tmalla_DateModiBy"></param>
        /// <returns>oeMalla</returns>
        public EMalla RegistrarMallas(string smalla, int iCompany_id, bool bmalla_Status, string smalla_CreateBy, DateTime tmalla_DateBy, string smalla_ModiBy, DateTime tmalla_DateModiBy)
        {
            DMalla odrMalla = new DMalla();
            EMalla oeMalla = odrMalla.RegistrarMalla(smalla, iCompany_id, bmalla_Status, smalla_CreateBy, tmalla_DateBy, smalla_ModiBy, tmalla_DateModiBy);
            odrMalla = null;
            return oeMalla;
        }

        /// <summary>
        /// Permite consultar información de Mallas
        /// 13/09/2010 Magaly Jiménez.
        /// </summary>
        /// <param name="smalla"></param>
        /// <returns>dtMalla</returns>
        public DataTable ConsultarMalla(string smalla)
        {
            DMalla odsMalla = new DMalla();
            EMalla oeMalla= new EMalla();
            DataTable dtMalla = odsMalla.consultarMalla(smalla);
            odsMalla = null;
            return dtMalla;

           
        }

        /// <summary>
        /// Permite Actualizar Malla de Puntos de Venta.
        /// 13/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iid_malla"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="smalla"></param>
        /// <param name="bmalla_Status"></param>
        /// <param name="smalla_ModiBy"></param>
        /// <param name="tmalla_DateModiBy"></param>
        /// <returns>oeaMalla</returns>
        public EMalla Actualizar_Malla(int iid_malla, int iCompany_id, string smalla, bool bmalla_Status, string smalla_ModiBy, DateTime tmalla_DateModiBy)
        {
            DMalla odaMalla = new DMalla();
            EMalla oeaMalla =odaMalla.Actualizar_Malla(iid_malla, iCompany_id, smalla, bmalla_Status, smalla_ModiBy, tmalla_DateModiBy);
            odaMalla = null;
            return oeaMalla;
        }
    }
}
