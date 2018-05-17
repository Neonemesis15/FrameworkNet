using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EAD_AsignacionCompetidores
    /// Creada Por:         Carlos Marín
    /// Fecha de Creación:  01/12/2011
    /// </summary>
   public class EAD_AsignacionCompetidores
   {

       #region Atributos
       int lAA_idAsignacionCompe;
       int lCompany_id;
       int lCompay_idCompe;
       bool lAA_Status;

      
       #endregion

       #region Propiedades

       public int AA_idAsignacionCompe
       {
           get { return lAA_idAsignacionCompe; }
           set { lAA_idAsignacionCompe = value; }
       }
       public int Company_id
       {
           get { return lCompany_id; }
           set { lCompany_id = value; }
       }
       public int Compay_idCompe
       {
           get { return lCompay_idCompe; }
           set { lCompay_idCompe = value; }
       }
       public bool AA_Status
       {
           get { return lAA_Status; }
           set { lAA_Status = value; }
       }

       #endregion


   }
}
