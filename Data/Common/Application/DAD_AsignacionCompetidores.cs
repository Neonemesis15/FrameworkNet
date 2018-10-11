using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase:DAD_AsignacionCompetidores
    /// Creada Por: Carlos Marín
    /// Fecha de Creacion: 01/12/2011
    /// Descripcion: Define los Metodos transaccionales para el maestro DAD_AsignacionCompetidores.
    /// </summary>
   public class DAD_AsignacionCompetidores
    {
               private Conexion oConn;
               public DAD_AsignacionCompetidores()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;

        }





   public EAD_AsignacionCompetidores RegistrarAsignacionCompetidores(int iCompany_id, int iCompay_idCompe, bool bAA_Status, string sCreateBy,
    DateTime dDateBy, string sModiBy, DateTime dDateModiBy)
     {
        DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTRAR_ASIGNACIONCOMPETIDORES", iCompany_id, iCompay_idCompe, bAA_Status,
                sCreateBy, dDateBy, sModiBy, dDateModiBy);
        EAD_AsignacionCompetidores oEAD_AsignacionCompetidores = new EAD_AsignacionCompetidores();

        oEAD_AsignacionCompetidores.AA_idAsignacionCompe = Convert.ToInt32(dt.Rows[0]["AA_idAsignacionCompe"].ToString());
        oEAD_AsignacionCompetidores.AA_Status = bAA_Status;
        oEAD_AsignacionCompetidores.Company_id = iCompany_id;
        oEAD_AsignacionCompetidores.Compay_idCompe = iCompay_idCompe;

        return oEAD_AsignacionCompetidores;

      }


   public EAD_AsignacionCompetidores RegistrarAsignacionCompetidoresTMP(string ID_COMCLIENTE, string ID_CLIENTE, string ID_COMPETIDORA, string COMCLIENTE_STATUS)
   {
       Conexion cn = new Conexion(2);

       DataTable dt = cn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTRAR_TBL_CLIENTE_COMPETIDORA", ID_COMCLIENTE, ID_CLIENTE, ID_COMPETIDORA,
                COMCLIENTE_STATUS);
       EAD_AsignacionCompetidores oEAD_AsignacionCompetidores = new EAD_AsignacionCompetidores();


       return oEAD_AsignacionCompetidores;

   }



    public DataTable ConsultarAsignacionCompetidores(string sCompany_id, string sCompay_idCompe)
    {
        DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_SELECT_AD_AsignacionCompetidores", sCompany_id, sCompay_idCompe);

        return dt;
    }


    }
}
