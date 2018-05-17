using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EAssignment__Presentations
    /// Creada Por: Ing.Carlos Alberto Hernández
    /// Fecha:20/10/2009
    /// Descripcion: Define los atributos y Propiedades para la Clase Assignment__Presentations
    /// Modificaciones: Se adiciona el campo Cod_channel y el campo Assignment_Status , Ing. Mauricio Ortiz . 21/01/2010
    /// Requerimiento<>
    /// </summary>
    public class EAssignment__Presentations
    {
        public EAssignment__Presentations() { 
        
        //Se define el constructor por Defecto
        
        
        }
        private int lidproductService;
        private string lidProductCategory;
        private int lidProduct;
        private int lidproductprincipal;
        private int lcompanyid;
        private int lcodstrategy;
        private string lPresentaCompetition1;
        private string lPresentaCompetition2;
        private string lPresentaCompetition3;
        private string lcod_Channel;
        private bool lAssignment_Status;
        private string lproductServiceCreateBy;
        private DateTime lproductServiceDateBy;
        private string lproductServiceModiBy;
        private DateTime lproductServiceDateModiBy;


        //Definicion de Propiedades

        public int idproductService {
            get { return this.lidproductService;}
            set{this.lidproductService=value;}

        }

        public string  idProductCategory{
          get{return this.lidProductCategory;}
            set
            {
                this.lidProductCategory = value;}
    
    
    
        }
        
        public int idProduct {
            get { return this.lidProduct;}
            set{this.lidProduct=value;}

        }

        public int idproductprincipal {
            get { return this.lidproductprincipal;}
            set{this.lidproductprincipal=value;}

        }

        public int companyid {
            get { return this.lcompanyid;}
            set{this.lcompanyid=value;}

        }

        public int codstrategy
        {
            get { return this.lcodstrategy; }
            set { this.lcodstrategy = value; }

        }


        public string PresentaCompetition1
        {
            get { return this.lPresentaCompetition1; }
            set
            {
                this.lPresentaCompetition1 = value;
            }



        }

        public string PresentaCompetition2
        {
            get { return this.lPresentaCompetition2; }
            set
            {
                this.lPresentaCompetition2 = value;
            }



        }

        public string PresentaCompetition3
        {
            get { return this.lPresentaCompetition3; }
            set
            {
                this.lPresentaCompetition3 = value;
            }



        }

        public string cod_Channel
        {
            get { return this.lcod_Channel;}
            set { this.lcod_Channel = value;}
        }

        public bool Assignment_Status
        {
            get { return this.lAssignment_Status; }
            set { this.lAssignment_Status = value; }
        }

        public string productServiceCreateBy
        {
            get { return this.lproductServiceCreateBy; }
            set
            {
                this.lproductServiceCreateBy = value;
            }



        }


        public DateTime productServiceDateBy
        {
            get { return this.lproductServiceDateBy; }
            set
            {
                this.lproductServiceDateBy = value;
            }



        }

        public string productServiceModiBy
        {
            get { return this.lproductServiceModiBy; }
            set
            {
                this.lproductServiceModiBy = value;
            }



        }

        public DateTime productServiceDateModiBy
        {
            get { return this.lproductServiceDateModiBy; }
            set
            {
                this.lproductServiceDateModiBy = value;
            }



        }


        
        
        }
        


    }

