using System;
using System.Collections.Generic;
using System.Data;
using Lucky.Entity.Common.Application;
using System.Text;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: Dinfo_Planning
    /// CreateBy: Ing. Magaly Andrea Jiménez
    /// DateBy: 03/07/2010
    /// Description: Establece los metodos para operar informacion relacionada con informes Planning
    /// Requerimiento No:
    /// </summary>
    /// 
    public class Dinfo_Planning
    {
        private Conexion oConn;
        public Dinfo_Planning()
        {

            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        public DataSet Eliminar_info_Planning(string sruta_reporte, string scod_channel)
        {

            DataSet ds = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_ELIMINAR_INFORMES", sruta_reporte, scod_channel);

            return ds;
        }

        /// <summary>
        /// Método que permite validar si ya ha sido cargado un informe en la BD
        /// Modificación : 28/07/2010 debido a que el atributo id_planning cambio de int a string fue 
        /// necesario quitar el convert que se estaba realizando. Se modificó nombre de Store 
        /// UP_WEBSIGE_PLANNING_DUPLICADOS_INFORMES por UP_WEBXPLORA_PLA_VERIFICA_INFORMEDUPLICADO      
        /// </summary>
        /// <param name="scod_Channel"></param>
        /// <param name="sruta_reporte"></param>
       
        /// <returns dt></returns>
        public DataTable Duplicados_Info_Planning(string scod_Channel, string sruta_reporte)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_VERIFICA_INFORMEDUPLICADO", scod_Channel, sruta_reporte);
            Einfo_Planning oeinfo_Planning = new Einfo_Planning();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeinfo_Planning.id_infoplanning = Convert.ToInt32(dt.Rows[i]["id_infoplanning"].ToString().Trim());
                        oeinfo_Planning.id_planning = dt.Rows[i]["id_planning"].ToString().Trim();
                        oeinfo_Planning.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeinfo_Planning.Report_Id = Convert.ToInt32(dt.Rows[i]["Report_Id"].ToString().Trim());
                        oeinfo_Planning.cod_Channel = dt.Rows[i]["cod_Channel"].ToString().Trim();                       
                        oeinfo_Planning.cod_Strategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"].ToString().Trim());
                        oeinfo_Planning.cod_Country = dt.Rows[i]["cod_Country"].ToString().Trim();
                        oeinfo_Planning.nom_reporte = dt.Rows[i]["nom_reporte"].ToString().Trim();
                        oeinfo_Planning.ruta_reporte = dt.Rows[i]["ruta_reporte"].ToString().Trim();
                        oeinfo_Planning.info_status = Convert.ToBoolean(dt.Rows[i]["info_status"].ToString().Trim());
                        oeinfo_Planning.info_CreateBy = dt.Rows[i]["info_CreateBy"].ToString().Trim();
                        oeinfo_Planning.info_dateBy = Convert.ToDateTime(dt.Rows[i]["info_dateBy"].ToString().Trim());
                        oeinfo_Planning.info_ModiBy = dt.Rows[i]["info_ModiBy"].ToString().Trim();
                        oeinfo_Planning.info_DateModiby = Convert.ToDateTime(dt.Rows[i]["info_DateModiby"].ToString().Trim());
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
        /// Método que permite validar si ya ha sido cargado un informe en la BD teniendo en cuenta q tenga subcanal       
        ///  13/04/2011 . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="scod_Channel"></param>
        /// <param name="sruta_reporte"></param>
        /// <param name="scod_SubChannel"></param>
        /// <returns dt></returns>
        public DataTable Duplicados_Info_Planning_consubcanal(string scod_Channel, string sruta_reporte, string scod_SubChannel)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_VERIFICA_INFORMEDUPLICADO_consubcanal", scod_Channel, sruta_reporte, scod_SubChannel);
            Einfo_Planning oeinfo_Planning = new Einfo_Planning();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeinfo_Planning.id_infoplanning = Convert.ToInt32(dt.Rows[i]["id_infoplanning"].ToString().Trim());
                        oeinfo_Planning.id_planning = dt.Rows[i]["id_planning"].ToString().Trim();
                        oeinfo_Planning.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeinfo_Planning.Report_Id = Convert.ToInt32(dt.Rows[i]["Report_Id"].ToString().Trim());
                        oeinfo_Planning.cod_Channel = dt.Rows[i]["cod_Channel"].ToString().Trim();
                        oeinfo_Planning.cod_SubChannel = dt.Rows[i]["cod_subchannel"].ToString().Trim();
                        oeinfo_Planning.cod_Strategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"].ToString().Trim());
                        oeinfo_Planning.cod_Country = dt.Rows[i]["cod_Country"].ToString().Trim();
                        oeinfo_Planning.nom_reporte = dt.Rows[i]["nom_reporte"].ToString().Trim();
                        oeinfo_Planning.ruta_reporte = dt.Rows[i]["ruta_reporte"].ToString().Trim();
                        oeinfo_Planning.info_status = Convert.ToBoolean(dt.Rows[i]["info_status"].ToString().Trim());
                        oeinfo_Planning.info_CreateBy = dt.Rows[i]["info_CreateBy"].ToString().Trim();
                        oeinfo_Planning.info_dateBy = Convert.ToDateTime(dt.Rows[i]["info_dateBy"].ToString().Trim());
                        oeinfo_Planning.info_ModiBy = dt.Rows[i]["info_ModiBy"].ToString().Trim();
                        oeinfo_Planning.info_DateModiby = Convert.ToDateTime(dt.Rows[i]["info_DateModiby"].ToString().Trim());
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
