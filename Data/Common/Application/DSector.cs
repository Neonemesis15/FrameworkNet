using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
        /// <summary>
    /// Descripción métodos para Sector
    /// CreateBy: Ing. Magalu Jiménez
    /// CreateDate: 15-09-2010
    /// Requerimiento:
    /// 
    public class DSector
    {

         private Conexion oConn;
         public DSector()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        ///  permite registrar sectores de Puntos de venta
        /// 15/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sSector"></param>
        /// <param name="iid_malla"></param>
        /// <param name="bSector_Status"></param>
        /// <param name="sSector_CreateBy"></param>
        /// <param name="tSector_DateBy"></param>
        /// <param name="sSector_ModiBy"></param>
        /// <param name="tSector_DateModiBy"></param>
         /// <returns>oerSector</returns>
         public ESector RegistrarSector(string sSector, int iid_malla, bool bSector_Status,
           string sSector_CreateBy, DateTime tSector_DateBy, string sSector_ModiBy, DateTime tSector_DateModiBy)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERSECTOR", sSector, iid_malla, bSector_Status,
             sSector_CreateBy, tSector_DateBy, sSector_ModiBy, tSector_DateModiBy);
             ESector oerSector = new ESector();
             oerSector.Sector = sSector;
             oerSector.id_malla = iid_malla;
             oerSector.Sector_Status = bSector_Status;
             oerSector.Sector_CreateBy = sSector_CreateBy;
             oerSector.Sector_DateBy = tSector_DateBy;
             oerSector.Sector_ModiBy = sSector_ModiBy;
             oerSector.Sector_DateModiBy = tSector_DateModiBy;
             return oerSector;
         }
        /// <summary>
        /// permite Consultar los sectores de puntos de venta
        /// 15/09/2010 Magaly Jiménez
         ///modificación: se agrega parametro iCompany_id
         /// 11/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="sSector"></param>
        /// <param name="iid_malla"></param>
         /// <returns>dt</returns>
         public DataTable ObtenerSector(int iid_malla, string sSector, int iCompany_id)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTASECTORES", iid_malla, sSector, iCompany_id);
             ESector oeSector = new ESector();
             EMalla oeMallas=new EMalla();
             if (dt != null)
             {
                 if (dt.Rows.Count > 0)
                 {
                     for (int i = 0; i <= dt.Rows.Count - 1; i++)
                     {
                         oeSector.id_sector = Convert.ToInt32(dt.Rows[i]["id_sector"].ToString().Trim());
                         oeMallas.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                         oeSector.id_malla = Convert.ToInt32(dt.Rows[i]["id_malla"].ToString().Trim());
                         oeSector.Sector = dt.Rows[i]["Sector"].ToString().Trim();
                         oeSector.Sector_Status = Convert.ToBoolean(dt.Rows[i]["Sector_Status"].ToString().Trim());
                         //oeSector.Sector_CreateBy = dt.Rows[i]["Sector_CreateBy"].ToString().Trim();
                         //oeSector.Sector_DateBy = Convert.ToDateTime(dt.Rows[i]["Sector_DateBy"].ToString().Trim());
                         //oeSector.Sector_ModiBy = dt.Rows[i]["Sector_ModiBy"].ToString().Trim();
                         //oeSector.Sector_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Sector_DateModiBy"].ToString().Trim());
                
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
        /// Permite Actualizar Sector de Puntos de Venta
        /// 15/09/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iid_sector"></param>
        /// <param name="iid_malla"></param>
        /// <param name="sSector"></param>
        /// <param name="bSector_Status"></param>
        /// <param name="sSector_ModiBy"></param>
        /// <param name="tSector_DateModiBy"></param>
         /// <returns>oeaSector</returns>
         public ESector Actualizar_Sector(int iid_sector, int iid_malla, string sSector, bool bSector_Status,
             string sSector_ModiBy, DateTime tSector_DateModiBy)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_SECTOR", iid_sector, iid_malla, sSector, bSector_Status,
             sSector_ModiBy, tSector_DateModiBy);
             ESector oeaSector = new ESector();
             oeaSector.id_sector = iid_sector;
             oeaSector.id_malla = iid_malla;
             oeaSector.Sector = sSector;
             oeaSector.Sector_Status = bSector_Status;
             oeaSector.Sector_ModiBy = sSector_ModiBy;
             oeaSector.Sector_DateModiBy = tSector_DateModiBy;
            
             return oeaSector;
         }
    }
}
