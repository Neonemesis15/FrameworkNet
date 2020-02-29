using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{  /// <summary>
    /// CreateBy: Ing. Carlos Alberto Hernández
    /// CreateDate:02/05/2009
    /// Description: Define las propiedades de la clase Modulo
    /// Requerimiento:
    /// </summary>
   public  class EModulo
    {
       public EModulo() { 
       
       //Se define el constructor por defecto
       
       }
       private string lModuloid;
       private string lModuloName;
       private string lModuloDescription;
       private bool lModuloStatus;
       private string lModuloCreateBy;
       private string lModuloDateBy;
       private string lModuloModiBy;
       private string lModuloDateModiBy;


       public string Moduloid {
           get {return this.lModuloid;}
           set { this.lModuloid = value; }
       }

       public string ModuloName
       {
           get { return this.lModuloName; }
           set { this.lModuloName = value; }
       }

       public string ModuloDescription
       {
           get { return this.lModuloDescription; }
           set { this.lModuloDescription = value; }
       }

       public bool ModuloStatus
       {

           get { return this.lModuloStatus; }
           set { this.lModuloStatus = value; }
       }

       public string ModuloCreateBy
       {
           get { return this.lModuloCreateBy; }
           set { this.lModuloCreateBy = value; }
       }


       public string ModuloDateBy
       {
           get { return this.lModuloDateBy; }
           set { this.lModuloDateBy = value; }
       }

       public string ModuloModiBy
       {
           get { return this.lModuloModiBy; }
           set { this.lModuloModiBy = value; }
       }

       public string ModuloDateModiBy
       {
           get { return this.lModuloDateModiBy; }
           set { this.lModuloDateModiBy = value; }
       }
    }
}
