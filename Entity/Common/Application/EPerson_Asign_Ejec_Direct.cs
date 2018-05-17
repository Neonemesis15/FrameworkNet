using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EPerson_Asign_Ejec_Direct
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  02/02/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Person_Asign_Ejec_Direct
    ///                     permite al administrador del sistema gestionar la Asignación de ejecutivos de cuenta a directores de cuenta, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Asignación de ejecutivos de cuenta
    /// </summary>
    /// 
    public class EPerson_Asign_Ejec_Direct
    {
        public EPerson_Asign_Ejec_Direct()
        {
            //Se define el constructor por defecto
        }

        private int lId_Asign_Ejec_Direct;
        private int lPerson_id_Director;
        private int lPerson_id_Ejecutive;
        private bool lAsign_Ejec_Direct_status;
        private string lAsign_Ejec_Direct_CreateBy;
        private DateTime lAsign_Ejec_Direct_DateBy;
        private string lAsign_Ejec_Direct_ModiBy;
        private DateTime lAsign_Ejec_Direct_DateModiBy;
        private string lcod_Country;
        private string lName_Country;
        private string lPerson_NameDirector;
        private string lPerson_NameEjecutivo;


        public int Id_Asign_Ejec_Direct
        {
            get { return this.lId_Asign_Ejec_Direct; }
            set { this.lId_Asign_Ejec_Direct = value; }
        }

        public int Person_id_Director
        {
            get { return this.lPerson_id_Director; }
            set { this.lPerson_id_Director = value; }
        }

        public int Person_id_Ejecutive
        {
            get { return this.lPerson_id_Ejecutive; }
            set { this.lPerson_id_Ejecutive = value; }
        }

        public bool Asign_Ejec_Direct_status
        {
            get { return this.lAsign_Ejec_Direct_status; }
            set { this.lAsign_Ejec_Direct_status = value; }
        }

        public string Asign_Ejec_Direct_CreateBy
        {
            get { return this.lAsign_Ejec_Direct_CreateBy; }
            set { this.lAsign_Ejec_Direct_CreateBy = value; }
        }

        public DateTime Asign_Ejec_Direct_DateBy
        {
            get { return this.lAsign_Ejec_Direct_DateBy; }
            set { this.lAsign_Ejec_Direct_DateBy = value; }
        }

        public string Asign_Ejec_Direct_ModiBy
        {
            get { return this.lAsign_Ejec_Direct_ModiBy; }
            set { this.lAsign_Ejec_Direct_ModiBy = value; }
        }

        public DateTime Asign_Ejec_Direct_DateModiBy
        {
            get { return this.lAsign_Ejec_Direct_DateModiBy; }
            set { this.lAsign_Ejec_Direct_DateModiBy = value; }
        }

        public string cod_Country
        {
            get { return this.lcod_Country; }
            set { this.lcod_Country = value; }
        }

        public string Name_country
        {
            get { return this.lName_Country; }
            set { this.lName_Country = value; }
        }

        public string Person_NameDirector
        {
            get { return this.lPerson_NameDirector; }
            set { this.lPerson_NameDirector = value; }
        }

        public string Person_NameEjecutivo
        {
            get { return this.lPerson_NameEjecutivo; }
            set { this.lPerson_NameEjecutivo = value; }
        }
    }
}