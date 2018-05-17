using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lucky.Entity.Common.Application;


namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Descripción : se encargada de operar las transacciones a la tabla puntos de venta (PointOfSale).
    /// CreateBy: Ing. Mauricio Ortiz
    /// CreateDate: 28/05/2009
    /// Requerimiento:

    public class DPuntosDV
    {
        private Conexion oConn;
        public DPuntosDV()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion();
            oUserInterface = null;
        }

        /// <summary>
        /// Metodo para Registrar Puntos de venta
        /// Modificación : 25/08/2010 se elimina parametro string spdv_Code, fue pasado a la tabla 
        ///                PointOfSale_Client. se cambia nombre al store deacuerdo a las metricas 
        ///                establecidad [UP_WEB_REGISTERPDV] por [UP_WEBXPLORA_AD_REGISTRAR_PUNTOSDEVENTA]
        ///                Ing. Mauricio Ortiz
        /// </summary>
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
        /// <param name="spdvcodDepartment"></param>
        /// <param name="spdvcodProvince"></param>
        /// <param name="spdvcodDistrict"></param>
        /// <param name="spdvcodCommunity"></param>
        /// <param name="spdvAddress"></param>
        /// <param name="spdvemail"></param>
        /// <param name="spdvcodChannel"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <param name="iid_Segment"></param>
        /// <param name="bpdvstatus"></param>
        /// <param name="sPdvCreateBy"></param>
        /// <param name="tPdvDateBy"></param>
        /// <param name="sPdvModiBy"></param>
        /// <param name="tPdvDateModiBy"></param>
        /// <returns>oerPDV</returns>
        public EPuntosDV registrarPDVPK(string sid_typeDocument, string spdvRegTax,
            string spdvcontact1, string spdvposition1, string spdvcontact2, string spdvposition2, string spdvRazónSocial,
            string spdvName, string spdvPhone, string spdvAnexo, string spdvFax, string spdvcodCountry, string spdvcodDepartment,
            string spdvcodProvince, string spdvcodDistrict, string spdvcodCommunity, string spdvAddress, string spdvemail,
            string spdvcodChannel, int iidNodeComType, string sNodeCommercial, int iid_Segment, bool bpdvstatus, string sPdvCreateBy, DateTime tPdvDateBy,
            string sPdvModiBy, DateTime tPdvDateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTRAR_PUNTOSDEVENTA", sid_typeDocument, spdvRegTax,
             spdvcontact1, spdvposition1, spdvcontact2, spdvposition2, spdvRazónSocial,
             spdvName, spdvPhone, spdvAnexo, spdvFax, spdvcodCountry, spdvcodDepartment,
             spdvcodProvince, spdvcodDistrict, spdvcodCommunity, spdvAddress, spdvemail,
             spdvcodChannel, iidNodeComType, sNodeCommercial, iid_Segment,  bpdvstatus, sPdvCreateBy, tPdvDateBy,
             sPdvModiBy, tPdvDateModiBy);

            EPuntosDV oerPDV = new EPuntosDV();

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
            oerPDV.pdvcodDepartment = spdvcodDepartment;
            oerPDV.pdvcodProvince = spdvcodProvince;
            oerPDV.pdvcodDistrict = spdvcodDistrict;
            oerPDV.pdvcodCommunity = spdvcodCommunity;
            oerPDV.pdvAddress = spdvAddress;
            oerPDV.pdvemail = spdvemail;
            oerPDV.pdvcodChannel = spdvcodChannel;
            oerPDV.idNodeComType = iidNodeComType;
            oerPDV.NodeCommercial = sNodeCommercial;
            oerPDV.id_Segment = iid_Segment;
            oerPDV.pdvstatus = bpdvstatus;
            oerPDV.PdvCreateBy = sPdvCreateBy;
            oerPDV.PdvDateBy = tPdvDateBy;
            oerPDV.PdvModiBy = sPdvModiBy;
            oerPDV.PdvDateModiBy = tPdvDateModiBy;

            return oerPDV;
        }

        /// <summary>
        /// Metodo para Actualizar Puntos de venta Ing. Carlos Alberto hernandezstring spdv_Code,
        /// Modificación : 25/08/2010 se elimina parametro string spdv_Code, fue pasado a la tabla 
        ///                PointOfSale_Client. se cambia nombre al store deacuerdo a las metricas 
        ///                establecidad [UP_WEB_ACTUALIZAR_PDV] por [UP_WEBXPLORA_AD_ACTUALIZAR_PUNTODEVENTA]
        ///                Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iid_PointOfsale"></param>
        /// <param name="sid_typeDocument"></param>
        /// <param name="spdv_RegTax"></param>
        /// <param name="spdv_contact1"></param>
        /// <param name="spdv_position1"></param>
        /// <param name="spdv_contact2"></param>
        /// <param name="spdv_position2"></param>
        /// <param name="spdv_RazónSocial"></param>
        /// <param name="spdv_Name"></param>
        /// <param name="spdv_Phone"></param>
        /// <param name="spdv_Anexo"></param>
        /// <param name="spdv_Fax"></param>
        /// <param name="spdv_codCountry"></param>
        /// <param name="spdv_codDepartment"></param>
        /// <param name="spdv_codProvince"></param>
        /// <param name="spdv_codDistrict"></param>
        /// <param name="spdv_codCommunity"></param>
        /// <param name="spdv_Address"></param>
        /// <param name="spdv_email"></param>
        /// <param name="spdv_codChannel"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <param name="iid_Segment"></param>
        /// <param name="bpdv_status"></param>
        /// <param name="sPdv_ModiBy"></param>
        /// <param name="tPdv_DateModiBy"></param>
        /// <returns>oeaPDV</returns>
        public EPuntosDV Actualizar_PDV(int iid_PointOfsale, string sid_typeDocument, string spdv_RegTax,
            string spdv_contact1, string spdv_position1, string spdv_contact2, string spdv_position2, string spdv_RazónSocial,
            string spdv_Name, string spdv_Phone, string spdv_Anexo, string spdv_Fax, string spdv_codCountry,
            string spdv_codDepartment, string spdv_codProvince, string spdv_codDistrict, string spdv_codCommunity,
            string spdv_Address, string spdv_email, string spdv_codChannel, int iidNodeComType, string sNodeCommercial, int iid_Segment,
            bool bpdv_status, string sPdv_ModiBy, DateTime tPdv_DateModiBy)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAR_PUNTODEVENTA", iid_PointOfsale, sid_typeDocument, spdv_RegTax,
             spdv_contact1, spdv_position1, spdv_contact2, spdv_position2, spdv_RazónSocial, spdv_Name, spdv_Phone, spdv_Anexo, spdv_Fax, spdv_codCountry,
             spdv_codDepartment, spdv_codProvince, spdv_codDistrict, spdv_codCommunity, spdv_Address, spdv_email, spdv_codChannel, iidNodeComType, sNodeCommercial, iid_Segment,
             bpdv_status, sPdv_ModiBy, tPdv_DateModiBy);

            EPuntosDV oeaPDV = new EPuntosDV();

            oeaPDV.id_PointOfsale = iid_PointOfsale;
            oeaPDV.id_typeDocument = sid_typeDocument;
            oeaPDV.pdvRegTax = spdv_RegTax;
            oeaPDV.pdvcontact1 = spdv_contact1;
            oeaPDV.pdvposition1 = spdv_position1;
            oeaPDV.pdvcontact2 = spdv_contact2;
            oeaPDV.pdvposition2 = spdv_position2;
            oeaPDV.pdvRazónSocial = spdv_RazónSocial;
            oeaPDV.pdvName = spdv_Name;
            oeaPDV.pdvPhone = spdv_Phone;
            oeaPDV.pdvAnexo = spdv_Anexo;
            oeaPDV.pdvFax = spdv_Fax;
            oeaPDV.pdvcodCountry = spdv_codCountry;
            oeaPDV.pdvcodDepartment = spdv_codDepartment;
            oeaPDV.pdvcodProvince = spdv_codProvince;
            oeaPDV.pdvcodDistrict = spdv_codDistrict;
            oeaPDV.pdvcodCommunity = spdv_codCommunity;
            oeaPDV.pdvAddress = spdv_Address;
            oeaPDV.pdvemail = spdv_email;
            oeaPDV.pdvcodChannel = spdv_codChannel;
            oeaPDV.idNodeComType = iidNodeComType;
            oeaPDV.NodeCommercial = sNodeCommercial;
            oeaPDV.id_Segment = iid_Segment;
            oeaPDV.pdvstatus = bpdv_status;
            oeaPDV.PdvModiBy = sPdv_ModiBy;
            oeaPDV.PdvDateModiBy = tPdv_DateModiBy;

            return oeaPDV;
        }


        /// <summary>
        /// actualiza en planning campos modificados desde PDV
        /// 09/03/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iid_ClientPDV"></param>
        /// <param name="scod_City"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <returns></returns>
        public EPuntosDV Actualizar_NodoPlanningPDV(int iid_ClientPDV, string scod_City, int iidNodeComType, string sNodeCommercial)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARNODOPDVPLANNING", iid_ClientPDV, scod_City, iidNodeComType, sNodeCommercial);

            EPuntosDV oeaNodoPlaPDV = new EPuntosDV();
            

            oeaNodoPlaPDV.id_ClientPDV = iid_ClientPDV;
            oeaNodoPlaPDV.pdvcodProvince = scod_City;
            oeaNodoPlaPDV.idNodeComType = iidNodeComType;
            oeaNodoPlaPDV.NodeCommercial = sNodeCommercial;           


            return oeaNodoPlaPDV;
        }
       
        
        /// <summary>
        /// Método para consultar los puntos de venta
        /// Modificación : 25/08/2010 se quita campo  pdv_Code el cual fue cambiado para la tabla dbo.PointOfSale_Client. 
        ///                Se cambia nombre al store de acuerdo a las métricas establecidas [UP_WEB_SEARCHPDV] 
        ///                por [UP_WEBXPLORA_AD_BUSCAR_PUNTODEVENTA] Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="sPdvCodProvince"></param>
        /// <param name="sPdvRegTax"></param>
        /// <param name="sPdvName"></param>
        /// <returns>dt</returns>
        public DataTable ObtenerPDV(string sPdvCodProvince, string sPdvRegTax, string sPdvName, string sPdvChannel)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_BUSCAR_PUNTODEVENTA", sPdvCodProvince, sPdvRegTax, sPdvName, sPdvChannel);
            EPuntosDV oePdv = new EPuntosDV();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oePdv.id_PointOfsale = Convert.ToInt32(dt.Rows[i]["id_PointOfsale"].ToString().Trim());
                        oePdv.id_typeDocument = dt.Rows[i]["id_typeDocument"].ToString().Trim();
                        oePdv.pdvRegTax = dt.Rows[i]["pdv_RegTax"].ToString().Trim();
                        oePdv.pdvcontact1 = dt.Rows[i]["pdv_contact1"].ToString().Trim();
                        oePdv.pdvposition1 = dt.Rows[i]["pdv_position1"].ToString().Trim();
                        oePdv.pdvcontact2 = dt.Rows[i]["pdv_contact2"].ToString().Trim();
                        oePdv.pdvposition2 = dt.Rows[i]["pdv_position2"].ToString().Trim();
                        oePdv.pdvRazónSocial = dt.Rows[i]["pdv_RazónSocial"].ToString().Trim();
                        oePdv.pdvName = dt.Rows[i]["pdv_Name"].ToString().Trim();
                        oePdv.pdvPhone = dt.Rows[i]["pdv_Phone"].ToString().Trim();
                        oePdv.pdvAnexo = dt.Rows[i]["pdv_Anexo"].ToString().Trim();
                        oePdv.pdvFax = dt.Rows[i]["pdv_Fax"].ToString().Trim();
                        oePdv.pdvcodCountry = dt.Rows[i]["pdv_codCountry"].ToString().Trim();
                        oePdv.pdvcodDepartment = dt.Rows[i]["pdv_codDepartment"].ToString().Trim();
                        oePdv.pdvcodProvince = dt.Rows[i]["pdv_codProvince"].ToString().Trim();
                        oePdv.pdvcodDistrict = dt.Rows[i]["pdv_codDistrict"].ToString().Trim();
                        oePdv.pdvcodCommunity = dt.Rows[i]["pdv_codCommunity"].ToString().Trim();
                        oePdv.pdvAddress = dt.Rows[i]["pdv_Address"].ToString().Trim();
                        oePdv.pdvemail = dt.Rows[i]["pdv_email"].ToString().Trim();
                        oePdv.pdvcodChannel = dt.Rows[i]["pdv_codChannel"].ToString().Trim();
                        oePdv.idNodeComType = Convert.ToInt32(dt.Rows[i]["idNodeComType"].ToString().Trim());
                        oePdv.NodeCommercial = dt.Rows[i]["NodeCommercial"].ToString().Trim();
                        oePdv.id_Segment = Convert.ToInt32(dt.Rows[i]["id_Segment"].ToString().Trim());
                        oePdv.pdvstatus = Convert.ToBoolean(dt.Rows[i]["pdv_status"].ToString().Trim());
                        oePdv.PdvCreateBy = dt.Rows[i]["Pdv_CreateBy"].ToString().Trim();
                        oePdv.PdvDateBy = Convert.ToDateTime(dt.Rows[i]["Pdv_DateBy"].ToString().Trim());
                        oePdv.PdvModiBy = dt.Rows[i]["Pdv_ModiBy"].ToString().Trim();
                        oePdv.PdvDateModiBy = Convert.ToDateTime(dt.Rows[i]["Pdv_DateModiBy"].ToString().Trim());
                        
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// consulta cademas de la tabla intermedia
        /// 02/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sID_CADENA"></param>
        /// <returns></returns>
        public DataTable ObtenerCADENA(string sID_CADENA)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_OBTENENODECOMERCIALTMP", sID_CADENA);
            EPuntosDV oePdvtmp = new EPuntosDV();
            ENodeComercial oeNodetmp = new ENodeComercial();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {

                        //oePdvtmp.pdvcodChannel = dt.Rows[i]["pdv_codChannel"].ToString().Trim();
                        //oeNodetmp.NodeCommercial = Convert.ToInt32(dt.Rows[i]["NodeCommercial"].ToString().Trim());
                        //oeNodetmp.commercialNodeName = dt.Rows[i]["commercialNodeName"].ToString().Trim();
                        //oeNodetmp.NodeCommercialStatus = Convert.ToBoolean(dt.Rows[i]["NodeCommercialStatus"].ToString().Trim());
                      
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Actualiza cadena en tabla de cadena en BD intermedia
        /// 03/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="spdv_codChannel"></param>
        /// <param name="bpdv_status"></param>
        /// <param name="sNodeCommercial"></param>
        /// <returns></returns>
        public EPuntosDV Actualizar_Cadenatmp(string spdv_codChannel,  string sNodeCommercial)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARNODECOMERCIALTMP", spdv_codChannel, sNodeCommercial);
            EPuntosDV oeaCadenatmp = new EPuntosDV();

            ////oeaCadenatmp.pdvcodChannel = spdv_codChannel;

            return oeaCadenatmp;
        }
               
        /// <summary>
        /// Metodo para Registrar clientes de Punto de venta
        /// Módificación : 26/08/2010 se agrega parametro sClientPDV_Code y iid_sector. Ing. Mauricio Ortiz
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iid_PointOfsale"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="bClientPDV_Status"></param>
        /// <param name="sClientPDV_CreateBy"></param>
        /// <param name="tClientPDV_DateBy"></param>
        /// <param name="sClientPDV_ModiBy"></param>
        /// <param name="tClientPDV_DateModiBy"></param>
        /// <returns>oerPDV</returns>
        public EPuntosDV registrarClientPDVPK(int iCompany_id, int iid_PointOfsale, string sClientPDV_Code, int iid_sector, long lcod_Oficina, int iId_Dex, bool bClientPDV_Status,
            string sClientPDV_CreateBy, DateTime tClientPDV_DateBy, string sClientPDV_ModiBy, DateTime tClientPDV_DateModiBy, string pdv_alias)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_REGISTERPDVCLIENT", iCompany_id, iid_PointOfsale, sClientPDV_Code, iid_sector, lcod_Oficina, iId_Dex, bClientPDV_Status,
             sClientPDV_CreateBy, tClientPDV_DateBy, sClientPDV_ModiBy, tClientPDV_DateModiBy,pdv_alias);
            EPuntosDV oerPDV = new EPuntosDV();
            oerPDV.Company_id = iCompany_id;
            oerPDV.id_PointOfsale = iid_PointOfsale;
            oerPDV.ClientPDV_Code = sClientPDV_Code;
            oerPDV.id_sector = iid_sector;
            oerPDV.cod_Oficina = lcod_Oficina;
            oerPDV.Id_Dex = iId_Dex;
            oerPDV.ClientPDV_Status = bClientPDV_Status;
            oerPDV.ClientPDV_CreateBy = sClientPDV_CreateBy;
            oerPDV.ClientPDV_DateBy = tClientPDV_DateBy;
            oerPDV.ClientPDV_ModiBy = sClientPDV_ModiBy;
            oerPDV.ClientPDV_DateModiBy = tClientPDV_DateModiBy;
            return oerPDV;
        }
        /// <summary>
        /// INSERTA pdvCliente en BD intermedia
        /// 02/02/2011  Magaly Jiménez 
        /// </summary>
        /// <returns></returns>
        public EPuntosDV registrarClientPDVPKTMP()
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERPDVCLIENTTMP");
            EPuntosDV oerPDV = new EPuntosDV();
            //oerPDV.Company_id = iCompany_id;
            //oerPDV.id_PointOfsale = iid_PointOfsale;
            //oerPDV.ClientPDV_Code = sClientPDV_Code;
            //oerPDV.id_sector = iid_sector;
            //oerPDV.cod_Oficina = lcod_Oficina;
            //oerPDV.ClientPDV_Status = bClientPDV_Status;
            //oerPDV.ClientPDV_CreateBy = sClientPDV_CreateBy;
            //oerPDV.ClientPDV_DateBy = tClientPDV_DateBy;
            //oerPDV.ClientPDV_ModiBy = sClientPDV_ModiBy;
            //oerPDV.ClientPDV_DateModiBy = tClientPDV_DateModiBy;
            return oerPDV;
        }



        //Metodo para Consultar clientes de Punto de venta
        public DataTable ObtenerPDVClient(int iid_PointOfsale)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHPDVCLIENT", iid_PointOfsale);
            EPuntosDV oePdv = new EPuntosDV();
            ECompany oeCompany = new ECompany();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oePdv.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oeCompany.CompanyName = dt.Rows[i]["Company_Name"].ToString().Trim();
                        oePdv.ClientPDV_Status = Convert.ToBoolean(dt.Rows[i]["ClientPDV_Status"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Metodo para Consultar clientes de Punto de venta actual q se desea actualizar Ing. Mauricio Ortiz
        public DataTable ObtenerPDVClientActual(int iiCompany_id, int iid_PointOfsale)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_SEARCHCLIENTPDVACTUAL", iiCompany_id, iid_PointOfsale);
            EPuntosDV oePdv = new EPuntosDV();
            ECompany oeCompany = new ECompany();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oePdv.Company_id = Convert.ToInt32(dt.Rows[i]["Company_id"].ToString().Trim());
                        oePdv.id_PointOfsale = Convert.ToInt32(dt.Rows[i]["id_PointOfsale"].ToString().Trim());
                        oePdv.ClientPDV_Status = Convert.ToBoolean(dt.Rows[i]["ClientPDV_Status"].ToString().Trim());
                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        //Metodo para Actualizar Clientes Puntos de venta Ing. Mauricio Ortiz
        /// <summary>
        /// Modifica: se agregan 2 campos codigo y sector
        /// 21/09/2010 Magaly Jiménez
        /// Modificación: se agrega campo de cod_Oficina
        /// 12/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iid_PointOfsale"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="iid_sector"></param>
        /// <param name="bClientPDV_Status"></param>
        /// <param name="sClientPDV_ModiBy"></param>
        /// <param name="tClientPDV_DateModiBy"></param>
        /// <returns>oeaPDV</returns>
        public EPuntosDV Actualizar_PDVClient(int iCompany_id, int iid_PointOfsale, string sClientPDV_Code, int iid_sector, long lcod_Oficina, int iId_Dex, bool bClientPDV_Status, string sClientPDV_ModiBy, DateTime tClientPDV_DateModiBy, string pdv_alias)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEB_ACTUALIZAR_PDVCLIENT", iCompany_id, iid_PointOfsale, sClientPDV_Code, iid_sector, lcod_Oficina, iId_Dex, bClientPDV_Status, sClientPDV_ModiBy, tClientPDV_DateModiBy, pdv_alias);
            EPuntosDV oeaPDV = new EPuntosDV();

            oeaPDV.Company_id = iCompany_id;
            oeaPDV.id_PointOfsale = iid_PointOfsale;
            oeaPDV.ClientPDV_Code = sClientPDV_Code;
            oeaPDV.id_sector = iid_sector;
            oeaPDV.cod_Oficina = lcod_Oficina;
            oeaPDV.ClientPDV_Status = bClientPDV_Status;
            oeaPDV.ClientPDV_ModiBy = sClientPDV_ModiBy;
            oeaPDV.ClientPDV_DateModiBy = tClientPDV_DateModiBy;
            return oeaPDV;
        }

        /// <summary>
        /// actualiza tabla Pointsale_Planning desde PDV_Cliente.
        /// 09/03/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iid_ClientPDV"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="iid_malla"></param>
        /// <param name="iid_sector"></param>
        /// <returns></returns>
        public EPuntosDV Actualizar_PDVPlanningPDVClient(int iid_ClientPDV, long lcod_Oficina,  int iid_malla, int iid_sector, string pdv_contact)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZAPDVPLANNINGCONPDVCLIENTE", iid_ClientPDV, lcod_Oficina, iid_malla,  iid_sector, pdv_contact);
            EPuntosDV oeaPDV = new EPuntosDV();
            EMalla oeapdvm=new EMalla();

            oeaPDV.id_ClientPDV = iid_ClientPDV;
            oeaPDV.cod_Oficina = lcod_Oficina;
            oeapdvm.id_malla = iid_malla;
            oeaPDV.id_sector = iid_sector;          
          
            return oeaPDV;
        }
        /// <summary>
        /// Modificación: se agrega campo de cod_Oficina
        /// 12/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iiCompany_id"></param>
        /// <param name="spdv_codCountry"></param>
        /// <param name="spdv_codChannel"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <returns></returns>
        public DataTable ConsultarPDVClient(int iiCompany_id, string spdv_codCountry, string spdv_codChannel, int iidNodeComType, string sNodeCommercial)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_CONSULTARDVCLIENT", iiCompany_id, spdv_codCountry,  spdv_codChannel,  iidNodeComType,  sNodeCommercial);
            EPuntosDV oePdv = new EPuntosDV();
            //ESector oemalla=new ESector();
            EPuntosDV oepdvC=new EPuntosDV();
                      

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    //for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    //{
                    //    oePdv.id_ClientPDV = Convert.ToInt32(dt.Rows[i]["id_ClientPDV"].ToString().Trim());
                    //    oePdv.id_PointOfsale = Convert.ToInt32(dt.Rows[i]["id_PointOfsale"].ToString().Trim());
                    //    oePdv.ClientPDV_Code = dt.Rows[i]["ClientPDV_Code"].ToString().Trim();                
                    //    oePdv.id_sector = Convert.ToInt32(dt.Rows[i]["id_sector"].ToString().Trim());
                    //    oePdv.cod_Oficina = Convert.ToInt64(dt.Rows[i]["cod_Oficina"].ToString().Trim());
                    //    //oemalla.id_malla = Convert.ToInt32(dt.Rows[i]["id_malla"].ToString().Trim());
                    //    oePdv.ClientPDV_Status = Convert.ToBoolean(dt.Rows[i]["ClientPDV_Status"].ToString().Trim());
                    
                    //}
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// llena grilla
        /// 01/02/2011 Magaly Jimenez
        /// </summary>
        /// <param name="iiCompany_id"></param>
        /// <param name="spdv_codCountry"></param>
        /// <param name="spdv_codChannel"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <returns></returns>
        public DataTable ConsultarPDVClientGrilla(int iiCompany_id, string spdv_codCountry, string spdv_codChannel, int iidNodeComType, string sNodeCommercial)
        {
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_LLENACONSULAPDVCLIENTE", iiCompany_id, spdv_codCountry, spdv_codChannel, iidNodeComType, sNodeCommercial);
            EPuntosDV oePdv = new EPuntosDV();
     
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        //oePdv.id_ClientPDV = Convert.ToInt32(dt.Rows[i]["id_ClientPDV"].ToString().Trim());
                        //oePdv.id_PointOfsale = Convert.ToInt32(dt.Rows[i]["id_PointOfsale"].ToString().Trim());
                        //oePdv.ClientPDV_Code = dt.Rows[i]["ClientPDV_Code"].ToString().Trim();
                        //oePdv.id_sector = Convert.ToInt32(dt.Rows[i]["Sector"].ToString().Trim());
                        //oePdv.cod_Oficina = Convert.ToInt64(dt.Rows[i]["Name_Oficina"].ToString().Trim());
                        //oemalla.id_malla = Convert.ToInt32(dt.Rows[i]["id_malla"].ToString().Trim());
                        //oePdv.ClientPDV_Status = Convert.ToBoolean(dt.Rows[i]["ClientPDV_Status"].ToString().Trim());

                    }
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable obtener_pos_gis(string id_planning)
        {
            DataTable dt = new DataTable();
            dt = oConn.ejecutarDataTable("UP_XPLORAMAPS_OBTENER_PDV_PLANNING", id_planning);
            return dt;
        }
    }
}
        