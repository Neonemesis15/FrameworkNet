using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;
namespace Lucky.Business.Common.Application
{
   public class OPE_REPORTE_PUBLICACION
    {
       public OPE_REPORTE_PUBLICACION()
        {
            //Se define el constructor por defecto
        }

    /// <summary>
    /// permite registra información de levantamiento de publicaciones
    /// 28/04/2011  Magaly Jiménez
    /// </summary>
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
       public EOPE_REPORTE_PUBLICACION RegistrarINFOLevantaPublicacion(int iPerson_id, string sid_Plannig, int icompany_id, int inodeComercial_id, string sid_ProductFamily, string sSKU,
         int iid_tipoPublicacion, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, DateTime tFec_Reg_BD, string sCreateBy, DateTime tDateBy, string sModiBy, DateTime tDateModiBy, bool bValidado,  string spromocionPuntual,
        decimal dPVP, decimal dOferta)
       {
           DOPE_REPORTE_PUBLICACION odrOPE_levanPublicacion = new DOPE_REPORTE_PUBLICACION();
           EOPE_REPORTE_PUBLICACION oeOPE_levanPublicacion = odrOPE_levanPublicacion.RegistrarLevantamientoPublicacion(iPerson_id, sid_Plannig, icompany_id, inodeComercial_id, sid_ProductFamily, sSKU,
          iid_tipoPublicacion, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, tFec_Reg_BD, sCreateBy, tDateBy, sModiBy, tDateModiBy, bValidado, spromocionPuntual, dPVP, dOferta);
          odrOPE_levanPublicacion = null;
           return oeOPE_levanPublicacion;
       }

       /// <summary>
       /// consulta grilla con registros en levantamiento de publicaciones.
       /// 28/04/2011  Magaly Jiménez
       /// </summary>
       /// <param name="sid_Plannig"></param>
       /// <returns></returns>
       public DataSet ConsultarGrillaLevaPublicaciones(string sid_Plannig, DateTime tFec_Reg_BD)
       {
           DOPE_REPORTE_PUBLICACION odlp = new DOPE_REPORTE_PUBLICACION();
           EOPE_REPORTE_PUBLICACION oelevapublicacion = new EOPE_REPORTE_PUBLICACION();

           DataSet dtLevantaPublicacion = odlp.ConsultarGrillalevaPublicacion(sid_Plannig, tFec_Reg_BD);
           odlp = null;
           return dtLevantaPublicacion;
       }

       /// <summary>
       /// consulta grilla con registros en levantamiento de publicaciones.por SKU
       /// 06/05/2011  Magaly Jiménez
       /// </summary>
       /// <param name="sid_Plannig"></param>
       /// <param name="tFec_Reg_BD"></param>
       /// <returns></returns>
       public DataSet ConsultarGrillaLevaPublicacionesSKU(string sid_Plannig, DateTime tFec_Reg_BD)
       {
           DOPE_REPORTE_PUBLICACION odlp = new DOPE_REPORTE_PUBLICACION();
           EOPE_REPORTE_PUBLICACION oelevapublicacion = new EOPE_REPORTE_PUBLICACION();

           DataSet dtLevantaPublicacion = odlp.ConsultarGrillalevaPublicacionSKU(sid_Plannig, tFec_Reg_BD);
           odlp = null;
           return dtLevantaPublicacion;
       }


       /// <summary>
       /// Obtiene ids de levantamiento de publicaciones
       /// 07/05/2011  Magaly Jiménez
       /// </summary>
       /// <param name="scamino"></param>
       /// <param name="sProduct_Name"></param>
       /// <param name="sname_Family"></param>
       /// <param name="scommercialNodeName"></param>
       /// <param name="sNombre"></param>
       /// <returns></returns>
       public DataSet ObteneridsLevantamientoP( string sProduct_Name, string sname_Family, string scommercialNodeName, string sNombre)
       {
           EOPE_REPORTE_PUBLICACION oeidslevantamientoP = new EOPE_REPORTE_PUBLICACION();
           DOPE_REPORTE_PUBLICACION oeidslevantamiento1P = new DOPE_REPORTE_PUBLICACION();
           DataSet dsidsLevantamientoP = oeidslevantamiento1P.ObteneridsLevantamientoP( sProduct_Name, sname_Family, scommercialNodeName, sNombre);
           oeidslevantamiento1P = null;
           return dsidsLevantamientoP;
       }


       /// <summary>
       ///  actualizar levantamiento publicaciones.
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
       public EOPE_REPORTE_PUBLICACION Actualizar_levaPublicacion(int iid_rptePbl, int inodeComercial_id, string sid_ProductFamily, string sSKU,
         int iid_tipoPublicacion, DateTime tfec_ini_act, DateTime tfec_fin_act, DateTime tFec_Reg_Cel, string sModiBy, DateTime tDateModiBy, bool bValidado, string spromocionPuntual,
        decimal dPVP, decimal dOferta)
       {
           DOPE_REPORTE_PUBLICACION odapLEPPI = new DOPE_REPORTE_PUBLICACION();

           EOPE_REPORTE_PUBLICACION oeaAPLevPubli = odapLEPPI.Actualizar_LevaPublicacion(iid_rptePbl, inodeComercial_id, sid_ProductFamily, sSKU,
         iid_tipoPublicacion, tfec_ini_act, tfec_fin_act, tFec_Reg_Cel, sModiBy, tDateModiBy, bValidado, spromocionPuntual,
         dPVP, dOferta);

           odapLEPPI = null;
           return oeaAPLevPubli;
       }
    }
}
