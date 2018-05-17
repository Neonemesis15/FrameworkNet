using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Servicio
{
    public class E_OrdenCompra
    {
        public E_OrdenCompra()
        {
            oList_Detalle=new List<E_OrdenCompraDetalle>();
        }

        [JsonProperty("a")]
        public string Nro_OC { get; set; }
        [JsonProperty("b")]
        public string Cod_Proveedor { get; set; }
        [JsonProperty("c")]
        public double Subtotal { get; set; }
        [JsonProperty("d")]
        public double IGV { get; set; }
        [JsonProperty("e")]
        public double Total { get; set; }
        [JsonProperty("f")]
        public string Condicion { get; set; }
        [JsonProperty("g")]
        public string Fecha_Registro { get; set; }
        [JsonProperty("h")]
        public string User_Registro { get; set; }
        [JsonProperty("i")]
        public string Estado { get; set; }
        [JsonProperty("j")]
        public string Razon_Social { get; set; }
        [JsonProperty("k")]
        public string Ruc { get; set; }
        [JsonProperty("l")]
        public string Autorizado_Por { get; set; }
        [JsonProperty("m")]
        public string Tranportar { get; set; }
        [JsonProperty("n")]
        public string Atendido { get; set; }
        [JsonProperty("o")]
        public string Fecha_Envio { get; set; }
        //private List<E_OrdenCompraDetalle> oList_Detalle;
        public List<E_OrdenCompraDetalle> oList_Detalle { get; set; }
    }

    public class E_OrdenCompraDetalle
    {
        
        [JsonProperty("a")]
        public string ProductID { get; set; }
        [JsonProperty("b")]
        public int UnitsInStock { get; set; }
        [JsonProperty("c")]
        public string ProductName { get; set; }
        [JsonProperty("d")]
        public double UnitPrice { get; set; }
        [JsonProperty("e")]
        public double PriceTotal { get; set; }
        [JsonProperty("f")]
        public string Nro_OC { get; set; }
    }
}
