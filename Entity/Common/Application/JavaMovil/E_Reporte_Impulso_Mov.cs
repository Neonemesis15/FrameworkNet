using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Impulso_Mov
    {
        public E_Reporte_Impulso_Mov()
        {
            Detalle = new List<E_Reporte_Impulso_Mov_Detalle>();
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
        public string Cod_Actividad { get; set; }

        [JsonProperty("h")]
        public string Fecha_Registro { get; set; }

        [JsonProperty("i")]
        public string Latitud { get; set; }

        [JsonProperty("j")]
        public string Longitud { get; set; }

        [JsonProperty("k")]
        public string Origen { get; set; }

        [JsonProperty("l")]
        public List<E_Reporte_Impulso_Mov_Detalle> Detalle { get; set; }
    }

    public class E_Reporte_Impulso_Mov_Detalle
    {
        [JsonIgnore()]
        public int Cod_Reporte { get; set; }

        [JsonProperty("a")]
        public string Sku_Producto { get; set; }
        
        [JsonProperty("b")]
        public string Ingreso { get; set; }

        [JsonProperty("c")]
        public string Vta_x_Kilo { get; set; }

        [JsonProperty("d")]
        public string Vta_x_Unidad { get; set; }

        [JsonProperty("e")]
        public string Precio { get; set; }

        [JsonProperty("f")]
        public string Stock_Final { get; set; }
    }
}
