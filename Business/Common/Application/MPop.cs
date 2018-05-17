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
    /// Clase de material POP Lucky
    /// Create By: Ing Mauricio Ortiz
    /// Fecha de Creación: 27/05/2009
    /// requerimiento:
    /// </summary>

    public class MPop
    {
        public MPop()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        //----Metodo que permite registrar Material POP
        //----Se agrega parametro idtipoMa - 27/05/2011 Angel Ortiz
        public EMPop RegistrarMPOP(string idtipoMa, string sPOPname, string sPOPdescription, bool bStatus, string sMPointOfPurchaseCreateBy, DateTime tMPointOfPurchaseDateBy, string sMPointOfPurchaseModiBy, DateTime tMPointOfPurchaseDateModiBy)
        {
            Lucky.Data.Common.Application.DEMPop odrMPOP = new Lucky.Data.Common.Application.DEMPop();
            EMPop oerMPOP = odrMPOP.RegistrarMPOPPK(idtipoMa, sPOPname, sPOPdescription, bStatus, sMPointOfPurchaseCreateBy, tMPointOfPurchaseDateBy, sMPointOfPurchaseModiBy, tMPointOfPurchaseDateModiBy);
            odrMPOP = null;
            return oerMPOP;
        }
        //----Metodo que permite Actualizar Material POP Ing.Carlos Alberto Hernandez 
        //----Se agrega parametro idtipoMa - 27/05/2011 Angel Ortiz
        public EMPop Actualizar_MPOP(int iid_MPointOfPurchase, string idtipoMa, string sPOPname, string sPOPdescription, bool bStatus, string sMPointOfPurchaseModiBy, DateTime tMPointOfPurchaseDateModiBy)
        {
            Lucky.Data.Common.Application.DEMPop odaMPOP = new Lucky.Data.Common.Application.DEMPop();
            EMPop oeaMPOP = odaMPOP.Actualizar_MPOP(iid_MPointOfPurchase, idtipoMa, sPOPname, sPOPdescription, bStatus, sMPointOfPurchaseModiBy, tMPointOfPurchaseDateModiBy);
            odaMPOP = null;
            return oeaMPOP;
        }

        //---Metodo de Consulta de Material POP

        public DataTable BuscarMPOP(string sPOPname)
        {
            Lucky.Data.Common.Application.DEMPop odseMPOP = new Lucky.Data.Common.Application.DEMPop();
            EMPop oeMPOP = new EMPop();
            DataTable dtMPOP = odseMPOP.ObtenerMPOP(sPOPname);
            odseMPOP = null;
            return dtMPOP;
        }
    }
}
