using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// Clase:              ECompetition__Information
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  30-09-2009
    /// Requerimientos No:  <>
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Competition__Information
    ///                     permite al personal operativo y de apoyo por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar los registros de actividades en el comercio
    /// Modificacion:       28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>

    public class ECompetition__Information
    {
        public ECompetition__Information()
        {
            //Se Define el contructor por defecto        
        }
        //Se definen los atributos de la clase
        private int lid_cinfo;
        private string lid_planning;
        private DateTime lcinfo_DateExecution;
        private string lcinfo_nameCompany;
        private string lcinfo_Brand;
        private int lcod_Strategy;
        private string lcinfo_Name_Activity;
        private string lcod_Channel;
        private DateTime lcinfo_FeciniPromo;
        private DateTime lcinfo_FecfinPromo;
        private string lcinfo_Vigente;
        private int lcinfo_PersonnelCatid;
        private string lMecanica;
        private string lid_ProductCategory;        
        private string lcinfo_Comment_Observa;
        private bool lcinfo_Principal;
        private bool lcinfo_Status;
        private string lcinfo_CreateBy;
        private DateTime lcinfo_DateBy;
        private string lcinfo_ModiBy;
        private DateTime lcinfo_DateModiBy;
        private int lvalor; // este campo se utiliza para construir un formato de actividades en el comercio con n filas

        //estos atributos pertenecen a la entidad Competition_InformationPhoto
        private int lid_PhotoCI;
        private string lPhotoCI_PathName;
        private bool lPhotoCI_Status;
        private string lPhotoCI_Observacion;
        private string lPhotoCI_CreateBy;
        private DateTime lPhotoCI_DateBy;
        private string lPhotoCI_ModiBy;
        private DateTime lPhotoCI_DateModiBy;

        //estos atributos pertenecen a la entidad Competition_InformationPOP
        private int lid_CI_POP;
        private int lid_MPointOfPurchase;
        private bool lCI_POP_Status;
        private string lCI_POP_CreateBy;
        private DateTime lCI_POP_DateBy;
        private string lCI_POP_ModiBy;
        private DateTime lCI_POP_DateModiBy;
		

        //se definen las propiedades de los atributos de la clase
        public int id_cinfo
        {
            get { return this.lid_cinfo; }
            set { this.lid_cinfo = value; }
        }
        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }
        public DateTime cinfo_DateExecution
        {
            get { return this.lcinfo_DateExecution; }
            set { this.lcinfo_DateExecution = value; }
        }
        public string cinfo_nameCompany
        {
            get { return this.lcinfo_nameCompany; }
            set { this.lcinfo_nameCompany = value; }
        }
        public string cinfo_Brand
        {
            get { return this.lcinfo_Brand; }
            set { this.lcinfo_Brand = value; }
        }
        public int cod_Strategy
        {
            get { return this.lcod_Strategy; }
            set { this.lcod_Strategy = value; }
        }
        public string cinfo_Name_Activity
        {
            get { return this.lcinfo_Name_Activity; }
            set { this.lcinfo_Name_Activity = value; }
        }
        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel = value; }
        }
        public DateTime cinfo_FeciniPromo
        {
            get { return this.lcinfo_FeciniPromo; }
            set { this.lcinfo_FeciniPromo = value; }
        }
        public DateTime cinfo_FecfinPromo
        {
            get { return this.lcinfo_FecfinPromo; }
            set { this.lcinfo_FecfinPromo = value; }
        }
        public string cinfo_Vigente
        {
            get { return this.lcinfo_Vigente; }
            set { this.lcinfo_Vigente = value; }
        }
        public int cinfo_PersonnelCatid
        {
            get { return this.lcinfo_PersonnelCatid; }
            set { this.lcinfo_PersonnelCatid = value; }
        }
        public string Mecanica
        {
            get { return this.lMecanica; }
            set { this.lMecanica = value; }
        }
        public string id_ProductCategory
        {
            get { return this.lid_ProductCategory; }
            set { this.lid_ProductCategory = value; }
        }        
        public string cinfo_Comment_Observa
        {
            get { return this.lcinfo_Comment_Observa; }
            set { this.lcinfo_Comment_Observa = value; }
        }

        public bool cinfo_Principal
        {
            get { return this.lcinfo_Principal; }
            set { this.lcinfo_Principal = value; }
        }

        public bool cinfo_Status
        {
            get { return this.lcinfo_Status; }
            set { this.lcinfo_Status = value; }
        }

        public string cinfo_CreateBy
        {
            get { return this.lcinfo_CreateBy; }
            set { this.lcinfo_CreateBy = value; }
        }
        public DateTime cinfo_DateBy
        {
            get { return this.lcinfo_DateBy; }
            set { this.lcinfo_DateBy = value; }
        }
        public string cinfo_ModiBy
        {
            get { return this.lcinfo_ModiBy; }
            set { this.lcinfo_ModiBy = value; }
        }
        public DateTime cinfo_DateModiBy
        {
            get { return this.lcinfo_DateModiBy; }
            set { this.lcinfo_DateModiBy = value; }
        }
        public int valor
        {
            get { return this.lvalor; }
            set { this.lvalor = value; }
        }

        public int id_PhotoCI
        {
            get { return this.lid_PhotoCI; }
            set { this.lid_PhotoCI = value; }
        }

        public string PhotoCI_PathName
        {
            get { return this.lPhotoCI_PathName; }
            set { this.lPhotoCI_PathName = value; }
        }
        public bool PhotoCI_Status
        {
            get { return this.lPhotoCI_Status; }
            set { this.lPhotoCI_Status = value; }
        }

        public string PhotoCI_Observacion
        {
            get { return this.lPhotoCI_Observacion; }
            set { this.lPhotoCI_Observacion = value; }
        }

        public string PhotoCI_CreateBy
        {
            get { return this.lPhotoCI_CreateBy; }
            set { this.lPhotoCI_CreateBy = value; }
        }
        public DateTime PhotoCI_DateBy
        {
            get { return this.lPhotoCI_DateBy; }
            set { this.lPhotoCI_DateBy = value; }
        }
        public string PhotoCI_ModiBy
        {
            get { return this.lPhotoCI_ModiBy; }
            set { this.lPhotoCI_ModiBy = value; }
        }
        public DateTime PhotoCI_DateModiBy
        {
            get { return this.lPhotoCI_DateModiBy; }
            set { this.lPhotoCI_DateModiBy = value; }
        }

        public int id_CI_POP
        {
            get { return this.lid_CI_POP; }
            set { this.lid_CI_POP = value; }
        }
        public int id_MPointOfPurchase
        {
            get { return this.lid_MPointOfPurchase; }
            set { this.lid_MPointOfPurchase = value; }
        }
        public bool CI_POP_Status
        {
            get { return this.lCI_POP_Status; }
            set { this.lCI_POP_Status = value; }
        }
        public string CI_POP_CreateBy
        {
            get { return this.lCI_POP_CreateBy; }
            set { this.lCI_POP_CreateBy = value; }
        }
        public DateTime CI_POP_DateBy
        {
            get { return this.lCI_POP_DateBy; }
            set { this.lCI_POP_DateBy = value; }
        }
        public string CI_POP_ModiBy
        {
            get { return this.lCI_POP_ModiBy; }
            set { this.lCI_POP_ModiBy = value; }
        }
        public DateTime CI_POP_DateModiBy
        {
            get { return this.lCI_POP_DateModiBy; }
            set { this.lCI_POP_DateModiBy = value; }
        }
    }
}