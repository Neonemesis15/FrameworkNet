using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>

    /// Clase:              EProducts_PlanningOpe
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  16/02/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Products_PlanningOpe
    ///                     permite al supervisor gestionar la asignación de productos a personal operativo, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Asignación de productos a operativo.
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>

    public class EProducts_PlanningOpe
    {
        public EProducts_PlanningOpe()
        {
            //Se define el contructor por defecto
        }

        //Aqui se definen los atributos
        private int lid_Products_PlanningOpe;
        private int lid_ProductsPlanning;
        private string lid_Planning;
        private int lPerson_id;
        private bool lProducts_PlanningOpe_Status;
        private string lProducts_PlanningOpe_CreateBy;
        private DateTime lProducts_PlanningOpe_DateBy;
        private string lProducts_PlanningOpe_ModiBy;
        private DateTime lProducts_PlanningOpe_DateModiBy;

        //Defino las propiedades de los atributos

        public int id_Products_PlanningOpe
        {
            get { return this.lid_Products_PlanningOpe; }
            set { this.lid_Products_PlanningOpe = value; }
        }
        public int id_ProductsPlanning
        {
            get { return this.lid_ProductsPlanning; }
            set { this.lid_ProductsPlanning = value; }
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
        public bool Products_PlanningOpe_Status
        {
            get { return this.lProducts_PlanningOpe_Status; }
            set { this.lProducts_PlanningOpe_Status = value; }
        }
        public string Products_PlanningOpe_CreateBy
        {
            get { return this.lProducts_PlanningOpe_CreateBy; }
            set { this.lProducts_PlanningOpe_CreateBy = value; }
        }
        public DateTime Products_PlanningOpe_DateBy
        {
            get { return this.lProducts_PlanningOpe_DateBy; }
            set { this.lProducts_PlanningOpe_DateBy = value; }
        }
        public string Products_PlanningOpe_ModiBy
        {
            get { return this.lProducts_PlanningOpe_ModiBy; }
            set { this.lProducts_PlanningOpe_ModiBy = value; }
        }
        public DateTime Products_PlanningOpe_DateModiBy
        {
            get { return this.lProducts_PlanningOpe_DateModiBy; }
            set { this.lProducts_PlanningOpe_DateModiBy = value; }
        }

    }
}
