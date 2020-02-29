using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Application.Interfaces;

namespace Lucky.Data.Common.Application
{  
    /// <summary>
    /// Description: 
    /// - Clase Data encargada de definir todos los metodos transaccionales para operar el Planning
    /// CreateBy: 
    /// - 02/05/2009 - Ing. Carlos Alberto Hernandez RIncón 
    /// Changes:
    /// - 08/01/2019 - Pablo A. Salas Alvarez (PSA) Add method presupuestoSearch by idCompany. 
    /// - 02/05/2009 - Carlos Alberto Hernandez RIncón (CAHR) Create Class.
    public class DPlanning
    {
        private Conexion oConn;

        // Variable para Almacenar los mensajes de Error
        private String message = "";

        /// <summary>
        /// Retornar los mensajes de Error
        /// </summary>
        /// <returns></returns>
        public String getMessages() {
            return message;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DPlanning()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        #region Methods: CREATE

        /// <summary>
        /// Metodo para Crear Ciudades Planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sidPlannig"></param>
        /// <param name="sCodCity"></param>
        /// <param name="icompanyid"></param>
        /// <param name="sCityPrincipal"></param>
        /// <param name="bCityPlanningStatus"></param>
        /// <param name="sCityPlanningCreateBy"></param>
        /// <param name="tCityPlanningDateBy"></param>
        /// <param name="sCityPlanningModiBy"></param>
        /// <param name="tCityPlanningDateModiBy"></param>
        /// <returns oecityplanning></returns>
        public ECityPlanning CrearCityPlanning(string sidPlanning, string sCodCity, int icompanyid, string sCityPrincipal, bool bCityPlanningStatus, string sCityPlanningCreateBy,
            DateTime tCityPlanningDateBy, string sCityPlanningModiBy, DateTime tCityPlanningDateModiBy)
        {
            ECityPlanning oecityplanning = new ECityPlanning();
            DataSet ds = oConn.ejecutarDataSet("UP_WEBSIGE_REGISTERCITYPLANNING", sidPlanning, sCodCity, icompanyid, sCityPrincipal, bCityPlanningStatus, sCityPlanningCreateBy, tCityPlanningDateBy, sCityPlanningModiBy, tCityPlanningDateModiBy);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oecityplanning.idplanning = sidPlanning;
                    oecityplanning.CodCity = sCodCity;
                    oecityplanning.companyid = icompanyid;
                    oecityplanning.CityPrincipal = sCityPrincipal;
                    oecityplanning.CityPlanningStatus = bCityPlanningStatus;
                    oecityplanning.CityPlanningCreateBy = sCityPlanningCreateBy;
                    oecityplanning.CityPlanningDateBy = tCityPlanningDateBy;
                    oecityplanning.CityPlanningModiBy = sCityPlanningModiBy;
                    oecityplanning.CityPlanningDateModiBy = tCityPlanningDateModiBy;


                }



            }
            return oecityplanning;


        }

        /// <summary>
        /// Metodo para Registrar Objetivos Planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="sobsDescription"></param>
        /// <param name="sobjCreateBy"></param>
        /// <param name="tobjDateBy"></param>
        /// <param name="sobModyBy"></param>
        /// <param name="tobjDateModyBy"></param>
        /// <returns oeobj></returns>
        public EObjetivesPlanning Crear_ObjPlanning(string sidplanning, string sobsDescription, string sobjCreateBy, DateTime tobjDateBy, string sobModyBy, DateTime tobjDateModyBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTEROBJPLANING", sidplanning, sobsDescription, sobjCreateBy, tobjDateBy, sobModyBy, tobjDateModyBy);
            EObjetivesPlanning oeobj = new EObjetivesPlanning();
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oeobj.id_Planning = sidplanning;
                    oeobj.objPlaDescription = sobsDescription;
                    oeobj.objPlaCreateBy = sobjCreateBy;
                    oeobj.objPlaDateBy = tobjDateBy;
                    oeobj.objPlaModiBy = sobModyBy;
                    oeobj.objPlaDatemodiBy = tobjDateModyBy;
                }
            }

            return oeobj;

        }

        /// <summary>
        /// Metodo para registrar los Mandatorios del Planning 
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="sMandtoryDescription"></param>
        /// <param name="sMandtoryCreateBy"></param>
        /// <param name="tMandtoryDateBy"></param>
        /// <param name="sMandtoryModiBy"></param>
        /// <param name="tMandtoryDateModiBy"></param>
        /// <returns ds></returns>
        public EMandatoryPlanning Crear_MandatoriosPlanning(string sidplanning, string sMandtoryDescription, string sMandtoryCreateBy, DateTime tMandtoryDateBy, string sMandtoryModiBy, DateTime tMandtoryDateModiBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WENSIGE_PLANNING_REGISTERMANDAPLANNIG", sidplanning, sMandtoryDescription, sMandtoryCreateBy, tMandtoryDateBy, sMandtoryModiBy, tMandtoryDateModiBy);
            EMandatoryPlanning oemanda = new EMandatoryPlanning();
            if (ds != null)
            {

                if (ds.Tables.Count > 0)
                {
                    oemanda.id_planning = sidplanning;
                    oemanda.MandtoryDescription = sMandtoryDescription;
                    oemanda.MandtoryCreateBy = sMandtoryCreateBy;
                    oemanda.MandtoryDateBy = tMandtoryDateBy;
                    oemanda.MandtoryModiBy = sMandtoryModiBy;
                    oemanda.MandtoryDateModiBy = tMandtoryDateModiBy;




                }


            }

            return oemanda;



        }

        /// <summary>
        /// Método para registrar la mecánica del planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="smecaDescription"></param>
        /// <param name="smecaCreateBy"></param>
        /// <param name="tmecaDateBy"></param>
        /// <param name="smecaModyBy"></param>
        /// <param name="tmecaDateModyBy"></param>
        /// <returns oemeca></returns>
        public EMechanicalActivity Crear_MecanicaPlanning(string sidplanning, string smecaDescription, string smecaCreateBy, DateTime tmecaDateBy, string smecaModyBy, DateTime tmecaDateModyBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERMECANICAPLANNING", sidplanning, smecaDescription, smecaCreateBy, tmecaDateBy, smecaModyBy, tmecaDateModyBy);
            EMechanicalActivity oemeca = new EMechanicalActivity();
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oemeca.idPlanning = sidplanning;
                    oemeca.MechanicalActivityDescription = smecaDescription;
                    oemeca.MechanicalActivityCreateBy = smecaCreateBy;
                    oemeca.MechanicalActivityDateBy = tmecaDateBy;
                    oemeca.MechanicalActivityModyBy = smecaModyBy;
                    oemeca.MechanicalActivityDateModyBy = tmecaDateModyBy;

                }


            }
            return oemeca;






        }

        /// <summary>
        /// Método para Crear Observaciones del la Actividad
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="sobsDescription"></param>
        /// <param name="sobsCrerateBy"></param>
        /// <param name="tobsDateBy"></param>
        /// <param name="sobsModiBy"></param>
        /// <param name="tobsDateModiBy"></param>
        /// <returns oeobs></returns>
        public EObservationPlanning Crear_Observa(string sidplanning, string sobsDescription, string sobsCrerateBy, DateTime tobsDateBy, string sobsModiBy, DateTime tobsDateModiBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_REGISTEROBSERVA", sidplanning, sobsDescription, sobsCrerateBy, tobsDateBy, sobsModiBy, tobsDateModiBy);
            EObservationPlanning oeobs = new EObservationPlanning();

            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {

                    oeobs.id_planning = sidplanning;
                    oeobs.obsDescription = sobsDescription;
                    oeobs.obsCrerateBy = sobsCrerateBy;
                    oeobs.obsDateBy = tobsDateBy;
                    oeobs.obsModiBy = sobsModiBy;
                    oeobs.obsDateModiBy = tobsDateModiBy;




                }




            }
            return oeobs;





        }

        /// <summary>
        /// Metodo para Registrar Presentaciones de la Competencia 12/12/2009
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="iidProductsPlanning"></param>
        /// <param name="snameproducCompe"></param>
        /// <param name="sBrandCompe"></param>
        /// <param name="sproductmanufac"></param>
        /// <param name="bproducCompeStatus"></param>
        /// <param name="sproducCompeCreateBy"></param>
        /// <param name="tproducCompeDateBy"></param>
        /// <param name="sproducCompeModiBy"></param>
        /// <param name="tproducCompeDateModiBy"></param>
        /// <returns oeproduccompe></returns>
        public EProduct_Compe Crear_ProductCompe(string sidplanning, int iidProductsPlanning, string snameproducCompe, string sBrandCompe, string sproductmanufac, bool bproducCompeStatus, string sproducCompeCreateBy, DateTime tproducCompeDateBy, string sproducCompeModiBy, DateTime tproducCompeDateModiBy)
        {

            DataSet dsdcompe = null;
            dsdcompe = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERPROUCTCOMPETENCIA", sidplanning, iidProductsPlanning, snameproducCompe, sBrandCompe, sproductmanufac, bproducCompeStatus, sproducCompeCreateBy, tproducCompeDateBy, sproducCompeModiBy, tproducCompeDateModiBy);
            EProduct_Compe oeproduccompe = new EProduct_Compe();
            if (dsdcompe != null)
            {
                if (dsdcompe.Tables.Count > 0)
                {
                    oeproduccompe.idplanning = sidplanning;
                    oeproduccompe.idProductsPlanning = iidProductsPlanning;
                    oeproduccompe.nameproducCompe = snameproducCompe;
                    oeproduccompe.BrandCompe = sBrandCompe;
                    oeproduccompe.ProductCompemanufacturer = sproductmanufac;
                    oeproduccompe.producCompeStatus = bproducCompeStatus;
                    oeproduccompe.producCompeCreateBy = sproducCompeCreateBy;
                    oeproduccompe.producCompeDateBy = tproducCompeDateBy;
                    oeproduccompe.producCompeModiBy = sproducCompeModiBy;
                    oeproduccompe.producCompeDateModiBy = tproducCompeDateModiBy;
                }
            }
            return oeproduccompe;
        }

        /// <summary>
        /// Metodo para Crear Aprendizajes
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="slearngDescription"></param>
        /// <param name="slearngCreateBy"></param>
        /// <param name="tlearngDateBy"></param>
        /// <param name="slearngModiBy"></param>
        /// <param name="tlearngDateModiBy"></param>
        /// <returns oelear></returns>
        public ELearnningPlanning Crear_Leanning(string sidplanning, string slearngDescription, string slearngCreateBy, DateTime tlearngDateBy, string slearngModiBy, DateTime tlearngDateModiBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_REGISTERLEARNNING", sidplanning, slearngDescription, slearngCreateBy, tlearngDateBy, slearngModiBy, tlearngDateModiBy);
            ELearnningPlanning oelear = new ELearnningPlanning();
            if (ds != null)
            {

                if (ds.Tables.Count > 0)
                {

                    oelear.idplanning = sidplanning;
                    oelear.learngDescription = slearngDescription;
                    oelear.learngDateBy = tlearngDateBy;
                    oelear.learngModiBy = slearngModiBy;
                    oelear.learngDateModiBy = tlearngDateModiBy;


                }






            }
            return oelear;



        }

        /// <summary>
        /// Metodo para registrar Datos calculados de Ventas
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="iidmetasales"></param>
        /// <param name="iobjectid"></param>
        /// <param name="icolumnid"></param>
        /// <param name="bDateCalStatus"></param>
        /// <param name="sDateCalCreateBy"></param>
        /// <param name="tDateCalDateBy"></param>
        /// <param name="sDateCalModyBy"></param>
        /// <param name="tDateCalDateModiBy"></param>
        /// <returns oemetacal></returns>
        public EMetaDataCaculation Crear_DateCalSales(string sidplanning, int iidmetasales, int iobjectid, int icolumnid, bool bDateCalStatus, string sDateCalCreateBy, DateTime tDateCalDateBy, string sDateCalModyBy, DateTime tDateCalDateModiBy)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_REGISTERDATECALSALES", sidplanning, iidmetasales, iobjectid, icolumnid, bDateCalStatus, sDateCalCreateBy, tDateCalDateBy, sDateCalModyBy, tDateCalDateModiBy);
            EMetaDataCaculation oemetacal = new EMetaDataCaculation();
            if (dt.Rows.Count > 0)
            {
                oemetacal.idplanning = sidplanning;
                oemetacal.idmetatabla = iidmetasales;
                oemetacal.objectid = iobjectid;
                oemetacal.columnid = icolumnid;
                oemetacal.DateCalStatus = bDateCalStatus;
                oemetacal.DateCalCreateBy = sDateCalCreateBy;
                oemetacal.DateCalDateBy = tDateCalDateBy;
                oemetacal.DateCalModyBy = sDateCalModyBy;
                oemetacal.DateCalDateModiBy = tDateCalDateModiBy;

            }
            else
            {


                return null;

            }
            return oemetacal;





        }

        /// <summary>
        /// Metodo para registrar datos Calculados de Precios
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="iidmetaprices"></param>
        /// <param name="iobjectid"></param>
        /// <param name="icolumnid"></param>
        /// <param name="bDateCalStatus"></param>
        /// <param name="sDateCalCreateBy"></param>
        /// <param name="tDateCalDateBy"></param>
        /// <param name="sDateCalModyBy"></param>
        /// <param name="tDateCalDateModiBy"></param>
        /// <returns oemetacal></returns>
        public EMetaDataCaculation Crear_DateCalPrices(string sidplanning, int iidmetaprices, int iobjectid, int icolumnid, bool bDateCalStatus, string sDateCalCreateBy, DateTime tDateCalDateBy, string sDateCalModyBy, DateTime tDateCalDateModiBy)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_REGISTERMEDATADATACALPRICES", sidplanning, iidmetaprices, iobjectid, icolumnid, bDateCalStatus, sDateCalCreateBy, tDateCalDateBy, sDateCalModyBy, tDateCalDateModiBy);
            EMetaDataCaculation oemetacal = new EMetaDataCaculation();
            if (dt.Rows.Count > 0)
            {
                oemetacal.idplanning = sidplanning;
                oemetacal.idmetatabla = iidmetaprices;
                oemetacal.objectid = iobjectid;
                oemetacal.columnid = icolumnid;
                oemetacal.DateCalStatus = bDateCalStatus;
                oemetacal.DateCalCreateBy = sDateCalCreateBy;
                oemetacal.DateCalDateBy = tDateCalDateBy;
                oemetacal.DateCalModyBy = sDateCalModyBy;
                oemetacal.DateCalDateModiBy = tDateCalDateModiBy;
            }
            else
            {

                return null;

            }
            return oemetacal;
        }

        /// <summary>
        /// Metodo para registrar los datos Calculados en Covertura
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="iidmetacoverage"></param>
        /// <param name="iobjectid"></param>
        /// <param name="icolumnid"></param>
        /// <param name="bDateCalStatus"></param>
        /// <param name="sDateCalCreateBy"></param>
        /// <param name="tDateCalDateBy"></param>
        /// <param name="sDateCalModyBy"></param>
        /// <param name="tDateCalDateModiBy"></param>
        /// <returns oemetacal></returns>
        public EMetaDataCaculation Crear_DateCalCoverange(string sidplanning, int iidmetacoverage, int iobjectid, int icolumnid, bool bDateCalStatus, string sDateCalCreateBy, DateTime tDateCalDateBy, string sDateCalModyBy, DateTime tDateCalDateModiBy)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_REGISTERMEDATADATACALCOVERAGE", sidplanning, iidmetacoverage, iobjectid, icolumnid, bDateCalStatus, sDateCalCreateBy, tDateCalDateBy, sDateCalModyBy, tDateCalDateModiBy);
            EMetaDataCaculation oemetacal = new EMetaDataCaculation();
            if (dt.Rows.Count > 0)
            {
                oemetacal.idplanning = sidplanning;
                oemetacal.idmetatabla = iidmetacoverage;
                oemetacal.objectid = iobjectid;
                oemetacal.columnid = icolumnid;
                oemetacal.DateCalStatus = bDateCalStatus;
                oemetacal.DateCalCreateBy = sDateCalCreateBy;
                oemetacal.DateCalDateBy = tDateCalDateBy;
                oemetacal.DateCalModyBy = sDateCalModyBy;
                oemetacal.DateCalDateModiBy = tDateCalDateModiBy;
            }
            else
            {
                return null;

            }
            return oemetacal;





        }

        /// <summary>
        /// Metodo para Crear Datos Calculados de medición de Espacios
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="iidmetaspace"></param>
        /// <param name="iobjectid"></param>
        /// <param name="icolumnid"></param>
        /// <param name="bDateCalStatus"></param>
        /// <param name="sDateCalCreateBy"></param>
        /// <param name="tDateCalDateBy"></param>
        /// <param name="sDateCalModyBy"></param>
        /// <param name="tDateCalDateModiBy"></param>
        /// <returns oemetacal></returns>
        public EMetaDataCaculation Crear_DateCalSpace(string sidplanning, int iidmetaspace, int iobjectid, int icolumnid, bool bDateCalStatus, string sDateCalCreateBy, DateTime tDateCalDateBy, string sDateCalModyBy, DateTime tDateCalDateModiBy)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_REGISTERMETADATASPACEMESURERMENTDATACAL", sidplanning, iidmetaspace, iobjectid, icolumnid, bDateCalStatus, sDateCalCreateBy, tDateCalDateBy, sDateCalModyBy, tDateCalDateModiBy);
            EMetaDataCaculation oemetacal = new EMetaDataCaculation();
            if (dt.Rows.Count > 0)
            {
                oemetacal.idplanning = sidplanning;
                oemetacal.idmetatabla = iidmetaspace;
                oemetacal.objectid = iobjectid;
                oemetacal.columnid = icolumnid;
                oemetacal.DateCalStatus = bDateCalStatus;
                oemetacal.DateCalCreateBy = sDateCalCreateBy;
                oemetacal.DateCalDateBy = tDateCalDateBy;
                oemetacal.DateCalModyBy = sDateCalModyBy;
                oemetacal.DateCalDateModiBy = tDateCalDateModiBy;
            }
            else
            {
                return null;
            }
            return oemetacal;


        }

        /// <summary>
        /// Metodo para registrar los detalles de los items para los Formatos de Levantamiento de información en Planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="siplanning"></param>
        /// <param name="iidcodPoint"></param>
        /// <param name="icodtitem"></param>
        /// <param name="iubicacion"></param>
        /// <param name="iiddesignFor"></param>
        /// <param name="bcontenstatus"></param>
        /// <param name="scontendorCreateBy"></param>
        /// <param name="tcontenedorDateBy"></param>
        /// <param name="scontenedorModiBy"></param>
        /// <param name="tcontenedorDateModiBy"></param>
        /// <returns oecontegorma></returns>
        public EContenedoraFormatos CrearDetalleitemformato(string siplanning, int iidcodPoint, int icodtitem, int iubicacion, int iiddesignFor, bool bcontenstatus, string scontendorCreateBy, DateTime tcontenedorDateBy, string scontenedorModiBy, DateTime tcontenedorDateModiBy)
        {
            DataSet dsiteforma = null;
            dsiteforma = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTER_CONTENEDORFORMATOS", siplanning, iidcodPoint, icodtitem, iubicacion, iiddesignFor, bcontenstatus, scontendorCreateBy, tcontenedorDateBy, scontenedorModiBy, tcontenedorDateModiBy);
            EContenedoraFormatos oecontegorma = new EContenedoraFormatos();
            if (dsiteforma != null)
            {
                if (dsiteforma.Tables.Count > 0)
                {
                    oecontegorma.idPlanning = siplanning;
                    oecontegorma.idcodPoint = iidcodPoint;
                    oecontegorma.codItem = icodtitem;
                    oecontegorma.ubicacion = iubicacion;
                    oecontegorma.iddesignFor = iiddesignFor;
                    oecontegorma.contenstatus = bcontenstatus;
                    oecontegorma.contendorCreateBy = scontendorCreateBy;
                    oecontegorma.contenedorDateBy = tcontenedorDateBy;
                    oecontegorma.contenedorModiBy = scontenedorModiBy;
                    oecontegorma.contenedorDateModiBy = tcontenedorDateModiBy;
                }
            }
            return oecontegorma;
        }



        /// <summary>
        /// Metodo para Crear el Planning
        /// Modificación: 23/07/2010 Se adecuada inserción unicamente con los campos
        ///               que de acuerdo al nuevo planteamiento se debe cubrir para 
        ///               la creacion del planning. se excluyen @Planning_ReportAditional,
        ///               @Planning_DevelopmentActivityReport, @Planning_Person_Eje,
        ///               @Planning_ActivityFormats, @Planning_AreaInvolved, @id_designFor,
        ///               @Name_Contact, @Email_Contac y @Planning_FormaCompe. Ing. Mauricio Ortiz
        ///               30/07/2010 se adiciona parámetro @id_planning ya que éste no seguirá siendo 
        ///               autogenerado por sql sino por la aplicación concatenando número de presupuesto y fecha actual.
        ///               se modifica nombre del sp UP_WEBSIGE_REGISTERPLANNING por UP_WEBXPLORA_PLA_CREARPLANNING
        ///               de acuerdo a métricas establecidas. Ing. Mauricio Ortiz 
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sPlanning_Name"></param>
        /// <param name="icod_Strategy"></param>
        /// <param name="sPlanning_CodChannel"></param>
        /// <param name="tPlanning_StartActivity"></param>
        /// <param name="tPlanning_EndActivity"></param>
        /// <param name="tPlanning_DateRepSoli"></param>
        /// <param name="tPlanning_PreproduDateini"></param>
        /// <param name="tPlanning_PreproduDateEnd"></param>
        /// <param name="sPlanning_ProjectDuration"></param>
        /// <param name="tPlanning_DateFinreport"></param>
        /// <param name="sPlanning_Vigen"></param>
        /// <param name="sPlanning_Budget"></param>
        /// <param name="bPlanning_Status"></param>
        /// <param name="iStatus_id"></param>
        /// <param name="sPlanning_CreateBy"></param>
        /// <param name="tPlanning_DateBy"></param>
        /// <param name="sPlanning_ModiBy"></param>
        /// <param name="tPlanning_DateModiBy"></param>
        /// <returns oeplanning></returns>
        public EPlaning CrearPlanning(string sid_planning, string sPlanning_Name, int icod_Strategy, string sPlanning_CodChannel,
            DateTime tPlanning_StartActivity, DateTime tPlanning_EndActivity, DateTime tPlanning_DateRepSoli,
            DateTime tPlanning_PreproduDateini, DateTime tPlanning_PreproduDateEnd, string sPlanning_ProjectDuration,
            DateTime tPlanning_DateFinreport, string sPlanning_Vigen, string sPlanning_Budget, bool bPlanning_Status,
            int iStatus_id, string sPlanning_CreateBy, DateTime tPlanning_DateBy, string sPlanning_ModiBy,
            DateTime tPlanning_DateModiBy)
        {
            EPlaning oeplanning = new EPlaning();

            DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_PLA_CREARPLANNING", sid_planning, sPlanning_Name, icod_Strategy, sPlanning_CodChannel,
             tPlanning_StartActivity, tPlanning_EndActivity, tPlanning_DateRepSoli,
             tPlanning_PreproduDateini, tPlanning_PreproduDateEnd, sPlanning_ProjectDuration,
             tPlanning_DateFinreport, sPlanning_Vigen, sPlanning_Budget, bPlanning_Status,
             iStatus_id, sPlanning_CreateBy, tPlanning_DateBy, sPlanning_ModiBy,
             tPlanning_DateModiBy);

            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oeplanning.idplanning = sid_planning;
                    oeplanning.PlanningName = sPlanning_Name;
                    oeplanning.codStrategy = icod_Strategy;
                    oeplanning.PlanningCodChannel = sPlanning_CodChannel;
                    oeplanning.PlanningStartActivity = tPlanning_StartActivity;
                    oeplanning.PlanningEndActivity = tPlanning_EndActivity;
                    oeplanning.PlanningDateRepSoli = tPlanning_DateRepSoli;
                    oeplanning.PlanningPreproduDateini = tPlanning_PreproduDateini;
                    oeplanning.PlanningPreproduDateEnd = tPlanning_PreproduDateEnd;
                    oeplanning.PlanningProjectDuration = sPlanning_ProjectDuration;
                    oeplanning.PlanningDateFinreport = tPlanning_DateFinreport;
                    oeplanning.PlanningVigen = sPlanning_Vigen;
                    oeplanning.PlanningBudget = sPlanning_Budget;
                    oeplanning.PlanningStatus = bPlanning_Status;
                    oeplanning.Statusid = iStatus_id;
                    oeplanning.PlanningCreateBy = sPlanning_CreateBy;
                    oeplanning.PlanningDateBy = tPlanning_DateBy;
                    oeplanning.PlanningModiBy = sPlanning_ModiBy;
                    oeplanning.PlanningDateModiBy = tPlanning_DateModiBy;
                }
            }
            return oeplanning;
        }

        /// <summary>
        /// Metodo para crear registro en la base de datos DB_LUCKY_TMP en la tabla TBL_EQUIPO
        /// Ing. Mauricio Ortiz
        /// 14/02/2011
        /// Modificación : 24/05/2011 se adiciona el parametro canal no existía al momento de crear el metodo  . Ing. Mauricio Ortiz. 
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sPlanning_Name"></param>
        /// <param name="SCanal"></param>
        /// <returns>dt</returns>
        public DataTable CrearPlanningTBL_EQUIPO(string sid_planning, string sPlanning_Name, string SCanal)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_CREARPLANNING_TBL_EQUIPO", sid_planning, sPlanning_Name, SCanal);
            return dt;
        }

        public DataTable RegistrarTBL_MARCA_COMPETIDORA(string ID_Cliente, string ID_Competidora, string ID_EQMARCA, string STATUS)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_MARCA_COMPETIDORA", ID_Cliente, ID_Competidora, ID_EQMARCA, STATUS);
            return dt;
        }



        /// <summary>
        /// Método para insertar registros en PLA_Panel_Planning
        /// Ing. Mauricio Ortiz
        /// 03/03/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iid_MPOSPlanning"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="iReport_Id"></param>
        /// <param name="bStatus_PanelPlanning"></param>
        /// <param name="sPanelPlanning_CreateBy"></param>
        /// <param name="tPanelPlanning_DateBy"></param>
        /// <param name="sPanelPlanning_ModiBy"></param>
        /// <param name="tPanelPlanning_DateModiBy"></param>
        /// <returns></returns>
        public EPLA_Panel_Planning Registrar_PLA_Panel_Planning(string sid_planning, int iid_MPOSPlanning, string sClientPDV_Code, int iReport_Id, bool bStatus_PanelPlanning,
            string sPanelPlanning_CreateBy, DateTime tPanelPlanning_DateBy,
            string sPanelPlanning_ModiBy, DateTime tPanelPlanning_DateModiBy, int iid_ReportsPlanning)
        {
            EPLA_Panel_Planning oeEPLA_Panel_Planning = new EPLA_Panel_Planning();

            DataTable dtPLA_Panel_Planning = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_PLA_Panel_Planning", sid_planning, iid_MPOSPlanning, sClientPDV_Code, iReport_Id,
                bStatus_PanelPlanning, sPanelPlanning_CreateBy, tPanelPlanning_DateBy,
                sPanelPlanning_ModiBy, tPanelPlanning_DateModiBy, iid_ReportsPlanning);

            if (dtPLA_Panel_Planning != null)
            {
                if (dtPLA_Panel_Planning.Rows.Count > 0)
                {
                    oeEPLA_Panel_Planning.id_planning = sid_planning;
                    oeEPLA_Panel_Planning.id_MPOSPlanning = iid_MPOSPlanning;
                    oeEPLA_Panel_Planning.ClientPDV_Code = sClientPDV_Code;
                    oeEPLA_Panel_Planning.Report_Id = iReport_Id;
                    oeEPLA_Panel_Planning.Status_PanelPlanning = bStatus_PanelPlanning;
                    oeEPLA_Panel_Planning.PanelPlanning_CreateBy = sPanelPlanning_CreateBy;
                    oeEPLA_Panel_Planning.PanelPlanning_DateBy = tPanelPlanning_DateBy;
                    oeEPLA_Panel_Planning.PanelPlanning_ModiBy = sPanelPlanning_ModiBy;
                    oeEPLA_Panel_Planning.PanelPlanning_DateModiBy = tPanelPlanning_DateModiBy;
                }
            }
            dtPLA_Panel_Planning = null;
            return oeEPLA_Panel_Planning;
        }



        /// <summary>
        /// Metodo para insertar reportes por planning
        /// Ing. Mauricio Ortiz
        /// 26/10/2010 
        /// Modificación: Se adiciona el campo año , fecha inicio y fecha fin . Ing. Mauricio Ortiz . 03/02/2010
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iReport_Id"></param>
        /// <param name="sid_Month"></param>
        /// <param name="iReportsPlanning_Periodo"></param>
        /// <param name="bReportsPlanning_Status"></param>
        /// <param name="sReportsPlanning_CreateBy"></param>
        /// <param name="tReportsPlanning_DateBy"></param>
        /// <param name="sReportsPlanning_ModiBy"></param>
        /// <param name="tReportsPlanning_DateModiBy"></param>
        /// <returns>dtReportesPla</returns>
        public DataTable Crear_ReportPlanning(string sid_planning, int iReport_Id, int iid_Year, string sid_Month, int iReportsPlanning_Periodo,
          DateTime tReportsPlanning_RecogerDesde, DateTime tReportsPlanning_RecogerHasta, bool bReportsPlanning_Status, string sReportsPlanning_CreateBy, DateTime tReportsPlanning_DateBy, string sReportsPlanning_ModiBy,
            DateTime tReportsPlanning_DateModiBy)
        {
            DataTable dtReportesPla = null;
            dtReportesPla = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_CREARREPORTESPLANNING", sid_planning, iReport_Id, iid_Year, sid_Month, iReportsPlanning_Periodo,
            tReportsPlanning_RecogerDesde, tReportsPlanning_RecogerHasta, bReportsPlanning_Status, sReportsPlanning_CreateBy, tReportsPlanning_DateBy, sReportsPlanning_ModiBy,
             tReportsPlanning_DateModiBy);

            return dtReportesPla;
        }


        /// Modificaciones: Se adiciona el campo Cod_channel y Assignment_Status , Ing. Mauricio Ortiz . 21/01/2010
        public EAssignment__Presentations Crear_Presentaciones_AsignacionCanal(
            string sidProductCategory, int iidProduct, int iid_productprincipal,
            int icompanyid, int icodstrategy, string sPresentaCompetition1,
            string sPresentaCompetition2, string sPresentaCompetition3,
            string scod_Channel, bool bAssignment_Status,
            string sproductServiceCreateBy, DateTime tproductServiceDateBy,
            string sproductServiceModiBy, DateTime tproductServiceDateModiBy)
        {
            DataSet dspresasi = null;
            dspresasi = oConn.ejecutarDataSet("UP_WEBSIGE_ASIGNACION_CANAL_PRESENTAREGISTER", sidProductCategory, iidProduct, iid_productprincipal, icompanyid, icodstrategy, sPresentaCompetition1, sPresentaCompetition2, sPresentaCompetition3, scod_Channel, bAssignment_Status, sproductServiceCreateBy, tproductServiceDateBy, sproductServiceModiBy, tproductServiceDateModiBy);
            EAssignment__Presentations oeapre = new EAssignment__Presentations();
            if (dspresasi != null)
            {
                if (dspresasi.Tables.Count > 0)
                {
                    oeapre.idProductCategory = sidProductCategory;
                    oeapre.idProduct = iidProduct;
                    oeapre.idproductprincipal = iid_productprincipal;
                    oeapre.companyid = icompanyid;
                    oeapre.codstrategy = icodstrategy;
                    oeapre.PresentaCompetition1 = sPresentaCompetition1;
                    oeapre.PresentaCompetition2 = sPresentaCompetition2;
                    oeapre.PresentaCompetition3 = sPresentaCompetition3;
                    oeapre.cod_Channel = scod_Channel;
                    oeapre.Assignment_Status = bAssignment_Status;
                    oeapre.productServiceCreateBy = sproductServiceCreateBy;
                    oeapre.productServiceDateBy = tproductServiceDateBy;
                    oeapre.productServiceModiBy = sproductServiceModiBy;
                    oeapre.productServiceDateModiBy = tproductServiceDateModiBy;
                }


            }
            return oeapre;


        }

        public ECity_Principal_Service Crear_Ciudad_Principal(
            string scod_City, int iCod_Strategy, string sCod_Channel,
            int icompany_id, bool bCityPri_Status,
            string sCityPri_CreateBy, DateTime tCityPri_DateBy,
            string sCityPri_ModiBy, DateTime tCityPri_DateModiBy)
        {
            DataSet dscp = null;
            dscp = oConn.ejecutarDataSet("UP_WEBSIGE_ASIGNACION_CANAL_REGISTERCIUDADPRINCIPAL", scod_City, iCod_Strategy, sCod_Channel, icompany_id, bCityPri_Status, sCityPri_CreateBy, tCityPri_DateBy, sCityPri_ModiBy, tCityPri_DateModiBy);
            ECity_Principal_Service oecp = new ECity_Principal_Service();
            if (dscp != null)
            {
                if (dscp.Tables.Count > 0)
                {
                    oecp.cod_City = scod_City;
                    oecp.CodStrategy = iCod_Strategy;
                    oecp.CodChannel = sCod_Channel;
                    oecp.company_id = icompany_id;
                    oecp.CityPriStatus = bCityPri_Status;
                    oecp.CityPriCreateBy = sCityPri_CreateBy;
                    oecp.CityPriDateBy = tCityPri_DateBy;
                    oecp.CityPriModiBy = sCityPri_ModiBy;
                    oecp.CityPriDateModiBy = tCityPri_DateModiBy;



                }


            }
            return oecp;

        }



        /// <summary>
        /// Metodo Data Para Registrar los Indicadores para Precios Ing.Carlos Hernandez
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca parametros dentro del comentario de clase
        ///                Ing. Mauricio Ortiz                 
        /// </summary>
        /// <param name="iidtabla"></param>
        /// <param name="sidplanning"></param>
        /// <param name="iidindicador"></param>
        /// <param name="icolumn"></param>
        /// <param name="sSymbolName"></param>
        /// <param name="sOperating"></param>
        /// <param name="sFormula"></param>
        /// <param name="sReformulation"></param>
        /// <param name="sorigendatos"></param>
        /// <param name="smetapricesCreateBy"></param>
        /// <param name="tmetapricesDateBy"></param>
        /// <param name="smetapricesModiBy"></param>
        /// <param name="tmetapricesDateModiBy"></param>
        /// <returns oesaveindicator></returns>
        public EMetadataPrices_Planning Crear_Indicarores_Prices_Planning(int iidtabla, string sidplanning, int iidindicador, int icolumn, string sSymbolName, string sOperating, string sFormula, string sReformulation, string sorigendatos, string smetapricesCreateBy, DateTime tmetapricesDateBy, string smetapricesModiBy, DateTime tmetapricesDateModiBy)
        {

            DataSet dsidica = null;
            dsidica = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERINDICATORPRICES", iidtabla, sidplanning, iidindicador, icolumn, sSymbolName, sOperating, sFormula, sReformulation, sorigendatos, smetapricesCreateBy, tmetapricesDateBy, smetapricesModiBy, tmetapricesDateModiBy);
            EMetadataPrices_Planning oesaveindicator = new EMetadataPrices_Planning();
            if (dsidica != null)
            {
                if (dsidica.Tables.Count > 0)
                {
                    oesaveindicator.objectid = iidtabla;
                    oesaveindicator.idplanning = sidplanning;
                    oesaveindicator.idindicador = iidindicador;
                    oesaveindicator.columnid = icolumn;
                    oesaveindicator.SymbolName = sSymbolName;
                    oesaveindicator.Operating = sOperating;
                    oesaveindicator.Formula = sFormula;
                    oesaveindicator.Reformulation = sReformulation;
                    oesaveindicator.OrigenDatos = sorigendatos;
                    oesaveindicator.metapricesCreateBy = smetapricesCreateBy;
                    oesaveindicator.metapricesDateBy = tmetapricesDateBy;
                    oesaveindicator.metapricesModiBy = smetapricesModiBy;
                    oesaveindicator.metapricesDateModiBy = tmetapricesDateModiBy;
                }
            }
            return oesaveindicator;
        }


        /// <summary>
        /// Metodo Data Para Registrar los Indicadores para Cobertura Ing.Carlos Hernandez
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca parametros dentro del comentario de clase
        ///                Ing. Mauricio Ortiz                 
        /// </summary>
        /// <param name="iidtabla"></param>
        /// <param name="sidplanning"></param>
        /// <param name="iidindicador"></param>
        /// <param name="icolumn"></param>
        /// <param name="sSymbolName"></param>
        /// <param name="sOperating"></param>
        /// <param name="sFormula"></param>
        /// <param name="sReformulation"></param>
        /// <param name="sorigendatos"></param>
        /// <param name="smetacoverageCreateBy"></param>
        /// <param name="tmetacoverageDateBy"></param>
        /// <param name="smetacoverageModiBy"></param>
        /// <param name="tmetacoverageDateModiBy"></param>
        /// <returns oesaveindicator></returns>
        public EMetadataCoverage_Planning Crear_Indicarores_coverage_Planning(int iidtabla, string sidplanning, int iidindicador, int icolumn, string sSymbolName, string sOperating, string sFormula, string sReformulation, string sorigendatos, string smetacoverageCreateBy, DateTime tmetacoverageDateBy, string smetacoverageModiBy, DateTime tmetacoverageDateModiBy)
        {

            DataSet dsidica = null;
            dsidica = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERINDICATORCOVERAGE", iidtabla, sidplanning, iidindicador, icolumn, sSymbolName, sOperating, sFormula, sReformulation, sorigendatos, smetacoverageCreateBy, tmetacoverageDateBy, smetacoverageModiBy, tmetacoverageDateModiBy);
            EMetadataCoverage_Planning oesaveindicator = new EMetadataCoverage_Planning();
            if (dsidica != null)
            {
                if (dsidica.Tables.Count > 0)
                {
                    oesaveindicator.objectid = iidtabla;
                    oesaveindicator.idplanning = sidplanning;
                    oesaveindicator.idindicador = iidindicador;
                    oesaveindicator.columnid = icolumn;
                    oesaveindicator.SymbolName = sSymbolName;
                    oesaveindicator.Operating = sOperating;
                    oesaveindicator.Formula = sFormula;
                    oesaveindicator.Reformulation = sReformulation;
                    oesaveindicator.OrigenDatos = sorigendatos;
                    oesaveindicator.metacoverageCreateBy = smetacoverageCreateBy;
                    oesaveindicator.metacoverageDateBy = tmetacoverageDateBy;
                    oesaveindicator.metacoverageModiBy = smetacoverageModiBy;
                    oesaveindicator.metacoverageDateModiBy = tmetacoverageDateModiBy;
                }
            }
            return oesaveindicator;
        }

        /// <summary>
        /// Metodo Data Para Registrar los Indicadores para Medicion de Espacios Ing.Carlos Hernandez
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca parametros dentro del comentario de clase
        ///                Ing. Mauricio Ortiz                 
        /// </summary>
        /// <param name="iidtabla"></param>
        /// <param name="sidplanning"></param>
        /// <param name="iidindicador"></param>
        /// <param name="icolumn"></param>
        /// <param name="sSymbolName"></param>
        /// <param name="sOperating"></param>
        /// <param name="sFormula"></param>
        /// <param name="sReformulation"></param>
        /// <param name="sorigendatos"></param>
        /// <param name="smetaspaceCreateBy"></param>
        /// <param name="tmetaspaceDateBy"></param>
        /// <param name="smetaspaceModiBy"></param>
        /// <param name="tmetaspaceDateModiBy"></param>
        /// <returns oesaveindicator></returns>
        public EMetadataSpaceMeasurement_Planning Crear_Indicarores_Space_Planning(int iidtabla, string sidplanning, int iidindicador, int icolumn, string sSymbolName, string sOperating, string sFormula, string sReformulation, string sorigendatos, string smetaspaceCreateBy, DateTime tmetaspaceDateBy, string smetaspaceModiBy, DateTime tmetaspaceDateModiBy)
        {
            DataSet dsidica = null;
            dsidica = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERINDICATORSPACE", iidtabla, sidplanning, iidindicador, icolumn, sSymbolName, sOperating, sFormula, sReformulation, sorigendatos, smetaspaceCreateBy, tmetaspaceDateBy, smetaspaceModiBy, tmetaspaceDateModiBy);
            EMetadataSpaceMeasurement_Planning oesaveindicator = new EMetadataSpaceMeasurement_Planning();
            if (dsidica != null)
            {
                if (dsidica.Tables.Count > 0)
                {
                    oesaveindicator.objectid = iidtabla;
                    oesaveindicator.idplanning = sidplanning;
                    oesaveindicator.idindicador = iidindicador;
                    oesaveindicator.columnid = icolumn;
                    oesaveindicator.SymbolName = sSymbolName;
                    oesaveindicator.Operating = sOperating;
                    oesaveindicator.Formula = sFormula;
                    oesaveindicator.Reformulation = sReformulation;
                    oesaveindicator.OrigenDatos = sorigendatos;
                    oesaveindicator.metaspaceCreateBy = smetaspaceCreateBy;
                    oesaveindicator.metaspaceDateBy = tmetaspaceDateBy;
                    oesaveindicator.metaspaceModiBy = smetaspaceModiBy;
                    oesaveindicator.metaspaceDateModiBy = tmetaspaceDateModiBy;
                }
            }
            return oesaveindicator;
        }

        /// <summary>
        /// Metodo para Asignar Operativos a Supervisores Ing. Carlos Hernandez 18/12/2009
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca parametros dentro del comentario de clase
        ///                Ing. Mauricio Ortiz                 
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="iPersonidSupe"></param>
        /// <param name="iPersonidOpera"></param>
        /// <param name="bAsigmenPerstatus"></param>
        /// <param name="sAsigmenPerCreateBy"></param>
        /// <param name="tAsigmenPerDateBy"></param>
        /// <param name="sAsigmenPerModiBy"></param>
        /// <param name="tAsigmenPerDateModiBy"></param>
        /// <returns oeasiop></returns>
        public EOperating__Supervisor__Assignment Crear_Asignaciones_Operativos_Supervi(string sidplanning, int iPersonidSupe, int iPersonidOpera, bool bAsigmenPerstatus, string sAsigmenPerCreateBy, DateTime tAsigmenPerDateBy, string sAsigmenPerModiBy, DateTime tAsigmenPerDateModiBy)
        {
            DataSet dsasisop = null;
            dsasisop = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTEROPERATYXSUPERVISOR", sidplanning, iPersonidSupe, iPersonidOpera, bAsigmenPerstatus, sAsigmenPerCreateBy, tAsigmenPerDateBy, sAsigmenPerModiBy, tAsigmenPerDateModiBy);
            EOperating__Supervisor__Assignment oeasiop = new EOperating__Supervisor__Assignment();
            if (dsasisop != null)
            {
                if (dsasisop.Tables.Count > 0)
                {
                    oeasiop.idplanning = sidplanning;
                    oeasiop.PersonidSupe = iPersonidSupe;
                    oeasiop.PersonidOpera = iPersonidOpera;
                    oeasiop.AsigmenPerstatus = bAsigmenPerstatus;
                    oeasiop.AsigmenPerCreateBy = sAsigmenPerCreateBy;
                    oeasiop.AsigmenPerDateBy = tAsigmenPerDateBy;
                    oeasiop.AsigmenPerModiBy = sAsigmenPerModiBy;
                    oeasiop.AsigmenPerDateModiBy = tAsigmenPerDateModiBy;
                }
            }
            return oeasiop;
        }


        public ESales_Plan Crear_Plan_Ventas(int icodstrategy, int icompanyid, string sPlanningCodChannel, int iidCityPri, decimal fValuePlanCityPri, string scodcountry, decimal fValuePlanCountry, string sSalesPlanUnit, int iidMonth, int iYearsid, bool bSalesPlan_Status, string sSalesPlanCreateBy, DateTime tSalesPlanDateBy, string sSalesPlanModiBy, DateTime tSalesPlanDateModiBy)
        {

            DataSet dsplan = null;
            dsplan = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_SALESPLAN", icodstrategy, icompanyid, sPlanningCodChannel, iidCityPri, fValuePlanCityPri, scodcountry, fValuePlanCountry, sSalesPlanUnit, iidMonth, iYearsid, bSalesPlan_Status, sSalesPlanCreateBy, tSalesPlanDateBy, sSalesPlanModiBy, tSalesPlanDateModiBy);
            ESales_Plan oesalesplan = new ESales_Plan();
            if (dsplan != null)
            {
                if (dsplan.Tables.Count > 0)
                {
                    oesalesplan.codstrategy = icodstrategy;
                    oesalesplan.companyid = icompanyid;
                    oesalesplan.PlanningCodChannel = sPlanningCodChannel;
                    oesalesplan.idCityPri = iidCityPri;
                    oesalesplan.ValuePlanCityPri = fValuePlanCityPri;
                    oesalesplan.codcountry = scodcountry;
                    oesalesplan.ValuePlanCountry = fValuePlanCountry;
                    oesalesplan.SalesPlanUnit = sSalesPlanUnit;
                    oesalesplan.idMonth = iidMonth;
                    oesalesplan.Yearsid = iYearsid;
                    oesalesplan.SalesPlan_Status = bSalesPlan_Status;
                    oesalesplan.SalesPlanCreateBy = sSalesPlanCreateBy;
                    oesalesplan.SalesPlanDateBy = tSalesPlanDateBy;
                    oesalesplan.SalesPlanModiBy = sSalesPlanModiBy;
                    oesalesplan.SalesPlanDateModiBy = tSalesPlanDateModiBy;
                }
            }
            return oesalesplan;

        }

        /// <summary>
        /// Método para Crear Sugerencias de la Actividad 
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="ssuggDescription"></param>
        /// <param name="ssuggCreateBy"></param>
        /// <param name="tsuggDateBy"></param>
        /// <param name="ssuggModiBy"></param>
        /// <param name="tsuggDateModiBy"></param>
        /// <returns oesugg></returns>
        public ESuggetionPlanning Crear_Suggetion(string sidplanning, string ssuggDescription, string ssuggCreateBy, DateTime tsuggDateBy, string ssuggModiBy, DateTime tsuggDateModiBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_REGISTERSUGETION", sidplanning, ssuggDescription, ssuggCreateBy, tsuggDateBy, ssuggModiBy, tsuggDateModiBy);
            ESuggetionPlanning oesugg = new ESuggetionPlanning();
            if (ds != null)
            {

                if (ds.Tables.Count > 0)
                {
                    oesugg.idplanning = sidplanning;
                    oesugg.suggDescription = ssuggDescription;
                    oesugg.suggCreateBy = ssuggCreateBy;
                    oesugg.suggDateBy = tsuggDateBy;
                    oesugg.suggModiBy = ssuggModiBy;
                    oesugg.suggDateModiBy = tsuggDateModiBy;
                }
            }
            return oesugg;

        }


        /// <summary>
        /// Metodo para Crear  Reportes para Planning 
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iReportSt_id"></param>
        /// <param name="bReportsPlanning_Status"></param>
        /// <param name="sReportsPlanning_CreateBy"></param>
        /// <param name="tReportsPlanning_DateBy"></param>
        /// <param name="sReportsPlanning_ModiBy"></param>
        /// <param name="tReportsPlanning_DateModiBy"></param>
        /// <returns oereport></returns>
        public EReports_Planning Crear_Formatos_Planning(string sid_planning, int iReportSt_id, bool bReportsPlanning_Status, string sReportsPlanning_CreateBy, DateTime tReportsPlanning_DateBy, string sReportsPlanning_ModiBy, DateTime tReportsPlanning_DateModiBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_REGISTERFORMATOSPLANNIG", sid_planning, iReportSt_id, bReportsPlanning_Status, sReportsPlanning_CreateBy, tReportsPlanning_DateBy, sReportsPlanning_ModiBy, tReportsPlanning_DateModiBy);
            EReports_Planning oereport = new EReports_Planning();
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oereport.id_planning = sid_planning;
                    oereport.ReportsPlanning_Status = bReportsPlanning_Status;
                    oereport.ReportsPlanning_CreateBy = sReportsPlanning_CreateBy;
                    oereport.ReportsPlanning_DateBy = tReportsPlanning_DateBy;
                    oereport.ReportsPlanning_ModiBy = sReportsPlanning_ModiBy;
                    oereport.ReportsPlanning_DateModiBy = tReportsPlanning_DateModiBy;
                }
            }
            return oereport;
        }

        /// <summary>
        /// Método para registrar el material pop para el planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca comentario de clase
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sidplanning"></param>
        /// <param name="iidMPointOfPurchase"></param>
        /// <param name="bMPOPPlanningStatus"></param>
        /// <param name="sMPOPPlanningCreateBy"></param>
        /// <param name="tMPOPPlanningDateBy"></param>
        /// <param name="sMPOPPlanningModiBy"></param>
        /// <param name="tMPOPPlanningDateModiBy"></param>
        /// <returns oempop></returns>
        public EMPointOfPurchase_Planning Crear_MPOP_PLanning(string sidplanning, int iidMPointOfPurchase, bool bMPOPPlanningStatus, string sMPOPPlanningCreateBy, DateTime tMPOPPlanningDateBy, string sMPOPPlanningModiBy, DateTime tMPOPPlanningDateModiBy)
        {
            DataSet dsmpop = null;
            dsmpop = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERMPOP", sidplanning, iidMPointOfPurchase, bMPOPPlanningStatus, sMPOPPlanningCreateBy, tMPOPPlanningDateBy, sMPOPPlanningModiBy, tMPOPPlanningDateModiBy);
            EMPointOfPurchase_Planning oempop = new EMPointOfPurchase_Planning();
            if (dsmpop != null)
            {
                if (dsmpop.Tables.Count > 0)
                {
                    oempop.id_Planning = sidplanning;
                    oempop.id_MPointOfPurchase = iidMPointOfPurchase;
                    oempop.MPOPPlanning_Status = bMPOPPlanningStatus;
                    oempop.MPOPPlanning_CreateBy = sMPOPPlanningCreateBy;
                    oempop.MPOPPlanning_DateBy = tMPOPPlanningDateBy;
                    oempop.MPOPPlanning_ModiBy = sMPOPPlanningModiBy;
                    oempop.MPOPPlanning_DateModiBy = tMPOPPlanningDateModiBy;
                }
            }
            return oempop;
        }

        /// <summary>
        /// Método para crear items adicionales en el planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca comentario de clase
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="iidcod_Point"></param>
        /// <param name="sidplanning"></param>
        /// <param name="sitemadiCreateBy"></param>
        /// <param name="titemadiDateBy"></param>
        /// <param name="sitemadModiBy"></param>
        /// <param name="TitemadDateModiBy"></param>
        /// <returns oeitemsave></returns>
        public EAdditionalItems__Management Crear_ItemsAditional_Planning(int iidcod_Point, string sidplanning, string sitemadiCreateBy, DateTime titemadiDateBy, string sitemadModiBy, DateTime TitemadDateModiBy)
        {
            DataSet dsitem = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTER_ADITIONALITEMS", iidcod_Point, sidplanning, sitemadiCreateBy, titemadiDateBy, sitemadModiBy, TitemadDateModiBy);
            EAdditionalItems__Management oeitemsave = new EAdditionalItems__Management();
            if (dsitem != null)
            {
                if (dsitem.Tables.Count > 0)
                {
                    oeitemsave.idcod_Point = iidcod_Point;
                    oeitemsave.idplanning = sidplanning;
                    oeitemsave.itemadiCreateBy = sitemadiCreateBy;
                    oeitemsave.itemadiDateBy = titemadiDateBy;
                    oeitemsave.itemadModiBy = sitemadModiBy;
                    oeitemsave.itemadDateModiBy = TitemadDateModiBy;
                }
            }
            return oeitemsave;
        }

        /// <summary>
        /// Metodo para crear puntos de venta del planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca comentario de clase
        ///                Ing. Mauricio Ortiz        
        /// </summary>
        /// <param name="iid_ClientPDV"></param>
        /// <param name="sid_Planning"></param>
        /// <param name="bPointOfSalePlanning_Status"></param>
        /// <param name="sPointOfSalePlanning_CreateBy"></param>
        /// <param name="tPointOfSalePlanning_DateBy"></param>
        /// <param name="sPointOfSalePlanning_ModiBy"></param>
        /// <param name="tPointOfSalePlanning_DateModiBy"></param>
        /// <returns oepoipla></returns>
        public EPointOfSale_Planning Crear_PDV_Planning(int iid_ClientPDV, string sid_Planning, bool bPointOfSalePlanning_Status, string sPointOfSalePlanning_CreateBy, DateTime tPointOfSalePlanning_DateBy, string sPointOfSalePlanning_ModiBy, DateTime tPointOfSalePlanning_DateModiBy)
        {
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_REGISTERPDVXPLA", iid_ClientPDV, sid_Planning, bPointOfSalePlanning_Status, sPointOfSalePlanning_CreateBy, tPointOfSalePlanning_DateBy, sPointOfSalePlanning_ModiBy, tPointOfSalePlanning_DateModiBy);
            EPointOfSale_Planning oepoipla = new EPointOfSale_Planning();
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oepoipla.id_ClientPDV = iid_ClientPDV;
                    oepoipla.id_Planning = sid_Planning;
                    oepoipla.PointOfSalePlanning_Status = bPointOfSalePlanning_Status;
                    oepoipla.PointOfSalePlanning_CreateBy = sPointOfSalePlanning_CreateBy;
                    oepoipla.PointOfSalePlanning_DateBy = tPointOfSalePlanning_DateBy;
                    oepoipla.PointOfSalePlanning_ModiBy = sPointOfSalePlanning_ModiBy;
                    oepoipla.PointOfSalePlanning_DateModiBy = tPointOfSalePlanning_DateModiBy;
                }
            }
            return oepoipla;
        }

        /// <summary>
        /// Metodo para crear productos del planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca comentario de clase
        ///                Ing. Mauricio Ortiz
        ///                31/08/2010 se cambia tipo de dato de lid_Product de int a long . Ing. Mauricio Ortiz
        ///                02/03/2011 se adiciona el parametro Report_Id . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="lid_Product"></param>
        /// <param name="sidProductCategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sidSubBrand"></param>
        /// <param name="sProducCarac"></param>
        /// <param name="sProducBeni"></param>
        /// <param name="iProductsPlanningInitialStock"></param>
        /// <param name="iReport_Id"></param>
        /// <param name="bStatus"></param>
        /// <param name="sProductPlanCreateBy"></param>
        /// <param name="tProductPlanDateBy"></param>
        /// <param name="sProductPlanModiBy"></param>
        /// <param name="tProductPlanDateModiBy"></param>
        /// <returns oeprosave></returns>
        public EProducts_Planning Crear_Products_Planning(string sid_planning, long lid_Product, string sidProductCategory, int iid_Brand, string sidSubBrand, string sProducCarac, string sProducBeni, int iProductsPlanningInitialStock, int iReport_Id, bool bStatus, string sProductPlanCreateBy, DateTime tProductPlanDateBy, string sProductPlanModiBy, DateTime tProductPlanDateModiBy)
        {//eliminar
            DataSet ds = null;
            ds = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERPRODUCTPLANNING", sid_planning, lid_Product, sidProductCategory, iid_Brand, sidSubBrand, sProducCarac, sProducBeni, iProductsPlanningInitialStock, iReport_Id, bStatus, sProductPlanCreateBy, tProductPlanDateBy, sProductPlanModiBy, tProductPlanDateModiBy);
            EProducts_Planning oeprosave = new EProducts_Planning();
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oeprosave.id_planning = sid_planning;
                    oeprosave.id_Product = lid_Product;
                    oeprosave.idProductCategory = sidProductCategory;
                    oeprosave.id_Brand = iid_Brand;
                    oeprosave.idSubBrand = sidSubBrand;
                    oeprosave.ProductCaracte = sProducCarac;
                    oeprosave.ProductBenefi = sProducBeni;
                    oeprosave.ProductsPlanning_InitialStock = iProductsPlanningInitialStock;
                    oeprosave.Report_Id = iReport_Id;
                    oeprosave.Status = bStatus;
                    oeprosave.ProductPlaCreateBy = sProductPlanCreateBy;
                    oeprosave.ProductPlaDateBy = tProductPlanDateBy;
                    oeprosave.ProductPlanModiBy = sProductPlanModiBy;
                    oeprosave.ProductPlanDateModiBy = tProductPlanDateModiBy;
                }
            }
            return oeprosave;
        }

        public DataTable Crear_Productos_Planning(string sid_planning, long lid_Product, string sidProductCategory, int iid_Brand, string sidSubBrand, string sProduct_Family, string sProduct_SubFamily, string sProducCarac, string sProducBeni, int iProductsPlanningInitialStock, int iReport_Id, bool bStatus, string sProductPlanCreateBy, DateTime tProductPlanDateBy, string sProductPlanModiBy, DateTime tProductPlanDateModiBy)
        {
            Conexion cn = new Conexion();
            DataTable dt = null;
            dt = cn.ejecutarDataTable("UP_WEBSIGE_PLANNING_REGISTERPRODUCTPLANNING", sid_planning, lid_Product, sidProductCategory, iid_Brand, sidSubBrand, sProduct_Family, sProduct_SubFamily, sProducCarac, sProducBeni, iProductsPlanningInitialStock, iReport_Id, bStatus, sProductPlanCreateBy, tProductPlanDateBy, sProductPlanModiBy, tProductPlanDateModiBy);
            return dt;
        }
        
        /// <summary>
        /// Método para insertar registro en la tabla PLA_Brand_Planning
        /// Ing. Mauricio Ortiz
        /// 26/02/2011
        /// Modificación : 02/03/2011 se adiciona el parametro Report_Id . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="iReport_Id"></param>
        /// <param name="bStatus"></param>
        /// <param name="sBrandPlan_CreateBy"></param>
        /// <param name="tBrandPlan_DateBy"></param>
        /// <param name="sBrandPlan_ModiBy"></param>
        /// <param name="tBrandPlan_DateModiBy"></param>
        /// <returns></returns>
        //public DataTable Crear_MarcasPlanning(string sid_planning, string sid_ProductCategory, int iid_Brand , int iReport_Id, bool bStatus, string sBrandPlan_CreateBy, DateTime tBrandPlan_DateBy, string sBrandPlan_ModiBy, DateTime tBrandPlan_DateModiBy)
        //{
        //    DataTable dt = null;
        //    dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_PLA_Brand_Planning", sid_planning, sid_ProductCategory, iid_Brand, iReport_Id, bStatus, sBrandPlan_CreateBy, tBrandPlan_DateBy, sBrandPlan_ModiBy, tBrandPlan_DateModiBy);
        //    return dt;
        //}
        //cambio para captar actualizacion
        public DataTable Crear_Marcas_Planning(string sid_planning, string sid_ProductCategory, int iid_Brand, int iReport_Id, bool bStatus, string sBrandPlan_CreateBy, DateTime tBrandPlan_DateBy, string sBrandPlan_ModiBy, DateTime tBrandPlan_DateModiBy)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_PLA_Brand_Planning", sid_planning, sid_ProductCategory, iid_Brand, iReport_Id, bStatus, sBrandPlan_CreateBy, tBrandPlan_DateBy, sBrandPlan_ModiBy, tBrandPlan_DateModiBy);
            return dt;
        }

        public DataTable Crear_FamiliasPlanning(string sid_planning, string sid_ProductCategory, int iid_Brand, string sid_ProductFamily, int iReport_Id, bool bStatus, string sFamilyPlan_CreateBy, DateTime tFamilyPlan_DateBy, string sFamilyPlan_ModiBy, DateTime tFamilyPlan_DateModiBy)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_PLA_Family_Planning", sid_planning, sid_ProductCategory, iid_Brand, sid_ProductFamily, iReport_Id, bStatus, sFamilyPlan_CreateBy, tFamilyPlan_DateBy, sFamilyPlan_ModiBy, tFamilyPlan_DateModiBy);
            return dt;
        }

        /// <summary>
        /// Método para crear registros en la tabla PLA_Category_Planning
        /// Ing. Mauricio Ortiz
        /// 05/05/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="iReport_Id"></param>
        /// <param name="bStatus"></param>
        /// <param name="sCategoryPlan_CreateBy"></param>
        /// <param name="tCategoryPlan_DateBy"></param>
        /// <param name="sCategoryPlan_ModiBy"></param>
        /// <param name="tCategoryPlan_DateModiBy"></param>
        /// <returns></returns>
        public DataTable Crear_CategoriasPlanning(string sid_planning, string sid_ProductCategory, int iReport_Id, bool bStatus, string sCategoryPlan_CreateBy, DateTime tCategoryPlan_DateBy, string sCategoryPlan_ModiBy, DateTime tCategoryPlan_DateModiBy)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_PLA_Category_Planning", sid_planning, sid_ProductCategory, iReport_Id, bStatus, sCategoryPlan_CreateBy, tCategoryPlan_DateBy, sCategoryPlan_ModiBy, tCategoryPlan_DateModiBy);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
            }
            return dt;
        }

        /// <summary>
        /// Método para regitrar en la tabla TBL_PRODUCTO_CADENA 
        /// Ing. Mauricio Ortiz
        /// 16/02/2011
        /// </summary>
        /// <param name="stipoProducto"></param>
        /// <param name="lid_Product"></param>
        /// <param name="sid_planning"></param>
        /// <returns></returns>
        public DataTable Registrar_TBL_PRODUCTO_CADENA(string sescenario, string stipoProducto, long lid_Product, string sid_planning,
            string sID_SKU, string sID_CADENA, string sID_CANAL, string sCOD_PRODUCTO, string sID_CLIENTE, string sID_CATEGORIA, string sID_MARCA, string sID_FAMILIA, string @TIPO_PRODUCTO, string sFLG_ACTIVO)
        {
            oConn = new Conexion(2);
            DataTable dtRegistrar_TBL_PRODUCTO_CADENA = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_PRODUCTO_CADENA", sescenario, stipoProducto, lid_Product, sid_planning,
                 sID_SKU, sID_CADENA, sID_CANAL, sCOD_PRODUCTO, sID_CLIENTE, sID_CATEGORIA, sID_MARCA, sID_FAMILIA, @TIPO_PRODUCTO, sFLG_ACTIVO);
            return dtRegistrar_TBL_PRODUCTO_CADENA;
        }

        /// <summary>
        /// Método para regitrar en la tabla TBL_EQUIPO_PRODUCTOS 
        /// Ing. Mauricio Ortiz
        /// 11/04/2011
        /// Modificación: se adiciona el parametro  string sopcionreporte para poder ingresar 1 o null en campo FLAG_MANDATORIO
        /// </summary>
        /// <param name="stipoProducto"></param>
        /// <param name="sopcionreporte"></param>
        /// <returns></returns>

        public DataTable Registrar_TBL_EQUIPO_PRODUCTOS(string id_planning, long id_producto, string cod_producto,
                string id_categoria, string categoria, int id_marca, string id_submarca, string id_eq_fam, string id_familia, string familia, string id_eq_subfam,
            string id_subfamilia, string subfamilia, string marca, string mar_propio, int id_reporte, string tipo_prod, string sopcionreporte, string idcompany, string canal)
        {
            oConn = new Conexion(2);
            DataTable dtRegistrar_TBL_EQUIPO_PRODUCTOS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_EQUIPO_PRODUCTOS", id_planning, id_producto, cod_producto,
                id_categoria, categoria, id_marca, id_submarca, id_eq_fam, id_familia, familia, id_eq_subfam, id_subfamilia, subfamilia, marca, mar_propio,
                id_reporte, tipo_prod, sopcionreporte, idcompany, canal);
            return dtRegistrar_TBL_EQUIPO_PRODUCTOS;
        }

        /// <summary>
        /// Método para registrar en la tabla TBL_EQUIPO_MARCAS
        /// Angel Ortiz
        /// 25/08/2011
        /// Modificación: Se adiciona los parámetros para realizar la inserción desde la aplicación.
        /// </summary>
        /// <returns></returns>
        public DataTable Registrar_TBL_EQUIPO_MARCAS(string id_eq_marca, string id_equipo, string id_categoria, string categoria, string id_eq_categoria,
            string id_marca, string id_reporte, string status)
        {
            oConn = new Conexion(2);
            DataTable dtRegistrar_TBL_EQUIPO_MARCAS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_EQUIPO_MARCAS", id_eq_marca, id_equipo, id_categoria, categoria,
                id_eq_categoria, id_marca, id_reporte, status);
            return dtRegistrar_TBL_EQUIPO_MARCAS;
        }

        /// <summary>
        /// Método para registrar en la tabla TBL_EQUIPO_FAMILIAS 
        /// Ing. Mauricio Ortiz
        /// 23/03/2011
        /// Angel Ortiz
        /// 25/08/2011
        /// Modificación: Se adiciona los parámetros para realizar la inserción desde la aplicación.
        /// </summary>
        /// <returns></returns>
        public DataTable Registrar_TBL_EQUIPO_FAMILIAS(string id_eqfamilia, string id_equipo, string id_categoria, string id_eqcategoria, string id_marca, string id_eqmarca,
            string id_familia, string id_reporte)
        {
            oConn = new Conexion(2);
            DataTable dtRegistrar_TBL_EQUIPO_FAMILIAS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_EQUIPO_FAMILIAS", id_eqfamilia, id_equipo, id_categoria,
                id_eqcategoria, id_marca, id_eqmarca, id_familia, id_reporte);
            return dtRegistrar_TBL_EQUIPO_FAMILIAS;
        }

        /// <summary>
        /// Método para registrar en la tabla TBL_EQUIPO_CATEGORIAS 
        /// Ing. Mauricio Ortiz
        /// 05/05/2011
        /// Angel Ortiz
        /// 25/08/2011
        /// Modificación: Se adiciona los parámetros para realizar la inserción desde la aplicación.
        /// </summary>
        /// <returns></returns>
        public DataTable Registrar_TBL_EQUIPO_CATEGORIAS(string id_eq_catego, string id_equipo, string id_categoria, string id_reporte, string status)
        {
            oConn = new Conexion(2);
            DataTable dtRegistrar_TBL_EQUIPO_CATEGORIAS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_REGISTRAR_TBL_EQUIPO_CATEGORIAS", id_eq_catego, id_equipo, id_categoria, id_reporte, status);
            return dtRegistrar_TBL_EQUIPO_CATEGORIAS;
        }


        /// <summary>
        /// Metodo Data Para Registrar los Indicadores para Ventas Ing.Carlos Hernandez
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca parametros dentro del comentario de clase
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iidtabla"></param>
        /// <param name="sidplanning"></param>
        /// <param name="iidindicador"></param>
        /// <param name="icolumn"></param>
        /// <param name="sSymbolName"></param>
        /// <param name="sOperating"></param>
        /// <param name="sFormula"></param>
        /// <param name="sReformulation"></param>
        /// <param name="sorigendatos"></param>
        /// <param name="smetasalesCreateBy"></param>
        /// <param name="tmetasalesDateBy"></param>
        /// <param name="smetasalesModiBy"></param>
        /// <param name="tmetasalesDateModiBy"></param>
        /// <returns oesaveindicator></returns>
        public EMetadataSales_Planning Crear_Indicarores_Sales_Planning(int iidtabla, string sidplanning, int iidindicador, int icolumn, string sSymbolName, string sOperating, string sFormula, string sReformulation, string sorigendatos, string smetasalesCreateBy, DateTime tmetasalesDateBy, string smetasalesModiBy, DateTime tmetasalesDateModiBy)
        {
            DataSet dsidica = null;
            dsidica = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_REGISTERINDICATORSALES", iidtabla, sidplanning, iidindicador, icolumn, sSymbolName, sOperating, sFormula, sReformulation, sorigendatos, smetasalesCreateBy, tmetasalesDateBy, smetasalesModiBy, tmetasalesDateModiBy);
            EMetadataSales_Planning oesaveindicator = new EMetadataSales_Planning();
            if (dsidica != null)
            {
                if (dsidica.Tables.Count > 0)
                {
                    oesaveindicator.objectid = iidtabla;
                    oesaveindicator.idplanning = sidplanning;
                    oesaveindicator.idindicador = iidindicador;
                    oesaveindicator.columnid = icolumn;
                    oesaveindicator.SymbolName = sSymbolName;
                    oesaveindicator.Operating = sOperating;
                    oesaveindicator.Formula = sFormula;
                    oesaveindicator.Reformulation = sReformulation;
                    oesaveindicator.OrigenDatos = sorigendatos;
                    oesaveindicator.metasalesCreateBy = smetasalesCreateBy;
                    oesaveindicator.metasalesDateBy = tmetasalesDateBy;
                    oesaveindicator.metasalesModiBy = smetasalesModiBy;
                    oesaveindicator.metasalesDateModiBy = tmetasalesDateModiBy;
                }
            }
            return oesaveindicator;
        }

        /// <summary>
        /// Modificación : 25/08/2010 se elimina parametro pdv_code  ya no existe en la tabla . Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_PointOfsale"></param>
        /// <param name="sid_typeDocument"></param>
        /// <param name="spdvRegTax"></param>
        /// <param name="spdvcontact1"></param>
        /// <param name="spdvposition1"></param>
        /// <param name="spdvcontact2"></param>
        /// <param name="spdvposition2"></param>
        /// <param name="spdvRazónSocial"></param>
        /// <param name="spdvName"></param>
        /// <param name="spdvPhone"></param>
        /// <param name="spdvAnexo"></param>
        /// <param name="spdvFax"></param>
        /// <param name="spdvcodCountry"></param>
        /// <param name="snameCountry"></param>
        /// <param name="spdvcodDepartment"></param>
        /// <param name="snameDepartament"></param>
        /// <param name="spdvcodProvince"></param>
        /// <param name="snameprovince"></param>
        /// <param name="spdvcodDistrict"></param>
        /// <param name="snameDistrict"></param>
        /// <param name="spdvcodCommunity"></param>
        /// <param name="snameComunity"></param>
        /// <param name="spdvAddress"></param>
        /// <param name="spdvemail"></param>
        /// <param name="spdvcodChannel"></param>
        /// <param name="snameChannel"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="snamecomtype"></param>
        /// <param name="sNodeCommercial"></param>
        /// <param name="snamenodecomercial"></param>
        /// <param name="iid_Segment"></param>
        /// <param name="snameSegment"></param>
        /// <param name="bpdvstatus"></param>
        /// <param name="sPdvCreateBy"></param>
        /// <param name="tPdvDateBy"></param>
        /// <param name="sPdvModiBy"></param>
        /// <param name="tPdvDateModiBy"></param>
        /// <returns></returns>
        public EPuntosDV Cargar_PDV_Planning(
            int iid_PointOfsale, string sid_typeDocument, string spdvRegTax,
            string spdvcontact1, string spdvposition1, string spdvcontact2,
            string spdvposition2, string spdvRazónSocial,
            string spdvName, string spdvPhone, string spdvAnexo,
            string spdvFax, string spdvcodCountry, string snameCountry,
            string spdvcodDepartment, string snameDepartament,
            string spdvcodProvince, string snameprovince,
            string spdvcodDistrict, string snameDistrict,
            string spdvcodCommunity, string snameComunity,
            string spdvAddress, string spdvemail,
            string spdvcodChannel, string snameChannel,
            int iidNodeComType, string snamecomtype,
            string sNodeCommercial, string snamenodecomercial,
            int iid_Segment, string snameSegment,
            bool bpdvstatus, string sPdvCreateBy, DateTime tPdvDateBy,
            string sPdvModiBy, DateTime tPdvDateModiBy)
        {
            DataSet dspdv = null;
            dspdv = oConn.ejecutarDataSet(
             "UP_WEBSIGE_PLANNING_INSERTARPDVTMP",
             iid_PointOfsale, sid_typeDocument, spdvRegTax,
             spdvcontact1, spdvposition1, spdvcontact2,
             spdvposition2, spdvRazónSocial,
             spdvName, spdvPhone, spdvAnexo, spdvFax,
             spdvcodCountry, snameCountry, spdvcodDepartment,
             snameDepartament,
             spdvcodProvince, snameprovince, spdvcodDistrict,
             snameDistrict, spdvcodCommunity, snameComunity,
             spdvAddress, spdvemail,
             spdvcodChannel, snameChannel, iidNodeComType,
             snamecomtype, sNodeCommercial, snamenodecomercial,
             iid_Segment, snameSegment, bpdvstatus, sPdvCreateBy,
             tPdvDateBy, sPdvModiBy, tPdvDateModiBy);
            EPuntosDV oerPDV = new EPuntosDV();
            if (dspdv != null)
            {

                if (dspdv.Tables.Count > 0)
                {

                    oerPDV.id_PointOfsale = iid_PointOfsale;
                    oerPDV.id_typeDocument = sid_typeDocument;
                    oerPDV.pdvRegTax = spdvRegTax;
                    oerPDV.pdvcontact1 = spdvcontact1;
                    oerPDV.pdvposition1 = spdvposition1;
                    oerPDV.pdvcontact2 = spdvcontact2;
                    oerPDV.pdvposition2 = spdvposition2;
                    oerPDV.pdvRazónSocial = spdvRazónSocial;
                    oerPDV.pdvName = spdvName;
                    oerPDV.pdvPhone = spdvPhone;
                    oerPDV.pdvAnexo = spdvAnexo;
                    oerPDV.pdvFax = spdvFax;
                    oerPDV.pdvcodCountry = spdvcodCountry;
                    oerPDV.nameCountry = snameCountry;
                    oerPDV.pdvcodDepartment = spdvcodDepartment;
                    oerPDV.nameDepartament = snameDepartament;
                    oerPDV.pdvcodProvince = spdvcodProvince;
                    oerPDV.nameprovince = snameprovince;
                    oerPDV.pdvcodDistrict = spdvcodDistrict;
                    oerPDV.nameDistrict = snameDistrict;
                    oerPDV.pdvcodCommunity = spdvcodCommunity;
                    oerPDV.nameComunity = snameComunity;
                    oerPDV.pdvAddress = spdvAddress;
                    oerPDV.pdvemail = spdvemail;
                    oerPDV.pdvcodChannel = spdvcodChannel;
                    oerPDV.nameChannel = snameChannel;
                    oerPDV.idNodeComType = iidNodeComType;
                    oerPDV.nameNodeType = snamecomtype;
                    oerPDV.NodeCommercial = sNodeCommercial;
                    oerPDV.nameNodeComercial = snamenodecomercial;
                    oerPDV.id_Segment = iid_Segment;
                    oerPDV.nameSegment = snameSegment;
                    oerPDV.pdvstatus = bpdvstatus;
                    oerPDV.PdvCreateBy = sPdvCreateBy;
                    oerPDV.PdvDateBy = tPdvDateBy;
                    oerPDV.PdvModiBy = sPdvModiBy;
                    oerPDV.PdvDateModiBy = tPdvDateModiBy;
                }
            }
            return oerPDV;
        }



        #endregion

        #region Methods: UPDATE




        /// <summary>
        /// Descripción     :Metodo para  Actualizar contacto y area involucrada en Planning
        /// Fecha Creación  : 06/08/2010
        /// Creado por      : Mauricio Ortiz 
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sPlanning_AreaInvolved"></param>
        /// <param name="sName_Contact"></param>
        /// <param name="sPlanning_ModiBy"></param>
        /// <param name="tPlanning_DateModiBy"></param>
        /// <returns oeplanning></returns>
        public EPlaning ActualizaContactoyarea(string sid_planning, string sPlanning_AreaInvolved, string sName_Contact,
             string sPlanning_ModiBy, DateTime tPlanning_DateModiBy)
        {
            EPlaning oeplanning = new EPlaning();

            DataSet ds = oConn.ejecutarDataSet("UP_WEBXPLORA_PLA_UPDATECONTACTO_Y_AREAINVOLUCRADA", sid_planning, sPlanning_AreaInvolved,
                sName_Contact, sPlanning_ModiBy, tPlanning_DateModiBy);

            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oeplanning.idplanning = sid_planning;
                    oeplanning.PlanningAreaInvolved = sPlanning_AreaInvolved;
                    oeplanning.namecontac = sName_Contact;
                    oeplanning.PlanningModiBy = sPlanning_ModiBy;
                    oeplanning.PlanningDateModiBy = tPlanning_DateModiBy;
                }
            }
            return oeplanning;
        }

        /// <summary>
        /// Descripción : Metodo para actualizar la informacion relacionada a la primera pestaña de planning . asignacion de presupuesto
        /// Creado      : Ing. Mauricio Ortiz
        /// Fecha       : 10/09/2010
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sPlanning_CodChannel"></param>
        /// <param name="tPlanning_StartActivity"></param>
        /// <param name="tPlanning_EndActivity"></param>
        /// <param name="tPlanning_DateRepSoli"></param>
        /// <param name="tPlanning_PreproduDateini"></param>
        /// <param name="tPlanning_PreproduDateEnd"></param>
        /// <param name="sPlanning_ProjectDuration"></param>
        /// <param name="tPlanning_DateFinreport"></param>
        /// <param name="sPlanning_Vigen"></param>
        /// <param name="bPlanning_Status"></param>
        /// <param name="iStatus_id"></param>
        /// <param name="sPlanning_ModiBy"></param>
        /// <param name="tPlanning_DateModiBy"></param>
        /// <returns></returns>
        public EPlaning Actualiza_DatosAsignarPresupuesto(string sid_planning, string sPlanning_CodChannel, DateTime tPlanning_StartActivity,
            DateTime tPlanning_EndActivity, DateTime tPlanning_DateRepSoli, DateTime tPlanning_PreproduDateini, DateTime tPlanning_PreproduDateEnd,
            string sPlanning_ProjectDuration, DateTime tPlanning_DateFinreport, string sPlanning_Vigen, bool bPlanning_Status, int iStatus_id,
            string sPlanning_ModiBy, DateTime tPlanning_DateModiBy)
        {
            EPlaning oePlanning = new EPlaning();
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ACTUALIZA_DATOSASIGNARPRESUPUESTO", sid_planning, sPlanning_CodChannel, tPlanning_StartActivity,
             tPlanning_EndActivity, tPlanning_DateRepSoli, tPlanning_PreproduDateini, tPlanning_PreproduDateEnd,
             sPlanning_ProjectDuration, tPlanning_DateFinreport, sPlanning_Vigen, bPlanning_Status, iStatus_id,
             sPlanning_ModiBy, tPlanning_DateModiBy);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    oePlanning.idplanning = sid_planning;
                    oePlanning.PlanningCodChannel = sPlanning_CodChannel;
                    oePlanning.PlanningStartActivity = tPlanning_StartActivity;
                    oePlanning.PlanningEndActivity = tPlanning_EndActivity;
                    oePlanning.PlanningDateRepSoli = tPlanning_DateRepSoli;
                    oePlanning.PlanningPreproduDateini = tPlanning_PreproduDateini;
                    oePlanning.PlanningPreproduDateEnd = tPlanning_PreproduDateEnd;
                    oePlanning.PlanningProjectDuration = sPlanning_ProjectDuration;
                    oePlanning.PlanningDateFinreport = tPlanning_DateFinreport;
                    oePlanning.PlanningVigen = sPlanning_Vigen;
                    oePlanning.PlanningStatus = bPlanning_Status;
                    oePlanning.Statusid = iStatus_id;
                    oePlanning.PlanningModiBy = sPlanning_ModiBy;
                    oePlanning.PlanningDateModiBy = tPlanning_DateModiBy;
                }
            }
            return oePlanning;
        }

        /// <summary>
        /// Metodo para actualizar estado en TBL_EQUIPO
        /// Ing. Mauricio Ortiz
        /// 14/02/2011
        /// Modificación : se adiciona el campo Canal . Ing. Mauricio Ortiz 24/05/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sCanal"></param>
        /// <param name="sEstado"></param>       
        /// <returns></returns>
        public DataTable ActualizarEstadoTBL_EQUIPO(string sid_planning, string sCanal, string sEstado)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ACTUALIZARPLANNING_TBL_EQUIPO", sid_planning, sCanal, sEstado);
            return dt;
        }
        public EContenedoraFormatos Actualizar_Items_Formatos(int icodItem, bool bcontenstatus, string scontenedorModiBy, DateTime tcontenedorDateModiBy)
        {
            DataSet dsconte = null;
            dsconte = oConn.ejecutarDataSet("UP_WEBSIGE_PLANNING_UPDATEITEMSFORMATO", icodItem, bcontenstatus, scontenedorModiBy, tcontenedorDateModiBy);
            EContenedoraFormatos oeconte = new EContenedoraFormatos();
            oeconte.codItem = icodItem;
            oeconte.contenstatus = bcontenstatus;
            oeconte.contenedorModiBy = scontenedorModiBy;
            oeconte.contenedorDateModiBy = tcontenedorDateModiBy;
            return oeconte;


        }



        public ECity_Principal_Service Modify_Ciudad_Principal(
    string sCod_Channel, int icompany_id, bool bCityPri_Status,
    string sCityPri_ModiBy, DateTime tCityPri_DateModiBy)
        {
            DataTable dtmcp = null;
            dtmcp = oConn.ejecutarDataTable("UP_WEBSIGE_ASIGNACION_CANAL_MODIFYCIUDADPRINCIPAL", sCod_Channel, icompany_id, bCityPri_Status, sCityPri_ModiBy, tCityPri_DateModiBy);
            ECity_Principal_Service oemcp = new ECity_Principal_Service();
            oemcp.CodChannel = sCod_Channel;
            oemcp.company_id = icompany_id;
            oemcp.CityPriStatus = bCityPri_Status;
            oemcp.CityPriModiBy = sCityPri_ModiBy;
            oemcp.CityPriDateModiBy = tCityPri_DateModiBy;
            return oemcp;
        }

        public EAssignment__Presentations Modify_Assignment__Presentations(
            string scod_Channel, string sidProductCategory, int icompanyid,
            bool bAssignment_Status, string sproductServiceModiBy,
            DateTime tproductServiceDateModiBy)
        {
            DataTable dtmap = null;
            dtmap = oConn.ejecutarDataTable("UP_WEBSIGE_ASIGNACION_CANAL_MODIFYASIGNACIONCATEGORIA", scod_Channel, sidProductCategory, icompanyid, bAssignment_Status, sproductServiceModiBy, tproductServiceDateModiBy);
            EAssignment__Presentations oemap = new EAssignment__Presentations();
            oemap.cod_Channel = scod_Channel;
            oemap.idProductCategory = sidProductCategory;
            oemap.companyid = icompanyid;
            oemap.Assignment_Status = bAssignment_Status;
            oemap.productServiceModiBy = sproductServiceModiBy;
            oemap.productServiceDateModiBy = tproductServiceDateModiBy;

            return oemap;
        }

        public EAssignment__Presentations Modify_Assignment__PresentationXCategoria(
            string scod_Channel, string sidProductCategory, int iid_Product,
            int icompanyid, bool bAssignment_Status, string sproductServiceModiBy,
            DateTime tproductServiceDateModiBy)
        {
            DataTable dtmap = null;
            dtmap = oConn.ejecutarDataTable("UP_WEBSIGE_ASIGNACION_CANAL_MODIFYASIGNACIONPRODUCTOPRINCIPALXCATEGORIA", scod_Channel, sidProductCategory, iid_Product, icompanyid, bAssignment_Status, sproductServiceModiBy, tproductServiceDateModiBy);
            EAssignment__Presentations oemap = new EAssignment__Presentations();
            oemap.cod_Channel = scod_Channel;
            oemap.idProductCategory = sidProductCategory;
            oemap.idProduct = iid_Product;
            oemap.companyid = icompanyid;
            oemap.Assignment_Status = bAssignment_Status;
            oemap.productServiceModiBy = sproductServiceModiBy;
            oemap.productServiceDateModiBy = tproductServiceDateModiBy;

            return oemap;
        }

        /// <summary>
        /// Metodo para actulizar Presupuesto de Campañas Lucky
        /// </summary>
        public EPresupuesto Actualizar_Presupuestos(string sNumberbudget, string sprenew, string snamepresu, DateTime tFeciniPlanning, DateTime tFecFinPlanning, string sbudgetModiBy, DateTime tbudgetDateModiBy)
        {
            DataTable dtupresu = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATE_PRESUPUESTO", sNumberbudget, sprenew, snamepresu, tFeciniPlanning, tFecFinPlanning, sbudgetModiBy, tbudgetDateModiBy);
            EPresupuesto oePresupuesto = new EPresupuesto();

            oePresupuesto.Numberbudget = sprenew;
            oePresupuesto.Namebudget = snamepresu;

            oePresupuesto.FeciniPlanning = tFeciniPlanning;
            oePresupuesto.FecFinPlanning = tFecFinPlanning;
            oePresupuesto.budgetModiBy = sbudgetModiBy;
            oePresupuesto.budgetDateModiBy = tbudgetDateModiBy;
            return oePresupuesto;
        }

        /// <summary>
        /// Metodo para Actualizar Objetivos en Planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca parametros dentro del comentario de clase
        ///                Ing. Mauricio Ortiz              
        /// </summary>
        /// <param name="sobjPlaDescription"></param>
        /// <param name="sobjPlaModiBy"></param>
        /// <param name="tobjPlaDatemodiBy"></param>
        /// <param name="sidplanning"></param>
        /// <returns oeupObjetivos></returns>
        public EObjetivesPlanning Actualizar_Objetivos_Planning(string sobjPlaDescription, string sobjPlaModiBy, DateTime tobjPlaDatemodiBy, string sidplanning)
        {
            DataTable dtupobj = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATE_OBJETIVESPLANNING", sobjPlaDescription, sobjPlaModiBy, tobjPlaDatemodiBy, sidplanning);
            EObjetivesPlanning oeupObjetivos = new EObjetivesPlanning();
            oeupObjetivos.objPlaDescription = sobjPlaDescription;
            oeupObjetivos.objPlaModiBy = sobjPlaModiBy;
            oeupObjetivos.objPlaDatemodiBy = tobjPlaDatemodiBy;
            oeupObjetivos.id_Planning = sidplanning;
            return oeupObjetivos;
        }

        /// <summary>
        /// ---Metodo Para Actualizar Planning
        /// </summary>
        /// ----Parametros de Entrada
        /// <param name="snameclient"></param>
        /// <param name="semailcontac"></param>
        /// <param name="snumprenew"></param>
        /// <param name="bstatus"></param>
        /// <param name="snameuser"></param>
        /// <param name="tdatemodiby"></param>
        /// ---Parametros de Salida
        /// <returns>Retorna un objeto tipo EPlanning</returns>
        public EPlaning Actualizar_Planning(string snameplanning, string snameclient, string semailcontac, string snumprenew, bool bstatus, string snumpresu, string snameuser, DateTime tdatemodiby)
        {
            DataTable dtuppla = null;
            dtuppla = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATEPLANNING", snameplanning, snameclient, semailcontac, snumprenew, bstatus, snumpresu, snameuser, tdatemodiby);
            EPlaning oeplanning = new EPlaning();
            oeplanning.PlanningName = snameplanning;
            oeplanning.namecontac = snameclient;
            oeplanning.emailcontac = semailcontac;
            oeplanning.PlanningStatus = bstatus;
            oeplanning.PlanningModiBy = snameuser;
            oeplanning.PlanningDateModiBy = tdatemodiby;
            return oeplanning;
        }

        /// <summary>
        /// Metodo para Actualizar Mecanica de la Actividad en Planning
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca parametros dentro del comentario de clase
        ///                Ing. Mauricio Ortiz              
        /// </summary>
        /// <param name="sMechanicalActivityDescription"></param>
        /// <param name="sMechanicalActivityModyBy"></param>
        /// <param name="tMechanicalActivityDateModyBy"></param>
        /// <param name="sidplanning"></param>
        /// <returns oeupmeca></returns>
        public EMechanicalActivity Actualizar_Mecanica_Planning(string sMechanicalActivityDescription, string sMechanicalActivityModyBy, DateTime tMechanicalActivityDateModyBy, string sidplanning)
        {
            DataTable dtupmeca = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATE_MECANICAPLANNING", sMechanicalActivityDescription, sMechanicalActivityModyBy, tMechanicalActivityDateModyBy, sidplanning);
            EMechanicalActivity oeupmeca = new EMechanicalActivity();
            oeupmeca.MechanicalActivityDescription = sMechanicalActivityDescription;
            oeupmeca.MechanicalActivityModyBy = sMechanicalActivityModyBy;
            oeupmeca.MechanicalActivityDateModyBy = tMechanicalActivityDateModyBy;
            oeupmeca.idPlanning = sidplanning;
            return oeupmeca;
        }

        /// <summary>
        /// Metodo para actualizar mandatorios de la campaña 
        /// Modificación : 29/07/2010 se cambia tipo de dato de id_planning de int a string 
        ///                y se coloca comentario de clase
        ///                Ing. Mauricio Ortiz              
        /// </summary>
        /// <param name="sMandtoryDescription"></param>
        /// <param name="sMandtoryModiBy"></param>
        /// <param name="tMandtoryDateModiBy"></param>
        /// <param name="sidplanning"></param>
        /// <returns oeupmanda></returns>
        public EMandatoryPlanning Actualizar_Mandatorios_Planning(string sMandtoryDescription, string sMandtoryModiBy, DateTime tMandtoryDateModiBy, string sidplanning)
        {
            DataTable dtupmanda = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATE_MANDATORYPLANNING", sMandtoryDescription, sMandtoryModiBy, tMandtoryDateModiBy, sidplanning);
            EMandatoryPlanning oeupmanda = new EMandatoryPlanning();
            oeupmanda.MandtoryDescription = sMandtoryDescription;
            oeupmanda.MandtoryModiBy = sMandtoryModiBy;
            oeupmanda.MandtoryDateModiBy = tMandtoryDateModiBy;
            oeupmanda.id_planning = sidplanning;
            return oeupmanda;
        }

        public ESales_Plan Actualizar_PlanVentas(
            int iSalesPlanid, int icod_strategy, int icmpanyid, 
            int iidCityPri, decimal fValuePlanCityPri, 
            string scodcountry, decimal fValuePlanCountry, 
            string sSalesPlanUnit, string sSalesPlanModiBy, 
            DateTime tSalesPlanDateModiBy)
        {
            DataTable dtupplan = oConn.ejecutarDataTable("UP_WEBSIGE_PLANNING_UPDATESALESPLAN", iSalesPlanid, icod_strategy, icmpanyid, iidCityPri, fValuePlanCityPri, scodcountry, fValuePlanCountry, sSalesPlanUnit, sSalesPlanModiBy, tSalesPlanDateModiBy);

            ESales_Plan oeupsalesplan = new ESales_Plan();
            oeupsalesplan.SalesPlanid = iSalesPlanid;
            oeupsalesplan.codstrategy = icod_strategy;
            oeupsalesplan.companyid = icmpanyid;
            oeupsalesplan.idCityPri = iidCityPri;
            oeupsalesplan.ValuePlanCityPri = fValuePlanCityPri;
            oeupsalesplan.codcountry = scodcountry;
            oeupsalesplan.ValuePlanCountry = fValuePlanCountry;
            oeupsalesplan.SalesPlanUnit = sSalesPlanUnit;
            oeupsalesplan.SalesPlanModiBy = sSalesPlanModiBy;
            oeupsalesplan.SalesPlanDateModiBy = tSalesPlanDateModiBy;
            return oeupsalesplan;
        }


        /// <summary>
        /// Método para actualizar en reportsplanning
        /// Ing. Mauricio Ortiz
        /// 17/03/2011
        /// </summary>
        /// <param name="iid_ReportsPlanning"></param>
        /// <param name="tReportsPlanning_RecogerDesde"></param>
        /// <param name="tReportsPlanning_RecogerHasta"></param>
        /// <param name="sReportsPlanning_ModiBy"></param>
        /// <param name="tReportsPlanning_DateModiBy"></param>
        /// <returns></returns>
        public DataTable Actualizar_ReportsPlanning(int iid_ReportsPlanning, DateTime tReportsPlanning_RecogerDesde,
             DateTime tReportsPlanning_RecogerHasta, string sReportsPlanning_ModiBy, DateTime tReportsPlanning_DateModiBy)
        {
            DataTable dtReportsPlanning = null;
            dtReportsPlanning = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ACTUALIZARREPORTESPLANNING",
                 iid_ReportsPlanning, tReportsPlanning_RecogerDesde,
              tReportsPlanning_RecogerHasta, sReportsPlanning_ModiBy, tReportsPlanning_DateModiBy);
            return dtReportsPlanning;
        }


        #endregion

        #region Methods: DELETE


        /// <summary>
        /// Método para eliminar los registro de la tabla PLA_Panel_Planning de un planning para un reporte seleccinado
        /// Ing. Mauricio Ortiz
        /// 04/03/2011
        /// </summary>
        /// <param name="lid_PanelPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_Pla_paneles(long lid_PanelPlanning)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINAR_PANELES_PLANNING", lid_PanelPlanning);
            return dt;
        }


        public DataTable Delete_Asignaciones_Operativos_Supervi(string sidplanning, int iPersonidOpera)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_DELETE_ASIGNACION_OPERATIVO_A_SUPERVISOR", sidplanning, iPersonidOpera);
            return dt;
        }

        public DataTable DeletePDV_Planning(int iid_MPOSPlanning)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_DELETE_PDVPLANNING", iid_MPOSPlanning);
            return dt;
        }


        /// <summary>
        /// Metodo para eliminar reportes planning
        /// Ing. Mauricio Ortiz
        /// 09/11/2010 
        /// </summary>
        /// <param name="iid_ReportsPlanning"></param>
        /// <returns>dtReportsPlanning</returns>
        public DataTable Eliminar_ReportsPlanning(int iid_ReportsPlanning)
        {
            DataTable dtReportsPlanning = null;
            dtReportsPlanning = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINARREPORTESPLANNING", iid_ReportsPlanning);
            return dtReportsPlanning;
        }


        /// <summary>
        /// Método para eliminar los productos del planning
        /// Ing. Mauricio Ortiz
        /// 08/11/2010 
        /// </summary>
        /// <param name="lid_ProductsPlanning"></param>
        /// <returns>dtEliminaProductPlanning</returns>
        public DataTable Eliminar_ProductPlanning(long lid_ProductsPlanning)
        {

            Conexion cn = new Conexion();
            DataTable dtEliminaProductPlanning = cn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINARPRODUCTOSPLANNING", lid_ProductsPlanning);
            return dtEliminaProductPlanning;
        }


        /// <summary>
        /// Método para eliminar las marcas del planning
        /// Ing. Mauricio Ortiz
        /// 02/03/2011
        /// </summary>
        /// <param name="lid_BrandPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_MarcasPlanning(long lid_BrandPlanning)
        {
            DataTable dtEliminaMarcasPlanning = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINARMARCASPLANNING", lid_BrandPlanning);
            return dtEliminaMarcasPlanning;
        }


        /// <summary>
        /// Método para eliminar las familias del planning
        /// Ing. Mauricio Ortiz
        /// 23/03/2011
        /// </summary>
        /// <param name="lid_FamilyPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_FamiliasPlanning(long lid_FamilyPlanning)
        {
            DataTable dtEliminaFamiliasPlanning = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINARFAMILIASPLANNING", lid_FamilyPlanning);
            return dtEliminaFamiliasPlanning;
        }

        /// <summary>
        /// Método para eliminar las categorias del planning
        /// Ing. Mauricio Ortiz
        /// 06/05/2011
        /// </summary>
        /// <param name="lid_CategoryPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_CategoriasPlanning(long lid_CategoryPlanning)
        {
            DataTable dtEliminaCategoriasPlanning = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINARCATEGORIASPLANNING", lid_CategoryPlanning);
            return dtEliminaCategoriasPlanning;
        }

        /// <summary>
        /// Método para eliminar productos de la tabla TBL_PRODUCTO_CADENA
        /// Ing. Mauricio Ortiz
        /// 02/03/2011
        /// </summary>
        /// <param name="lid_ProductsPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_ProductTBL_PRODUCTO_CADENA(long lid_ProductsPlanning)
        {
            oConn = new Conexion(2);
            DataTable dtEliminaProductTBL_PRODUCTO_CADENA = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINAR_TBL_PRODUCTO_CADENA", lid_ProductsPlanning);
            return dtEliminaProductTBL_PRODUCTO_CADENA;
        }


        /// <summary>
        /// Método para eliminar registros de la tabla TBL_EQUIPO_PRODUCTOS
        /// Ing. Mauricio Ortiz
        /// 11/04/2011
        /// </summary>
        /// <param name="lid_ProductsPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_ProductTBL_EQUIPO_PRODUCTOS(string codProduct, string Nombre_Reporte, int Company_id, string planning)
        {
            oConn = new Conexion(2);
            DataTable dtEliminaProductTBL_EQUIPO_PRODUCTOS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINAR_TBL_EQUIPO_PRODUCTOS", codProduct, Nombre_Reporte, Company_id, planning);
            return dtEliminaProductTBL_EQUIPO_PRODUCTOS;
        }

        /// <summary>
        /// Método para eliminar Marcas de la tabla TBL_EQUIPO_MARCAS
        /// Ing. Mauricio Ortiz
        /// 23/03/2011
        /// </summary>
        /// <param name="lid_BrandPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_MarcasTBL_EQUIPO_MARCAS(string sid_BrandPlanning)
        {
            oConn = new Conexion(2);
            DataTable dtEliminaMarcasTBL_EQUIPO_MARCAS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINAR_TBL_EQUIPO_MARCAS", sid_BrandPlanning);
            return dtEliminaMarcasTBL_EQUIPO_MARCAS;
        }

        /// <summary>
        /// Método para eliminar familias de la bd intermedia
        /// Ing- Mauricio Ortiz
        /// 24/03/2011
        /// </summary>
        /// <param name="sid_FamilyPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_FamiliasTBL_EQUIPO_FAMILIAS(string sid_FamilyPlanning)
        {
            oConn = new Conexion(2);
            DataTable dtEliminaFamiliasTBL_EQUIPO_FAMILIAS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINAR_TBL_EQUIPO_FAMILIAS", sid_FamilyPlanning);
            return dtEliminaFamiliasTBL_EQUIPO_FAMILIAS;
        }

        /// <summary>
        /// Método para eliminar Categorias de la bd intermedia
        /// Ing. Mauricio Ortiz
        /// 06/05/2011
        /// </summary>
        /// <param name="sid_CategoryPlanning"></param>
        /// <returns></returns>
        public DataTable Eliminar_CategoriasTBL_EQUIPO_CATEGORIAS(string sid_CategoryPlanning)
        {
            oConn = new Conexion(2);
            DataTable dtEliminaTBL_EQUIPO_CATEGORIAS = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_ELIMINAR_TBL_EQUIPO_CATEGORIAS", sid_CategoryPlanning);
            return dtEliminaTBL_EQUIPO_CATEGORIAS;
        }

        #endregion

        #region Methods: LIST / GET

        public DataTable lista_campanias_cliente(int company_id)
        {
            DataTable dt = new DataTable();
            dt = oConn.ejecutarDataTable("UP_XPLORAMAPS_OBTENER_LISTA_CAMPANIAS", company_id);
            return dt;
        }

        /// <summary>
        /// Obtener información del Presupuesto,
        /// Interface con EasyWin, devuelve información 
        /// para llenar Combos correspondientes al Planning.
        /// Case 1: (Obtiene Clientes asociados a un Planning.)
        /// - Company_id    .- Identificador de Compañia.
        /// - Company_Name  .- Nombre de la Compañia.
        /// Case 5: (Obtiene Clientes Historicos asociados a un Planning.)
        /// - Person_id         .- Identificador de Usuario.
        /// - Nombres           .- Nombre del Usuario
        /// - person_status     .- Estado del usuario.
        /// - Perfil_id         .- Identificador del Perfil del Usuario.
        /// - name_user         .- Nombre que se utiliza en el sistema.
        /// - User_Password     .- Password para acceder al sistema.
        /// - Person_Email      .- Email del Usuario.
        /// Case 2: (Obtener Supervisores)
        /// - Person_id         .- Identificador de Usuario Supervisor.
        /// - Nombres           .- Nombre del Usuario Supervisor.
        /// - Perfil_id         .- Identificador del Perfil del Usuario (Supervisor).
        /// - name_user         .- Nombre utilizado en el Sistema (Supervisor)
        /// - User_Password     .- Password para acceder al Sistema.
        /// - Person_Email      .- Email del Usuario (Supervisor).
        /// Case 6: (Obtener Supervisores Históricos)
        /// - Person_id         .- Identificador de Usuario Supervisor Histórico.
        /// - Nombres           .- Nombre del Usuario Supervisor Histórico.
        /// - Perfil_id         .- Identificador del Perfil del Usuario (Supervisor Histórico).
        /// - name_user         .- Nombre utilizado en el Sistema (Supervisor Histórico)
        /// - User_Password     .- Password para acceder al Sistema.
        /// - Person_Email      .- Email del Usuario (Supervisor Histórico).
        /// Case 3: (Obtener Personal Operativo)
        /// - Person_id         .- Identificador de Usuario Operativo.
        /// - Nombres           .- Nombre del Usuario Operativo.
        /// - Perfil_id         .- Identificador del Perfil del Usuario (Operativo).
        /// - perfil_name       .- Nombre utilizado en el Sistema (Operativo)
        /// Case 4: (Obtener Supervisores en Consulta)
        /// - person_id         .- Identificador de Usuario Supervisor.
        /// - Nombres           .- Nombre del Usuario Supervisor.
        /// - person_status     .- Estado del Usuario Supervisor.
        /// - Perfil_id         .- Identificador del Perfil en el Sistema (Supervisor).
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public DataTable cmbInterfaceEasyWin(String idBudget,
        int option)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEB_INTERFACE_EASYWIN_SIGE_LLENARCOMBOS",
                    idBudget,
                    option);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return dt;
        }

        /// <summary>
        /// Obtener el Listado de Controllers,
        /// Supervisores y Mercaderistas
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <returns></returns>
        public DataSet getStaffPlanning(String idPlanning)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = oConn.ejecutarDataSet(
                    "UP_WEBXPLORA_PLA_OBTENERSTAFFPLANNING",
                    idPlanning);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return ds;
        }

        /// <summary>
        /// Verificar si una persona ya tiene asignado un Supervisor.
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="idPerson"></param>
        /// <returns></returns>
        public DataTable getCheckOperationAssigment(
        String idPlanning, int idPerson)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEBXPLORA_PLA_VERIFICAR_ASIGNACION_OPERATIVO_A_SUPERVISOR",
                    idPlanning,
                    idPerson);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="idCity"></param>
        /// <param name="idNodeCommercial"></param>
        /// <param name="idOficina"></param>
        /// <param name="idMalla"></param>
        /// <returns></returns>
        public DataSet getInfoPtoVenta(String idPlanning,
        string idCity, int idNodeCommercialType,
        string idNodeCommercial, int idOficina,
        int idMalla)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = oConn.ejecutarDataSet(
                    "UP_WEBXPLORA_PLA_LLENAFILTROSASIGNACIONPDV",
                    idPlanning,
                    idCity,
                    idNodeCommercialType,
                    idNodeCommercial,
                    idOficina,
                    idMalla);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return ds;
        }

        /// <summary>
        /// Obtener información del Planning By IdPlanning
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <returns></returns>
        public DataTable getByIdPlanning(String idBudget)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEBSIGE_SEARCH_PLANNINGXPRESUPUESTO",
                    idBudget);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return dt;
        }

        /// <summary>
        /// Método para consultar los registro de la tabla PLA_Panel_Planning de un planning para un reporte seleccinado
        /// Ing. Mauricio Ortiz
        /// 04/03/2011
        /// </summary>
        /// <param name="iid_planning"></param>
        /// <param name="iReport_Id"></param>
        /// <returns></returns>
        public DataTable Consulta_Pla_paneles(
            string iid_planning, int iReport_Id, 
            int ireportplanning)
        {
            DataTable dt = 
                oConn.ejecutarDataTable(
                "UP_WEBXPLORA_PLA_CONSULTAR_PANELES_PLANNING", 
                iid_planning, iReport_Id, ireportplanning);
            return dt;
        }

        /// <summary>
        /// Descripción : Método para consultar los puntos de venta asignados a un planning
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 04/09/2010
        /// Modificación: 12/11/2010 se adiciona nuevos parametros scod_City ,iidNodeComType ,
        ///					sNodeCommercial, lcod_Oficina  Ing. Mauricio Ortiz
        /// </summary>       
        /// <param name="sid_planning"></param>
        /// <param name="scod_City"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="imalla"></param>
        /// <param name="isector"></param>
        /// <returns>dt</returns>
        public DataTable Consultar_PDVPlanning(
            string sid_planning,
            string scod_City,
            int iidNodeComType,
            string sNodeCommercial,
            long lcod_Oficina,
            int imalla,
            int isector)
        {

            DataTable dt = new DataTable();

            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEBXPLORA_PLA_CONSULTARPDVPLANNING",
                    sid_planning,
                    scod_City,
                    iidNodeComType,
                    sNodeCommercial,
                    lcod_Oficina,
                    imalla,
                    isector);
            }
            catch (Exception ex)
            {
                message = "Ocurrio un Error: " + ex.ToString();
            }

            return dt;
        }

        /// <summary>
        /// Descripción : Método para consultar los puntos de venta asignados a un planning general
        ///               se crea este método debido a que por Web Services generaba problemas ya que los puntos de venta
        ///               presentaban en sus datos caracteres especiales 
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 21/10/2010        
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <returns></returns>
        public DataTable Consultar_PDVPlanningGeneral(
            string sid_planning, int imalla, int isector)
        {
            DataTable dtpdvpla = null;
            dtpdvpla = oConn.ejecutarDataTable(
                "UP_WEBSIGE_PLANNING_OBTENERPDVPLA",
                sid_planning,
                imalla,
                isector);
            return dtpdvpla;
        }

        /// <summary>
        /// Get List of PointOfSale by IdPlanning
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <param name="idCity"></param>
        /// <param name="idTypeNodeCommercial"></param>
        /// <param name="idNodeCommercial"></param>
        /// <param name="idOficina"></param>
        /// <param name="idMalla"></param>
        /// <param name="idSector"></param>
        /// <returns></returns>
        public DataTable getListPdvPlanning(String idPlanning,
        String idCity, int idTypeNodeCommercial,
        String idNodeCommercial, int idOficina,
        int idMalla, int idSector)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEBSIGE_PLANNING_OBTENERPDVPLA",
                    idPlanning,
                    idCity,
                    idTypeNodeCommercial,
                    idNodeCommercial,
                    idOficina,
                    idMalla,
                    idSector);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return dt;

        }

        /// <summary>
        /// Metodo para consultar reportes planning
        /// Ing. Mauricio Ortiz
        /// 09/11/2010 
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <returns>dtReportesPla</returns>
        public DataTable Consulta_ReportPlanning(
            string sid_planning)
        {
            DataTable dtReportesPla = null;
            dtReportesPla = oConn.ejecutarDataTable(
                "UP_WEBXPLORA_PLA_CONSULTAREPORTESPLANNING", 
                sid_planning);
            return dtReportesPla;
        }


        /// <summary>
        /// Método para consultar los productos del planning
        /// Ing. Mauricio Ortiz
        /// 28/10/2010 
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="iid_company"></param>
        /// <returns>dsProductPlanning</returns>
        public DataSet Consultar_ProductPlanning(
            string sid_planning, int iid_company)
        {
            DataSet dsProductPlanning = null;
            dsProductPlanning = oConn.ejecutarDataSet(
                "UP_WEBXPLORA_PLA_OBTENERPRODUCTOSPLANNING", 
                sid_planning, iid_company);
            return dsProductPlanning;
        }


        /// <summary>
        /// Retornar la información del Presupuesto by idCompany
        /// - Numero_Presupuesto    .- Correspondiente al [number_ budget].
        /// - Nombre                .- Concatenado del [number_ budget] + name_budget.
        /// - name                  .- Corresponde al name_budget (Nombre del Bucket).
        /// - id_planning           .- Corresponde al Identificador del Planning.
        /// </summary>
        /// <param name="idCompany"></param>
        /// <returns></returns>
        public DataTable presupuestoSearch(int idCompany)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEBXPLORA_PLA_SEARCHPRESUPUESTOSASIGNADOS",
                    idCompany);
            }
            catch (Exception ex)
            {
                message = "Ocurrio un Error: " + ex.Message.ToString();
            }

            // Validar si no existen errores
            if (getMessages().Equals(""))
            {
                // Alertar que no se encontraron registros
                if (dt.Rows.Count <= 0)
                {
                    message = "Error: No se encontraron registros";
                }
            }

            return dt;
        }

        /// <summary>
        /// Obtener toda la información relacionada al Planning
        /// para poder realizar seguimiento.
        /// </summary>
        /// <param name="idPlanning"></param>
        /// <returns>DataSet</returns>
        /// DataTable[0] - Obtiene información para llenar combo de Planning
        /// - id_objplanning    .- Identificador del Objetivo del Planning,
        /// - id_planning       .- Identificador del Planning.
        /// DataTable[1] - Obtiene información de los objetivos para la Campaña
        /// - id_planning       .- Identificador del Planning.
        /// - planning_name     .- Nombre del Planning,
        /// - objpladescription .- Breve Descripción del Objetivo del Planning,
        /// - objplacreateby    .- Persona que creó los Objetivos del Planning,
        /// - objpladateby      .- Fecha de creación de los Objetivos del Planning,
        /// - objplamodiby      .- Ultima Persona que actualizó la información de los Objetivos del Planning,
        /// - objpladatemodiby  .- Ultima fecha de actualización de los Objetivos del Planning.)
        /// DataTable[2] - Obtiene información de los Productos con SKU Mandatorio Planning.
        /// - id_mandtoryplanning   .- Identificador del Id SKU Mandatorio Planning.
        /// - id_planning           .- Identificador del Planning.
        /// - mandtorydescription   .- Descripción del SKU Mandatorio Planning.
        /// - mandtorycreateby      .- Persona que creó el SKU Mandatorio Planning.
        /// - mandtorydateby        .- Fecha de Creación del SKU Mandatorio Planning.
        /// - mandtorymodiby        .- Última persona que actualizó el SKU Mandatorio Planning.
        /// - mandtorydatemodiby    .- Última fecha de actualización del SKU Mandatorio Planning.
        /// DataTable[3] - Obtiene información de la Mecánica de las Actividades
        /// - mechanicalactivity_id         .- Identificador de la Mecánica de la Actividad Planning.
        /// - id_planning                   .- Identificador del Planning.
        /// - mechanicalactivity_description.- Descripción de la Mecánica de la Actividad Planning.
        /// - mechanicalactivity_createby   .- Persona que creó la Mecánica de la Actividad Planning.
        /// - mechanicalactivity_dateby     .- Fecha de creación de la Mecánica de la Actividad Planning.
        /// - mechanicalactivity_modyby     .- Última persona que actualizó la Mecánica de la Actividad Planning.
        /// - mechanicalactivity_datemodyby .- Última fecha de actualización de la Mecánica de la Actividad Planning.
        /// DataTable[4] - Obtiene información del Personal Asignado al Planning.
        /// - id_staffplanning          .- Identificador del Staff Planning.
        /// - id_planning               .- Identificador del Planning.
        /// - person_id                 .- Identificador del Trabajador Asignado a X Punto de Venta.
        /// - staffplanning_status      .- Estado en que se encuentra la Asignación de X Punto de Venta al Trabajador.
        /// - staffplanning_createby    .- Persona que definió el Staff Planning.
        /// - staffplanning_dateby      .- Fecha que el usuario crea la asignación del trabajador al Planning.
        /// - staffplanning_modiby      .- Usuario que actualizó la asignación del trabajador al Planning.
        /// - staffplanning_datemodiby  .- Fecha que el usuario actualizó  la asignación del trabajador al Planning.
        /// DataTable[5] - Obtiene información de la asginación de Mercaderista y Supervisores
        /// - id_asigper                .- Identificador de la Asignación Supervisor - Mercaderista al Planning.
        /// - id_planning               .- Identificador de Planning.
        /// - person_idsupe             .- Usuario Supervisor asignado a la Asignación Supervisor - Mercaderista al Planning.
        /// - person_idopera            .- Usuario Mercaderista asignado a la Asignación Supervisor - Mercaderista al Planning.
        /// - asigmenper_status         .- Estado de la asignación Supervisor - Mercaderista al Planning
        /// - asigmenper_createby       .- Usuario que creo la relación Asignación Supervisor - Mercaderista al Planning.
        /// - asigmenper_dateby         .- Fecha de creación de la relación Asignación Supervisor - Mercaderista al Planning.
        /// - asigmenper_modiby         .- Usuario que actualizó la relación Asignación Supervisor - Mercaderista al Planning.
        /// - asigmenper_datemodiby     .- Fecha de actualización de la relación Asignación Supervisor - Mercaderista al Planning.
        /// DataTable[6] - Obtiene información de los PDVs de la Campania
        /// - id_mposplanning           .- Identificador del Punto de Venta asignado al Planning.
        /// DataTable[7] - Obtiene información de los Productos Asignados por Campania 
        /// - id_productsplanning           .- Identificador de la asignación de Productos al Planning
        /// - id_planning                   .- Identificador de Planning.
        /// - id_product                    .- Identificador de Producto asignado al Planning.
        /// - id_productcategory            .- Identificador de la Categoria del Producto asignado al Planning.
        /// - id_brand                      .- Identificador de la Marca del Producto asignado al Planning.
        /// - id_subbrand                   .- Identificador de la SubMarca del Producto asignado al Planning.
        /// - id_productfamily              .- Identificador de la Familia del Producto asignado al Planning.
        /// - id_productsubfamily           .- Identificador de la SubFamilia del Producto asignada al Planning.
        /// - product_caracte               .- Caracteristicas del Producto asignado al Planning.
        /// - product_benefi                .- Beneficios del Producto asignado al Planning.
        /// - productsplanning_initialstock .- Stock Inicial del Producto asignado al Planning.
        /// - report_id                     .- Identificador del Reporte Asignado al Producto y Planning.
        /// - status                        .- Estado de la Asignación del Producto al Planning.
        /// - productplan_createby          .- Usuario que creó la Asignación del Producto al Planning.
        /// - productplan_dateby            .- Fecha de creación de la Asignación del Producto al Planning.
        /// - productplan_modiby            .- Usuario que modificó la Asignación del Producto al Planning.
        /// - productplan_datemodiby        .- Fecha de actualización de la Asignación del Producto al Planning.
        /// DataTable[8] - Obtiene información de los Puntos de Venta Asignados a los Mercaderistas.
        /// - id_posplanningope             .- Identificador de la Asignación de la Ruta al Planning.
        /// - id_mposplanning               .- Identificador del Punto de Venta Planificado asignado a la Ruta y Planning.
        /// - id_planning                   .- Identificador del Planning.
        /// - person_id                     .- Identificador del Usuario Asignado a la Ruta y Planning.
        /// - posplanningope_fechainicio    .- Fecha Inicio de la Asignación de la Ruta al Planning.
        /// - posplanningope_fechafin       .- Fecha Fin de la Asignación de la Ruta al Planning.
        /// - id_frecuencia                 .- Identificador de la frecuencia de visita de la Asignación de la Ruta al Planning.
        /// - posplanningope_status         .- Status de la Asignación de la Ruta al Planning.
        /// - posplanningope_createby       .- Usuario que creó la Asignación de la Ruta al Planning.
        /// - posplanningope_dateby         .- Fecha de creación de la Asignación de la Ruta al Planning.
        /// - posplanningope_modiby         .- Usuario que modifió la Asignación de la Ruta al Planning.
        /// - posplanningope_datemodiby     .- Fecha de actualización de la Asignación de la Ruta al Planning.
        /// DataTable[9] - Obtiene información del Planning Seleccionado
        /// - id_planning                           .- Identificador del Planning.
        /// - planning_name                         .- Nombre del Planning.
        /// - cod_strategy                          .- Identificador de la Estrategia asignada al Planning.
        /// - planning_codchannel                   .- Identificador del Canal asignado al Planning.
        /// - planning_startactivity                .- Fecha de inicio de actividades del Planning
        /// - planning_endactivity                  .- Fecha de fin de actividades del Planning.
        /// - planning_reportaditional              .- Descripción de los reportes que se espera del Planning.
        /// - planning_developmentactivityreport    .- Descripción del desarrollo de las actividades del Planning
        /// - planning_person_eje                   .- Usuario responsable del Planning.
        /// - planning_activityformats              .- Descripción de los formatos de actividades del Planning.
        /// - planning_areainvolved                 .- Descripción de las áreas involucradas del Planning.
        /// - planning_daterepsoli                  .- Fecha de Inicio para alimentar la información de los reportes asignado al Planning.
        /// - planning_preprodudateini              .- Fecha de inicio de Salida piloto asignada al Planning.
        /// - planning_preprodudateend              .- Fecha de Fin de Salida piloto asignada al Planning.
        /// - planning_projectduration              .- Descripción de la duración de la Salida piloto asignada al Planning.
        /// - planning_datefinreport                .- Fecha de Fin para alimentar la información de los reportes asignados al Planning.
        /// - planning_vigen                        .- Vigencia del Planning.
        /// - planning_budget                       .- Identificado del Budget asignado al Planning.
        /// - id_designfor                          .- Código del usuario responsable del Planning.
        /// - name_contact                          .- Persona de Contacto del Planning.
        /// - email_contac                          .- Email de Contacto del Planning.
        /// - planning_status                       .- Estado del Planning.
        /// - status_id                             .- Identificador del Estado del Planning.
        /// - planning_formacompe                   .- Descripción de los formatos asignados al Planning.
        /// - planning_createby                     .- Usuario que creo el Planning.
        /// - planning_dateby                       .- Fecha de creación del Planning.
        /// - planning_modiby                       .- Usuario que modificó la información del Planning.
        /// - planning_datemodiby                   .- Fecha de actualización del Planning.
        /// - strategy_name                         .- Descripción de la Estrategia asociado al Planning.
        /// DataTable[10]- Obtiene información de los Reportes asignados a la Campania
        /// - id_reportsplanning                    .- 
        /// - id_planning                           .- 
        /// - report_id                             .- 
        /// - id_year                               .- 
        /// - id_month                              .- 
        /// - reportsplanning_periodo               .- 
        /// - reportsplanning_recogerdesde          .- 
        /// - reportsplanning_recogerhasta          .- 
        /// - reportsplanning_validacionanalista    .- 
        /// - reportsplanning_status                .- 
        /// - reportsplanning_createby              .- 
        /// - reportsplanning_dateby                .- 
        /// - reportsplanning_modiby                .- 
        /// - reportsplanning_datemodiby            .- 
        /// DataTable[11]- Obtiene información de los Paneles Asignados a la Campania
        /// - id_panelplanning
        /// - id_planning
        /// - id_mposplanning
        /// - clientpdv_code
        /// - report_id
        /// - status_panelplanning
        /// - panelplanning_createby
        /// - panelplanning_dateby
        /// - panelplanning_modiby
        /// - panelplanning_datemodiby
        /// DataTable[12]- Obtiene información de las Marcas Asignadas a la Campania
        /// - id_brandplanning
        /// - id_planning
        /// - id_productcategory
        /// - id_brand
        /// - report_id
        /// - status
        /// - brandplan_createby
        /// - brandplan_dateby
        /// - brandplan_modiby
        /// - brandplan_datemodiby
        /// DataTable[13]- Obtiene información de las Familias Asignadas a la Campania
        /// - id_familyplanning
        /// - id_planning
        /// - id_productcategory
        /// - id_brand
        /// - id_productfamily
        /// - report_id
        /// - status
        /// - familyplan_createby
        /// - familyplan_dateby
        /// - familyplan_modiby
        /// - familyplan_datemodiby
        /// DataTable[14]- Obtiene información de las Categorias Asignadas a la Campania
        /// - id_categoryplanning
        /// - id_planning
        /// - id_productcategory
        /// - report_id
        /// - status
        /// - categoryplan_createby
        /// - categoryplan_dateby
        /// - categoryplan_modiby
        /// - categoryplan_datemodiby
        public DataSet getInfoPlanning(String idPlanning)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = oConn.ejecutarDataSet(
                    "UP_WEBSIGE_PLANNIG_CREADOS",
                    idPlanning);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return ds;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable getDuplicateRutas(String idPointOfSalePlanningOper,
        String idPerson, String idPlanning)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEBXPLORA_PLA_DUPLICADOASIGNARPDVAOPERATIVO",
                    idPointOfSalePlanningOper,
                    idPerson,
                    idPlanning);
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return dt;
        }

        #region Methods: VALIDATIONS / ENABLED / DISABLED

        /// <summary>
        /// Metodo para Activar acceso de Supervisor a SIGE
        /// </summary>
        public EPresupuesto Activar_Acces_Supervisor(int ipersonid, string snumberpresupuesto, string iperfilid)
        {
            EPresupuesto oepresupuesto = new EPresupuesto();
            EUsuario oeusuarios = new EUsuario();

            DataSet ds = oConn.ejecutarDataSet("UP_WEBSIGEPLA_ACTIVARINGSIGESUPE", ipersonid, snumberpresupuesto, iperfilid);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    oeusuarios.Personid = ipersonid;
                    oepresupuesto.Perfilid = iperfilid;
                    oepresupuesto.Namebudget = snumberpresupuesto;
                }
            }
            return oepresupuesto;
        }


        /// <summary>
        /// Metodo para Indicar como se ha de gestionar la información dependiendo el reporte, cliente y canal seleccionado 
        /// Ing. Mauricio Ortiz
        /// 25/02/2011
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="scod_Channel"></param>
        /// <param name="iReport_id"></param>
        /// <returns></returns>
        public DataTable ValidaTipoGestion(int iCompany_id, string scod_Channel, int iReport_id)
        {
            DataTable dtValidacion = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_GESTIONINFORMACIONXPRODUCTOSXREPORTE", iCompany_id, scod_Channel, iReport_id);
            return dtValidacion;
        }

        /// <summary>
        /// Método para permitir continuar con el registro de productos , categorias , marcas y familias
        /// 07/05/2011
        /// Ing. Mauricio Ortiz       
        /// </summary>
        /// <param name="sTIPO_LEVANTAMIENTO"></param>
        /// <param name="lid_Product"></param>
        /// <param name="sid_ProductCategory"></param>
        /// <param name="iid_Brand"></param>
        /// <param name="sid_ProductFamily"></param>
        /// <returns></returns>
        public DataTable Permitir_GuardarLevantamiento(string sTIPO_LEVANTAMIENTO, long lid_Product,
            string sid_ProductCategory, int iid_Brand, string sid_ProductFamily)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_PERMITIR_REGISTRAR_Levantamiento_inf", sTIPO_LEVANTAMIENTO, lid_Product,
             sid_ProductCategory, iid_Brand, sid_ProductFamily);
            return dt;
        }

        #endregion

    }
}