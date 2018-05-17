using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{

    /// <summary>
    /// Clase: EOperating__Supervisor__Assignment
    /// Creada Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha:18/12/2009
    /// Descripción: Define los atributos y propiedades de la Clase Operating__Supervisor__Assignment
    /// Requerimiento<>
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
    
   public  class EOperating__Supervisor__Assignment
    {
       public EOperating__Supervisor__Assignment() { 
       //Se DeClara el constructor por defecto
       
       }

       private int lidasigPer;
       private string lidplanning;
       private int lPersonidSupe;
       private int lPersonidOpera;
       private bool lAsigmenPerstatus;
       private string lAsigmenPerCreateBy;
       private DateTime lAsigmenPerDateBy;
       private string lAsigmenPerModiBy;
       private DateTime lAsigmenPerDateModiBy;

       public int idasigPer {
           get { return this.lidasigPer; }
           set { this.lidasigPer = value; }
       
       
       
       }

       public string idplanning
       {
           get { return this.lidplanning; }
           set { this.lidplanning = value; }



       }


       public int PersonidSupe
       {
           get { return this.lPersonidSupe; }
           set { this.lPersonidSupe = value; }



       }

       public int PersonidOpera
       {
           get { return this.lPersonidOpera; }
           set { this.lPersonidOpera = value; }



       }

       public bool AsigmenPerstatus
       {
           get { return this.lAsigmenPerstatus; }
           set { this.lAsigmenPerstatus = value; }



       }

       public string AsigmenPerCreateBy
       {
           get { return this.lAsigmenPerCreateBy; }
           set { this.lAsigmenPerCreateBy = value; }



       }

       public DateTime AsigmenPerDateBy
       {
           get { return this.lAsigmenPerDateBy; }
           set { this.lAsigmenPerDateBy = value; }



       }

       public string AsigmenPerModiBy
       {
           get { return this.lAsigmenPerModiBy; }
           set { this.lAsigmenPerModiBy = value; }



       }

       public DateTime AsigmenPerDateModiBy
       {
           get { return this.lAsigmenPerDateModiBy; }
           set { this.lAsigmenPerDateModiBy = value; }



       }


    }
}
