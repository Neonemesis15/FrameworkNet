using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{
    /// <summary>
    /// Clase:              EPuntosDV
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  12/05/2009
    /// Requerimientos No:  «Functional» SIGE-ARF-050 Gestionar Maestro de Puntos de Venta
    ///                     «Functional» SIGE-ARF-096 Crear Puntos de Venta
    ///                     «Functional» SIGE-ARF-097 Consultar Puntos de Venta
    ///                     «Functional» SIGE-ARF-153 Actualizar Puntos de Venta
    ///                     «Functional» SIGE-ARF-098 Inactivar Puntos de Venta
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase PuntosDV
    ///                     permite al administrador del sistema gestionar los Puntos de venta, por medio de las 
    ///                     operaciones de Crear, Consultar, Actualizar e Inactivar puntos de venta.
    ///                     El sistema SIGE  Debe proveer un formulario para registrar los Puntos de Venta(PDV) 
    ///                     asociados a los clientes a los cuales Lucky provee servicios. 
    ///                     Este maestro permitira Crear, actualizar y/o inactivar PDV.
    ///                     Consideraciones: La estructura de este maestro se diseñara conforme a la información 
    ///                     entregada por los lideres Usuarios. ver referencia en files:
    ///                     C:\SIGE\Artefactos Socializados\Puntos de Venta 2003.xls
    /// Modificaciones:     18/09/2009 Ing. Mauricio Ortiz Se adiciono el campo id_typeDocument,id_Segment 
    ///                     Se reorganizan campos de la tabla, Se elimina el campo pdvidMarketChain,
    ///                     Se elimina el campo pdvcodTypetrade
    ///                     24/09/2009 Ing. Mauricio Ortiz se adiciono los atributos lid_ClientPDV, lCompany_id, 
    ///                     lClientPDV_Status, lClientPDV_CreateBy, lClientPDV_DateBy, lClientPDV_ModiBy, 
    ///                     lClientPDV_DateModiBy para los clientes de cada punto de venta 
    ///                     25/08/2010 se quita private string lpdvCode ya no aplica se pasa para la tabla PointOfSale_Client
    ///                     se crea  private string lClientPDV_Code q recibira el codigo para cada cliente. Ing. Mauricio Ortiz
    ///                     26/08/2010 se agrega id_sector. Ing. Mauricio Ortiz
    ///   modificación se agrega cod_oficina para maestro de PDV Cliente.
    ///   11/11/2010 Magaly Jiménez
    ///    modificación se agrega Id_Dex para maestro de PDV .
    ///   02/04/2011 Magaly Jiménez
    ///   
    /// Modificación se agrega pdv_Alias para maestro de PDV.
    /// 17/08/2011
    ///                                          
    /// </summary>

    public class EPuntosDV
    {
        private int lid_PointOfsale;
        private string lid_typeDocument;
        private string lpdvRegTax;
        private string lpdvcontact1;
        private string lpdvposition1;
        private string lpdvcontact2;
        private string lpdvposition2;
        private string lpdvRazónSocial;
        private string lpdvName;
        private string lpdvPhone;
        private string lpdvAnexo;
        private string lpdvFax;
        private string lpdvcodCountry;
        private string lnameCountry;
        private string lpdvcodDepartment;
        private string lnameDepartament;
        private string lpdvcodProvince;
        private string lnameprovince;
        private string lpdvcodDistrict;
        private string lnameDistrict;
        private string lpdvcodCommunity;
        private string lnameComunity;
        private string lpdvAddress;
        private string lpdvemail;
        private string lpdvcodChannel;
        private string lnameChannel;
        private int lidNodeComType;
        private string lnameNodeType;
        private string lNodeCommercial;
        private string lnameNodeComercial;
        private int lid_Segment;
        private string lnameSegment;
        private bool lpdvstatus;
        private string lPdvCreateBy;
        private DateTime lPdvDateBy;
        private string lPdvModiBy;
        private DateTime lPdvDateModiBy;

        private int lid_ClientPDV;
        private int lCompany_id;
        private string lClientPDV_Code;
        private int lid_sector;
        private long lcod_Oficina;
        private int lId_Dex;
        private bool lClientPDV_Status;
        private string lClientPDV_CreateBy;
        private DateTime lClientPDV_DateBy;
        private string lClientPDV_ModiBy;
        private DateTime lClientPDV_DateModiBy;


        public int id_PointOfsale
        {
            get { return this.lid_PointOfsale; }
            set { this.lid_PointOfsale = value; }
        }

        public string id_typeDocument
        {
            get { return this.lid_typeDocument; }
            set { this.lid_typeDocument = value; }
        }

        public string pdvRegTax
        {
            get { return this.lpdvRegTax; }
            set { this.lpdvRegTax = value; }
        }

        public string pdvcontact1
        {
            get { return this.lpdvcontact1; }
            set { this.lpdvcontact1 = value; }
        }

        public string pdvposition1
        {
            get { return this.lpdvposition1; }
            set { this.lpdvposition1 = value; }
        }

        public string pdvcontact2
        {
            get { return this.lpdvcontact2; }
            set { this.lpdvcontact2 = value; }
        }

        public string pdvposition2
        {
            get { return this.lpdvposition2; }
            set { this.lpdvposition2 = value; }
        }

        public string pdvRazónSocial
        {
            get { return this.lpdvRazónSocial; }
            set { this.lpdvRazónSocial = value; }
        }

        public string pdvName
        {
            get { return this.lpdvName; }
            set { this.lpdvName = value; }
        }

        public string pdvPhone
        {
            get { return this.lpdvPhone; }
            set { this.lpdvPhone = value; }
        }

        public string pdvAnexo
        {
            get { return this.lpdvAnexo; }
            set { this.lpdvAnexo = value; }
        }

        public string pdvFax
        {
            get { return this.lpdvFax; }
            set { this.lpdvFax = value; }
        }

        public string pdvcodCountry
        {
            get { return this.lpdvcodCountry; }
            set { this.lpdvcodCountry = value; }
        }

        public string nameCountry
        {
            get { return this.lnameCountry; }
            set { this.lnameCountry = value; }
        }

        public string pdvcodDepartment
        {
            get { return this.lpdvcodDepartment; }
            set { this.lpdvcodDepartment = value; }
        }

        public string nameDepartament
        {
            get { return this.lnameDepartament; }
            set { this.lnameDepartament = value; }
        }

        public string pdvcodProvince
        {
            get { return this.lpdvcodProvince; }
            set { this.lpdvcodProvince = value; }
        }

        public string nameprovince
        {
            get { return this.lnameprovince; }
            set { this.lnameprovince = value; }
        }

        public string pdvcodDistrict
        {
            get { return this.lpdvcodDistrict; }
            set { this.lpdvcodDistrict = value; }
        }

        public string nameDistrict
        {
            get { return this.lnameDistrict; }
            set { this.lnameDistrict = value; }
        }

        public string pdvcodCommunity
        {
            get { return this.lpdvcodCommunity; }
            set { this.lpdvcodCommunity = value; }
        }

        public string nameComunity
        {
            get { return this.lnameComunity; }
            set { this.lnameComunity = value; }
        }


        public string pdvAddress
        {
            get { return this.lpdvAddress; }
            set { this.lpdvAddress = value; }
        }

        public string pdvemail
        {
            get { return this.lpdvemail; }
            set { this.lpdvemail = value; }
        }

        public string pdvcodChannel
        {
            get { return this.lpdvcodChannel; }
            set { this.lpdvcodChannel = value; }
        }

        public string nameChannel
        {
            get { return this.lnameChannel; }
            set { this.lnameChannel = value; }
        }

        public int idNodeComType
        {
            get { return this.lidNodeComType; }
            set { this.lidNodeComType = value; }

        }

        public string nameNodeType
        {
            get { return this.lnameNodeType; }
            set { this.lnameNodeType = value; }
        }


        //Se agrega esta propiedad a PDV Ing. Carlos Hernandez 09/06/2009
        public string NodeCommercial
        {
            get { return this.lNodeCommercial; }
            set { this.lNodeCommercial = value; }
        }
        public string nameNodeComercial
        {
            get { return this.lnameNodeComercial; }
            set { this.lnameNodeComercial = value; }
        }
        //Se agrega esta propiedad a PDV Ing. Mauricio Ortiz 17/09/2009
        public int id_Segment
        {
            get { return this.lid_Segment; }
            set { this.lid_Segment = value; }
        }

        //Se agrega esta propiedad a PDV Ing. Magaly Jimenez 02/04/2011
        public int Id_Dex
        {
            get { return this.lId_Dex; }
            set { this.lId_Dex = value; }
        }
        

        public string nameSegment
        {
            get { return this.lnameSegment; }
            set { this.lnameSegment = value; }
        }

        public bool pdvstatus
        {
            get { return this.lpdvstatus; }
            set { this.lpdvstatus = value; }
        }

        public string PdvCreateBy
        {
            get { return this.lPdvCreateBy; }
            set { this.lPdvCreateBy = value; }
        }

        public DateTime PdvDateBy
        {
            get { return this.lPdvDateBy; }
            set { this.lPdvDateBy = value; }
        }

        public string PdvModiBy
        {
            get { return this.lPdvModiBy; }
            set { this.lPdvModiBy = value; }
        }

        public DateTime PdvDateModiBy
        {
            get { return this.lPdvDateModiBy; }
            set { this.lPdvDateModiBy = value; }
        }

        public int id_ClientPDV
        {
            get { return this.lid_ClientPDV; }
            set { this.lid_ClientPDV = value; }
        }

        public string ClientPDV_Code
        {
            get { return this.lClientPDV_Code; }
            set { this.lClientPDV_Code = value; }
        }

        public int id_sector
        {
            get { return this.lid_sector; }
            set { this.lid_sector = value; }
        }
        public long cod_Oficina
        {
            get { return this.lcod_Oficina; }
            set { this.lcod_Oficina = value; }
        }
        
        public int Company_id
        {
            get { return this.lCompany_id; }
            set { this.lCompany_id = value; }

        }
        public bool ClientPDV_Status
        {
            get { return this.lClientPDV_Status; }
            set { this.lClientPDV_Status = value; }
        }
        public string ClientPDV_CreateBy
        {
            get { return this.lClientPDV_CreateBy; }
            set { this.lClientPDV_CreateBy = value; }
        }
        public DateTime ClientPDV_DateBy
        {
            get { return this.lClientPDV_DateBy; }
            set { this.lClientPDV_DateBy = value; }
        }
        public string ClientPDV_ModiBy
        {
            get { return this.lClientPDV_ModiBy; }
            set { this.lClientPDV_ModiBy = value; }
        }
        public DateTime ClientPDV_DateModiBy
        {
            get { return this.lClientPDV_DateModiBy; }
            set { this.lClientPDV_DateModiBy = value; }
        }
    }
}
