using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EQuestions_Strategy
    /// Creada Por: Ing. Mauricio Ortiz
    /// Descripcion: Define los atributos y propiedades de los mismos para la Clase Questions_Strategy
    /// Requerimiento No <>
    /// </summary>
    /// 
    public class EQuestions_Strategy
    {
        public EQuestions_Strategy()
        {        
        //Se define el contructor por defecto
        }
        private int lid_Question;
        private int lcod_Strategy;
        private char ltype_Question;
        private string lDescription_Question;
        private bool lQuestion_Status;
        private string lQuestion_CreateBy;
        private DateTime lQuestion_DateBy;
        private string lQuestion_ModiBy;
        private DateTime lQuestion_DateModiBy;

        public int id_Question
        {
            get { return this.lid_Question; }
            set { this.lid_Question = value; }
        }

        public int cod_Strategy
        {
            get { return this.lcod_Strategy; }
            set { this.lcod_Strategy = value; }
        }

        public char type_Question
        {
            get { return this.ltype_Question; }
            set { this.ltype_Question = value; }
        }

        public string Description_Question
        {
            get { return this.lDescription_Question; }
            set { this.lDescription_Question = value; }
        }

        public bool Question_Status
        {
            get { return this.lQuestion_Status; }
            set { this.lQuestion_Status = value; }
        }

        public string Question_CreateBy
        {
            get { return this.lQuestion_CreateBy; }
            set { this.lQuestion_CreateBy = value; }
        }

        public DateTime Question_DateBy
        {
            get { return this.lQuestion_DateBy; }
            set { this.lQuestion_DateBy = value; }
        }

        public string Question_ModiBy
        {
            get { return this.lQuestion_ModiBy; }
            set { this.lQuestion_ModiBy = value; }
        }

        public DateTime Question_DateModiBy
        {
            get { return this.lQuestion_DateModiBy; }
            set { this.lQuestion_DateModiBy = value; }
        }



		

    }
}
