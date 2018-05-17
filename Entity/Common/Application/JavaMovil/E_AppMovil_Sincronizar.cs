using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_AppMovil_Sincronizar
    {
        [JsonProperty("a")]
        public List<E_PuntoVenta> listaPtoVenta { get; set; }

        [JsonProperty("b")]
        public List<E_AppMovilCategoria> listaCategoria { get; set; }

        [JsonProperty("c")]
        public List<E_AppMovilMarca> listaMarca { get; set; }

        [JsonProperty("d")]
        public List<E_AppMovilProducto> listaProducto { get; set; }

        [JsonProperty("e")]
        public List<E_AppMovilUndMed> listaUnidadMedida { get; set; }

        [JsonProperty("f")]
        public List<E_Cobro_Cab> listaCobroCab { get; set; }

        [JsonProperty("g")]
        public List<E_Cobro_detalle> listaCobroDetalle { get; set; }

    }

    public class E_AppMovilCategoria
    {
        [JsonProperty("a")]
        public int codCategoria { get; set; }

        [JsonProperty("b")]
        public String nombreCat { get; set; }
    }

    public class E_AppMovilMarca
    {
        [JsonProperty("a")]
        public int codMarca { get; set; }

        [JsonProperty("b")]
        public String nombreMarca { get; set; }

        [JsonProperty("c")]
        public int codCat { get; set; }
    }

    public class E_AppMovilUndMed
    {
        [JsonProperty("a")]
        public int codUnd { get; set; }

        [JsonProperty("b")]
        public String nombreUnd { get; set; }

    }

    public class E_AppMovilProducto
    {
        [JsonProperty("a")]
        public int codigo { get; set; }

        [JsonProperty("b")]
        public String nombre { get; set; }

        [JsonProperty("c")]
        public double precio { get; set; }

        [JsonProperty("d")]
        public int stock { get; set; }

        [JsonProperty("e")]
        public int unidadmedida { get; set; }

        [JsonProperty("f")]
        public int codcat { get; set; }

        [JsonProperty("g")]
        public int codmarca { get; set; }

        [JsonProperty("h")]
        public double dscto { get; set; }
    }

    public class E_Pedido_Cab
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

         [JsonProperty("b")]
        public int codigo { get; set; }

             [JsonProperty("c")]
        public string fechaini { get; set; }

     [JsonProperty("d")]
        public string fechafin { get; set; }

             [JsonProperty("e")]
        public double montobase { get; set; }

             [JsonProperty("f")]
        public double igv { get; set; }

             [JsonProperty("g")]
        public double montotoal { get; set; }


             [JsonProperty("i")]
             public int tipo { get; set; }

             [JsonProperty("k")]
             public List<E_Pedido_detalle> detalle { get; set; }
    }

    public class E_Pedido_detalle
    {   
        [JsonIgnore()]
        public int codPedido { get; set; }

        [JsonProperty("a")]
        public string codProducto { get; set; }
        
        [JsonProperty("b")]
        public double precio { get; set; }

        [JsonProperty("c")]
        public double dscto { get; set; }

        [JsonProperty("d")]
        public int cantidad { get; set; }

        [JsonProperty("e")]
        public double monto { get; set; }
    }

    public class E_Cobro_Cab
    {
        [JsonProperty("a")]
        public int codPedido { get; set; }

        [JsonProperty("b")]
        public string codCliente { get; set; }
        
        [JsonProperty("c")]
        public string fechaini { get; set; }

        [JsonProperty("d")]
        public double montobase { get; set; }

        [JsonProperty("e")]
        public double igv { get; set; }

        [JsonProperty("f")]
        public double montotoal { get; set; }
        
        [JsonProperty("g")]
        public int tipo { get; set; }

    }

    public class E_Cobro_detalle
    {
        [JsonProperty("a")]
        public int coddetalle { get; set; }

        [JsonProperty("b")]
        public int codPedido { get; set; }

        [JsonProperty("c")]
        public string codProducto { get; set; }

        [JsonProperty("d")]
        public double precio { get; set; }

        [JsonProperty("e")]
        public double dscto { get; set; }

        [JsonProperty("f")]
        public int cantidad { get; set; }

        [JsonProperty("g")]
        public double monto { get; set; }
    }
}