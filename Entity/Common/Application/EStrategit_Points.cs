using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EStrategit_Points
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  11/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-021 Gestión de Items  de Servicios
    ///                     «Functional» SIGE-ARF-069 Crear Items de Servicios
    ///                     «Functional» SIGE-ARF-070 Consultar Items de Servicios
    ///                     «Functional» SIGE-ARF-071 Actualizar Items de Servicios
    ///                     «Functional» SIGE-ARF-072 Deshabilitar Item de Servicio
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Strategit_Points
    ///                     permite al administrador del sistema gestionar los items de servicio, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar items de servicio.
    ///                     Define las caracteristicas de cada Estrategia usadas por el Negocio de acuerdo a la 
    ///                     Gestión de Estrategias esto quiere decir que permitirá detallar cuales son las característica 
    ///                     de los servicios proveidos por Lucky al cliente.
    /// </summary>
    
    public class EStrategit_Points
    {
        
        private int lid_cod_Point;
        private string lcodPoint;
        private string lDescriptionPoint;
        private int lcodStrategy;
        private int lcompany_id;
        private string lcod_Channel;
        private int lReport_Id;
        private bool lStatusPoint;
        private string lPointCreateBy;
        private string lPointDateBy;
        private string lPointModiBy;
        private string lPointDateModiBy;


        public int idcodPoint
        {
            get { return this.lid_cod_Point; }
            set { this.lid_cod_Point = value; }
        }
        

        public string codPoint
        {
            get { return this.lcodPoint; }
            set { this.lcodPoint=value; }
        }

        public string DescriptionPoint
        {
            get { return this.lDescriptionPoint; }
            set { this.lDescriptionPoint = value; }
        }

        public int codStrategy
        {
            get { return this.lcodStrategy; }
            set { this.lcodStrategy = value; }
        }

        public int company_id
        {
            get { return this.lcompany_id; }
            set { this.lcompany_id = value; }
        }
        public string cod_Channel
        {
            get { return this.lcod_Channel; }
            set { this.lcod_Channel= value; }
        }

        public int Report_Id
        {
            get { return this.lReport_Id; }
            set { this.lReport_Id = value; }
        }

        public bool StatusPoint
        {
            get { return this.lStatusPoint; }
            set { this.lStatusPoint = value; }
        }

        public string PointCreateBy
        {
            get { return this.lPointCreateBy; }
            set { this.lPointCreateBy = value; }
        }

        public string PointDateBy
        {
            get { return this.lPointDateBy; }
            set { this.lPointDateBy = value; }
        }

        public string PointModiBy
        {
            get { return this.lPointModiBy; }
            set { this.lPointModiBy = value; }
        }

        public string PointDateModiBy
        {
            get { return this.lPointDateModiBy; }
            set { this.lPointDateModiBy = value; }
        }
    }
}