using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Security;

namespace Lucky.Data.Common.Security
{
    public class DUsuarioAcceso
    {
        private Conexion oConn;
        public DUsuarioAcceso()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }
        /// <summary>
        /// Obtiene acceso aleatorio
        /// </summary>
        /// <param name="sUser">Usuario</param>
        /// <param name="sOriCod">Origen</param>
        /// <returns></returns>
        public EUsuarioAcceso UsuarioAcceso(String sUser, String sPassw)
        {
            DataSet ds = oConn.ejecutarDataSet("UP_WEB_ACEDER_USER", sUser, sPassw);
            if (ds.Tables[0] != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    EUsuarioAcceso oeUsuarioAcceso = new EUsuarioAcceso();
                   
                 
                    oeUsuarioAcceso.codCountry = ds.Tables[0].Rows[0]["cod_Country"].ToString().Trim();
                    oeUsuarioAcceso.nameuser = ds.Tables[0].Rows[0]["name_user"].ToString().Trim();
                    oeUsuarioAcceso.UserPassword = ds.Tables[0].Rows[0]["User_Password"].ToString().Trim();
                    oeUsuarioAcceso.Perfilid = ds.Tables[0].Rows[0]["Perfil_id"].ToString().Trim();
                    oeUsuarioAcceso.Moduloid = ds.Tables[0].Rows[0]["Modulo_id"].ToString().Trim();
                    
                    return oeUsuarioAcceso;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        //public EUsuarioAcceso UsuarioAccesoAleatorioxCentroCosto(String sOriCod, String sCcoCod, String sUser)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("UP_WEB_GEN_ACCESO_CENTROCOSTO", sOriCod, sCcoCod, sUser);
        //    if (ds.Tables[0] != null)
        //    {
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            EUsuarioAcceso oeUsuarioAcceso = new EUsuarioAcceso();
        //            oeUsuarioAcceso.CodigoDivision = ds.Tables[0].Rows[0]["DivCod"].ToString().Trim();
        //            oeUsuarioAcceso.CodigoCentroCosto = ds.Tables[0].Rows[0]["CcoCod"].ToString().Trim();
        //            oeUsuarioAcceso.CodigoCliente = ds.Tables[0].Rows[0]["CiaCod"].ToString().Trim();
        //            oeUsuarioAcceso.CodigoLocalidad = ds.Tables[0].Rows[0]["LocCod"].ToString().Trim();
        //            oeUsuarioAcceso.CodigoModulo = ds.Tables[0].Rows[0]["ModCod"].ToString().Trim();
        //            oeUsuarioAcceso.Usuario = ds.Tables[0].Rows[0]["Name"].ToString().Trim();
        //            return oeUsuarioAcceso;
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
        ///// <summary>
        ///// Verifica el origen de un determinado usuario 
        ///// </summary>
        ///// <param name="sUser">Usuario</param>
        ///// <param name="oOriCod">Origen</param>
        ///// <returns></returns>
        //public bool verificarAccesoOrigen(String sUser, String sOriCod)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("UP_WEB_GEN_OBTENER_ORIGEN", sUser, sOriCod);
        //    if (ds.Tables.Count > 0)
        //    {
        //        if (ds.Tables[0].Rows.Count > 0) return true; else return false;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //// <summary>
        ///// Devuelve la relacion de Origenes relacionados a un determinado Usuario
        ///// </summary>
        ///// <param name="sUser">Usuario</param>
        ///// <param name="oOriCod">Origen</param>
        ///// <returns></returns>
        //public DataTable UsuarioAccesosxOrigen(String sUser, String sOriCod)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("UP_WEB_GEN_OBTENER_ORIGEN", sUser, sOriCod);
        //    if (ds.Tables[0] != null)
        //        return ds.Tables[0];
        //    else
        //        return null;
        //}
        ///// <summary>
        ///// Devuelve la relacion de Centro de Costo relacionados a un determinado Usuario
        ///// </summary>
        ///// <param name="sUser">Usuario</param>
        ///// <param name="sOriCod">Origen</param>
        ///// <returns></returns>
        //public DataTable UsuarioAccesosxCentroCosto(String sOriCod, String sUser)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("UP_WEB_GEN_OBTENER_CCO_USER", sOriCod, sUser);
        //    if (ds.Tables[0] != null)
        //        return ds.Tables[0];
        //    else
        //        return null;
        //}
        ///// <summary>
        ///// Devuelve la relacion de CIAS a las cuales tiene acceso un determinado usuario por CCO
        ///// </summary>
        ///// <param name="sOriCod">Origen</param>
        ///// <param name="sCcoCod">Centro de Costo</param>
        ///// <param name="sUser">Usuario</param>
        ///// <returns></returns>
        //public DataTable UsuarioAccesosxCompanias(String sOriCod, String sCcoCod, String sUser)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("UP_WEB_GEN_ACCESO_CIAS", sUser, sOriCod, sCcoCod);
        //    if (ds.Tables[0] != null)
        //        return ds.Tables[0];
        //    else
        //        return null;
        //}
        ///// <summary>
        ///// Devuelve la relacion de accesos de usuarios por módulo
        ///// </summary>
        ///// <param name="sOriCod">Origen</param>
        ///// <param name="sModCod">Módulo</param>
        ///// <param name="sUser">Usuario</param>
        ///// <returns></returns>
        //public DataTable obtenerUsuarioAccesos(String sOriCod, String sModCod, String sUser)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("up_psp_dev_modacc_all", sOriCod, sModCod, sUser);
        //    if (ds.Tables.Count > 0)
        //        return ds.Tables[0];
        //    else
        //        return null;
        //}
        ///// <summary>
        ///// Devuelve la relacion de origenes por usuario y módulo
        ///// </summary>
        ///// <param name="sUsuCod">Login</param>
        ///// <param name="sModCod">Módulo</param>
        ///// <returns></returns>
        //public DataTable obtenerOrigenesxUsuario_Modulo(String sUsuCod, String sModCod)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("up_cfg_dev_accesos", sUsuCod, sModCod);
        //    if (ds.Tables.Count > 0)
        //        return ds.Tables[0];
        //    else
        //        return null;
        //}
        ///// <summary>
        ///// Elimina los Accesos de un determinado Usuario para una determinada Compania
        ///// (Elimina de la tabla ModAcc)
        ///// </summary>
        ///// <param name="sOriCod">Origen</param>
        ///// <param name="sCiaCod">CIA</param>
        ///// <param name="sCcoCod">Centro Costo</param>
        ///// <param name="sUser">Usuario</param>
        //public void eliminar(String sOriCod, String sCiaCod, String sCcoCod, String sUser)
        //{
        //    oConn.ejecutarSinRetorno("UP_WEB_GEN_DEL_ALL_ACCESO_USER_CIA", sOriCod,
        //        sCiaCod, sCcoCod, sUser);
        //}
        ///// <summary>
        ///// Agrega un nuevo Acceso en la tabla ModAcc
        ///// </summary>
        ///// <param name="sOriCod">Origen</param>
        ///// <param name="sCiaCod">CIA</param>
        ///// <param name="sCcoCod">Centro Costo</param>
        ///// <param name="sDivCod">Division</param>
        ///// <param name="sLocCod">Localidad</param>
        ///// <param name="sUser">Usuario</param>
        ///// <param name="oConn">Objeto Conexion</param>
        //public void agregar(String sOriCod, String sCiaCod, String sCcoCod, String sDivCod, String sLocCod, String sUser)
        //{
        //    oConn.ejecutarSinRetorno("UP_WEB_GEN_REG_ACCESO", sOriCod, sCiaCod,
        //        sCcoCod, sDivCod, sLocCod, sUser);
        //}
        ///// <summary>
        ///// Devuelve la lista de Roles
        ///// </summary>
        ///// <param name="ps_CodigoRol">Nombre del Rol. Si se envia NULL no se toma en cuenta este parámetro en la condición del where</param>
        ///// <param name="ps_Prioridad">Prioridad del Rol. . Si se envia NULL no se toma en cuenta este parámetro en la condición del where</param>
        ///// <param name="ps_Tipo">Tipo de Rol. Si se envia NULL no se toma en cuenta este parámetro en la condición del where</param>
        //public DataTable listarRoles(String ps_CodigoRol, String ps_Prioridad, String ps_Tipo)
        //{
        //    DataSet ds = oConn.ejecutarDataSet("UP_HLP_LIS_ROLES", ps_CodigoRol, ps_Prioridad, ps_Tipo);
        //    if (ds.Tables[0] != null)
        //        return ds.Tables[0];
        //    else
        //        return null;
        //}

        //Funciones creadas para mantenimiemto de accesos.


        /// <summary>
        /// Verifica el origen de un determinado usuario 
        /// </summary>
        /// <param name="sUser">Usuario</param>
        /// <param name="oConn">Objeto Conexion</param>
        /// <returns></returns>
        //public DataSet validarOrigen(String sUser, SGS.Data.Conexion oConn)
        //{
        //    return oConn.ejecutarDataSet("UP_WEB_GEN_OBTENER_ORIGEN", sUser, "");
        //}

        /// <summary>

        /// Verifica si el usuario cuenta con acceso al Sistema SGSnet en UsuOri.
        /// </summary>
        /// <param name="sUser">Usuario</param>
        /// <param name="sOriCod">Origen</param>
        /// <param name="oConn">Objeto Conexion</param>
        /// <returns></returns>
        /// 

        //public DataSet validarAcceso_Hlp(String sUser, String sOriCod, SGS.Data.Conexion oConn)
        //{
        //    return oConn.ejecutarDataSet("UP_WEB_GEN_ACCESO_HLP", sUser, sOriCod);
        //}

        ///// <summary>
        ///// Devuelve la relacion de la letra Inicial de los nombres de Usuarios de un determinado 
        ///// CCO-Sistema. Las iniciales sirven para la realizacion de Busquedas rapidas.
        ///// </summary>
        ///// <param name="sOriCod">Origen</param>
        ///// <param name="sCcoCod">Centro de Costo</param>
        ///// <param name="oConn">Objeto Conexion</param>
        ///// <returns>DataSet con listado de Letras</returns>
        //public DataSet listarRolesAcceso_Index(String sOriCod, String sCcoCod, SGS.Data.Conexion oConn)
        //{
        //    return oConn.ejecutarDataSet("UP_WEB_GEN_LISTAR_ROLES_INIC", sOriCod, sCcoCod);
        //}
        ///// <summary>
        ///// Devuelve la relacion de Usuarios, Roles y Companias, segun un determinado CCO-Sistema
        ///// </summary>
        ///// <param name="sOriCod">Origen</param>
        ///// <param name="sCcoCod">Centro de Costo</param>
        ///// <param name="sModCod">Codigo Modulo</param>
        ///// <param name="oConn">Objeto Conexion</param>
        ///// <returns>DataSet (usuario, ciacod, ciades, rol)</returns>
        //public DataSet listarRolesAcceso(String sOriCod, String sCcoCod, String sModCod, SGS.Data.Conexion oConn)
        //{
        //    return oConn.ejecutarDataSet("UP_WEB_GEN_LISTAR_ROLES_ACC", sOriCod, sCcoCod, sModCod);
        //}
        ///// <summary>
        ///// Devuelve la relacion de Usuarios, Roles y Companias, segun un determinado CCO-Sistema
        ///// y la letra de Indice del nombre del usuario
        ///// </summary>
        ///// <param name="sOriCod">Origen</param>
        ///// <param name="sCcoCod">Centro de Costo</param>
        ///// <param name="sModCod">Codigo Modulo</param>
        ///// <param name="sLetra">Letra de busqueda</param>
        ///// <param name="oConn">Objeto Conexion</param>
        ///// <returns></returns>
        //public DataSet listarRolesAcceso_Letra(String sOriCod, String sCcoCod, String sModCod, String sLetra, SGS.Data.Conexion oConn)
        //{
        //    return oConn.ejecutarDataSet("UP_WEB_GEN_LISTAR_ROLES_LET", sOriCod, sCcoCod, sModCod, sLetra);
        //}
        ///// <summary>
        ///// Devuelve la Lista de todos los Roles considerados en el CCO-Sistema
        ///// </summary>
        ///// <param name="sModCod">Codigo Modulo</param>
        ///// <param name="oConn">Objeto Conexion</param>
        ///// <returns>DataSet (group_name de sec_menu_web)</returns>
        //public DataSet listarRolesSistema(String sModCod, SGS.Data.Conexion oConn)
        //{
        //    return oConn.ejecutarDataSet("UP_WEB_GEN_LISTAR_ROLES", sModCod);
        //}
    }
}