using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
   public  class DOPE_REPORTE_MATERIAL_POP
    {
       private Conexion oConn;
       public DOPE_REPORTE_MATERIAL_POP()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

       /// <summary>
       /// inserta levantamiento de material pop
       /// 02/05/2011 Magaly jiménez
       /// </summary>
       /// <param name="iPerson_id"></param>
       /// <param name="sid_Plannig"></param>
       /// <param name="icompany_id"></param>
       /// <param name="sClientPDV_code"></param>
       /// <param name="iId_brand"></param>
       /// <param name="iid_MPointOfPurchase"></param>
       /// <param name="sid_Tipo_Prom"></param>
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
       public EOPE_REPORTE_MATERIAL_POP RegistrarLevantamientoMaterialPOP(int iPerson_id, string sid_Plannig, int icompany_id, string sClientPDV_code, int iId_brand, int iid_MPointOfPurchase, string sid_Tipo_Prom,
         DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, DateTime tFec_Reg_BD, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy, bool bValidado)
       {
           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_REGISTEMATERIALPOP", iPerson_id, sid_Plannig, icompany_id, sClientPDV_code, iId_brand, iid_MPointOfPurchase, sid_Tipo_Prom,
         tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, tFec_Reg_BD, sCreateBy, tDateBy, sModiBy, tDateModiBy, bValidado);

           EOPE_REPORTE_MATERIAL_POP oeEOPE_Levantamienmaterialpop = new EOPE_REPORTE_MATERIAL_POP();


           oeEOPE_Levantamienmaterialpop.Person_id = iPerson_id;
           oeEOPE_Levantamienmaterialpop.id_Plannig = sid_Plannig;
           oeEOPE_Levantamienmaterialpop.company_id = icompany_id;
           oeEOPE_Levantamienmaterialpop.ClientPDV_code = sClientPDV_code;
           oeEOPE_Levantamienmaterialpop.Id_brand = iId_brand;
           oeEOPE_Levantamienmaterialpop.id_MPointOfPurchase = iid_MPointOfPurchase;
           oeEOPE_Levantamienmaterialpop.id_Tipo_Prom = sid_Tipo_Prom;
           oeEOPE_Levantamienmaterialpop.fec_ini_act = tfec_ini_act;
           oeEOPE_Levantamienmaterialpop.fec_fin_act = tfec_fin_act;
           oeEOPE_Levantamienmaterialpop.Fec_Reg_Cel = tFec_Reg_Cel;
           oeEOPE_Levantamienmaterialpop.Fec_Reg_BD = tFec_Reg_BD;
           oeEOPE_Levantamienmaterialpop.CreateBy = sCreateBy;
           oeEOPE_Levantamienmaterialpop.DateBy = tDateBy;
           oeEOPE_Levantamienmaterialpop.ModiBy = sModiBy;
           oeEOPE_Levantamienmaterialpop.DateModiBy = tDateModiBy;
           oeEOPE_Levantamienmaterialpop.Validado = bValidado;



           return oeEOPE_Levantamienmaterialpop;

       }



       /// <summary>
       /// Consulta levantamiento de material pop
       /// 02/05/2011 Magaly jiménez
       /// </summary>
       /// <param name="sid_Plannig"></param>
       /// <returns></returns>
       public DataSet ConsultarGrillalevaMaterialPOP(string sid_Plannig, DateTime tFec_Reg_BD)
       {
           DataSet dt = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTALEVANTAMIENTOMATERIALPOP", sid_Plannig, tFec_Reg_BD);

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
       /// consulta id de levantamiento de material POP
       /// 11/05/2011  Magaly jiménez
       /// </summary>
       /// <param name="sName_Brand"></param>
       /// <param name="spdv_Name"></param>
       /// <param name="snombre"></param>
       /// <param name="sPOP_name"></param>
       /// <returns></returns>
       public DataSet ObteneridsLevantamientoMaterialPOP(string sName_Brand, string spdv_Name, string snombre, string sPOP_name)
       {
           DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_OPE_CONSULTAIDS_LEVANTAMIENTOMATERIALPOP", sName_Brand, spdv_Name, snombre, sPOP_name);
           return ds;
       }
       /// <summary>
       ///  Actualizar levantamiento de material pop
       /// 02/05/2011 Magaly jiménez
       /// </summary>
       /// <param name="iid_rpteMatPOP"></param>
       /// <param name="sClientPDV_code"></param>
       /// <param name="iId_brand"></param>
       /// <param name="iid_MPointOfPurchase"></param>
       /// <param name="sid_Tipo_Prom"></param>
       /// <param name="tfec_ini_act"></param>
       /// <param name="tfec_fin_act"></param>
       /// <param name="tFec_Reg_Cel"></param>
       /// <param name="sModiBy"></param>
       /// <param name="tDateModiBy"></param>
       /// <param name="bValidado"></param>
       /// <returns></returns>
       public EOPE_REPORTE_MATERIAL_POP Actualizar_LevaMaterialPOP(int iid_rpteMatPOP, string sClientPDV_code, int iId_brand, int iid_MPointOfPurchase, string sid_Tipo_Prom,  DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, string sModiBy, DateTime tDateModiBy, bool bValidado)
       {
           DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_ACTUALIZARLENVANTAMIENTOMATERIALPOP", iid_rpteMatPOP, sClientPDV_code, iId_brand, iid_MPointOfPurchase,
           sid_Tipo_Prom, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, sModiBy, tDateModiBy, bValidado);
           EOPE_REPORTE_MATERIAL_POP oealp = new EOPE_REPORTE_MATERIAL_POP();

           oealp.id_rpteMatPOP = iid_rpteMatPOP;
           oealp.ClientPDV_code = sClientPDV_code;
           oealp.Id_brand = iId_brand;
           oealp.id_MPointOfPurchase = iid_MPointOfPurchase;
           oealp.id_Tipo_Prom = sid_Tipo_Prom;
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
