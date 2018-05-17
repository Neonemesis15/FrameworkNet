using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Autor       :   Joseph Gonzales
    /// Fecha       :   04 - 06 - 2012
    /// Descripción :   Entidad para el registro de códigos ITT
    /// </summary>
    public class E_Reporte_Codigo_ITT_Mov
    {
        public E_Reporte_Codigo_ITT_Mov() {
            ListaDistribuidora = new List<E_Codigo_ITT_Distribuidora>();
            //ListaNuevaDistribuidora = new List<E_Codigo_ITT_Nueva_Distribuidora>();
        }

        [JsonProperty("a")]
        public string CodPtoVenta { get; set; }

        [JsonProperty("b")]
        public List<E_Codigo_ITT_Distribuidora> ListaDistribuidora { get; set; }

        //[JsonProperty("c")]
        //public List<E_Codigo_ITT_Nueva_Distribuidora> ListaNuevaDistribuidora  { get; set; }
    }

    public class E_Codigo_ITT_Distribuidora
    {
        [JsonProperty("a")]
        public string CodDistribuidora { get; set; }

        [JsonProperty("b")]
        public string CodITT { get; set; }
    }

    //public class E_Codigo_ITT_Nueva_Distribuidora
    //{
    //    [JsonProperty("a")]
    //    public string NombreDistribuidora { get; set; }
    //    [JsonIgnore()]
    //    public string CreadoPor { get; set; }
    //}

    //public class E_Reporte_Codigo_ITT_Mov_Response {
    //    public E_Reporte_Codigo_ITT_Mov_Response() {
    //        ListaDistribuidoras = new List<E_Distribuidora>();
    //    }
        
    //    [JsonProperty("a")]
    //    public List<E_Distribuidora> ListaDistribuidoras { get; set; }
    //}


    //public class E_Reporte_Codigo_ITT_Mov
    //{
    //    public E_Reporte_Codigo_ITT_Mov()
    //    {
    //        Detalle = new List<E_Reporte_Codigo_ITT_Mov_Detalle>();
    //    }

    //    [JsonProperty("a")]
    //    public int personId { get; set; }

    //    [JsonProperty("b")]
    //    public string perfilId { get; set; }

    //    [JsonProperty("c")]
    //    public string equipoId { get; set; }

    //    [JsonProperty("d")]
    //    public int clienteId { get; set; }

    //    [JsonProperty("e")]
    //    public string clientPDV_Code { get; set; }

    //    [JsonProperty("f")]
    //    public DateTime fechaReg { get; set; }

    //    [JsonProperty("g")]
    //    public string latitud { get; set; }

    //    [JsonProperty("h")]
    //    public string longitud { get; set; }

    //    [JsonProperty("i")]
    //    public string origen { get; set; }

    //    [JsonProperty("j")]
    //    public List<E_Reporte_Codigo_ITT_Mov_Detalle> Detalle { get; set; }

    //    //[JsonProperty("j")]
    //    //public List<E_Reporte_Codigo_ITT_Detalle> detalle { get; set; }
    //}

    //public class E_Reporte_Codigo_ITT_Mov_Detalle
    //{

    //    [JsonIgnore()]
    //    public int idRegistro { get; set; }

    //    [JsonProperty("a")]
    //    public string Cod_Producto { get; set; }

    //    [JsonProperty("b")]
    //    public string Distribuidora { get; set; }

    //    [JsonProperty("c")]
    //    public string Descripcion { get; set; }
    //}
}
