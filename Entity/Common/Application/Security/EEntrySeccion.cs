using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application.Security
{  /// <summary>
    /// Clase: EntrySeccion
    /// Creada por: Ing. Carlos Alberto Hernandez Rincon
    /// Fecha de Creacion:02/05/2009
    /// Descripcion: Permite validar los numeros de accesos de los usuarios
    /// a SIGE
    /// Requerimiento:
    /// </summary>

    public class EEntrySeccion
    {
       public EEntrySeccion()  {
       ///Define el constructor por defecto
       
       }
       private int lidentry;
       private string lseccionname;
       private string lentryCreateBy;
       private string lentryDateBy;
       private string lentryModiBy;
       private string lentryDatemodi;

       public int identry {

           get { return this.lidentry; }
           set { this.lidentry = value; }
       
       
       }
       public string seccionname
       {

           get { return this.lseccionname; }
           set { this.lseccionname = value; }
       }

       public string entryCreateBy
       {

           get { return this.lentryCreateBy; }
           set { this.lentryCreateBy = value; }
       }

       public string entryDateBy
       {

           get { return this.lentryDateBy; }
           set { this.lentryDateBy = value; }
       }

       public string entryModiBy
       {

           get { return this.lentryModiBy; }
           set { this.lentryModiBy = value; }
       }

       public string entryDatemodi
       {

           get { return this.lentryDatemodi; }
           set { this.lentryDatemodi = value; }
       }



    }
}
