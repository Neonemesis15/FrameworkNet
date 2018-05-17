using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ENodeComercial
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  14/06/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase NodeComercial
    ///                     permite al administrador del sistema gestionar los Barrios, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Nodos Comerciales.
    /// Modificaciones:     18/06/09    Se incluye el campo idNodeComType para identificar tipo de nodo comercial. Ing. Mauricio Ortiz.
    ///                     26/06/09    Se cambia lNodeCommercial de string a int. Ing. Mauricio Ortiz.
    ///                     10/06/2011  Se Agrega el parámetro Direccion. Angel Ortiz.
    ///                     12/08/2011  Se Agrega el parámetro Corporación. Joseph Gonzales.
    ///                     18/08/2011  Se Agrega los parámetros NodeCommercial_codCountry,NodeCommercial_codDepartment,NodeCommercial_codProvince,NodeCommercial_codDistrict,
    ///                     NodeCommercial_codCommunity. Carlos Marin
    ///                     
    ///                     
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    public class ENodeComercial
    {
        public ENodeComercial()  
        {

            //Se define el Constructor por defecto

        }
        //Aqui define Atributos
        private int lNodeCommercial;
        private string lcommercialNodeName;
        private int lidNodeComType;
        private string lNodeComType_name;
        private string lNodeCommercialDireccion;
        private int lid_corporacion;
        private string lcorporacion_name;
        private bool lNodeCommercialStatus;
        private string lNodeCommercialCreateBy;
        private DateTime lNodeCommercialDateBy;
        private string lNodeCommercialModiBy;
        private DateTime lNodeCommercialDatemodiBy;
        private string lNodeCommercial_codCountry;
        private string lCountry_name;
        private string lNodeCommercial_codDepartment;
        private string lDepartment_name;
        private string lNodeCommercial_codProvince;
        private string lProvince_name;
        private string lNodeCommercial_codDistrict;
        private string lDistrict_name;
        private string lNodeCommercial_codCommunity;
        private string lCommunity_name;

        //Aqui define propiedades de los atributos
        public int NodeCommercial
        {
            get { return this.lNodeCommercial; }
            set { this.lNodeCommercial = value; }
        }

        public string commercialNodeName
        {
            get { return this.lcommercialNodeName; }
            set { this.lcommercialNodeName = value; }
        }

        public int idNodeComType
        {
            get { return this.lidNodeComType; }
            set { this.lidNodeComType = value; }
        }

        public string NodeComType_name
        {
            get { return this.lNodeComType_name; }
            set { this.lNodeComType_name = value; }
        }

        public int id_corporacion
        {
            get { return this.lid_corporacion; }
            set { this.lid_corporacion = value; }
        }

        public string corporacion_name
        {
            get { return lcorporacion_name; }
            set { lcorporacion_name = value; }
        }

        public string NodeCommercialDireccion
        {
            get { return lNodeCommercialDireccion; }
            set { lNodeCommercialDireccion = value; }
        }

        public bool NodeCommercialStatus
        {
            get { return this.lNodeCommercialStatus; }
            set { this.lNodeCommercialStatus = value; }
        }

        public string NodeCommercialCreateBy
        {
            get { return this.lNodeCommercialCreateBy; }
            set { this.lNodeCommercialCreateBy = value; }
        }

        public DateTime NodeCommercialDateBy
        {
            get { return this.lNodeCommercialDateBy; }
            set { this.lNodeCommercialDateBy = value; }
        }

        public string NodeCommercialModiBy
        {
            get { return this.lNodeCommercialModiBy; }
            set { this.lNodeCommercialModiBy = value; }
        }

        public DateTime NodeCommercialDatemodiBy
        {
            get { return this.lNodeCommercialDatemodiBy; }
            set { this.lNodeCommercialDatemodiBy = value; }
        }
          
        public string NodeCommercial_codCountry
        {
            get { return this.lNodeCommercial_codCountry; }
            set { this.lNodeCommercial_codCountry = value; }
        }
        public string NodeCommercial_codDepartment
        {
            get { return this.lNodeCommercial_codDepartment; }
            set { this.lNodeCommercial_codDepartment = value; }
        }
        public string NodeCommercial_codProvince
        {
            get { return this.lNodeCommercial_codProvince; }
            set { this.lNodeCommercial_codProvince = value; }
        }

        public string NodeCommercial_codDistrict
        {
            get { return this.lNodeCommercial_codDistrict; }
            set { this.lNodeCommercial_codDistrict = value; }
        }
        public string NodeCommercial_codCommunity
        {
            get { return this.lNodeCommercial_codCommunity; }
            set { this.lNodeCommercial_codCommunity = value; }
        }
       
        public string Country_name
        {
            get { return this.lCountry_name; }
            set { this.lCountry_name = value; }
        }
        public string Department_name
        {
            get { return this.lDepartment_name; }
            set { this.lDepartment_name = value; }
        }

        public string Province_name
        {
            get { return this.lProvince_name; }
            set { this.lProvince_name = value; }
        }

        public string District_name
        {
            get { return this.lDistrict_name; }
            set { this.lDistrict_name = value; }
        }

        public string Community_name
        {
            get { return this.lCommunity_name; }
            set { this.lCommunity_name = value; }
        }

    }
}