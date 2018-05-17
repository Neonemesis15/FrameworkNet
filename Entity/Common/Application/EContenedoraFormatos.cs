using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase               : EContenedora de Formatos
    /// Creada Por          : Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación   : 07/08/2009
    /// Requerimiento       : <>
    /// Modificacion        : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>

   public class EContenedoraFormatos
    {
       public EContenedoraFormatos() { 
       
       //Se define el constructor por defecto
       
       
       }

       //Se definen los Atributos
       private int lidcontenedor;
       private string lidPlanning;
       private int lidcodPoint;
       private int lcodItem;
       private int lubicacion;
       private int liddesignFor;
       private bool lcontenstatus;
       private string lcontendorCreateBy;
       private DateTime lcontenedorDateBy;
       private string lcontenedorModiBy;
       private DateTime lcontenedorDateModiBy;

       //Se definen las Porpiedades de los Atributos de la Clase

       public int idcontenedor {
           get { return this.lidcontenedor; }
           set { this.lidcontenedor = value; }
       
       
       
       }

       public string idPlanning
       {
           get { return this.lidPlanning; }
           set { this.lidPlanning = value; }



       }

       public int idcodPoint
       {
           get { return this.lidcodPoint; }
           set { this.lidcodPoint = value; }



       }

       public int ubicacion
       {
           get { return this.lubicacion; }
           set { this.lubicacion = value; }



       }

       public int iddesignFor
       {
           get { return this.liddesignFor; }
           set { this.lubicacion = value; }



       }
       public bool contenstatus {
           get { return this.lcontenstatus; }
           set { this.lcontenstatus = value; }
       
       
       }

       public int codItem
       {
           get { return this.lcodItem; }
           set { this.lcodItem = value; }



       }

       public string contendorCreateBy {
           get { return this.lcontendorCreateBy; }
           set { this.lcontendorCreateBy = value; }
       
       
       
       }

       public DateTime contenedorDateBy {
           get { return this.lcontenedorDateBy; }
           set { this.lcontenedorDateBy = value; }       
       
       
       }

       public string contenedorModiBy
       {
           get { return this.lcontenedorModiBy; }
           set { this.lcontenedorModiBy = value; }



       }

       public DateTime contenedorDateModiBy
       {
           get { return this.lcontenedorDateModiBy; }
           set { this.lcontenedorDateModiBy = value; }


       }
    }
}
