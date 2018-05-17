using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
  public  class OPE_REPORTE_EXHB_IMPULSO
    {

      public OPE_REPORTE_EXHB_IMPULSO()
        {
            //Se define el constructor por defecto
        }

      /// <summary>
      /// inserta datos de levantamiento de exhibición e impuloso
      /// 02/05/2011 Magaly jiménez
      /// </summary>
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
      public EOPE_REPORTE_EXHB_IMPULSO RegistrarINFOLevantaexhiimpulso(int iPerson_id, string sid_Plannig, int icompany_id, string sClientPDV_code, string sid_ProductFamily, string sSKU,
         string sid_Tipo_Act, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, DateTime tFec_Reg_BD, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy, bool bValidado)
      {
          DOPE_REPORTE_EXHB_IMPULSO odrOPE_levanexhicimpulso = new DOPE_REPORTE_EXHB_IMPULSO();
          EOPE_REPORTE_EXHB_IMPULSO oeOPE_levanexhiimpulso = odrOPE_levanexhicimpulso.RegistrarLevantamientoExhbImpulso(iPerson_id, sid_Plannig, icompany_id, sClientPDV_code, sid_ProductFamily, sSKU,
        sid_Tipo_Act, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, tFec_Reg_BD, sCreateBy, tDateBy, sModiBy, tDateModiBy, bValidado);
          odrOPE_levanexhicimpulso = null;
          return oeOPE_levanexhiimpulso;
      }

      /// <summary>
      ///  consulta por planning los registros levantados para exhibición e impulso
      /// 02/05/2011 Magaly Jiménez
      /// </summary>
      /// <param name="sid_Plannig"></param>
      /// <returns></returns>
      public DataSet ConsultarGrillaLevaExhiImpulso(string sid_Plannig, DateTime tFec_Reg_BD)
      {

          DOPE_REPORTE_EXHB_IMPULSO odlp = new DOPE_REPORTE_EXHB_IMPULSO();
          EOPE_REPORTE_EXHB_IMPULSO oelevapublicacion = new EOPE_REPORTE_EXHB_IMPULSO();

          DataSet dtLevantaPublicacion = odlp.ConsultarGrillalevaExhiImpulso(sid_Plannig, tFec_Reg_BD);
          odlp = null;
          return dtLevantaPublicacion;
      }

      /// <summary>
      /// consulta por planning los registros levantados para exhibición e impulso
      /// 02/05/2011 Magaly Jiménez
      /// </summary>
      /// <param name="sid_Plannig"></param>
      /// <param name="tFec_Reg_BD"></param>
      /// <returns></returns>
      public DataSet ConsultarGrillaLevaExhiImpulsoSKU(string sid_Plannig, DateTime tFec_Reg_BD)
      {

          DOPE_REPORTE_EXHB_IMPULSO odlp = new DOPE_REPORTE_EXHB_IMPULSO();
          EOPE_REPORTE_EXHB_IMPULSO oelevapublicacion = new EOPE_REPORTE_EXHB_IMPULSO();

          DataSet dtLevantaPublicacion = odlp.ConsultarGrillalevaExhiImpulsoSKU(sid_Plannig, tFec_Reg_BD);
          odlp = null;
          return dtLevantaPublicacion;
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
          EOPE_REPORTE_PUBLICACION oeidslevantamientoP = new EOPE_REPORTE_PUBLICACION();
          DOPE_REPORTE_PUBLICACION oeidslevantamiento1P = new DOPE_REPORTE_PUBLICACION();
          DataSet dsidsLevantamientoP = oeidslevantamiento1P.ObteneridsLevantamientoP(sProduct_Name, sname_Family, spdv_Name, sdescripcion);
          oeidslevantamiento1P = null;
          return dsidsLevantamientoP;
      }
/// <summary>
/// actualizar levantamiento exhibición e impulso.
/// 02/05/2011  Magaly jiménez
/// </summary>
/// <param name="iid_rptePbl"></param>
/// <param name="sClientPDV_code"></param>
/// <param name="sid_ProductFamily"></param>
/// <param name="sSKU"></param>
/// <param name="sid_Tipo_Act"></param>
/// <param name="tfec_ini_act"></param>
/// <param name="tfec_fin_act"></param>
/// <param name="tFec_Reg_Cel"></param>
/// <param name="sModiBy"></param>
/// <param name="tDateModiBy"></param>
/// <param name="bValidado"></param>
/// <returns></returns>
      public EOPE_REPORTE_EXHB_IMPULSO Actualizar_levaExhibImpulos(int iid_rptePbl, string sClientPDV_code, string sid_ProductFamily, string sSKU,
         string sid_Tipo_Act, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, string sModiBy, DateTime tDateModiBy, bool bValidado)
      {
          DOPE_REPORTE_EXHB_IMPULSO odapLEPPI = new DOPE_REPORTE_EXHB_IMPULSO();

          EOPE_REPORTE_EXHB_IMPULSO oeaAPLevPubli = odapLEPPI.Actualizar_LevaExhiImpulso(iid_rptePbl, sClientPDV_code, sid_ProductFamily, sSKU,
         sid_Tipo_Act, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, sModiBy, tDateModiBy, bValidado);

          odapLEPPI = null;
          return oeaAPLevPubli;
      }
    }
}
