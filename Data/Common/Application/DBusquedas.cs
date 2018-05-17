using System;
using System.Data;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{


     public class DBusquedas
    {
         private Conexion oConn;
         public DBusquedas() {

             UserInterface oUserInterface = new UserInterface();
             oConn = new Conexion();
             oUserInterface = null;
         
        }

         public DataTable Search_User(string sPersonnd, string sPeersonFirsname, string sNameUser) {

             DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_USER", sPersonnd, sPeersonFirsname, sNameUser);
             if (dt.Rows.Count > 0) {

                 for (int i = 0; i <= dt.Rows.Count - 1; i++)
                 {
                     EUsuario osUsuario = new EUsuario();
                     osUsuario.Personnd = sPersonnd;
                     osUsuario.PersonFirtsname = sPeersonFirsname;
                     osUsuario.nameuser = sNameUser;
                     //osUsuario.Personid = osUsuario.Personid;
                     osUsuario.Personid = Convert.ToInt32(dt.Rows[i]["Person_id"].ToString().Trim());
                     osUsuario.idtypeDocument = dt.Rows[i]["id_typeDocument"].ToString().Trim();
                     osUsuario.Personnd = dt.Rows[i]["Person_nd"].ToString().Trim();
                     osUsuario.PersonFirtsname = dt.Rows[i]["Person_Firtsname"].ToString().Trim();
                     osUsuario.PersonLastName = dt.Rows[i]["Person_LastName"].ToString().Trim();
                     osUsuario.PersonSurname = dt.Rows[i]["Person_Surname"].ToString().Trim();
                     osUsuario.PersonSeconName = dt.Rows[i]["Person_SeconName"].ToString().Trim();
                     osUsuario.PersonEmail = dt.Rows[i]["Person_Email"].ToString().Trim();
                     osUsuario.PersonPhone = dt.Rows[i]["Person_Phone"].ToString().Trim();
                     osUsuario.PersonAddres = dt.Rows[i]["Person_Addres"].ToString().Trim();
                     osUsuario.codCountry = dt.Rows[i]["cod_Country"].ToString().Trim();
                     osUsuario.nameuser = dt.Rows[i]["name_user"].ToString().Trim();
                     osUsuario.UserPassword = dt.Rows[i]["User_Password"].ToString().Trim();
                     osUsuario.Perfilid = dt.Rows[i]["Perfil_id"].ToString().Trim();
                     osUsuario.Moduloid = dt.Rows[i]["Modulo_id"].ToString().Trim();
                     osUsuario.UserRecall = dt.Rows[i]["User_Recall"].ToString().Trim();
                     osUsuario.companyid = dt.Rows[i]["Company_id"].ToString().Trim();
                     osUsuario.PersonStatus = Convert.ToBoolean(dt.Rows[i]["Person_Status"].ToString().Trim());

                     

                 }
                 return dt;

             
             
             
              }
             else
                {
                    return null;
                }
         
         
         
         
         }


    }
}
