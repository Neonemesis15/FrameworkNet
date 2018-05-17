using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    //CreateBy: Ing. Mauricio Ortiz
    //CreateDate: 10/07/2009
    //Description: Atributos Entidad EProducts_Planning vs servicios 
    
    //Requerimiento:
    /// <summary>
    /// Se agregan los campos de auditoria Ing. Carlos Hernandez
    /// Fecha de Modificación: 16/07/2009
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    ///                   31/08/2010 se cambia tipo de dato @id_Product de int a long Ing. Mauricio Ortiz
    ///                   02/03/2011 se adiciona el parametro Report_Id . Ing. Mauricio Ortiz

    /// </summary>
    public class EProducts_Planning
    {

        public EProducts_Planning()
        {        
        //Se define el contructor por defecto
        }
        private int lid_ProductsPlanning;
        private string lid_planning;
        private long lid_Product;
        private string lidProductCategory;
        private int lid_Brand;
        private string lidSubBrand;
        private string lProductCaracte;
        private string lProductBenefi;
        private int lProductsPlanning_InitialStock;
        private int lReport_Id;
        private bool lStatus;
        private string lProductPlaCreateBy;
        private DateTime lProductPlaDateBy;
        private string lProductPlanModiBy;
        private DateTime lProductPlanDateModiBy;

        public int id_ProductsPlanning
        {
            get { return this.lid_ProductsPlanning; }
            set { this.lid_ProductsPlanning = value; }
        }

        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }

        public long id_Product
        {
            get { return this.lid_Product; }
            set { this.lid_Product = value; }
        }

        public string idProductCategory {
            get { return this.lidProductCategory; }
            set { this.lidProductCategory = value; }
        
        
        
        }



        public int id_Brand
        {
            get { return this.lid_Brand; }
            set { this.lid_Brand = value; }
        }

        public string idSubBrand {
            get { return this.lidSubBrand; }
            set { this.lidSubBrand = value; }
        
        
        
        
        }

        public string ProductCaracte
        {
            get { return this.lProductCaracte; }
            set { this.lProductCaracte = value; }




        }

        public string ProductBenefi
        {
            get { return this.lProductBenefi; }
            set { this.lProductBenefi = value; }




        }
        public int ProductsPlanning_InitialStock
        {
            get { return this.lProductsPlanning_InitialStock; }
            set { this.lProductsPlanning_InitialStock = value; }
        }

        
        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }

        public bool Status
        {
            get { return this.lStatus; }
            set { this.lStatus = value; }
        }

        public string ProductPlaCreateBy
        {
            get { return this.lProductPlaCreateBy; }
            set { this.lProductPlaCreateBy = value; }
        }

        public DateTime ProductPlaDateBy
        {
            get { return this.lProductPlaDateBy; }
            set { this.lProductPlaDateBy = value; }
        }

        public string ProductPlanModiBy
        {
            get { return this.lProductPlanModiBy; }
            set { this.lProductPlanModiBy = value; }
        }

        public DateTime ProductPlanDateModiBy
        {
            get { return this.lProductPlanDateModiBy; }
            set { this.lProductPlanDateModiBy = value; }
        }





    }
}
