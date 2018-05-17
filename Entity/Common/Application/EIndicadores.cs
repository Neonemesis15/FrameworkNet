using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EIndicadores
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  01/06/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-041 Gestion de Indicadores
    ///                     «Functional» SIGE-ARF-093 Crear Indicador
    ///                     «Functional» SIGE-ARF-094 Consultar Indicador
    ///                     «Functional» SIGE-ARF-154 Actualizar Indicador
    ///                     «Functional» SIGE-ARF-095 Inactivar Indicador
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Indicadores
    ///                     Permite establecer la forma en que se realizaran los calculos de la información 
    ///                     recolectada en calle, para tal fin se contara con una maestro en el cual se relizaran 
    ///                     las siguientes tareas:
    ///                     1. Se seleccionara la Tabla de la cual se realizaran operaciones
    ///                     2. Campo A para realizar la operacion
    ///                     3. Campo B para realizar las operacion
    ///                     4. Tipo de operacion(suma, resta, division, multiplicación)
    ///                     Los campos que  se mostrará de las tablas son aquellos con los cuales se pueden realizar calculos.
    ///                     Estaran preparametrizadas las operaciones basicas:
    ///                     a. Suma
    ///                     b. Multiplicación
    ///                     c. División
    ///                     d. Resta
    ///                     El usuario parametrizara como quiera que los campos operen esto quiere decir que realizar 
    ///                     la siguiente accion:
    ///                     1. Seleccionara la Tabla
    ///                     2. SIGE mostrara en en un combo los campos que pueden ser calculados
    ///                     3. seleccionara el primer campo y picara en la opcion agrergar
    ///                     4. Seleccionara el tipo de operacion(suma.multiplicacion. division,resta) y le da agregar
    ///                     5. Hara esta iteraccion las veces que necesite y le dara la opcion agrupar, la cual colocara 
    ///                     entre parentisis toda la formula generada, este sera el unico nivle de agrupamiento.
    ///                     6. Ahora selecciona la opcion Generar Indicador
    ///                     7. En el modulo Planning cuando este construyendo el mismo asociara el infome al indicador 
    ///                     creado, por ejemplo: 
    ///                     7.1 El indicador se llama Ventas Efectivas y el informe se llama Informe Ventas Efectivas, 
    ///                     entonces en una ventana asociara el informe Ventas efectivas  con el indicador Ventas efectivas 
    ///                     creado con lo cual el sistema sabra que tipo de elementos debe calcular para generar el informe 
    ///                     ventas efectivas.
    /// Modificaciones :    Se inserta private bool lindicador_Status . Ing. Mauricio Ortiz 
    /// </summary>
    
    public class EIndicadores
    {
        public EIndicadores() { 
        
        //Se define el Constructor por defecto
        
        }
        private int lidtabla;
        private string lnametabla;
        private int lcodDetitem;
        private string lItemDetDescription;
        private int lidindicador;
        private string lnameindicador;
        private string lformula;
        private string ldescripcionoperacion;
        private int lReport_Id;
        private bool lindicador_Status;
        private int  lidsymbol;
        private string lnamsymbol;
        private int lcodStrategy;
        private string lindicadorCreateBy;
        private DateTime lindicadorDateBy;
        private string lindicadorModiBy;
        private DateTime lindicadorDateModiBy;
        private string lcod_Country;

        public int idtabla {

            get { return this.lidtabla; }
            set { this.lidtabla = value; }
        
        }

        public string nametabla {

            get { return this.lnametabla; }
            set { this.lnametabla = value; }
        
        
        }
        public int codDetitem {

            get { return this.lcodDetitem; }
            set { this.lcodDetitem = value; }
        
        
        }
        public string ItemDetDescription {

            get { return this.lItemDetDescription; }
            set { this.lItemDetDescription = value; }
        
        
        
        }

        public int idindicador
        {

            get { return this.lidindicador; }
            set { this.lidindicador = value; }


        }

        public string nameindicador
        {
            get { return this.lnameindicador; }
            set { this.lnameindicador = value; }
        }

        public string formula
        {

            get { return this.lformula; }
            set { this.lformula = value; }



        }

        public string descripcionoperacion
        {
            get { return this.ldescripcionoperacion; }
            set { this.ldescripcionoperacion = value; }
        }

        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value;}
        }

        public bool indicador_Status
        {

            get { return this.lindicador_Status; }
            set { this.lindicador_Status = value; }

        }


        public int idsymbol
        {

            get { return this.lidsymbol; }
            set { this.lidsymbol = value; }

        }

        public string namsymbol
        {

            get { return this.lnamsymbol; }
            set { this.lnamsymbol = value; }



        }

        public int codStrategy
        {

            get { return this.lcodStrategy; }
            set { this.lcodStrategy = value; }



        }

        public string indicadorCreateBy{
        
             get{return this.lindicadorCreateBy;}
             set{this.lindicadorCreateBy=value;}
              


        
        
        
        }

        public DateTime indicadorDateBy{
        
             get{return this.lindicadorDateBy;}
             set{this.lindicadorDateBy=value;}
              


        
        
        
        }

          public string indicadorModiBy{
        
             get{return this.lindicadorModiBy;}
             set{this.lindicadorModiBy=value;}
              


        
        
        
        }

          public DateTime indicadorDateModiBy
          {

              get { return this.lindicadorDateModiBy; }
              set { this.lindicadorDateModiBy = value; }
          }

          public string cod_Country
          {
              get { return this.lcod_Country; }
              set { this.lcod_Country = value; }
          }
              


        
        
        
        
    }
}
