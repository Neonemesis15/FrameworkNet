using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción metodos transaccionales Segments_Type.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:16/09/2009
    /// Requerimiento:

    public class DSegments_Type
    {
        private Conexion oConn;
        public DSegments_Type()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        ///Metodo para Registrar tipos de segmentos
        public ESegments_Type RegistrarSegmentsTypePK(string sSegment_Type, string sSegment_Description, bool bSegmentType_Status,
            string sSegmentType_CreateBy, DateTime tSegmentType_DateBy, string sSegmentType_ModiBy, DateTime tSegmentType_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERSEGMENTSTYPE", sSegment_Type, sSegment_Description, bSegmentType_Status,
             sSegmentType_CreateBy, tSegmentType_DateBy, sSegmentType_ModiBy, tSegmentType_DateModiBy);

            ESegments_Type oerSegmentType = new ESegments_Type();
            oerSegmentType.Segment_Type = sSegment_Type;
            oerSegmentType.Segment_Description = sSegment_Description;
            oerSegmentType.SegmentType_Status = bSegmentType_Status;
            oerSegmentType.SegmentType_CreateBy = sSegmentType_CreateBy;
            oerSegmentType.SegmentType_DateBy = tSegmentType_DateBy;
            oerSegmentType.SegmentType_ModiBy = sSegmentType_ModiBy;
            oerSegmentType.SegmentType_DateModiBy = tSegmentType_DateModiBy;
            return oerSegmentType;
        }

        ///Método para consultar tipos de segmento
        public DataTable ObtenerSegmentsType(string sSegment_Type)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHSEGMENTSTYPE",  sSegment_Type);
            ESegments_Type oeSegmentsType = new ESegments_Type();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeSegmentsType.id_SegmentsType = Convert.ToInt32(dt.Rows[i]["id_SegmentsType"].ToString().Trim());
                        oeSegmentsType.Segment_Type = dt.Rows[i]["Segment_Type"].ToString().Trim();
                        oeSegmentsType.Segment_Description = dt.Rows[i]["Segment_Description"].ToString().Trim();
                        oeSegmentsType.SegmentType_Status = Convert.ToBoolean(dt.Rows[i]["SegmentType_Status"].ToString().Trim());
                        oeSegmentsType.SegmentType_CreateBy = dt.Rows[i]["SegmentType_CreateBy"].ToString().Trim();
                        oeSegmentsType.SegmentType_DateBy = Convert.ToDateTime(dt.Rows[i]["SegmentType_DateBy"].ToString().Trim());
                        oeSegmentsType.SegmentType_ModiBy = dt.Rows[i]["SegmentType_ModiBy"].ToString().Trim();
                        oeSegmentsType.SegmentType_DateModiBy = Convert.ToDateTime(dt.Rows[i]["SegmentType_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        //Método para Actualizar Tipos de segmentos
        public ESegments_Type Actualizar_SegmentsType(int iid_SegmentsType, string sSegment_Type, string sSegment_Description, bool bSegmentType_Status,
            string sSegmentType_ModiBy, DateTime tSegmentType_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_SEGMENTSTYPE", iid_SegmentsType, sSegment_Type, sSegment_Description, bSegmentType_Status,
             sSegmentType_ModiBy, tSegmentType_DateModiBy);

            ESegments_Type oeaSegmentsType = new ESegments_Type();

            oeaSegmentsType.id_SegmentsType = iid_SegmentsType;
            oeaSegmentsType.Segment_Type = sSegment_Type;
            oeaSegmentsType.Segment_Description = sSegment_Description;
            oeaSegmentsType.SegmentType_Status = bSegmentType_Status;
            oeaSegmentsType.SegmentType_ModiBy = sSegmentType_ModiBy;
            oeaSegmentsType.SegmentType_DateModiBy = tSegmentType_DateModiBy;
            return oeaSegmentsType;
        }
    }
}
        
            
        
