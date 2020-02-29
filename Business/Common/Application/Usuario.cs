using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Data.Common.Security;
using Lucky.Entity.Common.Application;
using Lucky.Business;
using Lucky.Entity.Common.Security;
using Lucky.Entity.Common.Application.Security;
using Lucky.Entity.Common.Application.Response;


namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase de usuario de sistema
    /// Create By: Ing Carlos Alberto Hernández Rincon
    /// Fecha de Creación: 28/04/2009:9:50 am
    /// Requerimiento<>:
    /// Descripcion: Define los metodos del Negocio para registrar, 
    /// actualizar, y autenticar Usuarios
    /// Changes:
    /// - 02-01-2018 - Pablo Salas Alvarez (PSA) - Se adiciona la clase fncLogin(String userName, String userPassword)
    /// </summary>
    public class Usuario
    {
        // Invocando a la Clase Acceso a Datos.
        DUsuario odUsuario = new DUsuario();

        // Variable para guardar los mensajes de Error
        String messages = "";

        /// <summary>
        /// Metodo que si devuelve vacion ("") no se presentaron errores,
        /// Caso contrario muestra el mensaje de Error.
        /// </summary>
        /// <returns></returns>
        public String getMessages() {
            return messages;
        }

        //public event SIGEEventHandler PrimerAcceso;
        public Usuario()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }
        
        /// <summary>
        /// Permite obtener información de un usuario determinado.
        /// Este metodo permite consultar usuarios registrados 
        /// en la aplicacion.
        /// </summary>
        /// <param name="sName">Código de usuario</param>
        /// <param name="oConn">Objeto Conexión</param>
        /// <returns></returns>
        public EUsuario obtener(string sUser, string sPassw)
        {
            EUsuario oeUsuario = new EUsuario();
            //Lucky.Data.Common.Application.DUsuario odUsuario = 
            //    new Lucky.Data.Common.Application.DUsuario();
            try{
                oeUsuario = odUsuario.obtenerPK(sUser, sPassw);
                if (!odUsuario.getMessages().Equals("")) {
                    messages = "Ocurrio un Error: " + 
                        odUsuario.getMessages();
                }
            }
            catch (Exception ex) {
                messages = "Error: " + ex.Message.ToString();
            }
            //odUsuario = null;
            return oeUsuario;
        }

        /// <summary>
        /// Permite autenticar a un usuario. Desatando determinados eventos si el usuario no cuenta con permisos
        /// </summary>
        /// <param name="sName">Usuario</param>
        /// <param name="oConn">Origen</param>
        /// <returns></returns>
        /// //Metodo que permite realizar el registro de Usuarios en SIGE
        public EUsuario Registrar(string sidtypeDocument, string sPersonnd, 
            string sPersonFirtsname, string sPersonLastName, 
            string sPersonSurname, string sPersonSeconName,
            string sPersonEmail, string sPersonPhone, 
            string sPersonAddres, string sCountryid,
            string snameuser, string sUserPassword, string iPerfilid, 
            string sModuloid, string suserrecall, int icompanyid, 
            bool bPersonStatus, string sPersonCreateBy, 
            DateTime tPersonDateBy, string sPersonModiBy, 
            DateTime tPersonDateModiBy)
        {
            Lucky.Data.Common.Application.DUsuario odrUsuario = new Lucky.Data.Common.Application.DUsuario();
            EUsuario oerUsuario = odrUsuario.RegistrarPK(sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName,
            sPersonEmail, sPersonPhone, sPersonAddres, sCountryid, snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonCreateBy, tPersonDateBy, sPersonModiBy, tPersonDateModiBy);
            odrUsuario = null;
            return oerUsuario;
        }

        //Permite realizar registro de usuario seleccionando mercaderista, perfil 001
        public EUsuario RegistrarMovil(
            string sidtypeDocument, string sPersonnd, 
            string sPersonFirtsname, string sPersonLastName, 
            string sPersonSurname, string sPersonSeconName,
            string sPersonEmail, string sPersonPhone, 
            string sPersonAddres, string sCountryid,
            string snameuser, string sUserPassword, string iPerfilid, 
            string sModuloid, string suserrecall, int icompanyid, 
            bool bPersonStatus, string sPersonCreateBy, 
            DateTime tPersonDateBy, string sPersonModiBy, 
            DateTime tPersonDateModiBy)
        {
            Lucky.Data.Common.Application.DUsuario odrUsuario = new Lucky.Data.Common.Application.DUsuario();
            EUsuario oerUsuario = odrUsuario.RegistrarUsuarioMovil(sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName,
            sPersonEmail, sPersonPhone, sPersonAddres, sCountryid, snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonCreateBy, tPersonDateBy, sPersonModiBy, tPersonDateModiBy);
            odrUsuario = null;
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
        /// <param name="sCountryid"></param>
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
        /// <returns></returns>
        public EUsuario RegistrarMovilTMP(
            int iperson_id, string sidtypeDocument, string sPersonnd, 
            string sPersonFirtsname, string sPersonLastName, 
            string sPersonSurname, string sPersonSeconName,
            string sPersonEmail, string sPersonPhone, 
            string sPersonAddres, string sCountryid,
            string snameuser, string sUserPassword, 
            string iPerfilid, string sModuloid, string suserrecall, 
            int icompanyid, bool bPersonStatus, string sPersonCreateBy, 
            DateTime tPersonDateBy, string sPersonModiBy, 
            DateTime tPersonDateModiBy)
        {
            Lucky.Data.Common.Application.DUsuario odrUsuarioTMP = new Lucky.Data.Common.Application.DUsuario();
            EUsuario oerUsuarioTMP = odrUsuarioTMP.RegistrarUsuarioMovilDBTMP(iperson_id, sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName,
            sPersonEmail, sPersonPhone, sPersonAddres, sCountryid, snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonCreateBy, tPersonDateBy, sPersonModiBy, tPersonDateModiBy);
            odrUsuarioTMP = null;
            return oerUsuarioTMP;
        }

        //Metodo que permite realizar la Actualizacion de Usuarios en SIGE
        public EUsuario Actualizar(
            int iPersonid, string sidtypeDocument, string sPersonnd, 
            string sPersonFirtsname, string sPersonLastName, 
            string sPersonSurname, string sPersonSeconName,
            string sPersonEmail, string sPersonPhone, 
            string sPersonAddres, string scodCountry,
            string snameuser, string sUserPassword, 
            string iPerfilid, string sModuloid, 
            string suserrecall, int icompanyid, 
            bool bPersonStatus, string sPersonModiBy, 
            DateTime tPersonDateModiBy)
        {
            Lucky.Data.Common.Application.DUsuario odaUsuario = new Lucky.Data.Common.Application.DUsuario();
            EUsuario oeaUsuario = odaUsuario.ActualizarUser(iPersonid, sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName, sPersonEmail, sPersonPhone, sPersonAddres, scodCountry,
                   snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonModiBy, tPersonDateModiBy);
            odaUsuario = null;
            return oeaUsuario;
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
        public EUsuario ActualizarTMP(
            int iPersonid, string sidtypeDocument, 
            string sPersonnd, string sPersonFirtsname, 
            string sPersonLastName, string sPersonSurname, 
            string sPersonSeconName, string sPersonEmail, 
            string sPersonPhone, string sPersonAddres, 
            string scodCountry, string snameuser, string sUserPassword, 
            string iPerfilid, string sModuloid, string suserrecall, 
            int icompanyid, bool bPersonStatus, string sPersonModiBy, 
            DateTime tPersonDateModiBy)
        {
            Lucky.Data.Common.Application.DUsuario odaUsuarioTMP = new Lucky.Data.Common.Application.DUsuario();
            EUsuario oeaUsuarioTMP = odaUsuarioTMP.ActualizarUserTMP(iPersonid, sidtypeDocument, sPersonnd, sPersonFirtsname, sPersonLastName, sPersonSurname, sPersonSeconName, sPersonEmail, sPersonPhone, sPersonAddres, scodCountry,
                   snameuser, sUserPassword, iPerfilid, sModuloid, suserrecall, icompanyid, bPersonStatus, sPersonModiBy, tPersonDateModiBy);
            odaUsuarioTMP = null;
            return oeaUsuarioTMP;
        }

        //Metodo que Permite hacer la Busqueda de un Usuario ya existente
        public DataTable Search(
            string sPersonnd, string sPersonFirsname, string sNameuser)
        {

            Lucky.Data.Common.Application.DBusquedas odsUsuario = new Lucky.Data.Common.Application.DBusquedas();
            DataTable dt = odsUsuario.Search_User(sPersonnd, sPersonFirsname, sNameuser);

            odsUsuario = null;
            return dt;

        }


        //----Metodo para registrar Roles
        public ERoles RegistrarRoles(
            string sRol_id, string sRolName, string sRolDescription, 
            bool bRolStatus, string sRolCreateBy, string sRolDateBy, 
            string sRolModiBy, string sRolDateModiBy)
        {

            Lucky.Data.Common.Application.DRoles odrroles = new Lucky.Data.Common.Application.DRoles();
            ERoles oeroles = odrroles.RegistrarRolesPK(sRol_id, sRolName, sRolDescription, bRolStatus, sRolCreateBy, sRolDateBy, sRolModiBy, sRolDateModiBy);
            odrroles = null;
            return oeroles;


        }
        //---Metodo de Consulta de Roles

        public DataTable BuscarRoles(string sRolName)
        {
            Lucky.Data.Common.Application.DRoles odsroles = 
                new Lucky.Data.Common.Application.DRoles();
            ERoles oeroles = new ERoles();
            DataTable dtroles = odsroles.ObtenerRoles(sRolName);
            odsroles = null;
            return dtroles;

        }

        //Metdo para Actualizacion de Roles
        public ERoles ActualizaRol(string sRolid, string sRolName, 
            string sRolDescription, bool bRolStatus, string sRolModiBy, 
            string sRolDateModiBy)
        {
            Lucky.Data.Common.Application.DRoles odacroles = new Lucky.Data.Common.Application.DRoles();
            ERoles oeroles = odacroles.ActulizarRoles(sRolid, sRolName, sRolDescription, bRolStatus, sRolModiBy, sRolDateModiBy);
            odacroles = null;
            return oeroles;
        }

        //----Metodo para registrar Perfiles
        public EProfiles RegistrarProfiles(//string sPerfil_id,
            string sTipoPerfil_id, string sRolid, string sLevel, 
            string sPerfilName, string dModuloId, 
            string sPerfilDescription,int idChannel, 
            bool bPerfilStatus, string sPerfilCreateBy, 
            string sPerfilDateBy, string sPerfilModiBy, 
            string sPerfilDateModiBy)
        {
            Lucky.Data.Common.Application.DProfiles odrperfiles = new Lucky.Data.Common.Application.DProfiles();
            EProfiles oeperfiles = odrperfiles.registrarPerfilesPK(//sPerfil_id,
                sTipoPerfil_id, sRolid, sLevel, sPerfilName, dModuloId, sPerfilDescription, idChannel, bPerfilStatus, sPerfilCreateBy, sPerfilDateBy, sPerfilModiBy, sPerfilDateModiBy);

            odrperfiles = null;
            return oeperfiles;
        }

        //---Metodo de Consulta de Perfiles
        public DataTable BuscarPerfiles(
            string sPerfilName, string sRolid, int idChannel, 
            string sLevel/*, string sTipPerfil*/)
        {
            DataTable dtperfiles = null;
            try
            {
                Lucky.Data.Common.Application.DProfiles odsperfiles = new Lucky.Data.Common.Application.DProfiles();
                dtperfiles = odsperfiles.ObtenerPerfiles(sPerfilName, sRolid, idChannel, sLevel/*, sTipPerfil*/);
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message.ToString());
                messages = "Error: " + ex.Message.ToString();
            }
            
            return dtperfiles;
        }
        
        //----Metodo para registrar Perfiles
        public EProfiles Actualizar_Perfiles(
            string sPerfilid, string sTipPerfilid, string sRolid, 
            string sLevel, string sPerfilName, string dModuloId, 
            string sPerfilDescription, int idChannel, 
            bool bPerfilStatus, string sPerfilModiBy)
        {
            Lucky.Data.Common.Application.DProfiles odaperfiles = new Lucky.Data.Common.Application.DProfiles();
            EProfiles oeaperfiles = odaperfiles.Actualizar_Perfiles(
                  sPerfilid
                , sTipPerfilid
                , sRolid
                , sLevel
                , sPerfilName
                , dModuloId
                , sPerfilDescription
                , idChannel
                , bPerfilStatus
                , sPerfilModiBy);

            odaperfiles = null;
            return oeaperfiles;
        }

        /// <summary>
        /// Cambia el password del usuario 
        public EUsuario cambiarContrasena(string sUser, 
            string sNewPwd, string sModiBy, string sDatemodi)
        {
            Lucky.Data.Common.Application.DUsuario odUsuario = 
                new Lucky.Data.Common.Application.DUsuario();
            EUsuario oecusuario = odUsuario.cambiarContrasena(
                sUser, sNewPwd,  sModiBy, sDatemodi);

            odUsuario = null;
            return oecusuario;
        }

        /// <summary>
        /// Metodo para consultar credenciales de Usuario para envio de correo
        /// </summary>
        /// <param name="snameuser"></param>
        /// <returns></returns>
        public DataTable ConsultarCredenciales(string snumdoc)
        {
            DUsuario odusuario = new DUsuario();
            DataTable dtusuario = odusuario.ConsultarCredenciales(snumdoc);
            odusuario = null;
            return dtusuario;
        }

        //----Metodo para registrar Niveles
        public EPersonLevel RegistrarNiveles(
            string sid_Level, string sLevel_Description, 
            bool bLevel_status, string sLevel_CreateBy,
            DateTime tLevel_DateBy, string sLevel_ModiBy, 
            DateTime tLevel_DateModiBy)
        {
            DPersonLevel odrNiveles = new DPersonLevel();
            EPersonLevel oeNiveles = odrNiveles.registrarPersonLevelPK(sid_Level, sLevel_Description, bLevel_status, sLevel_CreateBy,
              tLevel_DateBy, sLevel_ModiBy, tLevel_DateModiBy);
            odrNiveles = null;
            return oeNiveles;
        }

        /// <summary>
        /// Registra relación de nivel de usuario a modulos para permisos
        /// 03/12/2010  Magaly Jiménez
        /// </summary>
        /// <param name="sid_Level"></param>
        /// <param name="sModulo_id"></param>
        /// <param name="sModulo_Name"></param>
        /// <param name="bPerson_Modulo_Status"></param>
        /// <param name="sPerson_Modulo_CreateBy"></param>
        /// <param name="tPerson_Modulo_Dateby"></param>
        /// <param name="sPerson_Modulo_ModiBy"></param>
        /// <param name="tPerson_Modulo_DateModiBy"></param>
        /// <returns></returns>
        public EPersonLevel RegistrarNivelesModulo(
            string sid_Level, string sModulo_id, string sModulo_Name, 
            bool bPerson_Modulo_Status, string sPerson_Modulo_CreateBy,
            DateTime tPerson_Modulo_Dateby, string sPerson_Modulo_ModiBy, 
            DateTime tPerson_Modulo_DateModiBy)
        {
            DPersonLevel odrNivelesModulo = new DPersonLevel();
            EPersonLevel oeNivelesModulo = odrNivelesModulo.registrarPersonLevelModuloPK(sid_Level, sModulo_id, sModulo_Name, bPerson_Modulo_Status, sPerson_Modulo_CreateBy,
            tPerson_Modulo_Dateby, sPerson_Modulo_ModiBy, tPerson_Modulo_DateModiBy);
            odrNivelesModulo = null;
            return oeNivelesModulo;
        }

        //---Metodo de Consulta de Niveles
        public DataTable BuscarNiveles(
            string sid_Level, string sLevel_Description)
        {
            DPersonLevel odsNiveles = new DPersonLevel();
            EPersonLevel oeNiveles = new EPersonLevel();
            DataTable dtNiveles = 
                odsNiveles.ObtenerNiveles(sid_Level, sLevel_Description);
            odsNiveles = null;
            return dtNiveles;
        }
        
        //----Metodo para Atualizar Niveles
        public EPersonLevel Actualizar_Niveles(
            string sid_Level, string sLevel_Description, 
            bool bLevel_status, string sLevel_ModiBy, 
            DateTime tLevel_DateModiBy)
        {
            DPersonLevel odaNiveles = new DPersonLevel();
            EPersonLevel oeaNiveles = 
                odaNiveles.Actualizar_Niveles(
                sid_Level, sLevel_Description, bLevel_status,
                sLevel_ModiBy,tLevel_DateModiBy);              
            odaNiveles = null;
            return oeaNiveles;
        }
        
        /// <summary>
        /// Actualiza estado de modulos de la tabla de AD_Person_Modulos
        /// 04/12/2010  Magaly Jiménez
        /// </summary>
        /// <param name="sid_Level"></param>
        /// <param name="bPerson_Modulo_Status"></param>
        /// <param name="sPerson_Modulo_ModiBy"></param>
        /// <param name="tPerson_Modulo_DateModiBy"></param>
        /// <returns></returns>
        public EPersonLevel Actualizar_NivelesModulos(
            string sid_Level, string sModulo_id, 
            bool bPerson_Modulo_Status, string sPerson_Modulo_ModiBy, 
            DateTime tPerson_Modulo_DateModiBy)
        {
            DPersonLevel odaNivelesModulos = new DPersonLevel();
            EPersonLevel oeaNivelesModulos = 
                odaNivelesModulos.Actualizar_NivelesModulos(
                sid_Level, sModulo_id, bPerson_Modulo_Status, 
                sPerson_Modulo_ModiBy, tPerson_Modulo_DateModiBy);
            odaNivelesModulos = null;
            return oeaNivelesModulos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codusuario"></param>
        /// <param name="codcliente"></param>
        /// <param name="nodoxcanal_estado"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public int registrarClientesxUsuario(
            int codusuario, int codcliente, bool nodoxcanal_estado,
            string username)
        {
            DUsuario ouser = new DUsuario();
            int st = 0;
            try
            {
                st = ouser.registrarClientesxUsuario(
                    codusuario, codcliente, nodoxcanal_estado, username);
            }
            catch (Exception ex) {

                Exception exe;
                exe = ex;
            
            }
            return st;
        }

        public DataSet buscarClientesxUsuario(
            int iPerson_id, int iCompany_id)
        {
            DUsuario ouser = new DUsuario();
            DataSet dsuser = new DataSet();
            dsuser = ouser.buscarClientesxUsuario(iPerson_id, iCompany_id);
            return dsuser;
        }

        /// <summary>
        /// Metodo retornar que retorna los datos de Usuario y la Url para redireccionar despues del logueo.
        /// Funciona como orquestador
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        public LoginResponse fncLogin(String userName, String userPassword,
        String idMachine, DateTime dateBy) {
            LoginResponse oLoginResponse = new LoginResponse();
            String urlPage = "";

            Lucky.Entity.Common.Application.EUsuario oEUsuario = new EUsuario();
            DSesion_Users oDSesion_Users = new DSesion_Users();
            try
            {
                String sPassEncriptado = odUsuario.fncEncriptar(userPassword);
                if (odUsuario.getMessages().Equals(""))
                {
                    String sPassBaseDeDatos = odUsuario.fncGetPassword(userName).Rows[0]["User_Password"].ToString();
                    if (odUsuario.getMessages().Equals(""))
                    {
                        //if (sPassEncriptado != sPassBaseDeDatos){
                        //    if (sPassBaseDeDatos.Length < 15)
                        //    {
                        //        odUsuario.fncUpdatePasswordEncriptado(sPassEncriptado, userName);
                        //    }
                        //    if (!odUsuario.getMessages().Equals("")){
                        //        messages = odUsuario.getMessages();
                        //    }
                        //}

                        if (sPassEncriptado.Equals(sPassBaseDeDatos))
                        {
                            oEUsuario = odUsuario.obtenerPK(userName, userPassword);
                            if (odUsuario.getMessages().Equals(""))
                            {
                                oDSesion_Users.Registrar_Auditoria(
                                    userName,
                                    int.Parse(oEUsuario.companyid),
                                    idMachine,
                                    dateBy);
                                if (oDSesion_Users.getMessages().Equals(""))
                                {
                                    urlPage = odUsuario.fncVerifyFirstAccess(userName,
                                        oEUsuario.companyid,
                                        oEUsuario.Perfilid,
                                        odUsuario.fncGetDataAplication(
                                        oEUsuario.codCountry,
                                        oEUsuario.Moduloid));
                                }
                                else
                                {
                                    messages = oDSesion_Users.getMessages();
                                }
                            }
                            else
                            {
                                messages = odUsuario.getMessages();
                            }
                        }
                        else {
                            if (sPassBaseDeDatos.Length < 15)
                            {
                                odUsuario.fncUpdatePasswordEncriptado(sPassEncriptado, userName);
                            }
                            else {
                                messages = "Error: ¡Usuario / Password Incorrecto!";
                            }
                        }
                    }
                }
                else {
                    messages = odUsuario.getMessages();
                }
                oLoginResponse.OEUsuario = oEUsuario;
                oLoginResponse.UrlPage = urlPage;
            }
            catch (Exception ex) {
                messages = "Error: " + ex.Message.ToString();
            }
            return oLoginResponse;
        }
        

    }
}

     