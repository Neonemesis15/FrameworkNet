using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción breve de DEMPop.
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate:27/05/2009
    /// Requerimiento:

    public class DEMPop
    {
        private Conexion oConn;
        public DEMPop()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        //Método para Registrar Material POP
        //Se agrego el parametro idtipoMa - 27/05/2011 Angel Ortiz
        public EMPop RegistrarMPOPPK(string idtipoMa, string sPOPname, string sPOPdescription, bool bStatus, string sMPointOfPurchaseCreateBy, DateTime tMPointOfPurchaseDateBy, string sMPointOfPurchaseModiBy, DateTime tMPointOfPurchaseDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERMPOP", idtipoMa, sPOPname, sPOPdescription, bStatus, sMPointOfPurchaseCreateBy, tMPointOfPurchaseDateBy, sMPointOfPurchaseModiBy, tMPointOfPurchaseDateModiBy);
            EMPop oerMPOP = new EMPop();
            oerMPOP.idtipoMa = idtipoMa;
            oerMPOP.POPname = sPOPname;
            oerMPOP.POPdescription = sPOPdescription;
            oerMPOP.Status = bStatus;
            oerMPOP.MPointOfPurchaseCreateBy = sMPointOfPurchaseCreateBy;
            oerMPOP.MPointOfPurchaseDateBy = tMPointOfPurchaseDateBy;
            oerMPOP.MPointOfPurchaseModiBy = sMPointOfPurchaseModiBy;
            oerMPOP.MPointOfPurchaseDateModiBy = tMPointOfPurchaseDateModiBy;

            return oerMPOP;
        }

        //Método para Actualizar Material POP
        //Se agrego el parametro idtipoMa - 27/05/2011 Angel Ortiz
        public EMPop Actualizar_MPOP(int iid_MPointOfPurchase, string idtipoMa, string sPOPname, string sPOPdescription, bool bStatus, string sMPointOfPurchaseModiBy, DateTime tMPointOfPurchaseDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_MPOP", idtipoMa, iid_MPointOfPurchase,sPOPname, sPOPdescription, bStatus, sMPointOfPurchaseModiBy, tMPointOfPurchaseDateModiBy);
            EMPop oeaMPOP = new EMPop();
            oeaMPOP.idMPointOfPurchase = iid_MPointOfPurchase;
            oeaMPOP.idtipoMa = idtipoMa; 
            oeaMPOP.POPname = sPOPname;
            oeaMPOP.POPdescription = sPOPdescription;
            oeaMPOP.Status = bStatus;
            oeaMPOP.MPointOfPurchaseModiBy = sMPointOfPurchaseModiBy;
            oeaMPOP.MPointOfPurchaseDateModiBy = tMPointOfPurchaseDateModiBy;

            return oeaMPOP;
        }

        /// <summary>
        ///Nombre Metodo: SEARCHMPOP
        ///Función: Permite Consultar material POP
        ///Se agrego el parametro idtipoMa - 27/05/2011 Angel Ortiz
        /// </summary>

        public DataTable ObtenerMPOP(string sPOPname)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHMPOP", sPOPname);
            EMPop oeMPOP = new EMPop();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeMPOP.idMPointOfPurchase = Convert.ToInt32(dt.Rows[i]["id_MPointOfPurchase"].ToString().Trim());
                        oeMPOP.idtipoMa = dt.Rows[i]["idtipoMa"].ToString().Trim();
                        oeMPOP.POPname = dt.Rows[i]["POP_name"].ToString().Trim();
                        oeMPOP.POPdescription = dt.Rows[i]["POP_description"].ToString().Trim();
                        oeMPOP.Status = Convert.ToBoolean(dt.Rows[i]["Status"].ToString().Trim());
                        oeMPOP.MPointOfPurchaseCreateBy = dt.Rows[i]["MPointOfPurchase_CreateBy"].ToString().Trim();
                        oeMPOP.MPointOfPurchaseDateBy = Convert.ToDateTime(dt.Rows[i]["MPointOfPurchase_DateBy"].ToString().Trim());
                        oeMPOP.MPointOfPurchaseModiBy = dt.Rows[i]["MPointOfPurchase_ModiBy"].ToString().Trim();
                        oeMPOP.MPointOfPurchaseDateModiBy = Convert.ToDateTime(dt.Rows[i]["MPointOfPurchase_DateModiBy"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}
