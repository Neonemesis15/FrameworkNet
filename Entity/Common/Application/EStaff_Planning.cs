using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EStaff_Planning
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  12/08/2010
    /// Requerimientos No: 
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Staff_Planning
    ///                     permite al usuario por medio de las operaciones transaccionales a la tabla Staff_Planning
    ///                     que corresponde a la asignación de personal a un planning.
    /// </summary>
    public class EStaff_Planning
    {
        public EStaff_Planning()
        {
            //Se define el constructor de la clase por defecto
        }        

        /// <summary>
        /// se definen los atributos de la clase Staff_Planning
        /// </summary>
        private int lid_StaffPlanning;
        private string lid_planning;
        private int lPerson_id;
        private bool lStaffPlanning_Status;
        private string lStaffPlanning_CreateBy;
        private DateTime lStaffPlanning_DateBy;
        private string lStaffPlanning_ModiBy;
        private DateTime lStaffPlanning_DateModiBy;
                       
        // se definen las propiedades de los atributos de la clase Staff_Planning       
        public int id_StaffPlanning
        {
            get { return this.lid_StaffPlanning; }
            set { this.lid_StaffPlanning = value; }
        }
       
        public string id_planning
        {
            get { return this.lid_planning; }
            set { this.lid_planning = value; }
        }

        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
        }

        public bool StaffPlanning_Status
        {
            get { return this.lStaffPlanning_Status; }
            set { this.lStaffPlanning_Status = value; }
        }

        public string StaffPlanning_CreateBy
        {
            get { return this.lStaffPlanning_CreateBy; }
            set { this.lStaffPlanning_CreateBy = value; }
        }

        public DateTime StaffPlanning_DateBy
        {
            get { return this.lStaffPlanning_DateBy; }
            set { this.lStaffPlanning_DateBy = value; }
        }

        public string StaffPlanning_ModiBy
        {
            get { return this.lStaffPlanning_ModiBy; }
            set { this.lStaffPlanning_ModiBy = value; }
        }

        public DateTime StaffPlanning_DateModiBy
        {
            get { return this.lStaffPlanning_DateModiBy; }
            set { this.lStaffPlanning_DateModiBy = value; }
        }
    }
}