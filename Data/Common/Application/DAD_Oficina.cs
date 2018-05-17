using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción métodos para Oficina
    /// CreateBy: Ing. Maagaly Jiménez
    /// CreateDate: 29-10-2010
    /// Requerimiento:
   public class DAD_Oficina
    {
        private Conexion oConn;
        public DAD_Oficina()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
      /// <summary>
      /// Permite registrar oficinas
      /// 29/10/2010 Magaly jiménez
        ///  modificiación se agregan campos abreviatura y orden 
        /// 25/02/2011 Magaly Jiménez
      /// </summary>
      /// <param name="sName_Oficina"></param>
      /// <param name="iCompany_id"></param>
      /// <param name="bOficina_Status"></param>
      /// <param name="sOficina_CreateBy"></param>
      /// <param name="tOficina_DateBy"></param>
      /// <param name="sOficina_ModiBy"></param>
      /// <param name="tOficina_DateModiBy"></param>
      /// <returns></returns>
        public EAD_Oficina RegistrarOficinas(int iCompany_id, string sName_Oficina, string sAbreviatura, int iOrden, bool bOficina_Status, string sOficina_CreateBy, DateTime tOficina_DateBy, string sOficina_ModiBy, DateTime tOficina_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTER_OFICINA", iCompany_id, sName_Oficina, sAbreviatura, iOrden, bOficina_Status, sOficina_CreateBy, tOficina_DateBy, sOficina_ModiBy, tOficina_DateModiBy);
           EAD_Oficina oerOficina =new EAD_Oficina(); 
        
         
           oerOficina.Company_id=iCompany_id;
           oerOficina.Name_Oficina = sName_Oficina;
           oerOficina.Abreviatura = sAbreviatura;
           oerOficina.Orden = iOrden;
           oerOficina.Oficina_Status=bOficina_Status;
           oerOficina.Oficina_CreateBy=sOficina_CreateBy;
           oerOficina.Oficina_DateBy=tOficina_DateBy;
           oerOficina.Oficina_ModiBy=sOficina_ModiBy;
           oerOficina.Oficina_DateModiBy=tOficina_DateModiBy;          
           return oerOficina;

        }
       /// <summary>
       /// consulta información en maestro de oficinas
       /// 30/10/2010 Magaly Jiménez
       /// </summary>
       /// <param name="lcod_Oficina"></param>
       /// <param name="sName_Oficina"></param>
       /// <returns></returns>
       public DataTable ObtenerOficina(long lcod_Oficina, string sName_Oficina)
       {
           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTAROFICINA", lcod_Oficina, sName_Oficina);
           EAD_Oficina oeOficina = new EAD_Oficina();           
       
           if (dt != null)
           {
               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i <= dt.Rows.Count - 1; i++)
                   {
                       oeOficina.cod_Oficina = Convert.ToInt64(dt.Rows[i]["cod_Oficina"].ToString().Trim());
                       oeOficina.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                       oeOficina.Name_Oficina = dt.Rows[i]["Name_Oficina"].ToString().Trim();
                       oeOficina.Abreviatura = dt.Rows[i]["Abreviatura"].ToString().Trim();
                       oeOficina.Orden = Convert.ToInt32(dt.Rows[i]["Orden"].ToString().Trim());
                       oeOficina.Oficina_Status = Convert.ToBoolean(dt.Rows[i]["Oficina_Status"].ToString().Trim());
                       oeOficina.Oficina_CreateBy = dt.Rows[i]["Oficina_CreateBy"].ToString().Trim();
                       oeOficina.Oficina_DateBy = Convert.ToDateTime(dt.Rows[i]["Oficina_DateBy"].ToString().Trim());
                       oeOficina.Oficina_ModiBy = dt.Rows[i]["Oficina_ModiBy"].ToString().Trim();
                       oeOficina.Oficina_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Oficina_DateModiBy"].ToString().Trim());

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
       /// permite Actualizar información en maestro de Oficina.
       /// 30/10/2010 Magaly Jiménez
       /// modificiación se agregan campos de abreviatura y orden en  maestro de Oficina.
       /// 25/02/2011 Magaly Jiménez
       /// </summary>
       /// <param name="lcod_Oficina"></param>
       /// <param name="iCompany_id"></param>
       /// <param name="sName_Oficina"></param>
       /// <param name="bOficina_Status"></param>
       /// <param name="sOficina_ModiBy"></param>
       /// <param name="tOficina_DateModiBy"></param>
       /// <returns>OEAoficina</returns>
       public EAD_Oficina Actualizar_Oficina(long lcod_Oficina, int iCompany_id, string sName_Oficina, string sAbreviatura, int iOrden, bool bOficina_Status, string sOficina_ModiBy, DateTime tOficina_DateModiBy)
       {
           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_OFICINA", lcod_Oficina, iCompany_id, sName_Oficina,  sAbreviatura, iOrden, bOficina_Status,  sOficina_ModiBy, tOficina_DateModiBy);
           EAD_Oficina OEAoficina = new EAD_Oficina();

           OEAoficina.Company_id = iCompany_id;
           OEAoficina.Name_Oficina = sName_Oficina;
           OEAoficina.Abreviatura = sAbreviatura;
           OEAoficina.Orden = iOrden;
           OEAoficina.Oficina_Status = bOficina_Status;
           OEAoficina.Oficina_ModiBy = sOficina_ModiBy;
           OEAoficina.Oficina_DateModiBy = tOficina_DateModiBy;

           return OEAoficina;
       }

    }
}
