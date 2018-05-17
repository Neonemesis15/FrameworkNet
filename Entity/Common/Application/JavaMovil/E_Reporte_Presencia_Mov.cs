using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    /// <summary>
    /// Descripcion :Entidad Reporte Presencia para aplicativo Movil Movistar
    /// Fecha       :18/05/2012 PSA
    /// </summary>
    public class E_Reporte_Presencia_Mov
    {
        public E_Reporte_Presencia_Mov()
        {
            Detalle = new List<E_Reporte_Presencia_Mov_Detalle>();
        }

        [JsonProperty("a")]
        public int Cod_Persona { get; set; }
        [JsonProperty("b")]
        public string Cod_Equipo { get; set; }
        [JsonProperty("c")]
        public int Cod_Compania { get; set; }
        [JsonProperty("d")]
        public string Cod_PtoVenta { get; set; }
        [JsonProperty("e")]
        public int Cod_Categoria { get; set; }
        [JsonProperty("f")]
        public int Cod_Marca { get; set; }
        [JsonProperty("g")]
        public string Cod_OpcionPresencia { get; set; }
        [JsonProperty("h")]
        public string FechaRegistro { get; set; }
        [JsonProperty("i")]
        public string Latitud { get; set; }
        [JsonProperty("j")]
        public string Longitud { get; set; }
        [JsonProperty("k")]
        public string Origen { get; set; }
        [JsonProperty("l")]
        public string Comentario { get; set; }
        [JsonProperty("m")]
        public List<E_Reporte_Presencia_Mov_Detalle> Detalle { get; set; }
        //Add 04/05/2012 PSA
        [JsonProperty("n")]
        public string Cod_Familia { get; set; }
        [JsonProperty("o")]
        public string Cod_SubFamilia { get; set; }

        [JsonProperty("p")]
        public string Cod_SubCategoria { get; set; }

        [JsonProperty("q")]
        public string Cod_SubMarca { get; set; }

        [JsonProperty("r")]
        public string Cod_Presentacion { get; set; }

        [JsonProperty("s")]
        public string Fase { get; set; }

        [JsonProperty("t")]//Parametro para Registrar si el PDV es Nuevo o Antiguo 13/06/2012 PSA
        public string Nuevo { get; set; }

    }

    /// <summary>
    /// Descripcion : Entidad Reporte Presencia Detalle para aplicativo Movil Movistar
    /// Fecha       : 18/05/2012 PSA
    /// </summary>
    public class E_Reporte_Presencia_Mov_Detalle
    {

        [JsonProperty("a")]
        public string Cod_MatApoyo { get; set; }
        [JsonProperty("b")]
        public string Valor_MatApoyo { get; set; }
        [JsonProperty("c")]
        public string SKU_Producto { get; set; }
        [JsonProperty("d")]
        public string Precio { get; set; }
        [JsonProperty("e")]
        public string Stock { get; set; }
        [JsonProperty("f")]
        public string Cod_Observacion { get; set; }
        [JsonProperty("g")]
        public string Observacion { get; set; }
        [JsonProperty("h")]
        public string Cantidad { get; set; }
        [JsonProperty("i")]
        public string Num_Frentes { get; set; }
        [JsonProperty("j")]
        public string Profundidad { get; set; }
        [JsonProperty("k")]
        public string Pedido_Sugerido { get; set; }
        [JsonProperty("l")]
        public string Presencia { get; set; }
        [JsonProperty("m")]
        public string Cumple_Layout { get; set; }
        [JsonProperty("n")]
        public string Cod_Ubicacion { get; set; }
        [JsonProperty("o")]
        public string Cod_Posicion { get; set; }
        [JsonProperty("p")]
        public string Cod_Cluster { get; set; }
        [JsonProperty("q")]
        public string Valor_Cluster { get; set; }

    }

    public class E_Reporte_Presencia_Datos_Response
    {
        [JsonProperty("a")]
        public string CodPtoVenta { get; set; }

        [JsonProperty("b")]
        public string FasePtoVenta { get; set; }

        [JsonIgnore()]
        public string comentario { get; set; }

        [JsonIgnore()]
        public string MensajeUsuario { get; set; }
    }

}
