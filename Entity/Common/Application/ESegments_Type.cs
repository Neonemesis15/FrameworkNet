using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              ESegments_Type
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  16/09/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Segments_Type
    ///                     permite al administrador del sistema gestionar los tipos de segmento, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar tipos de segmento.
    /// </summary>
     
    public class ESegments_Type
    {
    
        public ESegments_Type()
        {
            // Se define el constructor por defecto
        }

        private int lid_SegmentsType;
        private string lSegment_Type;
        private string lSegment_Description;
        private bool lSegmentType_Status;
        private string lSegmentType_CreateBy;
        private DateTime lSegmentType_DateBy;
        private string lSegmentType_ModiBy;
        private DateTime lSegmentType_DateModiBy;

        public int id_SegmentsType
        {
            get { return this.lid_SegmentsType; }
            set { this.lid_SegmentsType = value; }
        }
        public string Segment_Type
        {
            get { return this.lSegment_Type; }
            set { this.lSegment_Type = value; }
        }
        public string Segment_Description
        {
            get { return this.lSegment_Description; }
            set { this.lSegment_Description = value; }
        }
        public bool SegmentType_Status
        {
            get { return this.lSegmentType_Status; }
            set { this.lSegmentType_Status = value; }
        }
        public string SegmentType_CreateBy
        {
            get { return this.lSegmentType_CreateBy; }
            set { this.lSegmentType_CreateBy = value; }
        }
        public DateTime SegmentType_DateBy
        {
            get { return this.lSegmentType_DateBy; }
            set { this.lSegmentType_DateBy = value; }
        }
        public string SegmentType_ModiBy
        {
            get { return this.lSegmentType_ModiBy; }
            set { this.lSegmentType_ModiBy = value; }
        }
        public DateTime SegmentType_DateModiBy
        {
            get { return this.lSegmentType_DateModiBy; }
            set { this.lSegmentType_DateModiBy = value; }
        }
    }
}
        
