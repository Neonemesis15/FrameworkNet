using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase: EMetadataSpaceMeasurement_Planning
    /// Creado Por: Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación: 28/09/2009
    /// Descripción: Define los atributos y propiedades de la clase MetadataCoverage_Planning
    /// Requerimiento<>
    /// Modificacion    : 28/07/2010 Se modifica tipo de dato para el campo id_planning de tipo int pasa a string . Ing Mauricio Ortiz
    /// </summary>
    public class EMetadataSpaceMeasurement_Planning
    {
        public EMetadataSpaceMeasurement_Planning()
        {

            //Se define el constructor por defecto

        }

        private int lidmetaspace;
        private int lobjectid;
        private string lidplanning;
        private int lidindicador;
        private int lcolumnid;
        private string lSymbolName;
        private string lOperating;
        private string lFormula;
        private string lReformulation;
        private string lOrigenDatos;
        private string lmetaspaceCreateBy;
        private DateTime lmetaspaceDateBy;
        private string lmetaspaceModiBy;
        private DateTime lmetaspaceDateModiBy;

        public int idmetaspace
        {
            get { return this.lidmetaspace; }
            set { this.lidmetaspace = value; }



        }

        public int objectid
        {
            get { return this.lobjectid; }
            set { this.lobjectid = value; }



        }

        public string idplanning
        {
            get { return this.lidplanning; }
            set { this.lidplanning = value; }



        }

        public int idindicador
        {
            get { return this.lidindicador; }
            set { this.lidindicador = value; }



        }

        public int columnid
        {
            get { return this.lcolumnid; }
            set { this.lcolumnid = value; }



        }

        public string SymbolName
        {
            get { return this.lSymbolName; }
            set { this.lSymbolName = value; }



        }

        public string Operating
        {
            get { return this.lOperating; }
            set { this.lOperating = value; }



        }

        public string Formula
        {
            get { return this.lFormula; }
            set { this.lFormula = value; }



        }

        public string Reformulation
        {
            get { return this.lReformulation; }
            set { this.lReformulation = value; }



        }
        public string OrigenDatos
        {
            get { return this.lOrigenDatos; }
            set { this.lOrigenDatos = value; }



        }
        public string metaspaceCreateBy
        {
            get { return this.lmetaspaceCreateBy; }
            set { this.lmetaspaceCreateBy = value; }



        }

        public DateTime metaspaceDateBy
        {
            get { return this.lmetaspaceDateBy; }
            set { this.lmetaspaceDateBy = value; }



        }

        public string metaspaceModiBy
        {
            get { return this.lmetaspaceModiBy; }
            set { this.lmetaspaceModiBy = value; }



        }

        public DateTime metaspaceDateModiBy
        {
            get { return this.lmetaspaceDateModiBy; }
            set { this.lmetaspaceDateModiBy = value; }



        }


    }
}
