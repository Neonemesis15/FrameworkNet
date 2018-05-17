using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    //Clase:                EinfoaUsuarios de la tabla dbo.CLIE_Users_Reports
    /// Creada Por:         Ing. Magaly andrea Jimenez
    /// Fecha de Creación:  03/08/2010
    /// // Descripcion:     Inserta en la base de datos las asignaciones de informe a usuario en la tabla dbo.CLIE_Users_Reports.
    ///Modificación se agrega Subchannel en maestro.
   

    public class EInfoaUsaurio
    {
        public EInfoaUsaurio()
        {
        }
        /// <summary>
        /// se agrega campo nuevo Subnivel
        /// 25/04/2011  Magaly Jiménez
        /// </summary>
        private int lid_userinforme;
        private int lPerson_id;
        private int lReport_Id;
        private int lcod_Strategy;
        private string lcod_Channel;
        private string lcod_subchannel;
        private string lcod_Subnivel;
        private int lCompany_id;
        private bool luserinfo_status;
        private string luserinfo_CreateBy;
        private DateTime luserinfo_DateBy;
        private string luserinfo_ModiBy;
        private DateTime luserinfo_DateModiBy;
        private string lNombre_Completo;


        public int id_userinforme
        {
            get { return this.lid_userinforme; }
            set { this.lid_userinforme = value; }
        }

        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
        }
        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }
        public int cod_Strategy
        {
            get { return this.lcod_Strategy; }
            set { this.lcod_Strategy = value; }
        }
        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel = value; }
        }
        public string cod_subchannel
        {
            get { return this.lcod_subchannel; }
            set { this.lcod_subchannel = value; }
        }

        public string cod_Subnivel
        {
            get { return this.lcod_Subnivel; }
            set { this.lcod_Subnivel = value; }
        }   
        
        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }

        public bool userinfo_status
        {
            get { return this.luserinfo_status; }
            set { this.luserinfo_status = value; }
        }
         public string userinfo_CreateBy
        {
            get { return this.luserinfo_CreateBy; }
            set { this.luserinfo_CreateBy = value; }
        }
         public DateTime userinfo_DateBy
        {
            get { return this.luserinfo_DateBy; }
            set { this.luserinfo_DateBy = value; }
        }
         public string userinfo_ModiBy
        {
            get { return this.luserinfo_ModiBy; }
            set { this.luserinfo_ModiBy = value; }
        }
        public DateTime userinfo_DateModiBy
        {
            get { return this.luserinfo_DateModiBy; }
            set { this.luserinfo_DateModiBy = value; }
        }
        
        public string Nombre_Completo
        {
            get {return this.lNombre_Completo;}
            set { this.lNombre_Completo = value; }

        }

    }
    
}





  
    
    
