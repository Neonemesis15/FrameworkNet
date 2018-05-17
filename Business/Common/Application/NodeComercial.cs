using System;
using System.Collections.Generic;
using System.Data;
using Lucky.Data.Common.Application;
using Lucky.Entity.Common.Application;

namespace Lucky.Business.Common.Application
{
    /// <summary>
    /// Clase:NodeComercial
    /// Creada Por: Ing. Carlos Alberto Hernandez R
    /// Fecha de Creacion:13/06/2009
    /// Descripcion: Define los metodos del Negocio para Nodos COmerciales
    /// Requerimiento No <>
    /// </summary>

   public class NodeComercial
    {
        public NodeComercial() 
        {
            //Define el Constructor por Defecto
        }

        /// <summary>
        ///  Método para Registrar Nodos Comerciales
        ///  Modificaciones: 26-06-09 Se elimina el parametro sNodeCommercial es un identity Ing. Mauricio Ortiz.
        ///  Modificaciones: 10-06-11 Se agrega parámetros para registrar relación entre el Nodo Comercial y Canales. Angel Ortiz.
        ///  Modificaciones: 12-08-11 Se agrega el párámetro iIdCorporacion para registrar por corporación(no obligatorio). Angel Ortiz.
        /// </summary>
        public ENodeComercial RegistrarNodeComercial(string scommercialNodeName, int iidNodeComType , int iIdCorporacion ,string sdireccion, bool bNodeCommercialStatus,
            string sNodeCommercialCreateBy, DateTime tNodeCommercialDateBy, string sNodeCommercialModiBy, DateTime tNodeCommercialDatemodiBy, string sNodeCommercial_codCountry, string
            sNodeCommercial_codDepartment, string sNodeCommercial_codProvince, string sNodeCommercial_codDistrict, string sNodeCommercial_codCommunity )
        {
            DNodeComercial odrnodecome = new DNodeComercial();
            ENodeComercial oernodecome = odrnodecome.RegistrarNodeComercial(scommercialNodeName, iidNodeComType, iIdCorporacion, sdireccion, bNodeCommercialStatus,
                sNodeCommercialCreateBy, tNodeCommercialDateBy, sNodeCommercialModiBy, tNodeCommercialDatemodiBy, sNodeCommercial_codCountry, sNodeCommercial_codDepartment, sNodeCommercial_codProvince, sNodeCommercial_codDistrict, sNodeCommercial_codCommunity);
            odrnodecome = null;
            return oernodecome;
        }

        /// <summary>
        ///  Método para Registrar las relaciones entre los Nodos Comerciales y los Canales.       
        ///  10-06-11 Se agrega Método para el registro de la relación de los Nodos COmerciales con Canal. Angel Ortiz.
        /// </summary>
        public int RegistrarNodeComercialXChannel(int iidNode, int iidChannel, int iidCompany, bool status, string createby)
        {
            DNodeComercial odrnodecome = new DNodeComercial();
            int st=0;
            st = odrnodecome.RegistrarNodeComercialXChannel(iidNode, iidChannel, iidCompany, status, createby);           
            return st;
        }

        /// <summary>
        /// Inserta nodo comercial en BD intermedia
        /// 02/02/2011 Magaly Jiménez
        /// Modificaciones: 10/06/2011 - Se agregaron parámetros para insertar directamente en la tabla de la DB Intermedia - Angel Ortiz
        /// </summary>
        public int RegistrarNodeComercialTMP(int iidNode, string scommercialNodeName, bool bNodeCommercialStatus)
        {
            DNodeComercial odrnodecometmp = new DNodeComercial();
            int st = 0;
            st = odrnodecometmp.RegistrarNodeComercialTMP(iidNode, scommercialNodeName, bNodeCommercialStatus);
            odrnodecometmp = null;
            return st;
        }

        /// <summary>
        /// Inserta nodo comercial en BD intermedia
        /// 02/02/2011 Magaly Jiménez
        /// Modificaciones: 10/06/2011 - Se agregaron parámetros para insertar directamente en la tabla de la DB Intermedia - Angel Ortiz
        /// </summary>
        public int RegistrarNodeComercialXChannelTMP(int iidClient, int iidChannel, int iidNode, bool status)
        {
            DNodeComercial odrnodecometmp = new DNodeComercial();
            int st = 0;
            st = odrnodecometmp.RegistrarNodeComercialXChannelTMP(iidClient, iidChannel, iidNode, status);
            odrnodecometmp = null;
            return st;
        }

        /// <summary>
        /// Metodo para consultar Nodos Comerciales
        ///  Modificaciones: 26-06-09 Se elimina el parametro sNodeCommercial n/a para la consulta  Ing. Mauricio Ortiz
        /// </summary>
        public DataTable ConsultarNodeComercial(string snamenodeComercial, int idCliente, int idCorporacion)
        {
            DNodeComercial odcnodecome = new DNodeComercial();
            DataTable dt = odcnodecome.ConsultarNodeComercial(snamenodeComercial, idCliente, idCorporacion);
            return dt;       
        }

        /// <summary>
        /// Metodo para consultar relaciones de Nodos Comerciales con Canales
        /// 28/06/2011 -  Angel Ortiz
        /// </summary>
        public DataTable ConsultarNodeComercialXChannel(int idCliente, int NodeComercial)
        {
            DNodeComercial odcnodecome = new DNodeComercial();
            DataTable dt = odcnodecome.ConsultarNodeComercialXChannel(idCliente, NodeComercial);
            return dt;
        }
        
       
       /// <summary>
        /// Metodo para Actualizar Nodos Comerciales
        /// Modificaciones: 26-06-09 Se cambia el parametro sNodeCommercial es un int Ing. Mauricio Ortiz
        /// Modificaciones: 15-08-11 Se agrega el parametro iIdCorporacion de tipo int. Joseph Gonzales
        /// </summary>
        public ENodeComercial ActualizarNodeComercial(int iNodeCommercial, string scommercialNodeName, int iidNodeComType, int iIdCorporacion ,string sNodeCommercial_Direccion, bool bNodeCommercialStatus,
            string sNodeCommercialModiBy, DateTime tNodeCommercialDatemodiBy, string sNodeCommercial_codCountry, string
            sNodeCommercial_codDepartment, string sNodeCommercial_codProvince, string sNodeCommercial_codDistrict, string sNodeCommercial_codCommunity)
        {
            DNodeComercial odanodecome = new DNodeComercial();
            ENodeComercial oeanodecome = odanodecome.ActualizarNodeComercial(iNodeCommercial, scommercialNodeName, iidNodeComType, iIdCorporacion, sNodeCommercial_Direccion, bNodeCommercialStatus, sNodeCommercialModiBy, tNodeCommercialDatemodiBy, sNodeCommercial_codCountry,sNodeCommercial_codDepartment,sNodeCommercial_codProvince,sNodeCommercial_codDistrict,sNodeCommercial_codCountry);
            odanodecome = null;
            return oeanodecome;       
        }


        /// <summary>
        /// Metodo para Actualizar Nodos Comerciales x Canales
        /// Angel Ortiz 30/06/2011
        /// </summary>
        public int ActualizarNodeComercialXChannel(int iNodeCommercial, int iid_Channel, int iCompany_id, bool status, string sNodeCommercialModiBy)
        {
            DNodeComercial odanodecome = new DNodeComercial();
            int oeanodecome = odanodecome.ActualizarNodeComercialXChannel(iNodeCommercial, iid_Channel, iCompany_id, status, sNodeCommercialModiBy);            
            return oeanodecome;
        }


        /// <summary>
        /// Actualiza nombre de cadena o nodo comercial y estado en Bd intermedia
        /// 03/02/2011 Magaly Jiménez
        /// </summary>
        /// <param name="iNodeCommercial"></param>
        /// <param name="scommercialNodeName"></param>
        /// <param name="bNodeCommercialStatus"></param>
        /// <returns></returns>
        public ENodeComercial ActualizarNodeComercialTMP(int iNodeCommercial, string scommercialNodeName,  bool bNodeCommercialStatus)
        {
            DNodeComercial odanodecomecadena = new DNodeComercial();
            ENodeComercial oeanodecomecadena = odanodecomecadena.ActualizarNodeComercialTMP(iNodeCommercial, scommercialNodeName, bNodeCommercialStatus);
            odanodecomecadena = null;
            return oeanodecomecadena;
        }

        /// <summary>
        /// Actualiza la relacion Cadena con Canal
        /// 30/06/2011 - Angel Ortiz
        /// </summary>
        /// <param name="iNodeCommercial"></param>
        /// <param name="scommercialNodeName"></param>
        /// <param name="bNodeCommercialStatus"></param>
        /// <returns></returns>
        public int ActualizarNodeComercialXChannelTMP(int iCompany_id, int iNodeCommercial, int iid_Channel, bool bNodeCommercialStatus)
        {
            DNodeComercial odanodecomecadena = new DNodeComercial();
            int oeanodecomecadena = odanodecomecadena.ActualizarNodeComercialXChannelTMP(iCompany_id, iNodeCommercial, iid_Channel, bNodeCommercialStatus);            
            return oeanodecomecadena;
        }

        /// <summary>
        /// Obtiene en una lista generica los objetos de NodeCompercial
        /// 22/03/2011 Ditmar Estrada
        /// </summary>
        /// <param name="iidPlanning"></param>
        /// <returns></returns>
        public List<ENodeComercial> Get_NodeComercialBy_idPlanning(string sidPlanning)
        {
            try
            {
                DNodeComercial oDNodeComercial = new DNodeComercial();
                return oDNodeComercial.Get_NodeComercialBy_idPlanning(sidPlanning);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
