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
    /// Clase de servicios Lucky
    /// Create By: Ing Mauricio Ortiz
    /// Fecha de Creación: 27/05/2009
    /// requerimiento:
    /// </summary>
    public class Estrategy
    {
        public Estrategy()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        //----Metodo que permite registrar Servicios

        public EEstrategy RegistrarServicios(string sStrategyName, string sStrategyDescription, string scodCountry, bool sStrategyStatus, string sStrategyCreateBy, string sStrategyDateBy, string sStrategyModiBy, string sStrategyDateModiBy)
        {
            Lucky.Data.Common.Application.DEstrategy odrservicios = new Lucky.Data.Common.Application.DEstrategy();
            EEstrategy oeservicios = odrservicios.RegistrarServiciosPK(sStrategyName, sStrategyDescription, scodCountry, sStrategyStatus, sStrategyCreateBy, sStrategyDateBy, sStrategyModiBy, sStrategyDateModiBy);
            odrservicios = null;
            return oeservicios;
        }

        //----Metodo que permite Actualizar Servicios Ing. Carlos Alberto Hernandez

        public EEstrategy Actualizar_Servicios(int icodstrategy, string sStrategyName, string sStrategyDescription, string scodCountry, bool sStrategyStatus, string sStrategyModiBy, string sStrategyDateModiBy)
        {
            Lucky.Data.Common.Application.DEstrategy odaservicios = new Lucky.Data.Common.Application.DEstrategy();
            EEstrategy oeaservicios = odaservicios.Actualizar_Servicios(icodstrategy, sStrategyName, sStrategyDescription, scodCountry, sStrategyStatus, sStrategyModiBy, sStrategyDateModiBy);
            odaservicios = null;
            return oeaservicios;
        }

        //----Metodo que permite registrar Items de Servicios

        public EStrategit_Points RegistrarItemsServicios(string scod_Point, string sDescription_Point, int icod_Strategy, int icompany_id, string scod_Channel, int iReport_Id, bool bStatus_Point, string sPoint_CreateBy, string sPoint_DateBy, string sPoint_ModiBy, string sPoint_DateModiBy)
        {
            Lucky.Data.Common.Application.DStrategit_Points odritemsservicios = new Lucky.Data.Common.Application.DStrategit_Points();
            EStrategit_Points oeitemsservicios = odritemsservicios.RegistrarItemsServPK(scod_Point,sDescription_Point, icod_Strategy, icompany_id, scod_Channel, iReport_Id, bStatus_Point, sPoint_CreateBy, sPoint_DateBy, sPoint_ModiBy, sPoint_DateModiBy);
            odritemsservicios = null;
            return oeitemsservicios;        
        }

        //----Metodo que permite Actualizar Items de Servicios

        public EStrategit_Points Actualizar_ItemsServicios(int iid_codPoint,string scod_Point, string sDescription_Point, int icod_Strategy, int icompany_id, string scod_Channel, int iReport_Id, bool bStatus_Point, string sPoint_ModiBy, string sPoint_DateModiBy)
        {
            Lucky.Data.Common.Application.DStrategit_Points odaitemsservicios = new Lucky.Data.Common.Application.DStrategit_Points();
            EStrategit_Points oeaitemsservicios = odaitemsservicios.Actualizar_ItemsServicios(iid_codPoint,scod_Point, sDescription_Point, icod_Strategy, icompany_id, scod_Channel, iReport_Id, bStatus_Point, sPoint_ModiBy, sPoint_DateModiBy);
            odaitemsservicios = null;
            return oeaitemsservicios;
        }

        //---Metodo de Consulta de Servicios

        public DataTable BuscarServicios(string sStrategyName, string scodcountry)
        {
            Lucky.Data.Common.Application.DEstrategy odsestrategias = new Lucky.Data.Common.Application.DEstrategy();
            EEstrategy oeestrategias = new EEstrategy();
            DataTable dtServicios = odsestrategias.ObtenerServicios(sStrategyName, scodcountry);
            odsestrategias = null;
            return dtServicios;
        }

        //---Metodo de Consulta de Items de Servicios

        public DataTable BuscarItemServicios(int iCodStrategy, int icompanyid )
        {
            Lucky.Data.Common.Application.DStrategit_Points odseStrategyPoint = new Lucky.Data.Common.Application.DStrategit_Points();
            EStrategit_Points oeStrategyPoint = new EStrategit_Points();
            DataTable dtItemServicios = odseStrategyPoint.ObtenerItemServicios(iCodStrategy, icompanyid);

            odseStrategyPoint = null;
            return dtItemServicios;
        }            
    }
}
