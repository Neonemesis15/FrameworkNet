using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:DPLA_Supe_Objetivos_Sod_May
    /// Creada Por: Carlos Marín
    /// Fecha de Creacion: 04/11/2011
    /// Descripcion: Define los Metodos transaccionales para el maestro Supe_Objetivos_Sod_May.
    /// </summary>
   public class DPLA_Supe_Objetivos_Sod_May
    {
         private Conexion oConn;
         public DPLA_Supe_Objetivos_Sod_May()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;

        }
         /// <summary>
         ///Metodo para Registrar Supe_Objetivos_Sod_May
         /// </summary>

         public EPLA_Supe_Objetivos_Sod_May RegistrarSupe_Objetivos_Sod_May(int icompany_id, string scod_channel, int iid_malla,
     string sid_ProductCategory, int iid_Brand, int iid_ReportsPlanning, double dValue_Marca,double dValue_Categoria, bool bStatus, string sCreateBy,DateTime dDateBy
             , string sModiBy , DateTime dDateModiBy)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_REGISTRAROBJETIVOS_SOD_MAY", icompany_id, scod_channel, iid_malla,
                      sid_ProductCategory, iid_Brand, iid_ReportsPlanning, dValue_Marca, dValue_Categoria, bStatus, sCreateBy, dDateBy, sModiBy, dDateModiBy);
             EPLA_Supe_Objetivos_Sod_May oEPLA_Supe_Objetivos_Sod_May = new EPLA_Supe_Objetivos_Sod_May();

             oEPLA_Supe_Objetivos_Sod_May.company_id = icompany_id;
             oEPLA_Supe_Objetivos_Sod_May.cod_channel = scod_channel;
             oEPLA_Supe_Objetivos_Sod_May.id_malla = iid_malla;
             oEPLA_Supe_Objetivos_Sod_May.id_ProductCategory = sid_ProductCategory;
             oEPLA_Supe_Objetivos_Sod_May.id_Brand = iid_Brand;
             oEPLA_Supe_Objetivos_Sod_May.id_ReportsPlanning = iid_ReportsPlanning;
             oEPLA_Supe_Objetivos_Sod_May.Value_Marca = dValue_Marca;
             oEPLA_Supe_Objetivos_Sod_May.Value_Categoria = dValue_Categoria;
             oEPLA_Supe_Objetivos_Sod_May.Status = bStatus;
             return oEPLA_Supe_Objetivos_Sod_May;


         }

         /// <summary>
         ///Metodo para Consultar Supe_Objetivos_Sod_May
         /// </summary>
         public DataTable ConsultarSupe_Objetivos_Sod_May(int icompany_id, string scod_channel, int iid_malla,
                 string sid_ProductCategory, int iid_Brand, int iid_ReportsPlanning)
         {

             DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_CONSULTAROBJETIVOS_SOD_MAY", icompany_id, scod_channel, iid_malla, sid_ProductCategory, iid_Brand, iid_ReportsPlanning);
             EPLA_Supe_Objetivos_Sod_May oEPLA_Supe_Objetivos_Sod_May = new EPLA_Supe_Objetivos_Sod_May();

             if (dt != null)
             {
                 if (dt.Rows.Count > 0)
                 {
                     for (int i = 0; i <= dt.Rows.Count - 1; i++)
                     {
                         oEPLA_Supe_Objetivos_Sod_May.company_id = Convert.ToInt32(dt.Rows[i]["company_id"].ToString().Trim());
                         oEPLA_Supe_Objetivos_Sod_May.cod_channel = dt.Rows[i]["cod_channel"].ToString().Trim();
                         oEPLA_Supe_Objetivos_Sod_May.id_malla = Convert.ToInt32(dt.Rows[i]["id_malla"].ToString().Trim());
                         oEPLA_Supe_Objetivos_Sod_May.id_ProductCategory = dt.Rows[i]["id_ProductCategory"].ToString().Trim();
                         oEPLA_Supe_Objetivos_Sod_May.id_Brand = Convert.ToInt32(dt.Rows[i]["id_Brand"].ToString().Trim());
                         oEPLA_Supe_Objetivos_Sod_May.id_ReportsPlanning = Convert.ToInt32(dt.Rows[i]["id_ReportsPlanning"].ToString().Trim());
                         oEPLA_Supe_Objetivos_Sod_May.Value_Marca = Convert.ToDouble(dt.Rows[i]["Value_Marca"].ToString().Trim());
                         oEPLA_Supe_Objetivos_Sod_May.Value_Categoria = Convert.ToDouble(dt.Rows[i]["Value_Categoria"].ToString().Trim());
                         oEPLA_Supe_Objetivos_Sod_May.Status = Convert.ToBoolean(dt.Rows[i]["Status"].ToString().Trim());


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
         ///Metodo para Actualizar Corporaciones
         /// </summary>
         public EPLA_Supe_Objetivos_Sod_May ActualizarSupe_Objetivos_Sod_May(int id_iobjsodmay, int icompany_id, string scod_channel, int iid_malla,
     string sid_ProductCategory, int iid_Brand, int iid_ReportsPlanning, double dValue_Marca, double dValue_Categoria, bool bStatus
             , string sModiBy, DateTime dDateModiBy)
         {
             DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_ACTUALIZAROBJETIVOS_SOD_MAY", id_iobjsodmay, icompany_id, scod_channel, iid_malla, sid_ProductCategory, iid_Brand,
                 iid_ReportsPlanning, dValue_Marca, dValue_Categoria, bStatus, sModiBy, dDateModiBy);
             EPLA_Supe_Objetivos_Sod_May oEPLA_Supe_Objetivos_Sod_May = new EPLA_Supe_Objetivos_Sod_May();

             oEPLA_Supe_Objetivos_Sod_May.company_id = icompany_id;
             oEPLA_Supe_Objetivos_Sod_May.cod_channel = scod_channel;
             oEPLA_Supe_Objetivos_Sod_May.id_malla = iid_malla;
             oEPLA_Supe_Objetivos_Sod_May.id_ProductCategory = sid_ProductCategory;
             oEPLA_Supe_Objetivos_Sod_May.id_Brand = iid_Brand;
             oEPLA_Supe_Objetivos_Sod_May.id_ReportsPlanning = iid_ReportsPlanning;
             oEPLA_Supe_Objetivos_Sod_May.Value_Marca = dValue_Marca;
             oEPLA_Supe_Objetivos_Sod_May.Value_Categoria = dValue_Categoria;
             oEPLA_Supe_Objetivos_Sod_May.Status = bStatus;
             return oEPLA_Supe_Objetivos_Sod_May;
         }





    }
}
