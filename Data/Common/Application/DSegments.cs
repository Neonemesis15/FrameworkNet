using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción metodos transaccionales de Segments
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:16/09/2009
    /// Requerimiento:

    public class DSegments
    {
        private Conexion oConn;
        public DSegments()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        ///Metodo para Registrar segmentos

        public ESegments RegistrarSegments(string sSegment_Name, int iid_SegmentsType, bool bSegment_Status,
            string sSegment_CreateBy, DateTime tSegment_DateBy, string sSegment_ModiBy, DateTime tSegment_DateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERSEGMENTS", sSegment_Name, iid_SegmentsType, bSegment_Status,
             sSegment_CreateBy, tSegment_DateBy, sSegment_ModiBy, tSegment_DateModiBy);
            ESegments oerSegments = new ESegments();
            oerSegments.Segment_Name = sSegment_Name;
            oerSegments.id_SegmentsType = iid_SegmentsType;
            oerSegments.Segment_Status = bSegment_Status;
            oerSegments.Segment_CreateBy = sSegment_CreateBy;
            oerSegments.Segment_DateBy = tSegment_DateBy;
            oerSegments.Segment_ModiBy = sSegment_ModiBy;
            oerSegments.Segment_DateModiBy = tSegment_DateModiBy;
            return oerSegments;
        }


        //Método que Permite Consultar segmentos
        public DataTable ObtenerSegments(int iid_SegmentsType)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHSEGMENTS", iid_SegmentsType);
            ESegments oeSegments = new ESegments();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeSegments.id_Segment = Convert.ToInt32(dt.Rows[i]["id_Segment"].ToString().Trim());
                        oeSegments.Segment_Name = dt.Rows[i]["Segment_Name"].ToString().Trim();
                        oeSegments.id_SegmentsType = Convert.ToInt32(dt.Rows[i]["id_SegmentsType"].ToString().Trim());
                        oeSegments.Segment_Status = Convert.ToBoolean(dt.Rows[i]["Segment_Status"].ToString().Trim());
                        oeSegments.Segment_CreateBy = dt.Rows[i]["Segment_CreateBy"].ToString().Trim();
                        oeSegments.Segment_DateBy = Convert.ToDateTime(dt.Rows[i]["Segment_DateBy"].ToString().Trim());
                        oeSegments.Segment_ModiBy = dt.Rows[i]["Segment_ModiBy"].ToString().Trim();
                        oeSegments.Segment_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Segment_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Método que Permite Consultar segmentos para actualizar
        public DataTable ObtenerSegmentsActual(string sSegment_Name, int iid_SegmentsType)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHPSEGMENTSACTUAL", sSegment_Name, iid_SegmentsType);
            ESegments oeSegments = new ESegments();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeSegments.id_Segment = Convert.ToInt32(dt.Rows[i]["id_Segment"].ToString().Trim());
                        oeSegments.Segment_Name = dt.Rows[i]["Segment_Name"].ToString().Trim();
                        oeSegments.id_SegmentsType = Convert.ToInt32(dt.Rows[i]["id_SegmentsType"].ToString().Trim());
                        oeSegments.Segment_Status = Convert.ToBoolean(dt.Rows[i]["Segment_Status"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Método para Actualizar Segments

        public ESegments Actualizar_Segments(int iid_Segment, int iid_SegmentsType, bool bSegment_Status,
            string sSegment_ModiBy, DateTime tSegment_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZA_SEGMENTS", iid_Segment, iid_SegmentsType, bSegment_Status,
                sSegment_ModiBy, tSegment_DateModiBy);
            ESegments oeaSegments = new ESegments();
            oeaSegments.id_Segment = iid_Segment;
            oeaSegments.id_SegmentsType = iid_SegmentsType;
            oeaSegments.Segment_Status = bSegment_Status;
            oeaSegments.Segment_ModiBy = sSegment_ModiBy;
            oeaSegments.Segment_DateModiBy = tSegment_DateModiBy;
            return oeaSegments;
        }
    }
}

            