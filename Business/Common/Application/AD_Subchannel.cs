using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: SubCategoria
    /// CreateBy: Ing. Magaly Jiménez
    /// DateBy: 14/04/2011
    /// Description: Establece los metodos para operar informacion relacionada con las SubChannel de productos Lucky
    /// Requerimiento No:
    /// AlterBy: Angel Ortiz
    /// Se agrega el Parámetro Company_id.
    /// </summary>
   public class AD_Subchannel
    {
       public AD_Subchannel()
        {
            //Se define el constructor por defecto
        }
       /// <summary>
       /// Registra subchannel
       /// 14/04/2011 Magaly Jiménez
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
       public EAD_Subchannel RegistrarSubChanel(string scod_subchannel, string scod_Channel, int iCompany_id, string sName_subchannel, bool bStatus, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy)
       {
           DAD_Subchannel odrsubChannel = new DAD_Subchannel();
           EAD_Subchannel oeSubChannel = odrsubChannel.RegistrarSubChannel(scod_subchannel, scod_Channel, iCompany_id, sName_subchannel, bStatus, sCreateBy, tDateBy, sModiBy, tDateModiBy);
           odrsubChannel = null;
           return oeSubChannel;
       }
       /// <summary>
       /// Consulta subchannel
       /// 14/04/2011 Magaly Jiménez
       /// Angel Ortiz - Agregado Company_id
       /// </summary>
       /// <param name="scod_Channel"></param>
       /// <param name="scod_Channel"></param>
       /// <param name="sName_subchannel"></param>
       /// <returns></returns>
       public DataTable ConsultarSubChannel(int sCompany_id, string scod_Channel, string sName_subchannel)
       {
            DAD_Subchannel odsSubchannel = new DAD_Subchannel();           
            EAD_Subchannel oeSubChannel = new EAD_Subchannel();
            DataTable dtSubChannel = odsSubchannel.ConsultarSubCHANNEL(sCompany_id, scod_Channel, sName_subchannel);
            odsSubchannel = null;
            return dtSubChannel;
       }

       /// <summary>
       /// Actualizar subchannel
       /// 14/04/2011 Magaly Jiménez
       /// 18/07/2011 Angel Ortiz - Agregado Company_id
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
           DAD_Subchannel odaSubchannel = new DAD_Subchannel();
           EAD_Subchannel oeaSubChannel = odaSubchannel.Actualizar_SubChannel(scod_subchannel, scod_Channel, iCompany_id, sName_subchannel, bStatus, sModiBy, tDateModiBy);
           odaSubchannel = null;
           return oeaSubChannel;
       }
    }
}
