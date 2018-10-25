using System;
using System.Collections.Generic;
using System.Text;

namespace Lucky.Data
{
   
    /// <summary>
    /// Clase UserInterface: Define el Tipo de Interfaz a usuar en el desarrollo de la Aplicación
    /// Developed by: 
    /// - Ing. Carlos Alberto Hernandez R. (CAHR)
    /// Changes:
    /// - 2009-02-10 Carlos Alberto Hernandez R. (CAHR) Creación de la Clase
    /// - 2018-10-21 Pablo Salas Alvarez (PSA) Refactoring.
    /// </summary>
    public class UserInterface{

        // Atributo lUsuario
        private string lUsuario;

        // Atributo lContraseña
        private string lContrasena;

        // Encapsulamiento para Usuario
        public string Usuario{
            get { return this.lUsuario; }
            set { this.lUsuario = value; }
        }

        // Encapsulamiento para Contraseña
        public string Contrasena{
            get { return this.lContrasena; }
            set { this.lContrasena = value; }
        }
        
        // Atributo para almacenar los Mensaje de Error
        public String message;
        

        /// <summary>
        /// Constructor
        /// Define el tipo de aplicación a usuar
        /// </summary>
        public UserInterface()
        {
            // Si la Aplicación es Web
            if (AppDomain.CurrentDomain.GetData("ApplicationType") == "Web"){
                
                // Verifica si los Objeto Session sUser y sPwd son diferente de vacio
                try{
                    WebUserInterface owui = new WebUserInterface();
                    // Verificar que no haya errores en el Mensaje de regreso
                    if (owui.getMessate().Equals(null)){

                        // Setear en el String lUsuario el valor de la Session sUser
                        lUsuario = owui.User();

                        // Setear en el String lUsuario el valor de la Session sPwd
                        lContrasena = owui.Contrasena();
                        // owui = null;
                    }
                    else{
                        message = owui.getMessate();
                    }
                
                }catch (Exception ex) {
                    message = "Ocurrio un Error: "
                        + ex.ToString().Substring(0, 100) + "...";
                }
                
            } else{
                //Si la Aplicación es de Escritorio
                DesktopUserInterface odui = new DesktopUserInterface();
                lUsuario = odui.User();
                lContrasena = odui.Contrasena();
                odui = null;
            }
        }

        /// <summary>
        /// Obtiene el Mensaje de Error en caso se haya presentado
        /// Si es Null quiere decir que todo esta ok.
        /// </summary>
        /// <returns></returns>
        public String getMessate(){
            return message;
        }


    }

    /// <summary>
    /// Define un clase interna de Heriencia simple 
    /// de System.Web.UI.Page si la aplicación es Web
    /// , verifica si los objetos Session sUser y sPswd son 
    /// diferentes de NULL
    /// Developed by: 
    /// - Ing. Carlos Alberto Hernandez R. (CAHR)
    /// Changes:
    /// - 2009-02-10 Carlos Alberto Hernandez R. (CAHR) Creación de la Clase
    /// - 2018-10-21 Pablo Salas Alvarez (PSA) Refactoring.
    /// </summary>
    internal class WebUserInterface : System.Web.UI.Page{

        // Atributo para almacenar los Mensaje de Error
        public String message;

        /// <summary>
        /// Retorna el valor de la Session sUser
        /// </summary>
        /// <returns></returns>
        internal string User(){
            // Si la Session sUser es diferente de NULL
            // Declara un Internal String User()
            // Retorna el valor, caso contrario retorna vacio ("")
            try{
                if (Session["sUser"] != null)
                    return Session["sUser"].ToString().Trim();
                else
                {
                    message = "Ocurrio un Error ... no se encontró la Sessión 'sUser', " +
                               "¡por favor verifique!";
                }
            }catch (Exception ex) {
                message = "Ocurrio un Error: " + ex.ToString().Substring(0,90) +
                                   " ... ¡por favor verifique!";
            }
            return "";
        }

        /// <summary>
        /// Retorna el valor de la Session de sPswd
        /// </summary>
        /// <returns></returns>
        internal string Contrasena(){
            // Si la Session sPswd es diferente de NULL
            // Retorna el valor, caso contrario retorna vacio ("")
            try{
                if (Session["sPswd"] != null)
                    return Session["sPswd"].ToString().Trim();
                else{
                    message = "Ocurrio un Error ... no se encontró la Sessión 'sPswd', " +
                               "¡por favor verifique!";
                    }
            }
            catch (Exception ex){
                message = "Ocurrio un Error: " + ex.ToString().Substring(0, 90) +
                                   " ... ¡por favor verifique!";
            }

            return "";
        }

        /// <summary>
        /// Obtiene el Mensaje de Error en caso se haya presentado
        /// Si es Null quiere decir que todo esta ok.
        /// </summary>
        /// <returns></returns>
        public String getMessate() {
            return message;
        }
    }


    /// <summary>
    /// Define una clase interna si el tipo de aplicación es de escritorio
    /// </summary>
    internal class DesktopUserInterface
    {
        internal string User()
        {
            if (AppDomain.CurrentDomain.GetData("sUser") != null)
                return AppDomain.CurrentDomain.GetData("sUser").ToString();
            else
                return "";
        }
        internal string Contrasena()
        {
            if (AppDomain.CurrentDomain.GetData("sPswd") != null)
                return AppDomain.CurrentDomain.GetData("sPswd").ToString();
            else
                return "";
        }
    }
}