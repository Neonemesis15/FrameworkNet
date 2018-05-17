using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Segments_Type
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 16/09/2009
    /// Description: Establece los metodos para operar informacion relacionada con Tipos de segmento Lucky
    /// Requerimiento No:
    /// </summary>
    /// 
    public class Segments_Type
    {
        public Segments_Type()
        {
            //Se define el constructor por defecto
        }

        //Método que permite registrar Tipos de segmento  Ing. Mauricio Ortiz
        public ESegments_Type RegistrarSegmentsType(string sSegment_Type, string sSegment_Description, bool bSegmentType_Status,
            string sSegmentType_CreateBy, DateTime tSegmentType_DateBy, string sSegmentType_ModiBy, DateTime tSegmentType_DateModiBy)
        {
            DSegments_Type odrSegmentsType = new DSegments_Type();
            ESegments_Type oeSegmentsType = odrSegmentsType.RegistrarSegmentsTypePK(sSegment_Type, sSegment_Description, bSegmentType_Status,
             sSegmentType_CreateBy, tSegmentType_DateBy, sSegmentType_ModiBy, tSegmentType_DateModiBy);
            odrSegmentsType = null;
            return oeSegmentsType;
        }

        //---Metodo de Consulta de tipos de segmento Ing. Mauricio Ortiz

        public DataTable BuscarSegmentsType(string sSegment_Type)
        {
            DSegments_Type odseSegmentsType = new DSegments_Type();
            ESegments_Type oeSegmentsType = new ESegments_Type();

            DataTable dtSegmentsType = odseSegmentsType.ObtenerSegmentsType(sSegment_Type);
            odseSegmentsType = null;
            return dtSegmentsType;
        }

        //----Metodo que permite Actualizar tipos de segmentos Ing. Mauricio Ortiz

        public ESegments_Type Actualizar_SegmentsType(int iid_SegmentsType, string sSegment_Type, string sSegment_Description, bool bSegmentType_Status,
            string sSegmentType_ModiBy, DateTime tSegmentType_DateModiBy)
        {
            DSegments_Type odaSegmentsType = new DSegments_Type();
            ESegments_Type oeaSegmentsType = odaSegmentsType.Actualizar_SegmentsType(iid_SegmentsType, sSegment_Type, sSegment_Description, bSegmentType_Status,
            sSegmentType_ModiBy, tSegmentType_DateModiBy);
            odaSegmentsType = null;
            return oeaSegmentsType;
        }
    }
}
        