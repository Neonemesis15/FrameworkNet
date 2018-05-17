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
    /// Clase: AD_AsignacionCompetidores
    /// Creada Por: Carlos Marin
    /// Fecha de Creacion: 01/12/2011
    /// Descripcion: Define metodos para maestro AD_AsignacionCompetidores
    /// </summary>
   public class AD_AsignacionCompetidores
    {
       public EAD_AsignacionCompetidores RegistrarAsignacionCompetidores(int iCompany_id, int iCompay_idCompe, bool bAA_Status, string sCreateBy,
    DateTime dDateBy, string sModiBy, DateTime dDateModiBy)
       {

           DAD_AsignacionCompetidores oDAD_AsignacionCompetidores = new DAD_AsignacionCompetidores();
           EAD_AsignacionCompetidores oEAD_AsignacionCompetidores = oDAD_AsignacionCompetidores.RegistrarAsignacionCompetidores(iCompany_id, iCompay_idCompe, bAA_Status,
                            sCreateBy, dDateBy, sModiBy, dDateModiBy);
           oDAD_AsignacionCompetidores = null;
           return oEAD_AsignacionCompetidores;

       }

       public EAD_AsignacionCompetidores RegistrarAsignacionCompetidoresTMP(string ID_COMCLIENTE, string ID_CLIENTE, string ID_COMPETIDORA, string COMCLIENTE_STATUS)
       {

           DAD_AsignacionCompetidores oDAD_AsignacionCompetidores = new DAD_AsignacionCompetidores();
           EAD_AsignacionCompetidores oEAD_AsignacionCompetidores = oDAD_AsignacionCompetidores.RegistrarAsignacionCompetidoresTMP(ID_COMCLIENTE, ID_CLIENTE, ID_COMPETIDORA,
                            COMCLIENTE_STATUS);
           oDAD_AsignacionCompetidores = null;
           return oEAD_AsignacionCompetidores;

       } 

       public DataTable ConsultarAsignacionCompetidores(string sCompany_id, string sCompay_idCompe)
       {
           DAD_AsignacionCompetidores oDAD_AsignacionCompetidores = new DAD_AsignacionCompetidores();
           DataTable dt = oDAD_AsignacionCompetidores.ConsultarAsignacionCompetidores(sCompany_id, sCompay_idCompe);

           return dt;
       }




    }


}
