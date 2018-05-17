using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EProduct_Compe
    /// Creada Por: Ing.Carlos Alberto Hernández Rincón
    /// Fecha: 12/12/2009
    /// Descripción: Define los atributos y propiedades de la Clase Product_Compe
    /// Se agrega el atributo lProductCompemanufacturer para soportar el nombre del fabricante, Solicitado por Rafael Leal 
    /// Requerimiento<>
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
    public class EProduct_Compe
    {
        public EProduct_Compe() { 
        
        //Se define el constructor por defecto
        
        
        }
        //Atributos
        private int lidproducCompe;
        private string lidplanning;
        private int lidProductsPlanning;
        private string lnameproducCompe;
        private string lBrandCompe;
        private string lProductCompemanufacturer;
        private bool lproducCompeStatus;
        private string lproducCompeCreateBy;
        private DateTime lproducCompeDateBy;
        private string lproducCompeModiBy;
        private DateTime lproducCompeDateModiBy;

        //Propiedades

        public int idproducCompe {
            get { return this.lidproducCompe; }
            set { this.lidproducCompe=value;}        
        
        
        
        }
        public string idplanning
        {
            get { return this.lidplanning; }
            set { this.lidplanning = value; }



        }


        public int idProductsPlanning {
            get { return this.lidProductsPlanning; }
            set { this.lidProductsPlanning = value; }
        
        
        }

        public string nameproducCompe {
            get { return this.lnameproducCompe; }
            set { this.lnameproducCompe = value; }
        
        
        
        }

        public string BrandCompe
        {
            get { return this.lBrandCompe; }
            set { this.lBrandCompe = value; }



        }
       public  string ProductCompemanufacturer {
            get { return this.lProductCompemanufacturer; }
            set { this.lProductCompemanufacturer = value; }
        
        
        
        }

        public bool producCompeStatus {
            get { return this.lproducCompeStatus; }
            set { this.lproducCompeStatus = value; }
        
        
        
        }

        public string producCompeCreateBy
        {
            get { return this.lproducCompeCreateBy; }
            set { this.lproducCompeCreateBy = value; }



        }

        public DateTime producCompeDateBy {
            get { return this.lproducCompeDateBy; }
            set { this.lproducCompeDateBy = value; }
        
        
        }


        public string producCompeModiBy
        {
            get { return this.lproducCompeModiBy; }
            set { this.lproducCompeModiBy = value; }



        }

        public DateTime producCompeDateModiBy
        {
            get { return this.lproducCompeDateModiBy; }
            set { this.lproducCompeDateModiBy = value; }


        }
      
    }
}
