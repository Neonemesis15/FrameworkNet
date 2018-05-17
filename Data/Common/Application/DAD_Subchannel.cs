using System;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para SubChannel
    /// CreateBy: Ing. Magaly Jiménez
    /// CreateDate: 14-04-2011
    /// AlterBy: Angel Ortiz
    /// Agregado Company_id y parametrización de objeto de conexión a DB.
    
    public class DAD_Subchannel
    {
        private Conexion oConn;
        
        public DAD_Subchannel()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

        /// <summary>
        /// Registra subchannel
        /// 14/04/2011 Magaly Jiménez
        /// 18/07/2011 Angel Ortiz - Added Company_id
        /// </summary>
        /// <param name="cod_subchannel"></param>
        /// <param name="cod_Channel"></param>
        /// <param name="Company_id"></param>
        /// <param name="Name_subchannel"></param>
        /// <param name="Status"></param>
        /// <param name="CreateBy"></param>
        /// <param name="DateBy"></param>
        /// <param name="ModiBy"></param>
        /// <param name="DateModiBy"></param>
        /// <returns></returns>
        public EAD_Subchannel RegistrarSubChannel(string scod_subchannel, string scod_Channel, int iCompany_id, string sName_subchannel, bool bStatus, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_SUBCHANNEL", scod_subchannel, scod_Channel, iCompany_id,  sName_subchannel,  bStatus, sCreateBy,  tDateBy,  sModiBy,  tDateModiBy);

            EAD_Subchannel oerSubchannel = new EAD_Subchannel();

            oerSubchannel.cod_subchannel = scod_Channel;
            oerSubchannel.cod_Channel = scod_Channel;
            oerSubchannel.ICompany_id = iCompany_id;
            oerSubchannel.Name_subchannel = sName_subchannel;
            oerSubchannel.Status = bStatus;
            oerSubchannel.CreateBy = sCreateBy;
            oerSubchannel.DateBy =tDateBy ;
            oerSubchannel.ModiBy=sModiBy;
            oerSubchannel.DateModiBy = tDateModiBy;
            return oerSubchannel;         
        }



        /// <summary>
        /// Consulta subchannel
        /// 14/04/2011 Magaly jiménez
        /// Angel Ortiz - Agredo parámetro Company_id
        /// </summary>
        /// <param name="Company_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="sName_subchannel"></param>
        /// <returns></returns>
        public DataTable ConsultarSubCHANNEL(int iCompany_id, string scod_Channel, string sName_subchannel)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTASUBCHANNEL", iCompany_id, scod_Channel, sName_subchannel);
            EAD_Subchannel oeSuchannel = new EAD_Subchannel();
         
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        //oeSubCategoria.id_Subcategory = Convert.ToInt64(dt.Rows[i]["id_Subcategory"].ToString().Trim());
                        //oeSubCategoria.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                        //oeSubCategoria.Name_Subcategory = dt.Rows[i]["Name_Subcategory"].ToString().Trim();
                        //oeSubCategoria.Subcategory_Status = Convert.ToBoolean(dt.Rows[i]["Subcategory_Status"].ToString().Trim());
                        //oeSubCategoria.Subcategory_CreateBy = dt.Rows[i]["Subcategory_CreateBy"].ToString().Trim();
                        //oeSubCategoria.Subcategory_DateBy = Convert.ToDateTime(dt.Rows[i]["Subcategory_DateBy"].ToString().Trim());
                        //oeSubCategoria.Subcategory_ModiBy = dt.Rows[i]["Subcategory_ModiBy"].ToString().Trim();
                        //oeSubCategoria.Subcategory_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Subcategory_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return dt;
            }
        }

        /// <summary>
        /// Actualizar subchannel
        /// 14/04/2011 Magaly Jiménez
        /// 18/07/2011 Angel Ortiz - Added Company_id
        /// </summary>
        /// <param name="cod_subchannel"></param>
        /// <param name="cod_Channel"></param>
        /// <param name="Company_id"></param>
        /// <param name="Name_subchannel"></param>
        /// <param name="Status"></param>
        /// <param name="ModiBy"></param>
        /// <param name="DateModiBy"></param>
        /// <returns></returns>
        public EAD_Subchannel Actualizar_SubChannel(string scod_subchannel, string scod_Channel, int iCompany_id, string sName_subchannel, bool bStatus, string sModiBy, DateTime tDateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARSUBCHANNEL", scod_subchannel, scod_Channel, iCompany_id, sName_subchannel, bStatus, sModiBy, tDateModiBy);
            EAD_Subchannel oeaSubchannel = new EAD_Subchannel();

            oeaSubchannel.cod_subchannel = scod_subchannel;
            oeaSubchannel.cod_Channel = scod_Channel;
            oeaSubchannel.ICompany_id = iCompany_id;
            oeaSubchannel.Name_subchannel = sName_subchannel;
            oeaSubchannel.Status = bStatus;
            oeaSubchannel.ModiBy = sModiBy;
            oeaSubchannel.DateModiBy = tDateModiBy;

            return oeaSubchannel;
        }
    }
}
