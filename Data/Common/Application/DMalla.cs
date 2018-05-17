using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para Brand
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate: 13-09-2010
    /// Requerimiento:

    public class DMalla
    {

        private Conexion oConn;
        public DMalla()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// Permite registrar mallas de puntos de Venta.
        /// 13/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="smalla"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="bmalla_Status"></param>
        /// <param name="smalla_CreateBy"></param>
        /// <param name="tmalla_DateBy"></param>
        /// <param name="smalla_ModiBy"></param>
        /// <param name="tmalla_DateModiBy"></param>
        /// <returns>oerMalla</returns>
        public EMalla RegistrarMalla(string smalla, int iCompany_id, bool bmalla_Status, string smalla_CreateBy, DateTime tmalla_DateBy, string smalla_ModiBy, DateTime tmalla_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERMALLA", smalla, iCompany_id, bmalla_Status, smalla_CreateBy, tmalla_DateBy, smalla_ModiBy, tmalla_DateModiBy);
            EMalla oerMalla = new EMalla();

            oerMalla.malla = smalla;
            oerMalla.Company_id = iCompany_id;
            oerMalla.malla_Status = bmalla_Status;
            oerMalla.malla_CreateBy = smalla_CreateBy;
            oerMalla.malla_DateBy = tmalla_DateBy;
            oerMalla.malla_ModiBy = smalla_ModiBy;
            oerMalla.malla_DateModiBy = tmalla_DateModiBy;


            return oerMalla;
        }

        /// <summary>
        /// consulta  información en el maestro de malla
        /// </summary>
        /// <param name="smalla"></param>
        /// <returns>dt</returns>
        
        public DataTable consultarMalla (string Smalla)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTAMALLA", Smalla);
            EMalla oeMalla = new EMalla();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeMalla.id_malla = Convert.ToInt32(dt.Rows[i]["id_malla"].ToString().Trim());
                        oeMalla.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeMalla.malla = dt.Rows[i]["malla"].ToString().Trim();
                        oeMalla.malla_Status = Convert.ToBoolean(dt.Rows[i]["malla_Status"].ToString().Trim());
                        oeMalla.malla_CreateBy = dt.Rows[i]["malla_CreateBy"].ToString().Trim();
                        oeMalla.malla_DateBy = Convert.ToDateTime(dt.Rows[i]["malla_DateBy"].ToString().Trim());
                        oeMalla.malla_ModiBy = dt.Rows[i]["malla_ModiBy"].ToString().Trim();
                        oeMalla.malla_DateModiBy = Convert.ToDateTime(dt.Rows[i]["malla_DateModiBy"].ToString().Trim());

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
        /// Metodo para Actualizar Mallas de Puntos de Venta
        /// 13/09/2010
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
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_MALLAS", iid_malla, iCompany_id, smalla, bmalla_Status, smalla_ModiBy, tmalla_DateModiBy);
            EMalla oeaMalla = new EMalla();

            oeaMalla.malla = smalla;
            oeaMalla.Company_id = iCompany_id;
            oeaMalla.malla_Status = bmalla_Status;
            oeaMalla.malla_ModiBy = smalla_ModiBy;
            oeaMalla.malla_DateModiBy = tmalla_DateModiBy;          
       
            return oeaMalla;
        }
    }
}

