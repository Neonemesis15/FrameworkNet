using System;

namespace Lucky.Entity.Common.Application
{   
    /// <summary>
    /// Clase:              EPersonLevel
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  24/08/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase PersonLevel
    ///                     permite al administrador del sistema gestionar los niveles de usuario , por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar niveles de usuario.
    /// </summary>

    public class EPersonLevel
    {
        /// tabla PersonLevel
        private string lid_Level;
        private string lLevel_Description;
        private bool lLevel_status;
        private string lLevel_CreateBy;
        private DateTime lLevel_DateBy;
        private string lLevel_ModiBy;
        private DateTime lLevel_DateModiBy;
        /// <summary>
        /// Se adiciona campos de tabla AD_Person_Modulos
        /// 03/12/2010 Magaly Jiménez
        /// </summary>
        
        private long lid_Person_Modulo;
        private string  lModulo_id;
        private string  lModulo_Name;
        private bool  lPerson_Modulo_Status;
        private string  lPerson_Modulo_CreateBy;
        private DateTime lPerson_Modulo_Dateby;
        private string  lPerson_Modulo_ModiBy;
        private DateTime lPerson_Modulo_DateModiBy;



        public string id_Level
        {
            get { return this.lid_Level; }
            set { this.lid_Level = value; }
        }
        public string Level_Description
        {
            get { return this.lLevel_Description; }
            set { this.lLevel_Description = value; }
        }
        public bool Level_status
        {
            get { return this.lLevel_status; }
            set { this.lLevel_status = value; }
        }
        public string Level_CreateBy
        {
            get { return this.lLevel_CreateBy; }
            set { this.lLevel_CreateBy = value; }
        }
        public DateTime Level_DateBy
        {
            get { return this.lLevel_DateBy; }
            set { this.lLevel_DateBy = value; }
        }
        public string Level_ModiBy
        {
            get { return this.lLevel_ModiBy; }
            set { this.lLevel_ModiBy = value; }
        }
        public DateTime Level_DateModiBy
        {
            get { return this.lLevel_DateModiBy; }
            set { this.lLevel_DateModiBy = value; }
        }


        ///Se adiciona campos de la tabla AD_Person_Modulos

        public long id_Person_Modulo
        {
            get { return this.lid_Person_Modulo; }
            set { this.lid_Person_Modulo = value; }
        }
        public string Modulo_id
        {
            get { return this.lModulo_id; }
            set { this.lModulo_id = value; }
        }
        public string Modulo_Name
        {
            get { return this.lModulo_Name; }
            set { this.lModulo_Name = value; }
        }
        public bool Person_Modulo_Status
        {
            get { return this.lPerson_Modulo_Status; }
            set { this.lPerson_Modulo_Status = value; }
        }
        public string Person_Modulo_CreateBy
        {
            get { return this.lPerson_Modulo_CreateBy; }
            set { this.lPerson_Modulo_CreateBy = value; }
        }
        public DateTime Person_Modulo_Dateby
        {
            get { return this.lPerson_Modulo_Dateby; }
            set { this.lPerson_Modulo_Dateby = value; }
        }
        public string Person_Modulo_ModiBy
        {
            get { return this.lPerson_Modulo_ModiBy; }
            set { this.lPerson_Modulo_ModiBy = value; }
        }
        public DateTime Person_Modulo_DateModiBy
        {
            get { return this.lPerson_Modulo_DateModiBy; }
            set { this.lPerson_Modulo_DateModiBy = value; }
        }
     
    }
}
        
        
