using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ESectlr
    /// Creada Por:         Ing. Magaly Jiménez
    /// Fecha de Creación:  15/09/2010
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Sector
    ///                     permite al administrador del sistema gestionar las sectores, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar sectores.
    /// </summary>
    public class ESector
    {
        public ESector()
        {
            //Se define el constructor por defecto
        }

        private int lid_sector;
        private int lid_malla;
        private string lSector;
        private bool lSector_Status;
        private string lSector_CreateBy;
        private DateTime lSector_DateBy;
        private string lSector_ModiBy;
        private DateTime lSector_DateModiBy;

        public int id_sector
        {
            get { return this.lid_sector; }
            set { this.lid_sector = value; }
        }
        public int id_malla
        {
            get { return this.lid_malla; }
            set { this.lid_malla = value; }
        }
        public string Sector
        {
            get { return this.lSector; }
            set { this.lSector = value; }
        }
        public bool Sector_Status
        {
            get { return this.lSector_Status; }
            set { this.lSector_Status = value; }
        }
        public string Sector_CreateBy
        {
            get { return this.lSector_CreateBy; }
            set { this.lSector_CreateBy = value; }
        }
        public DateTime Sector_DateBy
        {
            get { return this.lSector_DateBy; }
            set { this.lSector_DateBy = value; }
        }
        public string Sector_ModiBy
        {
            get { return this.lSector_ModiBy; }
            set { this.lSector_ModiBy = value; }
        }
        public DateTime Sector_DateModiBy
        {
            get { return this.lSector_DateModiBy; }
            set { this.lSector_DateModiBy = value; }
        }
    }
}
