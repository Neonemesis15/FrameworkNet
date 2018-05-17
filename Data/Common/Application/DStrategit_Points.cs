using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DStrategitPoints.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:27/05/2009
    /// Requerimiento:
    public class DStrategit_Points
    {
        private Conexion oConn; 
        public DStrategit_Points()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        //Método para Registrar Items de Servicios

        public EStrategit_Points RegistrarItemsServPK(string scod_Point, string sDescription_Point, int icod_Strategy, int icompany_id, string scod_Channel, int iReport_Id, bool bStatus_Point, string sPoint_CreateBy, string sPoint_DateBy, string sPoint_ModiBy, string sPoint_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERITEMSSERVICES", scod_Point, sDescription_Point, icod_Strategy,icompany_id, scod_Channel, iReport_Id, bStatus_Point, sPoint_CreateBy, sPoint_DateBy, sPoint_ModiBy, sPoint_DateModiBy);
            EStrategit_Points oerItemsServicios = new EStrategit_Points();
            oerItemsServicios.codPoint = scod_Point;
            oerItemsServicios.DescriptionPoint = sDescription_Point;
            oerItemsServicios.codStrategy = icod_Strategy;
            oerItemsServicios.company_id = icompany_id;
            oerItemsServicios.cod_Channel = scod_Channel;
            oerItemsServicios.Report_Id = iReport_Id;
            oerItemsServicios.StatusPoint = bStatus_Point;
            oerItemsServicios.PointCreateBy = sPoint_CreateBy;
            oerItemsServicios.PointDateBy = sPoint_DateBy;
            oerItemsServicios.PointModiBy = sPoint_ModiBy;
            oerItemsServicios.PointDateModiBy = sPoint_DateModiBy;
            return oerItemsServicios;
        }

        /// <summary>
        ///Nombre Metodo: Search_ItemsServicios 
        ///Función: Permite Consultar servicios Lucky
        /// </summary>

        public DataTable ObtenerItemServicios(int iCodStrategy, int icompanyid)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHITEMSSERVICIOS", iCodStrategy,icompanyid);
            EStrategit_Points oeStrategyPoint = new EStrategit_Points();
            EEstrategy oeEstrategy = new EEstrategy();
           

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeStrategyPoint.idcodPoint = Convert.ToInt32(dt.Rows[i]["id_cod_Point"].ToString().Trim());
                        oeStrategyPoint.codPoint = dt.Rows[i]["cod_Point"].ToString().Trim();
                        oeStrategyPoint.DescriptionPoint = dt.Rows[i]["Description_Point"].ToString().Trim();
                        oeEstrategy.codCountry = dt.Rows[i]["cod_Country"].ToString().Trim();
                        oeStrategyPoint.codStrategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"].ToString().Trim());
                        oeStrategyPoint.company_id = Convert.ToInt32(dt.Rows[i]["company_id"].ToString().Trim());
                        oeStrategyPoint.cod_Channel = dt.Rows[i]["cod_Channel"].ToString().Trim();                        
                        oeStrategyPoint.Report_Id = Convert.ToInt32(dt.Rows[i]["Report_Id"].ToString().Trim());
                        oeStrategyPoint.StatusPoint = Convert.ToBoolean(dt.Rows[i]["Status_Point"].ToString().Trim());
                        oeStrategyPoint.PointCreateBy = dt.Rows[i]["Point_CreateBy"].ToString().Trim();
                        oeStrategyPoint.PointDateBy = dt.Rows[i]["Point_DateBy"].ToString().Trim();
                        oeStrategyPoint.PointModiBy = dt.Rows[i]["Point_ModiBy"].ToString().Trim();
                        oeStrategyPoint.PointDateModiBy = dt.Rows[i]["Point_DateModiBy"].ToString().Trim();
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        //Método para Actualizar Items de Servicios

        public EStrategit_Points Actualizar_ItemsServicios(int iid_codPoint,string scod_Point, string sDescription_Point, int icod_Strategy, int icompany_id, string scod_Channel , int iReport_Id, bool bStatus_Point, string sPoint_ModiBy, string sPoint_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_ITEMSSERVICES", iid_codPoint,scod_Point, sDescription_Point, icod_Strategy, icompany_id, scod_Channel, iReport_Id, bStatus_Point, sPoint_ModiBy, sPoint_DateModiBy);
            EStrategit_Points oeaItemsServicios = new EStrategit_Points();
            oeaItemsServicios.idcodPoint = iid_codPoint;
            oeaItemsServicios.codPoint = scod_Point;
            oeaItemsServicios.DescriptionPoint = sDescription_Point;
            oeaItemsServicios.codStrategy = icod_Strategy;
            oeaItemsServicios.company_id = icompany_id;
            oeaItemsServicios.cod_Channel = scod_Channel;            
            oeaItemsServicios.Report_Id = iReport_Id;
            oeaItemsServicios.StatusPoint = bStatus_Point;
            oeaItemsServicios.PointModiBy = sPoint_ModiBy;
            oeaItemsServicios.PointDateModiBy = sPoint_DateModiBy;
            return oeaItemsServicios;
        }

    }
}

         