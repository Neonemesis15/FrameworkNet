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
    /// Clase: Segments
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 16/09/2009
    /// Description: Establece los metodos para operar informacion relacionada con Segmento Lucky
    /// Requerimiento No:
    /// </summary>
    /// 

    public class Segments
    {
        public Segments()
        {
            //Se define el constructor por defecto
        }
        //Método que permite registrar segmento  Ing. Mauricio Ortiz
        public ESegments RegistrarSegments(string sSegment_Name, int iid_SegmentsType, bool bSegment_Status,
            string sSegment_CreateBy, DateTime tSegment_DateBy, string sSegment_ModiBy, DateTime tSegment_DateModiBy)
        {
            DSegments odrSegments = new DSegments();
            ESegments oeSegments = odrSegments.RegistrarSegments(sSegment_Name, iid_SegmentsType, bSegment_Status,
                sSegment_CreateBy, tSegment_DateBy, sSegment_ModiBy, tSegment_DateModiBy);
            odrSegments = null;
            return oeSegments;
        }

        //---Metodo de Consulta de segmento Ing. Mauricio Ortiz

        public DataTable BuscarSegments(int iid_SegmentsType)
        {
            DSegments odseSegments = new DSegments();
            ESegments oeSegments = new ESegments();

            DataTable dtSegments = odseSegments.ObtenerSegments(iid_SegmentsType);
            odseSegments = null;
            return dtSegments;
        }

        //---Metodo de Consulta de segmento para actualizar Ing. Mauricio Ortiz

        public DataTable BuscarSegmentsActual(string sSegment_Name, int iid_SegmentsType)
        {
            DSegments odseSegments = new DSegments();
            ESegments oeSegments = new ESegments();

            DataTable dtSegments = odseSegments.ObtenerSegmentsActual(sSegment_Name, iid_SegmentsType);
            odseSegments = null;
            return dtSegments;
        }

        //----Metodo que permite Actualizar segmentos Ing. Mauricio Ortiz

        public ESegments Actualizar_Segments(int iid_Segment, int iid_SegmentsType, bool bSegment_Status,
            string sSegment_ModiBy, DateTime tSegment_DateModiBy)
        {
            DSegments odaSegments = new DSegments();
            ESegments oeaSegments = odaSegments.Actualizar_Segments(iid_Segment, iid_SegmentsType, bSegment_Status,
            sSegment_ModiBy, tSegment_DateModiBy);
            odaSegments = null;
            return oeaSegments;
        }


    }
}
