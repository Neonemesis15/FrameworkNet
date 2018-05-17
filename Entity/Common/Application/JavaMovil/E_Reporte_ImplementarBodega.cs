using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Entidad E_Reporte_Bodega para ColgateBodega
    /// Sirbe para guardar los datos de los nuevos PDV que registren los Generadores.(Implementacion del PDv)
    /// pSalas 27/03/2012
    /// </summary>
    public class E_Reporte_ImplementarBodega
    {
        private string codCliente;
        [JsonProperty("a")]
        public string CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
        private string codVendedor;
        [JsonIgnore()]
        public string CodVendedor
        {
            get { return codVendedor; }
            set { codVendedor = value; }
        }
        private string codOficina;
        [JsonIgnore()]
        public string CodOficina
        {
            get { return codOficina; }
            set { codOficina = value; }
        }
        private string nombre;
        [JsonProperty("b")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string razonSocial;
        [JsonProperty("c")]
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        private string direccion;
        [JsonProperty("d")]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string distrito;
        [JsonProperty("e")]
        public string Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }
        private string referencia;
        [JsonProperty("f")]
        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        private string ventanaCP;
        [JsonIgnore()]
        public string VentanaCP
        {
            get { return ventanaCP; }
            set { ventanaCP = value; }
        }
        private string miniMueble;
        [JsonIgnore()]
        public string MiniMueble
        {
            get { return miniMueble; }
            set { miniMueble = value; }
        }
        private string cluster;
        [JsonIgnore()]
        public string Cluster
        {
            get { return cluster; }
            set { cluster = value; }
        }
        private string otroDistribuidor;
        [JsonIgnore()]
        public string OtroDistribuidor
        {
            get { return otroDistribuidor; }
            set { otroDistribuidor = value; }
        }
        private string origen;
        [JsonProperty("g")]
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        private string latitud;
        [JsonProperty("h")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        private string longitud;
        [JsonProperty("i")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        private string status;
        [JsonIgnore()]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string person_id;
        [JsonProperty("j")]
        public string Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }
        private string fec_Reg;
        [JsonProperty("k")]
        public string Fec_Reg
        {
            get { return fec_Reg; }
            set { fec_Reg = value; }
        }
        private string ruc;                 //Campo Adicional Solicitado ColgateBodega pSalas 27/03/2012
        [JsonProperty("l")]
        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        private string nombreDistribuidora; //Campo Adicional Solicitado ColgateBodega pSalas 27/03/2012
        [JsonProperty("m")]
        public string NombreDistribuidora
        {
            get { return nombreDistribuidora; }
            set { nombreDistribuidora = value; }
        }
        private string id_Estado_PDV;       //Campo Adicional Solicitado ColgateBodega(0 - Implementación, 1 - Mantenimiento) pSalas 27/03/2012
        [JsonIgnore()]
        public string Id_Estado_PDV
        {
            get { return id_Estado_PDV; }
            set { id_Estado_PDV = value; }
        }

    }
}