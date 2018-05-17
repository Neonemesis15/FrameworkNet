using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Application.Interfaces;

namespace Lucky.Data.Common.Application
{ 
    /// <summary>
    /// Clase: Aplicacion
    /// Creada Por: Ing. Carlos Alberto Hernandez R.
    /// Fecha de Creaciòn: 29/04/2009
    /// Descripcion: Ddefine metodos transaccionales para Aplicacion
    /// Requerimiento No: <>
    /// 
    /// </summary>
    public class DAplicacion
    {
        private Conexion oConn;
        public DAplicacion()
        {
            UserInterface oUserInterface = new UserInterface();
            oConn = new Conexion(1);
            oUserInterface = null;
        }
        public EAplicacion obtenerPK(String sCountry, String smodul)
        {
            DataSet ds = oConn.ejecutarDataSet("UP_GEN_OBTENER_DATOS_SISTEMA", sCountry, smodul);
            if (ds.Tables[0] != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    EAplicacion oeAplicacion = new EAplicacion();
                    oeAplicacion.codapplucky = ds.Tables[0].Rows[0]["cod_applucky"].ToString().Trim();
                    oeAplicacion.nameapp = ds.Tables[0].Rows[0]["name_app"].ToString().Trim();
                    oeAplicacion.verapp = ds.Tables[0].Rows[0]["ver_app"].ToString().Trim();
                    oeAplicacion.abrapp = ds.Tables[0].Rows[0]["abr_app"].ToString().Trim();
                    oeAplicacion.appStatus = Convert.ToBoolean(ds.Tables[0].Rows[0]["app_Status"].ToString().Trim());
                    oeAplicacion.appurl = ds.Tables[0].Rows[0]["app_url"].ToString().Trim();
                    oeAplicacion.appCreateBy = ds.Tables[0].Rows[0]["app_CreateBy"].ToString().Trim();
                    oeAplicacion.appDateBy = ds.Tables[0].Rows[0]["app_DateBy"].ToString().Trim();
                    oeAplicacion.appModiBy = ds.Tables[0].Rows[0]["app_ModiBy"].ToString().Trim();
                    oeAplicacion.appDateModiBy = ds.Tables[0].Rows[0]["app_DateModiBy"].ToString().Trim();

                    return oeAplicacion;
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


        /// <summary>
        /// Metodo para controlar la no duplicidad de campos mandatorios y que no hacen parte de la Primary Key de las Entity
        /// Creado por: Ing. Carlos Alberto Hernandez
        /// 09/06/2009
        /// 
        /// </summary>
        /// <param name="sTabla"></param>
        /// <param name="scampo"></param>
        /// <returns></returns>
        public DataTable ConsultaDuplicados(string sTabla, string scampo, string scampo1, string scampo2)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                ///Add 03/09/2012 PSalas
                #region Tipo_Perfil
                case "Tipo_Profiles":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        //EAD_Corporacion oEAD_Corporacion = new EAD_Corporacion();
                        E_TipoProfiles oE_TipoProfiles = new E_TipoProfiles();
                        if (dt.Rows.Count > 0)
                        {
                            //oE_TipoProfiles.TipPerfil_id = dt.Rows[0]["TipPerfil_id"].ToString().Trim();
                            //oE_TipoProfiles.TipPerfil_Descripcion = dt.Rows[0]["TipPerfil_Descripcion"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {

                        return null;

                    }
                    break;
                #endregion
                #region AD_Corporacion
                case "AD_Corporacion":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Corporacion oEAD_Corporacion = new EAD_Corporacion();
                        if (dt.Rows.Count > 0)
                        {
                            oEAD_Corporacion.corp_name = dt.Rows[0]["corp_name"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {

                        return null;

                    }
                    break;
                #endregion
                #region Roles
                case "Roles":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ERoles oeduroles = new ERoles();
                        if (dt.Rows.Count > 0)
                        {
                            oeduroles.RolName = dt.Rows[0]["Rol_Name"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {

                        return null;

                    }
                    break;
                #endregion
                #region Person Level
                case "Person_Level":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPersonLevel oeduNiveles = new EPersonLevel();
                        if (dt.Rows.Count > 0)
                        {
                            oeduNiveles.Level_Description = dt.Rows[0]["Level_Description"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Profiles
                case "Profiles":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {

                        EProfiles oeduprofile = new EProfiles();


                        if (dt.Rows.Count > 0)
                        {
                            oeduprofile.PerfilName = dt.Rows[0]["Perfil_Name"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Person
                case "Person":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EUsuario oeduperson = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {
                            oeduperson.Personnd = dt.Rows[0]["Person_nd"].ToString().Trim();                                          
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Person Name
                case "Person_name":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EUsuario oeduperson = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {
             
                            oeduperson.nameuser = dt.Rows[0]["name_user"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Person Movil
                case "personmovil":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EUsuario oeduperson = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {
                            oeduperson.Personnd = dt.Rows[0]["Person_nd"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Company
                case "Company":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECompany oedcompany = new ECompany();
                        if (dt.Rows.Count > 0)
                        {
                            oedcompany.Companynd = dt.Rows[0]["Company_nd"].ToString().Trim();
                            oedcompany.CompanyName = dt.Rows[0]["Company_Name"].ToString().Trim();

                            return dt;
                        }


                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Strategies
                case "Strategies":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EEstrategy oedustrategy = new EEstrategy();

                        if (dt.Rows.Count > 0)
                        {
                            oedustrategy.StrategyName = dt.Rows[0]["Strategy_Name"].ToString().Trim();
                            oedustrategy.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Strategit_Point
                case "Strategit_Points":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EStrategit_Points odustratpoint = new EStrategit_Points();


                        if (dt.Rows.Count > 0)
                        {
                            odustratpoint.DescriptionPoint = dt.Rows[0]["Description_Point"].ToString().Trim();
                            odustratpoint.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            odustratpoint.company_id = Convert.ToInt32(dt.Rows[0]["company_id"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Item_Points
                case "Item_Points":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EItemsPoint oduitempoint = new EItemsPoint();


                        if (dt.Rows.Count > 0)
                        {
                            oduitempoint.id_cod_point = Convert.ToInt32(dt.Rows[0]["id_cod_point"].ToString().Trim());
                            oduitempoint.Description_Point = dt.Rows[0]["Item_Description"].ToString().Trim();
                            oduitempoint.id_Ubicación = Convert.ToInt32(dt.Rows[0]["id_Ubicación"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region MPointOfPurchase

                case "MPointOfPurchase":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EMPop oedumpop = new EMPop();



                        if (dt.Rows.Count > 0)
                        {
                            oedumpop.POPname = dt.Rows[0]["POP_name"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Segments_Type
                case "Segments_Type":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESegments_Type oedSegmentsType = new ESegments_Type();

                        if (dt.Rows.Count > 0)
                        {
                            oedSegmentsType.Segment_Type = dt.Rows[0]["Segment_Name"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                #endregion
                #region Segments
                case "Segments":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESegments oedSegments = new ESegments();

                        if (dt.Rows.Count > 0)
                        {
                            oedSegments.Segment_Name = dt.Rows[0]["Segment_Name"].ToString().Trim();
                            oedSegments.id_SegmentsType = Convert.ToInt32(dt.Rows[0]["id_SegmentsType"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region PointOfSale
                //Modificación:  25/08/2010 Se quita el pdvcode ya no existe en la tabla. Ing. Mauricio Ortiz 
                case "PointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPuntosDV oedpdv = new EPuntosDV();

                        if (dt.Rows.Count > 0)
                        {                           
                            oedpdv.pdvName = dt.Rows[0]["pdv_Name"].ToString().Trim();
                            oedpdv.pdvAddress = dt.Rows[0]["pdv_Address"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region PointOfSaleDoc
                case "PointOfSaleDoc":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPuntosDV oedpdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedpdv.pdvRegTax = dt.Rows[0]["pdv_RegTax"].ToString().Trim();
                            oedpdv.pdvRazónSocial = dt.Rows[0]["pdv_RazónSocial"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region PointOfSale_Client
                case "PointOfSale_Client":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPuntosDV oedCliePDV = new EPuntosDV();

                        if (dt.Rows.Count > 0)
                        {
                            oedCliePDV.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oedCliePDV.id_PointOfsale = Convert.ToInt32(dt.Rows[0]["id_PointOfsale"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Channel
                case "Channel":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECanales oedcanales = new ECanales();



                        if (dt.Rows.Count > 0)
                        {
                            
                            ///Modificación: se agrega parametro Company_id para no repetir junto con nombre de canal. 20/10/2010 Magaly Jiménez
                            oedcanales.ChannelName = dt.Rows[0]["Channel_Name"].ToString().Trim();
                            oedcanales.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region ProductCategory
                /// Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
                /// 18/08/2010 Magaly Jiménez
                case "ProductCategory":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProduct_Type oeduproductcategory = new EProduct_Type();
                        if (dt.Rows.Count > 0)
                        {
                            oeduproductcategory.Product_Category = dt.Rows[0]["Product_Category"].ToString().Trim();
                              return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Product_Tipo
                case "Product_Tipo":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProduct_Tipo oeduproducttipo = new EProduct_Tipo();
                        if (dt.Rows.Count > 0)
                        {
                            oeduproducttipo.Product_Tipo = dt.Rows[0]["Product_Tipo"].ToString().Trim();
                            oeduproducttipo.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Brand
                ///Se adiciona parametro id_ProductCategory para duplciado. 01/12/2010  Magaly Jiménez
                case "Brand":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBrand oeduBrand = new EBrand();
                        if (dt.Rows.Count > 0)
                        {
                            oeduBrand.Name_Brand = dt.Rows[0]["Name_Brand"].ToString().Trim();
                            oeduBrand.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oeduBrand.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Oficina
                case "AD_Oficina":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Oficina oeduOficina = new EAD_Oficina();
                        
                        if (dt.Rows.Count > 0)
                        {
                            oeduOficina.Name_Oficina = dt.Rows[0]["Name_Oficina"].ToString().Trim();
                            oeduOficina.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region SubBrand
                case "SubBrand":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESubBrand oeduSubBrand = new ESubBrand();
                        if (dt.Rows.Count > 0)
                        {
                            oeduSubBrand.Name_SubBrand = dt.Rows[0]["Name_SubBrand"].ToString().Trim();
                            oeduSubBrand.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Sector
                case "Sector":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESector oeduSector = new ESector();
                     if (dt.Rows.Count > 0)
                        {
                            oeduSector.Sector = dt.Rows[0]["Sector"].ToString().Trim();
                            oeduSector.id_malla = Convert.ToInt32(dt.Rows[0]["id_malla"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region ProductPresentation
                case "Product_Presentations":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, Convert.ToDecimal(scampo1), scampo2);
                    if (dt != null)
                    {
                        EProduct_Presentations oeduPresen = new EProduct_Presentations();
                        if (dt.Rows.Count > 0)
                        {
                            oeduPresen.ProductPresentationName = dt.Rows[0]["ProductPresentationName"].ToString().Trim();
                            oeduPresen.ProductPresentation_Neto = Convert.ToDecimal(dt.Rows[0]["ProductPresentation_Neto"].ToString().Trim());
                            oeduPresen.id_UnitOfMeasure = Convert.ToInt32(dt.Rows[0]["id_UnitOfMeasure"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Products
                case "Products":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProductos oeduproduct = new EProductos();



                        if (dt.Rows.Count > 0)
                        {
                            oeduproduct.Product_Name = dt.Rows[0]["Product_Name"].ToString().Trim();
                            oeduproduct.cod_Product = dt.Rows[0]["cod_Product"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region ProductFamily
                ///se crea metodo para verificar duplicados en maestro de familia de producto. 19/10/2010 Magaly Jiménez
                case "ProductFamily":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProduct_Family oedProduFamily = new EProduct_Family();
                      
                        
                        if (dt.Rows.Count > 0)
                        {
                            oedProduFamily.id_ProductFamily = dt.Rows[0]["id_ProductFamily"].ToString().Trim();
                            oedProduFamily.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            oedProduFamily.name_Family = dt.Rows[0]["name_Family"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region City_UserRepor
                case "City_UserRepor":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECity_UserReport oeduCityUR = new ECity_UserReport();
                                           
                        
                        if (dt.Rows.Count > 0)
                        {
                            oeduCityUR.id_userinforme = Convert.ToInt32(dt.Rows[0]["id_userinforme"].ToString().Trim());
                            oeduCityUR.cod_Oficina =Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim());


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region AD_ReportOficina
                case "AD_ReportOficina":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Report_Oficina oedupRO = new EAD_Report_Oficina();
                        


                        if (dt.Rows.Count > 0)
                        {
                            oedupRO.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedupRO.cod_Oficina = Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim());


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region ProductEAN
                case "ProductsEAN":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProductos oeduproduct = new EProductos();
                        if (dt.Rows.Count > 0)
                        {
                            oeduproduct.Product_CodeEAN = dt.Rows[0]["Product_CodeEAN"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                //case "Reports":
                //    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                //    if (dt != null)
                //    {
                //        EReports oedureport = new EReports();
                //        if (dt.Rows.Count > 0)
                //        {
                //            oedureport.ReportNameReport = dt.Rows[0]["Report_NameReport"].ToString().Trim();
                //            return dt;
                //        }
                //    }
                //    else
                //    {
                //        return null;

                //    }
                //    break;

                #region Reports_TypeReport
                case "Reports_TypeReport":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports oedureportModulos = new EReports();
                        if (dt.Rows.Count > 0)
                        {
                            oedureportModulos.reportId = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedureportModulos.idTypeReport = Convert.ToInt32(dt.Rows[0]["id_TypeReport"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Reports_Modulo
                case "Reports_Modulo":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports oedureportModulos = new EReports();
                        if (dt.Rows.Count > 0)
                        {
                            oedureportModulos.reportId = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedureportModulos.moduloid = dt.Rows[0]["Modulo_id"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Reports_Strategit
                case "Reports_Strategit":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReportsStrategit oedurstrategy = new EReportsStrategit();




                        if (dt.Rows.Count > 0)
                        {
                            oedurstrategy.Report_id = Convert.ToInt32(dt.Rows[0]["Report_id"].ToString().Trim());


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Reports
                case "Reports":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports oedureports = new EReports();




                        if (dt.Rows.Count > 0)
                        {
                            oedureports.ReportNameReport = dt.Rows[0]["Report_NameReport"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region ReportsChannel
                case "ReportChannel":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReportChannel oedReCanal = new EReportChannel();

                        if (dt.Rows.Count > 0)
                        {
                            oedReCanal.Report_id = Convert.ToInt32((dt.Rows[0]["Report_id"].ToString().Trim()));
                            oedReCanal.Company_id = Convert.ToInt32((dt.Rows[0]["Company_id"].ToString().Trim()));
                            oedReCanal.cod_Channel = (dt.Rows[0]["cod_Channel"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Country
                case "Country":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECountry oedcountry = new ECountry();




                        if (dt.Rows.Count > 0)
                        {
                            oedcountry.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            oedcountry.NameCountry = dt.Rows[0]["Name_Country"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Department

                case "Departament":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDepartamento oeddpto = new EDepartamento();
                        if (dt.Rows.Count > 0)
                        {
                            oeddpto.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            oeddpto.Namedpto = dt.Rows[0]["Name_dpto"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region CityCountry
                case "CityCountry":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECity oedcity = new ECity();

                        if (dt.Rows.Count > 0)
                        {
                            oedcity.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            oedcity.NameCity = dt.Rows[0]["Name_City"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region CityDpto
                case "CityDto":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECity oedcity = new ECity();

                        if (dt.Rows.Count > 0)
                        {
                            oedcity.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            oedcity.NameCity = dt.Rows[0]["Name_City"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region DistrictCity
                case "DistrictCity":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDistrito oeddistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oeddistrito.codCity = dt.Rows[0]["cod_City"].ToString().Trim();
                            oeddistrito.NameLocal = dt.Rows[0]["Name_Local"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region DistrictCountry
                case "DistrictCountry":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDistrito oeddistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oeddistrito.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            oeddistrito.NameLocal = dt.Rows[0]["Name_Local"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region District Dpto
                case "DistrictDepto":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDistrito oeddistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oeddistrito.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            oeddistrito.NameLocal = dt.Rows[0]["Name_Local"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region CommunityCountry
                case "CommunityCountry":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region CommunityDpto
                case "CommunityDpto":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region CommunityCity
                case "CommunityCity":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.codcity = dt.Rows[0]["cod_city"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region CommunityDistrict
                case "CommunityDistrict":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.codDistrict = dt.Rows[0]["cod_District"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region MarketChain
                case "MarketChain":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECadenas oedCadenas = new ECadenas();



                        if (dt.Rows.Count > 0)
                        {
                            oedCadenas.MarketChainname = dt.Rows[0]["MarketChain_name"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Indicadores
                case "Indicadores":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EIndicadores oedindicadores = new EIndicadores();





                        if (dt.Rows.Count > 0)
                        {
                            oedindicadores.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_strategy"].ToString().Trim());
                            oedindicadores.nameindicador = (dt.Rows[0]["name_indicador"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region NodeComercial_Type
                case "NodeComercial_Type":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ENodeType oedNodetype = new ENodeType();



                        if (dt.Rows.Count > 0)
                        {
                            oedNodetype.lNodeComTypename = (dt.Rows[0]["NodeComType_name"].ToString().Trim());

                            return dt;
                        }
                    }
                    


                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Distribuidora
                /// duplicados maestro distribuidoras 01/04/2011 Magaly jiménez.
                case "Distribuidora":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Distribuidora oeddex = new EAD_Distribuidora();



                        if (dt.Rows.Count > 0)
                        {
                            oeddex.lDex_Name = (dt.Rows[0]["Dex_Name"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region NodeCommercial
                case "NodeCommercial":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ENodeComercial oednode = new ENodeComercial();
                        if (dt.Rows.Count > 0)
                        {
                            oednode.commercialNodeName = (dt.Rows[0]["commercialNodeName"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                #endregion
                #region Staff_Planning
                case "Staff_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EStaff_Planning oeStaffPlanning = new EStaff_Planning();
                       
                        if (dt.Rows.Count > 0)
                        {
                            oeStaffPlanning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeStaffPlanning.Person_id = Convert.ToInt32(dt.Rows[0]["Person_id"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Reports_Planning
                case "Reports_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports_Planning oeReports_Planning = new EReports_Planning();                       

                        if (dt.Rows.Count > 0)
                        {
                            oeReports_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeReports_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oeReports_Planning.id_Month = dt.Rows[0]["id_Month"].ToString().Trim();                           
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Mallas
                case "Mallas":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EMalla oeduMalla = new EMalla();
                       
                        if (dt.Rows.Count > 0)
                        {
                            oeduMalla.Company_id = Convert.ToInt32( dt.Rows[0]["Company_id"].ToString().Trim());
                            oeduMalla.malla = dt.Rows[0]["malla"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region Product_planning
                case "Product_planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProducts_Planning oeProductplanning = new EProducts_Planning();
                        
                        if (dt.Rows.Count > 0)
                        {
                            oeProductplanning.id_planning =dt.Rows[0]["id_planning"].ToString().Trim();
                            oeProductplanning.id_Product = Convert.ToInt64(dt.Rows[0]["id_Product"].ToString().Trim());
                          
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region PLA_Brand_Planning
                /// se agrega metodo para verificar duplicados del tabla PLA_Brand_Planning
                /// 26/02/2011 Ing. Mauricio Ortiz
                case "PLA_Brand_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPLA_Brand_Planning oeEPLA_Brand_Planning = new EPLA_Brand_Planning();
                        
                        if (dt.Rows.Count > 0)
                        {
                            oeEPLA_Brand_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeEPLA_Brand_Planning.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region PLA_Panel_Planning
                /// se agrega metodo para verificar duplicados del tabla PLA_Panel_Planning
                /// 03/03/2011 Ing. Mauricio Ortiz
                case "PLA_Panel_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPLA_Panel_Planning oeEPLA_Panel_Planning = new EPLA_Panel_Planning();

                        if (dt.Rows.Count > 0)
                        {
                            oeEPLA_Panel_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeEPLA_Panel_Planning.id_MPOSPlanning = Convert.ToInt32(dt.Rows[0]["id_MPOSPlanning"].ToString().Trim());
                            oeEPLA_Panel_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                          
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region PLA_Family_Planning
                /// se agrega metodo para verificar duplicados del tabla PLA_Family_Planning
                /// 22/03/2011 Ing. Mauricio Ortiz
                case "PLA_Family_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPLA_Family_Planning oeEPLA_Family_Planning = new EPLA_Family_Planning();
                        if (dt.Rows.Count > 0)
                        {
                            oeEPLA_Family_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeEPLA_Family_Planning.id_ProductFamily =dt.Rows[0]["id_ProductFamily"].ToString().Trim();
                            oeEPLA_Family_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                #endregion
                #region AD_ProductosAncla
                /// se agrega metodo para verificar duplicados del maestro productos ancla
                    /// 07/09/2010 Magaly Jimenez
                case "AD_ProductosAncla":
                    dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_SEARCH_DUPLICAPANCLA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_ProductosAncla oeproducAncla = new EAD_ProductosAncla();
                            
                        if (dt.Rows.Count > 0)
                        {
                            oeproducAncla.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oeproducAncla.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            oeproducAncla.id_Subcategory = Convert.ToInt64(dt.Rows[0]["id_Subcategory"].ToString().Trim());
                            oeproducAncla.cod_Oficina = Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim()); 

                            return dt;
                        }
                    }
                    else 
                    {
                        return null;
                    }
                    break;
                #endregion
            }

            //destruyye el dt si no encuentra nada para liberar recuersos 
            return dt = null;







        }

        /// <summary>
        /// Se Crea Este Metodo Provisional para agregar un atributo mas para evaluar Duplicidad
        /// Creado Por: Ing. Carlos Alberto Hernández R.
        /// Fecha:02/08/2011
        /// </summary>
        /// <param name="sTabla"></param>
        /// <param name="scampo"></param>
        /// <param name="scampo1"></param>
        /// <param name="scampo2"></param>
        /// <param name="scampo3"></param>
        /// <returns></returns>

        public DataTable ConsultaDuplicadosNew(string sTabla, string scampo, string scampo1, string scampo2, string scampo3)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                case "Roles":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA_NEW", sTabla, scampo, scampo1, scampo2,scampo3);
                    if (dt != null)
                    {
                        ERoles oeduroles = new ERoles();
                        if (dt.Rows.Count > 0)
                        {
                            oeduroles.RolName = dt.Rows[0]["Rol_Name"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {

                        return null;

                    }
                    break;
                case "Person_Level":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA_NEW", sTabla, scampo, scampo1, scampo2,scampo3);
                    if (dt != null)
                    {
                        EPersonLevel oeduNiveles = new EPersonLevel();
                        if (dt.Rows.Count > 0)
                        {
                            oeduNiveles.Level_Description = dt.Rows[0]["Level_Description"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "Profiles":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA_NEW", sTabla, scampo, scampo1, scampo2,scampo3);
                    if (dt != null)
                    {

                        EProfiles oeduprofile = new EProfiles();


                        if (dt.Rows.Count > 0)
                        {
                            oeduprofile.PerfilName = dt.Rows[0]["Perfil_Name"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Person":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA_NEW", sTabla, scampo, scampo1, scampo2,scampo3);
                    if (dt != null)
                    {
                        EUsuario oeduperson = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {
                            oeduperson.Personnd = dt.Rows[0]["Person_nd"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                case "Person_name":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EUsuario oeduperson = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {

                            oeduperson.nameuser = dt.Rows[0]["name_user"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "personmovil":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EUsuario oeduperson = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {
                            oeduperson.Personnd = dt.Rows[0]["Person_nd"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Company":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECompany oedcompany = new ECompany();
                        if (dt.Rows.Count > 0)
                        {
                            oedcompany.Companynd = dt.Rows[0]["Company_nd"].ToString().Trim();
                            oedcompany.CompanyName = dt.Rows[0]["Company_Name"].ToString().Trim();

                            return dt;
                        }


                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Strategies":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EEstrategy oedustrategy = new EEstrategy();

                        if (dt.Rows.Count > 0)
                        {
                            oedustrategy.StrategyName = dt.Rows[0]["Strategy_Name"].ToString().Trim();
                            oedustrategy.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Strategit_Points":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EStrategit_Points odustratpoint = new EStrategit_Points();


                        if (dt.Rows.Count > 0)
                        {
                            odustratpoint.DescriptionPoint = dt.Rows[0]["Description_Point"].ToString().Trim();
                            odustratpoint.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            odustratpoint.company_id = Convert.ToInt32(dt.Rows[0]["company_id"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Item_Points":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EItemsPoint oduitempoint = new EItemsPoint();


                        if (dt.Rows.Count > 0)
                        {
                            oduitempoint.id_cod_point = Convert.ToInt32(dt.Rows[0]["id_cod_point"].ToString().Trim());
                            oduitempoint.Description_Point = dt.Rows[0]["Item_Description"].ToString().Trim();
                            oduitempoint.id_Ubicación = Convert.ToInt32(dt.Rows[0]["id_Ubicación"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;


                case "MPointOfPurchase":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EMPop oedumpop = new EMPop();



                        if (dt.Rows.Count > 0)
                        {
                            oedumpop.POPname = dt.Rows[0]["POP_name"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Segments_Type":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESegments_Type oedSegmentsType = new ESegments_Type();

                        if (dt.Rows.Count > 0)
                        {
                            oedSegmentsType.Segment_Type = dt.Rows[0]["Segment_Name"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;




                case "Segments":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESegments oedSegments = new ESegments();

                        if (dt.Rows.Count > 0)
                        {
                            oedSegments.Segment_Name = dt.Rows[0]["Segment_Name"].ToString().Trim();
                            oedSegments.id_SegmentsType = Convert.ToInt32(dt.Rows[0]["id_SegmentsType"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;



                //Modificación:  25/08/2010 Se quita el pdvcode ya no existe en la tabla. Ing. Mauricio Ortiz 
                case "PointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPuntosDV oedpdv = new EPuntosDV();

                        if (dt.Rows.Count > 0)
                        {
                            oedpdv.pdvName = dt.Rows[0]["pdv_Name"].ToString().Trim();
                            oedpdv.pdvAddress = dt.Rows[0]["pdv_Address"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "PointOfSaleDoc":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPuntosDV oedpdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedpdv.pdvRegTax = dt.Rows[0]["pdv_RegTax"].ToString().Trim();
                            oedpdv.pdvRazónSocial = dt.Rows[0]["pdv_RazónSocial"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "PointOfSale_Client":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPuntosDV oedCliePDV = new EPuntosDV();

                        if (dt.Rows.Count > 0)
                        {
                            oedCliePDV.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oedCliePDV.id_PointOfsale = Convert.ToInt32(dt.Rows[0]["id_PointOfsale"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;



                case "Channel":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECanales oedcanales = new ECanales();



                        if (dt.Rows.Count > 0)
                        {

                            ///Modificación: se agrega parametro Company_id para no repetir junto con nombre de canal. 20/10/2010 Magaly Jiménez
                            oedcanales.ChannelName = dt.Rows[0]["Channel_Name"].ToString().Trim();
                            oedcanales.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                /// Modificiación: se elimina campo id_ProductClass, ya no se utiliza.
                /// 18/08/2010 Magaly Jiménez
                case "ProductCategory":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProduct_Type oeduproductcategory = new EProduct_Type();
                        if (dt.Rows.Count > 0)
                        {
                            oeduproductcategory.Product_Category = dt.Rows[0]["Product_Category"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "Product_Tipo":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProduct_Tipo oeduproducttipo = new EProduct_Tipo();
                        if (dt.Rows.Count > 0)
                        {
                            oeduproducttipo.Product_Tipo = dt.Rows[0]["Product_Tipo"].ToString().Trim();
                            oeduproducttipo.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                ///Se adiciona parametro id_ProductCategory para duplciado. 01/12/2010  Magaly Jiménez
                case "Brand":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBrand oeduBrand = new EBrand();
                        if (dt.Rows.Count > 0)
                        {
                            oeduBrand.Name_Brand = dt.Rows[0]["Name_Brand"].ToString().Trim();
                            oeduBrand.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oeduBrand.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "AD_Oficina":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Oficina oeduOficina = new EAD_Oficina();

                        if (dt.Rows.Count > 0)
                        {
                            oeduOficina.Name_Oficina = dt.Rows[0]["Name_Oficina"].ToString().Trim();
                            oeduOficina.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case "SubBrand":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESubBrand oeduSubBrand = new ESubBrand();
                        if (dt.Rows.Count > 0)
                        {
                            oeduSubBrand.Name_SubBrand = dt.Rows[0]["Name_SubBrand"].ToString().Trim();
                            oeduSubBrand.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;


                case "Sector":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESector oeduSector = new ESector();
                        if (dt.Rows.Count > 0)
                        {
                            oeduSector.Sector = dt.Rows[0]["Sector"].ToString().Trim();
                            oeduSector.id_malla = Convert.ToInt32(dt.Rows[0]["id_malla"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "Product_Presentations":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, Convert.ToDecimal(scampo1), scampo2);
                    if (dt != null)
                    {
                        EProduct_Presentations oeduPresen = new EProduct_Presentations();
                        if (dt.Rows.Count > 0)
                        {
                            oeduPresen.ProductPresentationName = dt.Rows[0]["ProductPresentationName"].ToString().Trim();
                            oeduPresen.ProductPresentation_Neto = Convert.ToDecimal(dt.Rows[0]["ProductPresentation_Neto"].ToString().Trim());
                            oeduPresen.id_UnitOfMeasure = Convert.ToInt32(dt.Rows[0]["id_UnitOfMeasure"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;




                case "Products":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProductos oeduproduct = new EProductos();



                        if (dt.Rows.Count > 0)
                        {
                            oeduproduct.Product_Name = dt.Rows[0]["Product_Name"].ToString().Trim();
                            oeduproduct.cod_Product = dt.Rows[0]["cod_Product"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                ///se crea metodo para verificar duplicados en maestro de familia de producto. 19/10/2010 Magaly Jiménez
                case "ProductFamily":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProduct_Family oedProduFamily = new EProduct_Family();


                        if (dt.Rows.Count > 0)
                        {
                            oedProduFamily.id_ProductFamily = dt.Rows[0]["id_ProductFamily"].ToString().Trim();
                            oedProduFamily.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            oedProduFamily.name_Family = dt.Rows[0]["name_Family"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;



                case "City_UserRepor":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECity_UserReport oeduCityUR = new ECity_UserReport();


                        if (dt.Rows.Count > 0)
                        {
                            oeduCityUR.id_userinforme = Convert.ToInt32(dt.Rows[0]["id_userinforme"].ToString().Trim());
                            oeduCityUR.cod_Oficina = Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim());


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;


                case "AD_ReportOficina":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Report_Oficina oedupRO = new EAD_Report_Oficina();



                        if (dt.Rows.Count > 0)
                        {
                            oedupRO.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedupRO.cod_Oficina = Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim());


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "ProductsEAN":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EProductos oeduproduct = new EProductos();
                        if (dt.Rows.Count > 0)
                        {
                            oeduproduct.Product_CodeEAN = dt.Rows[0]["Product_CodeEAN"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                //case "Reports":
                //    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                //    if (dt != null)
                //    {
                //        EReports oedureport = new EReports();
                //        if (dt.Rows.Count > 0)
                //        {
                //            oedureport.ReportNameReport = dt.Rows[0]["Report_NameReport"].ToString().Trim();
                //            return dt;
                //        }
                //    }
                //    else
                //    {
                //        return null;

                //    }
                //    break;


                case "Reports_TypeReport":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports oedureportModulos = new EReports();
                        if (dt.Rows.Count > 0)
                        {
                            oedureportModulos.reportId = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedureportModulos.idTypeReport = Convert.ToInt32(dt.Rows[0]["id_TypeReport"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;



                case "Reports_Modulo":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports oedureportModulos = new EReports();
                        if (dt.Rows.Count > 0)
                        {
                            oedureportModulos.reportId = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedureportModulos.moduloid = dt.Rows[0]["Modulo_id"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;



                case "Reports_Strategit":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReportsStrategit oedurstrategy = new EReportsStrategit();




                        if (dt.Rows.Count > 0)
                        {
                            oedurstrategy.Report_id = Convert.ToInt32(dt.Rows[0]["Report_id"].ToString().Trim());


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Reports":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports oedureports = new EReports();




                        if (dt.Rows.Count > 0)
                        {
                            oedureports.ReportNameReport = dt.Rows[0]["Report_NameReport"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                case "ReportChannel":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReportChannel oedReCanal = new EReportChannel();

                        if (dt.Rows.Count > 0)
                        {
                            oedReCanal.Report_id = Convert.ToInt32((dt.Rows[0]["Report_id"].ToString().Trim()));
                            oedReCanal.Company_id = Convert.ToInt32((dt.Rows[0]["Company_id"].ToString().Trim()));
                            oedReCanal.cod_Channel = (dt.Rows[0]["cod_Channel"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Country":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECountry oedcountry = new ECountry();




                        if (dt.Rows.Count > 0)
                        {
                            oedcountry.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            oedcountry.NameCountry = dt.Rows[0]["Name_Country"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;


                case "Departament":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDepartamento oeddpto = new EDepartamento();
                        if (dt.Rows.Count > 0)
                        {
                            oeddpto.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            oeddpto.Namedpto = dt.Rows[0]["Name_dpto"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "CityCountry":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECity oedcity = new ECity();

                        if (dt.Rows.Count > 0)
                        {
                            oedcity.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            oedcity.NameCity = dt.Rows[0]["Name_City"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;
                case "CityDto":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECity oedcity = new ECity();

                        if (dt.Rows.Count > 0)
                        {
                            oedcity.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            oedcity.NameCity = dt.Rows[0]["Name_City"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "DistrictCity":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDistrito oeddistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oeddistrito.codCity = dt.Rows[0]["cod_City"].ToString().Trim();
                            oeddistrito.NameLocal = dt.Rows[0]["Name_Local"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case "DistrictCountry":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDistrito oeddistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oeddistrito.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            oeddistrito.NameLocal = dt.Rows[0]["Name_Local"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case "DistrictDepto":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EDistrito oeddistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oeddistrito.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            oeddistrito.NameLocal = dt.Rows[0]["Name_Local"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case "CommunityCountry":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case "CommunityDpto":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case "CommunityCity":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.codcity = dt.Rows[0]["cod_city"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case "CommunityDistrict":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EBarrio oedbarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedbarrios.codDistrict = dt.Rows[0]["cod_District"].ToString().Trim();
                            oedbarrios.NameCommunity = dt.Rows[0]["Name_Community"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;



                case "MarketChain":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECadenas oedCadenas = new ECadenas();



                        if (dt.Rows.Count > 0)
                        {
                            oedCadenas.MarketChainname = dt.Rows[0]["MarketChain_name"].ToString().Trim();


                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "Indicadores":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EIndicadores oedindicadores = new EIndicadores();





                        if (dt.Rows.Count > 0)
                        {
                            oedindicadores.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_strategy"].ToString().Trim());
                            oedindicadores.nameindicador = (dt.Rows[0]["name_indicador"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "NodeComercial_Type":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ENodeType oedNodetype = new ENodeType();



                        if (dt.Rows.Count > 0)
                        {
                            oedNodetype.lNodeComTypename = (dt.Rows[0]["NodeComType_name"].ToString().Trim());

                            return dt;
                        }
                    }



                    else
                    {
                        return null;

                    }
                    break;


                /// duplicados maestro distribuidoras 01/04/2011 Magaly jiménez.

                case "Distribuidora":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Distribuidora oeddex = new EAD_Distribuidora();



                        if (dt.Rows.Count > 0)
                        {
                            oeddex.lDex_Name = (dt.Rows[0]["Dex_Name"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;

                case "NodeCommercial":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ENodeComercial oednode = new ENodeComercial();
                        if (dt.Rows.Count > 0)
                        {
                            oednode.commercialNodeName = (dt.Rows[0]["commercialNodeName"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;

                    }
                    break;


                case "Staff_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EStaff_Planning oeStaffPlanning = new EStaff_Planning();

                        if (dt.Rows.Count > 0)
                        {
                            oeStaffPlanning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeStaffPlanning.Person_id = Convert.ToInt32(dt.Rows[0]["Person_id"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "Reports_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EReports_Planning oeReports_Planning = new EReports_Planning();

                        if (dt.Rows.Count > 0)
                        {
                            oeReports_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeReports_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oeReports_Planning.id_Month = dt.Rows[0]["id_Month"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "Mallas":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EMalla oeduMalla = new EMalla();

                        if (dt.Rows.Count > 0)
                        {
                            oeduMalla.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oeduMalla.malla = dt.Rows[0]["malla"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                case "Product_planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA_NEW", sTabla, scampo, scampo1, scampo2, scampo3);
                    if (dt != null)
                    {
                        EProducts_Planning oeProductplanning = new EProducts_Planning();

                        if (dt.Rows.Count > 0)
                        {
                            oeProductplanning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeProductplanning.id_Product = Convert.ToInt64(dt.Rows[0]["id_Product"].ToString().Trim());
                            oeProductplanning.Report_Id =Convert.ToInt32 (dt.Rows[0]["Report_Id"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                /// se agrega metodo para verificar duplicados del tabla PLA_Brand_Planning
                /// 26/02/2011 Ing. Mauricio Ortiz
                case "PLA_Brand_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA_NEW", sTabla, scampo, scampo1, scampo2,scampo3);
                    if (dt != null)
                    {
                        EPLA_Brand_Planning oeEPLA_Brand_Planning = new EPLA_Brand_Planning();

                        if (dt.Rows.Count > 0)
                        {
                            oeEPLA_Brand_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeEPLA_Brand_Planning.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            oeEPLA_Brand_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());


                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                /// se agrega metodo para verificar duplicados del tabla PLA_Panel_Planning
                /// 03/03/2011 Ing. Mauricio Ortiz
                case "PLA_Panel_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPLA_Panel_Planning oeEPLA_Panel_Planning = new EPLA_Panel_Planning();

                        if (dt.Rows.Count > 0)
                        {
                            oeEPLA_Panel_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeEPLA_Panel_Planning.id_MPOSPlanning = Convert.ToInt32(dt.Rows[0]["id_MPOSPlanning"].ToString().Trim());
                            oeEPLA_Panel_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                /// se agrega metodo para verificar duplicados del tabla PLA_Family_Planning
                /// 22/03/2011 Ing. Mauricio Ortiz
                case "PLA_Family_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EPLA_Family_Planning oeEPLA_Family_Planning = new EPLA_Family_Planning();
                        if (dt.Rows.Count > 0)
                        {
                            oeEPLA_Family_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeEPLA_Family_Planning.id_ProductFamily = dt.Rows[0]["id_ProductFamily"].ToString().Trim();
                            oeEPLA_Family_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                /// se agrega metodo para verificar duplicados del maestro productos ancla
                /// 07/09/2010 Magaly Jimenez
                case "AD_ProductosAncla":
                    dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_SEARCH_DUPLICAPANCLA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_ProductosAncla oeproducAncla = new EAD_ProductosAncla();

                        if (dt.Rows.Count > 0)
                        {
                            oeproducAncla.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oeproducAncla.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            oeproducAncla.id_Subcategory = Convert.ToInt64(dt.Rows[0]["id_Subcategory"].ToString().Trim());
                            oeproducAncla.cod_Oficina = Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                /// se agrega condicion para verificar duplicados en tipo de canal
                /// 05/08/2011 - Angel Ortiz
                case "Channel_Type":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ECanalTipo oeduroles = new ECanalTipo();
                        if (dt.Rows.Count > 0)
                        {
                            oeduroles.Schtype_nombre = dt.Rows[0]["chtype_nombre"].ToString().Trim();
                            return dt;
                        }
                    }
                    else
                    {

                        return null;

                    }
                    break;
            }

            //destruyye el dt si no encuentra nada para liberar recuersos 
            return dt = null;







        }

        /// Metodo para consultar la no duplicidad en presentaciones de producto 
        /// creado por: Ing. Mauricio Ortiz
        /// 31/08/2009
        /// se modifica: metodo para agrgar prarmetro de duplicado para Categoria subcategoria marca y nombre de presentación
        /// 
        public DataTable ConsultaDuplicadosPancla(string sTabla, int icompany_id, string sid_ProductCategory, long lid_Subcategory, long lcod_Oficina)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                case "AD_ProductosAncla":
                    dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_SEARCH_DUPLICAPANCLA", sTabla, icompany_id, sid_ProductCategory, lid_Subcategory, lcod_Oficina);
                    if (dt != null)
                    {
                        EAD_ProductosAncla oeproducAncla = new EAD_ProductosAncla();

                        if (dt.Rows.Count > 0)
                        {
                            oeproducAncla.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oeproducAncla.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            oeproducAncla.id_Subcategory = Convert.ToInt64(dt.Rows[0]["id_Subcategory"].ToString().Trim());
                            oeproducAncla.cod_Oficina = Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim());

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
            }
            return dt = null;
            }
        public DataTable ConsultaDuplicadosPresent(string sTabla, string scampo, long lcampo1, int icampo2, string scampo3)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {

                case "Product_Presentations":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICADECIMAL", sTabla, scampo, lcampo1, icampo2, scampo3);
                    if (dt != null)
                    {
                        EProduct_Presentations oeduPresen = new EProduct_Presentations();
                        if (dt.Rows.Count > 0)
                        {
                            oeduPresen.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            oeduPresen.id_Subcategory = Convert.ToInt64(dt.Rows[0]["id_Subcategory"].ToString().Trim());
                            oeduPresen.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            oeduPresen.ProductPresentationName = dt.Rows[0]["ProductPresentationName"].ToString().Trim();
                           
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
            }
            return dt = null;
        }

        /// Metodo para consultar la no duplicidad en formatos de levantamiento de informacion creados o actualizados 
        /// creado por: Ing. Mauricio Ortiz
        /// 15/01/2010
        public DataTable ConsultaDuplicadosFormato(string sTabla, string scampo, string scampo1, string scampo2, string scampo3)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                case "Strategit_Points":

                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICAFORMATO", sTabla, scampo, scampo1, scampo2, scampo3);
                    if (dt != null)
                    {
                        EStrategit_Points odustratpoint = new EStrategit_Points();


                        if (dt.Rows.Count > 0)
                        {
                            odustratpoint.DescriptionPoint = dt.Rows[0]["Description_Point"].ToString().Trim();
                            odustratpoint.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            odustratpoint.company_id = Convert.ToInt32(dt.Rows[0]["company_id"].ToString().Trim());
                            odustratpoint.cod_Channel = dt.Rows[0]["cod_Channel"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
            }
            return dt = null;

        }

        /// <summary>
        /// Consulta de duplicados en la tabla reports_planning
        /// Mauricio Ortiz
        /// 26/10/2010 
        /// </summary>
        /// <param name="sTabla"></param>
        /// <param name="scampo"></param>
        /// <param name="scampo1"></param>
        /// <param name="scampo2"></param>
        /// <param name="scampo3"></param>
        /// <returns></returns>
        public DataTable ConsultaDuplicadoReportPlanning(string sTabla, string scampo, string scampo1, string scampo2, string scampo3)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                case "Reports_Planning":

                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICAREPORTPLANNING", sTabla, scampo, scampo1, scampo2, scampo3);
                    if (dt != null)
                    {
                        EReports_Planning oeReports_Planning = new EReports_Planning();

                        if (dt.Rows.Count > 0)
                        {
                            oeReports_Planning.id_planning = dt.Rows[0]["id_planning"].ToString().Trim();
                            oeReports_Planning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oeReports_Planning.id_Month = dt.Rows[0]["id_Month"].ToString().Trim();
                            oeReports_Planning.ReportsPlanning_Periodo = Convert.ToInt32(dt.Rows[0]["ReportsPlanning_Periodo"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
            }
            return dt = null;                     
        }

        /// <summary>
        /// Ing. Mauricio Ortiz
        /// 04/02/2011
        /// Description: Validar rangos de fecha para crear reportes del planning
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="ireport_id"></param>
        /// <param name="tReportsPlanning_RecogerDesde"></param>
        /// <param name="tReportsPlanning_RecogerHasta"></param>
        /// <param name="iid_year"></param>
        /// <returns></returns>
        public DataTable ConsultaRangos(string sid_planning, int ireport_id, DateTime tReportsPlanning_RecogerDesde, DateTime tReportsPlanning_RecogerHasta, int iid_year)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_VALIDAR_RANGOS_REPORTSPLANNING", sid_planning, ireport_id, tReportsPlanning_RecogerDesde, tReportsPlanning_RecogerHasta, iid_year);
            return dt;
        }


        /// <summary>
        /// Método que retorna informacion para validar si se puede actualizar el reporte del planning con las fechas ingresadas
        /// Ing. Mauricio Ortiz
        /// 17/03/2011
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <param name="sReport_NameReport"></param>
        /// <param name="sid_Month"></param>
        /// <param name="iid_Year"></param>
        /// <param name="iReportsPlanning_Periodo"></param>
        /// <returns></returns> 
        public DataTable PermitirUpdateReportsPlanning(string sid_planning, string sReport_NameReport, string sid_Month, int iid_Year, int iReportsPlanning_Periodo)
        {
            DataTable dt = null;
            dt = oConn.ejecutarDataTable("UP_WEBXPLORA_PLA_VALIDAR_ACTUALIZAR_REPORTSPLANNING", sid_planning,sReport_NameReport,sid_Month,iid_Year,iReportsPlanning_Periodo);
            return dt;
        }

        /// Metodo para controlar que se logre deshabilitar un registro en los maestros del modulo administrativo
        /// Creado por: Ing. Mauricio Ortiz
        /// Fecha: 09-07-2009

        public DataTable PermitirDeshabilitar(string sTabla, string scampo)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                case "Corporacion":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EAD_Corporacion oEAD_Corporacion = new EAD_Corporacion();
                        if (dt.Rows.Count > 0)
                        {
                            oEAD_Corporacion.corp_id = Convert.ToInt32(dt.Rows[0]["corp_id"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CompanyBudget":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EUsuario oedUsuario = new EUsuario();
                        EPresupuesto oedPresupuesto = new EPresupuesto();
                        EProductos oedProductos = new EProductos();
                        if (dt.Rows.Count > 0)
                        {
                            oedPresupuesto.Companyid = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());

                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "CompanyPerson":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EUsuario oedUsuario = new EUsuario();
                        EPresupuesto oedPresupuesto = new EPresupuesto();
                        EProductos oedProductos = new EProductos();
                        if (dt.Rows.Count > 0)
                        {

                            oedUsuario.companyid = dt.Rows[0]["Company_id"].ToString().Trim();

                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CompanyProducts":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EUsuario oedUsuario = new EUsuario();
                        EPresupuesto oedPresupuesto = new EPresupuesto();
                        EProductos oedProductos = new EProductos();
                        if (dt.Rows.Count > 0)
                        {

                            oedProductos.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "PersonBudget":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPresupuesto oedPresupuesto = new EPresupuesto();
                        if (dt.Rows.Count > 0)
                        {
                            oedPresupuesto.Personid = Convert.ToInt32(dt.Rows[0]["Person_id"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "PersonPerson_Asign_Ejec_Direct":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPerson_Asign_Ejec_Direct oedPerson_Asign_Ejec_Direct = new EPerson_Asign_Ejec_Direct();

                        if (dt.Rows.Count > 0)
                        {
                            oedPerson_Asign_Ejec_Direct.Person_id_Ejecutive = Convert.ToInt32(dt.Rows[0]["Person_id_Ejecutive"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "PersonDirPerson_Asign_Ejec_Direct":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPerson_Asign_Ejec_Direct oedPerson_Asign_Ejec_Direct = new EPerson_Asign_Ejec_Direct();

                        if (dt.Rows.Count > 0)
                        {
                            oedPerson_Asign_Ejec_Direct.Person_id_Ejecutive = Convert.ToInt32(dt.Rows[0]["Person_id_Director"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "RolesProfiles":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProfiles oedProfiles = new EProfiles();

                        if (dt.Rows.Count > 0)
                        {
                            oedProfiles.Rolid = dt.Rows[0]["Rol_id"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "NivelesappLucky":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPersonLevel oedNiveles = new EPersonLevel();
                        if (dt.Rows.Count > 0)
                        {
                            oedNiveles.id_Level = dt.Rows[0]["id_level"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "NivelesProfiles":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPersonLevel oedNiveles = new EPersonLevel();
                        if (dt.Rows.Count > 0)
                        {
                            oedNiveles.id_Level = dt.Rows[0]["id_level"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "ProfilesBudget":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPresupuesto oedPresupuesto = new EPresupuesto();


                        if (dt.Rows.Count > 0)
                        {
                            oedPresupuesto.Perfilid = dt.Rows[0]["Perfil_id"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "ProfilesPerson":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EUsuario oedUsuario = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {
                            oedUsuario.Perfilid = dt.Rows[0]["Perfil_id"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }


                case "StrategiesIndicadores":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EIndicadores oedIndicadores = new EIndicadores();
                        if (dt.Rows.Count > 0)
                        {
                            oedIndicadores.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_strategy"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "StrategiesItemPoints":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {

                        EItemsPoint oedItemPoint = new EItemsPoint();
                        if (dt.Rows.Count > 0)
                        {
                            oedItemPoint.cod_Strategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "StrategiesPlanning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPlaning oedPlanning = new EPlaning();
                        if (dt.Rows.Count > 0)
                        {
                            oedPlanning.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "StrategiesQuestionStrategy":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EQuestions_Strategy oedQuestionStrategy = new EQuestions_Strategy();

                        if (dt.Rows.Count > 0)
                        {
                            oedQuestionStrategy.cod_Strategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "StrategiesreportStrategy":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EReportsStrategit oedReportStrategy = new EReportsStrategit();
                        if (dt.Rows.Count > 0)
                        {
                            oedReportStrategy.cod_Strategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "StrategiesStPoints":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EStrategit_Points oedStrategyPoint = new EStrategit_Points();
                        if (dt.Rows.Count > 0)
                        {
                            oedStrategyPoint.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Strategit_PointsItemPoints":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EItemsPoint oedItemPoints = new EItemsPoint();

                        if (dt.Rows.Count > 0)
                        {
                            oedItemPoints.id_cod_point = Convert.ToInt32(dt.Rows[0]["id_cod_point"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "MPointOfPurchaseMPointOfPurchase_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EMPointOfPurchase_Planning oedMPOPlanning = new EMPointOfPurchase_Planning();



                        if (dt.Rows.Count > 0)
                        {
                            oedMPOPlanning.id_MPointOfPurchase = Convert.ToInt32(dt.Rows[0]["id_MPointOfPurchase"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "ChannelPlanning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPlaning oedPlanning = new EPlaning();
                        if (dt.Rows.Count > 0)
                        {
                            oedPlanning.PlanningCodChannel = dt.Rows[0]["Planning_CodChannel"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "ChannelPointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPDV = new EPuntosDV();

                        if (dt.Rows.Count > 0)
                        {
                            oedPDV.pdvcodChannel = dt.Rows[0]["pdv_codChannel"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Segments_TypeSegments":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        ESegments oedSegment = new ESegments();
                        if (dt.Rows.Count > 0)
                        {
                            oedSegment.id_SegmentsType = Convert.ToInt32(dt.Rows[0]["id_SegmentsType"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Segments_TypePointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPDV = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPDV.id_Segment = Convert.ToInt32(dt.Rows[0]["id_Segment"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }


                case "PointOfSalePointOfSale_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPointOfSale_Planning oedPDVPlanning = new EPointOfSale_Planning();
                        if (dt.Rows.Count > 0)
                        {
                            oedPDVPlanning.id_ClientPDV = Convert.ToInt32(dt.Rows[0]["id_ClientPDV"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "ProductsProducts_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProducts_Planning oedProductPlanning = new EProducts_Planning();
                        if (dt.Rows.Count > 0)
                        {
                            oedProductPlanning.id_Product = Convert.ToInt32(dt.Rows[0]["id_Product"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "ProductsProducts_Packing":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProductPacking oedProductPacking = new EProductPacking();
                        if (dt.Rows.Count > 0)
                        {
                            oedProductPacking.id_Product = Convert.ToInt32(dt.Rows[0]["id_Product"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "ReportsReports_Strategit":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EReportsStrategit oedReportStrategy = new EReportsStrategit();
                        if (dt.Rows.Count > 0)
                        {
                            oedReportStrategy.Report_id = Convert.ToInt32(dt.Rows[0]["Report_id"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Reports_StrategitReports_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EReports_Planning oedreportPlanning = new EReports_Planning();
                        if (dt.Rows.Count > 0)
                        {
                            oedreportPlanning.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Reports_Channels":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EReportChannel oedreportesClieUser=new EReportChannel();
                      
                        if (dt.Rows.Count > 0) 
                        {
                            oedreportesClieUser.ReportCanal_id = Convert.ToInt32(dt.Rows[0]["ReportCanal_id"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Reports_StrategitIndicadores":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EIndicadores oedIndicadores = new EIndicadores();
                        if (dt.Rows.Count > 0)
                        {
                            oedIndicadores.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }



                case "Item_PointsItem_Point_Detalle":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EItem_Point_Detalle oedItemPointDet = new EItem_Point_Detalle();
                        if (dt.Rows.Count > 0)
                        {
                            oedItemPointDet.cod_item = Convert.ToInt32(dt.Rows[0]["cod_item"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Item_PointsContenedora_Formatos":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EContenedoraFormatos oedContenedoraForatos = new EContenedoraFormatos();

                        if (dt.Rows.Count > 0)
                        {
                            oedContenedoraForatos.codItem = Convert.ToInt32(dt.Rows[0]["cod_Item"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "CountryappLucky":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EAplicacionWeb oedAppLucky = new EAplicacionWeb();
                        if (dt.Rows.Count > 0)
                        {
                            oedAppLucky.cod_Country = dt.Rows[0]["cod_Country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }


                case "CountryCity":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        ECity oedCity = new ECity();
                        if (dt.Rows.Count > 0)
                        {
                            oedCity.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "CountryCommunity":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EBarrio oedBarrios = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedBarrios.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "CountryCompany":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        ECompany oedCompany = new ECompany();
                        if (dt.Rows.Count > 0)
                        {
                            oedCompany.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "CountryDepartament":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EDepartamento oedDepto = new EDepartamento();
                        if (dt.Rows.Count > 0)
                        {
                            oedDepto.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CountryDistrict":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EDistrito oedDistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oedDistrito.codcountry = dt.Rows[0]["cod_country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "CountryPerson":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EUsuario oedUsuario = new EUsuario();
                        if (dt.Rows.Count > 0)
                        {
                            oedUsuario.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CountryPointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPDv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPDv.pdvcodCountry = dt.Rows[0]["pdv_codCountry"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "CountryStrategies":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EEstrategy oedStrategy = new EEstrategy();
                        if (dt.Rows.Count > 0)
                        {
                            oedStrategy.codCountry = dt.Rows[0]["cod_Country"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "DepartamentCity":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        ECity oedCity = new ECity();
                        if (dt.Rows.Count > 0)
                        {
                            oedCity.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "DepartamentCommunity":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EBarrio oedBarrio = new EBarrio();

                        if (dt.Rows.Count > 0)
                        {
                            oedBarrio.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "DepartamentDistrict":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EDistrito oedDistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oedDistrito.coddpto = dt.Rows[0]["cod_dpto"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "DepartamentPointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdv.pdvcodDepartment = dt.Rows[0]["pdv_codDepartment"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CityCity_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        ECityPlanning oedCityPlanning = new ECityPlanning();
                        if (dt.Rows.Count > 0)
                        {
                            oedCityPlanning.CodCity = dt.Rows[0]["Cod_City"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CityCommunity":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EBarrio oedBarrio = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedBarrio.codcity = dt.Rows[0]["cod_city"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CityDistrict":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EDistrito oedDistrito = new EDistrito();
                        if (dt.Rows.Count > 0)
                        {
                            oedDistrito.codCity = dt.Rows[0]["cod_City"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CityPointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdv.pdvcodProvince = dt.Rows[0]["pdv_codProvince"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "DistrictCommunity":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EBarrio oedBarrio = new EBarrio();
                        if (dt.Rows.Count > 0)
                        {
                            oedBarrio.codDistrict = dt.Rows[0]["cod_District"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "DistrictPointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdv.pdvcodDistrict = dt.Rows[0]["pdv_codDistrict"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "CommunityPointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdv.pdvcodCommunity = dt.Rows[0]["pdv_codCommunity"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                //case "MarketChainPointOfSale":
                //    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                //    if (dt != null)
                //    {
                //        EPuntosDV oedPdv = new EPuntosDV();
                //        if (dt.Rows.Count > 0)
                //        {
                //            oedPdv.pdvidMarketChain = dt.Rows[0]["id_marketChain"].ToString().Trim();
                //            return dt;
                //        }
                //        else
                //        {
                //            return dt = null;
                //        }
                //    }
                //    else
                //    {
                //        return null;
                //    }
                case "IndicadoresReports":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EReports oedReport = new EReports();
                        if (dt.Rows.Count > 0)
                        {
                            oedReport.idindicador = Convert.ToInt32(dt.Rows[0]["id_indicador"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "NodeComercial_TypeNodeCommercial":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        ENodeComercial oedNodeCom = new ENodeComercial();
                        if (dt.Rows.Count > 0)
                        {
                            oedNodeCom.idNodeComType = Convert.ToInt32(dt.Rows[0]["idNodeComType"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "NodeComercial_TypePointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdv.idNodeComType = Convert.ToInt32(dt.Rows[0]["idNodeComType"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    /// se crea case para permitir deshabilitar distribuidoras 02/04/2011 Magaly Jiménez
                case "Dex":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EAD_Distribuidora oedDex = new EAD_Distribuidora();
                     
                        if (dt.Rows.Count > 0)
                        {
                            oedDex.Id_Dex = Convert.ToInt32(dt.Rows[0]["Id_Dex"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "NodeCommercialPointOfSale":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EPuntosDV oedPdv = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdv.NodeCommercial = dt.Rows[0]["NodeCommercial"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "ProductCategoryProduct_Tipo":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProduct_Tipo oedProductTipo = new EProduct_Tipo();

                        if (dt.Rows.Count > 0)
                        {
                            oedProductTipo.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                //case "Product_TipoProducts":
                //    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                //    if (dt != null)
                //    {
                //        EProductos oedProducts = new EProductos();

                //        if (dt.Rows.Count > 0)
                //        {
                //            oedProducts.id_ProductTipo = dt.Rows[0]["id_ProductTipo"].ToString().Trim();
                //            return dt;
                //        }
                //        else
                //        {
                //            return dt = null;
                //        }
                //    }
                //    else
                //    {
                //        return null;
                //    }
                case "BrandProducts_Planning":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProducts_Planning oedProductPlanning = new EProducts_Planning();
                        if (dt.Rows.Count > 0)
                        {
                            oedProductPlanning.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "BrandProducts":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProductos oedProducts = new EProductos();
                        if (dt.Rows.Count > 0)
                        {
                            oedProducts.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                case "Brand_SubBrand":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        ESubBrand oedSubBrand = new ESubBrand();
                        if (dt.Rows.Count > 0)
                        {
                            oedSubBrand.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                /// verifica si hay registros de PDVCliente en tabla de reporte Competencia
                /// 24/02/2011 Magaly Jiménez 
                case "PDVCliente_OPE_REPORTE_COMPETENCIA":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        
                        EPuntosDV oedPdvClienteOPECompetencia = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdvClienteOPECompetencia.ClientPDV_Code = dt.Rows[0]["ClientPDV_Code"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }                    
                      
                    }
                    else
                    {
                        return null;
                    }
                /// verifica si hay registros de PDVCliente en tabla de reporte Exhibición 
                /// 24/02/2011 Magaly Jiménez 
                case "PDVCliente_OPE_REPORTE_EXHIBICION":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {

                        EPuntosDV oedPdvClienteOPEExhibicion = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdvClienteOPEExhibicion.ClientPDV_Code = dt.Rows[0]["ClientPDV_Code"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }

                    }
                    else
                    {
                        return null;
                    }
                /// verifica si hay registros de PDVCliente en tabla de reporte Precio
                /// 24/02/2011 Magaly Jiménez 
                case "PDVCliente_OPE_REPORTE_PRECIO":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {

                        EPuntosDV oedPdvClienteOPEPrecio = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdvClienteOPEPrecio.ClientPDV_Code = dt.Rows[0]["ClientPDV_Code"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }

                    }
                    else
                    {
                        return null;
                    }
                /// verifica si hay registros de PDVCliente en tabla de reporte sod
                /// 24/02/2011 Magaly Jiménez 
                case "PDVCliente_OPE_REPORTE_SOD":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {

                        EPuntosDV oedPdvClienteOPESod = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdvClienteOPESod.ClientPDV_Code = dt.Rows[0]["ClientPDV_Code"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }

                    }
                    else
                    {
                        return null;
                    }
                /// verifica si hay registros de PDVCliente en tabla de reporte stock
                /// 24/02/2011 Magaly Jiménez 
                case "PDVCliente_OPE_REPORTE_STOCK":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {

                        EPuntosDV oedPdvClienteOPEStock = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdvClienteOPEStock.ClientPDV_Code = dt.Rows[0]["ClientPDV_Code"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }

                    }
                    else
                    {
                        return null;
                    }
                    /// verifica si hay registros de PDVCliente en tabla de reporte fotografico
                    /// 24/02/2011 Magaly Jiménez 
                case "PDVCliente_OPE_REPORTE_FOTOGRAFICO":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {

                        EPuntosDV oedPdvClienteOPEFotografico = new EPuntosDV();
                        if (dt.Rows.Count > 0)
                        {
                            oedPdvClienteOPEFotografico.ClientPDV_Code = dt.Rows[0]["ClientPDV_Code"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }

                    }
                    else
                    {
                        return null;
                    }
                case "AD_Report_Oficina":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EAD_Report_Oficina oedesRepOficina = new EAD_Report_Oficina();
                       
                        if (dt.Rows.Count > 0)
                        {
                            oedesRepOficina.cod_Oficina = Convert.ToInt64(dt.Rows[0]["cod_Oficina"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "SubBrandProducts":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProductos oedProducts = new EProductos();
                        if (dt.Rows.Count > 0)
                        {
                            oedProducts.id_SubBrand = Convert.ToInt32(dt.Rows[0]["id_SubBrand"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                case "Malla_Sector":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {

                        ESubBrand oedSubBrand = new ESubBrand();
                        if (dt.Rows.Count > 0)
                        {
                            oedSubBrand.id_Brand = Convert.ToInt32(dt.Rows[0]["id_Brand"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }


                    case "Product_SubCategory_Products":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProductos oedProducts = new EProductos();
                        if (dt.Rows.Count > 0)
                        {
                            oedProducts.id_Subcategory = Convert.ToInt64( dt.Rows[0]["id_Subcategory"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    // se cambia tipo de datos de id_ProductPresentation de string por long.
                    // 25/08/2010 por:Magaly jiménez
                case "Product_PresentationsProducts":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITAR", sTabla, scampo);
                    if (dt != null)
                    {
                        EProduct_Presentations oedPresen = new EProduct_Presentations();
                        if (dt.Rows.Count > 0)
                        {
                            oedPresen.id_ProductPresentation =  dt.Rows[0]["id_Product_Presentation"].ToString().Trim();
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    // permite dehabilitar productos ancla
                    //08/09/2010 Magaly Jiménez
                





            }

            //destruye el dt si no encuentra nada para liberar recuersos 
            return dt = null;
        }

        /// Metodo para controlar que se logre deshabilitar un registro en el maestro de reportes vs servicios q no este relacionado en indicadores
        /// Creado por: Ing. Mauricio Ortiz
        /// Fecha: 07-10-2009

        public DataTable PermitirDeshabilitarRepVSServ(string sTabla, string scampo, string scampo1)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                case "Reports_StrategitIndicadores":
                    dt = oConn.ejecutarDataTable("UP_WEB_PERMITIR_DESHABILITARRepVSServ", sTabla, scampo, scampo1);
                    if (dt != null)
                    {
                        EIndicadores oedIndicadores = new EIndicadores();
                        if (dt.Rows.Count > 0)
                        {
                            oedIndicadores.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedIndicadores.codStrategy = Convert.ToInt32(dt.Rows[0]["cod_strategy"].ToString().Trim());
                            return dt;
                        }
                        else
                        {
                            return dt = null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    
            }

            //destruye el dt si no encuentra nada para liberar recuersos 
            return dt = null;


        }

        public DataTable DuplicadosInfoaUsuarios(string sTabla, string scampo, string scampo1, string scampo2, string scampo3, string scampo4, string scampo5, string scampo6)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                case "CLIE_Users_Reports":
                    dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_DUPLICAINFOAUSUARIO", sTabla, scampo, scampo1, scampo2, scampo3, scampo4, scampo5, scampo6);
                    if (dt != null)
                    {
                        EInfoaUsaurio oedInfoaUsu = new EInfoaUsaurio();

                        if (dt.Rows.Count > 0)
                        {
                            oedInfoaUsu.Person_id = Convert.ToInt32(dt.Rows[0]["Person_id"].ToString().Trim());
                            oedInfoaUsu.Report_Id = Convert.ToInt32(dt.Rows[0]["Report_Id"].ToString().Trim());
                            oedInfoaUsu.cod_Strategy = Convert.ToInt32(dt.Rows[0]["cod_Strategy"].ToString().Trim());
                            oedInfoaUsu.cod_Channel = dt.Rows[0]["cod_Channel"].ToString().Trim();
                            oedInfoaUsu.cod_subchannel = dt.Rows[0]["cod_subchannel"].ToString().Trim();
                            oedInfoaUsu.cod_Subnivel = dt.Rows[0]["cod_Subnivel"].ToString().Trim();
                            oedInfoaUsu.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                    /// metodo para evitar duplicidad en subcategoria 
                case "Product_SubCategory":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        ESubCategoria oeduSubcategoria = new ESubCategoria();                       
                  
                        if (dt.Rows.Count > 0)
                        {
                            oeduSubcategoria.Name_Subcategory = dt.Rows[0]["Name_Subcategory"].ToString().Trim();
                            oeduSubcategoria.id_ProductCategory = dt.Rows[0]["id_ProductCategory"].ToString().Trim();
                            
                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;

                    ///se adiciona metodo de verificación de duplicados en subchannel 14/04/2011  Magaly Jiménez
                case "AD_SubCanal":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA", sTabla, scampo, scampo1, scampo2);
                    if (dt != null)
                    {
                        EAD_Subchannel oeduSubcanal = new EAD_Subchannel();

                        if (dt.Rows.Count > 0)
                        {
                            oeduSubcanal.Name_subchannel = dt.Rows[0]["Name_subchannel"].ToString().Trim();
                            oeduSubcanal.cod_Channel = dt.Rows[0]["cod_Channel"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;



                case "Parametros_Reports":
                    dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICAPARAMETROREPORTE", sTabla, scampo, scampo1, scampo2, scampo3);
                    if (dt != null)
                    {
                        EAD_GestionProductosXReporte oedParareport = new EAD_GestionProductosXReporte();


                        if (dt.Rows.Count > 0)
                        {
                            oedParareport.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
                            oedParareport.cod_Channel = dt.Rows[0]["cod_Channel"].ToString().Trim();
                            oedParareport.Report_id = Convert.ToInt32(dt.Rows[0]["Report_id"].ToString().Trim());
                            oedParareport.id_Tipo_Reporte = dt.Rows[0]["id_Tipo_Reporte"].ToString().Trim();

                            return dt;
                        }
                    }
                    else
                    {
                        return null;
                    }
                    break;
            }
            return dt = null;
        }

        public DataTable DuplicadosCategoriasPlanning(string sTabla, string scampo, string scampo1, string scampo2)
        {
            DataTable dt = null;

            //Este switch-case Establece la secuencia de Busqueda

            switch (sTabla)
            {
                 /// se agrega metodo para verificar duplicados del tabla PLA_Category_Planning
                 /// 05/05/2011 Ing. Mauricio Ortiz
                 case "PLA_Category_Planning":
                     dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICA_Cat_Planning", sTabla, scampo, scampo1, scampo2);
                     if (dt != null)
                     {
                         if (dt.Rows.Count > 0)
                         {
                             return dt;
                         }
                     }
                     else
                     {
                         return null;
                     }
                     break;
             }

            //destruye el dt si no encuentra nada para liberar recuersos 
            return dt = null;
        }

        //public DataTable DuplicadosParametroReport(string sTabla, string scampo, string scampo1, string scampo2, string scampo3)
        //{
        //    DataTable dt = null;

        //    //Este switch-case Establece la secuencia de Busqueda

        //    switch (sTabla)
        //    {
        //        case "Parametros_Reports":
        //            dt = oConn.ejecutarDataTable("UP_WEB_SEARCH_DUPLICAPARAMETROREPORTE", sTabla, scampo, scampo1, scampo2, scampo3);
        //            if (dt != null)
        //            {
        //                EAD_GestionProductosXReporte oedParareport = new EAD_GestionProductosXReporte();


        //                if (dt.Rows.Count > 0)
        //                {
        //                    oedParareport.Company_id = Convert.ToInt32(dt.Rows[0]["Company_id"].ToString().Trim());
        //                    oedParareport.cod_Channel = dt.Rows[0]["cod_Channel"].ToString().Trim();
        //                    oedParareport.Report_id = Convert.ToInt32(dt.Rows[0]["Report_id"].ToString().Trim());
        //                    oedParareport.id_Tipo_Reporte = dt.Rows[0]["id_Tipo_Reporte"].ToString().Trim();
                          
        //                    return dt;
        //                }
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //            break;
        //    }
        //}
    }
}
        
