using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DCompany
    /// CreateBy: Ing. Carlos Alberto Hernández Rincón
    /// DateBy: 05/05/2009
    /// Description: Estable ce los metodos para operar informacion relacionada con Clientes Lucky
    /// Requerimiento No:
    /// </summary>

    public class DCompany
    {

        private Conexion oConn;
        private String message = "";
        public DCompany()
        {

            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        public String getMessage() {
            return message;
        }

        /// <summary>
        ///Nombre Metodo: Register_Company
        ///Función: Permite el registro de Clientes Lucky
        /// </summary>

        /// se agreta parametro sCompany_Foto 21 de enero del 2011 Magaly Jiménez
        public ECompany Register_Company(string iidtypeDocument, string sTypeCompany, string sCompanynd, string sCompanyName, string sCompanyEmail,
            string sCompanyPhone, string sCompanyAddres, string sCompany_Foto, string scodCountry, bool bCompanyStatus,
             string sCompanyCreateBy, string sCompanyDate, string sCompanyModiBy, string sCompanyDateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTER_COMPANY", iidtypeDocument, sTypeCompany, sCompanynd, sCompanyName, sCompanyEmail, sCompanyPhone, sCompanyAddres, sCompany_Foto, scodCountry,
                 bCompanyStatus, sCompanyCreateBy, sCompanyDate, sCompanyModiBy, sCompanyDateModiBy);

            ECompany ocrcompany = new ECompany();

            ocrcompany.idtypeDocument = iidtypeDocument;
            ocrcompany.Companynd = sCompanynd;
            ocrcompany.Type_Company = sTypeCompany;
            ocrcompany.CompanyName = sCompanyName;
            ocrcompany.CompanyEmail = sCompanyEmail;
            ocrcompany.CompanyPhone = sCompanyPhone;
            ocrcompany.CompanyAddres = sCompanyAddres;
            ocrcompany.Company_Foto = sCompany_Foto;
            ocrcompany.codCountry = scodCountry;
            ocrcompany.CompanyStatus = bCompanyStatus;
            ocrcompany.CompanyCreateBy = sCompanyCreateBy;
            ocrcompany.CompanyDateBy = sCompanyDate;
            ocrcompany.CompanyModiBy = sCompanyModiBy;
            ocrcompany.CompanyDateModiBy = sCompanyDateModiBy;
            ocrcompany.Companyid=Convert.ToInt32(dt.Rows[0]["Company_id"].ToString());
            return ocrcompany;


        }



         public DataTable Register_ClienteTMP(string sCompany_id, string sid_typeDocument, string sCompany_nd, string sCompany_Name, string sCompany_Addres,
            string scod_Country, string sCompany_Status)
        {
            Conexion cn = new Conexion(2);

            DataTable dt = cn.ejecutarDataTable("UP_WEB_REGISTER_TBL_CLIENTE", sCompany_id,sid_typeDocument,sCompany_nd,sCompany_Name,sCompany_Addres,
            scod_Country,  sCompany_Status);


            return dt;
            


        }

       public DataTable Register_ClienteTMP_Competencia(string sCompany_id, string sCompany_Name, string sCompany_Status)
        {
            Conexion cn = new Conexion(2);

            DataTable dt = cn.ejecutarDataTable("UP_WEB_REGISTER_TBL_COMPETIDORA", sCompany_id, sCompany_Name, sCompany_Status);


            return dt;
            


        }
        

        



        //UP_XPLORAMAPS_OBTENER_LISTA_CLIENTES
        public DataTable listarcompany()
        {
            DataTable dt = oConn.ejecutarDataTable("UP_XPLORAMAPS_OBTENER_LISTA_CLIENTES");
            return dt;
        }

        /// <summary>
        ///Nombre Metodo: Search_Company
        ///Función: Permite Consultar  Clientes Lucky
        /// </summary>
        /// se agreta parametro sCompany_Foto 21 de enero del 2011 Magaly Jiménez
        public DataTable ObtenerCompañias(string scompanynd, string scompanyname, string scodcountry)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_COMPANY", scompanynd, scompanyname, scodcountry);
            ECompany oeCompany = new ECompany();

            if (dt != null)
            {

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oeCompany.Companyid = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeCompany.Type_Company = dt.Rows[i]["Type_Company"].ToString().Trim();
                        oeCompany.idtypeDocument = dt.Rows[i]["id_typeDocument"].ToString().Trim();
                        oeCompany.Companynd = dt.Rows[i]["Company_nd"].ToString().Trim();
                        oeCompany.CompanyName = dt.Rows[i]["Company_Name"].ToString().Trim();
                        oeCompany.CompanyEmail = dt.Rows[i]["Company_Email"].ToString().Trim();
                        oeCompany.CompanyPhone = dt.Rows[i]["Company_Phone"].ToString().Trim();
                        oeCompany.CompanyAddres = dt.Rows[i]["Company_Addres"].ToString().Trim();
                        oeCompany.Company_Foto = dt.Rows[i]["Company_Foto"].ToString().Trim();
                        oeCompany.codCountry = dt.Rows[i]["cod_Country"].ToString().Trim();
                        oeCompany.CompanyStatus = Convert.ToBoolean(dt.Rows[i]["Company_Status"].ToString().Trim());
                        oeCompany.CompanyCreateBy = dt.Rows[i]["Company_CreateBy"].ToString().Trim();
                        oeCompany.CompanyDateBy = dt.Rows[i]["Company_DateBy"].ToString().Trim();
                        oeCompany.CompanyModiBy = dt.Rows[i]["Company_ModiBy"].ToString().Trim();
                        oeCompany.CompanyDateModiBy = dt.Rows[i]["Company_DateModiBy"].ToString().Trim();
                    }
                }

                return dt;
            }

            else
            {
                return null;
            }
        }
        //Metodo para Actualizar compañia

        /// se agreta parametro sCompany_Foto 21 de enero del 2011 Magaly Jiménez
        public ECompany Actualizar_Company(int icomapnyid, string iidtypeDocument, string sTypeCompany, string sCompanynd, string sCompanyName, string sCompanyEmail,
       string sCompanyPhone, string sCompanyAddres, string sCompany_Foto, string scodCountry, bool bCompanyStatus,
         string sCompanyModiBy, string sCompanyDateModiBy)
        {

            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_COMPANY", icomapnyid, iidtypeDocument, sTypeCompany, sCompanynd, sCompanyName, sCompanyEmail, sCompanyPhone, sCompanyAddres, sCompany_Foto, scodCountry,
                 bCompanyStatus, sCompanyModiBy, sCompanyDateModiBy);

            ECompany ocacompany = new ECompany();
            ocacompany.Companyid = icomapnyid;
            ocacompany.idtypeDocument = iidtypeDocument;
            ocacompany.Companynd = sCompanynd;
            ocacompany.Type_Company = sTypeCompany;
            ocacompany.CompanyName = sCompanyName;
            ocacompany.CompanyEmail = sCompanyEmail;
            ocacompany.CompanyPhone = sCompanyPhone;
            ocacompany.CompanyAddres = sCompanyAddres;
            ocacompany.Company_Foto = sCompany_Foto;
            ocacompany.codCountry = scodCountry;
            ocacompany.CompanyStatus = bCompanyStatus;
            ocacompany.CompanyModiBy = sCompanyModiBy;
            ocacompany.CompanyDateModiBy = sCompanyDateModiBy;
            return ocacompany;
        }


        public DataTable getCompanyCompetition()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = oConn.ejecutarDataTable(
                    "UP_WEB_SIGE_OBTENER_CLIENTES");
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message.ToString();
            }
            return dt;
        }
    }
}


       
