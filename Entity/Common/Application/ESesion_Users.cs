using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase : ESesion_Users
    /// Creado por : Ing. Mauricio Ortiz
    /// Fecha de creación: 17/11/2010
    /// Descripción : Define los atributos y propiedades de la clase Sesion_Users
    ///               y permite controlar la cantidad de ingresos por parte de los usuarios del modulo cliente
    /// </summary>
    public class ESesion_Users
    {
        public ESesion_Users()
        {
            // Se define el constructor por defecto
        }

        private int lid_seccion;
        private string lname_user;
        private int lCompany_id;
        private string lModulo_id;
        private string lModulo_Name;
        private string lcod_Channel;
        private int lReport_Id;
        private string lMachine;
        private string lNameFile;
        private DateTime lDateby;
        private string lHora;




        public int id_seccion
        {
            get { return this.lid_seccion; }
            set { this.lid_seccion = value; }
        }

        public string name_user
        {
            get { return this.lname_user; }
            set { this.lname_user = value; }
        }

        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
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

        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel = value; }
        }

        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }

        public string Machine
        {
            get { return this.lMachine; }
            set { this.lMachine = value; }
        }

        public string NameFile
        {
            get { return this.lNameFile; }
            set { this.lNameFile = value; }
        }

        public DateTime Dateby
        {
            get { return this.lDateby; }
            set { this.lDateby = value; }
        }

        public string Hora
        {
            get { return this.lHora; }
            set { this.lHora = value; }
        }
    }
}
