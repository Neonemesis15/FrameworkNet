using System;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EAD_Subchannel
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  19/08/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase EAD_Subchannel
    ///                     permite al administrador del sistema gestionar las EAD_Subchannel, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar EAD_Subchannel.
    /// Modificado por: Angel Ortiz.
    /// 18/07/2011
    /// Se agrega el parámetro Company _id.
    /// </summary>


    public class EAD_Subchannel 
    {
        public EAD_Subchannel()
        {
            //Se define el constructor por defecto
        }

        private string lcod_subchannel;
        private string lcod_Channel;
        private int iCompany_id;        
        private string lName_subchannel;
        private bool lStatus;
        private string lCreateBy;
        private DateTime lDateBy;
        private string lModiBy;
        private DateTime lDateModiBy;
        
        public string cod_subchannel
        {
            get { return this.lcod_subchannel; }
            set { this.lcod_subchannel = value; }
        }

        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel = value; }
        }

        public int ICompany_id
        {
            get { return iCompany_id; }
            set { iCompany_id = value; }
        }

        public string Name_subchannel
        {
            get { return this.lName_subchannel; }
            set { this.lName_subchannel = value; }
        }

        public bool Status
        {
            get { return this.lStatus; }
            set { this.lStatus = value; }
        }
        public string CreateBy
        {
            get { return this.lCreateBy; }
            set { this.lCreateBy = value; }
        }
        public DateTime DateBy
        {
            get { return this.lDateBy; }
            set { this.lDateBy = value; }
        }
        public string ModiBy
        {
            get { return this.lModiBy; }
            set { this.lModiBy = value; }
        }
        public DateTime DateModiBy
        {
            get { return this.lDateModiBy; }
            set { this.lDateModiBy = value; }
        }
    }
}
