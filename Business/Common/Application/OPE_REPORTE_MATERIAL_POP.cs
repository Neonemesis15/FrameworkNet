using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;


namespace Lucky.Business.Common.Application
{
    public  class OPE_REPORTE_MATERIAL_POP
    {
        public OPE_REPORTE_MATERIAL_POP()
        {
            //Se define el constructor por defecto
        }

        /// <summary>
        ///  inserta levantamiento de material pop
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
        public EOPE_REPORTE_MATERIAL_POP RegistrarINFOLevantaMaterialPOP(int iPerson_id, string sid_Plannig, int icompany_id, string sClientPDV_code, int iId_brand, int iid_MPointOfPurchase, string sid_Tipo_Prom,
         DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, DateTime tFec_Reg_BD, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy, bool bValidado)
        {
            DOPE_REPORTE_MATERIAL_POP odrOPE_levaneMaterialPOP = new DOPE_REPORTE_MATERIAL_POP();

            EOPE_REPORTE_MATERIAL_POP oeOPE_levaneMaterialPOP= odrOPE_levaneMaterialPOP.RegistrarLevantamientoMaterialPOP(iPerson_id, sid_Plannig, icompany_id, sClientPDV_code, iId_brand, iid_MPointOfPurchase, sid_Tipo_Prom,
           tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, tFec_Reg_BD, sCreateBy, tDateBy, sModiBy, tDateModiBy, bValidado);
            odrOPE_levaneMaterialPOP = null;
            return oeOPE_levaneMaterialPOP;
        }

        /// <summary>
        /// Consulta levantamiento de material pop
        /// 02/05/2011 Magaly jiménez
        /// </summary>
        /// <param name="sid_Plannig"></param>
        /// <returns></returns>
        public DataSet ConsultarGrillaLevaMaterialPOP(string sid_Plannig, DateTime tFec_Reg_BD)
        {
            DOPE_REPORTE_MATERIAL_POP odlp = new DOPE_REPORTE_MATERIAL_POP();
            EOPE_REPORTE_MATERIAL_POP oelevapublicacion = new EOPE_REPORTE_MATERIAL_POP();


            DataSet dtLevantaMaterialPOP = odlp.ConsultarGrillalevaMaterialPOP(sid_Plannig, tFec_Reg_BD);
            odlp = null;
            return dtLevantaMaterialPOP;
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
            EOPE_REPORTE_MATERIAL_POP oeidslevantamietoMPOP = new EOPE_REPORTE_MATERIAL_POP();
            DOPE_REPORTE_MATERIAL_POP oeidslevantamiento1P = new DOPE_REPORTE_MATERIAL_POP();
            DataSet dsidsLevantamientoP = oeidslevantamiento1P.ObteneridsLevantamientoMaterialPOP(sName_Brand, spdv_Name, snombre, sPOP_name);
            oeidslevantamiento1P = null;
            return dsidsLevantamientoP;
        }

        /// <summary>
        /// Actualizar levantamiento de material pop
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
        public EOPE_REPORTE_MATERIAL_POP Actualizar_levaMaterialPOP(int iid_rpteMatPOP, string sClientPDV_code, int iId_brand, int iid_MPointOfPurchase, string sid_Tipo_Prom, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, string sModiBy, DateTime tDateModiBy, bool bValidado)
        {
          
            DOPE_REPORTE_MATERIAL_POP odapLEPPI = new DOPE_REPORTE_MATERIAL_POP();
            EOPE_REPORTE_MATERIAL_POP oeaAPLevMaterialPOP = odapLEPPI.Actualizar_LevaMaterialPOP(iid_rpteMatPOP, sClientPDV_code, iId_brand, iid_MPointOfPurchase,
           sid_Tipo_Prom, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, sModiBy, tDateModiBy, bValidado);

            odapLEPPI = null;
            return oeaAPLevMaterialPOP;
        }
    }
}
