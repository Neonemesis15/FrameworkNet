using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class E_Reporte_Competencia_Mov
    {
        public E_Reporte_Competencia_Mov() {
            Detalle = new List<E_Reporte_Competencia_Mov_Detalle>();
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
        public string Cod_Categoria { get; set; }
        [JsonProperty("f")]
        public string Cod_Marca { get; set; }
        [JsonProperty("g")]
        public string Cod_Tipo_Prom { get; set; }
        [JsonProperty("h")]
        public string Cod_Tipo_Act { get; set; }
        [JsonProperty("i")]
        public string Cod_Grupo_Obj { get; set; }
        [JsonProperty("j")]
        public string Precio_Costo { get; set; }
        [JsonProperty("k")]
        public string Precio_PDV { get; set; }
        [JsonProperty("l")]
        public string Precio_Regular { get; set; }
        [JsonProperty("m")]
        public string Precio_Oferta { get; set; }
        [JsonProperty("n")]
        public string Fec_Ini_Act { get; set; }
        [JsonProperty("o")]
        public string Fec_Fin_Act { get; set; }
        [JsonProperty("p")]
        public string Txt_Grupo_Obj { get; set; }
        [JsonProperty("q")]
        public string Cant_Personal { get; set; }
        [JsonProperty("r")]
        public string Premio { get; set; }
        [JsonProperty("s")]
        public string Mecanica { get; set; }
        [JsonProperty("t")]
        public string Mat_Apoyo { get; set;}
        [JsonProperty("u")]
        public string Cod_Empresa { get; set; }
        [JsonProperty("v")]
        public string Programa { get; set; }
        [JsonProperty("w")]
        public string Descripcion_Actividad { get; set; }
        [JsonProperty("x")]
        public string Cod_Material { get; set; }
        [JsonProperty("y")]
        public string Descripcion_Material { get; set; }
        [JsonProperty("z")]
        public string Tasa_Interes { get; set; }
        [JsonProperty("aa")]
        public string Cod_Banco { get; set; }
        [JsonProperty("ab")]
        public string Proporcion_Materia { get; set; }
        [JsonProperty("ac")]
        public string Proporcion_Efectiva { get; set; }
        [JsonProperty("ad")]
        public string Tipo_Competencia { get; set; }
        [JsonProperty("ae")]
        public string Observaciones { get; set; }
        [JsonProperty("af")]
        public string Fec_Comunicacion { get; set; }
        [JsonProperty("ag")]
        public string Fecha_Registro { get; set; }
        [JsonProperty("ah")]
        public string Latitud { get; set; }
        [JsonProperty("ai")]
        public string Longitud { get; set; }
        [JsonProperty("aj")]
        public string Origen { get; set; }
        [JsonProperty("ak")]
        public string Nombre_Foto { get; set; }
        [JsonProperty("al")]
        public List<E_Reporte_Competencia_Mov_Detalle> Detalle { get; set; }
        [JsonProperty("am")]//Add 05/09/2012 PSalas 
        public string Precio_Mayorista { get; set; }
        [JsonProperty("an")]//Tipo de Oferta, Add 05/09/2012, PSalas 
        public string MObservacion { get; set; }
    }

    public class E_Reporte_Competencia_Mov_Detalle {
        [JsonProperty("a")]
        public string Cod_Mat_Apoyo { get; set; }
        [JsonProperty("b")]
        public string Nombre_Foto { get; set; }
    }
}
