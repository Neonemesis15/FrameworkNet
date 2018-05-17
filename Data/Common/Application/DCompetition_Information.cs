using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// Clase:              DCompetition__Information
    /// Creada Por:         Ing. Mauricio Ortiz
    /// Fecha de Creación:  22-10-2009
    /// Requerimientos No:  <>
    /// Descripcion:        Clase Data encargada de definir todos los metodos transaccionales para operar Competition__Information
    /// </summary>
    /// 
    public class DCompetition_Information
    {
        private Conexion oConn;
        public DCompetition_Information()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }       

        /// <summary>
        /// Método para registrar información de actividades en el comercio
        /// Modificación: 29/07/2010 Se cambia nombre de Store UP_WEBSIGE_OPERATIVO_SAVEFORMATOACTIVIDADCOMERCIO
        /// Por UP_WEBXPLORA_OPE_SAVEACTIVIDADCOMERCIO y se modifica tipo de dato del 
        /// parametro id_planning de int a string
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
        /// <param name="bcinfo_Status"></param>
        /// <param name="scinfo_CreateBy"></param>
        /// <param name="tcinfo_DateBy"></param>
        /// <param name="scinfo_ModiBy"></param>
        /// <param name="tcinfo_DateModiBy"></param>
        /// <returns oerActividadCom></returns>
        public ECompetition__Information RegistrarActividadCom(string sid_planning, DateTime tcinfo_DateExecution,
            string scinfo_nameCompany, string scinfo_Brand, int icod_Strategy, string scinfo_Name_Activity,
            string scod_Channel, DateTime tcinfo_FeciniPromo, DateTime tcinfo_FecfinPromo, string scinfo_Vigente,
            int icinfo_PersonnelCatid, string sMecanica, string sid_ProductCategory, 
            string scinfo_Comment_Observa, bool bcinfo_Status, string scinfo_CreateBy, DateTime tcinfo_DateBy, string scinfo_ModiBy,
            DateTime tcinfo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_OPE_SAVEACTIVIDADCOMERCIO", sid_planning,
                tcinfo_DateExecution, scinfo_nameCompany, scinfo_Brand, icod_Strategy, scinfo_Name_Activity,
                scod_Channel, tcinfo_FeciniPromo, tcinfo_FecfinPromo, scinfo_Vigente, icinfo_PersonnelCatid, sMecanica,
                sid_ProductCategory, scinfo_Comment_Observa, bcinfo_Status, scinfo_CreateBy, tcinfo_DateBy, scinfo_ModiBy,
                tcinfo_DateModiBy);

            ECompetition__Information oerActividadCom = new ECompetition__Information();
            oerActividadCom.id_planning = sid_planning;
            oerActividadCom.cinfo_DateExecution = tcinfo_DateExecution;
            oerActividadCom.cinfo_nameCompany = scinfo_nameCompany;
            oerActividadCom.cinfo_Brand = scinfo_Brand;
            oerActividadCom.cod_Strategy = icod_Strategy;
            oerActividadCom.cinfo_Name_Activity = scinfo_Name_Activity;
            oerActividadCom.cod_Channel = scod_Channel;
            oerActividadCom.cinfo_FeciniPromo = tcinfo_FeciniPromo;
            oerActividadCom.cinfo_FecfinPromo = tcinfo_FecfinPromo;
            oerActividadCom.cinfo_Vigente = scinfo_Vigente;
            oerActividadCom.cinfo_PersonnelCatid = icinfo_PersonnelCatid;
            oerActividadCom.Mecanica = sMecanica;
            oerActividadCom.id_ProductCategory = sid_ProductCategory;            
            oerActividadCom.cinfo_Comment_Observa = scinfo_Comment_Observa;
            oerActividadCom.cinfo_Status = bcinfo_Status;           
            oerActividadCom.cinfo_CreateBy = scinfo_CreateBy;
            oerActividadCom.cinfo_DateBy = tcinfo_DateBy;
            oerActividadCom.cinfo_ModiBy = scinfo_ModiBy;
            oerActividadCom.cinfo_DateModiBy = tcinfo_DateModiBy;
            return oerActividadCom;
        }

        // Método para registrar fotografias de actividades en el comercio
        public ECompetition__Information RegistrarPhotoActividadCom(int iid_cinfo, string sPhotoCI_PathName, bool bPhotoCI_Status,
            string sPhotoCI_CreateBy, DateTime tPhotoCI_DateBy, string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_OPERATIVO_SAVEPHOTOACTIVIDADCOMERCIO", iid_cinfo, sPhotoCI_PathName, bPhotoCI_Status,
             sPhotoCI_CreateBy, tPhotoCI_DateBy, sPhotoCI_ModiBy, tPhotoCI_DateModiBy);

            ECompetition__Information oerPhotoActividadCom = new ECompetition__Information();
            oerPhotoActividadCom.id_cinfo = iid_cinfo;
            oerPhotoActividadCom.PhotoCI_PathName = sPhotoCI_PathName;
            oerPhotoActividadCom.PhotoCI_Status = bPhotoCI_Status;
            oerPhotoActividadCom.PhotoCI_CreateBy = sPhotoCI_CreateBy;
            oerPhotoActividadCom.PhotoCI_DateBy = tPhotoCI_DateBy;
            oerPhotoActividadCom.PhotoCI_ModiBy = sPhotoCI_ModiBy;
            oerPhotoActividadCom.PhotoCI_DateModiBy = tPhotoCI_DateModiBy;
            return oerPhotoActividadCom;
        }

        // Método para registrar material POP de actividades en el comercio
        public ECompetition__Information RegistrarPOPActividadCom(int iid_cinfo, int iid_MPointOfPurchase, bool bCI_POP_Status,
            string sCI_POP_CreateBy, DateTime tCI_POP_DateBy, string sCI_POP_ModiBy, DateTime tCI_POP_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_OPERATIVO_SAVEPOPACTIVIDADCOMERCIO", iid_cinfo, iid_MPointOfPurchase, bCI_POP_Status,
             sCI_POP_CreateBy, tCI_POP_DateBy, sCI_POP_ModiBy, tCI_POP_DateModiBy);

            ECompetition__Information oerPOPActividadCom = new ECompetition__Information();
            oerPOPActividadCom.id_cinfo = iid_cinfo;
            oerPOPActividadCom.id_MPointOfPurchase = iid_MPointOfPurchase;
            oerPOPActividadCom.CI_POP_Status = bCI_POP_Status;
            oerPOPActividadCom.CI_POP_CreateBy = sCI_POP_CreateBy;
            oerPOPActividadCom.CI_POP_DateBy = tCI_POP_DateBy;
            oerPOPActividadCom.CI_POP_ModiBy = sCI_POP_ModiBy;
            oerPOPActividadCom.CI_POP_DateModiBy = tCI_POP_DateModiBy;            
            return oerPOPActividadCom;
        }

        //Metodo para Actualizar información de actividad del comercio 

        public ECompetition__Information ActualizarActividadCom(int iid_cinfo, DateTime tcinfo_DateExecution, string scinfo_nameCompany, string scinfo_Brand,
            int icod_Strategy, string scinfo_Name_Activity, string scod_Channel, DateTime tcinfo_FeciniPromo, DateTime tcinfo_FecfinPromo,
            string scinfo_Vigente, int icinfo_PersonnelCatid, string sMecanica, string sid_ProductCategory, string scinfo_Comment_Observa,
            bool bcinfo_Status, string scinfo_ModiBy, DateTime tcinfo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_OPERATIVO_UPDATEFORMATOACTIVIDADCOMERCIO", iid_cinfo,  tcinfo_DateExecution,  scinfo_nameCompany,  scinfo_Brand,
             icod_Strategy,  scinfo_Name_Activity,  scod_Channel,  tcinfo_FeciniPromo,  tcinfo_FecfinPromo,
             scinfo_Vigente,  icinfo_PersonnelCatid,  sMecanica,  sid_ProductCategory,  scinfo_Comment_Observa,
             bcinfo_Status,  scinfo_ModiBy,  tcinfo_DateModiBy);
            ECompetition__Information oeaActividadCom = new ECompetition__Information();
            
            oeaActividadCom.id_cinfo = iid_cinfo;
            oeaActividadCom.cinfo_DateExecution = tcinfo_DateExecution;
            oeaActividadCom.cinfo_nameCompany = scinfo_nameCompany;
            oeaActividadCom.cinfo_Brand = scinfo_Brand;
            oeaActividadCom.cod_Strategy = icod_Strategy;
            oeaActividadCom.cinfo_Name_Activity = scinfo_Name_Activity;
            oeaActividadCom.cod_Channel = scod_Channel;
            oeaActividadCom.cinfo_FeciniPromo = tcinfo_FeciniPromo;
            oeaActividadCom.cinfo_FecfinPromo = tcinfo_FecfinPromo;
            oeaActividadCom.cinfo_Vigente = scinfo_Vigente;
            oeaActividadCom.cinfo_PersonnelCatid = icinfo_PersonnelCatid;
            oeaActividadCom.Mecanica = sMecanica;
            oeaActividadCom.id_ProductCategory = sid_ProductCategory;            
            oeaActividadCom.cinfo_Comment_Observa = scinfo_Comment_Observa;
            oeaActividadCom.cinfo_Status = bcinfo_Status;                       
            oeaActividadCom.cinfo_ModiBy = scinfo_ModiBy;
            oeaActividadCom.cinfo_DateModiBy = tcinfo_DateModiBy;
            
            return oeaActividadCom;
        }

        //Metodo para Actualizar POP de actividad del comercio 

        public ECompetition__Information ActualizarPOPActividadCom(int iid_cinfo, int iid_MPointOfPurchase, bool bCI_POP_Status,
            string sCI_POP_ModiBy, DateTime tCI_POP_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_OPERATIVO_UPDATEPOPACTIVIDADCOMERCIO", iid_cinfo, iid_MPointOfPurchase, bCI_POP_Status,
             sCI_POP_ModiBy, tCI_POP_DateModiBy);
            ECompetition__Information oeaPOPActividadCom = new ECompetition__Information();
            oeaPOPActividadCom.id_cinfo = iid_cinfo;
            oeaPOPActividadCom.id_MPointOfPurchase = iid_MPointOfPurchase;
            oeaPOPActividadCom.CI_POP_Status = bCI_POP_Status;         
            oeaPOPActividadCom.CI_POP_ModiBy = sCI_POP_ModiBy;
            oeaPOPActividadCom.CI_POP_DateModiBy = tCI_POP_DateModiBy;          

            return oeaPOPActividadCom;
        }

        //Metodo para Actualizar Fotos de actividad del comercio 

        public ECompetition__Information ActualizarPhotoActividadCom(int iid_cinfo, string sPhotoCI_PathName, bool bPhotoCI_Status,
            string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_OPERATIVO_UPDATEPHOTOACTIVIDADCOMERCIO", iid_cinfo,  sPhotoCI_PathName, bPhotoCI_Status,
             sPhotoCI_ModiBy,  tPhotoCI_DateModiBy );
            ECompetition__Information oeaPhotoActividadCom = new ECompetition__Information();
            oeaPhotoActividadCom.id_cinfo = iid_cinfo;
            oeaPhotoActividadCom.PhotoCI_PathName = sPhotoCI_PathName;
            oeaPhotoActividadCom.PhotoCI_Status = bPhotoCI_Status;            
            oeaPhotoActividadCom.PhotoCI_ModiBy = sPhotoCI_ModiBy;
            oeaPhotoActividadCom.PhotoCI_DateModiBy = tPhotoCI_DateModiBy;
            return oeaPhotoActividadCom;
        }



        //Metodo para Actualizar información de actividad principal

        public ECompetition__Information ActualizarActividadComPrincipal(int iid_cinfo, string scinfo_Comment_Observa, bool bcinfo_Principal, string scinfo_ModiBy, DateTime tcinfo_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATEFORMATOACTCOMPRINCIPAL", iid_cinfo, scinfo_Comment_Observa,
            bcinfo_Principal, scinfo_ModiBy, tcinfo_DateModiBy);
            ECompetition__Information oeaActividadCom = new ECompetition__Information();

            oeaActividadCom.id_cinfo = iid_cinfo;
            oeaActividadCom.cinfo_Comment_Observa = scinfo_Comment_Observa;
            oeaActividadCom.cinfo_Principal = bcinfo_Principal;
            oeaActividadCom.cinfo_ModiBy = scinfo_ModiBy;
            oeaActividadCom.cinfo_DateModiBy = tcinfo_DateModiBy;

            return oeaActividadCom;
        }


        //Metodo para Actualizar comentarios de las fotos de actividad principal del comercio

        public ECompetition__Information ActualizarObsFotoActividadCom(int iid_PhotoCI, int iid_cinfo, string sPhotoCI_Observacion, string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATEPHOTOFORMATOACTCOMPRINCIPAL", iid_PhotoCI, iid_cinfo, sPhotoCI_Observacion, sPhotoCI_ModiBy, tPhotoCI_DateModiBy);
            ECompetition__Information oeaActividadCom = new ECompetition__Information();

            oeaActividadCom.id_PhotoCI = iid_PhotoCI;
            oeaActividadCom.PhotoCI_Observacion = sPhotoCI_Observacion;
            oeaActividadCom.PhotoCI_ModiBy = sPhotoCI_ModiBy;
            oeaActividadCom.PhotoCI_DateModiBy = tPhotoCI_DateModiBy;           

            return oeaActividadCom;
        }



        //Metodo para Actualizar observacion Fotos de actividad del comercio 

        public ECompetition__Information ActualizarObservacionPhotoActCom(int iid_PhotoCI,int iid_cinfo, string sPhotoCI_Observacion,
            string sPhotoCI_ModiBy, DateTime tPhotoCI_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATEOBSERVACIONPHOTOACTCOM", iid_PhotoCI, iid_cinfo, sPhotoCI_Observacion,
             sPhotoCI_ModiBy, tPhotoCI_DateModiBy);
            ECompetition__Information oeaPhotoActividadCom = new ECompetition__Information();
            oeaPhotoActividadCom.id_PhotoCI = iid_PhotoCI;
            oeaPhotoActividadCom.id_cinfo = iid_cinfo;
            oeaPhotoActividadCom.PhotoCI_Observacion = sPhotoCI_Observacion;            
            oeaPhotoActividadCom.PhotoCI_ModiBy = sPhotoCI_ModiBy;
            oeaPhotoActividadCom.PhotoCI_DateModiBy = tPhotoCI_DateModiBy;
            return oeaPhotoActividadCom;
        }

    }
}
        
     