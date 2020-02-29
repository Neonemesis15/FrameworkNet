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
    /// Clase de Canales
    /// Create By: Ing Mauricio Ortiz
    /// Fecha de Creación: 27/05/2009
    /// requerimiento:
    /// </summary>

    public class Canales
    {
        // Variable para guardar los mensajes de Error
        String messages = "";

        DCanales odseCanales = new DCanales();
        public Canales()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        /// <summary>
        /// Metodo para retornar los mensajes de Error
        /// </summary>
        /// <returns></returns>
        public String getMessages() {
            return messages;
        }

        //----Metodo que permite registrar Canales
        public ECanales RegistrarCanales(string scodChannel, int iCompany_id, string sChannelName, string sChanneldescription, int iChannelType, bool bChannelStatus, string sChannelCreateBy, DateTime tChannelDateBy, string sChannelModiBy, DateTime tChannelDateModiBy)
        {
            DCanales odrCanales = new DCanales();
            ECanales oerCanales = odrCanales.RegistrarCanalesPK(scodChannel, iCompany_id, sChannelName, sChanneldescription, iChannelType, bChannelStatus, sChannelCreateBy, tChannelDateBy, sChannelModiBy, tChannelDateModiBy);
            odrCanales = null;
            return oerCanales;
        }
        public ECanales RegistrarCanalesTMP(string scodChannel, string sChannelName, string sChannelType, bool bChannelStatus)
        {
            DCanales odrCanales = new DCanales();
            ECanales oerCanales = odrCanales.RegistrarCanalesTMP(scodChannel, sChannelName, sChannelType, bChannelStatus);
            return oerCanales;
        }
        
        //----Metodo que permite Actualizar Canales Ing. Carlos Alberto Hernandez R
        public ECanales Actualizar_Canales(string scodChannel, int iCompany_id, string sChannelName, string sChanneldescription, int iChannel_type, bool bChannelStatus, string sChannelModiBy, DateTime tChannelDateModiBy)
        {
            DCanales odaCanales = new DCanales();
            ECanales oeaCanales = odaCanales.Actualizar_Canales(scodChannel, iCompany_id, sChannelName, sChanneldescription, iChannel_type, bChannelStatus, sChannelModiBy, tChannelDateModiBy);
            odaCanales = null;
            return oeaCanales;
        }        
        public ECanales Actualizar_Canales_TMP(string scodChannel, string sChannelName, string sChannelType, bool bChannelStatus)
        {
            DCanales odaCanales = new DCanales();
            ECanales oeacanales = odaCanales.Actualizar_Canales_TMP(scodChannel, sChannelName, sChannelType, bChannelStatus);
            odaCanales = null;
            return oeacanales;
        }

        //---Metodo de Consulta de Canales
        public DataTable BuscarCanales(string scodchannel, string sChannelName)
        {
            ECanales oeCanales = new ECanales();
            DataTable dtCanales = odseCanales.ObtenerCanales(scodchannel,sChannelName);
            odseCanales = null;
            return dtCanales;
        }

        /// <summary>
        /// Obtener Canales por IdCountry and IdCompany
        /// </summary>
        /// <param name="idCountry"></param>
        /// <param name="idCompany"></param>
        /// <returns></returns>
        public DataTable getCanalesByIdCountryAndIdCompany(
        String idCountry, String idCompany) {
            
            DataTable dt = new DataTable();

            try{
                dt = odseCanales.getCanalesByIdCountryAndIdCompany(
                    idCountry == null ? "0" : idCountry,
                    idCompany == null ? "0" : idCompany);
                if (!odseCanales.getMessages().Equals("")) {
                    messages = odseCanales.getMessages();
                }
            }catch (Exception ex) {
                messages = "Error al Obtener Canales: " + 
                    ex.Message.ToString();
            }
            return dt;
        }

        /// <summary>
        /// Dummy para Obtener Canales por IdCountry and IdCompany
        /// </summary>
        /// <param name="idCountry"></param>
        /// <param name="idCompany"></param>
        /// <returns></returns>
        public DataTable getCanalesByIdCountryAndIdCompanyDummy(
        String idCountry, String idCompany) {
            // Crear el Objeto DataTable
            DataTable dt = new DataTable();

            // Definir las Columnas
            dt.Columns.Add("cod_channel", typeof(int));
            dt.Columns.Add("channel_name", typeof(string));

            //Llenar información
            dt.Rows.Add(1000,"Mayoristas");
            dt.Rows.Add(1001, "Minoristas");
            dt.Rows.Add(1002, "Autoservicios");

            return dt;
        }
    }
}
