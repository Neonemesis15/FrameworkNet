using System;
using System.Data;
using Lucky.Entity.Common.Application;



namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DCanales.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:27/05/2009
    /// Requerimiento:

    public class DCanales
    {
        private Conexion oConn;
        public DCanales()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

        //Método para Registrar Canales
        /// <summary>
        ///  Modificación: se agrega campo de company_id
        ///  20/10/2010 Magaly Jiménez
        /// </summary>
        /// <param name="scodChannel"></param>
        /// <param name="iCompany_id"></param>
        /// <param name="sChannelName"></param>
        /// <param name="sChanneldescription"></param>
        /// <param name="bChannelStatus"></param>
        /// <param name="sChannelCreateBy"></param>
        /// <param name="tChannelDateBy"></param>
        /// <param name="sChannelModiBy"></param>
        /// <param name="tChannelDateModiBy"></param>
        /// <returns></returns>
        public ECanales RegistrarCanalesPK(string scodChannel, int iCompany_id, string sChannelName, string sChanneldescription, int iChannelType, bool bChannelStatus, string sChannelCreateBy, DateTime tChannelDateBy, string sChannelModiBy, DateTime tChannelDateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERCHANNEL", scodChannel, iCompany_id, sChannelName, sChanneldescription, iChannelType, bChannelStatus, sChannelCreateBy, tChannelDateBy, sChannelModiBy, tChannelDateModiBy);
            ECanales oercanales = new ECanales();
            oercanales.codChannel = scodChannel;
            oercanales.Company_id = iCompany_id;
            oercanales.ChannelName = sChannelName;
            oercanales.Channeldescription = sChanneldescription;
            oercanales.ChannelType = iChannelType;
            oercanales.ChannelStatus = bChannelStatus;
            oercanales.ChannelCreateBy = sChannelCreateBy;
            oercanales.ChannelDateBy = tChannelDateBy;
            oercanales.ChannelModiBy = sChannelModiBy;
            oercanales.ChannelDateModiBy = tChannelDateModiBy;
            return oercanales;
        }
        public ECanales RegistrarCanalesTMP(string scodChannel, string sChannelName, string sChannelType, bool bChannelStatus)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERCHANNEL_TMP", scodChannel, sChannelName, sChannelType, Convert.ToInt32(bChannelStatus));
            ECanales oercanales = new ECanales();
            return oercanales;
        }

        //Metodo para Actualizar Canales Ing. Carlos Alberto Hernandez R
        public ECanales Actualizar_Canales(string scodChannel, int iCompany_id, string sChannelName, string sChanneldescription, int iChannelType, bool bChannelStatus, string sChannelModiBy, DateTime tChannelDateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_CHANNEL", scodChannel, iCompany_id, sChannelName, sChanneldescription, iChannelType, bChannelStatus, sChannelModiBy, tChannelDateModiBy);
            ECanales oeacanales = new ECanales();
            oeacanales.codChannel = scodChannel;
            oeacanales.Company_id = iCompany_id;
            oeacanales.ChannelName = sChannelName;
            oeacanales.Channeldescription = sChanneldescription;
            oeacanales.ChannelType = iChannelType;
            oeacanales.ChannelStatus = bChannelStatus;
            oeacanales.ChannelModiBy = sChannelModiBy;
            oeacanales.ChannelDateModiBy = tChannelDateModiBy;
            return oeacanales;
        }
        public ECanales Actualizar_Canales_TMP(string scodChannel, string sChannelName, string sChannelType, bool bChannelStatus)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_CHANNEL_TMP", scodChannel, sChannelName, sChannelType, Convert.ToInt32(bChannelStatus));
            ECanales oeacanales = new ECanales();
            return oeacanales;
        }

        /// <summary>
        ///Nombre Metodo: SEARCHCANALES
        ///Función: Permite Consultar Canales
        /// </summary>
        public DataTable ObtenerCanales(string sCodChannel, string sChannelName)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHCANALES", sCodChannel, sChannelName);
            ECanales oeCanales = new ECanales();            

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeCanales.codChannel = dt.Rows[i]["cod_Channel"].ToString().Trim();
                        oeCanales.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeCanales.ChannelName = dt.Rows[i]["Channel_Name"].ToString().Trim();
                        oeCanales.Channeldescription = dt.Rows[i]["Channel_description"].ToString().Trim();
                        oeCanales.ChannelType = Convert.ToInt32(dt.Rows[i]["chtype_id"].ToString().Trim());
                        oeCanales.ChannelStatus = Convert.ToBoolean(dt.Rows[i]["Channel_Status"].ToString().Trim());
                        oeCanales.ChannelCreateBy = dt.Rows[i]["Channel_CreateBy"].ToString().Trim();
                        oeCanales.ChannelDateBy = Convert.ToDateTime(dt.Rows[i]["Channel_DateBy"].ToString().Trim());
                        oeCanales.ChannelModiBy = dt.Rows[i]["Channel_ModiBy"].ToString().Trim();
                        oeCanales.ChannelDateModiBy = Convert.ToDateTime(dt.Rows[i]["Channel_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        
           
    }
}
           