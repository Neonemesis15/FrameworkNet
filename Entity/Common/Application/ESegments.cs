using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ESegments
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  15/09/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Segments
    ///                     permite al administrador del sistema gestionar los Segments, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar Segments.
    /// </summary>
    /// 
    public class ESegments
    {
        public ESegments()
        {
            // Se define el constructor por defecto
        }

        private int lid_Segment;
        private string lSegment_Name;        
        private int lid_SegmentsType;
        private bool lSegment_Status;
        private string lSegment_CreateBy;
        private DateTime lSegment_DateBy;
        private string lSegment_ModiBy;
        private DateTime lSegment_DateModiBy;

        public int id_Segment
        {
            get { return this.lid_Segment; }
            set { this.lid_Segment = value; }
        }

        public string Segment_Name
        {
            get { return this.lSegment_Name; }
            set { this.lSegment_Name = value; }
        }       

        public int id_SegmentsType
        {
            get { return this.lid_SegmentsType; }
            set { this.lid_SegmentsType = value; }
        }

        public bool Segment_Status
        {
            get { return this.lSegment_Status; }
            set { this.lSegment_Status = value; }
        }

        public string Segment_CreateBy
        {
            get { return this.lSegment_CreateBy; }
            set { this.lSegment_CreateBy = value; }
        }

        public DateTime Segment_DateBy
        {
            get { return this.lSegment_DateBy; }
            set { this.lSegment_DateBy = value; }
        }

        public string Segment_ModiBy
        {
            get { return this.lSegment_ModiBy; }
            set { this.lSegment_ModiBy = value; }
        }

        public DateTime Segment_DateModiBy
        {
            get { return this.lSegment_DateModiBy; }
            set { this.lSegment_DateModiBy = value; }
        }
    }
}
        

