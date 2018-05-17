using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>

    /// Clase:              EPointOfSale_PlanningOper
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  16/02/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase PointOfSale_PlanningOper
    ///                     permite al supervisor gestionar la asignación de puntos de venta a personal operativo, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Asignación de puntos de venta a operativo.
    /// Modificacion    :   28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    ///                     06/09/2010 se crean dos atributos para las fechas inicial y final
    ///                     lPOSPlanningOpe_Fechainicio y lPOSPlanningOpe_Fechafin. Ing. Mauricio Ortiz
    /// </summary>


    public class EPointOfSale_PlanningOper
    {
        public EPointOfSale_PlanningOper()
        {
            //Se define el contructor por defecto
        }

        //Aqui se definen los atributos
        private int lid_POSPlanningOpe;
        private int lid_MPOSPlanning;
        private string lid_Planning;
        private int lPerson_id;
        private DateTime lPOSPlanningOpe_Fechainicio;
        private DateTime lPOSPlanningOpe_Fechafin;
        private int lFrecuencia;
        private bool lPOSPlanningOpe_Status;
        private string lPOSPlanningOpe_CreateBy;
        private DateTime lPOSPlanningOpe_DateBy;
        private string lPOSPlanningOpe_ModiBy;
        private DateTime lPOSPlanningOpe_DateModiBy;

        //Defino las propiedades de los atributos

        public int id_POSPlanningOpe
        {
            get { return this.lid_POSPlanningOpe; }
            set { this.lid_POSPlanningOpe = value; }
        }

        public int id_MPOSPlanning
        {
            get { return this.lid_MPOSPlanning; }
            set { this.lid_MPOSPlanning = value; }
        }

        public string id_Planning
        {
            get { return this.lid_Planning; }
            set { this.lid_Planning = value; }
        }

        public int Person_id
        {
            get { return this.lPerson_id; }
            set { this.lPerson_id = value; }
        }

        public DateTime POSPlanningOpe_Fechainicio
        {
            get { return this.lPOSPlanningOpe_Fechainicio; }
            set { this.lPOSPlanningOpe_Fechainicio = value; }
        }

        public DateTime POSPlanningOpe_Fechafin
        {
            get { return this.lPOSPlanningOpe_Fechafin; }
            set { this.lPOSPlanningOpe_Fechafin = value; }
        }

        /// <summary>
        /// Se Agrega esta Propiedad
        /// Ing. Carlos Hernandez
        /// Fecha:13/07/2011
        /// </summary>
        public int Frecuencia
        {
            get { return this.lFrecuencia; }
            set { this.lFrecuencia = value; }
        }

        public bool POSPlanningOpe_Status
        {
            get { return this.lPOSPlanningOpe_Status; }
            set { this.lPOSPlanningOpe_Status = value; }
        }

        public string POSPlanningOpe_CreateBy
        {
            get { return this.lPOSPlanningOpe_CreateBy; }
            set { this.lPOSPlanningOpe_CreateBy = value; }
        }

        public DateTime POSPlanningOpe_DateBy
        {
            get { return this.lPOSPlanningOpe_DateBy; }
            set { this.lPOSPlanningOpe_DateBy = value; }
        }

        public string POSPlanningOpe_ModiBy
        {
            get { return this.lPOSPlanningOpe_ModiBy; }
            set { this.lPOSPlanningOpe_ModiBy = value; }
        }

        public DateTime POSPlanningOpe_DateModiBy
        {
            get { return this.lPOSPlanningOpe_DateModiBy; }
            set { this.lPOSPlanningOpe_DateModiBy = value; }
        }
    }
}
