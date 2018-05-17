using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
namespace Lucky.Data.Common.Application
{
  public  class DOPE_REPORTE_EXHB_IMPULSO
    {

      
      private Conexion oConn;
      public DOPE_REPORTE_EXHB_IMPULSO()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

      /// <summary>
      /// inserta datos de levantamiento de exhibición e impuloso
      /// 02/05/2011 Magaly jiménez
      ///  </summary>
      /// <param name="iPerson_id"></param>
      /// <param name="sid_Plannig"></param>
      /// <param name="icompany_id"></param>
      /// <param name="sClientPDV_code"></param>
      /// <param name="sid_ProductFamily"></param>
      /// <param name="sSKU"></param>
      /// <param name="sid_Tipo_Act"></param>
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
      public EOPE_REPORTE_EXHB_IMPULSO RegistrarLevantamientoExhbImpulso(int iPerson_id, string sid_Plannig, int icompany_id, string sClientPDV_code, string sid_ProductFamily, string sSKU,
         string sid_Tipo_Act, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, DateTime tFec_Reg_BD, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy, bool bValidado)
      {
          DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_REGISTELENVANTAEXHI_IMPULSO", iPerson_id, sid_Plannig, icompany_id, sClientPDV_code, sid_ProductFamily, sSKU,
        sid_Tipo_Act, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, tFec_Reg_BD, sCreateBy, tDateBy, sModiBy, tDateModiBy, bValidado);

          EOPE_REPORTE_EXHB_IMPULSO oeEOPE_LevantamienExhiImpulso = new EOPE_REPORTE_EXHB_IMPULSO();


          oeEOPE_LevantamienExhiImpulso.Person_id = iPerson_id;
          oeEOPE_LevantamienExhiImpulso.id_Plannig = sid_Plannig;
          oeEOPE_LevantamienExhiImpulso.company_id = icompany_id;
          oeEOPE_LevantamienExhiImpulso.ClientPDV_code = sClientPDV_code;
          oeEOPE_LevantamienExhiImpulso.id_ProductFamily = sid_ProductFamily;
          oeEOPE_LevantamienExhiImpulso.SKU = sSKU;
          oeEOPE_LevantamienExhiImpulso.id_Tipo_Act = sid_Tipo_Act;
          oeEOPE_LevantamienExhiImpulso.fec_ini_act = tfec_ini_act;
          oeEOPE_LevantamienExhiImpulso.fec_fin_act = tfec_fin_act;
          oeEOPE_LevantamienExhiImpulso.Fec_Reg_Cel = tFec_Reg_Cel;
          oeEOPE_LevantamienExhiImpulso.Fec_Reg_BD = tFec_Reg_BD;
          oeEOPE_LevantamienExhiImpulso.CreateBy = sCreateBy;
          oeEOPE_LevantamienExhiImpulso.DateBy = tDateBy;
          oeEOPE_LevantamienExhiImpulso.ModiBy = sModiBy;
          oeEOPE_LevantamienExhiImpulso.DateModiBy = tDateModiBy;
          oeEOPE_LevantamienExhiImpulso.Validado = bValidado;



          return oeEOPE_LevantamienExhiImpulso;

      }

  /// <summary>
  /// consulta por planning los registros levantados para exhibición e impulso
  /// 02/05/2011 Magaly Jiménez
  /// </summary>
  /// <param name="sid_Plannig"></param>
  /// <returns></returns>
      public DataSet ConsultarGrillalevaExhiImpulso(string sid_Plannig, DateTime tFec_Reg_BD)
        {
            DataSet dt = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTALEVANTAMIENTOEXHIIMPULSO", sid_Plannig,  tFec_Reg_BD);

            EOPE_REPORTE_EXHB_IMPULSO odLP = new EOPE_REPORTE_EXHB_IMPULSO();
                   
     
            if (dt != null)
            {
               
                return dt;
            }
            else
            {
                return null;
            }
        }




      /// <summary>
      /// consulta por planning los registros levantados para exhibición e impulso por sku
      /// 02/05/2011 Magaly Jiménezmary>
      /// <param name="sid_Plannig"></param>
      /// <param name="tFec_Reg_BD"></param>
      /// <returns></returns>
      public DataSet ConsultarGrillalevaExhiImpulsoSKU(string sid_Plannig, DateTime tFec_Reg_BD)
        {
            DataSet dt = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTALEVANTAMIENTOEXHIIMPULSOSKU", sid_Plannig, tFec_Reg_BD);

            EOPE_REPORTE_EXHB_IMPULSO odLP = new EOPE_REPORTE_EXHB_IMPULSO();
                   
     
            if (dt != null)
            {
               
                return dt;
            }
            else
            {
                return null;
            }
        }


      /// <summary>
      /// consulta ids de combos de levantamiento de exhibición e impulos.
      /// 09/05/2011 Magaly jiménez
      /// </summary>
      /// <param name="sProduct_Name"></param>
      /// <param name="sname_Family"></param>
      /// <param name="spdv_Name"></param>
      /// <param name="sdescripcion"></param>
      /// <returns></returns>
      public DataSet ObteneridsLevantamientoEI(string sProduct_Name, string sname_Family, string spdv_Name, string sdescripcion)
      {
          DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTAIDS_LEVANTAMIENTOEXHIBIMPULSO", sProduct_Name, sname_Family, spdv_Name, sdescripcion);
          return ds;
      }
      /// <summary>
      /// actualizar levantamiento exhibición e impulso.
      /// 02/05/2011  Magaly jiménez
      /// <summary>

      public EOPE_REPORTE_EXHB_IMPULSO Actualizar_LevaExhiImpulso(int iid_rptePbl, string sClientPDV_code, string sid_ProductFamily, string sSKU,
         string sid_Tipo_Act, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, string sModiBy, DateTime tDateModiBy, bool bValidado)
      {
          DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_ACTUALIZARLENVANTAMIENTOEXHIBIMPULSO", iid_rptePbl, sClientPDV_code, sid_ProductFamily, sSKU,
         sid_Tipo_Act, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, sModiBy, tDateModiBy, bValidado);
          EOPE_REPORTE_EXHB_IMPULSO oealp = new EOPE_REPORTE_EXHB_IMPULSO();

          oealp.id_exhbiImpl = iid_rptePbl;
          oealp.ClientPDV_code = sClientPDV_code;
          oealp.id_ProductFamily = sid_ProductFamily;
          oealp.SKU = sSKU;
          oealp.id_Tipo_Act = sid_Tipo_Act;
          oealp.fec_ini_act = tfec_ini_act;
          oealp.fec_fin_act = tfec_fin_act;
          oealp.Fec_Reg_Cel = tFec_Reg_Cel;
          oealp.ModiBy = sModiBy;
          oealp.DateModiBy = tDateModiBy;
          oealp.Validado = bValidado;
       

   
          return oealp;
      }

    }
}
