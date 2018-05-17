using System;
using System.Collections.Generic;
using System.Text;

namespace Lucky.Data
{
    /// <summary>
    /// Clase UserInterface: Define el Tipo de Interfaz a usuar en el desarrollo de la Aplicación
    /// Creada Por: Ing. Carlos Alberto Hernández
    /// 10/02/2009
    /// </summary>
    public class UserInterface
    {
        /// <summary>
        /// Este constructior define el tipo de aplicación a usuar
        /// </summary>
        public UserInterface()
        {
            //Si la Aplicación es Web
            if (AppDomain.CurrentDomain.GetData("ApplicationType") == "Web")
            {
                WebUserInterface owui = new WebUserInterface();
                lUsuario = owui.User();
                lContrasena = owui.Contrasena();
                owui = null;
            }
            else
            {
                //Si la Aplicación es de Escritorio
                DesktopUserInterface odui = new DesktopUserInterface();
                lUsuario = odui.User();
                lContrasena = odui.Contrasena();
                odui = null;
            }
        }
        /// <summary>
        /// Define Atributos particulares extracapa de la Clase
        /// </summary>
        private string lUsuario;
        private string lContrasena;
        public string Usuario
        {
            get
            {
                return this.lUsuario;
            }
            set
            {
                this.lUsuario = value;
            }
        }
        public string Contrasena
        {
            get
            {
                return this.lContrasena;
            }
            set
            {
                this.lContrasena = value;
            }
        }
    }
    /// <summary>
    /// Define un clase interna de Heriencia simple de System.Web.UI.Page si la aplicación es Web
    /// </summary>
    internal class WebUserInterface : System.Web.UI.Page
    {
        internal string User()
        { 
            if (Session["sUser"] != null)
                return Session["sUser"].ToString().Trim();
            else
                return "";
        }
        internal string Contrasena()
        {
            if (Session["sPswd"] != null)
                return Session["sPswd"].ToString().Trim();
            else
                return "";
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