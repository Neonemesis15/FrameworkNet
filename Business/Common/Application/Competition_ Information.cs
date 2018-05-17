using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Competition__Information
    /// Creada Por: Ing. Mauricio Ortiz
    /// Fecha de Creacion; 22/10/2009
    /// Descripcion: Define los metodos del negocio para la clase Competition__Information
    /// Requerimiento No <>
    /// </summary>
    /// 
    public class Competition__Information
    {
        public Competition__Information()
        {
            //Se define el constructor por defecto
        }       

        /// <summary>
        /// Método para registrar información de actividades en el comercio
        /// Modificación : 29/07/2010 se cambia el tipo de dato de id_planning de int a string
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="tcinfo_DateExecution"></param>
        /// <param name="scinfo_nameCompany"></param>
        /// <param name="scinfo_Brand"></param>
        /// <param name="icod_Strategy"></param>
        /// <param name="scinfo_Name_Activity"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="tcinfo_FeciniPromo"></param>
        /// <param name="tcinfo_FecfinPromo"></param>
        /// <param name="scinfo_Vigente"></param>
        /// <param name="icinfo_PersonnelCatid"></param>
        /// <param name="sMecanica"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="scinfo_Comment_Observa"></param>
        /// <param name="binfo_Status"></param>
        /// <param name="scinfo_CreateBy"></param>
        /// <param name="tcinfo_DateBy"></param>
        /// <param name="scinfo_ModiBy"></param>
        /// <param name="tcinfo_DateModiBy"></param>
        /// <returns oerActividadCom></returns>
        public ECompetition__Information RegistrarActividadCom(string sid_planning, DateTime tcinfo_DateExecution,
            string scinfo_nameCompany, string scinfo_Brand, int icod_Strategy, string scinfo_Name_Activity,
            string scod_Channel, DateTime tcinfo_FeciniPromo, DateTime tcinfo_FecfinPromo, string scinfo_Vigente,
            int icinfo_PersonnelCatid, string sMecanica, string sid_ProductCategory, 
            string scinfo_Comment_Observa, bool binfo_Status, string scinfo_CreateBy, DateTime tcinfo_DateBy, string scinfo_ModiBy,
            DateTime tcinfo_DateModiBy)
        {
            DCompetition_Information odrActividadCom = new DCompetition_Information();
            ECompetition__Information oerActividadCom = odrActividadCom.RegistrarActividadCom(sid_planning, tcinfo_DateExecution,
             scinfo_nameCompany, scinfo_Brand, icod_Strategy, scinfo_Name_Activity,
             scod_Channel, tcinfo_FeciniPromo, tcinfo_FecfinPromo, scinfo_Vigente,
             icinfo_PersonnelCatid, sMecanica, sid_ProductCategory, 
             scinfo_Comment_Observa, binfo_Status, scinfo_CreateBy, tcinfo_DateBy, scinfo_ModiBy,
             tcinfo_DateModiBy);
            odrActividadCom = null;
            return oerActividadCom;
        }

        // Método para registrar fotografias de actividades en el comercio
        public ECompetition__Information RegistrarPhotoActividadCom(int iid_cinfo, string sPhotoCI_PathName, bool bPhotoCI_Status,
            string sPhotoCI_CreateBy, DateTime tPhotoCI_DateBy, string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            DCompetition_Information odrPhotoActividadCom = new DCompetition_Information();
            ECompetition__Information oerPhotoActividadCom = odrPhotoActividadCom.RegistrarPhotoActividadCom(iid_cinfo, sPhotoCI_PathName, bPhotoCI_Status,
             sPhotoCI_CreateBy, tPhotoCI_DateBy, sPhotoCI_ModiBy, tPhotoCI_DateModiBy);
            odrPhotoActividadCom = null;
            return oerPhotoActividadCom;
        }

        // Método para registrar POP de actividades en el comercio
        public ECompetition__Information RegistrarPOPActividadCom(int iid_cinfo, int iid_MPointOfPurchase, bool bCI_POP_Status,
            string sCI_POP_CreateBy, DateTime tCI_POP_DateBy, string sCI_POP_ModiBy, DateTime tCI_POP_DateModiBy)
        {
            DCompetition_Information odrPOPActividadCom = new DCompetition_Information();
            ECompetition__Information oerPOPActividadCom = odrPOPActividadCom.RegistrarPOPActividadCom(iid_cinfo, iid_MPointOfPurchase, bCI_POP_Status,
                sCI_POP_CreateBy, tCI_POP_DateBy, sCI_POP_ModiBy, tCI_POP_DateModiBy);
            odrPOPActividadCom = null;
            return oerPOPActividadCom;
        }

        //----Metodo que permite Actualizar Informacion de actividad en el comercio

        public ECompetition__Information ActualizarActividadCom(int iid_cinfo, DateTime tcinfo_DateExecution, string scinfo_nameCompany, string scinfo_Brand,
            int icod_Strategy, string scinfo_Name_Activity, string scod_Channel, DateTime tcinfo_FeciniPromo, DateTime tcinfo_FecfinPromo,
            string scinfo_Vigente, int icinfo_PersonnelCatid, string sMecanica, string sid_ProductCategory, string scinfo_Comment_Observa,
            bool bcinfo_Status, string scinfo_ModiBy, DateTime tcinfo_DateModiBy)
        {
            Lucky.Data.Common.Application.DCompetition_Information odaActividadCom = new Lucky.Data.Common.Application.DCompetition_Information();

            ECompetition__Information oeaActividaCom = odaActividadCom.ActualizarActividadCom(iid_cinfo, tcinfo_DateExecution, scinfo_nameCompany, scinfo_Brand,
             icod_Strategy, scinfo_Name_Activity, scod_Channel, tcinfo_FeciniPromo, tcinfo_FecfinPromo,
             scinfo_Vigente, icinfo_PersonnelCatid, sMecanica, sid_ProductCategory, scinfo_Comment_Observa,
             bcinfo_Status, scinfo_ModiBy, tcinfo_DateModiBy);
            odaActividadCom = null;
            return oeaActividaCom;            
        }

        //----Metodo que permite Actualizar POP de actividad en el comercio

        public ECompetition__Information ActualizarPOPActividadCom(int iid_cinfo, int iid_MPointOfPurchase, bool bCI_POP_Status,
            string sCI_POP_ModiBy, DateTime tCI_POP_DateModiBy)
        {
            Lucky.Data.Common.Application.DCompetition_Information odaPOPActividadCom = new Lucky.Data.Common.Application.DCompetition_Information();

            ECompetition__Information oeaPOPActividaCom = odaPOPActividadCom.ActualizarPOPActividadCom(iid_cinfo, iid_MPointOfPurchase, bCI_POP_Status,
            sCI_POP_ModiBy, tCI_POP_DateModiBy);
            odaPOPActividadCom = null;
            return oeaPOPActividaCom;
        }

        //----Metodo que permite Actualizar FOTOS de actividad en el comercio

        public ECompetition__Information ActualizarPhotoActividadCom(int iid_cinfo, string sPhotoCI_PathName, bool bPhotoCI_Status,
            string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            Lucky.Data.Common.Application.DCompetition_Information odaPhotoActividadCom = new Lucky.Data.Common.Application.DCompetition_Information();

            ECompetition__Information oeaPhotoActividaCom = odaPhotoActividadCom.ActualizarPhotoActividadCom( iid_cinfo,  sPhotoCI_PathName,  bPhotoCI_Status,
             sPhotoCI_ModiBy,  tPhotoCI_DateModiBy);
            odaPhotoActividadCom = null;
            return oeaPhotoActividaCom;
        }

        //Metodo para Actualizar información de actividad principal
        public ECompetition__Information ActualizarActComPrincipal(int iid_cinfo, string scinfo_Comment_Observa, bool bcinfo_Principal, string scinfo_ModiBy, DateTime tcinfo_DateModiBy)
        {
            Lucky.Data.Common.Application.DCompetition_Information odaActividadComPrinc = new Lucky.Data.Common.Application.DCompetition_Information();
            ECompetition__Information oeaActComPrinc = odaActividadComPrinc.ActualizarActividadComPrincipal(iid_cinfo, scinfo_Comment_Observa, bcinfo_Principal, scinfo_ModiBy, tcinfo_DateModiBy);
            odaActividadComPrinc = null;
            return oeaActComPrinc;
        }

        //Metodo para Actualizar comentarios de las fotos de actividad principal del comercio
        public ECompetition__Information ActualizarObsFotoActividadCom(int iid_PhotoCI, int iid_cinfo, string sPhotoCI_Observacion, string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            Lucky.Data.Common.Application.DCompetition_Information odaActualizaObsFotoActividadCom = new Lucky.Data.Common.Application.DCompetition_Information();
            ECompetition__Information oeaActObsFotoActiCom = odaActualizaObsFotoActividadCom.ActualizarObsFotoActividadCom(iid_PhotoCI, iid_cinfo, sPhotoCI_Observacion, sPhotoCI_ModiBy, tPhotoCI_DateModiBy);
            odaActualizaObsFotoActividadCom = null;
            return oeaActObsFotoActiCom;
        }

        //Metodo para Actualizar observacion Fotos de actividad del comercio 
        public ECompetition__Information ActualizarObsPhotoActCom(int iid_PhotoCI, int iid_cinfo, string sPhotoCI_Observacion,
            string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            Lucky.Data.Common.Application.DCompetition_Information odaObsActividadCom = new Lucky.Data.Common.Application.DCompetition_Information();
            ECompetition__Information oeaObsActividaCom = odaObsActividadCom.ActualizarObservacionPhotoActCom(iid_PhotoCI, iid_cinfo, sPhotoCI_Observacion,
             sPhotoCI_ModiBy, tPhotoCI_DateModiBy);
            odaObsActividadCom = null;
            return oeaObsActividaCom;
        }

    }
}