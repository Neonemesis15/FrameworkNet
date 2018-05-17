using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EItem_Point_Detalle
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  10/07/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Item_Point_Detalle
    /// </summary>
     
    public class EItem_Point_Detalle
    {
        public EItem_Point_Detalle()
        {        
        //Se define el contructor por defecto
        }
        private int lcod_Detitem;
        private int lcod_item;
        private string lItem_DetDescription;
        private int lid_typeDate;
        private int lid_tabla;
        private bool lDetItem_Status;
        private string lDetitem_CreateBy;
        private DateTime lDetitem_DateBy;
        private string  lDetitem_ModiBy;
        private DateTime lDetitem_DateModiBy;

        public int cod_Detitem
        {
            get { return this.lcod_Detitem; }
            set { this.lcod_Detitem = value; }
        }

        public int cod_item
        {
            get { return this.lcod_item; }
            set { this.lcod_item = value; }
        }

        public string Item_DetDescription
        {
            get { return this.lItem_DetDescription; }
            set { this.lItem_DetDescription = value; }
        }

        public int id_typeDate
        {
            get { return this.lid_typeDate; }
            set { this.lid_typeDate = value; }
        }

        public int id_tabla
        {
            get { return this.lid_tabla; }
            set { this.lid_tabla = value; }
        }

        public bool DetItem_Status
        {
            get { return this.lDetItem_Status; }
            set { this.lDetItem_Status = value; }
        }

        public string Detitem_CreateBy
        {
            get { return this.lDetitem_CreateBy; }
            set { this.lDetitem_CreateBy = value; }
        }
        public DateTime Detitem_DateBy
        {
            get { return this.lDetitem_DateBy; }
            set { this.lDetitem_DateBy = value; }
        }
        public string Detitem_ModiBy
        {
            get { return this.lDetitem_ModiBy; }
            set { this.lDetitem_ModiBy = value; }
        }
        public DateTime Detitem_DateModiBy
        {
            get { return this.lDetitem_DateModiBy; }
            set { this.lDetitem_DateModiBy = value; }
        }
    }
}
