using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{    
    /// <summary>
    /// Clase:              ECanales
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  12/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-039 Gestion de Canales de Servicios 
    ///                     «Functional» SIGE-ARF-085 Crear Canales 
    ///                     «Functional» SIGE-ARF-086 Consultar Canales Canales 
    ///                     «Functional» SIGE-ARF-087 Actualizar Canales
    ///                     «Functional» SIGE-ARF-088 Deshabilitar Canales 
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Canales
    ///                     Permite, crear, actualizar  e inativar los canales en los cuales Lucky provee sus servicios
    /// Modificación:       27/05/2009 lChannelDateBy y lChannelDateModiBy se cambio de string a DateTime Ing. Mauricio Ortiz
    /// </summary>
   

    public class ECanales
    {
        public ECanales() { 
        
        //Aqui se define el constructor por defecto
        
        
        }
        /// <summary>
        /// se agrega campo de company_Id
        /// 20/10/2010 Magaly Jiménez
        /// </summary>
        private string lcodChannel;
        private int lCompany_id;
        private string lChannelName;
        private string lChanneldescription;
        private int lChannelType;
        private bool lChannelStatus;
        private string lChannelCreateBy;
        private DateTime lChannelDateBy;  
        private string lChannelModiBy;
        private DateTime lChannelDateModiBy; 

        public string codChannel
        {
            get { return this.lcodChannel; }
            set { this.lcodChannel = value; }
        }

        public int Company_id 
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }
        }

        public string ChannelName
        {
            get { return this.lChannelName; }
            set { this.lChannelName = value; }
        }

        public string Channeldescription
        {
            get { return this.lChanneldescription; }
            set { this.lChanneldescription = value; }
        }

        public int ChannelType
        {
            get { return lChannelType; }
            set { lChannelType = value; }
        }

        public bool ChannelStatus
        {
            get { return this.lChannelStatus; }
            set { this.lChannelStatus = value; }
        }

        public string ChannelCreateBy
        {
            get { return this.lChannelCreateBy; }
            set { this.lChannelCreateBy = value; }
        }

        public DateTime ChannelDateBy
        {
            get { return this.lChannelDateBy; }
            set { this.lChannelDateBy = value; }

        }

        public string ChannelModiBy
        {
            get { return this.lChannelModiBy; }
            set { this.lChannelModiBy = value; }
        }

        public DateTime ChannelDateModiBy
        {
            get { return this.lChannelDateModiBy; }
            set { this.lChannelDateModiBy = value; }
       }
    }
}
