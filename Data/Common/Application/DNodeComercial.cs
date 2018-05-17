using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lucky.Entity.Common.Application;

namespace Lucky.Data.Common.Application
{
    /// <summary>
    /// Clase: DNodeComercial
    /// Creado Por: Ing. Carlos Alberto Hernandez R
    /// Fecha de Creacion: 13/06/2009
    /// Descripcion: Define los metodos transaccionales para NodeComercial    
    /// Requerimiento No <>
    /// </summary>

    public class DNodeComercial
    {
        private Conexion oConn;
        public DNodeComercial() 
        {
            UserInterface oUserInterface = new UserInterface();            
            oUserInterface = null;
        }

        /// <summary>
        ///     Metodo para Registrar Nodos Comerciales
        ///     Modificaciones: 26-06-09 Se elimina el parametro sNodeCommercial es un identity Ing. Mauricio Ortiz
        ///     Modificaciones: 10-06-2011 Se agrega parámetros para registrar relación entre el Nodo Comercial y Canales. Angel Ortiz.
        ///     Modificaciones: 10-06-2011 Se agrega parámetro para insertar registro de dirección. Angel Ortiz.
        /// </summary>
        public ENodeComercial RegistrarNodeComercial(string scommercialNodeName, int iidNodeComType, int icorporacionId, string sdireccion, bool bNodeCommercialStatus,
          string sNodeCommercialCreateBy, DateTime tNodeCommercialDateBy, string sNodeCommercialModiBy, DateTime tNodeCommercialDatemodiBy, string sNodeCommercial_codCountry, string
            sNodeCommercial_codDepartment, string sNodeCommercial_codProvince, string sNodeCommercial_codDistrict, string sNodeCommercial_codCommunity) 
        {
            oConn = new Conexion(1);
            int idNode = Convert.ToInt32(oConn.ejecutarEscalar("UP_WEBSIGE_REGISTERNODECOMERCIAL", scommercialNodeName, iidNodeComType, icorporacionId, sdireccion, bNodeCommercialStatus,
                sNodeCommercialCreateBy, tNodeCommercialDateBy, sNodeCommercialModiBy, tNodeCommercialDatemodiBy, sNodeCommercial_codCountry, sNodeCommercial_codDepartment, sNodeCommercial_codProvince, sNodeCommercial_codDistrict, sNodeCommercial_codCommunity));
            ENodeComercial oernodecome = new ENodeComercial(); 
            oernodecome.NodeCommercial = idNode;
            oernodecome.commercialNodeName = scommercialNodeName;
            oernodecome.idNodeComType = iidNodeComType;
            oernodecome.id_corporacion = icorporacionId;
            oernodecome.NodeCommercialDireccion = sdireccion;
            oernodecome.NodeCommercialStatus = bNodeCommercialStatus;
            oernodecome.NodeCommercialCreateBy = sNodeCommercialCreateBy;
            oernodecome.NodeCommercialDateBy = tNodeCommercialDateBy;
            oernodecome.NodeCommercialModiBy = sNodeCommercialModiBy;
            oernodecome.NodeCommercialDatemodiBy = tNodeCommercialDatemodiBy;
            oernodecome.NodeCommercial_codCountry = sNodeCommercial_codCountry;
            oernodecome.NodeCommercial_codDepartment = sNodeCommercial_codDepartment;
            oernodecome.NodeCommercial_codProvince = sNodeCommercial_codProvince;
            oernodecome.NodeCommercial_codDistrict = sNodeCommercial_codDistrict;
            oernodecome.NodeCommercial_codCommunity = sNodeCommercial_codCommunity;

            return oernodecome;
        }

        /// <summary>
        /// Registra la relacion NOdo Comercial con Canal.
        /// 10/06/2011 - Angel Ortiz.        
        /// </summary>        
        public int RegistrarNodeComercialXChannel(int iidNode, int iidChannel, int iidCompany, bool status, string createby)
        {
            oConn = new Conexion(1);
            int st = 0;
            st = Convert.ToInt16(oConn.ejecutarEscalar("UP_WEBXPLORA_AD_REGISTRAR_NODECOMXCHANNEL", iidNode, iidChannel, iidCompany, status, createby));
            return st;
        }

        /// <summary>
        /// Inserta Nodo Comercial en BD intermedia
        /// 02/02/2011 Magaly Jiménez
        /// Modificaciones: 10/06/2011 Se agrega código para conectar directamente a la DB Intermedia y hacer la inserción del registro. Angel Ortiz.
        /// </summary>        
        public int RegistrarNodeComercialTMP(int iidNode, string scommercialNodeName, bool bNodeCommercialStatus)
        {
            Conexion cn = new Conexion(2);
            int st = 0;
            int status = bNodeCommercialStatus ? 1 : 0; //convierte de bool a int.
            cn.ejecutarDataTable("UP_WEBXPLORA_AD_REGISTERNODECOMERCIALTMP", iidNode, scommercialNodeName);            
            return st;
        }

        /// <summary>
        /// Inserta relacion Cadena X Canal
        /// 13/06/2011 Angel Ortiz
        /// </summary>   
        public int RegistrarNodeComercialXChannelTMP(int iidClient, int iidChannel, int iidNode, bool status)
        {
            oConn = new Conexion(2);
            int st = 0;
            st = Convert.ToInt16(oConn.ejecutarEscalar("UP_WEBXPLORA_AD_REGISTERCADENA_X_CANAL", iidClient, iidChannel, iidNode, status));
            return st;
        }

        /// <summary>
        /// Metodo para consultar Nodos Comerciales
        /// Modificaciones: 26-06-09 Se elimina  el parametro sNodeCommercial n/a para la consulta Ing. Mauricio Ortiz
        /// Modificaciones: 14-08-1 Se agrega los campos de corporación.
        /// </summary>

        public DataTable ConsultarNodeComercial(string snamenodeComercial, int idtipo, int idCorporacion)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_SEARCHNODECOMERCIAL", snamenodeComercial, idtipo, idCorporacion);
            ENodeComercial oecnodecome = new ENodeComercial();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        oecnodecome.NodeCommercial = Convert.ToInt32(dt.Rows[i]["NodeCommercial"].ToString().Trim());
                        oecnodecome.commercialNodeName = dt.Rows[i]["commercialNodeName"].ToString().Trim();
                        oecnodecome.idNodeComType = Convert.ToInt32(dt.Rows[i]["idNodeComType"].ToString().Trim());
                        oecnodecome.NodeComType_name = dt.Rows[i]["NodeComType_name"].ToString().Trim();
                        oecnodecome.NodeCommercialDireccion = dt.Rows[i]["NodeCommercial_Direccion"].ToString().Trim();
                        oecnodecome.id_corporacion = Convert.ToInt32(dt.Rows[i]["NodeCommercial_corp_id"].ToString().Trim());
                        oecnodecome.corporacion_name = dt.Rows[i]["corp_name"].ToString().Trim();
                        oecnodecome.NodeCommercialStatus = Convert.ToBoolean(dt.Rows[i]["NodeCommercial_Status"].ToString().Trim());
                        oecnodecome.NodeCommercialCreateBy = dt.Rows[i]["NodeCommercial_CreateBy"].ToString().Trim();
                        oecnodecome.NodeCommercialDateBy = Convert.ToDateTime(dt.Rows[i]["NodeCommercial_DateBy"].ToString().Trim());
                        oecnodecome.NodeCommercialModiBy = dt.Rows[i]["NodeCommercial_ModiBy"].ToString().Trim();
                        oecnodecome.NodeCommercial_codCountry = dt.Rows[i]["NodeCommercial_codCountry"].ToString().Trim();
                        oecnodecome.Country_name = dt.Rows[i]["Name_Country"].ToString().Trim();
                        oecnodecome.NodeCommercial_codDepartment = dt.Rows[i]["NodeCommercial_codDepartment"].ToString().Trim();
                        oecnodecome.Department_name = dt.Rows[i]["Name_dpto"].ToString().Trim();
                        oecnodecome.NodeCommercial_codProvince = dt.Rows[i]["NodeCommercial_codProvince"].ToString().Trim();
                        oecnodecome.Province_name = dt.Rows[i]["Name_City"].ToString().Trim();
                        oecnodecome.NodeCommercial_codDistrict = dt.Rows[i]["NodeCommercial_codDistrict"].ToString().Trim();
                        oecnodecome.District_name = dt.Rows[i]["Name_Local"].ToString().Trim();
                        oecnodecome.NodeCommercial_codCommunity = dt.Rows[i]["NodeCommercial_codCommunity"].ToString().Trim();
                        oecnodecome.Community_name = dt.Rows[i]["Name_Community"].ToString().Trim();
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
        /// Metodo para consultar la relacion de Nodos Comerciales X Canal
        /// 28/06/2011 - Angel Ortiz
        /// 
        /// </summary>

        public DataTable ConsultarNodeComercialXChannel(int idCliente, int NodeComercial)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_AD_WEBXPLORA_SEARCHNODECOMMERCIAL_X_CHANNEL", idCliente, NodeComercial);
            return dt;            
        }

        /// <summary>
        /// Metodo para Actualizar Nodos Comerciales
        /// Modificaciones: 26-06-09 Se cambia el parametro sNodeCommercial es un int Ing. Mauricio Ortiz
        /// Se agrega parametro para el atributo direccion. - Angel Ortiz 30/06/2011
        /// </summary>


        public ENodeComercial ActualizarNodeComercial(int iNodeCommercial, string scommercialNodeName, int iidNodeComType , int iIdCorporacion , string sNodeCommercial_Direccion, bool bNodeCommercialStatus,
           string sNodeCommercialModiBy, DateTime tNodeCommercialDatemodiBy, string sNodeCommercial_codCountry, string
            sNodeCommercial_codDepartment, string sNodeCommercial_codProvince, string sNodeCommercial_codDistrict, string sNodeCommercial_codCommunity)
        {
            oConn = new Conexion(1);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_ACTUALIZARNODECOMERCIAL", iNodeCommercial, scommercialNodeName, iidNodeComType, iIdCorporacion, sNodeCommercial_Direccion, bNodeCommercialStatus, sNodeCommercialModiBy, 
              tNodeCommercialDatemodiBy, sNodeCommercial_codCountry,sNodeCommercial_codDepartment,sNodeCommercial_codProvince,sNodeCommercial_codDistrict,sNodeCommercial_codCommunity);        
            ENodeComercial oeanodecome = new ENodeComercial();
            oeanodecome.NodeCommercial = iNodeCommercial;
            oeanodecome.commercialNodeName = scommercialNodeName;
            oeanodecome.idNodeComType = iidNodeComType;
            oeanodecome.id_corporacion = iIdCorporacion;
            oeanodecome.NodeCommercialDireccion = sNodeCommercial_Direccion;
            oeanodecome.NodeCommercialStatus = bNodeCommercialStatus;
            oeanodecome.NodeCommercialModiBy = sNodeCommercialModiBy;
            oeanodecome.NodeCommercialDatemodiBy = tNodeCommercialDatemodiBy;
            oeanodecome.NodeCommercial_codCountry = sNodeCommercial_codCountry;
            oeanodecome.NodeCommercial_codDepartment = sNodeCommercial_codDepartment;
            oeanodecome.NodeCommercial_codProvince = sNodeCommercial_codProvince;
            oeanodecome.NodeCommercial_codDistrict = sNodeCommercial_codDistrict;
            oeanodecome.NodeCommercial_codCommunity = sNodeCommercial_codCommunity;
            return oeanodecome;


        }

        /// <summary>
        /// Método para Actualizar Nodos Comerciales x Canales
        /// Angel Ortiz 30/06/2011
        /// </summary>
        
        public int ActualizarNodeComercialXChannel(int iNodeCommercial, int iid_Channel, int iCompany_id, bool status, string sNodeCommercialModiBy)
        {
            int val=0;
            oConn = new Conexion(1);
            try{
                DataTable dt = oConn.ejecutarDataTable("UP_WEBSIGE_AD_ACTUALIZARNODECOMERCIALXCHANNEL", iNodeCommercial, iid_Channel, iCompany_id, status, sNodeCommercialModiBy);
                //return oeanodecome;
                val = 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return val;
        }

        /// <summary>
        /// Actualiza nombre de cadena o nodo comercial y estado en DB intermedia
        /// 03/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iNodeCommercial"></param>
        /// <param name="scommercialNodeName"></param>
        /// <param name="bNodeCommercialStatus"></param>
        /// <returns></returns>
        
        public ENodeComercial ActualizarNodeComercialTMP(int iNodeCommercial, string scommercialNodeName,  bool bNodeCommercialStatus)
        {
            oConn = new Conexion(2);
            DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARNODECOMERCIALDENODOTMP", iNodeCommercial, scommercialNodeName, bNodeCommercialStatus);
            ENodeComercial oeanodecomeCadena = new ENodeComercial();
            //oeanodecome.NodeCommercial = iNodeCommercial;
            //oeanodecome.commercialNodeName = scommercialNodeName;
            //oeanodecome.NodeCommercialStatus = bNodeCommercialStatus;
 
            return oeanodecomeCadena;


        }

        /// <summary>
        /// Actualiza la relacion NodoComercial(Cadena) con canal.
        /// 30/06/2011 Angel Ortiz
        /// </summary>

        public int ActualizarNodeComercialXChannelTMP(int iCompany_id, int iNodeCommercial, int iid_Channel, bool bNodeCommercialStatus)
        {
            int val=0;
            oConn = new Conexion(2);
            try
            {
                DataTable dt = oConn.ejecutarDataTable("UP_WEBXPLORA_AD_ACTUALIZARNODECOMERCIALXCHANNEL_TMP", iCompany_id, iNodeCommercial, iid_Channel, bNodeCommercialStatus);
                val = 1;
            }
            catch (Exception ex) 
            {
                throw ex;
            }

            return val;
        }

        /// <summary>
        /// Ontener 
        /// 22/03/2011 Ditmar Estrada
        /// </summary>
        /// <returns></returns>


        public List<ENodeComercial> Get_NodeComercialBy_idPlanning(string sid_Planning)
        {
            oConn = new Conexion(1);
            List<ENodeComercial> oListENodeComercial = new List<ENodeComercial>();
            try
            {
                SqlDataReader sdr = oConn.ejecutarDataReader("UP_WEBXPLORA_AD_OBTENER_NODECOMERCIAL_BY_idPlanning", sid_Planning);
               while (sdr.Read())
               { 
                   ENodeComercial oENodeComercial=new ENodeComercial();
                   oENodeComercial.NodeCommercial = (Int32)sdr.GetValue(sdr.GetOrdinal("id_NodeCommercial"));
                   oENodeComercial.commercialNodeName = (String)sdr.GetValue(sdr.GetOrdinal("commercialNodeName"));
                   oENodeComercial.idNodeComType = (Int32)sdr.GetValue(sdr.GetOrdinal("idNodeComType"));
                   oENodeComercial.NodeCommercialStatus = (Boolean)sdr.GetValue(sdr.GetOrdinal("NodeCommercial_Status"));
                   oENodeComercial.NodeCommercialCreateBy = (String)sdr.GetValue(sdr.GetOrdinal("NodeCommercial_CreateBy"));
                   oENodeComercial.NodeCommercialDateBy = (DateTime)sdr.GetValue(sdr.GetOrdinal("NodeCommercial_DateBy"));
                   oENodeComercial.NodeCommercialModiBy = (String)sdr.GetValue(sdr.GetOrdinal("NodeCommercial_ModiBy"));
                   oENodeComercial.NodeCommercialDatemodiBy = (DateTime)sdr.GetValue(sdr.GetOrdinal("NodeCommercial_DatemodiBy"));

                   oListENodeComercial.Add(oENodeComercial);
               }
               sdr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oListENodeComercial;
        }
    }
}