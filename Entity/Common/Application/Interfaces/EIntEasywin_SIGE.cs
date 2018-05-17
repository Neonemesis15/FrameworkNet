using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application.Interfaces
{
    /// <summary>
    /// Clase:EIntEasywin_SIGE
    /// Creada por: Ing. Carlos Alberto Hernández R
    /// Fecha de Creación: 26/05/2009
    /// Descripcion: Define los atributos para la Clase EIntEasywin_SIGE
    /// Requerimiento No:SIGE-ARNF-002 Interface con el Sistema Easywin
    /// </summary>


    public class EIntEasywin_SIGE
    {
        public EIntEasywin_SIGE() { 
        
        //Se define el constructor por defecto
        
        }

        private string ltipodoc;
        private string lnumdoc;
        private string lprimnom;
        private string lsegnom;
        private string lapepat;
        private string lapemat;
        private string lemail;
        private string ltelefono;
        private string ldireccion;
        private string lcodpais;
        private string lcodrol;
        private string lnomrol;
        private string lcodcargo;
        private string lnomcargo;
        private string lccosto;
        private string lccostod;
        private string lusrd;
        private string lfchact;
        private string lRUC;
        private string lNOMCLI;
        private string lDIRCLI;
        private string lTELEFCLI;
        private string lEMAILCLI;
        private string lNOMBCONT;
        private string lEMAILCONT;
        private string lstat;
        private string lFLGERRS;
        private int lIDNUMBER;
        private int lPersonid;

        public string tipodoc {

            get { return this.ltipodoc; }
            set { this.ltipodoc = value; }
        
        
        }
        public string numdoc
        {

            get { return this.lnumdoc; }
            set { this.lnumdoc = value; }


        }
        public string primnom
        {

            get { return this.lprimnom; }
            set { this.lprimnom = value; }


        }

        public string segnom
        {

            get { return this.lsegnom; }
            set { this.lsegnom = value; }


        }
        public string apepat
        {

            get { return this.lapepat; }
            set { this.lapepat = value; }


        }

        public string apemat
        {

            get { return this.lapemat; }
            set { this.lapemat = value; }


        }
        public string email
        {

            get { return this.lemail; }
            set { this.lemail = value; }


        }

        public string telefono
        {

            get { return this.ltelefono; }
            set { this.ltelefono = value; }


        }

        public string direccion
        {

            get { return this.ldireccion; }
            set { this.ldireccion = value; }


        }


        public string codpais
        {

            get { return this.lcodpais; }
            set { this.lcodpais = value; }


        }

        public string codrol
        {

            get { return this.lcodrol; }
            set { this.lcodrol = value; }


        }

        public string nomrol
        {

            get { return this.lnomrol; }
            set { this.lnomrol = value; }


        }

        public string codcargo
        {

            get { return this.lcodcargo; }
            set { this.lcodcargo = value; }


        }

        public string nomcargo
        {

            get { return this.lnomcargo; }
            set { this.lnomcargo = value; }


        }

        public string ccosto
        {

            get { return this.lccosto; }
            set { this.lccosto = value; }


        }

        public string ccostod
        {

            get { return this.lccostod; }
            set { this.lccostod = value; }


        }

        public string usrd
        {

            get { return this.lusrd; }
            set { this.lusrd = value; }


        }
        public string fchact
        {

            get { return this.lfchact; }
            set { this.lfchact = value; }


        }

        public string RUC {

            get { return this.lRUC; }
            set { this.lRUC = value; }
        
        
        }

        public string NOMCLI
        {

            get { return this.lNOMCLI; }
            set { this.lNOMCLI = value; }


        }
        public string DIRCLI
        {

            get { return this.lDIRCLI; }
            set { this.lDIRCLI = value; }


        }

        public string TELEFCLI
        {

            get { return this.lTELEFCLI; }
            set { this.lTELEFCLI = value; }


        }
        public string EMAILCLI
        {

            get { return this.lEMAILCLI; }
            set { this.lEMAILCLI = value; }


        }

        public string NOMBCONT
        {

            get { return this.lNOMBCONT; }
            set { this.lNOMBCONT = value; }


        }

        public string EMAILCONT
        {

            get { return this.lNOMBCONT; }
            set { this.lNOMBCONT = value; }


        }

         public string stat
        {

            get { return this.lstat; }
            set { this.lstat = value; }


        }

         public string FLGERRS
         {

             get { return this.lFLGERRS; }
             set { this.lFLGERRS = value; }


         }

         public int IDNUMBER
         {

             get { return this.lIDNUMBER; }
             set { this.lIDNUMBER = value; }


         }

         public int Personid
         {

             get { return this.lPersonid; }
             set { this.lPersonid = value; }


         }


    }
}
