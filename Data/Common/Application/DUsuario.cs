using System;
using System.Data;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Security;
using Lucky.Entity.Common.Application.Security;


namespace Lucky.Data.Common.Application
{

    /// <summary>
    /// Descripción breve de DUsuario.
    /// CreateBy: Ing. Carlos Alberto Hernandez RIncón
    /// CreateDate:27/04/2009
    /// Requerimiento:SIGE-ARF-024
    /// </summary>
    public class DUsuario
    {
        // Variable para almacenar los mensajes de Error.
        String messages = "";
        private Conexion oConn;
        /// <summary>
        /// Define en el constructor la inicialización de la interfaz de la Clase y el objeto de conexión a usar en la
        /// transacionalidad de la Clase
        /// </summary>
        public DUsuario()
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }
        /// <summary>
        /// Metodo para Consular Ingreso de usuarios
        /// Modificacion: Se agrega nivel de Usuario 24/08/2009 Ing. Carlos Hernández
        /// </summary>
        /// Entradas
        /// <param name="sUser"></param>
        /// <param name="sPassw"></param>
        /// Salidas
        /// <returns>retorna un objeto tipo EUsuario</returns>
        /// Modificación: se agrega al retornoo del la consulta  oeUsuario.fotocompany 
        /// Modificado por: Ing. Carlos Hernandez 01/09/2010
        public EUsuario obtenerPK(string  sUser, string  sPassw)
        {
            EUsuario oeUsuario = new EUsuario();
            try
            {
                oConn = new Conexion(1);
                DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACEDER_USER",
                    sUser, sPassw);
                
                if (dt.Rows.Count > 0){
                    oeUsuario.nameuser = sUser;
                    oeUsuario.UserPassword = sPassw;
                    oeUsuario.Personid = Convert.ToInt32(dt.Rows[0]["Person_id"].ToString().Trim());
                    oeUsuario.idtypeDocument = dt.Rows[0]["id_typeDocument"].ToString().Trim();
                    oeUsuario.Personnd = dt.Rows[0]["Person_nd"].ToString().Trim();
                    oeUsuario.PersonFirtsname = dt.Rows[0]["Person_Firtsname"].ToString().Trim();
                    oeUsuario.PersonLastName = dt.Rows[0]["Person_LastName"].ToString().Trim();
                    oeUsuario.PersonSurname = dt.Rows[0]["Person_Surname"].ToString().Trim();
                    oeUsuario.PersonSeconName = dt.Rows[0]["Person_SeconName"].ToString().Trim();
                    oeUsuario.PersonEmail = dt.Rows[0]["Person_Email"].ToString().Trim();
                    oeUsuario.PersonPhone = dt.Rows[0]["Person_Phone"].ToString().Trim();
                    oeUsuario.PersonAddres = dt.Rows[0]["Person_Addres"].ToString().Trim();
                    oeUsuario.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                    oeUsuario.Perfilid = dt.Rows[0]["Perfil_id"].ToString().Trim();
                    oeUsuario.NamePerfil = dt.Rows[0]["Perfil_Name"].ToString().Trim();
                    oeUsuario.companyid = dt.Rows[0]["Company_id"].ToString().Trim();
                    oeUsuario.companyName = dt.Rows[0]["Company_Name"].ToString().Trim();
                    oeUsuario.fotocompany = dt.Rows[0]["url_Foto"].ToString().Trim();
                    oeUsuario.PersonStatus = Convert.ToBoolean(dt.Rows[0]["Person_Status"].ToString().Trim());
                    oeUsuario.Moduloid = dt.Rows[0]["Modulo_id"].ToString().Trim();
                    oeUsuario.idlevel = dt.Rows[0]["Id_level"].ToString().Trim();
                    oeUsuario.leveldescription = dt.Rows[0]["namelevel"].ToString().Trim();
                    oeUsuario.coddepartam = dt.Rows[0]["cod_dpto"].ToString().Trim();
                    oeUsuario.codcity = dt.Rows[0]["cod_city"].ToString().Trim();
                }
                
            }
            catch (Exception ex) {
                messages = "Ocurrio un Error: " + ex.Message.ToString();
            }

            return oeUsuario;
        }
         
        /// <summary>
        /// consulta perfil.
        /// 14/02/2011 Magaly Jimenez
        /// </summary>
        /// <param name="sperfil"></param>
        /// <returns></returns>
        
        //public EProfiles obtenerPerfil(string  sperfil)
        //{
        //    DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTAPERFIL", sperfil);
        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            EProfiles oePerfil = new EProfiles();
        //           // EUsuario oePerfil = new EUsuario(); 
        //            return oePerfil;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        
        
        /// <summary>
        ///  Metodo para Registrar Usuarios en SIGE
        /// </summary>
        /// ----Parametros de Entrada
        /// <param name="sidtypeDocument"></param>
        /// <param name="sPersonnd"></param>
        /// <param name="sPersonFirtsname"></param>
        /// <param name="sPersonLastName"></param>
        /// <param name="sPersonSurname"></param>
        /// <param name="sPersonSeconName"></param>
        /// <param name="sPersonEmail"></param>
        /// <param name="sPersonPhone"></param>
        /// <param name="sPersonAddres"></param>
        /// <param name="scodCountry"></param>
        /// <param name="snameuser"></param>
        /// <param name="sUserPassword"></param>
        /// <param name="iPerfilid"></param>
        /// <param name="sModuloid"></param>
        /// <param name="suserrecall"></param>
        /// <param name="icompanyid"></param>
        /// <param name="bPersonStatus"></param>
        /// <param name="sPersonCreateBy"></param>
        /// <param name="tPersonDateBy"></param>
        /// <param name="sPersonModiBy"></param>
        /// <param name="tPersonDateModiBy"></param>
        /// ----Parametros de Salida----
        /// <returns>Retorna un Objeto tipo EUsuario</returns>

        public EUsuario RegistrarPK(string sidtypeDocument, string sPersonnd,string sPersonFirtsname,
            string sPersonLastName,string sPersonSurname, string sPersonSeconName, 
            string sPersonEmail, string sPersonPhone, string sPersonAddres,string scodCountry,
            string snameuser, string sUserPassword, string iPerfilid,string sModuloid, 
            string suserrecall, int icompanyid,  bool bPersonStatus, string sPersonCreateBy, 
            DateTime tPersonDateBy, string sPersonModiBy, DateTime tPersonDateModiBy)
        {
           oConn = new Conexion(1);
           DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_REGISTER", sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName, sPersonEmail, sPersonPhone, sPersonAddres, scodCountry,
                   snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonCreateBy, tPersonDateBy, sPersonModiBy, tPersonDateModiBy);
            EUsuario oerUsuario = new EUsuario();
           
            oerUsuario.idtypeDocument = sidtypeDocument;
            oerUsuario.Personnd = sPersonnd;
            oerUsuario.PersonFirtsname = sPersonFirtsname;
            oerUsuario.PersonLastName = sPersonLastName;
            oerUsuario.PersonSurname = sPersonSurname;
            oerUsuario.PersonSeconName = sPersonSeconName;
            oerUsuario.PersonEmail = sPersonEmail;
            oerUsuario.PersonPhone = sPersonPhone;
            oerUsuario.PersonAddres = sPersonAddres;
            oerUsuario.codCountry = scodCountry;
            oerUsuario.nameuser = snameuser;
            oerUsuario.UserPassword = sUserPassword;
            oerUsuario.Perfilid = iPerfilid;
            oerUsuario.Moduloid = sModuloid;
            oerUsuario.UserRecall = suserrecall;
            oerUsuario.companyid = Convert.ToString(icompanyid);
            oerUsuario.PersonStatus = bPersonStatus;
            oerUsuario.PersonCreateBy = sPersonCreateBy;
            oerUsuario.PersonDateBy = Convert.ToString(tPersonDateBy);
            oerUsuario.PersonModiBy = sPersonModiBy;
            oerUsuario.PersonDateModiBy = Convert.ToString(tPersonDateModiBy);

            return oerUsuario;
       
         }

        public EUsuario RegistrarUsuarioMovil(string sidtypeDocument, string sPersonnd, string sPersonFirtsname, 
         string sPersonLastName, string sPersonSurname, string sPersonSeconName,
         string sPersonEmail, string sPersonPhone, string sPersonAddres, string scodCountry,
         string snameuser, string sUserPassword, string iPerfilid, string sModuloid, string suserrecall, 
         int icompanyid, bool bPersonStatus, string sPersonCreateBy, DateTime tPersonDateBy, string sPersonModiBy, 
         DateTime tPersonDateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERUSER", sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName, sPersonEmail, sPersonPhone, sPersonAddres, scodCountry,
                   snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonCreateBy, tPersonDateBy, sPersonModiBy, tPersonDateModiBy);
            EUsuario oerUsuario = new EUsuario();
            oerUsuario.Personid = Convert.ToInt32(dt.Rows[0]["Person_id"]);
            oerUsuario.idtypeDocument = sidtypeDocument;
            oerUsuario.Personnd = sPersonnd;
            oerUsuario.PersonFirtsname = sPersonFirtsname;
            oerUsuario.PersonLastName = sPersonLastName;
            oerUsuario.PersonSurname = sPersonSurname;
            oerUsuario.PersonSeconName = sPersonSeconName;
            oerUsuario.PersonEmail = sPersonEmail;
            oerUsuario.PersonPhone = sPersonPhone;
            oerUsuario.PersonAddres = sPersonAddres;
            oerUsuario.codCountry = scodCountry;
            oerUsuario.nameuser = dt.Rows[0]["name_user"].ToString();
            oerUsuario.UserPassword = sUserPassword;
            oerUsuario.Perfilid = iPerfilid;
            oerUsuario.Moduloid = sModuloid;
            oerUsuario.UserRecall = suserrecall;
            oerUsuario.companyid = Convert.ToString(icompanyid);
            oerUsuario.PersonStatus = bPersonStatus;
            oerUsuario.PersonCreateBy = sPersonCreateBy;
            oerUsuario.PersonDateBy = Convert.ToString(tPersonDateBy);
            oerUsuario.PersonModiBy = sPersonModiBy;
            oerUsuario.PersonDateModiBy = Convert.ToString(tPersonDateModiBy);

            return oerUsuario;

       }
        /// <summary>
        /// Registra usuarios en la tambla Person de la BD DB_LUCKY_TMP
        /// 12/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sidtypeDocument"></param>
        /// <param name="sPersonnd"></param>
        /// <param name="sPersonFirtsname"></param>
        /// <param name="sPersonLastName"></param>
        /// <param name="sPersonSurname"></param>
        /// <param name="sPersonSeconName"></param>
        /// <param name="sPersonEmail"></param>
        /// <param name="sPersonPhone"></param>
        /// <param name="sPersonAddres"></param>
        /// <param name="scodCountry"></param>
        /// <param name="snameuser"></param>
        /// <param name="sUserPassword"></param>
        /// <param name="iPerfilid"></param>
        /// <param name="sModuloid"></param>
        /// <param name="suserrecall"></param>
        /// <param name="icompanyid"></param>
        /// <param name="bPersonStatus"></param>
        /// <param name="sPersonCreateBy"></param>
        /// <param name="tPersonDateBy"></param>
        /// <param name="sPersonModiBy"></param>
        /// <param name="tPersonDateModiBy"></param>
        /// <returns>oerUsuarioMovil</returns>
        public EUsuario RegistrarUsuarioMovilDBTMP(int iperson_id, string sidtypeDocument, string sPersonnd, 
        string sPersonFirtsname, string sPersonLastName, string sPersonSurname, string sPersonSeconName,
        string sPersonEmail, string sPersonPhone, string sPersonAddres, string scodCountry,
        string snameuser, string sUserPassword, string iPerfilid, string sModuloid, string suserrecall, 
        int icompanyid, bool bPersonStatus, string sPersonCreateBy, DateTime tPersonDateBy, string sPersonModiBy, 
        DateTime tPersonDateModiBy)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERUSERMOVIL", iperson_id, sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName, sPersonEmail, sPersonPhone, sPersonAddres, scodCountry,
                   snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonCreateBy, tPersonDateBy, sPersonModiBy, tPersonDateModiBy);
            EUsuario oerUsuarioMovil = new EUsuario();

            oerUsuarioMovil.Personid = iperson_id;
            oerUsuarioMovil.idtypeDocument = sidtypeDocument;
            oerUsuarioMovil.Personnd = sPersonnd;
            oerUsuarioMovil.PersonFirtsname = sPersonFirtsname;
            oerUsuarioMovil.PersonLastName = sPersonLastName;
            oerUsuarioMovil.PersonSurname = sPersonSurname;
            oerUsuarioMovil.PersonSeconName = sPersonSeconName;
            oerUsuarioMovil.PersonEmail = sPersonEmail;
            oerUsuarioMovil.PersonPhone = sPersonPhone;
            oerUsuarioMovil.PersonAddres = sPersonAddres;
            oerUsuarioMovil.codCountry = scodCountry;
            oerUsuarioMovil.nameuser = snameuser;
            oerUsuarioMovil.UserPassword = sUserPassword;
            oerUsuarioMovil.Perfilid = iPerfilid;
            oerUsuarioMovil.Moduloid = sModuloid;
            oerUsuarioMovil.UserRecall = suserrecall;
            oerUsuarioMovil.companyid = Convert.ToString(icompanyid);
            oerUsuarioMovil.PersonStatus = bPersonStatus;
            oerUsuarioMovil.PersonCreateBy = sPersonCreateBy;
            oerUsuarioMovil.PersonDateBy = Convert.ToString(tPersonDateBy);
            oerUsuarioMovil.PersonModiBy = sPersonModiBy;
            oerUsuarioMovil.PersonDateModiBy = Convert.ToString(tPersonDateModiBy);

            return oerUsuarioMovil;

        }
        /// <summary>
        ///  //Metodo para actualizar usuarios en SIGE
        /// </summary>
        /// ----Parametros de Entrada
        /// <param name="iPersonid"></param>
        /// <param name="sidtypeDocument"></param>
        /// <param name="sPersonnd"></param>
        /// <param name="sPersonFirtsname"></param>
        /// <param name="sPersonLastName"></param>
        /// <param name="sPersonSurname"></param>
        /// <param name="sPersonSeconName"></param>
        /// <param name="sPersonEmail"></param>
        /// <param name="sPersonPhone"></param>
        /// <param name="sPersonAddres"></param>
        /// <param name="scodCountry"></param>
        /// <param name="snameuser"></param>
        /// <param name="sUserPassword"></param>
        /// <param name="iPerfilid"></param>
        /// <param name="sModuloid"></param>
        /// <param name="suserrecall"></param>
        /// <param name="icompanyid"></param>
        /// <param name="bPersonStatus"></param>
        /// <param name="sPersonModiBy"></param>
        /// <param name="tPersonDateModiBy"></param>
        /// ---Parametros de Salida
        /// <returns>Retorna un </returns>
        public EUsuario ActualizarUser(int iPersonid,string sidtypeDocument, string sPersonnd, 
          string sPersonFirtsname, string sPersonLastName, string sPersonSurname, string sPersonSeconName,
          string sPersonEmail, string sPersonPhone, string sPersonAddres, string scodCountry,
          string snameuser, string sUserPassword, string iPerfilid, string sModuloid, string suserrecall, 
          int icompanyid, bool bPersonStatus, string sPersonModiBy, DateTime tPersonDateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEB_UPDATEPERSON",iPersonid, sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName, sPersonEmail, sPersonPhone, sPersonAddres, scodCountry,
                   snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid,bPersonStatus, sPersonModiBy, tPersonDateModiBy);
                EUsuario oeuUsuario = new EUsuario();
            oeuUsuario.Personid = iPersonid;
            oeuUsuario.idtypeDocument = sidtypeDocument;
            oeuUsuario.Personnd = sPersonnd;
            oeuUsuario.PersonFirtsname = sPersonFirtsname;
            oeuUsuario.PersonLastName = sPersonLastName;
            oeuUsuario.PersonSurname = sPersonSurname;
            oeuUsuario.PersonSeconName = sPersonSeconName;
            oeuUsuario.PersonEmail = sPersonEmail;
            oeuUsuario.PersonPhone = sPersonPhone;
            oeuUsuario.PersonAddres = sPersonAddres;
            oeuUsuario.codCountry = scodCountry;
            oeuUsuario.nameuser = snameuser;
            oeuUsuario.UserPassword = sUserPassword;
            oeuUsuario.Perfilid = iPerfilid;
            oeuUsuario.Moduloid = sModuloid;
            oeuUsuario.UserRecall = suserrecall;
            oeuUsuario.companyid = Convert.ToString(icompanyid);
            oeuUsuario.PersonStatus = bPersonStatus;
            
            oeuUsuario.PersonModiBy = sPersonModiBy;
            oeuUsuario.PersonDateModiBy = Convert.ToString(tPersonDateModiBy);
            return oeuUsuario;
            
   
        }
        /// <summary>
        /// Actualiza tabla person en la base de datos DB_LUCKY_TMP
        /// 12/01/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iPersonid"></param>
        /// <param name="sidtypeDocument"></param>
        /// <param name="sPersonnd"></param>
        /// <param name="sPersonFirtsname"></param>
        /// <param name="sPersonLastName"></param>
        /// <param name="sPersonSurname"></param>
        /// <param name="sPersonSeconName"></param>
        /// <param name="sPersonEmail"></param>
        /// <param name="sPersonPhone"></param>
        /// <param name="sPersonAddres"></param>
        /// <param name="scodCountry"></param>
        /// <param name="snameuser"></param>
        /// <param name="sUserPassword"></param>
        /// <param name="iPerfilid"></param>
        /// <param name="sModuloid"></param>
        /// <param name="suserrecall"></param>
        /// <param name="icompanyid"></param>
        /// <param name="bPersonStatus"></param>
        /// <param name="sPersonModiBy"></param>
        /// <param name="tPersonDateModiBy"></param>
        /// <returns></returns>
        public EUsuario ActualizarUserTMP(
            int iPersonid, string sidtypeDocument, string sPersonnd, 
            string sPersonFirtsname, string sPersonLastName, 
            string sPersonSurname, string sPersonSeconName,
            string sPersonEmail, string sPersonPhone, 
            string sPersonAddres, string scodCountry,
            string snameuser, string sUserPassword, string iPerfilid, 
            string sModuloid, string suserrecall, int icompanyid, 
            bool bPersonStatus, string sPersonModiBy, 
            DateTime tPersonDateModiBy)
        {
            oConn = new Conexion(1);
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_UPDATEPERSONTMP", iPersonid, sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName, sPersonEmail, sPersonPhone, sPersonAddres, scodCountry,
                   snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonModiBy, tPersonDateModiBy);
            EUsuario oeuUsuario = new EUsuario();
            oeuUsuario.Personid = iPersonid;
            oeuUsuario.idtypeDocument = sidtypeDocument;
            oeuUsuario.Personnd = sPersonnd;
            oeuUsuario.PersonFirtsname = sPersonFirtsname;
            oeuUsuario.PersonLastName = sPersonLastName;
            oeuUsuario.PersonSurname = sPersonSurname;
            oeuUsuario.PersonSeconName = sPersonSeconName;
            oeuUsuario.PersonEmail = sPersonEmail;
            oeuUsuario.PersonPhone = sPersonPhone;
            oeuUsuario.PersonAddres = sPersonAddres;
            oeuUsuario.codCountry = scodCountry;
            oeuUsuario.nameuser = snameuser;
            oeuUsuario.UserPassword = sUserPassword;
            oeuUsuario.Perfilid = iPerfilid;
            oeuUsuario.Moduloid = sModuloid;
            oeuUsuario.UserRecall = suserrecall;
            oeuUsuario.companyid = Convert.ToString(icompanyid);
            oeuUsuario.PersonStatus = bPersonStatus;

            oeuUsuario.PersonModiBy = sPersonModiBy;
            oeuUsuario.PersonDateModiBy = Convert.ToString(tPersonDateModiBy);
            return oeuUsuario;
        }
    
        /// <summary>
        /// Verificar si el el primer acceso del Usuario
        /// </summary>
        /// <param name="sUser"></param>
        /// <returns></returns>
        public EEntrySeccion PrimerAcceso(string sUser)
        {
            EEntrySeccion oeseccion = new EEntrySeccion();
            try{
                oConn = new Conexion(1);
                DataTable dt = oConn.ejecutarDataTable(
                    "UP_WEB_GEN_VERIFICA_PRM_INGRESO", sUser);

                if (dt.Rows.Count > 0){
                    oeseccion.seccionname = sUser;
                    oeseccion.seccionname =
                        dt.Rows[0]["seccion_name"].ToString().Trim();
                }
                else {
                    messages = "Error: No se Encontraron registros para " +
                    "La consulta solicitada, ¡por favor verificar!";
                }
                
            }
            catch (Exception ex) {
                messages = "Error: " + ex.Message.ToString();
            }

            return oeseccion;
        }
        /// <summary>
        /// Metodo para rregistrar la primera session de Usuario en SIGE
        /// </summary>
        public EUsuario  cambiarContrasena(string sUser, string sNewPwd, string sModiby, string sDatemodi )
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_CAMBIOPASSWORD",  sUser, sNewPwd, sModiby,sDatemodi);
            EUsuario oecusuario= new EUsuario();
            oecusuario.nameuser= sUser;
            oecusuario.UserPassword=sNewPwd;
            oecusuario.PersonModiBy = sModiby;
            oecusuario.PersonDateModiBy = sDatemodi;
            return oecusuario;
        }
       //Metodo para controlar el registro de la primera session de usuario

        public EEntrySeccion Register_PrimerSeccion(string sSeccionname, string sentryCreateBy,string sentryDateBy, 
            string sentryModiBy, string sentryDatemod)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTER_SECCIONUSER_SIGE", sSeccionname, sentryCreateBy, sentryDateBy, sentryModiBy, sentryDatemod);
            EEntrySeccion oerseccion = new EEntrySeccion();                
            oerseccion.seccionname = sSeccionname;
            oerseccion.entryCreateBy = sentryCreateBy;
            oerseccion.entryDateBy = sentryDateBy;
            oerseccion.entryModiBy = sentryModiBy;
            oerseccion.entryDatemodi = sentryDatemod;
            return oerseccion;
        }

        /// <summary>
        /// Metodo para consultar credenciales de Usuario para envio de correo
        /// </summary>
        /// <param name="snameuser"></param>
        /// <returns></returns>
        public DataTable ConsultarCredenciales(string snumdoc)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_CONSULTACREDENCIALES", snumdoc);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    EUsuario oeusuario = new EUsuario();
                    oeusuario.nameuser = dt.Rows[0]["name_user"].ToString().Trim();
                    oeusuario.UserPassword = dt.Rows[0]["User_Password"].ToString().Trim();
                }
                return dt;
            }
            else
            {
                return null;            
            }
        }

        public int registrarClientesxUsuario(int codusuario, int codcliente, bool nodoxcanal_estado, string username)
        {
            oConn = new Conexion(1);
            int st = 0;
            try
            {
                st = Convert.ToInt32(oConn.ejecutarEscalar(
                    "UP_WEBXPLORA_ACTUALIZAR_CLIENTE_X_USUARIO", codusuario, codcliente, nodoxcanal_estado, username));
            }
            catch (Exception ex) { }
            return st;
        }

        public DataSet buscarClientesxUsuario(int iPerson_id, int iCompany_id) 
        {
            oConn = new Conexion(1);
            DataSet ds = new DataSet();

            try {
                ds = oConn.ejecutarDataSet("UP_WEBXPLORA_AD_LISTA_CLIENTE_X_USUARIO", iPerson_id, iCompany_id);
            }
            catch (Exception ex) {
                throw ex;
            }

            return ds;
        }
        /// <summary>
        /// Devolver el mensaje de Error, en caso haya ocurrido errores
        /// durante la ejecución de alguno de los métodos.
        /// </summary>
        /// <returns></returns>
        public String getMessages() {
            return messages;
        }

        /// <summary>
        /// Función para Encriptar Passwords
        /// </summary>
        /// <param name="password"></param>
        public String fncEncriptar(String password)
        {
            String tamperProofKey = "YourUglyRandomKeyLike-lkj54923c478";
            String result = "";
            try
            {
                result = Lucky.CFG.Util.Encriptacion.Codificar(password, tamperProofKey);
            }
            catch (Exception ex)
            {
                messages = "Ocurrio un Error: " + ex.Message.ToString();
            }
            return result;
        }

        /// <summary>
        /// Función para obtener el Password de la Base de Datos,
        /// por userName.
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public DataTable fncGetPassword(String userName){
            DataTable dt = new DataTable();
            try{
                
                oConn = new Conexion(1);
                dt = oConn.ejecutarDataTable("UP_WEBXPLORAGEN_PASSUSER", userName);

            }catch (Exception ex){
                
                messages = "Ocurrio un Error: " + ex.Message.ToString();

            }
            return dt;
        }

        /// <summary>
        /// Función para Actualizar la Encriptación del Password en Base de Datos
        /// En caso el password no se haya almacenado Encriptado.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="idUser"></param>
        public void fncUpdatePasswordEncriptado(String password, String idUser)
        {
            try
            {
                oConn = new Conexion(1);
                oConn.ejecutarDataReader("UP_WEBXPLORA_UPDATEPSWENCRIPTA", password, idUser);
            }
            catch (Exception ex)
            {
                messages = "Error: " + ex.Message.ToString();
            }
        }


        /// <summary>
        /// Retorna la Pagina a la que debe ser redireccionado el usuario despues de loguearse.
        /// </summary>
        public String fncGetDataAplication(String idCountry, 
        String idModule){

            String pagina = "";

            EAplicacion oeAplicacion = new EAplicacion();
            DAplicacion oAplicacionWeb = new DAplicacion();

            try{
                oeAplicacion = oAplicacionWeb.obtenerPK(
                    idCountry == null ? "0" : idCountry,
                    idModule == null ? "0" : idModule);
                // Verifica que no haya Errores
                if (oAplicacionWeb.getMessage().Equals("")){
                    pagina = oeAplicacion.appurl;

                }else{
                    messages = "Error: " + oAplicacionWeb.getMessage();
                }
            }catch (Exception ex){
                messages = "Error: " + ex.Message.ToString();
            }
            return pagina;
        }

        /// <summary>
        /// Retornar el Url a Direccionar por usuario y Perfil
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="idCompany"></param>
        /// <param name="idPerfil"></param>
        /// <param name="pUrlPagina">UrlPaginaParametro</param>
        public String fncVerifyFirstAccess(String userName, 
            String idCompany, String idPerfil, String pUrlPagina) {
            String urlPagina = "";
            EEntrySeccion oeSeccion = new EEntrySeccion();
            try{
                oeSeccion = PrimerAcceso(userName);
                if (getMessages().Equals("")) {
                    if (oeSeccion.seccionname == "1") {
                        urlPagina = "Cambio_pswd.aspx";
                    }
                    else if (idCompany.Equals("1562")
                           && (idPerfil.Equals("6001") 
                           || idPerfil.Equals("4512"))){
                        urlPagina = "http://sige.lucky.com.pe:8081/";
                    }
                    else if (idCompany.Equals("1561")
                      && idPerfil.Equals("4512"))
                    {
                        urlPagina = "http://sige.lucky.com.pe:8282";
                    }
                    else {
                        urlPagina = "~/" + pUrlPagina;
                    }
                }
            }catch (Exception ex) {
                messages = ex.Message.ToString();
            }
            return urlPagina;
        }

  
    }
}