using System;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Data.Common.Security;
using Lucky.Entity.Common.Application;
using Lucky.Business;
using Lucky.Entity.Common.Security;
using System.Collections.Generic;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase: Company
    /// CreateBy: Ing. Carlos Alberto Hernández Rincón
    /// DateBy: 05/05/2009
    /// Description: Establece los metodos para operar informacion relacionada con Clientes Lucky
    /// Requerimiento No:
    /// </summary>

    public class Company
    {
        public Company()
        {
            //Se define el constructor por defecto
        }

        public String message = "";

        public String getMessage() {
            return message;
        }

        public DataTable getCompanyCompetition() {
            Lucky.Data.Common.Application.DCompany odCompany = 
                new Lucky.Data.Common.Application.DCompany();

            DataTable dt = odCompany.getCompanyCompetition();
            
            if (!odCompany.getMessage().Equals("")) {
                message = odCompany.getMessage();
            }

            return dt;
        }

        public DataTable getCompanyCompetitionDummy() {
            // Crear el DataTable
            DataTable dt = new DataTable();
            try
            {
                // Crear las Columnas del DataTable
                dt.Columns.Add("company_id", typeof(int));
                dt.Columns.Add("company_name", typeof(string));
                //Llenar información
                dt.Rows.Add(1, "Competidora 01 S.A.C.");
                dt.Rows.Add(2, "Competidora 02 S.A.C.");
                dt.Rows.Add(3, "Competidora 03 S.A.C.");
                dt.Rows.Add(4, "Competidora 04 S.A.C.");
                dt.Rows.Add(5, "Competidora 05 S.A.C.");
            }
            catch (Exception ex)
            {
                message = "Ocurrio un Error: "
                    + ex.Message.ToString();
            }

            return dt;
        }

        /// <summary>
        ///Nombre Metodo: Register_Company
        ///Función: Permite el registro de Clientes Lucky
        /// </summary>
        /// se adiciona campo sCompany_Foto  21 de enero de 2010 Magaly jimenez
        public ECompany Register_Company(string iidtypeDocument, string sTypeCompany, string sCompanynd, string sCompanyName, string sCompanyEmail,
                string sCompanyPhone, string sCompanyAddres, string sCompany_Foto, string scodCountry, bool bCompanyStatus,
                 string sCompanyCreateBy, string sCompanyDate, string sCompanyModiBy, string sCompanyDateModiBy)
        {
            Lucky.Data.Common.Application.DCompany odCompany = new Lucky.Data.Common.Application.DCompany();
            ECompany oeCompany = odCompany.Register_Company(iidtypeDocument, sTypeCompany, sCompanynd, sCompanyName, sCompanyEmail, sCompanyPhone, sCompanyAddres, sCompany_Foto, scodCountry, bCompanyStatus,
                sCompanyCreateBy, sCompanyDate, sCompanyModiBy, sCompanyDateModiBy);
            odCompany = null;
            return oeCompany;

        }

        public DataTable Register_ClienteTMP(string sCompany_id, string sid_typeDocument, string sCompany_nd, string sCompany_Name, string sCompany_Addres,
        string scod_Country, string sCompany_Status)
        {
            DCompany oDCompany = new DCompany();
            DataTable dt = oDCompany.Register_ClienteTMP(sCompany_id, sid_typeDocument, sCompany_nd, sCompany_Name, sCompany_Addres,
            scod_Country, sCompany_Status);


            return dt;



        }


        public DataTable Register_ClienteTMP_Competencia(string sCompany_id, string sCompany_Name, string sCompany_Status)
        {
            DCompany oDCompany = new DCompany();

            DataTable dt = oDCompany.Register_ClienteTMP_Competencia(sCompany_id, sCompany_Name, sCompany_Status);


            return dt;



        }

        //---Metodo de Consulta de Compañias

        public DataTable BuscarCompañias(string scompanynd, string scompanyname, string scodcountry)
        {
            Lucky.Data.Common.Application.DCompany odscompañias = new Lucky.Data.Common.Application.DCompany();
            ECompany oecompañias = new ECompany();

            DataTable dtCompañias = odscompañias.ObtenerCompañias(scompanynd, scompanyname, scodcountry);
            odscompañias = null;

            return dtCompañias;

        }

        public List<ECompany> listarcompany()
        {
            List<ECompany> lista = new List<ECompany>();
            DCompany ocompany = new DCompany();            
            DataTable dt = ocompany.listarcompany();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ECompany ecompany = new ECompany();
                ecompany.Companyid = Convert.ToInt32(dt.Rows[i]["Company_id"]);
                ecompany.idtypeDocument = dt.Rows[i]["id_typeDocument"].ToString();
                ecompany.Type_Company = dt.Rows[i]["Type_Company"].ToString();
                ecompany.Companynd = dt.Rows[i]["Company_nd"].ToString();
                ecompany.CompanyName = dt.Rows[i]["Company_Name"].ToString();
                ecompany.CompanyEmail = dt.Rows[i]["Company_Email"].ToString();
                ecompany.CompanyPhone = dt.Rows[i]["Company_Phone"].ToString();
                ecompany.CompanyAddres = dt.Rows[i]["Company_Addres"].ToString();
                ecompany.Company_Foto = dt.Rows[i]["Company_Foto"].ToString();
                ecompany.codCountry = dt.Rows[i]["cod_Country"].ToString();
                ecompany.CompanyStatus = Convert.ToBoolean(dt.Rows[i]["Company_Status"]);
                ecompany.CompanyCreateBy = dt.Rows[i]["Company_CreateBy"].ToString();
                ecompany.CompanyDateBy = dt.Rows[i]["Company_DateBy"].ToString();
                ecompany.CompanyModiBy = dt.Rows[i]["Company_ModiBy"].ToString();
                ecompany.CompanyDateModiBy = dt.Rows[i]["Company_DateModiBy"].ToString();

                lista.Add(ecompany);
            }
            return lista;
        }
        /// <summary>
        ///Nombre Metodo: Actualizar_Company
        ///Función: Permite Actualizar de Clientes Lucky Ing. Carlos Alberto Hernandez
        /// </summary>
        /// se adiciona campo sCompany_Foto  21 de enero de 2010 Magaly jimenez
        public ECompany Actualizar_Company(int icompanyid, string iidtypeDocument, string sTypeCompany, string sCompanynd, string sCompanyName, string sCompanyEmail,
                string sCompanyPhone, string sCompanyAddres, string sCompany_Foto, string scodCountry, bool bCompanyStatus,
                  string sCompanyModiBy, string sCompanyDateModiBy)
        {
            Lucky.Data.Common.Application.DCompany odaCompany = new Lucky.Data.Common.Application.DCompany();
            ECompany oeCompany = odaCompany.Actualizar_Company(icompanyid, iidtypeDocument, sTypeCompany, sCompanynd, sCompanyName, sCompanyEmail, sCompanyPhone, sCompanyAddres, sCompany_Foto, scodCountry, bCompanyStatus,
                sCompanyModiBy, sCompanyDateModiBy);
            odaCompany = null;
            return oeCompany;
        }
    
        
    }
}

     
