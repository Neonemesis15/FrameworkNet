using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EItemsPoint
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  15/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-021 Gestión de Items  de Servicios
    ///                     «Functional» SIGE-ARF-069 Crear Items de Servicios
    ///                     «Functional» SIGE-ARF-070 Consultar Items de Servicios
    ///                     «Functional» SIGE-ARF-071 Actualizar Items de Servicios
    ///                     «Functional» SIGE-ARF-072 Deshabilitar Item de Servicio
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase ItemsPoint
    ///                     Define las caracteristicas de cada Estrategia usadas por el Negocio de acuerdo a la 
    ///                     Gestión de Estrategias esto quiere decir que permitira detallar cuales son las caracteristica 
    ///                     de los servicios proveidos por Lucky al cliente.
    /// </summary>

    public class EItemsPoint
    {
        private int lcod_Item;
        private int lid_cod_point;
        private string lDescription_Point;
        private string lcod_Point;
        private int lcod_Strategy;
        private string lItem_Description;
        private int lid_Ubicación;
        private bool lState_Item;
        private string lItem_CreateBy;
        private DateTime lItem_DateBy;
        private string lItem_ModiBy;
        private DateTime lItem_DateModiBy;
        private int lcompany_id;
        private string lcod_Country;
        private string lcod_Channel;

        public int cod_Item
        {
            get { return this.lcod_Item; }
            set { this.lcod_Item = value; }
        }

        public int id_cod_point
        {
            get { return this.lid_cod_point; }
            set { this.lid_cod_point = value; }
        }

        public string Description_Point
        {
            get { return this.lDescription_Point; }
            set { this.lDescription_Point = value; }
        }


        public string cod_Point
        {
            get { return this.lcod_Point; }
            set { this.lcod_Point = value; }
        }

        public int cod_Strategy
        {
            get { return this.lcod_Strategy; }
            set { this.lcod_Strategy = value; }
        }


        public string Item_Description
        {
            get { return this.lItem_Description; }
            set { this.lItem_Description = value; }
        }

        public int id_Ubicación
        {
            get { return this.lid_Ubicación; }
            set { this.lid_Ubicación = value; }
        }


        public bool State_Item
        {
            get { return this.lState_Item; }
            set { this.lState_Item = value; }
        }

        public string Item_CreateBy
        {
            get { return this.lItem_CreateBy; }
            set { this.lItem_CreateBy = value; }
        }

        public DateTime Item_DateBy
        {
            get { return this.lItem_DateBy; }
            set { this.lItem_DateBy = value; }
        }

        public string Item_ModiBy
        {
            get { return this.lItem_ModiBy; }
            set { this.lItem_ModiBy = value; }
        }

        public DateTime Item_DateModiBy
        {
            get { return this.lItem_DateModiBy; }
            set { this.lItem_DateModiBy = value; }
        }

        public int company_id
        {
            get { return this.lcompany_id; }
            set { this.lcompany_id = value; }
        }

        public string cod_Country
        {
            get { return this.lcod_Country; }
            set { this.lcod_Country = value; }
        }

        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel = value; }
        }
    }
}



     





