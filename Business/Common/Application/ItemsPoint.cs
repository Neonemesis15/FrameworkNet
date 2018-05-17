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
    /// Clase: ItemsPoint
    /// CreateBy: Ing. Mauricio Ortiz
    /// DateBy: 02/06/2009
    /// Description: Establece los metodos para operar informacion relacionada con items de formatos por servicio Lucky
    /// Requerimiento No:
    /// </summary>
    /// 
    public class ItemsPoint
    {
        public ItemsPoint()
        {   
            //Se define el constructor por defecto
        }

        //----Metodo que permite registrar items de formatos por servicio

        public EItemsPoint RegistrarItemForm(int iid_cod_point, string scod_Point, int icod_Strategy, string sItem_Description, int iid_Ubicación, bool bState_Item, string sItem_CreateBy, DateTime tItem_DateBy, string sItem_ModiBy, DateTime tItem_DateModiBy)
        {
            DItemsPoint odrItemForm = new DItemsPoint();
            EItemsPoint oeItemForm = odrItemForm.RegistrarItemsFormPK(iid_cod_point, scod_Point, icod_Strategy, sItem_Description, iid_Ubicación, bState_Item, sItem_CreateBy, tItem_DateBy, sItem_ModiBy, tItem_DateModiBy);

            odrItemForm = null;
            return oeItemForm;


        }


        //---Metodo de Consulta de estructura de formatos

        public DataTable BuscarEstructura(int iCodStrategy, string sdescription)
        {
            Lucky.Data.Common.Application.DItemsPoint odseestructura = new Lucky.Data.Common.Application.DItemsPoint();

            EItemsPoint oeEstructura = new EItemsPoint();

            DataTable dtEstructura = odseestructura.ObtenerEstructura(iCodStrategy, sdescription);

            odseestructura = null;
            return dtEstructura;
        }


        //----Metodo que permite Actualizar ItemsPoint Ing. Mauricio Ortiz

        public EItemsPoint Actualizar_itemsPoint(int icod_Item, string sItem_Description, int iid_Ubicación, bool bState_Item, string sItem_ModiBy, DateTime tItem_DateModiBy)
        {
            Lucky.Data.Common.Application.DItemsPoint odaitemPoint = new Lucky.Data.Common.Application.DItemsPoint();


            EItemsPoint oeaitempoint = odaitemPoint.Actualizar_itemPoint(icod_Item, sItem_Description, iid_Ubicación, bState_Item, sItem_ModiBy, tItem_DateModiBy);
            odaitemPoint = null;
            return oeaitempoint;
        }
     

    }
}
