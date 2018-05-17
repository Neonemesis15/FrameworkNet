using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;


namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: PLA_Supe_Objetivos_Sod_May
    /// Creada Por: Carlos Marin
    /// Fecha de Creacion: 04/11/2011
    /// Descripcion: Define metodos para maestro PLA_Supe_Objetivos_Sod_May
    /// </summary>
   public class PLA_Supe_Objetivos_Sod_May
    {
       public EPLA_Supe_Objetivos_Sod_May RegistrarSupe_Objetivos_Sod_May(int icompany_id, string scod_channel, int iid_malla,
     string sid_ProductCategory, int iid_Brand, int iid_ReportsPlanning, double dValue_Marca, double dValue_Categoria, bool bStatus, string sCreateBy, DateTime dDateBy
             , string sModiBy, DateTime dDateModiBy)
       {
           DPLA_Supe_Objetivos_Sod_May oDPLA_Supe_Objetivos_Sod_May = new DPLA_Supe_Objetivos_Sod_May();
           EPLA_Supe_Objetivos_Sod_May oEPLA_Supe_Objetivos_Sod_May = oDPLA_Supe_Objetivos_Sod_May.RegistrarSupe_Objetivos_Sod_May(icompany_id, scod_channel, iid_malla,
                      sid_ProductCategory, iid_Brand, iid_ReportsPlanning, dValue_Marca, dValue_Categoria, bStatus, sCreateBy, dDateBy, sModiBy, dDateModiBy);
           oDPLA_Supe_Objetivos_Sod_May = null;
           return oEPLA_Supe_Objetivos_Sod_May;

       }

       public DataTable ConsultarSupe_Objetivos_Sod_May(int icompany_id, string scod_channel, int iid_malla,
                 string sid_ProductCategory, int iid_Brand, int iid_ReportsPlanning)
       {
           DPLA_Supe_Objetivos_Sod_May oDPLA_Supe_Objetivos_Sod_May = new DPLA_Supe_Objetivos_Sod_May();
           DataTable dt = oDPLA_Supe_Objetivos_Sod_May.ConsultarSupe_Objetivos_Sod_May(icompany_id, scod_channel, iid_malla, sid_ProductCategory, iid_Brand, iid_ReportsPlanning);
           return dt;

       }

       public EPLA_Supe_Objetivos_Sod_May ActualizarSupe_Objetivos_Sod_May(int id_iobjsodmay, int icompany_id, string scod_channel, int iid_malla,
     string sid_ProductCategory, int iid_Brand, int iid_ReportsPlanning, double dValue_Marca, double dValue_Categoria, bool bStatus
             , string sModiBy, DateTime dDateModiBy)
       {
           DPLA_Supe_Objetivos_Sod_May oDPLA_Supe_Objetivos_Sod_May = new DPLA_Supe_Objetivos_Sod_May();
           EPLA_Supe_Objetivos_Sod_May oEPLA_Supe_Objetivos_Sod_May = oDPLA_Supe_Objetivos_Sod_May.ActualizarSupe_Objetivos_Sod_May(id_iobjsodmay, icompany_id, scod_channel, iid_malla, sid_ProductCategory, iid_Brand,
                 iid_ReportsPlanning, dValue_Marca, dValue_Categoria, bStatus, sModiBy, dDateModiBy);
           oDPLA_Supe_Objetivos_Sod_May = null;
           return oEPLA_Supe_Objetivos_Sod_May;

       }

    }
}
