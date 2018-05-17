using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// Clase:            EPhotographs_Service
    /// Creada Por:       Ing. Mauricio Ortiz
    /// Fecha de Creación:03-10-2009
    /// Requerimientos No:<>
    /// Descripcion:      Define los atributos y propiedades de los mismos para la Clase Photographs_Service
    ///                   permite al personal operativo y de apoyo por medio de las 
    ///                   operaciones de Crear, Consultar, Actualizar los registros fotográficos de actividades propias
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary> 


    public class EPhotographs_Service
    {
        public EPhotographs_Service()
        {
            //Se Define el contructor por defecto        
        }

        //Se definen los atributos de la clase

        private int lid_Photographs;
        private string lid_planning;
        private int lid_MPOSPlanning;
        private DateTime lPhoto_Date;
        private string lid_ProductCategory;
        private string lPhoto_TypeReport;
        private string lPhoto_Directory;
        private string lPhoto_Comment_Observa;
        private bool lPhoto_general;
        private bool lPhoto_detallado;
        private int lCompany_id;
        private bool lPhoto_Status;
        private string lPhoto_CreateBy;
        private DateTime lPhoto_DateBy;
        private string lPhoto_ModiBy;
        private DateTime lPhoto_DateModiBy;

        //se definen las propiedades de los atributos de la clase

        public int id_Photographs
        {
            get { return this.lid_Photographs; }
            set { this.lid_Photographs = value; }
        }

        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }

        public int id_MPOSPlanning
        {
            get { return this.lid_MPOSPlanning; }
            set { this.lid_MPOSPlanning = value; }
        }

        public DateTime Photo_Date
        {
            get { return this.lPhoto_Date; }
            set { this.lPhoto_Date = value; }
        }

        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }

        public string Photo_TypeReport
        {
            get { return this.lPhoto_TypeReport; }
            set { this.lPhoto_TypeReport = value; }
        }

        public string Photo_Directory
        {
            get { return this.lPhoto_Directory; }
            set { this.lPhoto_Directory = value; }
        }

        public string Photo_Comment_Observa
        {
            get { return this.lPhoto_Comment_Observa; }
            set { this.lPhoto_Comment_Observa = value; }
        }

        public bool Photo_general
        {
            get { return this.lPhoto_general; }
            set { this.lPhoto_general = value; }
        }

        public bool Photo_detallado
        {
            get { return this.lPhoto_detallado; }
            set { this.lPhoto_detallado = value; }
        }

        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }

        public bool Photo_Status
        {
            get { return this.lPhoto_Status; }
            set { this.lPhoto_Status = value; }
        }

        public string Photo_CreateBy
        {
            get { return this.lPhoto_CreateBy; }
            set { this.lPhoto_CreateBy = value; }
        }

        public DateTime Photo_DateBy
        {
            get { return this.lPhoto_DateBy; }
            set { this.lPhoto_DateBy = value; }
        }

        public string Photo_ModiBy
        {
            get { return this.lPhoto_ModiBy; }
            set { this.lPhoto_ModiBy = value; }
        }

        public DateTime Photo_DateModiBy
        {
            get { return this.lPhoto_DateModiBy; }
            set { this.lPhoto_DateModiBy = value; }
        }
    }
}