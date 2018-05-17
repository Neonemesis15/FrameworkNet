using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lucky.Entity.Common.Application.JavaMovil
{
    public class ESincronizar
    {
        [JsonProperty("p")]
        public List<EPuntoVenta> ListaPuntoVenta { get; set; }

        [JsonProperty("r")]
        public List<EReporte> ListaOpcionReporte { get; set; }

        [JsonProperty("c")]
        public List<ECategoria> listaCategoria { get; set; }

        [JsonProperty("m")]
        public List<EMarca> listaMarca { get; set; }

        [JsonProperty("a")]
        public List<EProducto> listaProducto { get; set; }

        [JsonProperty("e")]
        public List<EEstado> listaEstado { get; set; }

        [JsonProperty("o")]
        public List<EMotivo> listaMotivo { get; set; }

        [JsonProperty("t")]
        public List<EParametro> listaParametro { get; set; }

        //Add Joseph Gonzales 07/03/2012
        [JsonProperty("w")]
        public List<E_Tipo_Material_POP> listaTipoMaterialPOP { get; set; }

        //Add Joseph Gonzales 07/03/2012
        [JsonProperty("x")]
        public List<E_Promocion> listaPromocion { get; set; }

        //Add Joseph Gonzales 07/03/2012
        [JsonProperty("y")]
        public List<E_Observacion> listaObservacion { get; set; }

        //Add Joseph Gonzales 07/03/2012
        [JsonProperty("z")]
        public List<E_Empresa> listaEmpresa { get; set; }

        //Add Joseph Gonzales 07/03/2012
        [JsonProperty("v")]
        public List<E_Material_POP> listaMaterialPOP { get; set; }
        
        /// <summary>
        /// Cluster para ColgateBodega
        /// pSalas 27/03/2012
        /// </summary>
        [JsonProperty("u")]
        public List<E_Cluster> listaCluster { get; set; }
        
        /// <summary>
        /// Motivo de No Implementación ColgateBodega
        /// pSalas 27/03/2012
        /// </summary>
        [JsonProperty("n")]
        public List<E_NoVisita> listaNoVisita { get; set; }

    }
}