using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using LuckyMer.Contracts.DataContract;
using Telerik.Web.UI;

namespace Lucky.CFG.Util
{
    public class MenuLoadUtil
    {
        //Creado por: Ing. Ditmar Estrada Bernuy.
        //Fecha :21/03/2012
        //Comentario: Este metodo recibe como parametros un objeto de tipo RadMenu y
        //y otro objeto de tipo MenuServiceResponse que tiene una propiedad de tipo lista de Entidad MenuDetalle

        public  RadMenu LoadRadMenu(RadMenu rad_menu, MenuServiceResponse menuServiceResponse)
        {
            //declaramos los ID's del menu y del padre
            Int32 IDMenu = 0;
            Int32 IDPadre = 0;
        
            // Recorremos cada objeto de la Lista MenuDetalles
            for (Int32 x = 0; x < menuServiceResponse.MenuDetalles.Count; x++)
            {
                IDMenu = menuServiceResponse.MenuDetalles[x].Id_MenuD;
                IDPadre = menuServiceResponse.MenuDetalles[x].Id_Padre;
                //verficamos si son iguales para poder agregar al nivel 1 del Menu
                if (IDMenu == IDPadre)
                {
                    RadMenuItem menuItem = new RadMenuItem();
                    menuItem.Text = menuServiceResponse.MenuDetalles[x].Descripcion; 
                    menuItem.Value = menuServiceResponse.MenuDetalles[x].Id_MenuD.ToString();
                    menuItem.NavigateUrl = menuServiceResponse.MenuDetalles[x].Url; 
                    menuItem.ImageUrl = menuServiceResponse.MenuDetalles[x].Url_foto;
                    rad_menu.Items.Add(menuItem); //Agregamos los Subitems 
                    addMenuItem(menuItem, IDPadre, menuServiceResponse);
                }
            }

            return rad_menu;
        }
        private  void addMenuItem(RadMenuItem menuItem, Int32 IDPadreAnterior, MenuServiceResponse menuServiceResponse)
        {
            Int32 IDMenu = 0;
            Int32 IDPadre = menuServiceResponse.MenuDetalles.Count; 

            for (Int32 x = 0; x < menuServiceResponse.MenuDetalles.Count; x++)
            {
                IDMenu = menuServiceResponse.MenuDetalles[x].Id_MenuD; 
                IDPadre = menuServiceResponse.MenuDetalles[x].Id_Padre;  
                if (IDMenu != IDPadre && IDPadre == IDPadreAnterior)
                {
                    RadMenuItem menuNewItem = new RadMenuItem();
                    menuNewItem.Text = menuServiceResponse.MenuDetalles[x].Descripcion; 
                    menuNewItem.Value = menuServiceResponse.MenuDetalles[x].Id_MenuD.ToString();
                    menuNewItem.NavigateUrl = menuServiceResponse.MenuDetalles[x].Url + "?cod=" + menuServiceResponse.MenuDetalles[x].Id_objeto;
                    menuNewItem.ImageUrl = menuServiceResponse.MenuDetalles[x].Url_foto;
            
                    menuItem.Items.Add(menuNewItem);
                }
            }
        }
    }
}
