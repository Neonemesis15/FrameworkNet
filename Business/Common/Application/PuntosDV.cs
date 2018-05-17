using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase de Puntos de venta Lucky
    /// Create By: Ing Mauricio Ortiz
    /// Fecha de Creación: 28/05/2009
    /// requerimiento:
    /// </summary>
    /// 
    public class PuntosDV
    {
        public PuntosDV()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        //----

        /// <summary>
        /// Metodo que permite registrar PDV
        /// Módificación 25/08/2010 se elimina parametro spdvCode ya no existe en la tabla. Ing. Mauricio Ortiz.
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
        /// <returns>oepdv</returns>
        public EPuntosDV RegistrarPDV(string sid_typeDocument, string spdvRegTax,
            string spdvcontact1, string spdvposition1, string spdvcontact2, string spdvposition2, string spdvRazónSocial,
            string spdvName, string spdvPhone, string spdvAnexo, string spdvFax, string spdvcodCountry, string spdvcodDepartment,
            string spdvcodProvince, string spdvcodDistrict, string spdvcodCommunity, string spdvAddress, string spdvemail,
            string spdvcodChannel, int iidNodeComType, string sNodeCommercial, int iid_Segment, bool bpdvstatus, string sPdvCreateBy, DateTime tPdvDateBy,
            string sPdvModiBy, DateTime tPdvDateModiBy)
        {
            Lucky.Data.Common.Application.DPuntosDV odrPDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oepdv = odrPDV.registrarPDVPK(sid_typeDocument, spdvRegTax,
             spdvcontact1, spdvposition1, spdvcontact2, spdvposition2, spdvRazónSocial,
             spdvName, spdvPhone, spdvAnexo, spdvFax, spdvcodCountry, spdvcodDepartment,
             spdvcodProvince, spdvcodDistrict, spdvcodCommunity, spdvAddress, spdvemail,
             spdvcodChannel, iidNodeComType, sNodeCommercial, iid_Segment,  bpdvstatus, sPdvCreateBy, tPdvDateBy,
             sPdvModiBy, tPdvDateModiBy);

            odrPDV = null;
            return oepdv;
        }
       

        /// <summary>
        /// Metodo para Actualizar PDV
        /// Módificación 25/08/2010 se elimina parametro spdvCode ya no existe en la tabla. Ing. Mauricio Ortiz.
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
        /// <returns></returns>
        public EPuntosDV Actualizar_PDV(int iid_PointOfsale, string sid_typeDocument, string spdv_RegTax,
            string spdv_contact1, string spdv_position1, string spdv_contact2, string spdv_position2, string spdv_RazónSocial,
            string spdv_Name, string spdv_Phone, string spdv_Anexo, string spdv_Fax, string spdv_codCountry,
            string spdv_codDepartment, string spdv_codProvince, string spdv_codDistrict, string spdv_codCommunity,
            string spdv_Address, string spdv_email, string spdv_codChannel, int iidNodeComType, string sNodeCommercial, int iid_Segment,
            bool bpdv_status, string sPdv_ModiBy, DateTime tPdv_DateModiBy)
        {

            Lucky.Data.Common.Application.DPuntosDV odaPDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oepdv = odaPDV.Actualizar_PDV(iid_PointOfsale, sid_typeDocument, spdv_RegTax,
             spdv_contact1, spdv_position1, spdv_contact2, spdv_position2, spdv_RazónSocial, spdv_Name, spdv_Phone, spdv_Anexo, spdv_Fax, spdv_codCountry,
             spdv_codDepartment, spdv_codProvince, spdv_codDistrict, spdv_codCommunity, spdv_Address, spdv_email, spdv_codChannel, iidNodeComType, sNodeCommercial, iid_Segment,
             bpdv_status, sPdv_ModiBy, tPdv_DateModiBy);

            odaPDV = null;
            return oepdv;
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
        public EPuntosDV Actualizar_NodePlaPDV(int iid_ClientPDV, string scod_City, int iidNodeComType, string sNodeCommercial)
        {

            Lucky.Data.Common.Application.DPuntosDV odanodePDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oenodepdv = odanodePDV.Actualizar_NodoPlanningPDV(iid_ClientPDV, scod_City, iidNodeComType, sNodeCommercial);

            odanodePDV = null;
            return oenodepdv;
        }



        //---Metodo de Consulta de Puntos de venta

        public DataTable BuscarPDV(string sPdvCodProvince, string sPdvRegTax, string sPdvName, string sPdvChannel)
        {
            Lucky.Data.Common.Application.DPuntosDV odsePDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oePDV = new EPuntosDV();
            DataTable dtPDV = odsePDV.ObtenerPDV(sPdvCodProvince, sPdvRegTax, sPdvName, sPdvChannel);
            odsePDV = null;
            return dtPDV;
        }

        //----

        /// <summary>
        /// Metodo que permite registrar Clientes del PDV
        /// Módificación : 26/08/2010 se agrega parametro sClientPDV_Code y iid_sector . Ing. Mauricio Ortiz 
        /// Modificación: 12/11/2010 se agrega parametro cod_Oficina
        /// Magaly Jiménez
        /// </summary>
        /// <param name="iCompany_id"></param>
        /// <param name="iid_PointOfsale"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <param name="bClientPDV_Status"></param>
        /// <param name="sClientPDV_CreateBy"></param>
        /// <param name="tClientPDV_DateBy"></param>
        /// <param name="sClientPDV_ModiBy"></param>
        /// <param name="tClientPDV_DateModiBy"></param>
        /// <returns>oepdv</returns>
        public EPuntosDV RegistrarClientPDV(int iCompany_id, int iid_PointOfsale, string sClientPDV_Code, int iid_sector, long lcod_Oficina, int iId_Dex, bool bClientPDV_Status,
            string sClientPDV_CreateBy, DateTime tClientPDV_DateBy, string sClientPDV_ModiBy, DateTime tClientPDV_DateModiBy, string pdv_alias)
        {
            Lucky.Data.Common.Application.DPuntosDV odrPDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oepdv = odrPDV.registrarClientPDVPK(iCompany_id, iid_PointOfsale, sClientPDV_Code, iid_sector, lcod_Oficina, iId_Dex, bClientPDV_Status,
             sClientPDV_CreateBy, tClientPDV_DateBy, sClientPDV_ModiBy, tClientPDV_DateModiBy, pdv_alias);
            odrPDV = null;
            return oepdv;
        }
        /// <summary>
        ///INSERTA pdvCliente en BD intermedia
        /// 02/02/2011  Magaly Jiménez 
        /// </summary>
        /// <returns></returns>
        public EPuntosDV RegistrarClientPDVTMP()
        {
            Lucky.Data.Common.Application.DPuntosDV odrPDVtmp = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oepdvtmp = odrPDVtmp.registrarClientPDVPKTMP();
            odrPDVtmp = null;
            return oepdvtmp;
        }



        //---Metodo de Consulta de Clientes del Puntos de venta

        public DataTable BuscarPDVClient(int iid_PointOfsale)
        {
            Lucky.Data.Common.Application.DPuntosDV odsePDV = new Lucky.Data.Common.Application.DPuntosDV();
            DataTable dtPDVClient = odsePDV.ObtenerPDVClient(iid_PointOfsale);
            odsePDV = null;
            return dtPDVClient;
        }
        /// <summary>
        ///  consulta cademas de la tabla intermedia
        /// 02/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="sID_CADENA"></param>
        /// <returns></returns>
        public DataTable ObtenerCanedatmp(string sID_CADENA)
        {
            Lucky.Data.Common.Application.DPuntosDV odsecadenatmp = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oecadenatmp = new EPuntosDV();
            DataTable dtCadenatmp = odsecadenatmp.ObtenerCADENA(sID_CADENA);
            odsecadenatmp = null;
            return dtCadenatmp;
        }
        /// <summary>
        /// Actualiza cadena en tabla de cadena en BD intermedia
        /// 03/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="spdv_codChannel"></param>
        /// <param name="bpdv_status"></param>
        /// <param name="sNodeCommercial"></param>
        /// <returns></returns>
        public EPuntosDV Actualizar_Cadena(string spdv_codChannel, string sNodeCommercial)
        {
            Lucky.Data.Common.Application.DPuntosDV odaCadenatmp = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oecadenatmp = odaCadenatmp.Actualizar_Cadenatmp(spdv_codChannel,  sNodeCommercial);
            odaCadenatmp = null;
            return oecadenatmp;
        }

        //---Metodo de Consulta de Clientes del Puntos de venta actual que se desea actualizar

        public DataTable BuscarPDVClientActual(int iiCompany_id, int iid_PointOfsale)
        {
            Lucky.Data.Common.Application.DPuntosDV odsePDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oePDV = new EPuntosDV();
            DataTable dtPDVClient = odsePDV.ObtenerPDVClientActual(iiCompany_id, iid_PointOfsale);
            odsePDV = null;
            return dtPDVClient;
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
        /// <param name="bClientPDV_Status"></param>
        /// <param name="sClientPDV_ModiBy"></param>
        /// <param name="tClientPDV_DateModiBy"></param>
        /// <returns>oepdv</returns>
        public EPuntosDV Actualizar_PDVClient(int iCompany_id, int iid_PointOfsale, string sClientPDV_Code, int iid_sector, long lcod_Oficina, int iId_Dex, bool bClientPDV_Status, string sClientPDV_ModiBy, DateTime tClientPDV_DateModiBy, string pdv_alias)
        {
            Lucky.Data.Common.Application.DPuntosDV odaPDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oepdv = odaPDV.Actualizar_PDVClient(iCompany_id, iid_PointOfsale, sClientPDV_Code, iid_sector, lcod_Oficina, iId_Dex, bClientPDV_Status, sClientPDV_ModiBy, tClientPDV_DateModiBy, pdv_alias);
            odaPDV = null;
            return oepdv;
        }
        /// <summary>
        /// Actualiza tabla Pointsale_Planning desde PDV_Cliente.
        /// 09/03/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iid_ClientPDV"></param>
        /// <param name="lcod_Oficina"></param>
        /// <param name="iid_malla"></param>
        /// <param name="iid_sector"></param>
        /// <returns></returns>
        public EPuntosDV Actualizar_PDVPlanningPDVClient(int iid_ClientPDV, long lcod_Oficina, int iid_malla, int iid_sector, string pdv_contact)
        {
            Lucky.Data.Common.Application.DPuntosDV odaplaPDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oepdv = odaplaPDV.Actualizar_PDVPlanningPDVClient(iid_ClientPDV, lcod_Oficina, iid_malla, iid_sector, pdv_contact);
            odaplaPDV = null;
            return oepdv;
        }
        /// <summary>
        /// Permite Consultar relación de Punto de Venta a Cliente en el nuevo maestro PDVCliente
        /// 21/09/2010 Magaly jiménez
        /// Modificación: se agrega campo de cod_Oficina
        /// 12/11/2010 Magaly Jiménez
        /// </summary>
        /// <param name="iiCompany_id"></param>
        /// <param name="iid_PointOfsale"></param>
        /// <param name="sClientPDV_Code"></param>
        /// <returns>dtPDVClient</returns>
        public DataTable ConsultarPDVClient(int iiCompany_id, string spdv_codCountry, string spdv_codChannel, int iidNodeComType, string sNodeCommercial)
        {
            Lucky.Data.Common.Application.DPuntosDV odsePDV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oePDV = new EPuntosDV();
            DataTable dtPDVClient = odsePDV.ConsultarPDVClient(iiCompany_id, spdv_codCountry, spdv_codChannel, iidNodeComType, sNodeCommercial);
            odsePDV = null;
            return dtPDVClient;
        }
        /// <summary>
        /// llena grilla de consulta
        /// </summary>
        /// <param name="iiCompany_id"></param>
        /// <param name="spdv_codCountry"></param>
        /// <param name="spdv_codChannel"></param>
        /// <param name="iidNodeComType"></param>
        /// <param name="sNodeCommercial"></param>
        /// <returns></returns>
        public DataTable ConsultarPDVClientGrilla(int iiCompany_id, string spdv_codCountry, string spdv_codChannel, int iidNodeComType, string sNodeCommercial)
        {
            Lucky.Data.Common.Application.DPuntosDV odsePDVGV = new Lucky.Data.Common.Application.DPuntosDV();
            EPuntosDV oePDVGVGV = new EPuntosDV();
            DataTable dtPDVClientGV = odsePDVGV.ConsultarPDVClientGrilla(iiCompany_id, spdv_codCountry, spdv_codChannel, iidNodeComType, sNodeCommercial);
            odsePDVGV = null;
            return dtPDVClientGV;
        }


        /// <summary>
        /// Descripción : Método para consultar los puntos de venta asignados a un planning general
        ///               se crea este método debido a que por Web Services generaba problemas ya que los puntos de venta
        ///               presentaban en sus datos caracteres especiales 
        /// Creado por  : Ing. Mauricio Ortiz
        /// Fecha       : 21/10/2010        
        /// </summary>
        /// <param name="sid_planning"></param>
        /// <returns>dtpdvplanning</returns>
        public DataTable Consultar_PDVPlanningGeneral(string sid_planning ,int imalla ,int isector)
        {
            DPlanning odPlanning = new DPlanning();
            DataTable dtpdvplanning = odPlanning.Consultar_PDVPlanningGeneral(sid_planning, imalla,isector);
            return dtpdvplanning;
        }

        public List<PointOfSaleMarker> obtener_pos_gis(string id_planning)
        {
            List<PointOfSaleMarker> listaposgismarkers = new List<PointOfSaleMarker>();
            DPuntosDV dpointofsale = new DPuntosDV();
            DataTable dtpointofsale = new DataTable();

            dtpointofsale = dpointofsale.obtener_pos_gis(id_planning);

            for (int i = 0; i < dtpointofsale.Rows.Count; i++)
            {
                PointOfSaleMarker posm = new PointOfSaleMarker();
                posm.Id_pointofsale = Convert.ToInt32(dtpointofsale.Rows[i]["id_PointOfsale"]);
                posm.Pdv_name = dtpointofsale.Rows[i]["pdv_Name"].ToString();
                posm.Commercialnodename = dtpointofsale.Rows[i]["commercialNodeName"].ToString();
                posm.Pdv_address = dtpointofsale.Rows[i]["pdv_Address"].ToString();
                posm.Posgis_latitud = dtpointofsale.Rows[i]["posgis_latitud"].ToString();
                posm.Posgis_longitud = dtpointofsale.Rows[i]["posgis_longitud"].ToString();
                posm.Posgis_iconmarker = dtpointofsale.Rows[i]["posgis_iconmarker"].ToString();
                posm.Posgis_informacion = dtpointofsale.Rows[i]["posgis_informacion"].ToString();
                listaposgismarkers.Add(posm);
            }

            return listaposgismarkers;
        }
    }
}