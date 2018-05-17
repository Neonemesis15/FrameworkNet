using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EMetadataPrices_Planning
    /// Creado Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación: 28/09/2009
    /// Descripción: Define los atributos y propiedades de la clase MetadataSales_Planning
    /// Requerimiento<>
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
   public  class EMetadataPrices_Planning
    {
       public EMetadataPrices_Planning()
       { 
       
       //Se define el constructor por defecto
       
       }

       private int lidmetaprices;
       private int lobjectid;
       private string lidplanning;
       private int lidindicador;
       private int lcolumnid;
       private string lSymbolName;
       private string lOperating;
       private string lFormula;
       private string lReformulation;
       private string lOrigenDatos;
       private string lmetapricesCreateBy;
       private DateTime lmetapricesDateBy;
       private string lmetapricesModiBy;
       private DateTime lmetapricesDateModiBy;

       public int idmetaprices {
           get { return this.lidmetaprices; }
           set { this.lidmetaprices = value; }
       
       
       
       }

       public int objectid
       {
           get { return this.lobjectid; }
           set { this.lobjectid = value; }



       }

       public string idplanning
       {
           get { return this.lidplanning; }
           set { this.lidplanning = value; }



       }

       public int idindicador
       {
           get { return this.lidindicador; }
           set { this.lidindicador= value; }



       }

       public int columnid
       {
           get { return this.lcolumnid; }
           set { this.lcolumnid = value; }



       }

       public string SymbolName
       {
           get { return this.lSymbolName; }
           set { this.lSymbolName = value; }



       }

       public string Operating
       {
           get { return this.lOperating; }
           set { this.lOperating = value; }



       }

       public string Formula
       {
           get { return this.lFormula; }
           set { this.lFormula = value; }



       }

       public string Reformulation
       {
           get { return this.lReformulation; }
           set { this.lReformulation = value; }



       }

       public string OrigenDatos
       {
           get { return this.lOrigenDatos; }
           set { this.lOrigenDatos = value; }



       }

       public string metapricesCreateBy
       {
           get { return this.lmetapricesCreateBy; }
           set { this.lmetapricesCreateBy = value; }



       }

       public DateTime metapricesDateBy
       {
           get { return this.lmetapricesDateBy; }
           set { this.lmetapricesDateBy = value; }



       }

       public string metapricesModiBy
       {
           get { return this.lmetapricesModiBy; }
           set { this.lmetapricesModiBy = value; }



       }

       public DateTime metapricesDateModiBy
       {
           get { return this.lmetapricesDateModiBy; }
           set { this.lmetapricesDateModiBy = value; }



       }


    }
}
