using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DItemsPoints.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:02/06/2009
    /// Requerimiento:

    public class DItemsPoint
    {
        private Conexion oConn;

        public DItemsPoint()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Método para Registrar Items de Formatos

        public EItemsPoint RegistrarItemsFormPK(int iid_cod_point, string scod_Point, int icod_Strategy, string sItem_Description, int iid_Ubicación, bool bState_Item, string sItem_CreateBy, DateTime tItem_DateBy, string sItem_ModiBy, DateTime tItem_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERITEMPOINTS", iid_cod_point, scod_Point, icod_Strategy, sItem_Description, iid_Ubicación, bState_Item, sItem_CreateBy, tItem_DateBy, sItem_ModiBy, tItem_DateModiBy);
            EItemsPoint oerItemsForm = new EItemsPoint();

            oerItemsForm.id_cod_point = iid_cod_point;
            oerItemsForm.cod_Point = scod_Point;
            oerItemsForm.cod_Strategy = icod_Strategy;
            oerItemsForm.Item_Description = sItem_Description;
            oerItemsForm.id_Ubicación = iid_Ubicación;
            oerItemsForm.State_Item = bState_Item;
            oerItemsForm.Item_CreateBy = sItem_CreateBy;
            oerItemsForm.Item_DateBy = tItem_DateBy;
            oerItemsForm.Item_ModiBy = sItem_ModiBy;
            oerItemsForm.Item_DateModiBy = tItem_DateModiBy;

            return oerItemsForm;
        }

        /// <summary>
        ///Nombre Metodo: SEARCHESTRUCTURA
        ///Función: Permite Consultar estructura de formato
        /// </summary>

        public DataTable ObtenerEstructura(int iCodStrategy, string sdescription)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHESTRUCTURA", iCodStrategy, sdescription);
            EItemsPoint oeEstructura = new EItemsPoint();
            



            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeEstructura.cod_Item = Convert.ToInt32(dt.Rows[i]["cod_Item"].ToString().Trim());
                        oeEstructura.id_cod_point = Convert.ToInt32(dt.Rows[i]["id_cod_Point"].ToString().Trim());
                        oeEstructura.Description_Point = dt.Rows[i]["Description_Point"].ToString().Trim();                                                
                        oeEstructura.cod_Point = dt.Rows[i]["cod_Point"].ToString().Trim();
                        oeEstructura.cod_Strategy = Convert.ToInt32(dt.Rows[i]["cod_Strategy"].ToString().Trim());
                        oeEstructura.Item_Description = dt.Rows[i]["Item_Description"].ToString().Trim();                        
                        oeEstructura.State_Item = Convert.ToBoolean(dt.Rows[i]["State_Item"].ToString().Trim());
                        oeEstructura.Item_CreateBy = dt.Rows[i]["Item_CreateBy"].ToString().Trim();
                        oeEstructura.Item_DateBy = Convert.ToDateTime(dt.Rows[i]["Item_DateBy"].ToString().Trim());
                        oeEstructura.Item_ModiBy = dt.Rows[i]["Item_ModiBy"].ToString().Trim();
                        oeEstructura.Item_DateModiBy = Convert.ToDateTime(dt.Rows[i]["Item_DateModiBy"].ToString().Trim());
                        oeEstructura.id_Ubicación = Convert.ToInt32(dt.Rows[i]["id_Ubicación"].ToString().Trim());
                        oeEstructura.company_id = Convert.ToInt32(dt.Rows[i]["company_id"].ToString().Trim());
                        oeEstructura.cod_Country = dt.Rows[i]["cod_Country"].ToString().Trim();
                        oeEstructura.cod_Channel = dt.Rows[i]["cod_Channel"].ToString().Trim();
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Método para Actualizar Items Points  Ing. Mauricio Ortiz

        public EItemsPoint Actualizar_itemPoint(int icod_Item, string sItem_Description, int iid_Ubicación, bool bState_Item, string sItem_ModiBy, DateTime tItem_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_ITEMSPOINT", icod_Item, sItem_Description, iid_Ubicación, bState_Item, sItem_ModiBy, tItem_DateModiBy);
            EItemsPoint oeaitemPoint = new EItemsPoint();

            oeaitemPoint.Item_Description = sItem_Description;
            oeaitemPoint.id_Ubicación = iid_Ubicación;
            oeaitemPoint.State_Item = bState_Item;
            oeaitemPoint.Item_ModiBy = sItem_ModiBy;
            oeaitemPoint.Item_DateModiBy = tItem_DateModiBy;
            return oeaitemPoint;
        }
    }
}
     