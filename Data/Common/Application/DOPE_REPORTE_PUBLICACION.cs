using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
namespace Lucky.Data.Common.Application
{
  public  class DOPE_REPORTE_PUBLICACION
    {

      private Conexion oConn;
      public DOPE_REPORTE_PUBLICACION()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

      /// <summary>
      /// permite registra información de levantamiento de publicaciones
      /// 28/04/2011  Magaly Jiménez/// </summary>
      /// <param name="iPerson_id"></param>
      /// <param name="sid_Plannig"></param>
      /// <param name="icompany_id"></param>
      /// <param name="inodeComercial_id"></param>
      /// <param name="sid_ProductFamily"></param>
      /// <param name="sSKU"></param>
      /// <param name="iid_tipoPublicacion"></param>
      /// <param name="tfec_ini_act"></param>
      /// <param name="tfec_fin_act"></param>
      /// <param name="tFec_Reg_Cel"></param>
      /// <param name="tFec_Reg_BD"></param>
      /// <param name="sCreateBy"></param>
      /// <param name="tDateBy"></param>
      /// <param name="sModiBy"></param>
      /// <param name="tDateModiBy"></param>
      /// <param name="bValidado"></param>
      /// <returns></returns>
      public EOPE_REPORTE_PUBLICACION RegistrarLevantamientoPublicacion(int iPerson_id, string sid_Plannig, int icompany_id, int inodeComercial_id, string sid_ProductFamily, string sSKU,
         int iid_tipoPublicacion, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, DateTime tFec_Reg_BD,  string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy, bool bValidado, string spromocionPuntual,
        decimal dPVP, decimal dOferta)
      {
         DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTELENVANTAMIENTOPUBLI", iPerson_id,  sid_Plannig, icompany_id,  inodeComercial_id,  sid_ProductFamily, sSKU,
        iid_tipoPublicacion, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, tFec_Reg_BD, sCreateBy, tDateBy, sModiBy, tDateModiBy, bValidado, spromocionPuntual, dPVP, dOferta);

        EOPE_REPORTE_PUBLICACION oeEOPE_LevantamienPublicacion =new EOPE_REPORTE_PUBLICACION();
          

          oeEOPE_LevantamienPublicacion.Person_id = iPerson_id;
          oeEOPE_LevantamienPublicacion.id_Plannig = sid_Plannig;
          oeEOPE_LevantamienPublicacion.company_id = icompany_id;
          oeEOPE_LevantamienPublicacion.nodeComercial_id = inodeComercial_id;
          oeEOPE_LevantamienPublicacion.id_ProductFamily = sid_ProductFamily;
          oeEOPE_LevantamienPublicacion.SKU = sSKU;
          oeEOPE_LevantamienPublicacion.id_tipoPublicacion = iid_tipoPublicacion;
          oeEOPE_LevantamienPublicacion.fec_ini_act = tfec_ini_act;
          oeEOPE_LevantamienPublicacion.fec_fin_act = tfec_fin_act;
          oeEOPE_LevantamienPublicacion.Fec_Reg_Cel = tFec_Reg_Cel;
          oeEOPE_LevantamienPublicacion.Fec_Reg_BD = tFec_Reg_BD;
          oeEOPE_LevantamienPublicacion.CreateBy = sCreateBy;
          oeEOPE_LevantamienPublicacion.DateBy = tDateBy;
          oeEOPE_LevantamienPublicacion.ModiBy = sModiBy;
          oeEOPE_LevantamienPublicacion.DateModiBy = tDateModiBy;
          oeEOPE_LevantamienPublicacion.Validado = bValidado;
              

   
          return oeEOPE_LevantamienPublicacion;

      }

      /// <summary>
      /// consulta grilla con registros en levantamiento de publicaciones.
      /// 28/04/2011  Magaly Jiménez
      /// </summary>
      /// <param name="sid_Plannig"></param>
      /// <returns></returns>
      public DataSet ConsultarGrillalevaPublicacion(string sid_Plannig, DateTime tFec_Reg_BD)
        {
            DataSet dt = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTALEVANTAMIENTOPUBLICACIONES", sid_Plannig, tFec_Reg_BD);

            EOPE_REPORTE_PUBLICACION odLP = new EOPE_REPORTE_PUBLICACION();
                   
     
            if (dt != null)
            {
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                //    {
                        

                //    }
                //}
                return dt;
            }
            else
            {
                return null;
            }
        }
      /// <summary>
      /// consulta grilla con registros en levantamiento de publicaciones.por SKU
      /// 06/05/2011  Magaly Jiménez
      /// </summary>
      /// <param name="sid_Plannig"></param>
      /// <param name="tFec_Reg_BD"></param>
      /// <returns></returns>
       public DataSet ConsultarGrillalevaPublicacionSKU(string sid_Plannig, DateTime tFec_Reg_BD)
        {
            DataSet dt = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTALEVANTAMIENTOPUBLICACIONESSKU", sid_Plannig, tFec_Reg_BD);

            EOPE_REPORTE_PUBLICACION odLP = new EOPE_REPORTE_PUBLICACION();
                   
     
            if (dt != null)
            {
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                //    {
                        

                //    }
                //}
                return dt;
            }
            else
            {
                return null;
            }
        }
      /// <summary>
      /// obtiene ids de levantamiento de publicaciones
      /// 07/05/2011  Magaly Jiménez
      /// </summary>
      /// <param name="scamino"></param>
      /// <param name="sProduct_Name"></param>
      /// <param name="sname_Family"></param>
      /// <param name="scommercialNodeName"></param>
      /// <param name="sNombre"></param>
      /// <returns></returns>
       public DataSet ObteneridsLevantamientoP(string sProduct_Name, string sname_Family, string scommercialNodeName, string sNombre)
       {
           DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTAIDS_LEVANTAMIENTOPUBLICACIONESSKU", sProduct_Name, sname_Family, scommercialNodeName, sNombre);
           return ds;
       }
      /// <summary>
      /// actualizar levantamiento publicaciones.
      /// 30/04/2011  Magaly jiménez
      /// </summary>
      /// <param name="iid_rptePbl"></param>
      /// <param name="inodeComercial_id"></param>
      /// <param name="sid_ProductFamily"></param>
      /// <param name="sSKU"></param>
      /// <param name="iid_tipoPublicacion"></param>
      /// <param name="tfec_ini_act"></param>
      /// <param name="tfec_fin_act"></param>
      /// <param name="tFec_Reg_Cel"></param>
      /// <param name="sModiBy"></param>
      /// <param name="tDateModiBy"></param>
      /// <param name="bValidado"></param>
      /// <param name="spromocionPuntual"></param>
      /// <param name="dPVP"></param>
      /// <param name="dOferta"></param>
      /// <returns></returns>
      public EOPE_REPORTE_PUBLICACION Actualizar_LevaPublicacion(int iid_rptePbl,  int inodeComercial_id, string sid_ProductFamily, string sSKU,
         int iid_tipoPublicacion, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel,  string sModiBy, DateTime tDateModiBy, bool bValidado, string spromocionPuntual,
        decimal dPVP, decimal dOferta)
      {
          DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_ACTUALIZARLENVANTAMIENTOPUBLI", iid_rptePbl,   inodeComercial_id,  sid_ProductFamily,  sSKU,
         iid_tipoPublicacion,  tfec_ini_act,  tfec_fin_act,  tFec_Reg_Cel,   sModiBy,  tDateModiBy,  bValidado, spromocionPuntual,
         dPVP,  dOferta);
          EOPE_REPORTE_PUBLICACION oealp = new EOPE_REPORTE_PUBLICACION();

          oealp.id_rptePbl = iid_rptePbl;
          oealp.nodeComercial_id = inodeComercial_id;
          oealp.id_ProductFamily = sid_ProductFamily;
          oealp.SKU = sSKU;
          oealp.id_tipoPublicacion = iid_tipoPublicacion;
          oealp.fec_ini_act = tfec_ini_act;
          oealp.fec_fin_act = tfec_fin_act;
          oealp.Fec_Reg_Cel = tFec_Reg_Cel;
          oealp.ModiBy = sModiBy;
          oealp.DateModiBy = tDateModiBy;
          oealp.Validado = bValidado;
          oealp.promocionPuntual = spromocionPuntual;
          oealp.PVP = dPVP;
          oealp.Oferta = dOferta;

   
          return oealp;
      }
    }
}
